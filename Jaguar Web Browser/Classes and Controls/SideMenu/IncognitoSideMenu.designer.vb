<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncognitoSideMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IncognitoSideMenu))
        Me.TitleBar = New System.Windows.Forms.Panel()
        Me.MenuIcon = New System.Windows.Forms.PictureBox()
        Me.CloseMenuButton = New System.Windows.Forms.PictureBox()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.PanelRight = New System.Windows.Forms.Panel()
        Me.frmSideMenubtnSearch = New System.Windows.Forms.Button()
        Me.frmSideMenubtnSavePage = New System.Windows.Forms.Button()
        Me.frmSideMenubtnNewWindow = New System.Windows.Forms.Button()
        Me.frmSideMenubtnPrint = New System.Windows.Forms.Button()
        Me.frmSideMenubtnFullScreen = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelZoom = New System.Windows.Forms.Panel()
        Me.ZoomStatus = New System.Windows.Forms.TextBox()
        Me.frmSideMenubtnZoomIn = New System.Windows.Forms.Button()
        Me.frmSideMenubtnZoomOut = New System.Windows.Forms.Button()
        Me.lblConnectionStatus = New System.Windows.Forms.Label()
        Me.LabelConnectionStatus = New System.Windows.Forms.Label()
        Me.PanelLine = New System.Windows.Forms.Panel()
        Me.TitleBar.SuspendLayout()
        CType(Me.MenuIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseMenuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelZoom.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitleBar
        '
        Me.TitleBar.BackColor = System.Drawing.Color.Black
        Me.TitleBar.Controls.Add(Me.MenuIcon)
        Me.TitleBar.Controls.Add(Me.CloseMenuButton)
        Me.TitleBar.Controls.Add(Me.LabelName)
        Me.TitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBar.Location = New System.Drawing.Point(6, 0)
        Me.TitleBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Size = New System.Drawing.Size(347, 32)
        Me.TitleBar.TabIndex = 22
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
        'PanelLeft
        '
        Me.PanelLeft.BackColor = System.Drawing.Color.Black
        Me.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeft.Location = New System.Drawing.Point(0, 0)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(6, 600)
        Me.PanelLeft.TabIndex = 24
        '
        'PanelRight
        '
        Me.PanelRight.BackColor = System.Drawing.Color.Black
        Me.PanelRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelRight.Location = New System.Drawing.Point(353, 0)
        Me.PanelRight.Name = "PanelRight"
        Me.PanelRight.Size = New System.Drawing.Size(2, 600)
        Me.PanelRight.TabIndex = 23
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
        Me.frmSideMenubtnSearch.Location = New System.Drawing.Point(115, 0)
        Me.frmSideMenubtnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSideMenubtnSearch.Name = "frmSideMenubtnSearch"
        Me.frmSideMenubtnSearch.Size = New System.Drawing.Size(115, 115)
        Me.frmSideMenubtnSearch.TabIndex = 25
        Me.frmSideMenubtnSearch.Text = "Search"
        Me.frmSideMenubtnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.frmSideMenubtnSearch.UseVisualStyleBackColor = True
        '
        'frmSideMenubtnSavePage
        '
        Me.frmSideMenubtnSavePage.Dock = System.Windows.Forms.DockStyle.Left
        Me.frmSideMenubtnSavePage.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.frmSideMenubtnSavePage.FlatAppearance.BorderSize = 0
        Me.frmSideMenubtnSavePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frmSideMenubtnSavePage.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.frmSideMenubtnSavePage.ForeColor = System.Drawing.Color.White
        Me.frmSideMenubtnSavePage.Image = Global.WindowsApplication1.My.Resources.Resources.Save_Page
        Me.frmSideMenubtnSavePage.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.frmSideMenubtnSavePage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.frmSideMenubtnSavePage.Location = New System.Drawing.Point(115, 0)
        Me.frmSideMenubtnSavePage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSideMenubtnSavePage.Name = "frmSideMenubtnSavePage"
        Me.frmSideMenubtnSavePage.Size = New System.Drawing.Size(117, 115)
        Me.frmSideMenubtnSavePage.TabIndex = 27
        Me.frmSideMenubtnSavePage.Text = "Save Webpage"
        Me.frmSideMenubtnSavePage.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.frmSideMenubtnSavePage.UseVisualStyleBackColor = True
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
        Me.frmSideMenubtnNewWindow.Size = New System.Drawing.Size(115, 115)
        Me.frmSideMenubtnNewWindow.TabIndex = 26
        Me.frmSideMenubtnNewWindow.Text = "New Window"
        Me.frmSideMenubtnNewWindow.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.frmSideMenubtnNewWindow.UseVisualStyleBackColor = True
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
        Me.frmSideMenubtnPrint.Location = New System.Drawing.Point(232, 0)
        Me.frmSideMenubtnPrint.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSideMenubtnPrint.Name = "frmSideMenubtnPrint"
        Me.frmSideMenubtnPrint.Size = New System.Drawing.Size(115, 115)
        Me.frmSideMenubtnPrint.TabIndex = 29
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
        Me.frmSideMenubtnFullScreen.Location = New System.Drawing.Point(0, 0)
        Me.frmSideMenubtnFullScreen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frmSideMenubtnFullScreen.Name = "frmSideMenubtnFullScreen"
        Me.frmSideMenubtnFullScreen.Size = New System.Drawing.Size(115, 115)
        Me.frmSideMenubtnFullScreen.TabIndex = 28
        Me.frmSideMenubtnFullScreen.Text = "Fullscreen"
        Me.frmSideMenubtnFullScreen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.frmSideMenubtnFullScreen.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.frmSideMenubtnPrint)
        Me.Panel1.Controls.Add(Me.frmSideMenubtnSavePage)
        Me.Panel1.Controls.Add(Me.frmSideMenubtnNewWindow)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(6, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(347, 115)
        Me.Panel1.TabIndex = 30
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.frmSideMenubtnSearch)
        Me.Panel2.Controls.Add(Me.frmSideMenubtnFullScreen)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(6, 190)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(347, 115)
        Me.Panel2.TabIndex = 31
        '
        'PanelZoom
        '
        Me.PanelZoom.Controls.Add(Me.ZoomStatus)
        Me.PanelZoom.Controls.Add(Me.frmSideMenubtnZoomIn)
        Me.PanelZoom.Controls.Add(Me.frmSideMenubtnZoomOut)
        Me.PanelZoom.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelZoom.Location = New System.Drawing.Point(6, 32)
        Me.PanelZoom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelZoom.Name = "PanelZoom"
        Me.PanelZoom.Size = New System.Drawing.Size(347, 43)
        Me.PanelZoom.TabIndex = 32
        '
        'ZoomStatus
        '
        Me.ZoomStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
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
        'lblConnectionStatus
        '
        Me.lblConnectionStatus.AutoSize = True
        Me.lblConnectionStatus.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.lblConnectionStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConnectionStatus.Location = New System.Drawing.Point(210, 325)
        Me.lblConnectionStatus.Name = "lblConnectionStatus"
        Me.lblConnectionStatus.Size = New System.Drawing.Size(20, 20)
        Me.lblConnectionStatus.TabIndex = 34
        Me.lblConnectionStatus.Text = "0"
        '
        'LabelConnectionStatus
        '
        Me.LabelConnectionStatus.AutoSize = True
        Me.LabelConnectionStatus.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.LabelConnectionStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelConnectionStatus.Location = New System.Drawing.Point(21, 325)
        Me.LabelConnectionStatus.Name = "LabelConnectionStatus"
        Me.LabelConnectionStatus.Size = New System.Drawing.Size(175, 20)
        Me.LabelConnectionStatus.TabIndex = 33
        Me.LabelConnectionStatus.Text = "Connection Status:"
        '
        'PanelLine
        '
        Me.PanelLine.BackColor = System.Drawing.Color.Black
        Me.PanelLine.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.PanelLine.Location = New System.Drawing.Point(17, 320)
        Me.PanelLine.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelLine.Name = "PanelLine"
        Me.PanelLine.Size = New System.Drawing.Size(320, 1)
        Me.PanelLine.TabIndex = 35
        '
        'IncognitoSideMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Controls.Add(Me.lblConnectionStatus)
        Me.Controls.Add(Me.LabelConnectionStatus)
        Me.Controls.Add(Me.PanelLine)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelZoom)
        Me.Controls.Add(Me.TitleBar)
        Me.Controls.Add(Me.PanelRight)
        Me.Controls.Add(Me.PanelLeft)
        Me.Name = "IncognitoSideMenu"
        Me.Size = New System.Drawing.Size(355, 600)
        Me.TitleBar.ResumeLayout(False)
        Me.TitleBar.PerformLayout()
        CType(Me.MenuIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseMenuButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.PanelZoom.ResumeLayout(False)
        Me.PanelZoom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitleBar As System.Windows.Forms.Panel
    Friend WithEvents MenuIcon As System.Windows.Forms.PictureBox
    Friend WithEvents CloseMenuButton As System.Windows.Forms.PictureBox
    Friend WithEvents LabelName As System.Windows.Forms.Label
    Friend WithEvents PanelLeft As System.Windows.Forms.Panel
    Friend WithEvents PanelRight As System.Windows.Forms.Panel
    Friend WithEvents frmSideMenubtnSearch As System.Windows.Forms.Button
    Friend WithEvents frmSideMenubtnSavePage As System.Windows.Forms.Button
    Friend WithEvents frmSideMenubtnNewWindow As System.Windows.Forms.Button
    Friend WithEvents frmSideMenubtnPrint As System.Windows.Forms.Button
    Friend WithEvents frmSideMenubtnFullScreen As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PanelZoom As System.Windows.Forms.Panel
    Friend WithEvents ZoomStatus As System.Windows.Forms.TextBox
    Friend WithEvents frmSideMenubtnZoomIn As System.Windows.Forms.Button
    Friend WithEvents frmSideMenubtnZoomOut As System.Windows.Forms.Button
    Friend WithEvents lblConnectionStatus As System.Windows.Forms.Label
    Friend WithEvents LabelConnectionStatus As System.Windows.Forms.Label
    Friend WithEvents PanelLine As System.Windows.Forms.Panel

End Class
