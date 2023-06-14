Public Class HomeButton
    Inherits PictureBox

    Public Sub New()

        Me.Size = New Size(35, 34)
        Me.BackColor = Color.Transparent
        Me.Image = My.Resources.Home
        Me.SizeMode = PictureBoxSizeMode.Zoom

    End Sub

    Private Sub HomeButton_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseHover
        Me.Image = New Bitmap(My.Resources.Home_1)
    End Sub

    Private Sub HomeButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        Me.Image = New Bitmap(My.Resources.Home)
    End Sub
End Class
