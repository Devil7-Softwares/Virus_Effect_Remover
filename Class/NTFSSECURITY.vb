'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date : 07/12/2009                               '
'                                                                  '
'******************************************************************'

Imports System.IO
Imports System.Security
Imports System.Security.AccessControl
Imports System.Security.Permissions



Public Class NTFS

#Region "Constants"

    Private Const AllRights As FileSystemRights = FileSystemRights.FullControl _
                                     Or FileSystemRights.AppendData _
                                     Or FileSystemRights.ChangePermissions _
                                     Or FileSystemRights.CreateDirectories _
                                     Or FileSystemRights.CreateFiles _
                                     Or FileSystemRights.Delete _
                                     Or FileSystemRights.DeleteSubdirectoriesAndFiles _
                                     Or FileSystemRights.ExecuteFile _
                                     Or FileSystemRights.ListDirectory _
                                     Or FileSystemRights.Modify _
                                     Or FileSystemRights.Read _
                                     Or FileSystemRights.ReadAndExecute _
                                     Or FileSystemRights.ReadAttributes _
                                     Or FileSystemRights.ReadPermissions _
                                     Or FileSystemRights.Synchronize _
                                     Or FileSystemRights.TakeOwnership _
                                     Or FileSystemRights.Traverse _
                                     Or FileSystemRights.Write _
                                     Or FileSystemRights.WriteAttributes _
                                     Or FileSystemRights.WriteData _
                                     Or FileSystemRights.WriteExtendedAttributes

#End Region

#Region "Directory Ntfs security"""

    '*************************************************
    'Directory Ntfs Permission Entry add and remove
    '*************************************************

    'by this function you can get directly full control on any directory

    Friend Shared Function AddFullControlToDirectory(ByVal DirectoryName As String, Optional ByRef Ex As Exception = Nothing) As Boolean
        Try
            'First remove any deny type Entry of users from current object
            If Not NTFS.RemoveDirectorySecurity(DirectoryName, "Users", AllRights, AccessControlType.Deny, Ex) Then
                Return False
            End If
            '
            'Now allow type entry will be activate fullcontrol
            If Not AddDirectorySecurity(DirectoryName, "Users", FileSystemRights.FullControl, AccessControlType.Allow, Ex) Then
                Return False
            End If

            '---------------
            Return True
        Catch ex
            Return False
        End Try


    End Function

    'by this function you can directly remove full control
    Friend Shared Function RemoveFullControlToDirectory(ByVal DirectoryName As String, Optional ByRef Ex As Exception = Nothing) As Boolean
        Try

            ' Remove the access control entry from the directory.
            'if we add a deny type entry then there is no need to remove allow type entry
            'but for precausion we remove only full control entry
            If Not NTFS.RemoveDirectorySecurity(DirectoryName, "Users", FileSystemRights.FullControl, AccessControlType.Allow, Ex) Then
                Return False
            End If

            'and add the deny type entry to stop access
            If Not NTFS.AddDirectorySecurity(DirectoryName, "Users", FileSystemRights.FullControl, AccessControlType.Deny, Ex) Then
                Return False
            End If

            '-----------
            Return True
        Catch ex
            Return False
        End Try


    End Function


    ' Adds an ACL entry on the specified directory for the specified account.
    Friend Shared Function AddDirectorySecurity(ByVal FileName As String, _
                                           ByVal Account As String, _
                                           ByVal Rights As FileSystemRights, _
                                           ByVal ControlType As AccessControlType, _
                                                 Optional ByRef Ex As Exception = Nothing) As Boolean
        Try
            ' Create a new DirectoryInfoobject.
            Dim dInfo As New DirectoryInfo(FileName)

            ' Get a DirectorySecurity object that represents the 
            ' current security settings.
            Dim dSecurity As DirectorySecurity = dInfo.GetAccessControl()

            ' Add the FileSystemAccessRule to the security settings. 
            dSecurity.AddAccessRule(New FileSystemAccessRule(Account, Rights, ControlType))

            ' Set the new access settings.
            dInfo.SetAccessControl(dSecurity)

            Return True
        Catch ex 'As Exception
            Return False
        End Try

    End Function

    ' Removes an ACL entry on the specified directory for the specified account.
    Friend Shared Function RemoveDirectorySecurity(ByVal FileName As String, _
                                                   ByVal Account As String, _
                                                   ByVal Rights As FileSystemRights, _
                                                   ByVal ControlType As AccessControlType, _
                                                   Optional ByRef Ex As Exception = Nothing) As Boolean
        Try
            ' Create a new DirectoryInfo object.
            Dim dInfo As New DirectoryInfo(FileName)

            ' Get a DirectorySecurity object that represents the 
            ' current security settings.
            Dim dSecurity As DirectorySecurity = dInfo.GetAccessControl()

            ' Add the FileSystemAccessRule to the security settings. 
            dSecurity.RemoveAccessRule(New FileSystemAccessRule(Account, Rights, ControlType))

            ' Set the new access settings.
            dInfo.SetAccessControl(dSecurity)

            Return True
        Catch ex
            Return False
        End Try

    End Function
#End Region

#Region "File NTFS file security"

    '*************************************************************
    ' File NTFS Security entry add and remove
    '*************************************************************
    'directly provide fullcontrol of any file
    Friend Shared Function AddFullcontrolToFile(ByVal FileName As String, Optional ByRef Ex As Exception = Nothing) As Boolean

        Try
            'First remove any deny type Entry
            If Not NTFS.RemoveFileSecurity(FileName, "Users", AllRights, AccessControlType.Deny, Ex) Then
                Return False
            End If

            'now add fullcontrol allow entry
            If Not NTFS.AddFileSecurity(FileName, "Users", FileSystemRights.FullControl, AccessControlType.Allow, Ex) Then
                Return False
            End If

            '---------------
            Return True
        Catch ex
            Return False
        End Try

    End Function

    'remove full control of any file
    Friend Shared Function RemoveFullControlToFile(ByVal FileName As String, Optional ByRef Ex As Exception = Nothing) As Boolean
        Try

            'remove allow type fullcontrol entry
            If Not NTFS.RemoveFileSecurity(FileName, "Users", FileSystemRights.FullControl, AccessControlType.Allow, Ex) Then
                Return False
            End If

            ' and now add deny type fullcontrol entry
            If Not NTFS.AddFileSecurity(FileName, "Users", FileSystemRights.FullControl, AccessControlType.Deny) Then
                Return False
            End If

            '--------------
            Return True

        Catch ex
            Return False
        End Try

    End Function



    ' Adds an ACL entry on the specified file for the specified account.
    Friend Shared Function AddFileSecurity(ByVal fileName As String, _
                                           ByVal account As String, _
                                           ByVal rights As FileSystemRights, _
                                           ByVal controlType As AccessControlType, _
                                           Optional ByRef Ex As Exception = Nothing) As Boolean

        Try
            ' Get a FileSecurity object that represents the 
            ' current security settings.
            Dim fSecurity As FileSecurity = File.GetAccessControl(fileName)

            ' Add the FileSystemAccessRule to the security settings. 
            Dim accessRule As FileSystemAccessRule = _
                New FileSystemAccessRule(account, rights, controlType)

            fSecurity.AddAccessRule(accessRule)
            ' Set the new access settings.
            File.SetAccessControl(fileName, fSecurity)

            '----------------
            Return True
        Catch ex
            Return False
        End Try

    End Function


    ' Removes an ACL entry on the specified file for the specified account.
    Friend Shared Function RemoveFileSecurity(ByVal fileName As String, _
                                         ByVal account As String, _
                                         ByVal rights As FileSystemRights, _
                                         ByVal controlType As AccessControlType, _
                                               Optional ByRef Ex As Exception = Nothing) As Boolean

        Try
            ' Get a FileSecurity object that represents the 
            ' current security settings.
            Dim fSecurity As FileSecurity = File.GetAccessControl(fileName)

            ' Remove the FileSystemAccessRule from the security settings. 
            fSecurity.RemoveAccessRule(New FileSystemAccessRule(account, _
                rights, controlType))

            ' Set the new access settings.
            File.SetAccessControl(fileName, fSecurity)
            Return True
        Catch ex
            Return False
        End Try

    End Function

#End Region

End Class
