Imports System.Data.SqlClient
Imports System.Text
Imports DirectMarketingAgri

Public Class frmStock

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private dtLines As New DataTable
    Private dtCellChanged As DataTable = New DataTable()
    Private dDateWeekly As Date
    Private sDateWeekly, sSql As String
    Private iCellEdit, iItemCode As Integer
    Private fStock, fQuantity As Double
    Private frmMenu As Form1

    Public Sub New(frmParent As Form1)
        InitializeComponent()
        frmMenu = frmParent
    End Sub

    Private Sub frmOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Open the connection
        myConn = New SqlConnection(frmMenu.sConString)
        myConn.Open()
        Try
            'Calculate the first day of this week
            dDateWeekly = Today.AddDays(-Weekday(Today) + 1)
            sDateWeekly = dDateWeekly.ToString("yyyy-MM-dd")
            lblTitle.Text = "מלאי לשבוע " & sDateWeekly

            'fill the table
            With dtLines
                .Columns.Add("עדכן", System.Type.GetType("System.Boolean"))
                .Columns(0).DefaultValue = False
            End With
            UpdateLines()

            'table of changes
            With dtCellChanged
                .Columns.Add("ItemCode", System.Type.GetType("System.Int32"))
                .Columns.Add("Stock", System.Type.GetType("System.Int32"))
            End With
        Catch ex As Exception
            frmMenu.WriteLog(ex.Message, ex.ToString, Me.Text)
        End Try
        Me.CenterToScreen()
    End Sub

    Private Sub frmOrder_updateLine(sender As Object, e As EventArgs) Handles gOrderLines.CellEndEdit
        Dim iRow As Integer = DirectCast(e, System.Windows.Forms.DataGridViewCellEventArgs).RowIndex
        Dim iCol As Integer = DirectCast(e, System.Windows.Forms.DataGridViewCellEventArgs).ColumnIndex
        Dim sCol As String = (dtLines.Columns(iCol)).Caption
        If sCol <> "עדכן" Then
            'Mark V in modified rows
            iItemCode = dtLines.Rows(iRow)("ItemCode")
            fStock = dtLines.Rows(iRow)("מלאי")
            fQuantity = dtLines.Rows(iRow)("סך הזמנה")
            If Not IsNothing(fStock) Then
                'Add values that update to changes table
                dtCellChanged.Rows.Add(iItemCode, fStock)
                With gOrderLines
                    .Rows(iRow).Cells("עדכן").Value = True
                    dtLines.Columns("עודף/חוסר").ReadOnly = False
                    'Update the last column
                    .Rows(iRow).Cells("עודף/חוסר").Value = fStock - fQuantity
                    If fStock < fQuantity Then
                        .Rows(iRow).Cells("עודף/חוסר").Style.BackColor = Color.Red
                    Else
                        .Rows(iRow).Cells("עודף/חוסר").Style.BackColor = Color.LightGray
                    End If
                    .Columns("עודף/חוסר").ReadOnly = True
                End With
                'Compute sum line
                dtLines.Rows(dtLines.Rows.Count - 1)(iCol) = dtLines.Compute("SUM(" & sCol & ")", String.Empty) - dtLines.Rows(dtLines.Rows.Count - 1)(iCol)
                dtLines.Rows(dtLines.Rows.Count - 1)("עודף/חוסר") = dtLines.Compute("SUM([עודף/חוסר])", String.Empty) - dtLines.Rows(dtLines.Rows.Count - 1)("עודף/חוסר")
            End If
        End If
    End Sub

    Private Sub frmOrders_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        If dtCellChanged.Rows.Count <> 0 Then
            Dim result As DialogResult = MsgBox("האם לשמור את השינויים שנעשו?", MsgBoxStyle.YesNo)
            If result = DialogResult.Yes Then
                pctUpdate_Click(Me, e)
            End If
        End If
            If Not myReader.IsClosed Then myReader.Close()
        myConn.Close()
    End Sub

    Private Sub pctUpdate_Click(sender As Object, e As EventArgs) Handles pctUpdate.Click

        Dim builderSQL As New StringBuilder()

        'Update the Stock- update the line if exist, else add one
        For Each row In dtCellChanged.Rows
            fQuantity = row("Stock")
            iItemCode = row("ItemCode")
            Excute("SELECT OrderDateWeekly, ItemCode, InStock FROM Stock WHERE OrderDateWeekly = '" & sDateWeekly & "' And ItemCode = " & iItemCode, False)
            If myReader.HasRows Then
                builderSQL.AppendLine("UPDATE Stock SET InStock = " & fQuantity & " WHERE OrderDateWeekly = '" & sDateWeekly & "' And ItemCode = " & iItemCode)
            Else
                builderSQL.AppendLine("INSERT Stock VALUES('" & sDateWeekly & "'," & iItemCode & "," & fQuantity & ")")
            End If
            myReader.Close()
        Next

        If builderSQL.Length <> 0 Then
            Try
                Excute(builderSQL.ToString)
            Catch ex As Exception
                frmMenu.MsgBox("שגיאה. המלאי לא עודכן")
                Exit Sub
            End Try
            frmMenu.MsgBox("המלאי עודכן בהצלחה")
            'clear Update V
            For Each row In dtLines.Select("[עדכן]=True")
                row(0) = False
            Next
            dtCellChanged.Rows.Clear()
        End If
        builderSQL.Clear()
        myReader.Close()
    End Sub

    Private Sub pctExit_Click(sender As Object, e As EventArgs) Handles pctExit.Click
        If dtCellChanged.Rows.Count <> 0 Then
            Dim result As DialogResult = MsgBox("האם לשמור את השינויים שנעשו?", MsgBoxStyle.YesNo)
            If result = DialogResult.Yes Then
                pctUpdate_Click(Me, e)
            End If
        End If
        MyBase.Close()
        myConn.Close()
    End Sub

    Private Sub UpdateLines()
        'Update the table with the data of stock if exist
        dtLines.Clear()
        Excute("SELECT 'False' as N'עדכן', I.ItemCode, I.ItemName AS N'מוצר', SUM(ISNULL(Quantity,0)) AS N'סך הזמנה', " &
               "ISNULL(InStock,0) AS N'מלאי', ISNULL(InStock,0)-SUM(ISNULL(QUANTITY,0)) as N'עודף/חוסר',SUM(ISNULL(Quantity,0))*ISNULL(Price,0) as N'סכום' " &
               "FROM Items I LEFT JOIN (SELECT O.OrderCode, ItemCode, Quantity, OrderDateWeekly FROM OrderLines L " &
               "INNER JOIN Orders O ON O.OrderCode=L.OrderCode And O.OrderDateWeekly = '" & sDateWeekly & "') as OL ON I.ItemCode=OL.ItemCode " &
               "LEFT JOIN Stock S ON S.OrderDateWeekly = OL.OrderDateWeekly And S.ItemCode=I.ItemCode " &
               "GROUP BY I.ItemCode, I.ItemName, InStock, Price ORDER BY I.ItemCode", False)
        With dtLines
            .Load(myReader)
            .Columns("מלאי").ReadOnly = False
            .Rows.Add(0, 0, "סך הכל", .Compute("SUM([סך הזמנה])", ""), .Compute("SUM(מלאי)", ""), .Compute("SUM([עודף/חוסר])", ""), .Compute("SUM([סכום])", ""))
        End With
        With gOrderLines
            .DataSource = dtLines
            .Columns("ItemCode").Visible = False
            '.Columns("OrderDateWeekly").Visible = False
            .Rows(gOrderLines.Rows.Count - 1).DefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
            For Each row In gOrderLines.Rows
                If row.Cells(5).value >= 0 Then
                    row.Cells(5).Style.BackColor = Color.LightGray
                Else
                    row.Cells(5).Style.BackColor = Color.Red
                End If
            Next
            .Rows(dtLines.Rows.Count - 1).ReadOnly = True
        End With
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean

        Select Case keyData
            Case Keys.Enter
                pctUpdate_Click(Me, EventArgs.Empty)
            Case Keys.Right
                dDateWeekly = dDateWeekly.AddDays(-7)
                sDateWeekly = dDateWeekly.ToString("yyyy-MM-dd")
                lblTitle.Text = "מלאי לשבוע " & sDateWeekly
                UpdateLines()
            Case Keys.Left
                dDateWeekly = dDateWeekly.AddDays(7)
                sDateWeekly = dDateWeekly.ToString("yyyy-MM-dd")
                lblTitle.Text = "מלאי לשבוע " & sDateWeekly
                UpdateLines()
        End Select
        Return False
    End Function
    'Check if this item is the first or last
    'if not, move the code -+

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