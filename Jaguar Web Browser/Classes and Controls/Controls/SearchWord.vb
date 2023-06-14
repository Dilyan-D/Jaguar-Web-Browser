Public Class SearchWord

    Private Sub SearchWord_Load(sender As Object, e As EventArgs) Handles Me.Load
        Select Case My.Settings.Language
            Case 0
                txtSearchWord.Text = "Ex: dog"
            Case 1
                txtSearchWord.Text = "Например: куче"
        End Select
    End Sub

    Private Sub btnCloseSearchWord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseSearchWord.Click

        If MainForm.SearchWord.Visible = True Then
            MainForm.SearchPanel.Size = New Size(MainForm.SearchPanel.Width + 270, MainForm.SearchPanel.Height)
            MainForm.SearchWord.Visible = False
        Else
            MainForm.SearchWord.Visible = True
            MainForm.SearchPanel.Size = New Size(MainForm.SearchPanel.Width - 270, MainForm.SearchPanel.Height)
        End If


        If IncognitoForm.SearchWord.Visible = False Then
            IncognitoForm.SearchPanel.Size = New Size(IncognitoForm.SearchPanel.Width - 270, IncognitoForm.SearchPanel.Height)
            MainForm.SearchWord.Visible = True
        Else
            IncognitoForm.SearchWord.Visible = False
            IncognitoForm.SearchPanel.Size = New Size(IncognitoForm.SearchPanel.Width + 270, IncognitoForm.SearchPanel.Height)
        End If

    End Sub

    Private Sub txtSearchWord_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchWord.GotFocus
        Select Case My.Settings.Language
            Case 0
                If txtSearchWord.Text = "Ex: dog" Then
                    txtSearchWord.Text = ""
                    txtSearchWord.Font = New Font("Verdana", 11.5)
                    txtSearchWord.ForeColor = Color.Black
                End If

            Case 1
                If txtSearchWord.Text = "Например: куче" Then
                    txtSearchWord.Text = ""
                    txtSearchWord.Font = New Font("Verdana", 11.5)
                    txtSearchWord.ForeColor = Color.Black
                End If
        End Select
    End Sub

    Private Sub txtSearchWord_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchWord.LostFocus
        Select Case My.Settings.Language
            Case 0
                If txtSearchWord.Text = "" Then
                    txtSearchWord.Text = "Ex: dog"
                    txtSearchWord.Font = New Font("Verdana", 11.5, FontStyle.Italic)
                    txtSearchWord.ForeColor = Color.Silver
                End If

            Case 1
                If txtSearchWord.Text = "" Then
                    txtSearchWord.Text = "Например: куче"
                    txtSearchWord.Font = New Font("Verdana", 11.5, FontStyle.Italic)
                    txtSearchWord.ForeColor = Color.Silver
                End If
        End Select

    End Sub

    Private Sub txtSearchWord_TextChanged(sender As Object, e As EventArgs) Handles txtSearchWord.TextChanged

    End Sub

End Class
