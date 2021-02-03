Imports System.Data.SqlClient
Imports System.Text

Public Class frmAddPay

    Private frmPayments As frmPayments
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results, sSql, sNewItemName, sName As String
    Private fPrice, fOldPrice As Double
    Private imarketer As Integer
    Private iCurrCode As Integer = 1
    Private iMaxCode As Integer = 1
    Private bIsActive As Boolean
    Private dtMarketers As DataTable = New DataTable()

    Enum Action
        Add
        Update
    End Enum

    Public Sub New(frmParent As frmPayments, marketer As Integer, sumToPay As Decimal)
        InitializeComponent()
        frmPayments = frmParent
        imarketer = marketer
        fPrice = sumToPay
    End Sub

    Private Sub frmItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Open the connection
        myConn = New SqlConnection(frmPayments.frmMenu.sConString) '"Initial Catalog=DirectMarketing; Data Source=localhost; Integrated Security=SSPI; MultipleActiveResultSets=true")
        myConn.Open()

        'Fill marketers
        Excute("SELECT MarketerCode, MarketerName FROM Marketers WHERE IsActive = 'Y'", False)
        dtMarketers.Load(myReader)
        myReader.Close()
        txtMarketer.DataSource = dtMarketers
        txtMarketer.DisplayMember = "MarketerName"
        txtMarketer.ValueMember = "MarketerCode"
        Me.CenterToScreen()
        calculateMax()
    End Sub

    Private Sub frmItems_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        If Not myReader.IsClosed Then myReader.Close()
        myConn.Close()
    End Sub

    Private Sub pctAdd_Click(sender As Object, e As EventArgs) Handles pctAdd.Click
        addUpdateItems(Action.Add)
        If Not myReader.IsClosed Then
            myReader.Close()
        End If
    End Sub

    Private Sub pctUpdate_Click(sender As Object, e As EventArgs) Handles pctUpdate.Click
        addUpdateItems(Action.Update)
        If Not myReader.IsClosed Then
            myReader.Close()
        End If
    End Sub

    'Add or Update items
    Private Sub addUpdateItems(act As Action)
        Dim isAdd As Boolean = If(act = Action.Add, True, False)
        Dim sOrdersUpdate, sPaymentUpdate As String
        Dim builderSQL As New StringBuilder()

        If isAdd Then
            fPrice = txtSum.Text
            'Insert the new item
            Try
                'myCmd.CommandText = "INSERT INTO Payments VALUES (" & iMaxCode & ",'" & txtDate.Text & "'," & imarketer &
                '"," & fPrice & "," & txtTransferType.Text.Split(":")(0) & ", N'" & txtDetailes.Text & "')"
                'myCmd.ExecuteReader()
                Excute("INSERT INTO Payments VALUES (" & iMaxCode & ",'" & txtDate.Text & "'," & imarketer &
                "," & fPrice & "," & txtTransferType.Text.Split(":")(0) & ", N'" & txtDetailes.Text & "')", False)
            Catch ex As Exception
                frmPayments.frmMenu.MsgBox("שגיאה. התשלום לא התווסף למערכת, אנא נסה שנית")
                frmPayments.frmMenu.WriteLog(ex.Message, ex.ToString, Me.Text)
                Exit Sub
            End Try
            myReader.Close()
            Excute("SELECT OrderCode,OrderSum-ISNULL(Credit,0)-ISNULL(SumPayed,0) FROM Orders " &
                   "WHERE OrderSum-ISNULL(Credit,0)-ISNULL(SumPayed,0)>0 and MarketerCode = " & imarketer, False)
            If myReader.HasRows() Then
                sOrdersUpdate = "תשלום על הזמנות: "
            Else
                sOrdersUpdate = "תשלום על חשבון. "
            End If
            While myReader.Read() And fPrice > 0
                Dim fSum As Decimal = myReader.GetDecimal(1)
                Dim iOrderCode As Integer = myReader.GetInt32(0)
                sPaymentUpdate = "שולם " & If(fPrice >= fSum, "במלואו", "(" & fPrice & ")") & " בתשלום מספר " & iCurrCode & "."
                fPrice -= fSum
                sOrdersUpdate += iOrderCode.ToString + ","
                If fPrice < 0 Then
                    fSum += fPrice
                End If
                builderSQL.AppendLine("UPDATE Orders SET SumPayed = ISNULL(SumPayed,0) + " & fSum &
                                      ", Details = ISNULL(details,' ') + N'" & sPaymentUpdate & "' WHERE OrderCode = " & iOrderCode & " ")
            End While

            txtDetailes.Text += sOrdersUpdate.Substring(0, sOrdersUpdate.Length - 1)
            builderSQL.AppendLine("UPDATE Payments SET Detailes = N'" & txtDetailes.Text & "' WHERE PaymentCode = " & iMaxCode)

            If builderSQL.Length > 0 Then
                Try
                    Excute(builderSQL.ToString)
                Catch ex As Exception
                    frmPayments.frmMenu.WriteLog(ex.Message, ex.ToString, Me.Text)
                    Exit Sub
                End Try
            End If

            frmPayments.frmMenu.MsgBox("התשלום התווסף בהצלחה")
            frmPayments.Update()
            MyBase.Close()
            myConn.Close()
        Else
            'myCmd.CommandText = "UPDATE Payments SET TransferType = " & txtTransferType.Text.Split(":")(0) &
            '    ",Detailes = N'" & txtDetailes.Text & "' WHERE PaymentCode = " & iCurrCode
            Try
                'myCmd.ExecuteReader()
                Excute("UPDATE Payments SET TransferType = " & txtTransferType.Text.Split(":")(0) &
                ",Detailes = N'" & txtDetailes.Text & "' WHERE PaymentCode = " & iCurrCode, False)
            Catch ex As Exception
                frmPayments.frmMenu.MsgBox("שגיאה. פרטי התשלום לא עודכנו, אנא נסה שנית")
                myReader.Close()
                Exit Sub
            End Try
            If myReader.RecordsAffected <= 0 Then
                frmPayments.frmMenu.MsgBox("התשלום לא קיים במערכת, אנא לחץ על הוסף")
            Else
                frmPayments.frmMenu.MsgBox("פרטי התשלום עודכנו בהצלחה")
                frmPayments.Update()
                MyBase.Close()
                myConn.Close()
            End If
        End If
        myReader.Close()

    End Sub

    Private Sub pctExit_Click(sender As Object, e As EventArgs) Handles pctExit.Click
        frmPayments.Update()
        MyBase.Close()
        myConn.Close()
    End Sub


    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        'Check if this item is the first or last
        'if not, move the code -+
        Select Case keyData
            Case Keys.Enter
                If iCurrCode = iMaxCode Then
                    addUpdateItems(Action.Add)
                Else
                    addUpdateItems(Action.Update)
                End If
            Case Keys.Up, Keys.Right
                If (iCurrCode = 1) Then Return False
                iCurrCode -= 1
            Case Keys.Down, Keys.Left
                If iCurrCode = iMaxCode Then Return False
                iCurrCode += 1
            Case Else
                Return False
        End Select

        'Fill the other fileds
        If iCurrCode = iMaxCode Then
            txtCode.Text = iMaxCode
            txtDate.Text = Today.ToString("yyyy-MM-dd")
            txtMarketer.Text = ""
            txtSum.Text = 0
            txtTransferType.Text = getTransferType(4)
            txtDetailes.Text = ""

            With txtMarketer
                .Enabled = True
                .DropDownStyle = ComboBoxStyle.DropDown
                .BackColor = SystemColors.Window
            End With

            With txtSum
                .Enabled = True
                .BackColor = SystemColors.Window
            End With

            Return False
        End If

        Excute("SELECT PaymentCode,PayDate,Marketer,PaySum,TransferType,Detailes FROM Payments WHERE PaymentCode = " & iCurrCode, False)
        If myReader.Read() Then
            txtCode.Text = iCurrCode
            txtDate.Text = myReader.GetDateTime(1).ToString("yyyy-MM-dd")
            txtMarketer.SelectedValue = myReader.GetInt32(2)
            txtSum.Text = myReader.GetDecimal(3)
            txtTransferType.Text = getTransferType(myReader.GetInt32(4))
            txtDetailes.Text = myReader.GetString(5)

            With txtMarketer
                .Enabled = False
                .DropDownStyle = ComboBoxStyle.Simple
                .BackColor = SystemColors.Control
            End With

            With txtSum
                .Enabled = False
                .BackColor = SystemColors.Control
            End With

        End If
        myReader.Close()
        Return False
    End Function

    Private Sub calculateMax()
        'Calculate the next Code
        Excute("SELECT IsNull(MAX(PaymentCode),0) FROM Payments", False)
        If myReader.Read() Then iMaxCode = myReader.GetInt32(0) + 1
        myReader.Close()

        iCurrCode = iMaxCode
        txtCode.Text = iCurrCode
        txtMarketer.SelectedValue = imarketer
        txtDate.Text = Today.ToString("yyyy-MM-dd")
        txtTransferType.Text = getTransferType(4)
        txtDetailes.Text = ""
        txtSum.Text = FormatNumber(fPrice, 2, TriState.False, , TriState.True)
    End Sub

    Private Function getTransferType(transferType As Integer) As String
        For i = 0 To 4
            If transferType = txtTransferType.Items(i).substring(0, 1) Then
                Return txtTransferType.Items(i)
            End If
        Next
        Return txtTransferType.Items(0)
    End Function

    Private Sub Excute(sSql As String, Optional bToRead As Boolean = True)
        myCmd = myConn.CreateCommand
        myCmd.CommandText = sSql
        Try
            myReader = myCmd.ExecuteReader
            If bToRead Then myReader.Read()
        Catch ex As Exception
            frmPayments.frmMenu.WriteLog(ex.Message, ex.ToString, Me.Text)
        End Try
    End Sub
End Class