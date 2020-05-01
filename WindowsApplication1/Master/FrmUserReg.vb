'---------------------------------------------------------------
' Tentang APP Suzuki Integrated System
'---------------------------------------------------------------
' Created Date  : Januari 2020
' Programer     : Ahmad Sopian (sopian.ahmad@suzuki-mobil.co.id)
'---------------------------------------------------------------
'>>>>>>>>>>>>>>>>>>>> FORM MASTER DAFTAR USER BARU<<<<<<<<<<<<<<<<<<<<<
Public Class FrmUserReg
    Dim status As Integer
    Sub tampilleveluser()
        SQL = "select lookupname from gnmstreff WHERE codereff='LVLUSR' and isactive='1'"
        With comDB
            .CommandText = SQL
            .ExecuteNonQuery()
        End With
        rdDB = comDB.ExecuteReader
        If rdDB.HasRows Then
            Do While rdDB.Read
                CboLevel.Items.Add(rdDB("lookupname"))
            Loop
        Else
        End If
        rdDB.Close()
    End Sub

    Private Sub FrmUserReg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conecDB()      'Open the connection to database
        Call initCMD()      'Initialize the sqlclient command object
        Call tampilleveluser()
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If CboActive.Checked = True Then
            status = "1"
        ElseIf CboSuspend.Checked = True Then
            status = "0"
        End If
        Try
            SQL = "INSERT INTO sysuser VALUES ('" &
                        TxtUsername.Text & "','" &
                        TxtNamaLengkap.Text & "','" &
                        getMD5Hash(TxtPassword.Text) & "','" &
                        CboLevel.Text & "','" &
                        status & "','" &
                        FrmLogin.TxtUsername.Text & "','" &
                        DateAndTime.Now & "')"
            comDB = New MySql.Data.MySqlClient.MySqlCommand(SQL, connDB)
            comDB.ExecuteNonQuery()
            MsgBox("User " & TxtNamaLengkap.Text & " Berhasil Di Daftarkan", vbInformation, "Simpan Data")
            rdDB.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Simpan Data Gagal.")
        End Try
    End Sub
End Class