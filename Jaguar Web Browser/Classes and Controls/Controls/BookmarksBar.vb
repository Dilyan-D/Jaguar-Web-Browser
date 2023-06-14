Public Class BookmarksBar
    Inherits ToolStrip

    Public Sub New()
        MyBase.New()
        Me.BackColor = Color.FromArgb(227, 230, 232)
        Me.Dock = DockStyle.Top
        GripStyle = ToolStripGripStyle.Hidden
        LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow
        RenderMode = ToolStripRenderMode.Professional

    End Sub
End Class
