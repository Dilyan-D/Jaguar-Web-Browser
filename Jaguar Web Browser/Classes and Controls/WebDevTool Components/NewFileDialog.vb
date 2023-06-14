Imports VIBlend.WinForms.Controls

Public Class NewFileDialog

#Region "Design"

    Private Sub frmClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmClose.Click
        Me.Close()
    End Sub

    Private Sub frmClose_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles frmClose.MouseHover
        frmClose.Image = New Bitmap(My.Resources.Close_1)
    End Sub

    Private Sub frmClose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles frmClose.MouseLeave
        frmClose.Image = New Bitmap(My.Resources.Close)
    End Sub

#End Region

#Region "Events"

    Private Sub NewFileDialog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Select Case My.Settings.Language

            Case 0
                lblNewFile.Text = "New File..."
                Label2.Text = "File Name: "
                Label1.Text = "Programming Language: "
                btnCreate.Text = "Create..."
                btnCancel.Text = "Cancel"

            Case 1
                lblNewFile.Text = "Нов Файл..."
                Label2.Text = "Име: "
                Label1.Text = "Програмен език: "
                btnCreate.Text = "Създай..."
                btnCancel.Text = "Отмени"

        End Select
    End Sub

    Private Sub txtFileName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFileName.TextChanged
        If txtFileName.Text Is Nothing Or txtFileName.Text.Trim().Length < 1 Then
            btnCreate.Enabled = False
            cmbLanguages.Enabled = False
        Else
            btnCreate.Enabled = True
            cmbLanguages.Enabled = True
        End If
    End Sub

    Private Sub cmbLanguages_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLanguages.SelectedIndexChanged

        Select Case cmbLanguages.Text
            Case "HTML | .html"
                pbLanguagesIcons.BackgroundImage = New Bitmap(My.Resources.HTML5)
                MainForm.SFD.Filter = "HTML File|*.html"
            Case "CSS | .css"
                pbLanguagesIcons.BackgroundImage = New Bitmap(My.Resources.CSS3)
                MainForm.SFD.Filter = "Cascade Style Sheet File|*.css"
            Case "JavaScript | .js"
                pbLanguagesIcons.BackgroundImage = New Bitmap(My.Resources.JavaScript)
                MainForm.SFD.Filter = "JavaScript File|*.js"
            Case "PHP | .php"
                pbLanguagesIcons.BackgroundImage = New Bitmap(My.Resources.PHP)
                MainForm.SFD.Filter = "PHP File|*.php"
        End Select

    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click

        'Generating new tabpage'
        Dim TabPage As New vTabPage

        MainForm.JWDTTabControl.TabPages.Add(TabPage)
        MainForm.JWDTTabControl.SelectedTab = TabPage
        MainForm.JWDTTabControl.EnableCloseButtons = True
        MainForm.JWDTTabControl.ShowCloseButtonOnSelectedTabOnly = False
        MainForm.JWDTTabControl.AllowDragDrop = True
        MainForm.JWDTTabControl.TabPages.Remove(MainForm.WelcomeTabPage)

        'Generating new tabpage'


        'Validating File Names'
        Select Case cmbLanguages.Text
            Case "HTML | .html"
                TabPage.Text = txtFileName.Text + ".html"
            Case "CSS | .css"
                TabPage.Text = txtFileName.Text + ".css"
            Case "JavaScript | .js"
                TabPage.Text = txtFileName.Text + ".js"
            Case "PHP | .php"
                TabPage.Text = txtFileName.Text + ".php"
        End Select
        'Validating File Names'


        'Generate Controls'
        Dim CE As New CodeEditor
        CE.Dock = DockStyle.Fill
        TabPage.Controls.Add(CE)
        'Generate Controls'


        'Language validation'
        Select Case cmbLanguages.Text
            Case "HTML | .html"
                CE.TextEditor.Language = FastColoredTextBoxNS.Language.HTML
                CE.TextEditor.Text =
                    "<!DOCTYPE>" & vbCrLf &
                    "<html>" & vbCrLf &
                    "<head>" & vbCrLf &
                    "<meta http-equiv=""Content-Type"" content=""text/html;" & vbCrLf &
                    "charset=utf-8"" />" & vbCrLf &
                    "<title>Untitled Document</title>" & vbCrLf &
                    "</head>" & vbCrLf &
                    "" & vbCrLf &
                    "<body>" & vbCrLf &
                    "" & vbCrLf &
                    "</body>" & vbCrLf &
                    "</html>"

            Case "CSS | .css"
                CE.TextEditor.Language = FastColoredTextBoxNS.Language.Custom
                CE.TextEditor.Text = "@charset ""utf-8"";" & vbCrLf & " "

            Case "JavaScript | .js"
                CE.TextEditor.Language = FastColoredTextBoxNS.Language.JS
                CE.TextEditor.Text = "// JavaScript Document"

            Case "PHP | .php"
                CE.TextEditor.Language = FastColoredTextBoxNS.Language.PHP
                CE.TextEditor.Text =
                    "<?php" & vbCrLf &
                    "echo ""Hello World""" & vbCrLf &
                    "?>"
        End Select
        'Language validation'

        Me.Close()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

#End Region

End Class