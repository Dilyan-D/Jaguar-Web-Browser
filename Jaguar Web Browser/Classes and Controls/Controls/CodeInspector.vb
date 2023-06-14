Imports System.ComponentModel

Public Class CodeInspector

#Region "Form Design"

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Dim ScreenWidth = Screen.PrimaryScreen.Bounds.Width
    Dim ScreenHeight = My.Computer.Screen.Bounds.Height - (My.Computer.Screen.Bounds.Height - My.Computer.Screen.WorkingArea.Height)

    Private Sub ResizeButton_LoadCompleted(sender As Object, e As AsyncCompletedEventArgs) Handles ResizeButton.LoadCompleted
        If Me.Size <> New Size(ScreenWidth, ScreenHeight) Then
            ResizeButton.Image = New Bitmap(My.Resources.Maximize)
        Else
            ResizeButton.Image = New Bitmap(My.Resources.Normal)
        End If
    End Sub

    Private Sub ResizeButton_Click(sender As Object, e As EventArgs) Handles ResizeButton.Click
        If Me.Size <> New Size(ScreenWidth, ScreenHeight) Then
            ResizeButton.Image = New Bitmap(My.Resources.Normal)
            Maximize()
        Else
            ResizeButton.Image = New Bitmap(My.Resources.Maximize)
            Normalize()
        End If
    End Sub

    Private Sub ResizeButton_MouseHover(sender As Object, e As EventArgs) Handles ResizeButton.MouseHover
        If Me.Size <> New Size(ScreenWidth, ScreenHeight) Then
            ResizeButton.Image = New Bitmap(My.Resources.Maximize_1)
        Else
            ResizeButton.Image = New Bitmap(My.Resources.Normal_1)
        End If
    End Sub

    Private Sub ResizeButton_MouseLeave(sender As Object, e As EventArgs) Handles ResizeButton.MouseLeave
        If Me.Size <> New Size(ScreenWidth, ScreenHeight) Then
            ResizeButton.Image = New Bitmap(My.Resources.Maximize)
        Else
            ResizeButton.Image = New Bitmap(My.Resources.Normal)
        End If
    End Sub

    Sub Maximize()
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = My.Computer.Screen.Bounds.Height - (My.Computer.Screen.Bounds.Height - My.Computer.Screen.WorkingArea.Height)
        Me.Location = Screen.GetWorkingArea(Me).Location
    End Sub

    Sub Normalize()
        Me.Location = New Point(80, 80)
        Me.Width = 1000
        Me.Height = 600
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


#End Region

#Region "Form Events"

    Private Sub CodeInspector_Load(sender As Object, e As EventArgs) Handles CodeInspector.Load

    End Sub

#End Region
End Class