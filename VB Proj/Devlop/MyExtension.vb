Module FileInfoExtension
    <System.Runtime.CompilerServices.Extension()>
    Public Function IsFileOpen(ByVal file As IO.FileInfo) As Boolean
        Dim stream As IO.FileStream = Nothing
        Try
            stream = file.Open(IO.FileMode.Open, IO.FileAccess.ReadWrite, IO.FileShare.None)
            stream.Close()
            Return False
        Catch ex As Exception
            If TypeOf ex Is IO.IOException AndAlso IsFileLocked(ex) Then
                Return True
            End If
        End Try

        Return True
    End Function

    Private Function IsFileLocked(ex As Exception) As Boolean
        Dim errorCode As Integer = System.Runtime.InteropServices.Marshal.GetHRForException(ex) And ((1 << 16) - 1)
        Return errorCode = 32 OrElse errorCode = 33
    End Function

End Module

Module ControlSearch
    Public Function FindControl(ByVal ParentControl As Control, ByVal ControlNameToSearch As String) As Control
        Dim FoundControl As Control = Nothing

        For Each CurrentControl As Control In ParentControl.Controls
            If CurrentControl.Name.ToLower = ControlNameToSearch.ToLower Then
                FoundControl = CurrentControl
            ElseIf CurrentControl.HasChildren Then
                FoundControl = FindControl(CurrentControl, ControlNameToSearch)
            End If
            If FoundControl IsNot Nothing Then
                Exit For
            End If
        Next

        Return FoundControl
    End Function

End Module