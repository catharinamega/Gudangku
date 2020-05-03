Imports MySql.Data.MySqlClient
Public Class form_login
    Dim mouse_move As System.Drawing.Point
    Dim mposition As New Point
    Dim connection As New MySqlConnection(Form_main_menu.constring)
    Dim command As New MySqlCommand
    Dim dataadap As New MySqlDataAdapter
    Dim query As String
    Dim dt_user As DataTable
    Dim Valid As Boolean
    Public staff_id As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles panel_menu.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles panel_menu.MouseDown
        mouse_move = New Point(-e.X, -e.Y)
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles panel_menu.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            mposition = New Point
            mposition = Control.MousePosition
            mposition.Offset(mouse_move.X, mouse_move.Y)
            Me.Location = mposition
        End If
    End Sub

    Private Sub form_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panel_menu.BackColor = Color.FromArgb(20, 0, 0, 0)
        tb_user.Text = ""
    End Sub
    Private Sub Button_Click_1(sender As Object, e As EventArgs) Handles btn_masuk.Click
        Try
            If tb_user.Text <> "" Then
                Valid = False
                dt_user = New DataTable
                query = "Select staff_id, staff_name, password from staff where staff_id = '" & tb_user.Text & "'"
                command = New MySqlCommand(query, connection)
                dataadap = New MySqlDataAdapter(command)
                dataadap.Fill(dt_user)
                If dt_user.Rows.Count > 0 Then
                    If tb_pass.Text = dt_user.Rows(0).Item(2).ToString Then
                        Form_main_menu.l1.Text = "Selamat Datang, " & dt_user.Rows(0).Item(1).ToString
                        staff_id = dt_user.Rows(0).Item(0).ToString
                        Form_main_menu.Show()
                    Else
                        With Form_message
                            .tombol = 1
                            .pesan = "Data Tidak Valid!"
                            .ShowDialog()
                        End With
                        'MsgBox("Data Tidak valid!", MsgBoxStyle.OkOnly)
                    End If
                Else
                    With Form_message
                        .tombol = 1
                        .pesan = "Data Tidak Valid!"
                        .ShowDialog()
                    End With
                    ' MsgBox("Data Tidak valid!", MsgBoxStyle.OkOnly)
                End If
            Else
                With Form_message
                    .tombol = 1
                    .pesan = "Data Tidak Valid!"
                    .ShowDialog()
                End With
                ' MsgBox("Data Tidak valid!", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
