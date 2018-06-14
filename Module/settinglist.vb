'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date : 07/12/2009                               '
'                                                                  '
'******************************************************************'


Module settinglist
    'getting OS version.

    Public Function GetOSVersion() As String
        Select Case Environment.OSVersion.Platform
            Case PlatformID.Win32S
                Return "Win 3.1"

            Case PlatformID.Win32Windows
                Select Case Environment.OSVersion.Version.Minor
                    Case 0
                        Return "Win95"
                    Case 10
                        Return "Win98"
                    Case 90
                        Return "WinME"
                    Case Else
                        Return "Unknown"
                End Select

            Case PlatformID.Win32NT
                Select Case Environment.OSVersion.Version.Major
                    Case 3
                        Return "NT 3.51"
                    Case 4
                        Return "NT 4.0"
                    Case 5
                        Select Case Environment.OSVersion.Version.Minor
                            Case 0
                                Return "Win2000"
                            Case 1
                                Return "WinXP"
                            Case 2
                                Return "Win2003"
                            Case Else
                                Return "Error"
                        End Select
                    Case 6
                        Return "Vista/7/Win2008Server"
                    Case Else
                        Return "Unknown"
                End Select
            Case Else
                Return "Error"
        End Select
    End Function

    'This function is loaded at startup
End Module
