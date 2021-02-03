<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDelivery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDelivery))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pctUpdate = New System.Windows.Forms.PictureBox()
        Me.pctExit = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpPrintBy = New System.Windows.Forms.GroupBox()
        Me.txtDistLine = New System.Windows.Forms.ComboBox()
        Me.txtMarketer = New System.Windows.Forms.ComboBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.grpDates = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtToDate = New System.Windows.Forms.TextBox()
        Me.txtFromDate = New System.Windows.Forms.TextBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.cldDate = New System.Windows.Forms.MonthCalendar()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.pctUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPrintBy.SuspendLayout()
        Me.grpDates.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Mongolian Baiti", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTitle.Location = New System.Drawing.Point(192, 6)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(195, 39)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "תעודות משלוח"
        '
        'pctUpdate
        '
        Me.pctUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pctUpdate.Image = Global.DirectMarketingAgri.My.Resources.Resources.update1_removebg_preview
        Me.pctUpdate.Location = New System.Drawing.Point(76, 286)
        Me.pctUpdate.Name = "pctUpdate"
        Me.pctUpdate.Size = New System.Drawing.Size(65, 64)
        Me.pctUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctUpdate.TabIndex = 7
        Me.pctUpdate.TabStop = False
        '
        'pctExit
        '
        Me.pctExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pctExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pctExit.Image = Global.DirectMarketingAgri.My.Resources.Resources.icon
        Me.pctExit.Location = New System.Drawing.Point(253, 286)
        Me.pctExit.Name = "pctExit"
        Me.pctExit.Size = New System.Drawing.Size(66, 64)
        Me.pctExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pctExit.TabIndex = 5
        Me.pctExit.TabStop = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(90, 353)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(216, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "יציאה                                                 תצוגה"
        '
        'grpPrintBy
        '
        Me.grpPrintBy.Controls.Add(Me.txtDistLine)
        Me.grpPrintBy.Controls.Add(Me.txtMarketer)
        Me.grpPrintBy.Controls.Add(Me.RadioButton3)
        Me.grpPrintBy.Controls.Add(Me.RadioButton2)
        Me.grpPrintBy.Controls.Add(Me.RadioButton1)
        Me.grpPrintBy.Font = New System.Drawing.Font("Mongolian Baiti", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPrintBy.ForeColor = System.Drawing.Color.Green
        Me.grpPrintBy.Location = New System.Drawing.Point(12, 66)
        Me.grpPrintBy.Name = "grpPrintBy"
        Me.grpPrintBy.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grpPrintBy.Size = New System.Drawing.Size(367, 93)
        Me.grpPrintBy.TabIndex = 18
        Me.grpPrintBy.TabStop = False
        Me.grpPrintBy.Text = "הדפסה לפי:"
        '
        'txtDistLine
        '
        Me.txtDistLine.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDistLine.FormattingEnabled = True
        Me.txtDistLine.Location = New System.Drawing.Point(6, 54)
        Me.txtDistLine.Name = "txtDistLine"
        Me.txtDistLine.Size = New System.Drawing.Size(94, 31)
        Me.txtDistLine.TabIndex = 18
        Me.txtDistLine.Visible = False
        '
        'txtMarketer
        '
        Me.txtMarketer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMarketer.FormattingEnabled = True
        Me.txtMarketer.Location = New System.Drawing.Point(128, 54)
        Me.txtMarketer.Name = "txtMarketer"
        Me.txtMarketer.Size = New System.Drawing.Size(94, 31)
        Me.txtMarketer.TabIndex = 17
        Me.txtMarketer.Visible = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(29, 26)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(93, 28)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "קו חלוקה"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(173, 24)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(71, 28)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "משווק"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(308, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(57, 28)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "הכל"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'grpDates
        '
        Me.grpDates.Controls.Add(Me.Label2)
        Me.grpDates.Controls.Add(Me.Label1)
        Me.grpDates.Controls.Add(Me.txtToDate)
        Me.grpDates.Controls.Add(Me.txtFromDate)
        Me.grpDates.Controls.Add(Me.RadioButton4)
        Me.grpDates.Controls.Add(Me.RadioButton5)
        Me.grpDates.Controls.Add(Me.RadioButton6)
        Me.grpDates.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDates.ForeColor = System.Drawing.Color.Green
        Me.grpDates.Location = New System.Drawing.Point(12, 165)
        Me.grpDates.Name = "grpDates"
        Me.grpDates.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grpDates.Size = New System.Drawing.Size(367, 87)
        Me.grpDates.TabIndex = 19
        Me.grpDates.TabStop = False
        Me.grpDates.Text = "תאריכים:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(162, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 24)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "עד"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(293, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 24)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "מ-"
        '
        'txtToDate
        '
        Me.txtToDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToDate.Location = New System.Drawing.Point(63, 58)
        Me.txtToDate.Name = "txtToDate"
        Me.txtToDate.Size = New System.Drawing.Size(94, 20)
        Me.txtToDate.TabIndex = 15
        Me.txtToDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFromDate
        '
        Me.txtFromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFromDate.Location = New System.Drawing.Point(199, 58)
        Me.txtFromDate.Name = "txtFromDate"
        Me.txtFromDate.Size = New System.Drawing.Size(94, 20)
        Me.txtFromDate.TabIndex = 14
        Me.txtFromDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Mongolian Baiti", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(1, 24)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(121, 28)
        Me.RadioButton4.TabIndex = 2
        Me.RadioButton4.Text = "טווח תאריכים"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Font = New System.Drawing.Font("Mongolian Baiti", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton5.Location = New System.Drawing.Point(138, 24)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(106, 28)
        Me.RadioButton5.TabIndex = 1
        Me.RadioButton5.Text = "חודש אחרון"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Checked = True
        Me.RadioButton6.Font = New System.Drawing.Font("Mongolian Baiti", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton6.Location = New System.Drawing.Point(259, 24)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(106, 28)
        Me.RadioButton6.TabIndex = 0
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "שבוע אחרון"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'cldDate
        '
        Me.cldDate.Location = New System.Drawing.Point(75, 165)
        Me.cldDate.MaxSelectionCount = 30
        Me.cldDate.Name = "cldDate"
        Me.cldDate.TabIndex = 20
        Me.cldDate.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 377)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(365, 23)
        Me.ProgressBar1.TabIndex = 21
        Me.ProgressBar1.Visible = False
        '
        'frmDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.DirectMarketingAgri.My.Resources.Resources.circle2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(389, 412)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.cldDate)
        Me.Controls.Add(Me.grpDates)
        Me.Controls.Add(Me.grpPrintBy)
        Me.Controls.Add(Me.pctUpdate)
        Me.Controls.Add(Me.pctExit)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label6)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmDelivery"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "תעודות משלוח"
        CType(Me.pctUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPrintBy.ResumeLayout(False)
        Me.grpPrintBy.PerformLayout()
        Me.grpDates.ResumeLayout(False)
        Me.grpDates.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents pctUpdate As PictureBox
    Friend WithEvents pctExit As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents grpPrintBy As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents grpDates As GroupBox
    Friend WithEvents txtToDate As TextBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents txtFromDate As TextBox
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cldDate As MonthCalendar
    Friend WithEvents txtMarketer As ComboBox
    Friend WithEvents txtDistLine As ComboBox
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
