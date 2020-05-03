Public Class Form_message
    Public pesan As String
    Public hasil As Boolean = False 'Iya = true ; Tidak = False
    Public tombol As Integer = 1 ' 1 = OK ; 2 = Iya, Tidak    
    Private Sub btn_yes_Click(sender As Object, e As EventArgs) Handles btn_iya.Click
        hasil = True
        Me.Close()
    End Sub
    Private Sub Form_message_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        l_mess.Text = pesan
        If tombol = 1 Then
            btn_iya.Visible = False
            btn_tidak.Visible = False
            btn_ok.Visible = True
        ElseIf tombol = 2 Then
            btn_iya.Visible = True
            btn_tidak.Visible = True
            btn_ok.Visible = False
        End If
    End Sub
    Private Sub btn_tidak_Click(sender As Object, e As EventArgs) Handles btn_tidak.Click
        hasil = False
        Me.Close()
    End Sub
    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Me.Close()
    End Sub
End Class