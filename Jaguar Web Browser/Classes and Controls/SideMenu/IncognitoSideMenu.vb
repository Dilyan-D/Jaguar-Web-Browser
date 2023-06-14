#Region "Imports"
Imports System.Net
Imports System.IO
Imports VIBlend.WinForms.Controls
Imports VIBlend.Utilities.VIBLEND_THEME
#End Region

Public Class IncognitoSideMenu

#Region "Design"

    Private Sub CloseMenuButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CloseMenuButton.Click
        SlideOut()
    End Sub

    Private Sub CloseMenuButton_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles CloseMenuButton.MouseHover
        CloseMenuButton.Image = New Bitmap(My.Resources.Close_1)
    End Sub

    Private Sub CloseMenuButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CloseMenuButton.MouseLeave
        CloseMenuButton.Image = New Bitmap(My.Resources.Close)
    End Sub

#End Region


#Region "Events"

    Private Sub IncognitoSideMenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Dock = DockStyle.None
        ConnectionStatus()
    End Sub

    Private Sub frmSideMenubtnZoomOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSideMenubtnZoomOut.Click
        Try
            CType(IncognitoForm.IncognitoTabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.ZoomFactor -= 0.2
            ZoomStatus.Text = CType(IncognitoForm.IncognitoTabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.ZoomFactor.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmSideMenubtnZoomIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSideMenubtnZoomIn.Click
        Try
            CType(IncognitoForm.IncognitoTabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.ZoomFactor += 0.2
            ZoomStatus.Text = CType(IncognitoForm.IncognitoTabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.ZoomFactor.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmSideMenubtnNewWindow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSideMenubtnNewWindow.Click
        Dim IWF As New IncognitoForm
        IWF.Show()
    End Sub

    Private Sub frmSideMenubtnSavePage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSideMenubtnSavePage.Click

    End Sub

    Private Sub frmSideMenubtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSideMenubtnPrint.Click

    End Sub

    Private Sub frmSideMenubtnFullScreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSideMenubtnFullScreen.Click
        IncognitoForm.Timer.Enabled = True

        Select Case My.Settings.Language
            Case 0
                'English'
                If IncognitoForm.WindowState = FormWindowState.Normal Then
                    IncognitoForm.WindowState = FormWindowState.Maximized
                    frmSideMenubtnFullScreen.Image = My.Resources.Fullscreen_Exit
                    frmSideMenubtnFullScreen.Text = "Fullscreen Exit"
                    IncognitoForm.lblFullScreen.Visible = True
                    SlideOut()
                Else
                    IncognitoForm.WindowState = FormWindowState.Normal
                    frmSideMenubtnFullScreen.Image = My.Resources.Fullscreen
                    frmSideMenubtnFullScreen.Text = "Fullscreen"
                    IncognitoForm.lblFullScreen.Visible = False
                    SlideOut()
                End If

            Case 1
                'Bulgarian'
                If IncognitoForm.WindowState = FormWindowState.Normal Then
                    IncognitoForm.WindowState = FormWindowState.Maximized
                    frmSideMenubtnFullScreen.Image = My.Resources.Fullscreen_Exit
                    frmSideMenubtnFullScreen.Text = "Изход екран"
                    IncognitoForm.lblFullScreen.Visible = True
                    SlideOut()
                Else
                    IncognitoForm.WindowState = FormWindowState.Normal
                    frmSideMenubtnFullScreen.Image = My.Resources.Fullscreen
                    frmSideMenubtnFullScreen.Text = "Пълен екран"
                    IncognitoForm.lblFullScreen.Visible = False
                    SlideOut()
                End If


        End Select
    End Sub

    Private Sub frmSideMenubtnFullScreen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles frmSideMenubtnFullScreen.KeyDown
        If e.KeyCode = Keys.Escape Then

            Select Case My.Settings.Language
                Case 0
                    'English'
                    MainForm.WindowState = FormWindowState.Normal
                    frmSideMenubtnFullScreen.Image = My.Resources.Fullscreen
                    frmSideMenubtnFullScreen.Text = "Fullscreen"
                    MainForm.lblFullScreen.Visible = False
                Case 1
                    'Bulgarian'
                    MainForm.WindowState = FormWindowState.Normal
                    frmSideMenubtnFullScreen.Image = My.Resources.Fullscreen
                    frmSideMenubtnFullScreen.Text = "Пълен екран"
                    MainForm.lblFullScreen.Visible = False
            End Select

        End If
    End Sub

    Private Sub frmSideMenubtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSideMenubtnSearch.Click
        If IncognitoForm.SearchWord.Visible = False Then
            IncognitoForm.SearchWord.Visible = True
            IncognitoForm.SearchPanel.Size = New Size(IncognitoForm.SearchPanel.Width - 270, IncognitoForm.SearchPanel.Height)
            SlideOut()
        Else
            IncognitoForm.SearchWord.Visible = False
            IncognitoForm.SearchPanel.Size = New Size(IncognitoForm.SearchPanel.Width + 270, IncognitoForm.SearchPanel.Height)
            SlideOut()
        End If
    End Sub

#End Region


#Region "Functions"

    Sub ConnectionStatus()
        Try
            Using Client = New WebClient
                Using Stram = Client.OpenRead("https://www.google.com")
                    lblConnectionStatus.Text = "Connected"
                    lblConnectionStatus.ForeColor = Color.Navy
                End Using
            End Using
        Catch ex As Exception
            lblConnectionStatus.Text = "Not Connected"
            lblConnectionStatus.ForeColor = Color.Red
        End Try
    End Sub

    Sub SlideOut()
        Me.Location = New Point(0, 0)
        Do Until Me.Location.X = -300
            Me.Location = New Point(Me.Location.X - 1, 0)
        Loop

        Do Until Me.Location.X = -355
            Me.Location = New Point(Me.Location.X - 1, 0)
            System.Threading.Thread.Sleep(1)
            Refresh()
        Loop
    End Sub

#End Region

End Class
