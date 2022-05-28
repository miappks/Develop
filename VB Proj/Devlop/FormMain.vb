' Manager.vb
' This file contains:
'
' Class Develop.FormMain

Imports System.ComponentModel
Imports Develop.Core

''' <summary>
''' The main UI for the program.
''' </summary>
Public Class FormMain
    Public _manager As Manager
    Dim _designer As New Blank("Blank")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelLeft.Width = My.Settings.PanelLeftWidth

        _manager = New Manager(_designer, PropertyGrid, NameBox)

        _designer._manager = _manager


        _designer.Location = New Point(10, 10)
        _designer.MdiParent = Me
        SplitContainer1.Panel1.Controls.Add(_designer)
        _designer.Show()

        Dim codeEditor = New CodeEditor(_manager)
        codeEditor.Dock = DockStyle.Fill
        SplitContainer1.Panel2.Controls.Add(codeEditor)

        Dim toolbox = New ToolBox()
        toolbox.Dock = DockStyle.Fill
        ToolboxTab.Controls.Add(toolbox)


        ToolList.Items = ControlCreater.Names.OrderBy(Function(x) x).ToArray
        PropertyGrid.SelectedObject = _manager.DesignerForm
        NameBox.Text = _manager.DesignerForm.Name

        AddHandler _manager.ControlAdded, AddressOf ReloadHierarchie
        AddHandler _manager.ControlRemoved, AddressOf ReloadHierarchie
        AddHandler _manager.ControlNameChanged, AddressOf ReloadHierarchie
        AddHandler _manager.ControlHierarchieChanged, AddressOf ReloadHierarchie

        ReloadHierarchie()

    End Sub

    Private Sub ReloadHierarchie()

        HierarchieTreeView.Nodes.Clear()

        Dim root As New TreeNode(_manager.DesignerForm.Name & "   (" & GetType(Form).FullName & ")") With {.Tag = "[DESIGNER]"}

        For Each control In _manager.DesignerForm.Controls
            If control.GetType IsNot GetType(DevelopControls.DesignerButton) Then
                Dim subNodes = LoopRecursiveHierarchieTree(New TreeNode(control.Name & "   (" & If(control.GetType Is GetType(DevelopControls.CustomDesignerControl), "Custom " & DirectCast(control, DevelopControls.CustomDesignerControl).ControlClassName, control.GetType.FullName) & ")") With {.Tag = control.Name}, control)
                root.Nodes.Add(subNodes)
            End If
        Next

        HierarchieTreeView.Nodes.Add(root)
        ' HierarchieTreeView.Sort()
        HierarchieTreeView.ExpandAll()
    End Sub

    Private Function LoopRecursiveHierarchieTree(root As TreeNode, control As Control) As TreeNode
        For Each subControl As Control In control.Controls
            If subControl.GetType IsNot GetType(DevelopControls.DesignerButton) Then
                Dim subNode = New TreeNode(subControl.Name & "   (" & If(control.GetType Is GetType(DevelopControls.CustomDesignerControl), "Custom " & DirectCast(subControl, DevelopControls.CustomDesignerControl).ControlClassName, subControl.GetType.FullName) & ")") With {.Tag = subControl.Name}
                subNode = LoopRecursiveHierarchieTree(subNode, subControl)
                root.Nodes.Add(subNode)
            End If
        Next
        Return root
    End Function

    Private Sub ToolList_ItemClick(sender As Object, item As String) Handles ToolList.ItemClick

        Try
            _manager.AddControl(ControlCreater.CreatControlToContainer(item, _designer))
        Catch ex As Exception
            ' MsgBox("Error in creating control!")
        End Try
    End Sub

    Private Sub TestRun()
        CompileTo("temp.exe")
    End Sub

    Private Sub BuildExecutable()
        SaveDialog.Filter = "Executable|*.exe"
        If SaveDialog.ShowDialog() = DialogResult.Cancel Then Exit Sub

        CompileTo(SaveDialog.FileName)
    End Sub

    Private Sub CompileTo(name As String)
        If IO.File.Exists(name) And New IO.FileInfo(name).IsFileOpen Then
            MsgBox("Die Datei ist bereits geöffnet", vbCritical)
            Exit Sub
        End If

        Status.Text = "Compiling..."
        Progress.Style = ProgressBarStyle.Marquee

        'Show output Code in Editor
        'Try
        '    IO.File.WriteAllText("out.txt", New CodeGenerator(_manager).Generate)
        '    Process.Start("out.txt")
        'Catch : End Try



        Dim compiler = New CodeCompiler(New CodeGenerator(_manager).Generate, _manager)
        compiler.Compile(name)
        Progress.Style = ProgressBarStyle.Blocks

        DialogError.ListBox1.Items.Clear()

        If compiler.Errors.Count <> 0 Then
            For Each er As CodeDom.Compiler.CompilerError In compiler.Errors
                DialogError.ListBox1.Items.Add(
                    "Error " & er.ErrorNumber & ": " & vbCrLf & er.ErrorText)
            Next
            DialogError.ShowDialog()
        Else
            Status.Text = "Compiled, running..."

            ' no debug for now

            Process.Start(name)

        End If
        Status.Text = "Ready"

    End Sub

    Private Sub Save()
        SaveDialog.Filter = "Xml form data|*.xml"
        If SaveDialog.ShowDialog() = DialogResult.Cancel Then Exit Sub

        Dim s As New IO.StreamWriter(SaveDialog.FileName)
        s.Write(New XmlSaver(_manager).CompileToXml())
        s.Flush()
        s.Close()
    End Sub

    Private Sub Settings_Click(sender As Object, e As EventArgs) Handles Settings.Click
        ProjSettings()
    End Sub

    Private Sub ProjSettings()
        Dim ref As New ProjectSettings(_manager)
        ref.ShowDialog()
    End Sub

    Private Sub Open()
        If OpenDialog.ShowDialog() = DialogResult.Cancel Then Exit Sub
        Dim x As New XmlLoader(_manager)
        x.LoadXml(OpenDialog.FileName)
        PropertyGrid.SelectedObject = _designer
    End Sub

    Private Sub ToolOpen_Click(sender As Object, e As EventArgs) Handles ToolOpen.Click
        Open()
    End Sub

    Private Sub ToolCode_Click(sender As Object, e As EventArgs) Handles ToolCode.Click
        'If ToolCode.Checked Then
        '    'CodeEdit.MManager = _manager
        '    CodeEdit.Show()
        'Else
        '    CodeEdit.Close()
        'End If
        SplitContainer1.Panel2Collapsed = Not SplitContainer1.Panel2Collapsed
    End Sub

    Private Sub ToolBuild_Click(sender As Object, e As EventArgs) Handles ToolBuild.Click
        BuildExecutable()
    End Sub

    Private Sub ToolTest_Click(sender As Object, e As EventArgs) Handles ToolTest.Click
        TestRun()
    End Sub

    Private Sub ToolStripSave_Click(sender As Object, e As EventArgs) Handles ToolStripSave.Click
        Save()
    End Sub

    Private Sub FormMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.PanelLeftWidth = PanelLeft.Width
        My.Settings.Save()

        _designer.DisableClosing = False
        _designer.Close()
    End Sub

    Private Sub HierarchieTreeView_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles HierarchieTreeView.AfterSelect

        Dim ctrlName = HierarchieTreeView.SelectedNode.Tag
        If ctrlName = "[DESIGNER]" Then
            _manager.FocusControl(_manager.DesignerForm)
            Exit Sub
        End If

        Dim control As Control = ControlSearch.FindControl(_manager.DesignerForm, ctrlName)
        If control IsNot Nothing Then _manager.FocusControl(control)
    End Sub

    Private Sub ShowHideDesigner_Click(sender As Object, e As EventArgs) Handles ShowHideDesigner.Click
        SplitContainer1.Panel1Collapsed = Not SplitContainer1.Panel1Collapsed
    End Sub
End Class
