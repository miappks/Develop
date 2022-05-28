Imports System.ComponentModel

Public Class Blank
    Public DisableClosing = True

    Public _manager As Develop.Core.Manager

    Sub New(name As String)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        Me.Name = name
    End Sub

    Private Sub Blank_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = DisableClosing
    End Sub

    Private Sub Blank_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        If e.Data.GetDataPresent(GetType(Silver.UI.ToolBoxItem)) Then
            e.Effect = DragDropEffects.None
            Cursor.Current = Cursors.WaitCursor
            Dim dragedItem As Silver.UI.ToolBoxItem = e.Data.GetData(GetType(Silver.UI.ToolBoxItem))
            If dragedItem Is Nothing Then Exit Sub

            Try
                _manager.AddControl(Develop.Core.ControlCreater.CreatControlToContainer(dragedItem.Caption, _manager.DesignerForm, _manager.DesignerForm.PointToClient(Cursor.Position)))
            Catch ex As Exception
                ' MsgBox("Error in creating control!")
            End Try

            Cursor.Current = Cursors.Default
        End If
    End Sub

    Private Sub Blank_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(GetType(Silver.UI.ToolBoxItem)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
End Class