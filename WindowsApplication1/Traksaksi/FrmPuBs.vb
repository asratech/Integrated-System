'---------------------------------------------------------------
' Tentang APP Suzuki Integrated System
'---------------------------------------------------------------
' Created Date  : Januari 2020
' Programer     : Ahmad Sopian (sopian.ahmad@suzuki-mobil.co.id)
'---------------------------------------------------------------
'>>>>>>>>>>>>>>>>>>>> FORM TRANSAKSI PU/BS <<<<<<<<<<<<<<<<<<<<<
Public Class FrmPuBs
    Dim rs As New ClsResize
    Dim tipedokumen As String
    Dim status As String
    Dim f, g As Double
    Sub EditDetail()
        Dim baris As Integer
        baris = DgDataDtl.SelectedCells(0).RowIndex
        With DgDataDtl
            CboCabang.Text = .Item(0, baris).Value.ToString
            TxtNoInvoice.Text = .Item(1, baris).Value.ToString
            TglInvoice.Text = .Item(2, baris).Value.ToString
            TxtNominalInvoice.Text = .Item(3, baris).Value.ToString
            TxtPPH.Text = .Item(4, baris).Value.ToString
            TxtPPN.Text = .Item(5, baris).Value.ToString
            TxtKeterangan.Text = .Item(6, baris).Value.ToString
        End With
    End Sub
    Sub aturDG()
        Try
            DgDataDtl.Columns(0).Width = 96
            DgDataDtl.Columns(1).Width = 150
            DgDataDtl.Columns(2).Width = 100
            DgDataDtl.Columns(3).Width = 150
            DgDataDtl.Columns(4).Width = 150
            DgDataDtl.Columns(5).Width = 150
            DgDataDtl.Columns(6).Width = 150
            DgDataDtl.Columns(0).HeaderText = "Cabang"
            DgDataDtl.Columns(1).HeaderText = "No.Invoice"
            DgDataDtl.Columns(2).HeaderText = "Tgl.Invoice"
            DgDataDtl.Columns(3).HeaderText = "Nominal INV"
            DgDataDtl.Columns(4).HeaderText = "PPH"
            DgDataDtl.Columns(5).HeaderText = "PPN"
            DgDataDtl.Columns(6).HeaderText = "Keterangan"
        Catch ex As Exception
        End Try
        DgDataDtl.RowsDefaultCellStyle.BackColor = Color.LightBlue
        DgDataDtl.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub
    Sub Summary()
        If DgDataDtl.RowCount > 1 Then
            Dim totalharga As Double = 0
            For index As Integer = 0 To DgDataDtl.RowCount - 1
                totalharga += Convert.ToDouble(DgDataDtl.Rows(index).Cells(3).Value)
            Next
            TxtGrandTotal.Text = totalharga
        End If
    End Sub
    Sub kosongkandetail()
        TxtGrandTotal.Text = "0"
        TxtTotalPPH.Text = "0"
        TxtTotalPPN.Text = "0"
    End Sub
    Sub hitungtotalpph()
        If DgDataDtl.RowCount > 1 Then
            Dim totalpph As Double = 0
            For index As Integer = 0 To DgDataDtl.RowCount - 1
                totalpph += Convert.ToDouble(DgDataDtl.Rows(index).Cells(4).Value)
            Next
            TxtTotalPPH.Text = totalpph
        End If
    End Sub
    Sub hitungtotalppn()
        If DgDataDtl.RowCount > 1 Then
            Dim totalppn As Double = 0
            For index As Integer = 0 To DgDataDtl.RowCount - 1
                totalppn += Convert.ToDouble(DgDataDtl.Rows(index).Cells(5).Value)
            Next
            TxtTotalPPN.Text = totalppn
        End If
    End Sub
    Sub hitungGtotal()
        Dim dpp As Integer
        Dim ppn As Integer
        Dim pph As Integer
        Dim hasil As Integer
        dpp = TxtGrandTotal.Text
        ppn = TxtTotalPPN.Text
        pph = TxtTotalPPH.Text
        hasil = dpp + ppn - pph
        txtGTotal.Text = hasil
    End Sub
    Sub panggilterbilang()
        Dim angka As Double = 0
        If Double.TryParse(txtGTotal.Text, angka) Then
            TxtTerbilang.Text = Terbilang(angka) & " Rupiah"
        End If
    End Sub
    Sub Tampildgdetail()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT cabang as 'Cabang',invoiceno as 'No.Invoice',invoicedate as 'Tgl.Invoice',invoiceamt as 'DPP',pphamt as 'PPH',ppnamt as 'PPN',keterangan as 'Keterangan' FROM fntrpubsdtl", connDB)
        DS = New DataSet
        DA.Fill(DS)
        Dim dt As New DataTable
        For Each dt In DS.Tables
            DgDataDtl.DataSource = dt
        Next
        rdDB.Close()
    End Sub
    Private Sub FrmPuBs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
        Call conecDB()      'Open the connection to database
        Call initCMD()      'Initialize the sqlclient command object
        Call tampildivisi()
        Call tampilsupplier()
        Call tampilcabang()
        Call aturDG()
        Call Tampildgdetail()
        Call Summary()
        Call hitungtotalpph()
        Call hitungtotalppn()
        Call hitungGtotal()
        Call panggilterbilang()
        Call kosongkandetail()
        LblStatus.Text = "NEW"
        TxtDocNo.Text = "PUBSXXXX"
        CmdUpdate.Enabled = False
        CmdPosting.Enabled = False
        CmdPrint.Enabled = False
        'GunaGroupBox1.Enabled = False
    End Sub

    Sub tampildivisi()
        SQL = "select lookupname from gnmstreff WHERE codereff='DIV' and isactive='1'"
        With comDB
            .CommandText = SQL
            .ExecuteNonQuery()
        End With
        rdDB = comDB.ExecuteReader
        If rdDB.HasRows Then
            Do While rdDB.Read
                CboDivisi.Items.Add(rdDB("lookupname"))
            Loop
        Else
        End If
        rdDB.Close()
    End Sub
    Sub tampilsupplier()
        SQL = "select kodesupplier,namasupplier from gnmstsupplierhdr WHERE isactive='1'"
        With comDB
            .CommandText = SQL
            .ExecuteNonQuery()
        End With
        rdDB = comDB.ExecuteReader
        If rdDB.HasRows Then
            Do While rdDB.Read
                CboSupplier.Items.Add(rdDB("namasupplier"))
            Loop
        Else
        End If
        rdDB.Close()
    End Sub
    Sub tampilbanksupp()
        SQL = "select a.bankname,b.kodesupplier from gnmstsupplierbank a LEFT JOIN gnmstsupplierhdr b on a.suppliercode = b.kodesupplier WHERE b.suppliercode =isactive='1'"
        With comDB
            .CommandText = SQL
            .ExecuteNonQuery()
        End With
        rdDB = comDB.ExecuteReader
        If rdDB.HasRows Then
            Do While rdDB.Read
                CboSupplier.Items.Add(rdDB("namasupplier"))
            Loop
        Else
        End If
        rdDB.Close()
    End Sub
    Sub tampilcabang()
        SQL = "select * from gnmstcabang WHERE isactive='1'"
        With comDB
            .CommandText = SQL
            .ExecuteNonQuery()
        End With
        rdDB = comDB.ExecuteReader
        If rdDB.HasRows Then
            Do While rdDB.Read
                CboCabang.Items.Add(rdDB("namacabang"))
            Loop
        Else
        End If
        rdDB.Close()
    End Sub
    Sub NomorPUBS()
        Dim strsementara As String = ""
        Dim urutan As String = ""
        SQL = "Select * from fntrpubshdr where docno in (select max(docno) from fntrpubshdr)"
        With comDB
            .CommandText = SQL
            .ExecuteNonQuery()
        End With
        rdDB = comDB.ExecuteReader
        If rdDB.HasRows Then
            While (rdDB.Read())
                strsementara = Microsoft.VisualBasic.Right(rdDB.GetString(0), 3) + 1
                urutan = "PUBS" + Microsoft.VisualBasic.Right("000" & strsementara, 4)
                TxtDocNo.Text = urutan
            End While
        Else
            urutan = "PUBS" + "0001"
        End If
        rdDB.Close()
    End Sub

    Private Sub RbPU_CheckedChanged(sender As Object, e As EventArgs) Handles RbPU.CheckedChanged
        TxtNoPUBS.Mask = "PU/00000/AAA-AAAA/AAA/0000"
    End Sub

    Private Sub RbBS_CheckedChanged(sender As Object, e As EventArgs) Handles RbBS.CheckedChanged
        TxtNoPUBS.Mask = "BS/00000/AAA-AAAA/AAA/0000"
    End Sub
    Private Sub CboSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboSupplier.SelectedIndexChanged
        SQL = "SELECT KodeSupplier,NamaSupplier FROM gnmstsupplierhdr WHERE namasupplier= '" & CboSupplier.Text & "' AND isActive='1'"
        With comDB
            .CommandText = SQL
            .ExecuteNonQuery()
        End With
        rdDB = comDB.ExecuteReader
        rdDB.Read()
        If rdDB.HasRows Then
            TxtKodeSupplier.Text = rdDB.Item("KodeSupplier")
        End If
        rdDB.Close()
        Call tampilbank()
    End Sub
    Sub tampilbank()
        SQL = "select * from gnmstsupplierbank WHERE suppliercode ='" & TxtKodeSupplier.Text & "'"
        With comDB
            .CommandText = SQL
            .ExecuteNonQuery()
        End With
        rdDB = comDB.ExecuteReader
        If rdDB.HasRows Then
            Do While rdDB.Read
                CboBankSupp.Items.Add(rdDB("bankname"))
            Loop
        Else
        End If
        rdDB.Close()
    End Sub
    Sub tampilrek()
        SQL = "select * from gnmstsupplierbank WHERE suppliercode ='" & TxtKodeSupplier.Text & "' AND bankname='" & CboBankSupp.Text & "'"
        With comDB
            .CommandText = SQL
            .ExecuteNonQuery()
        End With
        rdDB = comDB.ExecuteReader
        If rdDB.HasRows Then
            Do While rdDB.Read
                CboRekSup.Items.Add(rdDB("bankacc"))
            Loop
        Else
        End If
        rdDB.Close()
    End Sub
    Private Sub CmdSimpan_Click(sender As Object, e As EventArgs) Handles CmdSimpan.Click
        If RbPU.Checked = True Then
            tipedokumen = "PU"
        ElseIf RbBS.Checked = True Then
            tipedokumen = "BS"
        End If
        If LblStatus.Text = "BUKA PU/BS" Then
            status = 1
        ElseIf LblStatus.Text = "PRINTED" Then
            status = 2
        End If
        Try
            Call NomorPUBS()
            SQL = "INSERT INTO fntrpubshdr(docno,doctype,docdate,pubsno,tgldibutuhkan,divisi,suppliercode,suppliername,rekno,bankname,statusposting,createby,createdate) VALUES ('" &
                                    TxtDocNo.Text & "','" &
                                    tipedokumen & "','" &
                                    TglDoc.Value & "','" &
                                    TxtNoPUBS.Text & "','" &
                                    TglDibutuhkan.Text & "','" &
                                    CboDivisi.Text & "','" &
                                    TxtKodeSupplier.Text & "','" &
                                    CboSupplier.Text & "','" &
                                    CboRekSup.Text & "','" &
                                    CboBankSupp.Text & "','" &
                                    status & "','" &
                                    FrmLogin.TxtUsername.Text & "','" &
                                    DateAndTime.Now & "')"
            comDB = New MySql.Data.MySqlClient.MySqlCommand(SQL, connDB)
            comDB.ExecuteNonQuery()
            MsgBox("Berhasil Simpan Data", vbInformation, "Simpan Data")
            rdDB.Close()
            CmdUpdate.Enabled = True
            CmdPosting.Enabled = False
            CmdPrint.Enabled = True
            CmdSimpan.Enabled = False
            LblStatus.Text = "BUKA PU/BS"
            GunaGroupBox1.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Simpan Data Gagal.")
        End Try
    End Sub
    Private Sub chkpph_CheckedChanged(sender As Object, e As EventArgs) Handles chkpph.CheckedChanged
        If chkpph.Checked = True Then
            TxtPPH.Text = Format(Val(g), "###,###")
            TxtPPH.Text = TxtNominalInvoice.Text * 0.02
        ElseIf chkpph.Checked = False Then
            TxtPPH.Text = "0"
        End If
    End Sub
    Private Sub chkppn_CheckedChanged(sender As Object, e As EventArgs) Handles chkppn.CheckedChanged
        If chkppn.Checked = True Then
            TxtPPN.Text = Format(Val(g), "###,###")
            TxtPPN.Text = TxtNominalInvoice.Text * 0.1
        ElseIf chkppn.Checked = False Then
            TxtPPN.Text = "0"
        End If
    End Sub
    Private Sub GunaTextBox2_TextChanged(sender As Object, e As EventArgs) Handles TxtNominalInvoice.TextChanged
        If TxtNominalInvoice.Text = "" Then
            TxtNominalInvoice.Text = "0"
        End If
        If chkpph.Checked = True Then
            TxtPPH.Text = Format(Val(g), "###,###")
            TxtPPH.Text = TxtNominalInvoice.Text * 0.02
        ElseIf chkpph.Checked = False Then
            TxtPPH.Text = "0"
        End If
        If chkppn.Checked = True Then
            TxtPPN.Text = Format(Val(g), "###,###")
            TxtPPN.Text = TxtNominalInvoice.Text * 0.1
        ElseIf chkppn.Checked = False Then
            TxtPPN.Text = "0"
        End If
    End Sub
    Private Sub CboBankSupp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboBankSupp.SelectedIndexChanged
        Call tampilrek()
    End Sub
    Private Sub CboCabang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCabang.SelectedIndexChanged
        SQL = "select * from gnmstcabang WHERE namacabang='" & CboCabang.Text & "' AND isactive='1'"
        With comDB
            .CommandText = SQL
            .ExecuteNonQuery()
        End With
        rdDB = comDB.ExecuteReader
        If rdDB.HasRows Then
            Do While rdDB.Read
                TxtKodeCabang.Text = rdDB.Item("idcabang")
            Loop
        Else
        End If
        rdDB.Close()
    End Sub

    Private Sub CmdAdd_Click(sender As Object, e As EventArgs) Handles CmdAdd.Click
        Try
            SQL = "INSERT INTO fntrpubsdtl VALUES ('" _
                & TxtDocNo.Text _
                & "','" _
                & TxtKodeCabang.Text _
                & "','" _
                & TxtNoInvoice.Text _
                & "','" _
                & TglInvoice.Text _
                & "','" _
                & TxtFakturPajak.Text _
                & "','" _
                & TxtNominalInvoice.Text _
                & "','" _
                & TxtKeterangan.Text _
                & "','" _
                & TxtPPN.Text _
                & "','" _
                & TxtPPH.Text _
                & "','" _
                & FrmLogin.TxtUsername.Text _
                & "','" _
                & DateAndTime.Now _
                & "')"
            comDB = New MySql.Data.MySqlClient.MySqlCommand(SQL, connDB)
            comDB.ExecuteNonQuery()
            MsgBox("Berhasil Simpan Data", vbInformation, "Simpan Data")
            rdDB.Close()
            Call aturDG()
            Call Tampildgdetail()
            Call Summary()
            Call hitungtotalpph()
            Call hitungtotalppn()
            Call hitungGtotal()
            Call panggilterbilang()
        Catch ex As Exception
            MessageBox.Show("Simpan Data Gagal.")
        End Try
    End Sub

    Private Sub DgDataDtl_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgDataDtl.CellContentClick
        Call EditDetail()
    End Sub

    Private Sub TxtNominalInvoice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNominalInvoice.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class