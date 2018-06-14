'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date : 21/02/2010                               '
'                     form ID : FA                                 '
'******************************************************************'


Imports System
Imports System.Diagnostics
Imports System.ServiceProcess
Imports System.Windows.Forms
Imports System.Security.AccessControl
Imports System.Security.Principal
Imports System.ComponentModel
Imports System.Resources

Imports Virus_Effect_Remover.KillProcessClass
Imports Virus_Effect_Remover.My
Imports Virus_Effect_Remover.Win32Process.Win32
Imports Virus_Effect_Remover.My.Resources
Imports Virus_Effect_Remover.NTFS
Imports System.Management


Public Class Form1

    'this function is used for changeing theme of VER by changing back color of selected controls
    Private Sub SetTheme(ByVal ThemeImage As Bitmap)
        On Error Resume Next

        Dim ChangeBkOf() As Control = {Me.BorderPanel1, Me.BorderPanel2, Me.BorderPanel4, Me.BorderPanel5, _
                                       Me.Panel5, Me.Panel6, Me.Panel7, Me.Form1Panel, Me.MainPage}

        For Each item As Control In ChangeBkOf
            item.BackgroundImage = ThemeImage
        Next

    End Sub

    'this function will configurate all check box and settings
    Friend Function loadAtStartUp() As Boolean

        'if any registry will create bug it will jump to other registry
        On Error Resume Next

        'If help file is missing then disable help menu.
        If Not My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory + "\VER_Help.chm") Then
            Me.HelpToolStripMenuItem1.Enabled = False
            Me.HelpToolStripMenuItem1.Text = "Help {File is missing.}"
        End If


        ' form tab visualisaton xp & vista tool difference
        'because in vista Dr.Watson does not 
        If GetOSVersion() = "WinXP" Then
            Me.DrWatsonToolStripMenuItem.Visible = True
        Else
            Me.DrWatsonToolStripMenuItem.Visible = False
        End If


        'Getting Drive AutoPlay Status
        Dim nodrivetype As Integer
        nodrivetype = RegInfection.scanregvalue _
        ("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
         "NoDriveTypeAutoRun")

        Select Case nodrivetype
            Case "149"
                Me.Enable_autorun.ButtonText = "USB/CD Autoplay On"
                Me.Enable_autorun.Icon = My.Resources.cancel_16
            Case "255"
                Me.Enable_autorun.ButtonText = "USB/CD Autoplay Off"
                Me.Enable_autorun.Icon = Nothing
            Case Else
                Me.Enable_autorun.ButtonText = "USB/CD Autoplay On"
                Me.Enable_autorun.Icon = My.Resources.cancel_16
        End Select


        'this section is replaced by select case ....

        ' If (nodrivetype = "149") Then
        'Me.Enable_autorun.ButtonText = "USB/CD Autoplay Allowed"
        'ElseIf (nodrivetype = "255") Then
        'Me.Enable_autorun.ButtonText = "USB/CD Autoplay Blocked"
        'Else
        'Me.Enable_autorun.ButtonText = "USB/CD Autoplay Allowed"
        'My.Computer.Registry.SetValue _
        '("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
        '"NoDriveTypeAutoRun", 149)
        'End If


        'Startup setting Check
        If My.Computer.Registry.GetValue _
        ("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", _
         "Virus Effect Remover", Nothing) = Nothing Then
            'MsgBox("Not found")
            Me.AddStartup.Checked = False
        Else
            Me.AddStartup.Checked = True
            'MsgBox("Found")
        End If


        'help setting Check
        If My.Computer.Registry.GetValue _
        (VERKey, "DontAllowHelp", Nothing) = 1 Then
            Me.Help_box.Checked = True
            Me.EnglishToolTip.Active = False
        Else
            Me.Help_box.Checked = False
            Me.EnglishToolTip.Active = True
        End If

        'DisableExitDialog setting Check
        If My.Computer.Registry.GetValue _
        (VERKey, "DisableExitDialog", Nothing) = 1 Then
            Me.DisableExitDialog.Checked = True
        Else
            Me.DisableExitDialog.Checked = False
        End If

        ''Floppy Setting Check
        'If My.Computer.Registry.GetValue _
        '(VERKey, "NeverAskFloppy", Nothing) = 1 Then
        '    Me.NeverAskFloppy.Checked = True
        '    Me.RemoveFloppyFromIgnoreList.Enabled = False
        'Else
        '    Me.Help_box.Checked = False
        '    Me.RemoveFloppyFromIgnoreList.Enabled = True
        'End If


        ' this section is not neccesory  for startup because default value is checked of ing_CDROM check box

        'Ignore cdrom  setting Check
        Me.IGN_CDROM.Checked = My.Computer.Registry.GetValue(VERKey, "IGN_CDROM", Me.IGN_CDROM.Checked)

        'Send to tray setting Check
        Me.send2tray.Checked = _
        My.Computer.Registry.GetValue(VERKey, "SendToTray", _
                                      Me.send2tray.Checked)



        ' getting folder option setting


        ' setting for system hiden file
        Me.SystemHided.Checked = My.Computer.Registry.GetValue _
        ("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
         "ShowSuperHidden", Me.SystemHided.Checked)




        'setting  for hide /show hidden fie & folder
        If My.Computer.Registry.GetValue _
        ("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
         "Hidden", Nothing) = 1 Then
            Me.ShowHideFile.Checked = True
            Me.SystemHided.Enabled = True
        Else
            Me.ShowHideFile.Checked = False
            Me.SystemHided.Enabled = False
        End If


        'ext hide check box in folderoption tab 
        Me.FileExt.Checked = My.Computer.Registry.GetValue _
        ("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
         "HideFileExt", Me.FileExt.Checked)



        'OpenToolStripMenuItem checked status
        Me.OpenToolStripMenuItem.Checked = _
        My.Computer.Registry.GetValue(VERKey, "Show Regisrty Backup", Me.OpenToolStripMenuItem.Checked)

        'floppy igone checked status
        Me.CheckBox4.Checked = _
        My.Computer.Registry.GetValue(VERKey, "DoNot_ING_Floppy", Me.CheckBox4.Checked)


        'removal media checkbox
        Me.GenDetail.Checked = _
        My.Computer.Registry.GetValue(VERKey, "GenDetail", Me.GenDetail.Checked)

        'if every thing is going well return true
        Return True

    End Function
    'this function is used to associate handle with control events
    'by this way we do not need to make a function again and again
    Private Sub AddHandlersToControls()
        'file menu controls
        AddHandler HideToolStripMenuItem.Click, AddressOf HideButton_Click
        AddHandler ExitToolStripMenuItem.Click, AddressOf EndButton_Click
        AddHandler RefressStatusToolStripMenuItem.Click, AddressOf RefreshButtonMain_Click
        AddHandler ExitToolStripMenuItem1.Click, AddressOf EndButton_Click

        'tool menu
        AddHandler TaskManagerToolStripMenuItem.Click, AddressOf Enable_taskmgr_Click
        AddHandler RegisrtyEditerToolStripMenuItem.Click, AddressOf Enable_regedit_Click
        AddHandler MSCONFIGToolStripMenuItem.Click, AddressOf Run_Msconfig
        AddHandler SystemFileCheckerToolStripMenuItem.Click, AddressOf SFC_Click
        AddHandler GenerateRunningProcessListToolStripMenuItem.Click, AddressOf GenerateprocessListButton_Click

        'handlers  for text boxs
        AddHandler TaskTabBox.Enter, AddressOf TextBox_Enter
        AddHandler TaskTabBox.Leave, AddressOf TextBox_Leave
        AddHandler TaskTabBox.TextChanged, AddressOf TextBox_TextChanged


        AddHandler ModuleAbsolutePathBox.Enter, AddressOf TextBox_Enter
        AddHandler ModuleAbsolutePathBox.Leave, AddressOf TextBox_Leave
        AddHandler ModuleAbsolutePathBox.TextChanged, AddressOf TextBox_TextChanged

        AddHandler LocationPathSecurity.Enter, AddressOf TextBox_Enter
        AddHandler LocationPathSecurity.Leave, AddressOf TextBox_Leave
        AddHandler LocationPathSecurity.TextChanged, AddressOf TextBox_TextChanged

        AddHandler DirectoryPath.Enter, AddressOf TextBox_Enter
        AddHandler DirectoryPath.Leave, AddressOf TextBox_Leave
        AddHandler DirectoryPath.TextChanged, AddressOf TextBox_TextChanged

        AddHandler LocateFile.Enter, AddressOf TextBox_Enter
        AddHandler LocateFile.Leave, AddressOf TextBox_Leave
        AddHandler LocateFile.TextChanged, AddressOf TextBox_TextChanged

        AddHandler DirLocation.Enter, AddressOf TextBox_Enter
        AddHandler DirLocation.Leave, AddressOf TextBox_Leave
        AddHandler DirLocation.TextChanged, AddressOf TextBox_TextChanged

        AddHandler Filenamebox.Enter, AddressOf TextBox_Enter
        AddHandler Filenamebox.Leave, AddressOf TextBox_Leave
        AddHandler Filenamebox.TextChanged, AddressOf TextBox_TextChanged

        'list view shorting handlers
        AddHandler ListView2.ColumnClick, AddressOf ListViewComparer.listView_ColumnClick
        AddHandler RemovalMediaDriveList.ColumnClick, AddressOf ListViewComparer.listView_ColumnClick
        AddHandler DirectoryFileListView.ColumnClick, AddressOf ListViewComparer.listView_ColumnClick
        AddHandler DelList.ColumnClick, AddressOf ListViewComparer.listView_ColumnClick
        AddHandler AccessRuleListView.ColumnClick, AddressOf ListViewComparer.listView_ColumnClick
        AddHandler AuditRuleListView.ColumnClick, AddressOf ListViewComparer.listView_ColumnClick
        AddHandler ModuleList.ColumnClick, AddressOf ListViewComparer.listView_ColumnClick
        AddHandler ProcessListOfModule.ColumnClick, AddressOf ListViewComparer.listView_ColumnClick
        AddHandler FileFoundLV.ColumnClick, AddressOf ListViewComparer.listView_ColumnClick
        AddHandler ProList.ColumnClick, AddressOf ListViewComparer.listView_ColumnClick


    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If DisableExitDialog.Checked Then Return

        If Not MsgBox("Are you sure you want to Exit?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            e.Cancel = True
        End If
    End Sub

    'Form Starting procedure
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        'setting  form size
        Me.MaximumSize = New Size(My.Computer.Screen.WorkingArea.Width, My.Computer.Screen.WorkingArea.Height)

        'now add theme
        Select Case My.Computer.Registry.GetValue(VERKey, "Theme", "BlueTheme")
            Case "BlueTheme"
                BlueTheme.Checked = True
                SetTheme(My.Resources.Health_care_shield_6)
            Case "GreenTheme"
                GreenTheme.Checked = True
                SetTheme(My.Resources.tick_16)
            Case "RedTheme"
                RedTheme.Checked = True
                SetTheme(My.Resources.Red_16)
            Case Else
                BlueTheme.Checked = True
                SetTheme(My.Resources.Health_care_shield_6)
        End Select


        'renaming name with version no.
        TitleName.Text = MainClass.VERName
        NotifyIcon1.Text = MainClass.VERName
        NotifyIcon1.BalloonTipTitle = MainClass.VERName
        AboutUsForm.Label1.Text = MainClass.VERName + "  "
        Me.Text = MainClass.VERName

        'now assign handlers to control Event
        AddHandlersToControls()


        'now capture tooltipHelp
        'Me.EnglishToolTip.SetToolTip(Me.VisualiseAllFile, My.Resources.EngResource.hlpcFA_VisualiseAllFile)
        'above line display how tooltip is alloted to control
        HelpToolTipBuilder_ForControl()


        'load at startup function will re configurate ver Checkbox , _
        'and control text according to current config
        loadAtStartUp()

        'retriving autorun.inf file retrive option...
        Autorun_BlockStatus()

        'Refressing registry
        Dim ref_status As Boolean = RefreshRegSatus()

        infobox.Text += EngResource.Seperator

        'Enable Autorun Button Status
        Dim autorun_status As Boolean = find_auroruninf()

        If send2tray.Checked = True And ref_status = False And autorun_status = False Then
            'first disable Process Timer
            'there is no need to refresh pro tree when program is hidden
            ProTreeTimer.Stop()
            'start back ground scanning 
            NotifyIconTimer.Enabled = True
            NotifyIcon1.Visible = True
            NotifyIcon1.ShowBalloonTip(2000)
            AddHandler Me.Shown, AddressOf Form1_Shown
            Exit Sub
        End If

        ProTreeTimer.Start()
        'closing splace screen thread
        MainClass.spl_th.Abort()

    End Sub
    'me.hide does not work with form.load
    'so by making this , i can use me.hide
    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Hide()
        RemoveHandler Me.Shown, AddressOf Form1_Shown
        'closinf spalce screen thread
        MainClass.spl_th.Abort()
    End Sub


#Region "                List View building function"
    'Mod item is a array list of processModule Collection
    Private Function BuildModuleList(ByVal ModItems As ArrayList, ByRef Module_List As ListView) As Boolean

        'clearing both module list and modulelistimage list
        Module_List.Items.Clear()
        ModuleListImage.Images.Clear()

        For Each moduleItem As System.Diagnostics.ProcessModule In ModItems

            Dim LVItem As New ListViewItem
            LVItem.Text = moduleItem.ModuleName
            Try
                LVItem.SubItems.Add(moduleItem.FileVersionInfo.FileDescription.ToString)
            Catch 'ex As Exception
                LVItem.SubItems.Add("")
            End Try

            LVItem.SubItems.Add(moduleItem.FileName)
            LVItem.SubItems.Add(moduleItem.BaseAddress.ToString)

            Try
                ModuleListImage.Images.Add(Drawing.Icon.ExtractAssociatedIcon(moduleItem.FileName))
                LVItem.ImageIndex = ModuleListImage.Images.Count - 1
            Catch ex As Exception

            End Try

            Module_List.Items.Add(LVItem)

            '-------------------------------------------------

            'we are not using this part of code 
            'because some files have different file icon so run time exrzction is etter option..
            '////////////////////////////////////////////////////////////////////////////////
            'we already stored these image in fixedimagelist
            'Select Case New FileInfo(moduleItem.FileName).Extension.ToLower
            '   Case ".exe"
            '.Items(.Items.Count - 1).ImageIndex = 1
            'FixedImageList.Images.Add(Drawing.Icon.ExtractAssociatedIcon(moduleItem.FileName))
            '.Items(.Items.Count - 1).ImageIndex = FixedImageList.Images.Count - 1
            '    Case ".dll"
            ' .Items(.Items.Count - 1).ImageIndex = 0
            '     Case Else
            'FixedImageList.Images.Add(Drawing.Icon.ExtractAssociatedIcon(moduleItem.FileName))
            '.Items(.Items.Count - 1).ImageIndex = FixedImageList.Images.Count - 1
            ' End Select
            '//////////////////////////////////////////////////////////////////////////////////

        Next
        '.Sorting = SortOrder.Ascending
        '.Sorting = SortOrder.None

    End Function

#End Region

#Region "              Process And module  Function     "

    Private Function DoPIDExist() As Boolean

    End Function


    'i am using this WMI script to get process because it is more capable to 
    'get path of some reserved process , diagnostic.process class do not have.
    Private tm As New Windows.Forms.Timer
    Private Sub StartProcessDetailScan(ByVal id As Integer)
        If tm.Enabled Then
            'if timer is ruining then change tag only
            tm.Tag = id.ToString
            'this is to refresh list ...
            DetailByID(tm, Nothing)
        Else
            tm.Interval = 100
            tm.Tag = id.ToString  ' now scan this PID
            AddHandler tm.Tick, AddressOf DetailByID
            tm.Start()
        End If
    End Sub

    Friend Sub DetailByID(ByVal sender As Object, ByVal e As System.EventArgs)
        If tm.Interval <> 2000 Then
            tm.Interval = 2000
        End If
        On Error Resume Next

        Dim queryObj As ManagementObject = WMISample.MyWMIQuery.NameFromId(sender.Tag)
        If queryObj Is Nothing Then
            sender.Stop()
            sender.dispose()
            'clear list
            For i = 0 To 47
                ProcessDetailList.Items(i).SubItems(1).Text = ""
            Next
            Return
        End If
        

        With Me.ProcessDetailList
            '1st page
            .Items(0).SubItems(1).Text = "" + queryObj("name")
            .Items(1).SubItems(1).Text = "" + queryObj("Caption")
            .Items(2).SubItems(1).Text = "" + queryObj("description")
            .Items(3).SubItems(1).Text = queryObj("ProcessID")
            .Items(4).SubItems(1).Text = queryObj("executablepath")
            .Items(5).SubItems(1).Text = ByteSizeOptimaized(GetFileSize(queryObj("executablepath")))
            .Items(6).SubItems(1).Text = queryObj("Priority")
            .Items(7).SubItems(1).Text = queryObj("threadcount")
            '.Items(8).SubItems(1).Text = NameByID(queryObj("parentprocessid"))
            'drawback is extention is remved from process name
            .Items(8).SubItems(1).Text = Process.GetProcessById(queryObj("parentprocessid")).ProcessName
            .Items(9).SubItems(1).Text = queryObj("ParentProcessId")
            .Items(10).SubItems(1).Text = queryObj("CommandLine")


            'This function return the user name which is using the process
            Dim outParams As ManagementBaseObject = queryObj.InvokeMethod("GetOwner", Nothing, Nothing)
            .Items(11).SubItems(1).Text = outParams("Domain") + "/" + outParams("User")



            '2nd page
            .Items(12).SubItems(1).Text = queryObj("PrivatePageCount")
            .Items(13).SubItems(1).Text = ((CSng(queryObj("KernelModeTime")) + CSng(queryObj("UserModeTime"))) / 10000000).ToString
            .Items(14).SubItems(1).Text = queryObj("PageFileUsage")
            .Items(15).SubItems(1).Text = queryObj("PageFaults")
            .Items(16).SubItems(1).Text = queryObj("VirtualSize")
            .Items(17).SubItems(1).Text = queryObj("WorkingSetSize")
            .Items(18).SubItems(1).Text = queryObj("MinimumWorkingSetSize")
            .Items(19).SubItems(1).Text = queryObj("MaximumWorkingSetSize")


            '3rd page

            .Items(20).SubItems(1).Text = queryObj("PeakWorkingSetSize")
            .Items(21).SubItems(1).Text = queryObj("PeakVirtualSize")
            .Items(22).SubItems(1).Text = queryObj("PeakPageFileUsage")
            .Items(23).SubItems(1).Text = queryObj("QuotaPagedPoolUsage")
            .Items(24).SubItems(1).Text = queryObj("QuotaNonPagedPoolUsage")
            .Items(25).SubItems(1).Text = queryObj("QuotaPeakPagedPoolUsage")
            .Items(26).SubItems(1).Text = queryObj("QuotaPeakNonPagedPoolUsage")


            '4th page
            .Items(27).SubItems(1).Text = queryObj("OSName")
            .Items(28).SubItems(1).Text = queryObj("CreationClassName")
            .Items(29).SubItems(1).Text = queryObj("WindowsVersion")
            .Items(30).SubItems(1).Text = queryObj("CreationDate")
            .Items(31).SubItems(1).Text = queryObj("CSCreationClassName")
            .Items(32).SubItems(1).Text = queryObj("CSName")
            .Items(33).SubItems(1).Text = queryObj("OSCreationClassName")


            '5th page
            .Items(34).SubItems(1).Text = queryObj("ExecutionState")
            .Items(35).SubItems(1).Text = queryObj("Handle")
            .Items(36).SubItems(1).Text = queryObj("HandleCount")
            ' .Items(37).SubItems(1).Text = queryObj("InstallDate") 'this is disabled because it is not returnng value
            .Items(38).SubItems(1).Text = queryObj("KernelModeTime")
            .Items(39).SubItems(1).Text = queryObj("OtherOperationCount")
            .Items(40).SubItems(1).Text = queryObj("OtherTransferCount")
            .Items(41).SubItems(1).Text = queryObj("ReadOperationCount")
            .Items(42).SubItems(1).Text = queryObj("ReadTransferCount")
            '.Items(43).SubItems(1).Text = queryObj("Status") 'this is disabled because it is not returning value
            .Items(44).SubItems(1).Text = queryObj("SessionId")
            .Items(45).SubItems(1).Text = queryObj("UserModeTime")
            .Items(46).SubItems(1).Text = queryObj("WriteOperationCount")
            .Items(47).SubItems(1).Text = queryObj("WriteTransferCount")
            .Update()
        End With
    End Sub

    Private Function RestartProcess(ByVal Pid As Integer) As ArrayList

        Dim P As Process = Process.GetProcessById(Pid)
        Dim ExecutablePath As String = P.MainModule.FileName
        Dim detail As New ArrayList

        'return 0 if process not terminated and file not deleted.
        'return 1 if process trminated but file is not deleted
        'return 2 if process terinated and file deleted.
        'return -1 if process do not exist
        'return -2 if process is dangerous
        'return -3 if exception in process termination

        Select Case killProcessById(Pid, False, EnableProcessFilter.Checked, detail)
            Case -1
                detail.Add("Process do not exist.")
                Exit Select
            Case -2
                detail.Add("Process can not restart. Termination skipped.")
                Exit Select
            Case -3
                detail.Add("Exception in process termination .Process Can not restart.")
                Exit Select
            Case 1
                Try
                    Process.Start(ExecutablePath)
                    detail.Add("Process Started Successfuly.")
                Catch ex As Exception
                    detail.Add("Error : " + ex.Message)
                End Try
                Exit Select
        End Select

        Return detail

    End Function

    'this function process all module s from a process using PID

    Shared Function GetProcessModule(ByVal Pid As String) As ArrayList
        Dim myProcessArray As New ArrayList
        myProcessArray.Clear()
        Dim pi As System.Diagnostics.Process
        pi = System.Diagnostics.Process.GetProcessById(Pid)

        'MsgBox(pi.ProcessName)
        Try
            For Each item As System.Diagnostics.ProcessModule In pi.Modules
                myProcessArray.Add(item)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return myProcessArray
    End Function

#End Region


#Region "       Infection operation in V.E.R. "

#Region " Functions used "
    Friend Function RefreshRegSatus() As Boolean
        Dim InfoCollection As New ArrayList
        InfoCollection.Clear()
        RegInfection.DetectRegError(InfoCollection)

        If InfoCollection.Count = 0 Then
            'not found condition
            PictureBox1.Visible = False
            Label3.Visible = False
            'PictureBox2.Visible = True
            infobox.Text = "Registry infection has not been found."
            Return False
        Else
            PictureBox1.Visible = True
            Label3.Visible = True
            'PictureBox2.Visible = False
            infobox.Text = ""

            For Each itm As String In InfoCollection
                infobox.Text += itm.ToString + vbNewLine
            Next
            infobox.Text += EngResource.Seperator _
                       + vbNewLine + "No. of Registry Error Found = " + InfoCollection.Count.ToString _
                                   + vbNewLine + "Registry Infection Found. Use One Click Registry Heal Button ...."
            Return True
        End If
    End Function
#End Region

#Region " Form Events "



#End Region

#End Region

#Region "             Main Side Column button Collection          "

    Private Sub OptionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionButton.Click
        Me.MainTabControl.SelectedTab = SettingPage
    End Sub

    Private Sub SecurityPermissionsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecurityPermissionsButton.Click
        Me.MainTabControl.SelectedTab = FolderOptionPage
        Me.FileFolderTab.SelectedTab = SecurityPermissionPage
    End Sub

    Private Sub UnlockModuleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnlockModuleButton.Click
        Me.MainTabControl.SelectedTab = UnlockerPage
    End Sub

    Private Sub FolderOptionsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FolderOptionsButton.Click
        Me.MainTabControl.SelectedTab = FolderOptionPage
        Me.FileFolderTab.SelectedTab = FolderOptionsSubPage
        Me.ShowFolderOption.Focus()
    End Sub

    Private Sub MediaInfoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MediaInfoButton.Click
        Me.MainTabControl.SelectedTab = FolderOptionPage
        Me.FileFolderTab.SelectedTab = RemovalMediaDetailPage
        GetRemovalMedia.Focus()
        Me.GetRemovalMedia.PerformClick()
    End Sub

    Private Sub FolderInfoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FolderInfoButton.Click
        Me.MainTabControl.SelectedTab = FolderOptionPage
        Me.FileFolderTab.SelectedTab = DirectoryDetailPage
        Me.BrowseDir.Focus()
        Me.BrowseDir.PerformClick()
    End Sub

    Private Sub FindCloneButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindCloneButton.Click
        CloneForm.Show()
    End Sub

    Private Sub GenerateprocessListButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateprocessListButton.Click
        Try
            Shell(My.Resources.SFC_Command, _
                  AppWinStyle.NormalFocus, True)
            System.Diagnostics.Process.Start("c:\process.txt")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RunNewProcessButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunNewProcessButton.Click
        Me.MainTabControl.SelectedTab = OtherToolPage
        TaskTabBox.Focus()
    End Sub

    'Startup Form Button
    Private Sub ScanStartupButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScanStartupButton.Click
        StartupForm.Show()
    End Sub

    Private Sub ScanServiceButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScanServiceButton.Click
        WinServiceForm.Show()
    End Sub

    Private Sub BlockAVirusbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlockAVirusbutton.Click
        BlockExeForm.Show()
        BlockExeForm.RefreshButton.PerformClick()
    End Sub

#End Region

#Region "            Main Menu Tool Strip Events"

#Region "           Main menu toolstrip File menu Event"


#End Region

#Region "           Main menu tool strip help event"

    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        On Error Resume Next
        Dim pi As New ProcessStartInfo
        pi.FileName = "http://www.virussecurelab.com/ver.html"
        Process.Start(pi)
    End Sub

    Private Sub OtherToolToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtherToolToolStripMenuItem.Click
        On Error Resume Next
        Dim pi As New ProcessStartInfo
        pi.FileName = "http://www.virussecurelab.com/products.html"
        Process.Start(pi)
    End Sub

    Private Sub BlogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlogToolStripMenuItem.Click
        On Error Resume Next
        Dim pi As New ProcessStartInfo
        pi.FileName = "http://www.virussecurelab.com"
        Process.Start(pi)
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutUsToolStripMenuItem.Click
        'MsgBox("This software is developed by Avinash Sachan." + vbNewLine + vbNewLine + "Email: avinashsachan@gmail.com", MsgBoxStyle.Information, "Developer")
        AboutUsForm.ShowDialog()
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
        Try
            System.Diagnostics.Process.Start("VER_Help.chm")
            Beep()
        Catch ex As Exception
            MessageBox.Show("Help File is moved or deleted." _
                           + vbNewLine + "Exception Type : " + ex.GetType.ToString, "Error")
        End Try

    End Sub

    'Private Sub ReportBugToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportBugToolStripMenuItem.Click
    'End Sub

#End Region

#Region "           Main menu ToolStrip Tool Events "

#Region "       Windows Management Console     "

    Private Sub PerformanceConsoleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerformanceConsoleToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("perfmon.msc")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub LocalUsersAndGroupsConsoleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalUsersAndGroupsConsoleToolStripMenuItem.Click
        'lusrmgr.msc
        Try
            System.Diagnostics.Process.Start("lusrmgr.msc")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub SharedFoldersManagementConsoleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SharedFoldersManagementConsoleToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("fsmgmt.msc")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub EventViewerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EventViewerToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("eventvwr.msc")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub DiskManagementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiskManagementToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("diskmgmt.msc")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub WMIControlToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WMIControlToolStripMenuItem.Click
        'wmimgmt.msc
        Try
            System.Diagnostics.Process.Start("wmimgmt.msc")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub ComputerManagementConsoleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComputerManagementConsoleToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("compmgmt.mscz")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub SecuritySettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecuritySettingsToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("secpol.msc")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub DeviceManagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeviceManagerToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("devmgmt.msc")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub DiskDefragmenterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiskDefragmenterToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("dfrg.msc")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ServiceManagementConsoleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiceManagementConsoleToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("services.msc")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

    Private Sub GroupPolicyEditerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupPolicyEditerToolStripMenuItem.Click
        Try
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\MMC", "RestrictToPermittedSnapins", 0)
            System.Diagnostics.Process.Start("gpedit.msc")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub WindowsExplorerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsExplorerToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("Explorer.exe")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DrWatsonToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DrWatsonToolStripMenuItem.Click
        Try
            Dim response As MsgBoxResult
            response = MsgBox("You must have Windows Xp Installation Disk before running the Dr. Watson reconery." _
                               , MsgBoxStyle.OkCancel, "Informtion")
            If response = MsgBoxResult.Cancel Then
                Return
            Else
                System.Diagnostics.Process.Start("drwtsn32.exe")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "           Main Menu Toolstrip edit Tool Event"

#Region "Registry Collection"

    Private Sub MakeRegisrtyBackupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MakeRegisrtyBackupToolStripMenuItem.Click

        Dim str As String = "Windows Registry Editor Version 5.00" + vbNewLine + vbNewLine
        'GetRegStr(My.Resources.HKCUPolicySystemKey, str)
        'GetRegStr(My.Resources.HKCUPolicyExplorerKey, str)

        'Collecting Policy Of current user
        '   MsgBox("My.Resources.HKCUPolicyKey")
        GetRegStr(My.Resources.HKCUPolicyKey, str, True, True)
        ' MsgBox("My.Resources.HKCURunKey")
        'collecting Auto startup
        GetRegStr(My.Resources.HKCURunKey, str, True, True)
        ' MsgBox("My.Resources.HKCURunOnceKey")
        GetRegStr(My.Resources.HKCURunOnceKey, str, True, True)
        ' MsgBox("My.Resources.HKLMRunKey")
        GetRegStr(My.Resources.HKLMRunKey, str, True, True)
        ' MsgBox("My.Resources.HKLMRunOnceEx")
        GetRegStr(My.Resources.HKLMRunOnceEx, str, True, True)
        ' MsgBox("My.Resources.HKLMRunOnceKey")
        GetRegStr(My.Resources.HKLMRunOnceKey, str, True, True)


        'creating file in same directory from where  application is running.
        NotePadDetail(My.Application.Info.DirectoryPath.ToString + "\RegBackUpSelected.reg", str, True, OpenToolStripMenuItem.Checked)

        'show sucess information in infobox.
        Beep()
        infobox.Text = "Registry backup created."
        MsgBox("Registry backup created.", MsgBoxStyle.Information)

    End Sub

    Private Sub RestoreBackupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreBackupToolStripMenuItem.Click

        Dim RegFile As String = "RegBackUpSelected.reg"

        Try
            'Enabling regedit
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableRegistryTools", 0)

            'detecting file Existance
            If Not My.Computer.FileSystem.FileExists("RegBackUpSelected.reg") Then

                If MsgBox("Previous Registry backup not found in current Folder." _
                           + vbNewLine + "Do you want to Locate regisrty file.", MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo _
                           , "Registry backup not found..") = MsgBoxResult.No Then
                    Return
                Else
                    'now we locate reg file if it is stored in other place.
                    Dim OpenFileDialog As New OpenFileDialog
                    OpenFileDialog.InitialDirectory = System.Environment.SpecialFolder.Desktop
                    OpenFileDialog.Multiselect = False
                    'OpenFileDialog.Filter = "Program files (*.exe)|*.exe|All files (*.*)|*.*"
                    OpenFileDialog.Filter = "Registry File (*.reg)|*.reg"
                    OpenFileDialog.Title = "V.E.R. Open File Dialog"
                    OpenFileDialog.ShowDialog()

                    'getting file name
                    RegFile = OpenFileDialog.FileName
                End If
            End If

            'creating regedit process variable
            Dim p As New Process
            p.StartInfo.FileName = "regedit"
            'this is command by which we send registry key to reg edit to add in 
            'windows registry .
            p.StartInfo.Arguments = "-s " + RegFile

            ' there is no need to show registry edit to show in process 
            'so we run it in back ground....
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden

            'running this proces 
            'tis process will terminate itself 
            p.Start()
            'there is know need to kill because regedit terminate itself after completing task..
            'because it is a commond line utility
            'p.kill()

            'if every this ng is going well msgbox will tell about success....
            infobox.Text = "Registry restored successfully."
            MsgBox("Registry restored successfully.", MsgBoxStyle.Information, "Registry Restored")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Registry restore task failed.")
        End Try

    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenToolStripMenuItem.Checked Then
            OpenToolStripMenuItem.Checked = False
            My.Computer.Registry.SetValue(VERKey, "Show Regisrty Backup", 0, RegistryValueKind.DWord)
        Else
            OpenToolStripMenuItem.Checked = True
            My.Computer.Registry.SetValue(VERKey, "Show Regisrty Backup", 1, RegistryValueKind.DWord)
        End If
    End Sub

#End Region

#End Region

#End Region

#Region "       Tab Page Event and function   "

#Region "         Main Page Events  "

#Region "           main page  Task buttons "

    'one click registry heal option
    Private Sub Run_remover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Run_remover.Click
        Try
            ' Dim clk As New Stopwatch
            ' clk.Start()

            If RegInfection.Remove_Effect() = True Then
                ' MsgBox(clk.Elapsed.TotalSeconds.ToString)
                infobox.Text = "Registry has been restored to its optimal state." _
                            + vbNewLine + vbNewLine + _
                             "Please wait, ten seconds to confirm." + _
                             vbNewLine + "Then click on the Refresh Button." _
                             + vbNewLine + vbNewLine + _
                            "If a virus is active, it will likely re-infect and show itself." _
                            + vbNewLine + "Clicking the Refresh button will show this state if it happens."

                MsgBox("Registry has been restored to its optimal state." + vbNewLine _
                       + "Some Effects will be active after Reboot.", MsgBoxStyle.Information, "Process Executed")
            Else
                MsgBox("Error During Registry optimization. Contact Avinash about this problem.", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error")
        End Try

    End Sub

    'System File checker button
    Private Sub SFC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SFC.Click
        'On Error GoTo handler
        Try
            Dim response As MsgBoxResult
            response = MsgBox("You must have " + GetOSVersion() + " Installation Disk before running the system file recovery." _
                               , MsgBoxStyle.OkCancel Or MsgBoxStyle.Information, "Information")
            If response = MsgBoxResult.Cancel Then
                Return
            Else
                Shell("sfc /scannow", vbNormalFocus)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        'handler:
        'MsgBox("Error opening file.", MsgBoxStyle.Critical, "System File Checker")

    End Sub

    'Show suspicious file button
    Private Sub Sys_Hidden_Show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sys_Hidden_Show.Click
        Try
            Sys_Hidden_Show_Form.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub



    'refresh button
    Private Sub RefreshButtonMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButtonMain.Click
        On Error Resume Next
        RefreshRegSatus()
        infobox.Text += EngResource.Seperator
        find_auroruninf()
        sortlistview()
    End Sub

#End Region

#Region "         Windows Tool in main page .  "

    'used key for msconfig ristriction
    Private Function Run_Msconfig() As Boolean
        Try
            If RegInfection.RegDisallowKey() Is Nothing Then
                System.Diagnostics.Process.Start("msconfig.exe")
            Else
                For Each oneValue As String In RegInfection.RegDisallowKey().GetValueNames()
                    If RegInfection.RegDisallowKey.GetValue(oneValue).ToString.ToUpper = "msconfig.exe".ToUpper Then
                        'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun", oneValue, "msconfig.exe0")
                        RegInfection.RegDisallowKey.DeleteValue(oneValue)
                    End If
                Next oneValue
                System.Diagnostics.Process.Start("msconfig.exe")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Function

    'Tab Used for Run Block Contant
    Private Sub Enable_taskmgr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Enable_taskmgr.Click
        Try
            'this key patch your blocking Instruction to 0 from 1
            My.Computer.Registry.SetValue(HKCUPolicySystemKey, "DisableTaskmgr", 0)

            'And this run task manager
            System.Diagnostics.Process.Start("taskmgr.exe")

            'If any error occurred during procedure the exception will tell you 
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Enable_regedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Enable_regedit.Click
        Try
            My.Computer.Registry.SetValue(HKCUPolicySystemKey, "DisableRegistryTools", 0)
            System.Diagnostics.Process.Start("regedit.exe")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub enable_msconfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enable_msconfig.Click
        Run_Msconfig()
    End Sub

#End Region

#Region "         main page Autorun.inf Task  "

#Region "Startup operation of autorun.inf"
    Private Sub Autorun_BlockStatus()
        Try
            If RefreshDoesNotexistAutorun() = True Then
                'means key exist
                Me.find_autorun.ButtonText = "Autorun.inf - Disabled"
                find_autorun.Icon = Nothing
            Else
                Me.find_autorun.ButtonText = "Autorun.inf - Enabled"
                find_autorun.Icon = My.Resources.cancel_16
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            'Me.find_autorun.ButtonText = "Error."
            'Me.find_autorun.Enabled = False
        End Try
    End Sub

    Private Function RefreshDoesNotexistAutorun() As Boolean
        'return true if key Exist (i.e. bloked condition .)

        Dim reg As Microsoft.Win32.RegistryKey
        reg = My.Computer.Registry.LocalMachine
        reg = reg.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\IniFileMapping", True)

        'getting key
        For Each item As String In reg.GetSubKeyNames()
            If item = "Autorun.inf" Then
                reg = reg.OpenSubKey("Autorun.inf", True)
                'getting value
                If reg.GetValue("") = "@SYS:DoesNotExist" Then
                    reg.Close()
                    Return True
                End If
                'reg.Close()
                'Return True
            End If
        Next

        reg.Close()
        Return False

    End Function
#End Region

#Region "Autorun activation deactivation"
    Friend Shared Function DoesNotExistAutorun() As Boolean
        Try
            'return true if successful

            'http://nick.brown.free.fr/blog/2007/10/memory-stick-worms.html
            'code added after 3.0.10
            'REGEDIT4()
            '[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\IniFileMapping\Autorun.inf]
            '@="@SYS:DoesNotExist"

            Dim reg As Microsoft.Win32.RegistryKey
            reg = My.Computer.Registry.LocalMachine
            reg = reg.CreateSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\IniFileMapping\Autorun.inf", Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree)
            reg.SetValue("", "@SYS:DoesNotExist")
            reg.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Exclamation, "Exception")
            Return False
        End Try

    End Function

    Friend Shared Function RemoveDoesNotExistAutorun() As Boolean
        Try
            'return true if successful
            Dim reg As Microsoft.Win32.RegistryKey
            reg = My.Computer.Registry.LocalMachine
            reg = reg.CreateSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\IniFileMapping", Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree)
            reg.DeleteSubKey("Autorun.inf")
            reg.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Exclamation, "Exception")
            Return False
        End Try

    End Function

#End Region

#Region "Autoplay form and button Events"
    Private Sub find_autorun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles find_autorun.Click
        Try
            If RefreshDoesNotexistAutorun() = True Then
                'key exist
                'so remove key
                If RemoveDoesNotExistAutorun() Then
                    find_autorun.ButtonText = "Autorun.inf - Enabled"
                    find_autorun.Icon = My.Resources.cancel_16
                End If
            Else
                'otherwise make key 
                If DoesNotExistAutorun() Then
                    find_autorun.ButtonText = "Autorun.inf - Disabled"
                    find_autorun.Icon = Nothing
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try

    End Sub

    Private Sub Enable_autorun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Enable_autorun.Click
        'On Error GoTo err
        Try
            Dim nodrivetype As String
            nodrivetype = RegInfection.scanregvalue(HKCUPolicyExplorerKey, "NoDriveTypeAutoRun")

            Select Case nodrivetype
                Case "149"
                    'Patching registry
                    My.Computer.Registry.SetValue(HKCUPolicyExplorerKey, "NoDriveTypeAutoRun", 255)
                    'Changinh text of button
                    Enable_autorun.ButtonText = "USB/CD Autoplay Off"
                    Enable_autorun.Icon = Nothing
                Case "255"
                    My.Computer.Registry.SetValue(HKCUPolicyExplorerKey, "NoDriveTypeAutoRun", 149)
                    Enable_autorun.ButtonText = "USB/CD Autoplay On"
                    Enable_autorun.Icon = My.Resources.cancel_16
                Case Else
                    'Patching registry
                    My.Computer.Registry.SetValue(HKCUPolicyExplorerKey, "NoDriveTypeAutoRun", 255)
                    'Changinh text of button
                    Enable_autorun.ButtonText = "USB/CD Autoplay Off"
                    Enable_autorun.Icon = Nothing
            End Select


            'If (nodrivetype = "149") Then
            'Enable_autorun.ButtonText = "USB/CD Autoplay Blocked"
            'My.Computer.Registry.SetValue(HKCUPolicyExplorerKey, "NoDriveTypeAutoRun", 255)
            'End If

            'If (nodrivetype = "255") Then
            'Enable_autorun.ButtonText = "USB/CD Autoplay UnBlocked"
            'My.Computer.Registry.SetValue(HKCUPolicyExplorerKey, "NoDriveTypeAutoRun", 149)
            'End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Auto Play Error.")
        End Try

    End Sub

    Private Sub USBStorageDeviceOption_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USBStorageDeviceOption.Click
        USBForm1.ShowDialog()
    End Sub
#End Region

    Private Sub Protectdrive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Protectdrive.Click
        ProtectDriveForm.ShowDialog()
    End Sub


#End Region

#Region "        Process tree ContextMenu tool Strip events   "

    Private Sub OnlyKillProcessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnlyKillProcessToolStripMenuItem.Click
        If ProTree.SelectedNode Is Nothing Then
            MsgBox("Nothing selected", MsgBoxStyle.Exclamation)
            Return
        End If

        ProTreeTimer.Stop()
        Try
            'MessageBox.Show(ProTree.SelectedNode.Text)
            Dim PID As String = ProTree.SelectedNode.Text.Split("*")(1).Trim
            'MessageBox.Show(PID)
            'Confirmation 
            If MsgBox("Do you Really want to terminate process : " + ProTree.SelectedNode.Text.Split("*")(0).Trim + "  ID : " + PID + " ?", _
                      MsgBoxStyle.OkCancel Or MsgBoxStyle.Information, "Confirmation") <> MsgBoxResult.Ok Then
                ProTreeTimer.Start()
                Return
            End If

            'now killng the process
            Dim Eventlist As New ArrayList
            killProcessById(PID, False, EnableProcessFilter.Checked, Eventlist)

            infobox.Text = ""
            For Each item As String In Eventlist
                infobox.Text += item + vbNewLine
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            ProTreeTimer.Start()
        End Try
    End Sub

    Private Sub KillProcessToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KillProcessToolStripMenuItem3.Click
        If ProTree.SelectedNode Is Nothing Then
            MsgBox("Nothing selected", MsgBoxStyle.Exclamation)
            Return
        End If

        ProTreeTimer.Stop()
        Try
            'MessageBox.Show(ProTree.SelectedNode.Text)
            Dim PID As String = ProTree.SelectedNode.Text.Split("*")(1).Trim
            'MessageBox.Show(PID)
            'Confirmation 
            If MsgBox("Do you want to terminate and delete file of process : " + ProTree.SelectedNode.Text.Split("*")(0).Trim + "  ID : " + PID + " ?", _
                      MsgBoxStyle.OkCancel Or MsgBoxStyle.Information, "Confirmation") <> MsgBoxResult.Ok Then
                ProTreeTimer.Start()
                Return
            End If

            'now killng the process
            Dim Eventlist As New ArrayList
            killProcessById(PID, True, EnableProcessFilter.Checked, Eventlist) ' true for file deletion

            infobox.Text = ""
            For Each item As String In Eventlist
                infobox.Text += item + vbNewLine
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            ProTreeTimer.Start()
        End Try
    End Sub

    Private Sub RestratProcessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestratProcessToolStripMenuItem.Click
        If ProTree.SelectedNode Is Nothing Then
            MsgBox("Nothing selected", MsgBoxStyle.Exclamation)
            Return
        End If

        ProTreeTimer.Stop()
        Try
            'MessageBox.Show(ProTree.SelectedNode.Text)
            Dim PID As String = ProTree.SelectedNode.Text.Split("*")(1).Trim
            'MessageBox.Show(PID)
            'Confirmation 
            If MsgBox("Do you Really want to terminate and restart process : " + ProTree.SelectedNode.Text.Split("*")(0).Trim + "  ID : " + PID + " ?", _
                      MsgBoxStyle.OkCancel Or MsgBoxStyle.Information, "Confirmation") <> MsgBoxResult.Ok Then
                ProTreeTimer.Start()
                Return
            End If

            'now killng the process
            Dim Eventlist As ArrayList
            Eventlist = RestartProcess(PID)
            infobox.Text = ""
            For Each item As String In Eventlist
                infobox.Text += item + vbNewLine
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            ProTreeTimer.Start()
        End Try
    End Sub

    Private Sub SuspendProcessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuspendProcessToolStripMenuItem.Click
        If ProTree.SelectedNode Is Nothing Then
            MsgBox("Nothing selected", MsgBoxStyle.Exclamation)
            Return
        End If
        Try
            ProTreeTimer.Stop()
            Dim PID As String
            Dim Proc As String
            PID = ProTree.SelectedNode.Text.Split("*")(1).Trim
            Proc = ProTree.SelectedNode.Text.Split("*")(0).Trim

            If SuspendProcess(PID) = True Then
                MsgBox("Process : " + Proc + " with ID : " _
                        + PID + " Successfully Suspended.", MsgBoxStyle.Information)
            Else
                MsgBox("Process : " + Proc + " with ID : " _
                       + PID + " Failed to Suspended.", MsgBoxStyle.Critical, "Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            ProTreeTimer.Start()
        End Try
    End Sub

    Private Sub ResumeProcessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumeProcessToolStripMenuItem.Click
        If ProTree.SelectedNode Is Nothing Then
            MsgBox("Nothing selected", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            ProTreeTimer.Stop()
            Dim PID As String
            Dim Proc As String
            PID = ProTree.SelectedNode.Text.Split("*")(1).Trim
            Proc = ProTree.SelectedNode.Text.Split("*")(0).Trim

            If ResumeProcess(PID) = True Then
                MsgBox("Process : " + Proc + " with ID : " _
                        + PID + " Successfully Resumed.", MsgBoxStyle.Information)
            Else
                MsgBox("Process : " + Proc + " with ID : " _
                       + PID + " Failed to Resumed.", MsgBoxStyle.Critical, "Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            ProTreeTimer.Start()
        End Try
    End Sub

    Private Sub GetRelatedModuleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetRelatedModuleToolStripMenuItem.Click
        If ProTree.SelectedNode Is Nothing Then
            MsgBox("Nothing selected", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            Me.MainTabControl.SelectTab(2)
            Me.TabControl1.SelectTab(1)
            NameLable.Text = ProTree.SelectedNode.Text.Split("*")(0).Trim
            IdLable.Text = ProTree.SelectedNode.Text.Split("*")(1).Trim
            PathLable.Text = ProTree.SelectedNode.ToolTipText

            'Dim modItems As ArrayList = GetProcessModule(ListView2.Items(ListView2.SelectedIndices(0)).SubItems(1).Text)
            'Building ModuleList
            BuildModuleList(GetProcessModule(IdLable.Text), ModuleList)

            'scaning the current process in list 2

            'If sender Is GetRelatedModuleToolStripMenuItem Then
            '    MsgBox("Listview 2")
            '    Return
            'End If
            'this function locate process in listview2
            For Each item As ListViewItem In ListView2.Items
                If IdLable.Text = item.SubItems(1).Text Then
                    ListView2.Focus()
                    item.Selected = True
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GetGeneralDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetGeneralDetailToolStripMenuItem.Click
        If ProTree.SelectedNode Is Nothing Then
            MsgBox("Nothing selected", MsgBoxStyle.Exclamation)
            Return
        End If
        Try
            Dim processid As String
            processid = ProTree.SelectedNode.Text
            processid = processid.Split("*")(1).Trim

            'scaning the current process in list 2
            For Each item As ListViewItem In ListView2.Items
                If processid = item.SubItems(1).Text Then
                    'Opening page
                    Me.MainTabControl.SelectedTab = ProcessDetailPage
                    Me.TabControl1.SelectedTab = Tp0
                    'Selecting item
                    item.Selected = True
                    item.EnsureVisible()
                    Exit Sub
                End If
            Next

            'here means that function did not find this process in process list
            MsgBox("Process is not present in Process list.", MsgBoxStyle.Exclamation)
            'we are not removing entry because all sub child also delete
            'process list update itself automaticaly
            ' ProTree.SelectedNode.Remove()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ReloadFullProcessTreeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReloadFullProcessTreeToolStripMenuItem.Click
        ProTreeTimer.Stop()
        ProTree.Nodes.Clear()
        ListView2.Items.Clear()
        ImageList2.Images.Clear()
        ProTreeTimer.Start()
    End Sub

    Private Sub OpenLocationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenLocationToolStripMenuItem1.Click
        If ProTree.SelectedNode Is Nothing Then
            MsgBox("Nothing selected", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            If My.Computer.FileSystem.FileExists(ProTree.SelectedNode.ToolTipText) Then
                Process.Start(My.Computer.FileSystem.GetParentPath(ProTree.SelectedNode.ToolTipText))
            Else
                MsgBox("File : " + ProTree.SelectedNode.ToolTipText + " Not found.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub CopyFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyFileToolStripMenuItem.Click
        If ProTree.SelectedNode Is Nothing Then
            MsgBox("Nothing selected", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            EditingClass.CopyToClipboard(ProTree.SelectedNode.ToolTipText)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub

    Private Sub CopyFilePathToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyFilePathToolStripMenuItem.Click
        If ProTree.SelectedNode Is Nothing Then
            MsgBox("Nothing selected", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            Clipboard.SetText(ProTree.SelectedNode.ToolTipText)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub

    Private Sub GetProcessFilePropertyToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetProcessFilePropertyToolStripMenuItem2.Click
        If ProTree.SelectedNode Is Nothing Then
            MsgBox("Nothing selected", MsgBoxStyle.Exclamation)
            Return
        End If

        If Not My.Computer.FileSystem.FileExists(ProTree.SelectedNode.ToolTipText) Then
            MsgBox("Process File Path is not Detected.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            win32.PropertyShow.ShowProperties(ProTree.SelectedNode.ToolTipText)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub

#End Region

#End Region

#Region "       Autorun TabPage events and functions   "

#Region "  Function used...."

    'temporary this function is created to scan autorun.in  file
    'when software is in background 
    'when tool in back ground it is not neccessory to update Autorun page boxes
    Private Function ScanAutorun(Optional ByRef CollectedAutorun As ArrayList = Nothing) As Boolean
        On Error Resume Next
        'first i will collect all autorun.inf file found in Computer
        'collect all autorun.inf path in this arraylist 
        'if we need this index then we can recieve it from CollectedAutorun
        CollectedAutorun = New ArrayList
        CollectedAutorun.Clear()

        For Each drive As System.IO.DriveInfo In DriveInfo.GetDrives

            If IgnoreDrive(drive) Then Continue For

            If My.Computer.FileSystem.FileExists(drive.ToString + "autorun.inf") Then
                CollectedAutorun.Add(drive.ToString + "autorun.inf")
            End If

        Next

        If CollectedAutorun.Count <= 0 Then
            Return False 'not found
        Else
            Return True 'Found
        End If

    End Function


    'This function used to refress the status of the system
    'if autorun found it return true
    'this function also update Autorun page Boxes
    Private Function find_auroruninf() As Boolean

        On Error Resume Next
        InfBox.Items.Clear()
        'FileFoundLV.Items.Clear()
        'ProList.Items.Clear()
        'ProList.Text = ""
        Dim Drives() As System.IO.DriveInfo = System.IO.DriveInfo.GetDrives
        Dim drive As System.IO.DriveInfo

        For Each drive In Drives '  _GetAllowedDrives()

            ' ''ignoring if cd rom
            ' ''  If drive.DriveType = IO.DriveType.CDRom And IGN_CDROM.Checked = True Then
            ' '' Do nothing
            ' '' Else 'search for autorun
            ' ''If (drive.Name.ToLower = "a:\" Or drive.Name.ToLower = "b:\") Then
            ' ''If CheckBox4.Checked Then 'user want to scan floppy

            If IgnoreDrive(drive) Then Continue For 'do not scan

            If My.Computer.FileSystem.FileExists(drive.Name + "autorun.inf") Then
                InfBox.Items.Add(drive.Name + "autorun.inf")
            End If



            ' ''End If
            ' ''Else
            ' '' If My.Computer.FileSystem.FileExists(drive.Name + "autorun.inf") Then
            ' '' InfBox.Items.Add(drive.Name + "autorun.inf")
            ' '' End If
            ' '' End If
            ' '' End If
        Next


        If InfBox.Items.Count <= 0 Then
            infobox.Text += "Autorun.inf file has not been found."
            AutorunBox1.Text = EngResource.AutorunFoundMsg
            Return False

        Else

            Me.MainTabControl.SelectTab(1)
            AutorunBox1.Text = "AutoRun.inf Found" + vbNewLine + vbNewLine + "Select File to get detail."
            infobox.Text += "Autorun.inf file found.       " _
            + vbNewLine + "Number of Autorun Found  = " _
            + InfBox.Items.Count.ToString + "." _
            + EngResource.Seperator + _
            "Confirm, that there will be NO ROM disc in drive first!" + vbNewLine + _
            "and drive should not Read Only during Deletion time."

            Return True
        End If


    End Function

    'CollectFile is used to Collect Files with same name from diffrent location
    'it return false if Exception occure
    'here file name is only File name with extention ( not a complete path of file)
    Private Function CollectFileAndProcess(ByVal FileName As String, ByRef CollectedFile As ArrayList, _
                                 ByRef CollectedProcess As ArrayList, Optional ByRef Ex As Exception = Nothing) As Boolean
        'first reset array list
        CollectedFile.Clear()
        CollectedProcess.Clear()


        'if file is full path then extact file name from it ....
        'like c:\dir\file.exe or like c:\dir/file.exe  ( mark '/' in place of  '\')
        'so 1st  we will scan this file with path exist or not
        If My.Computer.FileSystem.FileExists(FileName) Then
            'add this to collecedfile array list
            CollectedFile.Add(FileName)
        End If

        'Now get file name 
        FileName = My.Computer.FileSystem.GetName(FileName)
        'here hele is isolated from path

        '**************************************************************
        'this part of code is remover after ver 3.1.3.10 date 21/11/2009
        '
        'Try
        'Dim strs() As String = FileName.Split("\")
        'FileName = strs(strs.Length - 1)
        'Catch ex
        'error in file name retriving
        'Return False
        'End Try
        '**************************************************************

        'here error can occure if floppy drive is inserted and not working
        'in feew system it is not present but still alive so if this occured we can ignore this

        'First Search in each Drive Front
        For Each drive As DriveInfo In IO.DriveInfo.GetDrives

            'here i am inserting code to ignore drives
            If IgnoreDrive(drive) = True Then
                Continue For
            End If

            Try
                If My.Computer.FileSystem.FileExists(drive.Name + FileName) Then
                    CollectedFile.Add(drive.Name + FileName)
                End If
            Catch ex
                MsgBox(Ex.Message, MsgBoxStyle.Exclamation)
            End Try
        Next



        'second search in sensitive folders (c:\ , c:\windows , c:\windows\system32)
        '(C:\ not neede because scning in each drive also scan it )

        'File location in Windows drives
        If My.Computer.FileSystem.FileExists(windir + "\" + FileName) Then
            CollectedFile.Add(windir + "\" + FileName)
        End If

        'File Locatin in System32
        If My.Computer.FileSystem.FileExists(windir + "\system32\" + FileName) Then
            CollectedFile.Add(windir + "\system32\" + FileName)
        End If

        '3rd search it as each process executable
        For Each p As Process In Process.GetProcesses
            'in this some system process create exception
            'we will ignore them.
            Try
                If New FileInfo(p.MainModule.FileName).Name.ToUpper = FileName.ToUpper Then
                    CollectedFile.Add(p.MainModule.FileName)
                    CollectedProcess.Add(p)
                End If
            Catch 'ex As Exception

            End Try
        Next

        'now remove cloneImage from ArrayList
        If Not RemoveCloneImageInArrayList(CollectedFile, CollectedFile) _
        Then MsgBox("Some thing went Wrong during identical Image path removal process.", MsgBoxStyle.Exclamation)

        'indicate that function processed...
        Beep()
        'here final Collected files found
        Return True
    End Function


    '        xxxx          'here filename is only file name not a comlete file name with path
    '        xxxx          '(like :   explorer.exe)
    'first i designed this function only for file name but now i am using full file name with path
    'date 21/11/2009 after ver 3.1.3.10
    Private Function scanfilepath(ByVal FileName As String) As Boolean

        'first we clear all listview which list files and process
        ProList.Items.Clear()
        FileFoundLV.Items.Clear()
        'because we remove all items from listviews so imagelist will be cleared ....
        ImLAutoRT.Images.Clear()

        '   xxxxx ' here are those modification 
        'If path contain a folder



        'now collect files and process using this process
        Dim collectFile As New ArrayList
        Dim CollectProcess As New ArrayList
        Dim ex As Exception = Nothing

        If Not CollectFileAndProcess(FileName, collectFile, CollectProcess, ex) Then
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return False
        End If

        'adding files in listview
        For Each item As String In collectFile
            Dim fInfo As New FileInfo(item)
            '
            Dim LvItem As New ListViewItem
            LvItem.Text = fInfo.Name
            LvItem.SubItems.Add(ByteSizeOptimaized(fInfo.Length))
            LvItem.SubItems.Add(fInfo.FullName)
            '
            ImLAutoRT.Images.Add((ImLAutoRT.Images.Count + 1).ToString, GetICON.GetFileIcon(fInfo.FullName, 0).ToBitmap)
            '
            'LvItem.ImageKey = ImLAutoRT.Images.Count.ToString
            '
            'MsgBox(ImLAutoRT.Images.Count.ToString)

            FileFoundLV.Update()
            FileFoundLV.Items.Add(LvItem)
            FileFoundLV.Items(FileFoundLV.Items.Count - 1).ImageIndex = ImLAutoRT.Images.Count - 1
            FileFoundLV.EndUpdate()
        Next



        'adding process in listview
        For Each p As Process In CollectProcess
            Dim LvItem As New ListViewItem
            LvItem.Text = p.ProcessName
            LvItem.SubItems.Add(p.Id.ToString)
            LvItem.SubItems.Add(p.MainModule.FileName)

            'collecting picture

            ImLAutoRT.Images.Add((ImLAutoRT.Images.Count + 1).ToString, GetICON.GetFileIcon(p.MainModule.FileName, 1).ToBitmap)
            LvItem.ImageIndex = ImLAutoRT.Images.Count - 1
            ProList.Items.Add(LvItem)
        Next


        Return True
    End Function

    'this function retrive file name from autorun.inf file
    'here inf path is complete path of inf fiel path
    'and file name will be extacted file name with complete path
    Private Function GetFileNameFromInf(ByVal infPath As String, ByRef FileName As String, _
                                  Optional ByRef ex As Exception = Nothing) As Boolean

        'first check file Exist ?
        'if file deleted but entry exist
        If My.Computer.FileSystem.FileExists(infPath) = False Then
            MsgBox("File Moved or deleted.", MsgBoxStyle.Information, "Information")
            Return False
        End If


        '/****************************************************
        'file read sample
        'Dim oRead As IO.StreamReader = System.IO.File.OpenText(InfBox.Text)
        'Dim linein

        'While oRead.Peek <> -1
        'linein = oRead.ReadLine()
        'MsgBox(linein)
        'End While

        'oRead.Close()
        '/*****************************************************


        Try
            Dim oRead As IO.StreamReader = System.IO.File.OpenText(infPath)
            ' Loop until end of file.
            While oRead.Peek <> -1
                Dim txtlinesplit() As String
                'Read line into variable.
                'braking line string in to part for open= sentence
                txtlinesplit = oRead.ReadLine.ToString.Split("=")

                'if open commond found they can be in this format
                'open=folder.tmp/tmp.exe
                'open=folder.tmp\tmp.exe
                'open=folder.exe
                'open=wscript.exe file.vbs
                '
                'So first we will will split in 2 part from "=" sign
                'then associate this path to drive letter of inf file
                'this will make a complete file name with path
                If txtlinesplit(0).ToUpper = "OPEN" Then
                    'now get file name
                    FileName = txtlinesplit(1).ToString   'My.Computer.FileSystem.GetName(txtlinesplit(1).ToString)
                    'now there is 3 case
                    '1st  : file name is   :   file.exe
                    '2nd  : file name is   :   dir/file.exe  Or dir\file.exe
                    '3rd  : file name is   :   wscript.exe AntiVirus.vbs
                    'above two are solved by taking complete file path
                    '
                    'but for 3rd we check first about last three digit
                    'save last file in filename
                    'every thing wil be fine
                    Try
                        Dim strarr() As String = FileName.Split(".")
                        If strarr(strarr.Length - 1).ToUpper = "VBS" Then
                            'Now split this file name with whitespace
                            Dim flname() As String = FileName.Split(" ")
                            FileName = flname(flname.Length - 1).Trim
                        End If
                    Catch exs As Exception

                    End Try


                    'if file is present in any folder it will be like dir\virus.exe or like dir/virus.exe
                    'so this is better to sent a formated full path as a return value
                    'get drive letter from inf file
                    FileName = New DriveInfo(infPath).Name + FileName

                    'if virus present in drive
                    If My.Computer.FileSystem.FileExists(FileName) Then
                        'closing file
                        oRead.Close()
                        Return True
                    End If

                    'either virus deleted or have any argument
                    FileName = FileName.Split("-")(0).ToString.Trim
                    'MsgBox(FileName)
                    'closing file
                    oRead.Close()
                    Return True
                End If
            End While

            'closing file
            oRead.Close()
            Return False
        Catch ex
            Return False
        End Try

    End Function

#End Region

#Region "  Form Event ....."

    'scaning file typed in textbox
    Private Sub scanagain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scanagain.Click

        If TextBoxIsIdle(Filenamebox) Then Return

        If Filenamebox.Text = Filenamebox.Tag Or Filenamebox.Text.Trim() = "" Then
            MsgBox("Type the file name.", MsgBoxStyle.Exclamation)
            Return
        End If

        If Not scanfilepath(Filenamebox.Text) Then
            MsgBox("Something went wrong.(Error Code : 1 )", MsgBoxStyle.Exclamation)
            Return
        End If

        MsgBox("File with same name found : " + FileFoundLV.Items.Count.ToString _
               + vbNewLine + "Process with same source file : " + ProList.Items.Count.ToString, _
               MsgBoxStyle.Information)

    End Sub

    'scaning file typed in textbox
    Private Sub Filenamebox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Filenamebox.KeyDown
        If e.KeyCode = Keys.Enter Then

            If TextBoxIsIdle(Filenamebox) Then Return

            If Filenamebox.Text = "" Then
                MsgBox("Type the file name.", MsgBoxStyle.Exclamation)
                Return
            End If
            'deletebox.Items.Clear()
            'file_name()
            scanagain_Click(Nothing, Nothing)
        End If
    End Sub

    'when we select file in list
    Private Sub InfBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfBox.SelectedIndexChanged
        Try
            'return if file is not selected..
            If InfBox.SelectedIndex < 0 Then
                Return
            End If

            'if file deleted but entry exist
            If My.Computer.FileSystem.FileExists(InfBox.Text) = False Then
                MsgBox("File Moved or deleted.", MsgBoxStyle.Information, "Information")
                Return
            End If

            'clearing the text box and list box
            FileFoundLV.Items.Clear()
            ProList.Items.Clear()
            AutorunBox1.Text = ""

            'now getting autorun.inf text
            Try
                'first read this file and paste it in autorunbox1
                Dim oRead As IO.StreamReader = System.IO.File.OpenText(InfBox.Text)
                AutorunBox1.Text = oRead.ReadToEnd.ToString
                'closing file
                oRead.Close()
            Catch ex As Exception
                MsgBox("Error in autorun.inf file opening.", MsgBoxStyle.Exclamation)
                'MsgBox("-----------")
            End Try


            'getting file name from autorun.inf associated with open command
            Dim FileName As String = Nothing
            If Not GetFileNameFromInf(InfBox.Text, FileName) Then
                'here function is failed to to get name
                'so read this file in notepad
                If MsgBox("Error in file name parsing." + vbNewLine + _
                          "Would you like to find file name manually?", _
                          MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Process.Start(InfBox.Text)
                End If
                Return
            End If


            'now search this file in system dir and in process

            If Not scanfilepath(FileName) Then
                MsgBox("Somthing went wrong.(Error Code : 12 )", MsgBoxStyle.Exclamation)
                Return
            End If

            MsgBox("File with same name found : " + FileFoundLV.Items.Count.ToString _
                   + vbNewLine + "Process with same source file : " + ProList.Items.Count.ToString, _
                   MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error code : 13 ")
        End Try

    End Sub


    'one click  function delete all file and process  listed in list listview
    Private Sub onehit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles onehit.Click

        If EmptyListView(ProList, False) And EmptyListView(FileFoundLV, False) And InfBox.Items.Count <= 0 Then
            MsgBox("Every list of this page is empty.", MsgBoxStyle.Information)
            Return
        End If

        If Not MsgBox("One click  function delete all file and process listed in lists." _
               + vbNewLine + "if you do not want to remove any specific item please remove that item from list. " _
               + vbNewLine + vbNewLine + "Would you like to continue?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Return
        End If

        'Collect Information
        Dim EventList As New ArrayList


        'first terminate all process listed in prolist
        For Each item As ListViewItem In ProList.Items
            Dim evlist As New ArrayList
            If killProcessById(item.SubItems(1).Text, False, EnableProcessFilter.Checked, evlist) > 0 Then
                'now removing item from list view
                item.Remove()
            End If
            EventList.AddRange(evlist)
        Next

        'now delete all file in file listview
        For Each item As ListViewItem In FileFoundLV.Items
            Try
                'retrive file path
                Dim finfo As New FileInfo(item.SubItems(2).Text)
                finfo.Attributes = FileAttributes.Normal
                finfo.Delete()
                'now removing item from list view
                item.Remove()
                EventList.Add(finfo.FullName + "  deleted.")
            Catch ex As Exception
                MsgBox("Unable to delete file : " + item.SubItems(2).Text, MsgBoxStyle.Exclamation)
                EventList.Add("Error to delete : " + item.SubItems(2).Text)
            End Try
        Next

        'atlast delete all autorun.inf file is allowed
        If CheckBox1.Checked Then
            InfBox.Items.Clear()
            For Each drv As IO.DriveInfo In IO.DriveInfo.GetDrives
                Try

                    If IgnoreDrive(drv) = True Then
                        Continue For
                    End If


                    If My.Computer.FileSystem.FileExists(drv.Name + "autorun.inf") Then
                        'MsgBox(drv.Name + "autorun.inf")
                        Dim finfo As New FileInfo(drv.Name + "autorun.inf")
                        finfo.Attributes = FileAttributes.Normal
                        finfo.Delete()
                        EventList.Add(finfo.FullName + "  deleted.")
                    End If
                Catch ex As Exception
                    MsgBox("Error in deletion : " + drv.Name + "autorun.inf", MsgBoxStyle.Exclamation)
                End Try
            Next
            'refresh 
            find_auroruninf()
        End If

        If CheckBox8.Checked = True Then
            MainTabControl.SelectedTab = ProcessDetailPage
            TabControl1.SelectedTab = TP3
            KillEventListBox.Focus()
            For Each item As String In EventList
                KillEventListBox.Items.Add(item.ToString)
            Next
            'setting last item so that it can be visible
            KillEventListBox.SelectedIndex = KillEventListBox.Items.Count - 1
        End If

    End Sub

#End Region

#Region "  Prolist Context menu ...."

    Private Sub LocateProcessInProcessListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocateProcessInProcessListToolStripMenuItem.Click

        If NothingSelectedInlistView(ProList) Then Return

        Try
            Dim processid As String
            processid = ProList.Items(ProList.SelectedIndices(0)).SubItems(1).Text

            'scaning the current process in list 2
            For Each item As ListViewItem In ListView2.Items
                If processid = item.SubItems(1).Text Then
                    'Opening page
                    Me.MainTabControl.SelectedTab = ProcessDetailPage
                    Me.TabControl1.SelectedTab = Tp0
                    'Selecting item
                    item.Selected = True
                    item.EnsureVisible()
                    Exit Sub
                End If
            Next

            'here means that function did not find this process in process list
            MsgBox("Process is not present in Process list.", MsgBoxStyle.Exclamation)
            'removing Entry
            ProList.Items(ProList.SelectedIndices(0)).Remove()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub KillProcessToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KillProcessToolStripMenuItem4.Click

        If NothingSelectedInlistView(ProList) Then Return

        Try
            Dim Eventlist As New ArrayList
            Eventlist.Clear()

            'return 0 if process not terminated and file not deleted.
            'return 1 if process trminated but file is not deleted
            'return 2 if process terinated and file deleted.
            'return -1 if process do not exist
            'return -2 if process is dangerous
            'return -3 if exception in process termination

            ' Sending id to kill process
            Select Case killProcessById(ProList.Items(ProList.SelectedIndices(0)).SubItems(1).Text, _
                                        False, EnableProcessFilter.Checked, Eventlist)
                Case -1
                    MsgBox("Process do not Exist.", MsgBoxStyle.Exclamation)
                    ProList.Items(ProList.SelectedIndices(0)).Remove()
                    Exit Select
                Case -2
                    MsgBox("Process is dangerous.", MsgBoxStyle.Exclamation)
                    Exit Select
                Case -3
                    MsgBox("Exception during process termination.", MsgBoxStyle.Exclamation)
                    Exit Select
                Case 1
                    MsgBox("Process terminated.", MsgBoxStyle.Information)
                    ProList.Items(ProList.SelectedIndices(0)).Remove()
                    Exit Select
            End Select


            If CheckBox8.Checked = True Then
                For Each item As String In Eventlist
                    MainTabControl.SelectedTab = ProcessDetailPage
                    TabControl1.SelectedTab = TP3
                    KillEventListBox.Focus()
                    KillEventListBox.Items.Add(item.ToString)
                    KillEventListBox.SelectedIndex = KillEventListBox.Items.Count - 1
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GetDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetDetailToolStripMenuItem.Click
        If NothingSelectedInlistView(ProList) Then Return

        Try
            LocateProcessInProcessListToolStripMenuItem_Click(Nothing, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub GetModuleListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetModuleListToolStripMenuItem.Click

        'first locate process in process list
        LocateProcessInProcessListToolStripMenuItem_Click(Nothing, Nothing)

        'if selected item is removed by LocateProcessInProcessListToolStripMenuItem_Click(Nothing, Nothing)
        'this function will return

        If NothingSelectedInlistView(ProList) Then Return


        Try
            Me.MainTabControl.SelectedTab = ProcessDetailPage
            Me.TabControl1.SelectedTab = TP1

            NameLable.Text = ProList.Items(ProList.SelectedIndices(0)).SubItems(0).Text
            IdLable.Text = ProList.Items(ProList.SelectedIndices(0)).SubItems(1).Text
            PathLable.Text = ProList.Items(ProList.SelectedIndices(0)).SubItems(2).Text

            'Dim modItems As ArrayList = GetProcessModule(ProcessListOfModule.Items(ProcessListOfModule.SelectedIndices(0)).SubItems(1).Text)
            'Building ModuleList
            BuildModuleList(GetProcessModule _
                            (ProList.Items(ProList.SelectedIndices(0)).SubItems(1).Text), ModuleList)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CopyExecutableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyExecutableToolStripMenuItem.Click
        If NothingSelectedInlistView(ProList) Then Return
        Try
            EditingClass.CopyToClipboard _
            (ProList.Items(ProList.SelectedIndices(0)).SubItems(2).Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub

    Private Sub CopyExecutablePathToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyExecutablePathToolStripMenuItem.Click
        If NothingSelectedInlistView(ProList) Then Return
        Try
            Clipboard.SetText(ProList.Items(ProList.SelectedIndices(0)).SubItems(2).Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub LocateExecutableFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocateExecutableFileToolStripMenuItem.Click
        If NothingSelectedInlistView(ProList) Then Return
        If My.Computer.FileSystem.FileExists(ProList.Items(ProList.SelectedIndices(0)).SubItems(2).Text) Then
            Try
                Process.Start(My.Computer.FileSystem.GetParentPath(ProList.Items(ProList.SelectedIndices(0)).SubItems(2).Text))
            Catch
            End Try
        End If
    End Sub
    Private Sub GetProcessFilePropertyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetProcessFilePropertyToolStripMenuItem.Click
        If NothingSelectedInlistView(ProList) Then Return
        Try
            win32.PropertyShow.ShowProperties(ProList.Items(ProList.SelectedIndices(0)).SubItems(2).Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub KillProcessAndDeleteProcessFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KillProcessAndDeleteProcessFileToolStripMenuItem.Click

        If NothingSelectedInlistView(ProList) Then Return

        'Confirm that user want to delete file or not 
        Dim delFile As Boolean = False
        If (MsgBox("Do you really want to delete process file?", MsgBoxStyle.YesNo Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            delFile = True
        End If

        Try
            Dim Eventlist As ArrayList
            Eventlist = New ArrayList
            Eventlist.Clear()

            ' Sending id to kill process
            Select Case killProcessById(ProList.Items(ProList.SelectedIndices(0)).SubItems(1).Text, _
                                        delFile, EnableProcessFilter.Checked, Eventlist)

                Case -1
                    MsgBox("Process do not Exist.", MsgBoxStyle.Exclamation)
                    ProList.Items(ProList.SelectedIndices(0)).Remove()
                    Exit Select
                Case -2
                    MsgBox("Process is dangerous.", MsgBoxStyle.Exclamation)
                    Exit Select
                Case -3
                    MsgBox("Exception during process termination.", MsgBoxStyle.Exclamation)
                    Exit Select
                Case 1
                    ProList.Items(ProList.SelectedIndices(0)).Remove()
                    If delFile Then
                        MsgBox("process terminated but Failed to delete file.", MsgBoxStyle.Exclamation)
                    Else
                        MsgBox("process terminated but File deletion is skipped by User.", _
                               MsgBoxStyle.Information)
                    End If
                    Exit Select
                Case 2
                    ProList.Items(ProList.SelectedIndices(0)).Remove()
                    MsgBox("Process terminated and file deleted.", MsgBoxStyle.Information)
                    Exit Select
            End Select



            If CheckBox8.Checked = True Then
                For Each item As String In Eventlist
                    MainTabControl.SelectedTab = ProcessDetailPage
                    TabControl1.SelectedTab = TP3
                    KillEventListBox.Focus()
                    KillEventListBox.Items.Add(item.ToString)
                    KillEventListBox.SelectedIndex = KillEventListBox.Items.Count - 1
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RemoveThisEntryFromListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveThisEntryFromListToolStripMenuItem.Click
        If NothingSelectedInlistView(ProList) Then Return
        ProList.Items(ProList.SelectedIndices(0)).Remove()
    End Sub

#End Region

#Region "  FileFoundLV Context menu  "

    Private Sub LocateFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocateFileToolStripMenuItem.Click
        If NothingSelectedInlistView(FileFoundLV) Then Return

        Try
            If My.Computer.FileSystem.FileExists(FileFoundLV.Items(FileFoundLV.SelectedIndices(0)).SubItems(2).Text) Then
                Process.Start(My.Computer.FileSystem.GetParentPath(FileFoundLV.Items(FileFoundLV.SelectedIndices(0)).SubItems(2).Text))
            Else
                MsgBox("File not found.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub CopyFileToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyFileToolStripMenuItem3.Click
        If NothingSelectedInlistView(FileFoundLV) Then Return
        Try
            EditingClass.CopyToClipboard _
            (FileFoundLV.Items(FileFoundLV.SelectedIndices(0)).SubItems(2).Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub

    Private Sub CopyPathToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyPathToolStripMenuItem.Click
        If NothingSelectedInlistView(FileFoundLV) Then Return
        Try
            Clipboard.SetText(FileFoundLV.Items(FileFoundLV.SelectedIndices(0)).SubItems(2).Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub DeleteFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteFileToolStripMenuItem.Click

        If NothingSelectedInlistView(FileFoundLV) Then Return

St:
        Try
            Dim finfo As New FileInfo(FileFoundLV.Items(FileFoundLV.SelectedIndices(0)).SubItems(2).Text)
            finfo.Attributes = FileAttributes.Normal
            finfo.Delete()
            MsgBox(finfo.FullName + "  Deleted.", MsgBoxStyle.Information)
            FileFoundLV.Items(FileFoundLV.SelectedIndices(0)).Remove()
        Catch ex As UnauthorizedAccessException
            'file in use
            For Each P As Process In Process.GetProcesses
                Try
                    If P.MainModule.FileName.ToUpper = FileFoundLV.Items(FileFoundLV.SelectedIndices(0)).SubItems(2).Text.ToUpper Then
                        '
                        If MsgBox("File is Parrent file of process : " + P.ProcessName + _
                                  "   with ID : " + P.Id.ToString + vbNewLine + _
                                   "would you want to terminate this process?", _
                                   MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            'we can not use p.kill because user may delete dangerous process
                            'P.Kill()
                            'P.WaitForExit()
                            '
                            If killProcessById(P.Id, False) > 0 Then
                                'if killprocessbyid is >0 it means process is terminated
                                'Now search this pid in prolist otherwise 
                                'log of process will be present in prolist
                                '
                                For Each item As ListViewItem In ProList.Items
                                    If item.SubItems(1).Text.ToUpper = P.Id.ToString.ToUpper Then
                                        item.Remove()
                                    End If
                                Next
                                'again start
                                GoTo St
                                '
                            Else
                                MsgBox("Error in process termination. Unable to delete process")
                                Exit Sub
                            End If
                            '                            
                        Else
                            MsgBox("File is currently in use. unable to delete file.")
                            Exit Sub
                        End If

                    End If
                Catch exs As Exception

                End Try
            Next
            '
            'scan for as module usage
            '
            If MsgBox("Error in file deletion. Please scan this file using Unlocker Page." + vbNewLine + _
                    "Would you want to scan it ?", MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                MainTabControl.SelectedTab = UnlockerPage
                ModuleAbsolutePathBox.Text = FileFoundLV.Items(FileFoundLV.SelectedIndices(0)).SubItems(2).Text
                UnlockerGo_Click(Nothing, Nothing)
                MsgBox("Scan Complete ...", MsgBoxStyle.Information)
            End If
            '
        Catch ex As ArgumentException
            'file ntfs permission

        Catch ex As Exception
            MsgBox(ex.GetType.ToString)
        End Try

    End Sub

    Private Sub GetCompleteDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetCompleteDetailToolStripMenuItem.Click
        If NothingSelectedInlistView(FileFoundLV) Then Return
        Try
            win32.PropertyShow.ShowProperties(FileFoundLV.Items(FileFoundLV.SelectedIndices(0)).SubItems(2).Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub RemoveThisEntryFromListToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveThisEntryFromListToolStripMenuItem1.Click
        If NothingSelectedInlistView(FileFoundLV) Then Return
        FileFoundLV.Items(FileFoundLV.SelectedIndices(0)).Remove()
    End Sub

#End Region

#End Region

#Region "     Process Detail Tab page events "

    'Used to clear event list
    Private Sub ClearKillEventList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearKillEventList.Click
        KillEventListBox.Items.Clear()
    End Sub

    Private Sub KillThis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KillThis.Click
        ProTreeTimer.Stop()
        Try
            'Checking for No checked state.
            If ListView2.CheckedIndices.Count <= 0 Then
                MsgBox("Tick Process Box to Kill Related Process.", MsgBoxStyle.Exclamation)
                Return
            End If
            Dim Eventlist As ArrayList
            Eventlist = New ArrayList
            Eventlist.Clear()

            ' Sending each id to kill process
            For Each content In ListView2.CheckedIndices
                Dim evlist As New ArrayList
                killProcessById(ListView2.Items(content).SubItems(1).Text.ToString, _
                                CheckBox2.Checked, EnableProcessFilter.Checked, evlist)
                Eventlist.AddRange(evlist)
            Next


            'Refressing the list
            'getlist()

            If CheckBox3.Checked = True Then
                MainTabControl.SelectedTab = ProcessDetailPage
                TabControl1.SelectedTab = TP3
                KillEventListBox.Focus()
                For Each item As String In Eventlist
                    KillEventListBox.Items.Add(item.ToString)
                Next
                'setting last item so that it can be visible
                KillEventListBox.SelectedIndex = KillEventListBox.Items.Count - 1
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ProTreeTimer.Start()
        End Try
    End Sub

    Private Sub ListView2_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView2.SelectedIndexChanged

        If ListView2.SelectedIndices.Count > 0 Then
            Dim processid = ListView2.Items(ListView2.SelectedIndices(0)).SubItems(1).Text.ToString
            '  DetailByID(processid)
            StartProcessDetailScan(processid)

        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox2.BackColor = Color.Red
        Else
            CheckBox2.BackColor = Color.Transparent
        End If
    End Sub


#Region "          ListView2 Contextmenu Events       "

    Private Sub KillProcessToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KillProcessToolStripMenuItem2.Click
        'Checking for No checked state.
        If ListView2.SelectedItems.Count <= 0 Then
            MsgBox("Select process to Kill .", MsgBoxStyle.Exclamation)
            Return
        End If

        ProTreeTimer.Stop()
        Try
            Dim Eventlist As New ArrayList
            Eventlist.Clear()

            ' Sending  id to kill process

            killProcessById(ListView2.Items(ListView2.SelectedIndices(0)).SubItems(1).Text.ToString, _
                            CheckBox2.Checked, EnableProcessFilter.Checked, Eventlist)


            If CheckBox3.Checked = True Then
                For Each item As String In Eventlist
                    TabControl1.SelectedTab = TP3
                    KillEventListBox.Focus()
                    KillEventListBox.Items.Add(item.ToString)
                    KillEventListBox.SelectedIndex = KillEventListBox.Items.Count - 1
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ProTreeTimer.Start()
        End Try
    End Sub

    Private Sub RestartProcessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartProcessToolStripMenuItem.Click
        'Checking for No checked state.
        If ListView2.SelectedItems.Count <= 0 Then
            MsgBox("Select process to Kill .", MsgBoxStyle.Exclamation)
            Return
        End If

        ProTreeTimer.Stop()

        Try

            Dim Eventlist As ArrayList
            Eventlist = New ArrayList
            Eventlist.Clear()

            ' Sending each id to kill process

            Eventlist.AddRange( _
            RestartProcess(ListView2.Items(ListView2.SelectedIndices(0)).SubItems(1).Text.ToString))
            'Refressing the list
            'getlist()

            If CheckBox3.Checked = True Then
                TabControl1.SelectedTab = TP3
                KillEventListBox.Focus()
                For Each item As String In Eventlist
                    KillEventListBox.Items.Add(item.ToString)
                Next
                KillEventListBox.SelectedIndex = KillEventListBox.Items.Count - 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ProTreeTimer.Start()
        End Try
    End Sub

    Private Sub GetModuleDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetModuleDetailToolStripMenuItem.Click

        If NothingSelectedInlistView(ListView2) Then Return

        Try
            Me.TabControl1.SelectTab(1)
            NameLable.Text = ListView2.Items(ListView2.SelectedIndices(0)).SubItems(0).Text
            IdLable.Text = ListView2.Items(ListView2.SelectedIndices(0)).SubItems(1).Text
            'PathLable.Text = ListView2.Items(ListView2.SelectedIndices(0)).SubItems(2).Text

            'now we stroed path in tooltip
            PathLable.Text = ListView2.Items(ListView2.SelectedIndices(0)).ToolTipText

            'Dim modItems As ArrayList = GetProcessModule(ListView2.Items(ListView2.SelectedIndices(0)).SubItems(1).Text)
            'Building ModuleList
            BuildModuleList(GetProcessModule(ListView2.Items(ListView2.SelectedIndices(0)).SubItems(1).Text), ModuleList)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SuspendProcessToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuspendProcessToolStripMenuItem1.Click
        If NothingSelectedInlistView(ListView2) Then Return
        Try
            If SuspendProcess(ListView2.Items(ListView2.SelectedIndices(0)).SubItems(1).Text) = True Then
                MsgBox("Process : " + ListView2.Items(ListView2.SelectedIndices(0)).SubItems(0).Text + " with ID : " _
                        + ListView2.Items(ListView2.SelectedIndices(0)).SubItems(1).Text + " Successfully Suspended.", MsgBoxStyle.Information)
            Else
                MsgBox("Process : " + ListView2.Items(ListView2.SelectedIndices(0)).SubItems(0).Text + " with ID : " _
                       + ListView2.Items(ListView2.SelectedIndices(0)).SubItems(1).Text + " Failed to Suspended.", MsgBoxStyle.Critical, "Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ResumeProcessToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumeProcessToolStripMenuItem1.Click

        If NothingSelectedInlistView(ListView2) Then Return

        Try
            If ResumeProcess(ListView2.Items(ListView2.SelectedIndices(0)).SubItems(1).Text) = True Then
                MsgBox("Process : " + ListView2.Items(ListView2.SelectedIndices(0)).SubItems(0).Text + " with ID : " _
                        + ListView2.Items(ListView2.SelectedIndices(0)).SubItems(1).Text + " Successfully Resumed.", MsgBoxStyle.Information)
            Else
                MsgBox("Process : " + ListView2.Items(ListView2.SelectedIndices(0)).SubItems(0).Text + " with ID : " _
                       + ListView2.Items(ListView2.SelectedIndices(0)).SubItems(1).Text + " Failed to Resumed.", MsgBoxStyle.Critical, "Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub GetGenralDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetGenralDetailToolStripMenuItem.Click

        If NothingSelectedInlistView(ListView2) Then Return

        Me.MainTabControl.SelectTab(2)
        Me.TabControl1.SelectTab(0)
    End Sub

    Private Sub GetProcessFilePropertyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetProcessFilePropertyToolStripMenuItem1.Click
        If NothingSelectedInlistView(ListView2) Then Return
        If Not My.Computer.FileSystem.FileExists(ListView2.Items(ListView2.SelectedIndices(0)).ToolTipText) Then
            MsgBox("Process File Path is not Detected.", MsgBoxStyle.Exclamation)
            Return
        End If
        Try
            win32.PropertyShow.ShowProperties(ListView2.Items(ListView2.SelectedIndices(0)).ToolTipText)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
    'reload process tree 
    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        ProTreeTimer.Stop()
        ProTree.Nodes.Clear()
        ListView2.Items.Clear()
        ImageList2.Images.Clear()
        ProTreeTimer.Start()
    End Sub

    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
        If NothingSelectedInlistView(ListView2) Then Return
        Try
            If My.Computer.FileSystem.FileExists(ListView2.SelectedItems(0).ToolTipText) Then
                Process.Start(My.Computer.FileSystem.GetParentPath(ListView2.SelectedItems(0).ToolTipText))
            Else
                MsgBox("File : " + ListView2.SelectedItems(0).ToolTipText + " not found.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CopyFileToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyFileToolStripMenuItem1.Click
        If NothingSelectedInlistView(ListView2) Then Return
        Try
            EditingClass.CopyToClipboard _
            (ListView2.Items(ListView2.SelectedIndices(0)).ToolTipText)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub

    Private Sub CopyFilePathToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyFilePathToolStripMenuItem1.Click
        If NothingSelectedInlistView(ListView2) Then Return
        Try
            Clipboard.SetText(ListView2.Items(ListView2.SelectedIndices(0)).ToolTipText)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

#End Region

#Region "       Module list Contextmenu events   "

    Private Sub GetAllProcessUsingThisModuleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetAllProcessUsingThisModuleToolStripMenuItem.Click

        If NothingSelectedInlistView(ModuleList) Then Return

        Try
            Me.MainTabControl.SelectedTab = UnlockerPage
            ModuleAbsolutePathBox.Text = ModuleList.Items(ModuleList.SelectedIndices(0)).SubItems(2).Text
            If Not My.Computer.FileSystem.FileExists(ModuleAbsolutePathBox.Text) Then
                Return
            End If
            'this button function will list all process
            UnlockerGo_Click(Nothing, Nothing)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ReleaseSelectedModuleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReleaseSelectedModuleToolStripMenuItem.Click

        If NothingSelectedInlistView(ModuleList) Then Return

        Dim P As Process
        Try
            P = Process.GetProcessById(IdLable.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try

        If UnLoadModuleFromProcess(P.Id, ModuleList.Items(ModuleList.SelectedIndices(0)).SubItems(3).Text) = 0 Then
            ModuleList.Items(ModuleList.SelectedIndices(0)).Remove()
        Else
            MsgBox("Module Not Released from " + P.ProcessName)
        End If


    End Sub

    Private Sub OpenLocationOfModuleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenLocationOfModuleToolStripMenuItem.Click

        If NothingSelectedInlistView(ModuleList) Then Return

        Try
            System.Diagnostics.Process.Start(My.Computer.FileSystem.GetParentPath _
                                             (ModuleList.Items(ModuleList.SelectedIndices(0)).SubItems(2).Text))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CopyFileToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyFileToolStripMenuItem2.Click

        If NothingSelectedInlistView(ModuleList) Then Return

        Try
            EditingClass.CopyToClipboard _
            (ModuleList.Items(ModuleList.SelectedIndices(0)).SubItems(2).Text)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub

    Private Sub CopyFilePathToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyFilePathToolStripMenuItem2.Click

        If NothingSelectedInlistView(ModuleList) Then Return


        Try
            Clipboard.SetText(ModuleList.Items(ModuleList.SelectedIndices(0)).SubItems(2).Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub GetModuleFilePropertyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetModuleFilePropertyToolStripMenuItem.Click
        If NothingSelectedInlistView(ModuleList) Then Return

        Try
            win32.PropertyShow.ShowProperties(ModuleList.Items(ModuleList.SelectedIndices(0)).SubItems(2).Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

#End Region


#End Region

#Region "         File & Folder Option Tab page events   "

#Region "           Folder option page event"

    Private Sub ShowHideFile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowHideFile.CheckedChanged
        If ShowHideFile.Checked = False Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "Hidden", 2)
            SystemHided.Enabled = False
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "Hidden", 1)
            SystemHided.Enabled = True

        End If
    End Sub

    Private Sub SystemHided_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemHided.CheckedChanged

        If SystemHided.Checked = False Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowSuperHidden", 0)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowSuperHidden", 1)
        End If
    End Sub

    Private Sub FileExt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileExt.CheckedChanged
        If FileExt.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "HideFileExt", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "HideFileExt", 0)
        End If

    End Sub

    Private Sub ShowFolderOption_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowFolderOption.Click
        Try
            My.Computer.Registry.SetValue(HKCUPolicyExplorerKey, "NoFolderOptions", 0)
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\Folder\Hidden\SHOWALL", "CheckedValue", 1)
            Shell("CONTROL FOLDERS", AppWinStyle.MaximizedFocus)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Folder Option Error")
        End Try

    End Sub

#End Region

#Region "        Get Removal media panal   "

    Private Sub GetRemovalMedia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetRemovalMedia.Click

        On Error Resume Next
        RemovalMediaDriveList.Items.Clear()

        For Each drive As System.IO.DriveInfo In System.IO.DriveInfo.GetDrives
            'we are using this to ignore floppy drive
            If IgnoreDrive(drive) Then Continue For

            'Findind Removal Media
            ' If GetDriveType(drive) = "Removel Media" Then
            If drive.DriveType = IO.DriveType.Removable Then
                'With RemovalMediaDriveList
                Dim LvItem As New ListViewItem
                LvItem.Text = drive.Name
                LvItem.SubItems.Add(drive.VolumeLabel)
                LvItem.SubItems.Add(drive.DriveFormat)
                LvItem.SubItems.Add(ByteSizeOptimaized(drive.TotalSize))
                LvItem.SubItems.Add(ByteSizeOptimaized(drive.TotalSize - drive.AvailableFreeSpace))
                LvItem.SubItems.Add(ByteSizeOptimaized(drive.AvailableFreeSpace))

                'finding autorun.inf
                If My.Computer.FileSystem.FileExists(drive.Name.ToString + "Autorun.inf") Then
                    LvItem.SubItems.Add(drive.Name.ToString + "autorun.inf")
                    LvItem.BackColor = Color.Red
                Else
                    LvItem.SubItems.Add("")
                End If

                'now add this item to listview
                RemovalMediaDriveList.Items.Add(LvItem)


                '.Items.Add(drive.Name)
                '.Items(.Items.Count - 1).SubItems.Add(drive.VolumeLabel)
                '.Items(.Items.Count - 1).SubItems.Add(drive.DriveFormat)
                '.Items(.Items.Count - 1).SubItems.Add(ByteSizeOptimaized(drive.TotalSize))
                '.Items(.Items.Count - 1).SubItems.Add(ByteSizeOptimaized(drive.TotalSize - drive.AvailableFreeSpace))
                '.Items(.Items.Count - 1).SubItems.Add(ByteSizeOptimaized(drive.AvailableFreeSpace))

                ''finding autorun.inf
                'If My.Computer.FileSystem.FileExists(drive.Name.ToString + "Autorun.inf") Then
                '    .Items(.Items.Count - 1).SubItems.Add(drive.Name.ToString + "autorun.inf")
                '    .Items(.Items.Count - 1).BackColor = Color.Red
                'Else
                '    .Items(.Items.Count - 1).SubItems.Add("")
                'End If
                'End With

            End If
        Next

        If RemovalMediaDriveList.Items.Count <= 0 Then
            MsgBox("No Removable Media is connected.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub VisualiseAllFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisualiseAllFile.Click
        'check for not selection of any drive
        If ListViewIsEmptyOrNotSelected(RemovalMediaDriveList) Then Return

        'Clearing the NotepadArraylist
        Dim NotePadArrayList As New ArrayList
        NotePadArrayList.Clear()

        'Entering in to drive
        Dim Currentdrive As System.IO.DirectoryInfo
        Currentdrive = New System.IO.DirectoryInfo _
        (RemovalMediaDriveList.Items(RemovalMediaDriveList.SelectedIndices(0)).SubItems(0).Text.ToString)

        'Sending the current directory to visualise function

        If visualiseFileOfCurrentFolder(Currentdrive, NotePadArrayList) = False Then
            MsgBox("Operation Failed.")
            GetRemovalMedia.PerformClick()
            Return
        Else
            Me.TabControl5.SelectedTab = ChangeRemDetail
        End If

        'Always Add Detail to RemDetailTextbox
        Me.RemDetailTextbox.Text = "Operation Detail : " + vbNewLine
        For Each item As String In NotePadArrayList
            RemDetailTextbox.Text += item.ToString + vbNewLine
        Next


        'Adding Datail to notepad or text box
        If GenDetail.Checked = True Then
            'Adding detail to note pad
            Try
                'This will Generate the NotePad with detail
                NotePadDetail(Application.StartupPath.ToString + "\NotePadDetail.txt", RemDetailTextbox.Text, True, True)
            Catch
                MsgBox("Error Occured at NotePad Detail Genration")
            End Try
        End If
        'clearing arraylist
        NotePadArrayList.Clear()

    End Sub

    Private Sub RemoveSystemHidden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveSystemHidden.Click
        'check for not selection of any drive
        If ListViewIsEmptyOrNotSelected(RemovalMediaDriveList) Then Return

        'Resetting NotepadAray list 
        Dim NotePadArrayList As New ArrayList
        NotePadArrayList.Clear()


        'Entering in to selected  drive
        Dim Currentdrive As System.IO.DirectoryInfo
        Currentdrive = New System.IO.DirectoryInfo _
        (RemovalMediaDriveList.Items(RemovalMediaDriveList.SelectedIndices(0)).SubItems(0).Text.ToString)

        'Sending the current directory to Remove function
        If RemoveSystemHiddenFileInDrive(Currentdrive, NotePadArrayList) = False Then
            MsgBox("Operation Failed.")
            GetRemovalMedia.PerformClick()
            Return
        Else
            'Open Detail List
            Me.TabControl5.SelectedTab = ChangeRemDetail
        End If

        'Always Add Detail to RemDetailTextbox
        Me.RemDetailTextbox.Text = "Operation Detail : " + vbNewLine
        For Each item As String In NotePadArrayList
            RemDetailTextbox.Text += item.ToString + vbNewLine
        Next


        'Adding Datail to notepad or text box
        If GenDetail.Checked = True Then
            'Adding detail to note pad
            Try
                'This will Generate the NotePad with detail
                NotePadDetail(Application.StartupPath.ToString + "\NotePadDetail.txt", RemDetailTextbox.Text, True, True)
            Catch
                MsgBox("Error Occured at NotePad Detail Genration")
            End Try
        End If
        'clearing arraylist
        NotePadArrayList.Clear()
    End Sub

    Private Sub GenDetail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenDetail.CheckedChanged
        Try
            My.Computer.Registry.SetValue(VERKey, "GenDetail", GenDetail.Checked, RegistryValueKind.DWord)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error in registry creation..")
        End Try
    End Sub

    Private Sub GetdrvProperty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetdrvProperty.Click

        If ListViewIsEmptyOrNotSelected(RemovalMediaDriveList) Then Return

        Try
            win32.PropertyShow.ShowProperties(RemovalMediaDriveList.Items(RemovalMediaDriveList.SelectedIndices(0)).Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

#End Region

#Region "     Directory detail tab page events   "

    Private Sub BrowseDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseDir.Click
        Dim FolderBrowserDialog As New FolderBrowserDialog
        FolderBrowserDialog.ShowNewFolderButton = False
        If FolderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            DirectoryPath.Text = FolderBrowserDialog.SelectedPath.ToString
        End If
    End Sub

#Region "   file search with specified attribute(s)"

    Private Sub GetDirectoryFileListView(ByVal Attribute_s As FileAttributes)

        Try
            'Checking for true path selection
            'if nothing entred in text box
            If TextBoxIsIdle(DirectoryPath, True) Then Return
            'if directory does not exist
            If Not Directory_Exists(DirectoryPath.Text, True) Then Return

            'clearing list
            DirectoryFileListView.Items.Clear()

            Dim myDirectory As New System.IO.DirectoryInfo(DirectoryPath.Text)

            For Each aFile As System.IO.FileInfo In myDirectory.GetFiles
                If (aFile.Attributes And Attribute_s) = Attribute_s Then
                    Dim LvItem As New ListViewItem
                    LvItem.Text = aFile.Name
                    LvItem.SubItems.Add(ByteSizeOptimaized(aFile.Length / 1024))
                    LvItem.SubItems.Add(aFile.Extension)
                    LvItem.SubItems.Add(aFile.FullName)
                    DirectoryFileListView.Items.Add(LvItem)
                End If
            Next

            If DirectoryFileListView.Items.Count <= 0 Then
                MsgBox("File(s) with specified attribute(s) does not exist.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub

    Private Sub ShowAlllSytemFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowAlllSytemFile.Click
        On Error Resume Next
        GetDirectoryFileListView(FileAttributes.System)
    End Sub

    Private Sub ShowAllFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowAllFile.Click
        On Error Resume Next
        GetDirectoryFileListView(Nothing)
    End Sub

    Private Sub ShowAllHiddenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowAllHiddenFile.Click
        On Error Resume Next
        GetDirectoryFileListView(FileAttributes.Hidden)
    End Sub

    Private Sub OnlySystemHidden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnlySystemHidden.Click
        On Error Resume Next
        GetDirectoryFileListView(FileAttributes.Hidden + FileAttributes.System)
    End Sub

#End Region

    Private Sub DeleteFileInList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteFileInList.Click

        'if ListViewIsEmptyOrNotSelected(DirectoryFileListView, True) Then Return
        If EmptyListView(DirectoryFileListView, True) Then Return

        If NothingCheckedInlistView(DirectoryFileListView, False) And NothingSelectedInlistView(DirectoryFileListView, False) Then
            MsgBox("Select file(s) first.", MsgBoxStyle.Exclamation)
            Return
        End If


        If Not MsgBox("Selected file(s) will be Removed." + vbNewLineVER(2) + _
                      "Click [ O.K. ] to confirm, or [Cancel] to quit.", MsgBoxStyle.OkCancel Or MsgBoxStyle.Information) = MsgBoxResult.Ok Then
            Return
        End If

        '----------------------------------------------------------------------------

        'if no check box is checked but item is selected
        If DirectoryFileListView.CheckedIndices.Count <= 0 Then
            If DirectoryFileListView.SelectedItems.Count > 0 Then
                If My.Computer.FileSystem.FileExists _
                (DirectoryFileListView.Items(DirectoryFileListView.SelectedIndices(0)).SubItems(3).Text.ToString) Then

                    Dim afile As New System.IO.FileInfo(DirectoryFileListView.Items(DirectoryFileListView.SelectedIndices(0)).SubItems(3).Text.ToString)
                    Dim exs As New Exception

                    If DeleteFile(afile, False, True, True, , exs) = False Then
                        MsgBox(exs.Message, MsgBoxStyle.Exclamation)
                        DirectoryFileListView.Items(DirectoryFileListView.SelectedIndices(0)).BackColor = Color.Pink
                        Return
                    End If

                    'Taking Control Of file 
                    'NTFS.AddFullcontrolToFile(DirectoryFileListView.Items(DirectoryFileListView.SelectedIndices(0)).SubItems(3).Text)
                    'Dim attrib As New FileAttribute
                    'attrib = afile.Attributes
                    'afile.Attributes = IO.FileAttributes.Normal
                    'afile.Delete()
                    'Catch exs As Exception
                    '    MsgBox(exs.Message, MsgBoxStyle.Exclamation)
                    '    DirectoryFileListView.Items(DirectoryFileListView.SelectedIndices(0)).BackColor = Color.Red
                    '    Return
                    'End Try
                    DirectoryFileListView.Items(DirectoryFileListView.SelectedIndices(0)).Remove()
                Else
                    DirectoryFileListView.Items(DirectoryFileListView.SelectedIndices(0)).Remove()
                End If
            End If
            Return
        End If

        'If item checked then it will leave the selected one
        'now start renaming

        For Each content As Integer In DirectoryFileListView.CheckedIndices
            If My.Computer.FileSystem.FileExists(DirectoryFileListView.Items(content).SubItems(3).Text) Then
                Dim afile As New System.IO.FileInfo(DirectoryFileListView.Items(content).SubItems(3).Text.ToString)
                Dim exs As New Exception
                If DeleteFile(afile, False, True, True, , exs) = False Then
                    MsgBox(exs.Message, MsgBoxStyle.Exclamation)
                    DirectoryFileListView.Items(content).BackColor = Color.Pink
                    Continue For
                End If
                'Catch exs As Exception
                '    MsgBox(exs.Message, MsgBoxStyle.Exclamation)
                '    DirectoryFileListView.Items(content).BackColor = Color.Pink
                '    Continue For
                'End Try
                DirectoryFileListView.Items(content).Remove()
                ' if file not found 
            Else
                DirectoryFileListView.Items(content).Remove()
            End If
        Next

    End Sub

    Private Sub RenameFileInList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenameFileInList.Click

        'if ListViewIsEmptyOrNotSelected(DirectoryFileListView, True) Then Return
        If EmptyListView(DirectoryFileListView, True) Then Return

        If NothingCheckedInlistView(DirectoryFileListView, False) And NothingSelectedInlistView(DirectoryFileListView, False) Then
            MsgBox("Select file(s) first.", MsgBoxStyle.Exclamation)
            Return
        End If


        If Not MsgBox("Selected file(s) will be renamed." + vbNewLineVER(2) + _
                      "Click [ O.K. ] to confirm, or [Cancel] to quit.", MsgBoxStyle.OkCancel Or MsgBoxStyle.Information) = MsgBoxResult.Ok Then
            Return
        End If

        '----------------------------------------------------------------------------

        'if no check box is checked but item is selected
        If DirectoryFileListView.CheckedIndices.Count <= 0 Then
            If DirectoryFileListView.SelectedItems.Count > 0 Then
                If My.Computer.FileSystem.FileExists _
                (DirectoryFileListView.Items(DirectoryFileListView.SelectedIndices(0)).SubItems(3).Text.ToString) Then

                    Dim afile As System.IO.FileInfo = Nothing

                    Try
                        afile = New System.IO.FileInfo(DirectoryFileListView.Items(DirectoryFileListView.SelectedIndices(0)).SubItems(3).Text.ToString)
                        'Taking Control Of file 
                        NTFS.AddFullcontrolToFile(DirectoryFileListView.Items(DirectoryFileListView.SelectedIndices(0)).SubItems(3).Text)
                        Dim attrib As New FileAttribute
                        attrib = afile.Attributes
                        afile.Attributes = IO.FileAttributes.Normal
                        afile.MoveTo(afile.Directory.FullName + "\Renamed " + afile.Name)
                        afile.Attributes = attrib
                    Catch exs As Exception
                        MsgBox(exs.Message, MsgBoxStyle.Exclamation)
                        Return
                    End Try

                    UpdateDirectoryFileListView(DirectoryFileListView.SelectedIndices(0), afile)
                Else
                    DirectoryFileListView.Items(DirectoryFileListView.SelectedIndices(0)).Remove()
                End If
            End If
            Return
        End If

        'If item checked then it will leave the selected one
        'now start renaming

        For Each content As Integer In DirectoryFileListView.CheckedIndices
            If My.Computer.FileSystem.FileExists(DirectoryFileListView.Items(content).SubItems(3).Text) Then
                Dim afile As System.IO.FileInfo = Nothing

                Try
                    afile = New System.IO.FileInfo(DirectoryFileListView.Items(content).SubItems(3).Text.ToString)
                    'Taking Control Of file 
                    NTFS.AddFullcontrolToFile(DirectoryFileListView.Items(content).SubItems(3).Text)
                    Dim attrib As New FileAttribute
                    attrib = afile.Attributes
                    afile.Attributes = IO.FileAttributes.Normal
                    afile.MoveTo(afile.Directory.FullName + "\Renamed " + afile.Name)
                    afile.Attributes = attrib
                Catch exs As Exception
                    MsgBox(exs.Message, MsgBoxStyle.Exclamation)
                    Continue For

                End Try

                UpdateDirectoryFileListView(content, afile)

                ' if file not found 
            Else
                DirectoryFileListView.Items(content).Remove()
            End If
        Next
        '-----------------------------------------------------------

    End Sub
    'this function is worling for rename function
    Private Function UpdateDirectoryFileListView(ByVal content As Integer, ByVal afile As FileInfo) As Boolean
        DirectoryFileListView.Items(content).SubItems(0).Text = afile.Name
        DirectoryFileListView.Items(content).SubItems(1).Text = (afile.Length / 1024).ToString
        DirectoryFileListView.Items(content).SubItems(2).Text = afile.Extension
        DirectoryFileListView.Items(content).SubItems(3).Text = afile.FullName
    End Function


    Private Sub FileAttributeApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileAttributeApply.Click

        If ListViewIsEmptyOrNotSelected(DirectoryFileListView, True) Then Return

        'this function will not work if NTFS permission is not available 
        'or media is read only

        Try
            Dim Finfo As FileInfo = New FileInfo(DirectoryFileListView.Items(DirectoryFileListView.SelectedIndices(0)).SubItems(3).Text)
            'Nomalizing file attribute
            'Finfo.Attributes = FileAttributes.Normal

            Dim attrib As New FileAttributes
            attrib = FileAttributes.Normal

            'now set attribute
            If FileAttributeReadOnly.Checked = True Then
                attrib += FileAttributes.ReadOnly
            End If

            If FileAttributeSystem.Checked = True Then
                attrib += FileAttributes.System
            End If

            If FileAtttributeHidden.Checked = True Then
                attrib += FileAttributes.Hidden
            End If

            If FileAttributeArchive.Checked = True Then
                attrib += FileAttributes.Archive
            End If

            If FileAttributeCompressed.Checked = True Then
                attrib += FileAttributes.Compressed
            End If
            If FileAttributeOffLine.Checked = True Then
                attrib += FileAttributes.Offline
            End If
            If FileAttributeEncripted.Checked = True Then
                attrib += FileAttributes.Encrypted
            End If
            If FileAttributeTemporary.Checked = True Then
                attrib += FileAttributes.Temporary
            End If

            'now set this attribute to file
            Finfo.Attributes = attrib

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub DirectoryFileListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirectoryFileListView.SelectedIndexChanged

        If ListViewIsEmptyOrNotSelected(DirectoryFileListView, False) Then Return

        'Making all block unchecked
        FileAttributeReadOnly.Checked = False
        FileAtttributeHidden.Checked = False
        FileAttributeArchive.Checked = False
        FileAttributeSystem.Checked = False
        FileAttributeCompressed.Checked = False
        FileAttributeOffLine.Checked = False
        FileAttributeEncripted.Checked = False
        FileAttributeTemporary.Checked = False

        'seting file name 

        Try
            Dim afile As FileInfo = New FileInfo(DirectoryFileListView.Items(DirectoryFileListView.SelectedIndices(0)).SubItems(3).Text)
            If My.Computer.FileSystem.FileExists(afile.FullName) Then
                'getting attribute of file
                Dim afile_attrib() As String = afile.Attributes.ToString.Split(",")

                For Each item As String In afile_attrib
                    item = item.TrimStart(" ")
                    Select Case item.ToLower
                        Case "readonly"
                            FileAttributeReadOnly.Checked = True
                        Case "hidden"
                            FileAtttributeHidden.Checked = True
                        Case "archive"
                            FileAttributeArchive.Checked = True
                        Case "system"
                            FileAttributeSystem.Checked = True
                        Case "compressed"
                            FileAttributeCompressed.Checked = True
                        Case "offline"
                            FileAttributeOffLine.Checked = True
                        Case "encripted"
                            FileAttributeEncripted.Checked = True
                        Case "temporary"
                            FileAttributeTemporary.Checked = True
                    End Select
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'property button in folder detail page
    Private Sub DDFileDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DDFileDetail.Click
        'DirectoryFileListView
        If ListViewIsEmptyOrNotSelected(DirectoryFileListView) Then Return

        Try
            win32.PropertyShow.ShowProperties(DirectoryFileListView.Items(DirectoryFileListView.SelectedIndices(0)).SubItems(3).Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

#End Region

#Region "      Delete file page events  "

#Region " File operation Page"

    Private Sub BT1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT1.Click
        'Add Batch of file File
        Dim OpenFileDialog1 As New OpenFileDialog

        OpenFileDialog1.Filter = "Executable files (*.exe)|*.exe|DLL files (*.dll)|*.dll|ActiveX Control files (*.ocx)|*.ocx|All files (*.*)|*.*"
        OpenFileDialog1.Multiselect = True

        If OpenFileDialog1.ShowDialog() <> Windows.Forms.DialogResult.OK Then Return

        For Each item As String In OpenFileDialog1.FileNames
            'checking for duplicate entry
            Dim i As Integer = 0
            For i = 0 To DelList.Items.Count - 1
                If DelList.Items(i).SubItems(4).Text.ToUpper = item.ToUpper Then
                    'MsgBox("File alrready Exist.")
                    'jump to loop last
                    GoTo skip
                End If
            Next

            'here add this file to list
            Dim finfo As New IO.FileInfo(item)

            Dim LvItem As New ListViewItem
            LvItem.Text = (DelList.Items.Count + 1).ToString
            LvItem.SubItems.Add(finfo.Name)
            LvItem.SubItems.Add(finfo.Length.ToString)
            LvItem.SubItems.Add(finfo.Attributes.ToString)
            LvItem.SubItems.Add(finfo.FullName)
            DelList.Items.Add(LvItem)

skip:

        Next
    End Sub

    Private Sub ADDfile2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDfile2.Click

        If TextBoxIsIdle(LocateFile) Then Return

        If My.Computer.FileSystem.FileExists(LocateFile.Text) Then
            'checking for duplicate entry
            Dim i As Integer = 0
            For i = 0 To DelList.Items.Count - 1
                If DelList.Items(i).SubItems(4).Text.ToUpper = LocateFile.Text.ToUpper Then
                    'MsgBox("File alrready Exist.")
                    'jump to loop last
                    MsgBox("File is already added to list.", MsgBoxStyle.Information)
                    Return
                End If
            Next

            'here add this file to list
            Dim finfo As New IO.FileInfo(LocateFile.Text)

            Dim LvItem As New ListViewItem
            LvItem.Text = (DelList.Items.Count + 1).ToString
            LvItem.SubItems.Add(finfo.Name)
            LvItem.SubItems.Add(finfo.Length.ToString)
            LvItem.SubItems.Add(finfo.Attributes.ToString)
            LvItem.SubItems.Add(finfo.FullName)
            DelList.Items.Add(LvItem)

        Else
            MsgBox("File does not exist.", MsgBoxStyle.Exclamation)
        End If

        'End of this function

    End Sub

    Private Sub RemSFL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemSFL.Click
        If EmptyListView(DelList) Then Return
        For Each item As ListViewItem In DelList.SelectedItems
            item.Remove()
        Next
    End Sub

    Private Sub ClrList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClrList.Click
        DelList.Items.Clear()
    End Sub

    Private Sub DelACF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelACF.Click

        If EmptyListView(DelList, True) Then Return

        'Check for Confirmation....
        If MsgBox("Do you Realy want To delete all file added in list.", MsgBoxStyle.OkCancel, "Be careful..") _
                           = MsgBoxResult.Ok Then
            Dim EventCapture As New ArrayList
            Try
                Dim i As Integer = 0

                'here we will travers this listview form last file to first file
                'because during deletion file counting will reduce and index of each item will 
                'changed so this is ok to remove from bottom to top
                'if any object will not be deleted , we will change its color and leave it in listview
                For Each item As ListViewItem In DelList.Items

                    'get file name 
                    Dim afile As String = item.SubItems(4).Text

                    'check file existance
                    'if exist then delete it or remove its entry
                    If My.Computer.FileSystem.FileExists(afile) Then

                        Dim event1 As New ArrayList
                        If DeleteFile(New FileInfo(afile), SendToRecycleFile.Checked, ForceToDeleteFile.Checked, _
                                    EnableProcessFilter.Checked, event1) Then
                            'Remove Entry From List
                            item.Remove()
                        Else
                            item.BackColor = Color.Red
                        End If
                        EventCapture.AddRange(event1)

                    Else
                        'if the file is already move or deleted 
                        'removing Entry
                        item.Remove()
                        EventCapture.Add(afile + " : Not Found.")
                    End If
                Next

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                UpdateEventList(EventCapture, True)
                UDTabControl1.SelectedTab = UDTabPage3
            End Try
        End If

    End Sub

    Private Sub DelSF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelSF.Click

        If EmptyListView(DelList) Then Return

        If DelList.SelectedItems.Count <= 0 Then
            MsgBox("Select File First.")
            Return
        End If

        Dim EventCapture As New ArrayList

        Try
            For Each item As ListViewItem In DelList.SelectedItems
                Dim afile As String = item.SubItems(4).Text.ToString

                If My.Computer.FileSystem.FileExists(afile) Then
                    Dim event1 As New ArrayList
                    If DeleteFile(New FileInfo(afile), SendToRecycleFile.Checked, _
                                   ForceToDeleteFile.Checked, EnableProcessFilter.Checked, event1) Then
                        'Removing Entry From list
                        item.Remove()
                    Else
                        'Removing Entry From list
                        item.BackColor = Color.Red
                        'EventCapture.Add("Failed to delete File.")
                    End If
                    EventCapture.AddRange(event1)
                Else
                    EventCapture.Add(afile + " : Not Found.")
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            UpdateEventList(EventCapture, True)
            UDTabControl1.SelectedTab = UDTabPage3
        End Try
    End Sub

#End Region

#Region "Directory Option Page"

    Private Sub delAF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delAF.Click

        If TextBoxIsIdle(DirLocation) Then Return

        If Not My.Computer.FileSystem.DirectoryExists(DirLocation.Text) Then
            MsgBox("Folder not found.", MsgBoxStyle.Exclamation)
            Return
        End If

        If New DriveInfo(DirLocation.Text).Name.ToLower = DirLocation.Text.ToLower Then

            If MessageBox.Show("Your Selected path is root location of a drive." + vbNewLine + vbNewLine + _
                             "Do you really want to delete every file of this drive?" + vbNewLine + _
                             "Please be careful otherwise you may loose your all data of this drive.", "Warning", _
                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning, _
                             MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) <> Windows.Forms.DialogResult.Yes Then
                MsgBox("Action is Cancled by User", MsgBoxStyle.Exclamation)
                Return
            End If
        Else
            'confirm action with send to recycle bin option
            If Not MsgBox("This will delete all files of this Folder." + vbNewLine + _
                          "Confirm?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                MsgBox("Action is Cancled by User.", MsgBoxStyle.Information)
                Return
            End If
        End If

        If Not DriveIsReadyToReadAndWrite(New DriveInfo(DirLocation.Text)) Then
            MsgBox("This drive is not ready to Write Data." + vbNewLine + _
                   "Unable to Execute.", MsgBoxStyle.Exclamation)
            Return
        End If


        'create parrameter to collect information
        Dim dld As New ArrayList
        Dim ndld As New ArrayList
        Dim EventList As New ArrayList
        Dim Ex As New Exception
        If Not DeleteAllFilesInDir(New IO.DirectoryInfo(DirLocation.Text), FDel.Checked, _
                               EnableProcessFilter.Checked, IncSd1.Checked, True, RecycleBinBox.Checked, _
                               dld, ndld, REDir1.Checked, EventList, Ex) Then

            MsgBox(Ex.Message, MsgBoxStyle.Exclamation)

        End If

        UpdateEventList(EventList, True)
        UDTabControl1.SelectedTab = UDTabPage3


    End Sub

    'Confirm drive is ready and nor CDROM
    Private Function DriveIsReadyToReadAndWrite(ByVal DrvInfo As DriveInfo, Optional ByRef ex As Exception = Nothing) As Boolean
        Try

            If Not DrvInfo.IsReady Then
                Throw New Exception(DrvInfo.Name + " : Drive is not Ready.")
                Return False
            End If

            If DrvInfo.DriveType = DriveType.CDRom Then
                Throw New Exception(DrvInfo.Name + " : Drive is CDROM.")
                Return False
            End If

        Catch ex 'As Exception
            Return False
        End Try
        Return True
    End Function

    'Browse location
    Private Sub BR2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BR2.Click
        Dim FolderBrowserDialog1 As New FolderBrowserDialog
        FolderBrowserDialog1.ShowNewFolderButton = False
        FolderBrowserDialog1.ShowDialog()

        If Not My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath) Then
            'MsgBox("Folder not found.", MsgBoxStyle.Exclamation)
            Return
        End If
        DirLocation.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    '
    Private Sub DelAllEmptyDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelAllEmptyDir.Click
        If TextBoxIsIdle(DirLocation) Then Return

        If Not Directory_Exists(DirLocation.Text, True) Then Return

        If Not DriveIsReadyToReadAndWrite(New DriveInfo(DirLocation.Text)) Then
            MsgBox("This drive is not ready to Write Data." + vbNewLine + _
                   "Unable to Execute.", MsgBoxStyle.Exclamation)
            Return
        End If

        'confirm action with send to recycle bin option
        If Not MsgBox("This will delete all empty directories of this Folder." + vbNewLine + _
                      "Confirm?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            MsgBox("Action is Cancled by User.", MsgBoxStyle.Information)
            Return
        End If



        'now collect all allowed file names
        Dim allowedfiles As New ArrayList

        For Each line As String In FilesAllowedToDeleteBox.Lines
            If (line Is Nothing) Or line = "" Or line = " " Or line = "  " Then
                Continue For
            End If
            line = line.Trim()
            allowedfiles.Add(line)
        Next

        'create parrameter to collect information
        Dim dld As New ArrayList
        Dim ndld As New ArrayList
        Dim EventList As New ArrayList
        Dim Ex As New Exception

        If DeleteEmptyDirectory(New IO.DirectoryInfo(DirLocation.Text), allowedfiles, _
                                RecycleBinBox.Checked, FDel.Checked, _
                                EnableProcessFilter.Checked, _
                                dld, ndld, EventList, Ex) Then
            MsgBox(Ex.Message, MsgBoxStyle.Exclamation)
        End If

        UpdateEventList(EventList, True)
        UDTabControl1.SelectedTab = UDTabPage3



    End Sub

    Private Sub DelFileWithExt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelFileWithExt.Click
        If TextBoxIsIdle(DirLocation) Then Return
        If Not Directory_Exists(DirLocation.Text, True) Then Return

        If Not DriveIsReadyToReadAndWrite(New DriveInfo(DirLocation.Text)) Then
            MsgBox("This drive is not ready to Write Data." + vbNewLine + _
                   "Unable to Execute.", MsgBoxStyle.Exclamation)
            Return
        End If

        'confirm action with send to recycle bin option
        If Not MsgBox("This will delete all files of selected Extentions." + vbNewLine + _
                      "Confirm?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            MsgBox("Action is Cancled by User.", MsgBoxStyle.Information)
            Return
        End If



        'now collect all allowed file names
        Dim allowedExts As New ArrayList

        For Each line As String In ExtBox.Lines
            If (line Is Nothing) Or line = "" Or line = " " Or line = "  " Then
                Continue For
            End If
            line = line.Trim()
            allowedExts.Add(line)
        Next

        'create parrameter to collect information
        Dim dld As New ArrayList
        Dim ndld As New ArrayList
        Dim EventList As New ArrayList
        Dim Ex As New Exception

        If DeleteAllFileInDirectoryWithExtension(New IO.DirectoryInfo(DirLocation.Text), _
                                                 allowedExts, RecycleBinBox.Checked, _
                                                 FDel.Checked, EnableProcessFilter.Checked, _
                                                 IncSubDir2.Checked, dld, ndld, DelEmptyDir2.Checked, _
                                                 EventList, Ex) Then

        End If


        'no need to display deleted files and not dleted files...
        'all details are loged in eventlist
        'UpdateEventList(dld, True)
        'UpdateEventList(ndld, False)
        UpdateEventList(EventList, True)
        UDTabControl1.SelectedTab = UDTabPage3
    End Sub

    Private Sub RecycleBinBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecycleBinBox.Click
        If RecycleBinBox.Checked Then
            If MsgBox("Sending deleted file(s) to Recycle Bin will be a very slow process." + vbNewLine + _
                      "If error occure during file deletion, It will also prompt Error Message." + vbNewLine + _
                      "Would you like to send these file to Recycle Bin?", _
                      MsgBoxStyle.OkCancel Or MsgBoxStyle.Information, "Information") <> MsgBoxResult.Ok Then
                RecycleBinBox.Checked = False
                Return
            End If
        Else
            'do nothing 
        End If
    End Sub

#End Region

#Region "   Usefull Function   "
    'this function update EventListView
    Private Function UpdateEventList(ByVal EventList As ArrayList, ByVal ClearListview As Boolean) As Boolean
        If ClearListview Then
            EventListview.Items.Clear()
        End If

        For Each item As String In EventList
            EventListview.Items.Add(item)
        Next
    End Function

#End Region

#End Region

#Region "             NTFS security Detail                 "

#Region "Function Used in NTFS security Portion"

    Private Function RetriveFile_NTFSAccessRule(ByRef FInfo As FileInfo, Optional ByVal Exception As Exception = Nothing) As Boolean
        Try
            'Adding information in detail
            Label62.Text = "File Name"
            Label66.Text = FInfo.Name
            Label67.Text = FInfo.Attributes.ToString
            Label68.Text = FInfo.CreationTime.ToString + " */* " + FInfo.LastAccessTime.ToString
            'here check if filesystem is not NTFS then return and make NTFSTabControl Disabled

            Select Case (New DriveInfo(FInfo.FullName).DriveFormat)

                Case "NTFS"
                    Label69.Text = "File System Type is NTFS"
                    NTFSTabControl.Enabled = True

                Case "FAT32"
                    MsgBox("File System Type is FAT32", MsgBoxStyle.Exclamation)
                    Label69.Text = "File System Type is FAT32"
                    NTFSTabControl.Enabled = False
                    AccessRuleListView.Items.Clear()
                    AuditRuleListView.Items.Clear()
                    Return False
                Case Else
                    MsgBox("File System Type is not valid type.", MsgBoxStyle.Exclamation)
                    Label69.Text = "File System Type is not valid type."
                    NTFSTabControl.Enabled = False
                    AccessRuleListView.Items.Clear()
                    AuditRuleListView.Items.Clear()
                    Return False
            End Select

            'now set file name to label77 so that we can use this label to get file name
            Label77.Text = FInfo.FullName

            'now we start acces control capture
            Dim FSecurity As FileSecurity = FInfo.GetAccessControl()
            Dim Author As AuthorizationRuleCollection

            'collecting access rule
            Author = FSecurity.GetAccessRules(True, True, GetType(System.Security.Principal.NTAccount))
            'build accesslist view
            BuildAccessRuleListView(Author, AccessRuleListView)


            'again collecting AuditRule
            FSecurity = File.GetAccessControl(FInfo.FullName, AccessControlSections.Audit)
            Author = FSecurity.GetAuditRules(True, True, GetType(System.Security.Principal.NTAccount))
            'build audit rule listview
            BuildAuditRuleListView(Author, AuditRuleListView)

            'GetOwner
            Dim exs As Exception = Nothing
            If Not BuildOwnerList(FInfo.FullName, exs) Then
                MsgBox(exs.Message, MsgBoxStyle.Exclamation)
            End If

            'finaly at last return true
            Return True
        Catch ex As Exception
            Exception = ex
            Return False
        End Try

    End Function

    Private Function RetriveDirectory_NTFSAccessRule(ByRef DInfo As DirectoryInfo, _
                                                     Optional ByVal Exception As Exception = Nothing) As Boolean
        Try
            'Adding information in detail
            Label62.Text = "Folder Name"
            Label66.Text = DInfo.Name
            Label67.Text = DInfo.Attributes.ToString
            Label68.Text = DInfo.CreationTime.ToString + " */* " + DInfo.LastAccessTime.ToString

            'here check if filesystem is not NTFS then return and make NTFSTabControl Disabled

            Select Case (New DriveInfo(DInfo.FullName).DriveFormat)
                Case "NTFS"
                    Label69.Text = "File System Type is NTFS"
                    NTFSTabControl.Enabled = True

                Case "FAT32"
                    MsgBox("File System Type is FAT32", MsgBoxStyle.Exclamation)
                    Label69.Text = "File System Type is FAT32"
                    NTFSTabControl.Enabled = False
                    AccessRuleListView.Items.Clear()
                    AuditRuleListView.Items.Clear()
                    Return False
                Case Else
                    MsgBox("File System Type is not valid type.", MsgBoxStyle.Exclamation)
                    Label69.Text = "File System Type is not valid type."
                    NTFSTabControl.Enabled = False
                    AccessRuleListView.Items.Clear()
                    AuditRuleListView.Items.Clear()
                    Return False
            End Select

            Label77.Text = DInfo.FullName



            Dim DSecurity As DirectorySecurity
            Dim Author As AuthorizationRuleCollection

            ' collect Directory Access control detail in Dsecurity
            DSecurity = Directory.GetAccessControl(DInfo.FullName, AccessControlSections.Access)
            'store Access control in Author
            Author = DSecurity.GetAccessRules(True, True, GetType(System.Security.Principal.NTAccount))
            'start building list view
            BuildAccessRuleListView(Author, AccessRuleListView)


            'define Directory security audit rule
            DSecurity = Directory.GetAccessControl(DInfo.FullName, AccessControlSections.Audit)
            'again collecting AuditRule in author
            Author = DSecurity.GetAuditRules(True, True, GetType(System.Security.Principal.NTAccount))
            'now build Audit List
            BuildAuditRuleListView(Author, AuditRuleListView)


            'getowner 
            Dim exs As Exception = Nothing
            If Not BuildOwnerList(DInfo.FullName, exs) Then
                MsgBox(exs.Message, MsgBoxStyle.Exclamation)
            End If

            'finaly retrun true at the end of the success
            Return True
        Catch ex As Exception
            'return exception
            Exception = ex
            Return False
        End Try

    End Function

    'we directly send path to this function & this function deside this path is a file or folder 
    'then it create fileinfo or directoryinfo and send this info to find access rule

    Private Sub RetriveAccessRule(Optional ByVal Path As String = Nothing) ' Handles RetriveAccessRuleButton.Click
        'if function is called from other function and path is send to this function
        'LocationPathSecurity.Text is changed like sent path
        'rest function should work as it is 
        If Not Path Is Nothing Then
            LocationPathSecurity.Text = Path
        End If

        'now attempting pt perform function ACL collection.
        Try
            'if path is a file path
            If My.Computer.FileSystem.FileExists(LocationPathSecurity.Text) Then
                Dim FInfo As New FileInfo(LocationPathSecurity.Text)
                Dim ex As Exception = Nothing

                'if error occured then show detail
                If Not RetriveFile_NTFSAccessRule(FInfo, ex) Then
                    If ex IsNot Nothing Then
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                    End If
                    Return
                End If

                'if path is directory path
            ElseIf My.Computer.FileSystem.DirectoryExists(LocationPathSecurity.Text) Then

                Dim DirInfo As New DirectoryInfo(LocationPathSecurity.Text)
                Dim ex As Exception = Nothing
                'if error occured then show detail
                If Not RetriveDirectory_NTFSAccessRule(DirInfo, ex) Then
                    If ex IsNot Nothing Then
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                    End If
                    Return
                End If
            Else
                MsgBox("File/Folder is not found." + vbNewLine + _
                       "Please Check path of file/folder.", MsgBoxStyle.Exclamation)
                Return
            End If
        Catch exs As Exception
            MsgBox(exs.Message)
            Return
        End Try


    End Sub

    Private Function SetOwnerToTarget(ByVal Path As String, ByVal AccountName As String, _
                                      Optional ByRef ex As Exception = Nothing) As Boolean

        Try

            If My.Computer.FileSystem.FileExists(Path) Then

                Dim Fsecurity As New FileSecurity
                'Fsecurity.SetOwner(New NTAccount("Administrators"))
                Fsecurity.SetOwner(New NTAccount(AccountName))

                File.SetAccessControl(Path, Fsecurity)

                Return True

            ElseIf My.Computer.FileSystem.DirectoryExists(Path) Then

                Dim Dsecurity As New DirectorySecurity
                'Dsecurity.SetOwner(New NTAccount("Administrators"))
                Dsecurity.SetOwner(New NTAccount(AccountName))

                Directory.SetAccessControl(Path, Dsecurity)

                Return True

            Else
                'if path is not  valid return false
                MsgBox("Path is not valid.", MsgBoxStyle.Exclamation)
                ex = New FileNotFoundException
                Return False
            End If

        Catch ex 'As Exception
            Return False
        End Try
        'if function is successful return true
        Return True
    End Function

    'Private Function InterChangeOwner(ByVal SourcePath As String, ByVal DistinationPath As String) As Boolean
    '    Dim SourceFsecurity As FileSecurity = New FileInfo(SourcePath).GetAccessControl
    '   Dim DistinationFSecurity As FileSecurity = New FileInfo(DistinationPath).GetAccessControl
    '
    'Dim Identifier As System.Security.Principal.IdentityReference
    '   Identifier = SourceFsecurity.GetOwner(GetType(System.Security.Principal.NTAccount))
    '  DistinationFSecurity.SetOwner(Identifier)
    'End Function

#End Region


#Region "Build Lists"

    Private Sub BuildAccessRuleListView(ByVal Author As AuthorizationRuleCollection, ByRef LView As ListView)
        If Author.Count <= 0 Then
            MsgBox("Access Rules for This Target is not found.")
            LView.Items.Clear()
            Return
        End If

        'Clearing list view
        LView.Items.Clear()


        'now adding AccessRule in listview
        For Each Item As FileSystemAccessRule In Author
            Dim LvItem As New ListViewItem
            LvItem.Text = Item.AccessControlType.ToString()
            LvItem.SubItems.Add(Item.IdentityReference.Value)
            LvItem.SubItems.Add(Item.InheritanceFlags.ToString())
            LvItem.SubItems.Add(Item.IsInherited.ToString())
            LvItem.SubItems.Add(Item.PropagationFlags.ToString())
            LvItem.SubItems.Add(Item.FileSystemRights.ToString())
            LView.Items.Add(LvItem)
        Next

    End Sub

    Private Sub BuildAuditRuleListView(ByVal Author As AuthorizationRuleCollection, ByRef LView As ListView)
        If Author.Count <= 0 Then
            MsgBox("Audit Policy for This Target is not found.")
        End If

        'Clearing list view
        LView.Items.Clear()
        For Each Item As FileSystemAuditRule In Author

            Dim LVItem As New ListViewItem
            LVItem.Text = Item.AuditFlags.ToString()

            LVItem.SubItems.Add(Item.IdentityReference.Value)
            LVItem.SubItems.Add(Item.InheritanceFlags.ToString())
            LVItem.SubItems.Add(Item.IsInherited.ToString())
            LVItem.SubItems.Add(Item.PropagationFlags.ToString())
            LVItem.SubItems.Add(Item.FileSystemRights.ToString())
            LView.Items.Add(LVItem)
        Next

    End Sub

    'In this section if owner is not legal then it throws an exception that all or some identity 
    'reference could not recognized. 

    Private Function BuildOwnerList(ByVal path As String, Optional ByRef ex As Exception = Nothing) As Boolean
        Try

            '        Dim Author As AuthorizationRuleCollection = Nothing
            Dim CurrentOwner As String = ""
            If My.Computer.FileSystem.FileExists(path) Then
                Dim Fsecurity As FileSecurity = Nothing
                Fsecurity = New FileInfo(path).GetAccessControl
                CurrentOwner = Fsecurity.GetOwner(GetType(System.Security.Principal.NTAccount)).Value.ToString

            ElseIf My.Computer.FileSystem.DirectoryExists(path) Then
                Dim Dsecurity As DirectorySecurity = Nothing
                Dsecurity = New DirectoryInfo(path).GetAccessControl
                CurrentOwner = Dsecurity.GetOwner(GetType(System.Security.Principal.NTAccount)).Value.ToString
            Else
                ex = New FileNotFoundException
                MsgBox("Path is not valid.", MsgBoxStyle.Exclamation)
                Return False
            End If

            Try
                Dim CountNum As New ArrayList
                CountNum.AddRange(CurrentOwner.Split("\"))
                If CountNum.Count < 2 Then
                    Label88.Text = CurrentOwner
                Else
                    Label88.Text = CurrentOwner.Split("\")(0).Trim
                    Label83.Text = CurrentOwner.Split("\")(1).Trim
                End If
            Catch 'ex1 As Exception
                MsgBox("Unable to Find Owner Name", MsgBoxStyle.Exclamation)
            End Try





            'we removed this section because i saw that in both XP and Vista there are only two Account as aplicable user
            '"Adminisrators" and  that User which is loged On

            'So I am adding these both account name permanently

            'now we will add an other Possible owner in comobox dropdownlist

            OwnerComboBox.Items.Clear()
            OwnerComboBox.Text = "" 'CurrentOwner
            OwnerComboBox.Items.Add(Label83.Text)
            OwnerComboBox.Items.Add("Administrators")
            Return True
        Catch ex
            'if exception is occured due to invalid Owner name 
            'then we only add two possible owner in the list
            'for this we first retrive Domain name 
            'MsgBox(My.Computer.Name.ToString())
            ' Label88.Text = "-----------"
            ' Label83.Text = "-----------"

            OwnerComboBox.Items.Clear()
            OwnerComboBox.Text = ""
            OwnerComboBox.Items.Add(Label83.Text)
            OwnerComboBox.Items.Add("Administrators")
            '
            Return False
        End Try



    End Function

#End Region


#Region "Form and control Event"
    'kewdown function for textbox
    Private Sub LocationPathSecurity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LocationPathSecurity.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                RetriveAccessRule()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub FileFolderBr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileFolderBr.Click
        'Check If file raio button is checked
        If FileRadioButton.Checked Then
            ' now open file with  openfiledialog
            Dim OpenFileDialog As New OpenFileDialog
            OpenFileDialog.InitialDirectory = System.Environment.SpecialFolder.Desktop
            OpenFileDialog.Multiselect = False
            OpenFileDialog.Filter = "All files (*.*)|*.*|Executable files (*.exe)|*.exe|DLL files (*.dll)|*.dll"

            'if we are not selection any file then return
            If Not OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Return
            End If

            'if selected path is not a file or incorrect path then return
            If Not My.Computer.FileSystem.FileExists(OpenFileDialog.FileName) Then
                MsgBox("File does not Exist.")
                Return
            End If

            LocationPathSecurity.Text = OpenFileDialog.FileName
            Dim FInfo As New FileInfo(OpenFileDialog.FileName)
            Dim ex As Exception = Nothing

            'if error occured then show detail
            If Not RetriveFile_NTFSAccessRule(FInfo, ex) Then
                If ex IsNot Nothing Then
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                    Return
                End If
            End If

        Else
            'now we are searching for folder with folderBrowser

            'if folder is not  selected then 
            Dim FolderBrowserDialog As New FolderBrowserDialog
            If Not FolderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Return
            End If

            'if selected item is not an directory or do not exist
            If Not My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog.SelectedPath) Then
                Return
            End If

            LocationPathSecurity.Text = FolderBrowserDialog.SelectedPath
            Dim DirInfo As New DirectoryInfo(FolderBrowserDialog.SelectedPath)
            Dim ex As Exception = Nothing

            'if error occured then show detail
            If Not RetriveDirectory_NTFSAccessRule(DirInfo, ex) Then
                If ex IsNot Nothing Then
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                    Return
                End If
            End If

        End If
    End Sub

    'Used to retrive AccessRules of a target
    Private Sub RetriveAccessRuleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetriveAccessRuleButton.Click
        RetriveAccessRule()
    End Sub

    'directly add full control to target
    Private Sub GetFullControlButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetFullControlButton.Click

        If TextBoxIsIdle(LocationPathSecurity, True) Then Return


        Try
            If My.Computer.FileSystem.FileExists(Label77.Text) Then
                ' it is a file
                AddFullcontrolToFile(Label77.Text)
                MsgBox("Successfull Added access control entry for " + vbNewLine + Label77.Text)

            ElseIf My.Computer.FileSystem.DirectoryExists(Label77.Text) Then
                'it is a directory
                AddFullControlToDirectory(Label77.Text)
                MsgBox("Successfull Added access control entry for " + vbNewLine + Label77.Text)
            Else
                'error
                'either path is not present or file or folder is delted or moved
                MsgBox("File Or Folder Not found." + vbNewLine + "(Target is moved or deleted.)")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            'rescan target
            RetriveAccessRule(Label77.Text)
        End Try

    End Sub

    Private Sub RemoveFullControlButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFullControlButton.Click
        Try
            If My.Computer.FileSystem.FileExists(Label77.Text) Then
                ' it is a file
                RemoveFullControlToFile(Label77.Text)
                MsgBox("Successfull Removed Full access control entry for " + vbNewLine + Label77.Text)

            ElseIf My.Computer.FileSystem.DirectoryExists(Label77.Text) Then
                'it is a directory
                RemoveFullControlToDirectory(Label77.Text)
                MsgBox("Successfull Removed  Full access control entry for " + vbNewLine + Label77.Text)
            Else
                'error
                'either path is not present or file or folder is delted or moved
                MsgBox("File Or Folder Not found." + vbNewLine + "(Target is moved or deleted.)")
                'i added this return because there is no need to scan file ACL again
                'Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            'rescan target
            RetriveAccessRule(Label77.Text)
        End Try
    End Sub

    Private Sub OwnerApplyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OwnerApplyButton.Click

        'here we Take path from Label77.text
        'and accountName form comboBox

        'Check if ComboBox Text is Exist in Contents
        Select Case OwnerComboBox.Text.ToUpper
            Case "Administrators".ToUpper
                Exit Select

                'this will produce error
                'Case My.User.Name.ToString.Split("\")(1).Trim.ToUpper
                '   Exit Select

            Case Else
                If MsgBox("Not an applicable User Name." + vbNewLine + "Would you Like to Use this User Name ?", _
                       MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo, "Confirmation ") = MsgBoxResult.Yes Then
                    Exit Select
                End If
                Exit Sub
        End Select


        Dim ex As New Exception
        If Not SetOwnerToTarget(Label77.Text, OwnerComboBox.Text, ex) Then
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Else
            If Not BuildOwnerList(Label77.Text, ex) Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End If
        End If

    End Sub

#End Region

#End Region

#End Region

#Region "        Unlocker Tab Page events   "

    Private Sub UnlockerGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnlockerGo.Click

        'we are adding this sender.name because context menu of Lodule list is also using this function
        If (sender Is UnlockerGo) And TextBoxIsIdle(ModuleAbsolutePathBox) Then Return

        If Not File_Exists(ModuleAbsolutePathBox.Text) Then Return

        ProcessListOfModule.Items.Clear()

        'Dim owatch As New Stopwatch
        'owatch.Start()

        'collection all running process
        For Each p As Process In Process.GetProcesses
            'this try is added because critical process creates bug
            Try
                'collecting all modules of this process
                For Each itm As System.Diagnostics.ProcessModule In p.Modules
                    'compare this module to reference module
                    If itm.FileName.ToLower = ModuleAbsolutePathBox.Text.ToLower Then
                        Dim LVItem As New ListViewItem
                        LVItem.Text = p.ProcessName
                        LVItem.SubItems.Add(p.Id.ToString)
                        LVItem.SubItems.Add(p.MainModule.FileName)
                        LVItem.SubItems.Add(itm.BaseAddress.ToString)
                        LVItem.ImageKey = p.Id.ToString
                        ProcessListOfModule.Items.Add(LVItem)

                        'ProcessListOfModule.Items.Add(p.ProcessName)
                        'ProcessListOfModule.Items(ProcessListOfModule.Items.Count - 1).SubItems.Add(p.Id.ToString)
                        'ProcessListOfModule.Items(ProcessListOfModule.Items.Count - 1).SubItems.Add(p.MainModule.FileName)
                        'ProcessListOfModule.Items(ProcessListOfModule.Items.Count - 1).ImageKey = p.Id.ToString
                        'ProcessListOfModule.Items(ProcessListOfModule.Items.Count - 1).SubItems.Add(itm.BaseAddress.ToString)
                        Exit For
                    End If
                Next
            Catch ex As Exception
                'do nothing
            End Try
        Next

        'ProcessListOfModule.Sorting = SortOrder.Ascending
        'ProcessListOfModule.Sorting = SortOrder.None

        'owatch.Stop()
        'MsgBox(owatch.ElapsedMilliseconds.ToString)

    End Sub

    Private Sub Unlockerbrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Unlockerbrowse.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = System.Environment.SpecialFolder.Desktop
        OpenFileDialog.Filter = _
        "DLL files (*.dll)|*.dll|Executable files (*.exe)|*.exe|ActiveX Control files (*.ocx)|*.ocx|All files (*.*)|*.*"
        OpenFileDialog.Multiselect = False
        OpenFileDialog.FileName = ""
        If OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ModuleAbsolutePathBox.Text = OpenFileDialog.FileName
            If Not My.Computer.FileSystem.FileExists(ModuleAbsolutePathBox.Text) Then
                Return
            End If

            'now scan this module
            UnlockerGo_Click(Nothing, Nothing)
        End If

    End Sub

    Private Sub ProcessListOfModule_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProcessListOfModule.DoubleClick
        Try
            MainTabControl.SelectedTab = ProcessDetailPage
            TabControl1.SelectedTab = TP1
            NameLable.Text = ProcessListOfModule.Items(ProcessListOfModule.SelectedIndices(0)).SubItems(0).Text
            IdLable.Text = ProcessListOfModule.Items(ProcessListOfModule.SelectedIndices(0)).SubItems(1).Text
            PathLable.Text = ProcessListOfModule.Items(ProcessListOfModule.SelectedIndices(0)).SubItems(2).Text

            'Dim modItems As ArrayList = GetProcessModule(ProcessModuleList.Items(ProcessModuleList.SelectedIndices(0)).SubItems(1).Text)
            'Building ModuleList
            BuildModuleList(GetProcessModule(ProcessListOfModule.Items(ProcessListOfModule.SelectedIndices(0)).SubItems(1).Text), ModuleList)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

#Region "      Unlocker Context menu    "

    Private Sub LocateThisProcessInProcessListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocateThisProcessInProcessListToolStripMenuItem.Click

        If ListViewIsEmptyOrNotSelected(ProcessListOfModule) Then Return


        Dim processid As String
        'processid = ProTree.SelectedNode.Text
        processid = ProcessListOfModule.Items(ProcessListOfModule.SelectedIndices(0)).SubItems(1).Text
        'MsgBox(processid)

        'scaning the current process in list 2
        For Each item As ListViewItem In ListView2.Items
            If processid = item.SubItems(1).Text Then
                'Opening page
                Me.MainTabControl.SelectedTab = ProcessDetailPage
                Me.TabControl1.SelectedTab = Tp0
                'Selecting item
                item.Selected = True
                item.EnsureVisible()
                Exit Sub
            End If
        Next


        'here means that function did not find this process in process list
        MsgBox("Process is not present in Process list.", MsgBoxStyle.Exclamation)
        'removing Entry
        ProcessListOfModule.Items(ProcessListOfModule.SelectedIndices(0)).Remove()

    End Sub

    Private Sub GetProToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetProToolStripMenuItem.Click
        'ProcessListOfModule
        If ListViewIsEmptyOrNotSelected(ProcessListOfModule) Then Return

        '
        If Not My.Computer.FileSystem.FileExists _
        (ProcessListOfModule.Items(ProcessListOfModule.SelectedIndices(0)).SubItems(2).Text) Then
            MsgBox("Process File Path not detected.", MsgBoxStyle.Exclamation)
        End If

        Try
            win32.PropertyShow.ShowProperties(ProcessListOfModule.Items(ProcessListOfModule.SelectedIndices(0)).SubItems(2).Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ReleseCurrentModuleFromThisProcessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReleseCurrentModuleFromThisProcessToolStripMenuItem.Click


        If ListViewIsEmptyOrNotSelected(ProcessListOfModule) Then Return


        Dim P As Process = Diagnostics.Process.GetProcessById( _
        ProcessListOfModule.Items(ProcessListOfModule.SelectedIndices(0)).SubItems(1).Text)


        For Each moduleitem As System.Diagnostics.ProcessModule In P.Modules

            If moduleitem.FileName.ToLower = ModuleAbsolutePathBox.Text.ToLower Then

                If UnLoadModuleFromProcess(P.Id, moduleitem.BaseAddress) = 0 Then
                    ProcessListOfModule.Items(ProcessListOfModule.SelectedIndices(0)).Remove()
                Else
                    MsgBox("Not Released From :" + P.ProcessName, MsgBoxStyle.Exclamation)
                End If
            End If

        Next

    End Sub

    Private Sub KillProcessToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KillProcessToolStripMenuItem1.Click


        If ListViewIsEmptyOrNotSelected(ProcessListOfModule) Then Return


        Try
            Dim Eventlist As ArrayList
            Eventlist = New ArrayList
            Eventlist.Clear()

            'return 0 if process not terminated and file not deleted.
            'return 1 if process trminated but file is not deleted
            'return 2 if process terinated and file deleted.
            'return -1 if process do not exist
            'return -2 if process is dangerous
            'return -3 if exception in process termination

            ' Sending id to kill process
            Select Case killProcessById(ProcessListOfModule.Items(ProcessListOfModule.SelectedIndices(0)).SubItems(1).Text, _
                                        False, EnableProcessFilter.Checked, Eventlist)

                Case -1
                    MsgBox("Process do not Exist.", MsgBoxStyle.Exclamation)
                    ProcessListOfModule.Items(ProcessListOfModule.SelectedIndices(0)).Remove()
                    Exit Select
                Case -2
                    MsgBox("Process is dangerous.", MsgBoxStyle.Exclamation)
                    Exit Select
                Case -3
                    MsgBox("Exception during process termination.", MsgBoxStyle.Exclamation)
                    Exit Select
                Case 1
                    MsgBox("Process terminated.", MsgBoxStyle.Information)
                    ProcessListOfModule.Items(ProcessListOfModule.SelectedIndices(0)).Remove()
                    Exit Select
            End Select


            If CheckBox7.Checked = True Then
                For Each item As String In Eventlist
                    MainTabControl.SelectedTab = ProcessDetailPage
                    TabControl1.SelectedTab = TP3
                    KillEventListBox.Focus()
                    KillEventListBox.Items.Add(item.ToString)
                    KillEventListBox.SelectedIndex = KillEventListBox.Items.Count - 1
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub KillProcessAndDeleteParentFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KillProcessAndDeleteParentFileToolStripMenuItem.Click


        If ListViewIsEmptyOrNotSelected(ProcessListOfModule) Then Return


        'Confirm that user want to delete file or not 
        Dim delFile As Boolean = False
        If (MsgBox("Do you really want to delete process file?", MsgBoxStyle.YesNo Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            delFile = True
        End If

        Try
            Dim Eventlist As ArrayList
            Eventlist = New ArrayList
            Eventlist.Clear()

            ' Sending id to kill process
            Select Case killProcessById(ProcessListOfModule.Items(ProcessListOfModule.SelectedIndices(0)).SubItems(1).Text, _
                                        delFile, EnableProcessFilter.Checked, Eventlist)
                Case -1
                    MsgBox("Process do not Exist.", MsgBoxStyle.Exclamation)
                    ProcessListOfModule.Items(ProcessListOfModule.SelectedIndices(0)).Remove()
                    Exit Select
                Case -2
                    MsgBox("Process is dangerous.", MsgBoxStyle.Exclamation)
                    Exit Select
                Case -3
                    MsgBox("Exception during process termination.", MsgBoxStyle.Exclamation)
                    Exit Select
                Case 1
                    ProcessListOfModule.Items(ProcessListOfModule.SelectedIndices(0)).Remove()
                    If delFile Then
                        MsgBox("process terminated but Failed to delete file.", MsgBoxStyle.Exclamation)
                    Else
                        MsgBox("process terminated but File deletion is skipped by User.", _
                               MsgBoxStyle.Information)
                    End If
                    Exit Select
                Case 2
                    ProcessListOfModule.Items(ProcessListOfModule.SelectedIndices(0)).Remove()
                    MsgBox("Process terminated and file deleted.", MsgBoxStyle.Information)
                    Exit Select
            End Select



            If CheckBox7.Checked = True Then
                For Each item As String In Eventlist
                    MainTabControl.SelectedTab = ProcessDetailPage
                    TabControl1.SelectedTab = TP3
                    KillEventListBox.Focus()
                    KillEventListBox.Items.Add(item.ToString)
                    KillEventListBox.SelectedIndex = KillEventListBox.Items.Count - 1
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub GetRelatedProcessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetRelatedProcessToolStripMenuItem.Click


        If ListViewIsEmptyOrNotSelected(ProcessListOfModule) Then Return


        Try
            Me.MainTabControl.SelectedTab = ProcessDetailPage
            Me.TabControl1.SelectedTab = TP1
            NameLable.Text = ProcessListOfModule.Items(ProcessListOfModule.SelectedIndices(0)).SubItems(0).Text
            IdLable.Text = ProcessListOfModule.Items(ProcessListOfModule.SelectedIndices(0)).SubItems(1).Text
            PathLable.Text = ProcessListOfModule.Items(ProcessListOfModule.SelectedIndices(0)).SubItems(2).Text

            'Dim modItems As ArrayList = GetProcessModule(ProcessListOfModule.Items(ProcessListOfModule.SelectedIndices(0)).SubItems(1).Text)
            'Building ModuleList
            BuildModuleList(GetProcessModule _
                            (ProcessListOfModule.Items(ProcessListOfModule.SelectedIndices(0)).SubItems(1).Text), ModuleList)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ReleaseModuleFromAllProcessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReleaseModuleFromAllProcessToolStripMenuItem.Click

        If ListViewIsEmptyOrNotSelected(ProcessListOfModule) Then Return


        If MsgBox("Do you really want to unlock this Module from all process in list ?", _
                  MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Confirmation") <> MsgBoxResult.Yes Then
            Return
        End If

        Dim i As Integer = ProcessListOfModule.Items.Count - 1
        Dim j As Integer
        For j = i To 0 Step -1

            Dim P As Process = Diagnostics.Process.GetProcessById( _
            ProcessListOfModule.Items(j).SubItems(1).Text)
            For Each moduleitem As System.Diagnostics.ProcessModule In P.Modules
                If moduleitem.FileName.ToLower = ModuleAbsolutePathBox.Text.ToLower Then
                    If UnLoadModuleFromProcess(P.Id, moduleitem.BaseAddress) = 0 Then
                        ProcessListOfModule.Items(j).Remove()
                    Else
                        MsgBox("Not Released From :" + P.ProcessName, MsgBoxStyle.Exclamation)
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub ReleaseDeleteModuleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReleaseDeleteModuleToolStripMenuItem.Click

        'module ig going to released from all process
        If EmptyListView(ProcessListOfModule) Then Return


        'attempt to delete if list is Empty 
        If ProcessListOfModule.Items.Count <= 0 Then
            If My.Computer.FileSystem.FileExists(ModuleAbsolutePathBox.Text) Then
                Try
                    My.Computer.FileSystem.DeleteFile(ModuleAbsolutePathBox.Text)
                    ModuleAbsolutePathBox.Text = ""
                    MsgBox("Successfully deleted.", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("File : " + ModuleAbsolutePathBox.Text + " Not Found .", MsgBoxStyle.Exclamation)
                ModuleAbsolutePathBox.Text = ""
            End If
            Return
        End If

        'release for listed process
        Dim i As Integer = ProcessListOfModule.Items.Count - 1
        Dim j As Integer
        For j = i To 0 Step -1

            Dim P As Process = Diagnostics.Process.GetProcessById( _
            ProcessListOfModule.Items(j).SubItems(1).Text)
            For Each moduleitem As System.Diagnostics.ProcessModule In P.Modules
                If moduleitem.FileName.ToLower = ModuleAbsolutePathBox.Text.ToLower Then
                    If UnLoadModuleFromProcess(P.Id, moduleitem.BaseAddress) = 0 Then
                        ProcessListOfModule.Items(j).Remove()
                    Else
                        MsgBox("Not Released From :" + P.ProcessName, MsgBoxStyle.Exclamation)
                    End If
                End If
            Next
        Next

        'Attempt to delete
        If My.Computer.FileSystem.FileExists(ModuleAbsolutePathBox.Text) Then
            Try
                My.Computer.FileSystem.DeleteFile(ModuleAbsolutePathBox.Text)
                ModuleAbsolutePathBox.Text = ""
                MsgBox("Successfully deleted.")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        Else
            MsgBox("File : " + ModuleAbsolutePathBox.Text + " Not Found .")
            ModuleAbsolutePathBox.Text = ""
        End If
    End Sub

    Private Sub OpenLocationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenLocationToolStripMenuItem.Click

        If ListViewIsEmptyOrNotSelected(ProcessListOfModule) Then Return

        Try
            System.Diagnostics.Process.Start(My.Computer.FileSystem.GetParentPath _
                                                 (ProcessListOfModule.Items(ProcessListOfModule.SelectedIndices(0)).SubItems(2).Text))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

#End Region


#End Region

#Region "             Other tool page event"

#Region "new process events"
    Private Sub BrowseTask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseTask.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = System.Environment.SpecialFolder.Desktop
        OpenFileDialog.Filter = "Program files (*.exe)|*.exe|All files (*.*)|*.*"
        OpenFileDialog.Multiselect = False
        OpenFileDialog.FileName = ""
        If OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            TaskTabBox.Text = OpenFileDialog.FileName.ToString
        End If

    End Sub

    Private Sub RunTask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunTask.Click

        If TextBoxIsIdle(TaskTabBox) Then Return

        Try
            System.Diagnostics.Process.Start(TaskTabBox.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TaskTabBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TaskTabBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                System.Diagnostics.Process.Start(TaskTabBox.Text)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
#End Region


    Private Sub RenameIEButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenameIEButton.Click

        Try
            Dim results As String = Nothing
            results = InputBox("Enter text you want to add in Internet Explorer Title Bar", "Rename Internet Explorer Title Bar", Nothing)

            If results = Nothing Then
                Return
            End If

            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main", "Window Title", results)
            If MsgBox("Open InternetExplorer to confirm the action." + vbNewLine + _
                   "Would you like to open Internet explorer.?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Renamed") = MsgBoxResult.Yes Then
                Try
                    Process.Start("iexplore")
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, Nothing, False)
        End Try
    End Sub

    Private Sub CButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandPromptButton.Click
        Try
            'CMD Key
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\System", "DisableCMD", 0) Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\System", "DisableCMD", 0)
            End If

            Dim cmd As New ProcessStartInfo("CMD.EXE")
            cmd.WindowStyle = ProcessWindowStyle.Normal
            cmd.WorkingDirectory = "C:\"
            System.Diagnostics.Process.Start(cmd)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub

    Private Sub CButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DXDiagButton.Click
        Try
            Dim dx As New ProcessStartInfo("dxdiag.exe")
            dx.WindowStyle = ProcessWindowStyle.Normal
            Diagnostics.Process.Start(dx)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation, _
                            MessageBoxDefaultButton.Button1, Nothing, False)
        End Try

    End Sub

    Private Sub CButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSInfoButton.Click
        Try
            Dim MSinfo As New ProcessStartInfo("MSinfo32.exe")
            MSinfo.WindowStyle = ProcessWindowStyle.Normal
            Diagnostics.Process.Start(MSinfo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation, _
                            MessageBoxDefaultButton.Button1, Nothing, False)
        End Try
    End Sub

    'Show Process Command line
    Private Sub CButton23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessCommandLine.Click
        Try
            Shell("wmic /output:c:\ProcessCommandLine.txt process get Caption,CommandLine,executablepath,processid", _
                                    AppWinStyle.NormalFocus, True)
            System.Diagnostics.Process.Start("c:\ProcessCommandLine.txt")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideDriveButton.Click
        HideDriveMainForm.Show()
    End Sub

    Private Sub WCleanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WCleanButton.Click
        WindowCleanerForm.Show()
    End Sub

    Private Sub FileProtectorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileProtectorButton.Click
        FileProtectorMainForm.Show()
    End Sub

#End Region

#Region "          Option tab page event  "

    Private Sub AddStartup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStartup.Click
        On Error Resume Next
        Dim Regkey As Microsoft.Win32.RegistryKey
        Dim RegPath As String

        Regkey = My.Computer.Registry.CurrentUser
        RegPath = "Software\Microsoft\Windows\CurrentVersion\Run"
        Regkey = Regkey.OpenSubKey(RegPath, True)

        If AddStartup.Checked = True Then
            Regkey.SetValue("Virus Effect Remover", My.Application.Info.DirectoryPath + "\Virus Effect Remover.exe")
        Else
            Regkey.DeleteValue("Virus Effect Remover")
        End If
        Regkey.Close()
    End Sub

    Private Sub Help_box_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Help_box.Click
        My.Computer.Registry.SetValue(VERKey, "DontAllowHelp", Help_box.Checked, RegistryValueKind.DWord)
        EnglishToolTip.Active = Not Help_box.Checked
    End Sub

    Private Sub DisableExitDialog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisableExitDialog.Click
        My.Computer.Registry.SetValue(VERKey, "DisableExitDialog", DisableExitDialog.Checked, RegistryValueKind.DWord)
    End Sub

    Private Sub IGN_CDROM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IGN_CDROM.Click
        My.Computer.Registry.SetValue(VERKey, "IGN_CDROM", IGN_CDROM.Checked, RegistryValueKind.DWord)
        find_auroruninf()
    End Sub

    Private Sub send2tray_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles send2tray.Click
        My.Computer.Registry.SetValue(VERKey, "SendToTray", send2tray.Checked, RegistryValueKind.DWord)
    End Sub

    Private Sub ScanTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScanTime.CheckedChanged
        TrackBar2.Visible = ScanTime.Checked
    End Sub

    Private Sub TrackBar2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar2.Scroll
        Try
            NotifyIconTimer.Interval = TrackBar2.Value * 1000
            Label63.Text = (NotifyIconTimer.Interval / 1000).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        ProTreeTimer.Interval = TrackBar1.Value * 1000
        Label61.Text = (ProTreeTimer.Interval / 1000).ToString

    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked Then
            TrackBar1.Visible = True
        Else
            TrackBar1.Visible = False
        End If
    End Sub

    Private Sub EnableProcessFilter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableProcessFilter.CheckedChanged
        If EnableProcessFilter.Checked = False Then
            If MsgBox(My.Resources.EngResource.msgEnableProcessFilter, _
                      MsgBoxStyle.YesNo Or MsgBoxStyle.Information Or MsgBoxStyle.DefaultButton2, _
                      "Confirmation") = MsgBoxResult.Yes Then
                'do nothing
            Else
                EnableProcessFilter.Checked = True
            End If
        End If
    End Sub

#Region "  Theme  "
    Private Sub BlueTheme_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BlueTheme.Click
        My.Computer.Registry.SetValue(VERKey, "Theme", "BlueTheme", RegistryValueKind.String)
        SetTheme(My.Resources.Health_care_shield_6)
    End Sub

    Private Sub GreenTheme_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GreenTheme.Click
        My.Computer.Registry.SetValue(VERKey, "Theme", "GreenTheme", RegistryValueKind.String)
        SetTheme(My.Resources.tick_16)
    End Sub

    Private Sub RedTheme_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RedTheme.Click
        My.Computer.Registry.SetValue(VERKey, "Theme", "RedTheme", RegistryValueKind.String)
        SetTheme(My.Resources.Red_16)
    End Sub
#End Region

#End Region


#End Region

#Region "            Notify icon event         "

    Private Sub NotifyIconTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotifyIconTimer.Tick
        On Error Resume Next
        Dim regerror As Boolean
        Dim autorunerror As Boolean

        'here ScanAutorun is a dummy of Find_autoruninf() function which only scan autirun.inf file 
        '
        If Not (ScanAutorun() Or RefreshRegSatus()) Then
            'if system is ok we will return form here
            Return
        End If
        '
        'error found so scaning complete system.
        '
        regerror = RefreshRegSatus()
        infobox.Text += EngResource.Seperator
        autorunerror = find_auroruninf()


        If autorunerror = True Or regerror = True Then
            Me.Show()
            NotifyIcon1.Visible = False
            'there is no need to refresh pro tree when program is hidden
            ProTreeTimer.Start()
            NotifyIconTimer.Enabled = False
            Return
        End If


    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        NotifyIcon1.Visible = False
        NotifyIconTimer.Enabled = False
        'there is no need to refresh pro tree when program is hidden
        ProTreeTimer.Start()

        RefreshRegSatus()
        infobox.Text += EngResource.Seperator  'vbNewLine + "---------------------------------------------------------------------" + vbNewLine
        find_auroruninf()
    End Sub

    Private Sub StartTimerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartTimerToolStripMenuItem.Click
        If NotifyIconTimer.Enabled = False Then
            NotifyIconTimer.Enabled = True
            Dim str = NotifyIcon1.BalloonTipText
            NotifyIcon1.BalloonTipText = "Timer is started."
            NotifyIcon1.ShowBalloonTip(500)
            NotifyIcon1.BalloonTipText = str
        Else
            Dim str = NotifyIcon1.BalloonTipText
            NotifyIcon1.BalloonTipText = "Timer is already running."
            NotifyIcon1.ShowBalloonTip(500)
            NotifyIcon1.BalloonTipText = str
        End If
    End Sub

    Private Sub StopTimerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopTimerToolStripMenuItem.Click
        If NotifyIconTimer.Enabled = True Then
            NotifyIconTimer.Enabled = False
            Dim str = NotifyIcon1.BalloonTipText
            NotifyIcon1.BalloonTipText = "Timer is stopped"
            NotifyIcon1.ShowBalloonTip(500)
            NotifyIcon1.BalloonTipText = str
        Else
            Dim str = NotifyIcon1.BalloonTipText
            NotifyIcon1.BalloonTipText = "Timer is already stopped."
            NotifyIcon1.ShowBalloonTip(500)
            NotifyIcon1.BalloonTipText = str
        End If
    End Sub

    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click
        Me.Show()
        NotifyIcon1.Visible = False
        ProTreeTimer.Start()
        NotifyIconTimer.Enabled = False
    End Sub

    Private Sub ScanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScanToolStripMenuItem.Click
        On Error Resume Next
        Dim regerror As Boolean
        Dim autorunerror As Boolean

        'here ScanAutorun is a dummy of Find_autoruninf() function which only scan autirun.inf file 
        '
        If Not (ScanAutorun() Or RefreshRegSatus()) Then
            Return
        End If
        '
        'error found so scaning caomplete system.
        '
        regerror = RefreshRegSatus()
        infobox.Text += EngResource.Seperator 'vbNewLine + "---------------------------------------------------------------------" + vbNewLine
        autorunerror = find_auroruninf()


        If autorunerror = True Or regerror = True Then
            Me.Show()
            NotifyIcon1.Visible = False
            'there is no need to refresh pro tree when program is hidden
            ProTreeTimer.Start()
            NotifyIconTimer.Enabled = False
            Return
        End If

    End Sub


#End Region

#Region "        Process Tree Work procedure   "


    Private Function AddNodeNameRefresh(ByVal MainNOde As TreeNode, ByVal PID As Integer, ByVal PPID As Integer, ByVal PName As String, ByVal PPath As String) As Boolean
        'Addin child if main node is Parent Process

        'Getting Pid Value Of Main Node which is added Just After "*"
        Dim Str As String = MainNOde.Text.Split("*")(1)

        'Check if Main Node For same Node
        'This Used in treeview Root node because root node add itself again and again
        If Str = PID.ToString Then
            Return True
        End If


        'Comparing this id to The Parent id of retrived process
        If Str = PPID.ToString Then
            'Check For Existance
            For Each CNode As TreeNode In MainNOde.Nodes
                If CNode.Text.Split("*")(1) = PID.ToString Then
                    Return True
                End If
            Next
            'Set the Imagelist Icon
            'ImageList2.Images.Add(PID.ToString, GetICON.GetFileIcon(PPath, 1).ToBitmap)
            Try
                For Each key In ImageList2.Images.Keys
                    If key = PID.ToString Then
                        Exit Try
                    End If
                Next
                ImageList2.Images.Add(PID.ToString, GetICON.GetFileIcon(PPath, 1).ToBitmap)
                ' EventCollectionSub("Image added to imglist2. : no. of image in list =" + ImageList2.Images.Count.ToString)
            Catch
                'Do nothing
            End Try

            Dim Item1 As TreeNode = MainNOde.Nodes.Add(PName + "     *" + PID.ToString)
            '.ImageKey = PID.ToString
            Item1.ImageKey = PID.ToString
            Item1.ToolTipText = PPath

            Return True
        End If


        'Scaning Main node for Sub Node
        For Each CNode As TreeNode In MainNOde.Nodes
            'Getting child pid from its text
            Str = CNode.Text.Split("*")(1)
            If Str = PPID.ToString Then

                'NOw parent find Search for Already added
                For Each CCNode As TreeNode In CNode.Nodes
                    If CCNode.Text.Split("*")(1) = PID.ToString Then
                        Return True
                    End If
                Next
                'Not Added then Add
                'ImageList2.Images.Add(PID.ToString, GetICON.GetFileIcon(PPath, 1).ToBitmap)

                Try
                    For Each key In ImageList2.Images.Keys
                        If key = PID.ToString Then
                            Exit Try
                        End If
                    Next
                    ImageList2.Images.Add(PID.ToString, GetICON.GetFileIcon(PPath, 1).ToBitmap)
                    'EventCollectionSub("Image added to imglist2. : no. of image in list =" + ImageList2.Images.Count.ToString)
                Catch
                    'do nothing
                End Try

                Dim Item1 As TreeNode = CNode.Nodes.Add(PName + "     *" + PID.ToString)
                '.ImageKey = PID.ToString
                Item1.ImageKey = PID.ToString
                Item1.ToolTipText = PPath

                Return True
            Else
                'This is used to skip all recurtion  telling continously that 
                'The pid is added to List
                If AddNodeNameRefresh(CNode, PID, PPID, PName, PPath) Then
                    Return True
                End If
            End If
        Next
        Return False
    End Function

    'this function is used to remove the process which is terminated 
    Private Function DelNode(ByVal TNode As TreeNode, ByVal IDList As ArrayList) As Boolean

        Dim Pid As String = TNode.Text.Split("*")(1)

        For Each Id In IDList
            If Id.ToString = Pid Then
                'Found 
                'then again search for its child node
                For Each Node As TreeNode In TNode.Nodes
                    'again call the same function 
                    DelNode(Node, IDList)
                Next
                'it return true for all those process who is running at current time 
                Return True
            End If
        Next

        'Not Found then remove this process from list and image from its image list 
        'ImageList2.Images.RemoveByKey(Pid)
        'EventCollectionSub("Node removed from protree.  :" + TNode.Text)
        TNode.Remove()


        'For Each item As ListViewItem In ListView2.Items
        'If item.SubItems(1).Text = Pid Then
        'item.Remove()
        ' sortlistview()
        ' Exit For
        'End If
        'Next
        Return False
    End Function

    Private Sub DelItemInListView2(ByVal LVCollect As ArrayList, ByVal PIDList As ArrayList)

        For Each item3 As ListViewItem In LVCollect
            'scaning this item in to present process list
            For Each item4 In PIDList
                If item4.ToString = item3.SubItems(1).Text Then
                    'do not remove this row of listview2
                    GoTo lst1
                End If
            Next
            ListView2.Items(item3.Index).Remove()
            sortlistview()
            'EventCollectionSub("Item Removed from process list  :" + item3.Text)
lst1:
        Next
    End Sub

    'This array list is used in GetListTree() to collect previous pid's
    'Public OldPIDList As New ArrayList

    Private Sub GetListTree()
        Try


            '****************************************************
            'here a bug introduced during process scaning 
            '

            '*********************************************************************************'
            'First we delete terminated process from tree and list 
            'IMPORTANT : We can do this task by detecting which pid is not in old collection of PID
            'We con get old PID list by list view collection of pid
            'or making an universal array list


            'But now we are not doing this thing

            '1st we collect all running pid
            Dim PIDList As New ArrayList
            PIDList.Clear()

            'Storing All running Id in ArrayList
            For Each p As Process In Process.GetProcesses
                PIDList.Add(p.Id)
            Next

            'Collection list view items in array list
            Dim LVCollect As New ArrayList
            LVCollect.AddRange(ListView2.Items)

            'Deleting  terminated process from listview2 
            DelItemInListView2(LVCollect, PIDList)


            'Deleteing node from tree
            For Each NOde As TreeNode In ProTree.Nodes
                DelNode(NOde, PIDList)
            Next

            'deleting image from imagelist2
            'For Each item In ImageList2.Images.Keys
            'For Each itm In PIDList
            'If itm.ToString = item.ToString Then
            'GoTo lst2
            'End If
            'Next
            'ImageList2.Images.RemoveByKey(item)
            'EventCollectionSub("Image removed using key :" + item)
            'lst2:

            '       Next

            '********************************************************'

            '********************************************************'
            'Now  Adding New Id
            'This Process is Similar to New list Build Up
            'We first check for already exist 
            'Then if not then add otherwise return

            'Creating object
            Dim pro, Colpro
            Colpro = GetObject("winmgmts:").ExecQuery("Select * from Win32_Process ")


            For Each pro In Colpro
                Dim PPID As Integer = pro.parentprocessid
                Dim PID As Integer = pro.ProcessID
                Dim PName As String = pro.name
                Dim PPath As String = pro.executablepath.ToString

                'this was for system  idel process   but now not needed any more
                'If PID = 0 Then
                'GoTo last
                'End If



                For Each FNode As TreeNode In ProTree.Nodes
                    If AddNodeNameRefresh(FNode, PID, PPID, PName, PPath) = True Then
                        'Means Pid is processed and added
                        'Go for next process
                        GoTo last
                    End If
                Next

                'If not Found in total tree the node will be added at first place
                'Set the Imagelist Icon and assign the pid as that process key 
                'By this way each image icon will have uniqe key and have uniqe associated process
                Try
                    For Each key In ImageList2.Images.Keys
                        If key = PID.ToString Then
                            Exit Try
                        End If
                    Next
                    ImageList2.Images.Add(PID.ToString, GetICON.GetFileIcon(PPath, 1).ToBitmap)
                    '  EventCollectionSub("Image added to imglist2. : no. of image in list =" + ImageList2.Images.Count.ToString)
                Catch

                End Try

                'ImageList2.Images.Add(PID.ToString, GetICON.GetFileIcon(PPath, 1).ToBitmap)
                'Adding this node to main root and assining the kry to imagelist key
                'ProTree.Nodes.Add(PName + "     *" + PID.ToString).ImageKey = PID.ToString


                Dim Item1 As TreeNode = ProTree.Nodes.Add(PName + "     *" + PID.ToString)
                Item1.ImageKey = PID.ToString
                Item1.ToolTipText = PPath

                'this help to directly jump to the last of the loop 
last:

                'Adding these extra process to list view
                Try
                    'scaning the current process in list 2
                    For Each itm As ListViewItem In ListView2.Items
                        If PID.ToString = itm.SubItems(1).Text Then
                            Exit Try
                        End If
                    Next
                    'adding process to listview2
                    Dim item As New ListViewItem
                    item.Text = PName
                    item.SubItems.Add(PID.ToString)
                    item.ImageKey = PID.ToString

                    item.ToolTipText = PPath
                    ListView2.Update()
                    ListView2.Items.Add(item).ImageKey = PID.ToString
                    sortlistview()

                Catch ex As Exception
                    'EventCollectionSub(ex.Message)
                    'Do nothing
                End Try
            Next

        Catch ex As Exception
            'do nothing
        End Try

    End Sub

    Private Sub sortlistview()
        'ListView2.Sorting = SortOrder.Ascending
        'ListView2.Sorting = SortOrder.None
        Proc_Count.Text = "Running processes : " + ListView2.Items.Count.ToString
        ProTreeTextBox.Text = "Running processes : " + ListView2.Items.Count.ToString
    End Sub

    'timer which is used to refresh the main page process list in a finit time interval
    Private Sub ProTreeTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProTreeTimer.Tick
        GetListTree()
    End Sub

    'This function is used to retain the current Icon 
    'Because after selection Icon Index Changes to selected Index
    Private Sub ProTree_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles ProTree.AfterSelect
        e.Node.SelectedImageKey = e.Node.ImageKey
        'MessageBox.Show(ProTree.SelectedNode.Text)
    End Sub

    'With the help of the this function we select the node in right click
    'treeview do not select node in right click

    Private Sub ProTree_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles ProTree.NodeMouseClick
        ProTree.SelectedNode = e.Node
        'Label68.Text = ProTree.SelectedNode.Text
    End Sub


    'WE use these two function to start and stop timer i.e. refreshing of list because
    'If process is terminated during this procedure , this can result a error.
    'When list closed , timer again start running .

    Private Sub ListView1Strip_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ListView1Strip.Opening
        ProTreeTimer.Stop()
        'Label68.Text = "Stoped"
    End Sub

    Private Sub ListView1Strip_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosingEventArgs) Handles ListView1Strip.Closing
        ProTreeTimer.Start()
        'Label68.Text = "Started."
    End Sub


#End Region

#Region "           Title Bar Procedure     "

#Region "Title Bar Button"

    Private Sub EndButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndButton.Click
        Close()
    End Sub

    Private Sub MinimizeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'this button send form in back ground..
    Private Sub HideButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideButton.Click

        'Confirm floppy
        'if floppy allowed then
        If CheckBox4.Checked Then
            For Each drv As DriveInfo In DriveInfo.GetDrives
                If drv.Name.ToLower = "a:\" Or drv.Name.ToLower = "b:\" Then 'here A:\ and B:\ drive found in drive list
                    If MsgBox(EngResource.msgFloppyCheckbox, MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Warning") = MsgBoxResult.Yes Then
                        'here user want ot add floppy to scan list    'let things as it is 
                    Else
                        My.Computer.Registry.SetValue(VERKey, "DoNot_ING_Floppy", 0)
                        CheckBox4.Checked = False
                    End If
                    Exit For
                End If
            Next
        End If


        'hide form
        Me.Hide()
        'now show notification icon in taskbar
        NotifyIcon1.Visible = True
        'Stop protree timer if program is not visible
        ProTreeTimer.Stop()
        'start background scanning for registry and autorun file
        NotifyIconTimer.Enabled = True
        'dispaly notification that VER is running in back ground.
        NotifyIcon1.ShowBalloonTip(2000)
    End Sub

    Private Sub MaximizeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaximizeButton.Click

        'setting  form size
        Me.MaximumSize = New Size(My.Computer.Screen.WorkingArea.Width, My.Computer.Screen.WorkingArea.Height)

        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
            MaximizeButton.BackgroundImage = My.Resources.Window

        Else
            Me.WindowState = FormWindowState.Maximized
            MaximizeButton.BackgroundImage = My.Resources.Desktop

        End If
    End Sub

#End Region

#Region "Title bar move of form"
    '*********************************************************************************
    '*********************************************************************************
    'these are to maintain title bar move
#Region "declare variabls"
    Dim bit As Integer
    'Private p1 As Point
    Private p2 As Point
#End Region

#Region "Title button move "
    Private Sub TitleName_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TitleName.MouseDown
        bit = 1
        p2 = e.Location
    End Sub

    Private Sub TitleName_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TitleName.MouseMove
        'If bit = 1 Then
        '    Me.Location += (e.Location - p2)
        'End If
    End Sub

    Private Sub TitleName_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TitleName.MouseUp
        bit = 0
    End Sub
#End Region

#Region "Form panel"
    Private Sub Form1Panel_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Form1Panel.MouseDown
        bit = 1
        p2 = e.Location
    End Sub

    Private Sub Form1Panel_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Form1Panel.MouseMove
        If bit = 1 Then
            Me.Location += (e.Location - p2)
        End If
    End Sub

    Private Sub Form1Panel_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Form1Panel.MouseUp
        bit = 0
    End Sub
#End Region


    'End of title bar region
    '**********************************************************************************
    '**********************************************************************************
#End Region

#End Region


#Region "          testing      "
    Private Sub Label10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label10.DoubleClick
        Label10.Visible = False
    End Sub
#End Region

    Private Sub CheckBox4_Clicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.Click

        If CheckBox4.Checked Then
            If Not MsgBox(EngResource.msgFloppyCheckbox, MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Warning") = MsgBoxResult.Yes Then
                My.Computer.Registry.SetValue(VERKey, "DoNot_ING_Floppy", 0)
                CheckBox4.Checked = False
            Else
                My.Computer.Registry.SetValue(VERKey, "DoNot_ING_Floppy", 1)
                Return
            End If
        Else
            My.Computer.Registry.SetValue(VERKey, "DoNot_ING_Floppy", 0)
        End If
    End Sub

    Private Sub HelpToolTipBuilder_ForControl()
        '
        '< form1 Control tooltip allotment >
        '
        Me.EnglishToolTip.SetToolTip(Me.Run_remover, My.Resources.EngResource.hlpcFA_Run_remover)
        Me.EnglishToolTip.SetToolTip(Me.SFC, My.Resources.EngResource.hlpcFA_SFC)
        Me.EnglishToolTip.SetToolTip(Me.Sys_Hidden_Show, My.Resources.EngResource.hlpcFA_Sys_Hidden_Show)
        Me.EnglishToolTip.SetToolTip(Me.BlockAVirusbutton, My.Resources.EngResource.hlpcFA_BlockAVirusbutton)
        Me.EnglishToolTip.SetToolTip(Me.BrowseDir, My.Resources.EngResource.hlpcFA_BrowseDir)
        Me.EnglishToolTip.SetToolTip(Me.DDFileDetail, My.Resources.EngResource.hlpcFA_DDFileDetail)
        Me.EnglishToolTip.SetToolTip(Me.delAF, My.Resources.EngResource.hlpcFA_delAF)
        Me.EnglishToolTip.SetToolTip(Me.DeleteFileInList, My.Resources.EngResource.hlpcFA_DeleteFileInList)
        Me.EnglishToolTip.SetToolTip(Me.DelFileWithExt, My.Resources.EngResource.hlpcFA_DelFileWithExt)
        Me.EnglishToolTip.SetToolTip(Me.Enable_autorun, My.Resources.EngResource.hlpcFA_Enable_autorun)
        Me.EnglishToolTip.SetToolTip(Me.enable_msconfig, My.Resources.EngResource.hlpcFA_enable_msconfig)
        Me.EnglishToolTip.SetToolTip(Me.Enable_regedit, My.Resources.EngResource.hlpcFA_Enable_regedit)
        Me.EnglishToolTip.SetToolTip(Me.Enable_taskmgr, My.Resources.EngResource.hlpcFA_Enable_taskmgr)
        Me.EnglishToolTip.SetToolTip(Me.EndButton, My.Resources.EngResource.hlpcFA_EndButton)
        Me.EnglishToolTip.SetToolTip(Me.ExtBox, My.Resources.EngResource.hlpcFA_ExtBox)
        Me.EnglishToolTip.SetToolTip(Me.FileAttributeApply, My.Resources.EngResource.hlpcFA_FileAttributeApply)
        Me.EnglishToolTip.SetToolTip(Me.Filenamebox, My.Resources.EngResource.hlpcFA_Filenamebox)
        Me.EnglishToolTip.SetToolTip(Me.FilesAllowedToDeleteBox, My.Resources.EngResource.hlpcFA_FilesAllowedToDeleteBox)
        Me.EnglishToolTip.SetToolTip(Me.FindCloneButton, My.Resources.EngResource.hlpcFA_FindCloneButton)
        Me.EnglishToolTip.SetToolTip(Me.find_autorun, My.Resources.EngResource.hlpcFA_find_autorun)
        Me.EnglishToolTip.SetToolTip(Me.FolderInfoButton, My.Resources.EngResource.hlpcFA_FolderInfoButton)
        Me.EnglishToolTip.SetToolTip(Me.FolderOptionsButton, My.Resources.EngResource.hlpcFA_FolderOptionsButton)
        Me.EnglishToolTip.SetToolTip(Me.GenerateprocessListButton, My.Resources.EngResource.hlpcFA_GenerateprocessListButton)
        Me.EnglishToolTip.SetToolTip(Me.GetdrvProperty, My.Resources.EngResource.hlpcFA_GetdrvProperty)
        Me.EnglishToolTip.SetToolTip(GetRemovalMedia, My.Resources.EngResource.hlpcFA_GetRemovalMedia)
        Me.EnglishToolTip.SetToolTip(Me.HideButton, My.Resources.EngResource.hlpcFA_HideButton)
        Me.EnglishToolTip.SetToolTip(Me.HideDriveButton, My.Resources.EngResource.hlpcFA_HideDriveButton)
        Me.EnglishToolTip.SetToolTip(Me.InfBox, My.Resources.EngResource.hlpcFA_InfBox)
        Me.EnglishToolTip.SetToolTip(Me.MaximizeButton, My.Resources.EngResource.hlpcFA_MaximizeButton)
        Me.EnglishToolTip.SetToolTip(Me.MediaInfoButton, My.Resources.EngResource.hlpcFA_MediaInfoButton)
        Me.EnglishToolTip.SetToolTip(Me.MinimizeButton, My.Resources.EngResource.hlpcFA_MinimizeButton)
        Me.EnglishToolTip.SetToolTip(Me.onehit, My.Resources.EngResource.hlpcFA_onehit)
        Me.EnglishToolTip.SetToolTip(Me.OnlySystemHidden, My.Resources.EngResource.hlpcFA_OnlySystemHidden)
        Me.EnglishToolTip.SetToolTip(Me.OptionButton, My.Resources.EngResource.hlpcFA_OptionButton)
        Me.EnglishToolTip.SetToolTip(Me.ProcessCommandLine, My.Resources.EngResource.hlpcFA_ProcessCommandLine)
        Me.EnglishToolTip.SetToolTip(Me.Protectdrive, My.Resources.EngResource.hlpcFA_Protectdrive)
        Me.EnglishToolTip.SetToolTip(Me.RefreshButtonMain, My.Resources.EngResource.hlpcFA_RefreshButtonMain)
        Me.EnglishToolTip.SetToolTip(Me.RemoveSystemHidden, My.Resources.EngResource.hlpcFA_RemoveSystemHidden)
        Me.EnglishToolTip.SetToolTip(Me.RenameFileInList, My.Resources.EngResource.hlpcFA_RenameFileInList)
        Me.EnglishToolTip.SetToolTip(Me.RunNewProcessButton, My.Resources.EngResource.hlpcFA_RunNewProcessButton)
        Me.EnglishToolTip.SetToolTip(Me.scanagain, My.Resources.EngResource.hlpcFA_scanagain)
        Me.EnglishToolTip.SetToolTip(Me.ScanServiceButton, My.Resources.EngResource.hlpcFA_ScanServiceButton)
        Me.EnglishToolTip.SetToolTip(Me.ScanStartupButton, My.Resources.EngResource.hlpcFA_ScanStartupButton)
        Me.EnglishToolTip.SetToolTip(Me.SecurityPermissionsButton, My.Resources.EngResource.hlpcFA_SecurityPermissionsButton)
        Me.EnglishToolTip.SetToolTip(Me.ShowAllFile, My.Resources.EngResource.hlpcFA_ShowAllFile)
        Me.EnglishToolTip.SetToolTip(Me.ShowAllHiddenFile, My.Resources.EngResource.hlpcFA_ShowAllHiddenFile)
        Me.EnglishToolTip.SetToolTip(Me.ShowAlllSytemFile, My.Resources.EngResource.hlpcFA_ShowAlllSytemFile)
        Me.EnglishToolTip.SetToolTip(Me.ShowFolderOption, My.Resources.EngResource.hlpcFA_ShowFolderOption)
        Me.EnglishToolTip.SetToolTip(Me.UnlockModuleButton, My.Resources.EngResource.hlpcFA_UnlockModuleButton)
        Me.EnglishToolTip.SetToolTip(Me.USBStorageDeviceOption, My.Resources.EngResource.hlpcFA_USBStorageDeviceOption)
        Me.EnglishToolTip.SetToolTip(Me.VisualiseAllFile, My.Resources.EngResource.hlpcFA_VisualiseAllFile)
        Me.EnglishToolTip.SetToolTip(Me.AddStartup, My.Resources.EngResource.hlpcFA_AddStartup)
        Me.EnglishToolTip.SetToolTip(Me.send2tray, My.Resources.EngResource.hlpcFA_send2tray)
        Me.EnglishToolTip.SetToolTip(Me.Help_box, My.Resources.EngResource.hlpcFA_Help_box)
        Me.EnglishToolTip.SetToolTip(Me.IGN_CDROM, My.Resources.EngResource.hlpcFA_IGN_CDROM)
        Me.EnglishToolTip.SetToolTip(Me.ScanTime, My.Resources.EngResource.hlpcFA_ScanTime)
        Me.EnglishToolTip.SetToolTip(Me.EnableProcessFilter, My.Resources.EngResource.hlpcFA_EnableProcessFilter)
        Me.EnglishToolTip.SetToolTip(Me.CheckBox6, My.Resources.EngResource.hlpcFA_CheckBox6)
        Me.EnglishToolTip.SetToolTip(Me.CheckBox4, My.Resources.EngResource.hlpcFA_CheckBox4)
        Me.EnglishToolTip.SetToolTip(Me.GroupBox12, My.Resources.EngResource.hlpcFA_GroupBox12)
        Me.EnglishToolTip.SetToolTip(Me.GroupBox8, My.Resources.EngResource.hlpcFA_GroupBox8)
        Me.EnglishToolTip.SetToolTip(Me.RenameIEButton, My.Resources.EngResource.hlpcFA_RenameIEButton)
        Me.EnglishToolTip.SetToolTip(Me.CommandPromptButton, My.Resources.EngResource.hlpcFA_CommandPromptButton)
        Me.EnglishToolTip.SetToolTip(Me.DXDiagButton, My.Resources.EngResource.hlpcFA_DXDiagButton)
        Me.EnglishToolTip.SetToolTip(Me.MSInfoButton, My.Resources.EngResource.hlpcFA_MSInfoButton)
        Me.EnglishToolTip.SetToolTip(Me.FileProtectorButton, My.Resources.EngResource.hlpcFA_FileProtectorButton)
        Me.EnglishToolTip.SetToolTip(Me.WCleanButton, My.Resources.EngResource.hlpcFA_WCleanButton)
        Me.EnglishToolTip.SetToolTip(Me.AutorunBox1, My.Resources.EngResource.hlpcFA_AutorunBox1)
        Me.EnglishToolTip.SetToolTip(Me.CheckBox1, My.Resources.EngResource.hlpcFA_CheckBox1)
        Me.EnglishToolTip.SetToolTip(Me.FileFoundLV, My.Resources.EngResource.hlpcFA_FileFoundLV)
        Me.EnglishToolTip.SetToolTip(Me.ProList, My.Resources.EngResource.hlpcFA_ProList)
        Me.EnglishToolTip.SetToolTip(Me.KillThis, My.Resources.EngResource.hlpcFA_KillThis)
        Me.EnglishToolTip.SetToolTip(Me.ProcessDetailList, My.Resources.EngResource.hlpcFA_ProcessDetailList)
        Me.EnglishToolTip.SetToolTip(Me.CheckBox2, My.Resources.EngResource.hlpcFA_CheckBox2)
        Me.EnglishToolTip.SetToolTip(Me.ModuleList, My.Resources.EngResource.hlpcFA_ModuleList)
        Me.EnglishToolTip.SetToolTip(Me.ShowHideFile, My.Resources.EngResource.hlpcFA_ShowHideFile)
        Me.EnglishToolTip.SetToolTip(Me.SystemHided, My.Resources.EngResource.hlpcFA_SystemHided)
        Me.EnglishToolTip.SetToolTip(Me.FileExt, My.Resources.EngResource.hlpcFA_FileExt)
        Me.EnglishToolTip.SetToolTip(Me.BT1, My.Resources.EngResource.hlpcFA_BT1)
        Me.EnglishToolTip.SetToolTip(Me.BR2, My.Resources.EngResource.hlpcFA_BR2)
        Me.EnglishToolTip.SetToolTip(Me.IncSd1, My.Resources.EngResource.hlpcFA_IncSd1)
        Me.EnglishToolTip.SetToolTip(Me.REDir1, My.Resources.EngResource.hlpcFA_REDir1)
        Me.EnglishToolTip.SetToolTip(Me.DelAllEmptyDir, My.Resources.EngResource.hlpcFA_DelAllEmptyDir)
        Me.EnglishToolTip.SetToolTip(Me.IncSubDir2, My.Resources.EngResource.hlpcFA_IncSubDir2)
        Me.EnglishToolTip.SetToolTip(Me.DelEmptyDir2, My.Resources.EngResource.hlpcFA_DelEmptyDir2)
        Me.EnglishToolTip.SetToolTip(Me.RecycleBinBox, My.Resources.EngResource.hlpcFA_RecycleBinBox)
        Me.EnglishToolTip.SetToolTip(Me.FDel, My.Resources.EngResource.hlpcFA_FDel)
        Me.EnglishToolTip.SetToolTip(Me.DisableExitDialog, My.Resources.EngResource.hlpcFA_DisableExitDialog)
        
        '--------------------------------
        '<Here we will allot tooltip text for tool tip menu item>
        '
        Me.GroupPolicyEditerToolStripMenuItem.ToolTipText = My.Resources.EngResource.hlptFA_GroupPolicyEditerToolStripMenuItem
        Me.RestoreBackupToolStripMenuItem.ToolTipText = My.Resources.EngResource.hlptFA_RestoreBackupToolStripMenuItem
        Me.MakeRegisrtyBackupToolStripMenuItem.ToolTipText = My.Resources.EngResource.hlptFA_MakeRegisrtyBackupToolStripMenuItem
        '--------------------------------

    End Sub

    Private Sub ProcessModuleListStrip_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ProcessModuleListStrip.Opening
        If EmptyListView(ProcessListOfModule, False) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub FileFoundLVContextMenu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles FileFoundLVContextMenu.Opening
        If ListViewIsEmptyOrNotSelected(FileFoundLV, False) Then
            e.Cancel = True
        End If
    End Sub


    Private Sub ProListContextMenu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ProListContextMenu.Opening
        If ListViewIsEmptyOrNotSelected(ProList, False) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ModuleListStrip_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ModuleListStrip.Opening
        If ListViewIsEmptyOrNotSelected(ModuleList, False) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ListView2Strip_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ListView2Strip.Opening
        If ListViewIsEmptyOrNotSelected(ListView2, False) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ExpandToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpandToolStripMenuItem.Click
        On Error Resume Next
        ProTree.ExpandAll()
    End Sub

End Class
