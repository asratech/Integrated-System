'---------------------------------------------------------------
' Tentang APP Suzuki Integrated System
'---------------------------------------------------------------
' Created Date  : Januari 2020
' Programer     : Ahmad Sopian (sopian.ahmad@suzuki-mobil.co.id)
'---------------------------------------------------------------
'>>>>>>>>>>>>>>>>>>>> FORM MASTER SUPPLIER <<<<<<<<<<<<<<<<<<<<<
Public Class FrmSupplierNew
    Dim status As String
    Dim statusbank As String
    Dim jenissupplier As String
    Dim rs As New ClsResize

    Sub aturDG()
        Try
            DataBank.Columns(0).Width = 95
            DataBank.Columns(1).Width = 150
            DataBank.Columns(2).Width = 100
            DataBank.Columns(3).Width = 90
            DataBank.Columns(4).Width = 120
            DataBank.Columns(0).HeaderText = "Kode Supplier"
            DataBank.Columns(1).HeaderText = "Nama Supplier"
            DataBank.Columns(2).HeaderText = "Nama Bank"
            DataBank.Columns(3).HeaderText = "Rekening"
            DataBank.Columns(4).HeaderText = "Atas Nama"
            DataBank.Columns(5).HeaderText = "isActice"
        Catch ex As Exception
        End Try
        DataBank.RowsDefaultCellStyle.BackColor = Color.LightBlue
        DataBank.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub
    Sub Tampildgbank()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT a.kodesupplier,a.namasupplier,b.bankname,b.bankacc,b.bankuser,b.isactive FROM gnmstsupplierhdr a left join gnmstsupplierbank b on a.KodeSupplier = b.suppliercode WHERE a.KodeSupplier='" & TxtKodeSupplier.Text & "'", connDB)
        DS = New DataSet
        DA.Fill(DS)
        Dim dt As New DataTable
        For Each dt In DS.Tables
            DataBank.DataSource = dt
        Next
        rdDB.Close()
    End Sub
    Sub NomorSupp()
        Dim strsementara As String = ""
        Dim urutan As String = ""
        SQL = "Select * from gnmstsupplierhdr where KodeSupplier in (select max(KodeSupplier) from gnmstsupplierhdr)"
        With comDB
            .CommandText = SQL
            .ExecuteNonQuery()
        End With
        rdDB = comDB.ExecuteReader
        If rdDB.HasRows Then
            While (rdDB.Read())
                strsementara = Microsoft.VisualBasic.Right(rdDB.GetString(0), 3) + 1
                urutan = "SUP" + Microsoft.VisualBasic.Right("000" & strsementara, 3)
                TxtKodeSupplier.Text = urutan
            End While
        Else
            urutan = "SUP" + "001"
        End If
        rdDB.Close()
    End Sub
    Sub tampilDataBank()
        SQL = "select lookupname from gnmstreff WHERE codereff='BANKNAME' and isactive='1'"
        With comDB
            .CommandText = SQL
            .ExecuteNonQuery()
        End With
        rdDB = comDB.ExecuteReader
        If rdDB.HasRows Then
            Do While rdDB.Read
                CboBank.Items.Add(rdDB("lookupname"))
            Loop
        Else
        End If
        rdDB.Close()
    End Sub
    Private Sub DisableHeader()
        TxtNamaSupplier.Enabled = False
        TxtNpwp.Enabled = False
        TxtKodeSupplier.Enabled = False
        ComboBox1.Enabled = False
        RbKaryawan.Enabled = False
        RbPerusahaan.Enabled = False
        BtmSave.Enabled = False
    End Sub
    Private Sub EnableHeader()
        TxtNamaSupplier.Enabled = True
        TxtKodeSupplier.Enabled = False
        TxtNpwp.Enabled = True
        ComboBox1.Enabled = True
        RbKaryawan.Enabled = True
        RbPerusahaan.Enabled = True
        BtmSave.Enabled = False
        DetailGroup.Enabled = False
    End Sub
    Private Sub BtmSave_Click(sender As Object, e As EventArgs) Handles BtmSave.Click
        If ComboBox1.Text = "Active" Then
            status = 1
        ElseIf ComboBox1.Text = "Suspend" Then
            status = 0
        End If

        If RbKaryawan.Checked = True Then
            jenissupplier = "KR"
        ElseIf RbPerusahaan.Checked = True Then
            jenissupplier = "PR"
        End If
        Try
            Call NomorSupp()
            SQL = "INSERT INTO gnmstsupplierhdr VALUES ('" &
                            TxtKodeSupplier.Text & "','" &
                            TxtNamaSupplier.Text & "','" &
                            jenissupplier & "','" &
                            TxtNpwp.Text & "','" &
                            status & "','" &
                            FrmLogin.TxtUsername.Text & "','" &
                            DateAndTime.Now & "')"
            comDB = New MySql.Data.MySqlClient.MySqlCommand(SQL, connDB)
            comDB.ExecuteNonQuery()
            MsgBox("Berhasil Simpan Data", vbInformation, "Simpan Data")
            DisableHeader()
            DetailGroup.Enabled = True
            Call aturDG()
            BtmUpdate.Enabled = False
            BtmEdit.Enabled = True
            rdDB.Close()
            Call aturDG()
            Call Tampildgbank()

        Catch ex As Exception
            MessageBox.Show("Simpan Data Gagal.")
        End Try
    End Sub
    Private Sub FrmSupplierNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
        Call conecDB()      'Open the connection to database
        Call initCMD()      'Initialize the sqlclient command object
        BtmUpdate.Enabled = False
        BtmEdit.Enabled = False
        Call tampilDataBank()
        TxtNamaSupplier.Focus()
        TxtKodeSupplier.Text = "SUP-XXX"
        Button2.Enabled = False
        DetailGroup.Enabled = False

    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRekno.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RbBankActive.Checked = True Then
            statusbank = 1
        ElseIf RbBankSuspend.Checked = True Then
            statusbank = 0
        End If
        Try
            SQL = "INSERT INTO gnmstsupplierbank VALUES ('" &
                TxtKodeSupplier.Text & "','" &
                CboBank.Text & "','" &
                TxtRekno.Text & "','" &
                TxtRekName.Text & "','" &
                DateAndTime.Now & "','" &
                FrmLogin.TxtUsername.Text & "','" &
                statusbank & "')"
            comDB = New MySql.Data.MySqlClient.MySqlCommand(SQL, connDB)
            comDB.ExecuteNonQuery()
            MsgBox("Berhasil Simpan Data", vbInformation, "Simpan Data")
            rdDB.Close()
            Call aturDG()
            Call Tampildgbank()
            CboBank.Text = ""
            TxtRekName.Text = ""
            TxtRekno.Text = ""
        Catch ex As Exception
            MessageBox.Show("Simpan Data Gagal.")
        End Try
    End Sub
    Private Sub DataBank_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataBank.CellDoubleClick
        If status = 1 Then
            RbBankActive.Checked = True
        ElseIf status = 0 Then
            RbBankSuspend.Checked = True
        End If
        Try
            With DataBank
                CboBank.Text = .SelectedCells(2).Value
                TxtRekno.Text = .SelectedCells(3).Value
                TxtRekName.Text = .SelectedCells(4).Value
                status = .SelectedCells(5).Value
            End With
            Button2.Enabled = True
            Button1.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RbBankActive.Checked = True Then
            statusbank = 1
        ElseIf RbBankSuspend.Checked = True Then
            statusbank = 0
        End If
        Try
            SQL = "UPDATE gnmstsupplierbank set bankname='" & CboBank.Text & "',bankacc='" & TxtRekno.Text & "',bankuser='" & TxtRekName.Text & "',isactive='" & statusbank & "' WHERE suppliercode='" & TxtKodeSupplier.Text & "' and bankacc='" & TxtRekno.Text & "'"
            comDB = New MySql.Data.MySqlClient.MySqlCommand(SQL, connDB)
            comDB.ExecuteNonQuery()
            MsgBox("Berhasil Update Data", vbInformation, "Update Data")
            rdDB.Close()
            Call aturDG()
            Call Tampildgbank()
            CboBank.Text = ""
            TxtRekName.Text = ""
            TxtRekno.Text = ""
        Catch ex As Exception
            MessageBox.Show("Update Data Gagal.")
        End Try
    End Sub

    Private Sub DetailGroup_Click(sender As Object, e As EventArgs) Handles DetailGroup.Click

    End Sub

    Private Sub DataBank_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataBank.CellContentClick

    End Sub

    Private Sub BtmEdit_Click(sender As Object, e As EventArgs) Handles BtmEdit.Click
        EnableHeader()
        BtmSave.Enabled = False
        BtmEdit.Enabled = False
        BtmUpdate.Enabled = True
    End Sub

    Private Sub BtmUpdate_Click(sender As Object, e As EventArgs) Handles BtmUpdate.Click

        If RbKaryawan.Checked = True Then
            jenissupplier = "KR"
        ElseIf RbPerusahaan.Checked = True Then
            jenissupplier = "PR"
        End If
        Try
            SQL = "UPDATE gnmstsupplierhdr set NamaSupplier='" & TxtNamaSupplier.Text & "',JenisSupplier='" & jenissupplier & "',NpwpSupplier='" & TxtNpwp.Text & "',isactive='" & status & "' WHERE KodeSupplier='" & TxtKodeSupplier.Text & "'"
            comDB = New MySql.Data.MySqlClient.MySqlCommand(SQL, connDB)
            comDB.ExecuteNonQuery()
            MsgBox("Berhasil Update Data", vbInformation, "Update Data")
            rdDB.Close()
            Call aturDG()
            Call Tampildgbank()
            BtmEdit.Enabled = True
            BtmUpdate.Enabled = False
            DetailGroup.Enabled = True
            Call DisableHeader()
        Catch ex As Exception
            MessageBox.Show("Update Data Gagal.")
        End Try
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        FrmOpenSupplier.Show()
    End Sub
End Class