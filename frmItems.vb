Imports System.Data.SqlClient
Imports DirectMarketingAgri

Public Class frmItems
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private sName As String
    Private sNewItemName As String
    Private fPrice As Double
    Private iStock As Integer
    Private fOldPrice As Double
    Private iCurrCode As Integer = 1
    Private iMaxCode As Integer = 1
    Private bIsActive As Boolean
    Private frmMenu As Form1

    Enum Action
        Add
        Update
    End Enum

    Public Sub New(frmParent As Form1)
        InitializeComponent()
        frmMenu = frmParent
    End Sub

    Private Sub frmItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Open the connection
        myConn = New SqlConnection(frmMenu.sConString)
        myConn.Open()
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
        Dim msgText As String = ""
        sName = txtName.Text.Trim
        bIsActive = ckActive.Checked

        'Check a validation of the input
        If sName = "" Then
            frmMenu.MsgBox("אנא הקלד את שם המוצר אותו ברצונך " + If(isAdd, "להוסיף", "לעדכן"))
            Exit Sub
        ElseIf sName.Contains(" ") Then
            frmMenu.MsgBox("בהוספת מוצר יש לוודא שאין רווח בשם המוצר")
            Exit Sub
        ElseIf Not IsNumeric(txtPrice.Text) OrElse txtPrice.Text < 0 Then
            frmMenu.MsgBox("אנא הקלד מחיר תקין")
            Exit Sub
        ElseIf Not IsNumeric(txtUnitWeight.Text) OrElse txtUnitWeight.Text < 0 Then
            frmMenu.MsgBox("אנא הקלד משקל יחידה תקין")
            Exit Sub
        ElseIf Not IsNumeric(txtQuantityPerCarton.Text) OrElse txtQuantityPerCarton.Text < 0 Then
            frmMenu.MsgBox("אנא הקלד כמות לקרטון תקינה")
            Exit Sub
        End If
        fPrice = txtPrice.Text

        'Check if the item is exist
        Excute("Select ItemCode, ItemName From Items WHERE ItemName like N'" & sName & "%'", False)
        If Not myReader.HasRows AndAlso Not isAdd Then
            frmMenu.MsgBox("המוצר '" & sName & "' לא קיים במערכת")
            Exit Sub
        End If
        While myReader.Read()
            If myReader.GetString(1).Trim = txtName.Text Then
                If isAdd Then
                    frmMenu.MsgBox("מוצר בעל שם דומה קיים במערכת:" & vbLf & "'" & myReader.GetString(1).Trim & "'")
                    myReader.Close()
                    Exit Sub
                End If
                Exit While
            Else
                If Not isAdd Then
                    frmMenu.MsgBox("המוצר '" & sName & "' לא קיים במערכת")
                    myReader.Close()
                    Exit Sub
                End If
            End If
        End While
        myReader.Close()

        If isAdd Then
            Try
                'Insert the new item
                Excute("INSERT INTO Items VALUES (" & iMaxCode & ",N'" & sName & "'," & fPrice & ", '" &
                    If(bIsActive, "Y", "N") & "'," & txtUnitWeight.Text & "," & txtQuantityPerCarton.Text & ")")
            Catch ex As Exception
                frmMenu.WriteLog(ex.Message, ex.StackTrace, Me.Text)
                myReader.Close()
                Exit Sub
            End Try
            frmMenu.MsgBox("המוצר '" & sName & "' התווסף בהצלחה למערכת במחיר " & fPrice & "₪")
        Else
            Try
                Excute("UPDATE Items SET Price = " & fPrice & ", isActive = '" & If(bIsActive, "Y", "N") & "', UnitWeight = " &
                    txtUnitWeight.Text & ",QuantityPerCarton = " & txtQuantityPerCarton.Text & " WHERE ItemCode = " & iCurrCode)
            Catch ex As Exception
                frmMenu.WriteLog(ex.Message, ex.StackTrace, Me.Text)
                myReader.Close()
                Exit Sub
            End Try
            frmMenu.MsgBox("המוצר '" & sName & "' שונה בהצלחה")
        End If
        myReader.Close()

        If isAdd Then calculateMax()
    End Sub

    Private Sub pctExit_Click(sender As Object, e As EventArgs) Handles pctExit.Click
        MyBase.Close()
        myConn.Close()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        sName = txtName.Text.Trim

        If sName = "" OrElse Not myReader.IsClosed Then
            Exit Sub
        End If

        Try
            'Check if the item exist, if yes- fill its price and code
            Excute("Select ItemCode, ItemName, Price, ISNULL((SELECT TOP 1 instock FROM Stock WHERE ItemCode = I.ItemCode ORDER BY OrderDateWeekly DESC),0)," &
                "IsActive, ISNULL(UnitWeight,0.0), ISNULL(QuantityPerCarton,0) From Items I WHERE ItemName Like N'%" & sName & "%'", False)
            If Not myReader.HasRows() Then iCurrCode = iMaxCode
            While myReader.Read()
                If myReader.GetString(1).Trim() = sName Then
                    iCurrCode = myReader.GetInt32(0)
                    txtCode.Text = iCurrCode
                    fPrice = myReader.GetDecimal(2)
                    txtPrice.Text = fPrice
                    txtStock.Text = myReader.GetInt32(3)
                    ckActive.Checked = If(myReader.GetString(4) = "Y", True, False)
                    txtUnitWeight.Text = myReader.GetDecimal(5)
                    txtQuantityPerCarton.Text = myReader.GetInt32(6)
                Else
                    iCurrCode = iMaxCode
                End If
            End While
            If Not IsNumeric(txtPrice.Text) OrElse txtPrice.Text = 0 Then
                txtCode.Text = iCurrCode
            End If
            myReader.Close()
        Catch ex As Exception
            frmMenu.WriteLog(ex.Message, ex.ToString, Me.Text)
        End Try
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        'Check if this item is the first or last. if not, move the code -+
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
            txtName.Text = ""
            txtPrice.Text = ""
            txtUnitWeight.Text = ""
            txtQuantityPerCarton.Text = ""
            txtStock.Text = 0
            Return False
        End If

        Excute("Select ItemCode, ItemName, Price, ISNULL((SELECT TOP 1 instock FROM Stock WHERE ItemCode = I.ItemCode ORDER BY OrderDateWeekly DESC),0) AS Stock," &
            " IsActive, ISNULL(UnitWeight,0.0), ISNULL(QuantityPerCarton,0) From Items I WHERE ItemCode = " & iCurrCode, False)
        If myReader.Read() Then
            sName = myReader.GetString(1).Trim()
            txtCode.Text = iCurrCode
            txtPrice.Text = myReader.GetDecimal(2)
            txtStock.Text = myReader.GetInt32(3)
            txtName.Text = sName
            ckActive.Checked = If(myReader.GetString(4) = "Y", True, False)
            txtUnitWeight.Text = myReader.GetDecimal(5)
            txtQuantityPerCarton.Text = myReader.GetInt32(6)
        End If
        myReader.Close()
        Return False
    End Function

    Private Sub calculateMax()
        'Calculate the next ItemCode
        Excute("Select MAX(ItemCode) From Items", False)
        If myReader.Read() Then
            iMaxCode = myReader.GetInt32(0) + 1
        End If
        myReader.Close()
        iCurrCode = iMaxCode
        txtCode.Text = iCurrCode
        txtName.Text = ""
        txtPrice.Text = ""
        txtUnitWeight.Text = ""
        txtQuantityPerCarton.Text = ""
        txtStock.Text = 0
    End Sub

    Private Sub Excute(sSql As String, Optional bToRead As Boolean = True)
        myCmd = myConn.CreateCommand
        myCmd.CommandText = sSql
        Try
            myReader = myCmd.ExecuteReader
            If bToRead Then myReader.Read()
        Catch ex As Exception
            frmMenu.WriteLog(ex.Message, ex.ToString, Me.Text)
        End Try
    End Sub
End Class