Public Class CodeEditor

    Dim _manager As Develop.Core.Manager
    Dim _autofinish As Develop.Editing.AutoFinish

    Public Property MManager() As Develop.Core.Manager
        Get
            Return _manager
        End Get
        Set(ByVal value As Develop.Core.Manager)
            _manager = value
            Editor.AllText = value.UserCode
        End Set
    End Property

    Sub New(manager As Develop.Core.Manager)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        MManager = manager

        AddHandler MManager.UserCodeChanged, AddressOf Code_Changed

        Editor.AllText = MManager.UserCode
        Editor.ColorTable = New List(Of Color)(Develop.Editing.Keywords.ColorTable)
        Editor.HighlightRules =
                New List(Of KeyValuePair(Of String, Integer))(Develop.Editing.Keywords.RuleTable)
        _autofinish = New Develop.Editing.AutoFinish(Editor, ImageList1, FormMain._manager.ImportStatments.ToArray)
    End Sub

    Private Sub RichTextBox1_SelectionChanged(sender As Object, e As EventArgs) Handles Editor.SelectionChanged
        LineLabel.Text = "Line: " & Editor.CurrentCursor.Y
        RowLabel.Text = "Row: " & Editor.CurrentCursor.X
    End Sub

    Private Sub RebuildData_Click(sender As Object, e As EventArgs) Handles RebuildData.Click
        _autofinish.RebuildResolver()
    End Sub

    Private Sub Editor_TextChanged(sender As Object, e As EventArgs) Handles Editor.TextChanged
        locked = True
        MManager.UserCode = Editor.AllText
        locked = False
    End Sub

    Dim locked As Boolean = False
    Private Sub Code_Changed(oldVal As String, newVal As String)
        If locked Then Exit Sub

        Editor.AllText = MManager.UserCode
    End Sub


End Class
