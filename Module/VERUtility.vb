Imports System
Imports System.IO
Imports Virus_Effect_Remover.My.Resources

Module VERUtility

#Region "                Global declared variable"
    'Global declaretion 
    'Regisrty Key Collction
    Public HKCUPolicyExplorerKeyValuesCollection() As String = {"NoFolderOptions", "NoFileUrl", "NoRun", "NoLogoff", "NoClose", _
                                                                "NoSetFolders", "NoFind", "NoSetTaskBar", "NoDrives", "NoFileMenu", _
                                                                "NoDesktop", "NoUpdateCheck", "NoNetHood"}

    Public HKCUPolicySystemKeyValuesCollection() As String = {"DisableRegistryTools", "DisableTaskmgr", "DisableChangePassword" _
                                                              , "DisableLockWorkstation", "NoDispSettingsPage", "NoDispAppearancePage"}


    'setting windir to c:\windows  here c:\windows is installed xp drive
    Public windir As String = My.Application.GetEnvironmentVariable("WinDir")
    'current directory
    'Dim CurrentDir As String = My.Computer.FileSystem.CurrentDirectory

#End Region

#Region "    List view checking operations"
    'i have to check again and again about nothing selected or emplty condition in list view
    'so i creared this function s
    '
    'if nothing selected in listview this function return true
    'other wise it return false
    Friend Function NothingSelectedInlistView(ByRef Lv As ListView, _
                                              Optional ByVal ShowMsg As Boolean = True) As Boolean
        If Lv.SelectedItems.Count <= 0 Then
            If ShowMsg Then MsgBox("Select Entry first in list.", MsgBoxStyle.Exclamation)
            Return True
        End If
        Return False
    End Function

    Friend Function NothingCheckedInlistView(ByRef Lv As ListView, _
                                              Optional ByVal ShowMsg As Boolean = True) As Boolean
        If Lv.CheckedItems.Count <= 0 Then
            If ShowMsg Then MsgBox("Tick (Check) Entry first in list.", MsgBoxStyle.Exclamation)
            Return True
        End If
        Return False
    End Function

    'if no item in list view then return true
    Friend Function EmptyListView(ByRef Lv As ListView, _
                                              Optional ByVal ShowMsg As Boolean = True) As Boolean

        If Lv.Items.Count <= 0 Then
            If ShowMsg Then MsgBox("List is empty.", MsgBoxStyle.Exclamation)
            Return True
        End If
        Return False
    End Function

    'if above both condtion is true then it return true other wise false
    Friend Function ListViewIsEmptyOrNotSelected(ByRef Lv As ListView, _
                                              Optional ByVal ShowMsg As Boolean = True) As Boolean

        If EmptyListView(Lv, ShowMsg) Then Return True
        If NothingSelectedInlistView(Lv, ShowMsg) Then Return True
        Return False
    End Function
    'if above both condtion is true then it return true other wise false
    Friend Function ListViewIsEmptyOrNotChecked(ByRef Lv As ListView, _
                                              Optional ByVal ShowMsg As Boolean = True) As Boolean

        If EmptyListView(Lv, ShowMsg) Then Return True
        If NothingCheckedInlistView(Lv, ShowMsg) Then Return True
        Return False
    End Function

    'this function is working for IDEL listview 

    Friend Function ListviewIsIdle(ByRef Lv As ListView, _
                                              Optional ByVal ShowMsg As Boolean = True) As Boolean
        If EmptyListView(Lv, ShowMsg) Then Return True

        If NothingCheckedInlistView(Lv, False) And NothingSelectedInlistView(Lv, False) Then
            If ShowMsg Then MsgBox("Nothing selected or Ticked.", MsgBoxStyle.Exclamation)
            Return True
        End If

    End Function

#End Region


    'this utility will provide no. of new line in one go 
    Friend Function vbNewLineVER(Optional ByVal NumberofNewLine As Integer = 1) As String
        If NumberofNewLine <= 0 Then
            NumberofNewLine = 1
        End If

        Dim str As String = ""
        Dim i As Integer = 1
        For i = 1 To NumberofNewLine
            str = str + vbNewLine
        Next
        Return str

    End Function

    'this function will collect all allowed drives as driveinfo collection of drives
    'it will igone Floppy , CDROM and other drives if they are not allowed

    Friend Function _GetAllowedDrives() As ArrayList

        Dim AllowedDrives As New ArrayList
        AllowedDrives.AddRange(IO.DriveInfo.GetDrives)

        Dim NotAllowedDrives As New ArrayList

        'first collect Floppy Drives
        If My.Computer.Registry.GetValue(My.Resources.VERKey, "NeverAskFloppy", Nothing) = 1 Then
            'do not collect floppy drives , 
        Else
            'collect floppy drives to add in not allowed list
            'here  if this key is not present this will return as null
            '
            Try
                Dim r32 As Microsoft.Win32.RegistryKey = Nothing
                If RegistryWin32Formate(VERKey, r32) Then
                    Exit Try 'quiting will be best way to scape :)
                End If

                'now open value
                'If r32.GetValue("IgnoreFloppy", Nothing) Then
                If r32.GetValueKind("IgnoreFloppy") = RegistryValueKind.MultiString Then
                    NotAllowedDrives.AddRange(r32.GetValue("IgnoreFloppy", Nothing))
                End If
            Catch 'ex As Exception

            End Try

            'End If
            'My.Computer.Registry.GetValue(VERKey, "IgnoreFloppy", Nothing)

            ' NotAllowedDrives.AddRange()
        End If

        '2nd collect CDRoM Or ROmDrive '  i am assuming here that i am loding form1 first which 
        'initialize ING_CDROM to checked or unchacked state
        'ignore CDROm
        If Form1.IGN_CDROM.Checked = True Then
            For Each drv As DriveInfo In AllowedDrives
                If drv.DriveType = IO.DriveType.CDRom Then
                    NotAllowedDrives.Add(drv.Name)
                End If
            Next
        End If



        'here complete detail of not allowed drives are obtains
        'but there is a possiblity to get a clone path in notallowed list
        'so we now remove clone from arraylist
        RemoveCloneImageInArrayList(NotAllowedDrives, NotAllowedDrives)
        'here we can ignore this function because no one have more than 20 drives in his system 
        'and if any clone is there it will not cause any much time delay


        If NotAllowedDrives.Count <= 0 Then
            'no drive in registry
        Else
            'here some drives are found
            For Each drvlatter As String In NotAllowedDrives
                For Each drv As DriveInfo In AllowedDrives
                    'see if it is not allowed
                    If drvlatter.ToLower = drv.Name.ToLower Then
                        AllowedDrives.Remove(drv)
                        GoTo nextDrvlatter
                    End If
                Next
nextDrvlatter:
            Next

        End If

        ''''''''''''''''''' finaly we got all allowed files
        Return AllowedDrives
    End Function


    'this function removes clone image entry in a array list
    'while scanning file  if a file path exist more than one time this function remove them
    Friend Function RemoveCloneImageInArrayList(ByVal SourceArraylist As ArrayList, ByRef FinalArrayList As ArrayList) As Boolean
        'here first we save orignal array list in final arraylist
        'because if any thing go wrong , we will have our orignal array list
        FinalArrayList = SourceArraylist
        Try

            'Now Sort array list for clone Image Path 
            Dim i As Int32 = 0
            'when any image name will removed from collectedFile we decrease last count with one
            Dim lastCount As Int32 = SourceArraylist.Count - 1

            ' MsgBox(lastCount.ToString)
            For i = 0 To lastCount
                'picking index element
                For j = i + 1 To lastCount
                    If j > lastCount Then
                        Exit For
                    End If

                    If SourceArraylist(i).ToString.ToUpper = _
                    SourceArraylist(j).ToString.ToUpper Then
                        'now remove this element
                        SourceArraylist.RemoveAt(j)
                        'decrease last count
                        lastCount = lastCount - 1
                        'reset j again because each element is sifted to one place upper
                        j = j - 1

                    End If
                Next
            Next


            'here we will get final collected file arraylist
            FinalArrayList = SourceArraylist
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return False
        End Try
    End Function


    Friend Function Directory_Exists(ByVal path As String, Optional ByVal ShowMsg As Boolean = False) As Boolean

        If String.IsNullOrEmpty(path) Then
            If ShowMsg Then MsgBox("Provided folder path is empty or null.", MsgBoxStyle.Exclamation)
            Return False
        End If

        If My.Computer.FileSystem.DirectoryExists(path) Then
            Return True
        Else
            If ShowMsg Then MsgBox(EngResource.msg_FolderDoesNotExist, MsgBoxStyle.Exclamation)
            Return False
        End If
    End Function

    Friend Function File_Exists(ByVal path As String, Optional ByVal ShowMsg As Boolean = False) As Boolean

        If String.IsNullOrEmpty(path) Then
            If ShowMsg Then MsgBox("Provided file path is empty or null.", MsgBoxStyle.Exclamation)
            Return False
        End If

        If My.Computer.FileSystem.FileExists(path) Then
            Return True
        Else
            If ShowMsg Then MsgBox(EngResource.msg_FileDoesNotExist, MsgBoxStyle.Exclamation)
            Return False
        End If
    End Function


    'this function is design to scan if drive is ignorable 
    'true : ignore
    'false : do not ignore
    Public Function IgnoreDrive(ByRef drv As DriveInfo, _
                                Optional ByVal IgnoreFloppyDrive As Boolean = True, _
                                Optional ByVal IgnoreCDROMDrive As Boolean = True) As Boolean
        '--------------------------------------------
        ' first get which type drive is this
        Select Case drv.DriveType

            Case DriveType.CDRom
                If IgnoreCDROMDrive = True Then
                    If (Form1.IGN_CDROM.Checked = True) Then 'this is universal setting
                        Return True
                    End If
                End If
                Exit Select

            Case DriveType.Removable
                If IgnoreFloppyDrive Then
                    'here we are ignoring floppy , if it is egnored then scan
                    If Not Form1.CheckBox4.Checked = True Then    ' this is universal setting
                        'here i am scaning checkbox in place of registry value
                        'this can generate a problem if i will dispose form1
                        If drv.Name.ToLower = "a:\" Or drv.Name.ToLower = "b:\" Then
                            Return True
                        End If
                    End If
                End If
                Exit Select
            Case DriveType.Network
                Return True
            Case Else
                Return False
        End Select

        Return False

    End Function

#Region "   'text box Utility    "


    Friend Sub TextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) ' Handles textBoxSearch.Enter
        If sender.ForeColor = SystemColors.GrayText Then
            sender.ForeColor = SystemColors.WindowText
            sender.Text = ""
        End If

    End Sub

    Friend Sub TextBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles textBoxSearch.Leave
        If sender.Text.Trim() = "" Then
            sender.ForeColor = SystemColors.GrayText
            ' sender.Text = "Enter text1"
            'i am storing Initial Text in Tags to get is back
            sender.Text = sender.Tag
        End If
    End Sub

    Friend Function TextBoxIsIdle(ByRef txtbox As Windows.Forms.TextBox, Optional ByVal ShowMsg As Boolean = True) As Boolean
        If txtbox.ForeColor = SystemColors.GrayText Then
            If ShowMsg Then MsgBox("Please provide valid detail(s).", MsgBoxStyle.Information)
            Return True
        End If
        Return False
    End Function

    Friend Sub TextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Select Case sender.Text.Trim()
            Case ""
                Exit Select
            Case sender.tag
                sender.ForeColor = SystemColors.GrayText
                Exit Select
            Case Else
                sender.ForeColor = SystemColors.WindowText
        End Select
    End Sub

#End Region

End Module
