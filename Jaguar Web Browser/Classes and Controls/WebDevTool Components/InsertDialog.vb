Imports System.IO
Imports System.Net

Public Class InsertDialog

#Region "Form Design"
    'Move Form'
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub PanelTop_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelTop.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PanelTop_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelTop.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub PanelTop_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelTop.MouseUp
        drag = False
    End Sub
    'Move Form'



    'Close Button'
    Private Sub frmClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmClose.Click
        Me.Close()
    End Sub

    Private Sub frmClose_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles frmClose.MouseHover
        frmClose.Image = New Bitmap(My.Resources.Close_1)
    End Sub

    Private Sub frmClose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles frmClose.MouseLeave
        frmClose.Image = New Bitmap(My.Resources.Close)
    End Sub
    'Close Button'
#End Region

#Region "Form Events"

    Private Sub InsertDialog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Select Case My.Settings.Language
            Case 0
                English()

            Case 1
                Bulgarian()
        End Select
    End Sub

#Region "Insert Image"
    'Add the script for link section!!!
    Sub ImageScript()
        ImgTextEditor.Text =
            "<img src=""" & txtImgSrc.Text & """" & vbCrLf &
            "width=""" & txtImgWidth.Text & """ height=""" & txtImgHeight.Text & """" & " align=""" & cmbImgAlign.SelectedItem & """" & " hspace=""" & txtImgHSpace.Text & """" & " vspace=""" & txtImgVSpace.Text & """" & " border=""" & txtImgBorder.Text & """" & vbCrLf &
            "alt=""" & txtImgAlt.Text & """" & " id=""" & txtImgID.Text & """" & " class=""" & txtImgClass.Text & """" & " />"
    End Sub

    Private Sub ImgNumericValuesTxts_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImgWidth.KeyPress, txtImgHeight.KeyPress, txtImgVSpace.KeyPress, txtImgHSpace.KeyPress, txtImgBorder.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            txtImgWidth.Text = ""
            txtImgHeight.Text = ""
            txtImgVSpace.Text = ""
            txtImgHSpace.Text = ""
            txtImgBorder.Text = ""
            e.Handled = True
        End If
    End Sub

    Private Sub btnBrowseImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseImage.Click
        If OFDImage.ShowDialog = Windows.Forms.DialogResult.OK Then

            ImgPreview.Image = Image.FromFile(OFDImage.FileName)
            Dim URI As New Uri(Path.GetDirectoryName(OFDImage.FileName))
            txtImgSrc.Text = URI.AbsoluteUri
            txtImgSrc.Text = txtImgSrc.Text & "/" & Path.GetFileName(OFDImage.FileName)

            Dim BMP As New Bitmap(OFDImage.FileName)
            txtImgWidth.Text = BMP.Width
            txtImgHeight.Text = BMP.Height

            txtImgVSpace.Text = "0"
            txtImgHSpace.Text = "0"
            txtImgBorder.Text = "0"
            txtImgAlt.Text = ""
            txtImgID.Text = ""
            txtImgClass.Text = ""
            cmbImgAlign.SelectedItem = "Default"

            ImageScript()
        End If
    End Sub

    Private Sub txtImgSrc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImgSrc.TextChanged
        If txtImgSrc.Text = String.Empty Then
            Dim URI As New Uri(Path.GetDirectoryName(OFDImage.FileName))
            txtImgSrc.Text = URI.AbsoluteUri
            txtImgSrc.Text = txtImgSrc.Text & "/" & Path.GetFileName(OFDImage.FileName)
        Else
            ImageScript()
        End If
    End Sub

    Private Sub txtImgLink_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImgLink.TextChanged
        If txtImgLink.Text = String.Empty Then
            Dim LinkStart As String = "<a href=""" & txtImgLink.Text & """>"
            Dim LinkEnd As String = "</a>"
        Else

        End If
    End Sub

    Private Sub txtImgWidth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImgWidth.TextChanged
        Dim BMP As New Bitmap(OFDImage.FileName)
        If txtImgWidth.Text = String.Empty Then
            txtImgWidth.Text = BMP.Width
        Else
            ImageScript()
        End If
    End Sub

    Private Sub txtImgHeight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImgHeight.TextChanged
        Dim BMP As New Bitmap(OFDImage.FileName)
        If txtImgHeight.Text = String.Empty Then
            txtImgHeight.Text = BMP.Height
        Else
            ImageScript()
        End If
    End Sub

    Private Sub txtImgVSpace_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImgVSpace.TextChanged
        If txtImgVSpace.Text = String.Empty Then
            txtImgVSpace.Text = "0"
        Else
            ImageScript()
        End If
    End Sub

    Private Sub txtImgHSpace_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImgHSpace.TextChanged
        If txtImgHSpace.Text = String.Empty Then
            txtImgHSpace.Text = "0"
        Else
            ImageScript()
        End If
    End Sub

    Private Sub txtImgBorder_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImgBorder.TextChanged
        If txtImgBorder.Text = String.Empty Then
            txtImgBorder.Text = "0"
        Else
            ImageScript()
        End If
    End Sub

    Private Sub txtImgAlt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImgAlt.TextChanged
        If txtImgAlt.Text = String.Empty Then
            txtImgAlt.Text = " "
        Else
            ImageScript()
        End If
    End Sub

    Private Sub txtImgID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImgID.TextChanged
        If txtImgID.Text = String.Empty Then
            txtImgID.Text = " "
        Else
            ImageScript()
        End If
    End Sub

    Private Sub txtImgClass_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImgClass.TextChanged
        If txtImgClass.Text = String.Empty Then
            txtImgClass.Text = " "
        Else
            ImageScript()
        End If
    End Sub

    Private Sub cmbImgAlign_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbImgAlign.SelectedIndexChanged
        ImageScript()
    End Sub

    Private Sub btnCopyImgCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyImgCode.Click
        Try
            Timer.Enabled = True
            lblMsg1.Visible = True

            ImgTextEditor.SelectAll()
            My.Computer.Clipboard.SetText(ImgTextEditor.Text)
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "Insert Media"

    'Video To be fixed
#Region "Video"
    Dim type As String
    Dim vidcontrols As String = " "
    Dim autoplay As String = " "
    Dim vidloop As String = " "

    Sub VideoScript()
        VideoTextEditor.Text =
            "<video" & " width=""" & txtVidWidth.Text & """" & " height=""" & txtVidHeight.Text & """" & vidcontrols & autoplay & vidloop & ">" & vbCrLf &
            "<source" & " src=""" & txtVidSrc.Text & """" & " type=""" & type & """>" & vbCrLf &
            "</video>"
    End Sub

    Private Sub VidNumericValuesTxts_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVidHeight.KeyPress, txtVidWidth.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            txtVidWidth.Text = ""
            txtVidHeight.Text = ""
            e.Handled = True
        End If
    End Sub

    Private Sub btnBrowseVideo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseVideo.Click
        If OFDVideo.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim URI As New Uri(Path.GetDirectoryName(OFDVideo.FileName))
            txtVidSrc.Text = URI.AbsoluteUri
            txtVidSrc.Text = txtVidSrc.Text & "/" & Path.GetFileName(OFDVideo.FileName)

            If txtVidSrc.Text.Contains("mp4") Then
                type = "video/mp4"
            ElseIf txtVidSrc.Text.Contains("ogg") Then
                type = "video/ogg"
            End If

            vidPreview.URL = OFDVideo.FileName

            txtVidWidth.Text = "480"
            txtVidHeight.Text = "300"

            VideoScript()
        End If
    End Sub

    Private Sub txtVidSrc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVidSrc.TextChanged
        If txtVidSrc.Text = String.Empty Then
            Dim URI As New Uri(Path.GetDirectoryName(OFDVideo.FileName))
            txtVidSrc.Text = URI.AbsoluteUri
            txtVidSrc.Text = txtVidSrc.Text & "/" & Path.GetFileName(OFDVideo.FileName)
        Else
            VideoScript()
        End If

    End Sub

    Private Sub txtVidWidth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVidWidth.TextChanged
        If txtVidWidth.Text = String.Empty Then
            txtVidWidth.Text = "480"
        Else
            VideoScript()
        End If
    End Sub

    Private Sub txtVidHeight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVidHeight.TextChanged
        If txtVidHeight.Text = String.Empty Then
            txtVidHeight.Text = "300"
        Else
            VideoScript()
        End If
    End Sub

    'Fix the checkboxes'
    Private Sub ChkBoxVidControls_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkBoxVIdControls.CheckedChanged
        If ChkBoxVIdControls.Checked = True Then
            vidcontrols &= " controls "
        End If
    End Sub

    Private Sub ChkBoxVidAutoplay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkBoxVIdAutoplay.CheckedChanged

    End Sub

    Private Sub ChkBoxVidLoop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkBoxVIdLoop.CheckedChanged

    End Sub

    Private Sub btnCopyVidCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyVidCode.Click
        Try
            Timer.Enabled = True
            lblMsg2.Visible = True

            VideoTextEditor.SelectAll()
            My.Computer.Clipboard.SetText(VideoTextEditor.Text)
        Catch ex As Exception
        End Try
    End Sub
#End Region


#Region "YouTube Video"

    Sub YouTubeVideoScript()
        YTVidTextEditor.Text =
            "<iframe " & "width=""" & txtYTVIdWidth.Text & """ height =""" & txtYTVIdHeight.Text & """ src=""https://www.youtube.com/embed/" & txtYTVidSrc.Text & """ frameborder=""0"" </iframe>"
    End Sub

    Private Sub YTVidNumericValuesTxts_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtYTVIdWidth.KeyPress, txtYTVIdHeight.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            txtYTVIdWidth.Text = ""
            txtYTVIdHeight.Text = ""
            e.Handled = True
        End If
    End Sub

    Private Sub txtYTVidSrc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtYTVidSrc.GotFocus
        If txtYTVidSrc.Text = "Put YouTube link here..." Then
            txtYTVidSrc.Text = ""
        End If
    End Sub

    Private Sub txtYTVidSrc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtYTVidSrc.LostFocus
        If txtYTVidSrc.Text = "" Then
            txtYTVidSrc.Text = "Put YouTube link here..."
        End If
    End Sub

    Private Sub txtYTVidSrc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtYTVidSrc.TextChanged
        If txtYTVidSrc.Text = "Put YouTube link here..." Or txtYTVidSrc.Text = "" Then
        Else
            YouTubeVideoScript()
            txtYTVIdWidth.Text = "560"
            txtYTVIdHeight.Text = "315"
        End If
    End Sub

    Private Sub txtYTVIdWidth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtYTVIdWidth.TextChanged
        If txtYTVIdWidth.Text = String.Empty Then
            txtYTVIdWidth.Text = "560"
        Else
            YouTubeVideoScript()
        End If
    End Sub

    Private Sub txtYTVIdHeight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtYTVIdHeight.TextChanged
        If txtYTVIdHeight.Text = String.Empty Then
            txtYTVIdHeight.Text = "315"
        Else
            YouTubeVideoScript()
        End If
    End Sub

    Private Sub btnCopyYTVidCode_Click(sender As Object, e As EventArgs) Handles btnCopyYTVidCode.Click
        Try
            Timer.Enabled = True
            lblMsg3.Visible = True

            YTVidTextEditor.SelectAll()
            My.Computer.Clipboard.SetText(YTVidTextEditor.Text)
        Catch ex As Exception
        End Try
    End Sub

#End Region


#Region "Audio"

#End Region


#Region "SWF"

#End Region


#Region "SVG"

#End Region


#Region "SVG"

#End Region


#End Region

#Region "Insert Table"

#End Region

#Region "Insert Form"

#End Region

#Region "Insert HyperLink"

#End Region

#Region "Insert Char"

#End Region

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        lblMsg1.Visible = False
        lblMsg2.Visible = False
        lblMsg3.Visible = False
    End Sub

#End Region

#Region "Languages"

    Sub English()

        lblInsert.Text = "Insert..."

        ImageTabPage.Text = "Insert Image"
        Label1.Text = "Browse Image"
        Label14.Text = "* If your image is from Internet source, please insert the link for the image in ""Src"" field."
        btnCopyImgCode.Text = "Copy the code"

        MediaTabPage.Text = "Insert Media"

        VideoTabPage.Text = "Video"
        Label16.Text = "Browse video"
        btnCopyVidCode.Text = "Copy the code"

        YouTubeTabPage.Text = "YouTube video"
        btnCopyYTVidCode.Text = "Copy the code"

        AudioTabPage.Text = "Audio"
        SWFTabPage.Text = "SWF"
        SVGTabPage.Text = "SVG"
        GMapsTabPage.Text = "Google Maps"

        TableTabPage.Text = "Insert Table"
        btnGenerateTable.Text = "Generate"
        btnCopyTableCode.Text = "Copy the code"

        FormTabPage.Text = "Insert Form"
        CharTabPage.Text = "Insert Char"

        Dim InDevTextEN = "In development. Coming Soon!"
        lblInDev1.Text = InDevTextEN
        Label28.Text = InDevTextEN
        Label29.Text = InDevTextEN
        Label30.Text = InDevTextEN
        Label31.Text = InDevTextEN
        Label32.Text = InDevTextEN
        Label33.Text = InDevTextEN

        Dim lblMsg As String = "The code is copied"
        lblMsg1.Text = lblMsg
        lblMsg2.Text = lblMsg
        lblMsg3.Text = lblMsg

    End Sub

    Sub Bulgarian()

        lblInsert.Text = "Вмъкни..."

        ImageTabPage.Text = "Изображение"
        Label1.Text = "Избери..."
        Label14.Text = "* Ако източникът е Интернет, поставете пърният адрес на изображението."
        btnCopyImgCode.Text = "Копирай кода"

        MediaTabPage.Text = "Медия..."

        VideoTabPage.Text = "Видео"
        Label16.Text = "Избери..."
        btnCopyVidCode.Text = "Копирай кода"

        YouTubeTabPage.Text = "YouTube видео"
        btnCopyYTVidCode.Text = "Копирай кода"

        AudioTabPage.Text = "Аудио"
        SWFTabPage.Text = "SWF"
        SVGTabPage.Text = "SVG"
        GMapsTabPage.Text = "Google Карти"

        TableTabPage.Text = "Таблица"
        btnGenerateTable.Text = "Генерирай"
        btnCopyTableCode.Text = "Копирай кода"

        FormTabPage.Text = "Форма"
        CharTabPage.Text = "Символ"

        Dim InDevTextBG = "В процес на разработка. " & vbCrLf & " Очаквайте скоро!"
        lblInDev1.Text = InDevTextBG
        Label28.Text = InDevTextBG
        Label29.Text = InDevTextBG
        Label30.Text = InDevTextBG
        Label31.Text = InDevTextBG
        Label32.Text = InDevTextBG
        Label33.Text = InDevTextBG

        Dim lblMsg As String = "Кодът е копиран"
        lblMsg1.Text = lblMsg
        lblMsg2.Text = lblMsg
        lblMsg3.Text = lblMsg

    End Sub

#End Region

End Class