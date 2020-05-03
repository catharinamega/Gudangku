Imports MySql.Data.MySqlClient
Public Class Form_Data_Barang
    Dim colorback As New Color
    Dim mposition As New Point
    Dim movee As System.Drawing.Point
    Dim tim(2) As Integer
    Dim tiim(2) As String
    Public autogenerateID As String
    Public dt_exit As New DataTable

    Public query As String
    Public connection As New MySqlConnection(Form_main_menu.constring)
    Public commmand As New MySqlCommand
    Public dataadap As New MySqlDataAdapter
    Public dt_satuan As New DataTable
    Public dt_nama As New DataTable
    Public dt_invoice As New DataTable

    Public total As Integer

    Public day As String
    Public bulan As String
    Public tanggal As String
    Public waktuoi As String
    Sub Form_Data_Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        waktu.Enabled = True
        dgv.Rows.Clear()
        'DATA BARANG KELUAR
        If l_jud.Text = "Data Barang Keluar" Then
            Try
                'INVOICE DATA BARANG KELUAR
                autogenerateID = ""
                dt_exit = New DataTable
                query = "SELECT exit_id FROM item_exit;"
                commmand = New MySqlCommand(query, connection)
                dataadap = New MySqlDataAdapter(commmand)
                dataadap.Fill(dt_exit)


                If dt_exit.Rows.Count >= 9999 Then
                    autogenerateID = autogenerateID + (dt_exit.Rows.Count + 1).ToString
                ElseIf dt_exit.Rows.Count >= 999 Then
                    autogenerateID = autogenerateID + "0" + (dt_exit.Rows.Count + 1).ToString
                ElseIf dt_exit.Rows.Count >= 99 Then
                    autogenerateID = autogenerateID + "00" + (dt_exit.Rows.Count + 1).ToString
                ElseIf dt_exit.Rows.Count >= 9 Then
                    autogenerateID = autogenerateID + "000" + (dt_exit.Rows.Count + 1).ToString
                ElseIf dt_exit.Rows.Count >= 0 Then
                    autogenerateID = autogenerateID + "0000" + (dt_exit.Rows.Count + 1).ToString
                End If
                tb_inv.Text = "EX" + autogenerateID

                'COMBOBOX NAMA DGV
                dt_nama = New DataTable
                query = "SELECT item_id, item_name
FROM item;"

                commmand = New MySqlCommand(query, connection)
                dataadap = New MySqlDataAdapter(commmand)
                dataadap.Fill(dt_nama)
                cb_nama_barang.DataSource = dt_nama
                cb_nama_barang.ValueMember = "item_id"
                cb_nama_barang.DisplayMember = "item_name"



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            'DATA BARANG MASUK
        ElseIf l_jud.Text = "Data Barang Masuk" Then
            Try
                'INVOICE DATA BARANG MASUK
                autogenerateID = ""
                dt_invoice = New DataTable
                query = "SELECT incoming_id 
FROM item_incoming
 ;"
                commmand = New MySqlCommand(query, connection)
                dataadap = New MySqlDataAdapter(commmand)
                dataadap.Fill(dt_invoice)


                If dt_invoice.Rows.Count >= 9999 Then
                    autogenerateID = autogenerateID + (dt_invoice.Rows.Count + 1).ToString
                ElseIf dt_invoice.Rows.Count >= 999 Then
                    autogenerateID = autogenerateID + "0" + (dt_invoice.Rows.Count + 1).ToString
                ElseIf dt_invoice.Rows.Count >= 99 Then
                    autogenerateID = autogenerateID + "00" + (dt_invoice.Rows.Count + 1).ToString
                ElseIf dt_invoice.Rows.Count >= 9 Then
                    autogenerateID = autogenerateID + "000" + (dt_invoice.Rows.Count + 1).ToString
                ElseIf dt_exit.Rows.Count >= 0 Then
                    autogenerateID = autogenerateID + "0000" + (dt_invoice.Rows.Count + 1).ToString
                End If
                tb_inv.Text = "IN" + autogenerateID

                'COMBOBOX NAMA DGV
                dt_nama = New DataTable
                query = "SELECT item_id, item_name
FROM item;"

                commmand = New MySqlCommand(query, connection)
                dataadap = New MySqlDataAdapter(commmand)
                dataadap.Fill(dt_nama)
                cb_nama_barang.DataSource = dt_nama
                cb_nama_barang.ValueMember = "item_id"
                cb_nama_barang.DisplayMember = "item_name"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub cb_nama_barang_SelectedIndexChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellValueChanged
        Dim dt_satuan As New DataTable

        Try
            'DATA BARANG KELUAR
            If l_jud.Text = "Data Barang Keluar" Then
                'kolom kode
                If dgv.Rows.Count > 1 Then
                    dgv.Rows(e.RowIndex).Cells(1).Value = dgv.Rows(e.RowIndex).Cells(0).Value.ToString
                End If

                'kolom satuan
                If dgv.Rows.Count > 1 Then
                    query = "SELECT amount_type
FROM item
WHERE item_id = '" + dgv.Rows(e.RowIndex).Cells(0).Value.ToString + "' ;"
                    commmand = New MySqlCommand(query, connection)
                    dataadap = New MySqlDataAdapter(commmand)
                    dataadap.Fill(dt_satuan)

                    dgv.Rows(e.RowIndex).Cells(3).Value = dt_satuan.Rows(0).Item(0).ToString
                End If

                'DATA BARANG MASUK
            ElseIf l_jud.Text = "Data Barang Masuk" Then
                'kolom kode
                If dgv.Rows.Count > 1 Then
                    dgv.Rows(e.RowIndex).Cells(1).Value = dgv.Rows(e.RowIndex).Cells(0).Value.ToString
                End If

                'kolom satuan
                If dgv.Rows.Count > 1 Then
                    query = "SELECT amount_type
FROM item
WHERE item_id = '" + dgv.Rows(e.RowIndex).Cells(0).Value.ToString + "' ;"
                    commmand = New MySqlCommand(query, connection)
                    dataadap = New MySqlDataAdapter(commmand)
                    dataadap.Fill(dt_satuan)

                    dgv.Rows(e.RowIndex).Cells(3).Value = dt_satuan.Rows(0).Item(0).ToString
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub panel_menu_MouseMove(sender As Object, e As MouseEventArgs) Handles panel_menu.MouseMove
        If e.Button = MouseButtons.Left Then
            mposition = New Point
            mposition = MousePosition
            mposition.Offset(movee.X, movee.Y)
            Me.Location = mposition
        End If
    End Sub
    Private Sub panel_menu_MouseDown(sender As Object, e As MouseEventArgs) Handles panel_menu.MouseDown
        movee = New Point(-e.X, -e.Y)
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
    Private Sub waktu_Tick(sender As Object, e As EventArgs) Handles waktu.Tick
        If System.DateTime.Now.Day < 10 Then
            day = "0" & System.DateTime.Now.Day.ToString
        ElseIf System.DateTime.Now.Day >= 10 Then
            day = System.DateTime.Now.Day
        End If
        tb_day.Text = day
        tb_mon.Text = MonthName(System.DateTime.Now.Month)
        If System.DateTime.Now.Month < 10 Then
            bulan = "0" & System.DateTime.Now.Month.ToString
        ElseIf System.DateTime.Now.Month >= 10 Then
            bulan = System.DateTime.Now.Month
        End If
        tb_year.Text = System.DateTime.Now.Year
        tanggal = (tb_year.Text & "-" & bulan & "-" & tb_day.Text).ToString

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
        waktuoi = tiim(0) & ":" & tiim(1)
    End Sub
    Private Sub btn_daftar_Click(sender As Object, e As EventArgs) Handles btn_daftar.Click
        With Form_main_menu
            .form_from = "DAFTARKAN BARANG BARU"
            Form_barang_baru.ShowDialog()
            .form_from = ""
        End With
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        'Form_main_menu(sender, e)
    End Sub

    Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click

        If l_jud.Text = "Data Barang Masuk" Then
            'insert di item_incoming
            connection.Open()
            query = "INSERT INTO item_incoming 
VALUES ('" + tb_inv.Text.ToString + "','" + form_login.staff_id + "','" + tanggal.ToString + "','" + waktuoi.ToString + "',0,0)"
            commmand = New MySqlCommand(query, connection)
            ' MsgBox(query)
            commmand.ExecuteNonQuery()
            ' MsgBox("DATA BERHASIL DIINPUT")
            connection.Close()

            'insert di dincoming
            total = dgv.Rows.Count
            For i = 0 To total - 2
                connection.Open()
                query = "INSERT INTO dincoming
VALUES('" + tb_inv.Text.ToString + "','" + dgv.Rows(i).Cells(1).Value.ToString + "','" + dgv.Rows(i).Cells(2).Value.ToString + "'); "
                commmand = New MySqlCommand(query, connection)
                'MsgBox(query)
                commmand.ExecuteNonQuery()
                'MsgBox("DATA BERHASIL DIINPUT")
                connection.Close()
            Next
            With Form_message
                .tombol = 1
                .pesan = "DATA BERHASIL DIINPUT"
                .ShowDialog()
            End With
            ' MsgBox("DATA BERHASIL DIINPUT")
        ElseIf l_jud.Text = "Data Barang Keluar" Then
            'insert di item_exit
            connection.Open()
            query = "INSERT INTO item_exit 
VALUES ('" + tb_inv.Text.ToString + "','" + form_login.staff_id + "','" + tanggal.ToString + "','" + waktuoi.ToString + "',0,0)"
            commmand = New MySqlCommand(query, connection)
            'MsgBox(query)
            commmand.ExecuteNonQuery()
            'MsgBox("DATA BERHASIL DIINPUT")
            connection.Close()

            'insert di dexit
            total = dgv.Rows.Count
            For i = 0 To total - 2
                connection.Open()
                query = "INSERT INTO dexit
VALUES('" + tb_inv.Text.ToString + "','" + dgv.Rows(i).Cells(1).Value.ToString + "','" + dgv.Rows(i).Cells(2).Value.ToString + "'); "
                commmand = New MySqlCommand(query, connection)
                'MsgBox(query)
                commmand.ExecuteNonQuery()
                'MsgBox("DATA BERHASIL DIINPUT")
                connection.Close()
            Next
            With Form_message
                .tombol = 2
                .pesan = "DATA BERHASIL DIMASUKKAN. PRINT NOTA?"
                .ShowDialog()
                If .hasil = True Then
                    MsgBox("Data Akan diprint")
                End If
            End With
            'MessageBox.Show("DATA BERHASIL DIMASUKKAN. PRINT NOTA?", "REQUEST", MessageBoxButtons.YesNo)
        End If

    End Sub
End Class
