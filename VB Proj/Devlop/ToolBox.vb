Imports Silver.UI

Public Class ToolBox

    Private tlB As New Silver.UI.ToolBox()

    Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        Dim imgSet As ImageList = DataImageList
        For Each img In ComponentsImageList.Images
            imgSet.Images.Add(img)
        Next
        For Each img In WinFormsImgList.Images
            imgSet.Images.Add(img)
        Next

        tlB.Dock = DockStyle.Fill
        tlB.SmallImageList = imgSet

        CreateToolBox()

        Me.Controls.Add(tlB)

    End Sub

    Dim currentImageIndex = 0
    Private Sub AddItemToTB(caption As String, tabIndex As Integer, Optional Obj As Object = Nothing, Optional imageIndex As Integer = -2)
        Dim itm = New ToolBoxItem(caption, If(imageIndex = -2, currentImageIndex, imageIndex), True) With {.Object = Obj}
        tlB(tabIndex).AddItem(itm)
        currentImageIndex += 1
    End Sub

    Private Sub CreateToolBox()


        Dim General = New ToolBoxTab("Custom", -1)
        Dim generalTabIndex = 0
        ' General.ImgList = WinFormsImgList
        tlB.AddTab(General)

        currentImageIndex = 0
        AddItemToTB("Custom", generalTabIndex)


        Dim Data As ToolBoxTab = New ToolBoxTab("Data", -1)
        Dim DataSetTabIndex = 1
        ' Data.imag = DataImageList
        tlB.AddTab(Data)

        'AddItemToTB("Pointer", DataSetTabIndex)
        AddItemToTB("DataSet", DataSetTabIndex)
        AddItemToTB("OleDbDataAdapter", DataSetTabIndex)
        AddItemToTB("OleDbDataConnection", DataSetTabIndex)
        AddItemToTB("OleDbDataCommand", DataSetTabIndex)
        AddItemToTB("SqlDataAdapter", DataSetTabIndex)
        AddItemToTB("SqlConnection", DataSetTabIndex)
        AddItemToTB("SqlCommand", DataSetTabIndex)
        AddItemToTB("DataView", DataSetTabIndex)

        currentImageIndex += 1
        Dim Component = New ToolBoxTab("Components", -1)
        Dim ComponentTabIndex = 2
        ' Component.ImgList = ComponentsImageList
        tlB.AddTab(Component)

        ' AddItemToTB("Pointer", ComponentTabIndex)
        AddItemToTB("FileSystemWatcher", ComponentTabIndex)
        AddItemToTB("EventLog", ComponentTabIndex)
        AddItemToTB("DirectoryEntry", ComponentTabIndex)
        AddItemToTB("DirectorySearcher", ComponentTabIndex)
        AddItemToTB("MessageQueue", ComponentTabIndex)
        AddItemToTB("PerformanceCounter", ComponentTabIndex)
        AddItemToTB("Process", ComponentTabIndex)
        AddItemToTB("ServiceController", ComponentTabIndex)
        AddItemToTB("Timer", ComponentTabIndex)
        AddItemToTB("ReportDocument", ComponentTabIndex)

        currentImageIndex += 1
        Dim WinForm = New ToolBoxTab("Windows Forms", -1)
        Dim WinFormTabIndex = 3
        'WinForm.ImgList = WinFormsImgList
        tlB.AddTab(WinForm)
        
        ' AddItemToTB("Pointer", WinFormTabIndex)
        AddItemToTB("Label", WinFormTabIndex)
        AddItemToTB("LinkLabel", WinFormTabIndex)
        AddItemToTB("Button", WinFormTabIndex)
        AddItemToTB("TextBox", WinFormTabIndex)
        AddItemToTB("MainMenu", WinFormTabIndex)
        AddItemToTB("CheckBox", WinFormTabIndex)
        AddItemToTB("RadioButton", WinFormTabIndex)
        AddItemToTB("GroupBox", WinFormTabIndex)
        AddItemToTB("PictureBox", WinFormTabIndex)
        AddItemToTB("Panel", WinFormTabIndex)
        AddItemToTB("DataGrid", WinFormTabIndex)
        AddItemToTB("ListBox", WinFormTabIndex)
        AddItemToTB("CheckedListBox", WinFormTabIndex)
        AddItemToTB("ComboBox", WinFormTabIndex)
        AddItemToTB("ListView", WinFormTabIndex)
        AddItemToTB("TreeView", WinFormTabIndex)
        AddItemToTB("TabControl", WinFormTabIndex)
        AddItemToTB("DateTimePicker", WinFormTabIndex)
        AddItemToTB("MonthCalendar", WinFormTabIndex)
        AddItemToTB("HScrollBar", WinFormTabIndex)
        AddItemToTB("VScrollBar", WinFormTabIndex)
        AddItemToTB("Timer", WinFormTabIndex)
        AddItemToTB("Splitter", WinFormTabIndex)
        AddItemToTB("DomainUpDown", WinFormTabIndex)
        AddItemToTB("NumericUpDown", WinFormTabIndex)
        AddItemToTB("TrackBar", WinFormTabIndex)
        AddItemToTB("ProgressBar", WinFormTabIndex)
        AddItemToTB("RichTextBox", WinFormTabIndex)
        AddItemToTB("ImageList", WinFormTabIndex)
        AddItemToTB("HelpProvider", WinFormTabIndex)
        AddItemToTB("ToolTip", WinFormTabIndex)
        AddItemToTB("ContextMenu", WinFormTabIndex)
        AddItemToTB("ToolBar", WinFormTabIndex)
        AddItemToTB("StatusBar", WinFormTabIndex)
        AddItemToTB("NotifyIcon", WinFormTabIndex)
        AddItemToTB("OpenFileDialog", WinFormTabIndex)
        AddItemToTB("SaveFileDialog", WinFormTabIndex)
        AddItemToTB("FontDialog", WinFormTabIndex)
        AddItemToTB("ColorDialog", WinFormTabIndex)
        AddItemToTB("PrintDialog", WinFormTabIndex)
        AddItemToTB("PrintPreviewDialog", WinFormTabIndex)
        AddItemToTB("PrintPreviewControl", WinFormTabIndex)
        AddItemToTB("ErrorProvider", WinFormTabIndex)
        AddItemToTB("PrintDocument", WinFormTabIndex)
        AddItemToTB("PageSetupDialog", WinFormTabIndex)
        ' AddItemToTB("CrystalReportViewer", WinFormTabIndex)








    End Sub
End Class
