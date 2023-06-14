<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CodeEditor
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuTabControl = New VIBlend.WinForms.Controls.vTabControl()
        Me.HomeTabPage = New VIBlend.WinForms.Controls.vTabPage()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNewFile = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.EditTabPage = New VIBlend.WinForms.Controls.vTabPage()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.btnPaste = New System.Windows.Forms.Button()
        Me.btnCut = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnRedo = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.InsertTabPage = New VIBlend.WinForms.Controls.vTabPage()
        Me.btnCharacter = New System.Windows.Forms.Button()
        Me.btnHyperlink = New System.Windows.Forms.Button()
        Me.btnForm = New System.Windows.Forms.Button()
        Me.btnTable = New System.Windows.Forms.Button()
        Me.btnVideo = New System.Windows.Forms.Button()
        Me.btnFlash = New System.Windows.Forms.Button()
        Me.btnImage = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.ViewCustomizationTabPage = New VIBlend.WinForms.Controls.vTabPage()
        Me.btnOrientation = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnHideWeb = New System.Windows.Forms.Button()
        Me.btnHideCode = New System.Windows.Forms.Button()
        Me.SplitContainer = New VIBlend.WinForms.Controls.vSplitContainer()
        Me.TextEditor = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.TextEditorContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebBrowser = New System.Windows.Forms.WebBrowser()
        Me.WebBrowserContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BackwardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForwardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebBrowserCopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NavTabPage = New VIBlend.WinForms.Controls.vTabPage()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.SmallMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindInW3SchoolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindInStackOverflowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SWFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HyperlinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CharacterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAndCustomizationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideCodeEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideWebBrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LargerMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrientationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuTabControl.SuspendLayout()
        Me.HomeTabPage.SuspendLayout()
        Me.EditTabPage.SuspendLayout()
        Me.InsertTabPage.SuspendLayout()
        Me.ViewCustomizationTabPage.SuspendLayout()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        CType(Me.TextEditor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TextEditorContextMenu.SuspendLayout()
        Me.WebBrowserContextMenu.SuspendLayout()
        Me.SmallMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuTabControl
        '
        Me.MenuTabControl.AllowAnimations = True
        Me.MenuTabControl.Controls.Add(Me.HomeTabPage)
        Me.MenuTabControl.Controls.Add(Me.EditTabPage)
        Me.MenuTabControl.Controls.Add(Me.InsertTabPage)
        Me.MenuTabControl.Controls.Add(Me.ViewCustomizationTabPage)
        Me.MenuTabControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuTabControl.Font = New System.Drawing.Font("Verdana", 10.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.MenuTabControl.Location = New System.Drawing.Point(0, 28)
        Me.MenuTabControl.Name = "MenuTabControl"
        Me.MenuTabControl.Padding = New System.Windows.Forms.Padding(0, 29, 0, 0)
        Me.MenuTabControl.Size = New System.Drawing.Size(1342, 110)
        Me.MenuTabControl.TabAlignment = VIBlend.WinForms.Controls.vTabPageAlignment.Top
        Me.MenuTabControl.TabIndex = 9
        Me.MenuTabControl.TabPages.Add(Me.HomeTabPage)
        Me.MenuTabControl.TabPages.Add(Me.EditTabPage)
        Me.MenuTabControl.TabPages.Add(Me.InsertTabPage)
        Me.MenuTabControl.TabPages.Add(Me.ViewCustomizationTabPage)
        Me.MenuTabControl.TabsAreaBackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.MenuTabControl.TabsInitialOffset = 2
        Me.MenuTabControl.TabsSpacing = 0
        Me.MenuTabControl.TitleHeight = 29
        Me.MenuTabControl.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        '
        'HomeTabPage
        '
        Me.HomeTabPage.BackColor = System.Drawing.SystemColors.Control
        Me.HomeTabPage.Controls.Add(Me.btnInfo)
        Me.HomeTabPage.Controls.Add(Me.btnPrint)
        Me.HomeTabPage.Controls.Add(Me.btnSave)
        Me.HomeTabPage.Controls.Add(Me.btnNewFile)
        Me.HomeTabPage.Controls.Add(Me.btnOpen)
        Me.HomeTabPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HomeTabPage.Font = New System.Drawing.Font("Verdana", 10.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.HomeTabPage.Location = New System.Drawing.Point(0, 29)
        Me.HomeTabPage.Name = "HomeTabPage"
        Me.HomeTabPage.Padding = New System.Windows.Forms.Padding(0)
        Me.HomeTabPage.SelectedTextFont = New System.Drawing.Font("Verdana", 10.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.HomeTabPage.Size = New System.Drawing.Size(1342, 81)
        Me.HomeTabPage.TabIndex = 3
        Me.HomeTabPage.Text = "File"
        Me.HomeTabPage.TextFont = New System.Drawing.Font("Verdana", 10.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.HomeTabPage.TooltipText = "TabPage"
        Me.HomeTabPage.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        Me.HomeTabPage.Visible = False
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnInfo.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnInfo.FlatAppearance.BorderSize = 0
        Me.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInfo.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnInfo.Image = Global.WindowsApplication1.My.Resources.Resources.Info
        Me.btnInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnInfo.Location = New System.Drawing.Point(328, 4)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(81, 73)
        Me.btnInfo.TabIndex = 4
        Me.btnInfo.Text = "Info"
        Me.btnInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInfo.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnPrint.Image = Global.WindowsApplication1.My.Resources.Resources.JWDT_Print
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint.Location = New System.Drawing.Point(247, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(81, 73)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnSave.Image = Global.WindowsApplication1.My.Resources.Resources.Save
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(166, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(81, 73)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save File"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnNewFile
        '
        Me.btnNewFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnNewFile.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnNewFile.FlatAppearance.BorderSize = 0
        Me.btnNewFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewFile.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnNewFile.Image = Global.WindowsApplication1.My.Resources.Resources.New_File
        Me.btnNewFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNewFile.Location = New System.Drawing.Point(85, 4)
        Me.btnNewFile.Name = "btnNewFile"
        Me.btnNewFile.Size = New System.Drawing.Size(81, 73)
        Me.btnNewFile.TabIndex = 1
        Me.btnNewFile.Text = "New File"
        Me.btnNewFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNewFile.UseVisualStyleBackColor = False
        '
        'btnOpen
        '
        Me.btnOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnOpen.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnOpen.FlatAppearance.BorderSize = 0
        Me.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpen.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnOpen.Image = Global.WindowsApplication1.My.Resources.Resources.Open
        Me.btnOpen.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOpen.Location = New System.Drawing.Point(4, 4)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(81, 73)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "Open File"
        Me.btnOpen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOpen.UseVisualStyleBackColor = False
        '
        'EditTabPage
        '
        Me.EditTabPage.Controls.Add(Me.btnFind)
        Me.EditTabPage.Controls.Add(Me.btnSelectAll)
        Me.EditTabPage.Controls.Add(Me.btnPaste)
        Me.EditTabPage.Controls.Add(Me.btnCut)
        Me.EditTabPage.Controls.Add(Me.btnCopy)
        Me.EditTabPage.Controls.Add(Me.btnRedo)
        Me.EditTabPage.Controls.Add(Me.btnUndo)
        Me.EditTabPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditTabPage.Font = New System.Drawing.Font("Verdana", 10.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.EditTabPage.Location = New System.Drawing.Point(0, 29)
        Me.EditTabPage.Name = "EditTabPage"
        Me.EditTabPage.Padding = New System.Windows.Forms.Padding(0)
        Me.EditTabPage.SelectedTextFont = New System.Drawing.Font("Verdana", 10.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.EditTabPage.Size = New System.Drawing.Size(1342, 81)
        Me.EditTabPage.TabIndex = 4
        Me.EditTabPage.Text = "Edit"
        Me.EditTabPage.TextFont = New System.Drawing.Font("Verdana", 10.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.EditTabPage.TooltipText = "TabPage"
        Me.EditTabPage.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        Me.EditTabPage.Visible = False
        '
        'btnFind
        '
        Me.btnFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnFind.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnFind.FlatAppearance.BorderSize = 0
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFind.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnFind.Image = Global.WindowsApplication1.My.Resources.Resources.Find
        Me.btnFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFind.Location = New System.Drawing.Point(494, 4)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(81, 73)
        Me.btnFind.TabIndex = 8
        Me.btnFind.Text = "Find"
        Me.btnFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'btnSelectAll
        '
        Me.btnSelectAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnSelectAll.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSelectAll.FlatAppearance.BorderSize = 0
        Me.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectAll.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnSelectAll.Image = Global.WindowsApplication1.My.Resources.Resources.Select_All
        Me.btnSelectAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSelectAll.Location = New System.Drawing.Point(409, 4)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(85, 73)
        Me.btnSelectAll.TabIndex = 6
        Me.btnSelectAll.Text = "Select All"
        Me.btnSelectAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSelectAll.UseVisualStyleBackColor = False
        '
        'btnPaste
        '
        Me.btnPaste.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnPaste.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPaste.FlatAppearance.BorderSize = 0
        Me.btnPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaste.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnPaste.Image = Global.WindowsApplication1.My.Resources.Resources.Paste
        Me.btnPaste.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPaste.Location = New System.Drawing.Point(328, 4)
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(81, 73)
        Me.btnPaste.TabIndex = 5
        Me.btnPaste.Text = "Paste"
        Me.btnPaste.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPaste.UseVisualStyleBackColor = False
        '
        'btnCut
        '
        Me.btnCut.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnCut.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCut.FlatAppearance.BorderSize = 0
        Me.btnCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCut.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnCut.Image = Global.WindowsApplication1.My.Resources.Resources.Cut
        Me.btnCut.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCut.Location = New System.Drawing.Point(247, 4)
        Me.btnCut.Name = "btnCut"
        Me.btnCut.Size = New System.Drawing.Size(81, 73)
        Me.btnCut.TabIndex = 4
        Me.btnCut.Text = "Cut"
        Me.btnCut.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCut.UseVisualStyleBackColor = False
        '
        'btnCopy
        '
        Me.btnCopy.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnCopy.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCopy.FlatAppearance.BorderSize = 0
        Me.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopy.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnCopy.Image = Global.WindowsApplication1.My.Resources.Resources.Copy
        Me.btnCopy.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCopy.Location = New System.Drawing.Point(166, 4)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(81, 73)
        Me.btnCopy.TabIndex = 3
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCopy.UseVisualStyleBackColor = False
        '
        'btnRedo
        '
        Me.btnRedo.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnRedo.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRedo.FlatAppearance.BorderSize = 0
        Me.btnRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRedo.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnRedo.Image = Global.WindowsApplication1.My.Resources.Resources.Redo
        Me.btnRedo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRedo.Location = New System.Drawing.Point(85, 4)
        Me.btnRedo.Name = "btnRedo"
        Me.btnRedo.Size = New System.Drawing.Size(81, 73)
        Me.btnRedo.TabIndex = 2
        Me.btnRedo.Text = "Redo"
        Me.btnRedo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRedo.UseVisualStyleBackColor = False
        '
        'btnUndo
        '
        Me.btnUndo.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnUndo.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnUndo.FlatAppearance.BorderSize = 0
        Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUndo.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnUndo.Image = Global.WindowsApplication1.My.Resources.Resources.Undo
        Me.btnUndo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUndo.Location = New System.Drawing.Point(4, 4)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(81, 73)
        Me.btnUndo.TabIndex = 1
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUndo.UseVisualStyleBackColor = False
        '
        'InsertTabPage
        '
        Me.InsertTabPage.Controls.Add(Me.btnCharacter)
        Me.InsertTabPage.Controls.Add(Me.btnHyperlink)
        Me.InsertTabPage.Controls.Add(Me.btnForm)
        Me.InsertTabPage.Controls.Add(Me.btnTable)
        Me.InsertTabPage.Controls.Add(Me.btnVideo)
        Me.InsertTabPage.Controls.Add(Me.btnFlash)
        Me.InsertTabPage.Controls.Add(Me.btnImage)
        Me.InsertTabPage.Controls.Add(Me.btnInsert)
        Me.InsertTabPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InsertTabPage.Font = New System.Drawing.Font("Verdana", 10.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.InsertTabPage.Location = New System.Drawing.Point(0, 29)
        Me.InsertTabPage.Name = "InsertTabPage"
        Me.InsertTabPage.Padding = New System.Windows.Forms.Padding(0)
        Me.InsertTabPage.SelectedTextFont = New System.Drawing.Font("Verdana", 10.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.InsertTabPage.Size = New System.Drawing.Size(1342, 81)
        Me.InsertTabPage.TabIndex = 6
        Me.InsertTabPage.Text = "Insert"
        Me.InsertTabPage.TextFont = New System.Drawing.Font("Verdana", 10.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.InsertTabPage.TooltipText = "TabPage"
        Me.InsertTabPage.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        Me.InsertTabPage.Visible = False
        '
        'btnCharacter
        '
        Me.btnCharacter.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnCharacter.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCharacter.FlatAppearance.BorderSize = 0
        Me.btnCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCharacter.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnCharacter.Image = Global.WindowsApplication1.My.Resources.Resources.Character
        Me.btnCharacter.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCharacter.Location = New System.Drawing.Point(571, 4)
        Me.btnCharacter.Name = "btnCharacter"
        Me.btnCharacter.Size = New System.Drawing.Size(84, 73)
        Me.btnCharacter.TabIndex = 10
        Me.btnCharacter.Text = "Character"
        Me.btnCharacter.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCharacter.UseVisualStyleBackColor = False
        '
        'btnHyperlink
        '
        Me.btnHyperlink.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnHyperlink.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnHyperlink.FlatAppearance.BorderSize = 0
        Me.btnHyperlink.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHyperlink.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnHyperlink.Image = Global.WindowsApplication1.My.Resources.Resources.Hyperlink
        Me.btnHyperlink.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHyperlink.Location = New System.Drawing.Point(490, 4)
        Me.btnHyperlink.Name = "btnHyperlink"
        Me.btnHyperlink.Size = New System.Drawing.Size(81, 73)
        Me.btnHyperlink.TabIndex = 9
        Me.btnHyperlink.Text = "Hyperlink"
        Me.btnHyperlink.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHyperlink.UseVisualStyleBackColor = False
        '
        'btnForm
        '
        Me.btnForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnForm.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnForm.FlatAppearance.BorderSize = 0
        Me.btnForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnForm.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnForm.Image = Global.WindowsApplication1.My.Resources.Resources.Form
        Me.btnForm.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnForm.Location = New System.Drawing.Point(409, 4)
        Me.btnForm.Name = "btnForm"
        Me.btnForm.Size = New System.Drawing.Size(81, 73)
        Me.btnForm.TabIndex = 8
        Me.btnForm.Text = "Form"
        Me.btnForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnForm.UseVisualStyleBackColor = False
        '
        'btnTable
        '
        Me.btnTable.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnTable.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnTable.FlatAppearance.BorderSize = 0
        Me.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTable.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnTable.Image = Global.WindowsApplication1.My.Resources.Resources.Table
        Me.btnTable.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnTable.Location = New System.Drawing.Point(328, 4)
        Me.btnTable.Name = "btnTable"
        Me.btnTable.Size = New System.Drawing.Size(81, 73)
        Me.btnTable.TabIndex = 7
        Me.btnTable.Text = "Table"
        Me.btnTable.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTable.UseVisualStyleBackColor = False
        '
        'btnVideo
        '
        Me.btnVideo.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnVideo.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnVideo.FlatAppearance.BorderSize = 0
        Me.btnVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVideo.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnVideo.Image = Global.WindowsApplication1.My.Resources.Resources.Video
        Me.btnVideo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVideo.Location = New System.Drawing.Point(247, 4)
        Me.btnVideo.Name = "btnVideo"
        Me.btnVideo.Size = New System.Drawing.Size(81, 73)
        Me.btnVideo.TabIndex = 6
        Me.btnVideo.Text = "Video"
        Me.btnVideo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVideo.UseVisualStyleBackColor = False
        '
        'btnFlash
        '
        Me.btnFlash.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnFlash.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnFlash.FlatAppearance.BorderSize = 0
        Me.btnFlash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFlash.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnFlash.Image = Global.WindowsApplication1.My.Resources.Resources.SWF
        Me.btnFlash.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFlash.Location = New System.Drawing.Point(166, 4)
        Me.btnFlash.Name = "btnFlash"
        Me.btnFlash.Size = New System.Drawing.Size(81, 73)
        Me.btnFlash.TabIndex = 5
        Me.btnFlash.Text = "SWF"
        Me.btnFlash.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFlash.UseVisualStyleBackColor = False
        '
        'btnImage
        '
        Me.btnImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnImage.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnImage.FlatAppearance.BorderSize = 0
        Me.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImage.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnImage.Image = Global.WindowsApplication1.My.Resources.Resources.Add_Image
        Me.btnImage.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImage.Location = New System.Drawing.Point(85, 4)
        Me.btnImage.Name = "btnImage"
        Me.btnImage.Size = New System.Drawing.Size(81, 73)
        Me.btnImage.TabIndex = 4
        Me.btnImage.Text = "Image"
        Me.btnImage.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImage.UseVisualStyleBackColor = False
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnInsert.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnInsert.FlatAppearance.BorderSize = 0
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnInsert.Image = Global.WindowsApplication1.My.Resources.Resources.Insert
        Me.btnInsert.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnInsert.Location = New System.Drawing.Point(4, 4)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(81, 73)
        Me.btnInsert.TabIndex = 2
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'ViewCustomizationTabPage
        '
        Me.ViewCustomizationTabPage.Controls.Add(Me.btnOrientation)
        Me.ViewCustomizationTabPage.Controls.Add(Me.btnMenu)
        Me.ViewCustomizationTabPage.Controls.Add(Me.btnHideWeb)
        Me.ViewCustomizationTabPage.Controls.Add(Me.btnHideCode)
        Me.ViewCustomizationTabPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewCustomizationTabPage.Font = New System.Drawing.Font("Verdana", 10.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ViewCustomizationTabPage.Location = New System.Drawing.Point(0, 29)
        Me.ViewCustomizationTabPage.Name = "ViewCustomizationTabPage"
        Me.ViewCustomizationTabPage.Padding = New System.Windows.Forms.Padding(0)
        Me.ViewCustomizationTabPage.SelectedTextFont = New System.Drawing.Font("Verdana", 10.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ViewCustomizationTabPage.Size = New System.Drawing.Size(1342, 81)
        Me.ViewCustomizationTabPage.TabIndex = 7
        Me.ViewCustomizationTabPage.Text = "View and Customization"
        Me.ViewCustomizationTabPage.TextFont = New System.Drawing.Font("Verdana", 10.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ViewCustomizationTabPage.TooltipText = "TabPage"
        Me.ViewCustomizationTabPage.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        Me.ViewCustomizationTabPage.Visible = False
        '
        'btnOrientation
        '
        Me.btnOrientation.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnOrientation.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnOrientation.FlatAppearance.BorderSize = 0
        Me.btnOrientation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrientation.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.btnOrientation.Image = Global.WindowsApplication1.My.Resources.Resources.Rotate
        Me.btnOrientation.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOrientation.Location = New System.Drawing.Point(304, 4)
        Me.btnOrientation.Name = "btnOrientation"
        Me.btnOrientation.Size = New System.Drawing.Size(90, 73)
        Me.btnOrientation.TabIndex = 17
        Me.btnOrientation.Text = "Orientation"
        Me.btnOrientation.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOrientation.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.btnMenu.Image = Global.WindowsApplication1.My.Resources.Resources.JWDT_Menu
        Me.btnMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMenu.Location = New System.Drawing.Point(214, 4)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(90, 73)
        Me.btnMenu.TabIndex = 16
        Me.btnMenu.Text = "Small Menu"
        Me.btnMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'btnHideWeb
        '
        Me.btnHideWeb.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnHideWeb.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnHideWeb.FlatAppearance.BorderSize = 0
        Me.btnHideWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHideWeb.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.btnHideWeb.Image = Global.WindowsApplication1.My.Resources.Resources.Close_Panel
        Me.btnHideWeb.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHideWeb.Location = New System.Drawing.Point(114, 4)
        Me.btnHideWeb.Name = "btnHideWeb"
        Me.btnHideWeb.Size = New System.Drawing.Size(100, 73)
        Me.btnHideWeb.TabIndex = 8
        Me.btnHideWeb.Text = "Hide Web View"
        Me.btnHideWeb.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHideWeb.UseVisualStyleBackColor = False
        '
        'btnHideCode
        '
        Me.btnHideCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnHideCode.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnHideCode.FlatAppearance.BorderSize = 0
        Me.btnHideCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHideCode.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.btnHideCode.Image = Global.WindowsApplication1.My.Resources.Resources.Open_Panel
        Me.btnHideCode.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHideCode.Location = New System.Drawing.Point(4, 4)
        Me.btnHideCode.Name = "btnHideCode"
        Me.btnHideCode.Size = New System.Drawing.Size(110, 73)
        Me.btnHideCode.TabIndex = 7
        Me.btnHideCode.Text = "Hide Code Editor"
        Me.btnHideCode.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHideCode.UseVisualStyleBackColor = False
        '
        'SplitContainer
        '
        Me.SplitContainer.AllowAnimations = True
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer.Location = New System.Drawing.Point(0, 138)
        Me.SplitContainer.Name = "SplitContainer"
        Me.SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer.Panel1.BorderColor = System.Drawing.Color.Silver
        Me.SplitContainer.Panel1.Controls.Add(Me.TextEditor)
        Me.SplitContainer.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer.Panel1.Name = "Panel1"
        Me.SplitContainer.Panel1.Size = New System.Drawing.Size(669, 605)
        Me.SplitContainer.Panel1.TabIndex = 1
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer.Panel2.BorderColor = System.Drawing.Color.Silver
        Me.SplitContainer.Panel2.Controls.Add(Me.WebBrowser)
        Me.SplitContainer.Panel2.Location = New System.Drawing.Point(673, 0)
        Me.SplitContainer.Panel2.Name = "Panel2"
        Me.SplitContainer.Panel2.Size = New System.Drawing.Size(669, 605)
        Me.SplitContainer.Panel2.TabIndex = 2
        Me.SplitContainer.Size = New System.Drawing.Size(1342, 605)
        Me.SplitContainer.SplitterSize = 4
        Me.SplitContainer.StyleKey = "Splitter"
        Me.SplitContainer.TabIndex = 29
        Me.SplitContainer.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        '
        'TextEditor
        '
        Me.TextEditor.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.TextEditor.AutoScrollMinSize = New System.Drawing.Size(33, 23)
        Me.TextEditor.BackBrush = Nothing
        Me.TextEditor.CharHeight = 23
        Me.TextEditor.CharWidth = 11
        Me.TextEditor.ContextMenuStrip = Me.TextEditorContextMenu
        Me.TextEditor.CurrentLineColor = System.Drawing.Color.Gainsboro
        Me.TextEditor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextEditor.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.TextEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextEditor.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.TextEditor.IsReplaceMode = False
        Me.TextEditor.LineNumberColor = System.Drawing.Color.SteelBlue
        Me.TextEditor.Location = New System.Drawing.Point(0, 0)
        Me.TextEditor.Name = "TextEditor"
        Me.TextEditor.Paddings = New System.Windows.Forms.Padding(0)
        Me.TextEditor.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextEditor.Size = New System.Drawing.Size(669, 605)
        Me.TextEditor.TabIndex = 0
        Me.TextEditor.Zoom = 100
        '
        'TextEditorContextMenu
        '
        Me.TextEditorContextMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TextEditorContextMenu.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.TextEditorContextMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TextEditorContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.CopyToolStripMenuItem, Me.CutToolStripMenuItem, Me.PasteToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.InsertToolStripMenuItem})
        Me.TextEditorContextMenu.Name = "TextEditorContextMenu"
        Me.TextEditorContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TextEditorContextMenu.ShowImageMargin = False
        Me.TextEditorContextMenu.Size = New System.Drawing.Size(110, 186)
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(109, 26)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(109, 26)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(109, 26)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(109, 26)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(109, 26)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(109, 26)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'InsertToolStripMenuItem
        '
        Me.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem"
        Me.InsertToolStripMenuItem.Size = New System.Drawing.Size(109, 26)
        Me.InsertToolStripMenuItem.Text = "Insert..."
        '
        'WebBrowser
        '
        Me.WebBrowser.AllowWebBrowserDrop = False
        Me.WebBrowser.ContextMenuStrip = Me.WebBrowserContextMenu
        Me.WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser.Name = "WebBrowser"
        Me.WebBrowser.ScriptErrorsSuppressed = True
        Me.WebBrowser.Size = New System.Drawing.Size(669, 605)
        Me.WebBrowser.TabIndex = 0
        Me.WebBrowser.WebBrowserShortcutsEnabled = False
        '
        'WebBrowserContextMenu
        '
        Me.WebBrowserContextMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.WebBrowserContextMenu.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.WebBrowserContextMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackwardToolStripMenuItem, Me.ForwardToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.StopToolStripMenuItem, Me.WebBrowserCopyToolStripMenuItem})
        Me.WebBrowserContextMenu.Name = "TextEditorContextMenu"
        Me.WebBrowserContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.WebBrowserContextMenu.ShowImageMargin = False
        Me.WebBrowserContextMenu.Size = New System.Drawing.Size(141, 134)
        '
        'BackwardToolStripMenuItem
        '
        Me.BackwardToolStripMenuItem.Name = "BackwardToolStripMenuItem"
        Me.BackwardToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.BackwardToolStripMenuItem.Text = "Go Back"
        '
        'ForwardToolStripMenuItem
        '
        Me.ForwardToolStripMenuItem.Name = "ForwardToolStripMenuItem"
        Me.ForwardToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.ForwardToolStripMenuItem.Text = "Go Forward"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'WebBrowserCopyToolStripMenuItem
        '
        Me.WebBrowserCopyToolStripMenuItem.Name = "WebBrowserCopyToolStripMenuItem"
        Me.WebBrowserCopyToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.WebBrowserCopyToolStripMenuItem.Text = "Copy"
        '
        'NavTabPage
        '
        Me.NavTabPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavTabPage.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.NavTabPage.HeaderWidth = 150
        Me.NavTabPage.Location = New System.Drawing.Point(0, 28)
        Me.NavTabPage.Name = "NavTabPage"
        Me.NavTabPage.Padding = New System.Windows.Forms.Padding(0)
        Me.NavTabPage.SelectedTextFont = New System.Drawing.Font("Verdana", 9.0!)
        Me.NavTabPage.Size = New System.Drawing.Size(669, 605)
        Me.NavTabPage.TabIndex = 4
        Me.NavTabPage.Text = "Web Browser"
        Me.NavTabPage.TextFont = New System.Drawing.Font("Verdana", 9.0!)
        Me.NavTabPage.TooltipText = "TabPage"
        Me.NavTabPage.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010SILVER
        Me.NavTabPage.Visible = False
        '
        'OFD
        '
        Me.OFD.Filter = """HTML Files|*.html|Cascade Style Sheet|*.css|JavaScript Files|*.js|PHP Files|*.ph" &
    "p"""
        Me.OFD.Title = "Open File"
        '
        'SFD
        '
        Me.SFD.Filter = "HTML  | .html | CSS | .css | JavaScript | .js | PHP | .php"
        Me.SFD.Title = "Save File"
        '
        'SmallMenu
        '
        Me.SmallMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.SmallMenu.Font = New System.Drawing.Font("Verdana", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.SmallMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SmallMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.InsertToolStripMenuItem1, Me.ViewAndCustomizationToolStripMenuItem})
        Me.SmallMenu.Location = New System.Drawing.Point(0, 0)
        Me.SmallMenu.Name = "SmallMenu"
        Me.SmallMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.SmallMenu.Size = New System.Drawing.Size(1342, 28)
        Me.SmallMenu.TabIndex = 30
        Me.SmallMenu.Visible = False
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenFileToolStripMenuItem, Me.NewFileToolStripMenuItem, Me.SaveFileToolStripMenuItem, Me.PrintToolStripMenuItem, Me.InfoToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenFileToolStripMenuItem
        '
        Me.OpenFileToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.OpenFileToolStripMenuItem.Text = "Open File"
        '
        'NewFileToolStripMenuItem
        '
        Me.NewFileToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.NewFileToolStripMenuItem.Name = "NewFileToolStripMenuItem"
        Me.NewFileToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.NewFileToolStripMenuItem.Text = "New File"
        '
        'SaveFileToolStripMenuItem
        '
        Me.SaveFileToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.SaveFileToolStripMenuItem.Name = "SaveFileToolStripMenuItem"
        Me.SaveFileToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.SaveFileToolStripMenuItem.Text = "Save File"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem1, Me.RedoToolStripMenuItem1, Me.CopyToolStripMenuItem1, Me.CutToolStripMenuItem1, Me.PasteToolStripMenuItem1, Me.SelectAllToolStripMenuItem, Me.FindToolStripMenuItem, Me.FindInW3SchoolToolStripMenuItem, Me.FindInStackOverflowToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UndoToolStripMenuItem1
        '
        Me.UndoToolStripMenuItem1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.UndoToolStripMenuItem1.Name = "UndoToolStripMenuItem1"
        Me.UndoToolStripMenuItem1.Size = New System.Drawing.Size(289, 26)
        Me.UndoToolStripMenuItem1.Text = "Undo"
        '
        'RedoToolStripMenuItem1
        '
        Me.RedoToolStripMenuItem1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.RedoToolStripMenuItem1.Name = "RedoToolStripMenuItem1"
        Me.RedoToolStripMenuItem1.Size = New System.Drawing.Size(289, 26)
        Me.RedoToolStripMenuItem1.Text = "Redo"
        '
        'CopyToolStripMenuItem1
        '
        Me.CopyToolStripMenuItem1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.CopyToolStripMenuItem1.Name = "CopyToolStripMenuItem1"
        Me.CopyToolStripMenuItem1.Size = New System.Drawing.Size(289, 26)
        Me.CopyToolStripMenuItem1.Text = "Copy"
        '
        'CutToolStripMenuItem1
        '
        Me.CutToolStripMenuItem1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.CutToolStripMenuItem1.Name = "CutToolStripMenuItem1"
        Me.CutToolStripMenuItem1.Size = New System.Drawing.Size(289, 26)
        Me.CutToolStripMenuItem1.Text = "Cut"
        '
        'PasteToolStripMenuItem1
        '
        Me.PasteToolStripMenuItem1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.PasteToolStripMenuItem1.Name = "PasteToolStripMenuItem1"
        Me.PasteToolStripMenuItem1.Size = New System.Drawing.Size(289, 26)
        Me.PasteToolStripMenuItem1.Text = "Paste"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(289, 26)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(289, 26)
        Me.FindToolStripMenuItem.Text = "Find"
        '
        'FindInW3SchoolToolStripMenuItem
        '
        Me.FindInW3SchoolToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.FindInW3SchoolToolStripMenuItem.Name = "FindInW3SchoolToolStripMenuItem"
        Me.FindInW3SchoolToolStripMenuItem.Size = New System.Drawing.Size(289, 26)
        Me.FindInW3SchoolToolStripMenuItem.Text = "Find in W3School..."
        '
        'FindInStackOverflowToolStripMenuItem
        '
        Me.FindInStackOverflowToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.FindInStackOverflowToolStripMenuItem.Name = "FindInStackOverflowToolStripMenuItem"
        Me.FindInStackOverflowToolStripMenuItem.Size = New System.Drawing.Size(289, 26)
        Me.FindInStackOverflowToolStripMenuItem.Text = "Find in StackOverflow..."
        '
        'InsertToolStripMenuItem1
        '
        Me.InsertToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertToolStripMenuItem2, Me.ImageToolStripMenuItem, Me.SWFToolStripMenuItem, Me.VideoToolStripMenuItem, Me.TableToolStripMenuItem, Me.FormToolStripMenuItem, Me.HyperlinkToolStripMenuItem, Me.CharacterToolStripMenuItem})
        Me.InsertToolStripMenuItem1.Name = "InsertToolStripMenuItem1"
        Me.InsertToolStripMenuItem1.Size = New System.Drawing.Size(79, 24)
        Me.InsertToolStripMenuItem1.Text = "Insert"
        '
        'InsertToolStripMenuItem2
        '
        Me.InsertToolStripMenuItem2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.InsertToolStripMenuItem2.Name = "InsertToolStripMenuItem2"
        Me.InsertToolStripMenuItem2.Size = New System.Drawing.Size(181, 26)
        Me.InsertToolStripMenuItem2.Text = "Insert..."
        '
        'ImageToolStripMenuItem
        '
        Me.ImageToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ImageToolStripMenuItem.Name = "ImageToolStripMenuItem"
        Me.ImageToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ImageToolStripMenuItem.Text = "Image"
        '
        'SWFToolStripMenuItem
        '
        Me.SWFToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.SWFToolStripMenuItem.Name = "SWFToolStripMenuItem"
        Me.SWFToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.SWFToolStripMenuItem.Text = "SWF"
        '
        'VideoToolStripMenuItem
        '
        Me.VideoToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.VideoToolStripMenuItem.Name = "VideoToolStripMenuItem"
        Me.VideoToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.VideoToolStripMenuItem.Text = "Video"
        '
        'TableToolStripMenuItem
        '
        Me.TableToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.TableToolStripMenuItem.Name = "TableToolStripMenuItem"
        Me.TableToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.TableToolStripMenuItem.Text = "Table"
        '
        'FormToolStripMenuItem
        '
        Me.FormToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.FormToolStripMenuItem.Name = "FormToolStripMenuItem"
        Me.FormToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.FormToolStripMenuItem.Text = "Form"
        '
        'HyperlinkToolStripMenuItem
        '
        Me.HyperlinkToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.HyperlinkToolStripMenuItem.Name = "HyperlinkToolStripMenuItem"
        Me.HyperlinkToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.HyperlinkToolStripMenuItem.Text = "Hyperlink"
        '
        'CharacterToolStripMenuItem
        '
        Me.CharacterToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.CharacterToolStripMenuItem.Name = "CharacterToolStripMenuItem"
        Me.CharacterToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.CharacterToolStripMenuItem.Text = "Character"
        '
        'ViewAndCustomizationToolStripMenuItem
        '
        Me.ViewAndCustomizationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HideCodeEditorToolStripMenuItem, Me.HideWebBrowserToolStripMenuItem, Me.LargerMenuToolStripMenuItem, Me.OrientationToolStripMenuItem})
        Me.ViewAndCustomizationToolStripMenuItem.Name = "ViewAndCustomizationToolStripMenuItem"
        Me.ViewAndCustomizationToolStripMenuItem.Size = New System.Drawing.Size(252, 24)
        Me.ViewAndCustomizationToolStripMenuItem.Text = "View and Customization"
        '
        'HideCodeEditorToolStripMenuItem
        '
        Me.HideCodeEditorToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.HideCodeEditorToolStripMenuItem.Name = "HideCodeEditorToolStripMenuItem"
        Me.HideCodeEditorToolStripMenuItem.Size = New System.Drawing.Size(241, 26)
        Me.HideCodeEditorToolStripMenuItem.Text = "Hide Code Editor"
        '
        'HideWebBrowserToolStripMenuItem
        '
        Me.HideWebBrowserToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.HideWebBrowserToolStripMenuItem.Name = "HideWebBrowserToolStripMenuItem"
        Me.HideWebBrowserToolStripMenuItem.Size = New System.Drawing.Size(241, 26)
        Me.HideWebBrowserToolStripMenuItem.Text = "Hide Web Browser"
        '
        'LargerMenuToolStripMenuItem
        '
        Me.LargerMenuToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.LargerMenuToolStripMenuItem.Name = "LargerMenuToolStripMenuItem"
        Me.LargerMenuToolStripMenuItem.Size = New System.Drawing.Size(241, 26)
        Me.LargerMenuToolStripMenuItem.Text = "Larger Menu"
        '
        'OrientationToolStripMenuItem
        '
        Me.OrientationToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.OrientationToolStripMenuItem.Name = "OrientationToolStripMenuItem"
        Me.OrientationToolStripMenuItem.Size = New System.Drawing.Size(241, 26)
        Me.OrientationToolStripMenuItem.Text = "Orientation"
        '
        'CodeEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer)
        Me.Controls.Add(Me.MenuTabControl)
        Me.Controls.Add(Me.SmallMenu)
        Me.Name = "CodeEditor"
        Me.Size = New System.Drawing.Size(1342, 743)
        Me.MenuTabControl.ResumeLayout(False)
        Me.HomeTabPage.ResumeLayout(False)
        Me.EditTabPage.ResumeLayout(False)
        Me.InsertTabPage.ResumeLayout(False)
        Me.ViewCustomizationTabPage.ResumeLayout(False)
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel2.ResumeLayout(False)
        Me.SplitContainer.ResumeLayout(False)
        CType(Me.TextEditor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TextEditorContextMenu.ResumeLayout(False)
        Me.WebBrowserContextMenu.ResumeLayout(False)
        Me.SmallMenu.ResumeLayout(False)
        Me.SmallMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuTabControl As VIBlend.WinForms.Controls.vTabControl
    Friend WithEvents HomeTabPage As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents btnInfo As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNewFile As Button
    Friend WithEvents btnOpen As Button
    Friend WithEvents EditTabPage As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents btnFind As Button
    Friend WithEvents btnSelectAll As Button
    Friend WithEvents btnPaste As Button
    Friend WithEvents btnCut As Button
    Friend WithEvents btnCopy As Button
    Friend WithEvents btnRedo As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents InsertTabPage As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents btnCharacter As Button
    Friend WithEvents btnHyperlink As Button
    Friend WithEvents btnForm As Button
    Friend WithEvents btnTable As Button
    Friend WithEvents btnVideo As Button
    Friend WithEvents btnFlash As Button
    Friend WithEvents btnImage As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents ViewCustomizationTabPage As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnHideWeb As Button
    Friend WithEvents btnHideCode As Button
    Friend WithEvents SplitContainer As VIBlend.WinForms.Controls.vSplitContainer
    Friend WithEvents TextEditor As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents NavTabPage As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents OFD As OpenFileDialog
    Friend WithEvents SFD As SaveFileDialog
    Friend WithEvents TextEditorContextMenu As ContextMenuStrip
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WebBrowser As WebBrowser
    Friend WithEvents WebBrowserContextMenu As ContextMenuStrip
    Friend WithEvents BackwardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ForwardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WebBrowserCopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnOrientation As Button
    Friend WithEvents SmallMenu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ViewAndCustomizationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ImageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SWFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VideoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HyperlinkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CharacterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HideCodeEditorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HideWebBrowserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LargerMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrientationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindInW3SchoolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindInStackOverflowToolStripMenuItem As ToolStripMenuItem
End Class
