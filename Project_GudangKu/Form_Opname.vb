Public Class Form_Opname
    Dim movee As System.Drawing.Point
    Dim mpos As New Point
    Dim tim(2) As Integer 'waktu 0 jam, 1 menit, 2 detik
    Dim tiim(2) As String
    Private Sub Form_Opname_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panel_menu.BackColor = Color.FromArgb(30, 0, 0, 0)
        waktu.Enabled = True
        tb_ID.ForeColor = Color.White
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

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click, btn_close.Click
        Me.Close()
    End Sub
End Class