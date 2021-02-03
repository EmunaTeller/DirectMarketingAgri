<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItems))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pctUpdate = New System.Windows.Forms.PictureBox()
        Me.pctAdd = New System.Windows.Forms.PictureBox()
        Me.pctExit = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.ckActive = New System.Windows.Forms.CheckBox()
        Me.txtUnitWeight = New System.Windows.Forms.TextBox()
        Me.lblUnitWeight = New System.Windows.Forms.Label()
        Me.txtQuantityPerCarton = New System.Windows.Forms.TextBox()
        Me.lblQuantityPerCarton = New System.Windows.Forms.Label()
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
        Me.lblTitle.Location = New System.Drawing.Point(174, 6)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(104, 39)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "מוצרים"
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
        'lblName
        '
        Me.lblName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Green
        Me.lblName.Location = New System.Drawing.Point(192, 102)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(81, 25)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "שם מוצר"
        '
        'lblPrice
        '
        Me.lblPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.Green
        Me.lblPrice.Location = New System.Drawing.Point(222, 131)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(51, 25)
        Me.lblPrice.TabIndex = 9
        Me.lblPrice.Text = "מחיר"
        '
        'lblStock
        '
        Me.lblStock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStock.AutoSize = True
        Me.lblStock.BackColor = System.Drawing.Color.Transparent
        Me.lblStock.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.ForeColor = System.Drawing.Color.Green
        Me.lblStock.Location = New System.Drawing.Point(223, 160)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(50, 25)
        Me.lblStock.TabIndex = 10
        Me.lblStock.Text = "מלאי"
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
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(29, 107)
        Me.txtName.Name = "txtName"
        Me.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtName.Size = New System.Drawing.Size(122, 20)
        Me.txtName.TabIndex = 12
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(29, 135)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPrice.Size = New System.Drawing.Size(122, 20)
        Me.txtPrice.TabIndex = 13
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(29, 163)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.ReadOnly = True
        Me.txtStock.Size = New System.Drawing.Size(122, 20)
        Me.txtStock.TabIndex = 14
        Me.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCode
        '
        Me.lblCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCode.AutoSize = True
        Me.lblCode.BackColor = System.Drawing.Color.Transparent
        Me.lblCode.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.ForeColor = System.Drawing.Color.Green
        Me.lblCode.Location = New System.Drawing.Point(192, 73)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(81, 25)
        Me.lblCode.TabIndex = 15
        Me.lblCode.Text = "קוד מוצר"
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
        'ckActive
        '
        Me.ckActive.AutoSize = True
        Me.ckActive.Checked = True
        Me.ckActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckActive.Font = New System.Drawing.Font("Mongolian Baiti", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckActive.Location = New System.Drawing.Point(29, 53)
        Me.ckActive.Name = "ckActive"
        Me.ckActive.Size = New System.Drawing.Size(47, 19)
        Me.ckActive.TabIndex = 18
        Me.ckActive.Text = "פעיל"
        Me.ckActive.UseVisualStyleBackColor = True
        '
        'txtUnitWeight
        '
        Me.txtUnitWeight.Location = New System.Drawing.Point(29, 193)
        Me.txtUnitWeight.Name = "txtUnitWeight"
        Me.txtUnitWeight.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtUnitWeight.Size = New System.Drawing.Size(122, 20)
        Me.txtUnitWeight.TabIndex = 20
        '
        'lblUnitWeight
        '
        Me.lblUnitWeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUnitWeight.AutoSize = True
        Me.lblUnitWeight.BackColor = System.Drawing.Color.Transparent
        Me.lblUnitWeight.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitWeight.ForeColor = System.Drawing.Color.Green
        Me.lblUnitWeight.Location = New System.Drawing.Point(165, 189)
        Me.lblUnitWeight.Name = "lblUnitWeight"
        Me.lblUnitWeight.Size = New System.Drawing.Size(108, 25)
        Me.lblUnitWeight.TabIndex = 19
        Me.lblUnitWeight.Text = "משקל יחידה"
        '
        'txtQuantityPerCarton
        '
        Me.txtQuantityPerCarton.Location = New System.Drawing.Point(29, 220)
        Me.txtQuantityPerCarton.Name = "txtQuantityPerCarton"
        Me.txtQuantityPerCarton.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtQuantityPerCarton.Size = New System.Drawing.Size(122, 20)
        Me.txtQuantityPerCarton.TabIndex = 22
        '
        'lblQuantityPerCarton
        '
        Me.lblQuantityPerCarton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantityPerCarton.AutoSize = True
        Me.lblQuantityPerCarton.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantityPerCarton.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantityPerCarton.ForeColor = System.Drawing.Color.Green
        Me.lblQuantityPerCarton.Location = New System.Drawing.Point(162, 216)
        Me.lblQuantityPerCarton.Name = "lblQuantityPerCarton"
        Me.lblQuantityPerCarton.Size = New System.Drawing.Size(111, 25)
        Me.lblQuantityPerCarton.TabIndex = 21
        Me.lblQuantityPerCarton.Text = "כמות לקרטון"
        '
        'frmItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.DirectMarketingAgri.My.Resources.Resources.circle2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(298, 370)
        Me.Controls.Add(Me.txtQuantityPerCarton)
        Me.Controls.Add(Me.lblQuantityPerCarton)
        Me.Controls.Add(Me.txtUnitWeight)
        Me.Controls.Add(Me.lblUnitWeight)
        Me.Controls.Add(Me.ckActive)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.pctUpdate)
        Me.Controls.Add(Me.pctAdd)
        Me.Controls.Add(Me.pctExit)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label6)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmItems"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "מוצרים"
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
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents lblCode As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents ckActive As CheckBox
    Friend WithEvents txtUnitWeight As TextBox
    Friend WithEvents lblUnitWeight As Label
    Friend WithEvents txtQuantityPerCarton As TextBox
    Friend WithEvents lblQuantityPerCarton As Label
End Class
