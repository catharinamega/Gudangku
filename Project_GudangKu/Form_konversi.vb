Imports MySql.Data.MySqlClient
Public Class Form_konversi
    Dim movee As System.Drawing.Point
    Dim mpos As Point
    Dim connection As New MySqlConnection(Form_main_menu.constring)
    Dim command As New MySqlCommand
    Dim dataadap As New MySqlDataAdapter
    Dim query As String
    Dim dt_convert1 As New DataTable
    Dim dt_convert2 As New DataTable
    Dim dt_sat1 As New DataTable
    Dim dt_sat2 As New DataTable
    Dim dt_konversi As New DataTable
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
    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Try
            connection.Open()
            query = "UPDATE item SET amount = (amount-" + TB_Besar.Text.ToString + ") WHERE item_id = '" + CoBox_besar.SelectedValue.ToString + "'"
            command = New MySqlCommand(query, connection)
            command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message)
        End Try
        Try
            connection.Open()
            query = "UPDATE item SET amount = (amount+" + TB_kecil.Text.ToString + ") WHERE item_id = '" + CoBox_Kecil.SelectedValue.ToString + "'"
            command = New MySqlCommand(query, connection)
            command.ExecuteNonQuery()
            MsgBox("Data Turunan Berhasil Dikonversi")
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub CoBox_besar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CoBox_besar.SelectedIndexChanged
        dt_sat1 = New DataTable
        query = "SELECT i.amount_type, type_name FROM item i, amount_type a
WHERE i.item_id = '" + CoBox_besar.SelectedValue.ToString + "' AND i.amount_type = a.amount_type"
        command = New MySqlCommand(query, connection)
        dataadap = New MySqlDataAdapter(command)
        dataadap.Fill(dt_sat1)
        CoBox_satbesar.DataSource = dt_sat1
        CoBox_satbesar.DisplayMember = "type_name"
        CoBox_satbesar.ValueMember = "amount_type"

        dt_convert2 = New DataTable
        query = "SELECT item_name, item_id2 FROM item i, convert_data c WHERE i.item_id = c.item_id2 
AND c.item_id1 = '" + CoBox_besar.SelectedValue.ToString + "';"
        command = New MySqlCommand(query, connection)
        dataadap = New MySqlDataAdapter(command)
        dataadap.Fill(dt_convert2)
        CoBox_Kecil.DataSource = dt_convert2
        CoBox_Kecil.DisplayMember = "item_name"
        CoBox_Kecil.ValueMember = "item_id2"

    End Sub
    Private Sub Form_konversi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TB_kecil.Enabled = False
        dt_convert1 = New DataTable
        query = "SELECT item_name, item_id1 FROM item i, convert_data c WHERE i.item_id = c.item_id1;"
        command = New MySqlCommand(query, connection)
        dataadap = New MySqlDataAdapter(command)
        dataadap.Fill(dt_convert1)
        CoBox_besar.DataSource = dt_convert1
        CoBox_besar.DisplayMember = "item_name"
        CoBox_besar.ValueMember = "item_id1"

        CoBox_besar_SelectedIndexChanged(sender, e)


    End Sub

    Private Sub TB_Besar_TextChanged(sender As Object, e As EventArgs) Handles TB_Besar.TextChanged

        dt_konversi = New DataTable
        query = "SELECT amount FROM convert_data
WHERE item_id1 = '" + CoBox_besar.SelectedValue.ToString + "' AND item_id2 = '" + CoBox_Kecil.SelectedValue.ToString + "'"
        command = New MySqlCommand(query, connection)
        dataadap = New MySqlDataAdapter(command)
        dataadap.Fill(dt_konversi)

        If TB_Besar.Text <> "" Then
            TB_kecil.Text = (dt_konversi.Rows(0).Item(0).ToString) * TB_Besar.Text.ToString
        Else
            TB_kecil.Text = ""
        End If
    End Sub
    Private Sub CoBox_Kecil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CoBox_Kecil.SelectedIndexChanged
        dt_sat2 = New DataTable
        query = "SELECT i.amount_type, type_name FROM item i, amount_type a 
        WHERE i.item_id = '" + CoBox_Kecil.SelectedValue.ToString + "' AND i.amount_type = a.amount_type"
        command = New MySqlCommand(query, connection)
        dataadap = New MySqlDataAdapter(command)
        dataadap.Fill(dt_sat2)
        CoBox_satkecil.DataSource = dt_sat2
        CoBox_satkecil.DisplayMember = "type_name"
        CoBox_satkecil.ValueMember = "amount_type"
    End Sub
End Class