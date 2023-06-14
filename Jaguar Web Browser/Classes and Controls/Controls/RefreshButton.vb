Public Class RefreshButton
    Inherits PictureBox

    Public Sub New()

        Me.Size = New Size(26, 26)
        Me.BackColor = Color.FromArgb(227, 230, 232)
        Me.Image = My.Resources.Refresh
        Me.SizeMode = PictureBoxSizeMode.Zoom

    End Sub


    Private Sub RefreshButton_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseHover
        Me.Image = New Bitmap(My.Resources.Refresh_1)
    End Sub

    Private Sub RefreshButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        Me.Image = New Bitmap(My.Resources.Refresh)
    End Sub
End Class
