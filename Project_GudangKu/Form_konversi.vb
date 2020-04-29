Public Class Form_konversi
    Dim movee As System.Drawing.Point
    Dim mpos As Point

    Private Sub panel_menu_MouseDown(sender As Object, e As MouseEventArgs) Handles panel_menu.MouseDown
        movee = New Point(-e.X, -e.Y)
    End Sub
    Private Sub panel_menu_MouseMove(sender As Object, e As MouseEventArgs) Handles panel_menu.MouseMove
        If e.Button = MouseButtons.Left Then
            mpos = New Point
            mpos = MousePosition
            mpos.Offset(movee.X, movee.Y)
            Me.Location = mpos
        End If
    End Sub
    Private Sub Form_konversi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btn_daftar_Click(sender As Object, e As EventArgs) Handles btn_daftar.Click
        Form_Data_Turunan.ShowDialog()
    End Sub
    Private Sub btn_table_Click(sender As Object, e As EventArgs) Handles btn_table.Click
        With Form_semua_data
            .l_jud.Text = "Daftar Satuan"
            Form_main_menu.form_from = "Daftar Satuan"
            .Show()
        End With
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click, btn_close.Click
        Me.Close()
    End Sub
End Class