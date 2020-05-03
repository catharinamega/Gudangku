Imports MySql.Data.MySqlClient
Public Class Form_Daftar_Satuan
    Dim movee As System.Drawing.Point
    Dim mpos As New Point
    Dim sqlconnect As New MySqlConnection(Form_main_menu.constring)
    Dim sqlQuery As String
    Dim sqlcommand As New MySqlCommand
    Dim bisadipakai As String
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
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click, btn_back.Click
        Me.Close()
    End Sub
    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If RB_bisagunakan.Checked = True Then
            bisadipakai = 0
        ElseIf RB_tidakdigunakan.Checked = True Then
            bisadipakai = 1
        End If
        Try
            sqlconnect.Open()
            sqlQuery = "INSERT INTO amount_type
VALUES('" + TB_singkatan.Text.ToString + "', '" + TB_satuan.Text.ToString + "', '" + bisadipakai + "', 0)"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconnect)
            sqlcommand.ExecuteNonQuery()
            With Form_message
                .tombol = 1
                .pesan = "Data Satuan Baru Berhasil Dimasukkan"
                .ShowDialog()
            End With
            'MsgBox("Data Satuan Baru Berhasil Dimasukkan")
            sqlconnect.Close()
        Catch ex As Exception
            sqlconnect.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
End Class