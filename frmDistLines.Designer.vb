<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDistLines
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDistLines))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pctUpdate = New System.Windows.Forms.PictureBox()
        Me.pctAdd = New System.Windows.Forms.PictureBox()
        Me.pctExit = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblDriver = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtDriver = New System.Windows.Forms.TextBox()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.ckActive = New System.Windows.Forms.CheckBox()
        Me.lblDayOfWeek = New System.Windows.Forms.Label()
        Me.txtDayOfWeek = New System.Windows.Forms.ComboBox()
        Me.lblCarNum = New System.Windows.Forms.Label()
        Me.txtCarNum = New System.Windows.Forms.TextBox()
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
        Me.lblTitle.Location = New System.Drawing.Point(125, 6)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(148, 39)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "קווי חלוקה"
        '
        'pctUpdate
        '
        Me.pctUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pctUpdate.Image = Global.DirectMarketingAgri.My.Resources.Resources.update1_removebg_preview
        Me.pctUpdate.Location = New System.Drawing.Point(117, 267)
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
        Me.pctAdd.Location = New System.Drawing.Point(13, 267)
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
        Me.pctExit.Location = New System.Drawing.Point(220, 267)
        Me.pctExit.Name = "pctExit"
        Me.pctExit.Size = New System.Drawing.Size(66, 64)
        Me.pctExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pctExit.TabIndex = 5
        Me.pctExit.TabStop = False
        '
        'lblName
        '
        Me.lblName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Green
        Me.lblName.Location = New System.Drawing.Point(207, 102)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(60, 25)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "שם קו"
        '
        'lblDriver
        '
        Me.lblDriver.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDriver.AutoSize = True
        Me.lblDriver.BackColor = System.Drawing.Color.Transparent
        Me.lblDriver.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDriver.ForeColor = System.Drawing.Color.Green
        Me.lblDriver.Location = New System.Drawing.Point(206, 131)
        Me.lblDriver.Name = "lblDriver"
        Me.lblDriver.Size = New System.Drawing.Size(61, 25)
        Me.lblDriver.TabIndex = 9
        Me.lblDriver.Text = "מפעיל"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(27, 333)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(245, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "יציאה                         עדכון                        הוספה"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(35, 106)
        Me.txtName.Name = "txtName"
        Me.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtName.Size = New System.Drawing.Size(122, 20)
        Me.txtName.TabIndex = 12
        '
        'txtDriver
        '
        Me.txtDriver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDriver.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDriver.Location = New System.Drawing.Point(35, 134)
        Me.txtDriver.Name = "txtDriver"
        Me.txtDriver.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDriver.Size = New System.Drawing.Size(122, 20)
        Me.txtDriver.TabIndex = 13
        '
        'lblCode
        '
        Me.lblCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCode.AutoSize = True
        Me.lblCode.BackColor = System.Drawing.Color.Transparent
        Me.lblCode.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.ForeColor = System.Drawing.Color.Green
        Me.lblCode.Location = New System.Drawing.Point(188, 73)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(79, 25)
        Me.lblCode.TabIndex = 15
        Me.lblCode.Text = "מספר קו"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(35, 78)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCode.Size = New System.Drawing.Size(122, 20)
        Me.txtCode.TabIndex = 16
        '
        'ckActive
        '
        Me.ckActive.AutoSize = True
        Me.ckActive.Checked = True
        Me.ckActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckActive.Font = New System.Drawing.Font("Mongolian Baiti", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckActive.Location = New System.Drawing.Point(35, 56)
        Me.ckActive.Name = "ckActive"
        Me.ckActive.Size = New System.Drawing.Size(47, 19)
        Me.ckActive.TabIndex = 17
        Me.ckActive.Text = "פעיל"
        Me.ckActive.UseVisualStyleBackColor = True
        '
        'lblDayOfWeek
        '
        Me.lblDayOfWeek.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDayOfWeek.AutoSize = True
        Me.lblDayOfWeek.BackColor = System.Drawing.Color.Transparent
        Me.lblDayOfWeek.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDayOfWeek.ForeColor = System.Drawing.Color.Green
        Me.lblDayOfWeek.Location = New System.Drawing.Point(178, 160)
        Me.lblDayOfWeek.Name = "lblDayOfWeek"
        Me.lblDayOfWeek.Size = New System.Drawing.Size(89, 25)
        Me.lblDayOfWeek.TabIndex = 18
        Me.lblDayOfWeek.Text = "יום בשבוע"
        '
        'txtDayOfWeek
        '
        Me.txtDayOfWeek.FormattingEnabled = True
        Me.txtDayOfWeek.Items.AddRange(New Object() {"1: ראשון", "2: שני", "3: שלישי", "4: רביעי", "5: חמישי", "6: שישי", "7: שבת"})
        Me.txtDayOfWeek.Location = New System.Drawing.Point(35, 162)
        Me.txtDayOfWeek.Name = "txtDayOfWeek"
        Me.txtDayOfWeek.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDayOfWeek.Size = New System.Drawing.Size(122, 21)
        Me.txtDayOfWeek.TabIndex = 20
        '
        'lblCarNum
        '
        Me.lblCarNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCarNum.AutoSize = True
        Me.lblCarNum.BackColor = System.Drawing.Color.Transparent
        Me.lblCarNum.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarNum.ForeColor = System.Drawing.Color.Green
        Me.lblCarNum.Location = New System.Drawing.Point(178, 189)
        Me.lblCarNum.Name = "lblCarNum"
        Me.lblCarNum.Size = New System.Drawing.Size(92, 25)
        Me.lblCarNum.TabIndex = 21
        Me.lblCarNum.Text = "מספר רכב"
        '
        'txtCarNum
        '
        Me.txtCarNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCarNum.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCarNum.Location = New System.Drawing.Point(35, 191)
        Me.txtCarNum.Name = "txtCarNum"
        Me.txtCarNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCarNum.Size = New System.Drawing.Size(122, 20)
        Me.txtCarNum.TabIndex = 22
        '
        'frmDistLines
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.DirectMarketingAgri.My.Resources.Resources.circle2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(298, 355)
        Me.Controls.Add(Me.txtCarNum)
        Me.Controls.Add(Me.lblCarNum)
        Me.Controls.Add(Me.txtDayOfWeek)
        Me.Controls.Add(Me.lblDayOfWeek)
        Me.Controls.Add(Me.ckActive)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.txtDriver)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblDriver)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.pctUpdate)
        Me.Controls.Add(Me.pctAdd)
        Me.Controls.Add(Me.pctExit)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label6)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmDistLines"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "קווי חלוקה"
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
    Friend WithEvents lblName As Label
    Friend WithEvents lblDriver As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtDriver As TextBox
    Friend WithEvents lblCode As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents ckActive As CheckBox
    Friend WithEvents lblDayOfWeek As Label
    Friend WithEvents txtDayOfWeek As ComboBox
    Friend WithEvents lblCarNum As Label
    Friend WithEvents txtCarNum As TextBox
End Class
