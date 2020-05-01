<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPuBs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPuBs))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDocNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TglDoc = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboDivisi = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtKodeSupplier = New System.Windows.Forms.TextBox()
        Me.CboRekSup = New System.Windows.Forms.ComboBox()
        Me.CboBankSupp = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboSupplier = New System.Windows.Forms.ComboBox()
        Me.TglDibutuhkan = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtNoPUBS = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CmdSimpan = New Guna.UI.WinForms.GunaButton()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.DgDataDtl = New System.Windows.Forms.DataGridView()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaDateTimePicker1 = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.TxtFakturPajak = New System.Windows.Forms.MaskedTextBox()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TxtPPH = New System.Windows.Forms.TextBox()
        Me.TxtPPN = New System.Windows.Forms.TextBox()
        Me.CmdDelete = New Guna.UI.WinForms.GunaButton()
        Me.CmdAdd = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.chkppn = New Guna.UI.WinForms.GunaMediumCheckBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.chkpph = New Guna.UI.WinForms.GunaMediumCheckBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.CboCabang = New Guna.UI.WinForms.GunaComboBox()
        Me.TxtKeterangan = New System.Windows.Forms.RichTextBox()
        Me.TxtNominalInvoice = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.TglInvoice = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.TxtNoInvoice = New Guna.UI.WinForms.GunaTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CmdPosting = New Guna.UI.WinForms.GunaButton()
        Me.CmdPrint = New Guna.UI.WinForms.GunaButton()
        Me.CmdUpdate = New Guna.UI.WinForms.GunaButton()
        Me.CmdOpen = New Guna.UI.WinForms.GunaButton()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.RbPU = New Guna.UI.WinForms.GunaRadioButton()
        Me.RbBS = New Guna.UI.WinForms.GunaRadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TxtGrandTotal = New System.Windows.Forms.TextBox()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.TxtTotalPPH = New System.Windows.Forms.TextBox()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.TxtTotalPPN = New System.Windows.Forms.TextBox()
        Me.GunaLabel12 = New Guna.UI.WinForms.GunaLabel()
        Me.TxtTerbilang = New System.Windows.Forms.TextBox()
        Me.GunaLabel13 = New Guna.UI.WinForms.GunaLabel()
        Me.TxtKodeCabang = New System.Windows.Forms.TextBox()
        Me.txtGTotal = New System.Windows.Forms.TextBox()
        Me.GunaLabel14 = New Guna.UI.WinForms.GunaLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GunaGroupBox1.SuspendLayout()
        CType(Me.DgDataDtl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipe Dokumen"
        '
        'TxtDocNo
        '
        Me.TxtDocNo.Enabled = False
        Me.TxtDocNo.Location = New System.Drawing.Point(330, 40)
        Me.TxtDocNo.Name = "TxtDocNo"
        Me.TxtDocNo.Size = New System.Drawing.Size(161, 20)
        Me.TxtDocNo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(247, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "No.Dokumen"
        '
        'TglDoc
        '
        Me.TglDoc.CustomFormat = "dd/MM/yyyy"
        Me.TglDoc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TglDoc.Location = New System.Drawing.Point(330, 14)
        Me.TglDoc.Name = "TglDoc"
        Me.TglDoc.Size = New System.Drawing.Size(161, 20)
        Me.TglDoc.TabIndex = 4
        Me.TglDoc.Value = New Date(2020, 10, 3, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(247, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tanggal PU/BS"
        '
        'CboDivisi
        '
        Me.CboDivisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboDivisi.FormattingEnabled = True
        Me.CboDivisi.Location = New System.Drawing.Point(96, 65)
        Me.CboDivisi.Name = "CboDivisi"
        Me.CboDivisi.Size = New System.Drawing.Size(138, 21)
        Me.CboDivisi.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Divisi"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TxtKodeSupplier)
        Me.GroupBox1.Controls.Add(Me.CboRekSup)
        Me.GroupBox1.Controls.Add(Me.CboBankSupp)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CboSupplier)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 101)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informasi Pembayaran"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Kode"
        '
        'TxtKodeSupplier
        '
        Me.TxtKodeSupplier.Enabled = False
        Me.TxtKodeSupplier.Location = New System.Drawing.Point(57, 52)
        Me.TxtKodeSupplier.Name = "TxtKodeSupplier"
        Me.TxtKodeSupplier.Size = New System.Drawing.Size(138, 20)
        Me.TxtKodeSupplier.TabIndex = 18
        '
        'CboRekSup
        '
        Me.CboRekSup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboRekSup.FormattingEnabled = True
        Me.CboRekSup.Location = New System.Drawing.Point(296, 48)
        Me.CboRekSup.Name = "CboRekSup"
        Me.CboRekSup.Size = New System.Drawing.Size(160, 21)
        Me.CboRekSup.TabIndex = 17
        '
        'CboBankSupp
        '
        Me.CboBankSupp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBankSupp.FormattingEnabled = True
        Me.CboBankSupp.Location = New System.Drawing.Point(296, 22)
        Me.CboBankSupp.Name = "CboBankSupp"
        Me.CboBankSupp.Size = New System.Drawing.Size(160, 21)
        Me.CboBankSupp.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(201, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Nama Bank"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(201, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Nomor Rekening"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Supplier"
        '
        'CboSupplier
        '
        Me.CboSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSupplier.FormattingEnabled = True
        Me.CboSupplier.Location = New System.Drawing.Point(57, 25)
        Me.CboSupplier.Name = "CboSupplier"
        Me.CboSupplier.Size = New System.Drawing.Size(138, 21)
        Me.CboSupplier.TabIndex = 10
        '
        'TglDibutuhkan
        '
        Me.TglDibutuhkan.CustomFormat = "dd/MM/yyyy"
        Me.TglDibutuhkan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TglDibutuhkan.Location = New System.Drawing.Point(98, 92)
        Me.TglDibutuhkan.Name = "TglDibutuhkan"
        Me.TglDibutuhkan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TglDibutuhkan.Size = New System.Drawing.Size(138, 20)
        Me.TglDibutuhkan.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Tgl.Dibutuhkan"
        '
        'TxtNoPUBS
        '
        Me.TxtNoPUBS.Location = New System.Drawing.Point(330, 64)
        Me.TxtNoPUBS.Mask = "BS/00000/AAA-AAAA/AAA/0000"
        Me.TxtNoPUBS.Name = "TxtNoPUBS"
        Me.TxtNoPUBS.Size = New System.Drawing.Size(161, 20)
        Me.TxtNoPUBS.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(247, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "No.PU/BS"
        '
        'CmdSimpan
        '
        Me.CmdSimpan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdSimpan.AnimationHoverSpeed = 0.07!
        Me.CmdSimpan.AnimationSpeed = 0.03!
        Me.CmdSimpan.BaseColor = System.Drawing.Color.ForestGreen
        Me.CmdSimpan.BorderColor = System.Drawing.Color.Black
        Me.CmdSimpan.DialogResult = System.Windows.Forms.DialogResult.None
        Me.CmdSimpan.FocusedColor = System.Drawing.Color.Empty
        Me.CmdSimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CmdSimpan.ForeColor = System.Drawing.Color.White
        Me.CmdSimpan.Image = CType(resources.GetObject("CmdSimpan.Image"), System.Drawing.Image)
        Me.CmdSimpan.ImageSize = New System.Drawing.Size(25, 25)
        Me.CmdSimpan.Location = New System.Drawing.Point(6, 14)
        Me.CmdSimpan.Name = "CmdSimpan"
        Me.CmdSimpan.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdSimpan.OnHoverBorderColor = System.Drawing.Color.Black
        Me.CmdSimpan.OnHoverForeColor = System.Drawing.Color.White
        Me.CmdSimpan.OnHoverImage = Nothing
        Me.CmdSimpan.OnPressedColor = System.Drawing.Color.Black
        Me.CmdSimpan.Size = New System.Drawing.Size(90, 84)
        Me.CmdSimpan.TabIndex = 20
        Me.CmdSimpan.Text = "Simpan"
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.DgDataDtl)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel9)
        Me.GunaGroupBox1.Controls.Add(Me.GunaDateTimePicker1)
        Me.GunaGroupBox1.Controls.Add(Me.TxtFakturPajak)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel8)
        Me.GunaGroupBox1.Controls.Add(Me.Label12)
        Me.GunaGroupBox1.Controls.Add(Me.TextBox2)
        Me.GunaGroupBox1.Controls.Add(Me.TxtPPH)
        Me.GunaGroupBox1.Controls.Add(Me.TxtPPN)
        Me.GunaGroupBox1.Controls.Add(Me.CmdDelete)
        Me.GunaGroupBox1.Controls.Add(Me.CmdAdd)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel7)
        Me.GunaGroupBox1.Controls.Add(Me.chkppn)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel6)
        Me.GunaGroupBox1.Controls.Add(Me.chkpph)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel5)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel4)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel3)
        Me.GunaGroupBox1.Controls.Add(Me.CboCabang)
        Me.GunaGroupBox1.Controls.Add(Me.TxtKeterangan)
        Me.GunaGroupBox1.Controls.Add(Me.TxtNominalInvoice)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel2)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel1)
        Me.GunaGroupBox1.Controls.Add(Me.TglInvoice)
        Me.GunaGroupBox1.Controls.Add(Me.TxtNoInvoice)
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Location = New System.Drawing.Point(15, 240)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(682, 328)
        Me.GunaGroupBox1.TabIndex = 21
        Me.GunaGroupBox1.Text = "Detail Transaksi"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'DgDataDtl
        '
        Me.DgDataDtl.AllowUserToAddRows = False
        Me.DgDataDtl.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgDataDtl.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgDataDtl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgDataDtl.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgDataDtl.Location = New System.Drawing.Point(9, 181)
        Me.DgDataDtl.Name = "DgDataDtl"
        Me.DgDataDtl.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgDataDtl.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgDataDtl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgDataDtl.Size = New System.Drawing.Size(670, 133)
        Me.DgDataDtl.TabIndex = 31
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel9.Location = New System.Drawing.Point(190, 83)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(92, 15)
        Me.GunaLabel9.TabIndex = 27
        Me.GunaLabel9.Text = "Tgl. Faktur Pajak"
        '
        'GunaDateTimePicker1
        '
        Me.GunaDateTimePicker1.BaseColor = System.Drawing.Color.White
        Me.GunaDateTimePicker1.BorderColor = System.Drawing.Color.Silver
        Me.GunaDateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.GunaDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.GunaDateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaDateTimePicker1.ForeColor = System.Drawing.Color.Black
        Me.GunaDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.GunaDateTimePicker1.Location = New System.Drawing.Point(189, 101)
        Me.GunaDateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.GunaDateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.GunaDateTimePicker1.Name = "GunaDateTimePicker1"
        Me.GunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White
        Me.GunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDateTimePicker1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaDateTimePicker1.Size = New System.Drawing.Size(141, 24)
        Me.GunaDateTimePicker1.TabIndex = 26
        Me.GunaDateTimePicker1.Text = "29/04/2020"
        Me.GunaDateTimePicker1.Value = New Date(2020, 4, 29, 0, 0, 0, 0)
        '
        'TxtFakturPajak
        '
        Me.TxtFakturPajak.Location = New System.Drawing.Point(12, 101)
        Me.TxtFakturPajak.Mask = "000.000-00.00000000"
        Me.TxtFakturPajak.Name = "TxtFakturPajak"
        Me.TxtFakturPajak.Size = New System.Drawing.Size(171, 20)
        Me.TxtFakturPajak.TabIndex = 25
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel8.Location = New System.Drawing.Point(9, 83)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(90, 15)
        Me.GunaLabel8.TabIndex = 24
        Me.GunaLabel8.Text = "No.Faktur Pajak"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(499, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Sub Total"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(558, 85)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(124, 20)
        Me.TextBox2.TabIndex = 21
        '
        'TxtPPH
        '
        Me.TxtPPH.Enabled = False
        Me.TxtPPH.Location = New System.Drawing.Point(581, 34)
        Me.TxtPPH.Name = "TxtPPH"
        Me.TxtPPH.Size = New System.Drawing.Size(99, 20)
        Me.TxtPPH.TabIndex = 20
        '
        'TxtPPN
        '
        Me.TxtPPN.Enabled = False
        Me.TxtPPN.Location = New System.Drawing.Point(580, 59)
        Me.TxtPPN.Name = "TxtPPN"
        Me.TxtPPN.Size = New System.Drawing.Size(99, 20)
        Me.TxtPPN.TabIndex = 19
        '
        'CmdDelete
        '
        Me.CmdDelete.AnimationHoverSpeed = 0.07!
        Me.CmdDelete.AnimationSpeed = 0.03!
        Me.CmdDelete.BaseColor = System.Drawing.Color.Maroon
        Me.CmdDelete.BorderColor = System.Drawing.Color.Black
        Me.CmdDelete.DialogResult = System.Windows.Forms.DialogResult.None
        Me.CmdDelete.FocusedColor = System.Drawing.Color.Empty
        Me.CmdDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CmdDelete.ForeColor = System.Drawing.Color.White
        Me.CmdDelete.Image = CType(resources.GetObject("CmdDelete.Image"), System.Drawing.Image)
        Me.CmdDelete.ImageSize = New System.Drawing.Size(20, 20)
        Me.CmdDelete.Location = New System.Drawing.Point(558, 142)
        Me.CmdDelete.Name = "CmdDelete"
        Me.CmdDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdDelete.OnHoverBorderColor = System.Drawing.Color.Black
        Me.CmdDelete.OnHoverForeColor = System.Drawing.Color.White
        Me.CmdDelete.OnHoverImage = Nothing
        Me.CmdDelete.OnPressedColor = System.Drawing.Color.Black
        Me.CmdDelete.Size = New System.Drawing.Size(124, 27)
        Me.CmdDelete.TabIndex = 16
        Me.CmdDelete.Text = "Hapus"
        '
        'CmdAdd
        '
        Me.CmdAdd.AnimationHoverSpeed = 0.07!
        Me.CmdAdd.AnimationSpeed = 0.03!
        Me.CmdAdd.BaseColor = System.Drawing.Color.DarkSlateGray
        Me.CmdAdd.BorderColor = System.Drawing.Color.Black
        Me.CmdAdd.DialogResult = System.Windows.Forms.DialogResult.None
        Me.CmdAdd.FocusedColor = System.Drawing.Color.Empty
        Me.CmdAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CmdAdd.ForeColor = System.Drawing.Color.White
        Me.CmdAdd.Image = CType(resources.GetObject("CmdAdd.Image"), System.Drawing.Image)
        Me.CmdAdd.ImageSize = New System.Drawing.Size(25, 25)
        Me.CmdAdd.Location = New System.Drawing.Point(558, 109)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdAdd.OnHoverBorderColor = System.Drawing.Color.Black
        Me.CmdAdd.OnHoverForeColor = System.Drawing.Color.White
        Me.CmdAdd.OnHoverImage = Nothing
        Me.CmdAdd.OnPressedColor = System.Drawing.Color.Black
        Me.CmdAdd.Size = New System.Drawing.Size(124, 27)
        Me.CmdAdd.TabIndex = 14
        Me.CmdAdd.Text = "Tambah"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel7.Location = New System.Drawing.Point(525, 65)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(55, 15)
        Me.GunaLabel7.TabIndex = 13
        Me.GunaLabel7.Text = "PPN 10%"
        '
        'chkppn
        '
        Me.chkppn.BaseColor = System.Drawing.Color.White
        Me.chkppn.CheckedOffColor = System.Drawing.Color.Gray
        Me.chkppn.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkppn.FillColor = System.Drawing.Color.White
        Me.chkppn.Location = New System.Drawing.Point(506, 62)
        Me.chkppn.Name = "chkppn"
        Me.chkppn.Size = New System.Drawing.Size(20, 20)
        Me.chkppn.TabIndex = 12
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel6.Location = New System.Drawing.Point(524, 39)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(49, 15)
        Me.GunaLabel6.TabIndex = 11
        Me.GunaLabel6.Text = "PPH 2%"
        '
        'chkpph
        '
        Me.chkpph.BaseColor = System.Drawing.Color.White
        Me.chkpph.CheckedOffColor = System.Drawing.Color.Gray
        Me.chkpph.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkpph.FillColor = System.Drawing.Color.White
        Me.chkpph.Location = New System.Drawing.Point(506, 36)
        Me.chkpph.Name = "chkpph"
        Me.chkpph.Size = New System.Drawing.Size(20, 20)
        Me.chkpph.TabIndex = 10
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel5.Location = New System.Drawing.Point(335, 85)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(94, 15)
        Me.GunaLabel5.TabIndex = 9
        Me.GunaLabel5.Text = "Nominal Invoice"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel4.Location = New System.Drawing.Point(116, 142)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(67, 15)
        Me.GunaLabel4.TabIndex = 8
        Me.GunaLabel4.Text = "Keterangan"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(9, 36)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(48, 15)
        Me.GunaLabel3.TabIndex = 7
        Me.GunaLabel3.Text = "Cabang"
        '
        'CboCabang
        '
        Me.CboCabang.BackColor = System.Drawing.Color.Transparent
        Me.CboCabang.BaseColor = System.Drawing.Color.White
        Me.CboCabang.BorderColor = System.Drawing.Color.Silver
        Me.CboCabang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CboCabang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCabang.FocusedColor = System.Drawing.Color.Empty
        Me.CboCabang.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CboCabang.ForeColor = System.Drawing.Color.Black
        Me.CboCabang.FormattingEnabled = True
        Me.CboCabang.Location = New System.Drawing.Point(12, 54)
        Me.CboCabang.Name = "CboCabang"
        Me.CboCabang.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CboCabang.OnHoverItemForeColor = System.Drawing.Color.White
        Me.CboCabang.Size = New System.Drawing.Size(171, 26)
        Me.CboCabang.TabIndex = 6
        '
        'TxtKeterangan
        '
        Me.TxtKeterangan.Location = New System.Drawing.Point(189, 131)
        Me.TxtKeterangan.Name = "TxtKeterangan"
        Me.TxtKeterangan.Size = New System.Drawing.Size(311, 44)
        Me.TxtKeterangan.TabIndex = 5
        Me.TxtKeterangan.Text = ""
        '
        'TxtNominalInvoice
        '
        Me.TxtNominalInvoice.BaseColor = System.Drawing.Color.White
        Me.TxtNominalInvoice.BorderColor = System.Drawing.Color.Silver
        Me.TxtNominalInvoice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNominalInvoice.FocusedBaseColor = System.Drawing.Color.White
        Me.TxtNominalInvoice.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtNominalInvoice.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtNominalInvoice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtNominalInvoice.Location = New System.Drawing.Point(336, 101)
        Me.TxtNominalInvoice.Name = "TxtNominalInvoice"
        Me.TxtNominalInvoice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtNominalInvoice.Size = New System.Drawing.Size(164, 26)
        Me.TxtNominalInvoice.TabIndex = 4
        Me.TxtNominalInvoice.Text = "0"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(355, 36)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(89, 15)
        Me.GunaLabel2.TabIndex = 3
        Me.GunaLabel2.Text = "Tanggal Invoice"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(186, 36)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(86, 15)
        Me.GunaLabel1.TabIndex = 2
        Me.GunaLabel1.Text = "Nomor Invoice"
        '
        'TglInvoice
        '
        Me.TglInvoice.BaseColor = System.Drawing.Color.White
        Me.TglInvoice.BorderColor = System.Drawing.Color.Silver
        Me.TglInvoice.CustomFormat = "dd/MM/yyyy"
        Me.TglInvoice.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.TglInvoice.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TglInvoice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TglInvoice.ForeColor = System.Drawing.Color.Black
        Me.TglInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TglInvoice.Location = New System.Drawing.Point(358, 54)
        Me.TglInvoice.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TglInvoice.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.TglInvoice.Name = "TglInvoice"
        Me.TglInvoice.OnHoverBaseColor = System.Drawing.Color.White
        Me.TglInvoice.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TglInvoice.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TglInvoice.OnPressedColor = System.Drawing.Color.Black
        Me.TglInvoice.Size = New System.Drawing.Size(142, 26)
        Me.TglInvoice.TabIndex = 1
        Me.TglInvoice.Text = "04/04/2020"
        Me.TglInvoice.Value = New Date(2020, 4, 4, 17, 53, 25, 984)
        '
        'TxtNoInvoice
        '
        Me.TxtNoInvoice.BaseColor = System.Drawing.Color.White
        Me.TxtNoInvoice.BorderColor = System.Drawing.Color.Silver
        Me.TxtNoInvoice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNoInvoice.FocusedBaseColor = System.Drawing.Color.White
        Me.TxtNoInvoice.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtNoInvoice.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtNoInvoice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtNoInvoice.Location = New System.Drawing.Point(189, 54)
        Me.TxtNoInvoice.Name = "TxtNoInvoice"
        Me.TxtNoInvoice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtNoInvoice.Size = New System.Drawing.Size(163, 26)
        Me.TxtNoInvoice.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmdPosting)
        Me.GroupBox2.Controls.Add(Me.CmdPrint)
        Me.GroupBox2.Controls.Add(Me.CmdUpdate)
        Me.GroupBox2.Controls.Add(Me.CmdOpen)
        Me.GroupBox2.Controls.Add(Me.CmdSimpan)
        Me.GroupBox2.Location = New System.Drawing.Point(497, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 207)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'CmdPosting
        '
        Me.CmdPosting.AnimationHoverSpeed = 0.07!
        Me.CmdPosting.AnimationSpeed = 0.03!
        Me.CmdPosting.BaseColor = System.Drawing.Color.DarkRed
        Me.CmdPosting.BorderColor = System.Drawing.Color.Black
        Me.CmdPosting.DialogResult = System.Windows.Forms.DialogResult.None
        Me.CmdPosting.FocusedColor = System.Drawing.Color.Empty
        Me.CmdPosting.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CmdPosting.ForeColor = System.Drawing.Color.White
        Me.CmdPosting.Image = CType(resources.GetObject("CmdPosting.Image"), System.Drawing.Image)
        Me.CmdPosting.ImageSize = New System.Drawing.Size(25, 25)
        Me.CmdPosting.Location = New System.Drawing.Point(6, 154)
        Me.CmdPosting.Name = "CmdPosting"
        Me.CmdPosting.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdPosting.OnHoverBorderColor = System.Drawing.Color.Black
        Me.CmdPosting.OnHoverForeColor = System.Drawing.Color.White
        Me.CmdPosting.OnHoverImage = Nothing
        Me.CmdPosting.OnPressedColor = System.Drawing.Color.Black
        Me.CmdPosting.Size = New System.Drawing.Size(188, 42)
        Me.CmdPosting.TabIndex = 24
        Me.CmdPosting.Text = "Posting PU/BS"
        '
        'CmdPrint
        '
        Me.CmdPrint.AnimationHoverSpeed = 0.07!
        Me.CmdPrint.AnimationSpeed = 0.03!
        Me.CmdPrint.BaseColor = System.Drawing.Color.SaddleBrown
        Me.CmdPrint.BorderColor = System.Drawing.Color.Black
        Me.CmdPrint.DialogResult = System.Windows.Forms.DialogResult.None
        Me.CmdPrint.FocusedColor = System.Drawing.Color.Empty
        Me.CmdPrint.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CmdPrint.ForeColor = System.Drawing.Color.White
        Me.CmdPrint.Image = CType(resources.GetObject("CmdPrint.Image"), System.Drawing.Image)
        Me.CmdPrint.ImageSize = New System.Drawing.Size(25, 25)
        Me.CmdPrint.Location = New System.Drawing.Point(6, 106)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdPrint.OnHoverBorderColor = System.Drawing.Color.Black
        Me.CmdPrint.OnHoverForeColor = System.Drawing.Color.White
        Me.CmdPrint.OnHoverImage = Nothing
        Me.CmdPrint.OnPressedColor = System.Drawing.Color.Black
        Me.CmdPrint.Size = New System.Drawing.Size(188, 42)
        Me.CmdPrint.TabIndex = 23
        Me.CmdPrint.Text = "Cetak PU/BS"
        '
        'CmdUpdate
        '
        Me.CmdUpdate.AnimationHoverSpeed = 0.07!
        Me.CmdUpdate.AnimationSpeed = 0.03!
        Me.CmdUpdate.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdUpdate.BorderColor = System.Drawing.Color.Black
        Me.CmdUpdate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.CmdUpdate.FocusedColor = System.Drawing.Color.Empty
        Me.CmdUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CmdUpdate.ForeColor = System.Drawing.Color.White
        Me.CmdUpdate.Image = CType(resources.GetObject("CmdUpdate.Image"), System.Drawing.Image)
        Me.CmdUpdate.ImageSize = New System.Drawing.Size(25, 25)
        Me.CmdUpdate.Location = New System.Drawing.Point(104, 59)
        Me.CmdUpdate.Name = "CmdUpdate"
        Me.CmdUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdUpdate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.CmdUpdate.OnHoverForeColor = System.Drawing.Color.White
        Me.CmdUpdate.OnHoverImage = Nothing
        Me.CmdUpdate.OnPressedColor = System.Drawing.Color.Black
        Me.CmdUpdate.Size = New System.Drawing.Size(90, 39)
        Me.CmdUpdate.TabIndex = 22
        Me.CmdUpdate.Text = "Update"
        '
        'CmdOpen
        '
        Me.CmdOpen.AnimationHoverSpeed = 0.07!
        Me.CmdOpen.AnimationSpeed = 0.03!
        Me.CmdOpen.BaseColor = System.Drawing.Color.DarkOrange
        Me.CmdOpen.BorderColor = System.Drawing.Color.Black
        Me.CmdOpen.DialogResult = System.Windows.Forms.DialogResult.None
        Me.CmdOpen.FocusedColor = System.Drawing.Color.Empty
        Me.CmdOpen.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CmdOpen.ForeColor = System.Drawing.Color.White
        Me.CmdOpen.Image = CType(resources.GetObject("CmdOpen.Image"), System.Drawing.Image)
        Me.CmdOpen.ImageSize = New System.Drawing.Size(25, 25)
        Me.CmdOpen.Location = New System.Drawing.Point(105, 14)
        Me.CmdOpen.Name = "CmdOpen"
        Me.CmdOpen.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdOpen.OnHoverBorderColor = System.Drawing.Color.Black
        Me.CmdOpen.OnHoverForeColor = System.Drawing.Color.White
        Me.CmdOpen.OnHoverImage = Nothing
        Me.CmdOpen.OnPressedColor = System.Drawing.Color.Black
        Me.CmdOpen.Size = New System.Drawing.Size(89, 39)
        Me.CmdOpen.TabIndex = 21
        Me.CmdOpen.Text = "Buka"
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatus.ForeColor = System.Drawing.Color.Red
        Me.LblStatus.Location = New System.Drawing.Point(498, 2)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(115, 29)
        Me.LblStatus.TabIndex = 23
        Me.LblStatus.Text = "STATUS"
        Me.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RbPU
        '
        Me.RbPU.BaseColor = System.Drawing.SystemColors.Control
        Me.RbPU.CheckedOffColor = System.Drawing.Color.Gray
        Me.RbPU.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RbPU.FillColor = System.Drawing.Color.White
        Me.RbPU.Location = New System.Drawing.Point(90, 14)
        Me.RbPU.Name = "RbPU"
        Me.RbPU.Size = New System.Drawing.Size(151, 20)
        Me.RbPU.TabIndex = 23
        Me.RbPU.Text = "PU (Permohonan Uang)"
        '
        'RbBS
        '
        Me.RbBS.BaseColor = System.Drawing.SystemColors.Control
        Me.RbBS.CheckedOffColor = System.Drawing.Color.Gray
        Me.RbBS.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RbBS.FillColor = System.Drawing.Color.White
        Me.RbBS.Location = New System.Drawing.Point(90, 41)
        Me.RbBS.Name = "RbBS"
        Me.RbBS.Size = New System.Drawing.Size(134, 20)
        Me.RbBS.TabIndex = 24
        Me.RbBS.Text = "BS (Bon Sementara)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(247, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Diajukan Oleh"
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(330, 90)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(161, 20)
        Me.TextBox1.TabIndex = 26
        '
        'TxtGrandTotal
        '
        Me.TxtGrandTotal.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TxtGrandTotal.Enabled = False
        Me.TxtGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGrandTotal.ForeColor = System.Drawing.Color.Green
        Me.TxtGrandTotal.Location = New System.Drawing.Point(563, 571)
        Me.TxtGrandTotal.Name = "TxtGrandTotal"
        Me.TxtGrandTotal.Size = New System.Drawing.Size(131, 24)
        Me.TxtGrandTotal.TabIndex = 27
        Me.TxtGrandTotal.Text = "0"
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel10.Location = New System.Drawing.Point(494, 577)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(57, 15)
        Me.GunaLabel10.TabIndex = 28
        Me.GunaLabel10.Text = "Total DPP"
        '
        'TxtTotalPPH
        '
        Me.TxtTotalPPH.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TxtTotalPPH.Enabled = False
        Me.TxtTotalPPH.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPPH.ForeColor = System.Drawing.Color.Green
        Me.TxtTotalPPH.Location = New System.Drawing.Point(564, 632)
        Me.TxtTotalPPH.Name = "TxtTotalPPH"
        Me.TxtTotalPPH.Size = New System.Drawing.Size(131, 24)
        Me.TxtTotalPPH.TabIndex = 29
        Me.TxtTotalPPH.Text = "0"
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel11.Location = New System.Drawing.Point(494, 638)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(58, 15)
        Me.GunaLabel11.TabIndex = 30
        Me.GunaLabel11.Text = "Total PPH"
        '
        'TxtTotalPPN
        '
        Me.TxtTotalPPN.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TxtTotalPPN.Enabled = False
        Me.TxtTotalPPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPPN.ForeColor = System.Drawing.Color.Green
        Me.TxtTotalPPN.Location = New System.Drawing.Point(564, 601)
        Me.TxtTotalPPN.Name = "TxtTotalPPN"
        Me.TxtTotalPPN.Size = New System.Drawing.Size(131, 24)
        Me.TxtTotalPPN.TabIndex = 31
        Me.TxtTotalPPN.Text = "0"
        '
        'GunaLabel12
        '
        Me.GunaLabel12.AutoSize = True
        Me.GunaLabel12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel12.Location = New System.Drawing.Point(494, 607)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(58, 15)
        Me.GunaLabel12.TabIndex = 32
        Me.GunaLabel12.Text = "Total PPN"
        '
        'TxtTerbilang
        '
        Me.TxtTerbilang.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TxtTerbilang.Enabled = False
        Me.TxtTerbilang.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTerbilang.ForeColor = System.Drawing.Color.Green
        Me.TxtTerbilang.Location = New System.Drawing.Point(90, 600)
        Me.TxtTerbilang.Name = "TxtTerbilang"
        Me.TxtTerbilang.Size = New System.Drawing.Size(398, 23)
        Me.TxtTerbilang.TabIndex = 33
        '
        'GunaLabel13
        '
        Me.GunaLabel13.AutoSize = True
        Me.GunaLabel13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel13.Location = New System.Drawing.Point(21, 600)
        Me.GunaLabel13.Name = "GunaLabel13"
        Me.GunaLabel13.Size = New System.Drawing.Size(55, 15)
        Me.GunaLabel13.TabIndex = 34
        Me.GunaLabel13.Text = "Terbilang"
        '
        'TxtKodeCabang
        '
        Me.TxtKodeCabang.Location = New System.Drawing.Point(96, 717)
        Me.TxtKodeCabang.Name = "TxtKodeCabang"
        Me.TxtKodeCabang.Size = New System.Drawing.Size(100, 20)
        Me.TxtKodeCabang.TabIndex = 35
        '
        'txtGTotal
        '
        Me.txtGTotal.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtGTotal.Enabled = False
        Me.txtGTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGTotal.ForeColor = System.Drawing.Color.Green
        Me.txtGTotal.Location = New System.Drawing.Point(90, 568)
        Me.txtGTotal.Name = "txtGTotal"
        Me.txtGTotal.Size = New System.Drawing.Size(197, 24)
        Me.txtGTotal.TabIndex = 36
        Me.txtGTotal.Text = "0"
        '
        'GunaLabel14
        '
        Me.GunaLabel14.AutoSize = True
        Me.GunaLabel14.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel14.Location = New System.Drawing.Point(21, 574)
        Me.GunaLabel14.Name = "GunaLabel14"
        Me.GunaLabel14.Size = New System.Drawing.Size(67, 15)
        Me.GunaLabel14.TabIndex = 37
        Me.GunaLabel14.Text = "Grand Total"
        '
        'FrmPuBs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(707, 678)
        Me.Controls.Add(Me.GunaLabel14)
        Me.Controls.Add(Me.txtGTotal)
        Me.Controls.Add(Me.TxtKodeCabang)
        Me.Controls.Add(Me.GunaLabel13)
        Me.Controls.Add(Me.TxtTerbilang)
        Me.Controls.Add(Me.GunaLabel12)
        Me.Controls.Add(Me.TxtTotalPPN)
        Me.Controls.Add(Me.GunaLabel11)
        Me.Controls.Add(Me.TxtTotalPPH)
        Me.Controls.Add(Me.GunaLabel10)
        Me.Controls.Add(Me.TxtGrandTotal)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LblStatus)
        Me.Controls.Add(Me.RbBS)
        Me.Controls.Add(Me.RbPU)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtNoPUBS)
        Me.Controls.Add(Me.TglDibutuhkan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CboDivisi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TglDoc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDocNo)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPuBs"
        Me.Text = ".:: Input PU/BS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        CType(Me.DgDataDtl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDocNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TglDoc As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents CboDivisi As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CboSupplier As ComboBox
    Friend WithEvents TglDibutuhkan As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtNoPUBS As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CmdSimpan As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TglInvoice As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents TxtNoInvoice As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents CmdDelete As Guna.UI.WinForms.GunaButton
    Friend WithEvents CmdAdd As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents chkppn As Guna.UI.WinForms.GunaMediumCheckBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents chkpph As Guna.UI.WinForms.GunaMediumCheckBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents CboCabang As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents TxtKeterangan As RichTextBox
    Friend WithEvents TxtNominalInvoice As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CmdUpdate As Guna.UI.WinForms.GunaButton
    Friend WithEvents CmdOpen As Guna.UI.WinForms.GunaButton
    Friend WithEvents LblStatus As Label
    Friend WithEvents CboRekSup As ComboBox
    Friend WithEvents CboBankSupp As ComboBox
    Friend WithEvents CmdPosting As Guna.UI.WinForms.GunaButton
    Friend WithEvents CmdPrint As Guna.UI.WinForms.GunaButton
    Friend WithEvents RbPU As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents RbBS As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtKodeSupplier As TextBox
    Friend WithEvents TxtPPH As TextBox
    Friend WithEvents TxtPPN As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TxtFakturPajak As MaskedTextBox
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaDateTimePicker1 As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents TxtGrandTotal As TextBox
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TxtTotalPPH As TextBox
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TxtTotalPPN As TextBox
    Friend WithEvents GunaLabel12 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TxtTerbilang As TextBox
    Friend WithEvents GunaLabel13 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TxtKodeCabang As TextBox
    Friend WithEvents txtGTotal As TextBox
    Friend WithEvents GunaLabel14 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents DgDataDtl As DataGridView
End Class
