<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.WebView = New EO.WebBrowser.WebView()
        Me.Theme1 = New WindowsApplication1.Theme()
        Me.lblFullScreen = New System.Windows.Forms.Label()
        Me.SideMenu = New WindowsApplication1.SideMenu()
        Me.TabControl = New WindowsApplication1.TabControl()
        Me.TabPage = New VIBlend.WinForms.Controls.vTabPage()
        Me.WebBrowser = New EO.WinForm.WebControl()
        Me.SettingsTab = New VIBlend.WinForms.Controls.vTabPage()
        Me.SettingsTabControl = New VIBlend.WinForms.Controls.vTabControl()
        Me.GeneralTabPage = New VIBlend.WinForms.Controls.vTabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlatPanel10 = New WindowsApplication1.FlatPanel()
        Me.frmSettingsbtnFolderBrowse = New System.Windows.Forms.Button()
        Me.frmSettingstxtSaveLocation = New System.Windows.Forms.TextBox()
        Me.frmSettingsoptLemmeSave = New System.Windows.Forms.RadioButton()
        Me.frmSettingsoptSaveToLocation = New System.Windows.Forms.RadioButton()
        Me.frmSettingslblDownloads = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblMsg2 = New System.Windows.Forms.Label()
        Me.frmSettingsbtnSetHomepage = New System.Windows.Forms.Button()
        Me.FlatPanel5 = New WindowsApplication1.FlatPanel()
        Me.frmSettingstxtHomepageURL = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FlatPanel4 = New WindowsApplication1.FlatPanel()
        Me.PBSearchEnginesIcons = New System.Windows.Forms.PictureBox()
        Me.frmSettingscmbSearchEngines = New System.Windows.Forms.ComboBox()
        Me.frmSettingschkboxDefaultBrowser = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SetPagePanel = New System.Windows.Forms.Panel()
        Me.lblMsg1 = New System.Windows.Forms.Label()
        Me.frmSettingsbtnSetStartupPage = New System.Windows.Forms.Button()
        Me.FlatPanel3 = New WindowsApplication1.FlatPanel()
        Me.frmSettingstxtStartupPageURL = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlatPanel2 = New WindowsApplication1.FlatPanel()
        Me.frmSettingscmbOnStartup = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GeneralSettingsTitlePanel = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HistoryTabPage = New VIBlend.WinForms.Controls.vTabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.FlatPanel6 = New WindowsApplication1.FlatPanel()
        Me.frmSettingstxtSearchHistory = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.frmSettingsbtnClearHistory = New System.Windows.Forms.Button()
        Me.frmSettingschklistHistory = New System.Windows.Forms.CheckedListBox()
        Me.frmSettingschkboxSelectAllHistory = New System.Windows.Forms.CheckBox()
        Me.HistoryTitlePanel = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.BookmarksTabPage = New VIBlend.WinForms.Controls.vTabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.FlatPanel7 = New WindowsApplication1.FlatPanel()
        Me.frmSettingstxtSearchBookmark = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.frmSettingsbtnClearBookmarks = New System.Windows.Forms.Button()
        Me.frmSettingschklistBookmarks = New System.Windows.Forms.CheckedListBox()
        Me.frmSettingschkboxSelectAllBookmarks = New System.Windows.Forms.CheckBox()
        Me.BookmarksTitlePanel = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DownloadsTabPage = New VIBlend.WinForms.Controls.vTabPage()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.FlatPanel8 = New WindowsApplication1.FlatPanel()
        Me.frmSettingstxtSearchDownload = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.frmSettingsbtnClearDownloads = New System.Windows.Forms.Button()
        Me.frmSettingschklistDownloads = New System.Windows.Forms.CheckedListBox()
        Me.frmSettingschkboxSelectAllDownloads = New System.Windows.Forms.CheckBox()
        Me.DownloadsTitlePanel = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CustomizeTabPage = New VIBlend.WinForms.Controls.vTabPage()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.FlatPanel1 = New WindowsApplication1.FlatPanel()
        Me.LanguageIcon = New System.Windows.Forms.PictureBox()
        Me.frmSettingscmbLanguages = New System.Windows.Forms.ComboBox()
        Me.frmSettingschkboxVisableBookmarks = New System.Windows.Forms.CheckBox()
        Me.FlatPanel9 = New WindowsApplication1.FlatPanel()
        Me.frmSettingscmbCustomize = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CustomizeTitlePanel = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.AboutTabPage = New VIBlend.WinForms.Controls.vTabPage()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.JaguarLogo = New System.Windows.Forms.PictureBox()
        Me.AboutTitlePanel = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.HomeTabPage = New VIBlend.WinForms.Controls.vTabPage()
        Me.FlatRoundedPanel2 = New WindowsApplication1.FlatRoundedPanel()
        Me.JHPSearchButton = New System.Windows.Forms.Button()
        Me.JHPSearchFieldPanel = New WindowsApplication1.FlatRoundedPanel()
        Me.JHPSearchField = New System.Windows.Forms.TextBox()
        Me.JHPSearchEnginePic = New System.Windows.Forms.PictureBox()
        Me.JHPCmbSearchEngines = New System.Windows.Forms.ComboBox()
        Me.JHPBackground = New System.Windows.Forms.PictureBox()
        Me.WebDevTabPage = New VIBlend.WinForms.Controls.vTabPage()
        Me.JWDTTabControl = New VIBlend.WinForms.Controls.vTabControl()
        Me.WelcomeTabPage = New VIBlend.WinForms.Controls.vTabPage()
        Me.StartPagePanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RecentFilesListBox = New System.Windows.Forms.ListBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblOpenFile = New System.Windows.Forms.Label()
        Me.lblNewFile = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.MaskedTextBox = New System.Windows.Forms.TextBox()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.JWDTLogo = New System.Windows.Forms.PictureBox()
        Me.FirstRunTabPage = New VIBlend.WinForms.Controls.vTabPage()
        Me.WelcomeTabControl = New VIBlend.WinForms.Controls.vTabControl()
        Me.Step1 = New VIBlend.WinForms.Controls.vTabPage()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.btnNext1 = New System.Windows.Forms.Button()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.FlatPanel12 = New WindowsApplication1.FlatPanel()
        Me.cmbWelcomeTheme = New System.Windows.Forms.ComboBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.FlatPanel11 = New WindowsApplication1.FlatPanel()
        Me.pbWelcomeLanguage = New System.Windows.Forms.PictureBox()
        Me.cmbWelcomeLanguage = New System.Windows.Forms.ComboBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Step2 = New VIBlend.WinForms.Controls.vTabPage()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.btnBack1 = New System.Windows.Forms.Button()
        Me.btnNext2 = New System.Windows.Forms.Button()
        Me.Pic1 = New System.Windows.Forms.PictureBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Step3 = New VIBlend.WinForms.Controls.vTabPage()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.btnBack2 = New System.Windows.Forms.Button()
        Me.btnNext3 = New System.Windows.Forms.Button()
        Me.Pic2 = New System.Windows.Forms.PictureBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Step4 = New VIBlend.WinForms.Controls.vTabPage()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.btnBack3 = New System.Windows.Forms.Button()
        Me.btnNext4 = New System.Windows.Forms.Button()
        Me.PIc3 = New System.Windows.Forms.PictureBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Step5 = New VIBlend.WinForms.Controls.vTabPage()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.btnBack4 = New System.Windows.Forms.Button()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.MyHomePage = New VIBlend.WinForms.Controls.vTabPage()
        Me.MHPbtnShowHideBookmarksPanel = New System.Windows.Forms.Button()
        Me.MHPbtnShowTools = New System.Windows.Forms.Button()
        Me.MHPToolsPanel = New System.Windows.Forms.Panel()
        Me.MHPbtnMoveObjects = New System.Windows.Forms.Button()
        Me.MHPbtnInsertImage = New System.Windows.Forms.Button()
        Me.MHPbtnInsertVideo = New System.Windows.Forms.Button()
        Me.MHPbtnInsertSound = New System.Windows.Forms.Button()
        Me.MHPBookmarksPanel = New System.Windows.Forms.Panel()
        Me.MHPFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.MHPbtnBookmarksForward = New System.Windows.Forms.Button()
        Me.MHPbtnBookmarksBackward = New System.Windows.Forms.Button()
        Me.MHPBookmarksToolsPanel = New System.Windows.Forms.Panel()
        Me.MHPPanelAddBookmark = New System.Windows.Forms.Panel()
        Me.MHPbtnAddBookmark = New System.Windows.Forms.Button()
        Me.MHPtxtBookmarkURL = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.MHPtxtBookmarkName = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.MHPbtnAddBookmarkMenu = New System.Windows.Forms.Button()
        Me.MHPSearchButtonPanel = New WindowsApplication1.FlatRoundedPanel()
        Me.MHPSearchButton = New System.Windows.Forms.Button()
        Me.MHPSearchFieldPanel = New WindowsApplication1.FlatRoundedPanel()
        Me.MHPSearchField = New System.Windows.Forms.TextBox()
        Me.MHPSearchEnginePic = New System.Windows.Forms.PictureBox()
        Me.MHPCmbSearchEngines = New System.Windows.Forms.ComboBox()
        Me.MHPBackground = New System.Windows.Forms.PictureBox()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.SearchPanel = New WindowsApplication1.FlatPanel()
        Me.WebsiteIcon = New System.Windows.Forms.PictureBox()
        Me.frmMainFormbtnRefresh = New WindowsApplication1.RefreshButton()
        Me.frmMainFormbtnStop = New WindowsApplication1.StopButton()
        Me.frmMainFormbtnBookmark = New WindowsApplication1.BookmarkButton()
        Me.SearchField = New WindowsApplication1.SearchField()
        Me.frmMainFormbtnVoiceInput = New WindowsApplication1.VoiceInputButton()
        Me.frmMainFormbtnSearch = New WindowsApplication1.SearchButton()
        Me.frmMainFormbtnMenu = New WindowsApplication1.MenuButton()
        Me.frmMainFormbtnHome = New WindowsApplication1.HomeButton()
        Me.frmMainFormbtnForward = New WindowsApplication1.ForwardButton()
        Me.frmMainFormbtnBackward = New WindowsApplication1.BackwardButton()
        Me.SearchWord = New WindowsApplication1.SearchWord()
        Me.FormTitle = New WindowsApplication1.FormTitle()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.ResizeButton = New System.Windows.Forms.PictureBox()
        Me.MinimizeButton = New WindowsApplication1.MinimizeButton()
        Me.CloseButton = New WindowsApplication1.CloseButton()
        Me.BookmarksBar = New WindowsApplication1.BookmarksBar()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.frmSettingsDownloadFolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MHPOFDImage = New System.Windows.Forms.OpenFileDialog()
        Me.MHPOFDVideo = New System.Windows.Forms.OpenFileDialog()
        Me.MHPOFDSound = New System.Windows.Forms.OpenFileDialog()
        Me.MHPbtnMoveObjectsMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MHPbtnInsertImageMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InsertImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MHPbtnInsertVideoMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InsertVideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreVideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MHPbtnInsertSoundMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChooseSoundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreSoundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Theme1.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPage.SuspendLayout()
        Me.SettingsTab.SuspendLayout()
        Me.SettingsTabControl.SuspendLayout()
        Me.GeneralTabPage.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FlatPanel10.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.FlatPanel5.SuspendLayout()
        Me.FlatPanel4.SuspendLayout()
        CType(Me.PBSearchEnginesIcons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SetPagePanel.SuspendLayout()
        Me.FlatPanel3.SuspendLayout()
        Me.FlatPanel2.SuspendLayout()
        Me.GeneralSettingsTitlePanel.SuspendLayout()
        Me.HistoryTabPage.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.FlatPanel6.SuspendLayout()
        Me.HistoryTitlePanel.SuspendLayout()
        Me.BookmarksTabPage.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.FlatPanel7.SuspendLayout()
        Me.BookmarksTitlePanel.SuspendLayout()
        Me.DownloadsTabPage.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.FlatPanel8.SuspendLayout()
        Me.DownloadsTitlePanel.SuspendLayout()
        Me.CustomizeTabPage.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.FlatPanel1.SuspendLayout()
        CType(Me.LanguageIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlatPanel9.SuspendLayout()
        Me.CustomizeTitlePanel.SuspendLayout()
        Me.AboutTabPage.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.JaguarLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AboutTitlePanel.SuspendLayout()
        Me.HomeTabPage.SuspendLayout()
        Me.FlatRoundedPanel2.SuspendLayout()
        Me.JHPSearchFieldPanel.SuspendLayout()
        CType(Me.JHPSearchEnginePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JHPBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WebDevTabPage.SuspendLayout()
        Me.JWDTTabControl.SuspendLayout()
        Me.WelcomeTabPage.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.JWDTLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FirstRunTabPage.SuspendLayout()
        Me.WelcomeTabControl.SuspendLayout()
        Me.Step1.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.FlatPanel12.SuspendLayout()
        Me.FlatPanel11.SuspendLayout()
        CType(Me.pbWelcomeLanguage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Step2.SuspendLayout()
        Me.Panel15.SuspendLayout()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Step3.SuspendLayout()
        Me.Panel16.SuspendLayout()
        CType(Me.Pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Step4.SuspendLayout()
        Me.Panel17.SuspendLayout()
        CType(Me.PIc3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Step5.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.MyHomePage.SuspendLayout()
        Me.MHPToolsPanel.SuspendLayout()
        Me.MHPBookmarksPanel.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.MHPBookmarksToolsPanel.SuspendLayout()
        Me.MHPPanelAddBookmark.SuspendLayout()
        Me.MHPSearchButtonPanel.SuspendLayout()
        Me.MHPSearchFieldPanel.SuspendLayout()
        CType(Me.MHPSearchEnginePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MHPBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.SearchPanel.SuspendLayout()
        CType(Me.WebsiteIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmMainFormbtnRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmMainFormbtnStop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmMainFormbtnBookmark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmMainFormbtnVoiceInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmMainFormbtnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmMainFormbtnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmMainFormbtnHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmMainFormbtnForward, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmMainFormbtnBackward, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitlePanel.SuspendLayout()
        CType(Me.ResizeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinimizeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MHPbtnMoveObjectsMenu.SuspendLayout()
        Me.MHPbtnInsertImageMenu.SuspendLayout()
        Me.MHPbtnInsertVideoMenu.SuspendLayout()
        Me.MHPbtnInsertSoundMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer
        '
        Me.Timer.Interval = 5000
        '
        'WebView
        '
        '
        'Theme1
        '
        Me.Theme1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Theme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Theme1.Controls.Add(Me.lblFullScreen)
        Me.Theme1.Controls.Add(Me.SideMenu)
        Me.Theme1.Controls.Add(Me.TabControl)
        Me.Theme1.Controls.Add(Me.MainPanel)
        Me.Theme1.Controls.Add(Me.FormTitle)
        Me.Theme1.Controls.Add(Me.TitlePanel)
        Me.Theme1.Controls.Add(Me.BookmarksBar)
        Me.Theme1.Customization = "AAAA//////8="
        Me.Theme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Theme1.Image = Nothing
        Me.Theme1.Location = New System.Drawing.Point(0, 0)
        Me.Theme1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Theme1.Movable = True
        Me.Theme1.Name = "Theme1"
        Me.Theme1.NoRounding = False
        Me.Theme1.Sizable = True
        Me.Theme1.Size = New System.Drawing.Size(1321, 880)
        Me.Theme1.SmartBounds = True
        Me.Theme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.Theme1.TabIndex = 0
        Me.Theme1.Text = "Theme1"
        Me.Theme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme1.Transparent = False
        '
        'lblFullScreen
        '
        Me.lblFullScreen.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFullScreen.AutoSize = True
        Me.lblFullScreen.BackColor = System.Drawing.Color.Transparent
        Me.lblFullScreen.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lblFullScreen.ForeColor = System.Drawing.Color.White
        Me.lblFullScreen.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFullScreen.Location = New System.Drawing.Point(405, 5)
        Me.lblFullScreen.Name = "lblFullScreen"
        Me.lblFullScreen.Size = New System.Drawing.Size(561, 23)
        Me.lblFullScreen.TabIndex = 11
        Me.lblFullScreen.Text = "You are now in Fullscreen Mode. Press ESC to exit."
        Me.lblFullScreen.Visible = False
        '
        'SideMenu
        '
        Me.SideMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SideMenu.BackColor = System.Drawing.Color.Gray
        Me.SideMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.SideMenu.Location = New System.Drawing.Point(-355, 121)
        Me.SideMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SideMenu.Name = "SideMenu"
        Me.SideMenu.Size = New System.Drawing.Size(355, 2121)
        Me.SideMenu.TabIndex = 8
        '
        'TabControl
        '
        Me.TabControl.AllowAnimations = True
        Me.TabControl.AllowDragDrop = True
        Me.TabControl.AllowDrop = True
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Controls.Add(Me.TabPage)
        Me.TabControl.Controls.Add(Me.SettingsTab)
        Me.TabControl.Controls.Add(Me.HomeTabPage)
        Me.TabControl.Controls.Add(Me.WebDevTabPage)
        Me.TabControl.Controls.Add(Me.FirstRunTabPage)
        Me.TabControl.Controls.Add(Me.MyHomePage)
        Me.TabControl.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.TabControl.ForeColor = System.Drawing.Color.Black
        Me.TabControl.Location = New System.Drawing.Point(5, 92)
        Me.TabControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.Padding = New System.Windows.Forms.Padding(0, 27, 0, 0)
        Me.TabControl.ShowCloseButtonOnSelectedTabOnly = False
        Me.TabControl.Size = New System.Drawing.Size(1311, 783)
        Me.TabControl.TabAlignment = VIBlend.WinForms.Controls.vTabPageAlignment.Top
        Me.TabControl.TabIndex = 7
        Me.TabControl.TabPages.Add(Me.TabPage)
        Me.TabControl.TabPages.Add(Me.SettingsTab)
        Me.TabControl.TabPages.Add(Me.HomeTabPage)
        Me.TabControl.TabPages.Add(Me.WebDevTabPage)
        Me.TabControl.TabPages.Add(Me.FirstRunTabPage)
        Me.TabControl.TabPages.Add(Me.MyHomePage)
        Me.TabControl.TabsAreaBackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.TabControl.TabsInitialOffset = 2
        Me.TabControl.TabsShape = VIBlend.WinForms.Controls.TabsShape.Chrome
        Me.TabControl.TabsSpacing = -15
        Me.TabControl.TitleHeight = 27
        Me.TabControl.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        '
        'TabPage
        '
        Me.TabPage.Controls.Add(Me.WebBrowser)
        Me.TabPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPage.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.TabPage.HeaderHeight = 27
        Me.TabPage.HeaderWidth = 160
        Me.TabPage.Location = New System.Drawing.Point(0, 33)
        Me.TabPage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage.Name = "TabPage"
        Me.TabPage.Padding = New System.Windows.Forms.Padding(0)
        Me.TabPage.SelectedTextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.TabPage.Size = New System.Drawing.Size(1311, 750)
        Me.TabPage.TabIndex = 4
        Me.TabPage.Text = "New Tab"
        Me.TabPage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.TabPage.TextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.TabPage.TooltipText = "TabPage"
        Me.TabPage.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        Me.TabPage.Visible = False
        '
        'WebBrowser
        '
        Me.WebBrowser.BackColor = System.Drawing.Color.White
        Me.WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser.Location = New System.Drawing.Point(4, 4)
        Me.WebBrowser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WebBrowser.Name = "WebBrowser"
        Me.WebBrowser.Size = New System.Drawing.Size(1303, 742)
        Me.WebBrowser.TabIndex = 0
        Me.WebBrowser.WebView = Me.WebView
        '
        'SettingsTab
        '
        Me.SettingsTab.Controls.Add(Me.SettingsTabControl)
        Me.SettingsTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SettingsTab.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.SettingsTab.HeaderHeight = 27
        Me.SettingsTab.HeaderWidth = 200
        Me.SettingsTab.Location = New System.Drawing.Point(0, 27)
        Me.SettingsTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SettingsTab.Name = "SettingsTab"
        Me.SettingsTab.Padding = New System.Windows.Forms.Padding(0)
        Me.SettingsTab.SelectedTextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.SettingsTab.Size = New System.Drawing.Size(1311, 756)
        Me.SettingsTab.TabIndex = 7
        Me.SettingsTab.Text = "Settings"
        Me.SettingsTab.TextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.SettingsTab.TooltipText = "TabPage"
        Me.SettingsTab.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        Me.SettingsTab.Visible = False
        '
        'SettingsTabControl
        '
        Me.SettingsTabControl.AllowAnimations = True
        Me.SettingsTabControl.AllPagesHeight = 170
        Me.SettingsTabControl.Controls.Add(Me.GeneralTabPage)
        Me.SettingsTabControl.Controls.Add(Me.HistoryTabPage)
        Me.SettingsTabControl.Controls.Add(Me.BookmarksTabPage)
        Me.SettingsTabControl.Controls.Add(Me.DownloadsTabPage)
        Me.SettingsTabControl.Controls.Add(Me.CustomizeTabPage)
        Me.SettingsTabControl.Controls.Add(Me.AboutTabPage)
        Me.SettingsTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SettingsTabControl.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.SettingsTabControl.Location = New System.Drawing.Point(4, 4)
        Me.SettingsTabControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SettingsTabControl.Name = "SettingsTabControl"
        Me.SettingsTabControl.Padding = New System.Windows.Forms.Padding(170, 0, 0, 0)
        Me.SettingsTabControl.Size = New System.Drawing.Size(1303, 748)
        Me.SettingsTabControl.TabAlignment = VIBlend.WinForms.Controls.vTabPageAlignment.Left
        Me.SettingsTabControl.TabIndex = 0
        Me.SettingsTabControl.TabPages.Add(Me.GeneralTabPage)
        Me.SettingsTabControl.TabPages.Add(Me.HistoryTabPage)
        Me.SettingsTabControl.TabPages.Add(Me.BookmarksTabPage)
        Me.SettingsTabControl.TabPages.Add(Me.DownloadsTabPage)
        Me.SettingsTabControl.TabPages.Add(Me.CustomizeTabPage)
        Me.SettingsTabControl.TabPages.Add(Me.AboutTabPage)
        Me.SettingsTabControl.TabsAreaBackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.SettingsTabControl.TabsInitialOffset = 0
        Me.SettingsTabControl.TabsSpacing = 0
        Me.SettingsTabControl.TextOrientation = VIBlend.WinForms.Controls.vTabPageTextOrientation.Vertical
        Me.SettingsTabControl.TitleHeight = 170
        Me.SettingsTabControl.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        '
        'GeneralTabPage
        '
        Me.GeneralTabPage.Controls.Add(Me.Panel1)
        Me.GeneralTabPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GeneralTabPage.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.GeneralTabPage.Location = New System.Drawing.Point(170, 0)
        Me.GeneralTabPage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GeneralTabPage.Name = "GeneralTabPage"
        Me.GeneralTabPage.Padding = New System.Windows.Forms.Padding(0)
        Me.GeneralTabPage.SelectedTextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.GeneralTabPage.Size = New System.Drawing.Size(1133, 748)
        Me.GeneralTabPage.TabIndex = 3
        Me.GeneralTabPage.Text = "General"
        Me.GeneralTabPage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.GeneralTabPage.TextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.GeneralTabPage.TooltipText = "TabPage"
        Me.GeneralTabPage.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        Me.GeneralTabPage.Visible = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.FlatPanel10)
        Me.Panel1.Controls.Add(Me.frmSettingsoptLemmeSave)
        Me.Panel1.Controls.Add(Me.frmSettingsoptSaveToLocation)
        Me.Panel1.Controls.Add(Me.frmSettingslblDownloads)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.FlatPanel4)
        Me.Panel1.Controls.Add(Me.frmSettingschkboxDefaultBrowser)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.SetPagePanel)
        Me.Panel1.Controls.Add(Me.FlatPanel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GeneralSettingsTitlePanel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1125, 740)
        Me.Panel1.TabIndex = 0
        '
        'FlatPanel10
        '
        Me.FlatPanel10.BackColor = System.Drawing.Color.White
        Me.FlatPanel10.Controls.Add(Me.frmSettingsbtnFolderBrowse)
        Me.FlatPanel10.Controls.Add(Me.frmSettingstxtSaveLocation)
        Me.FlatPanel10.Location = New System.Drawing.Point(283, 628)
        Me.FlatPanel10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FlatPanel10.Name = "FlatPanel10"
        Me.FlatPanel10.Size = New System.Drawing.Size(357, 32)
        Me.FlatPanel10.TabIndex = 27
        '
        'frmSettingsbtnFolderBrowse
        '
        Me.frmSettingsbtnFolderBrowse.Enabled = False
        Me.frmSettingsbtnFolderBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.frmSettingsbtnFolderBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frmSettingsbtnFolderBrowse.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.frmSettingsbtnFolderBrowse.Location = New System.Drawing.Point(304, 0)
        Me.frmSettingsbtnFolderBrowse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSettingsbtnFolderBrowse.Name = "frmSettingsbtnFolderBrowse"
        Me.frmSettingsbtnFolderBrowse.Size = New System.Drawing.Size(53, 32)
        Me.frmSettingsbtnFolderBrowse.TabIndex = 33
        Me.frmSettingsbtnFolderBrowse.Text = "..."
        Me.frmSettingsbtnFolderBrowse.UseVisualStyleBackColor = True
        '
        'frmSettingstxtSaveLocation
        '
        Me.frmSettingstxtSaveLocation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmSettingstxtSaveLocation.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.frmSettingstxtSaveLocation.Location = New System.Drawing.Point(0, 0)
        Me.frmSettingstxtSaveLocation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSettingstxtSaveLocation.Name = "frmSettingstxtSaveLocation"
        Me.frmSettingstxtSaveLocation.Size = New System.Drawing.Size(357, 32)
        Me.frmSettingstxtSaveLocation.TabIndex = 26
        '
        'frmSettingsoptLemmeSave
        '
        Me.frmSettingsoptLemmeSave.Checked = True
        Me.frmSettingsoptLemmeSave.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.frmSettingsoptLemmeSave.Location = New System.Drawing.Point(69, 583)
        Me.frmSettingsoptLemmeSave.Margin = New System.Windows.Forms.Padding(4)
        Me.frmSettingsoptLemmeSave.Name = "frmSettingsoptLemmeSave"
        Me.frmSettingsoptLemmeSave.Size = New System.Drawing.Size(571, 30)
        Me.frmSettingsoptLemmeSave.TabIndex = 36
        Me.frmSettingsoptLemmeSave.TabStop = True
        Me.frmSettingsoptLemmeSave.Text = "Let me choose where to save"
        Me.frmSettingsoptLemmeSave.UseVisualStyleBackColor = True
        '
        'frmSettingsoptSaveToLocation
        '
        Me.frmSettingsoptSaveToLocation.AutoSize = True
        Me.frmSettingsoptSaveToLocation.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.frmSettingsoptSaveToLocation.Location = New System.Drawing.Point(69, 628)
        Me.frmSettingsoptSaveToLocation.Margin = New System.Windows.Forms.Padding(4)
        Me.frmSettingsoptSaveToLocation.Name = "frmSettingsoptSaveToLocation"
        Me.frmSettingsoptSaveToLocation.Size = New System.Drawing.Size(205, 29)
        Me.frmSettingsoptSaveToLocation.TabIndex = 34
        Me.frmSettingsoptSaveToLocation.Text = "Save to location:"
        Me.frmSettingsoptSaveToLocation.UseVisualStyleBackColor = True
        '
        'frmSettingslblDownloads
        '
        Me.frmSettingslblDownloads.AutoSize = True
        Me.frmSettingslblDownloads.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.frmSettingslblDownloads.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.frmSettingslblDownloads.Location = New System.Drawing.Point(29, 546)
        Me.frmSettingslblDownloads.Name = "frmSettingslblDownloads"
        Me.frmSettingslblDownloads.Size = New System.Drawing.Size(137, 25)
        Me.frmSettingslblDownloads.TabIndex = 33
        Me.frmSettingslblDownloads.Text = "Downloads"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblMsg2)
        Me.Panel3.Controls.Add(Me.frmSettingsbtnSetHomepage)
        Me.Panel3.Controls.Add(Me.FlatPanel5)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(69, 302)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(571, 112)
        Me.Panel3.TabIndex = 32
        '
        'lblMsg2
        '
        Me.lblMsg2.AutoSize = True
        Me.lblMsg2.BackColor = System.Drawing.Color.White
        Me.lblMsg2.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.lblMsg2.ForeColor = System.Drawing.Color.Green
        Me.lblMsg2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMsg2.Location = New System.Drawing.Point(5, 78)
        Me.lblMsg2.Name = "lblMsg2"
        Me.lblMsg2.Size = New System.Drawing.Size(231, 25)
        Me.lblMsg2.TabIndex = 33
        Me.lblMsg2.Text = "The URL has been set"
        Me.lblMsg2.Visible = False
        '
        'frmSettingsbtnSetHomepage
        '
        Me.frmSettingsbtnSetHomepage.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.frmSettingsbtnSetHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frmSettingsbtnSetHomepage.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.frmSettingsbtnSetHomepage.Location = New System.Drawing.Point(425, 74)
        Me.frmSettingsbtnSetHomepage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSettingsbtnSetHomepage.Name = "frmSettingsbtnSetHomepage"
        Me.frmSettingsbtnSetHomepage.Size = New System.Drawing.Size(141, 32)
        Me.frmSettingsbtnSetHomepage.TabIndex = 31
        Me.frmSettingsbtnSetHomepage.Text = "Set"
        Me.frmSettingsbtnSetHomepage.UseVisualStyleBackColor = True
        '
        'FlatPanel5
        '
        Me.FlatPanel5.BackColor = System.Drawing.Color.White
        Me.FlatPanel5.Controls.Add(Me.frmSettingstxtHomepageURL)
        Me.FlatPanel5.Location = New System.Drawing.Point(187, 36)
        Me.FlatPanel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FlatPanel5.Name = "FlatPanel5"
        Me.FlatPanel5.Size = New System.Drawing.Size(380, 32)
        Me.FlatPanel5.TabIndex = 26
        '
        'frmSettingstxtHomepageURL
        '
        Me.frmSettingstxtHomepageURL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmSettingstxtHomepageURL.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.frmSettingstxtHomepageURL.Location = New System.Drawing.Point(0, 0)
        Me.frmSettingstxtHomepageURL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSettingstxtHomepageURL.Name = "frmSettingstxtHomepageURL"
        Me.frmSettingstxtHomepageURL.Size = New System.Drawing.Size(380, 32)
        Me.frmSettingstxtHomepageURL.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(5, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(176, 25)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Enter URL here:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(5, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(210, 25)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Set your homepage"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(29, 271)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 25)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Homepage"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(67, 447)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(468, 40)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Set which search engine is used when " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "searching from the Search Field or Jaguar " &
    "Homepage"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(29, 421)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 25)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Search"
        '
        'FlatPanel4
        '
        Me.FlatPanel4.BackColor = System.Drawing.Color.White
        Me.FlatPanel4.Controls.Add(Me.PBSearchEnginesIcons)
        Me.FlatPanel4.Controls.Add(Me.frmSettingscmbSearchEngines)
        Me.FlatPanel4.Location = New System.Drawing.Point(237, 498)
        Me.FlatPanel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FlatPanel4.Name = "FlatPanel4"
        Me.FlatPanel4.Size = New System.Drawing.Size(403, 32)
        Me.FlatPanel4.TabIndex = 27
        '
        'PBSearchEnginesIcons
        '
        Me.PBSearchEnginesIcons.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBSearchEnginesIcons.Location = New System.Drawing.Point(348, 1)
        Me.PBSearchEnginesIcons.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PBSearchEnginesIcons.Name = "PBSearchEnginesIcons"
        Me.PBSearchEnginesIcons.Size = New System.Drawing.Size(29, 30)
        Me.PBSearchEnginesIcons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBSearchEnginesIcons.TabIndex = 31
        Me.PBSearchEnginesIcons.TabStop = False
        '
        'frmSettingscmbSearchEngines
        '
        Me.frmSettingscmbSearchEngines.BackColor = System.Drawing.Color.White
        Me.frmSettingscmbSearchEngines.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmSettingscmbSearchEngines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.frmSettingscmbSearchEngines.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frmSettingscmbSearchEngines.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.frmSettingscmbSearchEngines.FormattingEnabled = True
        Me.frmSettingscmbSearchEngines.Items.AddRange(New Object() {"Google", "Bing ", "Yahoo", "Youtube", "Wikipedia"})
        Me.frmSettingscmbSearchEngines.Location = New System.Drawing.Point(0, 0)
        Me.frmSettingscmbSearchEngines.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSettingscmbSearchEngines.Name = "frmSettingscmbSearchEngines"
        Me.frmSettingscmbSearchEngines.Size = New System.Drawing.Size(403, 30)
        Me.frmSettingscmbSearchEngines.TabIndex = 25
        '
        'frmSettingschkboxDefaultBrowser
        '
        Me.frmSettingschkboxDefaultBrowser.AutoSize = True
        Me.frmSettingschkboxDefaultBrowser.Enabled = False
        Me.frmSettingschkboxDefaultBrowser.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.frmSettingschkboxDefaultBrowser.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.frmSettingschkboxDefaultBrowser.Location = New System.Drawing.Point(35, 678)
        Me.frmSettingschkboxDefaultBrowser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSettingschkboxDefaultBrowser.Name = "frmSettingschkboxDefaultBrowser"
        Me.frmSettingschkboxDefaultBrowser.Size = New System.Drawing.Size(565, 29)
        Me.frmSettingschkboxDefaultBrowser.TabIndex = 28
        Me.frmSettingschkboxDefaultBrowser.Text = "Make Jaguar my default web browser (Coming soon)"
        Me.frmSettingschkboxDefaultBrowser.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(65, 502)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 25)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Search Engine:"
        '
        'SetPagePanel
        '
        Me.SetPagePanel.Controls.Add(Me.lblMsg1)
        Me.SetPagePanel.Controls.Add(Me.frmSettingsbtnSetStartupPage)
        Me.SetPagePanel.Controls.Add(Me.FlatPanel3)
        Me.SetPagePanel.Controls.Add(Me.Label3)
        Me.SetPagePanel.Controls.Add(Me.Label2)
        Me.SetPagePanel.Location = New System.Drawing.Point(69, 153)
        Me.SetPagePanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SetPagePanel.Name = "SetPagePanel"
        Me.SetPagePanel.Size = New System.Drawing.Size(571, 112)
        Me.SetPagePanel.TabIndex = 25
        Me.SetPagePanel.Visible = False
        '
        'lblMsg1
        '
        Me.lblMsg1.AutoSize = True
        Me.lblMsg1.BackColor = System.Drawing.Color.White
        Me.lblMsg1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.lblMsg1.ForeColor = System.Drawing.Color.Green
        Me.lblMsg1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMsg1.Location = New System.Drawing.Point(5, 78)
        Me.lblMsg1.Name = "lblMsg1"
        Me.lblMsg1.Size = New System.Drawing.Size(231, 25)
        Me.lblMsg1.TabIndex = 32
        Me.lblMsg1.Text = "The URL has been set"
        Me.lblMsg1.Visible = False
        '
        'frmSettingsbtnSetStartupPage
        '
        Me.frmSettingsbtnSetStartupPage.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.frmSettingsbtnSetStartupPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frmSettingsbtnSetStartupPage.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.frmSettingsbtnSetStartupPage.Location = New System.Drawing.Point(425, 74)
        Me.frmSettingsbtnSetStartupPage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSettingsbtnSetStartupPage.Name = "frmSettingsbtnSetStartupPage"
        Me.frmSettingsbtnSetStartupPage.Size = New System.Drawing.Size(141, 32)
        Me.frmSettingsbtnSetStartupPage.TabIndex = 31
        Me.frmSettingsbtnSetStartupPage.Text = "Set"
        Me.frmSettingsbtnSetStartupPage.UseVisualStyleBackColor = True
        '
        'FlatPanel3
        '
        Me.FlatPanel3.BackColor = System.Drawing.Color.White
        Me.FlatPanel3.Controls.Add(Me.frmSettingstxtStartupPageURL)
        Me.FlatPanel3.Location = New System.Drawing.Point(187, 36)
        Me.FlatPanel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FlatPanel3.Name = "FlatPanel3"
        Me.FlatPanel3.Size = New System.Drawing.Size(380, 32)
        Me.FlatPanel3.TabIndex = 26
        '
        'frmSettingstxtStartupPageURL
        '
        Me.frmSettingstxtStartupPageURL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmSettingstxtStartupPageURL.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.frmSettingstxtStartupPageURL.Location = New System.Drawing.Point(0, 0)
        Me.frmSettingstxtStartupPageURL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSettingstxtStartupPageURL.Name = "frmSettingstxtStartupPageURL"
        Me.frmSettingstxtStartupPageURL.Size = New System.Drawing.Size(380, 32)
        Me.frmSettingstxtStartupPageURL.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(5, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 25)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Enter URL here:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(5, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 25)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Set your startup page"
        '
        'FlatPanel2
        '
        Me.FlatPanel2.BackColor = System.Drawing.Color.White
        Me.FlatPanel2.Controls.Add(Me.frmSettingscmbOnStartup)
        Me.FlatPanel2.Location = New System.Drawing.Point(69, 114)
        Me.FlatPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FlatPanel2.Name = "FlatPanel2"
        Me.FlatPanel2.Size = New System.Drawing.Size(571, 32)
        Me.FlatPanel2.TabIndex = 24
        '
        'frmSettingscmbOnStartup
        '
        Me.frmSettingscmbOnStartup.BackColor = System.Drawing.Color.White
        Me.frmSettingscmbOnStartup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmSettingscmbOnStartup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.frmSettingscmbOnStartup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frmSettingscmbOnStartup.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.frmSettingscmbOnStartup.FormattingEnabled = True
        Me.frmSettingscmbOnStartup.Items.AddRange(New Object() {"Open Jaguar Homepage", "Open Blank page", "Open Homepage", "Open Specific page", "Open My Homepage"})
        Me.frmSettingscmbOnStartup.Location = New System.Drawing.Point(0, 0)
        Me.frmSettingscmbOnStartup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSettingscmbOnStartup.Name = "frmSettingscmbOnStartup"
        Me.frmSettingscmbOnStartup.Size = New System.Drawing.Size(571, 30)
        Me.frmSettingscmbOnStartup.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(29, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 25)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "On startup"
        '
        'GeneralSettingsTitlePanel
        '
        Me.GeneralSettingsTitlePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GeneralSettingsTitlePanel.Controls.Add(Me.Label4)
        Me.GeneralSettingsTitlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.GeneralSettingsTitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.GeneralSettingsTitlePanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GeneralSettingsTitlePanel.Name = "GeneralSettingsTitlePanel"
        Me.GeneralSettingsTitlePanel.Size = New System.Drawing.Size(1125, 60)
        Me.GeneralSettingsTitlePanel.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(5, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(396, 48)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "General Settings"
        '
        'HistoryTabPage
        '
        Me.HistoryTabPage.Controls.Add(Me.Panel4)
        Me.HistoryTabPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HistoryTabPage.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.HistoryTabPage.Location = New System.Drawing.Point(171, 0)
        Me.HistoryTabPage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HistoryTabPage.Name = "HistoryTabPage"
        Me.HistoryTabPage.Padding = New System.Windows.Forms.Padding(0)
        Me.HistoryTabPage.SelectedTextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.HistoryTabPage.Size = New System.Drawing.Size(1133, 748)
        Me.HistoryTabPage.TabIndex = 4
        Me.HistoryTabPage.Text = "History"
        Me.HistoryTabPage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.HistoryTabPage.TextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.HistoryTabPage.TooltipText = "TabPage"
        Me.HistoryTabPage.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        Me.HistoryTabPage.Visible = False
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.FlatPanel6)
        Me.Panel4.Controls.Add(Me.frmSettingsbtnClearHistory)
        Me.Panel4.Controls.Add(Me.frmSettingschklistHistory)
        Me.Panel4.Controls.Add(Me.frmSettingschkboxSelectAllHistory)
        Me.Panel4.Controls.Add(Me.HistoryTitlePanel)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(4, 4)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1125, 740)
        Me.Panel4.TabIndex = 1
        '
        'FlatPanel6
        '
        Me.FlatPanel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatPanel6.BackColor = System.Drawing.Color.White
        Me.FlatPanel6.Controls.Add(Me.frmSettingstxtSearchHistory)
        Me.FlatPanel6.Controls.Add(Me.Label15)
        Me.FlatPanel6.Location = New System.Drawing.Point(653, 82)
        Me.FlatPanel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FlatPanel6.Name = "FlatPanel6"
        Me.FlatPanel6.Size = New System.Drawing.Size(447, 31)
        Me.FlatPanel6.TabIndex = 20
        '
        'frmSettingstxtSearchHistory
        '
        Me.frmSettingstxtSearchHistory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.frmSettingstxtSearchHistory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.frmSettingstxtSearchHistory.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.frmSettingstxtSearchHistory.Location = New System.Drawing.Point(221, 4)
        Me.frmSettingstxtSearchHistory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSettingstxtSearchHistory.Multiline = True
        Me.frmSettingstxtSearchHistory.Name = "frmSettingstxtSearchHistory"
        Me.frmSettingstxtSearchHistory.Size = New System.Drawing.Size(224, 30)
        Me.frmSettingstxtSearchHistory.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(3, 4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(215, 25)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Search the history: "
        '
        'frmSettingsbtnClearHistory
        '
        Me.frmSettingsbtnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frmSettingsbtnClearHistory.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.frmSettingsbtnClearHistory.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.frmSettingsbtnClearHistory.Location = New System.Drawing.Point(165, 82)
        Me.frmSettingsbtnClearHistory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSettingsbtnClearHistory.Name = "frmSettingsbtnClearHistory"
        Me.frmSettingsbtnClearHistory.Size = New System.Drawing.Size(308, 33)
        Me.frmSettingsbtnClearHistory.TabIndex = 19
        Me.frmSettingsbtnClearHistory.Text = "Clear selected item(s)"
        Me.frmSettingsbtnClearHistory.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.frmSettingsbtnClearHistory.UseVisualStyleBackColor = True
        '
        'frmSettingschklistHistory
        '
        Me.frmSettingschklistHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.frmSettingschklistHistory.CheckOnClick = True
        Me.frmSettingschklistHistory.FormattingEnabled = True
        Me.frmSettingschklistHistory.Location = New System.Drawing.Point(29, 121)
        Me.frmSettingschklistHistory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSettingschklistHistory.Name = "frmSettingschklistHistory"
        Me.frmSettingschklistHistory.Size = New System.Drawing.Size(1070, 554)
        Me.frmSettingschklistHistory.TabIndex = 17
        '
        'frmSettingschkboxSelectAllHistory
        '
        Me.frmSettingschkboxSelectAllHistory.AutoSize = True
        Me.frmSettingschkboxSelectAllHistory.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.frmSettingschkboxSelectAllHistory.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.frmSettingschkboxSelectAllHistory.Location = New System.Drawing.Point(29, 85)
        Me.frmSettingschkboxSelectAllHistory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSettingschkboxSelectAllHistory.Name = "frmSettingschkboxSelectAllHistory"
        Me.frmSettingschkboxSelectAllHistory.Size = New System.Drawing.Size(127, 29)
        Me.frmSettingschkboxSelectAllHistory.TabIndex = 18
        Me.frmSettingschkboxSelectAllHistory.Text = "Select all"
        Me.frmSettingschkboxSelectAllHistory.UseVisualStyleBackColor = True
        '
        'HistoryTitlePanel
        '
        Me.HistoryTitlePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.HistoryTitlePanel.Controls.Add(Me.Label22)
        Me.HistoryTitlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HistoryTitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.HistoryTitlePanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HistoryTitlePanel.Name = "HistoryTitlePanel"
        Me.HistoryTitlePanel.Size = New System.Drawing.Size(1125, 60)
        Me.HistoryTitlePanel.TabIndex = 0
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Verdana", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label22.Location = New System.Drawing.Point(5, 4)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(183, 48)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "History"
        '
        'BookmarksTabPage
        '
        Me.BookmarksTabPage.Controls.Add(Me.Panel5)
        Me.BookmarksTabPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BookmarksTabPage.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.BookmarksTabPage.Location = New System.Drawing.Point(171, 0)
        Me.BookmarksTabPage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BookmarksTabPage.Name = "BookmarksTabPage"
        Me.BookmarksTabPage.Padding = New System.Windows.Forms.Padding(0)
        Me.BookmarksTabPage.SelectedTextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.BookmarksTabPage.Size = New System.Drawing.Size(1133, 748)
        Me.BookmarksTabPage.TabIndex = 5
        Me.BookmarksTabPage.Text = "Bookmarks"
        Me.BookmarksTabPage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BookmarksTabPage.TextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.BookmarksTabPage.TooltipText = "TabPage"
        Me.BookmarksTabPage.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        Me.BookmarksTabPage.Visible = False
        '
        'Panel5
        '
        Me.Panel5.AutoScroll = True
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.FlatPanel7)
        Me.Panel5.Controls.Add(Me.frmSettingsbtnClearBookmarks)
        Me.Panel5.Controls.Add(Me.frmSettingschklistBookmarks)
        Me.Panel5.Controls.Add(Me.frmSettingschkboxSelectAllBookmarks)
        Me.Panel5.Controls.Add(Me.BookmarksTitlePanel)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(4, 4)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1125, 740)
        Me.Panel5.TabIndex = 2
        '
        'FlatPanel7
        '
        Me.FlatPanel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatPanel7.BackColor = System.Drawing.Color.White
        Me.FlatPanel7.Controls.Add(Me.frmSettingstxtSearchBookmark)
        Me.FlatPanel7.Controls.Add(Me.Label16)
        Me.FlatPanel7.Location = New System.Drawing.Point(653, 82)
        Me.FlatPanel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FlatPanel7.Name = "FlatPanel7"
        Me.FlatPanel7.Size = New System.Drawing.Size(447, 31)
        Me.FlatPanel7.TabIndex = 24
        '
        'frmSettingstxtSearchBookmark
        '
        Me.frmSettingstxtSearchBookmark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.frmSettingstxtSearchBookmark.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.frmSettingstxtSearchBookmark.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.frmSettingstxtSearchBookmark.Location = New System.Drawing.Point(255, 4)
        Me.frmSettingstxtSearchBookmark.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSettingstxtSearchBookmark.Multiline = True
        Me.frmSettingstxtSearchBookmark.Name = "frmSettingstxtSearchBookmark"
        Me.frmSettingstxtSearchBookmark.Size = New System.Drawing.Size(191, 30)
        Me.frmSettingstxtSearchBookmark.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(3, 4)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(255, 25)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Search the bookmarks: "
        '
        'frmSettingsbtnClearBookmarks
        '
        Me.frmSettingsbtnClearBookmarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frmSettingsbtnClearBookmarks.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.frmSettingsbtnClearBookmarks.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.frmSettingsbtnClearBookmarks.Location = New System.Drawing.Point(165, 82)
        Me.frmSettingsbtnClearBookmarks.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSettingsbtnClearBookmarks.Name = "frmSettingsbtnClearBookmarks"
        Me.frmSettingsbtnClearBookmarks.Size = New System.Drawing.Size(308, 33)
        Me.frmSettingsbtnClearBookmarks.TabIndex = 23
        Me.frmSettingsbtnClearBookmarks.Text = "Clear selected item(s)"
        Me.frmSettingsbtnClearBookmarks.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.frmSettingsbtnClearBookmarks.UseVisualStyleBackColor = True
        '
        'frmSettingschklistBookmarks
        '
        Me.frmSettingschklistBookmarks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.frmSettingschklistBookmarks.CheckOnClick = True
        Me.frmSettingschklistBookmarks.FormattingEnabled = True
        Me.frmSettingschklistBookmarks.Location = New System.Drawing.Point(29, 121)
        Me.frmSettingschklistBookmarks.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSettingschklistBookmarks.Name = "frmSettingschklistBookmarks"
        Me.frmSettingschklistBookmarks.Size = New System.Drawing.Size(1070, 554)
        Me.frmSettingschklistBookmarks.TabIndex = 21
        '
        'frmSettingschkboxSelectAllBookmarks
        '
        Me.frmSettingschkboxSelectAllBookmarks.AutoSize = True
        Me.frmSettingschkboxSelectAllBookmarks.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.frmSettingschkboxSelectAllBookmarks.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.frmSettingschkboxSelectAllBookmarks.Location = New System.Drawing.Point(29, 85)
        Me.frmSettingschkboxSelectAllBookmarks.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSettingschkboxSelectAllBookmarks.Name = "frmSettingschkboxSelectAllBookmarks"
        Me.frmSettingschkboxSelectAllBookmarks.Size = New System.Drawing.Size(127, 29)
        Me.frmSettingschkboxSelectAllBookmarks.TabIndex = 22
        Me.frmSettingschkboxSelectAllBookmarks.Text = "Select all"
        Me.frmSettingschkboxSelectAllBookmarks.UseVisualStyleBackColor = True
        '
        'BookmarksTitlePanel
        '
        Me.BookmarksTitlePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.BookmarksTitlePanel.Controls.Add(Me.Label11)
        Me.BookmarksTitlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.BookmarksTitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.BookmarksTitlePanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BookmarksTitlePanel.Name = "BookmarksTitlePanel"
        Me.BookmarksTitlePanel.Size = New System.Drawing.Size(1125, 60)
        Me.BookmarksTitlePanel.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(5, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(271, 48)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Bookmarks"
        '
        'DownloadsTabPage
        '
        Me.DownloadsTabPage.Controls.Add(Me.Panel8)
        Me.DownloadsTabPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DownloadsTabPage.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.DownloadsTabPage.Location = New System.Drawing.Point(171, 0)
        Me.DownloadsTabPage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DownloadsTabPage.Name = "DownloadsTabPage"
        Me.DownloadsTabPage.Padding = New System.Windows.Forms.Padding(0)
        Me.DownloadsTabPage.SelectedTextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.DownloadsTabPage.Size = New System.Drawing.Size(1133, 748)
        Me.DownloadsTabPage.TabIndex = 6
        Me.DownloadsTabPage.Text = "Downloads"
        Me.DownloadsTabPage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.DownloadsTabPage.TextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.DownloadsTabPage.TooltipText = "TabPage"
        Me.DownloadsTabPage.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        Me.DownloadsTabPage.Visible = False
        '
        'Panel8
        '
        Me.Panel8.AutoScroll = True
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Controls.Add(Me.FlatPanel8)
        Me.Panel8.Controls.Add(Me.frmSettingsbtnClearDownloads)
        Me.Panel8.Controls.Add(Me.frmSettingschklistDownloads)
        Me.Panel8.Controls.Add(Me.frmSettingschkboxSelectAllDownloads)
        Me.Panel8.Controls.Add(Me.DownloadsTitlePanel)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(4, 4)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1125, 740)
        Me.Panel8.TabIndex = 2
        '
        'FlatPanel8
        '
        Me.FlatPanel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatPanel8.BackColor = System.Drawing.Color.White
        Me.FlatPanel8.Controls.Add(Me.frmSettingstxtSearchDownload)
        Me.FlatPanel8.Controls.Add(Me.Label17)
        Me.FlatPanel8.Location = New System.Drawing.Point(653, 82)
        Me.FlatPanel8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FlatPanel8.Name = "FlatPanel8"
        Me.FlatPanel8.Size = New System.Drawing.Size(447, 31)
        Me.FlatPanel8.TabIndex = 28
        '
        'frmSettingstxtSearchDownload
        '
        Me.frmSettingstxtSearchDownload.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.frmSettingstxtSearchDownload.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.frmSettingstxtSearchDownload.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.frmSettingstxtSearchDownload.Location = New System.Drawing.Point(255, 4)
        Me.frmSettingstxtSearchDownload.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSettingstxtSearchDownload.Multiline = True
        Me.frmSettingstxtSearchDownload.Name = "frmSettingstxtSearchDownload"
        Me.frmSettingstxtSearchDownload.Size = New System.Drawing.Size(191, 30)
        Me.frmSettingstxtSearchDownload.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(3, 4)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(250, 25)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Search the downloads: "
        '
        'frmSettingsbtnClearDownloads
        '
        Me.frmSettingsbtnClearDownloads.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frmSettingsbtnClearDownloads.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.frmSettingsbtnClearDownloads.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.frmSettingsbtnClearDownloads.Location = New System.Drawing.Point(165, 82)
        Me.frmSettingsbtnClearDownloads.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSettingsbtnClearDownloads.Name = "frmSettingsbtnClearDownloads"
        Me.frmSettingsbtnClearDownloads.Size = New System.Drawing.Size(308, 33)
        Me.frmSettingsbtnClearDownloads.TabIndex = 27
        Me.frmSettingsbtnClearDownloads.Text = "Clear selected item(s)"
        Me.frmSettingsbtnClearDownloads.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.frmSettingsbtnClearDownloads.UseVisualStyleBackColor = True
        '
        'frmSettingschklistDownloads
        '
        Me.frmSettingschklistDownloads.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.frmSettingschklistDownloads.CheckOnClick = True
        Me.frmSettingschklistDownloads.FormattingEnabled = True
        Me.frmSettingschklistDownloads.Location = New System.Drawing.Point(29, 121)
        Me.frmSettingschklistDownloads.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSettingschklistDownloads.Name = "frmSettingschklistDownloads"
        Me.frmSettingschklistDownloads.Size = New System.Drawing.Size(1070, 554)
        Me.frmSettingschklistDownloads.TabIndex = 25
        '
        'frmSettingschkboxSelectAllDownloads
        '
        Me.frmSettingschkboxSelectAllDownloads.AutoSize = True
        Me.frmSettingschkboxSelectAllDownloads.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.frmSettingschkboxSelectAllDownloads.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.frmSettingschkboxSelectAllDownloads.Location = New System.Drawing.Point(29, 85)
        Me.frmSettingschkboxSelectAllDownloads.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSettingschkboxSelectAllDownloads.Name = "frmSettingschkboxSelectAllDownloads"
        Me.frmSettingschkboxSelectAllDownloads.Size = New System.Drawing.Size(127, 29)
        Me.frmSettingschkboxSelectAllDownloads.TabIndex = 26
        Me.frmSettingschkboxSelectAllDownloads.Text = "Select all"
        Me.frmSettingschkboxSelectAllDownloads.UseVisualStyleBackColor = True
        '
        'DownloadsTitlePanel
        '
        Me.DownloadsTitlePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.DownloadsTitlePanel.Controls.Add(Me.Label12)
        Me.DownloadsTitlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DownloadsTitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.DownloadsTitlePanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DownloadsTitlePanel.Name = "DownloadsTitlePanel"
        Me.DownloadsTitlePanel.Size = New System.Drawing.Size(1125, 60)
        Me.DownloadsTitlePanel.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Verdana", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(5, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(268, 48)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Downloads"
        '
        'CustomizeTabPage
        '
        Me.CustomizeTabPage.Controls.Add(Me.Panel10)
        Me.CustomizeTabPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomizeTabPage.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.CustomizeTabPage.Location = New System.Drawing.Point(170, 0)
        Me.CustomizeTabPage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CustomizeTabPage.Name = "CustomizeTabPage"
        Me.CustomizeTabPage.Padding = New System.Windows.Forms.Padding(0)
        Me.CustomizeTabPage.SelectedTextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.CustomizeTabPage.Size = New System.Drawing.Size(1133, 748)
        Me.CustomizeTabPage.TabIndex = 7
        Me.CustomizeTabPage.Text = "Customize"
        Me.CustomizeTabPage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.CustomizeTabPage.TextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.CustomizeTabPage.TooltipText = "TabPage"
        Me.CustomizeTabPage.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        Me.CustomizeTabPage.Visible = False
        '
        'Panel10
        '
        Me.Panel10.AutoScroll = True
        Me.Panel10.BackColor = System.Drawing.Color.White
        Me.Panel10.Controls.Add(Me.Label31)
        Me.Panel10.Controls.Add(Me.FlatPanel1)
        Me.Panel10.Controls.Add(Me.frmSettingschkboxVisableBookmarks)
        Me.Panel10.Controls.Add(Me.FlatPanel9)
        Me.Panel10.Controls.Add(Me.Label18)
        Me.Panel10.Controls.Add(Me.CustomizeTitlePanel)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(4, 4)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1125, 740)
        Me.Panel10.TabIndex = 2
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label31.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label31.Location = New System.Drawing.Point(29, 209)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(198, 25)
        Me.Label31.TabIndex = 41
        Me.Label31.Text = "Choose Language:"
        '
        'FlatPanel1
        '
        Me.FlatPanel1.BackColor = System.Drawing.Color.White
        Me.FlatPanel1.Controls.Add(Me.LanguageIcon)
        Me.FlatPanel1.Controls.Add(Me.frmSettingscmbLanguages)
        Me.FlatPanel1.Location = New System.Drawing.Point(259, 206)
        Me.FlatPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FlatPanel1.Name = "FlatPanel1"
        Me.FlatPanel1.Size = New System.Drawing.Size(323, 32)
        Me.FlatPanel1.TabIndex = 40
        '
        'LanguageIcon
        '
        Me.LanguageIcon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LanguageIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LanguageIcon.Location = New System.Drawing.Point(267, 0)
        Me.LanguageIcon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LanguageIcon.Name = "LanguageIcon"
        Me.LanguageIcon.Size = New System.Drawing.Size(32, 32)
        Me.LanguageIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LanguageIcon.TabIndex = 37
        Me.LanguageIcon.TabStop = False
        '
        'frmSettingscmbLanguages
        '
        Me.frmSettingscmbLanguages.BackColor = System.Drawing.Color.White
        Me.frmSettingscmbLanguages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmSettingscmbLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.frmSettingscmbLanguages.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frmSettingscmbLanguages.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.frmSettingscmbLanguages.FormattingEnabled = True
        Me.frmSettingscmbLanguages.Items.AddRange(New Object() {"English", "Български"})
        Me.frmSettingscmbLanguages.Location = New System.Drawing.Point(0, 0)
        Me.frmSettingscmbLanguages.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSettingscmbLanguages.MaxDropDownItems = 12
        Me.frmSettingscmbLanguages.Name = "frmSettingscmbLanguages"
        Me.frmSettingscmbLanguages.Size = New System.Drawing.Size(323, 30)
        Me.frmSettingscmbLanguages.TabIndex = 29
        '
        'frmSettingschkboxVisableBookmarks
        '
        Me.frmSettingschkboxVisableBookmarks.AutoSize = True
        Me.frmSettingschkboxVisableBookmarks.Enabled = False
        Me.frmSettingschkboxVisableBookmarks.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.frmSettingschkboxVisableBookmarks.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.frmSettingschkboxVisableBookmarks.Location = New System.Drawing.Point(35, 266)
        Me.frmSettingschkboxVisableBookmarks.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSettingschkboxVisableBookmarks.Name = "frmSettingschkboxVisableBookmarks"
        Me.frmSettingschkboxVisableBookmarks.Size = New System.Drawing.Size(474, 29)
        Me.frmSettingschkboxVisableBookmarks.TabIndex = 36
        Me.frmSettingschkboxVisableBookmarks.Text = "Always show bookmarks bar (Coming soon)"
        Me.frmSettingschkboxVisableBookmarks.UseVisualStyleBackColor = True
        '
        'FlatPanel9
        '
        Me.FlatPanel9.BackColor = System.Drawing.Color.White
        Me.FlatPanel9.Controls.Add(Me.frmSettingscmbCustomize)
        Me.FlatPanel9.Location = New System.Drawing.Point(35, 150)
        Me.FlatPanel9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FlatPanel9.Name = "FlatPanel9"
        Me.FlatPanel9.Size = New System.Drawing.Size(547, 32)
        Me.FlatPanel9.TabIndex = 28
        '
        'frmSettingscmbCustomize
        '
        Me.frmSettingscmbCustomize.BackColor = System.Drawing.Color.White
        Me.frmSettingscmbCustomize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmSettingscmbCustomize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.frmSettingscmbCustomize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frmSettingscmbCustomize.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.frmSettingscmbCustomize.FormattingEnabled = True
        Me.frmSettingscmbCustomize.Items.AddRange(New Object() {"Office Blue", "Office Blue 2", "Office Silver", "Office Silver 2 - Default", "Office Green", "Sky", "Aqua", "Sunset", "Olive", "Retro", "Retro Blue", "Modern Blue", "Modern Green", "Modern Orange", "Steel"})
        Me.frmSettingscmbCustomize.Location = New System.Drawing.Point(0, 0)
        Me.frmSettingscmbCustomize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSettingscmbCustomize.MaxDropDownItems = 12
        Me.frmSettingscmbCustomize.Name = "frmSettingscmbCustomize"
        Me.frmSettingscmbCustomize.Size = New System.Drawing.Size(547, 30)
        Me.frmSettingscmbCustomize.TabIndex = 29
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(29, 85)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(552, 50)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "Customize allows you to set different look and feel " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to your web browser. Choose" &
    " from the themes below:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'CustomizeTitlePanel
        '
        Me.CustomizeTitlePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.CustomizeTitlePanel.Controls.Add(Me.Label13)
        Me.CustomizeTitlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomizeTitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.CustomizeTitlePanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CustomizeTitlePanel.Name = "CustomizeTitlePanel"
        Me.CustomizeTitlePanel.Size = New System.Drawing.Size(1125, 60)
        Me.CustomizeTitlePanel.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Verdana", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(5, 4)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(254, 48)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Customize"
        '
        'AboutTabPage
        '
        Me.AboutTabPage.Controls.Add(Me.Panel12)
        Me.AboutTabPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AboutTabPage.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.AboutTabPage.Location = New System.Drawing.Point(170, 0)
        Me.AboutTabPage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AboutTabPage.Name = "AboutTabPage"
        Me.AboutTabPage.Padding = New System.Windows.Forms.Padding(0)
        Me.AboutTabPage.SelectedTextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.AboutTabPage.Size = New System.Drawing.Size(1133, 748)
        Me.AboutTabPage.TabIndex = 8
        Me.AboutTabPage.Text = "About"
        Me.AboutTabPage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.AboutTabPage.TextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.AboutTabPage.TooltipText = "TabPage"
        Me.AboutTabPage.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        Me.AboutTabPage.Visible = False
        '
        'Panel12
        '
        Me.Panel12.AutoScroll = True
        Me.Panel12.BackColor = System.Drawing.Color.White
        Me.Panel12.Controls.Add(Me.Label35)
        Me.Panel12.Controls.Add(Me.Label36)
        Me.Panel12.Controls.Add(Me.btnReset)
        Me.Panel12.Controls.Add(Me.Label19)
        Me.Panel12.Controls.Add(Me.Label27)
        Me.Panel12.Controls.Add(Me.Label26)
        Me.Panel12.Controls.Add(Me.Label25)
        Me.Panel12.Controls.Add(Me.btnReport)
        Me.Panel12.Controls.Add(Me.Label24)
        Me.Panel12.Controls.Add(Me.Label23)
        Me.Panel12.Controls.Add(Me.Label20)
        Me.Panel12.Controls.Add(Me.Label21)
        Me.Panel12.Controls.Add(Me.Label28)
        Me.Panel12.Controls.Add(Me.Label29)
        Me.Panel12.Controls.Add(Me.Label30)
        Me.Panel12.Controls.Add(Me.JaguarLogo)
        Me.Panel12.Controls.Add(Me.AboutTitlePanel)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(4, 4)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1125, 740)
        Me.Panel12.TabIndex = 2
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Label35.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label35.Location = New System.Drawing.Point(48, 382)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(649, 48)
        Me.Label35.TabIndex = 67
        Me.Label35.Text = "Set all default settings of your browser. Deletes all cookies, bookmarks and pass" &
    "words."
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label36.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label36.Location = New System.Drawing.Point(35, 346)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(82, 25)
        Me.Label36.TabIndex = 66
        Me.Label36.Text = "Reset "
        '
        'btnReset
        '
        Me.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnReset.Location = New System.Drawing.Point(52, 432)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(103, 39)
        Me.btnReset.TabIndex = 65
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(335, 177)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(174, 25)
        Me.Label19.TabIndex = 64
        Me.Label19.Text = "being developed"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label27.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label27.Location = New System.Drawing.Point(255, 252)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(298, 25)
        Me.Label27.TabIndex = 63
        Me.Label27.Text = "• Dilyan Dyankov - DilyanD."
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label26.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label26.Location = New System.Drawing.Point(255, 226)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(256, 25)
        Me.Label26.TabIndex = 62
        Me.Label26.Text = "• Martin Dzhurov - MSD"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label25.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label25.Location = New System.Drawing.Point(244, 202)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(114, 25)
        Me.Label25.TabIndex = 61
        Me.Label25.Text = "Founders:"
        '
        'btnReport
        '
        Me.btnReport.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnReport.Location = New System.Drawing.Point(52, 570)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(103, 39)
        Me.btnReport.TabIndex = 60
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label24.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label24.Location = New System.Drawing.Point(243, 289)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(272, 25)
        Me.Label24.TabIndex = 59
        Me.Label24.Text = "(©) Jaguar Browser 2017"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label23.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label23.Location = New System.Drawing.Point(244, 177)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(86, 25)
        Me.Label23.TabIndex = 58
        Me.Label23.Text = "Status:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(244, 151)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(176, 25)
        Me.Label20.TabIndex = 57
        Me.Label20.Text = "Version: 0.9.7.2"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(241, 114)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(229, 25)
        Me.Label21.TabIndex = 56
        Me.Label21.Text = "Fast  Simple  Ellegant"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label28.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label28.Location = New System.Drawing.Point(241, 81)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(224, 29)
        Me.Label28.TabIndex = 55
        Me.Label28.Text = "Jaguar Browser"
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Label29.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label29.Location = New System.Drawing.Point(48, 519)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(649, 48)
        Me.Label29.TabIndex = 53
        Me.Label29.Text = "If you notice any bugs, glitches, or anything else wrong, please report it to us " &
    "via the button below."
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label30.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label30.Location = New System.Drawing.Point(35, 484)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(208, 25)
        Me.Label30.TabIndex = 52
        Me.Label30.Text = "Report a problem"
        '
        'JaguarLogo
        '
        Me.JaguarLogo.Image = CType(resources.GetObject("JaguarLogo.Image"), System.Drawing.Image)
        Me.JaguarLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.JaguarLogo.Location = New System.Drawing.Point(35, 85)
        Me.JaguarLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.JaguarLogo.Name = "JaguarLogo"
        Me.JaguarLogo.Size = New System.Drawing.Size(200, 199)
        Me.JaguarLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.JaguarLogo.TabIndex = 54
        Me.JaguarLogo.TabStop = False
        '
        'AboutTitlePanel
        '
        Me.AboutTitlePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.AboutTitlePanel.Controls.Add(Me.Label14)
        Me.AboutTitlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.AboutTitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.AboutTitlePanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AboutTitlePanel.Name = "AboutTitlePanel"
        Me.AboutTitlePanel.Size = New System.Drawing.Size(1125, 60)
        Me.AboutTitlePanel.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Verdana", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(5, 4)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(220, 48)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "About us"
        '
        'HomeTabPage
        '
        Me.HomeTabPage.Controls.Add(Me.FlatRoundedPanel2)
        Me.HomeTabPage.Controls.Add(Me.JHPSearchFieldPanel)
        Me.HomeTabPage.Controls.Add(Me.JHPBackground)
        Me.HomeTabPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HomeTabPage.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.HomeTabPage.HeaderHeight = 27
        Me.HomeTabPage.HeaderWidth = 200
        Me.HomeTabPage.Location = New System.Drawing.Point(0, 27)
        Me.HomeTabPage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HomeTabPage.Name = "HomeTabPage"
        Me.HomeTabPage.Padding = New System.Windows.Forms.Padding(0)
        Me.HomeTabPage.SelectedTextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.HomeTabPage.Size = New System.Drawing.Size(1311, 756)
        Me.HomeTabPage.TabIndex = 6
        Me.HomeTabPage.Text = "Jaguar Home"
        Me.HomeTabPage.TextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.HomeTabPage.TooltipText = "TabPage"
        Me.HomeTabPage.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        Me.HomeTabPage.Visible = False
        '
        'FlatRoundedPanel2
        '
        Me.FlatRoundedPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlatRoundedPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.FlatRoundedPanel2.BorderColor = System.Drawing.Color.Black
        Me.FlatRoundedPanel2.Controls.Add(Me.JHPSearchButton)
        Me.FlatRoundedPanel2.Edge = 10
        Me.FlatRoundedPanel2.Location = New System.Drawing.Point(939, 349)
        Me.FlatRoundedPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FlatRoundedPanel2.Name = "FlatRoundedPanel2"
        Me.FlatRoundedPanel2.Size = New System.Drawing.Size(52, 52)
        Me.FlatRoundedPanel2.TabIndex = 9
        '
        'JHPSearchButton
        '
        Me.JHPSearchButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.JHPSearchButton.FlatAppearance.BorderSize = 0
        Me.JHPSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.JHPSearchButton.Image = CType(resources.GetObject("JHPSearchButton.Image"), System.Drawing.Image)
        Me.JHPSearchButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.JHPSearchButton.Location = New System.Drawing.Point(4, 4)
        Me.JHPSearchButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.JHPSearchButton.Name = "JHPSearchButton"
        Me.JHPSearchButton.Size = New System.Drawing.Size(45, 46)
        Me.JHPSearchButton.TabIndex = 5
        Me.JHPSearchButton.UseVisualStyleBackColor = False
        '
        'JHPSearchFieldPanel
        '
        Me.JHPSearchFieldPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.JHPSearchFieldPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.JHPSearchFieldPanel.BorderColor = System.Drawing.Color.Black
        Me.JHPSearchFieldPanel.Controls.Add(Me.JHPSearchField)
        Me.JHPSearchFieldPanel.Controls.Add(Me.JHPSearchEnginePic)
        Me.JHPSearchFieldPanel.Controls.Add(Me.JHPCmbSearchEngines)
        Me.JHPSearchFieldPanel.Edge = 10
        Me.JHPSearchFieldPanel.Location = New System.Drawing.Point(279, 349)
        Me.JHPSearchFieldPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.JHPSearchFieldPanel.Name = "JHPSearchFieldPanel"
        Me.JHPSearchFieldPanel.Size = New System.Drawing.Size(653, 52)
        Me.JHPSearchFieldPanel.TabIndex = 8
        '
        'JHPSearchField
        '
        Me.JHPSearchField.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.JHPSearchField.BackColor = System.Drawing.Color.WhiteSmoke
        Me.JHPSearchField.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.JHPSearchField.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.JHPSearchField.Location = New System.Drawing.Point(13, 14)
        Me.JHPSearchField.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.JHPSearchField.Name = "JHPSearchField"
        Me.JHPSearchField.Size = New System.Drawing.Size(572, 25)
        Me.JHPSearchField.TabIndex = 4
        '
        'JHPSearchEnginePic
        '
        Me.JHPSearchEnginePic.BackColor = System.Drawing.Color.Transparent
        Me.JHPSearchEnginePic.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.JHPSearchEnginePic.Location = New System.Drawing.Point(595, 15)
        Me.JHPSearchEnginePic.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.JHPSearchEnginePic.Name = "JHPSearchEnginePic"
        Me.JHPSearchEnginePic.Size = New System.Drawing.Size(21, 22)
        Me.JHPSearchEnginePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.JHPSearchEnginePic.TabIndex = 7
        Me.JHPSearchEnginePic.TabStop = False
        '
        'JHPCmbSearchEngines
        '
        Me.JHPCmbSearchEngines.BackColor = System.Drawing.Color.WhiteSmoke
        Me.JHPCmbSearchEngines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.JHPCmbSearchEngines.DropDownWidth = 80
        Me.JHPCmbSearchEngines.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.JHPCmbSearchEngines.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.JHPCmbSearchEngines.ForeColor = System.Drawing.Color.Black
        Me.JHPCmbSearchEngines.FormattingEnabled = True
        Me.JHPCmbSearchEngines.Items.AddRange(New Object() {"Google", "Bing ", "Yahoo", "Youtube", "Wikipedia"})
        Me.JHPCmbSearchEngines.Location = New System.Drawing.Point(591, 14)
        Me.JHPCmbSearchEngines.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.JHPCmbSearchEngines.Name = "JHPCmbSearchEngines"
        Me.JHPCmbSearchEngines.Size = New System.Drawing.Size(49, 24)
        Me.JHPCmbSearchEngines.TabIndex = 6
        '
        'JHPBackground
        '
        Me.JHPBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JHPBackground.Image = CType(resources.GetObject("JHPBackground.Image"), System.Drawing.Image)
        Me.JHPBackground.Location = New System.Drawing.Point(4, 4)
        Me.JHPBackground.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.JHPBackground.Name = "JHPBackground"
        Me.JHPBackground.Size = New System.Drawing.Size(1303, 748)
        Me.JHPBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.JHPBackground.TabIndex = 0
        Me.JHPBackground.TabStop = False
        '
        'WebDevTabPage
        '
        Me.WebDevTabPage.Controls.Add(Me.JWDTTabControl)
        Me.WebDevTabPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebDevTabPage.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.WebDevTabPage.Location = New System.Drawing.Point(0, 27)
        Me.WebDevTabPage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WebDevTabPage.Name = "WebDevTabPage"
        Me.WebDevTabPage.Padding = New System.Windows.Forms.Padding(0)
        Me.WebDevTabPage.SelectedTextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.WebDevTabPage.Size = New System.Drawing.Size(1311, 756)
        Me.WebDevTabPage.TabIndex = 8
        Me.WebDevTabPage.Text = "Jaguar Web Development Tool"
        Me.WebDevTabPage.TextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.WebDevTabPage.TooltipText = "TabPage"
        Me.WebDevTabPage.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        Me.WebDevTabPage.Visible = False
        '
        'JWDTTabControl
        '
        Me.JWDTTabControl.AllowAnimations = True
        Me.JWDTTabControl.Controls.Add(Me.WelcomeTabPage)
        Me.JWDTTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JWDTTabControl.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.JWDTTabControl.Location = New System.Drawing.Point(4, 4)
        Me.JWDTTabControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.JWDTTabControl.Name = "JWDTTabControl"
        Me.JWDTTabControl.Padding = New System.Windows.Forms.Padding(0, 25, 0, 0)
        Me.JWDTTabControl.Size = New System.Drawing.Size(1303, 748)
        Me.JWDTTabControl.TabAlignment = VIBlend.WinForms.Controls.vTabPageAlignment.Top
        Me.JWDTTabControl.TabIndex = 1
        Me.JWDTTabControl.TabPages.Add(Me.WelcomeTabPage)
        Me.JWDTTabControl.TabsAreaBackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.JWDTTabControl.TabsInitialOffset = 0
        Me.JWDTTabControl.TabsShape = VIBlend.WinForms.Controls.TabsShape.VisualStudio
        Me.JWDTTabControl.TabsSpacing = -10
        Me.JWDTTabControl.TitleHeight = 25
        Me.JWDTTabControl.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        '
        'WelcomeTabPage
        '
        Me.WelcomeTabPage.Controls.Add(Me.StartPagePanel)
        Me.WelcomeTabPage.Controls.Add(Me.Panel2)
        Me.WelcomeTabPage.Controls.Add(Me.Panel11)
        Me.WelcomeTabPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WelcomeTabPage.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.WelcomeTabPage.HeaderHeight = 25
        Me.WelcomeTabPage.HeaderWidth = 150
        Me.WelcomeTabPage.Location = New System.Drawing.Point(0, 25)
        Me.WelcomeTabPage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WelcomeTabPage.Name = "WelcomeTabPage"
        Me.WelcomeTabPage.Padding = New System.Windows.Forms.Padding(0)
        Me.WelcomeTabPage.SelectedTextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.WelcomeTabPage.Size = New System.Drawing.Size(1303, 723)
        Me.WelcomeTabPage.TabIndex = 3
        Me.WelcomeTabPage.Text = "Welcome"
        Me.WelcomeTabPage.TextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.WelcomeTabPage.TooltipText = "TabPage"
        Me.WelcomeTabPage.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        Me.WelcomeTabPage.Visible = False
        '
        'StartPagePanel
        '
        Me.StartPagePanel.BackColor = System.Drawing.Color.White
        Me.StartPagePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StartPagePanel.Location = New System.Drawing.Point(295, 104)
        Me.StartPagePanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StartPagePanel.Name = "StartPagePanel"
        Me.StartPagePanel.Size = New System.Drawing.Size(1004, 615)
        Me.StartPagePanel.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.RecentFilesListBox)
        Me.Panel2.Controls.Add(Me.Label32)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Label33)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.lblOpenFile)
        Me.Panel2.Controls.Add(Me.lblNewFile)
        Me.Panel2.Controls.Add(Me.Panel9)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(4, 104)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(291, 615)
        Me.Panel2.TabIndex = 10
        '
        'RecentFilesListBox
        '
        Me.RecentFilesListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecentFilesListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RecentFilesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RecentFilesListBox.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.RecentFilesListBox.ForeColor = System.Drawing.Color.White
        Me.RecentFilesListBox.FormattingEnabled = True
        Me.RecentFilesListBox.ItemHeight = 22
        Me.RecentFilesListBox.Location = New System.Drawing.Point(25, 254)
        Me.RecentFilesListBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RecentFilesListBox.Name = "RecentFilesListBox"
        Me.RecentFilesListBox.Size = New System.Drawing.Size(240, 132)
        Me.RecentFilesListBox.TabIndex = 0
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Verdana", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label32.Location = New System.Drawing.Point(25, 197)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(106, 29)
        Me.Label32.TabIndex = 9
        Me.Label32.Text = "Recent"
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(25, 229)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(240, 1)
        Me.Panel7.TabIndex = 8
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Verdana", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label33.Location = New System.Drawing.Point(25, 16)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(80, 29)
        Me.Label33.TabIndex = 7
        Me.Label33.Text = "Start"
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(25, 137)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(240, 1)
        Me.Panel6.TabIndex = 1
        '
        'lblOpenFile
        '
        Me.lblOpenFile.AutoSize = True
        Me.lblOpenFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblOpenFile.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.lblOpenFile.ForeColor = System.Drawing.Color.White
        Me.lblOpenFile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOpenFile.Location = New System.Drawing.Point(23, 96)
        Me.lblOpenFile.Name = "lblOpenFile"
        Me.lblOpenFile.Size = New System.Drawing.Size(108, 20)
        Me.lblOpenFile.TabIndex = 1
        Me.lblOpenFile.Text = "Open File..."
        '
        'lblNewFile
        '
        Me.lblNewFile.AutoSize = True
        Me.lblNewFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNewFile.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.lblNewFile.ForeColor = System.Drawing.Color.White
        Me.lblNewFile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNewFile.Location = New System.Drawing.Point(23, 66)
        Me.lblNewFile.Name = "lblNewFile"
        Me.lblNewFile.Size = New System.Drawing.Size(100, 20)
        Me.lblNewFile.TabIndex = 0
        Me.lblNewFile.Text = "New File..."
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel9.Location = New System.Drawing.Point(25, 48)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(240, 1)
        Me.Panel9.TabIndex = 0
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel11.Controls.Add(Me.MaskedTextBox)
        Me.Panel11.Controls.Add(Me.Panel13)
        Me.Panel11.Controls.Add(Me.Label34)
        Me.Panel11.Controls.Add(Me.JWDTLogo)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(4, 4)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1295, 100)
        Me.Panel11.TabIndex = 9
        '
        'MaskedTextBox
        '
        Me.MaskedTextBox.Location = New System.Drawing.Point(1275, 2)
        Me.MaskedTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaskedTextBox.Name = "MaskedTextBox"
        Me.MaskedTextBox.Size = New System.Drawing.Size(143, 28)
        Me.MaskedTextBox.TabIndex = 7
        Me.MaskedTextBox.Visible = False
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel13.Location = New System.Drawing.Point(93, 16)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(944, 5)
        Me.Panel13.TabIndex = 6
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Verdana", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label34.Location = New System.Drawing.Point(112, 22)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(848, 59)
        Me.Label34.TabIndex = 5
        Me.Label34.Text = "Jaguar Web Development Tool"
        '
        'JWDTLogo
        '
        Me.JWDTLogo.Image = Global.WindowsApplication1.My.Resources.Resources.application_code_512
        Me.JWDTLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.JWDTLogo.Location = New System.Drawing.Point(19, 0)
        Me.JWDTLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.JWDTLogo.Name = "JWDTLogo"
        Me.JWDTLogo.Size = New System.Drawing.Size(100, 100)
        Me.JWDTLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.JWDTLogo.TabIndex = 0
        Me.JWDTLogo.TabStop = False
        '
        'FirstRunTabPage
        '
        Me.FirstRunTabPage.Controls.Add(Me.WelcomeTabControl)
        Me.FirstRunTabPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FirstRunTabPage.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.FirstRunTabPage.HeaderHeight = 27
        Me.FirstRunTabPage.HeaderWidth = 220
        Me.FirstRunTabPage.Location = New System.Drawing.Point(0, 27)
        Me.FirstRunTabPage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FirstRunTabPage.Name = "FirstRunTabPage"
        Me.FirstRunTabPage.Padding = New System.Windows.Forms.Padding(0)
        Me.FirstRunTabPage.SelectedTextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.FirstRunTabPage.Size = New System.Drawing.Size(1311, 756)
        Me.FirstRunTabPage.TabIndex = 9
        Me.FirstRunTabPage.Text = "Welcome to Jaguar"
        Me.FirstRunTabPage.TextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.FirstRunTabPage.TooltipText = "TabPage"
        Me.FirstRunTabPage.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        Me.FirstRunTabPage.Visible = False
        '
        'WelcomeTabControl
        '
        Me.WelcomeTabControl.AllowAnimations = True
        Me.WelcomeTabControl.Controls.Add(Me.Step1)
        Me.WelcomeTabControl.Controls.Add(Me.Step2)
        Me.WelcomeTabControl.Controls.Add(Me.Step3)
        Me.WelcomeTabControl.Controls.Add(Me.Step4)
        Me.WelcomeTabControl.Controls.Add(Me.Step5)
        Me.WelcomeTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WelcomeTabControl.Location = New System.Drawing.Point(4, 4)
        Me.WelcomeTabControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WelcomeTabControl.Name = "WelcomeTabControl"
        Me.WelcomeTabControl.Padding = New System.Windows.Forms.Padding(0, 0, 0, 26)
        Me.WelcomeTabControl.Size = New System.Drawing.Size(1303, 748)
        Me.WelcomeTabControl.TabAlignment = VIBlend.WinForms.Controls.vTabPageAlignment.Bottom
        Me.WelcomeTabControl.TabIndex = 1
        Me.WelcomeTabControl.TabPages.Add(Me.Step1)
        Me.WelcomeTabControl.TabPages.Add(Me.Step2)
        Me.WelcomeTabControl.TabPages.Add(Me.Step3)
        Me.WelcomeTabControl.TabPages.Add(Me.Step4)
        Me.WelcomeTabControl.TabPages.Add(Me.Step5)
        Me.WelcomeTabControl.TabsAreaBackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.WelcomeTabControl.TabsInitialOffset = 0
        Me.WelcomeTabControl.TabsSpacing = 0
        Me.WelcomeTabControl.TitleHeight = 26
        Me.WelcomeTabControl.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        '
        'Step1
        '
        Me.Step1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Step1.Controls.Add(Me.Panel14)
        Me.Step1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Step1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Step1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Step1.Name = "Step1"
        Me.Step1.Padding = New System.Windows.Forms.Padding(0)
        Me.Step1.SelectedTextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.Step1.Size = New System.Drawing.Size(1303, 722)
        Me.Step1.TabIndex = 3
        Me.Step1.Text = "1"
        Me.Step1.TextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.Step1.TooltipText = "TabPage"
        Me.Step1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        Me.Step1.Visible = False
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.btnNext1)
        Me.Panel14.Controls.Add(Me.Label41)
        Me.Panel14.Controls.Add(Me.FlatPanel12)
        Me.Panel14.Controls.Add(Me.Label40)
        Me.Panel14.Controls.Add(Me.FlatPanel11)
        Me.Panel14.Controls.Add(Me.Label39)
        Me.Panel14.Controls.Add(Me.Label38)
        Me.Panel14.Controls.Add(Me.Label37)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(4, 4)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1295, 714)
        Me.Panel14.TabIndex = 1
        '
        'btnNext1
        '
        Me.btnNext1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnNext1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnNext1.Location = New System.Drawing.Point(1167, 670)
        Me.btnNext1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNext1.Name = "btnNext1"
        Me.btnNext1.Size = New System.Drawing.Size(125, 41)
        Me.btnNext1.TabIndex = 46
        Me.btnNext1.Text = "Next"
        Me.btnNext1.UseVisualStyleBackColor = True
        '
        'Label41
        '
        Me.Label41.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label41.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label41.Location = New System.Drawing.Point(392, 385)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(144, 28)
        Me.Label41.TabIndex = 45
        Me.Label41.Text = "Choose Theme:"
        '
        'FlatPanel12
        '
        Me.FlatPanel12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlatPanel12.BackColor = System.Drawing.Color.White
        Me.FlatPanel12.Controls.Add(Me.cmbWelcomeTheme)
        Me.FlatPanel12.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatPanel12.Location = New System.Drawing.Point(602, 382)
        Me.FlatPanel12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FlatPanel12.Name = "FlatPanel12"
        Me.FlatPanel12.Size = New System.Drawing.Size(323, 32)
        Me.FlatPanel12.TabIndex = 44
        '
        'cmbWelcomeTheme
        '
        Me.cmbWelcomeTheme.BackColor = System.Drawing.Color.White
        Me.cmbWelcomeTheme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbWelcomeTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWelcomeTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbWelcomeTheme.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.cmbWelcomeTheme.FormattingEnabled = True
        Me.cmbWelcomeTheme.Items.AddRange(New Object() {"Office Blue", "Office Blue 2", "Office Silver", "Office Silver 2 - Default", "Office Green", "Sky", "Aqua", "Sunset", "Olive", "Retro", "Retro Blue", "Modern Blue", "Modern Green", "Modern Orange", "Steel"})
        Me.cmbWelcomeTheme.Location = New System.Drawing.Point(0, 0)
        Me.cmbWelcomeTheme.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbWelcomeTheme.MaxDropDownItems = 12
        Me.cmbWelcomeTheme.Name = "cmbWelcomeTheme"
        Me.cmbWelcomeTheme.Size = New System.Drawing.Size(323, 30)
        Me.cmbWelcomeTheme.TabIndex = 29
        '
        'Label40
        '
        Me.Label40.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label40.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label40.Location = New System.Drawing.Point(392, 334)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(171, 28)
        Me.Label40.TabIndex = 43
        Me.Label40.Text = "Choose Language:"
        '
        'FlatPanel11
        '
        Me.FlatPanel11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlatPanel11.BackColor = System.Drawing.Color.White
        Me.FlatPanel11.Controls.Add(Me.pbWelcomeLanguage)
        Me.FlatPanel11.Controls.Add(Me.cmbWelcomeLanguage)
        Me.FlatPanel11.Location = New System.Drawing.Point(602, 332)
        Me.FlatPanel11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FlatPanel11.Name = "FlatPanel11"
        Me.FlatPanel11.Size = New System.Drawing.Size(323, 32)
        Me.FlatPanel11.TabIndex = 42
        '
        'pbWelcomeLanguage
        '
        Me.pbWelcomeLanguage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbWelcomeLanguage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pbWelcomeLanguage.Location = New System.Drawing.Point(267, 0)
        Me.pbWelcomeLanguage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbWelcomeLanguage.Name = "pbWelcomeLanguage"
        Me.pbWelcomeLanguage.Size = New System.Drawing.Size(32, 32)
        Me.pbWelcomeLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbWelcomeLanguage.TabIndex = 37
        Me.pbWelcomeLanguage.TabStop = False
        '
        'cmbWelcomeLanguage
        '
        Me.cmbWelcomeLanguage.BackColor = System.Drawing.Color.White
        Me.cmbWelcomeLanguage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbWelcomeLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWelcomeLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbWelcomeLanguage.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbWelcomeLanguage.FormattingEnabled = True
        Me.cmbWelcomeLanguage.Items.AddRange(New Object() {"English", "Български"})
        Me.cmbWelcomeLanguage.Location = New System.Drawing.Point(0, 0)
        Me.cmbWelcomeLanguage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbWelcomeLanguage.MaxDropDownItems = 12
        Me.cmbWelcomeLanguage.Name = "cmbWelcomeLanguage"
        Me.cmbWelcomeLanguage.Size = New System.Drawing.Size(323, 33)
        Me.cmbWelcomeLanguage.TabIndex = 29
        '
        'Label39
        '
        Me.Label39.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label39.Location = New System.Drawing.Point(499, 223)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(323, 35)
        Me.Label39.TabIndex = 2
        Me.Label39.Text = "But first let set some things!"
        '
        'Label38
        '
        Me.Label38.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label38.Location = New System.Drawing.Point(310, 122)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(723, 35)
        Me.Label38.TabIndex = 1
        Me.Label38.Text = "Go through our quick guide to get to know with all the features!"
        '
        'Label37
        '
        Me.Label37.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Segoe UI", 35.0!)
        Me.Label37.Location = New System.Drawing.Point(390, 34)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(534, 78)
        Me.Label37.TabIndex = 0
        Me.Label37.Text = "Welcome to Jaguar"
        '
        'Step2
        '
        Me.Step2.Controls.Add(Me.Panel15)
        Me.Step2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Step2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Step2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Step2.Name = "Step2"
        Me.Step2.Padding = New System.Windows.Forms.Padding(0)
        Me.Step2.SelectedTextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.Step2.Size = New System.Drawing.Size(1303, 722)
        Me.Step2.TabIndex = 4
        Me.Step2.Text = "2"
        Me.Step2.TextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.Step2.TooltipText = "TabPage"
        Me.Step2.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        Me.Step2.Visible = False
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.btnBack1)
        Me.Panel15.Controls.Add(Me.btnNext2)
        Me.Panel15.Controls.Add(Me.Pic1)
        Me.Panel15.Controls.Add(Me.Label42)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel15.Location = New System.Drawing.Point(4, 4)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1295, 714)
        Me.Panel15.TabIndex = 1
        '
        'btnBack1
        '
        Me.btnBack1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBack1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnBack1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnBack1.Location = New System.Drawing.Point(3, 669)
        Me.btnBack1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack1.Name = "btnBack1"
        Me.btnBack1.Size = New System.Drawing.Size(125, 41)
        Me.btnBack1.TabIndex = 48
        Me.btnBack1.Text = "Back"
        Me.btnBack1.UseVisualStyleBackColor = True
        '
        'btnNext2
        '
        Me.btnNext2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext2.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnNext2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnNext2.Location = New System.Drawing.Point(1167, 669)
        Me.btnNext2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNext2.Name = "btnNext2"
        Me.btnNext2.Size = New System.Drawing.Size(125, 41)
        Me.btnNext2.TabIndex = 47
        Me.btnNext2.Text = "Next"
        Me.btnNext2.UseVisualStyleBackColor = True
        '
        'Pic1
        '
        Me.Pic1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pic1.Image = Global.WindowsApplication1.My.Resources.Resources.EN
        Me.Pic1.Location = New System.Drawing.Point(19, 79)
        Me.Pic1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pic1.Name = "Pic1"
        Me.Pic1.Size = New System.Drawing.Size(1258, 619)
        Me.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic1.TabIndex = 2
        Me.Pic1.TabStop = False
        '
        'Label42
        '
        Me.Label42.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Segoe UI", 35.0!)
        Me.Label42.Location = New System.Drawing.Point(412, 6)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(426, 78)
        Me.Label42.TabIndex = 1
        Me.Label42.Text = "The Main Form"
        '
        'Step3
        '
        Me.Step3.Controls.Add(Me.Panel16)
        Me.Step3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Step3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Step3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Step3.Name = "Step3"
        Me.Step3.Padding = New System.Windows.Forms.Padding(0)
        Me.Step3.SelectedTextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.Step3.Size = New System.Drawing.Size(1303, 722)
        Me.Step3.TabIndex = 5
        Me.Step3.Text = "3"
        Me.Step3.TextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.Step3.TooltipText = "TabPage"
        Me.Step3.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        Me.Step3.Visible = False
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.btnBack2)
        Me.Panel16.Controls.Add(Me.btnNext3)
        Me.Panel16.Controls.Add(Me.Pic2)
        Me.Panel16.Controls.Add(Me.Label43)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel16.Location = New System.Drawing.Point(4, 4)
        Me.Panel16.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(1295, 714)
        Me.Panel16.TabIndex = 1
        '
        'btnBack2
        '
        Me.btnBack2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBack2.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnBack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnBack2.Location = New System.Drawing.Point(3, 669)
        Me.btnBack2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack2.Name = "btnBack2"
        Me.btnBack2.Size = New System.Drawing.Size(125, 41)
        Me.btnBack2.TabIndex = 49
        Me.btnBack2.Text = "Back"
        Me.btnBack2.UseVisualStyleBackColor = True
        '
        'btnNext3
        '
        Me.btnNext3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext3.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnNext3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnNext3.Location = New System.Drawing.Point(1167, 669)
        Me.btnNext3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNext3.Name = "btnNext3"
        Me.btnNext3.Size = New System.Drawing.Size(125, 41)
        Me.btnNext3.TabIndex = 47
        Me.btnNext3.Text = "Next"
        Me.btnNext3.UseVisualStyleBackColor = True
        '
        'Pic2
        '
        Me.Pic2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pic2.Image = Global.WindowsApplication1.My.Resources.Resources.EN_2
        Me.Pic2.Location = New System.Drawing.Point(19, 79)
        Me.Pic2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pic2.Name = "Pic2"
        Me.Pic2.Size = New System.Drawing.Size(1160, 619)
        Me.Pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic2.TabIndex = 4
        Me.Pic2.TabStop = False
        '
        'Label43
        '
        Me.Label43.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Segoe UI", 35.0!)
        Me.Label43.Location = New System.Drawing.Point(412, 6)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(421, 78)
        Me.Label43.TabIndex = 3
        Me.Label43.Text = "The Side Menu"
        '
        'Step4
        '
        Me.Step4.Controls.Add(Me.Panel17)
        Me.Step4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Step4.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Step4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Step4.Name = "Step4"
        Me.Step4.Padding = New System.Windows.Forms.Padding(0)
        Me.Step4.SelectedTextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.Step4.Size = New System.Drawing.Size(1303, 722)
        Me.Step4.TabIndex = 6
        Me.Step4.Text = "4"
        Me.Step4.TextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.Step4.TooltipText = "TabPage"
        Me.Step4.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        Me.Step4.Visible = False
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.btnBack3)
        Me.Panel17.Controls.Add(Me.btnNext4)
        Me.Panel17.Controls.Add(Me.PIc3)
        Me.Panel17.Controls.Add(Me.Label44)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel17.Location = New System.Drawing.Point(4, 4)
        Me.Panel17.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(1295, 714)
        Me.Panel17.TabIndex = 1
        '
        'btnBack3
        '
        Me.btnBack3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBack3.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnBack3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnBack3.Location = New System.Drawing.Point(3, 669)
        Me.btnBack3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack3.Name = "btnBack3"
        Me.btnBack3.Size = New System.Drawing.Size(125, 41)
        Me.btnBack3.TabIndex = 51
        Me.btnBack3.Text = "Back"
        Me.btnBack3.UseVisualStyleBackColor = True
        '
        'btnNext4
        '
        Me.btnNext4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext4.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnNext4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnNext4.Location = New System.Drawing.Point(1167, 669)
        Me.btnNext4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNext4.Name = "btnNext4"
        Me.btnNext4.Size = New System.Drawing.Size(125, 41)
        Me.btnNext4.TabIndex = 50
        Me.btnNext4.Text = "Next"
        Me.btnNext4.UseVisualStyleBackColor = True
        '
        'PIc3
        '
        Me.PIc3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PIc3.Image = Global.WindowsApplication1.My.Resources.Resources.EN_3
        Me.PIc3.Location = New System.Drawing.Point(11, 86)
        Me.PIc3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PIc3.Name = "PIc3"
        Me.PIc3.Size = New System.Drawing.Size(1274, 609)
        Me.PIc3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PIc3.TabIndex = 49
        Me.PIc3.TabStop = False
        '
        'Label44
        '
        Me.Label44.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Segoe UI", 35.0!)
        Me.Label44.Location = New System.Drawing.Point(541, 5)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(242, 78)
        Me.Label44.TabIndex = 48
        Me.Label44.Text = "Settings"
        '
        'Step5
        '
        Me.Step5.Controls.Add(Me.Panel18)
        Me.Step5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Step5.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Step5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Step5.Name = "Step5"
        Me.Step5.Padding = New System.Windows.Forms.Padding(0)
        Me.Step5.SelectedTextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.Step5.Size = New System.Drawing.Size(1303, 722)
        Me.Step5.TabIndex = 7
        Me.Step5.Text = "5"
        Me.Step5.TextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.Step5.TooltipText = "TabPage"
        Me.Step5.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        Me.Step5.Visible = False
        '
        'Panel18
        '
        Me.Panel18.Controls.Add(Me.btnFinish)
        Me.Panel18.Controls.Add(Me.btnBack4)
        Me.Panel18.Controls.Add(Me.Label47)
        Me.Panel18.Controls.Add(Me.lblContact)
        Me.Panel18.Controls.Add(Me.Label46)
        Me.Panel18.Controls.Add(Me.Label45)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel18.Location = New System.Drawing.Point(4, 4)
        Me.Panel18.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(1295, 714)
        Me.Panel18.TabIndex = 1
        '
        'btnFinish
        '
        Me.btnFinish.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFinish.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinish.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnFinish.Location = New System.Drawing.Point(1167, 670)
        Me.btnFinish.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(125, 41)
        Me.btnFinish.TabIndex = 50
        Me.btnFinish.Text = "Finish"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'btnBack4
        '
        Me.btnBack4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBack4.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnBack4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnBack4.Location = New System.Drawing.Point(3, 670)
        Me.btnBack4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack4.Name = "btnBack4"
        Me.btnBack4.Size = New System.Drawing.Size(125, 41)
        Me.btnBack4.TabIndex = 49
        Me.btnBack4.Text = "Back"
        Me.btnBack4.UseVisualStyleBackColor = True
        '
        'Label47
        '
        Me.Label47.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label47.Location = New System.Drawing.Point(526, 386)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(294, 35)
        Me.Label47.TabIndex = 4
        Me.Label47.Text = "Happy surfing! - Team JB"
        '
        'lblContact
        '
        Me.lblContact.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblContact.AutoSize = True
        Me.lblContact.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblContact.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.lblContact.Location = New System.Drawing.Point(391, 204)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(549, 35)
        Me.lblContact.TabIndex = 3
        Me.lblContact.Text = "http://jaguarbrowser.wixsite.com/jaguar/contact"
        '
        'Label46
        '
        Me.Label46.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label46.Location = New System.Drawing.Point(312, 146)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(754, 35)
        Me.Label46.TabIndex = 2
        Me.Label46.Text = "If you have any questions, make sure you contact us via link below:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label45
        '
        Me.Label45.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label45.Font = New System.Drawing.Font("Segoe UI", 35.0!)
        Me.Label45.Location = New System.Drawing.Point(318, 26)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(748, 78)
        Me.Label45.TabIndex = 1
        Me.Label45.Text = "End of the guide"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MyHomePage
        '
        Me.MyHomePage.Controls.Add(Me.MHPbtnShowHideBookmarksPanel)
        Me.MyHomePage.Controls.Add(Me.MHPbtnShowTools)
        Me.MyHomePage.Controls.Add(Me.MHPToolsPanel)
        Me.MyHomePage.Controls.Add(Me.MHPBookmarksPanel)
        Me.MyHomePage.Controls.Add(Me.MHPSearchButtonPanel)
        Me.MyHomePage.Controls.Add(Me.MHPSearchFieldPanel)
        Me.MyHomePage.Controls.Add(Me.MHPBackground)
        Me.MyHomePage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyHomePage.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.MyHomePage.HeaderHeight = 27
        Me.MyHomePage.HeaderWidth = 200
        Me.MyHomePage.Location = New System.Drawing.Point(0, 27)
        Me.MyHomePage.Name = "MyHomePage"
        Me.MyHomePage.Padding = New System.Windows.Forms.Padding(0)
        Me.MyHomePage.SelectedTextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.MyHomePage.Size = New System.Drawing.Size(1311, 756)
        Me.MyHomePage.TabIndex = 11
        Me.MyHomePage.Text = "My Homepage"
        Me.MyHomePage.TextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.MyHomePage.TooltipText = "TabPage"
        Me.MyHomePage.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        Me.MyHomePage.Visible = False
        '
        'MHPbtnShowHideBookmarksPanel
        '
        Me.MHPbtnShowHideBookmarksPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MHPbtnShowHideBookmarksPanel.BackColor = System.Drawing.Color.Black
        Me.MHPbtnShowHideBookmarksPanel.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.MHPbtnShowHideBookmarksPanel.FlatAppearance.BorderSize = 0
        Me.MHPbtnShowHideBookmarksPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MHPbtnShowHideBookmarksPanel.ForeColor = System.Drawing.Color.Black
        Me.MHPbtnShowHideBookmarksPanel.Image = Global.WindowsApplication1.My.Resources.Resources.Expand_Arrow_25px
        Me.MHPbtnShowHideBookmarksPanel.Location = New System.Drawing.Point(4, 463)
        Me.MHPbtnShowHideBookmarksPanel.Name = "MHPbtnShowHideBookmarksPanel"
        Me.MHPbtnShowHideBookmarksPanel.Size = New System.Drawing.Size(30, 30)
        Me.MHPbtnShowHideBookmarksPanel.TabIndex = 14
        Me.MHPbtnShowHideBookmarksPanel.UseVisualStyleBackColor = False
        '
        'MHPbtnShowTools
        '
        Me.MHPbtnShowTools.BackColor = System.Drawing.Color.Black
        Me.MHPbtnShowTools.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.MHPbtnShowTools.FlatAppearance.BorderSize = 0
        Me.MHPbtnShowTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MHPbtnShowTools.ForeColor = System.Drawing.Color.Black
        Me.MHPbtnShowTools.Image = Global.WindowsApplication1.My.Resources.Resources.Forward_25px
        Me.MHPbtnShowTools.Location = New System.Drawing.Point(4, 4)
        Me.MHPbtnShowTools.Name = "MHPbtnShowTools"
        Me.MHPbtnShowTools.Size = New System.Drawing.Size(30, 30)
        Me.MHPbtnShowTools.TabIndex = 0
        Me.MHPbtnShowTools.UseVisualStyleBackColor = False
        '
        'MHPToolsPanel
        '
        Me.MHPToolsPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MHPToolsPanel.BackColor = System.Drawing.Color.Black
        Me.MHPToolsPanel.Controls.Add(Me.MHPbtnMoveObjects)
        Me.MHPToolsPanel.Controls.Add(Me.MHPbtnInsertImage)
        Me.MHPToolsPanel.Controls.Add(Me.MHPbtnInsertVideo)
        Me.MHPToolsPanel.Controls.Add(Me.MHPbtnInsertSound)
        Me.MHPToolsPanel.Location = New System.Drawing.Point(33, 4)
        Me.MHPToolsPanel.Name = "MHPToolsPanel"
        Me.MHPToolsPanel.Size = New System.Drawing.Size(1273, 30)
        Me.MHPToolsPanel.TabIndex = 13
        Me.MHPToolsPanel.Visible = False
        '
        'MHPbtnMoveObjects
        '
        Me.MHPbtnMoveObjects.BackColor = System.Drawing.Color.Black
        Me.MHPbtnMoveObjects.Dock = System.Windows.Forms.DockStyle.Right
        Me.MHPbtnMoveObjects.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.MHPbtnMoveObjects.FlatAppearance.BorderSize = 0
        Me.MHPbtnMoveObjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MHPbtnMoveObjects.ForeColor = System.Drawing.Color.Black
        Me.MHPbtnMoveObjects.Image = Global.WindowsApplication1.My.Resources.Resources.Move_25px
        Me.MHPbtnMoveObjects.Location = New System.Drawing.Point(1113, 0)
        Me.MHPbtnMoveObjects.Name = "MHPbtnMoveObjects"
        Me.MHPbtnMoveObjects.Size = New System.Drawing.Size(40, 30)
        Me.MHPbtnMoveObjects.TabIndex = 4
        Me.MHPbtnMoveObjects.UseVisualStyleBackColor = False
        '
        'MHPbtnInsertImage
        '
        Me.MHPbtnInsertImage.BackColor = System.Drawing.Color.Black
        Me.MHPbtnInsertImage.Dock = System.Windows.Forms.DockStyle.Right
        Me.MHPbtnInsertImage.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.MHPbtnInsertImage.FlatAppearance.BorderSize = 0
        Me.MHPbtnInsertImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MHPbtnInsertImage.ForeColor = System.Drawing.Color.Black
        Me.MHPbtnInsertImage.Image = Global.WindowsApplication1.My.Resources.Resources.Image_File_25px
        Me.MHPbtnInsertImage.Location = New System.Drawing.Point(1153, 0)
        Me.MHPbtnInsertImage.Name = "MHPbtnInsertImage"
        Me.MHPbtnInsertImage.Size = New System.Drawing.Size(40, 30)
        Me.MHPbtnInsertImage.TabIndex = 3
        Me.MHPbtnInsertImage.UseVisualStyleBackColor = False
        '
        'MHPbtnInsertVideo
        '
        Me.MHPbtnInsertVideo.BackColor = System.Drawing.Color.Black
        Me.MHPbtnInsertVideo.Dock = System.Windows.Forms.DockStyle.Right
        Me.MHPbtnInsertVideo.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.MHPbtnInsertVideo.FlatAppearance.BorderSize = 0
        Me.MHPbtnInsertVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MHPbtnInsertVideo.ForeColor = System.Drawing.Color.Black
        Me.MHPbtnInsertVideo.Image = Global.WindowsApplication1.My.Resources.Resources.Video__25px
        Me.MHPbtnInsertVideo.Location = New System.Drawing.Point(1193, 0)
        Me.MHPbtnInsertVideo.Name = "MHPbtnInsertVideo"
        Me.MHPbtnInsertVideo.Size = New System.Drawing.Size(40, 30)
        Me.MHPbtnInsertVideo.TabIndex = 2
        Me.MHPbtnInsertVideo.UseVisualStyleBackColor = False
        '
        'MHPbtnInsertSound
        '
        Me.MHPbtnInsertSound.BackColor = System.Drawing.Color.Black
        Me.MHPbtnInsertSound.Dock = System.Windows.Forms.DockStyle.Right
        Me.MHPbtnInsertSound.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.MHPbtnInsertSound.FlatAppearance.BorderSize = 0
        Me.MHPbtnInsertSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MHPbtnInsertSound.ForeColor = System.Drawing.Color.Black
        Me.MHPbtnInsertSound.Image = Global.WindowsApplication1.My.Resources.Resources.Bell_25px
        Me.MHPbtnInsertSound.Location = New System.Drawing.Point(1233, 0)
        Me.MHPbtnInsertSound.Name = "MHPbtnInsertSound"
        Me.MHPbtnInsertSound.Size = New System.Drawing.Size(40, 30)
        Me.MHPbtnInsertSound.TabIndex = 1
        Me.MHPbtnInsertSound.UseVisualStyleBackColor = False
        '
        'MHPBookmarksPanel
        '
        Me.MHPBookmarksPanel.Controls.Add(Me.MHPFlowLayoutPanel)
        Me.MHPBookmarksPanel.Controls.Add(Me.Panel19)
        Me.MHPBookmarksPanel.Controls.Add(Me.MHPBookmarksToolsPanel)
        Me.MHPBookmarksPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MHPBookmarksPanel.Location = New System.Drawing.Point(4, 492)
        Me.MHPBookmarksPanel.Name = "MHPBookmarksPanel"
        Me.MHPBookmarksPanel.Size = New System.Drawing.Size(1303, 260)
        Me.MHPBookmarksPanel.TabIndex = 12
        '
        'MHPFlowLayoutPanel
        '
        Me.MHPFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MHPFlowLayoutPanel.Location = New System.Drawing.Point(0, 30)
        Me.MHPFlowLayoutPanel.Name = "MHPFlowLayoutPanel"
        Me.MHPFlowLayoutPanel.Padding = New System.Windows.Forms.Padding(30, 5, 10, 5)
        Me.MHPFlowLayoutPanel.Size = New System.Drawing.Size(1303, 200)
        Me.MHPFlowLayoutPanel.TabIndex = 18
        '
        'Panel19
        '
        Me.Panel19.Controls.Add(Me.MHPbtnBookmarksForward)
        Me.Panel19.Controls.Add(Me.MHPbtnBookmarksBackward)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel19.Location = New System.Drawing.Point(0, 230)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(1303, 30)
        Me.Panel19.TabIndex = 17
        '
        'MHPbtnBookmarksForward
        '
        Me.MHPbtnBookmarksForward.BackColor = System.Drawing.Color.Black
        Me.MHPbtnBookmarksForward.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MHPbtnBookmarksForward.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.MHPbtnBookmarksForward.FlatAppearance.BorderSize = 0
        Me.MHPbtnBookmarksForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MHPbtnBookmarksForward.ForeColor = System.Drawing.Color.Black
        Me.MHPbtnBookmarksForward.Image = Global.WindowsApplication1.My.Resources.Resources.Forward_25px
        Me.MHPbtnBookmarksForward.Location = New System.Drawing.Point(674, 0)
        Me.MHPbtnBookmarksForward.Name = "MHPbtnBookmarksForward"
        Me.MHPbtnBookmarksForward.Size = New System.Drawing.Size(629, 30)
        Me.MHPbtnBookmarksForward.TabIndex = 16
        Me.MHPbtnBookmarksForward.UseVisualStyleBackColor = False
        '
        'MHPbtnBookmarksBackward
        '
        Me.MHPbtnBookmarksBackward.BackColor = System.Drawing.Color.Black
        Me.MHPbtnBookmarksBackward.Dock = System.Windows.Forms.DockStyle.Left
        Me.MHPbtnBookmarksBackward.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.MHPbtnBookmarksBackward.FlatAppearance.BorderSize = 0
        Me.MHPbtnBookmarksBackward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MHPbtnBookmarksBackward.ForeColor = System.Drawing.Color.Black
        Me.MHPbtnBookmarksBackward.Image = Global.WindowsApplication1.My.Resources.Resources.Back_25px
        Me.MHPbtnBookmarksBackward.Location = New System.Drawing.Point(0, 0)
        Me.MHPbtnBookmarksBackward.Name = "MHPbtnBookmarksBackward"
        Me.MHPbtnBookmarksBackward.Size = New System.Drawing.Size(674, 30)
        Me.MHPbtnBookmarksBackward.TabIndex = 15
        Me.MHPbtnBookmarksBackward.UseVisualStyleBackColor = False
        '
        'MHPBookmarksToolsPanel
        '
        Me.MHPBookmarksToolsPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MHPBookmarksToolsPanel.Controls.Add(Me.MHPPanelAddBookmark)
        Me.MHPBookmarksToolsPanel.Controls.Add(Me.MHPbtnAddBookmarkMenu)
        Me.MHPBookmarksToolsPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.MHPBookmarksToolsPanel.Location = New System.Drawing.Point(0, 0)
        Me.MHPBookmarksToolsPanel.Name = "MHPBookmarksToolsPanel"
        Me.MHPBookmarksToolsPanel.Size = New System.Drawing.Size(1303, 30)
        Me.MHPBookmarksToolsPanel.TabIndex = 14
        '
        'MHPPanelAddBookmark
        '
        Me.MHPPanelAddBookmark.BackColor = System.Drawing.Color.Black
        Me.MHPPanelAddBookmark.Controls.Add(Me.MHPbtnAddBookmark)
        Me.MHPPanelAddBookmark.Controls.Add(Me.MHPtxtBookmarkURL)
        Me.MHPPanelAddBookmark.Controls.Add(Me.Label49)
        Me.MHPPanelAddBookmark.Controls.Add(Me.MHPtxtBookmarkName)
        Me.MHPPanelAddBookmark.Controls.Add(Me.Label48)
        Me.MHPPanelAddBookmark.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MHPPanelAddBookmark.Location = New System.Drawing.Point(30, 0)
        Me.MHPPanelAddBookmark.Name = "MHPPanelAddBookmark"
        Me.MHPPanelAddBookmark.Size = New System.Drawing.Size(1273, 30)
        Me.MHPPanelAddBookmark.TabIndex = 16
        Me.MHPPanelAddBookmark.Visible = False
        '
        'MHPbtnAddBookmark
        '
        Me.MHPbtnAddBookmark.BackColor = System.Drawing.Color.Black
        Me.MHPbtnAddBookmark.Dock = System.Windows.Forms.DockStyle.Left
        Me.MHPbtnAddBookmark.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.MHPbtnAddBookmark.FlatAppearance.BorderSize = 0
        Me.MHPbtnAddBookmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MHPbtnAddBookmark.ForeColor = System.Drawing.Color.Black
        Me.MHPbtnAddBookmark.Image = Global.WindowsApplication1.My.Resources.Resources.Plus_Math_25px
        Me.MHPbtnAddBookmark.Location = New System.Drawing.Point(1153, 0)
        Me.MHPbtnAddBookmark.Name = "MHPbtnAddBookmark"
        Me.MHPbtnAddBookmark.Size = New System.Drawing.Size(30, 30)
        Me.MHPbtnAddBookmark.TabIndex = 16
        Me.MHPbtnAddBookmark.UseVisualStyleBackColor = False
        '
        'MHPtxtBookmarkURL
        '
        Me.MHPtxtBookmarkURL.BackColor = System.Drawing.Color.Black
        Me.MHPtxtBookmarkURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MHPtxtBookmarkURL.Dock = System.Windows.Forms.DockStyle.Left
        Me.MHPtxtBookmarkURL.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.MHPtxtBookmarkURL.ForeColor = System.Drawing.Color.White
        Me.MHPtxtBookmarkURL.Location = New System.Drawing.Point(389, 0)
        Me.MHPtxtBookmarkURL.Name = "MHPtxtBookmarkURL"
        Me.MHPtxtBookmarkURL.Size = New System.Drawing.Size(764, 30)
        Me.MHPtxtBookmarkURL.TabIndex = 15
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label49.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Label49.ForeColor = System.Drawing.Color.White
        Me.Label49.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label49.Location = New System.Drawing.Point(304, 0)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(85, 30)
        Me.Label49.TabIndex = 14
        Me.Label49.Text = "URL: "
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MHPtxtBookmarkName
        '
        Me.MHPtxtBookmarkName.BackColor = System.Drawing.Color.Black
        Me.MHPtxtBookmarkName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MHPtxtBookmarkName.Dock = System.Windows.Forms.DockStyle.Left
        Me.MHPtxtBookmarkName.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.MHPtxtBookmarkName.ForeColor = System.Drawing.Color.White
        Me.MHPtxtBookmarkName.Location = New System.Drawing.Point(85, 0)
        Me.MHPtxtBookmarkName.Name = "MHPtxtBookmarkName"
        Me.MHPtxtBookmarkName.Size = New System.Drawing.Size(219, 30)
        Me.MHPtxtBookmarkName.TabIndex = 13
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label48.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Label48.ForeColor = System.Drawing.Color.White
        Me.Label48.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label48.Location = New System.Drawing.Point(0, 0)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(85, 30)
        Me.Label48.TabIndex = 12
        Me.Label48.Text = "Name: "
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MHPbtnAddBookmarkMenu
        '
        Me.MHPbtnAddBookmarkMenu.BackColor = System.Drawing.Color.Black
        Me.MHPbtnAddBookmarkMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.MHPbtnAddBookmarkMenu.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.MHPbtnAddBookmarkMenu.FlatAppearance.BorderSize = 0
        Me.MHPbtnAddBookmarkMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MHPbtnAddBookmarkMenu.ForeColor = System.Drawing.Color.Black
        Me.MHPbtnAddBookmarkMenu.Image = Global.WindowsApplication1.My.Resources.Resources.Plus_Math_25px
        Me.MHPbtnAddBookmarkMenu.Location = New System.Drawing.Point(0, 0)
        Me.MHPbtnAddBookmarkMenu.Name = "MHPbtnAddBookmarkMenu"
        Me.MHPbtnAddBookmarkMenu.Size = New System.Drawing.Size(30, 30)
        Me.MHPbtnAddBookmarkMenu.TabIndex = 15
        Me.MHPbtnAddBookmarkMenu.UseVisualStyleBackColor = False
        '
        'MHPSearchButtonPanel
        '
        Me.MHPSearchButtonPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MHPSearchButtonPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MHPSearchButtonPanel.BorderColor = System.Drawing.Color.Black
        Me.MHPSearchButtonPanel.Controls.Add(Me.MHPSearchButton)
        Me.MHPSearchButtonPanel.Edge = 10
        Me.MHPSearchButtonPanel.Location = New System.Drawing.Point(968, 106)
        Me.MHPSearchButtonPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MHPSearchButtonPanel.Name = "MHPSearchButtonPanel"
        Me.MHPSearchButtonPanel.Size = New System.Drawing.Size(52, 52)
        Me.MHPSearchButtonPanel.TabIndex = 11
        '
        'MHPSearchButton
        '
        Me.MHPSearchButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MHPSearchButton.FlatAppearance.BorderSize = 0
        Me.MHPSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MHPSearchButton.Image = CType(resources.GetObject("MHPSearchButton.Image"), System.Drawing.Image)
        Me.MHPSearchButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MHPSearchButton.Location = New System.Drawing.Point(4, 4)
        Me.MHPSearchButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MHPSearchButton.Name = "MHPSearchButton"
        Me.MHPSearchButton.Size = New System.Drawing.Size(45, 46)
        Me.MHPSearchButton.TabIndex = 5
        Me.MHPSearchButton.UseVisualStyleBackColor = False
        '
        'MHPSearchFieldPanel
        '
        Me.MHPSearchFieldPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MHPSearchFieldPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MHPSearchFieldPanel.BorderColor = System.Drawing.Color.Black
        Me.MHPSearchFieldPanel.Controls.Add(Me.MHPSearchField)
        Me.MHPSearchFieldPanel.Controls.Add(Me.MHPSearchEnginePic)
        Me.MHPSearchFieldPanel.Controls.Add(Me.MHPCmbSearchEngines)
        Me.MHPSearchFieldPanel.Edge = 10
        Me.MHPSearchFieldPanel.Location = New System.Drawing.Point(308, 106)
        Me.MHPSearchFieldPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MHPSearchFieldPanel.Name = "MHPSearchFieldPanel"
        Me.MHPSearchFieldPanel.Size = New System.Drawing.Size(653, 52)
        Me.MHPSearchFieldPanel.TabIndex = 10
        '
        'MHPSearchField
        '
        Me.MHPSearchField.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MHPSearchField.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MHPSearchField.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MHPSearchField.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.MHPSearchField.Location = New System.Drawing.Point(13, 14)
        Me.MHPSearchField.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MHPSearchField.Name = "MHPSearchField"
        Me.MHPSearchField.Size = New System.Drawing.Size(572, 25)
        Me.MHPSearchField.TabIndex = 4
        '
        'MHPSearchEnginePic
        '
        Me.MHPSearchEnginePic.BackColor = System.Drawing.Color.Transparent
        Me.MHPSearchEnginePic.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MHPSearchEnginePic.Location = New System.Drawing.Point(595, 15)
        Me.MHPSearchEnginePic.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MHPSearchEnginePic.Name = "MHPSearchEnginePic"
        Me.MHPSearchEnginePic.Size = New System.Drawing.Size(21, 22)
        Me.MHPSearchEnginePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MHPSearchEnginePic.TabIndex = 7
        Me.MHPSearchEnginePic.TabStop = False
        '
        'MHPCmbSearchEngines
        '
        Me.MHPCmbSearchEngines.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MHPCmbSearchEngines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MHPCmbSearchEngines.DropDownWidth = 80
        Me.MHPCmbSearchEngines.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MHPCmbSearchEngines.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.MHPCmbSearchEngines.ForeColor = System.Drawing.Color.Black
        Me.MHPCmbSearchEngines.FormattingEnabled = True
        Me.MHPCmbSearchEngines.Items.AddRange(New Object() {"Google", "Bing ", "Yahoo", "Youtube", "Wikipedia"})
        Me.MHPCmbSearchEngines.Location = New System.Drawing.Point(591, 14)
        Me.MHPCmbSearchEngines.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MHPCmbSearchEngines.Name = "MHPCmbSearchEngines"
        Me.MHPCmbSearchEngines.Size = New System.Drawing.Size(49, 24)
        Me.MHPCmbSearchEngines.TabIndex = 6
        '
        'MHPBackground
        '
        Me.MHPBackground.BackColor = System.Drawing.Color.Transparent
        Me.MHPBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MHPBackground.Location = New System.Drawing.Point(4, 4)
        Me.MHPBackground.Name = "MHPBackground"
        Me.MHPBackground.Size = New System.Drawing.Size(1303, 748)
        Me.MHPBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MHPBackground.TabIndex = 0
        Me.MHPBackground.TabStop = False
        '
        'MainPanel
        '
        Me.MainPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.MainPanel.Controls.Add(Me.SearchPanel)
        Me.MainPanel.Controls.Add(Me.frmMainFormbtnMenu)
        Me.MainPanel.Controls.Add(Me.frmMainFormbtnHome)
        Me.MainPanel.Controls.Add(Me.frmMainFormbtnForward)
        Me.MainPanel.Controls.Add(Me.frmMainFormbtnBackward)
        Me.MainPanel.Controls.Add(Me.SearchWord)
        Me.MainPanel.Location = New System.Drawing.Point(5, 32)
        Me.MainPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1311, 60)
        Me.MainPanel.TabIndex = 6
        '
        'SearchPanel
        '
        Me.SearchPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchPanel.BackColor = System.Drawing.Color.White
        Me.SearchPanel.Controls.Add(Me.WebsiteIcon)
        Me.SearchPanel.Controls.Add(Me.frmMainFormbtnRefresh)
        Me.SearchPanel.Controls.Add(Me.frmMainFormbtnStop)
        Me.SearchPanel.Controls.Add(Me.frmMainFormbtnBookmark)
        Me.SearchPanel.Controls.Add(Me.SearchField)
        Me.SearchPanel.Controls.Add(Me.frmMainFormbtnVoiceInput)
        Me.SearchPanel.Controls.Add(Me.frmMainFormbtnSearch)
        Me.SearchPanel.Location = New System.Drawing.Point(141, 16)
        Me.SearchPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchPanel.Name = "SearchPanel"
        Me.SearchPanel.Size = New System.Drawing.Size(1127, 28)
        Me.SearchPanel.TabIndex = 4
        '
        'WebsiteIcon
        '
        Me.WebsiteIcon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebsiteIcon.BackColor = System.Drawing.Color.White
        Me.WebsiteIcon.Location = New System.Drawing.Point(993, 1)
        Me.WebsiteIcon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WebsiteIcon.Name = "WebsiteIcon"
        Me.WebsiteIcon.Size = New System.Drawing.Size(27, 26)
        Me.WebsiteIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.WebsiteIcon.TabIndex = 8
        Me.WebsiteIcon.TabStop = False
        '
        'frmMainFormbtnRefresh
        '
        Me.frmMainFormbtnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.frmMainFormbtnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.frmMainFormbtnRefresh.Image = CType(resources.GetObject("frmMainFormbtnRefresh.Image"), System.Drawing.Image)
        Me.frmMainFormbtnRefresh.Location = New System.Drawing.Point(1045, 1)
        Me.frmMainFormbtnRefresh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmMainFormbtnRefresh.Name = "frmMainFormbtnRefresh"
        Me.frmMainFormbtnRefresh.Size = New System.Drawing.Size(27, 26)
        Me.frmMainFormbtnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.frmMainFormbtnRefresh.TabIndex = 7
        Me.frmMainFormbtnRefresh.TabStop = False
        '
        'frmMainFormbtnStop
        '
        Me.frmMainFormbtnStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.frmMainFormbtnStop.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.frmMainFormbtnStop.Image = CType(resources.GetObject("frmMainFormbtnStop.Image"), System.Drawing.Image)
        Me.frmMainFormbtnStop.Location = New System.Drawing.Point(1071, 1)
        Me.frmMainFormbtnStop.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmMainFormbtnStop.Name = "frmMainFormbtnStop"
        Me.frmMainFormbtnStop.Size = New System.Drawing.Size(27, 26)
        Me.frmMainFormbtnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.frmMainFormbtnStop.TabIndex = 7
        Me.frmMainFormbtnStop.TabStop = False
        '
        'frmMainFormbtnBookmark
        '
        Me.frmMainFormbtnBookmark.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.frmMainFormbtnBookmark.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.frmMainFormbtnBookmark.Image = CType(resources.GetObject("frmMainFormbtnBookmark.Image"), System.Drawing.Image)
        Me.frmMainFormbtnBookmark.Location = New System.Drawing.Point(1097, 1)
        Me.frmMainFormbtnBookmark.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmMainFormbtnBookmark.Name = "frmMainFormbtnBookmark"
        Me.frmMainFormbtnBookmark.Size = New System.Drawing.Size(28, 26)
        Me.frmMainFormbtnBookmark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.frmMainFormbtnBookmark.TabIndex = 7
        Me.frmMainFormbtnBookmark.TabStop = False
        '
        'SearchField
        '
        Me.SearchField.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchField.BackColor = System.Drawing.Color.White
        Me.SearchField.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchField.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.SearchField.ForeColor = System.Drawing.Color.Black
        Me.SearchField.FormattingEnabled = True
        Me.SearchField.Location = New System.Drawing.Point(51, 0)
        Me.SearchField.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchField.Name = "SearchField"
        Me.SearchField.Size = New System.Drawing.Size(995, 26)
        Me.SearchField.TabIndex = 6
        Me.SearchField.Text = "Search or enter address"
        '
        'frmMainFormbtnVoiceInput
        '
        Me.frmMainFormbtnVoiceInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.frmMainFormbtnVoiceInput.Image = CType(resources.GetObject("frmMainFormbtnVoiceInput.Image"), System.Drawing.Image)
        Me.frmMainFormbtnVoiceInput.Location = New System.Drawing.Point(27, 1)
        Me.frmMainFormbtnVoiceInput.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmMainFormbtnVoiceInput.Name = "frmMainFormbtnVoiceInput"
        Me.frmMainFormbtnVoiceInput.Size = New System.Drawing.Size(23, 26)
        Me.frmMainFormbtnVoiceInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.frmMainFormbtnVoiceInput.TabIndex = 5
        Me.frmMainFormbtnVoiceInput.TabStop = False
        '
        'frmMainFormbtnSearch
        '
        Me.frmMainFormbtnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.frmMainFormbtnSearch.Image = CType(resources.GetObject("frmMainFormbtnSearch.Image"), System.Drawing.Image)
        Me.frmMainFormbtnSearch.Location = New System.Drawing.Point(1, 1)
        Me.frmMainFormbtnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmMainFormbtnSearch.Name = "frmMainFormbtnSearch"
        Me.frmMainFormbtnSearch.Size = New System.Drawing.Size(27, 26)
        Me.frmMainFormbtnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.frmMainFormbtnSearch.TabIndex = 4
        Me.frmMainFormbtnSearch.TabStop = False
        '
        'frmMainFormbtnMenu
        '
        Me.frmMainFormbtnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.frmMainFormbtnMenu.BackColor = System.Drawing.Color.Transparent
        Me.frmMainFormbtnMenu.Image = CType(resources.GetObject("frmMainFormbtnMenu.Image"), System.Drawing.Image)
        Me.frmMainFormbtnMenu.Location = New System.Drawing.Point(1273, 14)
        Me.frmMainFormbtnMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmMainFormbtnMenu.Name = "frmMainFormbtnMenu"
        Me.frmMainFormbtnMenu.Size = New System.Drawing.Size(32, 32)
        Me.frmMainFormbtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.frmMainFormbtnMenu.TabIndex = 3
        Me.frmMainFormbtnMenu.TabStop = False
        '
        'frmMainFormbtnHome
        '
        Me.frmMainFormbtnHome.BackColor = System.Drawing.Color.Transparent
        Me.frmMainFormbtnHome.Dock = System.Windows.Forms.DockStyle.Left
        Me.frmMainFormbtnHome.Image = CType(resources.GetObject("frmMainFormbtnHome.Image"), System.Drawing.Image)
        Me.frmMainFormbtnHome.Location = New System.Drawing.Point(100, 0)
        Me.frmMainFormbtnHome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmMainFormbtnHome.Name = "frmMainFormbtnHome"
        Me.frmMainFormbtnHome.Size = New System.Drawing.Size(35, 60)
        Me.frmMainFormbtnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.frmMainFormbtnHome.TabIndex = 2
        Me.frmMainFormbtnHome.TabStop = False
        '
        'frmMainFormbtnForward
        '
        Me.frmMainFormbtnForward.BackColor = System.Drawing.Color.Transparent
        Me.frmMainFormbtnForward.Dock = System.Windows.Forms.DockStyle.Left
        Me.frmMainFormbtnForward.Image = CType(resources.GetObject("frmMainFormbtnForward.Image"), System.Drawing.Image)
        Me.frmMainFormbtnForward.Location = New System.Drawing.Point(60, 0)
        Me.frmMainFormbtnForward.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmMainFormbtnForward.Name = "frmMainFormbtnForward"
        Me.frmMainFormbtnForward.Size = New System.Drawing.Size(40, 60)
        Me.frmMainFormbtnForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.frmMainFormbtnForward.TabIndex = 1
        Me.frmMainFormbtnForward.TabStop = False
        '
        'frmMainFormbtnBackward
        '
        Me.frmMainFormbtnBackward.BackColor = System.Drawing.Color.Transparent
        Me.frmMainFormbtnBackward.Dock = System.Windows.Forms.DockStyle.Left
        Me.frmMainFormbtnBackward.Image = CType(resources.GetObject("frmMainFormbtnBackward.Image"), System.Drawing.Image)
        Me.frmMainFormbtnBackward.Location = New System.Drawing.Point(0, 0)
        Me.frmMainFormbtnBackward.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmMainFormbtnBackward.Name = "frmMainFormbtnBackward"
        Me.frmMainFormbtnBackward.Size = New System.Drawing.Size(60, 60)
        Me.frmMainFormbtnBackward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.frmMainFormbtnBackward.TabIndex = 0
        Me.frmMainFormbtnBackward.TabStop = False
        '
        'SearchWord
        '
        Me.SearchWord.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchWord.Location = New System.Drawing.Point(916, 16)
        Me.SearchWord.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchWord.Name = "SearchWord"
        Me.SearchWord.Size = New System.Drawing.Size(351, 28)
        Me.SearchWord.TabIndex = 5
        Me.SearchWord.Visible = False
        '
        'FormTitle
        '
        Me.FormTitle.AutoSize = True
        Me.FormTitle.BackColor = System.Drawing.Color.Transparent
        Me.FormTitle.Font = New System.Drawing.Font("Verdana", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormTitle.ForeColor = System.Drawing.Color.White
        Me.FormTitle.Location = New System.Drawing.Point(3, 5)
        Me.FormTitle.Name = "FormTitle"
        Me.FormTitle.Size = New System.Drawing.Size(232, 23)
        Me.FormTitle.TabIndex = 5
        Me.FormTitle.Text = "Jaguar Web Browser"
        '
        'TitlePanel
        '
        Me.TitlePanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitlePanel.BackColor = System.Drawing.Color.Black
        Me.TitlePanel.Controls.Add(Me.ResizeButton)
        Me.TitlePanel.Controls.Add(Me.MinimizeButton)
        Me.TitlePanel.Controls.Add(Me.CloseButton)
        Me.TitlePanel.Location = New System.Drawing.Point(1231, 5)
        Me.TitlePanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(83, 25)
        Me.TitlePanel.TabIndex = 4
        '
        'ResizeButton
        '
        Me.ResizeButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResizeButton.Image = Global.WindowsApplication1.My.Resources.Resources.Normal
        Me.ResizeButton.Location = New System.Drawing.Point(25, 0)
        Me.ResizeButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ResizeButton.Name = "ResizeButton"
        Me.ResizeButton.Size = New System.Drawing.Size(33, 25)
        Me.ResizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ResizeButton.TabIndex = 2
        Me.ResizeButton.TabStop = False
        '
        'MinimizeButton
        '
        Me.MinimizeButton.BackColor = System.Drawing.Color.Transparent
        Me.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.MinimizeButton.Image = CType(resources.GetObject("MinimizeButton.Image"), System.Drawing.Image)
        Me.MinimizeButton.Location = New System.Drawing.Point(0, 0)
        Me.MinimizeButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(25, 25)
        Me.MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MinimizeButton.TabIndex = 1
        Me.MinimizeButton.TabStop = False
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.Transparent
        Me.CloseButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.CloseButton.Image = CType(resources.GetObject("CloseButton.Image"), System.Drawing.Image)
        Me.CloseButton.Location = New System.Drawing.Point(58, 0)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(25, 25)
        Me.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CloseButton.TabIndex = 0
        Me.CloseButton.TabStop = False
        '
        'BookmarksBar
        '
        Me.BookmarksBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BookmarksBar.AutoSize = False
        Me.BookmarksBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.BookmarksBar.Dock = System.Windows.Forms.DockStyle.None
        Me.BookmarksBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BookmarksBar.ImageScalingSize = New System.Drawing.Size(16, 20)
        Me.BookmarksBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.BookmarksBar.Location = New System.Drawing.Point(5, 92)
        Me.BookmarksBar.Name = "BookmarksBar"
        Me.BookmarksBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.BookmarksBar.Size = New System.Drawing.Size(1311, 30)
        Me.BookmarksBar.TabIndex = 12
        Me.BookmarksBar.Text = "BookmarksBar1"
        '
        'OFD
        '
        Me.OFD.Filter = """HTML Files|*.html|Cascade Style Sheet|*.css|JavaScript Files|*.js|PHP Files|*.ph" &
    "p"""
        Me.OFD.Title = "Open File"
        '
        'SFD
        '
        Me.SFD.Title = "Save File"
        '
        'ToolTip1
        '
        Me.ToolTip1.Active = False
        Me.ToolTip1.AutomaticDelay = 0
        Me.ToolTip1.AutoPopDelay = 15000
        Me.ToolTip1.InitialDelay = 0
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 0
        '
        'MHPOFDImage
        '
        Me.MHPOFDImage.Filter = "JPEG Files| *.JPG|GIF Files|*.GIF|WIndows Bitmaps|*.BMP|PNG|*.png"
        '
        'MHPOFDVideo
        '
        Me.MHPOFDVideo.Filter = "MP4|*.mp4"
        '
        'MHPOFDSound
        '
        Me.MHPOFDSound.Filter = "MP3|*.mp3|WAV|*.wav"
        '
        'MHPbtnMoveObjectsMenu
        '
        Me.MHPbtnMoveObjectsMenu.BackColor = System.Drawing.SystemColors.Control
        Me.MHPbtnMoveObjectsMenu.DropShadowEnabled = False
        Me.MHPbtnMoveObjectsMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MHPbtnMoveObjectsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoveToolStripMenuItem, Me.SaveToolStripMenuItem, Me.RestoreToolStripMenuItem})
        Me.MHPbtnMoveObjectsMenu.Name = "MHPbtnMoveObjectsMenu"
        Me.MHPbtnMoveObjectsMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MHPbtnMoveObjectsMenu.ShowImageMargin = False
        Me.MHPbtnMoveObjectsMenu.ShowItemToolTips = False
        Me.MHPbtnMoveObjectsMenu.Size = New System.Drawing.Size(104, 76)
        '
        'MoveToolStripMenuItem
        '
        Me.MoveToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.MoveToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.MoveToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MoveToolStripMenuItem.Name = "MoveToolStripMenuItem"
        Me.MoveToolStripMenuItem.Size = New System.Drawing.Size(103, 24)
        Me.MoveToolStripMenuItem.Text = "Move"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.SaveToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(103, 24)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.RestoreToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.RestoreToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(103, 24)
        Me.RestoreToolStripMenuItem.Text = "Restore"
        '
        'MHPbtnInsertImageMenu
        '
        Me.MHPbtnInsertImageMenu.BackColor = System.Drawing.SystemColors.Control
        Me.MHPbtnInsertImageMenu.DropShadowEnabled = False
        Me.MHPbtnInsertImageMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MHPbtnInsertImageMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertImageToolStripMenuItem, Me.RestoreImageToolStripMenuItem})
        Me.MHPbtnInsertImageMenu.Name = "MHPbtnMoveObjectsMenu"
        Me.MHPbtnInsertImageMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MHPbtnInsertImageMenu.ShowImageMargin = False
        Me.MHPbtnInsertImageMenu.ShowItemToolTips = False
        Me.MHPbtnInsertImageMenu.Size = New System.Drawing.Size(112, 52)
        '
        'InsertImageToolStripMenuItem
        '
        Me.InsertImageToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.InsertImageToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.InsertImageToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.InsertImageToolStripMenuItem.Name = "InsertImageToolStripMenuItem"
        Me.InsertImageToolStripMenuItem.Size = New System.Drawing.Size(111, 24)
        Me.InsertImageToolStripMenuItem.Text = "Choose..."
        '
        'RestoreImageToolStripMenuItem
        '
        Me.RestoreImageToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.RestoreImageToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.RestoreImageToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.RestoreImageToolStripMenuItem.Name = "RestoreImageToolStripMenuItem"
        Me.RestoreImageToolStripMenuItem.Size = New System.Drawing.Size(111, 24)
        Me.RestoreImageToolStripMenuItem.Text = "Restore"
        '
        'MHPbtnInsertVideoMenu
        '
        Me.MHPbtnInsertVideoMenu.BackColor = System.Drawing.SystemColors.Control
        Me.MHPbtnInsertVideoMenu.DropShadowEnabled = False
        Me.MHPbtnInsertVideoMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MHPbtnInsertVideoMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertVideoToolStripMenuItem, Me.RestoreVideoToolStripMenuItem})
        Me.MHPbtnInsertVideoMenu.Name = "MHPbtnMoveObjectsMenu"
        Me.MHPbtnInsertVideoMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MHPbtnInsertVideoMenu.ShowImageMargin = False
        Me.MHPbtnInsertVideoMenu.ShowItemToolTips = False
        Me.MHPbtnInsertVideoMenu.Size = New System.Drawing.Size(112, 52)
        '
        'InsertVideoToolStripMenuItem
        '
        Me.InsertVideoToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.InsertVideoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.InsertVideoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.InsertVideoToolStripMenuItem.Name = "InsertVideoToolStripMenuItem"
        Me.InsertVideoToolStripMenuItem.Size = New System.Drawing.Size(111, 24)
        Me.InsertVideoToolStripMenuItem.Text = "Choose..."
        '
        'RestoreVideoToolStripMenuItem
        '
        Me.RestoreVideoToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.RestoreVideoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.RestoreVideoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.RestoreVideoToolStripMenuItem.Name = "RestoreVideoToolStripMenuItem"
        Me.RestoreVideoToolStripMenuItem.Size = New System.Drawing.Size(111, 24)
        Me.RestoreVideoToolStripMenuItem.Text = "Restore"
        '
        'MHPbtnInsertSoundMenu
        '
        Me.MHPbtnInsertSoundMenu.BackColor = System.Drawing.SystemColors.Control
        Me.MHPbtnInsertSoundMenu.DropShadowEnabled = False
        Me.MHPbtnInsertSoundMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MHPbtnInsertSoundMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChooseSoundToolStripMenuItem, Me.RestoreSoundToolStripMenuItem})
        Me.MHPbtnInsertSoundMenu.Name = "MHPbtnMoveObjectsMenu"
        Me.MHPbtnInsertSoundMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MHPbtnInsertSoundMenu.ShowImageMargin = False
        Me.MHPbtnInsertSoundMenu.ShowItemToolTips = False
        Me.MHPbtnInsertSoundMenu.Size = New System.Drawing.Size(112, 52)
        '
        'ChooseSoundToolStripMenuItem
        '
        Me.ChooseSoundToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.ChooseSoundToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ChooseSoundToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ChooseSoundToolStripMenuItem.Name = "ChooseSoundToolStripMenuItem"
        Me.ChooseSoundToolStripMenuItem.Size = New System.Drawing.Size(111, 24)
        Me.ChooseSoundToolStripMenuItem.Text = "Choose..."
        '
        'RestoreSoundToolStripMenuItem
        '
        Me.RestoreSoundToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.RestoreSoundToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.RestoreSoundToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.RestoreSoundToolStripMenuItem.Name = "RestoreSoundToolStripMenuItem"
        Me.RestoreSoundToolStripMenuItem.Size = New System.Drawing.Size(111, 24)
        Me.RestoreSoundToolStripMenuItem.Text = "Restore"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1321, 880)
        Me.Controls.Add(Me.Theme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MainForm"
        Me.Text = "Jaguar Web Browser"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme1.ResumeLayout(False)
        Me.Theme1.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.TabPage.ResumeLayout(False)
        Me.SettingsTab.ResumeLayout(False)
        Me.SettingsTabControl.ResumeLayout(False)
        Me.GeneralTabPage.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlatPanel10.ResumeLayout(False)
        Me.FlatPanel10.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.FlatPanel5.ResumeLayout(False)
        Me.FlatPanel5.PerformLayout()
        Me.FlatPanel4.ResumeLayout(False)
        CType(Me.PBSearchEnginesIcons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SetPagePanel.ResumeLayout(False)
        Me.SetPagePanel.PerformLayout()
        Me.FlatPanel3.ResumeLayout(False)
        Me.FlatPanel3.PerformLayout()
        Me.FlatPanel2.ResumeLayout(False)
        Me.GeneralSettingsTitlePanel.ResumeLayout(False)
        Me.GeneralSettingsTitlePanel.PerformLayout()
        Me.HistoryTabPage.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.FlatPanel6.ResumeLayout(False)
        Me.FlatPanel6.PerformLayout()
        Me.HistoryTitlePanel.ResumeLayout(False)
        Me.HistoryTitlePanel.PerformLayout()
        Me.BookmarksTabPage.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.FlatPanel7.ResumeLayout(False)
        Me.FlatPanel7.PerformLayout()
        Me.BookmarksTitlePanel.ResumeLayout(False)
        Me.BookmarksTitlePanel.PerformLayout()
        Me.DownloadsTabPage.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.FlatPanel8.ResumeLayout(False)
        Me.FlatPanel8.PerformLayout()
        Me.DownloadsTitlePanel.ResumeLayout(False)
        Me.DownloadsTitlePanel.PerformLayout()
        Me.CustomizeTabPage.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.FlatPanel1.ResumeLayout(False)
        CType(Me.LanguageIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlatPanel9.ResumeLayout(False)
        Me.CustomizeTitlePanel.ResumeLayout(False)
        Me.CustomizeTitlePanel.PerformLayout()
        Me.AboutTabPage.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        CType(Me.JaguarLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AboutTitlePanel.ResumeLayout(False)
        Me.AboutTitlePanel.PerformLayout()
        Me.HomeTabPage.ResumeLayout(False)
        Me.FlatRoundedPanel2.ResumeLayout(False)
        Me.JHPSearchFieldPanel.ResumeLayout(False)
        Me.JHPSearchFieldPanel.PerformLayout()
        CType(Me.JHPSearchEnginePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JHPBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WebDevTabPage.ResumeLayout(False)
        Me.JWDTTabControl.ResumeLayout(False)
        Me.WelcomeTabPage.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        CType(Me.JWDTLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FirstRunTabPage.ResumeLayout(False)
        Me.WelcomeTabControl.ResumeLayout(False)
        Me.Step1.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.FlatPanel12.ResumeLayout(False)
        Me.FlatPanel11.ResumeLayout(False)
        CType(Me.pbWelcomeLanguage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Step2.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Step3.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        CType(Me.Pic2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Step4.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        CType(Me.PIc3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Step5.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.MyHomePage.ResumeLayout(False)
        Me.MHPToolsPanel.ResumeLayout(False)
        Me.MHPBookmarksPanel.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        Me.MHPBookmarksToolsPanel.ResumeLayout(False)
        Me.MHPPanelAddBookmark.ResumeLayout(False)
        Me.MHPPanelAddBookmark.PerformLayout()
        Me.MHPSearchButtonPanel.ResumeLayout(False)
        Me.MHPSearchFieldPanel.ResumeLayout(False)
        Me.MHPSearchFieldPanel.PerformLayout()
        CType(Me.MHPSearchEnginePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MHPBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.SearchPanel.ResumeLayout(False)
        CType(Me.WebsiteIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmMainFormbtnRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmMainFormbtnStop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmMainFormbtnBookmark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmMainFormbtnVoiceInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmMainFormbtnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmMainFormbtnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmMainFormbtnHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmMainFormbtnForward, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmMainFormbtnBackward, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitlePanel.ResumeLayout(False)
        CType(Me.ResizeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinimizeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MHPbtnMoveObjectsMenu.ResumeLayout(False)
        Me.MHPbtnInsertImageMenu.ResumeLayout(False)
        Me.MHPbtnInsertVideoMenu.ResumeLayout(False)
        Me.MHPbtnInsertSoundMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme1 As WindowsApplication1.Theme
    Friend WithEvents TitlePanel As System.Windows.Forms.Panel
    Friend WithEvents FormTitle As WindowsApplication1.FormTitle
    Friend WithEvents MainPanel As System.Windows.Forms.Panel
    Friend WithEvents frmMainFormbtnMenu As WindowsApplication1.MenuButton
    Friend WithEvents frmMainFormbtnHome As WindowsApplication1.HomeButton
    Friend WithEvents frmMainFormbtnForward As WindowsApplication1.ForwardButton
    Friend WithEvents frmMainFormbtnBackward As WindowsApplication1.BackwardButton
    Friend WithEvents SearchPanel As WindowsApplication1.FlatPanel
    Friend WithEvents frmMainFormbtnRefresh As WindowsApplication1.RefreshButton
    Friend WithEvents frmMainFormbtnStop As WindowsApplication1.StopButton
    Friend WithEvents frmMainFormbtnBookmark As WindowsApplication1.BookmarkButton
    Friend WithEvents SearchField As WindowsApplication1.SearchField
    Friend WithEvents frmMainFormbtnVoiceInput As WindowsApplication1.VoiceInputButton
    Friend WithEvents frmMainFormbtnSearch As WindowsApplication1.SearchButton
    Friend WithEvents TabControl As WindowsApplication1.TabControl
    Friend WithEvents WebsiteIcon As System.Windows.Forms.PictureBox
    Friend WithEvents SideMenu As WindowsApplication1.SideMenu
    Friend WithEvents TabPage As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents HomeTabPage As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents SettingsTab As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents SettingsTabControl As VIBlend.WinForms.Controls.vTabControl
    Friend WithEvents GeneralTabPage As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GeneralSettingsTitlePanel As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents HistoryTabPage As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents frmSettingscmbOnStartup As System.Windows.Forms.ComboBox
    Friend WithEvents FlatPanel2 As WindowsApplication1.FlatPanel
    Friend WithEvents SetPagePanel As System.Windows.Forms.Panel
    Friend WithEvents FlatPanel3 As WindowsApplication1.FlatPanel
    Friend WithEvents frmSettingstxtStartupPageURL As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents frmSettingschkboxDefaultBrowser As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents FlatPanel4 As WindowsApplication1.FlatPanel
    Friend WithEvents frmSettingscmbSearchEngines As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PBSearchEnginesIcons As System.Windows.Forms.PictureBox
    Friend WithEvents frmSettingsbtnSetStartupPage As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents frmSettingsbtnSetHomepage As System.Windows.Forms.Button
    Friend WithEvents FlatPanel5 As WindowsApplication1.FlatPanel
    Friend WithEvents frmSettingstxtHomepageURL As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblMsg1 As System.Windows.Forms.Label
    Friend WithEvents lblMsg2 As System.Windows.Forms.Label
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents BookmarksTabPage As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents DownloadsTabPage As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents CustomizeTabPage As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents AboutTabPage As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents HistoryTitlePanel As System.Windows.Forms.Panel
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents BookmarksTitlePanel As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents DownloadsTitlePanel As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents CustomizeTitlePanel As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents AboutTitlePanel As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents FlatPanel6 As WindowsApplication1.FlatPanel
    Friend WithEvents frmSettingstxtSearchHistory As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents frmSettingsbtnClearHistory As System.Windows.Forms.Button
    Friend WithEvents frmSettingschklistHistory As System.Windows.Forms.CheckedListBox
    Friend WithEvents frmSettingschkboxSelectAllHistory As System.Windows.Forms.CheckBox
    Friend WithEvents FlatPanel7 As WindowsApplication1.FlatPanel
    Friend WithEvents frmSettingstxtSearchBookmark As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents frmSettingsbtnClearBookmarks As System.Windows.Forms.Button
    Friend WithEvents frmSettingschklistBookmarks As System.Windows.Forms.CheckedListBox
    Friend WithEvents frmSettingschkboxSelectAllBookmarks As System.Windows.Forms.CheckBox
    Friend WithEvents FlatPanel8 As WindowsApplication1.FlatPanel
    Friend WithEvents frmSettingstxtSearchDownload As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents frmSettingsbtnClearDownloads As System.Windows.Forms.Button
    Friend WithEvents frmSettingschklistDownloads As System.Windows.Forms.CheckedListBox
    Friend WithEvents frmSettingschkboxSelectAllDownloads As System.Windows.Forms.CheckBox
    Friend WithEvents FlatPanel9 As WindowsApplication1.FlatPanel
    Friend WithEvents frmSettingscmbCustomize As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents frmSettingschkboxVisableBookmarks As System.Windows.Forms.CheckBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents JaguarLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblFullScreen As System.Windows.Forms.Label
    Friend WithEvents SearchWord As WindowsApplication1.SearchWord
    Friend WithEvents JHPBackground As System.Windows.Forms.PictureBox
    Friend WithEvents FlatRoundedPanel2 As WindowsApplication1.FlatRoundedPanel
    Friend WithEvents JHPSearchButton As System.Windows.Forms.Button
    Friend WithEvents JHPSearchFieldPanel As WindowsApplication1.FlatRoundedPanel
    Friend WithEvents JHPSearchField As System.Windows.Forms.TextBox
    Friend WithEvents JHPSearchEnginePic As System.Windows.Forms.PictureBox
    Friend WithEvents JHPCmbSearchEngines As System.Windows.Forms.ComboBox
    Friend WithEvents WebDevTabPage As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents BookmarksBar As WindowsApplication1.BookmarksBar
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents FlatPanel1 As WindowsApplication1.FlatPanel
    Friend WithEvents LanguageIcon As System.Windows.Forms.PictureBox
    Friend WithEvents frmSettingscmbLanguages As System.Windows.Forms.ComboBox
    Friend WithEvents WebBrowser As EO.WinForm.WebControl
    Friend WithEvents WebView As EO.WebBrowser.WebView
    Friend WithEvents ResizeButton As PictureBox
    Friend WithEvents MinimizeButton As MinimizeButton
    Friend WithEvents CloseButton As CloseButton
    Friend WithEvents JWDTTabControl As VIBlend.WinForms.Controls.vTabControl
    Friend WithEvents WelcomeTabPage As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents StartPagePanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RecentFilesListBox As ListBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label33 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblOpenFile As Label
    Friend WithEvents lblNewFile As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents MaskedTextBox As TextBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label34 As Label
    Friend WithEvents JWDTLogo As PictureBox
    Friend WithEvents OFD As OpenFileDialog
    Friend WithEvents SFD As SaveFileDialog
    Friend WithEvents frmSettingsoptLemmeSave As RadioButton
    Friend WithEvents frmSettingsoptSaveToLocation As RadioButton
    Friend WithEvents frmSettingslblDownloads As Label
    Friend WithEvents frmSettingsDownloadFolderBrowser As FolderBrowserDialog
    Friend WithEvents FlatPanel10 As FlatPanel
    Friend WithEvents frmSettingstxtSaveLocation As TextBox
    Friend WithEvents frmSettingsbtnFolderBrowse As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents FirstRunTabPage As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents WelcomeTabControl As VIBlend.WinForms.Controls.vTabControl
    Friend WithEvents Step1 As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents Step2 As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents Step3 As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents Step4 As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents Step5 As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Label37 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents FlatPanel11 As FlatPanel
    Friend WithEvents pbWelcomeLanguage As PictureBox
    Friend WithEvents cmbWelcomeLanguage As ComboBox
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents FlatPanel12 As FlatPanel
    Friend WithEvents cmbWelcomeTheme As ComboBox
    Friend WithEvents btnNext1 As Button
    Friend WithEvents Pic1 As PictureBox
    Friend WithEvents Label42 As Label
    Friend WithEvents Pic2 As PictureBox
    Friend WithEvents Label43 As Label
    Friend WithEvents btnNext2 As Button
    Friend WithEvents btnNext3 As Button
    Friend WithEvents btnNext4 As Button
    Friend WithEvents PIc3 As PictureBox
    Friend WithEvents Label44 As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents btnBack1 As Button
    Friend WithEvents btnBack2 As Button
    Friend WithEvents btnBack3 As Button
    Friend WithEvents btnFinish As Button
    Friend WithEvents btnBack4 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents MyHomePage As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents MHPBackground As PictureBox
    Friend WithEvents MHPSearchButtonPanel As FlatRoundedPanel
    Friend WithEvents MHPSearchButton As Button
    Friend WithEvents MHPSearchFieldPanel As FlatRoundedPanel
    Friend WithEvents MHPSearchField As TextBox
    Friend WithEvents MHPSearchEnginePic As PictureBox
    Friend WithEvents MHPCmbSearchEngines As ComboBox
    Friend WithEvents MHPbtnShowHideBookmarksPanel As Button
    Friend WithEvents MHPbtnShowTools As Button
    Friend WithEvents MHPToolsPanel As Panel
    Friend WithEvents MHPBookmarksPanel As Panel
    Friend WithEvents MHPBookmarksToolsPanel As Panel
    Friend WithEvents MHPPanelAddBookmark As Panel
    Friend WithEvents MHPbtnAddBookmarkMenu As Button
    Friend WithEvents Panel19 As Panel
    Friend WithEvents MHPbtnBookmarksForward As Button
    Friend WithEvents MHPbtnBookmarksBackward As Button
    Friend WithEvents MHPbtnInsertImage As Button
    Friend WithEvents MHPbtnInsertVideo As Button
    Friend WithEvents MHPbtnInsertSound As Button
    Friend WithEvents MHPbtnMoveObjects As Button
    Friend WithEvents MHPOFDImage As OpenFileDialog
    Friend WithEvents MHPOFDVideo As OpenFileDialog
    Friend WithEvents MHPOFDSound As OpenFileDialog
    Friend WithEvents MHPbtnMoveObjectsMenu As ContextMenuStrip
    Friend WithEvents MoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MHPbtnInsertImageMenu As ContextMenuStrip
    Friend WithEvents InsertImageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestoreImageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MHPbtnInsertVideoMenu As ContextMenuStrip
    Friend WithEvents InsertVideoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestoreVideoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MHPbtnInsertSoundMenu As ContextMenuStrip
    Friend WithEvents ChooseSoundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestoreSoundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MHPFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents Label48 As Label
    Friend WithEvents MHPtxtBookmarkName As TextBox
    Friend WithEvents MHPtxtBookmarkURL As TextBox
    Friend WithEvents Label49 As Label
    Friend WithEvents MHPbtnAddBookmark As Button
End Class
