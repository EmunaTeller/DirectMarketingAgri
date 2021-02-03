<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPayments
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayments))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gOrderLines = New System.Windows.Forms.DataGridView()
        Me.clmAddPay = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pctUpdate = New System.Windows.Forms.PictureBox()
        Me.pctExit = New System.Windows.Forms.PictureBox()
        Me.grpPrintBy = New System.Windows.Forms.GroupBox()
        Me.txtMonth = New System.Windows.Forms.ComboBox()
        Me.txtMarketer = New System.Windows.Forms.ComboBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        CType(Me.gOrderLines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPrintBy.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(265, 656)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "יציאה               עדכון"
        '
        'gOrderLines
        '
        Me.gOrderLines.AllowUserToAddRows = False
        Me.gOrderLines.AllowUserToDeleteRows = False
        Me.gOrderLines.AllowUserToOrderColumns = True
        Me.gOrderLines.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gOrderLines.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.gOrderLines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gOrderLines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.GreenYellow
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gOrderLines.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gOrderLines.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmAddPay})
        Me.gOrderLines.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.gOrderLines.Location = New System.Drawing.Point(14, 108)
        Me.gOrderLines.Name = "gOrderLines"
        Me.gOrderLines.ReadOnly = True
        Me.gOrderLines.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gOrderLines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.gOrderLines.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gOrderLines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gOrderLines.Size = New System.Drawing.Size(606, 466)
        Me.gOrderLines.TabIndex = 20
        Me.gOrderLines.TabStop = False
        '
        'clmAddPay
        '
        Me.clmAddPay.HeaderText = "תשלום"
        Me.clmAddPay.Name = "clmAddPay"
        Me.clmAddPay.ReadOnly = True
        Me.clmAddPay.Text = "תשלום"
        Me.clmAddPay.Width = 50
        '
        'lblCode
        '
        Me.lblCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCode.AutoSize = True
        Me.lblCode.BackColor = System.Drawing.Color.Transparent
        Me.lblCode.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.ForeColor = System.Drawing.Color.Green
        Me.lblCode.Location = New System.Drawing.Point(529, 14)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(81, 25)
        Me.lblCode.TabIndex = 15
        Me.lblCode.Text = "קוד מוצר"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.GreenYellow
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-4, -3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(640, 42)
        Me.DataGridView1.TabIndex = 21
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.GreenYellow
        Me.lblTitle.Font = New System.Drawing.Font("Mongolian Baiti", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTitle.Location = New System.Drawing.Point(182, -3)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(289, 37)
        Me.lblTitle.TabIndex = 22
        Me.lblTitle.Text = "תשלומים לשנת 2020"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pctUpdate
        '
        Me.pctUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pctUpdate.Image = Global.DirectMarketingAgri.My.Resources.Resources.update1_removebg_preview
        Me.pctUpdate.Location = New System.Drawing.Point(249, 590)
        Me.pctUpdate.Name = "pctUpdate"
        Me.pctUpdate.Size = New System.Drawing.Size(65, 64)
        Me.pctUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctUpdate.TabIndex = 7
        Me.pctUpdate.TabStop = False
        '
        'pctExit
        '
        Me.pctExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pctExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pctExit.Image = Global.DirectMarketingAgri.My.Resources.Resources.icon
        Me.pctExit.Location = New System.Drawing.Point(320, 590)
        Me.pctExit.Name = "pctExit"
        Me.pctExit.Size = New System.Drawing.Size(66, 64)
        Me.pctExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pctExit.TabIndex = 5
        Me.pctExit.TabStop = False
        '
        'grpPrintBy
        '
        Me.grpPrintBy.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPrintBy.Controls.Add(Me.txtMonth)
        Me.grpPrintBy.Controls.Add(Me.txtMarketer)
        Me.grpPrintBy.Controls.Add(Me.RadioButton3)
        Me.grpPrintBy.Controls.Add(Me.RadioButton2)
        Me.grpPrintBy.Controls.Add(Me.RadioButton1)
        Me.grpPrintBy.Font = New System.Drawing.Font("Mongolian Baiti", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPrintBy.ForeColor = System.Drawing.Color.Green
        Me.grpPrintBy.Location = New System.Drawing.Point(12, 42)
        Me.grpPrintBy.Name = "grpPrintBy"
        Me.grpPrintBy.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grpPrintBy.Size = New System.Drawing.Size(608, 60)
        Me.grpPrintBy.TabIndex = 23
        Me.grpPrintBy.TabStop = False
        Me.grpPrintBy.Text = "תצוגה לפי:"
        '
        'txtMonth
        '
        Me.txtMonth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMonth.FormattingEnabled = True
        Me.txtMonth.Items.AddRange(New Object() {"1: ינואר", "2: פברואר", "3: מרץ", "4: אפריל", "5: מאי", "6: יוני", "7: יולי", "8: אוגוסט", "9: ספטמבר", "10: אוקטובר", "11: נובמבר", "12: דצמבר"})
        Me.txtMonth.Location = New System.Drawing.Point(136, 24)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMonth.Size = New System.Drawing.Size(108, 28)
        Me.txtMonth.TabIndex = 24
        Me.txtMonth.Visible = False
        '
        'txtMarketer
        '
        Me.txtMarketer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMarketer.FormattingEnabled = True
        Me.txtMarketer.Location = New System.Drawing.Point(326, 24)
        Me.txtMarketer.Name = "txtMarketer"
        Me.txtMarketer.Size = New System.Drawing.Size(111, 28)
        Me.txtMarketer.TabIndex = 16
        Me.txtMarketer.Visible = False
        '
        'RadioButton3
        '
        Me.RadioButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Location = New System.Drawing.Point(527, 24)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(75, 24)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "סך הכל"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(247, 24)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(60, 24)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "חודש"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton1.Location = New System.Drawing.Point(443, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(67, 24)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "משווק"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'frmPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(632, 681)
        Me.Controls.Add(Me.grpPrintBy)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.gOrderLines)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.pctUpdate)
        Me.Controls.Add(Me.pctExit)
        Me.Controls.Add(Me.Label6)
        Me.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPayments"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "תשלומים"
        CType(Me.gOrderLines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPrintBy.ResumeLayout(False)
        Me.grpPrintBy.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pctUpdate As PictureBox
    Friend WithEvents pctExit As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents gOrderLines As DataGridView
    Friend WithEvents lblCode As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblTitle As Label
    Friend WithEvents grpPrintBy As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents clmAddPay As DataGridViewButtonColumn
    Friend WithEvents txtMarketer As ComboBox
    Friend WithEvents txtMonth As ComboBox
End Class
