<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMarketers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMarketers))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pctUpdate = New System.Windows.Forms.PictureBox()
        Me.pctAdd = New System.Windows.Forms.PictureBox()
        Me.pctExit = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPlace = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPlace = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lblDistLines = New System.Windows.Forms.Label()
        Me.ckActive = New System.Windows.Forms.CheckBox()
        Me.txtDistLines = New System.Windows.Forms.ComboBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
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
        Me.lblTitle.Location = New System.Drawing.Point(156, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(120, 39)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "משווקים"
        '
        'pctUpdate
        '
        Me.pctUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pctUpdate.Image = Global.DirectMarketingAgri.My.Resources.Resources.update1_removebg_preview
        Me.pctUpdate.Location = New System.Drawing.Point(117, 301)
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
        Me.pctAdd.Location = New System.Drawing.Point(13, 301)
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
        Me.pctExit.Location = New System.Drawing.Point(220, 301)
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
        Me.lblName.Location = New System.Drawing.Point(181, 102)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(91, 25)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "שם משווק"
        '
        'lblPlace
        '
        Me.lblPlace.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPlace.AutoSize = True
        Me.lblPlace.BackColor = System.Drawing.Color.Transparent
        Me.lblPlace.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlace.ForeColor = System.Drawing.Color.Green
        Me.lblPlace.Location = New System.Drawing.Point(173, 130)
        Me.lblPlace.Name = "lblPlace"
        Me.lblPlace.Size = New System.Drawing.Size(99, 25)
        Me.lblPlace.TabIndex = 9
        Me.lblPlace.Text = "מקום שיווק"
        '
        'lblAddress
        '
        Me.lblAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Green
        Me.lblAddress.Location = New System.Drawing.Point(209, 158)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(63, 25)
        Me.lblAddress.TabIndex = 10
        Me.lblAddress.Text = "כתובת"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(27, 367)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(245, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "יציאה                         עדכון                        הוספה"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(35, 107)
        Me.txtName.Name = "txtName"
        Me.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtName.Size = New System.Drawing.Size(122, 20)
        Me.txtName.TabIndex = 12
        '
        'txtPlace
        '
        Me.txtPlace.Location = New System.Drawing.Point(35, 135)
        Me.txtPlace.Name = "txtPlace"
        Me.txtPlace.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPlace.Size = New System.Drawing.Size(122, 20)
        Me.txtPlace.TabIndex = 13
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(35, 163)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(122, 20)
        Me.txtAddress.TabIndex = 14
        Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCode
        '
        Me.lblCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCode.AutoSize = True
        Me.lblCode.BackColor = System.Drawing.Color.Transparent
        Me.lblCode.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.ForeColor = System.Drawing.Color.Green
        Me.lblCode.Location = New System.Drawing.Point(181, 74)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(91, 25)
        Me.lblCode.TabIndex = 15
        Me.lblCode.Text = "קוד משווק"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(35, 79)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCode.Size = New System.Drawing.Size(122, 20)
        Me.txtCode.TabIndex = 16
        '
        'lblDistLines
        '
        Me.lblDistLines.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDistLines.AutoSize = True
        Me.lblDistLines.BackColor = System.Drawing.Color.Transparent
        Me.lblDistLines.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistLines.ForeColor = System.Drawing.Color.Green
        Me.lblDistLines.Location = New System.Drawing.Point(187, 242)
        Me.lblDistLines.Name = "lblDistLines"
        Me.lblDistLines.Size = New System.Drawing.Size(85, 25)
        Me.lblDistLines.TabIndex = 17
        Me.lblDistLines.Text = "קו חלוקה"
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
        Me.ckActive.TabIndex = 19
        Me.ckActive.Text = "פעיל"
        Me.ckActive.UseVisualStyleBackColor = True
        '
        'txtDistLines
        '
        Me.txtDistLines.DisplayMember = "Marketers"
        Me.txtDistLines.FormattingEnabled = True
        Me.txtDistLines.Items.AddRange(New Object() {"1: ראשון", "2: שני", "3: שלישי", "4: רביעי", "5: חמישי", "6: שישי", "7: שבת"})
        Me.txtDistLines.Location = New System.Drawing.Point(35, 246)
        Me.txtDistLines.Name = "txtDistLines"
        Me.txtDistLines.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDistLines.Size = New System.Drawing.Size(122, 21)
        Me.txtDistLines.TabIndex = 21
        Me.txtDistLines.ValueMember = "Marketers"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(35, 191)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(122, 20)
        Me.txtMail.TabIndex = 23
        Me.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblMail
        '
        Me.lblMail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMail.AutoSize = True
        Me.lblMail.BackColor = System.Drawing.Color.Transparent
        Me.lblMail.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.ForeColor = System.Drawing.Color.Green
        Me.lblMail.Location = New System.Drawing.Point(228, 186)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(44, 25)
        Me.lblMail.TabIndex = 22
        Me.lblMail.Text = "מייל"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(35, 219)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(122, 20)
        Me.txtPhone.TabIndex = 25
        Me.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPhone
        '
        Me.lblPhone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPhone.AutoSize = True
        Me.lblPhone.BackColor = System.Drawing.Color.Transparent
        Me.lblPhone.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.ForeColor = System.Drawing.Color.Green
        Me.lblPhone.Location = New System.Drawing.Point(217, 214)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(55, 25)
        Me.lblPhone.TabIndex = 24
        Me.lblPhone.Text = "טלפון"
        '
        'frmMarketers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.DirectMarketingAgri.My.Resources.Resources.circle2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(298, 391)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.txtDistLines)
        Me.Controls.Add(Me.ckActive)
        Me.Controls.Add(Me.lblDistLines)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtPlace)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblPlace)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.pctUpdate)
        Me.Controls.Add(Me.pctAdd)
        Me.Controls.Add(Me.pctExit)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label6)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMarketers"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "משווקים"
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
    Friend WithEvents lblPlace As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPlace As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblCode As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents lblDistLines As Label
    Friend WithEvents ckActive As CheckBox
    Friend WithEvents txtDistLines As ComboBox
    Friend WithEvents txtMail As TextBox
    Friend WithEvents lblMail As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblPhone As Label
End Class
