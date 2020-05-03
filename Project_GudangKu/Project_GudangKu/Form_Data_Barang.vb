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
    Sub Form_Data_Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        waktu.Enabled = True
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
                dt_exit = New DataTable
                query = "SELECT incoming_id 
FROM item_incoming
 ;"
                commmand = New MySqlCommand(query, connection)
                dataadap = New MySqlDataAdapter(commmand)
                dataadap.Fill(dt_invoice)


                If dt_invoice.Rows.Count >= 9999 Then
                    autogenerateID = autogenerateID + (dt_exit.Rows.Count + 1).ToString
                ElseIf dt_invoice.Rows.Count >= 999 Then
                    autogenerateID = autogenerateID + "0" + (dt_exit.Rows.Count + 1).ToString
                ElseIf dt_invoice.Rows.Count >= 99 Then
                    autogenerateID = autogenerateID + "00" + (dt_exit.Rows.Count + 1).ToString
                ElseIf dt_invoice.Rows.Count >= 9 Then
                    autogenerateID = autogenerateID + "000" + (dt_exit.Rows.Count + 1).ToString
                ElseIf dt_exit.Rows.Count >= 0 Then
                    autogenerateID = autogenerateID + "0000" + (dt_exit.Rows.Count + 1).ToString
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
    Private Sub cb_nama_barang_SelectedIndexChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        Dim dt_satuan As New DataTable

        Try
            'DATA BARANG KELUAR
            If l_jud.Text = "Data Barang Keluar" Then
                'kolom kode
                If DataGridView1.Rows.Count > 1 Then
                    DataGridView1.Rows(e.RowIndex).Cells(1).Value = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                End If

                'kolom satuan
                If DataGridView1.Rows.Count > 1 Then
                    query = "SELECT amount_type
FROM item
WHERE item_id = '" + DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString + "' ;"
                    commmand = New MySqlCommand(query, connection)
                    dataadap = New MySqlDataAdapter(commmand)
                    dataadap.Fill(dt_satuan)

                    DataGridView1.Rows(e.RowIndex).Cells(3).Value = dt_satuan.Rows(0).Item(0).ToString
                End If

                'DATA BARANG MASUK
            ElseIf l_jud.Text = "Data Barang Masuk" Then
                'kolom kode
                If DataGridView1.Rows.Count > 1 Then
                    DataGridView1.Rows(e.RowIndex).Cells(1).Value = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                End If

                'kolom satuan
                If DataGridView1.Rows.Count > 1 Then
                    query = "SELECT amount_type
FROM item
WHERE item_id = '" + DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString + "' ;"
                    commmand = New MySqlCommand(query, connection)
                    dataadap = New MySqlDataAdapter(commmand)
                    dataadap.Fill(dt_satuan)

                    DataGridView1.Rows(e.RowIndex).Cells(3).Value = dt_satuan.Rows(0).Item(0).ToString
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
        tb_day.Text = System.DateTime.Now.Day
        tb_mon.Text = MonthName(System.DateTime.Now.Month)
        tb_year.Text = System.DateTime.Now.Year
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
    Private Sub btn_daftar_Click(sender As Object, e As EventArgs) Handles btn_daftar.Click
        With Form_main_menu
            .form_from = "DAFTARKAN BARANG BARU"
            Form_barang_baru.ShowDialog()
            .form_from = ""
        End With
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class