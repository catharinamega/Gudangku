Public Class Form_Data_Barang
    Dim colorback As New Color
    Dim mposition As New Point
    Dim movee As System.Drawing.Point


    Private Sub Form_Data_Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class