Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO

Public Class Form1

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private iItemCode As Integer
    Private sItemName As String
    Private sNewItemName As String
    Private fPrice As Double
    Private fNewPrice As Double
    Public sConString As String
    Public sw As StreamWriter
    Public strFile As String = String.Format("ErrorLog_{0}.txt", DateTime.Today.ToString("dd-MM-yyyy"))

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Open the connection
        sConString = ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString
        myConn = New SqlConnection(sConString)
        myConn.Open()
        Me.CenterToScreen()
    End Sub

    Private Sub Form1_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        myConn.Close()
    End Sub

    Function MsgBox(str As String, Optional bottom As MsgBoxStyle = MsgBoxStyle.MsgBoxRight) As MsgBoxResult
        Return Interaction.MsgBox(str, bottom, "מערכת גידולי מים")
    End Function

    Public Sub WriteLog(error1 As String, error2 As String, Optional formName As String = "")
        File.Exists(strFile)
        Dim fileExists As Boolean = File.Exists(strFile)
        sw = New StreamWriter(File.Open(strFile, FileMode.OpenOrCreate))
        sw.WriteLine("Error Message in Occured at-- " & DateTime.Now)
        sw.WriteLine(If(formName <> "", formName & ": ", "") & error1)
        sw.WriteLine(error2)
        sw.Close()
        MsgBox("אירעה שגיאה, אנא הסתכל בקובץ הלוג")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim items = New frmItems(Me)
            items.Show()
        Catch ex As Exception
            WriteLog(ex.Message, ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim marketers = New frmMarketers(Me)
            marketers.Show()
        Catch ex As Exception
            WriteLog(ex.Message, ex.ToString)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim distLines = New frmDistLines(Me)
            distLines.Show()
        Catch ex As Exception
            WriteLog(ex.Message, ex.ToString)
        End Try
    End Sub

    Private Sub oButton4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim orders = New frmOrders(Me)
            orders.Show()
        Catch ex As Exception
            WriteLog(ex.Message, ex.ToString)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim delivery = New frmDelivery(Me)
            delivery.Show()
        Catch ex As Exception
            WriteLog(ex.Message, ex.ToString)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Dim stock = New frmStock(Me)
            stock.Show()
        Catch ex As Exception
            WriteLog(ex.Message, ex.ToString)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Dim payment = New frmPayments(Me)
            payment.Show()
        Catch ex As Exception
            WriteLog(ex.Message, ex.ToString)
        End Try
    End Sub
End Class
