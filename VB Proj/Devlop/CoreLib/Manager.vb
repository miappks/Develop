' Manager.vb
' This file contains:
'
' Class Develop.Core.Manager

Namespace Core
    ''' <summary>
    ''' The main manager of designer interface.
    ''' </summary>
    Public Class Manager
        '  Private ctrlCount As Integer = 0

        Public Event ControlAdded(c As Control)
        Public Event ControlRemoved(c As Control)
        Public Event ControlNameChanged(name As String, c As Control)
        Public Event ControlHierarchieChanged(c As Control)
        Public Event UserCodeChanged(oldCode As String, newCode As String)

        Public SizerCtrlDictionary As Dictionary(Of Control, Control)
        Public DragSupDictionary As Dictionary(Of Control, DragSupporter)
        Public SizeSupDictionary As Dictionary(Of Control, SizeSupporter)
        Public CtrlNameDictionary As Dictionary(Of Control, String)

        Public DesignerForm As Form
        Private _userCode As String

        Public Property UserCode As String
            Get
                Return _userCode
            End Get
            Set(value As String)
                Dim oldVal = _userCode
                _userCode = value
                RaiseEvent UserCodeChanged(oldVal, value)
                oldVal = Nothing
            End Set
        End Property

        Public References As New Specialized.StringCollection
        Public ImportStatments As New List(Of String)
        Public ApplicationFrameworkSettings As ApplicationFrameworkSettings

        Public Property DragEnable(c As Control) As Boolean
            Get
                If Not DragSupDictionary.ContainsKey(c) Then Throw New KeyNotFoundException
                Return DragSupDictionary(c).Enabled
            End Get
            Set(ByVal value As Boolean)
                DragSupDictionary(c).Enabled = value
            End Set
        End Property

        Public Property SizeEnable(c As Control) As Boolean
            Get
                If Not SizeSupDictionary.ContainsKey(c) Then Throw New KeyNotFoundException
                Return SizeSupDictionary(c).Enabled
            End Get
            Set(ByVal value As Boolean)
                SizeSupDictionary(c).Enabled = value
            End Set
        End Property

        Private _propGrid As PropertyGrid
        Private _focusCtrl As Control
        Private WithEvents _nameBox As TextBox

        Public Sub New(F As Form, Prop As PropertyGrid, Txt As TextBox)
            DesignerForm = F
            _propGrid = Prop
            _nameBox = Txt

            SizerCtrlDictionary = New Dictionary(Of Control, Control)
            DragSupDictionary = New Dictionary(Of Control, DragSupporter)
            SizeSupDictionary = New Dictionary(Of Control, SizeSupporter)
            CtrlNameDictionary = New Dictionary(Of Control, String)
            ApplicationFrameworkSettings = New ApplicationFrameworkSettings()

            AddHandler DesignerForm.Click, AddressOf ctrl_Click
            CtrlNameDictionary.Add(DesignerForm, "Blank")

            UserCode = String.Format("Partial Class " & F.Name & "{0}" &
                                     "    {0}" &
                                     "End Class", vbCrLf)

            References.AddRange({"System.dll",
                                     "System.Drawing.dll",
                                     "System.Windows.Forms.dll",
                                     "System.Data.dll",
                                     "Microsoft.VisualBasic.dll"})

            ImportStatments.AddRange({"System",
                                     "System.Drawing",
                                     "System.Windows.Forms",
                                     "System.Data",
                                     "System.Collections",
                                     "System.Collections.Generic",
                                     "Microsoft.VisualBasic"})
        End Sub

        Public Function RemoveControl(c As Control) As Boolean
            Try
                DesignerForm.Controls.Remove(c)
                DesignerForm.Controls.Remove(SizerCtrlDictionary(c))

                SizerCtrlDictionary.Remove(c)
                DragSupDictionary.Remove(c)
                SizeSupDictionary.Remove(c)
                CtrlNameDictionary.Remove(c)

                RaiseEvent ControlRemoved(c)
            Catch ex As Exception
                Return False
            End Try
            Return True
        End Function


        Public Sub AddControl(c As Control)

            If c Is Nothing Then Throw New ArgumentNullException
            If Not DesignerForm.Controls.Contains(c) Then Throw New ArgumentException

            Dim sizer As New DevelopControls.DesignerButton()
            'sizer.BackColor = SystemColors.ActiveCaption
            'sizer.FlatStyle = FlatStyle.Popup
            sizer.Top = c.Top + c.Height
            sizer.Left = c.Left + c.Width
            'sizer.Size = New Size(10, 10)
            'sizer.Text = ""

            Dim ds As New DragSupporter(c)
            Dim ss As New SizeSupporter(c, sizer)

            AddHandler c.MouseUp, AddressOf ctrl_Click
            AddHandler sizer.MouseClick, Sub(sender, e) ctrl_Click(c, e)

            'Context Menu
            Dim sizerContextMnuStrip = New ContextMenuStrip()

            Dim showCode = New ToolStripMenuItem() With {.Text = "Code anzeigen/verstecken"}
            AddHandler showCode.Click, AddressOf sizerAction_ShowCode
            Dim toCode = New ToolStripMenuItem() With {.Text = "Zu Code hinzufügen"}
            AddHandler toCode.Click, Sub(sender, e) sizerAction_toCode(c, e)

            Dim toForeGround = New ToolStripMenuItem() With {.Text = "In den Vordergrund"}
            AddHandler toForeGround.Click, Sub(sender, e) sizerAction_ToForeGround(c, sizer, e)
            Dim toBackground = New ToolStripMenuItem() With {.Text = "In den Hintergrund"}
            AddHandler toBackground.Click, Sub(sender, e) sizerAction_ToBackGround(c, sizer, e)

            Dim toUnderlyingControl = New ToolStripMenuItem() With {.Text = "Zu unterliegendem Control"}
            AddHandler toUnderlyingControl.Click, Sub(sender, e) sizerAction_ToUnderLyingControl(c, sizer)
            Dim awayFromUnderlyingControl = New ToolStripMenuItem() With {.Text = "Weg vom unterliegenden Control"}
            AddHandler awayFromUnderlyingControl.Click, Sub(sender, e) sizerAction_awayFromUnderLyingControl(c, sizer)

            Dim lock_unlock = New ToolStripMenuItem() With {.Text = "Sperren / Entsperren"}
            AddHandler lock_unlock.Click, Sub(sender, e) sizerAction_Lock_Unlock(c, sizer)
            Dim del = New ToolStripMenuItem() With {.Text = "Löschen"}
            AddHandler del.Click, Sub(sender, e) sizerAction_Delete(c, e)

            sizerContextMnuStrip.Items.Add(showCode)
            sizerContextMnuStrip.Items.Add(toCode)
            sizerContextMnuStrip.Items.Add(New ToolStripSeparator())
            sizerContextMnuStrip.Items.Add(toForeGround)
            sizerContextMnuStrip.Items.Add(toBackground)
            sizerContextMnuStrip.Items.Add(New ToolStripSeparator())
            sizerContextMnuStrip.Items.Add(toUnderlyingControl)
            sizerContextMnuStrip.Items.Add(awayFromUnderlyingControl)
            sizerContextMnuStrip.Items.Add(New ToolStripSeparator())
            sizerContextMnuStrip.Items.Add(lock_unlock)
            sizerContextMnuStrip.Items.Add(del)
            sizer.ContextMenuStrip = sizerContextMnuStrip

            DesignerForm.Controls.Add(sizer)
            sizer.BringToFront()
            c.BringToFront()

            SizerCtrlDictionary.Add(c, sizer)
            DragSupDictionary.Add(c, ds)
            SizeSupDictionary.Add(c, ss)
            ' Dim typeName = c.GetType.FullName.Split(".").Last
            'Dim ctrlCount = 0
            'For Each control In DesignerForm.Controls
            '    If control.GetType.Name = c.GetType.Name Then ctrlCount += 1
            'Next
            'If c.GetType.FullName = sizer.GetType.FullName Then
            '    buttonCtrlCount += 1
            '    MsgBox("Button")
            '    ctrlCount = DesignerForm.Controls.Count + 10
            'End If
            CtrlNameDictionary.Add(c, c.Name) ' If(String.IsNullOrEmpty(typeName), "Control", typeName) & ctrlCount.ToString)
            FocusControl(c)
            RaiseEvent ControlAdded(c)
            '  ctrlCount += 1
        End Sub

        Private Sub sizerAction_ShowCode(sender As Object, e As EventArgs)
            FormMain.ToolCode.PerformClick()
        End Sub

        Private Sub sizerAction_toCode(sender As Object, e As EventArgs)
            Dim newCode As String = CodeGenerator.HandlesClosure(sender)
            If Not FormMain._manager.UserCode.ToLower.Contains(newCode.ToLower.Split(vbNewLine).First) Then 'Erste Definitionszeile
                FormMain._manager.UserCode = FormMain._manager.UserCode.Replace("End Class", "")
                FormMain._manager.UserCode += vbNewLine & vbNewLine & newCode & vbNewLine & vbNewLine & "End Class"
            End If
        End Sub

        Private Sub sizerAction_ToForeGround(c As Control, sizer As Control, e As EventArgs)
            c.BringToFront()
            sizer.BringToFront()
            RaiseEvent ControlHierarchieChanged(c)
        End Sub

        Private Sub sizerAction_ToBackGround(c As Control, sizer As Control, e As EventArgs)
            c.SendToBack()
            sizer.SendToBack()
            RaiseEvent ControlHierarchieChanged(c)
        End Sub

        Private Sub sizerAction_Delete(sender As Control, e As EventArgs)
            If Not RemoveControl(sender) Then MsgBox("Error in removing control")
        End Sub

        Private Sub sizerAction_ToUnderLyingControl(c As Control, sizer As Control)
            Try
                Dim underLyingControl As Control = DesignerForm.GetChildAtPoint(New Point(c.Location.X - 1, c.Location.Y - 1))

                If underLyingControl Is Nothing Then
                    MsgBox("Kein darunterliegendes Control", vbExclamation)
                    Exit Sub
                End If
                If underLyingControl Is c.Parent Then
                    MsgBox("Bereits auf diesem Control", vbExclamation)
                    Exit Sub
                End If

                Dim underlyingLoc = underLyingControl.Location
                Dim cLoc = New Point(c.Location.X - underlyingLoc.X, c.Location.Y - underlyingLoc.Y)
                Dim sizerLoc = New Point(sizer.Location.X - underlyingLoc.X, sizer.Location.Y - underlyingLoc.Y)

                If underLyingControl.GetType = GetType(TabControl) Then
                    Dim underlyingLoc2 = DirectCast(underLyingControl, TabControl).SelectedTab.Location
                    cLoc = New Point(c.Location.X - underlyingLoc.X - underlyingLoc2.X, c.Location.Y - underlyingLoc.Y - underlyingLoc2.Y)
                    sizerLoc = New Point(sizer.Location.X - underlyingLoc.X - underlyingLoc2.X, sizer.Location.Y - underlyingLoc.Y - underlyingLoc2.Y)

                    c.Parent.Controls.Remove(c)
                    sizer.Parent.Controls.Remove(sizer)

                    DirectCast(underLyingControl, TabControl).SelectedTab.Controls.Add(c)
                    c.Location = cLoc
                    DirectCast(underLyingControl, TabControl).SelectedTab.Controls.Add(sizer)
                    sizer.Location = sizerLoc
                Else
                    c.Parent.Controls.Remove(c)
                    sizer.Parent.Controls.Remove(sizer)

                    underLyingControl.Controls.Add(c)
                    c.Location = cLoc
                    underLyingControl.Controls.Add(sizer)
                    sizer.Location = sizerLoc
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            RaiseEvent ControlHierarchieChanged(c)
        End Sub

        Private Sub sizerAction_awayFromUnderLyingControl(c As Control, sizer As Control)
            Try
                If DesignerForm.Controls.Contains(c) Then
                    MsgBox("Ist bereits auf der Hauptform", vbExclamation)
                    Exit Sub
                End If

                c.Parent.Controls.Remove(c)
                sizer.Parent.Controls.Remove(sizer)

                DesignerForm.Controls.Add(c)
                DesignerForm.Controls.Add(sizer)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            RaiseEvent ControlHierarchieChanged(c)
        End Sub


        Private Sub sizerAction_Lock_Unlock(c As Control, sizer As Control)
            If String.IsNullOrEmpty(sizer.Tag) Then

                Try
                    DragSupDictionary(c).Enabled = False
                    SizeSupDictionary(c).Enabled = False
                    sizer.Tag = 1
                    sizer.BackColor = Color.Red
                Catch ex As Exception
                    MsgBox("Sperren fehlgeschlagen" & vbNewLine & vbNewLine & ex.Message)
                End Try

            Else
                Try
                    DragSupDictionary(c).Enabled = True
                    SizeSupDictionary(c).Enabled = True
                    sizer.Tag = String.Empty
                    sizer.BackColor = SystemColors.ActiveCaption
                Catch ex As Exception
                    MsgBox("Entsperren fehlgeschlagen" & vbNewLine & vbNewLine & ex.Message)
                End Try

            End If
        End Sub

        Public Sub FocusControl(c As Control)
            _propGrid.SelectedObject = c
            _focusCtrl = c

            If TryCast(_focusCtrl, Form) IsNot Nothing Then
                _nameBox.Text = _focusCtrl.Name
            Else
                _nameBox.Text = c.Name 'CtrlNameDictionary(c)
            End If
        End Sub

        Private Sub ctrl_Click(sender As Object, e As MouseEventArgs)
            If e.Button = MouseButtons.Left Then
                FocusControl(sender)

            ElseIf e.Button = MouseButtons.Right And My.Computer.Keyboard.CtrlKeyDown Then
                sizerAction_Delete(sender, e)
            ElseIf e.Button = MouseButtons.Right And My.Computer.Keyboard.AltKeyDown Then
                sizerAction_toCode(sender, e)
            End If
        End Sub

        Private Sub _txtnam_TextChanged(sender As Object, e As EventArgs) Handles _nameBox.TextChanged
            If _focusCtrl Is Nothing Then Exit Sub
            If TryCast(_focusCtrl, Form) IsNot Nothing Then
                DesignerForm.Name = _nameBox.Text
            Else
                _focusCtrl.Name = _nameBox.Text
                CtrlNameDictionary(_focusCtrl) = _nameBox.Text
            End If
            RaiseEvent ControlNameChanged(_nameBox.Text, _focusCtrl)
        End Sub
    End Class
End Namespace

