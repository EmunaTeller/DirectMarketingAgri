Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration
Imports System.IO

Public Class frmOrders

    Private frmMenu As Form1
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private dtLines As New DataTable
    Private dtCellChanged As DataTable = New DataTable()
    Private dtThisOrder As DataTable = New DataTable()
    Private sItemName, sDateWeekly, sSql As String
    Private dDate, dOrderDateWeekly As Date
    Private iMaxCode As Integer
    Private bIsActive, bIsExists, bDateChanged, bLineChanged, bIsCredit, bIsChanges As Boolean
    Private dtItems As DataTable = New DataTable()
    Private dtDistLines As DataTable = New DataTable()
    Private iCellEdit As Integer

    Enum Action
        Add
        Update
    End Enum

    Public Sub New(frmParent As Form1)
        InitializeComponent()
        frmMenu = frmParent
        iMaxCode = ConfigurationManager.AppSettings("FirstDelivery").ToString()
    End Sub


    Private Sub frmOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Open the connection
        myConn = New SqlConnection(frmMenu.sConString)
        myConn.Open()

        'Calculate the first day of this week
        dOrderDateWeekly = Today.AddDays(-Weekday(Today) + 1)
        sDateWeekly = Format(dOrderDateWeekly, "yyyy-MM-dd")
        lblTitle.Text = "הזמנות לשבוע " & sDateWeekly

        'Check if the order week is exist
        Excute("SELECT COUNT(*) FROM ORDERS WHERE OrderDateWeekly = '" & sDateWeekly & "'")
        If myReader.GetInt32(0) > 0 Then
            bIsExists = True
        End If
        myReader.Close()

        'fill the table- headers and lines
        With dtLines
            Dim clmUpdate As New DataColumn()
            clmUpdate.ColumnName = "עדכן"
            clmUpdate.DataType = System.Type.GetType("System.Boolean")
            .Columns.Add(clmUpdate)

            Dim clmMarketer As New DataColumn()
            clmMarketer.ColumnName = "משווק"
            clmMarketer.DataType = System.Type.GetType("System.String")
            .Columns.Add(clmMarketer)

            'Update the headers with the item's names
            Excute("Select ItemCode, ItemName, Price, isActive From Items", False)
            dtItems.Load(myReader)
            myReader.Close()
            For Each item In dtItems.Rows
                Dim col As New DataColumn()
                sItemName = item("ItemName").Trim
                .Columns.Add(sItemName, System.Type.GetType("System.Int32")).DefaultValue = 0
            Next

            .Columns.Add("מספר הזמנה", System.Type.GetType("System.String"))
            .Columns.Add("תאריך", System.Type.GetType("System.String"))
            .Columns.Add("זיכוי", System.Type.GetType("System.Decimal"))
            .Columns.Add("קוד משווק", System.Type.GetType("System.Int32"))
            .Columns.Add("סכום", System.Type.GetType("System.Decimal"))

            'Add a sum line
            .Rows.Add()
            .Rows(0)(clmMarketer) = "סך הכל"

            If bIsExists Then
                UpdateLines(sDateWeekly)
            Else
                AddNewOrder(sDateWeekly)
            End If

            .Columns("משווק").ReadOnly = True
            .Columns("מספר הזמנה").ReadOnly = True
            .Columns("תאריך").ReadOnly = True
        End With

        'Create changes table
        With dtCellChanged
            .Columns.Add("OrderCode", System.Type.GetType("System.Int32"))
            .Columns.Add("ItemName", System.Type.GetType("System.String"))
            .Columns.Add("ORow", System.Type.GetType("System.Int32"))
            .Columns.Add("OCol", System.Type.GetType("System.Int32"))
            .Columns.Add("Credit", System.Type.GetType("System.Decimal"))
            .Columns.Add("Date", System.Type.GetType("System.DateTime"))
        End With

        'Properties
        Me.CenterToScreen()
        Me.WindowState = FormWindowState.Maximized
        With gOrderLines
            .DataSource = dtLines
            .Columns(0).DefaultCellStyle.BackColor = Color.GreenYellow
            .Columns(1).Frozen = True
            .Columns(1).Width = 100
            .Columns(1).DefaultCellStyle.Font = New Font("Tahoma", 11, FontStyle.Bold)
            .Columns("קוד משווק").Visible = False
            .Columns("סכום").Visible = False
            .Rows(0).Frozen = True
            .Rows(0).ReadOnly = True
            .Rows(0).DefaultCellStyle.Font = New Font("Tahoma", 11, FontStyle.Bold)
        End With

        'hide the not in active items
        For Each row In dtItems.Select("IsActive = 'N'")
            gOrderLines.Columns(row("ItemName").Trim).visible = If(dtLines.Rows(0)(row("ItemName").Trim) = 0, False, True)
        Next
    End Sub

    Private Sub frmOrder_updateLine1(sender As Object, e As EventArgs) Handles gOrderLines.CellBeginEdit
        Dim iRow As Integer = DirectCast(e, System.Windows.Forms.DataGridViewCellCancelEventArgs).RowIndex
        Dim iCol As Integer = DirectCast(e, System.Windows.Forms.DataGridViewCellCancelEventArgs).ColumnIndex
        Dim sCol As String = (dtLines.Columns(iCol)).Caption
        If sCol <> "עדכן" Then
            iCellEdit = dtLines.Rows(iRow)(iCol)
        End If
    End Sub

    Private Sub frmOrder_updateLine(sender As Object, e As EventArgs) Handles gOrderLines.CellEndEdit
        Dim iRow As Integer = DirectCast(e, System.Windows.Forms.DataGridViewCellEventArgs).RowIndex
        Dim iCol As Integer = DirectCast(e, System.Windows.Forms.DataGridViewCellEventArgs).ColumnIndex
        Dim sCol As String = (dtLines.Columns(iCol)).Caption
        If sCol <> "עדכן" Then
            If sCol = "זיכוי" Then
                dtCellChanged.Rows.Add(dtLines.Rows(iRow)("מספר הזמנה"), sCol, 0, 0, dtLines.Rows(iRow)(iCol))
            Else
                'Compute sum line
                dtLines.Rows(0)(iCol) = dtLines.Compute("SUM(" & sCol & ")", String.Empty) - dtLines.Rows(0)(iCol)

                Dim fPrice As Double = dtItems.Select("ItemName ='" & sCol.Trim & "'")(0)("Price")
                dtLines.Rows(iRow)("סכום") += fPrice * (dtLines.Rows(iRow)(iCol) - iCellEdit)
                dtCellChanged.Rows.Add(dtLines.Rows(iRow)("מספר הזמנה"), sCol, iRow, iCol)
            End If

            'Mark V in modified rows
            dtLines.Rows(iRow)("עדכן") = True
        End If
    End Sub

    Private Sub frmOrders_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        If dtCellChanged.Rows.Count <> 0 Then
            SaveChanges()
        End If
        If Not myReader.IsClosed Then myReader.Close()
        myConn.Close()
    End Sub

    Private Sub pctAdd_Click(sender As Object, e As EventArgs) Handles pctAdd.Click
        AddOrUpdateOrders(Action.Add)
        If Not myReader.IsClosed Then myReader.Close()
    End Sub

    Private Sub pctUpdate_Click(sender As Object, e As EventArgs) Handles pctUpdate.Click
        AddOrUpdateOrders(Action.Update)
        If Not myReader.IsClosed Then myReader.Close()
    End Sub

    Private Sub pctExit_Click(sender As Object, e As EventArgs) Handles pctExit.Click
        'If dtCellChanged.Rows.Count <> 0 Then
        '    SaveChanges()
        'End If
        MyBase.Close()
        If Not myReader.IsClosed Then myReader.Close()
        myConn.Close()
    End Sub

    Private Sub Invalidfill(sender As Object, e As EventArgs) Handles gOrderLines.DataError
        Dim iRow As Integer = DirectCast(e, System.Windows.Forms.DataGridViewCellCancelEventArgs).RowIndex
        Dim iCol As Integer = DirectCast(e, System.Windows.Forms.DataGridViewCellCancelEventArgs).ColumnIndex
        Dim sCol As String = (dtLines.Columns(iCol)).Caption
        frmMenu.MsgBox("אנא מלא כמות תקינה למוצר '" & sCol & "' בהזמנת המשווק '" & dtLines.Rows(iRow)("משווק") & "'")
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        'Check if this item is the first or last
        'if not, move the code -+
        Select Case keyData
            Case Keys.Enter
                If bIsExists Then
                    AddOrUpdateOrders(Action.Update)
                Else
                    AddOrUpdateOrders(Action.Add)
                End If
            Case Keys.Up, Keys.Right
            Case Keys.Down, Keys.Left
        End Select
        Return False
    End Function

    Private Function AddOrUpdateOrders(act As Action) As Boolean
        'Dim bIsExists As Boolean
        Dim builderSQL As New StringBuilder()
        Dim i As Integer = 1
        Dim iQuantity As Integer = 0
        Dim iItemCode As Integer
        Dim fPrice, fSumOrder As Double
        bIsActive = ckActive.Checked

        If bIsExists Then
            If act = Action.Add Then
                frmMenu.MsgBox("הזמנה לשבוע זה קיימת במערכת")
                Return False
            Else
                'Update the order's rows
                For Each row In dtCellChanged.Rows
                    If row("OCol") = 0 Then
                        If row("ORow") <> 0 Then
                            bLineChanged = True
                        ElseIf row("Credit") <> 0 Then
                            bIsCredit = True
                        Else
                            bDateChanged = True
                        End If
                        bDateChanged = If(IsDBNull(row("Date")), False, True)
                        fSumOrder = dtLines.Select("[מספר הזמנה] = " & row("OrderCode"))(0)("סכום")
                    Else
                        iQuantity = dtLines(row("ORow"))(row("OCol"))
                        iItemCode = dtItems.Select("ItemName ='" & row("ItemName").Trim & "'")(0)("ItemCode")
                        fPrice = dtItems.Select("ItemName ='" & row("ItemName").Trim & "'")(0)("Price")
                        If dtThisOrder.Select("OrderCode = " & row("OrderCode") & " and ItemName = '" & row("ItemName").Trim & "'").Count = 0 Then
                            builderSQL.AppendLine("INSERT INTO OrderLines Values(" & row("OrderCode") &
                                                              "," & iItemCode & "," & iQuantity & ",0," &
                                                              iQuantity * fPrice & ")")
                        Else
                            builderSQL.AppendLine("UPDATE OrderLines SET Quantity = " & iQuantity & ", LineSum = " &
                                                  iQuantity * fPrice & " WHERE ItemCode = " & iItemCode &
                                                  " AND OrderCode = " & row("OrderCode"))
                        End If
                        fSumOrder = If(IsDBNull(dtLines(row("ORow"))("סכום")), 0, dtLines(row("ORow"))("סכום"))
                    End If

                    builderSQL.AppendLine("UPDATE Orders SET OrderSum = " & fSumOrder & If(bDateChanged, ",OrderDate = '" & Format(row("Date"), ("yyyy-MM-dd")) & "'", "") &
                                          If(bIsCredit, ",Credit = '" & row("Credit") & "'", "") & " WHERE OrderCode = " & row("OrderCode"))
                Next

                If builderSQL.Length <> 0 Then
                    Try
                        Excute(builderSQL.ToString)
                    Catch ex As Exception
                        Exit Function
                    End Try
                    frmMenu.MsgBox("ההזמנה עודכנה בהצלחה")
                    ClearVUpdate()
                End If
                builderSQL.Clear()
            End If
        Else
            If act = Action.Add Then
                'Insert the new orders
                Excute("SELECT MarketerCode, D.DayOfWeek1, M.DistLine FROM Marketers M INNER JOIN DistributionLines D " &
                       "ON M.DistLine=D.LineCode WHERE M.IsActive = 'Y'", False)
                Dim iOrderCode As Integer = iMaxCode
                While myReader.Read()
                    builderSQL.AppendLine("INSERT INTO ORDERS Values(" & iOrderCode & ",'" &
                                          Format(dOrderDateWeekly.AddDays(-Weekday(dOrderDateWeekly) + myReader.GetInt32(1)), "yyyy-MM-dd") &
                                          "', " & myReader.GetInt32(0) & ", 0, '" & Format(dOrderDateWeekly, "yyyy-MM-dd") & "',0,0,'')")
                    iOrderCode += 1
                End While
                myReader.Close()

                Try
                    Excute(builderSQL.ToString)
                    builderSQL.Clear()
                Catch ex As Exception
                    frmMenu.MsgBox("שגיאה. ההזמנה לא נוספה למערכת")
                    Return False
                End Try
                myReader.Close()
                Dim bChanged As Boolean = False
                'Update the order's rows
                Dim drSelected() As DataRow = dtLines.Select()
                For Each row In drSelected
                    If row("משווק") <> "סך הכל" Then
                        bChanged = False
                        For Each item In dtItems.Rows()
                            iQuantity = row(item("ItemName").Trim)
                            If iQuantity <> 0 Then
                                builderSQL.AppendLine("INSERT INTO OrderLines Values(" & row("מספר הזמנה") & "," & item("ItemCode") & "," &
                                                      iQuantity & ",0," & iQuantity * item("Price") & ")")
                                bChanged = True
                            End If
                        Next
                        If bChanged Then
                            builderSQL.AppendLine("UPDATE Orders SET OrderSum = " & row("סכום") &
                                                  ",Credit = " & row("זיכוי") & ",OrderDate = '" & row("תאריך") & "' WHERE OrderCode = " & row("מספר הזמנה"))
                        End If
                    End If
                Next

                myCmd.CommandText = builderSQL.ToString
                myReader = myCmd.ExecuteReader()
                builderSQL.Clear()
                frmMenu.MsgBox("ההזמנה התווספה בהצלחה")
                ClearVUpdate()
                ckActive.Checked = True
                bIsActive = True
                bIsExists = True
            Else
                frmMenu.MsgBox("הזמנה לשבוע זה אינה קיימת במערכת")
            End If
        End If

        dtCellChanged.Rows.Clear()
        myReader.Close()
        Return True
    End Function

    Private Sub pctPrev_Click(sender As Object, e As EventArgs) Handles pctPrev.Click
        If dtCellChanged.Rows.Count() > 0 Then SaveChanges()

        dOrderDateWeekly = dOrderDateWeekly.AddDays(-7)
        sDateWeekly = Format(dOrderDateWeekly, "yyyy-MM-dd")
        Try
            UpdateLines(sDateWeekly)
            'If dtThisOrder.Rows.Count = 0 Then
            '    UpdateLines(sDateWeekly)
            'End If
        Catch ex As Exception
            frmMenu.WriteLog(ex.Message, ex.ToString, Me.Text)
        End Try

        'Update the title
        sDateWeekly = Format(dOrderDateWeekly, "yyyy-MM-dd")
        lblTitle.Text = "הזמנות לשבוע " & sDateWeekly
        If dOrderDateWeekly.AddDays(28) < Today Then
            ckActive.Checked = False
            gOrderLines.ReadOnly = True
        End If
        With gOrderLines
            .Rows(0).Frozen = True
            .Rows(0).ReadOnly = True
            .Rows(0).DefaultCellStyle.Font = New Font("Tahoma", 11, FontStyle.Bold)
        End With

        'hide the not in active items
        For Each row In dtItems.Select("IsActive = 'N'")
            gOrderLines.Columns(row("ItemName").Trim).visible = If(dtLines.Rows(0)(row("ItemName").Trim) = 0, False, True)
        Next
    End Sub

    Private Sub pctNext_Click(sender As Object, e As EventArgs) Handles pctNext.Click
        If Not bIsExists Then
            Dim result As MsgBoxResult = frmMenu.MsgBox("לא קיימת הזמנה לשבוע זה, האם לדלג? ", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.No Then Exit Sub
        End If

        If dtCellChanged.Rows.Count() > 0 Then SaveChanges()

        dOrderDateWeekly = dOrderDateWeekly.AddDays(7)
        sDateWeekly = Format(dOrderDateWeekly, "yyyy-MM-dd")

        Try
            'Check if the order week is exist
            Excute("SELECT top 1 OrderDateWeekly FROM Orders WHERE OrderDateWeekly >= '" & sDateWeekly & "' ORDER BY OrderCode")
            If myReader.HasRows() Then
                bIsExists = True
                dOrderDateWeekly = myReader.GetDateTime(0)
                sDateWeekly = Format(dOrderDateWeekly, "yyyy-MM-dd")
            Else
                bIsExists = False
            End If
            myReader.Close()

            If bIsExists Then
                UpdateLines(sDateWeekly)
            Else
                AddNewOrder(sDateWeekly)
            End If

        Catch ex As Exception
            frmMenu.WriteLog(ex.Message, ex.ToString, Me.Text)
        End Try

        'Update the title
        sDateWeekly = Format(dOrderDateWeekly, "yyyy-MM-dd")
        lblTitle.Text = "הזמנות לשבוע " & sDateWeekly

        If dOrderDateWeekly.AddDays(28) < Today Then
            ckActive.Checked = False
            gOrderLines.ReadOnly = True
        Else
            If bIsExists Then ckActive.Checked = True
            bIsActive = True
            gOrderLines.ReadOnly = False
        End If

        With gOrderLines
            .Rows(0).Frozen = True
            .Rows(0).ReadOnly = True
            .Rows(0).DefaultCellStyle.Font = New Font("Tahoma", 11, FontStyle.Bold)
        End With

        'hide the not in active items
        For Each row In dtItems.Select("IsActive = 'N'")
            gOrderLines.Columns(row("ItemName").Trim).visible = If(dtLines.Rows(0)(row("ItemName").Trim) = 0, False, True)
        Next
    End Sub

    Private Sub gOrderLines_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gOrderLines.CellContentClick
        Dim iRow As Integer = DirectCast(e, System.Windows.Forms.DataGridViewCellEventArgs).RowIndex
        Dim iCol As Integer = DirectCast(e, System.Windows.Forms.DataGridViewCellEventArgs).ColumnIndex
        Dim sCol As String = (dtLines.Columns(iCol)).Caption
        If sCol = "תאריך" Then
            Dim sOldDate As String = dtLines.Rows(iRow)(sCol)
            cldDate.Visible = True
            wait(6)
            Dim dOrderDate As Date = cldDate.SelectionStart
            Dim sOrderDate As String = dOrderDate.ToString("yyyy-MM-dd")
            If sOldDate = sOrderDate Then
                frmMenu.MsgBox("התאריך לא שונה")
            Else
                Dim result As DialogResult = frmMenu.MsgBox("האם לשנות את התאריך לכל קו החלוקה?", MsgBoxStyle.YesNoCancel)
                dtLines.Columns("תאריך").ReadOnly = False
                If result = DialogResult.Yes Then
                    For Each row In dtLines.Select("[תאריך] = '" & sOldDate & "'")
                        dtCellChanged.Rows.Add(row("מספר הזמנה"), sCol, 0, 0, 0, dOrderDate)
                        row("תאריך") = sOrderDate
                    Next
                ElseIf result = DialogResult.No Then
                    dtCellChanged.Rows.Add(dtLines.Rows(iRow)("מספר הזמנה"), sCol, 0, 0, 0, dOrderDate)
                    dtLines.Rows(iRow)("תאריך") = sOrderDate
                End If
                dtLines.Columns("תאריך").ReadOnly = True
            End If

            'Mark V in modified rows
            dtLines.Rows(iRow)("עדכן") = True
        End If
    End Sub

    Private Sub cldDate_DateChanged(sender As Object, e As DateRangeEventArgs) Handles cldDate.DateSelected
        'Dim sFromDate, sToDate As String
        cldDate.Visible = False
    End Sub

    Private Sub AddNewOrder(OrderDateWeekly As Date)

        'Calculate max order code
        Excute("Select ISNULL(MAX(OrderCode),999) From Orders", False)
        If myReader.Read() Then
            iMaxCode = myReader.GetInt32(0) + 1
        End If
        myReader.Close()

        'Update the rows with order's details
        Excute("SELECT MarketerCode, MarketerName, DayOfWeek1 FROM Marketers M inner join " &
               "DistributionLines D on M.DistLine=D.LineCode WHERE D.isActive = 'Y' and M.IsActive = 'Y'", False)

        With dtLines
            'Allow write to lock columns
            .Columns("משווק").ReadOnly = False
            .Columns("מספר הזמנה").ReadOnly = False
            .Columns("תאריך").ReadOnly = False
            .Rows.Clear()

            'Add a sum line
            .Rows.Add()
            .Rows(0)("משווק") = "סך הכל"

            'fill the table
            Dim i As Integer = 1
            While myReader.Read()
                .Rows.Add()
                .Rows(i)("עדכן") = True
                .Rows(i)("מספר הזמנה") = iMaxCode + i - 1
                .Rows(i)("תאריך") = Format(OrderDateWeekly.AddDays(-Weekday(OrderDateWeekly) + myReader.GetInt32(2)), "yyyy-MM-dd")
                .Rows(i)("משווק") = myReader.GetString(1).Trim
                .Rows(i)("קוד משווק") = myReader.GetInt32(0)
                .Rows(i)("סכום") = 0
                .Rows(i)("זיכוי") = 0
                i += 1
            End While
        End With
        ckActive.Checked = False
    End Sub

    Private Sub UpdateLines(OrderDateWeekly As String, Optional bUpdateThisOrder As Boolean = False)
        sSql = "SELECT O.OrderCode,OrderDate,O.MarketerCode,MarketerName,OL.ItemCode,ItemName,Quantity,OrderSum,ISNULL(Credit,0) " &
               "FROM Orders O LEFT JOIN OrderLines OL ON O.OrderCode=OL.OrderCode " &
               "LEFT JOIN Marketers M ON O.MarketerCode=M.MarketerCode " &
               "LEFT JOIN Items I ON OL.ItemCode=I.ItemCode WHERE OrderDateWeekly = '" & OrderDateWeekly & "'"
        Excute(sSql, False)
        If Not myReader.HasRows() Then
            myReader.Close()
            Excute("SELECT TOP 1 OrderDateWeekly FROM Orders WHERE OrderDateWeekly < '" & OrderDateWeekly & "' ORDER BY OrderDateWeekly DESC", False)
            If Not myReader.HasRows() Then
                frmMenu.MsgBox("לא קיימת הזמנה ישנה יותר")
                dOrderDateWeekly = dOrderDateWeekly.AddDays(7)
                myReader.Close()
                Exit Sub
            Else
                myReader.Read()
                dOrderDateWeekly = myReader.GetDateTime(0)
                sSql = sSql.Replace(OrderDateWeekly, Format(dOrderDateWeekly, "yyyy-MM-dd"))
                Excute(sSql, False)
            End If
        End If
        dtThisOrder.Clear()
        dtThisOrder.Load(myReader)
        If bUpdateThisOrder Then Exit Sub
        Dim LinesTemp = From row In dtThisOrder
                        Group row By OrderCode = row(0), OrderDate = row(1), MarketerCode = row(2), MarketerName = row(3),
                            OrderSum = row(7), Credit = row(8) Into Group

        With dtLines
            .Columns("משווק").ReadOnly = False
            .Columns("מספר הזמנה").ReadOnly = False
            .Columns("תאריך").ReadOnly = False
            .Rows.Clear()

            'Add a sum line
            .Rows.Add()
            .Rows(0)("משווק") = "סך הכל"

            Dim i As Integer = 1
            For Each row In LinesTemp
                .Rows.Add()
                .Rows(i)("עדכן") = False
                .Rows(i)("מספר הזמנה") = row.OrderCode
                .Rows(i)("תאריך") = Format(row.OrderDate, "yyyy-MM-dd")
                .Rows(i)("קוד משווק") = row.MarketerCode
                .Rows(i)("משווק") = row.MarketerName.Trim
                .Rows(i)("סכום") = row.OrderSum
                .Rows(i)("זיכוי") = row.Credit

                For Each line In dtThisOrder.Select("OrderCode = " & row.OrderCode)
                    If Not line.IsNull("Quantity") Then
                        .Rows(i)(line("ItemName").Trim) = line("Quantity")
                    End If
                Next
                i += 1

                For Each item In dtItems.Rows
                    Dim sItemName As String = item("ItemName").Trim
                    .Rows(0)(sItemName) = dtLines.Compute("SUM(" & sItemName & ")", String.Empty) - dtLines.Rows(0)(sItemName)
                Next
            Next

            .Columns("משווק").ReadOnly = True
            .Columns("מספר הזמנה").ReadOnly = True
            .Columns("תאריך").ReadOnly = True
        End With

        bIsExists = True
        ckActive.Checked = True
        myReader.Close()
    End Sub

    Private Sub ClearVUpdate()
        For Each row In dtLines.Select("[עדכן]=True")
            row(0) = False
        Next
        dtCellChanged.Rows.Clear()
        UpdateLines(sDateWeekly, True)
        bIsCredit = False
        bLineChanged = False
        bDateChanged = False
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

    Private Sub SaveChanges()
        Dim result As DialogResult = MsgBox("האם לשמור את השינויים שנעשו?", MsgBoxStyle.YesNo)
        If result = DialogResult.Yes Then
            If bIsExists Then
                AddOrUpdateOrders(Action.Update)
            Else
                AddOrUpdateOrders(Action.Add)
            End If
        End If
    End Sub

    Private Sub wait(ByVal seconds As Integer) ''add awakeeeeeeeeeeeeee
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(7)
            Application.DoEvents()
        Next
    End Sub
End Class
