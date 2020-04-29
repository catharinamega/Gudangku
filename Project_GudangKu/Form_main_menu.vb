Public Class Form_main_menu
    Dim movee As System.Drawing.Point
    Dim mposition As Point
    Dim tim(2) As Integer 'waktu 0 jam, 1 menit, 2 detik
    Dim tiim(2) As String
    Public form_from As String
    Public constring As String = "server=localhost;userid=root;password=;database=gudang"
    Private Sub Form_main_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pan_back.BackColor = Color.FromArgb(30, 0, 0, 0)
        panel_menu.BackColor = Color.FromArgb(50, 0, 0, 0)
        form_login.Hide()
        waktu.Enabled = True
    End Sub
    Private Sub panel_menu_MouseDown(sender As Object, e As MouseEventArgs) Handles panel_menu.MouseDown
        movee = New Point(-e.X, -e.Y)
    End Sub

    Private Sub panel_menu_MouseMove(sender As Object, e As MouseEventArgs) Handles panel_menu.MouseMove
        If e.Button = MouseButtons.Left Then
            mposition = New Point
            mposition = MousePosition
            mposition.Offset(movee.X, movee.Y)
            Me.Location = mposition
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click, bt_keluar.Click
        form_login.Show()
        Me.Close()
    End Sub
    Private Sub waktu_Tick(sender As Object, e As EventArgs) Handles waktu.Tick
        tim(2) = System.DateTime.Now.Second
        tim(1) = System.DateTime.Now.Minute
        tim(0) = System.DateTime.Now.Hour
        For i = 0 To 2
            If tim(i) < 10 Then
                tiim(i) = "0" & tim(i)
            Else
                tiim(i) = tim(i)
            End If
        Next
        l_tim.Text = tiim(0) & " : " & tiim(1) & " : " & tiim(2)
    End Sub
    Private Sub bt_dbm_Click(sender As Object, e As EventArgs) Handles bt_dbm.Click
        With Form_Data_Barang
            .l_jud.Text = bt_dbm.Text
            .btn_daftar.Visible = True
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_dbk_Click(sender As Object, e As EventArgs) Handles btn_dbk.Click
        With Form_Data_Barang
            .btn_daftar.Visible = False
            .l_jud.Text = btn_dbk.Text
            .ShowDialog()
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_seluruhbarang.Click
        With Form_semua_data
            .l_jud.Text = "Daftar Barang"
            form_from = "SELURUH BARANG"
            .ShowDialog()
        End With
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_kon_barang.Click
        With Form_konversi
            .ShowDialog()
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_stok_op.Click
        With Form_semua_data
            .l_jud.Text = "Daftar Barang"
            form_from = "STOK OPNAME"
            .ShowDialog()
            form_from = ""
        End With
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_uhdata.Click
        With Form_semua_data
            .l_jud.Text = "Daftar Barang"
            form_from = "UBAH HAPUS DATA"
            .ShowDialog()
            form_from = ""
        End With
    End Sub
    Private Sub pan_back_Paint(sender As Object, e As PaintEventArgs) Handles pan_back.Paint

    End Sub
End Class