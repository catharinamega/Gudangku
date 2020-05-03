Imports MySql.Data.MySqlClient
Public Class Form_Data_Turunan
    Dim movee As System.Drawing.Point
    Dim mpos As New Point
    Dim connection As New MySqlConnection(Form_main_menu.constring)
    Dim commmand As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim query As String
    Dim dt_satuan As New DataTable
    Dim dt_satuan2 As New DataTable
    Dim dt_satuan3 As New DataTable
    Dim dt_satuan4 As New DataTable
    Private Sub Form_Data_Turunan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dt_satuan = New DataTable
            query = "SELECT item_id, item_name FROM item;"
            commmand = New MySqlCommand(query, connection)
            adapter = New MySqlDataAdapter(commmand)
            adapter.Fill(dt_satuan)
            CB_itemBesar.DataSource = dt_satuan
            CB_itemBesar.DisplayMember = "item_name"
            CB_itemBesar.ValueMember = "item_id"
            TB_Jumlahbesar.Enabled = False
            Cb_satuanBesar.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            dt_satuan2 = New DataTable
            query = "SELECT item_id, item_name FROM item;"
            commmand = New MySqlCommand(query, connection)
            adapter = New MySqlDataAdapter(commmand)
            adapter.Fill(dt_satuan2)
            CB_itemKecil.DataSource = dt_satuan2
            CB_itemKecil.DisplayMember = "item_name"
            CB_itemKecil.ValueMember = "item_id"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CB_itemBesar_SelectedIndexChanged(sender, e)
        CB_itemKecil_SelectedIndexChanged(sender, e)

    End Sub

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
    Private Sub Form_Daftar_Satuan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panel_menu.BackColor = Color.FromArgb(30, 0, 0, 0)
    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click, btn_close.Click
        Me.Close()
    End Sub
    Private Sub btn_dafbar_Click(sender As Object, e As EventArgs) Handles btn_dafbar.Click
        With Form_main_menu
            .form_from = "DAFTARKAN BARANG BARU"
            Form_barang_baru.ShowDialog()
            .form_from = ""
        End With
    End Sub
    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Try
            connection.Open()
            query = "INSERT INTO convert_data 
            VALUES('" + CB_itemBesar.SelectedValue.ToString + "', 
            '" + TB_jumlahKecil.Text.ToString + "','" + CB_itemKecil.SelectedValue.ToString + "', 0)"
            commmand = New MySqlCommand(query, connection)
            commmand.ExecuteNonQuery()
            MsgBox("Data Turunan Berhasil Dimasukkan")
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub CB_itemBesar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_itemBesar.SelectedIndexChanged
        Try
            dt_satuan3 = New DataTable
            query = "SELECT i.item_id, type_name FROM item i, amount_type a WHERE i.amount_type = a.amount_type 
AND i.item_id = '" + CB_itemBesar.SelectedValue.ToString + "';"
            commmand = New MySqlCommand(query, connection)
            adapter = New MySqlDataAdapter(commmand)
            adapter.Fill(dt_satuan3)
            Cb_satuanBesar.DataSource = dt_satuan3
            Cb_satuanBesar.DisplayMember = "type_name"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub CB_itemKecil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_itemKecil.SelectedIndexChanged
        Try
            dt_satuan4 = New DataTable
            query = "SELECT i.item_id, type_name FROM item i, amount_type a WHERE i.amount_type = a.amount_type 
AND i.item_id = '" + CB_itemKecil.SelectedValue.ToString + "';"
            commmand = New MySqlCommand(query, connection)
            adapter = New MySqlDataAdapter(commmand)
            adapter.Fill(dt_satuan4)
            CB_satuanKecil.DataSource = dt_satuan4
            CB_satuanKecil.DisplayMember = "type_name"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class