'---------------------------------------------------------------
' Tentang APP Suzuki Integrated System
'---------------------------------------------------------------
' Created Date  : Januari 2020
' Programer     : Ahmad Sopian (sopian.ahmad@suzuki-mobil.co.id)
'---------------------------------------------------------------
'>>>>>>>>>>>>>>>>>>>> FORM REFERENSI <<<<<<<<<<<<<<<<<<<<<
Public Class FrmMstReferensi
    Dim isactive As String
    Sub aturDG()
        Try
            DgData.Columns(0).Width = 100
            DgData.Columns(1).Width = 150
            DgData.Columns(2).Width = 60
            DgData.Columns(0).HeaderText = "Kode Referensi"
            DgData.Columns(1).HeaderText = "Nama Referensi"
            DgData.Columns(2).HeaderText = "isActive"
            DgData.RowsDefaultCellStyle.BackColor = Color.LightBlue
            DgData.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Catch ex As Exception
        End Try
    End Sub
    Sub tampilDatareff()
        SQL = "select lookupname from gnmstreff WHERE codereff='REFF' and isactive='1'"
        With comDB
            .CommandText = SQL
            .ExecuteNonQuery()
        End With
        rdDB = comDB.ExecuteReader
        If rdDB.HasRows Then
            Do While rdDB.Read
                CboReff.Items.Add(rdDB("lookupname"))
            Loop
        Else
        End If
        rdDB.Close()
    End Sub
    Sub Kosong()
        CboReff.Items.Clear()
        Txtnamareff.Text = ""
        RDActive.Checked = False
        RDNotActive.Checked = False
    End Sub
    Sub caristatus()
        On Error Resume Next
        If rdDB.Item("isActive") = "1" Then
            RDActive.Checked = True
        Else
            RDNotActive.Checked = True
        End If
    End Sub
    Sub TampilData()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT codereff,lookupname,isactive FROM gnmstreff", connDB)
        DS = New DataSet
        DA.Fill(DS, "gnmstreff")
        DgData.DataSource = DS.Tables("gnmstreff")
    End Sub

    Private Sub FrmMstReferensi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call conecDB()      'Open the connection to database
        Call initCMD()      'Initialize the sqlclient command object
        Call tampilDatareff()
        Call TampilData()
        Call aturDG()
        GunaAdvenceButton3.Enabled = False
        TopLevel = False
        'FrmUtama.Panel1.Controls.Add(Me)
    End Sub
    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        If RDActive.Checked = True Then
            isactive = 1
        ElseIf RDActive.Checked = True Then
            isactive = 0
        End If
        SQL = "INSERT INTO gnmstreff VALUES ('" &
                        CboReff.Text & "','" &
                        Txtnamareff.Text & "','" &
                        isactive & "','" &
                        FrmLogin.TxtUsername.Text & "','" &
                        DateAndTime.Now & "')"
        comDB = New MySql.Data.MySqlClient.MySqlCommand(SQL, connDB)
        comDB.ExecuteNonQuery()
        MsgBox("Berhasil Simpan Data Referensi " & Txtnamareff.Text & "", vbInformation, "Simpan Data")
        Kosong()
        TampilData()
        tampilDatareff()
    End Sub
    Private Sub DgData_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgData.CellMouseDoubleClick
        CboReff.Text = DgData.Rows(e.RowIndex).Cells(0).Value
        Txtnamareff.Text = DgData.Rows(e.RowIndex).Cells(1).Value
        caristatus()
        GunaAdvenceButton1.Enabled = False
        GunaAdvenceButton3.Enabled = True
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        Me.Close()
    End Sub

    Private Sub DgData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgData.CellContentClick

    End Sub
End Class