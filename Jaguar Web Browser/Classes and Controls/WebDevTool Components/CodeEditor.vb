#Region "Imports"
Imports System.IO
Imports VIBlend.WinForms.Controls
Imports VIBlend.Utilities.VIBLEND_THEME
Imports FastColoredTextBoxNS
Imports System.Text.RegularExpressions
#End Region

Public Class CodeEditor

    Private Sub CodeEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case My.Settings.Language
            Case 0
                'English'
                English()
            Case 1
                'Bulgarian'
                Bulgarian()
        End Select
    End Sub

#Region "Web Render"

    Private Sub TextEditor_Load(sender As Object, e As EventArgs) Handles TextEditor.Load
        TextEditor.Text = MainForm.MaskedTextBox.Text
        WebBrowser.DocumentText = TextEditor.Text
    End Sub

    Dim null = Nothing
    Dim BlueBoldStyle As Style = New TextStyle(Brushes.Blue, null, FontStyle.Bold)
    Dim MagentaStyle As Style = New TextStyle(Brushes.Magenta, null, FontStyle.Regular)
    Dim GreenStyle As Style = New TextStyle(Brushes.Green, null, FontStyle.Italic)
    Dim BrownStyle As Style = New TextStyle(Brushes.Brown, null, FontStyle.Italic)
    Dim FireBrickBold As Style = New TextStyle(Brushes.Firebrick, null, FontStyle.Bold)
    Dim DodgerBlue As Style = New TextStyle(Brushes.DodgerBlue, null, FontStyle.Regular)
    Dim SteelBlue As Style = New TextStyle(Brushes.SteelBlue, null, FontStyle.Regular)
    Dim DarkGoldenRodBold As Style = New TextStyle(Brushes.DarkGoldenrod, null, FontStyle.Bold)
    Dim SlateGray As Style = New TextStyle(Brushes.SlateGray, null, FontStyle.Regular)
    Dim DarkViolet As Style = New TextStyle(Brushes.DarkViolet, null, FontStyle.Regular)

    Private Sub TextEditor_TextChanged(sender As Object, e As TextChangedEventArgs) Handles TextEditor.TextChanged
        WebBrowser.DocumentText = TextEditor.Text

        'CSS Styles'
        e.ChangedRange.ClearStyle(SlateGray, DarkViolet, DodgerBlue, FireBrickBold, BlueBoldStyle, DarkGoldenRodBold, MagentaStyle, GreenStyle, BrownStyle)
        e.ChangedRange.tb.CommentPrefix = null
        e.ChangedRange.tb.LeftBracket = "("
        e.ChangedRange.tb.RightBracket = ")"
        e.ChangedRange.tb.LeftBracket2 = "\x0"
        e.ChangedRange.tb.RightBracket2 = "\x0"
        e.ChangedRange.SetStyle(BrownStyle, """.*?""|'.+?'", RegexOptions.Multiline)
        e.ChangedRange.SetStyle(GreenStyle, "(/\*.*?\*/)|(/\*.*)", RegexOptions.Multiline)
        e.ChangedRange.SetStyle(GreenStyle, "(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline Or RegexOptions.RightToLeft)
        e.ChangedRange.SetStyle(MagentaStyle, "\b(\d+\s*(px|em|pt|in|cm|mm|ex|pc)*)\b(%)*", RegexOptions.Multiline)
        e.ChangedRange.SetStyle(MagentaStyle, "#\b([a-fA-F0-9]{3,8})\b", RegexOptions.Multiline)
        e.ChangedRange.SetStyle(SteelBlue, "(-(moz|o|ms|webkit|khtml)-(\w|-)+)", RegexOptions.Multiline)
        e.ChangedRange.SetStyle(FireBrickBold, "(#:(\w|\.|-)+:#)", RegexOptions.Multiline)
        e.ChangedRange.SetStyle(DodgerBlue, "\b(font-weight|border-radius|color-stop|alignment-adjust|alignment-baseline|animation|animation-delay|animation-direction|animation-duration|animation-iteration-count|animation-name|animation-play-state|animation-timing-function|appearance|azimuth|backface-visibility|background|background-attachment|background-break|background-clip|background-color|background-image|background-origin|background-position|background-repeat|background-size|baseline-shift|binding|bleed|bookmark-label|bookmark-level|bookmark-state|bookmark-target|border|border|border-bottom|border-bottom-color|border-bottom-left-radius|border-bottom-right-radius|border-bottom-style|border-bottom-width|border-collapse|border-color|border-image|border-image-outset|border-image-repeat|border-image-slice|border-image-source|border-image-width|border-left|border-left-color|border-left-style|border-left-width|border-right|border-right-color|border-right-style|border-right-width|border-spacing|border-style|border-top|border-top-color|border-top-left-radius|border-top-right-radius|border-top-style|border-top-width|border-width|bottom|box-align|box-decoration-break|box-direction|box-flex|box-flex-group|box-lines|box-ordinal-group|box-orient|box-pack|box-shadow|box-sizing|break-after|break-before|break-inside|caption-side|clear|clip|color|color-profile|column-count|column-fill|column-gap|column-rule|column-rule-color|column-rule-style|column-rule-width|column-span|column-width|columns|content|counter-increment|counter-reset|crop|cue|cue-after|cue-before|cursor|direction|display|dominant-baseline|drop-initial-after-adjust|drop-initial-after-align|drop-initial-before-adjust|drop-initial-before-align|drop-initial-size|drop-initial-value|elevation|empty-cells|filter|fit|fit-position|float|float-offset|font|font-effect|font-emphasize|font-family|font-size|font-size-adjust|font-stretch|font-style|font-variant|grid-columns|grid-rows|hanging-punctuation|height|hyphenate-after|hyphenate-before|hyphenate-character|hyphenate-lines|hyphenate-resource|hyphens|icon|image-orientation|image-rendering|image-resolution|inline-box-align|left|letter-spacing|line-height|line-stacking|line-stacking-ruby|line-stacking-shift|line-stacking-strategy|list-style|list-style-image|list-style-position|list-style-type|margin|margin-bottom|margin-left|margin-right|margin-top|mark|mark-after|mark-before|marker-offset|marks|marquee-direction|marquee-play-count|marquee-speed|marquee-style|max-height|max-width|min-height|min-width|move-to|nav-down|nav-index|nav-left|nav-right|nav-up|opacity|orphans|outline|outline-color|outline-offset|outline-style|outline-width|overflow|overflow-style|overflow-x|overflow-y|padding|padding-bottom|padding-left|padding-right|padding-top|page|page-break-after|page-break-before|page-break-inside|page-policy|pause|pause-after|pause-before|perspective|perspective-origin|phonemes|pitch|pitch-range|play-during|position|presentation-level|punctuation-trim|quotes|rendering-intent|resize|rest|rest-after|rest-before|richness|right|rotation|rotation-point|ruby-align|ruby-overhang|ruby-position|ruby-span|size|speak|speak-header|speak-numeral|speak-punctuation|speech-rate|stress|string-set|table-layout|target|target-name|target-new|target-position|text-align|text-align-last|text-decoration|text-emphasis|text-height|text-indent|text-justify|text-outline|text-overflow|text-shadow|text-transform|text-wrap|top|transform|transform-origin|transform-style|transition|transition-delay|transition-duration|transition-property|transition-timing-function|unicode-bidi|vertical-align|visibility|voice-balance|voice-duration|voice-family|voice-pitch|voice-pitch-range|voice-rate|voice-stress|voice-volume|volume|white-space|white-space-collapse|widows|width|word-break|word-spacing|word-wrap|z-index)\b", RegexOptions.Multiline)
        e.ChangedRange.SetStyle(BlueBoldStyle, "[\}|\{]", RegexOptions.Multiline)
        e.ChangedRange.SetStyle(DarkGoldenRodBold, "(\}.*?\{)|(\}.*)", RegexOptions.Multiline)
        e.ChangedRange.SetStyle(DarkGoldenRodBold, "(\}.*?\{)|(.*\{)", RegexOptions.Singleline Or RegexOptions.RightToLeft)
        e.ChangedRange.SetStyle(SlateGray, "[\.|\,|\;|\:|\=|\(|\)|\!]", RegexOptions.Multiline)
        e.ChangedRange.SetStyle(DarkViolet, "progid\:DXImageTransform\.Microsoft", RegexOptions.Multiline)
        e.ChangedRange.ClearFoldingMarkers()
        e.ChangedRange.SetFoldingMarkers("{", "}")
        e.ChangedRange.SetFoldingMarkers("/\*", "\*/")
        'CSS Styles'

    End Sub

#End Region

#Region "Menu Events"

#Region "Home"

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click, OpenFileToolStripMenuItem.Click

        OFD.ShowDialog()

        If OFD.FileName <> Nothing Then
            'Reads the file'
            Try
                Dim Reader As New IO.StreamReader(OFD.FileName)
                TextEditor.Text = Reader.ReadToEnd
                Reader.Close()
            Catch ex As Exception
            End Try
            'Reads the file'


            'Generating new page'
            Dim CE As New CodeEditor
            Dim TabPage As New vTabPage
            CE.Show()
            CE.Dock = DockStyle.Fill
            TabPage.Controls.Add(CE)

            MainForm.JWDTTabControl.TabPages.Add(TabPage)
            TabPage.Text = Path.GetFileName(OFD.FileName)
            MainForm.JWDTTabControl.SelectedTab = TabPage
            MainForm.JWDTTabControl.AllowDragDrop = True
            MainForm.JWDTTabControl.EnableCloseButtons = True
            MainForm.JWDTTabControl.ShowCloseButtonOnSelectedTabOnly = False

            If TabPage.Text.Contains(".html") Then
                TextEditor.Language = FastColoredTextBoxNS.Language.HTML
                SFD.Filter = "HTML File|*.html"
            End If
            If TabPage.Text.Contains(".css") Then
                TextEditor.Language = FastColoredTextBoxNS.Language.Custom
                SFD.Filter = "Cascade Style Sheet|*.css"
            End If
            If TabPage.Text.Contains(".js") Then
                TextEditor.Language = FastColoredTextBoxNS.Language.JS
                SFD.Filter = "JavaScript File|*.js"
            End If
            If TabPage.Text.Contains(".php") Then
                TextEditor.Language = FastColoredTextBoxNS.Language.PHP
                SFD.Filter = "PHP File|*.php"
            End If

            'Generating new page'
        End If

    End Sub

    Private Sub btnNewFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewFile.Click, NewFileToolStripMenuItem.Click
        NewFileDialog.ShowDialog()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click, SaveFileToolStripMenuItem.Click

        SFD.ShowDialog()

        If SFD.FileName <> Nothing Then
            Try
                Dim Writer As New StreamWriter(SFD.FileName)
                Writer.Write(TextEditor.Text)
                Writer.Close()
            Catch ex As Exception
            End Try

            MainForm.JWDTTabControl.SelectedTab.Text = Path.GetFileName(SFD.FileName)

        End If

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click, PrintToolStripMenuItem.Click

    End Sub

    Private Sub btnInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInfo.Click, InfoToolStripMenuItem.Click

    End Sub

#End Region

#Region "Edit"

    Private Sub btnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndo.Click, UndoToolStripMenuItem1.Click
        TextEditor.Undo()
    End Sub

    Private Sub btnRedo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRedo.Click, RedoToolStripMenuItem1.Click
        TextEditor.Redo()
    End Sub

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click, CopyToolStripMenuItem1.Click
        TextEditor.Copy()
    End Sub

    Private Sub btnCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCut.Click, CutToolStripMenuItem1.Click
        TextEditor.Cut()
    End Sub

    Private Sub btnPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaste.Click, PasteToolStripMenuItem1.Click
        TextEditor.Paste()
    End Sub

    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click, SelectAllToolStripMenuItem.Click
        TextEditor.SelectAll()
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click, FindToolStripMenuItem.Click
        TextEditor.ShowFindDialog()
        'FastColoredTextBoxNS.FindForm.ActiveForm.FormBorderStyle = FormBorderStyle.None
    End Sub

    Private Sub FindInW3SchoolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindInW3SchoolToolStripMenuItem.Click
        Try
            MainForm.NewTab()
            MainForm.SearchField.Text = "w3schools.com"
            MainForm.Search()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FindInStackOverflowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindInStackOverflowToolStripMenuItem.Click
        Try
            MainForm.NewTab()
            MainForm.SearchField.Text = "stackoverflow.com"
            MainForm.Search()
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "Insert"

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click, InsertToolStripMenuItem2.Click
        InsertDialog.Show()
    End Sub

    Private Sub btnImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImage.Click, ImageToolStripMenuItem.Click
        InsertDialog.Show()
        InsertDialog.TabControl.SelectedIndex = 0
    End Sub

    Private Sub btnFlash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFlash.Click, SWFToolStripMenuItem.Click
        InsertDialog.Show()
        InsertDialog.TabControl.SelectedIndex = 1
        InsertDialog.MediaTabControl.SelectedIndex = 3
    End Sub

    Private Sub btnVideo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVideo.Click, VideoToolStripMenuItem.Click
        InsertDialog.Show()
        InsertDialog.TabControl.SelectedIndex = 1
        InsertDialog.MediaTabControl.SelectedIndex = 0
    End Sub

    Private Sub btnTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTable.Click, TableToolStripMenuItem.Click
        InsertDialog.Show()
        InsertDialog.TabControl.SelectedIndex = 2
    End Sub

    Private Sub btnForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForm.Click, FormToolStripMenuItem.Click
        InsertDialog.Show()
        InsertDialog.TabControl.SelectedIndex = 3
    End Sub

    Private Sub btnCharacter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCharacter.Click, CharacterToolStripMenuItem.Click
        InsertDialog.Show()
        InsertDialog.TabControl.SelectedIndex = 4
    End Sub

#End Region

#Region "View and Customization"

    Private Sub btnHideCode_Click(sender As Object, e As EventArgs) Handles btnHideCode.Click, HideCodeEditorToolStripMenuItem.Click
        If btnHideWeb.Enabled = True Then
            btnHideWeb.Enabled = False
            SplitContainer.Panel1.Hide()
        Else
            btnHideWeb.Enabled = True
            SplitContainer.Panel1.Show()
        End If
    End Sub

    Private Sub btnHideWeb_Click(sender As Object, e As EventArgs) Handles btnHideWeb.Click, HideWebBrowserToolStripMenuItem.Click
        If btnHideCode.Enabled = True Then
            btnHideCode.Enabled = False
            SplitContainer.Panel2.Hide()
        Else
            btnHideCode.Enabled = True
            SplitContainer.Panel2.Show()
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        MenuTabControl.Visible = False
        SmallMenu.Visible = True
    End Sub

    Private Sub LargerMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LargerMenuToolStripMenuItem.Click
        MenuTabControl.Visible = True
        SmallMenu.Visible = False
    End Sub

    Private Sub btnOrientation_Click(sender As Object, e As EventArgs) Handles btnOrientation.Click, OrientationToolStripMenuItem.Click
        If SplitContainer.Orientation = Orientation.Horizontal Then
            SplitContainer.Orientation = Orientation.Vertical
        Else
            SplitContainer.Orientation = Orientation.Horizontal
        End If
    End Sub

#End Region

#End Region

#Region "Context Menus"

#Region "Text Editor"
    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        TextEditor.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        TextEditor.Redo()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        TextEditor.Copy()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        TextEditor.Cut()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        TextEditor.Paste()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        TextEditor.ClearSelected()
    End Sub

    Private Sub InsertToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertToolStripMenuItem.Click
        InsertDialog.ShowDialog()
    End Sub
#End Region

#Region "Web Browser"

    Private Sub BackwardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackwardToolStripMenuItem.Click

    End Sub

    Private Sub ForwardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardToolStripMenuItem.Click

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click

    End Sub

#End Region

#End Region

#Region "Languages"

    Public Sub English()

        'Tabs'
        HomeTabPage.Text = "File"
        EditTabPage.Text = "Edit"
        InsertTabPage.Text = "Insert"
        ViewCustomizationTabPage.Text = "View and Customization"
        '_____________________'



        'File'
        btnOpen.Text = "Open File"
        btnNewFile.Text = "New File"
        btnSave.Text = "Save File"
        btnPrint.Text = "Print"
        btnInfo.Text = "Info"
        '_____________________'



        'Edit'
        btnUndo.Text = "Undo"
        btnRedo.Text = "Redo"
        btnCopy.Text = "Copy"
        btnCut.Text = "Cut"
        btnPaste.Text = "Paste"
        btnSelectAll.Text = "Sellect All"
        btnFind.Text = "Find"
        '_____________________'



        'Insert'
        btnInsert.Text = "Insert"
        btnImage.Text = "Image"
        btnFlash.Text = "SWF"
        btnVideo.Text = "Video"
        btnTable.Text = "Table"
        btnForm.Text = "Form"
        btnHyperlink.Text = "Hyperlink"
        btnCharacter.Text = "Character"
        '_____________________'



        'V&C'
        btnHideCode.Text = "Hide Code Editor"
        btnHideWeb.Text = "Hide Web View"
        btnMenu.Text = "Small Menu"
        btnOrientation.Text = "Orientation"
        '_____________________'



        'Small Menu'

        FileToolStripMenuItem.Text = "File"
        EditToolStripMenuItem.Text = "Edit"
        InsertToolStripMenuItem1.Text = "Insert"
        ViewAndCustomizationToolStripMenuItem.Text = "View and Customization"

        OpenFileToolStripMenuItem.Text = "Open File"
        NewFileToolStripMenuItem.Text = "New File"
        SaveFileToolStripMenuItem.Text = "Save File"
        PrintToolStripMenuItem.Text = "Print"
        InfoToolStripMenuItem.Text = "Info"

        UndoToolStripMenuItem1.Text = "Undo"
        RedoToolStripMenuItem1.Text = "Redo"
        CopyToolStripMenuItem1.Text = "Copy"
        CutToolStripMenuItem1.Text = "Cut"
        PasteToolStripMenuItem1.Text = "Paste"
        SelectAllToolStripMenuItem.Text = "Select All"
        FindToolStripMenuItem.Text = "Find"
        FindInW3SchoolToolStripMenuItem.Text = "Find in W3School..."
        FindInStackOverflowToolStripMenuItem.Text = "Find in Stack Overflow..."

        InsertToolStripMenuItem2.Text = "Insert..."
        ImageToolStripMenuItem.Text = "Image"
        SWFToolStripMenuItem.Text = "SWF"
        VideoToolStripMenuItem.Text = "Video"
        TableToolStripMenuItem.Text = "Table"
        FormToolStripMenuItem.Text = "Form"
        HyperlinkToolStripMenuItem.Text = "Hyperlink"
        CharacterToolStripMenuItem.Text = "Charexter"

        HideCodeEditorToolStripMenuItem.Text = "Hide Code Editor"
        HideWebBrowserToolStripMenuItem.Text = "Hide Web Browser"
        LargerMenuToolStripMenuItem.Text = "Large Menu"
        OrientationToolStripMenuItem.Text = "Orientation"
        '_____________________'



        'Text Editor Context Menu'
        UndoToolStripMenuItem.Text = "Undo"
        RedoToolStripMenuItem.Text = "Redo"
        CopyToolStripMenuItem.Text = "Copy"
        CutToolStripMenuItem.Text = "Cut"
        PasteToolStripMenuItem.Text = "Paste"
        DeleteToolStripMenuItem.Text = "Delete"
        InsertToolStripMenuItem.Text = "Insert..."
        '_____________________'



        'Web Browser Context Menu'
        BackwardToolStripMenuItem.Text = "Go Back"
        ForwardToolStripMenuItem.Text = "Go Forward"
        RefreshToolStripMenuItem.Text = "Refresh"
        StopToolStripMenuItem.Text = "Stop"
        WebBrowserCopyToolStripMenuItem.Text = "Copy"
        '_____________________'

    End Sub

    Public Sub Bulgarian()

        'Tabs'
        HomeTabPage.Text = "Файл"
        EditTabPage.Text = "Редактиране"
        InsertTabPage.Text = "Вмъкни"
        ViewCustomizationTabPage.Text = "Изглед"
        '_____________________'



        'File'
        btnOpen.Text = "Отвори"
        btnNewFile.Text = "Нов Файл"
        btnSave.Text = "Съхрани"
        btnPrint.Text = "Принтирай"
        btnInfo.Text = "Инфо"
        '_____________________'



        'Edit'
        btnUndo.Text = "Отмени"
        btnRedo.Text = "Повтори"
        btnCopy.Text = "Копирай"
        btnCut.Text = "Изрежи"
        btnPaste.Text = "Постави"
        btnSelectAll.Text = "Избери"
        btnFind.Text = "Намери"
        '_____________________'



        'Insert'
        btnInsert.Text = "Вмъкни"
        btnImage.Text = "Картина"
        btnFlash.Text = "SWF"
        btnVideo.Text = "Видео"
        btnTable.Text = "Таблица"
        btnForm.Text = "Форма"
        btnHyperlink.Text = "Хиперлинк"
        btnCharacter.Text = "Символ"
        '_____________________'



        'V&C'
        btnHideCode.Text = "Скрий Редактора"
        btnHideWeb.Text = "Скрий Браузъра"
        btnMenu.Text = "Малко меню"
        btnOrientation.Text = "Ориентация"
        '_____________________'



        'Small Menu'

        FileToolStripMenuItem.Text = "Файл"
        EditToolStripMenuItem.Text = "Редактиране"
        InsertToolStripMenuItem1.Text = "Вмъкни"
        ViewAndCustomizationToolStripMenuItem.Text = "Изглед"

        OpenFileToolStripMenuItem.Text = "Отвори файл"
        NewFileToolStripMenuItem.Text = "Нов Файл"
        SaveFileToolStripMenuItem.Text = "Съхрани"
        PrintToolStripMenuItem.Text = "Принтирай"
        InfoToolStripMenuItem.Text = "Инфо"

        UndoToolStripMenuItem1.Text = "Отмени"
        RedoToolStripMenuItem1.Text = "Повтори"
        CopyToolStripMenuItem1.Text = "Копирай"
        CutToolStripMenuItem1.Text = "Изрежи"
        PasteToolStripMenuItem1.Text = "Постави"
        SelectAllToolStripMenuItem.Text = "Избери всичко"
        FindToolStripMenuItem.Text = "Намери"
        FindInW3SchoolToolStripMenuItem.Text = "Намери в W3School..."
        FindInStackOverflowToolStripMenuItem.Text = "Намери в Stack Overflow..."

        InsertToolStripMenuItem2.Text = "Вмъкни..."
        ImageToolStripMenuItem.Text = "Изображение"
        SWFToolStripMenuItem.Text = "SWF"
        VideoToolStripMenuItem.Text = "Видео"
        TableToolStripMenuItem.Text = "Таблица"
        FormToolStripMenuItem.Text = "Форма"
        HyperlinkToolStripMenuItem.Text = "Хиперлинк"
        CharacterToolStripMenuItem.Text = "Символ"

        HideCodeEditorToolStripMenuItem.Text = "Скрий Редактора"
        HideWebBrowserToolStripMenuItem.Text = "Скрий Браузъра"
        LargerMenuToolStripMenuItem.Text = "Голямо Меню"
        OrientationToolStripMenuItem.Text = "Ориентация"
        '_____________________'



        'Text Editor Context Menu'
        UndoToolStripMenuItem.Text = "Отмени"
        RedoToolStripMenuItem.Text = "Повтори"
        CopyToolStripMenuItem.Text = "Копирай"
        CutToolStripMenuItem.Text = "Изрежи"
        PasteToolStripMenuItem.Text = "Постави"
        DeleteToolStripMenuItem.Text = "Изтрий"
        InsertToolStripMenuItem.Text = "Вмъкни..."
        '_____________________'



        'Web Browser Context Menu'
        BackwardToolStripMenuItem.Text = "Назад"
        ForwardToolStripMenuItem.Text = "Напред"
        RefreshToolStripMenuItem.Text = "Презареди"
        StopToolStripMenuItem.Text = "Спри"
        WebBrowserCopyToolStripMenuItem.Text = "Копирай"
        '_____________________'

    End Sub

#End Region

End Class
