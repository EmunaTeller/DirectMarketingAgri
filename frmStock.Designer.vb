<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStock))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gOrderLines = New System.Windows.Forms.DataGridView()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pctUpdate = New System.Windows.Forms.PictureBox()
        Me.pctExit = New System.Windows.Forms.PictureBox()
        CType(Me.gOrderLines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(222, 629)
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
        Me.gOrderLines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
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
        Me.gOrderLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gOrderLines.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.gOrderLines.Location = New System.Drawing.Point(14, 56)
        Me.gOrderLines.Name = "gOrderLines"
        Me.gOrderLines.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gOrderLines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.gOrderLines.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gOrderLines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gOrderLines.Size = New System.Drawing.Size(523, 501)
        Me.gOrderLines.TabIndex = 20
        Me.gOrderLines.TabStop = False
        '
        'lblCode
        '
        Me.lblCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCode.AutoSize = True
        Me.lblCode.BackColor = System.Drawing.Color.Transparent
        Me.lblCode.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.ForeColor = System.Drawing.Color.Green
        Me.lblCode.Location = New System.Drawing.Point(446, 14)
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
        Me.DataGridView1.Size = New System.Drawing.Size(557, 42)
        Me.DataGridView1.TabIndex = 21
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.GreenYellow
        Me.lblTitle.Font = New System.Drawing.Font("Mongolian Baiti", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTitle.Location = New System.Drawing.Point(129, 1)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(309, 37)
        Me.lblTitle.TabIndex = 22
        Me.lblTitle.Text = "מלאי לשבוע 01/01/01"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pctUpdate
        '
        Me.pctUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pctUpdate.Image = Global.DirectMarketingAgri.My.Resources.Resources.update1_removebg_preview
        Me.pctUpdate.Location = New System.Drawing.Point(206, 563)
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
        Me.pctExit.Location = New System.Drawing.Point(277, 563)
        Me.pctExit.Name = "pctExit"
        Me.pctExit.Size = New System.Drawing.Size(66, 64)
        Me.pctExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pctExit.TabIndex = 5
        Me.pctExit.TabStop = False
        '
        'frmStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(549, 654)
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
        Me.Name = "frmStock"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "מלאי"
        CType(Me.gOrderLines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctExit, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
