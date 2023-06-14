Public Class SearchField
    Inherits ComboBox

    Public Sub New()

        Me.Size = New Size(200, 24)
        Me.BackColor = Color.White
        Me.FlatStyle = Windows.Forms.FlatStyle.Flat
        Me.DropDownStyle = ComboBoxStyle.DropDown
        Me.Text = "Search or enter adress"
        Me.ForeColor = Color.Silver
        Me.Font = New Font("Verdana", 9.5, FontStyle.Italic)

    End Sub

    Private Sub SearchField_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus

        Select Case My.Settings.Language

            Case 0
                'English'
                If Me.Text = "Search or enter adress" Then
                    Me.Text = ""
                    NormalText()
                End If

            Case 1
                'Bulgarian'
                If Me.Text = "Въведи адрес или потърси" Then
                    Me.Text = ""
                    NormalText()
                End If
        End Select

    End Sub

    Private Sub SearchField_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus

        Select Case My.Settings.Language

            Case 0
                'English'
                If Me.Text = "" Then
                    Me.Text = "Search or enter adress"
                    WaterMark()
                End If

            Case 1
                'Bulgarian'
                If Me.Text = "" Then
                    Me.Text = "Въведи адрес или потърси"
                    WaterMark()
                End If

        End Select

    End Sub

    Private Sub SearchField_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.TextChanged

        Select Case My.Settings.Language

            Case 0
                'English'
                If Me.Text <> "" Or Me.Text <> "Search or enter adress" Then
                    NormalText()
                End If

            Case 1
                'Bulgarian'
                If Me.Text <> "" Or Me.Text <> "Въведи адрес или потърси" Then
                    NormalText()
                End If

        End Select

    End Sub

    Sub WaterMark()
        Me.ForeColor = Color.Silver
        Me.Font = New Font("Verdana", 9.5, FontStyle.Italic)
    End Sub

    Sub NormalText()
        Me.Font = New Font("Verdana", 9.5, FontStyle.Regular)
        Me.ForeColor = Color.Black
    End Sub


End Class
