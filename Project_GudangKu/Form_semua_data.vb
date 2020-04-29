Imports MySql.Data.MySqlClient
Public Class Form_semua_data
    Dim conString As String = "server=localhost;uid=root;password=;database=gudang"
    Dim movee As System.Drawing.Point
    Dim mposition As Point
    Dim query As String
    Dim connection As New MySqlConnection(Form_main_menu.constring)
    Dim commmand As New MySqlCommand
    Dim dataadap As New MySqlDataAdapter
    Dim dt_data As New DataTable
    Dim dt_seluruhbarang As New DataTable
    Public pilihan_satuan As String
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
        Try
            query = "Select item_id `ID Barang`, item_name `Nama Barang`, amount `Jumlah`, amount_type `Satuan`, if(item_status = 0,'Tersedia','Tidak Tersedia') `Status Barang` from item;"
            commmand = New MySqlCommand(query, connection)
            dataadap = New MySqlDataAdapter(commmand)
            dataadap.Fill(dt_data)
            dgv.DataSource = dt_data
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If Form_main_menu.form_from = "UBAH HAPUS DATA" Then
            Try
                With Form_barang_baru
                    Form_barang_baru.tb_kode.Text = dgv.Rows(e.RowIndex).Cells(0).Value.ToString
                    Form_barang_baru.tb_nama.Text = dgv.Rows(e.RowIndex).Cells(1).Value.ToString

                    pilihan_satuan = dgv.Rows(e.RowIndex).Cells(3).Value.ToString
                End With
                Form_barang_baru.ShowDialog()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    'Private Sub Form_semua_data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    'If Form_main_menu.form_from = "UBAH HAPUS DATA" Then
    '    Call tampilkan_data_barang()
    '    'End If
    'End Sub
    'Private Sub textbox_search_TextChanged(sender As Object, e As EventArgs) Handles textbox_search.TextChanged
    '    If textbox_search.Text.Length > 0 Then
    '        Try
    '            dt_seluruhbarang = New DataTable
    '            query = "SELECT item_id `Kode`, item_name `Nama`, amount `Jumlah`, amount_type `Satuan`, if(item_status = 0,'Tersedia','Tidak Tersedia') `Status` FROM item WHERE item_name LIKE '%" + textbox_search.Text.ToString + "%' ;"
    '            commmand = New MySqlCommand(query, connection)
    '            dataadap = New MySqlDataAdapter(commmand)
    '            dataadap.Fill(dt_seluruhbarang)
    '            dgv.DataSource = dt_seluruhbarang
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    Else
    '        textbox_search.Text = ""
    '    End If
    'End Sub
    Private Sub textbox_search_TextChanged(sender As Object, e As EventArgs) Handles textbox_search.TextChanged
        If textbox_search.Text.Length <> 0 Then
            If Form_main_menu.form_from = "UBAH HAPUS DATA" Or Form_main_menu.form_from = "SELURUH BARANG" Then
                Try
                    dt_seluruhbarang = New DataTable
                    query = "SELECT item_id `ID Barang`, item_name `Nama Barang`, amount `Jumlah`, amount_type `Satuan`, item_status Status Barang
FROM item
WHERE item_name LIKE '%" + textbox_search.Text.ToString + "%'"
                    commmand = New MySqlCommand(query, connection)
                    dataadap = New MySqlDataAdapter(commmand)
                    dataadap.Fill(dt_seluruhbarang)
                    dgv.DataSource = dt_seluruhbarang
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            ElseIf Form_main_menu.form_from = "Daftar Satuan" Then
                Try
                    dt_seluruhbarang = New DataTable
                    query = "SELECT i1.item_name `Nama Barang (Satuan Besar)`, c1.amount `Konversi`, i2.item_name `Nama Barang (Satuan Kecil)`, c1.type_delete Hapus
FROM item i1, item i2, convert_data c1, convert_data c2
WHERE c1.item_id1 = i1.item_id AND c2.item_id1 = i2.item_id AND c1.item_id1 = c2.item_id1 AND (i1.item_name LIKE '%" + textbox_search.Text.ToString + "%' OR i2.item_name LIKE '%" + textbox_search.Text.ToString + "%');"
                    commmand = New MySqlCommand(query, connection)
                    dataadap = New MySqlDataAdapter(commmand)
                    dataadap.Fill(dt_seluruhbarang)
                    dgv.DataSource = dt_seluruhbarang
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            'textbox_search.Text = ""
            Form_semua_data_Load(sender, e)
        End If
    End Sub
    Sub Form_semua_data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form_main_menu.form_from = "UBAH HAPUS DATA" Then
            Call tampilkan_data_barang()
        ElseIf Form_main_menu.form_from = "Daftar Satuan" Then
            Call daftar_satuan()
        ElseIf Form_main_menu.form_from = "SELURUH BARANG" Then
            Call tampilkan_data_barang()
        End If
    End Sub
    Sub daftar_satuan()
        Try
            dt_data = New DataTable
            query = "SELECT i1.item_name `Nama Barang (Satuan Besar)`, c1.amount `Konversi`, i2.item_name `Nama Barang (Satuan Kecil)`, c1.type_delete Hapus
FROM item i1, item i2, convert_data c1, convert_data c2
WHERE c1.item_id1 = i1.item_id AND c2.item_id1 = i2.item_id AND c1.item_id1 = c2.item_id1;"
            commmand = New MySqlCommand(query, connection)
            dataadap = New MySqlDataAdapter(commmand)
            dataadap.Fill(dt_data)
            dgv.DataSource = dt_data
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class