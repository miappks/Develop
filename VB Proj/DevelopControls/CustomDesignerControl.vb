Public Class CustomDesignerControl
    Inherits Panel

    Private _ControlName As String

    Public Sub New(controlName As String)
        If String.IsNullOrEmpty(controlName) Then
            Me.ControlClassName = "System.Windows.Forms.Panel"
        Else
            Me.ControlClassName = controlName
        End If

        Me.BackColor = SystemColors.ControlLight
        Me.BorderStyle = BorderStyle.FixedSingle

    End Sub

    Public Property ControlClassName As String
        Get
            Return _ControlName
        End Get
        Set(value As String)
            Dim formattedClassName = value.Trim.Replace(" ", "")
            If Not String.IsNullOrEmpty(formattedClassName) Then _ControlName = formattedClassName
            Me.Refresh()
        End Set
    End Property

    Private Sub CustomDesignerControl_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.DrawString(ControlClassName, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(5, 5))
    End Sub
End Class
