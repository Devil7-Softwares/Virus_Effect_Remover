'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date : 07/12/2009                               '
'                                                                  '
'******************************************************************'



Public Class File_Action
    Friend Function DeleteFileArrayList(ByVal Full_FileNameArraylist As ArrayList,
                                        Optional ByRef EventCollect As ArrayList = Nothing,
                                        Optional ByVal SendToRecycleBin As Boolean = False,
                                        Optional ByRef Exception_Happend As Exception = Nothing,
                                        Optional ByVal ReplaceByFolder As Boolean = False,
                                        Optional ByVal GetNTFSRight As Boolean = True) As Boolean

        For Each item As String In Full_FileNameArraylist
            Dim Event1 As New ArrayList
            Event1.Clear()
            If Not _DeleteFile(item, Event1, SendToRecycleBin, Exception_Happend, ReplaceByFolder, GetNTFSRight) Then
                MsgBox(item + "  Not deleted.")
            End If
            EventCollect.AddRange(Event1)
        Next
    End Function

    'this function will return true if Get success
    Friend Function _DeleteFile(ByVal Full_FileName As String,
                                Optional ByRef EventCollect As ArrayList = Nothing,
                                Optional ByVal SendToRecycleBin As Boolean = False,
                                Optional ByRef Exception_Happend As Exception = Nothing,
                                Optional ByVal ReplaceByFolder As Boolean = False,
                                Optional ByVal GetNTFSRight As Boolean = True) As Boolean

        If Not My.Computer.FileSystem.FileExists(Full_FileName) Then
            EventCollect.Add(Full_FileName + " : not Exist.")
            Return False
        End If

        Try
            'first attempt to kill file
            Dim Finfo As New FileInfo(Full_FileName)
            'normalized attribute
            'if here arrtibute normalization operation fails , it means file NTFS permission do ot Exist
            Finfo.Attributes = FileAttributes.Normal

        Catch Exception_Happend
            EventCollect.Add(Exception_Happend.Message)
        End Try
    End Function
End Class
