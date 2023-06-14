<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MHPBookmark
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.WebView = New System.Windows.Forms.WebBrowser()
        Me.pbFavicon = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pbFavicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Black
        Me.btnRemove.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRemove.FlatAppearance.BorderSize = 0
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(125, 0)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(25, 25)
        Me.btnRemove.TabIndex = 2
        Me.btnRemove.Text = "✖"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.pbFavicon)
        Me.Panel1.Controls.Add(Me.btnRemove)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(150, 25)
        Me.Panel1.TabIndex = 3
        '
        'WebView
        '
        Me.WebView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebView.IsWebBrowserContextMenuEnabled = False
        Me.WebView.Location = New System.Drawing.Point(0, 25)
        Me.WebView.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebView.Name = "WebView"
        Me.WebView.ScriptErrorsSuppressed = True
        Me.WebView.ScrollBarsEnabled = False
        Me.WebView.Size = New System.Drawing.Size(150, 125)
        Me.WebView.TabIndex = 1
        Me.WebView.WebBrowserShortcutsEnabled = False
        '
        'pbFavicon
        '
        Me.pbFavicon.BackColor = System.Drawing.Color.Black
        Me.pbFavicon.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbFavicon.Location = New System.Drawing.Point(0, 0)
        Me.pbFavicon.Name = "pbFavicon"
        Me.pbFavicon.Size = New System.Drawing.Size(28, 25)
        Me.pbFavicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFavicon.TabIndex = 3
        Me.pbFavicon.TabStop = False
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Black
        Me.lblName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblName.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblName.Location = New System.Drawing.Point(28, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(97, 25)
        Me.lblName.TabIndex = 0
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MHPBookmark
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.WebView)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MHPBookmark"
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbFavicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRemove As Button
    Friend WithEvents Panel1 As Panel
    Public WithEvents WebView As WebBrowser
    Friend WithEvents pbFavicon As PictureBox
    Friend WithEvents lblName As Label
End Class
