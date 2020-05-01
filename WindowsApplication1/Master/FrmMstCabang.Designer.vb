<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMstCabang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMstCabang))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txtidcabang = New System.Windows.Forms.TextBox()
        Me.CboCompany = New System.Windows.Forms.ComboBox()
        Me.TxtNamaCabang = New System.Windows.Forms.TextBox()
        Me.RbActive = New Guna.UI.WinForms.GunaRadioButton()
        Me.RbSuspend = New Guna.UI.WinForms.GunaRadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.BtmSave = New Guna.UI.WinForms.GunaButton()
        Me.BtmOpen = New Guna.UI.WinForms.GunaButton()
        Me.BtmEdit = New Guna.UI.WinForms.GunaButton()
        Me.BtmDelete = New Guna.UI.WinForms.GunaButton()
        Me.DgDataCabang = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GunaGroupBox1.SuspendLayout()
        CType(Me.DgDataCabang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtmDelete)
        Me.GroupBox1.Controls.Add(Me.BtmEdit)
        Me.GroupBox1.Controls.Add(Me.BtmOpen)
        Me.GroupBox1.Controls.Add(Me.BtmSave)
        Me.GroupBox1.Location = New System.Drawing.Point(242, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(194, 110)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Txtidcabang
        '
        Me.Txtidcabang.Location = New System.Drawing.Point(84, 13)
        Me.Txtidcabang.Name = "Txtidcabang"
        Me.Txtidcabang.Size = New System.Drawing.Size(151, 20)
        Me.Txtidcabang.TabIndex = 1
        '
        'CboCompany
        '
        Me.CboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCompany.FormattingEnabled = True
        Me.CboCompany.Location = New System.Drawing.Point(84, 41)
        Me.CboCompany.Name = "CboCompany"
        Me.CboCompany.Size = New System.Drawing.Size(151, 21)
        Me.CboCompany.TabIndex = 2
        '
        'TxtNamaCabang
        '
        Me.TxtNamaCabang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNamaCabang.Location = New System.Drawing.Point(84, 68)
        Me.TxtNamaCabang.Name = "TxtNamaCabang"
        Me.TxtNamaCabang.Size = New System.Drawing.Size(151, 20)
        Me.TxtNamaCabang.TabIndex = 3
        '
        'RbActive
        '
        Me.RbActive.BaseColor = System.Drawing.SystemColors.Control
        Me.RbActive.CheckedOffColor = System.Drawing.Color.Gray
        Me.RbActive.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RbActive.FillColor = System.Drawing.Color.White
        Me.RbActive.Location = New System.Drawing.Point(86, 94)
        Me.RbActive.Name = "RbActive"
        Me.RbActive.Size = New System.Drawing.Size(61, 20)
        Me.RbActive.TabIndex = 4
        Me.RbActive.Text = "Active"
        '
        'RbSuspend
        '
        Me.RbSuspend.BaseColor = System.Drawing.SystemColors.Control
        Me.RbSuspend.CheckedOffColor = System.Drawing.Color.Gray
        Me.RbSuspend.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RbSuspend.FillColor = System.Drawing.Color.White
        Me.RbSuspend.Location = New System.Drawing.Point(154, 93)
        Me.RbSuspend.Name = "RbSuspend"
        Me.RbSuspend.Size = New System.Drawing.Size(81, 20)
        Me.RbSuspend.TabIndex = 5
        Me.RbSuspend.Text = "Not Active"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ID Cabang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Company"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nama Cabang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Status"
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.DgDataCabang)
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Location = New System.Drawing.Point(6, 131)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(430, 240)
        Me.GunaGroupBox1.TabIndex = 10
        Me.GunaGroupBox1.Text = "List Data Cabang"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'BtmSave
        '
        Me.BtmSave.AnimationHoverSpeed = 0.07!
        Me.BtmSave.AnimationSpeed = 0.03!
        Me.BtmSave.BaseColor = System.Drawing.Color.Green
        Me.BtmSave.BorderColor = System.Drawing.Color.Black
        Me.BtmSave.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtmSave.FocusedColor = System.Drawing.Color.Empty
        Me.BtmSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtmSave.ForeColor = System.Drawing.Color.White
        Me.BtmSave.Image = CType(resources.GetObject("BtmSave.Image"), System.Drawing.Image)
        Me.BtmSave.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtmSave.Location = New System.Drawing.Point(6, 11)
        Me.BtmSave.Name = "BtmSave"
        Me.BtmSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtmSave.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtmSave.OnHoverForeColor = System.Drawing.Color.White
        Me.BtmSave.OnHoverImage = Nothing
        Me.BtmSave.OnPressedColor = System.Drawing.Color.Black
        Me.BtmSave.Size = New System.Drawing.Size(90, 44)
        Me.BtmSave.TabIndex = 0
        Me.BtmSave.Text = "Save"
        '
        'BtmOpen
        '
        Me.BtmOpen.AnimationHoverSpeed = 0.07!
        Me.BtmOpen.AnimationSpeed = 0.03!
        Me.BtmOpen.BaseColor = System.Drawing.Color.DarkOrange
        Me.BtmOpen.BorderColor = System.Drawing.Color.Black
        Me.BtmOpen.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtmOpen.FocusedColor = System.Drawing.Color.Empty
        Me.BtmOpen.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtmOpen.ForeColor = System.Drawing.Color.White
        Me.BtmOpen.Image = CType(resources.GetObject("BtmOpen.Image"), System.Drawing.Image)
        Me.BtmOpen.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtmOpen.Location = New System.Drawing.Point(6, 61)
        Me.BtmOpen.Name = "BtmOpen"
        Me.BtmOpen.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtmOpen.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtmOpen.OnHoverForeColor = System.Drawing.Color.White
        Me.BtmOpen.OnHoverImage = Nothing
        Me.BtmOpen.OnPressedColor = System.Drawing.Color.Black
        Me.BtmOpen.Size = New System.Drawing.Size(90, 43)
        Me.BtmOpen.TabIndex = 1
        Me.BtmOpen.Text = "Open"
        '
        'BtmEdit
        '
        Me.BtmEdit.AnimationHoverSpeed = 0.07!
        Me.BtmEdit.AnimationSpeed = 0.03!
        Me.BtmEdit.BaseColor = System.Drawing.Color.SlateBlue
        Me.BtmEdit.BorderColor = System.Drawing.Color.Black
        Me.BtmEdit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtmEdit.FocusedColor = System.Drawing.Color.Empty
        Me.BtmEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtmEdit.ForeColor = System.Drawing.Color.White
        Me.BtmEdit.Image = CType(resources.GetObject("BtmEdit.Image"), System.Drawing.Image)
        Me.BtmEdit.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtmEdit.Location = New System.Drawing.Point(102, 11)
        Me.BtmEdit.Name = "BtmEdit"
        Me.BtmEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtmEdit.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtmEdit.OnHoverForeColor = System.Drawing.Color.White
        Me.BtmEdit.OnHoverImage = Nothing
        Me.BtmEdit.OnPressedColor = System.Drawing.Color.Black
        Me.BtmEdit.Size = New System.Drawing.Size(86, 42)
        Me.BtmEdit.TabIndex = 2
        Me.BtmEdit.Text = "Edit"
        '
        'BtmDelete
        '
        Me.BtmDelete.AnimationHoverSpeed = 0.07!
        Me.BtmDelete.AnimationSpeed = 0.03!
        Me.BtmDelete.BaseColor = System.Drawing.Color.Crimson
        Me.BtmDelete.BorderColor = System.Drawing.Color.Black
        Me.BtmDelete.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtmDelete.FocusedColor = System.Drawing.Color.Empty
        Me.BtmDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtmDelete.ForeColor = System.Drawing.Color.White
        Me.BtmDelete.Image = CType(resources.GetObject("BtmDelete.Image"), System.Drawing.Image)
        Me.BtmDelete.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtmDelete.Location = New System.Drawing.Point(102, 61)
        Me.BtmDelete.Name = "BtmDelete"
        Me.BtmDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtmDelete.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtmDelete.OnHoverForeColor = System.Drawing.Color.White
        Me.BtmDelete.OnHoverImage = Nothing
        Me.BtmDelete.OnPressedColor = System.Drawing.Color.Black
        Me.BtmDelete.Size = New System.Drawing.Size(86, 42)
        Me.BtmDelete.TabIndex = 3
        Me.BtmDelete.Text = "Delete"
        '
        'DgDataCabang
        '
        Me.DgDataCabang.AllowUserToAddRows = False
        Me.DgDataCabang.AllowUserToDeleteRows = False
        Me.DgDataCabang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgDataCabang.Location = New System.Drawing.Point(6, 33)
        Me.DgDataCabang.Name = "DgDataCabang"
        Me.DgDataCabang.ReadOnly = True
        Me.DgDataCabang.Size = New System.Drawing.Size(419, 204)
        Me.DgDataCabang.TabIndex = 0
        '
        'FrmMstCabang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 397)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RbSuspend)
        Me.Controls.Add(Me.RbActive)
        Me.Controls.Add(Me.TxtNamaCabang)
        Me.Controls.Add(Me.CboCompany)
        Me.Controls.Add(Me.Txtidcabang)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmMstCabang"
        Me.Text = "Master Cabang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.ResumeLayout(False)
        CType(Me.DgDataCabang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtmOpen As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtmSave As Guna.UI.WinForms.GunaButton
    Friend WithEvents Txtidcabang As TextBox
    Friend WithEvents CboCompany As ComboBox
    Friend WithEvents TxtNamaCabang As TextBox
    Friend WithEvents RbActive As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents RbSuspend As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents BtmDelete As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtmEdit As Guna.UI.WinForms.GunaButton
    Friend WithEvents DgDataCabang As DataGridView
End Class
