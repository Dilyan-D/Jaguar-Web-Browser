Public Class MinimizeButton
    Inherits PictureBox

    Public Sub New()

        MyBase.New()

        Me.Size = New Size(25, 25)
        Me.BackColor = Color.Transparent
        Me.Image = My.Resources.Minimize
        Me.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub MinimizeButton_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseHover
        Me.Image = New Bitmap(My.Resources.Minimize_1)
    End Sub

    Private Sub MinimizeButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        Me.Image = New Bitmap(My.Resources.Minimize)
    End Sub

End Class
