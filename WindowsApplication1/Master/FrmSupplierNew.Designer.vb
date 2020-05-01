<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSupplierNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSupplierNew))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNamaSupplier = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RbKaryawan = New Guna.UI.WinForms.GunaMediumRadioButton()
        Me.Karyawan = New Guna.UI.WinForms.GunaLabel()
        Me.RbPerusahaan = New Guna.UI.WinForms.GunaMediumRadioButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.TxtNpwp = New System.Windows.Forms.MaskedTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtmUpdate = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.BtmEdit = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BtmSave = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.DetailGroup = New Guna.UI.WinForms.GunaGroupBox()
        Me.RbBankSuspend = New Guna.UI.WinForms.GunaRadioButton()
        Me.RbBankActive = New Guna.UI.WinForms.GunaRadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.TxtRekName = New System.Windows.Forms.TextBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.TxtRekno = New System.Windows.Forms.TextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.CboBank = New System.Windows.Forms.ComboBox()
        Me.DataBank = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtKodeSupplier = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.DetailGroup.SuspendLayout()
        CType(Me.DataBank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode Supplier"
        '
        'TxtNamaSupplier
        '
        Me.TxtNamaSupplier.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNamaSupplier.Location = New System.Drawing.Point(296, 12)
        Me.TxtNamaSupplier.Name = "TxtNamaSupplier"
        Me.TxtNamaSupplier.Size = New System.Drawing.Size(161, 20)
        Me.TxtNamaSupplier.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(214, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama Supplier"
        '
        'RbKaryawan
        '
        Me.RbKaryawan.BaseColor = System.Drawing.Color.White
        Me.RbKaryawan.CheckedOffColor = System.Drawing.Color.Gray
        Me.RbKaryawan.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RbKaryawan.FillColor = System.Drawing.Color.White
        Me.RbKaryawan.Location = New System.Drawing.Point(82, 38)
        Me.RbKaryawan.Name = "RbKaryawan"
        Me.RbKaryawan.Size = New System.Drawing.Size(20, 20)
        Me.RbKaryawan.TabIndex = 5
        '
        'Karyawan
        '
        Me.Karyawan.AutoSize = True
        Me.Karyawan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Karyawan.Location = New System.Drawing.Point(102, 40)
        Me.Karyawan.Name = "Karyawan"
        Me.Karyawan.Size = New System.Drawing.Size(58, 15)
        Me.Karyawan.TabIndex = 6
        Me.Karyawan.Text = "Karyawan"
        '
        'RbPerusahaan
        '
        Me.RbPerusahaan.BaseColor = System.Drawing.Color.White
        Me.RbPerusahaan.CheckedOffColor = System.Drawing.Color.Gray
        Me.RbPerusahaan.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RbPerusahaan.FillColor = System.Drawing.Color.White
        Me.RbPerusahaan.Location = New System.Drawing.Point(82, 58)
        Me.RbPerusahaan.Name = "RbPerusahaan"
        Me.RbPerusahaan.Size = New System.Drawing.Size(20, 20)
        Me.RbPerusahaan.TabIndex = 7
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(102, 62)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(68, 15)
        Me.GunaLabel1.TabIndex = 8
        Me.GunaLabel1.Text = "Perusahaan"
        '
        'TxtNpwp
        '
        Me.TxtNpwp.Location = New System.Drawing.Point(296, 42)
        Me.TxtNpwp.Mask = "00.000.000.0-000.000"
        Me.TxtNpwp.Name = "TxtNpwp"
        Me.TxtNpwp.Size = New System.Drawing.Size(161, 20)
        Me.TxtNpwp.TabIndex = 9
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(214, 47)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(41, 15)
        Me.GunaLabel2.TabIndex = 10
        Me.GunaLabel2.Text = "NPWP"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(214, 70)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(39, 15)
        Me.GunaLabel3.TabIndex = 13
        Me.GunaLabel3.Text = "Status"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtmUpdate)
        Me.GroupBox1.Controls.Add(Me.GunaButton1)
        Me.GroupBox1.Controls.Add(Me.BtmEdit)
        Me.GroupBox1.Controls.Add(Me.BtmSave)
        Me.GroupBox1.Location = New System.Drawing.Point(463, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(212, 94)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'BtmUpdate
        '
        Me.BtmUpdate.AnimationHoverSpeed = 0.07!
        Me.BtmUpdate.AnimationSpeed = 0.03!
        Me.BtmUpdate.BaseColor = System.Drawing.Color.OrangeRed
        Me.BtmUpdate.BorderColor = System.Drawing.Color.Black
        Me.BtmUpdate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtmUpdate.FocusedColor = System.Drawing.Color.Empty
        Me.BtmUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtmUpdate.ForeColor = System.Drawing.Color.White
        Me.BtmUpdate.Image = CType(resources.GetObject("BtmUpdate.Image"), System.Drawing.Image)
        Me.BtmUpdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BtmUpdate.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtmUpdate.Location = New System.Drawing.Point(6, 52)
        Me.BtmUpdate.Name = "BtmUpdate"
        Me.BtmUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtmUpdate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtmUpdate.OnHoverForeColor = System.Drawing.Color.White
        Me.BtmUpdate.OnHoverImage = Nothing
        Me.BtmUpdate.OnPressedColor = System.Drawing.Color.Black
        Me.BtmUpdate.Size = New System.Drawing.Size(98, 34)
        Me.BtmUpdate.TabIndex = 18
        Me.BtmUpdate.Text = "Update"
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.Goldenrod
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = CType(resources.GetObject("GunaButton1.Image"), System.Drawing.Image)
        Me.GunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.GunaButton1.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton1.Location = New System.Drawing.Point(110, 11)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.Bisque
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(98, 35)
        Me.GunaButton1.TabIndex = 17
        Me.GunaButton1.Text = "Open"
        '
        'BtmEdit
        '
        Me.BtmEdit.AnimationHoverSpeed = 0.07!
        Me.BtmEdit.AnimationSpeed = 0.03!
        Me.BtmEdit.BaseColor = System.Drawing.Color.Crimson
        Me.BtmEdit.BorderColor = System.Drawing.Color.Black
        Me.BtmEdit.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BtmEdit.CheckedBorderColor = System.Drawing.Color.Black
        Me.BtmEdit.CheckedForeColor = System.Drawing.Color.White
        Me.BtmEdit.CheckedImage = CType(resources.GetObject("BtmEdit.CheckedImage"), System.Drawing.Image)
        Me.BtmEdit.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BtmEdit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtmEdit.FocusedColor = System.Drawing.Color.Empty
        Me.BtmEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtmEdit.ForeColor = System.Drawing.Color.White
        Me.BtmEdit.Image = CType(resources.GetObject("BtmEdit.Image"), System.Drawing.Image)
        Me.BtmEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BtmEdit.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtmEdit.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtmEdit.Location = New System.Drawing.Point(110, 51)
        Me.BtmEdit.Name = "BtmEdit"
        Me.BtmEdit.OnHoverBaseColor = System.Drawing.Color.LightPink
        Me.BtmEdit.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtmEdit.OnHoverForeColor = System.Drawing.Color.White
        Me.BtmEdit.OnHoverImage = Nothing
        Me.BtmEdit.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtmEdit.OnPressedColor = System.Drawing.Color.Black
        Me.BtmEdit.Size = New System.Drawing.Size(98, 35)
        Me.BtmEdit.TabIndex = 16
        Me.BtmEdit.Text = "Edit"
        '
        'BtmSave
        '
        Me.BtmSave.AnimationHoverSpeed = 0.07!
        Me.BtmSave.AnimationSpeed = 0.03!
        Me.BtmSave.BaseColor = System.Drawing.Color.LightSeaGreen
        Me.BtmSave.BorderColor = System.Drawing.Color.Black
        Me.BtmSave.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BtmSave.CheckedBorderColor = System.Drawing.Color.Black
        Me.BtmSave.CheckedForeColor = System.Drawing.Color.White
        Me.BtmSave.CheckedImage = CType(resources.GetObject("BtmSave.CheckedImage"), System.Drawing.Image)
        Me.BtmSave.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BtmSave.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtmSave.FocusedColor = System.Drawing.Color.Empty
        Me.BtmSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtmSave.ForeColor = System.Drawing.Color.White
        Me.BtmSave.Image = CType(resources.GetObject("BtmSave.Image"), System.Drawing.Image)
        Me.BtmSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BtmSave.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtmSave.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtmSave.Location = New System.Drawing.Point(6, 11)
        Me.BtmSave.Name = "BtmSave"
        Me.BtmSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtmSave.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtmSave.OnHoverForeColor = System.Drawing.Color.White
        Me.BtmSave.OnHoverImage = Nothing
        Me.BtmSave.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtmSave.OnPressedColor = System.Drawing.Color.Black
        Me.BtmSave.Size = New System.Drawing.Size(98, 35)
        Me.BtmSave.TabIndex = 15
        Me.BtmSave.Text = "Simpan"
        '
        'DetailGroup
        '
        Me.DetailGroup.BackColor = System.Drawing.Color.Transparent
        Me.DetailGroup.BaseColor = System.Drawing.Color.White
        Me.DetailGroup.BorderColor = System.Drawing.Color.Gainsboro
        Me.DetailGroup.Controls.Add(Me.RbBankSuspend)
        Me.DetailGroup.Controls.Add(Me.RbBankActive)
        Me.DetailGroup.Controls.Add(Me.Button2)
        Me.DetailGroup.Controls.Add(Me.GunaLabel7)
        Me.DetailGroup.Controls.Add(Me.Button1)
        Me.DetailGroup.Controls.Add(Me.GunaLabel6)
        Me.DetailGroup.Controls.Add(Me.TxtRekName)
        Me.DetailGroup.Controls.Add(Me.GunaLabel5)
        Me.DetailGroup.Controls.Add(Me.TxtRekno)
        Me.DetailGroup.Controls.Add(Me.GunaLabel4)
        Me.DetailGroup.Controls.Add(Me.CboBank)
        Me.DetailGroup.Controls.Add(Me.DataBank)
        Me.DetailGroup.LineColor = System.Drawing.Color.Gainsboro
        Me.DetailGroup.Location = New System.Drawing.Point(13, 105)
        Me.DetailGroup.Name = "DetailGroup"
        Me.DetailGroup.Size = New System.Drawing.Size(662, 350)
        Me.DetailGroup.TabIndex = 15
        Me.DetailGroup.Text = "Data Bank Supplier"
        Me.DetailGroup.TextLocation = New System.Drawing.Point(10, 8)
        '
        'RbBankSuspend
        '
        Me.RbBankSuspend.BaseColor = System.Drawing.SystemColors.Control
        Me.RbBankSuspend.CheckedOffColor = System.Drawing.Color.Gray
        Me.RbBankSuspend.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RbBankSuspend.FillColor = System.Drawing.Color.White
        Me.RbBankSuspend.Location = New System.Drawing.Point(375, 65)
        Me.RbBankSuspend.Name = "RbBankSuspend"
        Me.RbBankSuspend.Size = New System.Drawing.Size(74, 20)
        Me.RbBankSuspend.TabIndex = 21
        Me.RbBankSuspend.Text = "Suspend"
        '
        'RbBankActive
        '
        Me.RbBankActive.BaseColor = System.Drawing.SystemColors.Control
        Me.RbBankActive.CheckedOffColor = System.Drawing.Color.Gray
        Me.RbBankActive.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RbBankActive.FillColor = System.Drawing.Color.White
        Me.RbBankActive.Location = New System.Drawing.Point(307, 66)
        Me.RbBankActive.Name = "RbBankActive"
        Me.RbBankActive.Size = New System.Drawing.Size(61, 20)
        Me.RbBankActive.TabIndex = 20
        Me.RbBankActive.Text = "Active"
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(494, 61)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(161, 24)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel7.Location = New System.Drawing.Point(238, 66)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(39, 15)
        Me.GunaLabel7.TabIndex = 17
        Me.GunaLabel7.Text = "Status"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(494, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 24)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel6.Location = New System.Drawing.Point(236, 38)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(65, 15)
        Me.GunaLabel6.TabIndex = 15
        Me.GunaLabel6.Text = "Atas Nama"
        '
        'TxtRekName
        '
        Me.TxtRekName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRekName.Location = New System.Drawing.Point(307, 36)
        Me.TxtRekName.Name = "TxtRekName"
        Me.TxtRekName.Size = New System.Drawing.Size(164, 20)
        Me.TxtRekName.TabIndex = 14
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel5.Location = New System.Drawing.Point(10, 66)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(45, 15)
        Me.GunaLabel5.TabIndex = 13
        Me.GunaLabel5.Text = "No.Rek"
        '
        'TxtRekno
        '
        Me.TxtRekno.Location = New System.Drawing.Point(84, 64)
        Me.TxtRekno.Name = "TxtRekno"
        Me.TxtRekno.Size = New System.Drawing.Size(146, 20)
        Me.TxtRekno.TabIndex = 12
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel4.Location = New System.Drawing.Point(10, 38)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(68, 15)
        Me.GunaLabel4.TabIndex = 11
        Me.GunaLabel4.Text = "Nama Bank"
        '
        'CboBank
        '
        Me.CboBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBank.FormattingEnabled = True
        Me.CboBank.Location = New System.Drawing.Point(84, 36)
        Me.CboBank.Name = "CboBank"
        Me.CboBank.Size = New System.Drawing.Size(146, 21)
        Me.CboBank.TabIndex = 1
        '
        'DataBank
        '
        Me.DataBank.AllowUserToAddRows = False
        Me.DataBank.AllowUserToDeleteRows = False
        Me.DataBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataBank.Location = New System.Drawing.Point(13, 90)
        Me.DataBank.Name = "DataBank"
        Me.DataBank.ReadOnly = True
        Me.DataBank.Size = New System.Drawing.Size(645, 245)
        Me.DataBank.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Tipe Supplier"
        '
        'TxtKodeSupplier
        '
        Me.TxtKodeSupplier.Enabled = False
        Me.TxtKodeSupplier.Location = New System.Drawing.Point(81, 10)
        Me.TxtKodeSupplier.Name = "TxtKodeSupplier"
        Me.TxtKodeSupplier.Size = New System.Drawing.Size(127, 20)
        Me.TxtKodeSupplier.TabIndex = 17
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Active", "Suspend"})
        Me.ComboBox1.Location = New System.Drawing.Point(296, 70)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(161, 21)
        Me.ComboBox1.TabIndex = 18
        '
        'FrmSupplierNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 468)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TxtKodeSupplier)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DetailGroup)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.TxtNpwp)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.RbPerusahaan)
        Me.Controls.Add(Me.Karyawan)
        Me.Controls.Add(Me.RbKaryawan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNamaSupplier)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSupplierNew"
        Me.Text = "Input Master Supplier"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.DetailGroup.ResumeLayout(False)
        Me.DetailGroup.PerformLayout()
        CType(Me.DataBank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNamaSupplier As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RbKaryawan As Guna.UI.WinForms.GunaMediumRadioButton
    Friend WithEvents Karyawan As Guna.UI.WinForms.GunaLabel
    Friend WithEvents RbPerusahaan As Guna.UI.WinForms.GunaMediumRadioButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TxtNpwp As MaskedTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtmEdit As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents BtmSave As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents DetailGroup As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TxtRekName As TextBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TxtRekno As TextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents CboBank As ComboBox
    Friend WithEvents DataBank As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtKodeSupplier As TextBox
    Friend WithEvents RbBankSuspend As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents RbBankActive As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtmUpdate As Guna.UI.WinForms.GunaButton
    Friend WithEvents ComboBox1 As ComboBox
End Class
