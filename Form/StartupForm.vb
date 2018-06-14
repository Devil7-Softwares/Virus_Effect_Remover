'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date : 23/02/2010                               '
'                     form code : SF                               '
'******************************************************************'
Imports System.IO
Imports System.Text

Public Class StartupForm

#Region "Used Function"
    'here LvItem have three things , Caption(value) , and command line , group 
    Private Sub BuildList(ByVal Lv As ListView, ByVal LvItem As ListViewItem)

        For Each gr As ListViewGroup In Lv.Groups
            If gr.Name.ToLower = LvItem.Tag.ToLower Then ' a group of same tag is present
                'found
                'Exit For
                LvItem.Group = gr
                GoTo DontCreateGroup
            End If
        Next
        'add this group to listview
        Dim grNew As New ListViewGroup
        grNew.Name = LvItem.Tag
        grNew.Header = LvItem.Tag
        Lv.Groups.Add(grNew)
        LvItem.Group = grNew

DontCreateGroup:

        'get icon 
        If Not LvItem.ToolTipText = "" Then
            'get image 
            If My.Computer.FileSystem.FileExists(LvItem.ToolTipText) Then
                'Now we can get icon
                ImageList1.Images.Add(LvItem.ToolTipText, GetICON.GetFileIcon(LvItem.ToolTipText, 0).ToBitmap)
                '  .Items(.Items.Count - 1).ToolTipText = Path
                '  .Items(.Items.Count - 1).ImageKey = Startups.Caption.ToString
                LvItem.ImageKey = LvItem.ToolTipText
            End If
        End If

        Lv.Items.Add(LvItem) '.Group = LvItem.Group


    End Sub

    'this function return true i ffully succesied
    Friend Function GetstartupListNew() As Boolean
        On Error Resume Next

        StartupListView.Items.Clear()
        StartupListView.Groups.Clear()
        ImageList1.Images.Clear()

        'these are registry location from where we will get registry startup Entry
        Dim StartupRegistry() As String = {"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run", _
                                           "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\RunEx", _
                                           "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce", _
                                           "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce\Setup", _
                                           "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnceEx", _
                                           "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\RunServices", _
                                           "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\RunServicesOnce", _
                                           "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\policies\Explorer\Run", _
                                           "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", _
                                           "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\RunEx", _
                                           "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce", _
                                           "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce\Setup", _
                                           "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnceEx", _
                                           "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\RunServices", _
                                           "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\RunServicesOnce", _
                                           "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\policies\Explorer\Run"}

        'now scan these registry path
        For Each RegString As String In StartupRegistry
            'send this registry to convert in Win32 format
            Dim R32 As Microsoft.Win32.RegistryKey = Nothing
            If Not RegistryWin32Formate(RegString, R32, False) Then
                Continue For 'if conversion is not successful then do not scan this registry 
            End If

            'now send this key to get value
            RetriveValues(R32)

        Next

        '-----------------------------------
        'now scan "load" and "run" keyvalue of "HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\Windows"
        GetValueOfRegistryKey("HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\Windows", "Load")
        GetValueOfRegistryKey("HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\Windows", "Run")

        '--------------------------------------------
        'now scan Startup Folders

        'get all files of comman Startup folder
        AddStartupFolder(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "Common Startup", String.Empty), "Common Startup")
        'get all files of Startup Folder
        AddStartupFolder(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "Startup", String.Empty), "Startup")
        Return True
    End Function

    'this function will retirve all value of provided registry and log them 
    'in list view
    Private Function RetriveValues(ByVal StartupRegistry As Microsoft.Win32.RegistryKey) As Boolean
        'retrive all values
        '  MsgBox(StartupRegistry.Name)

        Try
            Dim RegistryValues() As String = StartupRegistry.GetValueNames
            'here if this registry do not have any value then return
            If RegistryValues.Length <= 0 Then Return True

            'now obtain data of  each registry 
            For Each value In RegistryValues
                GetValueOfRegistryKey(StartupRegistry.Name, value)
            Next

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Function GetValueOfRegistryKey(ByVal RegistryKey As String, ByVal RegValue As String) As Boolean

        Dim R32 As Microsoft.Win32.RegistryKey = Nothing
        If Not RegistryWin32Formate(RegistryKey, R32) Then
            Return False
        End If

        Try
            'then scan for valuekind
            If Not R32.GetValueKind(RegValue) = RegistryValueKind.String Then Return False

            Dim Data As String = R32.GetValue(RegValue) 'this is command line

            Dim path As String = ""
            Dim Argument As String = ""

            If Not ExtactPathAndArgument(Data, path, Argument) Then
                path = ""
                Argument = ""
            End If
        

            'form here we will build listview item
            Dim lvItem As New ListViewItem
            lvItem.Text = RegValue
            lvItem.ToolTipText = path
            lvItem.Tag = RegistryKey
            lvItem.SubItems.Add(Data)  'command line
            lvItem.SubItems.Add(path)     'path
            lvItem.SubItems.Add(Argument) 'argument

            BuildList(StartupListView, lvItem)

        Catch ex As Exception
            Return False
        End Try

    End Function

    'here strFolder is fullpath  of startuplink & LableName is Group name of this Startup Link
    'this LableName is used to display This entry in this group name

    Private Sub AddStartupFolder(ByVal strFolder As String, Optional ByVal LableName As String = Nothing)

        Try
            If String.IsNullOrEmpty(strFolder) OrElse (Not Directory.Exists(strFolder)) Then
                Return
            End If

            If LableName = Nothing Then
                LableName = strFolder
            End If


            For Each fl As IO.FileInfo In New IO.DirectoryInfo(strFolder).GetFiles
                Dim path As String = ""
                Dim arg As String = ""
                If fl.Extension.ToLower = ".lnk" Then 'if this is a link
                    ShortcutClass.ResolveShortcut(fl.FullName, path, arg)
                    'MsgBox(fl.FullName + vbNewLine + path + vbNewLine + arg)
                Else                                       'this is not a link , it is a file 
                    path = fl.FullName
                    arg = ""
                End If

                Dim Lvitem As New ListViewItem
                Lvitem.Tag = LableName
                Lvitem.Text = fl.Name
                Lvitem.ToolTipText = fl.FullName
                If arg = "" Or arg = Nothing Then
                    Lvitem.SubItems.Add(path)
                Else
                    Lvitem.SubItems.Add(path + " /" + arg)
                End If

                Lvitem.SubItems.Add(path)
                Lvitem.SubItems.Add(arg)

                BuildList(StartupListView, Lvitem)
            Next
        Catch ex As Exception

        End Try
    End Sub


#End Region

#Region "Startup Form Event"

#Region "    ToolStrip1 event       "
    Private Sub ScanStartupEntryToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScanStartupEntryToolStripButton.Click
        Try
            'GetStartupList()
            GetstartupListNew()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub AddNewStartupEntryToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewStartupEntryToolStripButton.Click
        Try
            Dim startupaddForm1 As New StartupAddForm
            startupaddForm1.ShowDialog()
            startupaddForm1.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ExplorerAssociatedFileDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExplorerAssociatedFileDetailToolStripMenuItem.Click
        Try
            Dim reset_result As MsgBoxResult

            reset_result = MsgBox("The Current Status is : " + vbNewLine + _
                                  My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", "Shell", Nothing) + vbNewLine + vbNewLine + _
            "To remove manually: Go to RUN, and type 'Regedit [Enter/Return key]'" + vbNewLine + _
            "In regedit go to key: HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon" + vbNewLine + _
            "Now locate key: ""Shell""             {unless you're using alternative shell!}" + vbNewLine + _
            "There should be only one string contained therein:" + vbNewLine + vbNewLine + _
            "Explorer.exe" + vbNewLine + vbNewLine + _
            "Remove ANY other strings carefully, (so you don't damage the above default!)" + vbNewLine + _
            "To reset the registry, then press the [OK] or [Cancel] button accordingly." + vbNewLine, MsgBoxStyle.OkCancel Or MsgBoxStyle.Information, "Userinit Key & How To Reset It")

            If reset_result = MsgBoxResult.Ok Then
                'again Confirm 
                If Not MessageBox.Show("Press [Ok] to reset your key", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then
                    MsgBox("Action cancled by User.", MsgBoxStyle.Information)
                    Return
                End If
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", "Shell", "Explorer.exe")
                MsgBox("The currrent status is : " + vbNewLine + _
                       My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", "Shell", Nothing), MsgBoxStyle.Information, "Reset Complete.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub UserinitAssociatedFileDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserinitAssociatedFileDetailToolStripMenuItem.Click
        Try
            Dim reset_result As MsgBoxResult

            reset_result = MsgBox("The Current Status is : " + vbNewLine + _
                                  My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", "Userinit", Nothing) + vbNewLine + vbNewLine + _
            "To remove manually: Go to RUN, and type 'Regedit [Enter/Return key]'" + vbNewLine + _
            "In regedit go to key: HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon" + vbNewLine + _
            "Now locate key: ""UserInit""" + vbNewLine + _
            "There should be only one string contained therein:" + vbNewLine + _
            "C:\WINDOWS\system32\userinit.exe," + vbNewLine + vbNewLine + _
            "Remove ANY other strings carefully, (so you don't damage the above default!)" + vbNewLine + _
            "[Remember : Here 'C:\Windows' is you installation drive.]" + vbNewLine + _
            "To reset the registry, then press the [OK] or [Cancel] button accordingly." + vbNewLine, MsgBoxStyle.OkCancel Or MsgBoxStyle.Information, "Reset Userinit Key ")

            If reset_result = MsgBoxResult.Ok Then
                'again Confirm 
                If Not MessageBox.Show("Press [Ok] to reset your key", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then
                    MsgBox("Action cancled by User.", MsgBoxStyle.Information)
                    Return
                End If
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", "Userinit", _
                   My.Application.GetEnvironmentVariable("WinDir") + "\system32\userinit.exe,")
                MsgBox("The currrent status is : " + vbNewLine + _
                       My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", "Userinit", Nothing), MsgBoxStyle.Information, "Reset Complete")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub OpenCommonStartupFolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenCommonStartupFolderToolStripMenuItem.Click
        Try
            ' Make sure variables are declared.
            Dim objShell, strDesktopPath
            objShell = CreateObject("WScript.Shell")
            strDesktopPath = objShell.SpecialFolders("AllUsersStartup")
            Process.Start(strDesktopPath)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub OpenUsersStartupFolderToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenUsersStartupFolderToolStripMenuItem1.Click
        Try
            ' Make sure variables are declared.
            Dim objShell, strDesktopPath
            objShell = CreateObject("WScript.Shell")
            strDesktopPath = objShell.SpecialFolders("Startup")
            Process.Start(strDesktopPath)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region


#Region "        Context menu Events"

    'this function is working
    Private Sub ViewRegistryInRegistryEditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewRegistryInRegistryEditorToolStripMenuItem.Click
        'collect string first
        Dim key As String = ""
        Dim value As String = ""


        '   Select Case StartupList.Items(StartupList.SelectedIndices(0)).SubItems(5).Text.ToUpper
        Select Case StartupListView.Items(StartupListView.SelectedIndices(0)).Group.Name.ToUpper

            Case "Startup".ToUpper
                If MsgBox("This startup is placed in User's Startup folder." + vbNewLineVER(2) + _
                          "Would you like to open this folder?", MsgBoxStyle.Information Or MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    OpenUsersStartupFolderToolStripMenuItem1_Click(sender, Nothing)
                End If
                Return
            Case "Common Startup".ToUpper
                If MsgBox("This startup is placed in Common Startup folder." + vbNewLineVER(2) + _
                          "Would you like to open this folder?", MsgBoxStyle.Information Or MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    OpenCommonStartupFolderToolStripMenuItem_Click(sender, Nothing)
                End If
                Return

            Case "Win.ini".ToUpper
                'two type entry exist in this entry
                'Load[0] Or  Run[0]
                Select Case StartupListView.Items(StartupListView.SelectedIndices(0)).Text.ToUpper
                    Case "Load".ToUpper
                        key = "HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\Windows"
                        value = "Load"
                        Return
                    Case "Run".ToUpper
                        key = "HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\Windows"
                        value = "Run"
                        '("HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\Windows", _
                        '"Run", AlsoDelFile, event2)
                        Return
                    Case Else
                        MsgBox("Please provide this Startup Entry detail to Author." _
                                + vbNewLine + "avinashsachan@gmail.com", MsgBoxStyle.Information)
                        Return
                End Select

            Case Else
                'now here it is a registy enrty 
                key = StartupListView.Items(StartupListView.SelectedIndices(0)).Group.Name
                value = StartupListView.Items(StartupListView.SelectedIndices(0)).Text

        End Select


        Dim r32 As Microsoft.Win32.RegistryKey = Nothing
        RegistryWin32Formate(key, r32)

        RegEditJump(r32.Name, value)

    End Sub

    Private Sub CopyFileToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyFileToolStripMenuItem3.Click
        If NothingSelectedInlistView(StartupListView) Then Return
        Try
            EditingClass.CopyToClipboard(StartupListView.Items(StartupListView.SelectedIndices(0)).SubItems(2).Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub

    Private Sub CopyFilePathToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyFilePathToolStripMenuItem3.Click
        If NothingSelectedInlistView(StartupListView) Then Return

        Try
            Clipboard.SetText(StartupListView.Items(StartupListView.SelectedIndices(0)).SubItems(2).Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

#End Region


    Private Sub StartupForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        SendToRecycleBinToolStripMenuItem.Checked = My.Computer.Registry.GetValue(My.Resources.VERKey + "\Startup", "SendToRecycleBin", 1)
        'Build Startup and service list , process list , block list
        GetstartupListNew()
    End Sub

    Private Sub OpenLocationOfSelectedEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenLocationOfSelectedEntryToolStripMenuItem.Click

        If NothingSelectedInlistView(StartupListView) Then Return

        Try
            Dim path = StartupListView.Items(StartupListView.SelectedIndices(0)).ToolTipText
            If My.Computer.FileSystem.FileExists(path) Then
                System.Diagnostics.Process.Start(My.Computer.FileSystem.GetParentPath(path))
            Else
                MsgBox("File not found.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub RemoveEntryOnlyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveEntryOnlyToolStripMenuItem.Click

        If NothingSelectedInlistView(StartupListView) Then Return

        Try
            'First confirming the action if not ok return
            If MsgBox("Do you want to remove this Startup Entry ?", _
                      MsgBoxStyle.OkCancel Or MsgBoxStyle.Information, _
                      " Confirmation") <> MsgBoxResult.Ok Then
                Return
            End If

            'removeFromlist()
            Dim EventCollect As New ArrayList
            removeFromlist(False, EventCollect)
            'EventForm.UpdateEventList(EventCollect)

            'get startup list 
            GetstartupListNew()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub RemoveEntryAndAssociatedFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveEntryAndAssociatedFileToolStripMenuItem.Click
        If NothingSelectedInlistView(StartupListView) Then Return
        Try

            'first confirming the action
            If MsgBox("Do you want to remove this Startup Entry and Associated file ?", _
                      MsgBoxStyle.OkCancel Or MsgBoxStyle.Information, _
                      "Confirmation") <> MsgBoxResult.Ok Then
                Return
            End If


            'Dim path = StartupList.Items(StartupList.SelectedIndices(0)).ToolTipText
            Dim EventCollect As New ArrayList
            removeFromlist(True, EventCollect)

            'EventForm.UpdateEventList(EventCollect)

            'rescan startuplist 
            GetstartupListNew()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub



    'this function is used to remove entry from startup

    Private Sub removeFromlist(Optional ByVal AlsoDelFile As Boolean = False, _
                               Optional ByRef EventCollect As ArrayList = Nothing)
        EventCollect.Clear()

        Try
            'check if nothing is selected
            If NothingSelectedInlistView(StartupListView) Then
                MessageBox.Show("Click on a Startup Entry to select it.", "No Startup Entry or blank selected", _
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            'MsgBox("Ready to delete.")
            'select startup type  from startup location 
            'these location will be
            'Startup , Comman Startup , Win.ini , Or registry key  or a registry key with * in starting
            '
            Select Case StartupListView.Items(StartupListView.SelectedIndices(0)).Group.Name.ToUpper

                Case "Startup".ToUpper
                    EventCollect.Add("Statup folder entry.")
                    Dim event4 As New ArrayList
                    RemoveFromStartupFolder("Startup", AlsoDelFile, event4)
                    EventCollect.AddRange(event4)
                    GetstartupListNew()
                    Return

                Case "Common Startup".ToUpper
                    EventCollect.Add("Common Statup folder entry.")
                    Dim event4 As New ArrayList
                    RemoveFromStartupFolder("Common Startup", AlsoDelFile, event4)
                    EventCollect.AddRange(event4)
                    GetstartupListNew()
                    Return

                    'Case "Win.ini".ToUpper
                    'two type entry exist in this entry
                    'Load[0] Or  Run[0]
                    '   Select Case StartupListView.Items(StartupListView.SelectedIndices(0)).Text.ToUpper
                    'Case "Load".ToUpper
                    'HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\Windows , Load ,
                    '   Dim event2 As New ArrayList
                    '  RemoveStartupFromRegistry _
                    ' ("HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\Windows", _
                    '  "Load", AlsoDelFile, event2)
                    '  EventCollect.AddRange(event2)
                    '  Return
                    ' Case "Run".ToUpper
                    'HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\Windows , Run , file path
                    '    Dim event2 As New ArrayList
                    '    RemoveStartupFromRegistry _
                    '    ("HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\Windows", _
                    '     "Run", AlsoDelFile, event2)
                    '    EventCollect.AddRange(event2)
                    '  '    Return
                    '  Case Else
                    '      MsgBox("Please provide this Startup Entry Detail To Author." _
                    '              + vbNewLine + "avinashsachan@gmail.com")
                    '      Return
                    ' End Select

                Case Else
                    'now here it is a registy enrty 

            End Select


            'registry entry deletion
            'we can get reg key from location Entry
            'and can fined parent file from commond entry

            Dim regpathLocation As String = StartupListView.Items(StartupListView.SelectedIndices(0)).Group.Name

            Dim registryValue As String = StartupListView.Items(StartupListView.SelectedIndices(0)).Text

            'now deelte  registry
            Dim event3 As New ArrayList
            RemoveStartupFromRegistry(regpathLocation, registryValue, AlsoDelFile, event3)
            EventCollect.AddRange(event3)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            EventCollect.Add("Error during procedure  : " + ex.Message)
        End Try
    End Sub

    Private Function RemoveFromStartupFolder(ByVal FolderName As String, _
                                              Optional ByVal AlsoDelFile As Boolean = False, _
                                              Optional ByRef EventCollect As ArrayList = Nothing) As Boolean

        ' in common startup the commond is targetfile name 
        ' so we hv to check for .lnk , .exe , .ini , .inf
        ' but we can delete the parent file with the help of the commond field

        'this is path to common folder option , we are getting it from registry
        Dim path As String = ""
        Select Case FolderName
            Case "Startup"
                path = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "Startup", Nothing)
                Exit Select
            Case "Common Startup"
                path = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "Common Startup", Nothing)
                Exit Select
            Case Else
                'this will not happen
                Return False
        End Select



        'Shortcut name
        Dim Shfile As String = StartupListView.Items(StartupListView.SelectedIndices(0)).Text
        '
        'in place of getting file name from listview i made this file info because some time
        ' file name formate is d:\win~1.exe but actual file path is d:\win hell tif.exe
        'by this way i can get proper file path
        Dim file As String = ""
        Try
            'we are saving original file name in tool tip
            If My.Computer.FileSystem.FileExists(StartupListView.Items(StartupListView.SelectedIndices(0)).ToolTipText) Then
                Dim finfo As New FileInfo(StartupListView.Items(StartupListView.SelectedIndices(0)).ToolTipText)
                file = finfo.FullName
            Else
                'if file not found through tooltip
                Dim finfo As New FileInfo(StartupListView.Items(StartupListView.SelectedIndices(0)).ToolTipText)
                file = finfo.FullName
            End If
        Catch ex As Exception
            'unable to find file so do not attempt to delete file
            AlsoDelFile = False
        End Try



        Dim FileTypeExt() As String = {"", ".lnk", ".exe", ".ini", ".inf", ".bat", ".cmd"}
        'searching Shortcut
        For Each extType In FileTypeExt
            Dim FullName As String = path + "\" + Shfile + extType

            If My.Computer.FileSystem.FileExists(FullName) Then
                Dim event1 As New ArrayList
                If Not DeleteFile(New FileInfo(FullName), SendToRecycleBinToolStripMenuItem.Checked, True, True, event1) Then
                    MsgBox("Unable to delete file.", MsgBoxStyle.Exclamation)
                End If
                EventCollect.Add(event1)

                'here shortcut is deleted now delete file
                If AlsoDelFile Then
                    DeleteFile(New FileInfo(StartupListView.Items(StartupListView.SelectedIndices(0)).SubItems(2).Text), SendToRecycleBinToolStripMenuItem.Checked, True, True, event1)
                    EventCollect.Add(event1)
                End If
                Return True
            End If
        Next
        'if any file type is not found
        MsgBox("Error to find shortcut file.", MsgBoxStyle.Exclamation)

        '
        'get original file
        '

        If AlsoDelFile Then
            Dim event2 As New ArrayList
            If DeleteFile(New FileInfo(StartupListView.Items(StartupListView.SelectedIndices(0)).SubItems(2).Text), SendToRecycleBinToolStripMenuItem.Checked, True, True, event2) Then
                MsgBox("Original file is deleted.", MsgBoxStyle.Information)
            End If
            EventCollect.Add(event2)
        End If
        Return False
    End Function

    Private Function RemoveStartupFromRegistry(ByVal key As String, ByVal kValue As String, _
                                               Optional ByVal DelFile As Boolean = False _
                                               , Optional ByRef EventCollect As ArrayList = Nothing) As Boolean
        EventCollect.Clear()
        Try
            Dim KeyOut As Microsoft.Win32.RegistryKey = Nothing
            If Not RegistryWin32Formate(key, KeyOut) Then
                MsgBox("Unable to delete Entry.", MsgBoxStyle.Exclamation)
                EventCollect.Add("Unable to delete file.")
                Return False
            End If

            'now delete file
            If DelFile Then
                Dim FilePath As String = ""
                'first get tooltip file
                If My.Computer.FileSystem.FileExists(StartupListView.Items(StartupListView.SelectedIndices(0)).ToolTipText) Then
                    Dim finfo As New FileInfo(StartupListView.Items(StartupListView.SelectedIndices(0)).ToolTipText)
                    FilePath = finfo.FullName
                Else
                    'if not found then try to get it from regisry value
                    FilePath = KeyOut.GetValue(kValue).ToString
                End If

                'kill file 
                Dim event1 As New ArrayList
                DeleteFile(New FileInfo(FilePath), SendToRecycleBinToolStripMenuItem.Checked, True, True, event1)
                EventCollect.AddRange(event1)

            End If

            KeyOut.DeleteValue(kValue)
            EventCollect.Add(KeyOut.ToString + ":" + kValue + ":   Deleted")
            KeyOut.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            EventCollect.Add(ex.Message)
            Return False
        End Try
    End Function


#End Region


    Private Sub SendToRecycleBinToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendToRecycleBinToolStripMenuItem.Click
        Try
            SendToRecycleBinToolStripMenuItem.Checked = Not SendToRecycleBinToolStripMenuItem.Checked
            My.Computer.Registry.SetValue(My.Resources.VERKey + "\Startup", "SendToRecycleBin", SendToRecycleBinToolStripMenuItem.Checked, RegistryValueKind.DWord)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ForcedDeletionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForcedDeletionToolStripMenuItem.Click
        ForcedDeletionToolStripMenuItem.Checked = Not ForcedDeletionToolStripMenuItem.Checked

    End Sub

    Private Sub StartupStrip_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles StartupStrip.Opening
        If ListViewIsEmptyOrNotSelected(StartupListView, False) Then
            e.Cancel = True
        End If
    End Sub
End Class