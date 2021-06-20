Imports MySql.Data.MySqlClient
Public Class Form_Opname
    Dim movee As System.Drawing.Point
    Dim mpos As New Point
    Dim tim(2) As Integer 'waktu 0 jam, 1 menit, 2 detik
    Dim tiim(2) As String
    Public query As String
    Public connection As New MySqlConnection(Form_main_menu.constring)
    Public commmand As New MySqlCommand
    Public dataadap As New MySqlDataAdapter
    Dim autogen As String
    Dim dt_opname As New DataTable
    Dim day As String
    Dim bulan As String
    Dim tanggal As String
    Dim waktuoi As String

    Private Sub Form_Opname_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panel_menu.BackColor = Color.FromArgb(30, 0, 0, 0)
        waktu.Enabled = True
        tb_ID.ForeColor = Color.White


        'autogenerate ID nya
        autogen = ""
        dt_opname = New DataTable
        query = "SELECT opname_id FROM stock_opname;"
        commmand = New MySqlCommand(query, connection)
        dataadap = New MySqlDataAdapter(commmand)
        dataadap.Fill(dt_opname)
        If dt_opname.Rows.Count >= 9999 Then
            autogen = autogen + (dt_opname.Rows.Count + 1).ToString
        ElseIf dt_opname.Rows.Count >= 999 Then
            autogen = autogen + "0" + (dt_opname.Rows.Count + 1).ToString
        ElseIf dt_opname.Rows.Count >= 99 Then
            autogen = autogen + "00" + (dt_opname.Rows.Count + 1).ToString
        ElseIf dt_opname.Rows.Count >= 9 Then
            autogen = autogen + "000" + (dt_opname.Rows.Count + 1).ToString
        ElseIf dt_opname.Rows.Count >= 0 Then
            autogen = autogen + "0000" + (dt_opname.Rows.Count + 1).ToString
        End If
        tb_ID.Text = "OP" & autogen

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

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click, btn_close.Click
        Me.Close()
    End Sub


    Private Sub TB_riil_TextChanged(sender As Object, e As EventArgs) Handles TB_riil.TextChanged
        If TB_riil.Text <> "" Then
            If TB_sistem.Text.ToString - TB_riil.Text.ToString >= 0 Then
                TB_Selisih.Text = TB_sistem.Text.ToString - TB_riil.Text.ToString
            ElseIf TB_sistem.Text.ToString - TB_riil.Text.ToString < 0 Then
                TB_Selisih.Text = TB_riil.Text.ToString - TB_sistem.Text.ToString
            End If
        Else
            TB_Selisih.Text = ""
        End If

    End Sub

    Private Sub btn_masuk_Click(sender As Object, e As EventArgs) Handles btn_masuk.Click
        Try
            query = "INSERT INTO stock_opname VALUES('" + tb_ID.Text.ToString + "', '" + form_login.staff_id.ToString + "',
'" + Form_semua_data.barangID.ToString + "', " + TB_sistem.Text.ToString + ", " + TB_riil.Text.ToString + ", " + TB_Selisih.Text.ToString + ",
'" + TB_keterangan.Text.ToString + "', '" + tanggal.ToString + "', '" + waktuoi.ToString + "', 0, 0)"
            connection.Open()
            commmand = New MySqlCommand(query, connection)
            commmand.ExecuteNonQuery()
            'MsgBox("SUKSES")
            With Form_message
                .pesan = "SUKSES"
                .tombol = 1
                .ShowDialog()
            End With
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
End Class