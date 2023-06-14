<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchWord
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
        Me.FlatPanel1 = New WindowsApplication1.FlatPanel()
        Me.txtSearchWord = New System.Windows.Forms.TextBox()
        Me.btnCloseSearchWord = New System.Windows.Forms.Button()
        Me.FlatPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlatPanel1
        '
        Me.FlatPanel1.BackColor = System.Drawing.Color.White
        Me.FlatPanel1.Controls.Add(Me.txtSearchWord)
        Me.FlatPanel1.Controls.Add(Me.btnCloseSearchWord)
        Me.FlatPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlatPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlatPanel1.Name = "FlatPanel1"
        Me.FlatPanel1.Size = New System.Drawing.Size(350, 28)
        Me.FlatPanel1.TabIndex = 0
        '
        'txtSearchWord
        '
        Me.txtSearchWord.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearchWord.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchWord.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtSearchWord.ForeColor = System.Drawing.Color.Silver
        Me.txtSearchWord.Location = New System.Drawing.Point(5, 2)
        Me.txtSearchWord.Name = "txtSearchWord"
        Me.txtSearchWord.Size = New System.Drawing.Size(315, 22)
        Me.txtSearchWord.TabIndex = 5
        Me.txtSearchWord.Text = "Ex: dog"
        '
        'btnCloseSearchWord
        '
        Me.btnCloseSearchWord.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCloseSearchWord.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnCloseSearchWord.FlatAppearance.BorderSize = 0
        Me.btnCloseSearchWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseSearchWord.Location = New System.Drawing.Point(323, 1)
        Me.btnCloseSearchWord.Name = "btnCloseSearchWord"
        Me.btnCloseSearchWord.Size = New System.Drawing.Size(26, 26)
        Me.btnCloseSearchWord.TabIndex = 4
        Me.btnCloseSearchWord.Text = "✖"
        Me.btnCloseSearchWord.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCloseSearchWord.UseVisualStyleBackColor = False
        '
        'SearchWord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlatPanel1)
        Me.Name = "SearchWord"
        Me.Size = New System.Drawing.Size(350, 28)
        Me.FlatPanel1.ResumeLayout(False)
        Me.FlatPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlatPanel1 As WindowsApplication1.FlatPanel
    Friend WithEvents btnCloseSearchWord As System.Windows.Forms.Button
    Friend WithEvents txtSearchWord As System.Windows.Forms.TextBox

End Class
