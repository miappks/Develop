Public Class DesignerButton
    Inherits Windows.Forms.Button

    Public Sub New()
        Me.BackColor = SystemColors.ActiveCaption
        Me.FlatStyle = FlatStyle.Popup
        Me.Size = New Size(10, 10)
        Me.Text = ""
    End Sub
End Class
