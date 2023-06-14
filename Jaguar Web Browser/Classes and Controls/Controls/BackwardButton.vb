Public Class BackwardButton
    Inherits PictureBox

    Public Sub New()

        Me.Size = New Size(60, 60)
        Me.BackColor = Color.Transparent
        Me.Image = My.Resources.Backward
        Me.SizeMode = PictureBoxSizeMode.Zoom

    End Sub

    Private Sub BackwardButton_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseHover
        Me.Image = New Bitmap(My.Resources.Backward_1)
    End Sub

    Private Sub BackwardButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        Me.Image = New Bitmap(My.Resources.Backward)
    End Sub
End Class
