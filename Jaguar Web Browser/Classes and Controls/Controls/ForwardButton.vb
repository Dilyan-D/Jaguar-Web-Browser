Public Class ForwardButton
    Inherits PictureBox

    Public Sub New()

        Me.Size = New Size(40, 39)
        Me.BackColor = Color.Transparent
        Me.Image = My.Resources.Forward
        Me.SizeMode = PictureBoxSizeMode.Zoom

    End Sub

    Private Sub ForwardButton_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseHover
        Me.Image = New Bitmap(My.Resources.Forward_1)
    End Sub

    Private Sub ForwardButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        Me.Image = New Bitmap(My.Resources.Forward)
    End Sub
End Class
