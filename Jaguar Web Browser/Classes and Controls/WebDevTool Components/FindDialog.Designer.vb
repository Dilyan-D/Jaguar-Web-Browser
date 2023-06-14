<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FindDialog
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
        Me.FlatPanel1 = New WindowsApplication1.FlatPanel()
        Me.FlatPanel2 = New WindowsApplication1.FlatPanel()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.lblNewFile = New System.Windows.Forms.Label()
        Me.frmClose = New System.Windows.Forms.PictureBox()
        Me.FlatPanel1.SuspendLayout()
        Me.FlatPanel2.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        CType(Me.frmClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlatPanel1
        '
        Me.FlatPanel1.BackColor = System.Drawing.Color.White
        Me.FlatPanel1.Controls.Add(Me.FlatPanel2)
        Me.FlatPanel1.Controls.Add(Me.Label2)
        Me.FlatPanel1.Controls.Add(Me.btnCancel)
        Me.FlatPanel1.Controls.Add(Me.btnFind)
        Me.FlatPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlatPanel1.Location = New System.Drawing.Point(0, 25)
        Me.FlatPanel1.Name = "FlatPanel1"
        Me.FlatPanel1.Size = New System.Drawing.Size(448, 103)
        Me.FlatPanel1.TabIndex = 20
        '
        'FlatPanel2
        '
        Me.FlatPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatPanel2.BackColor = System.Drawing.Color.White
        Me.FlatPanel2.Controls.Add(Me.txtFileName)
        Me.FlatPanel2.Location = New System.Drawing.Point(131, 17)
        Me.FlatPanel2.Name = "FlatPanel2"
        Me.FlatPanel2.Size = New System.Drawing.Size(305, 29)
        Me.FlatPanel2.TabIndex = 25
        '
        'txtFileName
        '
        Me.txtFileName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFileName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFileName.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtFileName.Location = New System.Drawing.Point(5, 4)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(294, 21)
        Me.txtFileName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 25)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Find what: "
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(319, 56)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(117, 35)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Tag = ""
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnFind
        '
        Me.btnFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFind.BackColor = System.Drawing.Color.White
        Me.btnFind.Enabled = False
        Me.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFind.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnFind.Location = New System.Drawing.Point(196, 56)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(117, 35)
        Me.btnFind.TabIndex = 22
        Me.btnFind.Tag = ""
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.Black
        Me.PanelTop.Controls.Add(Me.lblNewFile)
        Me.PanelTop.Controls.Add(Me.frmClose)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(448, 25)
        Me.PanelTop.TabIndex = 21
        '
        'lblNewFile
        '
        Me.lblNewFile.AutoSize = True
        Me.lblNewFile.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.lblNewFile.ForeColor = System.Drawing.Color.White
        Me.lblNewFile.Location = New System.Drawing.Point(1, 1)
        Me.lblNewFile.Name = "lblNewFile"
        Me.lblNewFile.Size = New System.Drawing.Size(64, 20)
        Me.lblNewFile.TabIndex = 1
        Me.lblNewFile.Text = "Find..."
        '
        'frmClose
        '
        Me.frmClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.frmClose.BackColor = System.Drawing.Color.Transparent
        Me.frmClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.frmClose.Image = Global.WindowsApplication1.My.Resources.Resources.Close
        Me.frmClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.frmClose.Location = New System.Drawing.Point(422, 1)
        Me.frmClose.Name = "frmClose"
        Me.frmClose.Size = New System.Drawing.Size(25, 25)
        Me.frmClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.frmClose.TabIndex = 0
        Me.frmClose.TabStop = False
        '
        'FindDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 128)
        Me.Controls.Add(Me.FlatPanel1)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FindDialog"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.FlatPanel1.ResumeLayout(False)
        Me.FlatPanel1.PerformLayout()
        Me.FlatPanel2.ResumeLayout(False)
        Me.FlatPanel2.PerformLayout()
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        CType(Me.frmClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlatPanel1 As FlatPanel
    Friend WithEvents PanelTop As Panel
    Friend WithEvents lblNewFile As Label
    Friend WithEvents frmClose As PictureBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents FlatPanel2 As FlatPanel
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents Label2 As Label
End Class
