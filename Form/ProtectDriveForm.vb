'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date : 07/12/2009                               '
'                                                                  '
'******************************************************************'

'*************BUG REPORT********************************'
' a bug is introducing when form try to load            '
' exception handling is properly done but this happen   '
'*******************************************************'

Imports System
Imports System.IO

Public Class ProtectDriveForm

#Region "  Function Used "

    'here drives is a arraylist of driveinfo's of drives
    'this funcion delte already present autorun.inf files and create a folder naming autorun.inf
    '
    Private Function protectDrivesNow(ByVal drives As ArrayList, ByRef Str As String, _
                                      Optional ByVal Attribute As FileAttributes = FileAttributes.Normal) As Boolean
        'resetting information
        Str = String.Empty

        For Each drive As DriveInfo In drives
            'useful when floppy attacched of write protected disk attached
            If Not drive.IsReady Then
                Str += drive.Name + " is " + drive.DriveType.ToString + " is not ready.   Skipped." + vbNewLine
                Continue For
            End If

            'here drive is ready to check and readty for r/w operation
            Try
                Str += vbNewLine
                'leaving CDROM 
                If drive.DriveType = DriveType.Removable Or drive.DriveType = DriveType.Fixed Then

                    'It delete already presented autorun.inf ""file""
                    If My.Computer.FileSystem.FileExists(drive.Name + "autorun.inf") Then
                        'setting file Attribute because most probably it has an attribute of readonly+systemn+hidden
                        'System.IO.File.SetAttributes(drive.Name + "autorun.inf", FileAttributes.Normal)

                        'here i am going to use deletefile function for exact delete operation 
                        'because in ntfs drives , this autorun.inf file is locked by read permission
                        Dim exs As New Exception
                        If Not DeleteFile(New FileInfo(drive.Name + "autorun.inf"), False, False, True, , exs) Then
                            Str += exs.Message  '"File  " + drive.Name + "Autorun.inf file was Exist.  Deleted" + vbNewLine
                            Continue For
                        Else
                            'storing Detail in str
                            Str += "File  " + drive.Name + "Autorun.inf file was Exist.  Deleted" + vbNewLine
                        End If

                    End If

                    'creating autorun.inf folder
                    CreateAutorun(drive, Str, Attribute)

                Else
                    Str += drive.Name + " is " + drive.DriveType.ToString + ".   Skipped." + vbNewLine
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
        Return True
    End Function

    Private Sub CreateAutorun(ByVal Drive As DriveInfo, ByRef str As String, ByVal Attribute As IO.FileAttributes)

        On Error Resume Next

        'creating autorun.inf folder
        If Not My.Computer.FileSystem.DirectoryExists(Drive.Name + "autorun.inf") Then
            'create folder

            My.Computer.FileSystem.CreateDirectory(Drive.Name + "Autorun.inf\AUTORUN.INI")
            Dim dir As New DirectoryInfo(Drive.Name + "Autorun.inf\AUTORUN.INI")
            dir.Attributes = Attribute
            My.Computer.FileSystem.CreateDirectory(Drive.Name + "Autorun.inf\SETUP.INI")
            dir = New DirectoryInfo(Drive.Name + "Autorun.inf\SETUP.INI")
            dir.Attributes = Attribute
            dir = New DirectoryInfo(Drive.Name + "Autorun.inf")
            dir.Attributes = Attribute

            str += "Folder " + Drive.Name + "Autorun.inf  created and attribute is changed to " + Attribute.ToString + vbNewLine
        Else
            Dim dir As New DirectoryInfo(Drive.Name + "Autorun.inf")
            dir.Attributes = FileAttributes.Normal

            My.Computer.FileSystem.CreateDirectory(Drive.Name + "Autorun.inf\AUTORUN.INI")
            dir = New DirectoryInfo(Drive.Name + "Autorun.inf\AUTORUN.INI")
            dir.Attributes = Attribute

            My.Computer.FileSystem.CreateDirectory(Drive.Name + "Autorun.inf\SETUP.INI")
            dir = New DirectoryInfo(Drive.Name + "Autorun.inf\SETUP.INI")
            dir.Attributes = Attribute

            dir = New DirectoryInfo(Drive.Name + "Autorun.inf")
            dir.Attributes = Attribute
            str += "Folder " + Drive.Name + "Autorun.inf  already Exist but attribute is changed to " + Attribute.ToString + vbNewLine
        End If
    End Sub

    'this function collect attribute s from checkboxs
    Private Function GetAttribute() As IO.FileAttributes
        'collect attribute
        Dim fAttrib As FileAttributes
        fAttrib = FileAttributes.Normal

        Try
            'Nomalizing file attribute
            fAttrib = FileAttributes.Normal

            If FileAttributeReadOnly.Checked = True Then
                fAttrib += FileAttributes.ReadOnly
            End If

            If FileAttributeSystem.Checked = True Then
                fAttrib += FileAttributes.System
            End If

            If FileAtttributeHidden.Checked = True Then
                fAttrib += FileAttributes.Hidden
            End If

            If FileAttributeArchive.Checked = True Then
                fAttrib += FileAttributes.Archive
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return FileAttributes.Normal
        End Try

        Return fAttrib

    End Function

    'this function collect autorun.inf file/folder status in each drive front
    Private Sub RefreshList()
        
        Try
            '1st clear listvierw
            DrvListView.Items.Clear()

            'here collect all drives of system and list them in listview
            'With DrvListView
            'now buield it
            For Each drv As DriveInfo In DriveInfo.GetDrives
              
                If IgnoreDrive(drv, True, True) Then Continue For

                Dim LvItem As New ListViewItem(drv.Name)

                LvItem.Text = drv.Name
                LvItem.SubItems.Add(drv.DriveType.ToString)

                If drv.IsReady Then
                    LvItem.SubItems.Add(drv.VolumeLabel)
                    LvItem.SubItems.Add(ByteSizeOptimaized(drv.TotalSize))
                    'here get if autorun.inf file or folder exist
                    If My.Computer.FileSystem.FileExists(drv.Name + "autorun.inf") Then
                        LvItem.SubItems.Add("File Found.")
                        LvItem.BackColor = Color.Red
                        LvItem.Checked = False
                    ElseIf My.Computer.FileSystem.DirectoryExists(drv.Name + "autorun.inf") Then
                        LvItem.SubItems.Add("Protected.")
                        LvItem.BackColor = Color.LightGreen
                        LvItem.Checked = True
                    Else
                        LvItem.SubItems.Add("Not Protected.")
                        LvItem.BackColor = Color.White
                        LvItem.Checked = False
                    End If
                Else
                    'here drive is not ready so make all sub entry empty
                    LvItem.SubItems.Add(String.Empty)
                    LvItem.SubItems.Add(String.Empty)
                    LvItem.SubItems.Add(String.Empty)
                    LvItem.Checked = False
                    LvItem.BackColor = Nothing
                End If
                'add this drive to listview
                DrvListView.Items.Add(LvItem)
            Next
            'End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

#End Region


    Private Sub ProtectDriveForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'adding handler 
        AddHandler RefreshButtorn.Click, AddressOf RefreshList


        Try
            RefreshList()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub


    Private Sub ApplyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyButton.Click
        Dim str As String = ""

        Dim drives As New ArrayList
        'drives = System.IO.DriveInfo.GetDrives
        'collect all allowed drives
        For Each drv As ListViewItem In DrvListView.Items
            'if drive is not selected that means not protected
            If Not drv.Checked Then
                'here check if folder is present in this drive
                If My.Computer.FileSystem.DirectoryExists(drv.Text + "autorun.inf") Then
                    Try
                        Dim auto As New DirectoryInfo(drv.Text + "autorun.inf")
                        auto.Attributes = FileAttributes.Normal
                        If Not DeleteAllFilesInDir(auto, , , True, True, False, , , True, ) Then
                            str += "Folder : " + drv.Text + "Autorun.inf was Exist.  Failed to Delete." + vbNewLine
                        Else
                            str += "Folder : " + drv.Text + "Autorun.inf was Exist.  Deleted." + vbNewLine
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                    End Try
                End If
                Continue For 'check other drive 
            End If

            Try
                'adding this drive to list 
                Dim drive As New DriveInfo(drv.Text)
                'collect it in array
                drives.Add(drive)
            Catch ex As Exception
                'here exception occure if drive is removed ....
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
           

        Next '/////////////////////
        'here collection of drives  and removal of autorun.inf folder is  completed

        If drives.Count <= 0 Then
            'MsgBox("No drive selected.", MsgBoxStyle.Information)
        Else
            'here send collected drives to protectdrivenow function to make autorun.inf folder
            Dim str1 As String = String.Empty
            protectDrivesNow(drives, str1, GetAttribute())
            str += vbNewLine + str1 + vbNewLine
        End If
        str += "Done!"
        'refresh list
        RefreshList()
        'display msgbox
        MsgBox(str, MsgBoxStyle.Information, "Protecting Drive From Autorun")
    End Sub

End Class