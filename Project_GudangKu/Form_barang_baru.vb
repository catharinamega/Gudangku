Public Class Form_barang_baru
    Dim mposition As New Point
    Dim movee As System.Drawing.Point
    Private Sub Form_barang_baru_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class