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

Public Class IncognitoForm

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

    Private Sub IncognitoWindowForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Select Case My.Settings.Language
            Case 0
                English()
            Case 1
                Bulgarian()
        End Select

        JIPCmbSearchEngines.SelectedIndex = My.Settings.IncognitoSearchEngine

        IncognitoTabControl.TabPages.Remove(TabPage)
        IncognitoTabControl.SelectedTab = IncognitoTabPage
        Maximize()
    End Sub

    Private Sub IncognitoWindowForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        IncognitoWebView.Engine.Stop(True)
    End Sub

    Private Sub frmIncognitoWindowFormbtnBackward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmIncognitoWindowFormbtnBackward.Click
        Try
            CType(IncognitoTabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.GoBack()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmIncognitoWindowFormbtnForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmIncognitoWindowFormbtnForward.Click
        Try
            CType(IncognitoTabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.GoForward()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmIncognitoWindowFormbtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmIncognitoWindowFormbtnHome.Click
        IncognitoTabControl.TabPages.Add(IncognitoTabPage)
        IncognitoTabControl.SelectedTab = IncognitoTabPage
    End Sub

    Private Sub frmIncognitoWindowFormbtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmIncognitoWindowFormbtnSearch.Click
        Try
            Search()
            favicon()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmIncognitoWindowFormbtnSearch_MouseHover(sender As Object, e As EventArgs) Handles frmIncognitoWindowFormbtnSearch.MouseHover
        If IncognitoTabPage.IsSelected = True Then
            ToolTip1.Active = True
        Else
            ToolTip1.Active = False
        End If
    End Sub

    Private Sub frmIncognitoWindowFormbtnVoiceInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmIncognitoWindowFormbtnVoiceInput.Click

    End Sub

    Private Sub SearchField_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SearchField.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            Search()

            favicon()
        End If
    End Sub

    Private Sub frmIncognitoWindowFormbtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmIncognitoWindowFormbtnRefresh.Click
        Try
            CType(IncognitoTabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Reload()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmIncognitoWindowFormbtnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmIncognitoWindowFormbtnStop.Click
        Try
            CType(IncognitoTabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.StopLoad()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmIncognitoWindowFormbtnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmIncognitoWindowFormbtnMenu.Click
        SlideIn()
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        lblFullScreen.Visible = False
    End Sub


    Private Sub TabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IncognitoTabControl.SelectedIndexChanged

        Select Case My.Settings.Language
            Case 0
                'English'
                Select Case IncognitoTabControl.SelectedTab.Text

                    Case "Incognito Mode"
                        SearchField.Enabled = False
                        SearchField.Text = "Incognito Mode"
                        WebsiteIcon.Image = Nothing
                        WebsiteIcon.BackColor = Color.FromArgb(240, 240, 240)

                    Case Else
                        SearchField.Enabled = True
                        WebsiteIcon.BackColor = Color.White

                End Select

            Case 1
                'Bulgarian'
                Select Case IncognitoTabControl.SelectedTab.Text

                    Case "Инкогнито"
                        SearchField.Enabled = False
                        SearchField.Text = "Режим Инкогнито"
                        WebsiteIcon.Image = Nothing
                        WebsiteIcon.BackColor = Color.FromArgb(240, 240, 240)

                    Case Else
                        SearchField.Enabled = True
                        WebsiteIcon.BackColor = Color.White

                End Select

        End Select

        Try
            SearchField.Text = CType(IncognitoTabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Url.ToString
            favicon()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub WebView_LoadCompleted(ByVal sender As Object, ByVal e As EO.WebBrowser.LoadCompletedEventArgs) Handles IncognitoWebView.LoadCompleted
        Try
            IncognitoTabControl.SelectedTab.Text = CType(IncognitoTabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Title.ToString
            SearchField.Text = CType(IncognitoTabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Url.ToString
            favicon()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub WebView_NewWindow(ByVal sender As Object, ByVal e As EO.WebBrowser.NewWindowEventArgs) Handles IncognitoWebView.NewWindow
        NewTab()
    End Sub

    Private Sub WebView_UrlChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles IncognitoWebView.UrlChanged
        Try
            IncognitoTabControl.SelectedTab.Text = CType(IncognitoTabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Title.ToString
            SearchField.Text = CType(IncognitoTabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Url.ToString
            favicon()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub IncognitoWebView_BeforeContextMenu(sender As Object, e As BeforeContextMenuEventArgs) Handles IncognitoWebView.BeforeContextMenu

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

#Region "Incognito Home page"

    Dim IncognitoSearchEngine As String

    Private Sub JIPSearchButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles JIPSearchButton.Click

        NewTab()
        SearchField.Text = IncognitoSearchEngine & JIPSearchField.Text
        CType(IncognitoTabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Url = SearchField.Text
        IncognitoTabControl.TabPages.Remove(IncognitoTabPage)
        favicon()

    End Sub

    Private Sub JIPSearchField_KeyDown(sender As Object, e As KeyEventArgs) Handles JIPSearchField.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            NewTab()
            SearchField.Text = IncognitoSearchEngine & JIPSearchField.Text
            CType(IncognitoTabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Url = SearchField.Text
            IncognitoTabControl.TabPages.Remove(IncognitoTabPage)
            favicon()

        End If

    End Sub

    Private Sub JIPSearchField_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles JIPSearchField.GotFocus

        If JIPSearchField.BackColor = Color.WhiteSmoke And JIPSearchFieldPanel.BackColor = Color.WhiteSmoke And JIPCmbSearchEngines.BackColor = Color.WhiteSmoke Then
            JIPSearchField.BackColor = Color.White
            JIPSearchFieldPanel.BackColor = Color.White
            JIPCmbSearchEngines.BackColor = Color.White
        End If

    End Sub

    Private Sub JIPSearchField_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles JIPSearchField.LostFocus
        If JIPSearchField.BackColor = Color.White And JIPSearchFieldPanel.BackColor = Color.White And JIPCmbSearchEngines.BackColor = Color.White Then
            JIPSearchField.BackColor = Color.WhiteSmoke
            JIPSearchFieldPanel.BackColor = Color.WhiteSmoke
            JIPCmbSearchEngines.BackColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub JIPCmbSearchEngines_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles JIPCmbSearchEngines.SelectedIndexChanged
        Select Case JIPCmbSearchEngines.SelectedIndex
            Case (0)
                IncognitoSearchEngine = "https://www.google.com/search?q="
                JIPSearchEnginePic.Image = My.Resources.google
            Case (1)
                IncognitoSearchEngine = "https://www.bing.com/search?q="
                JIPSearchEnginePic.Image = My.Resources.bing

            Case (2)
                IncognitoSearchEngine = "https://search.yahoo.com/search;_ylc=X3oDMTFiN25laTRvBF9TAzIwMjM1MzgwNzUEaXRjAzEEc2VjA3NyY2hfcWEEc2xrA3NyY2h3ZWI-?p="
                JIPSearchEnginePic.Image = My.Resources.yahoo

            Case (3)
                IncognitoSearchEngine = "https://www.youtube.com/results?search_query="
                JIPSearchEnginePic.Image = My.Resources.youtube

            Case (4)
                IncognitoSearchEngine = "https://bg.wikipedia.org/w/index.php?search="
                JIPSearchEnginePic.Image = My.Resources.wikipedia

        End Select

        My.Settings.IncognitoSearchEngine = JIPCmbSearchEngines.SelectedIndex
        My.Settings.Save()
    End Sub

#End Region

#Region "Functions"

    Public Function CheckURL(ByVal urltocheck As String)
        Dim url As New System.Uri("http://" & urltocheck)
        Dim req As System.Net.WebRequest
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
            CType(IncognitoTabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Url = SearchField.Text
        Else
            CType(IncognitoTabControl.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Url = IncognitoSearchEngine & SearchField.Text
        End If

    End Sub

    Sub SlideIn()
        IncognitoSideMenu.Location = New Point(-355, 0)
        Do Until IncognitoSideMenu.Location.X = 0
            IncognitoSideMenu.Location = New Point(IncognitoSideMenu.Location.X + 1, 0)
        Loop

        Do Until IncognitoSideMenu.Location.X = 0
            IncognitoSideMenu.Location = New Point(IncognitoSideMenu.Location.X + 1, 0)
            Refresh()
            System.Threading.Thread.Sleep(20)
        Loop
    End Sub

    Sub SlideOut()
        IncognitoSideMenu.Location = New Point(0, 0)
        Do Until IncognitoSideMenu.Location.X = -300
            IncognitoSideMenu.Location = New Point(IncognitoSideMenu.Location.X - 1, 0)
        Loop

        Do Until IncognitoSideMenu.Location.X = -355
            IncognitoSideMenu.Location = New Point(IncognitoSideMenu.Location.X - 1, 0)
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
        IncognitoTabControl.EnableCloseButtons = True
        Dim TabPage As New vTabPage
        IncognitoTabControl.TabPages.Add(TabPage)
        IncognitoTabControl.SelectedTab = TabPage
        TabPage.Text = "New Tab"
        TabPage.HeaderHeight = 27
        TabPage.HeaderWidth = 160
        TabPage.TextAlignment = ContentAlignment.MiddleLeft

        Dim WebBrowser As New EO.WinForm.WebControl
        WebBrowser.WebView = Me.IncognitoWebView
        WebBrowser.Dock = DockStyle.Fill

        IncognitoTabControl.SelectedTab.Controls.Add(WebBrowser)
    End Sub

#End Region

#Region "Languages"

    Sub English()

        'Incognito Form'
        Me.Text = "Jaguar Web Browser - Incognito mode"
        FormTitle.Text = "Jaguar Web Browser - Incognito mode"
        lblFullScreen.Text = "You are now in Fullscreen Mode. Press ESC to exit"
        IncognitoTabPage.Text = "Inkognito Mode"
        '____________________________'

        'Incognito Side Menu'
        IncognitoSideMenu.LabelName.Text = "Side Menu"
        IncognitoSideMenu.frmSideMenubtnNewWindow.Text = "New Window"
        IncognitoSideMenu.frmSideMenubtnSavePage.Text = "Save Webpage"
        IncognitoSideMenu.frmSideMenubtnPrint.Text = "Print"
        IncognitoSideMenu.frmSideMenubtnFullScreen.Text = "Fullscreen"
        IncognitoSideMenu.frmSideMenubtnSearch.Text = "Search"
        '____________________________'

        'Incognito Page'
        Label3.Text = "Welcome to Incognito Browsing Mode"
        Label7.Text = "While in Incognito Mode, Jaguar Browser does not save: "
        Label8.Text = "• Visited Pages" & vbCrLf & "• Searches" & vbCrLf & "• Temp Files"
        Label9.Text = "• Bookmarks" & vbCrLf & "• History" & vbCrLf & "• Downloads"
        Label10.Text = "Please note, that although you're in incognito mode, your Internet service provider can still track your browsing." & vbCrLf & "Happy surfing! - Team JB"
        '____________________________'

    End Sub

    Sub Bulgarian()

        'Incognito Form'
        Me.Text = "Ягуар Уеб Браузър - Режим инкогнито"
        FormTitle.Text = "Ягуар Уеб Браузър - Режим инкогнито"
        lblFullScreen.Text = "Вие сте в режим Пълен екран. Натиснете Esc за да излезете."
        IncognitoTabPage.Text = "Инкогнито"
        '____________________________'

        'Incognito Side Menu'
        IncognitoSideMenu.LabelName.Text = "Меню"
        IncognitoSideMenu.frmSideMenubtnNewWindow.Text = "Нов прозорец"
        IncognitoSideMenu.frmSideMenubtnSavePage.Text = "Съхрани"
        IncognitoSideMenu.frmSideMenubtnPrint.Text = "Принти- рай"
        IncognitoSideMenu.frmSideMenubtnFullScreen.Text = "Пълен екран"
        IncognitoSideMenu.frmSideMenubtnSearch.Text = "Търси"
        '____________________________'

        'Incognito Page'
        Label3.Text = "Добре дошли в Режим Инкогнито"
        Label7.Text = "Докато сте в Режим Инкогнито, Ягуар няма да запазва: "
        Label8.Text = "• Посетените страници" & vbCrLf & "• Търсенията" & vbCrLf & "• Временните файлове"
        Label9.Text = "• Отметки" & vbCrLf & "• История" & vbCrLf & "• Изтегляния"
        Label10.Text = "Моля, имайте предвид, че въпреки че сте в режим инкогнито, вашият Интернет доставчик все още може да Ви проследи." & vbCrLf & "Приятно сърфиране! - Екип JB"
        '____________________________'
    End Sub

#End Region
End Class