Imports System.ComponentModel

Public Class FlatPanel
    Inherits System.Windows.Forms.Panel

    Public Sub New()
        Me.Size = New Size(200, 20)
        Me.BackColor = Color.White

        Dim Up As New Panel
        Dim Down As New Panel
        Dim Left As New Panel
        Dim Right As New Panel

        Up.BackColor = Color.Black
        Down.BackColor = Color.Black
        Left.BackColor = Color.Black
        Right.BackColor = Color.Black

        Up.Height = 1
        Down.Height = 1
        Left.Width = 1
        Right.Width = 1

        Up.Dock = DockStyle.Top
        Down.Dock = DockStyle.Bottom
        Left.Dock = DockStyle.Left
        Right.Dock = DockStyle.Right

        Me.Controls.Add(Up)
        Me.Controls.Add(Down)
        Me.Controls.Add(Left)
        Me.Controls.Add(Right)
    End Sub

End Class
