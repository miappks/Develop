' CtrlCreate.vb
' This file contains:
'
' Class Develop.ControlCreater

Namespace Core
    ''' <summary>
    ''' Static class to create controls by type name.
    ''' </summary>
    Public Class ControlCreater

        ' And also add to Select Case Statement by CreateControl
        Public Shared Names As String() = {
            "Button",
            "CheckBox",
            "TextBox",
            "ComboBox",
            "ListBox",
            "ListView",
            "Label",
            "GroupBox",
            "ToolBar",
            "Menu",
            "TabControl",
            "PictureBox",
            "ProgressBar",
            "RadioButton",
            "RichtextBox",
            "TreeView",
            "FlowLayoutPanel",
            "GroupBox",
            "Panel",
            "TableLayoutPanel",
            "SplitContainer",
            "Custom"
            }

        'Private Shared ctrls As Type() = {
        '    GetType(Button),
        '    GetType(CheckBox),
        '    GetType(TextBox),
        '    GetType(ComboBox),
        '    GetType(ListBox),
        '    GetType(Label),
        '    GetType(GroupBox),
        '    GetType(ToolBar),
        '    GetType(ToolStripDropDownMenu)
        '}



        ''' <summary>
        ''' Create a contol of given type to the given container.
        ''' </summary>
        ''' <param name="str">The type string of the control to create. </param>
        ''' <param name="cont">The container which the control will create to. </param>
        ''' <returns>The created control. </returns>
        ''' <exception cref="System.NotSupportedException"/>
        Public Shared Function CreatControlToContainer(str As String, cont As Control, Optional location As Point = Nothing) As Control
            Dim ctrl As Control = CreateControl(str)
            If ctrl Is Nothing Then Return Nothing
            Dim ctrlType = ctrl.GetType
            Dim ctrlTypeName = ctrlType.Name
            If ctrl.GetType Is GetType(DevelopControls.CustomDesignerControl) Then ctrlTypeName = DirectCast(ctrl, DevelopControls.CustomDesignerControl).ControlClassName.Split(".").Last

            Dim ctrlCount = 1
            For Each control In cont.Controls
                If control.GetType Is ctrlType Then ctrlCount += 1
            Next

            'If ctrl.GetType.Name = GetType(Button).Name Then 'Weil Sizer auch ein Button ist
            '    Try
            '        ctrlCount = ctrlCount - cont.Controls.Count / 2
            '    Catch : End Try

            'End If

            'Wegen CustomControls Klassen, nur nach dem zählen weil viel Rechenintensiver
            While ControlSearch.FindControl(cont, ctrlTypeName & ctrlCount.ToString) IsNot Nothing
                ctrlCount += 1
            End While

            ctrl.Name = ctrlTypeName & ctrlCount.ToString
            ctrl.Text = ctrl.Name
            ctrl.Location = If(location = Nothing Or location = New Point(0, 0), New Point(10, 10), location)
            cont.Controls.Add(ctrl)
            Return ctrl
        End Function

        ''' <summary>
        ''' Create a contol of given type.
        ''' </summary>
        ''' <param name="str">The type string of the control to create. </param>
        ''' <returns>The created control. </returns>
        ''' <exception cref="System.NotSupportedException"/>
        Public Shared Function CreateControl(str As String) As Control
            'Try
            '    Dim ctrl As Control, index As Integer
            '    index = FindIn(str, Names)
            '    ''-------------------------- Danger Zone -------------------------------------
            '    'ctrl = DirectCast(ctrls(Index).GetConstructor({}).Invoke(Nothing), Control) '|
            '    ''-------------- Are there anything better than this? ------------------------
            'Catch ex As Exception
            '    Throw New NotSupportedException
            'End Try

            Select Case str
                Case "Button"
                    Dim btn = New Button
                    btn.UseVisualStyleBackColor = True
                    Return btn
                Case "CheckBox"
                    Return New CheckBox
                Case "TextBox"
                    Return New TextBox
                Case "ComboBox"
                    Return New ComboBox
                Case "ListBox"
                    Return New ListBox
                Case "ListView"
                    Return New ListView
                Case "Label"
                    Return New Label
                Case "GroupBox"
                    Return New GroupBox
                Case "ToolBar"
                    Return New ToolBar
                Case "Menu"
                    Return New ToolStripDropDownMenu
                Case "TabControl"
                    Dim tbC = New TabControl
                    tbC.TabPages.Add(New TabPage("TabPage1") With {.BackColor = Color.White})
                    tbC.TabPages.Add(New TabPage("TabPage2") With {.BackColor = Color.White})
                    Return tbC

                Case "PictureBox"
                    Return New PictureBox
                Case "ProgressBar"
                    Return New ProgressBar
                Case "RadioButton"
                    Return New RadioButton
                Case "RichtextBox"
                    Return New RichTextBox
                Case "TreeView"
                    Return New TreeView
                Case "FlowLayoutPanel"
                    Return New FlowLayoutPanel
                Case "GroupBox"
                    Return New GroupBox
                Case "Panel"
                    Return New Panel
                Case "TableLayoutPanel"
                    Return New TableLayoutPanel
                Case "SplitContainer"
                    Return New SplitContainer


                Case "Custom"
                    Dim customControlClassName = InputBox("Klassenname eingeben. bzw. Button oder " & "System.Windows.Forms.Button" & vbNewLine & vbNewLine & "Auf Gross- und Kleinschreibung achten")
                    If String.IsNullOrEmpty(customControlClassName) Then Return Nothing

                    str = customControlClassName
                    GoTo elseStatement

                Case Else
elseStatement:
                    If String.IsNullOrEmpty(str) Then Return Nothing

                    Try
                        Dim script = "return new " & str & If(str.EndsWith("()"), "", "()") & ";"
                        ' Dim options = New Microsoft.CodeAnalysis.Scripting.ScriptOptions

                        Dim getControlTask = Microsoft.CodeAnalysis.CSharp.Scripting.CSharpScript.EvaluateAsync(script, Microsoft.CodeAnalysis.Scripting.ScriptOptions.Default.WithReferences("System.Windows.Forms").WithImports("System.Windows.Forms"))
                        Dim ctrl = Task.Run(Of Object)(Async Function() Await getControlTask).Result
                        If TryCast(ctrl, Control) IsNot Nothing Then Return ctrl
                    Catch : End Try
                    Return New DevelopControls.CustomDesignerControl(str)

            End Select


            Return Nothing
        End Function

        Private Shared Function FindIn(str As String, arr As String()) As Integer
            For i As Integer = 0 To arr.Count - 1
                If arr(i) = str Then Return i
            Next
            Return -1
        End Function
    End Class
End Namespace
