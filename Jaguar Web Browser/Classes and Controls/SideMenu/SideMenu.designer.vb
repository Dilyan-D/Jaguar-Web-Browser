<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SideMenu
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SideMenu))
        Me.TitleBar = New System.Windows.Forms.Panel()
        Me.MenuIcon = New System.Windows.Forms.PictureBox()
        Me.CloseMenuButton = New System.Windows.Forms.PictureBox()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.PanelRight = New System.Windows.Forms.Panel()
        Me.PanelZoom = New System.Windows.Forms.Panel()
        Me.ZoomStatus = New System.Windows.Forms.TextBox()
        Me.frmSideMenubtnZoomIn = New System.Windows.Forms.Button()
        Me.frmSideMenubtnZoomOut = New System.Windows.Forms.Button()
        Me.PanelButtonsHolderRow1 = New System.Windows.Forms.Panel()
        Me.frmSideMenubtnSavePage = New System.Windows.Forms.Button()
        Me.frmSideMenubtnIncognitoWindow = New System.Windows.Forms.Button()
        Me.frmSideMenubtnNewWindow = New System.Windows.Forms.Button()
        Me.PanelButtonsHolderRow2 = New System.Windows.Forms.Panel()
        Me.frmSideMenubtnDownloadManager = New System.Windows.Forms.Button()
        Me.frmSideMenubtnBookmarks = New System.Windows.Forms.Button()
        Me.frmSideMenubtnHistory = New System.Windows.Forms.Button()
        Me.PanelButtonsHolderRow4 = New System.Windows.Forms.Panel()
        Me.frmSideMenubtnSettings = New System.Windows.Forms.Button()
        Me.frmSideMenubtnSearch = New System.Windows.Forms.Button()
        Me.frmSideMenubtnDevelopers = New System.Windows.Forms.Button()
        Me.PanelButtonsHolderRow3 = New System.Windows.Forms.Panel()
        Me.frmSideMenubtnPrint = New System.Windows.Forms.Button()
        Me.frmSideMenubtnFullScreen = New System.Windows.Forms.Button()
        Me.frmSideMenubtnCustomize = New System.Windows.Forms.Button()
        Me.lblConnectionStatus = New System.Windows.Forms.Label()
        Me.LabelConnectionStatus = New System.Windows.Forms.Label()
        Me.PanelLine = New System.Windows.Forms.Panel()
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.TitleBar.SuspendLayout()
        CType(Me.MenuIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseMenuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelZoom.SuspendLayout()
        Me.PanelButtonsHolderRow1.SuspendLayout()
        Me.PanelButtonsHolderRow2.SuspendLayout()
        Me.PanelButtonsHolderRow4.SuspendLayout()
        Me.PanelButtonsHolderRow3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitleBar
        '
        Me.TitleBar.BackColor = System.Drawing.Color.Black
        Me.TitleBar.Controls.Add(Me.MenuIcon)
        Me.TitleBar.Controls.Add(Me.CloseMenuButton)
        Me.TitleBar.Controls.Add(Me.LabelName)
        Me.TitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBar.Location = New System.Drawing.Point(5, 0)
        Me.TitleBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Size = New System.Drawing.Size(347, 32)
        Me.TitleBar.TabIndex = 1
        '
        'MenuIcon
        '
        Me.MenuIcon.BackColor = System.Drawing.Color.Transparent
        Me.MenuIcon.Image = Global.WindowsApplication1.My.Resources.Resources.Menu_ico
        Me.MenuIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MenuIcon.Location = New System.Drawing.Point(0, 4)
        Me.MenuIcon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MenuIcon.Name = "MenuIcon"
        Me.MenuIcon.Size = New System.Drawing.Size(25, 25)
        Me.MenuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MenuIcon.TabIndex = 10
        Me.MenuIcon.TabStop = False
        '
        'CloseMenuButton
        '
        Me.CloseMenuButton.BackColor = System.Drawing.Color.Transparent
        Me.CloseMenuButton.Image = Global.WindowsApplication1.My.Resources.Resources.Close
        Me.CloseMenuButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CloseMenuButton.Location = New System.Drawing.Point(320, 4)
        Me.CloseMenuButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CloseMenuButton.Name = "CloseMenuButton"
        Me.CloseMenuButton.Size = New System.Drawing.Size(25, 25)
        Me.CloseMenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CloseMenuButton.TabIndex = 9
        Me.CloseMenuButton.TabStop = False
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.BackColor = System.Drawing.Color.Transparent
        Me.LabelName.Font = New System.Drawing.Font("Verdana", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelName.ForeColor = System.Drawing.Color.White
        Me.LabelName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelName.Location = New System.Drawing.Point(119, 2)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(123, 23)
        Me.LabelName.TabIndex = 8
        Me.LabelName.Text = "Side Menu"
        '
        'PanelRight
        '
        Me.PanelRight.BackColor = System.Drawing.Color.Black
        Me.PanelRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelRight.Location = New System.Drawing.Point(352, 0)
        Me.PanelRight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelRight.Name = "PanelRight"
        Me.PanelRight.Size = New System.Drawing.Size(3, 601)
        Me.PanelRight.TabIndex = 4
        '
        'PanelZoom
        '
        Me.PanelZoom.Controls.Add(Me.ZoomStatus)
        Me.PanelZoom.Controls.Add(Me.frmSideMenubtnZoomIn)
        Me.PanelZoom.Controls.Add(Me.frmSideMenubtnZoomOut)
        Me.PanelZoom.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelZoom.Location = New System.Drawing.Point(5, 32)
        Me.PanelZoom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelZoom.Name = "PanelZoom"
        Me.PanelZoom.Size = New System.Drawing.Size(347, 43)
        Me.PanelZoom.TabIndex = 14
        '
        'ZoomStatus
        '
        Me.ZoomStatus.BackColor = System.Drawing.Color.Gray
        Me.ZoomStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ZoomStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.ZoomStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ZoomStatus.Font = New System.Drawing.Font("Verdana", 18.0!)
        Me.ZoomStatus.ForeColor = System.Drawing.Color.White
        Me.ZoomStatus.Location = New System.Drawing.Point(117, 0)
        Me.ZoomStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ZoomStatus.Name = "ZoomStatus"
        Me.ZoomStatus.ReadOnly = True
        Me.ZoomStatus.Size = New System.Drawing.Size(113, 37)
        Me.ZoomStatus.TabIndex = 17
        Me.ZoomStatus.Text = "1"
        Me.ZoomStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmSideMenubtnZoomIn
        '
        Me.frmSideMenubtnZoomIn.Dock = System.Windows.Forms.DockStyle.Right
        Me.frmSideMenubtnZoomIn.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.frmSideMenubtnZoomIn.FlatAppearance.BorderSize = 0
        Me.frmSideMenubtnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frmSideMenubtnZoomIn.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.frmSideMenubtnZoomIn.ForeColor = System.Drawing.Color.White
        Me.frmSideMenubtnZoomIn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.frmSideMenubtnZoomIn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.frmSideMenubtnZoomIn.Location = New System.Drawing.Point(230, 0)
        Me.frmSideMenubtnZoomIn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSideMenubtnZoomIn.Name = "frmSideMenubtnZoomIn"
        Me.frmSideMenubtnZoomIn.Size = New System.Drawing.Size(117, 43)
        Me.frmSideMenubtnZoomIn.TabIndex = 16
        Me.frmSideMenubtnZoomIn.Text = "+"
        Me.frmSideMenubtnZoomIn.UseVisualStyleBackColor = True
        '
        'frmSideMenubtnZoomOut
        '
        Me.frmSideMenubtnZoomOut.Dock = System.Windows.Forms.DockStyle.Left
        Me.frmSideMenubtnZoomOut.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.frmSideMenubtnZoomOut.FlatAppearance.BorderSize = 0
        Me.frmSideMenubtnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frmSideMenubtnZoomOut.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.frmSideMenubtnZoomOut.ForeColor = System.Drawing.Color.White
        Me.frmSideMenubtnZoomOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.frmSideMenubtnZoomOut.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.frmSideMenubtnZoomOut.Location = New System.Drawing.Point(0, 0)
        Me.frmSideMenubtnZoomOut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSideMenubtnZoomOut.Name = "frmSideMenubtnZoomOut"
        Me.frmSideMenubtnZoomOut.Size = New System.Drawing.Size(117, 43)
        Me.frmSideMenubtnZoomOut.TabIndex = 14
        Me.frmSideMenubtnZoomOut.Text = "-"
        Me.frmSideMenubtnZoomOut.UseVisualStyleBackColor = True
        '
        'PanelButtonsHolderRow1
        '
        Me.PanelButtonsHolderRow1.Controls.Add(Me.frmSideMenubtnSavePage)
        Me.PanelButtonsHolderRow1.Controls.Add(Me.frmSideMenubtnIncognitoWindow)
        Me.PanelButtonsHolderRow1.Controls.Add(Me.frmSideMenubtnNewWindow)
        Me.PanelButtonsHolderRow1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelButtonsHolderRow1.Location = New System.Drawing.Point(5, 75)
        Me.PanelButtonsHolderRow1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelButtonsHolderRow1.Name = "PanelButtonsHolderRow1"
        Me.PanelButtonsHolderRow1.Size = New System.Drawing.Size(347, 114)
        Me.PanelButtonsHolderRow1.TabIndex = 15
        '
        'frmSideMenubtnSavePage
        '
        Me.frmSideMenubtnSavePage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmSideMenubtnSavePage.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.frmSideMenubtnSavePage.FlatAppearance.BorderSize = 0
        Me.frmSideMenubtnSavePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frmSideMenubtnSavePage.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.frmSideMenubtnSavePage.ForeColor = System.Drawing.Color.White
        Me.frmSideMenubtnSavePage.Image = Global.WindowsApplication1.My.Resources.Resources.Save_Page
        Me.frmSideMenubtnSavePage.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.frmSideMenubtnSavePage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.frmSideMenubtnSavePage.Location = New System.Drawing.Point(230, 0)
        Me.frmSideMenubtnSavePage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSideMenubtnSavePage.Name = "frmSideMenubtnSavePage"
        Me.frmSideMenubtnSavePage.Size = New System.Drawing.Size(117, 114)
        Me.frmSideMenubtnSavePage.TabIndex = 11
        Me.frmSideMenubtnSavePage.Text = "Save Webpage"
        Me.frmSideMenubtnSavePage.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.frmSideMenubtnSavePage.UseVisualStyleBackColor = True
        '
        'frmSideMenubtnIncognitoWindow
        '
        Me.frmSideMenubtnIncognitoWindow.Dock = System.Windows.Forms.DockStyle.Left
        Me.frmSideMenubtnIncognitoWindow.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.frmSideMenubtnIncognitoWindow.FlatAppearance.BorderSize = 0
        Me.frmSideMenubtnIncognitoWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frmSideMenubtnIncognitoWindow.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.frmSideMenubtnIncognitoWindow.ForeColor = System.Drawing.Color.White
        Me.frmSideMenubtnIncognitoWindow.Image = Global.WindowsApplication1.My.Resources.Resources.Incognito_Window
        Me.frmSideMenubtnIncognitoWindow.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.frmSideMenubtnIncognitoWindow.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.frmSideMenubtnIncognitoWindow.Location = New System.Drawing.Point(115, 0)
        Me.frmSideMenubtnIncognitoWindow.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSideMenubtnIncognitoWindow.Name = "frmSideMenubtnIncognitoWindow"
        Me.frmSideMenubtnIncognitoWindow.Size = New System.Drawing.Size(115, 114)
        Me.frmSideMenubtnIncognitoWindow.TabIndex = 4
        Me.frmSideMenubtnIncognitoWindow.Text = "Incognito Window"
        Me.frmSideMenubtnIncognitoWindow.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.frmSideMenubtnIncognitoWindow.UseVisualStyleBackColor = True
        '
        'frmSideMenubtnNewWindow
        '
        Me.frmSideMenubtnNewWindow.Dock = System.Windows.Forms.DockStyle.Left
        Me.frmSideMenubtnNewWindow.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.frmSideMenubtnNewWindow.FlatAppearance.BorderSize = 0
        Me.frmSideMenubtnNewWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frmSideMenubtnNewWindow.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.frmSideMenubtnNewWindow.ForeColor = System.Drawing.Color.White
        Me.frmSideMenubtnNewWindow.Image = CType(resources.GetObject("frmSideMenubtnNewWindow.Image"), System.Drawing.Image)
        Me.frmSideMenubtnNewWindow.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.frmSideMenubtnNewWindow.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.frmSideMenubtnNewWindow.Location = New System.Drawing.Point(0, 0)
        Me.frmSideMenubtnNewWindow.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSideMenubtnNewWindow.Name = "frmSideMenubtnNewWindow"
        Me.frmSideMenubtnNewWindow.Size = New System.Drawing.Size(115, 114)
        Me.frmSideMenubtnNewWindow.TabIndex = 2
        Me.frmSideMenubtnNewWindow.Text = "New Window"
        Me.frmSideMenubtnNewWindow.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.frmSideMenubtnNewWindow.UseVisualStyleBackColor = True
        '
        'PanelButtonsHolderRow2
        '
        Me.PanelButtonsHolderRow2.Controls.Add(Me.frmSideMenubtnDownloadManager)
        Me.PanelButtonsHolderRow2.Controls.Add(Me.frmSideMenubtnBookmarks)
        Me.PanelButtonsHolderRow2.Controls.Add(Me.frmSideMenubtnHistory)
        Me.PanelButtonsHolderRow2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelButtonsHolderRow2.Location = New System.Drawing.Point(5, 189)
        Me.PanelButtonsHolderRow2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelButtonsHolderRow2.Name = "PanelButtonsHolderRow2"
        Me.PanelButtonsHolderRow2.Size = New System.Drawing.Size(347, 114)
        Me.PanelButtonsHolderRow2.TabIndex = 16
        '
        'frmSideMenubtnDownloadManager
        '
        Me.frmSideMenubtnDownloadManager.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmSideMenubtnDownloadManager.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.frmSideMenubtnDownloadManager.FlatAppearance.BorderSize = 0
        Me.frmSideMenubtnDownloadManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frmSideMenubtnDownloadManager.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.frmSideMenubtnDownloadManager.ForeColor = System.Drawing.Color.White
        Me.frmSideMenubtnDownloadManager.Image = Global.WindowsApplication1.My.Resources.Resources.Downloads
        Me.frmSideMenubtnDownloadManager.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.frmSideMenubtnDownloadManager.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.frmSideMenubtnDownloadManager.Location = New System.Drawing.Point(232, 0)
        Me.frmSideMenubtnDownloadManager.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSideMenubtnDownloadManager.Name = "frmSideMenubtnDownloadManager"
        Me.frmSideMenubtnDownloadManager.Size = New System.Drawing.Size(115, 114)
        Me.frmSideMenubtnDownloadManager.TabIndex = 9
        Me.frmSideMenubtnDownloadManager.Text = "Download Manager"
        Me.frmSideMenubtnDownloadManager.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.frmSideMenubtnDownloadManager.UseVisualStyleBackColor = True
        '
        'frmSideMenubtnBookmarks
        '
        Me.frmSideMenubtnBookmarks.Dock = System.Windows.Forms.DockStyle.Left
        Me.frmSideMenubtnBookmarks.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.frmSideMenubtnBookmarks.FlatAppearance.BorderSize = 0
        Me.frmSideMenubtnBookmarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frmSideMenubtnBookmarks.Font = New System.Drawing.Font("Verdana", 9.7!)
        Me.frmSideMenubtnBookmarks.ForeColor = System.Drawing.Color.White
        Me.frmSideMenubtnBookmarks.Image = Global.WindowsApplication1.My.Resources.Resources.Bookmarks
        Me.frmSideMenubtnBookmarks.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.frmSideMenubtnBookmarks.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.frmSideMenubtnBookmarks.Location = New System.Drawing.Point(117, 0)
        Me.frmSideMenubtnBookmarks.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSideMenubtnBookmarks.Name = "frmSideMenubtnBookmarks"
        Me.frmSideMenubtnBookmarks.Size = New System.Drawing.Size(115, 114)
        Me.frmSideMenubtnBookmarks.TabIndex = 11
        Me.frmSideMenubtnBookmarks.Text = "Bookmarks"
        Me.frmSideMenubtnBookmarks.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.frmSideMenubtnBookmarks.UseVisualStyleBackColor = True
        '
        'frmSideMenubtnHistory
        '
        Me.frmSideMenubtnHistory.Dock = System.Windows.Forms.DockStyle.Left
        Me.frmSideMenubtnHistory.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.frmSideMenubtnHistory.FlatAppearance.BorderSize = 0
        Me.frmSideMenubtnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frmSideMenubtnHistory.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.frmSideMenubtnHistory.ForeColor = System.Drawing.Color.White
        Me.frmSideMenubtnHistory.Image = Global.WindowsApplication1.My.Resources.Resources.History
        Me.frmSideMenubtnHistory.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.frmSideMenubtnHistory.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.frmSideMenubtnHistory.Location = New System.Drawing.Point(0, 0)
        Me.frmSideMenubtnHistory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSideMenubtnHistory.Name = "frmSideMenubtnHistory"
        Me.frmSideMenubtnHistory.Size = New System.Drawing.Size(117, 114)
        Me.frmSideMenubtnHistory.TabIndex = 10
        Me.frmSideMenubtnHistory.Text = "History"
        Me.frmSideMenubtnHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.frmSideMenubtnHistory.UseVisualStyleBackColor = True
        '
        'PanelButtonsHolderRow4
        '
        Me.PanelButtonsHolderRow4.Controls.Add(Me.frmSideMenubtnSettings)
        Me.PanelButtonsHolderRow4.Controls.Add(Me.frmSideMenubtnSearch)
        Me.PanelButtonsHolderRow4.Controls.Add(Me.frmSideMenubtnDevelopers)
        Me.PanelButtonsHolderRow4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelButtonsHolderRow4.Location = New System.Drawing.Point(5, 417)
        Me.PanelButtonsHolderRow4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelButtonsHolderRow4.Name = "PanelButtonsHolderRow4"
        Me.PanelButtonsHolderRow4.Size = New System.Drawing.Size(347, 114)
        Me.PanelButtonsHolderRow4.TabIndex = 17
        '
        'frmSideMenubtnSettings
        '
        Me.frmSideMenubtnSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmSideMenubtnSettings.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.frmSideMenubtnSettings.FlatAppearance.BorderSize = 0
        Me.frmSideMenubtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frmSideMenubtnSettings.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.frmSideMenubtnSettings.ForeColor = System.Drawing.Color.White
        Me.frmSideMenubtnSettings.Image = Global.WindowsApplication1.My.Resources.Resources.Settings
        Me.frmSideMenubtnSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.frmSideMenubtnSettings.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.frmSideMenubtnSettings.Location = New System.Drawing.Point(232, 0)
        Me.frmSideMenubtnSettings.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSideMenubtnSettings.Name = "frmSideMenubtnSettings"
        Me.frmSideMenubtnSettings.Size = New System.Drawing.Size(115, 114)
        Me.frmSideMenubtnSettings.TabIndex = 16
        Me.frmSideMenubtnSettings.Text = "Settings"
        Me.frmSideMenubtnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.frmSideMenubtnSettings.UseVisualStyleBackColor = True
        '
        'frmSideMenubtnSearch
        '
        Me.frmSideMenubtnSearch.Dock = System.Windows.Forms.DockStyle.Left
        Me.frmSideMenubtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.frmSideMenubtnSearch.FlatAppearance.BorderSize = 0
        Me.frmSideMenubtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frmSideMenubtnSearch.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.frmSideMenubtnSearch.ForeColor = System.Drawing.Color.White
        Me.frmSideMenubtnSearch.Image = Global.WindowsApplication1.My.Resources.Resources.Search_Word
        Me.frmSideMenubtnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.frmSideMenubtnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.frmSideMenubtnSearch.Location = New System.Drawing.Point(117, 0)
        Me.frmSideMenubtnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSideMenubtnSearch.Name = "frmSideMenubtnSearch"
        Me.frmSideMenubtnSearch.Size = New System.Drawing.Size(115, 114)
        Me.frmSideMenubtnSearch.TabIndex = 17
        Me.frmSideMenubtnSearch.Text = "Search"
        Me.frmSideMenubtnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.frmSideMenubtnSearch.UseVisualStyleBackColor = True
        '
        'frmSideMenubtnDevelopers
        '
        Me.frmSideMenubtnDevelopers.Dock = System.Windows.Forms.DockStyle.Left
        Me.frmSideMenubtnDevelopers.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.frmSideMenubtnDevelopers.FlatAppearance.BorderSize = 0
        Me.frmSideMenubtnDevelopers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frmSideMenubtnDevelopers.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.frmSideMenubtnDevelopers.ForeColor = System.Drawing.Color.White
        Me.frmSideMenubtnDevelopers.Image = Global.WindowsApplication1.My.Resources.Resources.Developers
        Me.frmSideMenubtnDevelopers.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.frmSideMenubtnDevelopers.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.frmSideMenubtnDevelopers.Location = New System.Drawing.Point(0, 0)
        Me.frmSideMenubtnDevelopers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSideMenubtnDevelopers.Name = "frmSideMenubtnDevelopers"
        Me.frmSideMenubtnDevelopers.Size = New System.Drawing.Size(117, 114)
        Me.frmSideMenubtnDevelopers.TabIndex = 18
        Me.frmSideMenubtnDevelopers.Text = "Developer"
        Me.frmSideMenubtnDevelopers.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.frmSideMenubtnDevelopers.UseVisualStyleBackColor = True
        '
        'PanelButtonsHolderRow3
        '
        Me.PanelButtonsHolderRow3.Controls.Add(Me.frmSideMenubtnPrint)
        Me.PanelButtonsHolderRow3.Controls.Add(Me.frmSideMenubtnFullScreen)
        Me.PanelButtonsHolderRow3.Controls.Add(Me.frmSideMenubtnCustomize)
        Me.PanelButtonsHolderRow3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelButtonsHolderRow3.Location = New System.Drawing.Point(5, 303)
        Me.PanelButtonsHolderRow3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelButtonsHolderRow3.Name = "PanelButtonsHolderRow3"
        Me.PanelButtonsHolderRow3.Size = New System.Drawing.Size(347, 114)
        Me.PanelButtonsHolderRow3.TabIndex = 17
        '
        'frmSideMenubtnPrint
        '
        Me.frmSideMenubtnPrint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmSideMenubtnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.frmSideMenubtnPrint.FlatAppearance.BorderSize = 0
        Me.frmSideMenubtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frmSideMenubtnPrint.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.frmSideMenubtnPrint.ForeColor = System.Drawing.Color.White
        Me.frmSideMenubtnPrint.Image = Global.WindowsApplication1.My.Resources.Resources.Print
        Me.frmSideMenubtnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.frmSideMenubtnPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.frmSideMenubtnPrint.Location = New System.Drawing.Point(230, 0)
        Me.frmSideMenubtnPrint.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSideMenubtnPrint.Name = "frmSideMenubtnPrint"
        Me.frmSideMenubtnPrint.Size = New System.Drawing.Size(117, 114)
        Me.frmSideMenubtnPrint.TabIndex = 14
        Me.frmSideMenubtnPrint.Text = "Print"
        Me.frmSideMenubtnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.frmSideMenubtnPrint.UseVisualStyleBackColor = True
        '
        'frmSideMenubtnFullScreen
        '
        Me.frmSideMenubtnFullScreen.Dock = System.Windows.Forms.DockStyle.Left
        Me.frmSideMenubtnFullScreen.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.frmSideMenubtnFullScreen.FlatAppearance.BorderSize = 0
        Me.frmSideMenubtnFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frmSideMenubtnFullScreen.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.frmSideMenubtnFullScreen.ForeColor = System.Drawing.Color.White
        Me.frmSideMenubtnFullScreen.Image = Global.WindowsApplication1.My.Resources.Resources.Fullscreen
        Me.frmSideMenubtnFullScreen.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.frmSideMenubtnFullScreen.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.frmSideMenubtnFullScreen.Location = New System.Drawing.Point(115, 0)
        Me.frmSideMenubtnFullScreen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSideMenubtnFullScreen.Name = "frmSideMenubtnFullScreen"
        Me.frmSideMenubtnFullScreen.Size = New System.Drawing.Size(115, 114)
        Me.frmSideMenubtnFullScreen.TabIndex = 12
        Me.frmSideMenubtnFullScreen.Text = "Fullscreen"
        Me.frmSideMenubtnFullScreen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.frmSideMenubtnFullScreen.UseVisualStyleBackColor = True
        '
        'frmSideMenubtnCustomize
        '
        Me.frmSideMenubtnCustomize.Dock = System.Windows.Forms.DockStyle.Left
        Me.frmSideMenubtnCustomize.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.frmSideMenubtnCustomize.FlatAppearance.BorderSize = 0
        Me.frmSideMenubtnCustomize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frmSideMenubtnCustomize.Font = New System.Drawing.Font("Verdana", 9.7!)
        Me.frmSideMenubtnCustomize.ForeColor = System.Drawing.Color.White
        Me.frmSideMenubtnCustomize.Image = Global.WindowsApplication1.My.Resources.Resources.Customize
        Me.frmSideMenubtnCustomize.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.frmSideMenubtnCustomize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.frmSideMenubtnCustomize.Location = New System.Drawing.Point(0, 0)
        Me.frmSideMenubtnCustomize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSideMenubtnCustomize.Name = "frmSideMenubtnCustomize"
        Me.frmSideMenubtnCustomize.Size = New System.Drawing.Size(115, 114)
        Me.frmSideMenubtnCustomize.TabIndex = 13
        Me.frmSideMenubtnCustomize.Text = "Customize"
        Me.frmSideMenubtnCustomize.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.frmSideMenubtnCustomize.UseVisualStyleBackColor = True
        '
        'lblConnectionStatus
        '
        Me.lblConnectionStatus.AutoSize = True
        Me.lblConnectionStatus.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.lblConnectionStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConnectionStatus.Location = New System.Drawing.Point(211, 542)
        Me.lblConnectionStatus.Name = "lblConnectionStatus"
        Me.lblConnectionStatus.Size = New System.Drawing.Size(20, 20)
        Me.lblConnectionStatus.TabIndex = 19
        Me.lblConnectionStatus.Text = "0"
        '
        'LabelConnectionStatus
        '
        Me.LabelConnectionStatus.AutoSize = True
        Me.LabelConnectionStatus.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.LabelConnectionStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelConnectionStatus.Location = New System.Drawing.Point(21, 542)
        Me.LabelConnectionStatus.Name = "LabelConnectionStatus"
        Me.LabelConnectionStatus.Size = New System.Drawing.Size(175, 20)
        Me.LabelConnectionStatus.TabIndex = 18
        Me.LabelConnectionStatus.Text = "Connection Status:"
        '
        'PanelLine
        '
        Me.PanelLine.BackColor = System.Drawing.Color.Black
        Me.PanelLine.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.PanelLine.Location = New System.Drawing.Point(17, 537)
        Me.PanelLine.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelLine.Name = "PanelLine"
        Me.PanelLine.Size = New System.Drawing.Size(320, 1)
        Me.PanelLine.TabIndex = 20
        '
        'PanelLeft
        '
        Me.PanelLeft.BackColor = System.Drawing.Color.Black
        Me.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeft.Location = New System.Drawing.Point(0, 0)
        Me.PanelLeft.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(5, 601)
        Me.PanelLeft.TabIndex = 21
        '
        'SideMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.lblConnectionStatus)
        Me.Controls.Add(Me.LabelConnectionStatus)
        Me.Controls.Add(Me.PanelLine)
        Me.Controls.Add(Me.PanelButtonsHolderRow4)
        Me.Controls.Add(Me.PanelButtonsHolderRow3)
        Me.Controls.Add(Me.PanelButtonsHolderRow2)
        Me.Controls.Add(Me.PanelButtonsHolderRow1)
        Me.Controls.Add(Me.PanelZoom)
        Me.Controls.Add(Me.TitleBar)
        Me.Controls.Add(Me.PanelLeft)
        Me.Controls.Add(Me.PanelRight)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "SideMenu"
        Me.Size = New System.Drawing.Size(355, 601)
        Me.TitleBar.ResumeLayout(False)
        Me.TitleBar.PerformLayout()
        CType(Me.MenuIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseMenuButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelZoom.ResumeLayout(False)
        Me.PanelZoom.PerformLayout()
        Me.PanelButtonsHolderRow1.ResumeLayout(False)
        Me.PanelButtonsHolderRow2.ResumeLayout(False)
        Me.PanelButtonsHolderRow4.ResumeLayout(False)
        Me.PanelButtonsHolderRow3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitleBar As System.Windows.Forms.Panel
    Friend WithEvents MenuIcon As System.Windows.Forms.PictureBox
    Friend WithEvents CloseMenuButton As System.Windows.Forms.PictureBox
    Friend WithEvents LabelName As System.Windows.Forms.Label
    Friend WithEvents PanelRight As System.Windows.Forms.Panel
    Friend WithEvents PanelZoom As System.Windows.Forms.Panel
    Friend WithEvents ZoomStatus As System.Windows.Forms.TextBox
    Friend WithEvents frmSideMenubtnZoomIn As System.Windows.Forms.Button
    Friend WithEvents frmSideMenubtnZoomOut As System.Windows.Forms.Button
    Friend WithEvents PanelButtonsHolderRow1 As System.Windows.Forms.Panel
    Friend WithEvents frmSideMenubtnSavePage As System.Windows.Forms.Button
    Friend WithEvents frmSideMenubtnIncognitoWindow As System.Windows.Forms.Button
    Friend WithEvents frmSideMenubtnNewWindow As System.Windows.Forms.Button
    Friend WithEvents PanelButtonsHolderRow2 As System.Windows.Forms.Panel
    Friend WithEvents frmSideMenubtnBookmarks As System.Windows.Forms.Button
    Friend WithEvents frmSideMenubtnHistory As System.Windows.Forms.Button
    Friend WithEvents frmSideMenubtnDownloadManager As System.Windows.Forms.Button
    Friend WithEvents PanelButtonsHolderRow4 As System.Windows.Forms.Panel
    Friend WithEvents frmSideMenubtnDevelopers As System.Windows.Forms.Button
    Friend WithEvents frmSideMenubtnSearch As System.Windows.Forms.Button
    Friend WithEvents frmSideMenubtnSettings As System.Windows.Forms.Button
    Friend WithEvents PanelButtonsHolderRow3 As System.Windows.Forms.Panel
    Friend WithEvents frmSideMenubtnPrint As System.Windows.Forms.Button
    Friend WithEvents frmSideMenubtnCustomize As System.Windows.Forms.Button
    Friend WithEvents frmSideMenubtnFullScreen As System.Windows.Forms.Button
    Friend WithEvents lblConnectionStatus As System.Windows.Forms.Label
    Friend WithEvents LabelConnectionStatus As System.Windows.Forms.Label
    Friend WithEvents PanelLine As System.Windows.Forms.Panel
    Friend WithEvents PanelLeft As System.Windows.Forms.Panel

End Class
