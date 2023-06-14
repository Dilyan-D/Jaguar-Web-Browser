<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncognitoForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IncognitoForm))
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Theme1 = New WindowsApplication1.Theme()
        Me.IncognitoSideMenu = New WindowsApplication1.IncognitoSideMenu()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.SearchPanel = New WindowsApplication1.FlatPanel()
        Me.WebsiteIcon = New System.Windows.Forms.PictureBox()
        Me.frmIncognitoWindowFormbtnRefresh = New WindowsApplication1.RefreshButton()
        Me.frmIncognitoWindowFormbtnStop = New WindowsApplication1.StopButton()
        Me.SearchField = New WindowsApplication1.SearchField()
        Me.frmIncognitoWindowFormbtnVoiceInput = New WindowsApplication1.VoiceInputButton()
        Me.frmIncognitoWindowFormbtnSearch = New WindowsApplication1.SearchButton()
        Me.frmIncognitoWindowFormbtnMenu = New WindowsApplication1.MenuButton()
        Me.frmIncognitoWindowFormbtnHome = New WindowsApplication1.HomeButton()
        Me.frmIncognitoWindowFormbtnForward = New WindowsApplication1.ForwardButton()
        Me.frmIncognitoWindowFormbtnBackward = New WindowsApplication1.BackwardButton()
        Me.SearchWord = New WindowsApplication1.SearchWord()
        Me.lblFullScreen = New System.Windows.Forms.Label()
        Me.FormTitle = New WindowsApplication1.FormTitle()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.ResizeButton = New System.Windows.Forms.PictureBox()
        Me.MinimizeButton = New WindowsApplication1.MinimizeButton()
        Me.CloseButton = New WindowsApplication1.CloseButton()
        Me.IncognitoTabControl = New WindowsApplication1.IncognitoTabControl()
        Me.TabPage = New VIBlend.WinForms.Controls.vTabPage()
        Me.IncognitoWebBrowser = New EO.WinForm.WebControl()
        Me.IncognitoWebView = New EO.WebBrowser.WebView()
        Me.IncognitoTabPage = New VIBlend.WinForms.Controls.vTabPage()
        Me.IncognitoPanel = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.JIPSearchFieldPanel = New WindowsApplication1.FlatRoundedPanel()
        Me.JIPSearchField = New System.Windows.Forms.TextBox()
        Me.JIPSearchEnginePic = New System.Windows.Forms.PictureBox()
        Me.JIPCmbSearchEngines = New System.Windows.Forms.ComboBox()
        Me.FlatRoundedPanel2 = New WindowsApplication1.FlatRoundedPanel()
        Me.JIPSearchButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Theme1.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.SearchPanel.SuspendLayout()
        CType(Me.WebsiteIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmIncognitoWindowFormbtnRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmIncognitoWindowFormbtnStop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmIncognitoWindowFormbtnVoiceInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmIncognitoWindowFormbtnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmIncognitoWindowFormbtnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmIncognitoWindowFormbtnHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmIncognitoWindowFormbtnForward, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmIncognitoWindowFormbtnBackward, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitlePanel.SuspendLayout()
        CType(Me.ResizeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinimizeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IncognitoTabControl.SuspendLayout()
        Me.TabPage.SuspendLayout()
        Me.IncognitoTabPage.SuspendLayout()
        Me.IncognitoPanel.SuspendLayout()
        Me.JIPSearchFieldPanel.SuspendLayout()
        CType(Me.JIPSearchEnginePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlatRoundedPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer
        '
        Me.Timer.Interval = 5000
        '
        'Theme1
        '
        Me.Theme1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Theme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Theme1.Controls.Add(Me.IncognitoSideMenu)
        Me.Theme1.Controls.Add(Me.MainPanel)
        Me.Theme1.Controls.Add(Me.lblFullScreen)
        Me.Theme1.Controls.Add(Me.FormTitle)
        Me.Theme1.Controls.Add(Me.TitlePanel)
        Me.Theme1.Controls.Add(Me.IncognitoTabControl)
        Me.Theme1.Customization = "AAAA//////8="
        Me.Theme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Theme1.Image = Nothing
        Me.Theme1.Location = New System.Drawing.Point(0, 0)
        Me.Theme1.Movable = True
        Me.Theme1.Name = "Theme1"
        Me.Theme1.NoRounding = False
        Me.Theme1.Sizable = True
        Me.Theme1.Size = New System.Drawing.Size(1301, 776)
        Me.Theme1.SmartBounds = True
        Me.Theme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.Theme1.TabIndex = 0
        Me.Theme1.Text = "Theme1"
        Me.Theme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme1.Transparent = False
        '
        'IncognitoSideMenu
        '
        Me.IncognitoSideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.IncognitoSideMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.IncognitoSideMenu.Location = New System.Drawing.Point(-355, 120)
        Me.IncognitoSideMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.IncognitoSideMenu.Name = "IncognitoSideMenu"
        Me.IncognitoSideMenu.Size = New System.Drawing.Size(355, 2000)
        Me.IncognitoSideMenu.TabIndex = 16
        '
        'MainPanel
        '
        Me.MainPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.MainPanel.Controls.Add(Me.SearchPanel)
        Me.MainPanel.Controls.Add(Me.frmIncognitoWindowFormbtnMenu)
        Me.MainPanel.Controls.Add(Me.frmIncognitoWindowFormbtnHome)
        Me.MainPanel.Controls.Add(Me.frmIncognitoWindowFormbtnForward)
        Me.MainPanel.Controls.Add(Me.frmIncognitoWindowFormbtnBackward)
        Me.MainPanel.Controls.Add(Me.SearchWord)
        Me.MainPanel.Location = New System.Drawing.Point(6, 32)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1291, 60)
        Me.MainPanel.TabIndex = 14
        '
        'SearchPanel
        '
        Me.SearchPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchPanel.BackColor = System.Drawing.Color.White
        Me.SearchPanel.Controls.Add(Me.WebsiteIcon)
        Me.SearchPanel.Controls.Add(Me.frmIncognitoWindowFormbtnRefresh)
        Me.SearchPanel.Controls.Add(Me.frmIncognitoWindowFormbtnStop)
        Me.SearchPanel.Controls.Add(Me.SearchField)
        Me.SearchPanel.Controls.Add(Me.frmIncognitoWindowFormbtnVoiceInput)
        Me.SearchPanel.Controls.Add(Me.frmIncognitoWindowFormbtnSearch)
        Me.SearchPanel.Location = New System.Drawing.Point(141, 16)
        Me.SearchPanel.Name = "SearchPanel"
        Me.SearchPanel.Size = New System.Drawing.Size(1106, 28)
        Me.SearchPanel.TabIndex = 4
        '
        'WebsiteIcon
        '
        Me.WebsiteIcon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebsiteIcon.BackColor = System.Drawing.Color.White
        Me.WebsiteIcon.Location = New System.Drawing.Point(1004, 1)
        Me.WebsiteIcon.Name = "WebsiteIcon"
        Me.WebsiteIcon.Size = New System.Drawing.Size(26, 26)
        Me.WebsiteIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.WebsiteIcon.TabIndex = 8
        Me.WebsiteIcon.TabStop = False
        '
        'frmIncognitoWindowFormbtnRefresh
        '
        Me.frmIncognitoWindowFormbtnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.frmIncognitoWindowFormbtnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.frmIncognitoWindowFormbtnRefresh.Image = CType(resources.GetObject("frmIncognitoWindowFormbtnRefresh.Image"), System.Drawing.Image)
        Me.frmIncognitoWindowFormbtnRefresh.Location = New System.Drawing.Point(1053, 1)
        Me.frmIncognitoWindowFormbtnRefresh.Name = "frmIncognitoWindowFormbtnRefresh"
        Me.frmIncognitoWindowFormbtnRefresh.Size = New System.Drawing.Size(26, 26)
        Me.frmIncognitoWindowFormbtnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.frmIncognitoWindowFormbtnRefresh.TabIndex = 7
        Me.frmIncognitoWindowFormbtnRefresh.TabStop = False
        '
        'frmIncognitoWindowFormbtnStop
        '
        Me.frmIncognitoWindowFormbtnStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.frmIncognitoWindowFormbtnStop.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.frmIncognitoWindowFormbtnStop.Image = CType(resources.GetObject("frmIncognitoWindowFormbtnStop.Image"), System.Drawing.Image)
        Me.frmIncognitoWindowFormbtnStop.Location = New System.Drawing.Point(1079, 1)
        Me.frmIncognitoWindowFormbtnStop.Name = "frmIncognitoWindowFormbtnStop"
        Me.frmIncognitoWindowFormbtnStop.Size = New System.Drawing.Size(26, 26)
        Me.frmIncognitoWindowFormbtnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.frmIncognitoWindowFormbtnStop.TabIndex = 7
        Me.frmIncognitoWindowFormbtnStop.TabStop = False
        '
        'SearchField
        '
        Me.SearchField.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchField.BackColor = System.Drawing.Color.White
        Me.SearchField.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchField.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SearchField.ForeColor = System.Drawing.Color.Silver
        Me.SearchField.FormattingEnabled = True
        Me.SearchField.Location = New System.Drawing.Point(51, 0)
        Me.SearchField.Name = "SearchField"
        Me.SearchField.Size = New System.Drawing.Size(1002, 28)
        Me.SearchField.TabIndex = 6
        Me.SearchField.Text = "Search or enter adress"
        '
        'frmIncognitoWindowFormbtnVoiceInput
        '
        Me.frmIncognitoWindowFormbtnVoiceInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.frmIncognitoWindowFormbtnVoiceInput.Image = CType(resources.GetObject("frmIncognitoWindowFormbtnVoiceInput.Image"), System.Drawing.Image)
        Me.frmIncognitoWindowFormbtnVoiceInput.Location = New System.Drawing.Point(26, 1)
        Me.frmIncognitoWindowFormbtnVoiceInput.Name = "frmIncognitoWindowFormbtnVoiceInput"
        Me.frmIncognitoWindowFormbtnVoiceInput.Size = New System.Drawing.Size(23, 26)
        Me.frmIncognitoWindowFormbtnVoiceInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.frmIncognitoWindowFormbtnVoiceInput.TabIndex = 5
        Me.frmIncognitoWindowFormbtnVoiceInput.TabStop = False
        '
        'frmIncognitoWindowFormbtnSearch
        '
        Me.frmIncognitoWindowFormbtnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.frmIncognitoWindowFormbtnSearch.Image = CType(resources.GetObject("frmIncognitoWindowFormbtnSearch.Image"), System.Drawing.Image)
        Me.frmIncognitoWindowFormbtnSearch.Location = New System.Drawing.Point(1, 1)
        Me.frmIncognitoWindowFormbtnSearch.Name = "frmIncognitoWindowFormbtnSearch"
        Me.frmIncognitoWindowFormbtnSearch.Size = New System.Drawing.Size(26, 26)
        Me.frmIncognitoWindowFormbtnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.frmIncognitoWindowFormbtnSearch.TabIndex = 4
        Me.frmIncognitoWindowFormbtnSearch.TabStop = False
        '
        'frmIncognitoWindowFormbtnMenu
        '
        Me.frmIncognitoWindowFormbtnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.frmIncognitoWindowFormbtnMenu.BackColor = System.Drawing.Color.Transparent
        Me.frmIncognitoWindowFormbtnMenu.Image = CType(resources.GetObject("frmIncognitoWindowFormbtnMenu.Image"), System.Drawing.Image)
        Me.frmIncognitoWindowFormbtnMenu.Location = New System.Drawing.Point(1253, 14)
        Me.frmIncognitoWindowFormbtnMenu.Name = "frmIncognitoWindowFormbtnMenu"
        Me.frmIncognitoWindowFormbtnMenu.Size = New System.Drawing.Size(32, 32)
        Me.frmIncognitoWindowFormbtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.frmIncognitoWindowFormbtnMenu.TabIndex = 3
        Me.frmIncognitoWindowFormbtnMenu.TabStop = False
        '
        'frmIncognitoWindowFormbtnHome
        '
        Me.frmIncognitoWindowFormbtnHome.BackColor = System.Drawing.Color.Transparent
        Me.frmIncognitoWindowFormbtnHome.Dock = System.Windows.Forms.DockStyle.Left
        Me.frmIncognitoWindowFormbtnHome.Image = CType(resources.GetObject("frmIncognitoWindowFormbtnHome.Image"), System.Drawing.Image)
        Me.frmIncognitoWindowFormbtnHome.Location = New System.Drawing.Point(100, 0)
        Me.frmIncognitoWindowFormbtnHome.Name = "frmIncognitoWindowFormbtnHome"
        Me.frmIncognitoWindowFormbtnHome.Size = New System.Drawing.Size(35, 60)
        Me.frmIncognitoWindowFormbtnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.frmIncognitoWindowFormbtnHome.TabIndex = 2
        Me.frmIncognitoWindowFormbtnHome.TabStop = False
        '
        'frmIncognitoWindowFormbtnForward
        '
        Me.frmIncognitoWindowFormbtnForward.BackColor = System.Drawing.Color.Transparent
        Me.frmIncognitoWindowFormbtnForward.Dock = System.Windows.Forms.DockStyle.Left
        Me.frmIncognitoWindowFormbtnForward.Image = CType(resources.GetObject("frmIncognitoWindowFormbtnForward.Image"), System.Drawing.Image)
        Me.frmIncognitoWindowFormbtnForward.Location = New System.Drawing.Point(60, 0)
        Me.frmIncognitoWindowFormbtnForward.Name = "frmIncognitoWindowFormbtnForward"
        Me.frmIncognitoWindowFormbtnForward.Size = New System.Drawing.Size(40, 60)
        Me.frmIncognitoWindowFormbtnForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.frmIncognitoWindowFormbtnForward.TabIndex = 1
        Me.frmIncognitoWindowFormbtnForward.TabStop = False
        '
        'frmIncognitoWindowFormbtnBackward
        '
        Me.frmIncognitoWindowFormbtnBackward.BackColor = System.Drawing.Color.Transparent
        Me.frmIncognitoWindowFormbtnBackward.Dock = System.Windows.Forms.DockStyle.Left
        Me.frmIncognitoWindowFormbtnBackward.Image = CType(resources.GetObject("frmIncognitoWindowFormbtnBackward.Image"), System.Drawing.Image)
        Me.frmIncognitoWindowFormbtnBackward.Location = New System.Drawing.Point(0, 0)
        Me.frmIncognitoWindowFormbtnBackward.Name = "frmIncognitoWindowFormbtnBackward"
        Me.frmIncognitoWindowFormbtnBackward.Size = New System.Drawing.Size(60, 60)
        Me.frmIncognitoWindowFormbtnBackward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.frmIncognitoWindowFormbtnBackward.TabIndex = 0
        Me.frmIncognitoWindowFormbtnBackward.TabStop = False
        '
        'SearchWord
        '
        Me.SearchWord.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchWord.Location = New System.Drawing.Point(896, 16)
        Me.SearchWord.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchWord.Name = "SearchWord"
        Me.SearchWord.Size = New System.Drawing.Size(351, 28)
        Me.SearchWord.TabIndex = 5
        Me.SearchWord.Visible = False
        '
        'lblFullScreen
        '
        Me.lblFullScreen.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFullScreen.AutoSize = True
        Me.lblFullScreen.BackColor = System.Drawing.Color.Transparent
        Me.lblFullScreen.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lblFullScreen.ForeColor = System.Drawing.Color.White
        Me.lblFullScreen.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFullScreen.Location = New System.Drawing.Point(398, 3)
        Me.lblFullScreen.Name = "lblFullScreen"
        Me.lblFullScreen.Size = New System.Drawing.Size(561, 23)
        Me.lblFullScreen.TabIndex = 13
        Me.lblFullScreen.Text = "You are now in Fullscreen Mode. Press ESC to exit."
        Me.lblFullScreen.Visible = False
        '
        'FormTitle
        '
        Me.FormTitle.AutoSize = True
        Me.FormTitle.BackColor = System.Drawing.Color.Transparent
        Me.FormTitle.Font = New System.Drawing.Font("Verdana", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.FormTitle.ForeColor = System.Drawing.Color.White
        Me.FormTitle.Location = New System.Drawing.Point(5, 3)
        Me.FormTitle.Name = "FormTitle"
        Me.FormTitle.Size = New System.Drawing.Size(232, 23)
        Me.FormTitle.TabIndex = 12
        Me.FormTitle.Text = "Jaguar Web Browser"
        '
        'TitlePanel
        '
        Me.TitlePanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitlePanel.BackColor = System.Drawing.Color.Black
        Me.TitlePanel.Controls.Add(Me.ResizeButton)
        Me.TitlePanel.Controls.Add(Me.MinimizeButton)
        Me.TitlePanel.Controls.Add(Me.CloseButton)
        Me.TitlePanel.Location = New System.Drawing.Point(1211, 5)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(82, 25)
        Me.TitlePanel.TabIndex = 5
        '
        'ResizeButton
        '
        Me.ResizeButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResizeButton.Image = Global.WindowsApplication1.My.Resources.Resources.Normal
        Me.ResizeButton.Location = New System.Drawing.Point(25, 0)
        Me.ResizeButton.Name = "ResizeButton"
        Me.ResizeButton.Size = New System.Drawing.Size(32, 25)
        Me.ResizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ResizeButton.TabIndex = 3
        Me.ResizeButton.TabStop = False
        '
        'MinimizeButton
        '
        Me.MinimizeButton.BackColor = System.Drawing.Color.Transparent
        Me.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.MinimizeButton.Image = CType(resources.GetObject("MinimizeButton.Image"), System.Drawing.Image)
        Me.MinimizeButton.Location = New System.Drawing.Point(0, 0)
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
        Me.CloseButton.Location = New System.Drawing.Point(57, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(25, 25)
        Me.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CloseButton.TabIndex = 0
        Me.CloseButton.TabStop = False
        '
        'IncognitoTabControl
        '
        Me.IncognitoTabControl.AllowAnimations = True
        Me.IncognitoTabControl.AllowDragDrop = True
        Me.IncognitoTabControl.AllowDrop = True
        Me.IncognitoTabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IncognitoTabControl.Controls.Add(Me.TabPage)
        Me.IncognitoTabControl.Controls.Add(Me.IncognitoTabPage)
        Me.IncognitoTabControl.EnableCloseButtons = True
        Me.IncognitoTabControl.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.IncognitoTabControl.ForeColor = System.Drawing.Color.Black
        Me.IncognitoTabControl.Location = New System.Drawing.Point(6, 92)
        Me.IncognitoTabControl.Name = "IncognitoTabControl"
        Me.IncognitoTabControl.Padding = New System.Windows.Forms.Padding(0, 27, 0, 0)
        Me.IncognitoTabControl.ShowCloseButtonOnSelectedTabOnly = False
        Me.IncognitoTabControl.Size = New System.Drawing.Size(1291, 678)
        Me.IncognitoTabControl.TabAlignment = VIBlend.WinForms.Controls.vTabPageAlignment.Top
        Me.IncognitoTabControl.TabIndex = 17
        Me.IncognitoTabControl.TabPages.Add(Me.TabPage)
        Me.IncognitoTabControl.TabPages.Add(Me.IncognitoTabPage)
        Me.IncognitoTabControl.TabsAreaBackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.IncognitoTabControl.TabsInitialOffset = 2
        Me.IncognitoTabControl.TabsShape = VIBlend.WinForms.Controls.TabsShape.Chrome
        Me.IncognitoTabControl.TabsSpacing = -15
        Me.IncognitoTabControl.TitleHeight = 27
        Me.IncognitoTabControl.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010BLACK
        '
        'TabPage
        '
        Me.TabPage.Controls.Add(Me.IncognitoWebBrowser)
        Me.TabPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPage.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.TabPage.Location = New System.Drawing.Point(0, 27)
        Me.TabPage.Name = "TabPage"
        Me.TabPage.Padding = New System.Windows.Forms.Padding(0)
        Me.TabPage.SelectedTextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.TabPage.Size = New System.Drawing.Size(1291, 651)
        Me.TabPage.TabIndex = 4
        Me.TabPage.Text = "New Tab"
        Me.TabPage.TextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.TabPage.TooltipText = "TabPage"
        Me.TabPage.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010BLACK
        Me.TabPage.Visible = False
        '
        'IncognitoWebBrowser
        '
        Me.IncognitoWebBrowser.BackColor = System.Drawing.Color.White
        Me.IncognitoWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IncognitoWebBrowser.Location = New System.Drawing.Point(4, 4)
        Me.IncognitoWebBrowser.Name = "IncognitoWebBrowser"
        Me.IncognitoWebBrowser.Size = New System.Drawing.Size(1283, 643)
        Me.IncognitoWebBrowser.TabIndex = 0
        Me.IncognitoWebBrowser.Text = "WebControl1"
        Me.IncognitoWebBrowser.WebView = Me.IncognitoWebView
        '
        'IncognitoWebView
        '
        '
        'IncognitoTabPage
        '
        Me.IncognitoTabPage.Controls.Add(Me.IncognitoPanel)
        Me.IncognitoTabPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IncognitoTabPage.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.IncognitoTabPage.HeaderHeight = 27
        Me.IncognitoTabPage.HeaderWidth = 200
        Me.IncognitoTabPage.Location = New System.Drawing.Point(0, 27)
        Me.IncognitoTabPage.Name = "IncognitoTabPage"
        Me.IncognitoTabPage.Padding = New System.Windows.Forms.Padding(0)
        Me.IncognitoTabPage.SelectedTextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.IncognitoTabPage.Size = New System.Drawing.Size(1291, 651)
        Me.IncognitoTabPage.TabIndex = 5
        Me.IncognitoTabPage.Text = "Incognito Mode"
        Me.IncognitoTabPage.TextFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.IncognitoTabPage.TooltipText = "TabPage"
        Me.IncognitoTabPage.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010BLACK
        Me.IncognitoTabPage.Visible = False
        '
        'IncognitoPanel
        '
        Me.IncognitoPanel.BackColor = System.Drawing.Color.Indigo
        Me.IncognitoPanel.Controls.Add(Me.Label10)
        Me.IncognitoPanel.Controls.Add(Me.Label9)
        Me.IncognitoPanel.Controls.Add(Me.Label8)
        Me.IncognitoPanel.Controls.Add(Me.Label7)
        Me.IncognitoPanel.Controls.Add(Me.Label3)
        Me.IncognitoPanel.Controls.Add(Me.JIPSearchFieldPanel)
        Me.IncognitoPanel.Controls.Add(Me.FlatRoundedPanel2)
        Me.IncognitoPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IncognitoPanel.Location = New System.Drawing.Point(4, 4)
        Me.IncognitoPanel.Name = "IncognitoPanel"
        Me.IncognitoPanel.Size = New System.Drawing.Size(1283, 643)
        Me.IncognitoPanel.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.Font = New System.Drawing.Font("Verdana", 15.0!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(230, 385)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(960, 139)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Please note, that although you're in incognito mode, your Internet service provid" &
    "ier can still track your browsing." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Happy surfing! - Team JB" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 15.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(654, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(177, 93)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "• Bookmarks" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• History" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• Downloads"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 15.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(270, 253)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(202, 93)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "• Visited Pages" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• Searches" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• Temp Files"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 15.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(236, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(724, 31)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "While in Incognito Mode, Jaguar Browser does not save:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 25.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(233, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(817, 51)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Welcome to Incognito Browsing Mode"
        '
        'JIPSearchFieldPanel
        '
        Me.JIPSearchFieldPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.JIPSearchFieldPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.JIPSearchFieldPanel.BorderColor = System.Drawing.Color.Black
        Me.JIPSearchFieldPanel.Controls.Add(Me.JIPSearchField)
        Me.JIPSearchFieldPanel.Controls.Add(Me.JIPSearchEnginePic)
        Me.JIPSearchFieldPanel.Controls.Add(Me.JIPCmbSearchEngines)
        Me.JIPSearchFieldPanel.Edge = 10
        Me.JIPSearchFieldPanel.Location = New System.Drawing.Point(242, 131)
        Me.JIPSearchFieldPanel.Name = "JIPSearchFieldPanel"
        Me.JIPSearchFieldPanel.Size = New System.Drawing.Size(804, 52)
        Me.JIPSearchFieldPanel.TabIndex = 8
        '
        'JIPSearchField
        '
        Me.JIPSearchField.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.JIPSearchField.BackColor = System.Drawing.Color.WhiteSmoke
        Me.JIPSearchField.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.JIPSearchField.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.JIPSearchField.Location = New System.Drawing.Point(13, 14)
        Me.JIPSearchField.Name = "JIPSearchField"
        Me.JIPSearchField.Size = New System.Drawing.Size(723, 25)
        Me.JIPSearchField.TabIndex = 4
        '
        'JIPSearchEnginePic
        '
        Me.JIPSearchEnginePic.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.JIPSearchEnginePic.BackColor = System.Drawing.Color.Transparent
        Me.JIPSearchEnginePic.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.JIPSearchEnginePic.Location = New System.Drawing.Point(745, 15)
        Me.JIPSearchEnginePic.Name = "JIPSearchEnginePic"
        Me.JIPSearchEnginePic.Size = New System.Drawing.Size(22, 22)
        Me.JIPSearchEnginePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.JIPSearchEnginePic.TabIndex = 7
        Me.JIPSearchEnginePic.TabStop = False
        '
        'JIPCmbSearchEngines
        '
        Me.JIPCmbSearchEngines.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.JIPCmbSearchEngines.BackColor = System.Drawing.Color.WhiteSmoke
        Me.JIPCmbSearchEngines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.JIPCmbSearchEngines.DropDownWidth = 80
        Me.JIPCmbSearchEngines.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.JIPCmbSearchEngines.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.JIPCmbSearchEngines.ForeColor = System.Drawing.Color.Black
        Me.JIPCmbSearchEngines.FormattingEnabled = True
        Me.JIPCmbSearchEngines.Items.AddRange(New Object() {"Google", "Bing ", "Yahoo", "Youtube", "Wikipedia"})
        Me.JIPCmbSearchEngines.Location = New System.Drawing.Point(742, 14)
        Me.JIPCmbSearchEngines.Name = "JIPCmbSearchEngines"
        Me.JIPCmbSearchEngines.Size = New System.Drawing.Size(49, 24)
        Me.JIPCmbSearchEngines.TabIndex = 6
        '
        'FlatRoundedPanel2
        '
        Me.FlatRoundedPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlatRoundedPanel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FlatRoundedPanel2.BorderColor = System.Drawing.Color.Black
        Me.FlatRoundedPanel2.Controls.Add(Me.JIPSearchButton)
        Me.FlatRoundedPanel2.Edge = 10
        Me.FlatRoundedPanel2.Location = New System.Drawing.Point(1052, 131)
        Me.FlatRoundedPanel2.Name = "FlatRoundedPanel2"
        Me.FlatRoundedPanel2.Size = New System.Drawing.Size(52, 52)
        Me.FlatRoundedPanel2.TabIndex = 9
        '
        'JIPSearchButton
        '
        Me.JIPSearchButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.JIPSearchButton.FlatAppearance.BorderSize = 0
        Me.JIPSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.JIPSearchButton.Image = Global.WindowsApplication1.My.Resources.Resources.Search
        Me.JIPSearchButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.JIPSearchButton.Location = New System.Drawing.Point(4, 4)
        Me.JIPSearchButton.Name = "JIPSearchButton"
        Me.JIPSearchButton.Size = New System.Drawing.Size(45, 45)
        Me.JIPSearchButton.TabIndex = 5
        Me.JIPSearchButton.UseVisualStyleBackColor = False
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
        'IncognitoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1301, 776)
        Me.Controls.Add(Me.Theme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "IncognitoForm"
        Me.Text = "Jaguar Web Browser - Incognito Mode"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme1.ResumeLayout(False)
        Me.Theme1.PerformLayout()
        Me.MainPanel.ResumeLayout(False)
        Me.SearchPanel.ResumeLayout(False)
        CType(Me.WebsiteIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmIncognitoWindowFormbtnRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmIncognitoWindowFormbtnStop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmIncognitoWindowFormbtnVoiceInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmIncognitoWindowFormbtnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmIncognitoWindowFormbtnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmIncognitoWindowFormbtnHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmIncognitoWindowFormbtnForward, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmIncognitoWindowFormbtnBackward, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitlePanel.ResumeLayout(False)
        CType(Me.ResizeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinimizeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IncognitoTabControl.ResumeLayout(False)
        Me.TabPage.ResumeLayout(False)
        Me.IncognitoTabPage.ResumeLayout(False)
        Me.IncognitoPanel.ResumeLayout(False)
        Me.IncognitoPanel.PerformLayout()
        Me.JIPSearchFieldPanel.ResumeLayout(False)
        Me.JIPSearchFieldPanel.PerformLayout()
        CType(Me.JIPSearchEnginePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlatRoundedPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TitlePanel As System.Windows.Forms.Panel
    Friend WithEvents FormTitle As WindowsApplication1.FormTitle
    Friend WithEvents lblFullScreen As System.Windows.Forms.Label
    Friend WithEvents MainPanel As System.Windows.Forms.Panel
    Friend WithEvents SearchPanel As WindowsApplication1.FlatPanel
    Friend WithEvents WebsiteIcon As System.Windows.Forms.PictureBox
    Friend WithEvents frmIncognitoWindowFormbtnRefresh As WindowsApplication1.RefreshButton
    Friend WithEvents frmIncognitoWindowFormbtnStop As WindowsApplication1.StopButton
    Friend WithEvents SearchField As WindowsApplication1.SearchField
    Friend WithEvents frmIncognitoWindowFormbtnVoiceInput As WindowsApplication1.VoiceInputButton
    Friend WithEvents frmIncognitoWindowFormbtnSearch As WindowsApplication1.SearchButton
    Friend WithEvents frmIncognitoWindowFormbtnMenu As WindowsApplication1.MenuButton
    Friend WithEvents frmIncognitoWindowFormbtnHome As WindowsApplication1.HomeButton
    Friend WithEvents frmIncognitoWindowFormbtnForward As WindowsApplication1.ForwardButton
    Friend WithEvents frmIncognitoWindowFormbtnBackward As WindowsApplication1.BackwardButton
    Friend WithEvents SearchWord As WindowsApplication1.SearchWord
    Friend WithEvents Theme1 As WindowsApplication1.Theme
    Friend WithEvents IncognitoSideMenu As WindowsApplication1.IncognitoSideMenu
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents MinimizeButton As MinimizeButton
    Friend WithEvents CloseButton As CloseButton
    Friend WithEvents ResizeButton As PictureBox
    Friend WithEvents IncognitoTabControl As IncognitoTabControl
    Friend WithEvents TabPage As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents IncognitoTabPage As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents IncognitoWebBrowser As EO.WinForm.WebControl
    Friend WithEvents IncognitoWebView As EO.WebBrowser.WebView
    Friend WithEvents IncognitoPanel As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents JIPSearchFieldPanel As FlatRoundedPanel
    Friend WithEvents JIPSearchField As TextBox
    Friend WithEvents JIPSearchEnginePic As PictureBox
    Friend WithEvents JIPCmbSearchEngines As ComboBox
    Friend WithEvents FlatRoundedPanel2 As FlatRoundedPanel
    Friend WithEvents JIPSearchButton As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
