Public Class ApplicationFrameworkSettings
    Public Property EnableVisualStyles As Boolean
    Public Property SetCompatibleTextRenderingDefault As Boolean

    Public Property SingleInstanceApplication As Boolean
    Public Property GUID As String

    Public Property CustomSubMain As Boolean
    Public Property SubMainCode As String

    Sub New()
        Me.EnableVisualStyles = True
        Me.SetCompatibleTextRenderingDefault = False

        SingleInstanceApplication = False
        GUID = System.Guid.NewGuid.ToString

        Me.CustomSubMain = False
        Me.SubMainCode = String.Empty
    End Sub
End Class
