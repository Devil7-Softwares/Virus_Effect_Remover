'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date : 07/12/2009                               '
'                                                                  '
'******************************************************************'

Imports System
Imports System.IO

Module deleteFileFolderModule



    Public Function DeleteAllFilesInDir(ByVal Dinfo As DirectoryInfo, _
                                        Optional ByVal ForceToDelete As Boolean = False, _
                                        Optional ByVal EnableProcessFilter As Boolean = True, _
                                        Optional ByVal DeleteSubDirectoryFiles As Boolean = False, _
                                        Optional ByVal DeleteRootDirectory As Boolean = False, _
                                        Optional ByVal SendToRecyleBin As Boolean = True, _
                                        Optional ByRef DeletedFiles As ArrayList = Nothing, _
                                        Optional ByRef NotDeletedFiles As ArrayList = Nothing, _
                                        Optional ByRef DeleteDirectoryIfEmpty As Boolean = False, _
                                        Optional ByRef EventCollection As ArrayList = Nothing, _
                                        Optional ByRef Ex As Exception = Nothing) As Boolean

        Try

            DeletedFiles = New ArrayList
            NotDeletedFiles = New ArrayList
            EventCollection = New ArrayList

            If (DeleteSubDirectoryFiles) Then
                For Each dir1 As DirectoryInfo In Dinfo.GetDirectories
                    Dim df As New ArrayList
                    Dim ndf As New ArrayList
                    Dim exp As New Exception
                    Dim event1 As New ArrayList
                    If Not DeleteAllFilesInDir(dir1, ForceToDelete, EnableProcessFilter, DeleteSubDirectoryFiles, True, SendToRecyleBin, _
                                               df, ndf, DeleteDirectoryIfEmpty, event1, exp) Then
                        EventCollection.AddRange(event1)
                        'EventCollection.Add(dir1.FullName + " : Failed To Delete.")
                    Else
                        EventCollection.AddRange(event1)
                        'EventCollection.Add(dir1.FullName + " : Deleted.")
                    End If

                    DeletedFiles.AddRange(df)
                    NotDeletedFiles.AddRange(ndf)
                Next
            End If




            'collecting files
            Dim tmp As New ArrayList
            tmp.Clear()
            tmp.AddRange(Dinfo.GetFiles())

            For Each Finfo As FileInfo In tmp
                'MsgBox(file.FullName)
                Dim exs As New Exception
                Dim event1 As New ArrayList
                If DeleteFile(Finfo, SendToRecyleBin, ForceToDelete, EnableProcessFilter, event1, exs) Then
                    DeletedFiles.Add(Finfo.FullName)
                    EventCollection.AddRange(event1)
                Else
                    NotDeletedFiles.Add(Finfo.FullName)
                    EventCollection.AddRange(event1)
                End If
            Next






            'deleteing Empy directory
            Try
                If DeleteDirectoryIfEmpty Then
                    If DeleteRootDirectory Then
                        If Dinfo.GetFiles().Length <= 0 Then
                            Dinfo.Attributes = FileAttributes.Normal
                            NTFS.AddFullControlToDirectory(Dinfo.FullName)
                            Dinfo.Delete()
                            EventCollection.Add(Dinfo.FullName + " : Deleted")
                        End If
                    End If
                End If
            Catch 'ex As Exception
                'do nothing
            End Try
            Return True
        Catch ex
            Return False
        End Try
    End Function

    'this function will help to delete all file with special Extension 
    'wildcard is not allowed this time
    'right now file extention will be like   .exe


    Public Function DeleteAllFileInDirectoryWithExtension(ByVal dinfo As DirectoryInfo, _
                                                          ByVal Extension As ArrayList, _
                                        Optional ByVal SendToRecycleBin As Boolean = True, _
                                        Optional ByVal ForceToDelete As Boolean = False, _
                                        Optional ByVal EnableProcessFilter As Boolean = True, _
                                        Optional ByRef DeleteSubDirectoryFiles As Boolean = False, _
                                        Optional ByRef DeletedFiles As ArrayList = Nothing, _
                                        Optional ByRef NotDeletedFiles As ArrayList = Nothing, _
                                        Optional ByRef DeleteIfDirectoryIsEmpty As Boolean = False, _
                                        Optional ByRef EventCollection As ArrayList = Nothing, _
                                        Optional ByRef Ex As Exception = Nothing) As Boolean



        Try

            DeletedFiles = New ArrayList
            NotDeletedFiles = New ArrayList
            EventCollection = New ArrayList

            'first process all sub directory if it is included
            If (DeleteSubDirectoryFiles) Then
                For Each dir1 As DirectoryInfo In dinfo.GetDirectories
                    'here "df" is used for deleted files , "ndf" used for not dleted files
                    '"exp" for exception and "event1" for eventcapture

                    Dim df As New ArrayList
                    Dim ndf As New ArrayList
                    Dim exp As New Exception
                    Dim event1 As New ArrayList
                    If Not DeleteAllFileInDirectoryWithExtension(dir1, Extension, SendToRecycleBin, _
                                                                 ForceToDelete, EnableProcessFilter, _
                                                                 DeleteSubDirectoryFiles, df, ndf, _
                                                                 DeleteIfDirectoryIsEmpty, event1, exp) Then
                        EventCollection.AddRange(event1)
                    Else
                        EventCollection.AddRange(event1)
                    End If
                    DeletedFiles.AddRange(df)
                    NotDeletedFiles.AddRange(ndf)
                Next
            End If





            'Collecting files of this directory
            'Dim tmp As New ArrayList
            'tmp.Clear()
            'tmp.AddRange(dinfo.GetFiles())
            Dim tmp As FileInfo() = dinfo.GetFiles


            For Each Finfo As FileInfo In tmp
                'here check extension 'if extention is matching proceed or do not delete it
                For Each ext As String In Extension

                    'now check that current file extention is matching with provided extention or not
                    'if it is not matching then check other extention.
                    If Not Finfo.Extension.ToLower = ext.ToLower Then
                        'this file should not be deleted.
                        Continue For
                    End If

                    'here this extention is found in collectionn so 
                    'Now attept to delete
                    Dim event1 As New ArrayList
                    If DeleteFile(Finfo, SendToRecycleBin, ForceToDelete, EnableProcessFilter, event1, Ex) Then
                        'file is deleted
                        DeletedFiles.Add(Finfo.FullName)
                        EventCollection.AddRange(event1)
                        'pick other file drom this dorectory
                        Exit For
                    Else
                        'fiel is not deleted
                        NotDeletedFiles.Add(Finfo.FullName)
                        EventCollection.AddRange(event1)
                        'pick other file of this directory
                        Exit For
                    End If
                Next

                '------------------------ End of one extention type
            Next





            'deleteing Empy directory if it is allowed
            Try
                'check if it is allowed
                If DeleteIfDirectoryIsEmpty Then
                    'check  there shoud be no file and directory in this directory
                    If ((dinfo.GetFiles().Length <= 0) And (dinfo.GetDirectories.Length <= 0)) Then
                        'normalize this directory , add NTFS permission and delete it.
                        dinfo.Attributes = FileAttributes.Normal
                        NTFS.AddFullControlToDirectory(dinfo.FullName)
                        'here i am not collecting events because it is an empty directory
                        'and there is no need to collect any information , only get info about deleted or not /.
                        'here i am not collection un-neccessory events of directory deletion
                        If DeleteDirectory(dinfo, SendToRecycleBin, ForceToDelete, EnableProcessFilter, , Ex) Then
                            EventCollection.Add(dinfo.FullName + " : Deleted.")
                        Else
                            'here there is any usage of this directory in system
                            EventCollection.Add(dinfo.FullName + " : is Empty but NOT Deleted.")
                        End If
                    End If
                End If
            Catch ex 'As Exception
                EventCollection.Add(Ex.Message)
                'do nothing
            End Try

            'return happlly
            Return True

        Catch ex
            EventCollection.Add(Ex.Message)
            Return False
        End Try

    End Function

    Public Function DeleteEmptyDirectory(ByVal dinfo As DirectoryInfo, _
                                         ByVal FilesAllowedToDelete As ArrayList, _
                                         Optional ByVal SendToRecycleBin As Boolean = True, _
                                         Optional ByVal ForceToDelete As Boolean = False, _
                                         Optional ByVal EnableProcessFilter As Boolean = False, _
                                         Optional ByRef DeletedDir As ArrayList = Nothing, _
                                         Optional ByRef FailedToDeletedDir As ArrayList = Nothing, _
                                         Optional ByRef EventCollection As ArrayList = Nothing, _
                                         Optional ByRef Ex As Exception = Nothing) As Boolean

        EventCollection = New ArrayList

        'MsgBox(dinfo.FullName)


        '1st process all directory inside this directory
        'if here exception occure , means do not have access control
        Dim dirinside As DirectoryInfo() = Nothing

        Try
            dirinside = dinfo.GetDirectories
        Catch ex
            'add NTFS full control
            If Not NTFS.AddFullControlToDirectory(dinfo.FullName, Ex) Then
                Return False
            Else
                'again assign dirinside 
                Try
                    dirinside = dinfo.GetDirectories
                Catch ex 'As Exception
                    Return False
                End Try
            End If
        End Try

        Try
            For Each dir1 As DirectoryInfo In dirinside
                Dim dld As New ArrayList
                Dim ndld As New ArrayList
                Dim event1 As New ArrayList

                If Not DeleteEmptyDirectory(dir1, FilesAllowedToDelete, _
                                            SendToRecycleBin, ForceToDelete, _
                                            EnableProcessFilter, dld, ndld, event1, Ex) Then
                    'do nothing only try to collect exception
                    EventCollection.AddRange(event1)
                    Continue For
                End If
                DeletedDir.AddRange(dld)
                FailedToDeletedDir.AddRange(ndld)
                EventCollection.AddRange(event1)
            Next
        Catch ex 'As Exception
            EventCollection.Add(Ex.Message)
            Return False
        End Try




        '2nd : check if any directory Exist
        If dinfo.GetDirectories.Length > 0 Then
            'here one directory exist so we can not delete this directory
            Ex = New Exception(dinfo.FullName + " : Directory Not Empty")
            'EventCollection.Add(dinfo.FullName + " : Directory not Empty.")
            Return False
        End If



        'here we got that only files exist 
        'so collect all files of current directory
        'if files counting is greater that allowed files count return 
        Dim FilesInSideDir As New ArrayList
        FilesInSideDir.AddRange(dinfo.GetFiles)
        If FilesInSideDir.Count > FilesAllowedToDelete.Count Then
            'no need to do any thing extra
            Ex = New Exception(dinfo.FullName + " : Directory Not Empty")
            'EventCollection.Add(dinfo.FullName + " : Directory not Empty.")
            Return False
        End If

        'check allowed files list 
        'travers each files of this directory and check if this file is in allowed list
        For Each fid As FileInfo In FilesInSideDir
            For Each alf As String In FilesAllowedToDelete
                ' MsgBox(fid.Name + "   :   " + alf)
                'Now look each file name in allowed list and compare it with found file in this directory
                If fid.Name.ToLower = alf.ToLower Then
                    'file found so scan next file in current directory
                    'we are removing this file because this found allready
                    'this will reduce sizeof files allowed to scan it again 
                    'presently it is not neccessory but if we will take long list of allowed list it will 
                    'take less time 
                    FilesAllowedToDelete.Remove(alf)
                    GoTo ContFor
                End If
            Next
            'ifcontrolcomes here that is not found that filein allowed list 
            'so retrun because on file is not matching 
            Ex = New Exception(dinfo.FullName + " : Directory Not Empty")
            'EventCollection.Add(dinfo.FullName + " : Directory not Empty.")
            Return False
ContFor:
        Next

        'here all files are scaned and they are same ready to delete
        For Each fl As FileInfo In FilesInSideDir
            'Dim exs As New Exception
            Dim event2 As New ArrayList
            If Not DeleteFile(fl, SendToRecycleBin, ForceToDelete, EnableProcessFilter, event2, Ex) Then
                'failed to delete this file so Exit
                EventCollection.AddRange(event2)
                Return False
            Else
                EventCollection.AddRange(event2)
                'continue
            End If
        Next

        'here delete this directory
        Dim event3 As New ArrayList
        If Not DeleteDirectory(dinfo, SendToRecycleBin, ForceToDelete, EnableProcessFilter, event3, Ex) Then
            FailedToDeletedDir.Add(dinfo.FullName)
            EventCollection.AddRange(event3)
            Return False
        Else
            DeletedDir.Add(dinfo.FullName)
            EventCollection.AddRange(event3)
            Return True
        End If


        'happly return true
        Return True
    End Function

#Region "         Delete file or folder         "

    Public Function DeleteFile(ByVal file_info As FileInfo, _
                               Optional ByVal SendToRecycleBin As Boolean = False, _
                               Optional ByVal ForceToDelete As Boolean = False, _
                                Optional ByVal EnableProcessFilter As Boolean = True, _
                                Optional ByRef EventCapture As ArrayList = Nothing, _
                                Optional ByRef ex As Exception = Nothing) As Boolean
        'we will send exception only file file is not deleted

        EventCapture = New ArrayList
        EventCapture.Clear()


        'Check For file exist
        If Not file_info.Exists Then
            ex = New System.IO.FileNotFoundException
            EventCapture.Add(file_info.FullName + "   : Not Found.")
            Return False
        Else
            'EventCapture.Add(file_info.FullName + "   : Found.")
            'do not log extra things 
        End If


        'STAGE 1
        '***************************************************
        '1st  Attemp to delete file

        Try
            If DeletefileNow(file_info, SendToRecycleBin, ex) Then
                EventCapture.Add(file_info.FullName + "   : Deleted.")
                'if it happen return happily
                Return True
            End If
        Catch 'exs As Exception
            'here no need to do any thing because it has a great probability to 
            'cause a Exception for file attribute is not normal
        End Try


        'STAGE 2
        '****************************************************
        'Now set attribute to normal `
        'if here Exception occure then it means that ntfs permission is not found
        'so add NTFS Permission
        Try
            file_info.Attributes = FileAttributes.Normal
            'EventCapture.Add(file_info.FullName + "  :Attribute set to Normal.")
            If DeletefileNow(file_info, SendToRecycleBin, ex) Then
                EventCapture.Add(file_info.FullName + "   : Deleted.")
                'if it happen return happily
                Return True
            End If
        Catch ex
            EventCapture.Add(ex.Message)
        End Try

        'STAGE 3 
        '*****************************************************
        'here we think that NTFS SECURITY IS not allow to delete file
        'so adding  ntfs access
        Try
            NTFS.AddFullcontrolToFile(file_info.FullName)
            'EventCapture.Add(file_info.FullName + " : Full Control added.")
        Catch ex
            'if here exception occure , its mean that drive is write protected...
            EventCapture.Add(file_info.FullName + " : Failed to add Full control. May be Media is write protected..")
            Return False
        End Try

        'Stage 4
        '******************************************************
        'Again we will try to delete file
        Try
            file_info.Attributes = FileAttributes.Normal
            If DeletefileNow(file_info, SendToRecycleBin, ex) Then
                EventCapture.Add(file_info.FullName + "   : Deleted.")
                'if it happen return happily
                Return True
            End If
        Catch ex
            'here Exception occure if it is used in any process
        End Try




        'Stage 4a
        '........................................................
        'now we are going to delete this file very hardly
        'if force to delte is not allowed
        'this try is only added to catch ex.
        Try
            If Not ForceToDelete Then
                EventCapture.Add(file_info.FullName + " : Failed to delete.")
                Throw New Exception("File is in use ,Unable to delete.")
                Return False
            End If
        Catch ex
            Return False
        End Try

        'Stage5
        '-------------------------------------------
        '{We can do a thing here , just check for modules of each process}
        'but right now we will search each process for its mainprocess file

        'check for file usage 
        For Each p As Process In Diagnostics.Process.GetProcesses

            Try
                If p.MainModule.FileName.ToLower = file_info.FullName.ToLower Then
                    EventCapture.Add(p.ProcessName + " with  PID :" + p.Id.ToString + "is using " + file_info.FullName)
                    'kill process
                    'now killng the process
                    Dim Eventlist As New ArrayList
                    Dim responce As Integer = KillProcessClass.killProcessById(p.Id, True, EnableProcessFilter, Eventlist)

                    EventCapture.AddRange(Eventlist)
                    'return 0 if process not terminated and file not deleted.
                    'return 1 if process trminated but file is not deleted
                    'return 2 if process terinated and file deleted.
                    'return -1 if process do not exist
                    'return -2 if process is dangerous
                    'return -3 if exception in process termination
                    Select Case responce
                        Case 2
                            'we can exit because file is deleted
                            EventCapture.Add(file_info.FullName + " : Deleted.")
                            Return True
                        Case 1
                            'may be there is more process using this
                            Exit Select
                        Case 0
                            'because process Exist we can not delete file
                            EventCapture.Add("Failed to terminate Process. Failed to delete file.")
                            Return False
                        Case -1
                            'process do not exist.... let function continue
                        Case -2
                            'process is dangerous ,,,  do not delete file
                            EventCapture.Add("A critical process is using is file. This will be dangerous to delte this file.")
                            EventCapture.Add("To delete this file Disable process filter.")
                            Return False
                        Case -3
                            'exception in process termination ' do not delete file
                            EventCapture.Add("Unable to delete file : " + file_info.FullName)
                            Return False
                    End Select

                    'try to delete file
                    Try
                        If DeletefileNow(file_info, SendToRecycleBin, ex) Then
                            EventCapture.Add(file_info.FullName + "   : Deleted.")
                            'if it happen return happily
                            Return True
                        End If
                    Catch
                        'do nothing may be file is deletetd.
                    End Try

                End If
            Catch exp As Exception
                'here exception will occure due to system process 
            End Try
        Next
        '---------------------------


        'after scanning in all proces path 
        ' we again try to delete file
        'try to delete file
        Try
            If DeletefileNow(file_info, SendToRecycleBin, ex) Then
                EventCapture.Add(file_info.FullName + "   : Deleted.")
                'if it happen return happily
                Return True
            End If
        Catch ex 'As Exception
            EventCapture.Add(ex.Message)
            Return False
        End Try

    End Function

    Public Function DeletefileNow(ByVal Finfo As FileInfo, _
                                     Optional ByVal SendToRecycleBin As Boolean = True, _
                                     Optional ByRef Ex As Exception = Nothing) As Boolean

        'clearing previous exception detail 
        'Exp = New Exception


        Try
            If SendToRecycleBin Then
                'here we are sending this file to recyll bin
                'if we use my.computer.filesystem.deletefile() then we have to add error msgbox 
                'Finfo.Attributes = FileAttributes.Normal
                My.Computer.FileSystem.DeleteFile(Finfo.FullName, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
            Else
                'kill this file using deletefile
                'Finfo.Attributes = FileAttributes.Normal
                My.Computer.FileSystem.DeleteFile(Finfo.FullName)
            End If
            Return True
        Catch ex
            Return False
        End Try
    End Function

    Public Function DeleteDirectory(ByVal dinfo As DirectoryInfo, _
                                    Optional ByVal SendToRecycleBin As Boolean = True, _
                                    Optional ByVal ForceToDelete As Boolean = False, _
                                    Optional ByVal EnableProcessFilter As Boolean = True, _
                                    Optional ByRef EventCollection As ArrayList = Nothing, _
                                    Optional ByRef ex As Exception = Nothing) As Boolean

        EventCollection = New ArrayList

        'do first attempt to delete dir directly
        If DeleteDirectoryNow(dinfo, SendToRecycleBin, ex) Then
            EventCollection.Add(dinfo.FullName + " : Deleted.")
            Return True
        End If

        'here we will  reach if exception will occure
        'so try to add NTFS security

        If Not NTFS.AddFullControlToDirectory(dinfo.FullName, ex) Then
            'here exception will occure if media is wrote protected
            EventCollection.Add(dinfo.FullName + " : failed to Delete.")
            Return False
        End If

        'now normalize attribute
        Try
            dinfo.Attributes = FileAttributes.Normal
        Catch ex
            'i dont know what wrong with if this happen...
            EventCollection.Add(dinfo.FullName + " : failed to Delete.")
            Return False
        End Try





        'do 2nd attempt to delete dir directly
        'here NTFS full control is added and Attribute is normal
        If DeleteDirectoryNow(dinfo, SendToRecycleBin, ex) Then
            EventCollection.Add(dinfo.FullName + " : Deleted.")
            Return True
        End If

        '--------------------------------------------
        'here if dir is not deleted then this is only change that any file or folder is under use
        'or dir is in use

        '====================
        'Select Case ex.GetType().ToString
        'The exception that is thrown when the operating system denies access 
        'because of an I/O error or a specific type of security error.
        'mark this thing that OS denies
        'Case "System.UnauthorizedAccessException'"
        'The exception that is thrown when an I/O error occurs.
        'ntfs permission , file in use type or not found type exception
        'Case "System.IO.IOException"
        'End Select
        '=======================


        'now check if forcetodelete is true
        If Not ForceToDelete Then
            EventCollection.Add(dinfo.FullName + "  : Failed to delete file/folder! Use Forced Deletion to remove this item.")
            Return False
        End If


        'first thing delete all directory
        'if any directory is not deleted then do not stop complete process
        Try
            For Each Dir As DirectoryInfo In dinfo.GetDirectories
                Dim Event1 As New ArrayList
                If Not DeleteDirectory(Dir, SendToRecycleBin, ForceToDelete, EnableProcessFilter, Event1, ex) Then
                    'EventCollection.AddRange(Event1)
                    '
                    'Enable this return to stop this process if any error happen 
                    'this will intrupt all procedure form this point
                    '
                    'Return False
                End If
                'only collect all information once because all detail about previous attempts are 
                'loged before in Event1 arraylist , there is no need to log any failed detail in eventcollection
                EventCollection.AddRange(Event1)
            Next
        Catch ex 'As Exception
            EventCollection.Add(dinfo.FullName + " : Failed to delete.")
            Return False
        End Try



        'delete each file of this directory
        Try
            For Each fl As FileInfo In dinfo.GetFiles
                Dim Event2 As New ArrayList
                If Not DeleteFile(fl, SendToRecycleBin, ForceToDelete, EnableProcessFilter, Event2, ex) Then
                    'EventCollection.AddRange(Event2)
                    'Enable this to Entrupt delete at this point if exception occure
                    'Return False
                End If
                EventCollection.AddRange(Event2)
            Next
        Catch ex 'As Exception
            'atleast one file exist so this will be better to leave this directory
            Return False
        End Try


        'now delete  this dir
        Try
            dinfo.Attributes = FileAttributes.Normal
            EventCollection.Add(dinfo.FullName + " : Attribute set to Normal.")
            dinfo.Delete()
            If dinfo.Exists Then
                EventCollection.Add(dinfo.FullName + " : Failed to delete.")
                Return False
            Else
                EventCollection.Add(dinfo.FullName + " : Deleted.")
                Return True
            End If
        Catch ex 'As Exception
            EventCollection.Add(dinfo.FullName + " : Failed to delete.")
            Return False
        End Try

    End Function

    Public Function DeleteDirectoryNow(ByVal Dinfo As DirectoryInfo, _
                                       Optional ByVal SendToRecycleBin As Boolean = True, _
                                       Optional ByRef Ex As Exception = Nothing) As Boolean

        'clearing previous exception detail 
        'Exp = New Exception


        Try
            If SendToRecycleBin Then
                'here we are sending this dir to recyle bin with all its contant
                'if we use my.computer.filesystem.deletedirectory() then we have to add error msgbox 
                Dinfo.Attributes = FileAttributes.Normal
                My.Computer.FileSystem.DeleteDirectory(Dinfo.FullName, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
            Else
                'kill this direcotry using directoryinfo.delete()
                Dinfo.Attributes = FileAttributes.Normal
                My.Computer.FileSystem.DeleteDirectory(Dinfo.FullName, FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            Return True
        Catch ex
            Return False
        End Try
        'collect recycle detail
        'creating rules
        'only error dialog will make it silent event




        'Try
        'attatemp to delete file
        'My.Computer.FileSystem.DeleteDirectory(Dinfo.FullName, FileIO.UIOption.OnlyErrorDialogs, Rcl, FileIO.UICancelOption.DoNothing)
        'System.IO.Directory.Delete(Dinfo.FullName, True)
        '
        'Return True
        'read only type drive or content of that folder is not normal attributed. 
        'Catch ex As System.UnauthorizedAccessException
        'MsgBox(Ex.Message + "  " + Ex.GetType().ToString)
        'Exit Try
        'ntfs permission , file in use type or not found type exception
        'Catch ex As System.IO.IOException
        'MsgBox(Ex.Message + "  " + Ex.GetType().ToString)
        'Exit Try

        'Catch ex As System.IO.DriveNotFoundException
        '   MsgBox(ex.Message + "  " + ex.GetType().ToString)
        'Catch ex As Exception
        'MsgBox(Ex.Message + "  " + Ex.GetType().ToString)
        'Return False

        'End Try

    End Function


#End Region

End Module
