<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddPay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddPay))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pctUpdate = New System.Windows.Forms.PictureBox()
        Me.pctAdd = New System.Windows.Forms.PictureBox()
        Me.pctExit = New System.Windows.Forms.PictureBox()
        Me.lblMarketer = New System.Windows.Forms.Label()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtSum = New System.Windows.Forms.TextBox()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lblTransferType = New System.Windows.Forms.Label()
        Me.txtDetailes = New System.Windows.Forms.TextBox()
        Me.lblDetailes = New System.Windows.Forms.Label()
        Me.txtTransferType = New System.Windows.Forms.ComboBox()
        Me.txtMarketer = New System.Windows.Forms.ComboBox()
        CType(Me.pctUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Mongolian Baiti", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTitle.Location = New System.Drawing.Point(152, 6)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(129, 39)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "תשלומים"
        '
        'pctUpdate
        '
        Me.pctUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pctUpdate.Image = Global.DirectMarketingAgri.My.Resources.Resources.update1_removebg_preview
        Me.pctUpdate.Location = New System.Drawing.Point(117, 281)
        Me.pctUpdate.Name = "pctUpdate"
        Me.pctUpdate.Size = New System.Drawing.Size(65, 64)
        Me.pctUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctUpdate.TabIndex = 7
        Me.pctUpdate.TabStop = False
        '
        'pctAdd
        '
        Me.pctAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pctAdd.Image = Global.DirectMarketingAgri.My.Resources.Resources.Add_removebg_preview
        Me.pctAdd.Location = New System.Drawing.Point(13, 281)
        Me.pctAdd.Name = "pctAdd"
        Me.pctAdd.Size = New System.Drawing.Size(65, 64)
        Me.pctAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctAdd.TabIndex = 6
        Me.pctAdd.TabStop = False
        '
        'pctExit
        '
        Me.pctExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pctExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pctExit.Image = Global.DirectMarketingAgri.My.Resources.Resources.icon
        Me.pctExit.Location = New System.Drawing.Point(220, 281)
        Me.pctExit.Name = "pctExit"
        Me.pctExit.Size = New System.Drawing.Size(66, 64)
        Me.pctExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pctExit.TabIndex = 5
        Me.pctExit.TabStop = False
        '
        'lblMarketer
        '
        Me.lblMarketer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMarketer.AutoSize = True
        Me.lblMarketer.BackColor = System.Drawing.Color.Transparent
        Me.lblMarketer.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarketer.ForeColor = System.Drawing.Color.Green
        Me.lblMarketer.Location = New System.Drawing.Point(216, 102)
        Me.lblMarketer.Name = "lblMarketer"
        Me.lblMarketer.Size = New System.Drawing.Size(60, 25)
        Me.lblMarketer.TabIndex = 8
        Me.lblMarketer.Text = "משווק"
        '
        'lblSum
        '
        Me.lblSum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSum.AutoSize = True
        Me.lblSum.BackColor = System.Drawing.Color.Transparent
        Me.lblSum.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSum.ForeColor = System.Drawing.Color.Green
        Me.lblSum.Location = New System.Drawing.Point(225, 160)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(51, 25)
        Me.lblSum.TabIndex = 9
        Me.lblSum.Text = "סכום"
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Green
        Me.lblDate.Location = New System.Drawing.Point(215, 130)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(61, 25)
        Me.lblDate.TabIndex = 10
        Me.lblDate.Text = "תאריך"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(27, 347)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(245, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "יציאה                         עדכון                        הוספה"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(29, 135)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDate.Size = New System.Drawing.Size(122, 20)
        Me.txtDate.TabIndex = 13
        '
        'txtSum
        '
        Me.txtSum.Location = New System.Drawing.Point(29, 163)
        Me.txtSum.Name = "txtSum"
        Me.txtSum.Size = New System.Drawing.Size(122, 20)
        Me.txtSum.TabIndex = 14
        Me.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCode
        '
        Me.lblCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCode.AutoSize = True
        Me.lblCode.BackColor = System.Drawing.Color.Transparent
        Me.lblCode.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.ForeColor = System.Drawing.Color.Green
        Me.lblCode.Location = New System.Drawing.Point(179, 73)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(97, 25)
        Me.lblCode.TabIndex = 15
        Me.lblCode.Text = "קוד תשלום"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(29, 78)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCode.Size = New System.Drawing.Size(122, 20)
        Me.txtCode.TabIndex = 16
        '
        'lblTransferType
        '
        Me.lblTransferType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTransferType.AutoSize = True
        Me.lblTransferType.BackColor = System.Drawing.Color.Transparent
        Me.lblTransferType.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransferType.ForeColor = System.Drawing.Color.Green
        Me.lblTransferType.Location = New System.Drawing.Point(165, 189)
        Me.lblTransferType.Name = "lblTransferType"
        Me.lblTransferType.Size = New System.Drawing.Size(111, 25)
        Me.lblTransferType.TabIndex = 19
        Me.lblTransferType.Text = "צורת העברה"
        '
        'txtDetailes
        '
        Me.txtDetailes.Location = New System.Drawing.Point(29, 222)
        Me.txtDetailes.Name = "txtDetailes"
        Me.txtDetailes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDetailes.Size = New System.Drawing.Size(122, 20)
        Me.txtDetailes.TabIndex = 22
        '
        'lblDetailes
        '
        Me.lblDetailes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDetailes.AutoSize = True
        Me.lblDetailes.BackColor = System.Drawing.Color.Transparent
        Me.lblDetailes.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetailes.ForeColor = System.Drawing.Color.Green
        Me.lblDetailes.Location = New System.Drawing.Point(157, 218)
        Me.lblDetailes.Name = "lblDetailes"
        Me.lblDetailes.Size = New System.Drawing.Size(119, 25)
        Me.lblDetailes.TabIndex = 21
        Me.lblDetailes.Text = "פרטים נוספים"
        '
        'txtTransferType
        '
        Me.txtTransferType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransferType.FormattingEnabled = True
        Me.txtTransferType.Items.AddRange(New Object() {"1: אשראי", "2: מזומן", "3: צ'ק", "4: העברה בנקאית", "5: אחר"})
        Me.txtTransferType.Location = New System.Drawing.Point(29, 193)
        Me.txtTransferType.Name = "txtTransferType"
        Me.txtTransferType.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTransferType.Size = New System.Drawing.Size(122, 21)
        Me.txtTransferType.TabIndex = 23
        '
        'txtMarketer
        '
        Me.txtMarketer.BackColor = System.Drawing.SystemColors.Control
        Me.txtMarketer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.txtMarketer.Enabled = False
        Me.txtMarketer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarketer.FormattingEnabled = True
        Me.txtMarketer.Location = New System.Drawing.Point(29, 107)
        Me.txtMarketer.Name = "txtMarketer"
        Me.txtMarketer.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMarketer.Size = New System.Drawing.Size(122, 20)
        Me.txtMarketer.TabIndex = 24
        '
        'frmAddPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.DirectMarketingAgri.My.Resources.Resources.circle2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(298, 370)
        Me.Controls.Add(Me.txtMarketer)
        Me.Controls.Add(Me.txtTransferType)
        Me.Controls.Add(Me.txtDetailes)
        Me.Controls.Add(Me.lblDetailes)
        Me.Controls.Add(Me.lblTransferType)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.txtSum)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.lblMarketer)
        Me.Controls.Add(Me.pctUpdate)
        Me.Controls.Add(Me.pctAdd)
        Me.Controls.Add(Me.pctExit)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label6)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAddPay"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "תשלומים"
        CType(Me.pctUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents pctUpdate As PictureBox
    Friend WithEvents pctAdd As PictureBox
    Friend WithEvents pctExit As PictureBox
    Friend WithEvents lblMarketer As Label
    Friend WithEvents lblSum As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtSum As TextBox
    Friend WithEvents lblCode As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents lblTransferType As Label
    Friend WithEvents txtDetailes As TextBox
    Friend WithEvents lblDetailes As Label
    Friend WithEvents txtTransferType As ComboBox
    Friend WithEvents txtMarketer As ComboBox
End Class
