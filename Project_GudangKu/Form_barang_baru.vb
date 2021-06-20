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
    Public kode As String
    Public panjang As Integer
    Dim autogenerate As String
    Dim dt_insert As New DataTable
    Dim aktiv As Integer
    'Private Sub bt_ok_ubah_click(sender As Object, e As EventArgs) Handles bt_ok_ubah.Click
    '    If Form_main_menu.form_from = "UBAH HAPUS DATA" Then
    '        Try
    '            If RB_bisagunakan.Checked = True Then
    '                aktiv = 0
    '            ElseIf RB_tidakdigunakan.Checked = True Then
    '                aktiv = 1
    '            End If
    '            query = "UPDATE item SET item_name  = '" + tb_nama.Text.ToString + "', amount_type = '" + cb_satuan.SelectedValue + "',
    '            item_status = '" + aktiv.ToString + "'
    '        WHERE item_id = '" + tb_kode.Text.ToString + "';"
    '            connection.Open()
    '            commmand = New MySqlCommand(query, connection)
    '            commmand.ExecuteNonQuery()
    '            With Form_message
    '                .tombol = 1
    '                .pesan = "SUKSES"
    '                .ShowDialog()
    '            End With
    '            'MsgBox("SUKSES")
    '            Form_semua_data.tampilkan_data_barang()
    '            connection.Close()
    '        Catch ex As Exception
    '            connection.Close()
    '            MsgBox(ex.Message)
    '        End Try
    '    ElseIf Form_main_menu.form_from = "DAFTARKAN BARANG BARU" Then
    '        Try
    '            dt_insert = New DataTable
    '            connection.Open()
    '            query = "INSERT INTO item VALUES('" + tb_kode.Text + "', '" + tb_nama.Text + " (" + (cb_satuan.SelectedValue.ToString) + ") " + " ',
    '                '""','" + cb_satuan.SelectedValue.ToString + "',0,0)"
    '            commmand = New MySqlCommand(query, connection)
    '            If tb_kode.Text = "" Or cb_satuan.SelectedItem.ToString = "" Or tb_nama.Text = "" Then
    '                'MsgBox("Data tidak lengkap!")
    '                With Form_message
    '                    .tombol = 1
    '                    .pesan = "Data tidak lengkap!"
    '                    .ShowDialog()
    '                End With
    '            ElseIf tb_kode.Text <> "" Or cb_satuan.SelectedItem.ToString <> "" Or tb_nama.Text <> "" Then
    '                Dim result As DialogResult = MsgBox("Are You Sure?'", MsgBoxStyle.YesNo)
    '                If result = DialogResult.Yes Then
    '                    ' MsgBox("Inserting data success!", MsgBoxStyle.OkOnly)
    '                    commmand.ExecuteNonQuery()
    '                    With Form_message
    '                        .tombol = 1
    '                        .pesan = "Inserting data success!"
    '                        .ShowDialog()
    '                    End With
    '                ElseIf result = DialogResult.No Then
    '                    ' MsgBox("Inserting data canceled!", MsgBoxStyle.OkOnly)
    '                    With Form_message
    '                        .tombol = 1
    '                        .pesan = "Inserting data canceled!"
    '                        .ShowDialog()
    '                    End With
    '                End If
    '            End If
    '            connection.Close()
    '        Catch ex As Exception
    '            connection.Close()
    '            MsgBox(ex.Message)
    '        End Try
    '    End If
    'End Sub
    Sub tb_nama_TextChanged(sender As Object, e As EventArgs) Handles tb_nama.Leave
        Try
            If Form_main_menu.form_from = "DAFTARKAN BARANG BARU" Then
                autogenerate = ""
                dt_insert = New DataTable
                panjang = tb_nama.Text.Length
                kode = tb_nama.Text.Substring(0, 3) + tb_nama.Text.Substring(panjang - 2, 2).ToString
                tb_kode.Text = kode.ToString.ToUpper
                query = "SELECT * FROM  item WHERE item_name LIKE '" + kode + "%'"
                commmand = New MySqlCommand(query, connection)
                dataadap = New MySqlDataAdapter(commmand)
                dataadap.Fill(dt_insert)
                tb_kode.Text = tb_kode.Text + autogenerate
                If dt_insert.Rows.Count >= 99 Then
                    autogenerate = autogenerate + (dt_insert.Rows.Count + 1).ToString
                ElseIf dt_insert.Rows.Count >= 9 Then
                    autogenerate = autogenerate + "0" + (dt_insert.Rows.Count + 1).ToString
                ElseIf dt_insert.Rows.Count >= 0 Then
                    autogenerate = autogenerate + "00" + (dt_insert.Rows.Count + 1).ToString
                End If
                tb_kode.Text = tb_kode.Text + autogenerate
            End If
        Catch ex As Exception
            If tb_nama.Text.Length <> 0 Then
                MsgBox(ex.Message)
            Else
                tb_kode.Text = ""
            End If
        End Try
    End Sub
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
        If Form_main_menu.form_from = "UBAH HAPUS DATA" Then
            cb_satuan.SelectedValue = Form_semua_data.pilihan_satuan
        End If
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
                'MsgBox("Item berhasil dihapus")
                With Form_message
                    .tombol = 1
                    .pesan = "Item berhasil dihapus"
                    .ShowDialog()
                End With
                connection.Close()
            End If
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
    'Private Sub bt_ok_ubah_click(sender As Object, e As EventArgs) Handles bt_ok_ubah.Click
    '    Try
    '        query = "UPDATE item SET item_name  = '" + tb_nama.Text.ToString + "', amount_type = '" + cb_satuan.SelectedValue + "' 
    '        WHERE item_id = '" + tb_kode.Text.ToString + "';"
    '        connection.Open()
    '        commmand = New MySqlCommand(query, connection)
    '        commmand.ExecuteNonQuery()
    '        MsgBox("SUKSES")
    '        connection.Close()
    '    Catch ex As Exception
    '        connection.Close()
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    Private Sub bt_ok_ubah_click(sender As Object, e As EventArgs) Handles bt_ok_ubah.Click
        If Form_main_menu.form_from = "UBAH HAPUS DATA" Then
            Try
                If RB_bisagunakan.Checked = True Then
                    aktiv = 0
                ElseIf RB_tidakdigunakan.Checked = True Then
                    aktiv = 1
                End If
                query = "UPDATE item SET item_name  = '" + tb_nama.Text + " (" + (cb_satuan.SelectedValue.ToString) + ")" + "', amount_type = '" + cb_satuan.SelectedValue + "',
                item_status = '" + aktiv.ToString + "'
            WHERE item_id = '" + tb_kode.Text.ToString + "';"
                connection.Open()
                commmand = New MySqlCommand(query, connection)
                commmand.ExecuteNonQuery()
                'MsgBox("SUKSES")
                With Form_message
                    .pesan = "SUKSES"
                    .tombol = 1
                    .ShowDialog()
                End With
                Form_semua_data.tampilkan_data_barang()
                connection.Close()
            Catch ex As Exception
                connection.Close()
                MsgBox(ex.Message)
            End Try
        ElseIf Form_main_menu.form_from = "DAFTARKAN BARANG BARU" Then
            Try
                If RB_bisagunakan.Checked = True Then
                    aktiv = 0
                ElseIf RB_tidakdigunakan.Checked = True Then
                    aktiv = 1
                End If
                dt_insert = New DataTable
                connection.Open()
                query = "INSERT INTO item VALUES('" + tb_kode.Text + "', '" + tb_nama.Text + " (" + (cb_satuan.SelectedValue.ToString) + ")" + " ',
                    '""','" + cb_satuan.SelectedValue.ToString + "', " + aktiv.ToString + ",0)"
                commmand = New MySqlCommand(query, connection)
                If tb_kode.Text = "" Or cb_satuan.SelectedItem.ToString = "" Or tb_nama.Text = "" Then
                    'MsgBox("Data tidak lengkap!")
                    With Form_message
                        .pesan = "Data tidak lengkap!"
                        .tombol = 1
                        .ShowDialog()
                    End With
                ElseIf tb_kode.Text <> "" Or cb_satuan.SelectedItem.ToString <> "" Or tb_nama.Text <> "" Then
                    'Dim result As DialogResult = MsgBox("Are You Sure?'", MsgBoxStyle.YesNo)
                    'If result = DialogResult.Yes Then
                    '    MsgBox("Inserting data success!", MsgBoxStyle.OkOnly)
                    '    commmand.ExecuteNonQuery()
                    'ElseIf result = DialogResult.No Then
                    '    MsgBox("Inserting data canceled!", MsgBoxStyle.OkOnly)
                    'End If
                    With Form_message
                        .pesan = "Are You Sure?"
                        .tombol = 2
                        .ShowDialog()
                        If .hasil = True Then
                            .pesan = "Inserting data success!"
                            .tombol = 1
                            .ShowDialog()
                        ElseIf .hasil = False Then
                            .pesan = "Inserting data canceled!"
                            .tombol = 1
                            .ShowDialog()
                        End If
                    End With
                End If
                connection.Close()
            Catch ex As Exception
                connection.Close()
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class