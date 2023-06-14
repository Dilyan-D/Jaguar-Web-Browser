Imports System.Net
Imports System.IO

Public Class MHPBookmark

    Private Enum Exec
        OLECMDID_OPTICAL_ZOOM = 63
    End Enum

    Private Enum ExecOpt
        OLECMDEXECOPT_DODEFAULT = 0
        OLECMDEXECOPT_PROMPTUSER = 1
        OLECMDEXECOPT_DONTPROMPTUSER = 2
        OLECMDEXECOPT_SHOWHELP = 3
    End Enum

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        MainForm.MHPFlowLayoutPanel.Controls.Remove(Me)
    End Sub

    Private Sub WebView_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebView.DocumentCompleted

        Try
            Dim Res As Object = Nothing
            Dim MyWeb As Object
            MyWeb = Me.WebView.ActiveXInstance
            MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, ExecOpt.OLECMDEXECOPT_DONTPROMPTUSER, 15, IntPtr.Zero)
        Catch ex As Exception
            MsgBox("Error:" & ex.Message)
        End Try

        CType(WebView, Control).Enabled = False

        Try
            Dim url As Uri = New Uri(WebView.Url.AbsoluteUri)
            Dim iconURL = "http://" & url.Host & "/favicon.ico"
            Dim request As WebRequest = HttpWebRequest.Create(iconURL)
            Dim response As HttpWebResponse = request.GetResponse()
            Dim stream As Stream = response.GetResponseStream()
            Dim favicon = Image.FromStream(stream)
            pbFavicon.Image = favicon
        Catch ex As Exception
            pbFavicon.Image = Nothing
        End Try

    End Sub

    Private Sub MHPBookmark_Click(sender As Object, e As EventArgs) Handles Me.Click
        MainForm.NewTab()

    End Sub
End Class