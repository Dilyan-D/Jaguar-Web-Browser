Public Class StopButton
    Inherits PictureBox

    Public Sub New()

        Me.Size = New Size(26, 26)
        Me.BackColor = Color.FromArgb(227, 230, 232)
        Me.Image = My.Resources.Button_stop
        Me.SizeMode = PictureBoxSizeMode.Zoom

    End Sub

    Private Sub StopButton_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseHover
        Me.Image = New Bitmap(My.Resources.Button_stop_1)
    End Sub

    Private Sub StopButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        Me.Image = New Bitmap(My.Resources.Button_stop)
    End Sub
End Class
