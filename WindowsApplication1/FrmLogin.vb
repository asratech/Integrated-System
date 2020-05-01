'---------------------------------------------------------------
' Tentang APP Suzuki Integrated System
'---------------------------------------------------------------
' Created Date  : Januari 2020
' Programer     : Ahmad Sopian (sopian.ahmad@suzuki-mobil.co.id)
'---------------------------------------------------------------
'>>>>>>>>>>>>>>>>>>>> FORM LOGIN <<<<<<<<<<<<<<<<<<<<<
Public Class FrmLogin
    Private Declare Function InternetGetConnectedState Lib "wininet" (ByRef conn As Long, ByVal val As Long) As Boolean
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUsername.Text = ""
        TxtPassword.Text = ""
        TxtUsername.Select()
    End Sub
    Private Function ValidasiEntry() As Boolean
        'Make sure that all fields have values
        If Me.TxtUsername.Text.Trim = "" Or
            Me.TxtPassword.Text.Trim = "" Then
            MsgBox("Username & Password Harus Diisi!", MsgBoxStyle.Exclamation, "Insufficient Data")
            Return True
        End If
    End Function
    'Load data user
    Private Sub CekUser()
        Try
            SQL = "SELECT * from sysuser " &
                 "WHERE status = '1' " &
                 "AND username ='" & Me.TxtUsername.Text & "' " &
                 "AND password ='" & getMD5Hash(TxtPassword.Text) & "'"
            With comDB
                .CommandText = SQL
                .ExecuteNonQuery()
            End With
            rdDB = comDB.ExecuteReader
            rdDB.Read()
            If rdDB.HasRows = True Then
                Me.Hide()
                FrmUtama.Show()
            Else
                MsgBox("Username and or Password are not found", MsgBoxStyle.Exclamation, "Information")
                TxtUsername.Text = ""
                TxtPassword.Text = ""
                TxtUsername.Select()
            End If
            rdDB.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub LoadData(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ProcessTabKey(True) 'Move to next text box
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If ValidasiEntry() = True Then
            TxtUsername.Select()
            Exit Sub
        End If

        Call conecDB()      'Open the connection to database
        Call initCMD()      'Initialize the sqlclient command object
        Call CekUser()
    End Sub



    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs)
        If ValidasiEntry() = True Then
            TxtUsername.Select()
            Exit Sub
        End If

        Call conecDB()      'Open the connection to database
        Call initCMD()      'Initialize the sqlclient command object
        Call CekUser()
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub BtmLogin_Click(sender As Object, e As EventArgs) Handles BtmLogin.Click
        If ValidasiEntry() = True Then
            TxtUsername.Select()
            Exit Sub
        End If

        Call conecDB()      'Open the connection to database
        Call initCMD()      'Initialize the sqlclient command object
        Call CekUser()
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        End
    End Sub
End Class