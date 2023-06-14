Public Class CloseButton
    Inherits PictureBox

    Public Sub New()

        MyBase.New()

        Me.Size = New Size(25, 25)
        Me.BackColor = Color.Transparent
        Me.Image = My.Resources.Close
        Me.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub CloseButton_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseHover
        Me.Image = New Bitmap(My.Resources.Close_1)
    End Sub

    Private Sub CloseButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        Me.Image = New Bitmap(My.Resources.Close)
    End Sub
End Class
