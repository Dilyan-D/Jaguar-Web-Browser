<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CodeInspector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CodeInspector))
        Me.Theme1 = New WindowsApplication1.Theme()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.ResizeButton = New System.Windows.Forms.PictureBox()
        Me.MinimizeButton = New WindowsApplication1.MinimizeButton()
        Me.CloseButton = New WindowsApplication1.CloseButton()
        Me.TextEditor = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.Theme1.SuspendLayout()
        Me.TitlePanel.SuspendLayout()
        CType(Me.ResizeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinimizeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Theme1
        '
        Me.Theme1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Theme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Theme1.Controls.Add(Me.TitlePanel)
        Me.Theme1.Controls.Add(Me.TextEditor)
        Me.Theme1.Customization = "AAAA//////8="
        Me.Theme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Theme1.Image = Nothing
        Me.Theme1.Location = New System.Drawing.Point(0, 0)
        Me.Theme1.Movable = True
        Me.Theme1.Name = "Theme1"
        Me.Theme1.NoRounding = False
        Me.Theme1.Sizable = True
        Me.Theme1.Size = New System.Drawing.Size(856, 747)
        Me.Theme1.SmartBounds = True
        Me.Theme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.Theme1.TabIndex = 0
        Me.Theme1.Text = "Theme1"
        Me.Theme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme1.Transparent = False
        '
        'TitlePanel
        '
        Me.TitlePanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitlePanel.BackColor = System.Drawing.Color.Black
        Me.TitlePanel.Controls.Add(Me.ResizeButton)
        Me.TitlePanel.Controls.Add(Me.MinimizeButton)
        Me.TitlePanel.Controls.Add(Me.CloseButton)
        Me.TitlePanel.Location = New System.Drawing.Point(781, 1)
        Me.TitlePanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(72, 21)
        Me.TitlePanel.TabIndex = 5
        '
        'ResizeButton
        '
        Me.ResizeButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResizeButton.Image = Global.WindowsApplication1.My.Resources.Resources.Normal
        Me.ResizeButton.Location = New System.Drawing.Point(25, 0)
        Me.ResizeButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ResizeButton.Name = "ResizeButton"
        Me.ResizeButton.Size = New System.Drawing.Size(22, 21)
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
        Me.MinimizeButton.Size = New System.Drawing.Size(25, 21)
        Me.MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MinimizeButton.TabIndex = 1
        Me.MinimizeButton.TabStop = False
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.Transparent
        Me.CloseButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.CloseButton.Image = CType(resources.GetObject("CloseButton.Image"), System.Drawing.Image)
        Me.CloseButton.Location = New System.Drawing.Point(47, 0)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(25, 21)
        Me.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CloseButton.TabIndex = 0
        Me.CloseButton.TabStop = False
        '
        'TextEditor
        '
        Me.TextEditor.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.TextEditor.AutoScrollMinSize = New System.Drawing.Size(33, 23)
        Me.TextEditor.BackBrush = Nothing
        Me.TextEditor.CharHeight = 23
        Me.TextEditor.CharWidth = 11
        Me.TextEditor.CurrentLineColor = System.Drawing.Color.Gainsboro
        Me.TextEditor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextEditor.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.TextEditor.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.TextEditor.IsReplaceMode = False
        Me.TextEditor.LineNumberColor = System.Drawing.Color.SteelBlue
        Me.TextEditor.Location = New System.Drawing.Point(3, 23)
        Me.TextEditor.Name = "TextEditor"
        Me.TextEditor.Paddings = New System.Windows.Forms.Padding(0)
        Me.TextEditor.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextEditor.Size = New System.Drawing.Size(850, 719)
        Me.TextEditor.TabIndex = 2
        Me.TextEditor.Zoom = 100
        '
        'CodeInspector
        '
        Me.ClientSize = New System.Drawing.Size(856, 747)
        Me.Controls.Add(Me.Theme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CodeInspector"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme1.ResumeLayout(False)
        Me.TitlePanel.ResumeLayout(False)
        CType(Me.ResizeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinimizeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CodeInspector As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents Theme1 As Theme
    Friend WithEvents TextEditor As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents TitlePanel As Panel
    Friend WithEvents ResizeButton As PictureBox
    Friend WithEvents MinimizeButton As MinimizeButton
    Friend WithEvents CloseButton As CloseButton
End Class
