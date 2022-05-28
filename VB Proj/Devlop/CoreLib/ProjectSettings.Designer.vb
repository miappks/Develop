<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectSettings
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("System.dll")
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("System.Windows.Forms.dll")
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("System.dll")
        Dim ListViewItem16 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("System.Windows.Forms.dll")
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.EnableVisualStyles = New System.Windows.Forms.CheckBox()
        Me.CompatibleTextRendering = New System.Windows.Forms.CheckBox()
        Me.Einzelinstanzanwendung = New System.Windows.Forms.CheckBox()
        Me.GuidTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.VerticalTabBar1 = New DevelopControls.VerticalTabBar()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBoxSubMain = New System.Windows.Forms.GroupBox()
        Me.OwnSubMainCode = New System.Windows.Forms.TextBox()
        Me.OwnSubMain = New System.Windows.Forms.RadioButton()
        Me.GroupBoxAWFW = New System.Windows.Forms.GroupBox()
        Me.Anwendungsframework = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.VerticalTabBar1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBoxSubMain.SuspendLayout()
        Me.GroupBoxAWFW.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        ListViewItem13.StateImageIndex = 0
        ListViewItem14.StateImageIndex = 0
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem13, ListViewItem14})
        Me.ListView1.LabelEdit = True
        Me.ListView1.LabelWrap = False
        Me.ListView1.Location = New System.Drawing.Point(6, 40)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(230, 376)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "References"
        Me.ColumnHeader1.Width = 276
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.LightGreen
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(249, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 42)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "＋"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.LightGreen
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button2.Location = New System.Drawing.Point(249, 70)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(47, 42)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "－"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 427)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "References:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.ListView2)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Location = New System.Drawing.Point(368, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(303, 427)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Code Imports:"
        '
        'ListView2
        '
        Me.ListView2.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.ListView2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView2.HideSelection = False
        ListViewItem15.StateImageIndex = 0
        ListViewItem16.StateImageIndex = 0
        Me.ListView2.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem15, ListViewItem16})
        Me.ListView2.LabelEdit = True
        Me.ListView2.LabelWrap = False
        Me.ListView2.Location = New System.Drawing.Point(6, 44)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(230, 372)
        Me.ListView2.TabIndex = 0
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.List
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Code Imports"
        Me.ColumnHeader2.Width = 276
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.LightGreen
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button3.Location = New System.Drawing.Point(248, 22)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(47, 42)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "＋"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.LightGreen
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button4.Location = New System.Drawing.Point(248, 70)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(47, 42)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "－"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button6.Location = New System.Drawing.Point(640, 489)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(98, 38)
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "Okay"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button5.Location = New System.Drawing.Point(744, 489)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(98, 38)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Cancel"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'EnableVisualStyles
        '
        Me.EnableVisualStyles.AutoSize = True
        Me.EnableVisualStyles.Location = New System.Drawing.Point(15, 21)
        Me.EnableVisualStyles.Name = "EnableVisualStyles"
        Me.EnableVisualStyles.Size = New System.Drawing.Size(121, 17)
        Me.EnableVisualStyles.TabIndex = 7
        Me.EnableVisualStyles.Text = "Enable Visual Styles"
        Me.EnableVisualStyles.UseVisualStyleBackColor = True
        '
        'CompatibleTextRendering
        '
        Me.CompatibleTextRendering.AutoSize = True
        Me.CompatibleTextRendering.Location = New System.Drawing.Point(15, 44)
        Me.CompatibleTextRendering.Name = "CompatibleTextRendering"
        Me.CompatibleTextRendering.Size = New System.Drawing.Size(154, 17)
        Me.CompatibleTextRendering.TabIndex = 8
        Me.CompatibleTextRendering.Text = "Compatible Text Rendering"
        Me.CompatibleTextRendering.UseVisualStyleBackColor = True
        '
        'Einzelinstanzanwendung
        '
        Me.Einzelinstanzanwendung.AutoSize = True
        Me.Einzelinstanzanwendung.Location = New System.Drawing.Point(15, 88)
        Me.Einzelinstanzanwendung.Name = "Einzelinstanzanwendung"
        Me.Einzelinstanzanwendung.Size = New System.Drawing.Size(143, 17)
        Me.Einzelinstanzanwendung.TabIndex = 9
        Me.Einzelinstanzanwendung.Text = "Einzelinstanzanwendung"
        Me.Einzelinstanzanwendung.UseVisualStyleBackColor = True
        '
        'GuidTextBox
        '
        Me.GuidTextBox.Location = New System.Drawing.Point(55, 23)
        Me.GuidTextBox.Name = "GuidTextBox"
        Me.GuidTextBox.Size = New System.Drawing.Size(256, 20)
        Me.GuidTextBox.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "GUID"
        '
        'VerticalTabBar1
        '
        Me.VerticalTabBar1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.VerticalTabBar1.Controls.Add(Me.TabPage1)
        Me.VerticalTabBar1.Controls.Add(Me.TabPage2)
        Me.VerticalTabBar1.ItemSize = New System.Drawing.Size(44, 136)
        Me.VerticalTabBar1.Location = New System.Drawing.Point(10, 10)
        Me.VerticalTabBar1.Multiline = True
        Me.VerticalTabBar1.Name = "VerticalTabBar1"
        Me.VerticalTabBar1.SelectedIndex = 0
        Me.VerticalTabBar1.Size = New System.Drawing.Size(832, 468)
        Me.VerticalTabBar1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.VerticalTabBar1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(140, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(688, 460)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Referenzen"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.Anwendungsframework)
        Me.TabPage2.Controls.Add(Me.OwnSubMain)
        Me.TabPage2.Controls.Add(Me.GroupBoxSubMain)
        Me.TabPage2.Controls.Add(Me.GroupBoxAWFW)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.GuidTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(140, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(688, 460)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Projekteinstellungen"
        '
        'GroupBoxSubMain
        '
        Me.GroupBoxSubMain.Controls.Add(Me.OwnSubMainCode)
        Me.GroupBoxSubMain.Location = New System.Drawing.Point(282, 73)
        Me.GroupBoxSubMain.Name = "GroupBoxSubMain"
        Me.GroupBoxSubMain.Size = New System.Drawing.Size(391, 370)
        Me.GroupBoxSubMain.TabIndex = 13
        Me.GroupBoxSubMain.TabStop = False
        '
        'OwnSubMainCode
        '
        Me.OwnSubMainCode.Location = New System.Drawing.Point(18, 19)
        Me.OwnSubMainCode.Multiline = True
        Me.OwnSubMainCode.Name = "OwnSubMainCode"
        Me.OwnSubMainCode.Size = New System.Drawing.Size(352, 334)
        Me.OwnSubMainCode.TabIndex = 1
        Me.OwnSubMainCode.Text = "Public Shared Sub Main(ByVal commandLineArgs as String())" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "End Sub"
        '
        'OwnSubMain
        '
        Me.OwnSubMain.AutoSize = True
        Me.OwnSubMain.Location = New System.Drawing.Point(282, 60)
        Me.OwnSubMain.Name = "OwnSubMain"
        Me.OwnSubMain.Size = New System.Drawing.Size(106, 17)
        Me.OwnSubMain.TabIndex = 0
        Me.OwnSubMain.TabStop = True
        Me.OwnSubMain.Text = "Eigene Sub Main"
        Me.OwnSubMain.UseVisualStyleBackColor = True
        '
        'GroupBoxAWFW
        '
        Me.GroupBoxAWFW.Controls.Add(Me.Einzelinstanzanwendung)
        Me.GroupBoxAWFW.Controls.Add(Me.CompatibleTextRendering)
        Me.GroupBoxAWFW.Controls.Add(Me.EnableVisualStyles)
        Me.GroupBoxAWFW.Location = New System.Drawing.Point(15, 73)
        Me.GroupBoxAWFW.Name = "GroupBoxAWFW"
        Me.GroupBoxAWFW.Size = New System.Drawing.Size(249, 141)
        Me.GroupBoxAWFW.TabIndex = 12
        Me.GroupBoxAWFW.TabStop = False
        '
        'Anwendungsframework
        '
        Me.Anwendungsframework.AutoSize = True
        Me.Anwendungsframework.Location = New System.Drawing.Point(15, 60)
        Me.Anwendungsframework.Name = "Anwendungsframework"
        Me.Anwendungsframework.Size = New System.Drawing.Size(136, 17)
        Me.Anwendungsframework.TabIndex = 0
        Me.Anwendungsframework.TabStop = True
        Me.Anwendungsframework.Text = "Anwendungsframework"
        Me.Anwendungsframework.UseVisualStyleBackColor = True
        '
        'ProjectSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(850, 539)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.VerticalTabBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProjectSettings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Project Settings"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.VerticalTabBar1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBoxSubMain.ResumeLayout(False)
        Me.GroupBoxSubMain.PerformLayout()
        Me.GroupBoxAWFW.ResumeLayout(False)
        Me.GroupBoxAWFW.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
	Friend WithEvents ColumnHeader1 As ColumnHeader
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents ListView2 As ListView
	Friend WithEvents ColumnHeader2 As ColumnHeader
	Friend WithEvents Button3 As Button
	Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EnableVisualStyles As CheckBox
    Friend WithEvents CompatibleTextRendering As CheckBox
    Friend WithEvents Einzelinstanzanwendung As CheckBox
    Friend WithEvents GuidTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents VerticalTabBar1 As DevelopControls.VerticalTabBar
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBoxAWFW As GroupBox
    Friend WithEvents Anwendungsframework As RadioButton
    Friend WithEvents GroupBoxSubMain As GroupBox
    Friend WithEvents OwnSubMain As RadioButton
    Friend WithEvents OwnSubMainCode As TextBox
End Class
