#Region "Imports"
Imports VIBlend.WinForms.Controls
Imports VIBlend.Utilities.VIBLEND_THEME
Imports VIBlend.WinForms.Controls.TabsShape
Imports EO.WebBrowser
Imports EO.WinForm.WebControl
Imports EO.WinForm.WebViewHost
Imports EO.Base
#End Region

Public Class TabControl
    Inherits vTabControl

    Public Sub New()

        Me.AllowDragDrop = True
        Me.AllowDrop = True
        Me.AllPagesHeight = -1
        Me.Dock = DockStyle.Fill
        Me.Font = New Font("Verdana", 10)
        Me.ForeColor = Color.Black
        Me.Padding = New Padding(0, 27, 0, 0)
        Me.ShowCloseButtonOnSelectedTabOnly = False
        Me.TabAlignment = Top
        Me.TabsInitialOffset = 2
        Me.TabsShape = Chrome
        Me.TabsSpacing = -15
        Me.TextOrientation = vTabPageTextOrientation.Horizontal
        Me.TitleHeight = 27
        Me.VIBlendTheme = OFFICE2010SILVER

        Dim AddTab As New vTabPage
        AddTab.Font = New Font("Verdana", 16, FontStyle.Bold)
        AddTab.Text = "+"
        AddTab.HeaderWidth = 55
        AddTab.HeaderHeight = 27
        AddTab.AllowDrop = False
        AddTab.EnableCloseButton = False

        Me.TabPages.Add(AddTab)

    End Sub

    Sub NewTab()
        Me.EnableCloseButtons = False
        Dim TabPage As New vTabPage
        Me.TabPages.Add(TabPage)
        Me.SelectedTab = TabPage
        TabPage.Text = "New Tab"
        TabPage.HeaderHeight = 27
        TabPage.HeaderWidth = 200
        TabPage.TextAlignment = ContentAlignment.MiddleLeft

        Dim WebBrowser As New EO.WinForm.WebControl
        WebBrowser.Dock = DockStyle.Fill
        TabPage.Controls.Add(WebBrowser)

        Dim WebView As New WebView
        WebBrowser.WebView = WebView

        AddHandler WebView.LoadCompleted, AddressOf WebView_LoadComplated
        AddHandler WebView.UrlChanged, AddressOf WebView_UrlChangedComplated
        AddHandler WebView.NewWindow, AddressOf WebView_NewWindow
        AddHandler WebView.BeforeContextMenu, AddressOf WebView_BeforeContextMenu
    End Sub

    Private Sub TabControl_TitleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.TitleClick
        If Me.SelectedTab.Text = "+" Then
            NewTab()
            MainForm.SearchField.Text = CType(Me.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Url
        End If
    End Sub

    Public Overrides Sub DrawSelectedAndHighlightedTab(ByVal g As Graphics, ByVal page As vTabPage, ByRef pageRectangle As Rectangle, ByRef pageRadius As Integer)
        MyBase.DrawSelectedAndHighlightedTab(g, page, pageRectangle, pageRadius)
        Dim closeRectangle As New Rectangle(page.GetPageRectange().Right - 25, page.GetPageRectange().Y + page.GetPageRectange().Height / 2 - 6.5, 13, 13)
        DrawCloseButton(g, closeRectangle, Color.Black, Color.Black)
    End Sub

    Public Overrides Sub DrawSelectedTab(ByVal g As Graphics, ByVal page As vTabPage, ByRef pageRectangle As Rectangle)
        MyBase.DrawSelectedTab(g, page, pageRectangle)
        Dim closeRectangle As New Rectangle(page.GetPageRectange().Right - 25, page.GetPageRectange().Y + page.GetPageRectange().Height / 2 - 6.5, 13, 13)
        DrawCloseButton(g, closeRectangle, Color.Black, Color.Black)
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        MyBase.OnMouseDown(e)

        Dim page As vTabPage = Me.HitTest(e.Location)

        If page IsNot Nothing Then

            Dim closeRectangle As New Rectangle(page.GetPageRectange().Right - 25, page.GetPageRectange().Y + page.GetPageRectange().Height / 2 - 6.5, 13, 13)

            If closeRectangle.Contains(e.Location) Then

                Me.TabPages.Remove(Me.SelectedTab)
                Me.SelectedIndex = Me.TabPages.Count - 1

                Try
                    'CType(Me.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Destroy()
                Catch ex As Exception
                End Try

                If Me.TabPages.Count = 1 Then
                    MainForm.Close()
                End If

            End If
        End If
    End Sub


    Private Sub WebView_LoadComplated(ByVal sender As Object, ByVal e As LoadCompletedEventArgs)
        Try
            Me.SelectedTab.Text = CType(Me.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Title.ToString

            MainForm.SearchField.Text = CType(Me.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Url.ToString
            MainForm.favicon()

            IncognitoForm.SearchField.Text = CType(Me.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Url.ToString
            IncognitoForm.favicon()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub WebView_UrlChangedComplated(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Me.SelectedTab.Text = CType(Me.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Title.ToString

            MainForm.SearchField.Text = CType(Me.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Url.ToString
            MainForm.favicon()

            IncognitoForm.SearchField.Text = CType(Me.SelectedTab.Controls.Item(0), EO.WinForm.WebControl).WebView.Url.ToString
            IncognitoForm.favicon()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub WebView_NewWindow(ByVal sender As Object, ByVal e As NewWindowEventArgs)
        NewTab()
    End Sub

    Private Sub WebView_BeforeContextMenu(sender As Object, e As BeforeContextMenuEventArgs)

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

End Class