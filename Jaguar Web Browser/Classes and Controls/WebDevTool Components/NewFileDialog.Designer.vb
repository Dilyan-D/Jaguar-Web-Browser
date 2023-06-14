<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewFileDialog
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
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.lblNewFile = New System.Windows.Forms.Label()
        Me.frmClose = New System.Windows.Forms.PictureBox()
        Me.FlatPanel1 = New WindowsApplication1.FlatPanel()
        Me.FlatPanel3 = New WindowsApplication1.FlatPanel()
        Me.cmbLanguages = New System.Windows.Forms.ComboBox()
        Me.FlatPanel2 = New WindowsApplication1.FlatPanel()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.pbLanguagesIcons = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelTop.SuspendLayout()
        CType(Me.frmClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlatPanel1.SuspendLayout()
        Me.FlatPanel3.SuspendLayout()
        Me.FlatPanel2.SuspendLayout()
        CType(Me.pbLanguagesIcons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.Black
        Me.PanelTop.Controls.Add(Me.lblNewFile)
        Me.PanelTop.Controls.Add(Me.frmClose)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(530, 25)
        Me.PanelTop.TabIndex = 18
        '
        'lblNewFile
        '
        Me.lblNewFile.AutoSize = True
        Me.lblNewFile.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.lblNewFile.ForeColor = System.Drawing.Color.White
        Me.lblNewFile.Location = New System.Drawing.Point(1, 1)
        Me.lblNewFile.Name = "lblNewFile"
        Me.lblNewFile.Size = New System.Drawing.Size(100, 20)
        Me.lblNewFile.TabIndex = 1
        Me.lblNewFile.Text = "New File..."
        '
        'frmClose
        '
        Me.frmClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.frmClose.BackColor = System.Drawing.Color.Transparent
        Me.frmClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.frmClose.Image = Global.WindowsApplication1.My.Resources.Resources.Close
        Me.frmClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.frmClose.Location = New System.Drawing.Point(504, 1)
        Me.frmClose.Name = "frmClose"
        Me.frmClose.Size = New System.Drawing.Size(25, 25)
        Me.frmClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.frmClose.TabIndex = 0
        Me.frmClose.TabStop = False
        '
        'FlatPanel1
        '
        Me.FlatPanel1.BackColor = System.Drawing.Color.White
        Me.FlatPanel1.Controls.Add(Me.FlatPanel3)
        Me.FlatPanel1.Controls.Add(Me.FlatPanel2)
        Me.FlatPanel1.Controls.Add(Me.pbLanguagesIcons)
        Me.FlatPanel1.Controls.Add(Me.btnCancel)
        Me.FlatPanel1.Controls.Add(Me.btnCreate)
        Me.FlatPanel1.Controls.Add(Me.Label2)
        Me.FlatPanel1.Controls.Add(Me.Label1)
        Me.FlatPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlatPanel1.Location = New System.Drawing.Point(0, 25)
        Me.FlatPanel1.Name = "FlatPanel1"
        Me.FlatPanel1.Size = New System.Drawing.Size(530, 175)
        Me.FlatPanel1.TabIndex = 19
        '
        'FlatPanel3
        '
        Me.FlatPanel3.BackColor = System.Drawing.Color.White
        Me.FlatPanel3.Controls.Add(Me.cmbLanguages)
        Me.FlatPanel3.Location = New System.Drawing.Point(290, 59)
        Me.FlatPanel3.Name = "FlatPanel3"
        Me.FlatPanel3.Size = New System.Drawing.Size(222, 30)
        Me.FlatPanel3.TabIndex = 24
        '
        'cmbLanguages
        '
        Me.cmbLanguages.BackColor = System.Drawing.Color.White
        Me.cmbLanguages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLanguages.Enabled = False
        Me.cmbLanguages.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbLanguages.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.cmbLanguages.FormattingEnabled = True
        Me.cmbLanguages.Items.AddRange(New Object() {"HTML | .html", "CSS | .css", "JavaScript | .js", "PHP | .php"})
        Me.cmbLanguages.Location = New System.Drawing.Point(0, 0)
        Me.cmbLanguages.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbLanguages.MaxDropDownItems = 12
        Me.cmbLanguages.Name = "cmbLanguages"
        Me.cmbLanguages.Size = New System.Drawing.Size(222, 28)
        Me.cmbLanguages.TabIndex = 25
        '
        'FlatPanel2
        '
        Me.FlatPanel2.BackColor = System.Drawing.Color.White
        Me.FlatPanel2.Controls.Add(Me.txtFileName)
        Me.FlatPanel2.Location = New System.Drawing.Point(142, 14)
        Me.FlatPanel2.Name = "FlatPanel2"
        Me.FlatPanel2.Size = New System.Drawing.Size(371, 29)
        Me.FlatPanel2.TabIndex = 23
        '
        'txtFileName
        '
        Me.txtFileName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFileName.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtFileName.Location = New System.Drawing.Point(5, 4)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(360, 21)
        Me.txtFileName.TabIndex = 0
        '
        'pbLanguagesIcons
        '
        Me.pbLanguagesIcons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbLanguagesIcons.Location = New System.Drawing.Point(376, 91)
        Me.pbLanguagesIcons.Name = "pbLanguagesIcons"
        Me.pbLanguagesIcons.Size = New System.Drawing.Size(70, 70)
        Me.pbLanguagesIcons.TabIndex = 22
        Me.pbLanguagesIcons.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(144, 117)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(117, 35)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Tag = ""
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.White
        Me.btnCreate.Enabled = False
        Me.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(21, 117)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(117, 35)
        Me.btnCreate.TabIndex = 20
        Me.btnCreate.Tag = ""
        Me.btnCreate.Text = "Create..."
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 25)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "File Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Programming Language:"
        '
        'NewFileDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 200)
        Me.Controls.Add(Me.FlatPanel1)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NewFileDialog"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewFileDialog"
        Me.TopMost = True
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        CType(Me.frmClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlatPanel1.ResumeLayout(False)
        Me.FlatPanel1.PerformLayout()
        Me.FlatPanel3.ResumeLayout(False)
        Me.FlatPanel2.ResumeLayout(False)
        Me.FlatPanel2.PerformLayout()
        CType(Me.pbLanguagesIcons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTop As Panel
    Friend WithEvents lblNewFile As Label
    Friend WithEvents frmClose As PictureBox
    Friend WithEvents FlatPanel1 As FlatPanel
    Friend WithEvents FlatPanel3 As FlatPanel
    Friend WithEvents cmbLanguages As ComboBox
    Friend WithEvents FlatPanel2 As FlatPanel
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents pbLanguagesIcons As PictureBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
