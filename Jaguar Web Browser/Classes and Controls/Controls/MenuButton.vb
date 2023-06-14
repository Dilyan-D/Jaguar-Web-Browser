Public Class MenuButton
    Inherits PictureBox

    Public Sub New()

        Me.Size = New Size(32, 32)
        Me.BackColor = Color.Transparent
        Me.Image = My.Resources.Menu
        Me.SizeMode = PictureBoxSizeMode.Zoom

    End Sub

    Private Sub MenuButton_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseHover
        Me.Image = New Bitmap(My.Resources.Menu_1)
    End Sub

    Private Sub MenuButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        Me.Image = New Bitmap(My.Resources.Menu)
    End Sub
End Class
