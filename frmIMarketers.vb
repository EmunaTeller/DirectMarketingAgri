Imports System.Data.SqlClient
Imports DirectMarketingAgri

Public Class frmMarketers

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results, sName, sSQL As String
    Private fPrice, fOldPrice As Double
    Private iStock As Integer
    Private iCurrCode As Integer = 1
    Private iMaxCode As Integer = 1
    Private iLineCode As Integer = 0
    Private dtDistLines As New DataTable
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

        Excute("SELECT LineCode, LineName FROM DistributionLines", False)
        dtDistLines.Load(myReader)
        txtDistLines.DataSource = dtDistLines
        txtDistLines.DisplayMember = "LineName"
        txtDistLines.ValueMember = "LineCode"

        Me.CenterToScreen()
        calculateMax()
    End Sub

    Private Sub frmMarketers_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
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

    Private Sub addUpdateItems(act As Action)
        Dim isAdd As Boolean = If(act = Action.Add, True, False)
        Dim msgText As String = ""
        sName = txtName.Text.Trim
        bIsActive = ckActive.Checked

        'Check a validation of the input
        If sName = "" Then
            frmMenu.MsgBox("אנא הקלד את שם המשווק אותו ברצונך " + If(isAdd, "להוסיף", "לעדכן"))
            Exit Sub
        End If

        'Validation, Check if the marketer is exist
        Excute("SELECT MarketerCode, MarketerName, ISNULL(Place,''), ISNULL([Address],''), DistLine FROM Marketers WHERE MarketerName like N'" & sName & "%'", False)
        If Not myReader.HasRows AndAlso Not isAdd Then
            frmMenu.MsgBox("המשווק '" & sName & "' לא קיים במערכת")
            Exit Sub
        End If
        While myReader.Read()
            If myReader.GetString(1).Trim = txtName.Text Then
                If isAdd Then
                    frmMenu.MsgBox("משווק בעל שם דומה קיים במערכת:" & vbLf & "'" & myReader.GetString(1).Trim & "'")
                    myReader.Close()
                    Exit Sub
                End If
                Exit While
            Else
                If Not isAdd Then
                    frmMenu.MsgBox("המשווק '" & sName & "' לא קיים במערכת")
                    Exit Sub
                End If
            End If
        End While
        myReader.Close()

        If isAdd Then
            Try
                'Insert the new marketer
                Excute("INSERT INTO Marketers VALUES (" & iMaxCode & ",N'" & sName & "', N'" & txtPlace.Text.Trim & "',N'" & txtAddress.Text.Trim & "'," & txtDistLines.SelectedValue & ",'Y','" & txtPhone.Text.Trim & "','" & txtMail.Text.Trim & "')", False)
            Catch ex As Exception
                frmMenu.MsgBox("שגיאה. המשווק לא התווסף למערכת, אנא נסה שנית")
                myReader.Close()
                Exit Sub
            End Try
            frmMenu.MsgBox("המשווק '" & sName & "' התווסף בהצלחה למערכת")
        Else
            Try
                'Update detailes of the marketer
                Excute("UPDATE Marketers SET place=N'" & txtPlace.Text & "',address=N'" & txtAddress.Text & "',DistLine=" & txtDistLines.SelectedValue & ",IsActive='" & If(bIsActive, "Y", "N") & "',Phone='" & txtPhone.Text & "',Mail='" & txtMail.Text & "'WHERE MarketerCode = " & iCurrCode, False)
            Catch ex As Exception
                frmMenu.MsgBox("שגיאה. " & sName & "' לא השתנה, אנא נסה שנית")
                myReader.Close()
                Exit Sub
            End Try
            frmMenu.MsgBox("פרטי המשווק '" & sName & "' עודכנו בהצלחה")
            myReader.Close()
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

        'Check if the marketer exist, if yes- fill its details
        fillFields(sName)
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
        fillFields(iCurrCode)
        Return False
    End Function

    Private Sub calculateMax()
        'Calculate the next ItemCode
        Excute("SELECT MAX(MarketerCode) FROM Marketers", False)
        If myReader.Read() Then iMaxCode = myReader.GetInt32(0) + 1
        myReader.Close()
        iCurrCode = iMaxCode
        txtCode.Text = iCurrCode
        txtName.Text = ""
        txtPlace.Text = ""
        txtAddress.Text = ""
        txtDistLines.Text = ""
    End Sub

    Private Function fillFields(nameOrCode As String) As Boolean
        'If the code/name exist fill the other fields, else fill the fileds with empty values
        sSQL = "SELECT MarketerCode, MarketerName, ISNULL(Place,''), ISNULL([Address],''), DistLine, IsActive, ISNULL([Phone],''), ISNULL([Mail],'') FROM Marketers"
        If IsNumeric(nameOrCode) Then
            If nameOrCode = iMaxCode Then
                txtCode.Text = iMaxCode
                txtName.Text = ""
                txtPlace.Text = ""
                txtAddress.Text = ""
                txtDistLines.Text = ""
                txtPhone.Text = ""
                txtMail.Text = ""
                myReader.Close()
                Return True
            End If
            iCurrCode = nameOrCode
            sSQL = sSQL & " WHERE MarketerCode = " & iCurrCode
        Else
            sName = nameOrCode
            sSQL = sSQL & " WHERE MarketerName like N'%" & sName & "%'"
        End If
        Excute(sSQL, False)
        If Not myReader.HasRows() Then iCurrCode = iMaxCode
        While myReader.Read()
            If myReader.GetString(1).Trim() = sName Or myReader.GetInt32(0) = iCurrCode Then
                iCurrCode = myReader.GetInt32(0)
                txtName.Text = myReader.GetString(1).Trim()
                txtPlace.Text = myReader.GetString(2).Trim()
                txtAddress.Text = myReader.GetString(3).Trim()
                txtDistLines.SelectedValue = myReader.GetInt32(4)
                ckActive.Checked = If(myReader.GetString(5) = "Y", True, False)
                txtPhone.Text = myReader.GetString(6)
                txtMail.Text = myReader.GetString(7)
            Else
                iCurrCode = iMaxCode
            End If
        End While
        txtCode.Text = iCurrCode
        myReader.Close()
        Return False
    End Function

    Private Function getLineName(code As Integer) As String
        Excute("SELECT LineName FROM DistributionLines WHERE LineCode = " & code, False)
        If myReader.Read() Then Return myReader.GetString(0)
        Return ""
    End Function

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