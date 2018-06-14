Imports System
Imports System.Management
Imports System.Windows.Forms
Imports System.IO
Imports System.Text

Namespace WMISample

    Public Class MyWMIQuery
        Friend Shared Function GetFloppydrives() As ArrayList
            Dim FloppyDrives As New ArrayList


            'collect logical drive detail
            'Dim drv = GetObject("winmgmts:").ExecQuery("SELECT * FROM Win32_LogicalDisk") 'get all drives in local computer
            Dim drv = GetObject("winmgmts:").ExecQuery("SELECT * FROM Win32_LogicalDisk WHERE Description = '3 1/2 Inch Floppy Drive'") 'get all floppy drive
            'Dim drv = GetObject("winmgmts:").ExecQuery("SELECT * FROM Win32_LogicalDisk WHERE MediaType = 5")


            Dim d As Object
            For Each d In drv
                FloppyDrives.Add(New DriveInfo(d.Caption))
            Next
            Return FloppyDrives
        End Function


        Public Shared Function NameFromId(ByVal PID As Integer) As ManagementObject

            Try
                Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Process where processid=" & PID)
                For Each queryObj As ManagementObject In searcher.Get()
                    'Console.WriteLine("Caption: {0}", queryObj("Caption"))
                    'Dim outParams As ManagementBaseObject = queryObj.InvokeMethod("GetOwner", Nothing, Nothing)
                    'MsgBox(outParams("User"))
                    Return queryObj
                Next
            Catch err As ManagementException
                'MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
                Return Nothing
            End Try
            Return Nothing

        End Function
        

    End Class

End Namespace