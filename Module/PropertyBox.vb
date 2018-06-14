'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date : 07/12/2009                               '
'                                                                  '
'******************************************************************'
Imports System.Runtime.InteropServices

Namespace win32
    Public Class PropertyShow

#Region "Shell"

        <DllImport("shell32.dll")>
        Public Shared Function ShellExecuteEx(<MarshalAs(UnmanagedType.Struct)> ByRef s As SHELLEXECUTEINFO) As Boolean
        End Function

#End Region

        Private Const SEE_MASK_INVOKEIDLIST As Integer = &HC

        Public Enum ShowWindowType As Short
            Hide = 0
            ShowNormal = 1
            Normal = 1
            ShowMinimized = 2
            ShowMaximized = 3
            Maximize = 3
            ShowNoActivate = 4
            Show = 5
            Minimize = 6
            ShowMinNoActive = 7
            ShowNa = 8
            Restore = 9
            ShowDefault = 10
            ForceMinimize = 11
            Max = 11
        End Enum

        Public Structure SHELLEXECUTEINFO
            Public cbSize As Integer
            Public fMask As Integer
            Public hWnd As Integer
            Public lpVerb As String
            Public lpFile As String
            Public lpParameters As String
            Public lpDirectory As String
            Public nShow As ShowWindowType
            Public unused As Short
            Public hInstApp As Integer

            Public lpIDList As Integer
            Public lpClass As String
            Public hkeyClass As Integer
            Public dwHotKey As Integer
            Public hIcon As Integer
            Public hProcess As Integer
        End Structure


        Public Shared Sub ShowProperties(ByVal fileName As String)
            Dim info As New SHELLEXECUTEINFO()

            info.cbSize = Marshal.SizeOf(GetType(SHELLEXECUTEINFO))
            info.lpFile = fileName
            info.nShow = ShowWindowType.Show
            info.fMask = SEE_MASK_INVOKEIDLIST
            info.lpVerb = "properties"
            ShellExecuteEx(info)
        End Sub
    End Class
End Namespace
