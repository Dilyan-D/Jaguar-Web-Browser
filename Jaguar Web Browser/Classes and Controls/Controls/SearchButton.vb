Public Class SearchButton
    Inherits PictureBox

    Public Sub New()

        Me.Size = New Size(26, 26)
        Me.BackColor = Color.FromArgb(227, 230, 232)
        Me.Image = My.Resources.Icon_search
        Me.SizeMode = PictureBoxSizeMode.Zoom

    End Sub

    Private Sub SearchButton_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseHover
        Me.Image = New Bitmap(My.Resources.Icon_search_1)
    End Sub

    Private Sub SearchButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        Me.Image = New Bitmap(My.Resources.Icon_search)
    End Sub
End Class
