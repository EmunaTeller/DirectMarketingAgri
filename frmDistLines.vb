Imports System.Data.SqlClient

Public Class frmDistLines

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


    Private Sub addUpdateItems(act As Action)
        Dim isAdd As Boolean = If(act = Action.Add, True, False)
        Dim msgText As String = ""
        sName = txtName.Text.Trim
        bIsActive = ckActive.Checked

        'Check a validation of the input
        If sName = "" Then
            frmMenu.MsgBox("אנא הקלד את שם הקו אותו ברצונך " + If(isAdd, "להוסיף", "לעדכן"))
            Exit Sub
        End If

        'Check if the line is exist
        Excute("SELECT * FROM DistributionLines WHERE LineName like N'" & sName & "%'", False)
        If Not myReader.HasRows AndAlso Not isAdd Then
            frmMenu.MsgBox("הקו '" & sName & "' לא קיים במערכת")
            Exit Sub
        End If
        While myReader.Read()
            If myReader.GetString(1).Trim = txtName.Text Then
                If isAdd Then
                    frmMenu.MsgBox("קו בעל שם דומה קיים במערכת: " & vbLf & "'" & myReader.GetString(1).Trim & "'")
                    myReader.Close()
                    Exit Sub
                End If
                Exit While
            Else
                If Not isAdd Then
                    frmMenu.MsgBox("קו '" & sName & "' לא קיים במערכת")
                    Exit Sub
                End If
            End If
        End While

        If isAdd Then
            Try
                'Insert the new line
                Excute("INSERT INTO DistributionLines VALUES (" & iMaxCode & ",N'" & sName & "',N'" & txtDriver.Text.Trim() & "'," & txtDayOfWeek.Text.Substring(0, 1) & ",'Y'," & txtCarNum.Text & ")", False)
            Catch ex As Exception
                frmMenu.MsgBox("שגיאה. הקו לא התווסף למערכת, אנא נסה שנית")
                myReader.Close()
                Exit Sub
            End Try
            frmMenu.MsgBox("הקו '" & sName & "' התווסף בהצלחה למערכת")
            ckActive.Checked = True
        Else
            Try
                'Update the details of line
                Excute("UPDATE DistributionLines SET Driver = N'" & txtDriver.Text.Trim() & "', DayOfWeek1 = " & txtDayOfWeek.Text.Substring(0, 1) & ", IsActive = '" & If(bIsActive, "Y", "N") & "', CarNum = " & txtCarNum.Text & " WHERE LineCode = " & iCurrCode, False)
            Catch ex As Exception
                frmMenu.MsgBox("שגיאה. '" & sName & "' לא השתנה, אנא נסה שנית")
                myReader.Close()
                Exit Sub
            End Try
            frmMenu.MsgBox("פרטי הקו '" & sName & "' שונו בהצלחה")
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
            'Check if the line exist, if yes- fill its details
            Excute("SELECT LineCode,LineName,ISNULL(Driver,''),DayOfWeek1,IsActive,ISNULL(CarNum,'') " &
                "FROM DistributionLines WHERE LineName like N'%" & sName & "%'", False)
            If Not myReader.HasRows() Then iCurrCode = iMaxCode
            While myReader.Read()
                If myReader.GetString(1).Trim() = sName Then
                    iCurrCode = myReader.GetInt32(0)
                    txtDriver.Text = myReader.GetString(2)
                    txtDayOfWeek.Text = getDay(myReader.GetInt32(3))
                    ckActive.Checked = If(myReader.GetString(4) = "Y", True, False)
                    txtCarNum.Text = myReader.GetInt32(5)
                Else
                    iCurrCode = iMaxCode
                End If
            End While
            txtCode.Text = iCurrCode
            myReader.Close()
        Catch ex As Exception
            frmMenu.WriteLog(ex.Message, ex.ToString, Me.Text)
        End Try
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
            txtName.Text = ""
            txtDriver.Text = ""
            txtDayOfWeek.Text = ""
            ckActive.Checked = False
            txtCarNum.Text = 0
            Return False
        End If

        Excute("SELECT LineCode,LineName,ISNULL(Driver,''),DayOfWeek1,IsActive,ISNULL(CarNum,'') FROM DistributionLines WHERE LineCode = " & iCurrCode, False)
        If myReader.Read() Then
            txtCode.Text = iCurrCode
            sName = myReader.GetString(1).Trim()
            txtName.Text = sName
            txtDriver.Text = myReader.GetString(2).Trim()
            txtDayOfWeek.Text = getDay(myReader.GetInt32(3))
            ckActive.Checked = If(myReader.GetString(4) = "Y", True, False)
            txtCarNum.Text = myReader.GetInt32(5)
        End If
        myReader.Close()
        Return False
    End Function

    Private Sub calculateMax()
        'Calculate the next ItemCode
        Excute("SELECT MAX(LineCode) FROM DistributionLines", False)
        If myReader.Read() Then iMaxCode = myReader.GetInt32(0) + 1
        myReader.Close()
        iCurrCode = iMaxCode
        txtCode.Text = iCurrCode
        txtName.Text = ""
        txtDriver.Text = ""
    End Sub

    Private Function getDay(day As Integer) As String
        For i = 0 To 6
            If day = txtDayOfWeek.Items(i).substring(0, 1) Then
                Return txtDayOfWeek.Items(i)
            End If
        Next
        Return txtDayOfWeek.Items(0)
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