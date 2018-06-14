'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date : 07/12/2009                               '
'                                                                  '
'******************************************************************'

Public Class EditingClass
    Friend Shared Function CopyToClipboard(ByVal FileName As String) As Boolean

        'check for file or folder exist
        Try
            If System.IO.File.Exists(FileName) Or System.IO.Directory.Exists(FileName) Then
                Dim FilePaths As New System.Collections.Specialized.StringCollection
                FilePaths.Add(FileName)
                Clipboard.SetFileDropList(FilePaths)
                Return True
            Else
                Return False
            End If
        Catch
            Return False
        End Try
    End Function
End Class
