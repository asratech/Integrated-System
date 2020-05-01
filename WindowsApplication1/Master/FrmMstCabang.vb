'---------------------------------------------------------------
' Tentang APP Suzuki Integrated System
'---------------------------------------------------------------
' Created Date  : Januari 2020
' Programer     : Ahmad Sopian (sopian.ahmad@suzuki-mobil.co.id)
'---------------------------------------------------------------
'>>>>>>>>>>>>>>>>>>>> FORM MASTER CABANG <<<<<<<<<<<<<<<<<<<<<
Public Class FrmMstCabang
    Dim Status As String
    Sub tampilcompany()
        SQL = "select lookupname from gnmstreff WHERE codereff='COMPANY' and isactive='1'"
        With comDB
            .CommandText = SQL
            .ExecuteNonQuery()
        End With
        rdDB = comDB.ExecuteReader
        If rdDB.HasRows Then
            Do While rdDB.Read
                CboCompany.Items.Add(rdDB("lookupname"))
            Loop
        Else
        End If
        rdDB.Close()
    End Sub
    Sub aturDG()
        Try
            DgDataCabang.Columns(0).Width = 100
            DgDataCabang.Columns(1).Width = 90
            DgDataCabang.Columns(2).Width = 150
            DgDataCabang.Columns(3).Width = 40
            DgDataCabang.Columns(0).HeaderText = "Kode Cabang"
            DgDataCabang.Columns(1).HeaderText = "Company"
            DgDataCabang.Columns(2).HeaderText = "Nama Cabang"
            DgDataCabang.Columns(3).HeaderText = "Aktif ?"
        Catch ex As Exception
        End Try
        DgDataCabang.RowsDefaultCellStyle.BackColor = Color.LightBlue
        DgDataCabang.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub
    Sub Tampildgcabang()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT idcabang,company,namacabang,isactive FROM gnmstcabang", connDB)
        DS = New DataSet
        DA.Fill(DS)
        Dim dt As New DataTable
        For Each dt In DS.Tables
            DgDataCabang.DataSource = dt
        Next
        rdDB.Close()
    End Sub
    Private Sub FrmMstCabang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conecDB()      'Open the connection to database
        Call initCMD()
        Call tampilcompany()
        Call aturDG()
        Call Tampildgcabang()
    End Sub

    Private Sub BtmSave_Click(sender As Object, e As EventArgs) Handles BtmSave.Click
        If RbActive.Checked = True Then
            Status = 1
        ElseIf RbSuspend.Checked = True Then
            Status = 0
        End If
        Try
            SQL = "INSERT INTO gnmstcabang VALUES ('" &
                        Txtidcabang.Text & "','" &
                        CboCompany.Text & "','" &
                        TxtNamaCabang.Text & "','" &
                        Status & "','" &
                        FrmLogin.TxtUsername.Text & "','" &
                        DateAndTime.Now & "')"
            comDB = New MySql.Data.MySqlClient.MySqlCommand(SQL, connDB)
            comDB.ExecuteNonQuery()
            MsgBox("Berhasil Simpan Data", vbInformation, "Simpan Data")
            rdDB.Close()
            Call aturDG()
            Call Tampildgcabang()
        Catch ex As Exception
            MessageBox.Show("Simpan Data Gagal.")
        End Try
    End Sub
End Class