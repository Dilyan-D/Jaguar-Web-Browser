#Region "Imports"

Imports System.Net
Imports System.IO
Imports System.Speech
Imports System.Speech.Recognition

Imports VIBlend.WinForms.Controls
Imports VIBlend.Utilities.VIBLEND_THEME

Imports EO.WebBrowser
Imports EO.WinForm.WebControl
Imports EO.WinForm.WebViewHost
Imports EO.Base
Imports EO.WebBrowser.WinForm
Imports System.ComponentModel

#End Region

Public Class MainForm

#Region "Form Design"

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Dim ScreenWidth = Screen.PrimaryScreen.Bounds.Width
    Dim ScreenHeight = My.Computer.Screen.Bounds.Height - (My.Computer.Screen.Bounds.Height - My.Computer.Screen.WorkingArea.Height)

    Private Sub ResizeButton_LoadCompleted(sender As Object, e As AsyncCompletedEventArgs) Handles ResizeButton.LoadCompleted
        If Me.Size <> New Size(ScreenWidth, ScreenHeight) Then
            ResizeButton.Image = New Bitmap(My.Resources.Maximize)
        Else
            ResizeButton.Image = New Bitmap(My.Resources.Normal)
        End If
    End Sub

    Private Sub ResizeButton_Click(sender As Object, e As EventArgs) Handles ResizeButton.Click
        If Me.Size <> New Size(ScreenWidth, ScreenHeight) Then
            ResizeButton.Image = New Bitmap(My.Resources.Normal)
            Maximize()
        Else
            ResizeButton.Image = New Bitmap(My.Resources.Maximize)
            Normalize()
        End If
    End Sub

    Private Sub ResizeButton_MouseHover(sender As Object, e As EventArgs) Handles ResizeButton.MouseHover
        If Me.Size <> New Size(ScreenWidth, ScreenHeight) Then
            ResizeButton.Image = New Bitmap(My.Resources.Maximize_1)
        Else
            ResizeButton.Image = New Bitmap(My.Resources.Normal_1)
        End If
    End Sub

    Private Sub ResizeButton_MouseLeave(sender As Object, e As EventArgs) Handles ResizeButton.MouseLeave
        If Me.Size <> New Size(ScreenWidth, ScreenHeight) Then
            ResizeButton.Image = New Bitmap(My.Resources.Maximize)
        Else
            ResizeButton.Image = New Bitmap(My.Resources.Normal)
        End If
    End Sub

    Sub Maximize()
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = My.Computer.Screen.Bounds.Height - (My.Computer.Screen.Bounds.Height - My.Computer.Screen.WorkingArea.Height)
        Me.Location = Screen.GetWorkingArea(Me).Location
    End Sub

    Sub Normalize()
        Me.Location = New Point(80, 80)
        Me.Width = 1000
        Me.Height = 600
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

#End Region

#Region "Form Events"

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Maximize()

        Tabs()

        SettingsLoad()

        Startup()

        FirstRun()

        'My.Settings.Reset()

    End Sub

    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            CType(TabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Destroy()
        Catch ex As Exception
        End Try
        WebView.Destroy()
    End Sub

    Private Sub frmMainFormbtnBackward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmMainFormbtnBackward.Click
        Try
            CType(TabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.GoBack()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmMainFormbtnForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmMainFormbtnForward.Click
        Try
            CType(TabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.GoForward()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmMainFormbtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmMainFormbtnHome.Click
        If frmSettingstxtHomepageURL.Text <> Nothing Then
            NewTab()
            SearchField.Text = My.Settings.Homepage
            Search()
            favicon()
        End If
    End Sub

    Private Sub frmMainFormbtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmMainFormbtnSearch.Click
        Try
            Search()
            favicon()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmMainFormbtnSearch_MouseHover(sender As Object, e As EventArgs) Handles frmMainFormbtnSearch.MouseHover
        If HomeTabPage.IsSelected = True Then
            ToolTip1.Active = True
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub frmMainFormbtnVoiceInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmMainFormbtnVoiceInput.Click

    End Sub

    Private Sub SearchField_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SearchField.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            Search()

            favicon()
        End If
    End Sub

    Private Sub frmMainFormbtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmMainFormbtnRefresh.Click
        Try
            CType(TabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Reload()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmMainFormbtnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmMainFormbtnStop.Click
        Try
            CType(TabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.StopLoad()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmMainFormbtnBookmark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmMainFormbtnBookmark.Click
        Try
            Dim x As Integer = -1
            x = frmSettingschklistBookmarks.FindString(CType(TabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Url.ToString)
            If x > -1 Then
                'Do not add'
            Else
                Bookmark()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmMainFormbtnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmMainFormbtnMenu.Click
        SlideIn()
    End Sub


    Private Sub TabControl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl.SelectedIndexChanged

        Select Case My.Settings.Language
            Case 0
                'English'
                Select Case TabControl.SelectedTab.Text

                    Case "Settings"
                        SearchField.Enabled = False
                        SearchField.Text = "Settings"
                        WebsiteIcon.Image = My.Resources.Settings
                        WebsiteIcon.BackColor = Color.FromArgb(240, 240, 240)

                    Case "Jaguar Web Development Tool"
                        SearchField.Enabled = False
                        SearchField.Text = "Jaguar Web Development Tool"
                        WebsiteIcon.Image = My.Resources.Developers
                        WebsiteIcon.BackColor = Color.FromArgb(240, 240, 240)

                    Case "Jaguar Home"
                        SearchField.Enabled = False
                        SearchField.Text = "Jaguar Home Page"
                        WebsiteIcon.Image = Nothing
                        WebsiteIcon.BackColor = Color.FromArgb(240, 240, 240)

                    Case "Welcome to Jaguar"
                        SearchField.Enabled = False
                        SearchField.Text = "Welcome to Jaguar"
                        WebsiteIcon.Image = Nothing
                        WebsiteIcon.BackColor = Color.FromArgb(240, 240, 240)

                    Case "My Homepage"
                        SearchField.Enabled = False
                        SearchField.Text = "My Homepage"
                        WebsiteIcon.Image = Nothing
                        WebsiteIcon.BackColor = Color.FromArgb(240, 240, 240)

                    Case Else
                        SearchField.Enabled = True
                        WebsiteIcon.BackColor = Color.White

                End Select

            Case 1
                'Bulgarian'
                Select Case TabControl.SelectedTab.Text

                    Case "Настройки"
                        SearchField.Enabled = False
                        SearchField.Text = "Настройки"
                        WebsiteIcon.Image = My.Resources.Settings
                        WebsiteIcon.BackColor = Color.FromArgb(240, 240, 240)

                    Case "Уеб инструменти за разработка"
                        SearchField.Enabled = False
                        SearchField.Text = "Уеб инструменти за разработка"
                        WebsiteIcon.Image = My.Resources.Developers
                        WebsiteIcon.BackColor = Color.FromArgb(240, 240, 240)

                    Case "Начална страница"
                        SearchField.Enabled = False
                        SearchField.Text = "Начална страница"
                        WebsiteIcon.Image = Nothing
                        WebsiteIcon.BackColor = Color.FromArgb(240, 240, 240)

                    Case "Добре дошли в Ягуар"
                        SearchField.Enabled = False
                        SearchField.Text = "Добре дошли в Ягуар"
                        WebsiteIcon.Image = Nothing
                        WebsiteIcon.BackColor = Color.FromArgb(240, 240, 240)

                    Case "Моята начална страница"
                        SearchField.Enabled = False
                        SearchField.Text = "Моята начална страница"
                        WebsiteIcon.Image = Nothing
                        WebsiteIcon.BackColor = Color.FromArgb(240, 240, 240)

                    Case Else
                        SearchField.Enabled = True
                        WebsiteIcon.BackColor = Color.White

                End Select

        End Select

        Try
            SearchField.Text = CType(TabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Url.ToString
            favicon()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub WebView_LoadCompleted(ByVal sender As Object, ByVal e As EO.WebBrowser.LoadCompletedEventArgs) Handles WebView.LoadCompleted
        Try
            TabControl.SelectedTab.Text = CType(TabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Title.ToString
            SearchField.Text = CType(TabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Url.ToString
            favicon()
            History()
            Bookmarked()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub WebView_NewWindow(ByVal sender As Object, ByVal e As EO.WebBrowser.NewWindowEventArgs) Handles WebView.NewWindow
        NewTab()
    End Sub

    Private Sub WebView_UrlChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles WebView.UrlChanged
        Try
            TabControl.SelectedTab.Text = CType(TabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Title.ToString
            SearchField.Text = CType(TabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Url.ToString
            favicon()
            Bookmarked()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub WebView_BeforeContextMenu(sender As Object, e As BeforeContextMenuEventArgs) Handles WebView.BeforeContextMenu

        Select Case My.Settings.Language
            Case 0
                e.Menu.Items.Clear()
                e.Menu.Items.Add(New MenuItem("Back", CommandIds.Back))
                e.Menu.Items.Add(New MenuItem("Forward", CommandIds.Forward))
                e.Menu.Items.Add(New MenuItem("Reload", CommandIds.Reload))
                e.Menu.Items.Add(MenuItem.CreateSeparator())
                e.Menu.Items.Add(New MenuItem("Copy", CommandIds.Copy))
                e.Menu.Items.Add(New MenuItem("Cut", CommandIds.Cut))
                e.Menu.Items.Add(New MenuItem("Paste", CommandIds.Paste))
                e.Menu.Items.Add(New MenuItem("Delete", CommandIds.Delete))
                e.Menu.Items.Add(MenuItem.CreateSeparator())
                e.Menu.Items.Add(New MenuItem("Print", CommandIds.Print))
                e.Menu.Items.Add(New MenuItem("View source", CommandIds.ViewSource))

            Case 1
                e.Menu.Items.Clear()
                e.Menu.Items.Add(New MenuItem("Назад", CommandIds.Back))
                e.Menu.Items.Add(New MenuItem("Напред", CommandIds.Forward))
                e.Menu.Items.Add(New MenuItem("Презареди", CommandIds.Reload))
                e.Menu.Items.Add(MenuItem.CreateSeparator())
                e.Menu.Items.Add(New MenuItem("Копирай", CommandIds.Copy))
                e.Menu.Items.Add(New MenuItem("Изрежи", CommandIds.Cut))
                e.Menu.Items.Add(New MenuItem("Постави", CommandIds.Paste))
                e.Menu.Items.Add(New MenuItem("Изтрий", CommandIds.Delete))
                e.Menu.Items.Add(MenuItem.CreateSeparator())
                e.Menu.Items.Add(New MenuItem("Принтирай", CommandIds.Print))
                e.Menu.Items.Add(New MenuItem("Виж изходния код", CommandIds.ViewSource))

        End Select

    End Sub

#End Region

#Region "Settings Events"

    Private Sub SettingsTabControl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsTabControl.SelectedIndexChanged

        Select Case SettingsTabControl.SelectedIndex
            Case (0)
                SideMenu.SettingsLoad()

            Case (1)
                If frmSettingschklistHistory.Items.Count <> My.Settings.History.Count Then
                    For Each item In My.Settings.History
                        frmSettingschklistHistory.Items.Add(item)
                    Next
                    My.Settings.HistoryCOUNT = frmSettingschklistHistory.Items.Count
                End If

            Case (2)
                If frmSettingschklistBookmarks.Items.Count <> My.Settings.Bookmarks.Count Then
                    For Each item In My.Settings.Bookmarks
                        frmSettingschklistBookmarks.Items.Add(item)
                    Next
                    My.Settings.BookmarksCOUNT = frmSettingschklistBookmarks.Items.Count
                End If

            Case (4)
                frmSettingscmbLanguages.SelectedIndex = My.Settings.Language
                frmSettingscmbCustomize.SelectedIndex = My.Settings.Theme
                frmSettingschkboxVisableBookmarks.Checked = My.Settings.BookmarkBarVisibility
        End Select

    End Sub

#Region "General"

    Private Sub frmSettingscmbOnStartup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSettingscmbOnStartup.SelectedIndexChanged

        Select Case frmSettingscmbOnStartup.SelectedIndex

            Case (0)
                SetPagePanel.Visible = False
                My.Settings.StartupLOAD = 0

            Case (1)
                SetPagePanel.Visible = False
                My.Settings.StartupLOAD = 1

            Case (2)
                SetPagePanel.Visible = False
                My.Settings.StartupLOAD = 2

                If frmSettingstxtHomepageURL.Text <> "" Then
                    My.Settings.Startup = frmSettingstxtHomepageURL.Text
                    My.Settings.Save()
                End If

            Case (3)
                SetPagePanel.Visible = True
                My.Settings.StartupLOAD = 3

                If frmSettingstxtStartupPageURL.Text <> "" Then
                    My.Settings.Startup = frmSettingstxtStartupPageURL.Text
                    My.Settings.Save()
                End If

            Case (4)
                SetPagePanel.Visible = False
                My.Settings.StartupLOAD = 4
        End Select

    End Sub

    Private Sub frmSettingsbtnSetStartupPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSettingsbtnSetStartupPage.Click
        Timer.Enabled = True
        lblMsg1.Visible = True

        If frmSettingstxtStartupPageURL.Text <> "" Then
            My.Settings.SpecificURL = frmSettingstxtStartupPageURL.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub frmSettingstxtStartupPageURL_TextChanged(sender As Object, e As EventArgs) Handles frmSettingstxtStartupPageURL.TextChanged
        If frmSettingstxtStartupPageURL.Text = "" Then
            frmSettingstxtStartupPageURL.Text = "about:blank"
        End If
    End Sub

    Private Sub frmSettingsbtnSetHomepage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSettingsbtnSetHomepage.Click
        Timer.Enabled = True
        lblMsg2.Visible = True

        If frmSettingstxtHomepageURL.Text <> "" Then
            My.Settings.Homepage = frmSettingstxtHomepageURL.Text
            My.Settings.Save()
        End If


    End Sub

    Private Sub frmSettingstxtHomepageURL_TextChanged(sender As Object, e As EventArgs) Handles frmSettingstxtHomepageURL.TextChanged
        If frmSettingstxtHomepageURL.Text = "" Then
            frmSettingstxtHomepageURL.Text = "about:blank"
        End If
    End Sub

    Private Sub frmSettingscmbSearchEngines_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSettingscmbSearchEngines.SelectedIndexChanged

        Select Case frmSettingscmbSearchEngines.SelectedIndex

            Case (0)
                PBSearchEnginesIcons.Image = My.Resources.google
                My.Settings.SearchEngine = "https://www.google.com/search?q="
                My.Settings.SearchEngineINDEX = 0

            Case (1)
                PBSearchEnginesIcons.Image = My.Resources.bing
                My.Settings.SearchEngine = "https://www.bing.com/search?q="
                My.Settings.SearchEngineINDEX = 1

            Case (2)
                PBSearchEnginesIcons.Image = My.Resources.yahoo
                My.Settings.SearchEngine = "https://search.yahoo.com/search;_ylc=X3oDMTFiN25laTRvBF9TAzIwMjM1MzgwNzUEaXRjAzEEc2VjA3NyY2hfcWEEc2xrA3NyY2h3ZWI-?p="
                My.Settings.SearchEngineINDEX = 2

            Case (3)
                PBSearchEnginesIcons.Image = My.Resources.youtube
                My.Settings.SearchEngine = "https://www.youtube.com/results?search_query="
                My.Settings.SearchEngineINDEX = 3

            Case (4)
                PBSearchEnginesIcons.Image = My.Resources.wikipedia
                My.Settings.SearchEngine = "https://bg.wikipedia.org/w/index.php?search="
                My.Settings.SearchEngineINDEX = 4

        End Select

    End Sub

    Private Sub frmSettingsoptLemmeSave_CheckedChanged(sender As Object, e As EventArgs) Handles frmSettingsoptLemmeSave.CheckedChanged
        If frmSettingsoptLemmeSave.Checked = True Then
            frmSettingsbtnFolderBrowse.Enabled = False
            frmSettingstxtSaveLocation.Enabled = False
        End If
    End Sub

    Private Sub frmSettingsoptSaveToLocation_CheckedChanged(sender As Object, e As EventArgs) Handles frmSettingsoptSaveToLocation.CheckedChanged
        If frmSettingsoptSaveToLocation.Checked = True Then
            frmSettingsbtnFolderBrowse.Enabled = True
            frmSettingstxtSaveLocation.Enabled = True

        End If
    End Sub

    Private Sub frmSettingsbtnFolderBrowse_Click(sender As Object, e As EventArgs) Handles frmSettingsbtnFolderBrowse.Click

        If frmSettingsDownloadFolderBrowser.ShowDialog() = DialogResult.OK Then

            My.Settings.DownloadPath = frmSettingsDownloadFolderBrowser.SelectedPath

        End If
        frmSettingstxtSaveLocation.Text = frmSettingsDownloadFolderBrowser.SelectedPath

    End Sub

#End Region

#Region "History"

    Private Sub frmSettingschkboxSelectAllHistory_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSettingschkboxSelectAllHistory.CheckedChanged

        If frmSettingschkboxSelectAllHistory.Checked = True Then
            For i As Integer = 0 To frmSettingschklistHistory.Items.Count - 1
                frmSettingschklistHistory.SetItemChecked(i, True)
            Next i

        Else

            For i As Integer = 0 To frmSettingschklistHistory.Items.Count - 1
                frmSettingschklistHistory.SetItemChecked(i, False)
            Next i

        End If

    End Sub

    Private Sub frmSettingsbtnClearHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSettingsbtnClearHistory.Click

        If frmSettingschkboxSelectAllHistory.Checked = True Then

            frmSettingschklistHistory.Items.Clear()
            My.Settings.History.Clear()
            SearchField.DataSource = My.Settings.History
            SearchField.Refresh()


            frmSettingschkboxSelectAllHistory.Checked = False

        Else

            With frmSettingschklistHistory

                If .CheckedItems.Count > 0 Then

                    For checked As Integer = .CheckedItems.Count - 1 To 0 Step -1

                        .Items.Remove(.CheckedItems(checked))
                        My.Settings.History.Remove(checked)
                        My.Settings.HistoryCOUNT = My.Settings.HistoryCOUNT - checked
                        SearchField.DataSource = My.Settings.History

                        frmSettingschkboxSelectAllHistory.Checked = False

                    Next

                End If

            End With

        End If

    End Sub

    Dim dt As New DataTable
    Private Sub frmSettingstxtSearchHistory_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSettingstxtSearchHistory.TextChanged


        Dim items = From it In frmSettingschklistHistory.Items.Cast(Of Object)()
                    Where it.ToString().IndexOf(frmSettingstxtSearchHistory.Text, StringComparison.CurrentCultureIgnoreCase) >= 0
        Dim matchingItemList As List(Of Object) = items.ToList()
        frmSettingschklistHistory.BeginUpdate()
        frmSettingschklistHistory.Items.Clear()
        For Each item In matchingItemList
            frmSettingschklistHistory.Items.Add(item)
        Next
        frmSettingschklistHistory.EndUpdate()

        If frmSettingstxtSearchHistory.Text = "" Then
            frmSettingschklistHistory.Items.Clear()
            For Each item In My.Settings.History
                frmSettingschklistHistory.Items.Add(item)
            Next
        End If
    End Sub

    Private Sub frmSettingschklistHistory_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles frmSettingschklistHistory.DoubleClick
        NewTab()
        SearchField.Text = frmSettingschklistHistory.SelectedItem.ToString()
        Search()
    End Sub

#End Region

#Region "Bookmarks"

    Private Sub frmSettingschkboxSelectAllBookmarks_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSettingschkboxSelectAllBookmarks.CheckedChanged

        If frmSettingschkboxSelectAllBookmarks.Checked = True Then
            For i As Integer = 0 To frmSettingschklistBookmarks.Items.Count - 1
                frmSettingschklistBookmarks.SetItemChecked(i, True)
            Next i

        Else

            For i As Integer = 0 To frmSettingschklistBookmarks.Items.Count - 1
                frmSettingschklistBookmarks.SetItemChecked(i, False)
            Next i

        End If

    End Sub

    Private Sub frmSettingsbtnClearBookmarks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSettingsbtnClearBookmarks.Click

        If frmSettingschkboxSelectAllBookmarks.Checked = True Then

            frmSettingschklistBookmarks.Items.Clear()
            My.Settings.Bookmarks.Clear()
            SearchField.DataSource = My.Settings.Bookmarks

            frmSettingschkboxSelectAllBookmarks.Checked = False

        Else

            With frmSettingschklistBookmarks

                If .CheckedItems.Count > 0 Then

                    For checked As Integer = .CheckedItems.Count - 1 To 0 Step -1

                        .Items.Remove(.CheckedItems(checked))
                        My.Settings.BookmarksCOUNT = My.Settings.BookmarksCOUNT - checked

                        frmSettingschkboxSelectAllBookmarks.Checked = False

                    Next

                End If

            End With

        End If

    End Sub

    Private Sub frmSettingstxtSearchBookmark_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSettingstxtSearchBookmark.TextChanged

        Dim items = From it In frmSettingschklistHistory.Items.Cast(Of Object)()
                    Where it.ToString().IndexOf(frmSettingstxtSearchBookmark.Text, StringComparison.CurrentCultureIgnoreCase) >= 0
        Dim matchingItemList As List(Of Object) = items.ToList()
        frmSettingschklistBookmarks.BeginUpdate()
        frmSettingschklistBookmarks.Items.Clear()
        For Each item In matchingItemList
            frmSettingschklistBookmarks.Items.Add(item)
        Next
        frmSettingschklistBookmarks.EndUpdate()

        If frmSettingstxtSearchBookmark.Text = "" Then
            frmSettingschklistBookmarks.Items.Clear()
            For Each item In My.Settings.Bookmarks
                frmSettingschklistBookmarks.Items.Add(item)
            Next
        End If

    End Sub

    Private Sub frmSettingschklistBookmarks_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles frmSettingschklistBookmarks.DoubleClick
        NewTab()
        SearchField.Text = frmSettingschklistBookmarks.SelectedItem.ToString()
        Search()
    End Sub

#End Region

#Region "Downloads"

    Private Sub frmSettingschkboxSelectAllDownloads_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSettingschkboxSelectAllDownloads.CheckedChanged

    End Sub

    Private Sub frmSettingsbtnClearDownloads_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSettingsbtnClearDownloads.Click

    End Sub

    Private Sub frmSettingstxtSearchDownload_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSettingstxtSearchDownload.TextChanged

    End Sub

#End Region

#Region "Customize"

    Private Sub frmSettingscmbCustomize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSettingscmbCustomize.SelectedIndexChanged
        Select Case frmSettingscmbCustomize.SelectedIndex
            Case 0
                OfficeBlue()
            Case 1
                OfficeBlue2()
            Case 2
                OfficeSilver()
            Case 3
                DefaultTheme()
            Case 4
                OfficeGreen()
            Case 5
                Sky()
            Case 6
                Aqua()
            Case 7
                Sunset()
            Case 8
                Olive()
            Case 9
                Retro()
            Case 10
                RetroBlue()
            Case 11
                ModernBlue()
            Case 12
                ModernGreen()
            Case 13
                ModernOrange()
            Case 14
                Steel()
        End Select

        My.Settings.Theme = frmSettingscmbCustomize.SelectedIndex
        My.Settings.Save()
    End Sub

    Private Sub frmSettingschkboxVisableBookmarks_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSettingschkboxVisableBookmarks.CheckedChanged

        If frmSettingschkboxVisableBookmarks.Checked = True And frmSettingschkboxVisableBookmarks.CheckState = CheckState.Checked Then
            BookmarksBar.Visible = True
            My.Settings.BookmarkBarVisibility = True
            TabControl.Size = New Size(TabControl.Width, TabControl.Height - 20)
            TabControl.Location = New System.Drawing.Point(TabControl.Location.X, TabControl.Location.Y + 20)

        Else
            BookmarksBar.Visible = False
            My.Settings.BookmarkBarVisibility = False
            TabControl.Size = New Size(TabControl.Width, TabControl.Height + 20)
            TabControl.Location = New System.Drawing.Point(TabControl.Location.X, TabControl.Location.Y - 20)

        End If
    End Sub

    Private Sub frmSettingscmbLanguages_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSettingscmbLanguages.SelectedIndexChanged

        Select Case frmSettingscmbLanguages.SelectedIndex

            Case 0
                LanguageIcon.Image = My.Resources.English
                English()
            Case 1
                LanguageIcon.Image = My.Resources.Bulgarian
                Bulgarian()
        End Select

        My.Settings.Language = frmSettingscmbLanguages.SelectedIndex
        My.Settings.Save()

    End Sub

#End Region

#Region "About"

    Private Sub Report_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        NewTab()
        CType(TabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Url = "http://jaguarbrowser.wixsite.com/jaguar/contact"
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        My.Settings.Reset()
        DefaultTheme()

        WebView.Engine.Stop(True) 'Clear cookies and cache

        Application.Restart()

    End Sub

#End Region

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        lblMsg1.Visible = False
        lblMsg2.Visible = False
        lblFullScreen.Visible = False
        Timer.Enabled = False
    End Sub

#End Region

#Region "Jaguar Home Page"

    Private Sub JHPSearchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JHPSearchButton.Click

        NewTab()
        SearchField.Text = My.Settings.SearchEngine & JHPSearchField.Text
        CType(TabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Url = SearchField.Text
        TabControl.TabPages.Remove(HomeTabPage)
        favicon()

    End Sub

    Private Sub JHPSearchField_KeyDown(sender As Object, e As KeyEventArgs) Handles JHPSearchField.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            NewTab()
            SearchField.Text = My.Settings.SearchEngine & JHPSearchField.Text
            CType(TabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Url = SearchField.Text
            TabControl.TabPages.Remove(HomeTabPage)
            favicon()
        End If
    End Sub

    Private Sub JHPSearchField_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles JHPSearchField.GotFocus
        If JHPSearchField.BackColor = Color.WhiteSmoke And JHPSearchFieldPanel.BackColor = Color.WhiteSmoke And JHPCmbSearchEngines.BackColor = Color.WhiteSmoke Then
            JHPSearchField.BackColor = Color.White
            JHPSearchFieldPanel.BackColor = Color.White
            JHPCmbSearchEngines.BackColor = Color.White
        End If
    End Sub

    Private Sub JHPSearchField_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles JHPSearchField.LostFocus
        If JHPSearchField.BackColor = Color.White And JHPSearchFieldPanel.BackColor = Color.White And JHPCmbSearchEngines.BackColor = Color.White Then
            JHPSearchField.BackColor = Color.WhiteSmoke
            JHPSearchFieldPanel.BackColor = Color.WhiteSmoke
            JHPCmbSearchEngines.BackColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub JHPCmbSearchEngines_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JHPCmbSearchEngines.SelectedIndexChanged
        Select Case JHPCmbSearchEngines.SelectedIndex

            Case (0)
                JHPSearchEnginePic.Image = My.Resources.google
                My.Settings.SearchEngine = "https://www.google.com/search?q="
                My.Settings.SearchEngineINDEX = 0

            Case (1)
                JHPSearchEnginePic.Image = My.Resources.bing
                My.Settings.SearchEngine = "https://www.bing.com/search?q="
                My.Settings.SearchEngineINDEX = 1

            Case (2)
                JHPSearchEnginePic.Image = My.Resources.yahoo
                My.Settings.SearchEngine = "https://search.yahoo.com/search;_ylc=X3oDMTFiN25laTRvBF9TAzIwMjM1MzgwNzUEaXRjAzEEc2VjA3NyY2hfcWEEc2xrA3NyY2h3ZWI-?p="
                My.Settings.SearchEngineINDEX = 2

            Case (3)
                JHPSearchEnginePic.Image = My.Resources.youtube
                My.Settings.SearchEngine = "https://www.youtube.com/results?search_query="
                My.Settings.SearchEngineINDEX = 3

            Case (4)
                JHPSearchEnginePic.Image = My.Resources.wikipedia
                My.Settings.SearchEngine = "https://bg.wikipedia.org/w/index.php?search="
                My.Settings.SearchEngineINDEX = 4

        End Select

        My.Settings.Save()

    End Sub

#End Region

#Region "My Homepage"

#Region "Search"

    Private Sub MHPSearchButton_Click(sender As Object, e As EventArgs) Handles MHPSearchButton.Click
        NewTab()
        SearchField.Text = My.Settings.SearchEngine & MHPSearchField.Text
        CType(TabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Url = SearchField.Text
        TabControl.TabPages.Remove(MyHomePage)
        favicon()
    End Sub

    Private Sub MHPSearchField_KeyDown(sender As Object, e As KeyEventArgs) Handles MHPSearchField.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            NewTab()
            SearchField.Text = My.Settings.SearchEngine & MHPSearchField.Text
            CType(TabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Url = SearchField.Text
            TabControl.TabPages.Remove(MyHomePage)
            favicon()
        End If
    End Sub

    Private Sub MHPSearchField_GotFocus(sender As Object, e As EventArgs) Handles MHPSearchField.GotFocus
        If MHPSearchField.BackColor = Color.WhiteSmoke And MHPSearchFieldPanel.BackColor = Color.WhiteSmoke And MHPCmbSearchEngines.BackColor = Color.WhiteSmoke Then
            MHPSearchField.BackColor = Color.White
            MHPSearchFieldPanel.BackColor = Color.White
            MHPCmbSearchEngines.BackColor = Color.White
        End If
    End Sub

    Private Sub MHPSearchField_LostFocus(sender As Object, e As EventArgs) Handles MHPSearchField.LostFocus
        If MHPSearchField.BackColor = Color.White And MHPSearchFieldPanel.BackColor = Color.White And MHPCmbSearchEngines.BackColor = Color.White Then
            MHPSearchField.BackColor = Color.WhiteSmoke
            MHPSearchFieldPanel.BackColor = Color.WhiteSmoke
            MHPCmbSearchEngines.BackColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub MHPCmbSearchEngines_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MHPCmbSearchEngines.SelectedIndexChanged
        Select Case MHPCmbSearchEngines.SelectedIndex

            Case (0)
                MHPSearchEnginePic.Image = My.Resources.google
                My.Settings.SearchEngine = "https://www.google.com/search?q="
                My.Settings.SearchEngineINDEX = 0

            Case (1)
                MHPSearchEnginePic.Image = My.Resources.bing
                My.Settings.SearchEngine = "https://www.bing.com/search?q="
                My.Settings.SearchEngineINDEX = 1

            Case (2)
                MHPSearchEnginePic.Image = My.Resources.yahoo
                My.Settings.SearchEngine = "https://search.yahoo.com/search;_ylc=X3oDMTFiN25laTRvBF9TAzIwMjM1MzgwNzUEaXRjAzEEc2VjA3NyY2hfcWEEc2xrA3NyY2h3ZWI-?p="
                My.Settings.SearchEngineINDEX = 2

            Case (3)
                MHPSearchEnginePic.Image = My.Resources.youtube
                My.Settings.SearchEngine = "https://www.youtube.com/results?search_query="
                My.Settings.SearchEngineINDEX = 3

            Case (4)
                MHPSearchEnginePic.Image = My.Resources.wikipedia
                My.Settings.SearchEngine = "https://bg.wikipedia.org/w/index.php?search="
                My.Settings.SearchEngineINDEX = 4

        End Select

        My.Settings.Save()
    End Sub

#End Region

#Region "MHP"

    Private Sub MHPbtnShowTools_Click(sender As Object, e As EventArgs) Handles MHPbtnShowTools.Click
        If MHPToolsPanel.Visible = False Then
            MHPToolsPanel.Visible = True
            MHPbtnShowTools.Image = New Bitmap(My.Resources.Back_25px)
        Else
            MHPToolsPanel.Visible = False
            MHPbtnShowTools.Image = New Bitmap(My.Resources.Forward_25px)
        End If
    End Sub

    Private Sub MHPbtnShowHideBookmarksPanel_Click(sender As Object, e As EventArgs) Handles MHPbtnShowHideBookmarksPanel.Click
        If MHPBookmarksPanel.Visible = True Then
            MHPBookmarksPanel.Visible = False
            MHPbtnShowHideBookmarksPanel.Image = New Bitmap(My.Resources.Collapse_Arrow_25px_1)
            MHPbtnShowHideBookmarksPanel.Location = New Point(3, MHPbtnShowHideBookmarksPanel.Location.Y + MHPBookmarksPanel.Height)
        Else
            MHPBookmarksPanel.Visible = True
            MHPbtnShowHideBookmarksPanel.Image = New Bitmap(My.Resources.Expand_Arrow_25px)
            MHPbtnShowHideBookmarksPanel.Location = New Point(3, MHPbtnShowHideBookmarksPanel.Location.Y - MHPBookmarksPanel.Height)
        End If
    End Sub

    Private Sub MHPbtnAddBookmarkMenu_Click(sender As Object, e As EventArgs) Handles MHPbtnAddBookmarkMenu.Click
        If MHPPanelAddBookmark.Visible = False Then
            MHPPanelAddBookmark.Visible = True
            MHPbtnAddBookmarkMenu.Image = New Bitmap(My.Resources.Back_25px)
        Else
            MHPPanelAddBookmark.Visible = False
            MHPbtnAddBookmarkMenu.Image = New Bitmap(My.Resources.Plus_Math_25px)
        End If
    End Sub

    Private Sub MHPbtnAddBookmark_Click(sender As Object, e As EventArgs) Handles MHPbtnAddBookmark.Click
        Dim Bookmark As New MHPBookmark
        If MHPtxtBookmarkURL.Text <> Nothing And MHPtxtBookmarkURL.Text <> Nothing Then
            Bookmark.lblName.Text = MHPtxtBookmarkName.Text
            Bookmark.WebView.Navigate(MHPtxtBookmarkURL.Text)
            MHPFlowLayoutPanel.Controls.Add(Bookmark)

            MHPtxtBookmarkName.Clear()
            MHPtxtBookmarkURL.Clear()
        End If
    End Sub

#End Region

#Region "MHPToolsPanel"

    Private Sub MHPbtnMoveObjects_Click(sender As Object, e As EventArgs) Handles MHPbtnMoveObjects.Click
        MHPbtnMoveObjectsMenu.Show(MHPbtnMoveObjects, 0, MHPbtnMoveObjects.Height)
    End Sub

    Private Sub MoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveToolStripMenuItem.Click

        AddHandler MHPSearchFieldPanel.MouseDown, AddressOf MHPSearchFieldPanel_MouseDown
        AddHandler MHPSearchFieldPanel.MouseMove, AddressOf MHPSearchFieldPanel_MouseMove

    End Sub

    Dim point As New Point
    Dim X, Y As Integer

    Private Sub MHPSearchFieldPanel_MouseDown(sender As Object, e As MouseEventArgs)
        X = Control.MousePosition.X - MHPSearchFieldPanel.Location.X
        Y = Control.MousePosition.Y - MHPSearchFieldPanel.Location.Y
    End Sub

    Private Sub MHPSearchFieldPanel_MouseMove(sender As Object, e As MouseEventArgs)
        MHPSearchFieldPanel.Cursor = Cursors.SizeAll

        If e.Button = Windows.Forms.MouseButtons.Left Then
            point = Control.MousePosition
            point.X = point.X - (X)
            point.Y = point.Y - (Y)
            MHPSearchFieldPanel.Location = point
            MHPSearchButtonPanel.Location = New Point(point.X + MHPSearchFieldPanel.Width + 4, point.Y)
        End If
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreToolStripMenuItem.Click
        MHPSearchFieldPanel.Location = New Point(My.Computer.Screen.WorkingArea.Width / 2 - (MHPSearchFieldPanel.Width / 2 + 56), 120)
        MHPSearchButtonPanel.Location = New Point(My.Computer.Screen.WorkingArea.Width / 2 + (MHPSearchFieldPanel.Width / 2 - 50), 120)

        My.Settings.MHPSearchFieldX = MHPSearchFieldPanel.Location.X
        My.Settings.MHPSearchFieldY = MHPSearchFieldPanel.Location.Y

        My.Settings.MHPSearchButtonX = MHPSearchButtonPanel.Location.X
        My.Settings.MHPSearchButtonY = MHPSearchButtonPanel.Location.Y

        My.Settings.Save()

        RemoveHandler MHPSearchFieldPanel.MouseDown, AddressOf MHPSearchFieldPanel_MouseDown
        RemoveHandler MHPSearchFieldPanel.MouseMove, AddressOf MHPSearchFieldPanel_MouseMove

        MHPSearchFieldPanel.Cursor = Cursors.Default
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        My.Settings.MHPSearchFieldX = MHPSearchFieldPanel.Location.X
        My.Settings.MHPSearchFieldY = MHPSearchFieldPanel.Location.Y

        My.Settings.MHPSearchButtonX = MHPSearchButtonPanel.Location.X
        My.Settings.MHPSearchButtonY = MHPSearchButtonPanel.Location.Y

        RemoveHandler MHPSearchFieldPanel.MouseDown, AddressOf MHPSearchFieldPanel_MouseDown
        RemoveHandler MHPSearchFieldPanel.MouseMove, AddressOf MHPSearchFieldPanel_MouseMove

        MHPSearchFieldPanel.Cursor = Cursors.Default

        My.Settings.Save()
    End Sub



    Private Sub MHPbtnInsertImage_Click(sender As Object, e As EventArgs) Handles MHPbtnInsertImage.Click
        MHPbtnInsertImageMenu.Show(MHPbtnMoveObjects, 0, MHPbtnMoveObjects.Height)
    End Sub

    Dim pixelColor As Color

    Private Sub InsertImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertImageToolStripMenuItem.Click
        If MHPOFDImage.ShowDialog = DialogResult.OK And MHPOFDImage.FileName <> Nothing Then
            MHPBackground.Image = Image.FromFile(MHPOFDImage.FileName)
            pixelColor = New Bitmap(MHPOFDImage.FileName).GetPixel(MHPBackground.Width / 2, MHPBackground.Height / 2)
            MHPBookmarksPanel.BackColor = pixelColor
            MHPBookmarksToolsPanel.BackColor = pixelColor
        End If
        My.Settings.MHPBackground = MHPOFDImage.FileName.ToString
        My.Settings.MHPColor = pixelColor
    End Sub

    Private Sub RestoreImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreImageToolStripMenuItem.Click
        MHPBackground.Image = Nothing
        MHPOFDImage.FileName = Nothing
        My.Settings.MHPBackground = Nothing
        My.Settings.Save()
    End Sub



    Private Sub MHPbtnInsertVideo_Click(sender As Object, e As EventArgs) Handles MHPbtnInsertVideo.Click
        MHPbtnInsertVideoMenu.Show(MHPbtnInsertVideo, 0, MHPbtnInsertVideo.Height)
    End Sub

    Private Sub InsertVideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertVideoToolStripMenuItem.Click
        If MHPOFDVideo.ShowDialog = DialogResult.OK And MHPOFDVideo.FileName <> Nothing Then
            Dim VideoBackground As New AxWMPLib.AxWindowsMediaPlayer
            MHPBackground.Controls.Add(VideoBackground)
            VideoBackground.Dock = DockStyle.Fill
            VideoBackground.uiMode = "none"
            VideoBackground.enableContextMenu = False
            VideoBackground.URL = MHPOFDVideo.FileName
            VideoBackground.settings.setMode("loop", True)
            VideoBackground.settings.mute = True
            VideoBackground.settings.autoStart = True
            VideoBackground.settings.enableErrorDialogs = False
            VideoBackground.stretchToFit = True

            pixelColor = Color.WhiteSmoke
            MHPBookmarksPanel.BackColor = pixelColor
            MHPBookmarksToolsPanel.BackColor = pixelColor
        End If
        My.Settings.MHPColor = pixelColor
    End Sub

    Private Sub RestoreVideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreVideoToolStripMenuItem.Click

    End Sub



    Private Sub MHPbtnInsertSound_Click(sender As Object, e As EventArgs) Handles MHPbtnInsertSound.Click
        MHPbtnInsertSoundMenu.Show(MHPbtnInsertSound, 0, MHPbtnInsertSound.Height)
    End Sub

    Private Sub ChooseSoundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChooseSoundToolStripMenuItem.Click
        If MHPOFDSound.ShowDialog = DialogResult.OK And MHPOFDSound.FileName <> Nothing Then
            My.Settings.MHPSound = MHPOFDSound.FileName.ToString()
        End If
    End Sub

    Private Sub RestoreSoundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreSoundToolStripMenuItem.Click
        My.Settings.MHPSound = Nothing
    End Sub

#End Region

#End Region

#Region "Developers"

#Region "Design"

    Private Sub lblNewFile_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblNewFile.MouseDown
        lblNewFile.ForeColor = Color.FromArgb(39, 157, 255)
    End Sub

    Private Sub lblNewFile_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblNewFile.MouseUp
        lblNewFile.ForeColor = Color.White
    End Sub

    Private Sub lblOpenFile_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblOpenFile.MouseDown
        lblOpenFile.ForeColor = Color.FromArgb(39, 157, 255)
    End Sub

    Private Sub lblOpenFile_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblOpenFile.MouseUp
        lblOpenFile.ForeColor = Color.White
    End Sub

#End Region

#Region "Events"

    Private Sub lblNewFile_Click(sender As Object, e As EventArgs) Handles lblNewFile.Click
        NewFileDialog.ShowDialog()
    End Sub

    Private Sub lblOpenFile_Click(sender As Object, e As EventArgs) Handles lblOpenFile.Click

        OFD.ShowDialog()

        'Add opened file to Recent Files Listbox'
        If RecentFilesListBox.Items.Contains(System.IO.Path.GetFileName(OFD.FileName)) Then
            'Do nothing'
        Else
            OFD.SafeFileNames.Count()
            For i As Integer = 0 To OFD.SafeFileNames.Count() - 1
                RecentFilesListBox.Items.Add(OFD.SafeFileNames(i))
            Next
        End If
        'Add opened file to Recent Files Listbox'


        'Reads the file'
        Try
            Dim Reader As New IO.StreamReader(OFD.FileName)
            MaskedTextBox.Text = Reader.ReadToEnd
            Reader.Close()
        Catch ex As Exception
        End Try
        'Reads the file'

        If OFD.FileName <> Nothing Then

            Dim CE As New CodeEditor
            Dim NewTabPage As New vTabPage
            JWDTTabControl.EnableCloseButtons = True
            JWDTTabControl.ShowCloseButtonOnSelectedTabOnly = False
            JWDTTabControl.TabPages.Remove(WelcomeTabPage)
            JWDTTabControl.TabPages.Add(NewTabPage)
            JWDTTabControl.SelectedTab = NewTabPage
            NewTabPage.Text = Path.GetFileName(OFD.FileName)
            NewTabPage.Controls.Add(CE)
            CE.Dock = DockStyle.Fill

        End If

    End Sub

#End Region

#End Region

#Region "Welcome"

    Private Sub cmbWelcomeLanguage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbWelcomeLanguage.SelectedIndexChanged

        Select Case cmbWelcomeLanguage.SelectedIndex

            Case 0
                pbWelcomeLanguage.Image = My.Resources.English
                English()
                WelcomeEN()

            Case 1
                pbWelcomeLanguage.Image = My.Resources.Bulgarian
                Bulgarian()
                WelcomeBG()

        End Select


        My.Settings.Language = cmbWelcomeLanguage.SelectedIndex
        My.Settings.Save()

    End Sub

    Private Sub cmbWelcomeTheme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbWelcomeTheme.SelectedIndexChanged
        Select Case cmbWelcomeTheme.SelectedIndex
            Case 0
                OfficeBlue()
            Case 1
                OfficeBlue2()
            Case 2
                OfficeSilver()
            Case 3
                DefaultTheme()
            Case 4
                OfficeGreen()
            Case 5
                Sky()
            Case 6
                Aqua()
            Case 7
                Sunset()
            Case 8
                Olive()
            Case 9
                Retro()
            Case 10
                RetroBlue()
            Case 11
                ModernBlue()
            Case 12
                ModernGreen()
            Case 13
                ModernOrange()
            Case 14
                Steel()
        End Select

        My.Settings.Theme = cmbWelcomeTheme.SelectedIndex
        My.Settings.Save()
    End Sub

    Private Sub btnNext1_Click(sender As Object, e As EventArgs) Handles btnNext1.Click
        WelcomeTabControl.SelectedTab = Step2
    End Sub

    Private Sub btnNext2_Click(sender As Object, e As EventArgs) Handles btnNext2.Click
        WelcomeTabControl.SelectedTab = Step3
    End Sub

    Private Sub btnNext3_Click(sender As Object, e As EventArgs) Handles btnNext3.Click
        WelcomeTabControl.SelectedTab = Step4
    End Sub

    Private Sub btnNext4_Click(sender As Object, e As EventArgs) Handles btnNext4.Click
        WelcomeTabControl.SelectedTab = Step5
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        TabControl.TabPages.Remove(FirstRunTabPage)
        TabControl.SelectedTab = HomeTabPage
    End Sub

    Private Sub btnBack1_Click(sender As Object, e As EventArgs) Handles btnBack1.Click
        WelcomeTabControl.SelectedTab = Step1
    End Sub

    Private Sub btnBack2_Click(sender As Object, e As EventArgs) Handles btnBack2.Click
        WelcomeTabControl.SelectedTab = Step2
    End Sub

    Private Sub btnBack3_Click(sender As Object, e As EventArgs) Handles btnBack3.Click
        WelcomeTabControl.SelectedTab = Step3
    End Sub

    Private Sub btnBack4_Click(sender As Object, e As EventArgs) Handles btnBack4.Click
        WelcomeTabControl.SelectedTab = Step4
    End Sub

    Private Sub lblContact_Click(sender As Object, e As EventArgs) Handles lblContact.Click
        NewTab()
        CType(TabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Url = "http://jaguarbrowser.wixsite.com/jaguar/contact"
    End Sub

#End Region

#Region "Functions"

    Sub SettingsLoad()
        'Region JHP
        JHPCmbSearchEngines.SelectedIndex = My.Settings.SearchEngineINDEX
        MHPCmbSearchEngines.SelectedIndex = My.Settings.SearchEngineINDEX
        frmSettingscmbSearchEngines.SelectedIndex = My.Settings.SearchEngineINDEX

        'Region Welcome
        cmbWelcomeLanguage.SelectedIndex = My.Settings.Language
        cmbWelcomeTheme.SelectedIndex = My.Settings.Theme
    End Sub

    Public Function CheckURL(ByVal urltocheck As String)
        Dim url As New Uri("http://" & urltocheck)
        Dim req As WebRequest
        req = WebRequest.Create(url)
        Dim resp As WebResponse
        Try
            resp = req.GetResponse()
            resp.Close()
            req = Nothing
            Return True
        Catch ex As Exception
            req = Nothing
            Return False
        End Try
    End Function

    Sub Search()

        If CheckURL(SearchField.Text) = True Then
            CType(TabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Url = SearchField.Text
        Else
            CType(TabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Url = My.Settings.SearchEngine & SearchField.Text
        End If

        favicon()

    End Sub

    Sub StartupSearch()

        If CheckURL(SearchField.Text) = True Then
            CType(TabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Url = SearchField.Text
        Else
            CType(TabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Url = My.Settings.SearchEngine & SearchField.Text
        End If

        favicon()

        SearchField.Items.Add(SearchField.Text)

    End Sub

    Sub SlideIn()
        SideMenu.Location = New System.Drawing.Point(-355, 0)
        Do Until SideMenu.Location.X = 0
            SideMenu.Location = New System.Drawing.Point(SideMenu.Location.X + 1, 0)
        Loop

        Do Until SideMenu.Location.X = 0
            SideMenu.Location = New System.Drawing.Point(SideMenu.Location.X + 1, 0)
            Refresh()
            System.Threading.Thread.Sleep(20)
        Loop
    End Sub

    Sub SlideOut()
        SideMenu.Location = New System.Drawing.Point(0, 0)
        Do Until SideMenu.Location.X = -300
            SideMenu.Location = New System.Drawing.Point(SideMenu.Location.X - 1, 0)
        Loop

        Do Until SideMenu.Location.X = -355
            SideMenu.Location = New System.Drawing.Point(SideMenu.Location.X - 1, 0)
            System.Threading.Thread.Sleep(1)
            Refresh()
        Loop
    End Sub

    Sub favicon()
        Try
            Dim url As Uri = New Uri(SearchField.Text)
            Dim iconURL = "http://" & url.Host & "/favicon.ico"
            Dim request As WebRequest = HttpWebRequest.Create(iconURL)
            Dim response As HttpWebResponse = request.GetResponse()
            Dim stream As Stream = response.GetResponseStream()
            Dim favicon = Image.FromStream(stream)
            WebsiteIcon.Image = favicon
        Catch ex As Exception
            WebsiteIcon.Image = Nothing
        End Try
    End Sub

    Sub NewTab()
        TabControl.EnableCloseButtons = False
        Dim TabPage As New vTabPage
        TabControl.TabPages.Add(TabPage)
        TabControl.SelectedTab = TabPage
        TabPage.Text = "New Tab"
        TabPage.HeaderHeight = 27
        TabPage.HeaderWidth = 200
        TabPage.TextAlignment = ContentAlignment.MiddleLeft

        Dim WebBrowser As New EO.WinForm.WebControl
        WebBrowser.Parent = TabControl.SelectedTab
        WebBrowser.Dock = DockStyle.Fill
        TabPage.Controls.Add(WebBrowser)

        WebBrowser.WebView = Me.WebView

    End Sub

    Sub Tabs()
        TabControl.TabPages.Remove(MyHomePage)
        TabControl.TabPages.Remove(FirstRunTabPage)
        TabControl.TabPages.Remove(WebDevTabPage)
        TabControl.TabPages.Remove(SettingsTab)
        TabControl.TabPages.Remove(HomeTabPage)
        TabControl.TabPages.Remove(TabPage)
    End Sub

    Sub Startup()
        Select Case My.Settings.StartupLOAD

            Case (0)
                TabControl.TabPages.Add(HomeTabPage)
                TabControl.SelectedTab = HomeTabPage
                If My.Settings.Language = 0 Then
                    SearchField.Text = "Jaguar Home"
                Else
                    SearchField.Text = "Начална страница"
                End If
                TabControl.TabPages.Remove(TabControl.TabPages.Count - 1)

            Case (1)
                If My.Settings.Language = 0 Then
                    SearchField.Text = "Search or enter adress"
                Else
                    SearchField.Text = "Въведи адрес или потърси"
                End If
                NewTab()

            Case (2)
                SearchField.Text = My.Settings.Homepage
                NewTab()
                StartupSearch()
                favicon()

            Case (3)
                SearchField.Text = My.Settings.SpecificURL
                NewTab()
                StartupSearch()
                favicon()

            Case (4)
                TabControl.TabPages.Add(MyHomePage)
                TabControl.SelectedTab = MyHomePage
                If My.Settings.Language = 0 Then
                    SearchField.Text = "My Homepage"
                Else
                    SearchField.Text = "Моята начална страница"
                End If
                TabControl.TabPages.Remove(TabControl.TabPages.Count - 1)
                MHPbtnBookmarksForward.Width = MHPBookmarksPanel.Width / 2
                MHPbtnBookmarksBackward.Width = MHPBookmarksPanel.Width / 2
                Try
                    MHPBackground.Image = Image.FromFile(My.Settings.MHPBackground.ToString)
                Catch ex As Exception
                End Try
                Try
                    My.Computer.Audio.Play(My.Settings.MHPSound.ToString, AudioPlayMode.Background)
                Catch ex As Exception
                End Try
                If My.Settings.MHPSearchFieldX <> 0 And My.Settings.MHPSearchFieldY <> 0 And My.Settings.MHPSearchButtonX <> 0 And My.Settings.MHPSearchButtonY <> 0 Then
                    MHPSearchFieldPanel.Location = New Point(My.Settings.MHPSearchFieldX, My.Settings.MHPSearchFieldY)
                    MHPSearchButtonPanel.Location = New Point(My.Settings.MHPSearchButtonX, My.Settings.MHPSearchButtonY)
                End If
                MHPBookmarksPanel.BackColor = My.Settings.MHPColor
                MHPBookmarksToolsPanel.BackColor = My.Settings.MHPColor

        End Select

        SearchField.DataSource = My.Settings.History

    End Sub

    Sub FirstRun()
        If My.Settings.FirstRun = True Then
            TabControl.TabPages.Add(FirstRunTabPage)
            TabControl.SelectedTab = FirstRunTabPage
            My.Settings.FirstRun = False
        End If
    End Sub

    Sub History()

        My.Settings.History.Add(SearchField.Text)
        SearchField.DataSource = My.Settings.History

    End Sub

    Sub Bookmark()

        If SearchField.Text <> "Settings" Then
            My.Settings.Bookmarks.Add(SearchField.Text)
            frmSettingschklistBookmarks.Items.Add(SearchField.Text)
        End If

        If frmSettingschkboxVisableBookmarks.Checked = True Then
            BookmarksBar.Items.Add(CType(TabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Url.ToString, WebsiteIcon.Image)
        End If

    End Sub

    Sub Bookmarked()

        Dim MatchFound As Boolean = False
        Dim I As Integer = 0

        ' Loop until I is greater than or equal to items OR there is a match found
        Do
            ' If text is in item, highlight item and mark match as found
            If InStr(frmSettingschklistBookmarks.Items(I).ToString, SearchField.Text, CompareMethod.Text) > 0 Then
                MatchFound = True
                frmMainFormbtnBookmark.Image = New Bitmap(My.Resources.Bookmark_1)
            End If
            I += 1
        Loop Until (I >= frmSettingschklistBookmarks.Items.Count) Or (MatchFound)

        ' If no match was found, deselect
        If Not MatchFound Then
            frmMainFormbtnBookmark.Image = New Bitmap(My.Resources.Bookmark)
        End If

    End Sub

#End Region

#Region "Themes"

    Dim BColor As Color
    Dim FColor As Color
    Dim SMBColor As Color
    Dim Theme As VIBlend.Utilities.VIBLEND_THEME

    Sub DefaultTheme()
        BColor = Color.FromArgb(227, 230, 232)
        SMBColor = Color.Gray
        FColor = Color.White
        Theme = OFFICE2010SILVER

        TabControl.VIBlendTheme = Theme
        SettingsTabControl.VIBlendTheme = Theme
        MainPanel.BackColor = BColor
        SearchPanel.BackColor = BColor
        SideMenu.ZoomStatus.BackColor = SMBColor
        SideMenu.BackColor = SMBColor
        frmMainFormbtnSearch.BackColor = BColor
        frmMainFormbtnVoiceInput.BackColor = BColor
        frmMainFormbtnRefresh.BackColor = BColor
        frmMainFormbtnStop.BackColor = BColor
        frmMainFormbtnBookmark.BackColor = BColor
        GeneralSettingsTitlePanel.BackColor = BColor
        HistoryTitlePanel.BackColor = BColor
        BookmarksTitlePanel.BackColor = BColor
        DownloadsTitlePanel.BackColor = BColor
        CustomizeTitlePanel.BackColor = BColor
        AboutTitlePanel.BackColor = BColor
        BookmarksBar.BackColor = BColor
    End Sub

    Sub OfficeBlue()
        BColor = Color.FromArgb(191, 219, 255)
        SMBColor = Color.FromArgb(51, 138, 255)
        FColor = Color.White
        Theme = VIBlend.Utilities.VIBLEND_THEME.OFFICEBLUE

        TabControl.VIBlendTheme = Theme
        SettingsTabControl.VIBlendTheme = Theme
        MainPanel.BackColor = BColor
        SearchPanel.BackColor = BColor
        SideMenu.ZoomStatus.BackColor = SMBColor
        SideMenu.BackColor = SMBColor
        frmMainFormbtnSearch.BackColor = BColor
        frmMainFormbtnVoiceInput.BackColor = BColor
        frmMainFormbtnRefresh.BackColor = BColor
        frmMainFormbtnStop.BackColor = BColor
        frmMainFormbtnBookmark.BackColor = BColor
        GeneralSettingsTitlePanel.BackColor = BColor
        HistoryTitlePanel.BackColor = BColor
        BookmarksTitlePanel.BackColor = BColor
        DownloadsTitlePanel.BackColor = BColor
        CustomizeTitlePanel.BackColor = BColor
        AboutTitlePanel.BackColor = BColor
        BookmarksBar.BackColor = BColor
    End Sub

    Sub OfficeBlue2()
        BColor = Color.FromArgb(187, 206, 230)
        SMBColor = Color.FromArgb(94, 139, 196)
        FColor = Color.White
        Theme = OFFICE2010BLUE

        TabControl.VIBlendTheme = Theme
        SettingsTabControl.VIBlendTheme = Theme
        MainPanel.BackColor = BColor
        SearchPanel.BackColor = BColor
        SideMenu.ZoomStatus.BackColor = SMBColor
        SideMenu.BackColor = SMBColor
        frmMainFormbtnSearch.BackColor = BColor
        frmMainFormbtnVoiceInput.BackColor = BColor
        frmMainFormbtnRefresh.BackColor = BColor
        frmMainFormbtnStop.BackColor = BColor
        frmMainFormbtnBookmark.BackColor = BColor
        GeneralSettingsTitlePanel.BackColor = BColor
        HistoryTitlePanel.BackColor = BColor
        BookmarksTitlePanel.BackColor = BColor
        DownloadsTitlePanel.BackColor = BColor
        CustomizeTitlePanel.BackColor = BColor
        AboutTitlePanel.BackColor = BColor
        BookmarksBar.BackColor = BColor
    End Sub

    Sub OfficeSilver()
        BColor = Color.FromArgb(207, 212, 221)
        SMBColor = Color.Gray
        FColor = Color.White
        Theme = VIBlend.Utilities.VIBLEND_THEME.OFFICESILVER

        TabControl.VIBlendTheme = Theme
        SettingsTabControl.VIBlendTheme = Theme
        MainPanel.BackColor = BColor
        SearchPanel.BackColor = BColor
        SideMenu.ZoomStatus.BackColor = SMBColor
        SideMenu.BackColor = SMBColor
        frmMainFormbtnSearch.BackColor = BColor
        frmMainFormbtnVoiceInput.BackColor = BColor
        frmMainFormbtnRefresh.BackColor = BColor
        frmMainFormbtnStop.BackColor = BColor
        frmMainFormbtnBookmark.BackColor = BColor
        GeneralSettingsTitlePanel.BackColor = BColor
        HistoryTitlePanel.BackColor = BColor
        BookmarksTitlePanel.BackColor = BColor
        DownloadsTitlePanel.BackColor = BColor
        CustomizeTitlePanel.BackColor = BColor
        AboutTitlePanel.BackColor = BColor
        BookmarksBar.BackColor = BColor
    End Sub

    Sub OfficeGreen()
        BColor = Color.FromArgb(222, 239, 229)
        SMBColor = Color.DarkSeaGreen
        FColor = Color.White
        Theme = VIBlend.Utilities.VIBLEND_THEME.OFFICEGREEN

        TabControl.VIBlendTheme = Theme
        SettingsTabControl.VIBlendTheme = Theme
        MainPanel.BackColor = BColor
        SearchPanel.BackColor = BColor
        SideMenu.ZoomStatus.BackColor = SMBColor
        SideMenu.BackColor = SMBColor
        frmMainFormbtnSearch.BackColor = BColor
        frmMainFormbtnVoiceInput.BackColor = BColor
        frmMainFormbtnRefresh.BackColor = BColor
        frmMainFormbtnStop.BackColor = BColor
        frmMainFormbtnBookmark.BackColor = BColor
        GeneralSettingsTitlePanel.BackColor = BColor
        HistoryTitlePanel.BackColor = BColor
        BookmarksTitlePanel.BackColor = BColor
        DownloadsTitlePanel.BackColor = BColor
        CustomizeTitlePanel.BackColor = BColor
        AboutTitlePanel.BackColor = BColor
        BookmarksBar.BackColor = BColor
    End Sub

    Sub Sky()
        BColor = Color.FromArgb(214, 231, 255)
        SMBColor = Color.LightSeaGreen
        FColor = Color.White
        Theme = BLUEBLEND

        TabControl.VIBlendTheme = Theme
        SettingsTabControl.VIBlendTheme = Theme
        MainPanel.BackColor = BColor
        SearchPanel.BackColor = BColor
        SideMenu.ZoomStatus.BackColor = SMBColor
        SideMenu.BackColor = SMBColor
        frmMainFormbtnSearch.BackColor = BColor
        frmMainFormbtnVoiceInput.BackColor = BColor
        frmMainFormbtnRefresh.BackColor = BColor
        frmMainFormbtnStop.BackColor = BColor
        frmMainFormbtnBookmark.BackColor = BColor
        GeneralSettingsTitlePanel.BackColor = BColor
        HistoryTitlePanel.BackColor = BColor
        BookmarksTitlePanel.BackColor = BColor
        DownloadsTitlePanel.BackColor = BColor
        CustomizeTitlePanel.BackColor = BColor
        AboutTitlePanel.BackColor = BColor
        BookmarksBar.BackColor = BColor
    End Sub

    Sub Aqua()
        BColor = Color.FromArgb(198, 238, 246)
        SMBColor = Color.LightSeaGreen
        FColor = Color.White
        Theme = ULTRABLUE

        TabControl.VIBlendTheme = Theme
        SettingsTabControl.VIBlendTheme = Theme
        MainPanel.BackColor = BColor
        SearchPanel.BackColor = BColor
        SideMenu.ZoomStatus.BackColor = SMBColor
        SideMenu.BackColor = SMBColor
        frmMainFormbtnSearch.BackColor = BColor
        frmMainFormbtnVoiceInput.BackColor = BColor
        frmMainFormbtnRefresh.BackColor = BColor
        frmMainFormbtnStop.BackColor = BColor
        frmMainFormbtnBookmark.BackColor = BColor
        GeneralSettingsTitlePanel.BackColor = BColor
        HistoryTitlePanel.BackColor = BColor
        BookmarksTitlePanel.BackColor = BColor
        DownloadsTitlePanel.BackColor = BColor
        CustomizeTitlePanel.BackColor = BColor
        AboutTitlePanel.BackColor = BColor
        BookmarksBar.BackColor = BColor
    End Sub

    Sub Sunset()
        BColor = Color.FromArgb(255, 242, 191)
        SMBColor = Color.FromArgb(255, 192, 128)
        FColor = Color.White
        Theme = ORANGEFRESH

        TabControl.VIBlendTheme = Theme
        SettingsTabControl.VIBlendTheme = Theme
        MainPanel.BackColor = BColor
        SearchPanel.BackColor = BColor
        SideMenu.ZoomStatus.BackColor = SMBColor
        SideMenu.BackColor = SMBColor
        frmMainFormbtnSearch.BackColor = BColor
        frmMainFormbtnVoiceInput.BackColor = BColor
        frmMainFormbtnRefresh.BackColor = BColor
        frmMainFormbtnStop.BackColor = BColor
        frmMainFormbtnBookmark.BackColor = BColor
        GeneralSettingsTitlePanel.BackColor = BColor
        HistoryTitlePanel.BackColor = BColor
        BookmarksTitlePanel.BackColor = BColor
        DownloadsTitlePanel.BackColor = BColor
        CustomizeTitlePanel.BackColor = BColor
        AboutTitlePanel.BackColor = BColor
        BookmarksBar.BackColor = BColor
    End Sub

    Sub Olive()
        BColor = Color.FromArgb(241, 245, 217)
        SMBColor = Color.FromArgb(190, 210, 80)
        FColor = Color.White
        Theme = OFFICE2003OLIVE

        TabControl.VIBlendTheme = Theme
        SettingsTabControl.VIBlendTheme = Theme
        MainPanel.BackColor = BColor
        SearchPanel.BackColor = BColor
        SideMenu.ZoomStatus.BackColor = SMBColor
        SideMenu.BackColor = SMBColor
        frmMainFormbtnSearch.BackColor = BColor
        frmMainFormbtnVoiceInput.BackColor = BColor
        frmMainFormbtnRefresh.BackColor = BColor
        frmMainFormbtnStop.BackColor = BColor
        frmMainFormbtnBookmark.BackColor = BColor
        GeneralSettingsTitlePanel.BackColor = BColor
        HistoryTitlePanel.BackColor = BColor
        BookmarksTitlePanel.BackColor = BColor
        DownloadsTitlePanel.BackColor = BColor
        CustomizeTitlePanel.BackColor = BColor
        AboutTitlePanel.BackColor = BColor
        BookmarksBar.BackColor = BColor
    End Sub

    Sub Retro()
        BColor = Color.FromArgb(245, 247, 238)
        SMBColor = Color.FromArgb(174, 176, 128)
        FColor = Color.White
        Theme = VIBlend.Utilities.VIBLEND_THEME.RETRO

        TabControl.VIBlendTheme = Theme
        SettingsTabControl.VIBlendTheme = Theme
        MainPanel.BackColor = BColor
        SearchPanel.BackColor = BColor
        SideMenu.ZoomStatus.BackColor = SMBColor
        SideMenu.BackColor = SMBColor
        frmMainFormbtnSearch.BackColor = BColor
        frmMainFormbtnVoiceInput.BackColor = BColor
        frmMainFormbtnRefresh.BackColor = BColor
        frmMainFormbtnStop.BackColor = BColor
        frmMainFormbtnBookmark.BackColor = BColor
        GeneralSettingsTitlePanel.BackColor = BColor
        HistoryTitlePanel.BackColor = BColor
        BookmarksTitlePanel.BackColor = BColor
        DownloadsTitlePanel.BackColor = BColor
        CustomizeTitlePanel.BackColor = BColor
        AboutTitlePanel.BackColor = BColor
        BookmarksBar.BackColor = BColor
    End Sub

    Sub RetroBlue()
        BColor = Color.FromArgb(224, 232, 243)
        SMBColor = Color.FromArgb(78, 123, 186)
        FColor = Color.White
        Theme = VIBlend.Utilities.VIBLEND_THEME.RETROBLUE

        TabControl.VIBlendTheme = Theme
        SettingsTabControl.VIBlendTheme = Theme
        MainPanel.BackColor = BColor
        SearchPanel.BackColor = BColor
        SideMenu.ZoomStatus.BackColor = SMBColor
        SideMenu.BackColor = SMBColor
        frmMainFormbtnSearch.BackColor = BColor
        frmMainFormbtnVoiceInput.BackColor = BColor
        frmMainFormbtnRefresh.BackColor = BColor
        frmMainFormbtnStop.BackColor = BColor
        frmMainFormbtnBookmark.BackColor = BColor
        GeneralSettingsTitlePanel.BackColor = BColor
        HistoryTitlePanel.BackColor = BColor
        BookmarksTitlePanel.BackColor = BColor
        DownloadsTitlePanel.BackColor = BColor
        CustomizeTitlePanel.BackColor = BColor
        AboutTitlePanel.BackColor = BColor
        BookmarksBar.BackColor = BColor
    End Sub

    Sub ModernBlue()
        BColor = Color.FromArgb(27, 161, 226)
        SMBColor = Color.FromArgb(29, 96, 128)
        FColor = Color.White
        Theme = METROBLUE

        TabControl.VIBlendTheme = Theme
        SettingsTabControl.VIBlendTheme = Theme
        MainPanel.BackColor = BColor
        SearchPanel.BackColor = BColor
        SideMenu.ZoomStatus.BackColor = SMBColor
        SideMenu.BackColor = SMBColor
        frmMainFormbtnSearch.BackColor = BColor
        frmMainFormbtnVoiceInput.BackColor = BColor
        frmMainFormbtnRefresh.BackColor = BColor
        frmMainFormbtnStop.BackColor = BColor
        frmMainFormbtnBookmark.BackColor = BColor
        GeneralSettingsTitlePanel.BackColor = BColor
        HistoryTitlePanel.BackColor = BColor
        BookmarksTitlePanel.BackColor = BColor
        DownloadsTitlePanel.BackColor = BColor
        CustomizeTitlePanel.BackColor = BColor
        AboutTitlePanel.BackColor = BColor
        BookmarksBar.BackColor = BColor
    End Sub

    Sub ModernGreen()
        BColor = Color.FromArgb(51, 153, 51)
        SMBColor = Color.FromArgb(39, 120, 39)
        FColor = Color.White
        Theme = METROGREEN

        TabControl.VIBlendTheme = Theme
        SettingsTabControl.VIBlendTheme = Theme
        MainPanel.BackColor = BColor
        SearchPanel.BackColor = BColor
        SideMenu.ZoomStatus.BackColor = SMBColor
        SideMenu.BackColor = SMBColor
        frmMainFormbtnSearch.BackColor = BColor
        frmMainFormbtnVoiceInput.BackColor = BColor
        frmMainFormbtnRefresh.BackColor = BColor
        frmMainFormbtnStop.BackColor = BColor
        frmMainFormbtnBookmark.BackColor = BColor
        GeneralSettingsTitlePanel.BackColor = BColor
        HistoryTitlePanel.BackColor = BColor
        BookmarksTitlePanel.BackColor = BColor
        DownloadsTitlePanel.BackColor = BColor
        CustomizeTitlePanel.BackColor = BColor
        AboutTitlePanel.BackColor = BColor
        BookmarksBar.BackColor = BColor
    End Sub

    Sub ModernOrange()
        BColor = Color.FromArgb(240, 150, 9)
        SMBColor = Color.FromArgb(165, 101, 5)
        FColor = Color.White
        Theme = METROORANGE

        TabControl.VIBlendTheme = Theme
        SettingsTabControl.VIBlendTheme = Theme
        MainPanel.BackColor = BColor
        SearchPanel.BackColor = BColor
        SideMenu.ZoomStatus.BackColor = SMBColor
        SideMenu.BackColor = SMBColor
        frmMainFormbtnSearch.BackColor = BColor
        frmMainFormbtnVoiceInput.BackColor = BColor
        frmMainFormbtnRefresh.BackColor = BColor
        frmMainFormbtnStop.BackColor = BColor
        frmMainFormbtnBookmark.BackColor = BColor
        GeneralSettingsTitlePanel.BackColor = BColor
        HistoryTitlePanel.BackColor = BColor
        BookmarksTitlePanel.BackColor = BColor
        DownloadsTitlePanel.BackColor = BColor
        CustomizeTitlePanel.BackColor = BColor
        AboutTitlePanel.BackColor = BColor
        BookmarksBar.BackColor = BColor
    End Sub

    Sub Steel()
        BColor = Color.FromArgb(227, 227, 227)
        SMBColor = Color.Gray
        FColor = Color.White
        Theme = VIBlend.Utilities.VIBLEND_THEME.STEEL

        TabControl.VIBlendTheme = Theme
        SettingsTabControl.VIBlendTheme = Theme
        MainPanel.BackColor = BColor
        SearchPanel.BackColor = BColor
        SideMenu.ZoomStatus.BackColor = SMBColor
        SideMenu.BackColor = SMBColor
        frmMainFormbtnSearch.BackColor = BColor
        frmMainFormbtnVoiceInput.BackColor = BColor
        frmMainFormbtnRefresh.BackColor = BColor
        frmMainFormbtnStop.BackColor = BColor
        frmMainFormbtnBookmark.BackColor = BColor
        GeneralSettingsTitlePanel.BackColor = BColor
        HistoryTitlePanel.BackColor = BColor
        BookmarksTitlePanel.BackColor = BColor
        DownloadsTitlePanel.BackColor = BColor
        CustomizeTitlePanel.BackColor = BColor
        AboutTitlePanel.BackColor = BColor
        BookmarksBar.BackColor = BColor
    End Sub

#End Region

#Region "Languages"

    Sub English()

        'Main Form'
        Me.Text = "Jaguar Web Browser"
        FormTitle.Text = "Jaguar Web Browser"
        lblFullScreen.Text = "You are now in Fullscreen Mode. Press ESC to exit."
        SettingsTab.Text = "Settings"
        HomeTabPage.Text = "Jaguar Home"
        WebDevTabPage.Text = "Jaguar Web Development Tool"
        MyHomePage.Text = "My Homepage"
        SearchField.Text = "Settings"
        '____________________________'



        'Side Menu'
        SideMenu.LabelName.Text = "Side Menu"
        SideMenu.frmSideMenubtnNewWindow.Text = "New Window"
        SideMenu.frmSideMenubtnIncognitoWindow.Text = "Incognito Window"
        SideMenu.frmSideMenubtnSavePage.Text = "Save Webpage"
        SideMenu.frmSideMenubtnHistory.Text = "History"
        SideMenu.frmSideMenubtnBookmarks.Text = "Bookmarks"
        SideMenu.frmSideMenubtnDownloadManager.Text = "Download Manager"
        SideMenu.frmSideMenubtnCustomize.Text = "Customize"
        SideMenu.frmSideMenubtnFullScreen.Text = "Fullscreen"
        SideMenu.frmSideMenubtnPrint.Text = "Print"
        SideMenu.frmSideMenubtnDevelopers.Text = "Developer"
        SideMenu.frmSideMenubtnSearch.Text = "Search"
        SideMenu.frmSideMenubtnSettings.Text = "Settings"
        SideMenu.ConnectionStatus()
        '____________________________'



        'Settings'
        GeneralTabPage.Text = "General"
        HistoryTabPage.Text = "History"
        BookmarksTabPage.Text = "Bookmarks"
        DownloadsTabPage.Text = "Downloads"
        CustomizeTabPage.Text = "Customize"
        AboutTabPage.Text = "About"
        '____________________________'



        'General'
        Label4.Text = "General Settings"

        Label1.Text = "On startup"
        Label2.Text = "Set your startup page"
        Label3.Text = "Enter URL here:"
        lblMsg1.Text = "The URL has been set"
        frmSettingsbtnSetStartupPage.Text = "Set"

        Label8.Text = "Homepage"
        Label10.Text = "Set your homepage"
        Label9.Text = "Enter URL here: "
        lblMsg2.Text = "The URL has been set"
        frmSettingsbtnSetHomepage.Text = "Set"

        Label6.Text = "Search"
        Label7.Text = "Set which search engine is used when" & vbCrLf & "searching from the Search Field or Jaguar Homepage"
        Label5.Text = "Search Engines: "

        frmSettingslblDownloads.Text = "Downloads"
        frmSettingsoptLemmeSave.Text = "Let me choose where to save"
        frmSettingsoptSaveToLocation.Text = "Save to location: "

        frmSettingschkboxDefaultBrowser.Text = "Make Jaguar my default web browser (Coming soon)"
        '____________________________'



        'History'
        Label22.Text = "History"

        frmSettingschkboxSelectAllHistory.Text = "Select all"
        frmSettingsbtnClearHistory.Text = "Clear selected item(s)"
        Label15.Text = "Search the history: "
        '____________________________'



        'Bookmarks'
        Label11.Text = "Bookmarks"

        frmSettingschkboxSelectAllBookmarks.Text = "Select all"
        frmSettingsbtnClearBookmarks.Text = "Clear selected item(s)"
        Label16.Text = "Search the bookmarks: "
        '____________________________'



        'Downloads'
        Label12.Text = "Downloads"

        frmSettingschkboxSelectAllDownloads.Text = "Select all"
        frmSettingsbtnClearDownloads.Text = "Clear selected item(s)"
        Label17.Text = "Search the history: "
        '____________________________'



        'Customize'
        Label13.Text = "Customize"

        Label18.Text = "Customize allows you to set different look and feel" & vbCrLf & "to your web browser. Choose from the themes below: "
        Label31.Text = "Choose Language: "
        frmSettingschkboxVisableBookmarks.Text = "Always show bookmarks bar (Coming soon)"
        '____________________________'



        'About'
        Label14.Text = "About us"

        Label28.Text = "Jaguar Web Browser"
        Label21.Text = "Fast  Simple  Ellegant"
        Label20.Text = "Version: 0.9.7.2"
        Label23.Text = "Status: "
        Label19.Text = "being developed"
        Label25.Text = "Founders: "
        Label26.Text = "• Martin Dzhurov - MSD"
        Label27.Text = "• Dilyan Dyankov - DilyanD."
        Label24.Text = "(©) Jaguar Web Browser 2017"

        Label36.Text = "Reset"
        Label35.Text = "Set all default settings of your browser. Deletes all cookies, bookmarks and passwords."
        btnReset.Text = "Reset"

        Label30.Text = "Report a problem"
        Label29.Text = "If you notice any bugs, glitches, or anything else wrong, please report it to us via the button below."
        btnReport.Text = "Report"
        '____________________________'


        'Jaguar Web Development Tool'
        WelcomeTabPage.Text = "Welcome"
        Label34.Text = "Jaguar Web Development Tool"
        Label33.Text = "Start"
        lblNewFile.Text = "New File..."
        lblOpenFile.Text = "Open File..."
        Label32.Text = "Recent"
        '____________________________'

        'Tooltip
        ToolTip1.SetToolTip(frmMainFormbtnSearch, "You cannot use this button to search while in the Jaguar Homepage, please use the search below.")

    End Sub

    Sub Bulgarian()

        'Main Form'
        Me.Text = "Ягуар Уеб Браузър"
        FormTitle.Text = "Ягуар Уеб Браузър"
        lblFullScreen.Text = "Вие сте в режим Пълен екран. Натиснете Esc за да излезете."
        SettingsTab.Text = "Настройки"
        HomeTabPage.Text = "Начална страница"
        WebDevTabPage.Text = "Уеб инструменти за разработка"
        MyHomePage.Text = "Моята начална страница"
        SearchField.Text = "Настройки"
        '____________________________'



        'Side Menu'
        SideMenu.LabelName.Text = "Меню"
        SideMenu.frmSideMenubtnNewWindow.Text = "Нов прозорец"
        SideMenu.frmSideMenubtnIncognitoWindow.Text = "Инкогни-то"
        SideMenu.frmSideMenubtnSavePage.Text = "Съхрани"
        SideMenu.frmSideMenubtnHistory.Text = "История"
        SideMenu.frmSideMenubtnBookmarks.Text = "Отметки"
        SideMenu.frmSideMenubtnDownloadManager.Text = "Изтегля-ния"
        SideMenu.frmSideMenubtnCustomize.Text = "Персона-лизация"
        SideMenu.frmSideMenubtnFullScreen.Text = "Пълен екран"
        SideMenu.frmSideMenubtnPrint.Text = "Принти- рай"
        SideMenu.frmSideMenubtnDevelopers.Text = "Програ- мисти"
        SideMenu.frmSideMenubtnSearch.Text = "Търси"
        SideMenu.frmSideMenubtnSettings.Text = "Настрой-ки"
        SideMenu.LabelConnectionStatus.Text = "Интернет статус:"
        SideMenu.ConnectionStatus()
        '____________________________'



        'Settings'
        GeneralTabPage.Text = "Общи"
        HistoryTabPage.Text = "История"
        BookmarksTabPage.Text = "Отметки"
        DownloadsTabPage.Text = "Изтегляния"
        CustomizeTabPage.Text = "Дизайн"
        AboutTabPage.Text = "За нас"
        '____________________________'



        'Genral'
        Label4.Text = "Общи настройки"

        Label1.Text = "При стартиране"
        Label2.Text = "Задай конкретна страница"
        Label3.Text = "Въведи адрес: "
        lblMsg1.Text = "Адресът е зададен"
        frmSettingsbtnSetStartupPage.Text = "Задай"

        Label8.Text = "Начална страница"
        Label10.Text = "Задай начална страница"
        Label9.Text = "Въведи адрес: "
        lblMsg2.Text = "Адресът е зададен"
        frmSettingsbtnSetHomepage.Text = "Задай"

        Label6.Text = "Търсачки"
        Label7.Text = "Задайте коя търсачка да се използва, когато търсите през" & vbCrLf & "главното поле или началната страница на Ягуар"
        Label5.Text = "Търсачки: "

        frmSettingslblDownloads.Text = "Изтегляния"
        frmSettingsoptLemmeSave.Text = "Нека да избирам къде да съхраня"
        frmSettingsoptSaveToLocation.Text = "Съхрани тук: "

        frmSettingschkboxDefaultBrowser.Text = "Направи Ягуар моя уеб браузър по подразбиране (Очаквайте скоро)"
        '____________________________'



        'History'
        Label22.Text = "История"

        frmSettingschkboxSelectAllHistory.Text = "Избери"
        frmSettingsbtnClearHistory.Text = "Изчисти избраните"
        Label15.Text = "Търси в историята: "
        '____________________________'



        'Bookmarks'
        Label11.Text = "Отметки"

        frmSettingschkboxSelectAllBookmarks.Text = "Избери"
        frmSettingsbtnClearBookmarks.Text = "Изчисти избраните"
        Label16.Text = "Търси в отметките: "
        '____________________________'



        'Downloads'
        Label12.Text = "Изтегляния"

        frmSettingschkboxSelectAllDownloads.Text = "Избери"
        frmSettingsbtnClearDownloads.Text = "Изчисти избраните"
        Label17.Text = "Търси в изтегляния: "
        '____________________________'



        'Customize'
        Label13.Text = "Персонализирай"

        Label18.Text = "Тук може да премените начина, по който изглежда" & vbCrLf & "вашия браузър. Изберете от предоставените теми  отдолу: "
        Label31.Text = "Избери език: "
        frmSettingschkboxVisableBookmarks.Text = "Винаги да се показва лентата с отметки (Очаквайте скоро)"
        '____________________________'



        'About'
        Label14.Text = "За нас"

        Label28.Text = "Ягуар Уеб Браузър"
        Label21.Text = "Бърз  Семпъл  Елегантен"
        Label20.Text = "Версия: 0.9.7.2"
        Label23.Text = "Статус: "
        Label19.Text = "разработва се"
        Label25.Text = "Основатели: "
        Label26.Text = "• Мартин Джуров - MSD"
        Label27.Text = "• Дилян Дянков - DilyanD."
        Label24.Text = "(©) Ягуар Уеб Браузър 2017"

        Label36.Text = "Рестартирай"
        Label35.Text = "Задава всички настройки по подразбиране, изтрива всички бисквитки, отметки и пароли."
        btnReset.Text = "Ресет"

        Label30.Text = "Докладвай проблем"
        Label29.Text = "Ако забележите някакви грешки, бъгове, или нещо друго нередно, моля свържете се с нас чрез бутона по-долу."
        btnReport.Text = "Докладвай"
        '____________________________'



        'Jaguar Web Development Tool'
        WelcomeTabPage.Text = "Начало"
        Label34.Text = "Ягуар - Уеб инструмент за разработка"
        Label33.Text = "Започни"
        lblNewFile.Text = "Нов файл..."
        lblOpenFile.Text = "Отвори файл..."
        Label32.Text = "Скорошни"
        '____________________________'

        'Tooltip
        ToolTip1.SetToolTip(frmMainFormbtnSearch, "Не можете да използвате този бутон за търсене, докато сте в началната страница. Моля, използвайте търсачката по-долу.")

    End Sub

    Sub WelcomeEN()

        FirstRunTabPage.Text = "Welcome to Jaguar"
        SearchField.Text = "Welcome to Jaguar"

        'Step 1'
        Label37.Text = "Welcome to Jaguar"
        Label38.Text = "Go through our quick guide to get to know with all the features!"
        Label39.Text = "But first let set some things!"
        Label40.Text = "Choose Language: "
        Label41.Text = "Choose Theme: "
        btnNext1.Text = "Next"

        'Step 2'
        Label42.Text = "The Main Form"
        Pic1.Image = My.Resources.EN
        btnBack1.Text = "Back"
        btnNext2.Text = "Next"

        'Step 3'
        Label43.Text = "The Side Menu"
        Pic2.Image = My.Resources.EN_2
        btnBack2.Text = "Back"
        btnNext3.Text = "Next"

        'Step 4'
        Label44.Text = "Settings"
        PIc3.Image = My.Resources.EN_3
        btnBack3.Text = "Back"
        btnNext4.Text = "Next"

        'Step 5'
        Label45.Text = "End of the guide"
        Label46.Text = "If you have any questions, make sure you contact us via link below:"
        Label47.Text = "Happy surfing! - Team JB"
        btnBack4.Text = "Back"
        btnFinish.Text = "Finish"

        'Tooltip
        ToolTip1.SetToolTip(frmMainFormbtnSearch, "You cannot use this button to search while in the Jaguar Homepage, please use the search below.")
    End Sub

    Sub WelcomeBG()

        FirstRunTabPage.Text = "Добре дошли в Ягуар"
        SearchField.Text = "Добре дошли в Ягуар"

        'Step 1'
        Label37.Text = "Добре дошли в Ягуар"
        Label38.Text = "Преминете бързото ни ръководство и се запознайте с всички функции!"
        Label39.Text = "Но нека първо настроим някои неща!"
        Label40.Text = "Избери език: "
        Label41.Text = "Избери тема: "
        btnNext1.Text = "Напред"

        'Step 2'
        Label42.Text = "Главната форма"
        Pic1.Image = My.Resources.BG1
        btnBack1.Text = "Назад"
        btnNext2.Text = "Напред"

        'Step 3'
        Label43.Text = "Страничното меню"
        Pic2.Image = My.Resources.BG_2
        btnBack2.Text = "Назад"
        btnNext3.Text = "Напред"

        'Step 4'
        Label44.Text = "Настройки"
        PIc3.Image = My.Resources.BG_3
        btnBack3.Text = "Назад"
        btnNext4.Text = "Напред"

        'Step 5'
        Label45.Text = "Край на ръководството"
        Label46.Text = "Ако имате някакви въпроси, свържете се с нас чрез линка отдолу:"
        Label47.Text = "Приятно сърфиране - Екип JB"
        btnBack4.Text = "Назад"
        btnFinish.Text = "Завърши"

        'Tooltip
        ToolTip1.SetToolTip(frmMainFormbtnSearch, "Не можете да използвате този бутон за търсене, докато сте в началната страница. Моля, използвайте търсачката по-долу.")

    End Sub

#End Region

End Class