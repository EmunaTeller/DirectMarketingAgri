Imports System.Collections
Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.Text
Imports DirectMarketingAgri

Public Class frmPayments

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private dtLines As New DataTable
    Private dtYearlyPayments As DataTable = New DataTable()
    Private dtMarketers As DataTable = New DataTable()
    Private sItemName, sDateWeekly, sSql As String
    Private dDate, dOrderDateWeekly As Date
    Private iMaxCode As Integer = 1000
    Private bIsActive, bIsExists As Boolean
    Private dtItems As DataTable = New DataTable()
    Private iCellEdit, iItemCode, iYear As Integer
    Private fStock, fQuantity As Double
    Dim masterdata As New DataSet()
    Dim vViewBy As ViewBy = ViewBy.All
    Public frmMenu As Form1

    Enum ViewBy
        All = 1
        PerMonth = 2
        PerMarketer = 3
    End Enum
    Public Sub New(frmParent As Form1)
        InitializeComponent()
        frmMenu = frmParent
    End Sub

    Private Sub frmOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Open the connection
        myConn = New SqlConnection(frmMenu.sConString) '"Initial Catalog=DirectMarketing; Data Source=localhost; Integrated Security=SSPI; MultipleActiveResultSets=true")
        myConn.Open()

        'Set year to title
        iYear = Year(Today())
        lblTitle.Text = "תשלומים לשנת " & iYear

        'Fill marketers
        Excute("SELECT MarketerCode, MarketerName FROM Marketers", False)
        dtMarketers.Load(myReader)
        myReader.Close()
        txtMarketer.DataSource = dtMarketers
        txtMarketer.DisplayMember = "MarketerName"
        txtMarketer.ValueMember = "MarketerCode"

        'Set default month and marketer
        txtMarketer.SelectedItem = txtMarketer.Items(0)
        txtMonth.SelectedItem = txtMonth.Items(Month(Today) - 1)

        'fill the table
        UpdateLines(vViewBy)
        Me.CenterToScreen()
    End Sub

    Private Sub frmOrder_updateLine(sender As Object, e As EventArgs) Handles gOrderLines.CellEndEdit
        Dim iRow As Integer = DirectCast(e, System.Windows.Forms.DataGridViewCellEventArgs).RowIndex
        Dim iCol As Integer = DirectCast(e, System.Windows.Forms.DataGridViewCellEventArgs).ColumnIndex
        Dim sCol As String = (dtLines.Columns(iCol)).Caption
        If sCol <> "עדכן" Then
        End If
    End Sub

    Private Sub frmOrders_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        If Not myReader.IsClosed Then myReader.Close()
        myConn.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        vViewBy = ViewBy.PerMarketer
        txtMarketer.Visible = True
        txtMonth.Visible = False
        gOrderLines.Columns("חודש").Visible = True
        UpdateLines(ViewBy.PerMarketer)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        vViewBy = ViewBy.PerMonth
        txtMonth.Visible = True
        txtMarketer.Visible = False
        gOrderLines.Columns("חודש").Visible = True
        UpdateLines(ViewBy.PerMonth)
    End Sub

    Private Sub gOrderLines_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gOrderLines.CellContentClick
        Dim iMarketerCode As Integer = gOrderLines.Rows(e.RowIndex).Cells("קוד משווק").Value
        Dim fSumToPay As Decimal = gOrderLines.Rows(e.RowIndex).Cells("יתרה לתשלום").Value
        If TypeOf gOrderLines.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
   e.RowIndex >= 0 AndAlso iMarketerCode <> 0 AndAlso gOrderLines.Rows(e.RowIndex).Cells(2).Value <> "סך הכל" Then
            'Open windows of new payment
            Dim addPay = New frmAddPay(Me, iMarketerCode, fSumToPay)
            addPay.Show(Me)
        End If
    End Sub

    Private Sub gOrderLines_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gOrderLines.CellContentDoubleClick
        If e.RowIndex >= 0 AndAlso gOrderLines.Rows(e.RowIndex).Cells(2).Value <> "סך הכל" Then
            Dim iMarketerCode As Integer = gOrderLines.Rows(e.RowIndex).Cells("קוד משווק").Value
            Dim fSumToPay As Decimal = gOrderLines.Rows(e.RowIndex).Cells("יתרה לתשלום").Value
            If TypeOf gOrderLines.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
                'Open windows of new payment
                Dim addPay = New frmAddPay(Me, iMarketerCode, fSumToPay)
                addPay.Show()
            Else
                'Update line by marketer
                txtMarketer.SelectedValue = iMarketerCode
                RadioButton1.Checked = True
                UpdateLines(ViewBy.PerMarketer)
            End If
        End If
    End Sub

    Private Sub txtMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtMonth.SelectedIndexChanged
        UpdateLines(ViewBy.PerMonth)
    End Sub

    Private Sub txtMarketer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtMarketer.SelectedIndexChanged
        UpdateLines(ViewBy.PerMarketer)
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        vViewBy = ViewBy.All
        txtMonth.Visible = False
        txtMarketer.Visible = False
        If gOrderLines.Columns.Contains("חודש") Then
            gOrderLines.Columns("חודש").Visible = False
            UpdateLines(ViewBy.All)
        End If
    End Sub

    Private Sub pctUpdate_Click(sender As Object, e As EventArgs) Handles pctUpdate.Click

        If Not myReader.IsClosed Then
            myReader.Close()
        End If
    End Sub

    Private Sub pctExit_Click(sender As Object, e As EventArgs) Handles pctExit.Click
        MyBase.Close()
        myConn.Close()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        'Check if this item is the first or last
        'if not, move the code -+
        Select Case keyData
            Case Keys.Up, Keys.Right
            Case Keys.Down, Keys.Left
        End Select
        Return False
    End Function


    Private Sub UpdateLines(view As ViewBy)
        Dim iMarketer, iMonth As Integer
        If view = ViewBy.All Then
            sSql = "SELECT O.MarketerCode as N'קוד משווק', M.MarketerName as 'משווק', NULL as N'חודש', SUM(OrderSum - Credit) as N'סך הזמנות', " &
                "SUM(ISNULL(SumPayed,0)) as N'שולם', SUM(OrderSum - Credit - ISNULL(SumPayed,0)) as N'יתרה לתשלום' " &
                "FROM Orders O INNER JOIN Marketers M ON O.MarketerCode=M.MarketerCode " &
                "WHERE YEAR(OrderDate) = YEAR(GETDATE()) GROUP BY O.MarketerCode, M.MarketerName " &
                "HAVING NOT (SUM(OrderSum - Credit) = 0 AND SUM(ISNULL(SumPayed,0)) = 0)"
        Else
            iMarketer = txtMarketer.SelectedValue
            iMonth = txtMonth.Text.Split(":")(0)
            sSql = "SELECT O.MarketerCode as N'קוד משווק', M.MarketerName as N'משווק', MONTH(OrderDate) as N'חודש', SUM(OrderSum - Credit) as N'סך הזמנות', " &
                "SUM(ISNULL(SumPayed,0)) as N'שולם', SUM(OrderSum - Credit - ISNULL(SumPayed,0)) as N'יתרה לתשלום' " &
                "FROM Orders O INNER JOIN Marketers M ON O.MarketerCode=M.MarketerCode " &
                "WHERE YEAR(OrderDate) = YEAR(GETDATE()) And MONTH(OrderDate) <= MONTH(GETDATE()) And OrderSum - Credit > 0 And " &
                If(view = ViewBy.PerMonth, "MONTH(OrderDate) = " & iMonth, "M.MarketerCode = " & iMarketer) &
                " GROUP BY O.MarketerCode, M.MarketerName, MONTH(OrderDate)"
        End If
        Excute(sSql, False)
        dtLines.Clear()
        dtLines.Load(myReader)
        myReader.Close()
        If dtLines.Rows.Count > 0 Then
            dtLines.Rows.Add(0, "סך הכל", 0, dtLines.Compute("SUM([סך הזמנות])", ""), dtLines.Compute("SUM(שולם)", ""), dtLines.Compute("SUM([יתרה לתשלום])", ""))

            With gOrderLines
                .DataSource = dtLines
                .Columns("קוד משווק").Visible = False
                If vViewBy = ViewBy.All Then
                    .Columns("חודש").Visible = False
                Else
                    .Columns("חודש").Visible = True
                End If
                .Rows(gOrderLines.Rows.Count - 1).DefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
            End With
        End If
    End Sub

    Public Sub Update()
        UpdateLines(ViewBy.All)
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