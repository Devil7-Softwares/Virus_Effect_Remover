'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date : 07/12/2009                               '
'                                                                  '
'******************************************************************'


Module RemovalMediaModule
    Friend Function RemoveSystemHiddenFileInDrive _
        (ByVal CurrentDrive As DirectoryInfo, ByRef NotePadArrayList As ArrayList) As Boolean
        Try
            'visualising current directory
            If (CurrentDrive.Attributes And FileAttributes.Hidden) = FileAttributes.Hidden Then
                'Normalising dir attribute
                CurrentDrive.Attributes = FileAttributes.Normal
                'Adding detail to array list
                NotePadArrayList.Add("Directory :" + CurrentDrive.FullName + "  Normalized")
            End If


            Dim afile As FileInfo
            'getting file of that directory
            For Each afile In CurrentDrive.GetFiles
                ' MsgBox(afile.FullName)
                'Checking for File Attribute to hiddden
                If (afile.Attributes And FileAttributes.Hidden) = FileAttributes.Hidden Then
                    'Checking for file attribute to System
                    'if it is true then it will be delete
                    If afile.Attributes And FileAttributes.System = FileAttributes.System Then
                        'Ntfs file security access not added because removal media support only Fat\Fat32
                        '******************************'

                        'Normalizing file attribute
                        afile.Attributes = FileAttributes.Normal
                        'Deleting file
                        afile.Delete()
                        'Adding Detail to array list
                        NotePadArrayList.Add("File : " + afile.FullName + " was System+Hidden Deleted.")
                    Else
                        'only normalize the file
                        afile.Attributes = FileAttributes.Normal
                        'adding detail to arraylist
                        NotePadArrayList.Add("File : " + afile.FullName + " was only hidden file. Attribute NOrmalized.")
                    End If
                End If
            Next

            'finding subdirectory of current directory
            Dim SubDirectory As DirectoryInfo
            For Each SubDirectory In CurrentDrive.GetDirectories
                'Recurtion to perform same task
                RemoveSystemHiddenFileInDrive(SubDirectory, NotePadArrayList)
            Next
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    'This Function Normalise Eech File and directory And Store it Information in Form1.NotePadArrayList
    'Before initiating  this function  we must clear The Form1.NotePadArrayList array List

    Friend Function visualiseFileOfCurrentFolder _
        (ByVal CurrentDrive As DirectoryInfo, ByRef NotePadArrayList As ArrayList) As Boolean


        Try
            'visualising current directory
            If (CurrentDrive.Attributes And FileAttributes.Hidden) = FileAttributes.Hidden Then
                Try
                    'Setting Attribute
                    CurrentDrive.Attributes = FileAttributes.Normal
                    'Adding Detail to NotePadArrayList
                    'Only Removal Media with Fat/Fat32 formation  will use this 
                    NotePadArrayList.Add("Directory : " + CurrentDrive.FullName + " is Normalised.")
                Catch
                    NotePadArrayList.Add("Directory : " + CurrentDrive.FullName + " is Failed to Normalise.")
                End Try
            End If

            'getting file of that directory
            Dim afile As FileInfo
            For Each afile In CurrentDrive.GetFiles
                Try
                    If (afile.Attributes And FileAttributes.Hidden) = FileAttributes.Hidden Then
                        'Setting to Normalise file
                        afile.Attributes = FileAttributes.Normal
                        'Adding Detail
                        NotePadArrayList.Add("File : " + afile.FullName + " is Normalised")
                    End If
                Catch
                    NotePadArrayList.Add("File : " + afile.FullName + " is Failed to Normalise")
                End Try
            Next


            'finding subdirectory of current directory
            Dim SubDirectory As DirectoryInfo
            For Each SubDirectory In CurrentDrive.GetDirectories
                'Recurtion to perform same task
                visualiseFileOfCurrentFolder(SubDirectory, NotePadArrayList)
            Next

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Module
