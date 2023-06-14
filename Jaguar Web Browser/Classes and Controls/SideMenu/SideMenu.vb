#Region "Imports"
Imports System.Net
Imports System.IO
Imports VIBlend.WinForms.Controls
Imports VIBlend.Utilities.VIBLEND_THEME
#End Region

Public Class SideMenu

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

    Private Sub SideMenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Dock = DockStyle.None
        ConnectionStatus()
    End Sub

    Private Sub frmSideMenubtnZoomOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSideMenubtnZoomOut.Click
        Try
            CType(MainForm.TabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.ZoomFactor -= 0.2
            ZoomStatus.Text = CType(MainForm.TabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.ZoomFactor.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmSideMenubtnZoomIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSideMenubtnZoomIn.Click
        Try
            CType(MainForm.TabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.ZoomFactor += 0.2
            ZoomStatus.Text = CType(MainForm.TabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.ZoomFactor.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmSideMenubtnNewWindow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSideMenubtnNewWindow.Click
        Dim NewMainForm As New MainForm
        NewMainForm.Show()
        SlideOut()
    End Sub

    Private Sub frmSideMenubtnIncognitoWindow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSideMenubtnIncognitoWindow.Click
        IncognitoForm.Show()
        SlideOut()
    End Sub

    Private Sub frmSideMenubtnSavePage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSideMenubtnSavePage.Click
        Dim CI As New CodeInspector
        CI.ShowDialog()

        'CodeInspector.CodeInspector.Text = CType(MainForm.TabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.EvalScript("document.documentElement.outerHTML")
    End Sub

    Private Sub frmSideMenubtnHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSideMenubtnHistory.Click
        MainForm.TabControl.TabPages.Add(MainForm.SettingsTab)
        MainForm.TabControl.SelectedTab = MainForm.SettingsTab
        MainForm.SettingsTabControl.SelectedIndex = 1
        SlideOut()
    End Sub

    Private Sub frmSideMenubtnBookmarks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSideMenubtnBookmarks.Click
        MainForm.TabControl.TabPages.Add(MainForm.SettingsTab)
        MainForm.TabControl.SelectedTab = MainForm.SettingsTab
        MainForm.SettingsTabControl.SelectedIndex = 2
        SlideOut()
    End Sub

    Private Sub frmSideMenubtnDownloadManager_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSideMenubtnDownloadManager.Click
        MainForm.TabControl.TabPages.Add(MainForm.SettingsTab)
        MainForm.TabControl.SelectedTab = MainForm.SettingsTab
        MainForm.SettingsTabControl.SelectedIndex = 3
        SlideOut()
    End Sub

    Private Sub frmSideMenubtnCustomize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSideMenubtnCustomize.Click
        MainForm.TabControl.TabPages.Add(MainForm.SettingsTab)
        MainForm.TabControl.SelectedTab = MainForm.SettingsTab
        MainForm.SettingsTabControl.SelectedIndex = 4
        SlideOut()
    End Sub

    Private Sub frmSideMenubtnFullScreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSideMenubtnFullScreen.Click
        MainForm.Timer.Enabled = True

        Select Case My.Settings.Language
            Case 0
                'English'
                If MainForm.WindowState = FormWindowState.Normal Then
                    MainForm.WindowState = FormWindowState.Maximized
                    frmSideMenubtnFullScreen.Image = My.Resources.Fullscreen_Exit
                    frmSideMenubtnFullScreen.Text = "Fullscreen Exit"
                    MainForm.lblFullScreen.Visible = True
                    SlideOut()
                Else
                    MainForm.WindowState = FormWindowState.Normal
                    frmSideMenubtnFullScreen.Image = My.Resources.Fullscreen
                    frmSideMenubtnFullScreen.Text = "Fullscreen"
                    MainForm.lblFullScreen.Visible = False
                    SlideOut()
                End If

            Case 1
                'Bulgarian'
                If MainForm.WindowState = FormWindowState.Normal Then
                    MainForm.WindowState = FormWindowState.Maximized
                    frmSideMenubtnFullScreen.Image = My.Resources.Fullscreen_Exit
                    frmSideMenubtnFullScreen.Text = "Изход екран"
                    MainForm.lblFullScreen.Visible = True
                    SlideOut()
                Else
                    MainForm.WindowState = FormWindowState.Normal
                    frmSideMenubtnFullScreen.Image = My.Resources.Fullscreen
                    frmSideMenubtnFullScreen.Text = "Пълен екран"
                    MainForm.lblFullScreen.Visible = False
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

    Private Sub frmSideMenubtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSideMenubtnPrint.Click
        CType(MainForm.TabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Print()
    End Sub

    Private Sub frmSideMenubtnSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSideMenubtnSettings.Click
        MainForm.TabControl.TabPages.Add(MainForm.SettingsTab)
        MainForm.TabControl.SelectedTab = MainForm.SettingsTab
        MainForm.SettingsTabControl.SelectedIndex = 0
        SlideOut()
        SettingsLoad()
    End Sub

    Private Sub frmSideMenubtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSideMenubtnSearch.Click
        If MainForm.SearchWord.Visible = False Then
            MainForm.SearchWord.Visible = True
            MainForm.SearchPanel.Size = New Size(MainForm.SearchPanel.Width - 270, MainForm.SearchPanel.Height)
            SlideOut()
        Else
            MainForm.SearchWord.Visible = False
            MainForm.SearchPanel.Size = New Size(MainForm.SearchPanel.Width + 270, MainForm.SearchPanel.Height)
            SlideOut()
        End If
    End Sub

    Private Sub frmSideMenubtnDevelopers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSideMenubtnDevelopers.Click
        MainForm.TabControl.TabPages.Add(MainForm.WebDevTabPage)
        MainForm.TabControl.SelectedTab = MainForm.WebDevTabPage
        SlideOut()
    End Sub

#End Region


#Region "Functions"

    Sub ConnectionStatus()

        Select Case My.Settings.Language
            Case 0
                'English'
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

            Case 1
                'Bulgarian'
                Try
                    Using Client = New WebClient
                        Using Stram = Client.OpenRead("https://www.google.com")
                            lblConnectionStatus.Text = "Свързан"
                            lblConnectionStatus.ForeColor = Color.Navy
                        End Using
                    End Using
                Catch ex As Exception
                    lblConnectionStatus.Text = "Няма връзка"
                    lblConnectionStatus.ForeColor = Color.Red
                End Try

        End Select

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

    Sub SettingsLoad()

        MainForm.frmSettingstxtHomepageURL.Text = My.Settings.Homepage
        MainForm.frmSettingstxtStartupPageURL.Text = My.Settings.SpecificURL

        Select Case My.Settings.Language
            Case 0
                'English'
                MainForm.frmSettingscmbOnStartup.Items.Clear()


                MainForm.frmSettingscmbOnStartup.Items.Add("Open Jaguar Homepage")
                MainForm.frmSettingscmbOnStartup.Items.Add("Open Blank page")
                MainForm.frmSettingscmbOnStartup.Items.Add("Open Homepage")
                MainForm.frmSettingscmbOnStartup.Items.Add("Open Specific page")
                MainForm.frmSettingscmbOnStartup.Items.Add("Open My Homepage")
                MainForm.frmSettingscmbOnStartup.SelectedIndex = My.Settings.StartupLOAD

            Case 1
                'Bulgarian'
                MainForm.frmSettingscmbOnStartup.Items.Clear()

                MainForm.frmSettingscmbOnStartup.Items.Add("Зареди началната страница на Ягуар")
                MainForm.frmSettingscmbOnStartup.Items.Add("Зареди празна страница")
                MainForm.frmSettingscmbOnStartup.Items.Add("Зареди начална страница")
                MainForm.frmSettingscmbOnStartup.Items.Add("Зареди конкретна страница")
                MainForm.frmSettingscmbOnStartup.Items.Add("Зареди Моята начална страница")
                MainForm.frmSettingscmbOnStartup.SelectedIndex = My.Settings.StartupLOAD

        End Select

    End Sub

#End Region

End Class
