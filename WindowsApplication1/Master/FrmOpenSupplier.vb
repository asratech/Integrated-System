Public Class FrmOpenSupplier
    Sub aturDG()
        Try
            DGData.Columns(0).Width = 70
            DGData.Columns(1).Width = 200
            DGData.Columns(1).Width = 30
            DGData.Columns(0).HeaderText = "Kode Supplier"
            DGData.Columns(1).HeaderText = "Nama Supplier"
            DGData.Columns(2).HeaderText = "isActive"
            DGData.RowsDefaultCellStyle.BackColor = Color.LightBlue
            DGData.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Catch ex As Exception
        End Try
    End Sub
    Sub TampilData()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT kodesupplier as 'Kode Supplier',namasupplier as 'Nama Supplier',isactive from gnmstsupplierhdr", connDB)
        DS = New DataSet
        DA.Fill(DS, "gnmstsupplierhdr")
        DGData.DataSource = DS.Tables("gnmstsupplierhdr")
        rdDB.Close()
    End Sub

    Private Sub FrmOpenSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conecDB()      'Open the connection to database
        Call initCMD()      'Initialize the sqlclient command object
        Call aturDG()
        Call TampilData()
    End Sub

    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        SQL = "select * from gnmstsupplierhdr where namasupplier like '%" & TxtCari.Text & "%'"
        With comDB
            .CommandText = SQL
            .ExecuteNonQuery()
        End With
        rdDB = comDB.ExecuteReader
        If rdDB.HasRows Then
            DA = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT kodesupplier as 'Kode Supplier',namasupplier as 'Nama Supplier',isactive from gnmstsupplierhdr", connDB)
            DS = New DataSet
            DA.Fill(DS, "gnmstsupplierhdr")
            DGData.DataSource = DS.Tables("gnmstsupplierhdr")
        End If
        rdDB.Close()
    End Sub
End Class