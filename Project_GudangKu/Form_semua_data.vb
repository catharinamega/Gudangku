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
    Dim hapusini As String
    Public barangID As String
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
            dt_data = New DataTable
            query = "select  i.item_id `ID Barang`, i.item_name `Nama Barang`, i.amount  + sum(if(i.item_id = di.item_id,di.amount,0)) - sum(if(de.item_id = i.item_id,de.amount ,0)) `Jumlah`,amount_type `Satuan`, if(item_status = 0,'Tersedia','Tidak Tersedia') `Status Barang`
From item i left Join dincoming di on i.item_id = di.item_id left Join dexit de on de.item_id = i.item_id
Group By i.item_id"
            commmand = New MySqlCommand(query, connection)
            dataadap = New MySqlDataAdapter(commmand)
            dataadap.Fill(dt_data)
            dgv.DataSource = dt_data
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
    '    If Form_main_menu.form_from = "UBAH HAPUS DATA" Then
    '        Try
    '            With Form_barang_baru
    '                Form_barang_baru.tb_kode.Text = dgv.Rows(e.RowIndex).Cells(0).Value.ToString
    '                Form_barang_baru.tb_nama.Text = dgv.Rows(e.RowIndex).Cells(1).Value.ToString
    '                pilihan_satuan = dgv.Rows(e.RowIndex).Cells(3).Value.ToString
    '                pilihan_satuan = dgv.Rows(e.RowIndex).Cells(3).Value.ToString
    '                hapusini = " (" + pilihan_satuan + ")"
    '                Form_barang_baru.tb_kode.Text = dgv.Rows(e.RowIndex).Cells(0).Value.ToString
    '                Form_barang_baru.tb_nama.Text = dgv.Rows(e.RowIndex).Cells(1).Value.ToString.Replace(hapusini, "")
    '            End With
    '            Form_barang_baru.ShowDialog()
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    ElseIf Form_main_menu.form_from = "Stok Opname" Then
    '        With Form_Opname
    '            .ShowDialog()
    '        End With
    '    End If
    'End Sub
    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If Form_main_menu.form_from = "UBAH HAPUS DATA" Then
            Try
                With Form_barang_baru
                    .tb_kode.Text = dgv.Rows(e.RowIndex).Cells(0).Value.ToString
                    .tb_nama.Text = dgv.Rows(e.RowIndex).Cells(1).Value.ToString
                    pilihan_satuan = dgv.Rows(e.RowIndex).Cells(3).Value.ToString

                    If dgv.Rows(e.RowIndex).Cells(4).Value.ToString = "Tersedia" Then
                        .RB_bisagunakan.Checked = True
                    ElseIf dgv.Rows(e.RowIndex).Cells(4).Value.ToString = "Tidak Tersedia" Then
                        .RB_tidakdigunakan.Checked = True
                    End If
                End With

                With Form_barang_baru
                    pilihan_satuan = dgv.Rows(e.RowIndex).Cells(3).Value.ToString
                    hapusini = " (" + pilihan_satuan + ")"
                    .tb_kode.Text = dgv.Rows(e.RowIndex).Cells(0).Value.ToString
                    .tb_nama.Text = dgv.Rows(e.RowIndex).Cells(1).Value.ToString.Replace(hapusini, "")
                End With

                Form_barang_baru.ShowDialog()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf Form_main_menu.form_from = "Stok Opname" Then
            With Form_Opname
                barangID = dgv.Rows(e.RowIndex).Cells(0).Value.ToString
                .cb_nama.Text = dgv.Rows(e.RowIndex).Cells(1).Value.ToString
                .cb_sat.Text = dgv.Rows(e.RowIndex).Cells(3).Value.ToString
                .TB_sistem.Text = dgv.Rows(e.RowIndex).Cells(2).Value.ToString
                .ShowDialog()
            End With
        End If
    End Sub
    Private Sub textbox_search_TextChanged(sender As Object, e As EventArgs) Handles textbox_search.TextChanged
        If textbox_search.Text.Length <> 0 Then
            If Form_main_menu.form_from = "UBAH HAPUS DATA" Or Form_main_menu.form_from = "SELURUH BARANG" Or Form_main_menu.form_from = "Stok Opname" Then
                Try
                    dt_seluruhbarang = New DataTable
                    query = "SELECT i.item_id `ID Barang`, i.item_name `Nama Barang`, i.amount  + sum(if(i.item_id = di.item_id,di.amount,0)) - sum(if(de.item_id = i.item_id,de.amount ,0)) `Jumlah`, amount_type `Satuan`, if(item_status = 0,'Tersedia','Tidak Tersedia') `Status Barang`
FROM item i left join dincoming di on i.item_id = di.item_id left join dexit de on de.item_id = i.item_id
WHERE i.item_name LIKE '%" + textbox_search.Text.ToString + "%' Group by i.item_id"
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
        ElseIf Form_main_menu.form_from = "Stok Opname" Then
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