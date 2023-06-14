Public Class FindDialog

#Region "Design"

    Private Sub frmClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmClose.Click
        Me.Close()
    End Sub

    Private Sub frmClose_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles frmClose.MouseHover
        frmClose.Image = New Bitmap(My.Resources.Close_1)
    End Sub

    Private Sub frmClose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles frmClose.MouseLeave
        frmClose.Image = New Bitmap(My.Resources.Close)
    End Sub

#End Region

#Region "Events"

    Private Sub FindDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case My.Settings.Language
            Case 0
                English()
            Case 1
                Bulgarian()
        End Select
    End Sub

    Private Sub txtFileName_TextChanged(sender As Object, e As EventArgs) Handles txtFileName.TextChanged

    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

#End Region

#Region "Language"

    Sub English()

    End Sub

    Sub Bulgarian()

    End Sub

#End Region

End Class