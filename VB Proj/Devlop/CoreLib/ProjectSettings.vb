' ProjectSettings.vb
' This file contains:
'
' Class Develop.ProjectSettings

Imports Develop.Core

''' <summary>
''' Form to edit project settings.
''' </summary>
Public Class ProjectSettings
    Dim _manager As Manager

    Public Sub New(man As Manager)
        ' 此调用是设计器所必需的。
        InitializeComponent()

        ListView1.Clear()

        For Each ref In man.References
            ListView1.Items.Add(ref)
        Next

        ListView2.Clear()

        For Each ref In man.ImportStatments
            ListView2.Items.Add(ref)
        Next

        EnableVisualStyles.Checked = man.ApplicationFrameworkSettings.EnableVisualStyles
        CompatibleTextRendering.Checked = man.ApplicationFrameworkSettings.SetCompatibleTextRenderingDefault
        Einzelinstanzanwendung.Checked = man.ApplicationFrameworkSettings.SingleInstanceApplication

        Anwendungsframework.Checked = Not man.ApplicationFrameworkSettings.CustomSubMain
        OwnSubMain.Checked = man.ApplicationFrameworkSettings.CustomSubMain

        GuidTextBox.Text = man.ApplicationFrameworkSettings.GUID
        If Not String.IsNullOrEmpty(man.ApplicationFrameworkSettings.SubMainCode) Then OwnSubMainCode.Text = man.ApplicationFrameworkSettings.SubMainCode

        _manager = man
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ref = InputBox("New Reference", Me.Text).Trim

        If Not _manager.References.Contains(ref) Then If Not String.IsNullOrEmpty(ref) Then ListView1.Items.Add(ref)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each item In ListView1.SelectedIndices
            ListView1.Items.RemoveAt(item)
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim import = InputBox("New Import", Me.Text).Trim
        If Not _manager.ImportStatments.Contains(import) Then If Not String.IsNullOrEmpty(import) Then ListView2.Items.Add(import)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For Each item In ListView2.SelectedIndices
            ListView2.Items.RemoveAt(item)
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        _manager.References.Clear()

        For Each item As ListViewItem In ListView1.Items
            _manager.References.Add(item.Text)
        Next

        _manager.ImportStatments.Clear()

        For Each item As ListViewItem In ListView2.Items
            _manager.ImportStatments.Add(item.Text)
        Next

        _manager.ApplicationFrameworkSettings.EnableVisualStyles = EnableVisualStyles.Checked
        _manager.ApplicationFrameworkSettings.SetCompatibleTextRenderingDefault = CompatibleTextRendering.Checked
        _manager.ApplicationFrameworkSettings.SingleInstanceApplication = Einzelinstanzanwendung.Checked

        _manager.ApplicationFrameworkSettings.GUID = GuidTextBox.Text
        _manager.ApplicationFrameworkSettings.SubMainCode = OwnSubMainCode.Text

        _manager.ApplicationFrameworkSettings.CustomSubMain = OwnSubMain.Checked

        Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
    End Sub


    Private Sub Anwendungsframework_CheckedChanged(sender As RadioButton, e As EventArgs) Handles Anwendungsframework.CheckedChanged
        GroupBoxAWFW.Enabled = sender.Checked
        GroupBoxSubMain.Enabled = Not sender.Checked
    End Sub

    Private Sub OwnSubMain_CheckedChanged(sender As RadioButton, e As EventArgs) Handles OwnSubMain.CheckedChanged
        GroupBoxAWFW.Enabled = Not sender.Checked
        GroupBoxSubMain.Enabled = sender.Checked
    End Sub
End Class