Imports System.Data.SqlClient
Imports System.Linq

Public Class frmDelivery

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private sSql As String
    Private sName As String
    Private sNewItemName As String
    Private fPrice As Double
    Private iStock As Integer
    Private fOldPrice As Double
    Private iMarketerCode As Integer = 0
    Private iDistLineCode As Integer = 1
    Private bIsActive As Boolean
    Private sPrintBy As String
    Private ePrintBy As PrintBy = PrintBy.ALL
    Private dtMarketers As DataTable = New DataTable
    Private dtDistLines As DataTable = New DataTable
    Private frmMenu As Form1

    Enum PrintBy
        ALL = 1
        Marketer = 2
        DistLine = 3
    End Enum

    Public Sub New(frmParent As Form1)
        InitializeComponent()
        frmMenu = frmParent
    End Sub

    Private Sub frmDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Open the connection
        myConn = New SqlConnection(frmMenu.sConString)
        myConn.Open()

        For Each rb As RadioButton In grpPrintBy.Controls.OfType(Of RadioButton)()
            AddHandler rb.CheckedChanged, AddressOf grpPrintBy_Enter
        Next
        For Each rb As RadioButton In grpDates.Controls.OfType(Of RadioButton)()
            AddHandler rb.CheckedChanged, AddressOf grpDates_Enter
        Next

        txtFromDate.Text = Date.Now.AddDays(-Weekday(Date.Now) + 1).ToString("yyyy-MM-dd")
        txtToDate.Text = Date.Now.AddDays(7 - Weekday(Date.Now)).ToString("yyyy-MM-dd")

        'Fill marketers
        Excute("SELECT MarketerCode, MarketerName FROM Marketers WHERE IsActive = 'Y'", False)
        dtMarketers.Load(myReader)
        myReader.Close()
        txtMarketer.DataSource = dtMarketers
        txtMarketer.DisplayMember = "MarketerName"
        txtMarketer.ValueMember = "MarketerCode"

        'Fill distribution lines
        Excute("SELECT LineCode, LineName FROM DistributionLines WHERE IsActive = 'Y'", False)
        dtDistLines.Load(myReader)
        myReader.Close()
        txtDistLine.DataSource = dtDistLines
        txtDistLine.DisplayMember = "LineName"
        txtDistLine.ValueMember = "LineCode"

        'Set default month and marketer
        txtMarketer.SelectedItem = txtMarketer.Items(0)
        txtDistLine.SelectedItem = txtDistLine.Items(0)
        Me.CenterToScreen()
    End Sub

    Private Sub frmDelivery_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        If Not myReader.IsClosed Then myReader.Close()
        myConn.Close()
    End Sub


    Private Sub pctUpdate_Click(sender As Object, e As EventArgs) Handles pctUpdate.Click
        ProgressBar1.Visible = True
        ProgressBar1.Maximum = 50
        ProgressBar1.Value = 40

        Dim iOrderCode = New Integer(1) {1004, 1005}
        Dim dtOrders As New DataTable()
        dtOrders.Columns.Add("OrderCode", System.Type.GetType("System.Int32"))

        sSql = "SELECT Distinct O.OrderCode FROM ORDERS O inner join OrderLines L on O.OrderCode=L.OrderCode " &
            "inner join Marketers M on o.MarketerCode=M.MarketerCode " &
            "WHERE OrderDate BETWEEN '" & txtFromDate.Text & "' and '" & txtToDate.Text & "'"
        sSql += If(ePrintBy = PrintBy.DistLine, " And M.DistLine = " & txtDistLine.SelectedValue,
            If(ePrintBy = PrintBy.Marketer, " And O.MarketerCode = " & txtMarketer.SelectedValue, ""))
        Excute(sSql, False)
        dtOrders.Load(myReader)

        If dtOrders.Rows.Count = 0 Then
            frmMenu.MsgBox("לא קיימות תעודות משלוח לפי סינון זה")
            Exit Sub
        End If

        Try
            Dim delivery = New Form2(dtOrders)
            delivery.Show()
        Catch ex As Exception
            frmMenu.WriteLog(ex.Message, ex.ToString, Me.Text)
        End Try
        ProgressBar1.Visible = False
    End Sub


    Private Sub pctExit_Click(sender As Object, e As EventArgs) Handles pctExit.Click
        MyBase.Close()
        myConn.Close()
    End Sub


    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        'Check if this item is the first or last
        'if not, move the code -+
        Select Case keyData
            Case Keys.Enter
                pctUpdate_Click(Me, EventArgs.Empty)
            Case Keys.Up, Keys.Right
            Case Keys.Down, Keys.Left
            Case Else
                Return False
        End Select

        myReader.Close()
        Return False
    End Function

    Private Sub grpPrintBy_Enter(sender As Object, e As EventArgs) ' Handles grpPrintBy.MouseClick, grpPrintBy.Enter, grpPrintBy.DragEnter
        Dim rButton As RadioButton = DirectCast(sender, RadioButton) 'grpPrintBy.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        If rButton.Text = "משווק" Then
            ePrintBy = PrintBy.Marketer
            txtDistLine.Visible = False
            txtMarketer.Visible = True
        ElseIf rButton.Text = "קו חלוקה" Then
            ePrintBy = PrintBy.DistLine
            txtDistLine.Visible = True
            txtMarketer.Visible = False
        Else
            ePrintBy = PrintBy.ALL
            txtDistLine.Visible = False
            txtMarketer.Visible = False
        End If
    End Sub

    Private Sub txtFromDate_DoubleClick(sender As Object, e As EventArgs) Handles txtFromDate.DoubleClick, txtToDate.DoubleClick
        cldDate.Visible = True
    End Sub

    Private Sub cldDate_DateChanged(sender As Object, e As DateRangeEventArgs) Handles cldDate.DateSelected
        'Dim sFromDate, sToDate As String
        cldDate.Visible = False
        txtFromDate.Text = cldDate.SelectionStart.ToString("yyyy-MM-dd")
        txtToDate.Text = cldDate.SelectionEnd.ToString("yyyy-MM-dd")
    End Sub

    Private Sub txtMarketer_TextChanged(sender As Object, e As EventArgs)
        sName = txtMarketer.SelectedText.Trim
        If sName = "" Then
            Exit Sub
        End If

        Excute("SELECT MarketerCode, MarketerName FROM Marketers WHERE MarketerName = N'" & sName & "'", False)
        While myReader.Read()
            If myReader.GetString(1).Trim() = sName Then
                iMarketerCode = myReader.GetInt32(0)
            End If
        End While
        myReader.Close()
    End Sub

    Private Sub txtDistLine_TextChanged(sender As Object, e As EventArgs)
        sName = txtDistLine.SelectedText.Trim
        If sName = "" Then
            Exit Sub
        End If

        Excute("SELECT LineCode, LineName FROM DistributionLines WHERE LineName = N'" & sName & "'", False)
        While myReader.Read()
            If myReader.GetString(1).Trim() = sName Then
                iDistLineCode = myReader.GetInt32(0)
            End If
        End While
        myReader.Close()
    End Sub

    Private Sub grpDates_Enter(sender As Object, e As EventArgs) 'Handles grpDates.Enter
        Dim rButton As RadioButton = DirectCast(sender, RadioButton)
        If rButton.Text = "שבוע אחרון" Then
            txtFromDate.Text = Date.Now.AddDays(-Weekday(Date.Now) + 1).ToString("yyyy-MM-dd")
            txtToDate.Text = Date.Now.AddDays(7 - Weekday(Date.Now)).ToString("yyyy-MM-dd")
        ElseIf rButton.Text = "חודש אחרון" Then
            txtFromDate.Text = New DateTime(Now.Year, Now.Month, 1).ToString("yyyy-MM-dd") 'Date.Now.AddDays(-Weekday(Date.Now) - 20).ToString("yyyy-MM-dd")
            txtToDate.Text = New DateTime(Now.Year, Now.Month, System.DateTime.DaysInMonth(Now.Year, Now.Month)).ToString("yyyy-MM-dd") 'Date.Now.AddDays(7 - Weekday(Date.Now)).ToString("yyyy-MM-dd")
        End If
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