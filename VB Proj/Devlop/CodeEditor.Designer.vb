<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CodeEditor
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CodeEditor))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LineLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RowLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RebuildData = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Editor = New DevelopControls.SEditor()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.White
        Me.ImageList1.Images.SetKeyName(0, "class.bmp")
        Me.ImageList1.Images.SetKeyName(1, "event.bmp")
        Me.ImageList1.Images.SetKeyName(2, "field.bmp")
        Me.ImageList1.Images.SetKeyName(3, "method.bmp")
        Me.ImageList1.Images.SetKeyName(4, "property.bmp")
        Me.ImageList1.Images.SetKeyName(5, "module.bmp")
        Me.ImageList1.Images.SetKeyName(6, "enum.bmp")
        Me.ImageList1.Images.SetKeyName(7, "interface.bmp")
        Me.ImageList1.Images.SetKeyName(8, "namespace.png")
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LineLabel, Me.RowLabel, Me.RebuildData})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 351)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(435, 26)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LineLabel
        '
        Me.LineLabel.AutoSize = False
        Me.LineLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.LineLabel.Name = "LineLabel"
        Me.LineLabel.Size = New System.Drawing.Size(122, 21)
        Me.LineLabel.Spring = True
        Me.LineLabel.Text = "Line: 0"
        '
        'RowLabel
        '
        Me.RowLabel.AutoSize = False
        Me.RowLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.RowLabel.Name = "RowLabel"
        Me.RowLabel.Size = New System.Drawing.Size(122, 21)
        Me.RowLabel.Spring = True
        Me.RowLabel.Text = "Row: 0"
        '
        'RebuildData
        '
        Me.RebuildData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.RebuildData.Image = CType(resources.GetObject("RebuildData.Image"), System.Drawing.Image)
        Me.RebuildData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RebuildData.Name = "RebuildData"
        Me.RebuildData.Size = New System.Drawing.Size(144, 24)
        Me.RebuildData.Text = "Rebuild Sense Database"
        '
        'ToolTip
        '
        Me.ToolTip.AutomaticDelay = 65536
        '
        'Editor
        '
        Me.Editor.AllText = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Editor.Antialiasing = True
        Me.Editor.AutoTabs = True
        Me.Editor.BackColor = System.Drawing.Color.White
        Me.Editor.BlinkCursor = True
        Me.Editor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Editor.Colors = CType(resources.GetObject("Editor.Colors"), System.Collections.Generic.List(Of String))
        Me.Editor.ColorTable = CType(resources.GetObject("Editor.ColorTable"), System.Collections.Generic.List(Of System.Drawing.Color))
        Me.Editor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Editor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Editor.HighlightRules = CType(resources.GetObject("Editor.HighlightRules"), System.Collections.Generic.List(Of System.Collections.Generic.KeyValuePair(Of String, Integer)))
        Me.Editor.LineNumber = True
        Me.Editor.LineNumberColor = System.Drawing.Color.DarkCyan
        Me.Editor.Lines = CType(resources.GetObject("Editor.Lines"), System.Collections.Generic.List(Of String))
        Me.Editor.Location = New System.Drawing.Point(0, 0)
        Me.Editor.Name = "Editor"
        Me.Editor.SelectionAlpha = CType(128, Byte)
        Me.Editor.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Editor.SeperatorColor = System.Drawing.Color.DarkBlue
        Me.Editor.SeperatorWidth = 2.0!
        Me.Editor.Size = New System.Drawing.Size(435, 377)
        Me.Editor.TabIndex = 9
        Me.Editor.TextRenderMethod = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        '
        'CodeEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Editor)
        Me.Name = "CodeEditor"
        Me.Size = New System.Drawing.Size(435, 377)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents LineLabel As ToolStripStatusLabel
    Friend WithEvents RowLabel As ToolStripStatusLabel
    Friend WithEvents RebuildData As ToolStripDropDownButton
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents Editor As DevelopControls.SEditor
End Class
