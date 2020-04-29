Imports MySql.Data.MySqlClient
Public Class Form_barang_baru
    Dim mposition As New Point
    Dim movee As System.Drawing.Point
    Dim connection As New MySqlConnection(Form_main_menu.constring)
    Dim commmand As New MySqlCommand
    Dim dataadap As New MySqlDataAdapter
    Dim query As String
    Dim dt_satuan = New DataTable 'combobox satuan
    Public pilihan_satuan As String
    Private Sub Form_barang_baru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        l_jud.Top = 60
        l_jud.Left = Me.Left / 2 - l_jud.Text.Length
        l_jud.TextAlign = ContentAlignment.MiddleCenter
        Waktu.Enabled = True
        If Form_main_menu.form_from = "UBAH HAPUS DATA" Then
            l_jud.Text = "Ubah / Hapus Data"
            bt_ok_ubah.Text = "Ubah"
            btn_daf_del.Text = "Hapus"
            btn_daf_del.BackColor = Color.Red
        ElseIf Form_main_menu.form_from = "DAFTARKAN BARANG BARU" Then
            l_jud.Text = "Daftarkan Barang Baru"
            btn_daf_del.Text = "Daftarkan Satuan Baru"
            btn_daf_del.BackColor = Color.Indigo
            bt_ok_ubah.Text = "OKE"
        End If
        'ComboBox
        dt_satuan = New DataTable
        query = "SELECT amount_type, type_name FROM amount_type ;"
        commmand = New MySqlCommand(query, connection)
        dataadap = New MySqlDataAdapter(commmand)
        dataadap.Fill(dt_satuan)
        cb_satuan.DataSource = dt_satuan
        cb_satuan.ValueMember = "amount_type"
        cb_satuan.DisplayMember = "type_name"
        cb_satuan.SelectedValue = Form_semua_data.pilihan_satuan
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
    Private Sub Waktu_Tick(sender As Object, e As EventArgs) Handles Waktu.Tick
        tb_day.Text = System.DateTime.Now.Day
        tb_mon.Text = MonthName(System.DateTime.Now.Month)
        tb_year.Text = System.DateTime.Now.Year
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click, btn_close.Click
        Me.Close()
    End Sub
    Private Sub btn_daf_del_Click(sender As Object, e As EventArgs) Handles btn_daf_del.Click
        Try
            If btn_daf_del.Text = "Daftarkan Satuan Baru" Then
                Form_Daftar_Satuan.ShowDialog()
            ElseIf btn_daf_del.Text = "Hapus" Then
                connection.Open()
                query = "Update from item set type_delete = 1 where item_id = '" + tb_kode.Text.ToString + "'"
                commmand = New MySqlCommand(query, connection)
                MsgBox(query)
                commmand.ExecuteNonQuery()
                MsgBox("Item berhasil dihapus")
                connection.Close()
            End If
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub bt_ok_ubah_click(sender As Object, e As EventArgs) Handles bt_ok_ubah.Click
        Try
            query = "UPDATE item SET item_name  = '" + tb_nama.Text.ToString + "', amount_type = '" + cb_satuan.SelectedValue + "' 
            WHERE item_id = '" + tb_kode.Text.ToString + "';"
            connection.Open()
            commmand = New MySqlCommand(query, connection)
            commmand.ExecuteNonQuery()
            MsgBox("SUKSES")
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
End Class