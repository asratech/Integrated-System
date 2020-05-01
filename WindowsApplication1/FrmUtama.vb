'---------------------------------------------------------------
' Tentang APP Suzuki Integrated System
'---------------------------------------------------------------
' Created Date  : Januari 2020
' Programer     : Ahmad Sopian (sopian.ahmad@suzuki-mobil.co.id)
'---------------------------------------------------------------
'>>>>>>>>>>>>>>>>>>>> FORM UTAMA <<<<<<<<<<<<<<<<<<<<<
Public Class FrmUtama
    Private Sub FrmUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.IsMdiContainer = True
    End Sub
    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        FrmSupplierNew.MdiParent = Me
        FrmSupplierNew.Show()
    End Sub

    Private Sub ReferensiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReferensiToolStripMenuItem.Click
        FrmMstReferensi.MdiParent = Me
        FrmMstReferensi.Show()
    End Sub
    Private Sub InputPUBSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputPUBSToolStripMenuItem.Click
        FrmPuBs.MdiParent = Me
        FrmPuBs.Show()
    End Sub

    Private Sub MasterCabangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterCabangToolStripMenuItem.Click
        FrmMstCabang.MdiParent = Me
        FrmMstCabang.Show()
    End Sub
    Private Sub CLOSEALLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLOSEALLToolStripMenuItem.Click
        If MessageBox.Show("Tutup Seluruh Window Yang Terbuka ?", "Konfirmasi",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            For Each frm As Form In Me.MdiChildren
                frm.Close()
            Next
        End If
    End Sub
    Private Sub MasterUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterUserToolStripMenuItem.Click

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        FrmLogin.Show()
        FrmLogin.TxtUsername.Text = ""
        FrmLogin.TxtPassword.Text = ""
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub DaftarkanUserBaruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarkanUserBaruToolStripMenuItem.Click
        FrmUserReg.MdiParent = Me
        FrmUserReg.Show()
    End Sub
End Class