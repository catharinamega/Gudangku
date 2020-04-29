Imports MySql.Data.MySqlClient
Public Class Form_semua_data
    Dim movee As System.Drawing.Point
    Dim mposition As Point
    Dim query As String
    Dim connection As New MySqlConnection(Form_main_menu.constring)
    Dim commmand As New MySqlCommand
    Dim dataadap As New MySqlDataAdapter
    Dim dt_data As New DataTable
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
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
    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Me.Close()
    End Sub
    Sub tampilkan_data_barang()
        query = "Select item_id `Kode`, item_name `Nama`, amount `Jumlah`, amount_type `Satuan` from item;"
        commmand = New MySqlCommand(query, connection)
        dataadap = New MySqlDataAdapter(commmand)
        dataadap.Fill(dt_data)
        dgv.DataSource = dt_data
    End Sub
    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If Form_main_menu.form_from = "UBAH HAPUS DATA" Then
            Form_barang_baru.ShowDialog()
        End If
    End Sub

    Private Sub Form_semua_data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form_main_menu.form_from = "UBAH HAPUS DATA" Then
            Call tampilkan_data_barang()
        End If
    End Sub
End Class