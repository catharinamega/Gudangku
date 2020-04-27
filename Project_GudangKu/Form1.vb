Public Class form_login
    Dim mouse_move As System.Drawing.Point
    Dim mposition As New Point
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles panel_menu.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles panel_menu.MouseDown
        mouse_move = New Point(-e.X, -e.Y)
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles panel_menu.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            mposition = New Point
            mposition = Control.MousePosition
            mposition.Offset(mouse_move.X, mouse_move.Y)
            Me.Location = mposition
        End If
    End Sub

    Private Sub form_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panel_menu.BackColor = Color.FromArgb(20, 0, 0, 0)

    End Sub

    Private Sub Button_Click_1(sender As Object, e As EventArgs) Handles btn_masuk.Click
        Form_main_menu.Show()
    End Sub
End Class
