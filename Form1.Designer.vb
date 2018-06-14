Imports Virus_Effect_Remover.C_Button.CButton

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Main Details", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Executation Details", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Size Details", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup4 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Operating System Details", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Process Name", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1, System.Drawing.Color.Empty, System.Drawing.Color.LightSteelBlue, Nothing)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Caption", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Description", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Process ID", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.GradientInactiveCaption, Nothing)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Process Path", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1, System.Drawing.Color.Empty, System.Drawing.Color.LightSkyBlue, Nothing)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"File Size", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Priority", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"ThreadCount", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"ParentProcess", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"ParentProcessId", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"CommandLine", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.InactiveCaption, Nothing)
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"User", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1, System.Drawing.Color.Empty, System.Drawing.Color.LightPink, Nothing)
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"PrivatePageCount", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Process Time", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"PageFileUsage", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem16 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"PageFaults", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem17 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"VirtualSize", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem18 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"WorkingSetSize", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem19 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"MinimumWorkingSetSize", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem20 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"MaximumWorkingSetSize", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem21 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"PeakWorkingSetSize", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem22 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"PeakVirtualSize", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem23 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"PeakPageFileUsage", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem24 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"QuotaPagedPoolUsage", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem25 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"QuotaNonPagedPoolUsage", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem26 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"QuotaPeakPagedPoolUsage", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem27 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"QuotaPeakNonPagedPoolUsage", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem28 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"OS Name", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem29 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"CreationClassName", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem30 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"WindowsVersion", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem31 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"CreationDate", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem32 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"CSCreationClassName", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem33 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"CSName", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem34 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"OSCreationClassName", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem35 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"ExecutionState", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem36 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Handle", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem37 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"HandleCount", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem38 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"InstallDate", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem39 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"KernelModeTime", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem40 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"OtherOperationCount", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem41 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"OtherTransferCount", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem42 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"ReadOperationCount", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem43 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"ReadTransferCount", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem44 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Status", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem45 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"SessionId", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem46 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"UserModeTime", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem47 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"WriteOperationCount", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem48 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"WriteTransferCount", Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunRemoverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefressStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MakeRegisrtyBackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreBackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.RegistryOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaskManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisrtyEditerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MSCONFIGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupPolicyEditerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsManagementConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComputerManagementConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeviceManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiskManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator25 = New System.Windows.Forms.ToolStripSeparator()
        Me.ServiceManagementConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventViewerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerformanceConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalUsersAndGroupsConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SharedFoldersManagementConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WMIControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecuritySettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiskDefragmenterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlternateExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.GenerateRunningProcessListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepairToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrWatsonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemFileCheckerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtherToolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator22 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.USBStorageDeviceOption = New Virus_Effect_Remover.C_Button.CButton()
        Me.Enable_autorun = New Virus_Effect_Remover.C_Button.CButton()
        Me.find_autorun = New Virus_Effect_Remover.C_Button.CButton()
        Me.Protectdrive = New Virus_Effect_Remover.C_Button.CButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.infobox = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.enable_msconfig = New Virus_Effect_Remover.C_Button.CButton()
        Me.Enable_regedit = New Virus_Effect_Remover.C_Button.CButton()
        Me.Enable_taskmgr = New Virus_Effect_Remover.C_Button.CButton()
        Me.Help_box = New System.Windows.Forms.CheckBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StartTimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopTimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ScanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyIconTimer = New System.Windows.Forms.Timer(Me.components)
        Me.InfBox = New System.Windows.Forms.ListBox()
        Me.Filenamebox = New System.Windows.Forms.TextBox()
        Me.scanagain = New System.Windows.Forms.Button()
        Me.onehit = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.AutorunBox1 = New System.Windows.Forms.RichTextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.KillThis = New System.Windows.Forms.Button()
        Me.send2tray = New System.Windows.Forms.CheckBox()
        Me.IGN_CDROM = New System.Windows.Forms.CheckBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.RunTask = New System.Windows.Forms.Button()
        Me.BrowseTask = New System.Windows.Forms.Button()
        Me.TaskTabBox = New System.Windows.Forms.TextBox()
        Me.RemoveSystemHidden = New System.Windows.Forms.Button()
        Me.VisualiseAllFile = New System.Windows.Forms.Button()
        Me.RenameFileInList = New System.Windows.Forms.Button()
        Me.DeleteFileInList = New System.Windows.Forms.Button()
        Me.OnlySystemHidden = New System.Windows.Forms.Button()
        Me.ShowAlllSytemFile = New System.Windows.Forms.Button()
        Me.ShowAllFile = New System.Windows.Forms.Button()
        Me.BrowseDir = New System.Windows.Forms.Button()
        Me.ShowAllHiddenFile = New System.Windows.Forms.Button()
        Me.EnableProcessFilter = New System.Windows.Forms.CheckBox()
        Me.HideButton = New System.Windows.Forms.Button()
        Me.AddStartup = New System.Windows.Forms.CheckBox()
        Me.MinimizeButton = New System.Windows.Forms.Button()
        Me.EndButton = New System.Windows.Forms.Button()
        Me.BR2 = New System.Windows.Forms.Button()
        Me.ExtBox = New System.Windows.Forms.TextBox()
        Me.DelFileWithExt = New System.Windows.Forms.Button()
        Me.delAF = New System.Windows.Forms.Button()
        Me.RecycleBinBox = New System.Windows.Forms.CheckBox()
        Me.FDel = New System.Windows.Forms.CheckBox()
        Me.FilesAllowedToDeleteBox = New System.Windows.Forms.TextBox()
        Me.DirLocation = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MaximizeButton = New System.Windows.Forms.Button()
        Me.GetdrvProperty = New System.Windows.Forms.Button()
        Me.DDFileDetail = New System.Windows.Forms.Button()
        Me.FileAttributeApply = New System.Windows.Forms.Button()
        Me.BT1 = New System.Windows.Forms.Button()
        Me.ModuleList = New System.Windows.Forms.ListView()
        Me.ModuleName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MOduleDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.modulePathPan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ModuleBaseAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ModuleListStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GetAllProcessUsingThisModuleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetModuleFilePropertyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReleaseSelectedModuleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenLocationOfModuleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyFileToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyFilePathToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModuleListImage = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FileFoundLV = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FileFoundLVContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LocateFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetCompleteDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator23 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopyFileToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyPathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator24 = New System.Windows.Forms.ToolStripSeparator()
        Me.RemoveThisEntryFromListToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImLAutoRT = New System.Windows.Forms.ImageList(Me.components)
        Me.ProList = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProListContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LocateProcessInProcessListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator19 = New System.Windows.Forms.ToolStripSeparator()
        Me.KillProcessToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KillProcessAndDeleteProcessFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator21 = New System.Windows.Forms.ToolStripSeparator()
        Me.GetDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetProcessFilePropertyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetModuleListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopyExecutableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyExecutablePathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator20 = New System.Windows.Forms.ToolStripSeparator()
        Me.LocateExecutableFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveThisEntryFromListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainTabControl = New System.Windows.Forms.TabControl()
        Me.MainPage = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ProTree = New System.Windows.Forms.TreeView()
        Me.ListView1Strip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.KillProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlyKillProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KillProcessToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestratProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetRelatedModuleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SuspendProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumeProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.GetGeneralDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetProcessFilePropertyToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator26 = New System.Windows.Forms.ToolStripSeparator()
        Me.AffinityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PriorityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HighToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboveNormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BelowNormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadFullProcessTreeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenLocationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyFilePathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExpandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ProTreeTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RefreshButtonMain = New Virus_Effect_Remover.C_Button.CButton()
        Me.Run_remover = New Virus_Effect_Remover.C_Button.CButton()
        Me.Sys_Hidden_Show = New Virus_Effect_Remover.C_Button.CButton()
        Me.SFC = New Virus_Effect_Remover.C_Button.CButton()
        Me.AutorunPanelPage = New System.Windows.Forms.TabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ProcessDetailPage = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView2Strip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.KillProcessToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetModuleDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SuspendProcessToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumeProcessToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GetGenralDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetProcessFilePropertyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator27 = New System.Windows.Forms.ToolStripSeparator()
        Me.AffinityToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyFileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyFilePathToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Proc_Count = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Tp0 = New System.Windows.Forms.TabPage()
        Me.ProcessDetailList = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TP1 = New System.Windows.Forms.TabPage()
        Me.PathLable = New System.Windows.Forms.TextBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.IdLable = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.NameLable = New System.Windows.Forms.Label()
        Me.TP3 = New System.Windows.Forms.TabPage()
        Me.ClearKillEventList = New System.Windows.Forms.Button()
        Me.KillEventListBox = New System.Windows.Forms.ListBox()
        Me.FixedImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.FolderOptionPage = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FileFolderTab = New System.Windows.Forms.TabControl()
        Me.FolderOptionsSubPage = New System.Windows.Forms.TabPage()
        Me.UtilityBox = New System.Windows.Forms.GroupBox()
        Me.FileExt = New System.Windows.Forms.CheckBox()
        Me.ShowFolderOption = New Virus_Effect_Remover.C_Button.CButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.ShowHideFile = New System.Windows.Forms.CheckBox()
        Me.SystemHided = New System.Windows.Forms.CheckBox()
        Me.RemovalMediaDetailPage = New System.Windows.Forms.TabPage()
        Me.GetRemovalMedia = New System.Windows.Forms.Button()
        Me.TabControl5 = New System.Windows.Forms.TabControl()
        Me.RemMDetail = New System.Windows.Forms.TabPage()
        Me.RemovalMediaDriveList = New System.Windows.Forms.ListView()
        Me.DriveName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DriveVolume = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DriveFormat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DriveTotalSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DriveUsedSpace = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DriveFreeSpace = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DriveInfectionStaus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChangeRemDetail = New System.Windows.Forms.TabPage()
        Me.RemDetailTextbox = New System.Windows.Forms.TextBox()
        Me.GenDetail = New System.Windows.Forms.CheckBox()
        Me.FormateDrive = New System.Windows.Forms.Button()
        Me.ReleaseDrive = New System.Windows.Forms.Button()
        Me.DirectoryDetailPage = New System.Windows.Forms.TabPage()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.IncludeSubFolder = New System.Windows.Forms.CheckBox()
        Me.DirectoryPath = New System.Windows.Forms.TextBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.FileAttributeTemporary = New System.Windows.Forms.CheckBox()
        Me.FileAttributeEncripted = New System.Windows.Forms.CheckBox()
        Me.FileAttributeOffLine = New System.Windows.Forms.CheckBox()
        Me.FileAttributeCompressed = New System.Windows.Forms.CheckBox()
        Me.FileAttributeSystem = New System.Windows.Forms.CheckBox()
        Me.FileAttributeArchive = New System.Windows.Forms.CheckBox()
        Me.FileAtttributeHidden = New System.Windows.Forms.CheckBox()
        Me.FileAttributeReadOnly = New System.Windows.Forms.CheckBox()
        Me.DirectoryFileListView = New System.Windows.Forms.ListView()
        Me.FileNameSubPage = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FileSizeColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FileExtention = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FullPathTab = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DelFilePage = New System.Windows.Forms.TabPage()
        Me.UDTabControl1 = New System.Windows.Forms.TabControl()
        Me.UDTabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.SendToRecycleFile = New System.Windows.Forms.CheckBox()
        Me.ForceToDeleteFile = New System.Windows.Forms.CheckBox()
        Me.RemSFL = New System.Windows.Forms.Button()
        Me.LocateFile = New System.Windows.Forms.TextBox()
        Me.DelSF = New System.Windows.Forms.Button()
        Me.DelList = New System.Windows.Forms.ListView()
        Me.SerialDelList = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FileDelList = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SizeDelList = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AttributeDelList = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PathDelList = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ADDfile2 = New System.Windows.Forms.Button()
        Me.DelACF = New System.Windows.Forms.Button()
        Me.ClrList = New System.Windows.Forms.Button()
        Me.UDTabPage2 = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.DelEmptyDir2 = New System.Windows.Forms.CheckBox()
        Me.IncSubDir2 = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.REDir1 = New System.Windows.Forms.CheckBox()
        Me.IncSd1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DelAllEmptyDir = New System.Windows.Forms.Button()
        Me.UDTabPage3 = New System.Windows.Forms.TabPage()
        Me.EventListview = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SecurityPermissionPage = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DirectoryRadioButton = New System.Windows.Forms.RadioButton()
        Me.FileRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.LocationPathSecurity = New System.Windows.Forms.TextBox()
        Me.NTFSTabControl = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.CButton19 = New Virus_Effect_Remover.C_Button.CButton()
        Me.CButton18 = New Virus_Effect_Remover.C_Button.CButton()
        Me.CButton16 = New Virus_Effect_Remover.C_Button.CButton()
        Me.AccessRuleListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.AuditRuleListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader26 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CButton22 = New Virus_Effect_Remover.C_Button.CButton()
        Me.CButton21 = New Virus_Effect_Remover.C_Button.CButton()
        Me.CButton20 = New Virus_Effect_Remover.C_Button.CButton()
        Me.TabPage13 = New System.Windows.Forms.TabPage()
        Me.OwnerApplyButton = New Virus_Effect_Remover.C_Button.CButton()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.OwnerComboBox = New System.Windows.Forms.ComboBox()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.TabPage12 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.RemoveFullControlButton = New Virus_Effect_Remover.C_Button.CButton()
        Me.GetFullControlButton = New Virus_Effect_Remover.C_Button.CButton()
        Me.FileFolderBr = New Virus_Effect_Remover.C_Button.CButton()
        Me.RetriveAccessRuleButton = New Virus_Effect_Remover.C_Button.CButton()
        Me.UnlockerPage = New System.Windows.Forms.TabPage()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.UnlockerGo = New System.Windows.Forms.Button()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.ProcessListOfModule = New System.Windows.Forms.ListView()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProcessModuleBaseAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProcessModuleListStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LocateThisProcessInProcessListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetProToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReleseCurrentModuleFromThisProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KillProcessToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KillProcessAndDeleteParentFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetRelatedProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReleaseModuleFromAllProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReleaseDeleteModuleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenLocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Unlockerbrowse = New System.Windows.Forms.Button()
        Me.ModuleAbsolutePathBox = New System.Windows.Forms.TextBox()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.OtherToolPage = New System.Windows.Forms.TabPage()
        Me.FileProtectorButton = New Virus_Effect_Remover.C_Button.CButton()
        Me.WCleanButton = New Virus_Effect_Remover.C_Button.CButton()
        Me.HideDriveButton = New Virus_Effect_Remover.C_Button.CButton()
        Me.ProcessCommandLine = New Virus_Effect_Remover.C_Button.CButton()
        Me.MSInfoButton = New Virus_Effect_Remover.C_Button.CButton()
        Me.CommandPromptButton = New Virus_Effect_Remover.C_Button.CButton()
        Me.RenameIEButton = New Virus_Effect_Remover.C_Button.CButton()
        Me.DXDiagButton = New Virus_Effect_Remover.C_Button.CButton()
        Me.SettingPage = New System.Windows.Forms.TabPage()
        Me.DisableExitDialog = New System.Windows.Forms.CheckBox()
        Me.RedTheme = New System.Windows.Forms.RadioButton()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.GreenTheme = New System.Windows.Forms.RadioButton()
        Me.BlueTheme = New System.Windows.Forms.RadioButton()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ScanTime = New System.Windows.Forms.CheckBox()
        Me.AutomaticDeleteAutorun = New System.Windows.Forms.CheckBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ProTreeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Form1Panel = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BlockAVirusbutton = New Virus_Effect_Remover.C_Button.CButton()
        Me.RunNewProcessButton = New Virus_Effect_Remover.C_Button.CButton()
        Me.ScanServiceButton = New Virus_Effect_Remover.C_Button.CButton()
        Me.ScanStartupButton = New Virus_Effect_Remover.C_Button.CButton()
        Me.GenerateprocessListButton = New Virus_Effect_Remover.C_Button.CButton()
        Me.FindCloneButton = New Virus_Effect_Remover.C_Button.CButton()
        Me.FolderInfoButton = New Virus_Effect_Remover.C_Button.CButton()
        Me.MediaInfoButton = New Virus_Effect_Remover.C_Button.CButton()
        Me.OptionButton = New Virus_Effect_Remover.C_Button.CButton()
        Me.FolderOptionsButton = New Virus_Effect_Remover.C_Button.CButton()
        Me.SecurityPermissionsButton = New Virus_Effect_Remover.C_Button.CButton()
        Me.UnlockModuleButton = New Virus_Effect_Remover.C_Button.CButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BorderPanel4 = New System.Windows.Forms.Panel()
        Me.BorderPanel5 = New System.Windows.Forms.Panel()
        Me.TitleBarPanel = New System.Windows.Forms.Panel()
        Me.TitleName = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BorderPanel1 = New System.Windows.Forms.Panel()
        Me.BorderPanel2 = New System.Windows.Forms.Panel()
        Me.EnglishToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.ModuleListStrip.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.FileFoundLVContextMenu.SuspendLayout()
        Me.ProListContextMenu.SuspendLayout()
        Me.MainTabControl.SuspendLayout()
        Me.MainPage.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.ListView1Strip.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.AutorunPanelPage.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ProcessDetailPage.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ListView2Strip.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Tp0.SuspendLayout()
        Me.TP1.SuspendLayout()
        Me.TP3.SuspendLayout()
        Me.FolderOptionPage.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FileFolderTab.SuspendLayout()
        Me.FolderOptionsSubPage.SuspendLayout()
        Me.UtilityBox.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.RemovalMediaDetailPage.SuspendLayout()
        Me.TabControl5.SuspendLayout()
        Me.RemMDetail.SuspendLayout()
        Me.ChangeRemDetail.SuspendLayout()
        Me.DirectoryDetailPage.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.DelFilePage.SuspendLayout()
        Me.UDTabControl1.SuspendLayout()
        Me.UDTabPage1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.UDTabPage2.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.UDTabPage3.SuspendLayout()
        Me.SecurityPermissionPage.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.NTFSTabControl.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage13.SuspendLayout()
        Me.TabPage12.SuspendLayout()
        Me.UnlockerPage.SuspendLayout()
        Me.ProcessModuleListStrip.SuspendLayout()
        Me.OtherToolPage.SuspendLayout()
        Me.SettingPage.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Form1Panel.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TitleBarPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunRemoverToolStripMenuItem, Me.RefressStatusToolStripMenuItem, Me.ToolStripSeparator3, Me.HideToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'RunRemoverToolStripMenuItem
        '
        Me.RunRemoverToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources._32
        Me.RunRemoverToolStripMenuItem.Name = "RunRemoverToolStripMenuItem"
        Me.RunRemoverToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RunRemoverToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.RunRemoverToolStripMenuItem.Text = "One Click Registry Heal"
        '
        'RefressStatusToolStripMenuItem
        '
        Me.RefressStatusToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.RefressStatusToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.arrow_refresh
        Me.RefressStatusToolStripMenuItem.Name = "RefressStatusToolStripMenuItem"
        Me.RefressStatusToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.RefressStatusToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.RefressStatusToolStripMenuItem.Text = "Refresh Status"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(235, 6)
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Image = CType(resources.GetObject("HideToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.HideToolStripMenuItem.Text = "Hide"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MakeRegisrtyBackupToolStripMenuItem, Me.RestoreBackupToolStripMenuItem, Me.ToolStripSeparator6, Me.RegistryOptionsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'MakeRegisrtyBackupToolStripMenuItem
        '
        Me.MakeRegisrtyBackupToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.arrow_R_48
        Me.MakeRegisrtyBackupToolStripMenuItem.Name = "MakeRegisrtyBackupToolStripMenuItem"
        Me.MakeRegisrtyBackupToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.MakeRegisrtyBackupToolStripMenuItem.Text = "Make Registry BackUp"
        '
        'RestoreBackupToolStripMenuItem
        '
        Me.RestoreBackupToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.arrow_L_48
        Me.RestoreBackupToolStripMenuItem.Name = "RestoreBackupToolStripMenuItem"
        Me.RestoreBackupToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.RestoreBackupToolStripMenuItem.Text = "Restore Registry BackUp"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(198, 6)
        '
        'RegistryOptionsToolStripMenuItem
        '
        Me.RegistryOptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem})
        Me.RegistryOptionsToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.cog
        Me.RegistryOptionsToolStripMenuItem.Name = "RegistryOptionsToolStripMenuItem"
        Me.RegistryOptionsToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.RegistryOptionsToolStripMenuItem.Text = "Registry Options"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.application_view_detail
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.OpenToolStripMenuItem.Text = "Open registry file after creating BackUp"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TaskManagerToolStripMenuItem, Me.RegisrtyEditerToolStripMenuItem, Me.MSCONFIGToolStripMenuItem, Me.GroupPolicyEditerToolStripMenuItem, Me.WindowsManagementConsoleToolStripMenuItem, Me.AlternateExplorerToolStripMenuItem, Me.ToolStripSeparator9, Me.GenerateRunningProcessListToolStripMenuItem, Me.RepairToolsToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.SettingsToolStripMenuItem.Text = "Tools"
        '
        'TaskManagerToolStripMenuItem
        '
        Me.TaskManagerToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.monitor_32
        Me.TaskManagerToolStripMenuItem.Name = "TaskManagerToolStripMenuItem"
        Me.TaskManagerToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.TaskManagerToolStripMenuItem.Text = "Task Manager"
        '
        'RegisrtyEditerToolStripMenuItem
        '
        Me.RegisrtyEditerToolStripMenuItem.Image = CType(resources.GetObject("RegisrtyEditerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RegisrtyEditerToolStripMenuItem.Name = "RegisrtyEditerToolStripMenuItem"
        Me.RegisrtyEditerToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.RegisrtyEditerToolStripMenuItem.Text = "Registry Editor"
        '
        'MSCONFIGToolStripMenuItem
        '
        Me.MSCONFIGToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.Window1
        Me.MSCONFIGToolStripMenuItem.Name = "MSCONFIGToolStripMenuItem"
        Me.MSCONFIGToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.MSCONFIGToolStripMenuItem.Text = "MSConfig"
        '
        'GroupPolicyEditerToolStripMenuItem
        '
        Me.GroupPolicyEditerToolStripMenuItem.Image = CType(resources.GetObject("GroupPolicyEditerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GroupPolicyEditerToolStripMenuItem.Name = "GroupPolicyEditerToolStripMenuItem"
        Me.GroupPolicyEditerToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.GroupPolicyEditerToolStripMenuItem.Text = "Group Policy Editor"
        '
        'WindowsManagementConsoleToolStripMenuItem
        '
        Me.WindowsManagementConsoleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComputerManagementConsoleToolStripMenuItem, Me.DeviceManagerToolStripMenuItem, Me.DiskManagementToolStripMenuItem, Me.ToolStripSeparator25, Me.ServiceManagementConsoleToolStripMenuItem, Me.EventViewerToolStripMenuItem, Me.PerformanceConsoleToolStripMenuItem, Me.LocalUsersAndGroupsConsoleToolStripMenuItem, Me.SharedFoldersManagementConsoleToolStripMenuItem, Me.WMIControlToolStripMenuItem, Me.SecuritySettingsToolStripMenuItem, Me.DiskDefragmenterToolStripMenuItem})
        Me.WindowsManagementConsoleToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.cog
        Me.WindowsManagementConsoleToolStripMenuItem.Name = "WindowsManagementConsoleToolStripMenuItem"
        Me.WindowsManagementConsoleToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.WindowsManagementConsoleToolStripMenuItem.Text = "Microsoft Management Consoles"
        '
        'ComputerManagementConsoleToolStripMenuItem
        '
        Me.ComputerManagementConsoleToolStripMenuItem.Name = "ComputerManagementConsoleToolStripMenuItem"
        Me.ComputerManagementConsoleToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.ComputerManagementConsoleToolStripMenuItem.Text = "Computer Management"
        Me.ComputerManagementConsoleToolStripMenuItem.ToolTipText = "Computer management and related system tools."
        '
        'DeviceManagerToolStripMenuItem
        '
        Me.DeviceManagerToolStripMenuItem.Name = "DeviceManagerToolStripMenuItem"
        Me.DeviceManagerToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.DeviceManagerToolStripMenuItem.Text = "Device Manager"
        Me.DeviceManagerToolStripMenuItem.ToolTipText = "You can use Device Manager to view a list of hardware devices installed on your c" & _
    "omputer and set properties for each device."
        '
        'DiskManagementToolStripMenuItem
        '
        Me.DiskManagementToolStripMenuItem.Name = "DiskManagementToolStripMenuItem"
        Me.DiskManagementToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.DiskManagementToolStripMenuItem.Text = "Disk Management"
        Me.DiskManagementToolStripMenuItem.ToolTipText = "Dynamic disk and volume management provided to Microsoft by VERITAS Software Corp" & _
    "oration."
        '
        'ToolStripSeparator25
        '
        Me.ToolStripSeparator25.Name = "ToolStripSeparator25"
        Me.ToolStripSeparator25.Size = New System.Drawing.Size(222, 6)
        '
        'ServiceManagementConsoleToolStripMenuItem
        '
        Me.ServiceManagementConsoleToolStripMenuItem.Name = "ServiceManagementConsoleToolStripMenuItem"
        Me.ServiceManagementConsoleToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.ServiceManagementConsoleToolStripMenuItem.Text = "Service Management"
        Me.ServiceManagementConsoleToolStripMenuItem.ToolTipText = "Starts, stops, and configures Windows services."
        '
        'EventViewerToolStripMenuItem
        '
        Me.EventViewerToolStripMenuItem.Name = "EventViewerToolStripMenuItem"
        Me.EventViewerToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.EventViewerToolStripMenuItem.Text = "Event Viewer"
        Me.EventViewerToolStripMenuItem.ToolTipText = "Displays event logs."
        '
        'PerformanceConsoleToolStripMenuItem
        '
        Me.PerformanceConsoleToolStripMenuItem.Name = "PerformanceConsoleToolStripMenuItem"
        Me.PerformanceConsoleToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.PerformanceConsoleToolStripMenuItem.Text = "Performance"
        Me.PerformanceConsoleToolStripMenuItem.ToolTipText = "The ActiveX Control snap-in allows you to add an ActiveX control to your console." & _
    ""
        '
        'LocalUsersAndGroupsConsoleToolStripMenuItem
        '
        Me.LocalUsersAndGroupsConsoleToolStripMenuItem.Name = "LocalUsersAndGroupsConsoleToolStripMenuItem"
        Me.LocalUsersAndGroupsConsoleToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.LocalUsersAndGroupsConsoleToolStripMenuItem.Text = "Local users and groups"
        Me.LocalUsersAndGroupsConsoleToolStripMenuItem.ToolTipText = "Manages Local Users and Groups"
        '
        'SharedFoldersManagementConsoleToolStripMenuItem
        '
        Me.SharedFoldersManagementConsoleToolStripMenuItem.Name = "SharedFoldersManagementConsoleToolStripMenuItem"
        Me.SharedFoldersManagementConsoleToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.SharedFoldersManagementConsoleToolStripMenuItem.Text = "Shared Folders Management"
        Me.SharedFoldersManagementConsoleToolStripMenuItem.ToolTipText = "Displays shared folders, current sessions, and open files."
        '
        'WMIControlToolStripMenuItem
        '
        Me.WMIControlToolStripMenuItem.Name = "WMIControlToolStripMenuItem"
        Me.WMIControlToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.WMIControlToolStripMenuItem.Text = "WMI Control"
        Me.WMIControlToolStripMenuItem.ToolTipText = "Allows configuration and control of the Windows Management Instrumentation (WMI) " & _
    "service."
        '
        'SecuritySettingsToolStripMenuItem
        '
        Me.SecuritySettingsToolStripMenuItem.Name = "SecuritySettingsToolStripMenuItem"
        Me.SecuritySettingsToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.SecuritySettingsToolStripMenuItem.Text = "Security Settings"
        Me.SecuritySettingsToolStripMenuItem.ToolTipText = "The Security Settings Extension snap-in extends the Group Policy snap-in and help" & _
    "s you define security policies for computers in your domain."
        '
        'DiskDefragmenterToolStripMenuItem
        '
        Me.DiskDefragmenterToolStripMenuItem.Name = "DiskDefragmenterToolStripMenuItem"
        Me.DiskDefragmenterToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.DiskDefragmenterToolStripMenuItem.Text = "Disk Defragmenter*"
        Me.DiskDefragmenterToolStripMenuItem.ToolTipText = "Windows Disk Defragmenter"
        '
        'AlternateExplorerToolStripMenuItem
        '
        Me.AlternateExplorerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WindowsExplorerToolStripMenuItem})
        Me.AlternateExplorerToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.folder_explore
        Me.AlternateExplorerToolStripMenuItem.Name = "AlternateExplorerToolStripMenuItem"
        Me.AlternateExplorerToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.AlternateExplorerToolStripMenuItem.Text = "Explorer"
        '
        'WindowsExplorerToolStripMenuItem
        '
        Me.WindowsExplorerToolStripMenuItem.Image = CType(resources.GetObject("WindowsExplorerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.WindowsExplorerToolStripMenuItem.Name = "WindowsExplorerToolStripMenuItem"
        Me.WindowsExplorerToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.WindowsExplorerToolStripMenuItem.Text = "Windows Explorer"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(247, 6)
        '
        'GenerateRunningProcessListToolStripMenuItem
        '
        Me.GenerateRunningProcessListToolStripMenuItem.Image = CType(resources.GetObject("GenerateRunningProcessListToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GenerateRunningProcessListToolStripMenuItem.Name = "GenerateRunningProcessListToolStripMenuItem"
        Me.GenerateRunningProcessListToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.GenerateRunningProcessListToolStripMenuItem.Text = "Generate Running Process List"
        '
        'RepairToolsToolStripMenuItem
        '
        Me.RepairToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DrWatsonToolStripMenuItem, Me.SystemFileCheckerToolStripMenuItem})
        Me.RepairToolsToolStripMenuItem.Image = CType(resources.GetObject("RepairToolsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RepairToolsToolStripMenuItem.Name = "RepairToolsToolStripMenuItem"
        Me.RepairToolsToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.RepairToolsToolStripMenuItem.Text = "Repair Tools"
        '
        'DrWatsonToolStripMenuItem
        '
        Me.DrWatsonToolStripMenuItem.Name = "DrWatsonToolStripMenuItem"
        Me.DrWatsonToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.DrWatsonToolStripMenuItem.Text = "Dr. Watson"
        Me.DrWatsonToolStripMenuItem.Visible = False
        '
        'SystemFileCheckerToolStripMenuItem
        '
        Me.SystemFileCheckerToolStripMenuItem.Name = "SystemFileCheckerToolStripMenuItem"
        Me.SystemFileCheckerToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.SystemFileCheckerToolStripMenuItem.Text = "System file checker"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlogToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.OtherToolToolStripMenuItem, Me.HelpToolStripMenuItem1, Me.ToolStripSeparator22, Me.AboutUsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'BlogToolStripMenuItem
        '
        Me.BlogToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources._32
        Me.BlogToolStripMenuItem.Name = "BlogToolStripMenuItem"
        Me.BlogToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.BlogToolStripMenuItem.Text = "Home Page"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.globe_32
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.UpdateToolStripMenuItem.Text = "V.E.R.© Update"
        '
        'OtherToolToolStripMenuItem
        '
        Me.OtherToolToolStripMenuItem.Image = CType(resources.GetObject("OtherToolToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OtherToolToolStripMenuItem.Name = "OtherToolToolStripMenuItem"
        Me.OtherToolToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.OtherToolToolStripMenuItem.Text = "Other Virus Secure Lab® Tools"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control
        Me.HelpToolStripMenuItem1.Image = CType(resources.GetObject("HelpToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(236, 22)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'ToolStripSeparator22
        '
        Me.ToolStripSeparator22.Name = "ToolStripSeparator22"
        Me.ToolStripSeparator22.Size = New System.Drawing.Size(233, 6)
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.AboutUsToolStripMenuItem.Image = CType(resources.GetObject("AboutUsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.AboutUsToolStripMenuItem.Text = "About Us"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.USBStorageDeviceOption)
        Me.GroupBox4.Controls.Add(Me.Enable_autorun)
        Me.GroupBox4.Controls.Add(Me.find_autorun)
        Me.GroupBox4.Controls.Add(Me.Protectdrive)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(183, 145)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(174, 120)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Autorun Options :"
        '
        'USBStorageDeviceOption
        '
        Me.USBStorageDeviceOption.BackColor = System.Drawing.Color.Transparent
        Me.USBStorageDeviceOption.ButtonText = "USB Storage Device Options"
        Me.USBStorageDeviceOption.Cursor = System.Windows.Forms.Cursors.Hand
        Me.USBStorageDeviceOption.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.USBStorageDeviceOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USBStorageDeviceOption.FontsStyle = System.Drawing.FontStyle.Regular
        Me.USBStorageDeviceOption.ForeColor = System.Drawing.Color.Black
        Me.USBStorageDeviceOption.Icon = Nothing
        Me.USBStorageDeviceOption.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.USBStorageDeviceOption.IconSpacingX = 5
        Me.USBStorageDeviceOption.IconSpacingY = 5
        Me.USBStorageDeviceOption.IconTransparency = 0.0!
        Me.USBStorageDeviceOption.Location = New System.Drawing.Point(6, 92)
        Me.USBStorageDeviceOption.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.USBStorageDeviceOption.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.USBStorageDeviceOption.Name = "USBStorageDeviceOption"
        Me.USBStorageDeviceOption.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.SteelBlue, System.Drawing.Color.SteelBlue, System.Drawing.Color.SteelBlue, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.LightSteelBlue}
        Me.USBStorageDeviceOption.Size = New System.Drawing.Size(160, 23)
        Me.USBStorageDeviceOption.TabIndex = 13
        Me.USBStorageDeviceOption.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.USBStorageDeviceOption.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.USBStorageDeviceOption.TextSpacingX = 5
        Me.USBStorageDeviceOption.TextSpacingY = 5
        '
        'Enable_autorun
        '
        Me.Enable_autorun.BackColor = System.Drawing.Color.Transparent
        Me.Enable_autorun.ButtonText = "Enable/Disable Autoplay"
        Me.Enable_autorun.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Enable_autorun.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.Enable_autorun.FontsStyle = System.Drawing.FontStyle.Regular
        Me.Enable_autorun.ForeColor = System.Drawing.Color.Black
        Me.Enable_autorun.Icon = Global.Virus_Effect_Remover.My.Resources.Resources.cancel_16
        Me.Enable_autorun.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Right
        Me.Enable_autorun.IconSpacingX = 5
        Me.Enable_autorun.IconSpacingY = 5
        Me.Enable_autorun.IconTransparency = 0.0!
        Me.Enable_autorun.Location = New System.Drawing.Point(6, 41)
        Me.Enable_autorun.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.Enable_autorun.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.Enable_autorun.Name = "Enable_autorun"
        Me.Enable_autorun.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.SteelBlue, System.Drawing.Color.SteelBlue, System.Drawing.Color.SteelBlue, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.LightSteelBlue}
        Me.Enable_autorun.Size = New System.Drawing.Size(160, 23)
        Me.Enable_autorun.TabIndex = 9
        Me.Enable_autorun.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.Enable_autorun.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.Enable_autorun.TextSpacingX = 5
        Me.Enable_autorun.TextSpacingY = 5
        '
        'find_autorun
        '
        Me.find_autorun.BackColor = System.Drawing.Color.Transparent
        Me.find_autorun.ButtonText = "AutoRun.inf File Status"
        Me.find_autorun.Cursor = System.Windows.Forms.Cursors.Hand
        Me.find_autorun.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.find_autorun.FontsStyle = System.Drawing.FontStyle.Regular
        Me.find_autorun.ForeColor = System.Drawing.Color.Black
        Me.find_autorun.Icon = Global.Virus_Effect_Remover.My.Resources.Resources.cancel_16
        Me.find_autorun.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Right
        Me.find_autorun.IconSpacingX = 5
        Me.find_autorun.IconSpacingY = 5
        Me.find_autorun.IconTransparency = 0.0!
        Me.find_autorun.Location = New System.Drawing.Point(6, 16)
        Me.find_autorun.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.find_autorun.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.find_autorun.Name = "find_autorun"
        Me.find_autorun.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.SteelBlue, System.Drawing.Color.SteelBlue, System.Drawing.Color.SteelBlue, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.LightSteelBlue}
        Me.find_autorun.Size = New System.Drawing.Size(160, 23)
        Me.find_autorun.TabIndex = 8
        Me.find_autorun.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.find_autorun.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.find_autorun.TextSpacingX = 5
        Me.find_autorun.TextSpacingY = 5
        '
        'Protectdrive
        '
        Me.Protectdrive.BackColor = System.Drawing.Color.Transparent
        Me.Protectdrive.ButtonText = "Protect Drive From Autorun"
        Me.Protectdrive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Protectdrive.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.Protectdrive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Protectdrive.FontsStyle = System.Drawing.FontStyle.Regular
        Me.Protectdrive.ForeColor = System.Drawing.Color.Black
        Me.Protectdrive.Icon = Nothing
        Me.Protectdrive.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.Protectdrive.IconSpacingX = 5
        Me.Protectdrive.IconSpacingY = 5
        Me.Protectdrive.IconTransparency = 0.0!
        Me.Protectdrive.Location = New System.Drawing.Point(6, 67)
        Me.Protectdrive.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.Protectdrive.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.Protectdrive.Name = "Protectdrive"
        Me.Protectdrive.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.SteelBlue, System.Drawing.Color.SteelBlue, System.Drawing.Color.SteelBlue, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.LightSteelBlue}
        Me.Protectdrive.Size = New System.Drawing.Size(160, 23)
        Me.Protectdrive.TabIndex = 10
        Me.Protectdrive.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.Protectdrive.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.Protectdrive.TextSpacingX = 5
        Me.Protectdrive.TextSpacingY = 5
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.infobox)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(6, 272)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(346, 121)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Information Box :"
        '
        'infobox
        '
        Me.infobox.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.infobox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.infobox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infobox.Location = New System.Drawing.Point(3, 16)
        Me.infobox.Name = "infobox"
        Me.infobox.ReadOnly = True
        Me.infobox.Size = New System.Drawing.Size(340, 102)
        Me.infobox.TabIndex = 0
        Me.infobox.TabStop = False
        Me.infobox.Text = "infobox"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.enable_msconfig)
        Me.GroupBox1.Controls.Add(Me.Enable_regedit)
        Me.GroupBox1.Controls.Add(Me.Enable_taskmgr)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(183, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(174, 97)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Windows Tools :"
        '
        'enable_msconfig
        '
        Me.enable_msconfig.BackColor = System.Drawing.Color.Transparent
        Me.enable_msconfig.ButtonText = "MSconfig"
        Me.enable_msconfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.enable_msconfig.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.enable_msconfig.FontsStyle = System.Drawing.FontStyle.Regular
        Me.enable_msconfig.ForeColor = System.Drawing.Color.Black
        Me.enable_msconfig.Icon = Nothing
        Me.enable_msconfig.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.enable_msconfig.IconSpacingX = 5
        Me.enable_msconfig.IconSpacingY = 5
        Me.enable_msconfig.IconTransparency = 0.0!
        Me.enable_msconfig.Location = New System.Drawing.Point(6, 67)
        Me.enable_msconfig.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.enable_msconfig.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.enable_msconfig.Name = "enable_msconfig"
        Me.enable_msconfig.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.SteelBlue, System.Drawing.Color.SteelBlue, System.Drawing.Color.SteelBlue, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.LightSteelBlue}
        Me.enable_msconfig.Size = New System.Drawing.Size(160, 23)
        Me.enable_msconfig.TabIndex = 7
        Me.enable_msconfig.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.enable_msconfig.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.enable_msconfig.TextSpacingX = 5
        Me.enable_msconfig.TextSpacingY = 5
        '
        'Enable_regedit
        '
        Me.Enable_regedit.BackColor = System.Drawing.Color.Transparent
        Me.Enable_regedit.ButtonText = "Registry Editor"
        Me.Enable_regedit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Enable_regedit.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.Enable_regedit.FontsStyle = System.Drawing.FontStyle.Regular
        Me.Enable_regedit.ForeColor = System.Drawing.Color.Black
        Me.Enable_regedit.Icon = Nothing
        Me.Enable_regedit.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.Enable_regedit.IconSpacingX = 5
        Me.Enable_regedit.IconSpacingY = 5
        Me.Enable_regedit.IconTransparency = 0.0!
        Me.Enable_regedit.Location = New System.Drawing.Point(6, 42)
        Me.Enable_regedit.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.Enable_regedit.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.Enable_regedit.Name = "Enable_regedit"
        Me.Enable_regedit.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.SteelBlue, System.Drawing.Color.SteelBlue, System.Drawing.Color.SteelBlue, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.LightSteelBlue}
        Me.Enable_regedit.Size = New System.Drawing.Size(160, 23)
        Me.Enable_regedit.TabIndex = 6
        Me.Enable_regedit.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.Enable_regedit.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.Enable_regedit.TextSpacingX = 5
        Me.Enable_regedit.TextSpacingY = 5
        '
        'Enable_taskmgr
        '
        Me.Enable_taskmgr.BackColor = System.Drawing.Color.Transparent
        Me.Enable_taskmgr.ButtonText = "Task Manager"
        Me.Enable_taskmgr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Enable_taskmgr.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.Enable_taskmgr.FontsStyle = System.Drawing.FontStyle.Regular
        Me.Enable_taskmgr.ForeColor = System.Drawing.Color.Black
        Me.Enable_taskmgr.Icon = Nothing
        Me.Enable_taskmgr.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.Enable_taskmgr.IconSpacingX = 5
        Me.Enable_taskmgr.IconSpacingY = 5
        Me.Enable_taskmgr.IconTransparency = 0.0!
        Me.Enable_taskmgr.Location = New System.Drawing.Point(6, 17)
        Me.Enable_taskmgr.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.Enable_taskmgr.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.Enable_taskmgr.Name = "Enable_taskmgr"
        Me.Enable_taskmgr.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.SteelBlue, System.Drawing.Color.SteelBlue, System.Drawing.Color.SteelBlue, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.LightSteelBlue}
        Me.Enable_taskmgr.Size = New System.Drawing.Size(160, 23)
        Me.Enable_taskmgr.TabIndex = 5
        Me.Enable_taskmgr.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.Enable_taskmgr.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.Enable_taskmgr.TextSpacingX = 5
        Me.Enable_taskmgr.TextSpacingY = 5
        '
        'Help_box
        '
        Me.Help_box.AutoSize = True
        Me.Help_box.BackColor = System.Drawing.Color.Transparent
        Me.Help_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Help_box.Location = New System.Drawing.Point(17, 77)
        Me.Help_box.Name = "Help_box"
        Me.Help_box.Size = New System.Drawing.Size(148, 20)
        Me.Help_box.TabIndex = 138
        Me.Help_box.Text = "Turn off Tooltip help."
        Me.Help_box.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartTimerToolStripMenuItem, Me.StopTimerToolStripMenuItem, Me.ToolStripSeparator7, Me.ScanToolStripMenuItem, Me.ShowToolStripMenuItem, Me.ToolStripSeparator10, Me.ExitToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(205, 126)
        '
        'StartTimerToolStripMenuItem
        '
        Me.StartTimerToolStripMenuItem.Image = CType(resources.GetObject("StartTimerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StartTimerToolStripMenuItem.Name = "StartTimerToolStripMenuItem"
        Me.StartTimerToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.StartTimerToolStripMenuItem.Text = "Start Timer"
        '
        'StopTimerToolStripMenuItem
        '
        Me.StopTimerToolStripMenuItem.Image = CType(resources.GetObject("StopTimerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StopTimerToolStripMenuItem.Name = "StopTimerToolStripMenuItem"
        Me.StopTimerToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.StopTimerToolStripMenuItem.Text = "Stop Timer"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(201, 6)
        '
        'ScanToolStripMenuItem
        '
        Me.ScanToolStripMenuItem.Image = CType(resources.GetObject("ScanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ScanToolStripMenuItem.Name = "ScanToolStripMenuItem"
        Me.ScanToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ScanToolStripMenuItem.Text = "Scan"
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Image = CType(resources.GetObject("ShowToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ShowToolStripMenuItem.Text = "Restore V.E.R. to desktop"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(201, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Image = CType(resources.GetObject("ExitToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(204, 22)
        Me.ExitToolStripMenuItem1.Text = "Close and Exit V.E.R."
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "Working in background...."
        Me.NotifyIcon1.BalloonTipTitle = "Virus Effect Remover"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Virus Effect Remover"
        '
        'NotifyIconTimer
        '
        Me.NotifyIconTimer.Interval = 2000
        Me.NotifyIconTimer.Tag = "Work with notify icon to refresh status during background working."
        '
        'InfBox
        '
        Me.InfBox.FormattingEnabled = True
        Me.InfBox.Location = New System.Drawing.Point(7, 32)
        Me.InfBox.Name = "InfBox"
        Me.InfBox.Size = New System.Drawing.Size(138, 160)
        Me.InfBox.TabIndex = 146
        Me.InfBox.TabStop = False
        '
        'Filenamebox
        '
        Me.Filenamebox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Filenamebox.Location = New System.Drawing.Point(8, 16)
        Me.Filenamebox.Name = "Filenamebox"
        Me.Filenamebox.Size = New System.Drawing.Size(177, 20)
        Me.Filenamebox.TabIndex = 0
        Me.Filenamebox.TabStop = False
        Me.Filenamebox.Tag = "Enter file name with Extension."
        Me.Filenamebox.Text = "Enter file name with Extension."
        '
        'scanagain
        '
        Me.scanagain.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.scanagain.Location = New System.Drawing.Point(8, 38)
        Me.scanagain.Name = "scanagain"
        Me.scanagain.Size = New System.Drawing.Size(177, 23)
        Me.scanagain.TabIndex = 9
        Me.scanagain.TabStop = False
        Me.scanagain.Text = "Scan File"
        Me.scanagain.UseVisualStyleBackColor = True
        '
        'onehit
        '
        Me.onehit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.onehit.Location = New System.Drawing.Point(432, 107)
        Me.onehit.Name = "onehit"
        Me.onehit.Size = New System.Drawing.Size(177, 49)
        Me.onehit.TabIndex = 151
        Me.onehit.Text = "One Click Delete All"
        Me.onehit.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CheckBox1.Location = New System.Drawing.Point(0, 0)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(174, 17)
        Me.CheckBox1.TabIndex = 153
        Me.CheckBox1.Text = "Also delete autorun.inf file"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'AutorunBox1
        '
        Me.AutorunBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AutorunBox1.BackColor = System.Drawing.Color.White
        Me.AutorunBox1.DetectUrls = False
        Me.AutorunBox1.Location = New System.Drawing.Point(160, 32)
        Me.AutorunBox1.Name = "AutorunBox1"
        Me.AutorunBox1.ReadOnly = True
        Me.AutorunBox1.Size = New System.Drawing.Size(253, 160)
        Me.AutorunBox1.TabIndex = 147
        Me.AutorunBox1.TabStop = False
        Me.AutorunBox1.Text = "Autorunbox"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.Black
        Me.CheckBox2.Location = New System.Drawing.Point(0, 0)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(113, 19)
        Me.CheckBox2.TabIndex = 23
        Me.CheckBox2.Text = "Also Delete File"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'KillThis
        '
        Me.KillThis.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KillThis.Location = New System.Drawing.Point(6, 351)
        Me.KillThis.Name = "KillThis"
        Me.KillThis.Size = New System.Drawing.Size(122, 36)
        Me.KillThis.TabIndex = 22
        Me.KillThis.Text = "Kill Process"
        Me.KillThis.UseVisualStyleBackColor = True
        '
        'send2tray
        '
        Me.send2tray.AutoSize = True
        Me.send2tray.BackColor = System.Drawing.Color.Transparent
        Me.send2tray.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.send2tray.Location = New System.Drawing.Point(17, 51)
        Me.send2tray.Name = "send2tray"
        Me.send2tray.Size = New System.Drawing.Size(206, 20)
        Me.send2tray.TabIndex = 145
        Me.send2tray.Text = "Send V.E.R. to Tray at Startup."
        Me.send2tray.UseVisualStyleBackColor = False
        '
        'IGN_CDROM
        '
        Me.IGN_CDROM.AutoSize = True
        Me.IGN_CDROM.BackColor = System.Drawing.Color.Transparent
        Me.IGN_CDROM.Checked = True
        Me.IGN_CDROM.CheckState = System.Windows.Forms.CheckState.Checked
        Me.IGN_CDROM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IGN_CDROM.Location = New System.Drawing.Point(17, 103)
        Me.IGN_CDROM.Name = "IGN_CDROM"
        Me.IGN_CDROM.Size = New System.Drawing.Size(214, 20)
        Me.IGN_CDROM.TabIndex = 144
        Me.IGN_CDROM.Text = "Ignore CDROM and ROM drive."
        Me.IGN_CDROM.UseVisualStyleBackColor = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox8.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox8.Controls.Add(Me.RunTask)
        Me.GroupBox8.Controls.Add(Me.BrowseTask)
        Me.GroupBox8.Controls.Add(Me.TaskTabBox)
        Me.GroupBox8.ForeColor = System.Drawing.Color.Black
        Me.GroupBox8.Location = New System.Drawing.Point(31, 69)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(551, 48)
        Me.GroupBox8.TabIndex = 0
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "New Task :"
        '
        'RunTask
        '
        Me.RunTask.Location = New System.Drawing.Point(479, 14)
        Me.RunTask.Name = "RunTask"
        Me.RunTask.Size = New System.Drawing.Size(56, 26)
        Me.RunTask.TabIndex = 2
        Me.RunTask.Text = "Run"
        Me.RunTask.UseVisualStyleBackColor = True
        '
        'BrowseTask
        '
        Me.BrowseTask.Location = New System.Drawing.Point(407, 14)
        Me.BrowseTask.Name = "BrowseTask"
        Me.BrowseTask.Size = New System.Drawing.Size(66, 26)
        Me.BrowseTask.TabIndex = 1
        Me.BrowseTask.Text = "Browse"
        Me.BrowseTask.UseVisualStyleBackColor = True
        '
        'TaskTabBox
        '
        Me.TaskTabBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TaskTabBox.Location = New System.Drawing.Point(6, 17)
        Me.TaskTabBox.Name = "TaskTabBox"
        Me.TaskTabBox.Size = New System.Drawing.Size(395, 20)
        Me.TaskTabBox.TabIndex = 0
        Me.TaskTabBox.Tag = "Type the name of a program or folder & V.E.R.© will open it for you."
        Me.TaskTabBox.Text = "Type the name of a program or folder & V.E.R.© will open it for you."
        '
        'RemoveSystemHidden
        '
        Me.RemoveSystemHidden.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RemoveSystemHidden.Location = New System.Drawing.Point(13, 336)
        Me.RemoveSystemHidden.Name = "RemoveSystemHidden"
        Me.RemoveSystemHidden.Size = New System.Drawing.Size(168, 23)
        Me.RemoveSystemHidden.TabIndex = 16
        Me.RemoveSystemHidden.Text = "Remove System+Hidden Files"
        Me.RemoveSystemHidden.UseVisualStyleBackColor = True
        '
        'VisualiseAllFile
        '
        Me.VisualiseAllFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.VisualiseAllFile.Location = New System.Drawing.Point(13, 308)
        Me.VisualiseAllFile.Name = "VisualiseAllFile"
        Me.VisualiseAllFile.Size = New System.Drawing.Size(168, 23)
        Me.VisualiseAllFile.TabIndex = 15
        Me.VisualiseAllFile.Text = "Make All Files Visible"
        Me.VisualiseAllFile.UseVisualStyleBackColor = True
        '
        'RenameFileInList
        '
        Me.RenameFileInList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RenameFileInList.Location = New System.Drawing.Point(158, 337)
        Me.RenameFileInList.Name = "RenameFileInList"
        Me.RenameFileInList.Size = New System.Drawing.Size(85, 23)
        Me.RenameFileInList.TabIndex = 23
        Me.RenameFileInList.Text = "Rename"
        Me.RenameFileInList.UseVisualStyleBackColor = True
        '
        'DeleteFileInList
        '
        Me.DeleteFileInList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DeleteFileInList.Location = New System.Drawing.Point(270, 337)
        Me.DeleteFileInList.Name = "DeleteFileInList"
        Me.DeleteFileInList.Size = New System.Drawing.Size(85, 23)
        Me.DeleteFileInList.TabIndex = 22
        Me.DeleteFileInList.Text = "Delete"
        Me.DeleteFileInList.UseVisualStyleBackColor = True
        '
        'OnlySystemHidden
        '
        Me.OnlySystemHidden.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OnlySystemHidden.Location = New System.Drawing.Point(449, 173)
        Me.OnlySystemHidden.Name = "OnlySystemHidden"
        Me.OnlySystemHidden.Size = New System.Drawing.Size(153, 23)
        Me.OnlySystemHidden.TabIndex = 21
        Me.OnlySystemHidden.Text = "System+Hidden"
        Me.OnlySystemHidden.UseVisualStyleBackColor = True
        '
        'ShowAlllSytemFile
        '
        Me.ShowAlllSytemFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShowAlllSytemFile.Location = New System.Drawing.Point(449, 149)
        Me.ShowAlllSytemFile.Name = "ShowAlllSytemFile"
        Me.ShowAlllSytemFile.Size = New System.Drawing.Size(153, 23)
        Me.ShowAlllSytemFile.TabIndex = 20
        Me.ShowAlllSytemFile.Text = "Only System"
        Me.ShowAlllSytemFile.UseVisualStyleBackColor = True
        '
        'ShowAllFile
        '
        Me.ShowAllFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShowAllFile.Location = New System.Drawing.Point(449, 71)
        Me.ShowAllFile.Name = "ShowAllFile"
        Me.ShowAllFile.Size = New System.Drawing.Size(153, 23)
        Me.ShowAllFile.TabIndex = 18
        Me.ShowAllFile.Text = "ALL Files"
        Me.ShowAllFile.UseVisualStyleBackColor = True
        '
        'BrowseDir
        '
        Me.BrowseDir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowseDir.Location = New System.Drawing.Point(360, 12)
        Me.BrowseDir.Name = "BrowseDir"
        Me.BrowseDir.Size = New System.Drawing.Size(65, 25)
        Me.BrowseDir.TabIndex = 17
        Me.BrowseDir.Text = "Browse"
        Me.BrowseDir.UseVisualStyleBackColor = True
        '
        'ShowAllHiddenFile
        '
        Me.ShowAllHiddenFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShowAllHiddenFile.Location = New System.Drawing.Point(449, 125)
        Me.ShowAllHiddenFile.Name = "ShowAllHiddenFile"
        Me.ShowAllHiddenFile.Size = New System.Drawing.Size(153, 23)
        Me.ShowAllHiddenFile.TabIndex = 13
        Me.ShowAllHiddenFile.Text = "Only Hidden"
        Me.ShowAllHiddenFile.UseVisualStyleBackColor = True
        '
        'EnableProcessFilter
        '
        Me.EnableProcessFilter.AutoSize = True
        Me.EnableProcessFilter.BackColor = System.Drawing.Color.Transparent
        Me.EnableProcessFilter.Checked = True
        Me.EnableProcessFilter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EnableProcessFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnableProcessFilter.Location = New System.Drawing.Point(17, 155)
        Me.EnableProcessFilter.Name = "EnableProcessFilter"
        Me.EnableProcessFilter.Size = New System.Drawing.Size(153, 20)
        Me.EnableProcessFilter.TabIndex = 154
        Me.EnableProcessFilter.Text = "Enable Process filter."
        Me.EnableProcessFilter.UseVisualStyleBackColor = False
        '
        'HideButton
        '
        Me.HideButton.BackColor = System.Drawing.Color.Transparent
        Me.HideButton.BackgroundImage = Global.Virus_Effect_Remover.My.Resources.Resources.arrow_down_48
        Me.HideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HideButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.HideButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.HideButton.FlatAppearance.BorderSize = 0
        Me.HideButton.Location = New System.Drawing.Point(708, 0)
        Me.HideButton.Name = "HideButton"
        Me.HideButton.Size = New System.Drawing.Size(28, 30)
        Me.HideButton.TabIndex = 16
        Me.HideButton.TabStop = False
        Me.HideButton.UseVisualStyleBackColor = False
        '
        'AddStartup
        '
        Me.AddStartup.AutoSize = True
        Me.AddStartup.BackColor = System.Drawing.Color.Transparent
        Me.AddStartup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddStartup.Location = New System.Drawing.Point(17, 25)
        Me.AddStartup.Name = "AddStartup"
        Me.AddStartup.Size = New System.Drawing.Size(242, 20)
        Me.AddStartup.TabIndex = 139
        Me.AddStartup.Text = "Add Virus Effect Remover to Startup."
        Me.AddStartup.UseVisualStyleBackColor = False
        '
        'MinimizeButton
        '
        Me.MinimizeButton.BackColor = System.Drawing.Color.Transparent
        Me.MinimizeButton.BackgroundImage = CType(resources.GetObject("MinimizeButton.BackgroundImage"), System.Drawing.Image)
        Me.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.MinimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.MinimizeButton.FlatAppearance.BorderSize = 0
        Me.MinimizeButton.ForeColor = System.Drawing.Color.Transparent
        Me.MinimizeButton.Location = New System.Drawing.Point(680, 0)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(28, 30)
        Me.MinimizeButton.TabIndex = 15
        Me.MinimizeButton.TabStop = False
        Me.MinimizeButton.UseVisualStyleBackColor = False
        '
        'EndButton
        '
        Me.EndButton.BackColor = System.Drawing.Color.Transparent
        Me.EndButton.BackgroundImage = Global.Virus_Effect_Remover.My.Resources.Resources.close_32
        Me.EndButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.EndButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.EndButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.EndButton.FlatAppearance.BorderSize = 0
        Me.EndButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EndButton.Location = New System.Drawing.Point(764, 0)
        Me.EndButton.Name = "EndButton"
        Me.EndButton.Size = New System.Drawing.Size(28, 30)
        Me.EndButton.TabIndex = 17
        Me.EndButton.TabStop = False
        Me.EndButton.UseVisualStyleBackColor = False
        '
        'BR2
        '
        Me.BR2.Location = New System.Drawing.Point(498, 15)
        Me.BR2.Name = "BR2"
        Me.BR2.Size = New System.Drawing.Size(82, 23)
        Me.BR2.TabIndex = 34
        Me.BR2.Text = "Browse"
        Me.BR2.UseVisualStyleBackColor = True
        '
        'ExtBox
        '
        Me.ExtBox.Location = New System.Drawing.Point(152, 41)
        Me.ExtBox.Multiline = True
        Me.ExtBox.Name = "ExtBox"
        Me.ExtBox.Size = New System.Drawing.Size(66, 58)
        Me.ExtBox.TabIndex = 1
        '
        'DelFileWithExt
        '
        Me.DelFileWithExt.Location = New System.Drawing.Point(11, 37)
        Me.DelFileWithExt.Name = "DelFileWithExt"
        Me.DelFileWithExt.Size = New System.Drawing.Size(106, 23)
        Me.DelFileWithExt.TabIndex = 0
        Me.DelFileWithExt.Text = "Delete File(s)"
        Me.DelFileWithExt.UseVisualStyleBackColor = True
        '
        'delAF
        '
        Me.delAF.Location = New System.Drawing.Point(11, 15)
        Me.delAF.Name = "delAF"
        Me.delAF.Size = New System.Drawing.Size(176, 23)
        Me.delAF.TabIndex = 24
        Me.delAF.Text = "Delete All files in this Folder"
        Me.delAF.UseVisualStyleBackColor = True
        '
        'RecycleBinBox
        '
        Me.RecycleBinBox.AutoSize = True
        Me.RecycleBinBox.Location = New System.Drawing.Point(24, 21)
        Me.RecycleBinBox.Name = "RecycleBinBox"
        Me.RecycleBinBox.Size = New System.Drawing.Size(127, 17)
        Me.RecycleBinBox.TabIndex = 26
        Me.RecycleBinBox.Text = "Send To Recycle Bin"
        Me.RecycleBinBox.UseVisualStyleBackColor = True
        '
        'FDel
        '
        Me.FDel.AutoSize = True
        Me.FDel.Location = New System.Drawing.Point(24, 44)
        Me.FDel.Name = "FDel"
        Me.FDel.Size = New System.Drawing.Size(101, 17)
        Me.FDel.TabIndex = 25
        Me.FDel.Text = "Forced Deletion"
        Me.FDel.UseVisualStyleBackColor = True
        '
        'FilesAllowedToDeleteBox
        '
        Me.FilesAllowedToDeleteBox.BackColor = System.Drawing.Color.White
        Me.FilesAllowedToDeleteBox.Location = New System.Drawing.Point(6, 65)
        Me.FilesAllowedToDeleteBox.Multiline = True
        Me.FilesAllowedToDeleteBox.Name = "FilesAllowedToDeleteBox"
        Me.FilesAllowedToDeleteBox.Size = New System.Drawing.Size(188, 90)
        Me.FilesAllowedToDeleteBox.TabIndex = 30
        Me.FilesAllowedToDeleteBox.Text = "desktop.ini" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Thumbs.db" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "desktop_.ini"
        '
        'DirLocation
        '
        Me.DirLocation.ForeColor = System.Drawing.SystemColors.GrayText
        Me.DirLocation.Location = New System.Drawing.Point(82, 17)
        Me.DirLocation.Name = "DirLocation"
        Me.DirLocation.Size = New System.Drawing.Size(388, 20)
        Me.DirLocation.TabIndex = 19
        Me.DirLocation.Tag = "Enter folder name with complete path."
        Me.DirLocation.Text = "Enter folder name with complete path."
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(534, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(205, 15)
        Me.Label10.TabIndex = 186
        Me.Label10.Text = "NEXT Test Copy : Reference 2010-02-24"
        Me.Label10.Visible = False
        '
        'MaximizeButton
        '
        Me.MaximizeButton.BackColor = System.Drawing.Color.Transparent
        Me.MaximizeButton.BackgroundImage = Global.Virus_Effect_Remover.My.Resources.Resources.Window
        Me.MaximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MaximizeButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.MaximizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.MaximizeButton.FlatAppearance.BorderSize = 0
        Me.MaximizeButton.ForeColor = System.Drawing.Color.Transparent
        Me.MaximizeButton.Location = New System.Drawing.Point(736, 0)
        Me.MaximizeButton.Name = "MaximizeButton"
        Me.MaximizeButton.Size = New System.Drawing.Size(28, 30)
        Me.MaximizeButton.TabIndex = 196
        Me.MaximizeButton.TabStop = False
        Me.MaximizeButton.UseVisualStyleBackColor = False
        '
        'GetdrvProperty
        '
        Me.GetdrvProperty.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GetdrvProperty.Location = New System.Drawing.Point(413, 333)
        Me.GetdrvProperty.Name = "GetdrvProperty"
        Me.GetdrvProperty.Size = New System.Drawing.Size(152, 23)
        Me.GetdrvProperty.TabIndex = 21
        Me.GetdrvProperty.Text = "Get Drive Properties"
        Me.GetdrvProperty.UseVisualStyleBackColor = True
        '
        'DDFileDetail
        '
        Me.DDFileDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DDFileDetail.Location = New System.Drawing.Point(45, 337)
        Me.DDFileDetail.Name = "DDFileDetail"
        Me.DDFileDetail.Size = New System.Drawing.Size(85, 23)
        Me.DDFileDetail.TabIndex = 24
        Me.DDFileDetail.Text = "File Details"
        Me.DDFileDetail.UseVisualStyleBackColor = True
        '
        'FileAttributeApply
        '
        Me.FileAttributeApply.Location = New System.Drawing.Point(53, 108)
        Me.FileAttributeApply.Name = "FileAttributeApply"
        Me.FileAttributeApply.Size = New System.Drawing.Size(88, 23)
        Me.FileAttributeApply.TabIndex = 8
        Me.FileAttributeApply.Text = "Apply"
        Me.FileAttributeApply.UseVisualStyleBackColor = True
        '
        'BT1
        '
        Me.BT1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT1.Location = New System.Drawing.Point(393, 6)
        Me.BT1.Name = "BT1"
        Me.BT1.Size = New System.Drawing.Size(74, 23)
        Me.BT1.TabIndex = 2
        Me.BT1.Text = "Browse"
        Me.BT1.UseVisualStyleBackColor = True
        '
        'ModuleList
        '
        Me.ModuleList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModuleList.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ModuleList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ModuleName, Me.MOduleDescription, Me.modulePathPan, Me.ModuleBaseAddress})
        Me.ModuleList.ContextMenuStrip = Me.ModuleListStrip
        Me.ModuleList.FullRowSelect = True
        Me.ModuleList.GridLines = True
        Me.ModuleList.Location = New System.Drawing.Point(3, 59)
        Me.ModuleList.MultiSelect = False
        Me.ModuleList.Name = "ModuleList"
        Me.ModuleList.Size = New System.Drawing.Size(342, 301)
        Me.ModuleList.SmallImageList = Me.ModuleListImage
        Me.ModuleList.TabIndex = 3
        Me.ModuleList.UseCompatibleStateImageBehavior = False
        Me.ModuleList.View = System.Windows.Forms.View.Details
        '
        'ModuleName
        '
        Me.ModuleName.Text = "Module Name"
        Me.ModuleName.Width = 111
        '
        'MOduleDescription
        '
        Me.MOduleDescription.Text = "Module Descriptipn"
        Me.MOduleDescription.Width = 173
        '
        'modulePathPan
        '
        Me.modulePathPan.Text = "Module Path"
        Me.modulePathPan.Width = 248
        '
        'ModuleBaseAddress
        '
        Me.ModuleBaseAddress.Text = "Base Address"
        Me.ModuleBaseAddress.Width = 95
        '
        'ModuleListStrip
        '
        Me.ModuleListStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GetAllProcessUsingThisModuleToolStripMenuItem, Me.GetModuleFilePropertyToolStripMenuItem, Me.ToolStripSeparator14, Me.ReleaseSelectedModuleToolStripMenuItem, Me.ToolStripSeparator13, Me.OpenLocationOfModuleToolStripMenuItem, Me.CopyFileToolStripMenuItem2, Me.CopyFilePathToolStripMenuItem2})
        Me.ModuleListStrip.Name = "ModuleListStrip"
        Me.ModuleListStrip.Size = New System.Drawing.Size(322, 148)
        '
        'GetAllProcessUsingThisModuleToolStripMenuItem
        '
        Me.GetAllProcessUsingThisModuleToolStripMenuItem.Image = CType(resources.GetObject("GetAllProcessUsingThisModuleToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GetAllProcessUsingThisModuleToolStripMenuItem.Name = "GetAllProcessUsingThisModuleToolStripMenuItem"
        Me.GetAllProcessUsingThisModuleToolStripMenuItem.Size = New System.Drawing.Size(321, 22)
        Me.GetAllProcessUsingThisModuleToolStripMenuItem.Text = "Get All Processes Using This Module"
        '
        'GetModuleFilePropertyToolStripMenuItem
        '
        Me.GetModuleFilePropertyToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.information
        Me.GetModuleFilePropertyToolStripMenuItem.Name = "GetModuleFilePropertyToolStripMenuItem"
        Me.GetModuleFilePropertyToolStripMenuItem.Size = New System.Drawing.Size(321, 22)
        Me.GetModuleFilePropertyToolStripMenuItem.Text = "Get Module File's Properties"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(318, 6)
        '
        'ReleaseSelectedModuleToolStripMenuItem
        '
        Me.ReleaseSelectedModuleToolStripMenuItem.Image = CType(resources.GetObject("ReleaseSelectedModuleToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReleaseSelectedModuleToolStripMenuItem.Name = "ReleaseSelectedModuleToolStripMenuItem"
        Me.ReleaseSelectedModuleToolStripMenuItem.Size = New System.Drawing.Size(321, 22)
        Me.ReleaseSelectedModuleToolStripMenuItem.Text = "Release Selected Module From Current Process"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(318, 6)
        '
        'OpenLocationOfModuleToolStripMenuItem
        '
        Me.OpenLocationOfModuleToolStripMenuItem.Image = CType(resources.GetObject("OpenLocationOfModuleToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenLocationOfModuleToolStripMenuItem.Name = "OpenLocationOfModuleToolStripMenuItem"
        Me.OpenLocationOfModuleToolStripMenuItem.Size = New System.Drawing.Size(321, 22)
        Me.OpenLocationOfModuleToolStripMenuItem.Text = "Open Location of Module"
        '
        'CopyFileToolStripMenuItem2
        '
        Me.CopyFileToolStripMenuItem2.Image = CType(resources.GetObject("CopyFileToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.CopyFileToolStripMenuItem2.Name = "CopyFileToolStripMenuItem2"
        Me.CopyFileToolStripMenuItem2.Size = New System.Drawing.Size(321, 22)
        Me.CopyFileToolStripMenuItem2.Text = "Copy File"
        '
        'CopyFilePathToolStripMenuItem2
        '
        Me.CopyFilePathToolStripMenuItem2.Image = CType(resources.GetObject("CopyFilePathToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.CopyFilePathToolStripMenuItem2.Name = "CopyFilePathToolStripMenuItem2"
        Me.CopyFilePathToolStripMenuItem2.Size = New System.Drawing.Size(321, 22)
        Me.CopyFilePathToolStripMenuItem2.Text = "Copy File Path"
        '
        'ModuleListImage
        '
        Me.ModuleListImage.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ModuleListImage.ImageSize = New System.Drawing.Size(18, 18)
        Me.ModuleListImage.TransparentColor = System.Drawing.Color.Transparent
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.Filenamebox)
        Me.GroupBox6.Controls.Add(Me.scanagain)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Black
        Me.GroupBox6.Location = New System.Drawing.Point(424, 32)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(194, 66)
        Me.GroupBox6.TabIndex = 150
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "I know this is a Virus:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 13)
        Me.Label2.TabIndex = 152
        Me.Label2.Text = "Process(s) with same name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "Associated file(s)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(6, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 13)
        Me.Label4.TabIndex = 157
        Me.Label4.Text = "Detected AutoRun File(s)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(157, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 158
        Me.Label5.Text = "Autorun File Content"
        '
        'FileFoundLV
        '
        Me.FileFoundLV.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.FileFoundLV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader11})
        Me.FileFoundLV.ContextMenuStrip = Me.FileFoundLVContextMenu
        Me.FileFoundLV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FileFoundLV.FullRowSelect = True
        Me.FileFoundLV.GridLines = True
        Me.FileFoundLV.Location = New System.Drawing.Point(0, 13)
        Me.FileFoundLV.MultiSelect = False
        Me.FileFoundLV.Name = "FileFoundLV"
        Me.FileFoundLV.Size = New System.Drawing.Size(313, 177)
        Me.FileFoundLV.SmallImageList = Me.ImLAutoRT
        Me.FileFoundLV.TabIndex = 160
        Me.FileFoundLV.UseCompatibleStateImageBehavior = False
        Me.FileFoundLV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "File Name"
        Me.ColumnHeader1.Width = 114
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Size"
        Me.ColumnHeader2.Width = 58
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "File Path"
        Me.ColumnHeader11.Width = 337
        '
        'FileFoundLVContextMenu
        '
        Me.FileFoundLVContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LocateFileToolStripMenuItem, Me.GetCompleteDetailToolStripMenuItem, Me.DeleteFileToolStripMenuItem, Me.ToolStripSeparator23, Me.CopyFileToolStripMenuItem3, Me.CopyPathToolStripMenuItem, Me.ToolStripSeparator24, Me.RemoveThisEntryFromListToolStripMenuItem1})
        Me.FileFoundLVContextMenu.Name = "FileFoundLVContextMenu"
        Me.FileFoundLVContextMenu.Size = New System.Drawing.Size(217, 148)
        '
        'LocateFileToolStripMenuItem
        '
        Me.LocateFileToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.folder_go
        Me.LocateFileToolStripMenuItem.Name = "LocateFileToolStripMenuItem"
        Me.LocateFileToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.LocateFileToolStripMenuItem.Text = "Locate File"
        '
        'GetCompleteDetailToolStripMenuItem
        '
        Me.GetCompleteDetailToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.information
        Me.GetCompleteDetailToolStripMenuItem.Name = "GetCompleteDetailToolStripMenuItem"
        Me.GetCompleteDetailToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.GetCompleteDetailToolStripMenuItem.Text = "Get File Properties"
        '
        'DeleteFileToolStripMenuItem
        '
        Me.DeleteFileToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.cross
        Me.DeleteFileToolStripMenuItem.Name = "DeleteFileToolStripMenuItem"
        Me.DeleteFileToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.DeleteFileToolStripMenuItem.Text = "Delete File"
        '
        'ToolStripSeparator23
        '
        Me.ToolStripSeparator23.Name = "ToolStripSeparator23"
        Me.ToolStripSeparator23.Size = New System.Drawing.Size(213, 6)
        '
        'CopyFileToolStripMenuItem3
        '
        Me.CopyFileToolStripMenuItem3.Image = Global.Virus_Effect_Remover.My.Resources.Resources.door_out
        Me.CopyFileToolStripMenuItem3.Name = "CopyFileToolStripMenuItem3"
        Me.CopyFileToolStripMenuItem3.Size = New System.Drawing.Size(216, 22)
        Me.CopyFileToolStripMenuItem3.Text = "Copy File"
        '
        'CopyPathToolStripMenuItem
        '
        Me.CopyPathToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.page_copy
        Me.CopyPathToolStripMenuItem.Name = "CopyPathToolStripMenuItem"
        Me.CopyPathToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.CopyPathToolStripMenuItem.Text = "Copy Path"
        '
        'ToolStripSeparator24
        '
        Me.ToolStripSeparator24.Name = "ToolStripSeparator24"
        Me.ToolStripSeparator24.Size = New System.Drawing.Size(213, 6)
        '
        'RemoveThisEntryFromListToolStripMenuItem1
        '
        Me.RemoveThisEntryFromListToolStripMenuItem1.Image = Global.Virus_Effect_Remover.My.Resources.Resources.cancel_16
        Me.RemoveThisEntryFromListToolStripMenuItem1.Name = "RemoveThisEntryFromListToolStripMenuItem1"
        Me.RemoveThisEntryFromListToolStripMenuItem1.Size = New System.Drawing.Size(216, 22)
        Me.RemoveThisEntryFromListToolStripMenuItem1.Text = "Remove this entry from list"
        '
        'ImLAutoRT
        '
        Me.ImLAutoRT.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImLAutoRT.ImageSize = New System.Drawing.Size(18, 18)
        Me.ImLAutoRT.Tag = "Image list for autorun tab"
        Me.ImLAutoRT.TransparentColor = System.Drawing.Color.Transparent
        '
        'ProList
        '
        Me.ProList.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ProList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader10})
        Me.ProList.ContextMenuStrip = Me.ProListContextMenu
        Me.ProList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProList.FullRowSelect = True
        Me.ProList.GridLines = True
        Me.ProList.Location = New System.Drawing.Point(0, 13)
        Me.ProList.MultiSelect = False
        Me.ProList.Name = "ProList"
        Me.ProList.Size = New System.Drawing.Size(302, 177)
        Me.ProList.SmallImageList = Me.ImLAutoRT
        Me.ProList.TabIndex = 161
        Me.ProList.UseCompatibleStateImageBehavior = False
        Me.ProList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Process"
        Me.ColumnHeader4.Width = 108
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ID"
        Me.ColumnHeader5.Width = 59
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Process Path"
        Me.ColumnHeader10.Width = 340
        '
        'ProListContextMenu
        '
        Me.ProListContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LocateProcessInProcessListToolStripMenuItem, Me.ToolStripSeparator19, Me.KillProcessToolStripMenuItem4, Me.KillProcessAndDeleteProcessFileToolStripMenuItem, Me.ToolStripSeparator21, Me.GetDetailToolStripMenuItem, Me.GetProcessFilePropertyToolStripMenuItem, Me.GetModuleListToolStripMenuItem, Me.ToolStripSeparator18, Me.CopyExecutableToolStripMenuItem, Me.CopyExecutablePathToolStripMenuItem, Me.ToolStripSeparator20, Me.LocateExecutableFileToolStripMenuItem, Me.RemoveThisEntryFromListToolStripMenuItem})
        Me.ProListContextMenu.Name = "ProListContextMenu"
        Me.ProListContextMenu.Size = New System.Drawing.Size(262, 248)
        '
        'LocateProcessInProcessListToolStripMenuItem
        '
        Me.LocateProcessInProcessListToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.find
        Me.LocateProcessInProcessListToolStripMenuItem.Name = "LocateProcessInProcessListToolStripMenuItem"
        Me.LocateProcessInProcessListToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
        Me.LocateProcessInProcessListToolStripMenuItem.Text = "Locate Process in Process List"
        '
        'ToolStripSeparator19
        '
        Me.ToolStripSeparator19.Name = "ToolStripSeparator19"
        Me.ToolStripSeparator19.Size = New System.Drawing.Size(258, 6)
        '
        'KillProcessToolStripMenuItem4
        '
        Me.KillProcessToolStripMenuItem4.Image = Global.Virus_Effect_Remover.My.Resources.Resources.cross
        Me.KillProcessToolStripMenuItem4.Name = "KillProcessToolStripMenuItem4"
        Me.KillProcessToolStripMenuItem4.Size = New System.Drawing.Size(261, 22)
        Me.KillProcessToolStripMenuItem4.Text = "Kill Process"
        '
        'KillProcessAndDeleteProcessFileToolStripMenuItem
        '
        Me.KillProcessAndDeleteProcessFileToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.delete
        Me.KillProcessAndDeleteProcessFileToolStripMenuItem.Name = "KillProcessAndDeleteProcessFileToolStripMenuItem"
        Me.KillProcessAndDeleteProcessFileToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
        Me.KillProcessAndDeleteProcessFileToolStripMenuItem.Text = "Kill process and delete process File"
        '
        'ToolStripSeparator21
        '
        Me.ToolStripSeparator21.Name = "ToolStripSeparator21"
        Me.ToolStripSeparator21.Size = New System.Drawing.Size(258, 6)
        '
        'GetDetailToolStripMenuItem
        '
        Me.GetDetailToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.information
        Me.GetDetailToolStripMenuItem.Name = "GetDetailToolStripMenuItem"
        Me.GetDetailToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
        Me.GetDetailToolStripMenuItem.Text = "Get Process General Detail"
        '
        'GetProcessFilePropertyToolStripMenuItem
        '
        Me.GetProcessFilePropertyToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.information
        Me.GetProcessFilePropertyToolStripMenuItem.Name = "GetProcessFilePropertyToolStripMenuItem"
        Me.GetProcessFilePropertyToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
        Me.GetProcessFilePropertyToolStripMenuItem.Text = "Get Process File Properties"
        '
        'GetModuleListToolStripMenuItem
        '
        Me.GetModuleListToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.information
        Me.GetModuleListToolStripMenuItem.Name = "GetModuleListToolStripMenuItem"
        Me.GetModuleListToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
        Me.GetModuleListToolStripMenuItem.Text = "Get Module List of Selected Process"
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(258, 6)
        '
        'CopyExecutableToolStripMenuItem
        '
        Me.CopyExecutableToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.door_out
        Me.CopyExecutableToolStripMenuItem.Name = "CopyExecutableToolStripMenuItem"
        Me.CopyExecutableToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
        Me.CopyExecutableToolStripMenuItem.Text = "Copy Executable"
        '
        'CopyExecutablePathToolStripMenuItem
        '
        Me.CopyExecutablePathToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.page_copy
        Me.CopyExecutablePathToolStripMenuItem.Name = "CopyExecutablePathToolStripMenuItem"
        Me.CopyExecutablePathToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
        Me.CopyExecutablePathToolStripMenuItem.Text = "Copy Executable Path"
        '
        'ToolStripSeparator20
        '
        Me.ToolStripSeparator20.Name = "ToolStripSeparator20"
        Me.ToolStripSeparator20.Size = New System.Drawing.Size(258, 6)
        '
        'LocateExecutableFileToolStripMenuItem
        '
        Me.LocateExecutableFileToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.folder_go
        Me.LocateExecutableFileToolStripMenuItem.Name = "LocateExecutableFileToolStripMenuItem"
        Me.LocateExecutableFileToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
        Me.LocateExecutableFileToolStripMenuItem.Text = "Locate Executable File"
        '
        'RemoveThisEntryFromListToolStripMenuItem
        '
        Me.RemoveThisEntryFromListToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.cancel_16
        Me.RemoveThisEntryFromListToolStripMenuItem.Name = "RemoveThisEntryFromListToolStripMenuItem"
        Me.RemoveThisEntryFromListToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
        Me.RemoveThisEntryFromListToolStripMenuItem.Text = "Remove this Entry from list"
        '
        'MainTabControl
        '
        Me.MainTabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainTabControl.Controls.Add(Me.MainPage)
        Me.MainTabControl.Controls.Add(Me.AutorunPanelPage)
        Me.MainTabControl.Controls.Add(Me.ProcessDetailPage)
        Me.MainTabControl.Controls.Add(Me.FolderOptionPage)
        Me.MainTabControl.Controls.Add(Me.UnlockerPage)
        Me.MainTabControl.Controls.Add(Me.OtherToolPage)
        Me.MainTabControl.Controls.Add(Me.SettingPage)
        Me.MainTabControl.Cursor = System.Windows.Forms.Cursors.Default
        Me.MainTabControl.ImageList = Me.FixedImageList
        Me.MainTabControl.Location = New System.Drawing.Point(148, 39)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(639, 427)
        Me.MainTabControl.TabIndex = 0
        '
        'MainPage
        '
        Me.MainPage.BackColor = System.Drawing.Color.Transparent
        Me.MainPage.BackgroundImage = Global.Virus_Effect_Remover.My.Resources.Resources.tick_16
        Me.MainPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainPage.Controls.Add(Me.GroupBox5)
        Me.MainPage.Controls.Add(Me.GroupBox3)
        Me.MainPage.Controls.Add(Me.GroupBox4)
        Me.MainPage.Controls.Add(Me.GroupBox1)
        Me.MainPage.Controls.Add(Me.GroupBox2)
        Me.MainPage.ImageKey = "(none)"
        Me.MainPage.Location = New System.Drawing.Point(4, 23)
        Me.MainPage.Name = "MainPage"
        Me.MainPage.Padding = New System.Windows.Forms.Padding(3)
        Me.MainPage.Size = New System.Drawing.Size(631, 400)
        Me.MainPage.TabIndex = 0
        Me.MainPage.Text = " Main"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.ProTree)
        Me.GroupBox5.Controls.Add(Me.ProTreeTextBox)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(363, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(265, 392)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Process Tree :"
        '
        'ProTree
        '
        Me.ProTree.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ProTree.ContextMenuStrip = Me.ListView1Strip
        Me.ProTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProTree.FullRowSelect = True
        Me.ProTree.ImageIndex = 0
        Me.ProTree.ImageList = Me.ImageList2
        Me.ProTree.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ProTree.Location = New System.Drawing.Point(3, 16)
        Me.ProTree.Name = "ProTree"
        Me.ProTree.SelectedImageIndex = 0
        Me.ProTree.ShowNodeToolTips = True
        Me.ProTree.Size = New System.Drawing.Size(259, 353)
        Me.ProTree.TabIndex = 14
        Me.ProTree.Tag = "Process Tree"
        '
        'ListView1Strip
        '
        Me.ListView1Strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KillProcessToolStripMenuItem, Me.RestratProcessToolStripMenuItem, Me.GetRelatedModuleToolStripMenuItem, Me.ToolStripSeparator4, Me.SuspendProcessToolStripMenuItem, Me.ResumeProcessToolStripMenuItem, Me.ToolStripSeparator5, Me.GetGeneralDetailToolStripMenuItem, Me.GetProcessFilePropertyToolStripMenuItem2, Me.ToolStripSeparator26, Me.AffinityToolStripMenuItem, Me.PriorityToolStripMenuItem, Me.ToolStripSeparator16, Me.OptionsToolStripMenuItem})
        Me.ListView1Strip.Name = "ProcessListStrip"
        Me.ListView1Strip.Size = New System.Drawing.Size(217, 248)
        Me.ListView1Strip.Tag = "Used in process tree"
        '
        'KillProcessToolStripMenuItem
        '
        Me.KillProcessToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnlyKillProcessToolStripMenuItem, Me.KillProcessToolStripMenuItem3})
        Me.KillProcessToolStripMenuItem.Image = CType(resources.GetObject("KillProcessToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KillProcessToolStripMenuItem.Name = "KillProcessToolStripMenuItem"
        Me.KillProcessToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.KillProcessToolStripMenuItem.Text = "Kill process"
        '
        'OnlyKillProcessToolStripMenuItem
        '
        Me.OnlyKillProcessToolStripMenuItem.Image = CType(resources.GetObject("OnlyKillProcessToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OnlyKillProcessToolStripMenuItem.Name = "OnlyKillProcessToolStripMenuItem"
        Me.OnlyKillProcessToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.OnlyKillProcessToolStripMenuItem.Text = "Only Kill Process"
        '
        'KillProcessToolStripMenuItem3
        '
        Me.KillProcessToolStripMenuItem3.Image = CType(resources.GetObject("KillProcessToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.KillProcessToolStripMenuItem3.Name = "KillProcessToolStripMenuItem3"
        Me.KillProcessToolStripMenuItem3.Size = New System.Drawing.Size(272, 22)
        Me.KillProcessToolStripMenuItem3.Text = "Kill Process and delete Associated File"
        '
        'RestratProcessToolStripMenuItem
        '
        Me.RestratProcessToolStripMenuItem.Image = CType(resources.GetObject("RestratProcessToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RestratProcessToolStripMenuItem.Name = "RestratProcessToolStripMenuItem"
        Me.RestratProcessToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.RestratProcessToolStripMenuItem.Text = "Restart Process"
        '
        'GetRelatedModuleToolStripMenuItem
        '
        Me.GetRelatedModuleToolStripMenuItem.Image = CType(resources.GetObject("GetRelatedModuleToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GetRelatedModuleToolStripMenuItem.Name = "GetRelatedModuleToolStripMenuItem"
        Me.GetRelatedModuleToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.GetRelatedModuleToolStripMenuItem.Text = "Get Related Module(s)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(213, 6)
        '
        'SuspendProcessToolStripMenuItem
        '
        Me.SuspendProcessToolStripMenuItem.Image = CType(resources.GetObject("SuspendProcessToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SuspendProcessToolStripMenuItem.Name = "SuspendProcessToolStripMenuItem"
        Me.SuspendProcessToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.SuspendProcessToolStripMenuItem.Text = "Suspend Process"
        '
        'ResumeProcessToolStripMenuItem
        '
        Me.ResumeProcessToolStripMenuItem.Image = CType(resources.GetObject("ResumeProcessToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ResumeProcessToolStripMenuItem.Name = "ResumeProcessToolStripMenuItem"
        Me.ResumeProcessToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ResumeProcessToolStripMenuItem.Text = "Resume Process"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(213, 6)
        '
        'GetGeneralDetailToolStripMenuItem
        '
        Me.GetGeneralDetailToolStripMenuItem.Image = CType(resources.GetObject("GetGeneralDetailToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GetGeneralDetailToolStripMenuItem.Name = "GetGeneralDetailToolStripMenuItem"
        Me.GetGeneralDetailToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.GetGeneralDetailToolStripMenuItem.Text = "Get Process General Details"
        '
        'GetProcessFilePropertyToolStripMenuItem2
        '
        Me.GetProcessFilePropertyToolStripMenuItem2.Image = Global.Virus_Effect_Remover.My.Resources.Resources.information
        Me.GetProcessFilePropertyToolStripMenuItem2.Name = "GetProcessFilePropertyToolStripMenuItem2"
        Me.GetProcessFilePropertyToolStripMenuItem2.Size = New System.Drawing.Size(216, 22)
        Me.GetProcessFilePropertyToolStripMenuItem2.Text = "Get Process File Properties"
        '
        'ToolStripSeparator26
        '
        Me.ToolStripSeparator26.Name = "ToolStripSeparator26"
        Me.ToolStripSeparator26.Size = New System.Drawing.Size(213, 6)
        '
        'AffinityToolStripMenuItem
        '
        Me.AffinityToolStripMenuItem.Enabled = False
        Me.AffinityToolStripMenuItem.Name = "AffinityToolStripMenuItem"
        Me.AffinityToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.AffinityToolStripMenuItem.Text = "Affinity"
        '
        'PriorityToolStripMenuItem
        '
        Me.PriorityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RealTimeToolStripMenuItem, Me.HighToolStripMenuItem, Me.AboveNormalToolStripMenuItem, Me.NormalToolStripMenuItem, Me.BelowNormalToolStripMenuItem, Me.IdleToolStripMenuItem})
        Me.PriorityToolStripMenuItem.Enabled = False
        Me.PriorityToolStripMenuItem.Name = "PriorityToolStripMenuItem"
        Me.PriorityToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.PriorityToolStripMenuItem.Text = "Priority"
        '
        'RealTimeToolStripMenuItem
        '
        Me.RealTimeToolStripMenuItem.Name = "RealTimeToolStripMenuItem"
        Me.RealTimeToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.RealTimeToolStripMenuItem.Text = "Real Time"
        '
        'HighToolStripMenuItem
        '
        Me.HighToolStripMenuItem.Name = "HighToolStripMenuItem"
        Me.HighToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.HighToolStripMenuItem.Text = "High"
        '
        'AboveNormalToolStripMenuItem
        '
        Me.AboveNormalToolStripMenuItem.Name = "AboveNormalToolStripMenuItem"
        Me.AboveNormalToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.AboveNormalToolStripMenuItem.Text = "Above Normal"
        '
        'NormalToolStripMenuItem
        '
        Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        Me.NormalToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.NormalToolStripMenuItem.Text = "Normal"
        '
        'BelowNormalToolStripMenuItem
        '
        Me.BelowNormalToolStripMenuItem.Name = "BelowNormalToolStripMenuItem"
        Me.BelowNormalToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.BelowNormalToolStripMenuItem.Text = "Below Normal"
        '
        'IdleToolStripMenuItem
        '
        Me.IdleToolStripMenuItem.Name = "IdleToolStripMenuItem"
        Me.IdleToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.IdleToolStripMenuItem.Text = "Idle"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(213, 6)
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReloadFullProcessTreeToolStripMenuItem, Me.OpenLocationToolStripMenuItem1, Me.CopyFileToolStripMenuItem, Me.CopyFilePathToolStripMenuItem, Me.ToolStripSeparator8, Me.ExpandToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Image = CType(resources.GetObject("OptionsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'ReloadFullProcessTreeToolStripMenuItem
        '
        Me.ReloadFullProcessTreeToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.arrow_refresh
        Me.ReloadFullProcessTreeToolStripMenuItem.Name = "ReloadFullProcessTreeToolStripMenuItem"
        Me.ReloadFullProcessTreeToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ReloadFullProcessTreeToolStripMenuItem.Text = "Reload Process Tree"
        '
        'OpenLocationToolStripMenuItem1
        '
        Me.OpenLocationToolStripMenuItem1.Image = CType(resources.GetObject("OpenLocationToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.OpenLocationToolStripMenuItem1.Name = "OpenLocationToolStripMenuItem1"
        Me.OpenLocationToolStripMenuItem1.Size = New System.Drawing.Size(179, 22)
        Me.OpenLocationToolStripMenuItem1.Text = "Open Location"
        '
        'CopyFileToolStripMenuItem
        '
        Me.CopyFileToolStripMenuItem.Image = CType(resources.GetObject("CopyFileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyFileToolStripMenuItem.Name = "CopyFileToolStripMenuItem"
        Me.CopyFileToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.CopyFileToolStripMenuItem.Text = "Copy File"
        '
        'CopyFilePathToolStripMenuItem
        '
        Me.CopyFilePathToolStripMenuItem.Image = CType(resources.GetObject("CopyFilePathToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyFilePathToolStripMenuItem.Name = "CopyFilePathToolStripMenuItem"
        Me.CopyFilePathToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.CopyFilePathToolStripMenuItem.Text = "Copy File Path"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(176, 6)
        '
        'ExpandToolStripMenuItem
        '
        Me.ExpandToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.doublesideArrow
        Me.ExpandToolStripMenuItem.Name = "ExpandToolStripMenuItem"
        Me.ExpandToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ExpandToolStripMenuItem.Text = "Expand"
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(18, 18)
        Me.ImageList2.Tag = "This List is used with Process tree and process List. it collect the icon of each" & _
    " running  executable. and store them making PID of process as image key."
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'ProTreeTextBox
        '
        Me.ProTreeTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ProTreeTextBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProTreeTextBox.Location = New System.Drawing.Point(3, 369)
        Me.ProTreeTextBox.Name = "ProTreeTextBox"
        Me.ProTreeTextBox.ReadOnly = True
        Me.ProTreeTextBox.Size = New System.Drawing.Size(259, 20)
        Me.ProTreeTextBox.TabIndex = 181
        Me.ProTreeTextBox.TabStop = False
        Me.ProTreeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.RefreshButtonMain)
        Me.GroupBox2.Controls.Add(Me.Run_remover)
        Me.GroupBox2.Controls.Add(Me.Sys_Hidden_Show)
        Me.GroupBox2.Controls.Add(Me.SFC)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(9, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(167, 224)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Task :"
        '
        'RefreshButtonMain
        '
        Me.RefreshButtonMain.BackColor = System.Drawing.Color.Transparent
        Me.RefreshButtonMain.ButtonText = "Refresh"
        Me.RefreshButtonMain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RefreshButtonMain.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.RefreshButtonMain.FontSize = 14
        Me.RefreshButtonMain.FontsStyle = System.Drawing.FontStyle.Regular
        Me.RefreshButtonMain.ForeColor = System.Drawing.Color.Black
        Me.RefreshButtonMain.Icon = Nothing
        Me.RefreshButtonMain.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.RefreshButtonMain.IconSpacingX = 5
        Me.RefreshButtonMain.IconSpacingY = 5
        Me.RefreshButtonMain.IconTransparency = 0.0!
        Me.RefreshButtonMain.Location = New System.Drawing.Point(8, 188)
        Me.RefreshButtonMain.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.RefreshButtonMain.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.RefreshButtonMain.Name = "RefreshButtonMain"
        Me.RefreshButtonMain.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.SteelBlue, System.Drawing.Color.SteelBlue, System.Drawing.Color.SteelBlue, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.LightSteelBlue}
        Me.RefreshButtonMain.Size = New System.Drawing.Size(150, 27)
        Me.RefreshButtonMain.TabIndex = 4
        Me.RefreshButtonMain.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.RefreshButtonMain.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.RefreshButtonMain.TextSpacingX = 5
        Me.RefreshButtonMain.TextSpacingY = 5
        '
        'Run_remover
        '
        Me.Run_remover.BackColor = System.Drawing.Color.Transparent
        Me.Run_remover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Run_remover.ButtonText = "  One Click  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Registry Heal"
        Me.Run_remover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Run_remover.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.Run_remover.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Run_remover.FontSize = 14
        Me.Run_remover.FontsStyle = System.Drawing.FontStyle.Regular
        Me.Run_remover.ForeColor = System.Drawing.Color.Black
        Me.Run_remover.Icon = Nothing
        Me.Run_remover.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.Run_remover.IconSpacingX = 5
        Me.Run_remover.IconSpacingY = 5
        Me.Run_remover.IconTransparency = 0.0!
        Me.Run_remover.Location = New System.Drawing.Point(10, 28)
        Me.Run_remover.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Run_remover.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.Run_remover.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.Run_remover.Name = "Run_remover"
        Me.Run_remover.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.SteelBlue, System.Drawing.Color.SteelBlue, System.Drawing.Color.SteelBlue, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.LightSteelBlue}
        Me.Run_remover.Size = New System.Drawing.Size(150, 69)
        Me.Run_remover.TabIndex = 1
        Me.Run_remover.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.Run_remover.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.Run_remover.TextSpacingX = 5
        Me.Run_remover.TextSpacingY = 5
        '
        'Sys_Hidden_Show
        '
        Me.Sys_Hidden_Show.BackColor = System.Drawing.Color.Transparent
        Me.Sys_Hidden_Show.ButtonText = "Show Suspicious Files"
        Me.Sys_Hidden_Show.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Sys_Hidden_Show.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.Sys_Hidden_Show.FontSize = 14
        Me.Sys_Hidden_Show.FontsStyle = System.Drawing.FontStyle.Regular
        Me.Sys_Hidden_Show.ForeColor = System.Drawing.Color.Black
        Me.Sys_Hidden_Show.Icon = Nothing
        Me.Sys_Hidden_Show.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.Sys_Hidden_Show.IconSpacingX = 5
        Me.Sys_Hidden_Show.IconSpacingY = 5
        Me.Sys_Hidden_Show.IconTransparency = 0.0!
        Me.Sys_Hidden_Show.Location = New System.Drawing.Point(6, 155)
        Me.Sys_Hidden_Show.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.Sys_Hidden_Show.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.Sys_Hidden_Show.Name = "Sys_Hidden_Show"
        Me.Sys_Hidden_Show.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.SteelBlue, System.Drawing.Color.SteelBlue, System.Drawing.Color.SteelBlue, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.LightSteelBlue}
        Me.Sys_Hidden_Show.Size = New System.Drawing.Size(150, 27)
        Me.Sys_Hidden_Show.TabIndex = 3
        Me.Sys_Hidden_Show.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.Sys_Hidden_Show.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.Sys_Hidden_Show.TextSpacingX = 5
        Me.Sys_Hidden_Show.TextSpacingY = 5
        '
        'SFC
        '
        Me.SFC.BackColor = System.Drawing.Color.Transparent
        Me.SFC.ButtonText = "System File Checker"
        Me.SFC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SFC.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.SFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SFC.FontSize = 14
        Me.SFC.FontsStyle = System.Drawing.FontStyle.Regular
        Me.SFC.ForeColor = System.Drawing.Color.Black
        Me.SFC.Icon = Nothing
        Me.SFC.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.SFC.IconSpacingX = 5
        Me.SFC.IconSpacingY = 5
        Me.SFC.IconTransparency = 0.0!
        Me.SFC.Location = New System.Drawing.Point(8, 122)
        Me.SFC.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.SFC.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.SFC.Name = "SFC"
        Me.SFC.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.SteelBlue, System.Drawing.Color.SteelBlue, System.Drawing.Color.SteelBlue, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.LightSteelBlue}
        Me.SFC.Size = New System.Drawing.Size(150, 27)
        Me.SFC.TabIndex = 2
        Me.SFC.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.SFC.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.SFC.TextSpacingX = 5
        Me.SFC.TextSpacingY = 5
        '
        'AutorunPanelPage
        '
        Me.AutorunPanelPage.BackColor = System.Drawing.Color.Transparent
        Me.AutorunPanelPage.Controls.Add(Me.GroupBox9)
        Me.AutorunPanelPage.ImageKey = "document_32.png"
        Me.AutorunPanelPage.Location = New System.Drawing.Point(4, 23)
        Me.AutorunPanelPage.Name = "AutorunPanelPage"
        Me.AutorunPanelPage.Padding = New System.Windows.Forms.Padding(3)
        Me.AutorunPanelPage.Size = New System.Drawing.Size(631, 400)
        Me.AutorunPanelPage.TabIndex = 9
        Me.AutorunPanelPage.Text = "Autorun Details"
        Me.AutorunPanelPage.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox9.Controls.Add(Me.Panel4)
        Me.GroupBox9.Controls.Add(Me.SplitContainer2)
        Me.GroupBox9.Controls.Add(Me.Label5)
        Me.GroupBox9.Controls.Add(Me.onehit)
        Me.GroupBox9.Controls.Add(Me.Label4)
        Me.GroupBox9.Controls.Add(Me.InfBox)
        Me.GroupBox9.Controls.Add(Me.GroupBox6)
        Me.GroupBox9.Controls.Add(Me.AutorunBox1)
        Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox9.ForeColor = System.Drawing.Color.Black
        Me.GroupBox9.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(625, 394)
        Me.GroupBox9.TabIndex = 164
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Autorun Details"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.CheckBox8)
        Me.Panel4.Controls.Add(Me.CheckBox1)
        Me.Panel4.Location = New System.Drawing.Point(444, 160)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(174, 36)
        Me.Panel4.TabIndex = 164
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox8.Checked = True
        Me.CheckBox8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CheckBox8.Location = New System.Drawing.Point(0, 19)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(174, 17)
        Me.CheckBox8.TabIndex = 162
        Me.CheckBox8.Text = "Show termination details"
        Me.CheckBox8.UseVisualStyleBackColor = False
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 201)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.FileFoundLV)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ProList)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer2.Size = New System.Drawing.Size(619, 190)
        Me.SplitContainer2.SplitterDistance = 313
        Me.SplitContainer2.TabIndex = 163
        '
        'ProcessDetailPage
        '
        Me.ProcessDetailPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProcessDetailPage.Controls.Add(Me.SplitContainer1)
        Me.ProcessDetailPage.ImageKey = "application.png"
        Me.ProcessDetailPage.Location = New System.Drawing.Point(4, 23)
        Me.ProcessDetailPage.Name = "ProcessDetailPage"
        Me.ProcessDetailPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ProcessDetailPage.Size = New System.Drawing.Size(631, 400)
        Me.ProcessDetailPage.TabIndex = 2
        Me.ProcessDetailPage.Text = "Process Details"
        Me.ProcessDetailPage.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.KillThis)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListView2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Proc_Count)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(625, 394)
        Me.SplitContainer1.SplitterDistance = 263
        Me.SplitContainer1.TabIndex = 0
        '
        'ListView2
        '
        Me.ListView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView2.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ListView2.CheckBoxes = True
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader6})
        Me.ListView2.ContextMenuStrip = Me.ListView2Strip
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(3, 3)
        Me.ListView2.MultiSelect = False
        Me.ListView2.Name = "ListView2"
        Me.ListView2.ShowItemToolTips = True
        Me.ListView2.Size = New System.Drawing.Size(257, 318)
        Me.ListView2.SmallImageList = Me.ImageList2
        Me.ListView2.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView2.TabIndex = 0
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Process"
        Me.ColumnHeader3.Width = 179
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "PID"
        Me.ColumnHeader6.Width = 64
        '
        'ListView2Strip
        '
        Me.ListView2Strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KillProcessToolStripMenuItem2, Me.RestartProcessToolStripMenuItem, Me.GetModuleDetailToolStripMenuItem, Me.ToolStripSeparator2, Me.SuspendProcessToolStripMenuItem1, Me.ResumeProcessToolStripMenuItem1, Me.ToolStripSeparator1, Me.GetGenralDetailToolStripMenuItem, Me.GetProcessFilePropertyToolStripMenuItem1, Me.ToolStripSeparator27, Me.AffinityToolStripMenuItem1, Me.ToolStripMenuItem1, Me.ToolStripSeparator17, Me.ToolStripMenuItem8})
        Me.ListView2Strip.Name = "ListView2Strip"
        Me.ListView2Strip.Size = New System.Drawing.Size(217, 248)
        '
        'KillProcessToolStripMenuItem2
        '
        Me.KillProcessToolStripMenuItem2.Image = CType(resources.GetObject("KillProcessToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.KillProcessToolStripMenuItem2.Name = "KillProcessToolStripMenuItem2"
        Me.KillProcessToolStripMenuItem2.Size = New System.Drawing.Size(216, 22)
        Me.KillProcessToolStripMenuItem2.Text = "Kill Process"
        '
        'RestartProcessToolStripMenuItem
        '
        Me.RestartProcessToolStripMenuItem.Image = CType(resources.GetObject("RestartProcessToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RestartProcessToolStripMenuItem.Name = "RestartProcessToolStripMenuItem"
        Me.RestartProcessToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.RestartProcessToolStripMenuItem.Text = "Restart Process"
        '
        'GetModuleDetailToolStripMenuItem
        '
        Me.GetModuleDetailToolStripMenuItem.Image = CType(resources.GetObject("GetModuleDetailToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GetModuleDetailToolStripMenuItem.Name = "GetModuleDetailToolStripMenuItem"
        Me.GetModuleDetailToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.GetModuleDetailToolStripMenuItem.Text = "Get Module Detail"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(213, 6)
        '
        'SuspendProcessToolStripMenuItem1
        '
        Me.SuspendProcessToolStripMenuItem1.Image = CType(resources.GetObject("SuspendProcessToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.SuspendProcessToolStripMenuItem1.Name = "SuspendProcessToolStripMenuItem1"
        Me.SuspendProcessToolStripMenuItem1.Size = New System.Drawing.Size(216, 22)
        Me.SuspendProcessToolStripMenuItem1.Text = "Suspend Process"
        '
        'ResumeProcessToolStripMenuItem1
        '
        Me.ResumeProcessToolStripMenuItem1.Image = CType(resources.GetObject("ResumeProcessToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ResumeProcessToolStripMenuItem1.Name = "ResumeProcessToolStripMenuItem1"
        Me.ResumeProcessToolStripMenuItem1.Size = New System.Drawing.Size(216, 22)
        Me.ResumeProcessToolStripMenuItem1.Text = "Resume Process"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(213, 6)
        '
        'GetGenralDetailToolStripMenuItem
        '
        Me.GetGenralDetailToolStripMenuItem.Image = CType(resources.GetObject("GetGenralDetailToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GetGenralDetailToolStripMenuItem.Name = "GetGenralDetailToolStripMenuItem"
        Me.GetGenralDetailToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.GetGenralDetailToolStripMenuItem.Text = "Get Process General Details"
        '
        'GetProcessFilePropertyToolStripMenuItem1
        '
        Me.GetProcessFilePropertyToolStripMenuItem1.Image = Global.Virus_Effect_Remover.My.Resources.Resources.information
        Me.GetProcessFilePropertyToolStripMenuItem1.Name = "GetProcessFilePropertyToolStripMenuItem1"
        Me.GetProcessFilePropertyToolStripMenuItem1.Size = New System.Drawing.Size(216, 22)
        Me.GetProcessFilePropertyToolStripMenuItem1.Text = "Get Process File Properties"
        '
        'ToolStripSeparator27
        '
        Me.ToolStripSeparator27.Name = "ToolStripSeparator27"
        Me.ToolStripSeparator27.Size = New System.Drawing.Size(213, 6)
        '
        'AffinityToolStripMenuItem1
        '
        Me.AffinityToolStripMenuItem1.Enabled = False
        Me.AffinityToolStripMenuItem1.Name = "AffinityToolStripMenuItem1"
        Me.AffinityToolStripMenuItem1.Size = New System.Drawing.Size(216, 22)
        Me.AffinityToolStripMenuItem1.Text = "Affinity"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7})
        Me.ToolStripMenuItem1.Enabled = False
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(216, 22)
        Me.ToolStripMenuItem1.Text = "Priority"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(151, 22)
        Me.ToolStripMenuItem2.Text = "Real Time"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(151, 22)
        Me.ToolStripMenuItem3.Text = "High"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(151, 22)
        Me.ToolStripMenuItem4.Text = "Above Normal"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(151, 22)
        Me.ToolStripMenuItem5.Text = "Normal"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(151, 22)
        Me.ToolStripMenuItem6.Text = "Below Normal"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(151, 22)
        Me.ToolStripMenuItem7.Text = "Idle"
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(213, 6)
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem9, Me.ToolStripMenuItem10, Me.CopyFileToolStripMenuItem1, Me.CopyFilePathToolStripMenuItem1})
        Me.ToolStripMenuItem8.Image = CType(resources.GetObject("ToolStripMenuItem8.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(216, 22)
        Me.ToolStripMenuItem8.Text = "Options"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Image = Global.Virus_Effect_Remover.My.Resources.Resources.arrow_refresh
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(196, 22)
        Me.ToolStripMenuItem9.Text = "Reload Full Process List"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Image = CType(resources.GetObject("ToolStripMenuItem10.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(196, 22)
        Me.ToolStripMenuItem10.Text = "Open Location"
        '
        'CopyFileToolStripMenuItem1
        '
        Me.CopyFileToolStripMenuItem1.Image = CType(resources.GetObject("CopyFileToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.CopyFileToolStripMenuItem1.Name = "CopyFileToolStripMenuItem1"
        Me.CopyFileToolStripMenuItem1.Size = New System.Drawing.Size(196, 22)
        Me.CopyFileToolStripMenuItem1.Text = "Copy File"
        '
        'CopyFilePathToolStripMenuItem1
        '
        Me.CopyFilePathToolStripMenuItem1.Image = CType(resources.GetObject("CopyFilePathToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.CopyFilePathToolStripMenuItem1.Name = "CopyFilePathToolStripMenuItem1"
        Me.CopyFilePathToolStripMenuItem1.Size = New System.Drawing.Size(196, 22)
        Me.CopyFilePathToolStripMenuItem1.Text = "Copy File Path"
        '
        'Proc_Count
        '
        Me.Proc_Count.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Proc_Count.BackColor = System.Drawing.Color.White
        Me.Proc_Count.Location = New System.Drawing.Point(3, 327)
        Me.Proc_Count.Name = "Proc_Count"
        Me.Proc_Count.ReadOnly = True
        Me.Proc_Count.Size = New System.Drawing.Size(258, 20)
        Me.Proc_Count.TabIndex = 1
        Me.Proc_Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.CheckBox2)
        Me.Panel3.Controls.Add(Me.CheckBox3)
        Me.Panel3.Location = New System.Drawing.Point(144, 352)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(113, 37)
        Me.Panel3.TabIndex = 33
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CheckBox3.Location = New System.Drawing.Point(0, 20)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(113, 17)
        Me.CheckBox3.TabIndex = 32
        Me.CheckBox3.Text = "Show Details"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Tp0)
        Me.TabControl1.Controls.Add(Me.TP1)
        Me.TabControl1.Controls.Add(Me.TP3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ImageList = Me.FixedImageList
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(358, 394)
        Me.TabControl1.TabIndex = 33
        '
        'Tp0
        '
        Me.Tp0.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Tp0.Controls.Add(Me.ProcessDetailList)
        Me.Tp0.ImageKey = "info_32.png"
        Me.Tp0.Location = New System.Drawing.Point(4, 23)
        Me.Tp0.Name = "Tp0"
        Me.Tp0.Padding = New System.Windows.Forms.Padding(3)
        Me.Tp0.Size = New System.Drawing.Size(350, 367)
        Me.Tp0.TabIndex = 0
        Me.Tp0.Text = "General Details"
        '
        'ProcessDetailList
        '
        Me.ProcessDetailList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader15})
        Me.ProcessDetailList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProcessDetailList.FullRowSelect = True
        Me.ProcessDetailList.GridLines = True
        ListViewGroup1.Header = "Main Details"
        ListViewGroup1.Name = "ListViewGroup1"
        ListViewGroup2.Header = "Executation Details"
        ListViewGroup2.Name = "ListViewGroup4"
        ListViewGroup3.Header = "Size Details"
        ListViewGroup3.Name = "ListViewGroup2"
        ListViewGroup4.Header = "Operating System Details"
        ListViewGroup4.Name = "ListViewGroup3"
        Me.ProcessDetailList.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3, ListViewGroup4})
        Me.ProcessDetailList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        ListViewItem1.Group = ListViewGroup1
        ListViewItem1.ToolTipText = "Selected Process name."
        ListViewItem2.Group = ListViewGroup1
        ListViewItem3.Group = ListViewGroup1
        ListViewItem4.Group = ListViewGroup1
        ListViewItem4.ToolTipText = "Unique Id of selected process."
        ListViewItem5.Group = ListViewGroup1
        ListViewItem5.ToolTipText = "Executable file which is ruuning this process"
        ListViewItem6.Group = ListViewGroup1
        ListViewItem6.ToolTipText = "Executable file Size."
        ListViewItem7.Group = ListViewGroup1
        ListViewItem8.Group = ListViewGroup1
        ListViewItem9.Group = ListViewGroup1
        ListViewItem9.ToolTipText = "This is the process which started selected process."
        ListViewItem10.Group = ListViewGroup1
        ListViewItem10.ToolTipText = "Unique of parent process."
        ListViewItem11.Group = ListViewGroup1
        ListViewItem11.ToolTipText = "Provides Information of process execution."
        ListViewItem12.Group = ListViewGroup1
        ListViewItem12.ToolTipText = "User Name under which selected process is executing."
        ListViewItem13.Group = ListViewGroup3
        ListViewItem14.Group = ListViewGroup3
        ListViewItem15.Group = ListViewGroup3
        ListViewItem16.Group = ListViewGroup3
        ListViewItem17.Group = ListViewGroup3
        ListViewItem18.Group = ListViewGroup3
        ListViewItem19.Group = ListViewGroup3
        ListViewItem20.Group = ListViewGroup3
        ListViewItem21.Group = ListViewGroup3
        ListViewItem22.Group = ListViewGroup3
        ListViewItem23.Group = ListViewGroup3
        ListViewItem24.Group = ListViewGroup3
        ListViewItem25.Group = ListViewGroup3
        ListViewItem26.Group = ListViewGroup3
        ListViewItem27.Group = ListViewGroup3
        ListViewItem28.Group = ListViewGroup4
        ListViewItem29.Group = ListViewGroup4
        ListViewItem30.Group = ListViewGroup4
        ListViewItem31.Group = ListViewGroup4
        ListViewItem32.Group = ListViewGroup4
        ListViewItem33.Group = ListViewGroup4
        ListViewItem34.Group = ListViewGroup4
        ListViewItem35.Group = ListViewGroup2
        ListViewItem36.Group = ListViewGroup2
        ListViewItem37.Group = ListViewGroup2
        ListViewItem38.Group = ListViewGroup2
        ListViewItem39.Group = ListViewGroup2
        ListViewItem40.Group = ListViewGroup2
        ListViewItem41.Group = ListViewGroup2
        ListViewItem42.Group = ListViewGroup2
        ListViewItem43.Group = ListViewGroup2
        ListViewItem44.Group = ListViewGroup2
        ListViewItem45.Group = ListViewGroup2
        ListViewItem46.Group = ListViewGroup2
        ListViewItem47.Group = ListViewGroup2
        ListViewItem48.Group = ListViewGroup2
        Me.ProcessDetailList.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12, ListViewItem13, ListViewItem14, ListViewItem15, ListViewItem16, ListViewItem17, ListViewItem18, ListViewItem19, ListViewItem20, ListViewItem21, ListViewItem22, ListViewItem23, ListViewItem24, ListViewItem25, ListViewItem26, ListViewItem27, ListViewItem28, ListViewItem29, ListViewItem30, ListViewItem31, ListViewItem32, ListViewItem33, ListViewItem34, ListViewItem35, ListViewItem36, ListViewItem37, ListViewItem38, ListViewItem39, ListViewItem40, ListViewItem41, ListViewItem42, ListViewItem43, ListViewItem44, ListViewItem45, ListViewItem46, ListViewItem47, ListViewItem48})
        Me.ProcessDetailList.Location = New System.Drawing.Point(3, 3)
        Me.ProcessDetailList.MultiSelect = False
        Me.ProcessDetailList.Name = "ProcessDetailList"
        Me.ProcessDetailList.ShowItemToolTips = True
        Me.ProcessDetailList.Size = New System.Drawing.Size(344, 361)
        Me.ProcessDetailList.TabIndex = 1
        Me.ProcessDetailList.UseCompatibleStateImageBehavior = False
        Me.ProcessDetailList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Parameter"
        Me.ColumnHeader9.Width = 134
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Detail"
        Me.ColumnHeader15.Width = 388
        '
        'TP1
        '
        Me.TP1.BackColor = System.Drawing.Color.Transparent
        Me.TP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TP1.Controls.Add(Me.PathLable)
        Me.TP1.Controls.Add(Me.Label73)
        Me.TP1.Controls.Add(Me.IdLable)
        Me.TP1.Controls.Add(Me.Label72)
        Me.TP1.Controls.Add(Me.Label71)
        Me.TP1.Controls.Add(Me.NameLable)
        Me.TP1.Controls.Add(Me.ModuleList)
        Me.TP1.ImageKey = "dll-icon_2.png"
        Me.TP1.Location = New System.Drawing.Point(4, 23)
        Me.TP1.Name = "TP1"
        Me.TP1.Padding = New System.Windows.Forms.Padding(3)
        Me.TP1.Size = New System.Drawing.Size(350, 367)
        Me.TP1.TabIndex = 1
        Me.TP1.Text = "Related Modules"
        '
        'PathLable
        '
        Me.PathLable.BackColor = System.Drawing.SystemColors.Control
        Me.PathLable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PathLable.Location = New System.Drawing.Point(101, 36)
        Me.PathLable.Name = "PathLable"
        Me.PathLable.ReadOnly = True
        Me.PathLable.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.PathLable.Size = New System.Drawing.Size(261, 13)
        Me.PathLable.TabIndex = 168
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Location = New System.Drawing.Point(6, 36)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(70, 13)
        Me.Label73.TabIndex = 168
        Me.Label73.Text = "Process Path"
        '
        'IdLable
        '
        Me.IdLable.AutoSize = True
        Me.IdLable.Location = New System.Drawing.Point(301, 11)
        Me.IdLable.Name = "IdLable"
        Me.IdLable.Size = New System.Drawing.Size(10, 13)
        Me.IdLable.TabIndex = 12
        Me.IdLable.Text = ":"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Location = New System.Drawing.Point(273, 11)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(22, 13)
        Me.Label72.TabIndex = 11
        Me.Label72.Text = "Id :"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Location = New System.Drawing.Point(6, 11)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(82, 13)
        Me.Label71.TabIndex = 10
        Me.Label71.Text = "Process Name :"
        '
        'NameLable
        '
        Me.NameLable.AutoSize = True
        Me.NameLable.Location = New System.Drawing.Point(98, 11)
        Me.NameLable.Name = "NameLable"
        Me.NameLable.Size = New System.Drawing.Size(10, 13)
        Me.NameLable.TabIndex = 9
        Me.NameLable.Text = ":"
        '
        'TP3
        '
        Me.TP3.BackColor = System.Drawing.SystemColors.Control
        Me.TP3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TP3.Controls.Add(Me.ClearKillEventList)
        Me.TP3.Controls.Add(Me.KillEventListBox)
        Me.TP3.ImageKey = "(none)"
        Me.TP3.Location = New System.Drawing.Point(4, 23)
        Me.TP3.Name = "TP3"
        Me.TP3.Size = New System.Drawing.Size(350, 367)
        Me.TP3.TabIndex = 3
        Me.TP3.Text = "Event Viewer"
        '
        'ClearKillEventList
        '
        Me.ClearKillEventList.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ClearKillEventList.Location = New System.Drawing.Point(92, 17)
        Me.ClearKillEventList.Name = "ClearKillEventList"
        Me.ClearKillEventList.Size = New System.Drawing.Size(151, 23)
        Me.ClearKillEventList.TabIndex = 1
        Me.ClearKillEventList.Text = "Clear Event List"
        Me.ClearKillEventList.UseVisualStyleBackColor = True
        '
        'KillEventListBox
        '
        Me.KillEventListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KillEventListBox.FormattingEnabled = True
        Me.KillEventListBox.Location = New System.Drawing.Point(0, 52)
        Me.KillEventListBox.Name = "KillEventListBox"
        Me.KillEventListBox.Size = New System.Drawing.Size(346, 316)
        Me.KillEventListBox.TabIndex = 0
        '
        'FixedImageList
        '
        Me.FixedImageList.ImageStream = CType(resources.GetObject("FixedImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.FixedImageList.Tag = "It is a fixed image list where we will strore image for fixed use."
        Me.FixedImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.FixedImageList.Images.SetKeyName(0, "dll-icon_2.png")
        Me.FixedImageList.Images.SetKeyName(1, "application.png")
        Me.FixedImageList.Images.SetKeyName(2, "folder-blue-mydocuments-48x48.png")
        Me.FixedImageList.Images.SetKeyName(3, "lock_edit.png")
        Me.FixedImageList.Images.SetKeyName(4, "folder_32.png")
        Me.FixedImageList.Images.SetKeyName(5, "Health care shield_6.png")
        Me.FixedImageList.Images.SetKeyName(6, "cog_edit.png")
        Me.FixedImageList.Images.SetKeyName(7, "System-Package-48x48.png")
        Me.FixedImageList.Images.SetKeyName(8, "information.png")
        Me.FixedImageList.Images.SetKeyName(9, "report_user.png")
        Me.FixedImageList.Images.SetKeyName(10, "usb_48.png")
        Me.FixedImageList.Images.SetKeyName(11, "app_48.png")
        Me.FixedImageList.Images.SetKeyName(12, "cross_48.png")
        Me.FixedImageList.Images.SetKeyName(13, "document_32.png")
        Me.FixedImageList.Images.SetKeyName(14, "spanner_48.png")
        Me.FixedImageList.Images.SetKeyName(15, "info_32.png")
        Me.FixedImageList.Images.SetKeyName(16, "key_32.png")
        Me.FixedImageList.Images.SetKeyName(17, "gear_32.png")
        '
        'FolderOptionPage
        '
        Me.FolderOptionPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FolderOptionPage.Controls.Add(Me.Panel1)
        Me.FolderOptionPage.ImageKey = "folder_32.png"
        Me.FolderOptionPage.Location = New System.Drawing.Point(4, 23)
        Me.FolderOptionPage.Name = "FolderOptionPage"
        Me.FolderOptionPage.Padding = New System.Windows.Forms.Padding(3)
        Me.FolderOptionPage.Size = New System.Drawing.Size(631, 400)
        Me.FolderOptionPage.TabIndex = 6
        Me.FolderOptionPage.Text = "Files & Folders Options"
        Me.FolderOptionPage.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FileFolderTab)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(623, 392)
        Me.Panel1.TabIndex = 11
        '
        'FileFolderTab
        '
        Me.FileFolderTab.Controls.Add(Me.FolderOptionsSubPage)
        Me.FileFolderTab.Controls.Add(Me.RemovalMediaDetailPage)
        Me.FileFolderTab.Controls.Add(Me.DirectoryDetailPage)
        Me.FileFolderTab.Controls.Add(Me.DelFilePage)
        Me.FileFolderTab.Controls.Add(Me.SecurityPermissionPage)
        Me.FileFolderTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FileFolderTab.ImageList = Me.FixedImageList
        Me.FileFolderTab.Location = New System.Drawing.Point(0, 0)
        Me.FileFolderTab.Name = "FileFolderTab"
        Me.FileFolderTab.SelectedIndex = 0
        Me.FileFolderTab.Size = New System.Drawing.Size(623, 392)
        Me.FileFolderTab.TabIndex = 0
        '
        'FolderOptionsSubPage
        '
        Me.FolderOptionsSubPage.BackColor = System.Drawing.SystemColors.Control
        Me.FolderOptionsSubPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.FolderOptionsSubPage.Controls.Add(Me.UtilityBox)
        Me.FolderOptionsSubPage.Controls.Add(Me.ShowFolderOption)
        Me.FolderOptionsSubPage.Controls.Add(Me.GroupBox7)
        Me.FolderOptionsSubPage.ImageKey = "folder_32.png"
        Me.FolderOptionsSubPage.Location = New System.Drawing.Point(4, 23)
        Me.FolderOptionsSubPage.Name = "FolderOptionsSubPage"
        Me.FolderOptionsSubPage.Padding = New System.Windows.Forms.Padding(3)
        Me.FolderOptionsSubPage.Size = New System.Drawing.Size(615, 365)
        Me.FolderOptionsSubPage.TabIndex = 0
        Me.FolderOptionsSubPage.Text = "Folder Options"
        '
        'UtilityBox
        '
        Me.UtilityBox.BackColor = System.Drawing.Color.Transparent
        Me.UtilityBox.Controls.Add(Me.FileExt)
        Me.UtilityBox.ForeColor = System.Drawing.Color.Black
        Me.UtilityBox.Location = New System.Drawing.Point(17, 97)
        Me.UtilityBox.Name = "UtilityBox"
        Me.UtilityBox.Size = New System.Drawing.Size(238, 50)
        Me.UtilityBox.TabIndex = 186
        Me.UtilityBox.TabStop = False
        Me.UtilityBox.Text = "Utility Box :"
        '
        'FileExt
        '
        Me.FileExt.AutoSize = True
        Me.FileExt.BackColor = System.Drawing.Color.Transparent
        Me.FileExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileExt.Location = New System.Drawing.Point(13, 19)
        Me.FileExt.Name = "FileExt"
        Me.FileExt.Size = New System.Drawing.Size(194, 20)
        Me.FileExt.TabIndex = 2
        Me.FileExt.Text = "Hide Known File Extensions."
        Me.FileExt.UseVisualStyleBackColor = False
        '
        'ShowFolderOption
        '
        Me.ShowFolderOption.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ShowFolderOption.BackColor = System.Drawing.Color.Transparent
        Me.ShowFolderOption.ButtonText = "Open Folder Options"
        Me.ShowFolderOption.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShowFolderOption.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.ShowFolderOption.FontSize = 14
        Me.ShowFolderOption.FontsStyle = System.Drawing.FontStyle.Regular
        Me.ShowFolderOption.ForeColor = System.Drawing.Color.Black
        Me.ShowFolderOption.Icon = Nothing
        Me.ShowFolderOption.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.ShowFolderOption.IconSpacingX = 5
        Me.ShowFolderOption.IconSpacingY = 5
        Me.ShowFolderOption.IconTransparency = 0.0!
        Me.ShowFolderOption.Location = New System.Drawing.Point(231, 290)
        Me.ShowFolderOption.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.ShowFolderOption.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.ShowFolderOption.Name = "ShowFolderOption"
        Me.ShowFolderOption.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.SteelBlue, System.Drawing.Color.SteelBlue, System.Drawing.Color.SteelBlue, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.LightSteelBlue}
        Me.ShowFolderOption.Size = New System.Drawing.Size(150, 50)
        Me.ShowFolderOption.TabIndex = 185
        Me.ShowFolderOption.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.ShowFolderOption.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.ShowFolderOption.TextSpacingX = 5
        Me.ShowFolderOption.TextSpacingY = 5
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.ShowHideFile)
        Me.GroupBox7.Controls.Add(Me.SystemHided)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Black
        Me.GroupBox7.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(238, 77)
        Me.GroupBox7.TabIndex = 5
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "File Hide or Show :"
        '
        'ShowHideFile
        '
        Me.ShowHideFile.AutoSize = True
        Me.ShowHideFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowHideFile.Location = New System.Drawing.Point(13, 19)
        Me.ShowHideFile.Name = "ShowHideFile"
        Me.ShowHideFile.Size = New System.Drawing.Size(217, 20)
        Me.ShowHideFile.TabIndex = 0
        Me.ShowHideFile.Text = "Show Hidden Files and Folders."
        Me.ShowHideFile.UseVisualStyleBackColor = True
        '
        'SystemHided
        '
        Me.SystemHided.AutoSize = True
        Me.SystemHided.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemHided.Location = New System.Drawing.Point(13, 45)
        Me.SystemHided.Name = "SystemHided"
        Me.SystemHided.Size = New System.Drawing.Size(194, 20)
        Me.SystemHided.TabIndex = 1
        Me.SystemHided.Text = "Show System+Hidden Files."
        Me.SystemHided.UseVisualStyleBackColor = True
        '
        'RemovalMediaDetailPage
        '
        Me.RemovalMediaDetailPage.BackColor = System.Drawing.SystemColors.Control
        Me.RemovalMediaDetailPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RemovalMediaDetailPage.Controls.Add(Me.GetRemovalMedia)
        Me.RemovalMediaDetailPage.Controls.Add(Me.GetdrvProperty)
        Me.RemovalMediaDetailPage.Controls.Add(Me.TabControl5)
        Me.RemovalMediaDetailPage.Controls.Add(Me.GenDetail)
        Me.RemovalMediaDetailPage.Controls.Add(Me.FormateDrive)
        Me.RemovalMediaDetailPage.Controls.Add(Me.ReleaseDrive)
        Me.RemovalMediaDetailPage.Controls.Add(Me.RemoveSystemHidden)
        Me.RemovalMediaDetailPage.Controls.Add(Me.VisualiseAllFile)
        Me.RemovalMediaDetailPage.ImageKey = "usb_48.png"
        Me.RemovalMediaDetailPage.Location = New System.Drawing.Point(4, 23)
        Me.RemovalMediaDetailPage.Name = "RemovalMediaDetailPage"
        Me.RemovalMediaDetailPage.Padding = New System.Windows.Forms.Padding(3)
        Me.RemovalMediaDetailPage.Size = New System.Drawing.Size(615, 365)
        Me.RemovalMediaDetailPage.TabIndex = 1
        Me.RemovalMediaDetailPage.Text = "Removable Media Details"
        '
        'GetRemovalMedia
        '
        Me.GetRemovalMedia.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GetRemovalMedia.Location = New System.Drawing.Point(220, 8)
        Me.GetRemovalMedia.Name = "GetRemovalMedia"
        Me.GetRemovalMedia.Size = New System.Drawing.Size(189, 23)
        Me.GetRemovalMedia.TabIndex = 22
        Me.GetRemovalMedia.Text = "Refresh Removable Media Details"
        Me.GetRemovalMedia.UseVisualStyleBackColor = True
        '
        'TabControl5
        '
        Me.TabControl5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl5.Controls.Add(Me.RemMDetail)
        Me.TabControl5.Controls.Add(Me.ChangeRemDetail)
        Me.TabControl5.ImageList = Me.FixedImageList
        Me.TabControl5.Location = New System.Drawing.Point(6, 37)
        Me.TabControl5.Name = "TabControl5"
        Me.TabControl5.SelectedIndex = 0
        Me.TabControl5.Size = New System.Drawing.Size(603, 268)
        Me.TabControl5.TabIndex = 20
        '
        'RemMDetail
        '
        Me.RemMDetail.Controls.Add(Me.RemovalMediaDriveList)
        Me.RemMDetail.ImageIndex = 10
        Me.RemMDetail.Location = New System.Drawing.Point(4, 23)
        Me.RemMDetail.Name = "RemMDetail"
        Me.RemMDetail.Padding = New System.Windows.Forms.Padding(3)
        Me.RemMDetail.Size = New System.Drawing.Size(595, 241)
        Me.RemMDetail.TabIndex = 0
        Me.RemMDetail.Text = "Removable Media Details"
        Me.RemMDetail.UseVisualStyleBackColor = True
        '
        'RemovalMediaDriveList
        '
        Me.RemovalMediaDriveList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.DriveName, Me.DriveVolume, Me.DriveFormat, Me.DriveTotalSize, Me.DriveUsedSpace, Me.DriveFreeSpace, Me.DriveInfectionStaus})
        Me.RemovalMediaDriveList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RemovalMediaDriveList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemovalMediaDriveList.FullRowSelect = True
        Me.RemovalMediaDriveList.GridLines = True
        Me.RemovalMediaDriveList.Location = New System.Drawing.Point(3, 3)
        Me.RemovalMediaDriveList.Name = "RemovalMediaDriveList"
        Me.RemovalMediaDriveList.Size = New System.Drawing.Size(589, 235)
        Me.RemovalMediaDriveList.TabIndex = 14
        Me.RemovalMediaDriveList.TileSize = New System.Drawing.Size(1, 1)
        Me.RemovalMediaDriveList.UseCompatibleStateImageBehavior = False
        Me.RemovalMediaDriveList.View = System.Windows.Forms.View.Details
        '
        'DriveName
        '
        Me.DriveName.Text = "Name"
        Me.DriveName.Width = 54
        '
        'DriveVolume
        '
        Me.DriveVolume.Text = "Drive Volume"
        Me.DriveVolume.Width = 98
        '
        'DriveFormat
        '
        Me.DriveFormat.Text = "Format"
        '
        'DriveTotalSize
        '
        Me.DriveTotalSize.Text = "Total Size"
        Me.DriveTotalSize.Width = 80
        '
        'DriveUsedSpace
        '
        Me.DriveUsedSpace.Text = "Used Space"
        Me.DriveUsedSpace.Width = 94
        '
        'DriveFreeSpace
        '
        Me.DriveFreeSpace.Text = "Free Space"
        Me.DriveFreeSpace.Width = 86
        '
        'DriveInfectionStaus
        '
        Me.DriveInfectionStaus.Text = "Infection Status"
        Me.DriveInfectionStaus.Width = 106
        '
        'ChangeRemDetail
        '
        Me.ChangeRemDetail.Controls.Add(Me.RemDetailTextbox)
        Me.ChangeRemDetail.Location = New System.Drawing.Point(4, 23)
        Me.ChangeRemDetail.Name = "ChangeRemDetail"
        Me.ChangeRemDetail.Padding = New System.Windows.Forms.Padding(3)
        Me.ChangeRemDetail.Size = New System.Drawing.Size(595, 241)
        Me.ChangeRemDetail.TabIndex = 1
        Me.ChangeRemDetail.Text = "Change Details"
        Me.ChangeRemDetail.UseVisualStyleBackColor = True
        '
        'RemDetailTextbox
        '
        Me.RemDetailTextbox.BackColor = System.Drawing.Color.White
        Me.RemDetailTextbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RemDetailTextbox.Location = New System.Drawing.Point(3, 3)
        Me.RemDetailTextbox.Multiline = True
        Me.RemDetailTextbox.Name = "RemDetailTextbox"
        Me.RemDetailTextbox.ReadOnly = True
        Me.RemDetailTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.RemDetailTextbox.Size = New System.Drawing.Size(589, 235)
        Me.RemDetailTextbox.TabIndex = 0
        '
        'GenDetail
        '
        Me.GenDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GenDetail.AutoSize = True
        Me.GenDetail.BackColor = System.Drawing.Color.Transparent
        Me.GenDetail.Location = New System.Drawing.Point(365, 312)
        Me.GenDetail.Name = "GenDetail"
        Me.GenDetail.Size = New System.Drawing.Size(239, 17)
        Me.GenDetail.TabIndex = 19
        Me.GenDetail.Text = "Generate details of changed files in Notepad."
        Me.GenDetail.UseVisualStyleBackColor = False
        '
        'FormateDrive
        '
        Me.FormateDrive.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FormateDrive.Enabled = False
        Me.FormateDrive.Location = New System.Drawing.Point(203, 336)
        Me.FormateDrive.Name = "FormateDrive"
        Me.FormateDrive.Size = New System.Drawing.Size(152, 23)
        Me.FormateDrive.TabIndex = 18
        Me.FormateDrive.Text = "Format Drive"
        Me.FormateDrive.UseVisualStyleBackColor = True
        Me.FormateDrive.Visible = False
        '
        'ReleaseDrive
        '
        Me.ReleaseDrive.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ReleaseDrive.Enabled = False
        Me.ReleaseDrive.Location = New System.Drawing.Point(203, 308)
        Me.ReleaseDrive.Name = "ReleaseDrive"
        Me.ReleaseDrive.Size = New System.Drawing.Size(152, 23)
        Me.ReleaseDrive.TabIndex = 17
        Me.ReleaseDrive.Text = "Release Drive"
        Me.ReleaseDrive.UseVisualStyleBackColor = True
        Me.ReleaseDrive.Visible = False
        '
        'DirectoryDetailPage
        '
        Me.DirectoryDetailPage.BackColor = System.Drawing.SystemColors.Control
        Me.DirectoryDetailPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DirectoryDetailPage.Controls.Add(Me.Label15)
        Me.DirectoryDetailPage.Controls.Add(Me.Label14)
        Me.DirectoryDetailPage.Controls.Add(Me.DDFileDetail)
        Me.DirectoryDetailPage.Controls.Add(Me.RenameFileInList)
        Me.DirectoryDetailPage.Controls.Add(Me.DeleteFileInList)
        Me.DirectoryDetailPage.Controls.Add(Me.OnlySystemHidden)
        Me.DirectoryDetailPage.Controls.Add(Me.ShowAlllSytemFile)
        Me.DirectoryDetailPage.Controls.Add(Me.IncludeSubFolder)
        Me.DirectoryDetailPage.Controls.Add(Me.ShowAllFile)
        Me.DirectoryDetailPage.Controls.Add(Me.BrowseDir)
        Me.DirectoryDetailPage.Controls.Add(Me.DirectoryPath)
        Me.DirectoryDetailPage.Controls.Add(Me.GroupBox11)
        Me.DirectoryDetailPage.Controls.Add(Me.DirectoryFileListView)
        Me.DirectoryDetailPage.Controls.Add(Me.ShowAllHiddenFile)
        Me.DirectoryDetailPage.ImageKey = "app_48.png"
        Me.DirectoryDetailPage.Location = New System.Drawing.Point(4, 23)
        Me.DirectoryDetailPage.Name = "DirectoryDetailPage"
        Me.DirectoryDetailPage.Size = New System.Drawing.Size(615, 365)
        Me.DirectoryDetailPage.TabIndex = 2
        Me.DirectoryDetailPage.Text = "Folder Details"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(474, 106)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 13)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "- With Attributes -"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(474, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "-    Show Files    -"
        '
        'IncludeSubFolder
        '
        Me.IncludeSubFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IncludeSubFolder.AutoSize = True
        Me.IncludeSubFolder.BackColor = System.Drawing.Color.Transparent
        Me.IncludeSubFolder.Enabled = False
        Me.IncludeSubFolder.Location = New System.Drawing.Point(449, 17)
        Me.IncludeSubFolder.Name = "IncludeSubFolder"
        Me.IncludeSubFolder.Size = New System.Drawing.Size(120, 17)
        Me.IncludeSubFolder.TabIndex = 19
        Me.IncludeSubFolder.Text = "Include Sub-Folders"
        Me.IncludeSubFolder.UseVisualStyleBackColor = False
        '
        'DirectoryPath
        '
        Me.DirectoryPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DirectoryPath.ForeColor = System.Drawing.SystemColors.GrayText
        Me.DirectoryPath.Location = New System.Drawing.Point(13, 14)
        Me.DirectoryPath.Name = "DirectoryPath"
        Me.DirectoryPath.Size = New System.Drawing.Size(324, 20)
        Me.DirectoryPath.TabIndex = 16
        Me.DirectoryPath.Tag = "Enter folder name with complete path."
        Me.DirectoryPath.Text = "Enter folder name with complete path."
        '
        'GroupBox11
        '
        Me.GroupBox11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox11.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox11.Controls.Add(Me.FileAttributeApply)
        Me.GroupBox11.Controls.Add(Me.FileAttributeTemporary)
        Me.GroupBox11.Controls.Add(Me.FileAttributeEncripted)
        Me.GroupBox11.Controls.Add(Me.FileAttributeOffLine)
        Me.GroupBox11.Controls.Add(Me.FileAttributeCompressed)
        Me.GroupBox11.Controls.Add(Me.FileAttributeSystem)
        Me.GroupBox11.Controls.Add(Me.FileAttributeArchive)
        Me.GroupBox11.Controls.Add(Me.FileAtttributeHidden)
        Me.GroupBox11.Controls.Add(Me.FileAttributeReadOnly)
        Me.GroupBox11.ForeColor = System.Drawing.Color.Black
        Me.GroupBox11.Location = New System.Drawing.Point(419, 210)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(189, 137)
        Me.GroupBox11.TabIndex = 15
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "File Attributes:"
        '
        'FileAttributeTemporary
        '
        Me.FileAttributeTemporary.AutoSize = True
        Me.FileAttributeTemporary.Enabled = False
        Me.FileAttributeTemporary.Location = New System.Drawing.Point(9, 88)
        Me.FileAttributeTemporary.Name = "FileAttributeTemporary"
        Me.FileAttributeTemporary.Size = New System.Drawing.Size(76, 17)
        Me.FileAttributeTemporary.TabIndex = 7
        Me.FileAttributeTemporary.Text = "Temporary"
        Me.FileAttributeTemporary.UseVisualStyleBackColor = True
        '
        'FileAttributeEncripted
        '
        Me.FileAttributeEncripted.AutoSize = True
        Me.FileAttributeEncripted.Location = New System.Drawing.Point(107, 64)
        Me.FileAttributeEncripted.Name = "FileAttributeEncripted"
        Me.FileAttributeEncripted.Size = New System.Drawing.Size(74, 17)
        Me.FileAttributeEncripted.TabIndex = 6
        Me.FileAttributeEncripted.Text = "Encrypted"
        Me.FileAttributeEncripted.UseVisualStyleBackColor = True
        '
        'FileAttributeOffLine
        '
        Me.FileAttributeOffLine.AutoSize = True
        Me.FileAttributeOffLine.Enabled = False
        Me.FileAttributeOffLine.Location = New System.Drawing.Point(107, 88)
        Me.FileAttributeOffLine.Name = "FileAttributeOffLine"
        Me.FileAttributeOffLine.Size = New System.Drawing.Size(56, 17)
        Me.FileAttributeOffLine.TabIndex = 5
        Me.FileAttributeOffLine.Text = "Offline"
        Me.FileAttributeOffLine.UseVisualStyleBackColor = True
        '
        'FileAttributeCompressed
        '
        Me.FileAttributeCompressed.AutoSize = True
        Me.FileAttributeCompressed.Location = New System.Drawing.Point(9, 65)
        Me.FileAttributeCompressed.Name = "FileAttributeCompressed"
        Me.FileAttributeCompressed.Size = New System.Drawing.Size(84, 17)
        Me.FileAttributeCompressed.TabIndex = 4
        Me.FileAttributeCompressed.Text = "Compressed"
        Me.FileAttributeCompressed.UseVisualStyleBackColor = True
        '
        'FileAttributeSystem
        '
        Me.FileAttributeSystem.AutoSize = True
        Me.FileAttributeSystem.Location = New System.Drawing.Point(107, 44)
        Me.FileAttributeSystem.Name = "FileAttributeSystem"
        Me.FileAttributeSystem.Size = New System.Drawing.Size(60, 17)
        Me.FileAttributeSystem.TabIndex = 3
        Me.FileAttributeSystem.Text = "System"
        Me.FileAttributeSystem.UseVisualStyleBackColor = True
        '
        'FileAttributeArchive
        '
        Me.FileAttributeArchive.AutoSize = True
        Me.FileAttributeArchive.Location = New System.Drawing.Point(9, 42)
        Me.FileAttributeArchive.Name = "FileAttributeArchive"
        Me.FileAttributeArchive.Size = New System.Drawing.Size(62, 17)
        Me.FileAttributeArchive.TabIndex = 2
        Me.FileAttributeArchive.Text = "Archive"
        Me.FileAttributeArchive.UseVisualStyleBackColor = True
        '
        'FileAtttributeHidden
        '
        Me.FileAtttributeHidden.AutoSize = True
        Me.FileAtttributeHidden.Location = New System.Drawing.Point(107, 21)
        Me.FileAtttributeHidden.Name = "FileAtttributeHidden"
        Me.FileAtttributeHidden.Size = New System.Drawing.Size(60, 17)
        Me.FileAtttributeHidden.TabIndex = 1
        Me.FileAtttributeHidden.Text = "Hidden"
        Me.FileAtttributeHidden.UseVisualStyleBackColor = True
        '
        'FileAttributeReadOnly
        '
        Me.FileAttributeReadOnly.AutoSize = True
        Me.FileAttributeReadOnly.Location = New System.Drawing.Point(9, 21)
        Me.FileAttributeReadOnly.Name = "FileAttributeReadOnly"
        Me.FileAttributeReadOnly.Size = New System.Drawing.Size(76, 17)
        Me.FileAttributeReadOnly.TabIndex = 0
        Me.FileAttributeReadOnly.Text = "Read Only"
        Me.FileAttributeReadOnly.UseVisualStyleBackColor = True
        '
        'DirectoryFileListView
        '
        Me.DirectoryFileListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DirectoryFileListView.CheckBoxes = True
        Me.DirectoryFileListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FileNameSubPage, Me.FileSizeColumn, Me.FileExtention, Me.FullPathTab})
        Me.DirectoryFileListView.FullRowSelect = True
        Me.DirectoryFileListView.GridLines = True
        Me.DirectoryFileListView.Location = New System.Drawing.Point(3, 44)
        Me.DirectoryFileListView.MultiSelect = False
        Me.DirectoryFileListView.Name = "DirectoryFileListView"
        Me.DirectoryFileListView.Size = New System.Drawing.Size(407, 289)
        Me.DirectoryFileListView.TabIndex = 14
        Me.DirectoryFileListView.UseCompatibleStateImageBehavior = False
        Me.DirectoryFileListView.View = System.Windows.Forms.View.Details
        '
        'FileNameSubPage
        '
        Me.FileNameSubPage.Text = "FileName"
        Me.FileNameSubPage.Width = 124
        '
        'FileSizeColumn
        '
        Me.FileSizeColumn.Text = "File Size"
        Me.FileSizeColumn.Width = 78
        '
        'FileExtention
        '
        Me.FileExtention.Text = "File Type"
        Me.FileExtention.Width = 59
        '
        'FullPathTab
        '
        Me.FullPathTab.Text = "Full Path"
        Me.FullPathTab.Width = 302
        '
        'DelFilePage
        '
        Me.DelFilePage.BackColor = System.Drawing.SystemColors.Control
        Me.DelFilePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DelFilePage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DelFilePage.Controls.Add(Me.UDTabControl1)
        Me.DelFilePage.ImageKey = "cross_48.png"
        Me.DelFilePage.Location = New System.Drawing.Point(4, 23)
        Me.DelFilePage.Name = "DelFilePage"
        Me.DelFilePage.Size = New System.Drawing.Size(615, 365)
        Me.DelFilePage.TabIndex = 4
        Me.DelFilePage.Text = "Delete Files"
        '
        'UDTabControl1
        '
        Me.UDTabControl1.Controls.Add(Me.UDTabPage1)
        Me.UDTabControl1.Controls.Add(Me.UDTabPage2)
        Me.UDTabControl1.Controls.Add(Me.UDTabPage3)
        Me.UDTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UDTabControl1.ImageList = Me.FixedImageList
        Me.UDTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UDTabControl1.Name = "UDTabControl1"
        Me.UDTabControl1.SelectedIndex = 0
        Me.UDTabControl1.Size = New System.Drawing.Size(613, 363)
        Me.UDTabControl1.TabIndex = 21
        '
        'UDTabPage1
        '
        Me.UDTabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.UDTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UDTabPage1.Controls.Add(Me.Panel8)
        Me.UDTabPage1.Controls.Add(Me.RemSFL)
        Me.UDTabPage1.Controls.Add(Me.LocateFile)
        Me.UDTabPage1.Controls.Add(Me.DelSF)
        Me.UDTabPage1.Controls.Add(Me.DelList)
        Me.UDTabPage1.Controls.Add(Me.ADDfile2)
        Me.UDTabPage1.Controls.Add(Me.DelACF)
        Me.UDTabPage1.Controls.Add(Me.ClrList)
        Me.UDTabPage1.Controls.Add(Me.BT1)
        Me.UDTabPage1.Location = New System.Drawing.Point(4, 23)
        Me.UDTabPage1.Name = "UDTabPage1"
        Me.UDTabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.UDTabPage1.Size = New System.Drawing.Size(605, 336)
        Me.UDTabPage1.TabIndex = 0
        Me.UDTabPage1.Text = "File Delete Operations"
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.Controls.Add(Me.SendToRecycleFile)
        Me.Panel8.Controls.Add(Me.ForceToDeleteFile)
        Me.Panel8.Location = New System.Drawing.Point(435, 288)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(149, 38)
        Me.Panel8.TabIndex = 36
        '
        'SendToRecycleFile
        '
        Me.SendToRecycleFile.AutoSize = True
        Me.SendToRecycleFile.Dock = System.Windows.Forms.DockStyle.Top
        Me.SendToRecycleFile.Location = New System.Drawing.Point(0, 0)
        Me.SendToRecycleFile.Name = "SendToRecycleFile"
        Me.SendToRecycleFile.Size = New System.Drawing.Size(149, 17)
        Me.SendToRecycleFile.TabIndex = 27
        Me.SendToRecycleFile.Text = "Send To Recycle Bin"
        Me.SendToRecycleFile.UseVisualStyleBackColor = True
        '
        'ForceToDeleteFile
        '
        Me.ForceToDeleteFile.AutoSize = True
        Me.ForceToDeleteFile.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ForceToDeleteFile.Location = New System.Drawing.Point(0, 21)
        Me.ForceToDeleteFile.Name = "ForceToDeleteFile"
        Me.ForceToDeleteFile.Size = New System.Drawing.Size(149, 17)
        Me.ForceToDeleteFile.TabIndex = 26
        Me.ForceToDeleteFile.Text = "Forced Deletion"
        Me.ForceToDeleteFile.UseVisualStyleBackColor = True
        '
        'RemSFL
        '
        Me.RemSFL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RemSFL.Location = New System.Drawing.Point(207, 284)
        Me.RemSFL.Name = "RemSFL"
        Me.RemSFL.Size = New System.Drawing.Size(154, 23)
        Me.RemSFL.TabIndex = 35
        Me.RemSFL.Text = "Remove Selected From List"
        Me.RemSFL.UseVisualStyleBackColor = True
        '
        'LocateFile
        '
        Me.LocateFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LocateFile.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LocateFile.Location = New System.Drawing.Point(16, 8)
        Me.LocateFile.Name = "LocateFile"
        Me.LocateFile.Size = New System.Drawing.Size(345, 20)
        Me.LocateFile.TabIndex = 34
        Me.LocateFile.Tag = "Enter file name with complete path."
        Me.LocateFile.Text = "Enter file name with complete path."
        '
        'DelSF
        '
        Me.DelSF.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DelSF.Location = New System.Drawing.Point(8, 283)
        Me.DelSF.Name = "DelSF"
        Me.DelSF.Size = New System.Drawing.Size(153, 23)
        Me.DelSF.TabIndex = 33
        Me.DelSF.Text = "Delete Selected File(s)"
        Me.DelSF.UseVisualStyleBackColor = True
        '
        'DelList
        '
        Me.DelList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DelList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SerialDelList, Me.FileDelList, Me.SizeDelList, Me.AttributeDelList, Me.PathDelList})
        Me.DelList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelList.FullRowSelect = True
        Me.DelList.GridLines = True
        Me.DelList.Location = New System.Drawing.Point(0, 36)
        Me.DelList.Name = "DelList"
        Me.DelList.Size = New System.Drawing.Size(599, 242)
        Me.DelList.TabIndex = 32
        Me.DelList.UseCompatibleStateImageBehavior = False
        Me.DelList.View = System.Windows.Forms.View.Details
        '
        'SerialDelList
        '
        Me.SerialDelList.Text = "*"
        Me.SerialDelList.Width = 29
        '
        'FileDelList
        '
        Me.FileDelList.Text = "File"
        Me.FileDelList.Width = 111
        '
        'SizeDelList
        '
        Me.SizeDelList.Text = "Size "
        Me.SizeDelList.Width = 71
        '
        'AttributeDelList
        '
        Me.AttributeDelList.Text = "Attribute"
        Me.AttributeDelList.Width = 75
        '
        'PathDelList
        '
        Me.PathDelList.Text = "Path"
        Me.PathDelList.Width = 501
        '
        'ADDfile2
        '
        Me.ADDfile2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ADDfile2.Location = New System.Drawing.Point(497, 6)
        Me.ADDfile2.Name = "ADDfile2"
        Me.ADDfile2.Size = New System.Drawing.Size(73, 23)
        Me.ADDfile2.TabIndex = 31
        Me.ADDfile2.Text = "Add File"
        Me.ADDfile2.UseVisualStyleBackColor = True
        '
        'DelACF
        '
        Me.DelACF.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DelACF.Location = New System.Drawing.Point(8, 309)
        Me.DelACF.Name = "DelACF"
        Me.DelACF.Size = New System.Drawing.Size(153, 23)
        Me.DelACF.TabIndex = 30
        Me.DelACF.Text = "Delete All Files"
        Me.DelACF.UseVisualStyleBackColor = True
        '
        'ClrList
        '
        Me.ClrList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ClrList.Location = New System.Drawing.Point(207, 309)
        Me.ClrList.Name = "ClrList"
        Me.ClrList.Size = New System.Drawing.Size(154, 23)
        Me.ClrList.TabIndex = 29
        Me.ClrList.Text = "Clear List"
        Me.ClrList.UseVisualStyleBackColor = True
        '
        'UDTabPage2
        '
        Me.UDTabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.UDTabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UDTabPage2.Controls.Add(Me.Label11)
        Me.UDTabPage2.Controls.Add(Me.BR2)
        Me.UDTabPage2.Controls.Add(Me.GroupBox10)
        Me.UDTabPage2.Controls.Add(Me.GroupBox13)
        Me.UDTabPage2.Controls.Add(Me.GroupBox14)
        Me.UDTabPage2.Controls.Add(Me.GroupBox15)
        Me.UDTabPage2.Controls.Add(Me.DirLocation)
        Me.UDTabPage2.Location = New System.Drawing.Point(4, 23)
        Me.UDTabPage2.Name = "UDTabPage2"
        Me.UDTabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.UDTabPage2.Size = New System.Drawing.Size(605, 336)
        Me.UDTabPage2.TabIndex = 1
        Me.UDTabPage2.Text = "Folder Delete Operations"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Location"
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox10.Controls.Add(Me.DelEmptyDir2)
        Me.GroupBox10.Controls.Add(Me.IncSubDir2)
        Me.GroupBox10.Controls.Add(Me.Label12)
        Me.GroupBox10.Controls.Add(Me.ExtBox)
        Me.GroupBox10.Controls.Add(Me.DelFileWithExt)
        Me.GroupBox10.Location = New System.Drawing.Point(278, 49)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(241, 125)
        Me.GroupBox10.TabIndex = 32
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Delete All Files of Specific Type"
        '
        'DelEmptyDir2
        '
        Me.DelEmptyDir2.AutoSize = True
        Me.DelEmptyDir2.Location = New System.Drawing.Point(11, 96)
        Me.DelEmptyDir2.Name = "DelEmptyDir2"
        Me.DelEmptyDir2.Size = New System.Drawing.Size(130, 17)
        Me.DelEmptyDir2.TabIndex = 29
        Me.DelEmptyDir2.Text = "Remove Empty Folder"
        Me.DelEmptyDir2.UseVisualStyleBackColor = True
        '
        'IncSubDir2
        '
        Me.IncSubDir2.AutoSize = True
        Me.IncSubDir2.Location = New System.Drawing.Point(11, 73)
        Me.IncSubDir2.Name = "IncSubDir2"
        Me.IncSubDir2.Size = New System.Drawing.Size(115, 17)
        Me.IncSubDir2.TabIndex = 28
        Me.IncSubDir2.Text = "Include Sub-Folder"
        Me.IncSubDir2.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(134, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Extension to delete"
        '
        'GroupBox13
        '
        Me.GroupBox13.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox13.Controls.Add(Me.REDir1)
        Me.GroupBox13.Controls.Add(Me.IncSd1)
        Me.GroupBox13.Controls.Add(Me.delAF)
        Me.GroupBox13.Location = New System.Drawing.Point(16, 49)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(200, 93)
        Me.GroupBox13.TabIndex = 31
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Clean Folder"
        '
        'REDir1
        '
        Me.REDir1.AutoSize = True
        Me.REDir1.Location = New System.Drawing.Point(34, 64)
        Me.REDir1.Name = "REDir1"
        Me.REDir1.Size = New System.Drawing.Size(130, 17)
        Me.REDir1.TabIndex = 28
        Me.REDir1.Text = "Remove Empty Folder"
        Me.REDir1.UseVisualStyleBackColor = True
        '
        'IncSd1
        '
        Me.IncSd1.AutoSize = True
        Me.IncSd1.Location = New System.Drawing.Point(34, 43)
        Me.IncSd1.Name = "IncSd1"
        Me.IncSd1.Size = New System.Drawing.Size(115, 17)
        Me.IncSd1.TabIndex = 27
        Me.IncSd1.Text = "Include Sub-Folder"
        Me.IncSd1.UseVisualStyleBackColor = True
        '
        'GroupBox14
        '
        Me.GroupBox14.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox14.Controls.Add(Me.RecycleBinBox)
        Me.GroupBox14.Controls.Add(Me.FDel)
        Me.GroupBox14.Location = New System.Drawing.Point(345, 231)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(176, 73)
        Me.GroupBox14.TabIndex = 30
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "General Setting"
        '
        'GroupBox15
        '
        Me.GroupBox15.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox15.Controls.Add(Me.FilesAllowedToDeleteBox)
        Me.GroupBox15.Controls.Add(Me.Label13)
        Me.GroupBox15.Controls.Add(Me.DelAllEmptyDir)
        Me.GroupBox15.Location = New System.Drawing.Point(16, 149)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(200, 161)
        Me.GroupBox15.TabIndex = 29
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Remove Empty Folder"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Delete These Files"
        '
        'DelAllEmptyDir
        '
        Me.DelAllEmptyDir.Location = New System.Drawing.Point(10, 19)
        Me.DelAllEmptyDir.Name = "DelAllEmptyDir"
        Me.DelAllEmptyDir.Size = New System.Drawing.Size(176, 23)
        Me.DelAllEmptyDir.TabIndex = 23
        Me.DelAllEmptyDir.Text = "Delete All empty Folder(s)."
        Me.DelAllEmptyDir.UseVisualStyleBackColor = True
        '
        'UDTabPage3
        '
        Me.UDTabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.UDTabPage3.Controls.Add(Me.EventListview)
        Me.UDTabPage3.ImageKey = "info_32.png"
        Me.UDTabPage3.Location = New System.Drawing.Point(4, 23)
        Me.UDTabPage3.Name = "UDTabPage3"
        Me.UDTabPage3.Size = New System.Drawing.Size(605, 336)
        Me.UDTabPage3.TabIndex = 2
        Me.UDTabPage3.Text = "Action Details"
        '
        'EventListview
        '
        Me.EventListview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7})
        Me.EventListview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EventListview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.EventListview.Location = New System.Drawing.Point(0, 0)
        Me.EventListview.Name = "EventListview"
        Me.EventListview.Size = New System.Drawing.Size(605, 336)
        Me.EventListview.TabIndex = 0
        Me.EventListview.UseCompatibleStateImageBehavior = False
        Me.EventListview.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Details"
        Me.ColumnHeader7.Width = 572
        '
        'SecurityPermissionPage
        '
        Me.SecurityPermissionPage.BackColor = System.Drawing.SystemColors.Control
        Me.SecurityPermissionPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SecurityPermissionPage.Controls.Add(Me.TableLayoutPanel2)
        Me.SecurityPermissionPage.Controls.Add(Me.Label16)
        Me.SecurityPermissionPage.Controls.Add(Me.Panel2)
        Me.SecurityPermissionPage.Controls.Add(Me.Label82)
        Me.SecurityPermissionPage.Controls.Add(Me.Label80)
        Me.SecurityPermissionPage.Controls.Add(Me.LocationPathSecurity)
        Me.SecurityPermissionPage.Controls.Add(Me.NTFSTabControl)
        Me.SecurityPermissionPage.Controls.Add(Me.FileFolderBr)
        Me.SecurityPermissionPage.Controls.Add(Me.RetriveAccessRuleButton)
        Me.SecurityPermissionPage.ImageKey = "(none)"
        Me.SecurityPermissionPage.Location = New System.Drawing.Point(4, 23)
        Me.SecurityPermissionPage.Name = "SecurityPermissionPage"
        Me.SecurityPermissionPage.Size = New System.Drawing.Size(615, 365)
        Me.SecurityPermissionPage.TabIndex = 5
        Me.SecurityPermissionPage.Text = "Files & Folders Security*"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.34233!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.65767!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label62, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label64, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label65, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label66, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label67, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label68, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label69, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label70, 0, 3)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(8, 62)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(595, 64)
        Me.TableLayoutPanel2.TabIndex = 16
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(5, 2)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(98, 13)
        Me.Label62.TabIndex = 0
        Me.Label62.Text = "File or Folder Name"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(5, 17)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(57, 13)
        Me.Label64.TabIndex = 1
        Me.Label64.Text = "Attribute(s)"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(5, 32)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(142, 13)
        Me.Label65.TabIndex = 2
        Me.Label65.Text = "Created On / Last Accessed"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(179, 2)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(40, 13)
        Me.Label66.TabIndex = 3
        Me.Label66.Text = "-----------"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(179, 17)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(40, 13)
        Me.Label67.TabIndex = 4
        Me.Label67.Text = "-----------"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(179, 32)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(40, 13)
        Me.Label68.TabIndex = 5
        Me.Label68.Text = "-----------"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(179, 47)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(40, 13)
        Me.Label69.TabIndex = 6
        Me.Label69.Text = "-----------"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Location = New System.Drawing.Point(5, 47)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(108, 13)
        Me.Label70.TabIndex = 7
        Me.Label70.Text = "Additional Information"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(35, 6)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 13)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Item Type"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DirectoryRadioButton)
        Me.Panel2.Controls.Add(Me.FileRadioButton)
        Me.Panel2.Location = New System.Drawing.Point(8, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(126, 26)
        Me.Panel2.TabIndex = 13
        '
        'DirectoryRadioButton
        '
        Me.DirectoryRadioButton.AutoSize = True
        Me.DirectoryRadioButton.Location = New System.Drawing.Point(60, 3)
        Me.DirectoryRadioButton.Name = "DirectoryRadioButton"
        Me.DirectoryRadioButton.Size = New System.Drawing.Size(54, 17)
        Me.DirectoryRadioButton.TabIndex = 1
        Me.DirectoryRadioButton.Text = "Folder"
        Me.DirectoryRadioButton.UseVisualStyleBackColor = True
        '
        'FileRadioButton
        '
        Me.FileRadioButton.AutoSize = True
        Me.FileRadioButton.Checked = True
        Me.FileRadioButton.Location = New System.Drawing.Point(13, 3)
        Me.FileRadioButton.Name = "FileRadioButton"
        Me.FileRadioButton.Size = New System.Drawing.Size(41, 17)
        Me.FileRadioButton.TabIndex = 0
        Me.FileRadioButton.TabStop = True
        Me.FileRadioButton.Text = "File"
        Me.FileRadioButton.UseVisualStyleBackColor = True
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.Location = New System.Drawing.Point(180, 5)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(211, 15)
        Me.Label82.TabIndex = 6
        Me.Label82.Text = "File && Folder NTFS Permissions"
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label80.Location = New System.Drawing.Point(462, 5)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(116, 13)
        Me.Label80.TabIndex = 0
        Me.Label80.Text = "~Under Development~"
        '
        'LocationPathSecurity
        '
        Me.LocationPathSecurity.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LocationPathSecurity.Location = New System.Drawing.Point(140, 27)
        Me.LocationPathSecurity.Name = "LocationPathSecurity"
        Me.LocationPathSecurity.Size = New System.Drawing.Size(285, 20)
        Me.LocationPathSecurity.TabIndex = 1
        Me.LocationPathSecurity.Tag = "Enter file or folder name with complete path."
        Me.LocationPathSecurity.Text = "Enter file or folder name with complete path."
        '
        'NTFSTabControl
        '
        Me.NTFSTabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NTFSTabControl.Controls.Add(Me.TabPage5)
        Me.NTFSTabControl.Controls.Add(Me.TabPage6)
        Me.NTFSTabControl.Controls.Add(Me.TabPage13)
        Me.NTFSTabControl.Controls.Add(Me.TabPage12)
        Me.NTFSTabControl.Enabled = False
        Me.NTFSTabControl.Location = New System.Drawing.Point(0, 137)
        Me.NTFSTabControl.Name = "NTFSTabControl"
        Me.NTFSTabControl.SelectedIndex = 0
        Me.NTFSTabControl.Size = New System.Drawing.Size(615, 228)
        Me.NTFSTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.NTFSTabControl.TabIndex = 12
        '
        'TabPage5
        '
        Me.TabPage5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage5.Controls.Add(Me.CButton19)
        Me.TabPage5.Controls.Add(Me.CButton18)
        Me.TabPage5.Controls.Add(Me.CButton16)
        Me.TabPage5.Controls.Add(Me.AccessRuleListView)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(607, 202)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "Access Rule"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'CButton19
        '
        Me.CButton19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CButton19.BackColor = System.Drawing.Color.Transparent
        Me.CButton19.ButtonText = "Edit Access Rule"
        Me.CButton19.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButton19.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.CButton19.Enabled = False
        Me.CButton19.FontsStyle = System.Drawing.FontStyle.Regular
        Me.CButton19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.CButton19.Icon = Nothing
        Me.CButton19.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.CButton19.IconSpacingX = 5
        Me.CButton19.IconSpacingY = 5
        Me.CButton19.IconTransparency = 0.0!
        Me.CButton19.Location = New System.Drawing.Point(213, 172)
        Me.CButton19.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.CButton19.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.CButton19.Name = "CButton19"
        Me.CButton19.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.CButton19.Size = New System.Drawing.Size(187, 23)
        Me.CButton19.TabIndex = 13
        Me.CButton19.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.CButton19.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.CButton19.TextSpacingX = 5
        Me.CButton19.TextSpacingY = 5
        '
        'CButton18
        '
        Me.CButton18.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CButton18.BackColor = System.Drawing.Color.Transparent
        Me.CButton18.ButtonText = "Remove Access Rule"
        Me.CButton18.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButton18.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.CButton18.Enabled = False
        Me.CButton18.FontsStyle = System.Drawing.FontStyle.Regular
        Me.CButton18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.CButton18.Icon = Nothing
        Me.CButton18.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.CButton18.IconSpacingX = 5
        Me.CButton18.IconSpacingY = 5
        Me.CButton18.IconTransparency = 0.0!
        Me.CButton18.Location = New System.Drawing.Point(411, 172)
        Me.CButton18.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.CButton18.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.CButton18.Name = "CButton18"
        Me.CButton18.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.CButton18.Size = New System.Drawing.Size(187, 23)
        Me.CButton18.TabIndex = 12
        Me.CButton18.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.CButton18.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.CButton18.TextSpacingX = 5
        Me.CButton18.TextSpacingY = 5
        '
        'CButton16
        '
        Me.CButton16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CButton16.BackColor = System.Drawing.Color.Transparent
        Me.CButton16.ButtonText = "Add Access Rule"
        Me.CButton16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButton16.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.CButton16.Enabled = False
        Me.CButton16.FontsStyle = System.Drawing.FontStyle.Regular
        Me.CButton16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.CButton16.Icon = Nothing
        Me.CButton16.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.CButton16.IconSpacingX = 5
        Me.CButton16.IconSpacingY = 5
        Me.CButton16.IconTransparency = 0.0!
        Me.CButton16.Location = New System.Drawing.Point(8, 172)
        Me.CButton16.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.CButton16.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.CButton16.Name = "CButton16"
        Me.CButton16.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.CButton16.Size = New System.Drawing.Size(187, 23)
        Me.CButton16.TabIndex = 11
        Me.CButton16.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.CButton16.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.CButton16.TextSpacingX = 5
        Me.CButton16.TextSpacingY = 5
        '
        'AccessRuleListView
        '
        Me.AccessRuleListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccessRuleListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21})
        Me.AccessRuleListView.FullRowSelect = True
        Me.AccessRuleListView.Location = New System.Drawing.Point(3, 3)
        Me.AccessRuleListView.MultiSelect = False
        Me.AccessRuleListView.Name = "AccessRuleListView"
        Me.AccessRuleListView.Size = New System.Drawing.Size(599, 165)
        Me.AccessRuleListView.TabIndex = 10
        Me.AccessRuleListView.UseCompatibleStateImageBehavior = False
        Me.AccessRuleListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Type"
        Me.ColumnHeader16.Width = 48
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Group or User name"
        Me.ColumnHeader17.Width = 139
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Inheritance flag"
        Me.ColumnHeader18.Width = 100
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Is Inherited?"
        Me.ColumnHeader19.Width = 79
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Propagation Flag"
        Me.ColumnHeader20.Width = 105
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Permission(s)"
        Me.ColumnHeader21.Width = 120
        '
        'TabPage6
        '
        Me.TabPage6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage6.Controls.Add(Me.AuditRuleListView)
        Me.TabPage6.Controls.Add(Me.CButton22)
        Me.TabPage6.Controls.Add(Me.CButton21)
        Me.TabPage6.Controls.Add(Me.CButton20)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(607, 202)
        Me.TabPage6.TabIndex = 1
        Me.TabPage6.Text = "Audit Rule"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'AuditRuleListView
        '
        Me.AuditRuleListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AuditRuleListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader26, Me.ColumnHeader27})
        Me.AuditRuleListView.FullRowSelect = True
        Me.AuditRuleListView.Location = New System.Drawing.Point(3, 3)
        Me.AuditRuleListView.MultiSelect = False
        Me.AuditRuleListView.Name = "AuditRuleListView"
        Me.AuditRuleListView.Size = New System.Drawing.Size(599, 165)
        Me.AuditRuleListView.TabIndex = 15
        Me.AuditRuleListView.UseCompatibleStateImageBehavior = False
        Me.AuditRuleListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Type"
        Me.ColumnHeader22.Width = 48
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Name"
        Me.ColumnHeader23.Width = 139
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "Inheritance flag"
        Me.ColumnHeader24.Width = 100
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "Is Inherited"
        Me.ColumnHeader25.Width = 79
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "Propogation Flag"
        Me.ColumnHeader26.Width = 105
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "Access"
        Me.ColumnHeader27.Width = 120
        '
        'CButton22
        '
        Me.CButton22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CButton22.BackColor = System.Drawing.Color.Transparent
        Me.CButton22.ButtonText = "Edit Audit Rule"
        Me.CButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButton22.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.CButton22.Enabled = False
        Me.CButton22.FontsStyle = System.Drawing.FontStyle.Regular
        Me.CButton22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.CButton22.Icon = Nothing
        Me.CButton22.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.CButton22.IconSpacingX = 5
        Me.CButton22.IconSpacingY = 5
        Me.CButton22.IconTransparency = 0.0!
        Me.CButton22.Location = New System.Drawing.Point(405, 172)
        Me.CButton22.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.CButton22.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.CButton22.Name = "CButton22"
        Me.CButton22.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.CButton22.Size = New System.Drawing.Size(187, 23)
        Me.CButton22.TabIndex = 14
        Me.CButton22.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.CButton22.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.CButton22.TextSpacingX = 5
        Me.CButton22.TextSpacingY = 5
        '
        'CButton21
        '
        Me.CButton21.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CButton21.BackColor = System.Drawing.Color.Transparent
        Me.CButton21.ButtonText = "Remove Audit Rule"
        Me.CButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButton21.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.CButton21.Enabled = False
        Me.CButton21.FontsStyle = System.Drawing.FontStyle.Regular
        Me.CButton21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.CButton21.Icon = Nothing
        Me.CButton21.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.CButton21.IconSpacingX = 5
        Me.CButton21.IconSpacingY = 5
        Me.CButton21.IconTransparency = 0.0!
        Me.CButton21.Location = New System.Drawing.Point(206, 172)
        Me.CButton21.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.CButton21.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.CButton21.Name = "CButton21"
        Me.CButton21.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.CButton21.Size = New System.Drawing.Size(187, 23)
        Me.CButton21.TabIndex = 13
        Me.CButton21.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.CButton21.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.CButton21.TextSpacingX = 5
        Me.CButton21.TextSpacingY = 5
        '
        'CButton20
        '
        Me.CButton20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CButton20.BackColor = System.Drawing.Color.Transparent
        Me.CButton20.ButtonText = "Add Audit Rule"
        Me.CButton20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButton20.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.CButton20.Enabled = False
        Me.CButton20.FontsStyle = System.Drawing.FontStyle.Regular
        Me.CButton20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.CButton20.Icon = Nothing
        Me.CButton20.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.CButton20.IconSpacingX = 5
        Me.CButton20.IconSpacingY = 5
        Me.CButton20.IconTransparency = 0.0!
        Me.CButton20.Location = New System.Drawing.Point(8, 172)
        Me.CButton20.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.CButton20.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.CButton20.Name = "CButton20"
        Me.CButton20.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.CButton20.Size = New System.Drawing.Size(187, 23)
        Me.CButton20.TabIndex = 12
        Me.CButton20.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.CButton20.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.CButton20.TextSpacingX = 5
        Me.CButton20.TextSpacingY = 5
        '
        'TabPage13
        '
        Me.TabPage13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage13.Controls.Add(Me.OwnerApplyButton)
        Me.TabPage13.Controls.Add(Me.Label88)
        Me.TabPage13.Controls.Add(Me.Label87)
        Me.TabPage13.Controls.Add(Me.Label85)
        Me.TabPage13.Controls.Add(Me.Label83)
        Me.TabPage13.Controls.Add(Me.OwnerComboBox)
        Me.TabPage13.Controls.Add(Me.Label81)
        Me.TabPage13.Location = New System.Drawing.Point(4, 22)
        Me.TabPage13.Name = "TabPage13"
        Me.TabPage13.Size = New System.Drawing.Size(607, 202)
        Me.TabPage13.TabIndex = 3
        Me.TabPage13.Text = "Owner"
        Me.TabPage13.UseVisualStyleBackColor = True
        '
        'OwnerApplyButton
        '
        Me.OwnerApplyButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.OwnerApplyButton.BackColor = System.Drawing.Color.Transparent
        Me.OwnerApplyButton.ButtonText = "Apply"
        Me.OwnerApplyButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OwnerApplyButton.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.OwnerApplyButton.FontsStyle = System.Drawing.FontStyle.Regular
        Me.OwnerApplyButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.OwnerApplyButton.Icon = Nothing
        Me.OwnerApplyButton.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.OwnerApplyButton.IconSpacingX = 5
        Me.OwnerApplyButton.IconSpacingY = 5
        Me.OwnerApplyButton.IconTransparency = 0.0!
        Me.OwnerApplyButton.Location = New System.Drawing.Point(262, 156)
        Me.OwnerApplyButton.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.OwnerApplyButton.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.OwnerApplyButton.Name = "OwnerApplyButton"
        Me.OwnerApplyButton.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.OwnerApplyButton.Size = New System.Drawing.Size(92, 27)
        Me.OwnerApplyButton.TabIndex = 7
        Me.OwnerApplyButton.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.OwnerApplyButton.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.OwnerApplyButton.TextSpacingX = 5
        Me.OwnerApplyButton.TextSpacingY = 5
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Location = New System.Drawing.Point(118, 21)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(40, 13)
        Me.Label88.TabIndex = 6
        Me.Label88.Text = "-----------"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Location = New System.Drawing.Point(14, 21)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(86, 13)
        Me.Label87.TabIndex = 5
        Me.Label87.Text = "Current Domain :"
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Location = New System.Drawing.Point(17, 132)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(84, 13)
        Me.Label85.TabIndex = 4
        Me.Label85.Text = "Change Owner :"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Location = New System.Drawing.Point(118, 58)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(40, 13)
        Me.Label83.TabIndex = 3
        Me.Label83.Text = "-----------"
        '
        'OwnerComboBox
        '
        Me.OwnerComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OwnerComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.OwnerComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.OwnerComboBox.FormattingEnabled = True
        Me.OwnerComboBox.Location = New System.Drawing.Point(121, 129)
        Me.OwnerComboBox.Name = "OwnerComboBox"
        Me.OwnerComboBox.Size = New System.Drawing.Size(389, 21)
        Me.OwnerComboBox.TabIndex = 2
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Location = New System.Drawing.Point(14, 58)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(84, 13)
        Me.Label81.TabIndex = 1
        Me.Label81.Text = "Current Owner  :"
        '
        'TabPage12
        '
        Me.TabPage12.BackColor = System.Drawing.Color.Transparent
        Me.TabPage12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage12.Controls.Add(Me.Label9)
        Me.TabPage12.Controls.Add(Me.Label79)
        Me.TabPage12.Controls.Add(Me.Label77)
        Me.TabPage12.Controls.Add(Me.Label74)
        Me.TabPage12.Controls.Add(Me.RemoveFullControlButton)
        Me.TabPage12.Controls.Add(Me.GetFullControlButton)
        Me.TabPage12.Location = New System.Drawing.Point(4, 22)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Size = New System.Drawing.Size(607, 202)
        Me.TabPage12.TabIndex = 2
        Me.TabPage12.Text = "Options"
        Me.TabPage12.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(63, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(427, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Warning! Do not attempt this if you do not KNOW what this function does!"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Location = New System.Drawing.Point(14, 116)
        Me.Label79.Name = "Label79"
        Me.Label79.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label79.Size = New System.Drawing.Size(462, 78)
        Me.Label79.TabIndex = 4
        Me.Label79.Text = resources.GetString("Label79.Text")
        Me.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Location = New System.Drawing.Point(73, 12)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(31, 13)
        Me.Label77.TabIndex = 2
        Me.Label77.Text = "--------"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Location = New System.Drawing.Point(13, 12)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(54, 13)
        Me.Label74.TabIndex = 1
        Me.Label74.Text = "Full Path :"
        '
        'RemoveFullControlButton
        '
        Me.RemoveFullControlButton.BackColor = System.Drawing.Color.Transparent
        Me.RemoveFullControlButton.ButtonText = "One Click Remove Full Control"
        Me.RemoveFullControlButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RemoveFullControlButton.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.RemoveFullControlButton.FontsStyle = System.Drawing.FontStyle.Regular
        Me.RemoveFullControlButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.RemoveFullControlButton.Icon = Nothing
        Me.RemoveFullControlButton.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.RemoveFullControlButton.IconSpacingX = 5
        Me.RemoveFullControlButton.IconSpacingY = 5
        Me.RemoveFullControlButton.IconTransparency = 0.0!
        Me.RemoveFullControlButton.Location = New System.Drawing.Point(355, 45)
        Me.RemoveFullControlButton.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.RemoveFullControlButton.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.RemoveFullControlButton.Name = "RemoveFullControlButton"
        Me.RemoveFullControlButton.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.RemoveFullControlButton.Size = New System.Drawing.Size(187, 23)
        Me.RemoveFullControlButton.TabIndex = 3
        Me.RemoveFullControlButton.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.RemoveFullControlButton.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.RemoveFullControlButton.TextSpacingX = 5
        Me.RemoveFullControlButton.TextSpacingY = 5
        '
        'GetFullControlButton
        '
        Me.GetFullControlButton.BackColor = System.Drawing.Color.Transparent
        Me.GetFullControlButton.ButtonText = "One Click Get Full Control"
        Me.GetFullControlButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GetFullControlButton.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.GetFullControlButton.FontsStyle = System.Drawing.FontStyle.Regular
        Me.GetFullControlButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.GetFullControlButton.Icon = Nothing
        Me.GetFullControlButton.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.GetFullControlButton.IconSpacingX = 5
        Me.GetFullControlButton.IconSpacingY = 5
        Me.GetFullControlButton.IconTransparency = 0.0!
        Me.GetFullControlButton.Location = New System.Drawing.Point(62, 45)
        Me.GetFullControlButton.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.GetFullControlButton.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.GetFullControlButton.Name = "GetFullControlButton"
        Me.GetFullControlButton.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.GetFullControlButton.Size = New System.Drawing.Size(187, 23)
        Me.GetFullControlButton.TabIndex = 0
        Me.GetFullControlButton.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.GetFullControlButton.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.GetFullControlButton.TextSpacingX = 5
        Me.GetFullControlButton.TextSpacingY = 5
        '
        'FileFolderBr
        '
        Me.FileFolderBr.BackColor = System.Drawing.Color.Transparent
        Me.FileFolderBr.ButtonText = "Browse"
        Me.FileFolderBr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FileFolderBr.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.FileFolderBr.FontsStyle = System.Drawing.FontStyle.Regular
        Me.FileFolderBr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.FileFolderBr.Icon = Nothing
        Me.FileFolderBr.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.FileFolderBr.IconSpacingX = 5
        Me.FileFolderBr.IconSpacingY = 5
        Me.FileFolderBr.IconTransparency = 0.0!
        Me.FileFolderBr.Location = New System.Drawing.Point(431, 26)
        Me.FileFolderBr.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.FileFolderBr.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.FileFolderBr.Name = "FileFolderBr"
        Me.FileFolderBr.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.FileFolderBr.Size = New System.Drawing.Size(56, 21)
        Me.FileFolderBr.TabIndex = 14
        Me.FileFolderBr.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.FileFolderBr.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.FileFolderBr.TextSpacingX = 5
        Me.FileFolderBr.TextSpacingY = 5
        '
        'RetriveAccessRuleButton
        '
        Me.RetriveAccessRuleButton.BackColor = System.Drawing.Color.Transparent
        Me.RetriveAccessRuleButton.ButtonText = "Retrieve - Rule(s)"
        Me.RetriveAccessRuleButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RetriveAccessRuleButton.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.RetriveAccessRuleButton.FontsStyle = System.Drawing.FontStyle.Regular
        Me.RetriveAccessRuleButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.RetriveAccessRuleButton.Icon = Nothing
        Me.RetriveAccessRuleButton.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.RetriveAccessRuleButton.IconSpacingX = 5
        Me.RetriveAccessRuleButton.IconSpacingY = 5
        Me.RetriveAccessRuleButton.IconTransparency = 0.0!
        Me.RetriveAccessRuleButton.Location = New System.Drawing.Point(493, 26)
        Me.RetriveAccessRuleButton.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.RetriveAccessRuleButton.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.RetriveAccessRuleButton.Name = "RetriveAccessRuleButton"
        Me.RetriveAccessRuleButton.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.RetriveAccessRuleButton.Size = New System.Drawing.Size(110, 21)
        Me.RetriveAccessRuleButton.TabIndex = 9
        Me.RetriveAccessRuleButton.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.RetriveAccessRuleButton.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.RetriveAccessRuleButton.TextSpacingX = 5
        Me.RetriveAccessRuleButton.TextSpacingY = 5
        '
        'UnlockerPage
        '
        Me.UnlockerPage.BackColor = System.Drawing.SystemColors.Control
        Me.UnlockerPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UnlockerPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UnlockerPage.Controls.Add(Me.CheckBox7)
        Me.UnlockerPage.Controls.Add(Me.UnlockerGo)
        Me.UnlockerPage.Controls.Add(Me.Label78)
        Me.UnlockerPage.Controls.Add(Me.ProcessListOfModule)
        Me.UnlockerPage.Controls.Add(Me.Unlockerbrowse)
        Me.UnlockerPage.Controls.Add(Me.ModuleAbsolutePathBox)
        Me.UnlockerPage.Controls.Add(Me.Label76)
        Me.UnlockerPage.ImageKey = "key_32.png"
        Me.UnlockerPage.Location = New System.Drawing.Point(4, 23)
        Me.UnlockerPage.Name = "UnlockerPage"
        Me.UnlockerPage.Size = New System.Drawing.Size(631, 400)
        Me.UnlockerPage.TabIndex = 10
        Me.UnlockerPage.Text = "Unlocker"
        '
        'CheckBox7
        '
        Me.CheckBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(424, 58)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(167, 17)
        Me.CheckBox7.TabIndex = 16
        Me.CheckBox7.Text = "Show details after termination."
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'UnlockerGo
        '
        Me.UnlockerGo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UnlockerGo.Location = New System.Drawing.Point(478, 28)
        Me.UnlockerGo.Name = "UnlockerGo"
        Me.UnlockerGo.Size = New System.Drawing.Size(56, 23)
        Me.UnlockerGo.TabIndex = 15
        Me.UnlockerGo.Text = "Scan"
        Me.UnlockerGo.UseVisualStyleBackColor = True
        '
        'Label78
        '
        Me.Label78.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label78.AutoSize = True
        Me.Label78.BackColor = System.Drawing.Color.Transparent
        Me.Label78.Location = New System.Drawing.Point(135, 62)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(148, 13)
        Me.Label78.TabIndex = 14
        Me.Label78.Text = "Only modules will be released."
        '
        'ProcessListOfModule
        '
        Me.ProcessListOfModule.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ProcessListOfModule.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProcessListOfModule.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ProcessListOfModule.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ProcessModuleBaseAddress})
        Me.ProcessListOfModule.ContextMenuStrip = Me.ProcessModuleListStrip
        Me.ProcessListOfModule.FullRowSelect = True
        Me.ProcessListOfModule.GridLines = True
        Me.ProcessListOfModule.Location = New System.Drawing.Point(11, 84)
        Me.ProcessListOfModule.MultiSelect = False
        Me.ProcessListOfModule.Name = "ProcessListOfModule"
        Me.ProcessListOfModule.Size = New System.Drawing.Size(606, 300)
        Me.ProcessListOfModule.SmallImageList = Me.ImageList2
        Me.ProcessListOfModule.TabIndex = 10
        Me.ProcessListOfModule.UseCompatibleStateImageBehavior = False
        Me.ProcessListOfModule.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Process Name"
        Me.ColumnHeader12.Width = 142
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "PID"
        Me.ColumnHeader13.Width = 55
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Process File Path"
        Me.ColumnHeader14.Width = 250
        '
        'ProcessModuleBaseAddress
        '
        Me.ProcessModuleBaseAddress.Text = "Module Base Address"
        Me.ProcessModuleBaseAddress.Width = 143
        '
        'ProcessModuleListStrip
        '
        Me.ProcessModuleListStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LocateThisProcessInProcessListToolStripMenuItem, Me.GetProToolStripMenuItem, Me.ToolStripSeparator15, Me.ReleseCurrentModuleFromThisProcessToolStripMenuItem, Me.KillProcessToolStripMenuItem1, Me.KillProcessAndDeleteParentFileToolStripMenuItem, Me.GetRelatedProcessToolStripMenuItem, Me.ToolStripSeparator11, Me.ReleaseModuleFromAllProcessToolStripMenuItem, Me.ReleaseDeleteModuleToolStripMenuItem, Me.ToolStripSeparator12, Me.OpenLocationToolStripMenuItem})
        Me.ProcessModuleListStrip.Name = "ProcessModuleListStrip"
        Me.ProcessModuleListStrip.Size = New System.Drawing.Size(300, 220)
        '
        'LocateThisProcessInProcessListToolStripMenuItem
        '
        Me.LocateThisProcessInProcessListToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.find
        Me.LocateThisProcessInProcessListToolStripMenuItem.Name = "LocateThisProcessInProcessListToolStripMenuItem"
        Me.LocateThisProcessInProcessListToolStripMenuItem.Size = New System.Drawing.Size(299, 22)
        Me.LocateThisProcessInProcessListToolStripMenuItem.Text = "Locate this Process in Process List"
        '
        'GetProToolStripMenuItem
        '
        Me.GetProToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.information
        Me.GetProToolStripMenuItem.Name = "GetProToolStripMenuItem"
        Me.GetProToolStripMenuItem.Size = New System.Drawing.Size(299, 22)
        Me.GetProToolStripMenuItem.Text = "Get Process File Properties"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(296, 6)
        '
        'ReleseCurrentModuleFromThisProcessToolStripMenuItem
        '
        Me.ReleseCurrentModuleFromThisProcessToolStripMenuItem.Image = CType(resources.GetObject("ReleseCurrentModuleFromThisProcessToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReleseCurrentModuleFromThisProcessToolStripMenuItem.Name = "ReleseCurrentModuleFromThisProcessToolStripMenuItem"
        Me.ReleseCurrentModuleFromThisProcessToolStripMenuItem.Size = New System.Drawing.Size(299, 22)
        Me.ReleseCurrentModuleFromThisProcessToolStripMenuItem.Text = "Release Current Module From This Process"
        '
        'KillProcessToolStripMenuItem1
        '
        Me.KillProcessToolStripMenuItem1.Image = CType(resources.GetObject("KillProcessToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.KillProcessToolStripMenuItem1.Name = "KillProcessToolStripMenuItem1"
        Me.KillProcessToolStripMenuItem1.Size = New System.Drawing.Size(299, 22)
        Me.KillProcessToolStripMenuItem1.Text = "Kill Selected Process"
        '
        'KillProcessAndDeleteParentFileToolStripMenuItem
        '
        Me.KillProcessAndDeleteParentFileToolStripMenuItem.Image = CType(resources.GetObject("KillProcessAndDeleteParentFileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KillProcessAndDeleteParentFileToolStripMenuItem.Name = "KillProcessAndDeleteParentFileToolStripMenuItem"
        Me.KillProcessAndDeleteParentFileToolStripMenuItem.Size = New System.Drawing.Size(299, 22)
        Me.KillProcessAndDeleteParentFileToolStripMenuItem.Text = "Kill Process and Delete Parent File"
        '
        'GetRelatedProcessToolStripMenuItem
        '
        Me.GetRelatedProcessToolStripMenuItem.Image = CType(resources.GetObject("GetRelatedProcessToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GetRelatedProcessToolStripMenuItem.Name = "GetRelatedProcessToolStripMenuItem"
        Me.GetRelatedProcessToolStripMenuItem.Size = New System.Drawing.Size(299, 22)
        Me.GetRelatedProcessToolStripMenuItem.Text = "Get All Modules of This Process"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(296, 6)
        '
        'ReleaseModuleFromAllProcessToolStripMenuItem
        '
        Me.ReleaseModuleFromAllProcessToolStripMenuItem.Image = CType(resources.GetObject("ReleaseModuleFromAllProcessToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReleaseModuleFromAllProcessToolStripMenuItem.Name = "ReleaseModuleFromAllProcessToolStripMenuItem"
        Me.ReleaseModuleFromAllProcessToolStripMenuItem.Size = New System.Drawing.Size(299, 22)
        Me.ReleaseModuleFromAllProcessToolStripMenuItem.Text = "Release This Module From All Processes"
        '
        'ReleaseDeleteModuleToolStripMenuItem
        '
        Me.ReleaseDeleteModuleToolStripMenuItem.Image = CType(resources.GetObject("ReleaseDeleteModuleToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReleaseDeleteModuleToolStripMenuItem.Name = "ReleaseDeleteModuleToolStripMenuItem"
        Me.ReleaseDeleteModuleToolStripMenuItem.Size = New System.Drawing.Size(299, 22)
        Me.ReleaseDeleteModuleToolStripMenuItem.Text = "Release and Delete This Module"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(296, 6)
        '
        'OpenLocationToolStripMenuItem
        '
        Me.OpenLocationToolStripMenuItem.Image = CType(resources.GetObject("OpenLocationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenLocationToolStripMenuItem.Name = "OpenLocationToolStripMenuItem"
        Me.OpenLocationToolStripMenuItem.Size = New System.Drawing.Size(299, 22)
        Me.OpenLocationToolStripMenuItem.Text = "Open Location of Process Executable"
        '
        'Unlockerbrowse
        '
        Me.Unlockerbrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Unlockerbrowse.Location = New System.Drawing.Point(377, 29)
        Me.Unlockerbrowse.Name = "Unlockerbrowse"
        Me.Unlockerbrowse.Size = New System.Drawing.Size(86, 23)
        Me.Unlockerbrowse.TabIndex = 9
        Me.Unlockerbrowse.Text = "Browse"
        Me.Unlockerbrowse.UseVisualStyleBackColor = True
        '
        'ModuleAbsolutePathBox
        '
        Me.ModuleAbsolutePathBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModuleAbsolutePathBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ModuleAbsolutePathBox.Location = New System.Drawing.Point(14, 31)
        Me.ModuleAbsolutePathBox.Name = "ModuleAbsolutePathBox"
        Me.ModuleAbsolutePathBox.Size = New System.Drawing.Size(344, 20)
        Me.ModuleAbsolutePathBox.TabIndex = 7
        Me.ModuleAbsolutePathBox.Tag = "Enter Module name with complete path."
        Me.ModuleAbsolutePathBox.Text = "Enter Module name with complete path."
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.BackColor = System.Drawing.Color.Transparent
        Me.Label76.Location = New System.Drawing.Point(13, 10)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(132, 13)
        Me.Label76.TabIndex = 6
        Me.Label76.Text = "Module name and it's Path"
        '
        'OtherToolPage
        '
        Me.OtherToolPage.BackColor = System.Drawing.SystemColors.Control
        Me.OtherToolPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OtherToolPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OtherToolPage.Controls.Add(Me.FileProtectorButton)
        Me.OtherToolPage.Controls.Add(Me.WCleanButton)
        Me.OtherToolPage.Controls.Add(Me.HideDriveButton)
        Me.OtherToolPage.Controls.Add(Me.ProcessCommandLine)
        Me.OtherToolPage.Controls.Add(Me.MSInfoButton)
        Me.OtherToolPage.Controls.Add(Me.GroupBox8)
        Me.OtherToolPage.Controls.Add(Me.CommandPromptButton)
        Me.OtherToolPage.Controls.Add(Me.RenameIEButton)
        Me.OtherToolPage.Controls.Add(Me.DXDiagButton)
        Me.OtherToolPage.ImageKey = "gear_32.png"
        Me.OtherToolPage.Location = New System.Drawing.Point(4, 23)
        Me.OtherToolPage.Margin = New System.Windows.Forms.Padding(1)
        Me.OtherToolPage.Name = "OtherToolPage"
        Me.OtherToolPage.Size = New System.Drawing.Size(631, 400)
        Me.OtherToolPage.TabIndex = 7
        Me.OtherToolPage.Text = "Other Tools"
        '
        'FileProtectorButton
        '
        Me.FileProtectorButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.FileProtectorButton.BackColor = System.Drawing.Color.Transparent
        Me.FileProtectorButton.ButtonText = "File Protector"
        Me.FileProtectorButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FileProtectorButton.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.FileProtectorButton.FontsStyle = System.Drawing.FontStyle.Regular
        Me.FileProtectorButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.FileProtectorButton.Icon = Nothing
        Me.FileProtectorButton.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.FileProtectorButton.IconSpacingX = 5
        Me.FileProtectorButton.IconSpacingY = 5
        Me.FileProtectorButton.IconTransparency = 0.0!
        Me.FileProtectorButton.Location = New System.Drawing.Point(215, 318)
        Me.FileProtectorButton.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.FileProtectorButton.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.FileProtectorButton.Name = "FileProtectorButton"
        Me.FileProtectorButton.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.FileProtectorButton.Size = New System.Drawing.Size(196, 22)
        Me.FileProtectorButton.TabIndex = 201
        Me.FileProtectorButton.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.FileProtectorButton.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.FileProtectorButton.TextSpacingX = 5
        Me.FileProtectorButton.TextSpacingY = 5
        '
        'WCleanButton
        '
        Me.WCleanButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WCleanButton.BackColor = System.Drawing.Color.Transparent
        Me.WCleanButton.ButtonText = "Windows Cleaner"
        Me.WCleanButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WCleanButton.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.WCleanButton.FontsStyle = System.Drawing.FontStyle.Regular
        Me.WCleanButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.WCleanButton.Icon = Nothing
        Me.WCleanButton.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.WCleanButton.IconSpacingX = 5
        Me.WCleanButton.IconSpacingY = 5
        Me.WCleanButton.IconTransparency = 0.0!
        Me.WCleanButton.Location = New System.Drawing.Point(215, 346)
        Me.WCleanButton.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.WCleanButton.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.WCleanButton.Name = "WCleanButton"
        Me.WCleanButton.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.WCleanButton.Size = New System.Drawing.Size(196, 22)
        Me.WCleanButton.TabIndex = 200
        Me.WCleanButton.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.WCleanButton.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.WCleanButton.TextSpacingX = 5
        Me.WCleanButton.TextSpacingY = 5
        '
        'HideDriveButton
        '
        Me.HideDriveButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.HideDriveButton.BackColor = System.Drawing.Color.Transparent
        Me.HideDriveButton.ButtonText = "Hide Drive(s)"
        Me.HideDriveButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HideDriveButton.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.HideDriveButton.FontsStyle = System.Drawing.FontStyle.Regular
        Me.HideDriveButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.HideDriveButton.Icon = Nothing
        Me.HideDriveButton.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.HideDriveButton.IconSpacingX = 5
        Me.HideDriveButton.IconSpacingY = 5
        Me.HideDriveButton.IconTransparency = 0.0!
        Me.HideDriveButton.Location = New System.Drawing.Point(215, 290)
        Me.HideDriveButton.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.HideDriveButton.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.HideDriveButton.Name = "HideDriveButton"
        Me.HideDriveButton.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.HideDriveButton.Size = New System.Drawing.Size(196, 22)
        Me.HideDriveButton.TabIndex = 199
        Me.HideDriveButton.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.HideDriveButton.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.HideDriveButton.TextSpacingX = 5
        Me.HideDriveButton.TextSpacingY = 5
        '
        'ProcessCommandLine
        '
        Me.ProcessCommandLine.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ProcessCommandLine.BackColor = System.Drawing.Color.Transparent
        Me.ProcessCommandLine.ButtonText = "Process Command Line"
        Me.ProcessCommandLine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProcessCommandLine.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.ProcessCommandLine.FontsStyle = System.Drawing.FontStyle.Regular
        Me.ProcessCommandLine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.ProcessCommandLine.Icon = Nothing
        Me.ProcessCommandLine.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.ProcessCommandLine.IconSpacingX = 5
        Me.ProcessCommandLine.IconSpacingY = 5
        Me.ProcessCommandLine.IconTransparency = 0.0!
        Me.ProcessCommandLine.Location = New System.Drawing.Point(215, 262)
        Me.ProcessCommandLine.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.ProcessCommandLine.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.ProcessCommandLine.Name = "ProcessCommandLine"
        Me.ProcessCommandLine.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.ProcessCommandLine.Size = New System.Drawing.Size(196, 22)
        Me.ProcessCommandLine.TabIndex = 198
        Me.ProcessCommandLine.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.ProcessCommandLine.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.ProcessCommandLine.TextSpacingX = 5
        Me.ProcessCommandLine.TextSpacingY = 5
        '
        'MSInfoButton
        '
        Me.MSInfoButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MSInfoButton.BackColor = System.Drawing.Color.Transparent
        Me.MSInfoButton.ButtonText = "MS Info tool"
        Me.MSInfoButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MSInfoButton.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.MSInfoButton.FontsStyle = System.Drawing.FontStyle.Regular
        Me.MSInfoButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.MSInfoButton.Icon = Nothing
        Me.MSInfoButton.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.MSInfoButton.IconSpacingX = 5
        Me.MSInfoButton.IconSpacingY = 5
        Me.MSInfoButton.IconTransparency = 0.0!
        Me.MSInfoButton.Location = New System.Drawing.Point(215, 234)
        Me.MSInfoButton.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.MSInfoButton.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.MSInfoButton.Name = "MSInfoButton"
        Me.MSInfoButton.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.MSInfoButton.Size = New System.Drawing.Size(196, 22)
        Me.MSInfoButton.TabIndex = 196
        Me.MSInfoButton.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.MSInfoButton.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.MSInfoButton.TextSpacingX = 5
        Me.MSInfoButton.TextSpacingY = 5
        '
        'CommandPromptButton
        '
        Me.CommandPromptButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CommandPromptButton.BackColor = System.Drawing.Color.Transparent
        Me.CommandPromptButton.ButtonText = "Command Prompt"
        Me.CommandPromptButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CommandPromptButton.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.CommandPromptButton.FontsStyle = System.Drawing.FontStyle.Regular
        Me.CommandPromptButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.CommandPromptButton.Icon = Nothing
        Me.CommandPromptButton.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.CommandPromptButton.IconSpacingX = 5
        Me.CommandPromptButton.IconSpacingY = 5
        Me.CommandPromptButton.IconTransparency = 0.0!
        Me.CommandPromptButton.Location = New System.Drawing.Point(215, 178)
        Me.CommandPromptButton.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.CommandPromptButton.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.CommandPromptButton.Name = "CommandPromptButton"
        Me.CommandPromptButton.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.CommandPromptButton.Size = New System.Drawing.Size(196, 22)
        Me.CommandPromptButton.TabIndex = 194
        Me.CommandPromptButton.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.CommandPromptButton.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.CommandPromptButton.TextSpacingX = 5
        Me.CommandPromptButton.TextSpacingY = 5
        '
        'RenameIEButton
        '
        Me.RenameIEButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RenameIEButton.BackColor = System.Drawing.Color.Transparent
        Me.RenameIEButton.ButtonText = "Rename Internet Explorer Title Bar"
        Me.RenameIEButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RenameIEButton.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.RenameIEButton.FontsStyle = System.Drawing.FontStyle.Regular
        Me.RenameIEButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.RenameIEButton.Icon = Nothing
        Me.RenameIEButton.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.RenameIEButton.IconSpacingX = 5
        Me.RenameIEButton.IconSpacingY = 5
        Me.RenameIEButton.IconTransparency = 0.0!
        Me.RenameIEButton.Location = New System.Drawing.Point(215, 150)
        Me.RenameIEButton.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.RenameIEButton.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.RenameIEButton.Name = "RenameIEButton"
        Me.RenameIEButton.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.RenameIEButton.Size = New System.Drawing.Size(196, 22)
        Me.RenameIEButton.TabIndex = 189
        Me.RenameIEButton.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.RenameIEButton.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.RenameIEButton.TextSpacingX = 5
        Me.RenameIEButton.TextSpacingY = 5
        '
        'DXDiagButton
        '
        Me.DXDiagButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DXDiagButton.BackColor = System.Drawing.Color.Transparent
        Me.DXDiagButton.ButtonText = "DirectX Diagnostic Tool"
        Me.DXDiagButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DXDiagButton.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.DXDiagButton.FontsStyle = System.Drawing.FontStyle.Regular
        Me.DXDiagButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.DXDiagButton.Icon = Nothing
        Me.DXDiagButton.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.DXDiagButton.IconSpacingX = 5
        Me.DXDiagButton.IconSpacingY = 5
        Me.DXDiagButton.IconTransparency = 0.0!
        Me.DXDiagButton.Location = New System.Drawing.Point(215, 206)
        Me.DXDiagButton.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.DXDiagButton.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.DXDiagButton.Name = "DXDiagButton"
        Me.DXDiagButton.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.DXDiagButton.Size = New System.Drawing.Size(196, 22)
        Me.DXDiagButton.TabIndex = 195
        Me.DXDiagButton.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.DXDiagButton.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.DXDiagButton.TextSpacingX = 5
        Me.DXDiagButton.TextSpacingY = 5
        '
        'SettingPage
        '
        Me.SettingPage.BackColor = System.Drawing.SystemColors.Control
        Me.SettingPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SettingPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SettingPage.Controls.Add(Me.DisableExitDialog)
        Me.SettingPage.Controls.Add(Me.RedTheme)
        Me.SettingPage.Controls.Add(Me.CheckBox4)
        Me.SettingPage.Controls.Add(Me.GroupBox12)
        Me.SettingPage.Controls.Add(Me.Label63)
        Me.SettingPage.Controls.Add(Me.Label61)
        Me.SettingPage.Controls.Add(Me.CheckBox6)
        Me.SettingPage.Controls.Add(Me.Label75)
        Me.SettingPage.Controls.Add(Me.EnableProcessFilter)
        Me.SettingPage.Controls.Add(Me.CheckBox5)
        Me.SettingPage.Controls.Add(Me.Label20)
        Me.SettingPage.Controls.Add(Me.Label19)
        Me.SettingPage.Controls.Add(Me.Label18)
        Me.SettingPage.Controls.Add(Me.ScanTime)
        Me.SettingPage.Controls.Add(Me.send2tray)
        Me.SettingPage.Controls.Add(Me.IGN_CDROM)
        Me.SettingPage.Controls.Add(Me.AutomaticDeleteAutorun)
        Me.SettingPage.Controls.Add(Me.AddStartup)
        Me.SettingPage.Controls.Add(Me.Help_box)
        Me.SettingPage.Controls.Add(Me.TrackBar1)
        Me.SettingPage.Controls.Add(Me.TrackBar2)
        Me.SettingPage.ImageKey = "spanner_48.png"
        Me.SettingPage.Location = New System.Drawing.Point(4, 23)
        Me.SettingPage.Name = "SettingPage"
        Me.SettingPage.Padding = New System.Windows.Forms.Padding(3)
        Me.SettingPage.Size = New System.Drawing.Size(631, 400)
        Me.SettingPage.TabIndex = 4
        Me.SettingPage.Text = "Options"
        '
        'DisableExitDialog
        '
        Me.DisableExitDialog.AutoSize = True
        Me.DisableExitDialog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisableExitDialog.Location = New System.Drawing.Point(17, 352)
        Me.DisableExitDialog.Name = "DisableExitDialog"
        Me.DisableExitDialog.Size = New System.Drawing.Size(139, 20)
        Me.DisableExitDialog.TabIndex = 194
        Me.DisableExitDialog.Text = "Disable Exit dialog"
        Me.DisableExitDialog.UseVisualStyleBackColor = True
        '
        'RedTheme
        '
        Me.RedTheme.AutoSize = True
        Me.RedTheme.Checked = True
        Me.RedTheme.Location = New System.Drawing.Point(445, 294)
        Me.RedTheme.Name = "RedTheme"
        Me.RedTheme.Size = New System.Drawing.Size(81, 17)
        Me.RedTheme.TabIndex = 2
        Me.RedTheme.TabStop = True
        Me.RedTheme.Text = "Red Theme"
        Me.RedTheme.UseVisualStyleBackColor = True
        Me.RedTheme.Visible = False
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox4.Location = New System.Drawing.Point(17, 232)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(198, 20)
        Me.CheckBox4.TabIndex = 193
        Me.CheckBox4.Text = "Do not ignore floppy drive(s)."
        Me.CheckBox4.UseVisualStyleBackColor = False
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox12.Controls.Add(Me.GreenTheme)
        Me.GroupBox12.Controls.Add(Me.BlueTheme)
        Me.GroupBox12.Location = New System.Drawing.Point(230, 258)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(128, 68)
        Me.GroupBox12.TabIndex = 188
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "V.E.R. Theme"
        '
        'GreenTheme
        '
        Me.GreenTheme.AutoSize = True
        Me.GreenTheme.BackColor = System.Drawing.SystemColors.Control
        Me.GreenTheme.Location = New System.Drawing.Point(19, 40)
        Me.GreenTheme.Name = "GreenTheme"
        Me.GreenTheme.Size = New System.Drawing.Size(90, 17)
        Me.GreenTheme.TabIndex = 1
        Me.GreenTheme.Text = "Green Theme"
        Me.GreenTheme.UseVisualStyleBackColor = False
        '
        'BlueTheme
        '
        Me.BlueTheme.AutoSize = True
        Me.BlueTheme.BackColor = System.Drawing.SystemColors.Control
        Me.BlueTheme.Checked = True
        Me.BlueTheme.Location = New System.Drawing.Point(19, 21)
        Me.BlueTheme.Name = "BlueTheme"
        Me.BlueTheme.Size = New System.Drawing.Size(91, 17)
        Me.BlueTheme.TabIndex = 0
        Me.BlueTheme.TabStop = True
        Me.BlueTheme.Text = "Blue Theme   "
        Me.BlueTheme.UseVisualStyleBackColor = False
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.BackColor = System.Drawing.Color.Red
        Me.Label63.ForeColor = System.Drawing.Color.White
        Me.Label63.Location = New System.Drawing.Point(316, 132)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(13, 13)
        Me.Label63.TabIndex = 187
        Me.Label63.Text = "2"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.BackColor = System.Drawing.Color.Red
        Me.Label61.ForeColor = System.Drawing.Color.White
        Me.Label61.Location = New System.Drawing.Point(316, 184)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(13, 13)
        Me.Label61.TabIndex = 185
        Me.Label61.Text = "1"
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox6.Location = New System.Drawing.Point(17, 181)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(291, 20)
        Me.CheckBox6.TabIndex = 184
        Me.CheckBox6.Text = "Change process refresh interval (Seconds) ="
        Me.CheckBox6.UseVisualStyleBackColor = False
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.BackColor = System.Drawing.Color.Transparent
        Me.Label75.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.ForeColor = System.Drawing.Color.Red
        Me.Label75.Location = New System.Drawing.Point(390, 160)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(130, 15)
        Me.Label75.TabIndex = 155
        Me.Label75.Text = "Highly Recommended"
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox5.Enabled = False
        Me.CheckBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox5.Location = New System.Drawing.Point(249, 370)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(277, 20)
        Me.CheckBox5.TabIndex = 153
        Me.CheckBox5.Text = "Delete associated file(s) on USB insertion."
        Me.CheckBox5.UseVisualStyleBackColor = False
        Me.CheckBox5.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(409, 103)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 13)
        Me.Label20.TabIndex = 150
        Me.Label20.Text = "Recommended"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(409, 54)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(79, 13)
        Me.Label19.TabIndex = 149
        Me.Label19.Text = "Recommended"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(409, 32)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 13)
        Me.Label18.TabIndex = 148
        Me.Label18.Text = "Recommended"
        '
        'ScanTime
        '
        Me.ScanTime.AutoSize = True
        Me.ScanTime.BackColor = System.Drawing.Color.Transparent
        Me.ScanTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScanTime.Location = New System.Drawing.Point(17, 129)
        Me.ScanTime.Name = "ScanTime"
        Me.ScanTime.Size = New System.Drawing.Size(293, 20)
        Me.ScanTime.TabIndex = 146
        Me.ScanTime.Text = "V.E.R. Background scan interval (Seconds) ="
        Me.ScanTime.UseVisualStyleBackColor = False
        '
        'AutomaticDeleteAutorun
        '
        Me.AutomaticDeleteAutorun.AutoSize = True
        Me.AutomaticDeleteAutorun.BackColor = System.Drawing.Color.Transparent
        Me.AutomaticDeleteAutorun.Enabled = False
        Me.AutomaticDeleteAutorun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutomaticDeleteAutorun.Location = New System.Drawing.Point(101, 332)
        Me.AutomaticDeleteAutorun.Name = "AutomaticDeleteAutorun"
        Me.AutomaticDeleteAutorun.Size = New System.Drawing.Size(509, 20)
        Me.AutomaticDeleteAutorun.TabIndex = 141
        Me.AutomaticDeleteAutorun.Text = "Allow automatic Deletion of Autorun.inf and any associated file(s) on USB inserti" & _
    "on"
        Me.AutomaticDeleteAutorun.UseVisualStyleBackColor = False
        Me.AutomaticDeleteAutorun.Visible = False
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(393, 181)
        Me.TrackBar1.Maximum = 5
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(157, 45)
        Me.TrackBar1.TabIndex = 156
        Me.TrackBar1.Value = 1
        Me.TrackBar1.Visible = False
        '
        'TrackBar2
        '
        Me.TrackBar2.Location = New System.Drawing.Point(393, 119)
        Me.TrackBar2.Maximum = 5
        Me.TrackBar2.Minimum = 1
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(157, 45)
        Me.TrackBar2.TabIndex = 186
        Me.TrackBar2.Value = 2
        Me.TrackBar2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(25, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 165
        Me.Label3.Text = "System Status:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Virus_Effect_Remover.My.Resources.Resources._001_30
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(50, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(43, 23)
        Me.PictureBox1.TabIndex = 164
        Me.PictureBox1.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 469)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(790, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 163
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ProTreeTimer
        '
        Me.ProTreeTimer.Interval = 2000
        Me.ProTreeTimer.Tag = "Used to refresh process tree."
        '
        'Form1Panel
        '
        Me.Form1Panel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Form1Panel.BackgroundImage = Global.Virus_Effect_Remover.My.Resources.Resources.tick_16
        Me.Form1Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Form1Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Form1Panel.Controls.Add(Me.Label10)
        Me.Form1Panel.Controls.Add(Me.StatusStrip1)
        Me.Form1Panel.Controls.Add(Me.Label6)
        Me.Form1Panel.Controls.Add(Me.Panel5)
        Me.Form1Panel.Controls.Add(Me.MainTabControl)
        Me.Form1Panel.Controls.Add(Me.Panel7)
        Me.Form1Panel.Controls.Add(Me.MenuStrip1)
        Me.Form1Panel.Controls.Add(Me.Panel6)
        Me.Form1Panel.Controls.Add(Me.Label3)
        Me.Form1Panel.Controls.Add(Me.PictureBox1)
        Me.Form1Panel.Controls.Add(Me.TableLayoutPanel1)
        Me.Form1Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.Form1Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Form1Panel.Location = New System.Drawing.Point(4, 34)
        Me.Form1Panel.Name = "Form1Panel"
        Me.Form1Panel.Size = New System.Drawing.Size(792, 497)
        Me.Form1Panel.TabIndex = 189
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 186
        Me.Label6.Text = "- Instant Tools -"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImage = Global.Virus_Effect_Remover.My.Resources.Resources.tick_16
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 491)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(790, 4)
        Me.Panel5.TabIndex = 191
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.BackgroundImage = Global.Virus_Effect_Remover.My.Resources.Resources.tick_16
        Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 28)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(790, 4)
        Me.Panel7.TabIndex = 193
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 4)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(790, 24)
        Me.MenuStrip1.TabIndex = 190
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.BackgroundImage = Global.Virus_Effect_Remover.My.Resources.Resources.tick_16
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(790, 4)
        Me.Panel6.TabIndex = 192
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.BlockAVirusbutton, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.RunNewProcessButton, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ScanServiceButton, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ScanStartupButton, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GenerateprocessListButton, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.FindCloneButton, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.FolderInfoButton, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.MediaInfoButton, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.OptionButton, 0, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.FolderOptionsButton, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.SecurityPermissionsButton, 0, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.UnlockModuleButton, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 5)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 114)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 15
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(143, 371)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 13)
        Me.Label8.TabIndex = 186
        Me.Label8.Text = "     - Special Tools -"
        '
        'BlockAVirusbutton
        '
        Me.BlockAVirusbutton.BackColor = System.Drawing.Color.Transparent
        Me.BlockAVirusbutton.ButtonText = "Block A Virus"
        Me.BlockAVirusbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BlockAVirusbutton.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.BlockAVirusbutton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlockAVirusbutton.FontsStyle = System.Drawing.FontStyle.Bold
        Me.BlockAVirusbutton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.BlockAVirusbutton.Icon = Nothing
        Me.BlockAVirusbutton.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.BlockAVirusbutton.IconSpacingX = 5
        Me.BlockAVirusbutton.IconSpacingY = 5
        Me.BlockAVirusbutton.IconTransparency = 0.0!
        Me.BlockAVirusbutton.Location = New System.Drawing.Point(3, 249)
        Me.BlockAVirusbutton.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.BlockAVirusbutton.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.BlockAVirusbutton.Name = "BlockAVirusbutton"
        Me.BlockAVirusbutton.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.BlockAVirusbutton.Size = New System.Drawing.Size(137, 20)
        Me.BlockAVirusbutton.TabIndex = 9
        Me.BlockAVirusbutton.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.BlockAVirusbutton.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.BlockAVirusbutton.TextSpacingX = 5
        Me.BlockAVirusbutton.TextSpacingY = 5
        '
        'RunNewProcessButton
        '
        Me.RunNewProcessButton.BackColor = System.Drawing.Color.Transparent
        Me.RunNewProcessButton.ButtonText = "Run New Process"
        Me.RunNewProcessButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RunNewProcessButton.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.RunNewProcessButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RunNewProcessButton.FontsStyle = System.Drawing.FontStyle.Bold
        Me.RunNewProcessButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.RunNewProcessButton.Icon = Nothing
        Me.RunNewProcessButton.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.RunNewProcessButton.IconSpacingX = 5
        Me.RunNewProcessButton.IconSpacingY = 5
        Me.RunNewProcessButton.IconTransparency = 0.0!
        Me.RunNewProcessButton.Location = New System.Drawing.Point(3, 55)
        Me.RunNewProcessButton.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.RunNewProcessButton.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.RunNewProcessButton.Name = "RunNewProcessButton"
        Me.RunNewProcessButton.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.RunNewProcessButton.Size = New System.Drawing.Size(137, 20)
        Me.RunNewProcessButton.TabIndex = 3
        Me.RunNewProcessButton.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.RunNewProcessButton.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.RunNewProcessButton.TextSpacingX = 5
        Me.RunNewProcessButton.TextSpacingY = 5
        '
        'ScanServiceButton
        '
        Me.ScanServiceButton.BackColor = System.Drawing.Color.Transparent
        Me.ScanServiceButton.ButtonText = "Scan Services"
        Me.ScanServiceButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ScanServiceButton.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.ScanServiceButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScanServiceButton.FontsStyle = System.Drawing.FontStyle.Bold
        Me.ScanServiceButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.ScanServiceButton.Icon = Nothing
        Me.ScanServiceButton.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.ScanServiceButton.IconSpacingX = 5
        Me.ScanServiceButton.IconSpacingY = 5
        Me.ScanServiceButton.IconTransparency = 0.0!
        Me.ScanServiceButton.Location = New System.Drawing.Point(3, 3)
        Me.ScanServiceButton.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.ScanServiceButton.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.ScanServiceButton.Name = "ScanServiceButton"
        Me.ScanServiceButton.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.ScanServiceButton.Size = New System.Drawing.Size(137, 20)
        Me.ScanServiceButton.TabIndex = 1
        Me.ScanServiceButton.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.ScanServiceButton.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.ScanServiceButton.TextSpacingX = 5
        Me.ScanServiceButton.TextSpacingY = 5
        '
        'ScanStartupButton
        '
        Me.ScanStartupButton.BackColor = System.Drawing.Color.Transparent
        Me.ScanStartupButton.ButtonText = "Scan Startup"
        Me.ScanStartupButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ScanStartupButton.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.ScanStartupButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScanStartupButton.FontsStyle = System.Drawing.FontStyle.Bold
        Me.ScanStartupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.ScanStartupButton.Icon = Nothing
        Me.ScanStartupButton.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.ScanStartupButton.IconSpacingX = 5
        Me.ScanStartupButton.IconSpacingY = 5
        Me.ScanStartupButton.IconTransparency = 0.0!
        Me.ScanStartupButton.Location = New System.Drawing.Point(3, 29)
        Me.ScanStartupButton.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.ScanStartupButton.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.ScanStartupButton.Name = "ScanStartupButton"
        Me.ScanStartupButton.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.ScanStartupButton.Size = New System.Drawing.Size(137, 20)
        Me.ScanStartupButton.TabIndex = 2
        Me.ScanStartupButton.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.ScanStartupButton.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.ScanStartupButton.TextSpacingX = 5
        Me.ScanStartupButton.TextSpacingY = 5
        '
        'GenerateprocessListButton
        '
        Me.GenerateprocessListButton.BackColor = System.Drawing.Color.Transparent
        Me.GenerateprocessListButton.ButtonText = "Generate Process List"
        Me.GenerateprocessListButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GenerateprocessListButton.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.GenerateprocessListButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GenerateprocessListButton.FontsStyle = System.Drawing.FontStyle.Bold
        Me.GenerateprocessListButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.GenerateprocessListButton.Icon = Nothing
        Me.GenerateprocessListButton.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.GenerateprocessListButton.IconSpacingX = 5
        Me.GenerateprocessListButton.IconSpacingY = 5
        Me.GenerateprocessListButton.IconTransparency = 0.0!
        Me.GenerateprocessListButton.Location = New System.Drawing.Point(3, 81)
        Me.GenerateprocessListButton.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.GenerateprocessListButton.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.GenerateprocessListButton.Name = "GenerateprocessListButton"
        Me.GenerateprocessListButton.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.GenerateprocessListButton.Size = New System.Drawing.Size(137, 20)
        Me.GenerateprocessListButton.TabIndex = 4
        Me.GenerateprocessListButton.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.GenerateprocessListButton.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.GenerateprocessListButton.TextSpacingX = 5
        Me.GenerateprocessListButton.TextSpacingY = 5
        '
        'FindCloneButton
        '
        Me.FindCloneButton.BackColor = System.Drawing.Color.Transparent
        Me.FindCloneButton.ButtonText = "Find Clone File(s)"
        Me.FindCloneButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FindCloneButton.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.FindCloneButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FindCloneButton.FontsStyle = System.Drawing.FontStyle.Bold
        Me.FindCloneButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.FindCloneButton.Icon = Nothing
        Me.FindCloneButton.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.FindCloneButton.IconSpacingX = 5
        Me.FindCloneButton.IconSpacingY = 5
        Me.FindCloneButton.IconTransparency = 0.0!
        Me.FindCloneButton.Location = New System.Drawing.Point(3, 107)
        Me.FindCloneButton.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.FindCloneButton.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.FindCloneButton.Name = "FindCloneButton"
        Me.FindCloneButton.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.FindCloneButton.Size = New System.Drawing.Size(137, 20)
        Me.FindCloneButton.TabIndex = 5
        Me.FindCloneButton.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.FindCloneButton.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.FindCloneButton.TextSpacingX = 5
        Me.FindCloneButton.TextSpacingY = 5
        '
        'FolderInfoButton
        '
        Me.FolderInfoButton.BackColor = System.Drawing.Color.Transparent
        Me.FolderInfoButton.ButtonText = "Get Folder Info"
        Me.FolderInfoButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FolderInfoButton.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.FolderInfoButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FolderInfoButton.FontsStyle = System.Drawing.FontStyle.Bold
        Me.FolderInfoButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.FolderInfoButton.Icon = Nothing
        Me.FolderInfoButton.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.FolderInfoButton.IconSpacingX = 5
        Me.FolderInfoButton.IconSpacingY = 5
        Me.FolderInfoButton.IconTransparency = 0.0!
        Me.FolderInfoButton.Location = New System.Drawing.Point(3, 152)
        Me.FolderInfoButton.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.FolderInfoButton.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.FolderInfoButton.Name = "FolderInfoButton"
        Me.FolderInfoButton.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.FolderInfoButton.Size = New System.Drawing.Size(137, 20)
        Me.FolderInfoButton.TabIndex = 6
        Me.FolderInfoButton.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.FolderInfoButton.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.FolderInfoButton.TextSpacingX = 5
        Me.FolderInfoButton.TextSpacingY = 5
        '
        'MediaInfoButton
        '
        Me.MediaInfoButton.BackColor = System.Drawing.Color.Transparent
        Me.MediaInfoButton.ButtonText = "Get Media Info"
        Me.MediaInfoButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MediaInfoButton.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.MediaInfoButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MediaInfoButton.FontsStyle = System.Drawing.FontStyle.Bold
        Me.MediaInfoButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.MediaInfoButton.Icon = Nothing
        Me.MediaInfoButton.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.MediaInfoButton.IconSpacingX = 5
        Me.MediaInfoButton.IconSpacingY = 5
        Me.MediaInfoButton.IconTransparency = 0.0!
        Me.MediaInfoButton.Location = New System.Drawing.Point(3, 178)
        Me.MediaInfoButton.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.MediaInfoButton.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.MediaInfoButton.Name = "MediaInfoButton"
        Me.MediaInfoButton.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.MediaInfoButton.Size = New System.Drawing.Size(137, 20)
        Me.MediaInfoButton.TabIndex = 7
        Me.MediaInfoButton.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.MediaInfoButton.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.MediaInfoButton.TextSpacingX = 5
        Me.MediaInfoButton.TextSpacingY = 5
        '
        'OptionButton
        '
        Me.OptionButton.BackColor = System.Drawing.Color.Transparent
        Me.OptionButton.ButtonText = "V.E.R. Options"
        Me.OptionButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OptionButton.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.OptionButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OptionButton.FontsStyle = System.Drawing.FontStyle.Bold
        Me.OptionButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.OptionButton.Icon = Nothing
        Me.OptionButton.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.OptionButton.IconSpacingX = 5
        Me.OptionButton.IconSpacingY = 5
        Me.OptionButton.IconTransparency = 0.0!
        Me.OptionButton.Location = New System.Drawing.Point(3, 327)
        Me.OptionButton.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.OptionButton.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.OptionButton.Name = "OptionButton"
        Me.OptionButton.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.OptionButton.Size = New System.Drawing.Size(137, 20)
        Me.OptionButton.TabIndex = 12
        Me.OptionButton.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.OptionButton.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.OptionButton.TextSpacingX = 5
        Me.OptionButton.TextSpacingY = 5
        '
        'FolderOptionsButton
        '
        Me.FolderOptionsButton.BackColor = System.Drawing.Color.Transparent
        Me.FolderOptionsButton.ButtonText = "Folder Options"
        Me.FolderOptionsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FolderOptionsButton.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.FolderOptionsButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FolderOptionsButton.FontsStyle = System.Drawing.FontStyle.Bold
        Me.FolderOptionsButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.FolderOptionsButton.Icon = Nothing
        Me.FolderOptionsButton.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.FolderOptionsButton.IconSpacingX = 5
        Me.FolderOptionsButton.IconSpacingY = 5
        Me.FolderOptionsButton.IconTransparency = 0.0!
        Me.FolderOptionsButton.Location = New System.Drawing.Point(3, 223)
        Me.FolderOptionsButton.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.FolderOptionsButton.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.FolderOptionsButton.Name = "FolderOptionsButton"
        Me.FolderOptionsButton.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.FolderOptionsButton.Size = New System.Drawing.Size(137, 20)
        Me.FolderOptionsButton.TabIndex = 8
        Me.FolderOptionsButton.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.FolderOptionsButton.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.FolderOptionsButton.TextSpacingX = 5
        Me.FolderOptionsButton.TextSpacingY = 5
        '
        'SecurityPermissionsButton
        '
        Me.SecurityPermissionsButton.BackColor = System.Drawing.Color.Transparent
        Me.SecurityPermissionsButton.ButtonText = "Security Permissions*"
        Me.SecurityPermissionsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SecurityPermissionsButton.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.SecurityPermissionsButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SecurityPermissionsButton.FontsStyle = System.Drawing.FontStyle.Bold
        Me.SecurityPermissionsButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.SecurityPermissionsButton.Icon = Nothing
        Me.SecurityPermissionsButton.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.SecurityPermissionsButton.IconSpacingX = 5
        Me.SecurityPermissionsButton.IconSpacingY = 5
        Me.SecurityPermissionsButton.IconTransparency = 0.0!
        Me.SecurityPermissionsButton.Location = New System.Drawing.Point(3, 301)
        Me.SecurityPermissionsButton.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.SecurityPermissionsButton.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.SecurityPermissionsButton.Name = "SecurityPermissionsButton"
        Me.SecurityPermissionsButton.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.SecurityPermissionsButton.Size = New System.Drawing.Size(137, 20)
        Me.SecurityPermissionsButton.TabIndex = 11
        Me.SecurityPermissionsButton.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.SecurityPermissionsButton.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.SecurityPermissionsButton.TextSpacingX = 5
        Me.SecurityPermissionsButton.TextSpacingY = 5
        '
        'UnlockModuleButton
        '
        Me.UnlockModuleButton.BackColor = System.Drawing.Color.Transparent
        Me.UnlockModuleButton.ButtonText = "Unlock Module"
        Me.UnlockModuleButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UnlockModuleButton.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.UnlockModuleButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UnlockModuleButton.FontsStyle = System.Drawing.FontStyle.Bold
        Me.UnlockModuleButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.UnlockModuleButton.Icon = Nothing
        Me.UnlockModuleButton.IconAlign = Virus_Effect_Remover.C_Button.CButton.IconBitmapAlign.Left
        Me.UnlockModuleButton.IconSpacingX = 5
        Me.UnlockModuleButton.IconSpacingY = 5
        Me.UnlockModuleButton.IconTransparency = 0.0!
        Me.UnlockModuleButton.Location = New System.Drawing.Point(3, 275)
        Me.UnlockModuleButton.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.UnlockModuleButton.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.UnlockModuleButton.Name = "UnlockModuleButton"
        Me.UnlockModuleButton.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.UnlockModuleButton.Size = New System.Drawing.Size(137, 20)
        Me.UnlockModuleButton.TabIndex = 10
        Me.UnlockModuleButton.TextAlign = Virus_Effect_Remover.C_Button.CButton.ButtonTextAlign.Center
        Me.UnlockModuleButton.TextImageRelation = Virus_Effect_Remover.C_Button.CButton.ButtonTextImageRelation.TextAboveImage
        Me.UnlockModuleButton.TextSpacingX = 5
        Me.UnlockModuleButton.TextSpacingY = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 13)
        Me.Label7.TabIndex = 186
        Me.Label7.Text = "     - Details Tools -"
        '
        'BorderPanel4
        '
        Me.BorderPanel4.BackColor = System.Drawing.Color.Transparent
        Me.BorderPanel4.BackgroundImage = Global.Virus_Effect_Remover.My.Resources.Resources.tick_16
        Me.BorderPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BorderPanel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BorderPanel4.Location = New System.Drawing.Point(4, 531)
        Me.BorderPanel4.Name = "BorderPanel4"
        Me.BorderPanel4.Size = New System.Drawing.Size(792, 4)
        Me.BorderPanel4.TabIndex = 189
        '
        'BorderPanel5
        '
        Me.BorderPanel5.BackColor = System.Drawing.Color.Transparent
        Me.BorderPanel5.BackgroundImage = Global.Virus_Effect_Remover.My.Resources.Resources.tick_16
        Me.BorderPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BorderPanel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.BorderPanel5.Location = New System.Drawing.Point(0, 4)
        Me.BorderPanel5.Name = "BorderPanel5"
        Me.BorderPanel5.Size = New System.Drawing.Size(4, 531)
        Me.BorderPanel5.TabIndex = 190
        '
        'TitleBarPanel
        '
        Me.TitleBarPanel.BackColor = System.Drawing.Color.Transparent
        Me.TitleBarPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TitleBarPanel.Controls.Add(Me.TitleName)
        Me.TitleBarPanel.Controls.Add(Me.Button2)
        Me.TitleBarPanel.Controls.Add(Me.MinimizeButton)
        Me.TitleBarPanel.Controls.Add(Me.HideButton)
        Me.TitleBarPanel.Controls.Add(Me.MaximizeButton)
        Me.TitleBarPanel.Controls.Add(Me.EndButton)
        Me.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBarPanel.ForeColor = System.Drawing.Color.Red
        Me.TitleBarPanel.Location = New System.Drawing.Point(4, 4)
        Me.TitleBarPanel.Name = "TitleBarPanel"
        Me.TitleBarPanel.Size = New System.Drawing.Size(792, 30)
        Me.TitleBarPanel.TabIndex = 0
        '
        'TitleName
        '
        Me.TitleName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TitleName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TitleName.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.TitleName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleName.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TitleName.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.TitleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TitleName.Location = New System.Drawing.Point(28, 0)
        Me.TitleName.Name = "TitleName"
        Me.TitleName.Size = New System.Drawing.Size(652, 30)
        Me.TitleName.TabIndex = 194
        Me.TitleName.TabStop = False
        Me.TitleName.Text = "    Virus Effect Remover"
        Me.TitleName.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Virus_Effect_Remover.My.Resources.Resources._32
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 30)
        Me.Button2.TabIndex = 195
        Me.Button2.TabStop = False
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BorderPanel1
        '
        Me.BorderPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BorderPanel1.BackgroundImage = Global.Virus_Effect_Remover.My.Resources.Resources.tick_16
        Me.BorderPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BorderPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BorderPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BorderPanel1.Name = "BorderPanel1"
        Me.BorderPanel1.Size = New System.Drawing.Size(800, 4)
        Me.BorderPanel1.TabIndex = 193
        '
        'BorderPanel2
        '
        Me.BorderPanel2.BackColor = System.Drawing.Color.Transparent
        Me.BorderPanel2.BackgroundImage = Global.Virus_Effect_Remover.My.Resources.Resources.tick_16
        Me.BorderPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BorderPanel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.BorderPanel2.Location = New System.Drawing.Point(796, 4)
        Me.BorderPanel2.Name = "BorderPanel2"
        Me.BorderPanel2.Size = New System.Drawing.Size(4, 531)
        Me.BorderPanel2.TabIndex = 192
        '
        'EnglishToolTip
        '
        Me.EnglishToolTip.AutomaticDelay = 5000
        Me.EnglishToolTip.AutoPopDelay = 9000
        Me.EnglishToolTip.InitialDelay = 2000
        Me.EnglishToolTip.IsBalloon = True
        Me.EnglishToolTip.ReshowDelay = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 535)
        Me.ControlBox = False
        Me.Controls.Add(Me.Form1Panel)
        Me.Controls.Add(Me.BorderPanel4)
        Me.Controls.Add(Me.TitleBarPanel)
        Me.Controls.Add(Me.BorderPanel5)
        Me.Controls.Add(Me.BorderPanel2)
        Me.Controls.Add(Me.BorderPanel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Virus Effect Remover"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ModuleListStrip.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.FileFoundLVContextMenu.ResumeLayout(False)
        Me.ProListContextMenu.ResumeLayout(False)
        Me.MainTabControl.ResumeLayout(False)
        Me.MainPage.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ListView1Strip.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.AutorunPanelPage.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ProcessDetailPage.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ListView2Strip.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Tp0.ResumeLayout(False)
        Me.TP1.ResumeLayout(False)
        Me.TP1.PerformLayout()
        Me.TP3.ResumeLayout(False)
        Me.FolderOptionPage.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.FileFolderTab.ResumeLayout(False)
        Me.FolderOptionsSubPage.ResumeLayout(False)
        Me.UtilityBox.ResumeLayout(False)
        Me.UtilityBox.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.RemovalMediaDetailPage.ResumeLayout(False)
        Me.RemovalMediaDetailPage.PerformLayout()
        Me.TabControl5.ResumeLayout(False)
        Me.RemMDetail.ResumeLayout(False)
        Me.ChangeRemDetail.ResumeLayout(False)
        Me.ChangeRemDetail.PerformLayout()
        Me.DirectoryDetailPage.ResumeLayout(False)
        Me.DirectoryDetailPage.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.DelFilePage.ResumeLayout(False)
        Me.UDTabControl1.ResumeLayout(False)
        Me.UDTabPage1.ResumeLayout(False)
        Me.UDTabPage1.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.UDTabPage2.ResumeLayout(False)
        Me.UDTabPage2.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.UDTabPage3.ResumeLayout(False)
        Me.SecurityPermissionPage.ResumeLayout(False)
        Me.SecurityPermissionPage.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.NTFSTabControl.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage13.ResumeLayout(False)
        Me.TabPage13.PerformLayout()
        Me.TabPage12.ResumeLayout(False)
        Me.TabPage12.PerformLayout()
        Me.UnlockerPage.ResumeLayout(False)
        Me.UnlockerPage.PerformLayout()
        Me.ProcessModuleListStrip.ResumeLayout(False)
        Me.OtherToolPage.ResumeLayout(False)
        Me.SettingPage.ResumeLayout(False)
        Me.SettingPage.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Form1Panel.ResumeLayout(False)
        Me.Form1Panel.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TitleBarPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunRemoverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefressStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MakeRegisrtyBackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestoreBackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TaskManagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisrtyEditerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MSCONFIGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupPolicyEditerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlternateExplorerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsExplorerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GenerateRunningProcessListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepairToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DrWatsonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemFileCheckerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents infobox As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Help_box As System.Windows.Forms.CheckBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ScanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIconTimer As System.Windows.Forms.Timer
    Friend WithEvents HideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfBox As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Filenamebox As System.Windows.Forms.TextBox
    Friend WithEvents scanagain As System.Windows.Forms.Button
    Friend WithEvents onehit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OtherToolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileFoundLV As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ProList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents AutorunBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents MainTabControl As System.Windows.Forms.TabControl
    Friend WithEvents MainPage As System.Windows.Forms.TabPage
    Friend WithEvents ProcessDetailPage As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Proc_Count As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents KillThis As System.Windows.Forms.Button
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents SettingPage As System.Windows.Forms.TabPage
    Friend WithEvents AddStartup As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AutomaticDeleteAutorun As System.Windows.Forms.CheckBox
    Friend WithEvents IGN_CDROM As System.Windows.Forms.CheckBox
    Friend WithEvents send2tray As System.Windows.Forms.CheckBox
    Friend WithEvents ScanTime As System.Windows.Forms.CheckBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents FolderOptionPage As System.Windows.Forms.TabPage
    Friend WithEvents FileExt As System.Windows.Forms.CheckBox
    Friend WithEvents SystemHided As System.Windows.Forms.CheckBox
    Friend WithEvents ShowHideFile As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents OtherToolPage As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents RunTask As System.Windows.Forms.Button
    Friend WithEvents BrowseTask As System.Windows.Forms.Button
    Friend WithEvents TaskTabBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents FileFolderTab As System.Windows.Forms.TabControl
    Friend WithEvents FolderOptionsSubPage As System.Windows.Forms.TabPage
    Friend WithEvents RemovalMediaDetailPage As System.Windows.Forms.TabPage
    Friend WithEvents RemovalMediaDriveList As System.Windows.Forms.ListView
    Friend WithEvents DriveName As System.Windows.Forms.ColumnHeader
    Friend WithEvents DriveVolume As System.Windows.Forms.ColumnHeader
    Friend WithEvents DriveFormat As System.Windows.Forms.ColumnHeader
    Friend WithEvents DriveTotalSize As System.Windows.Forms.ColumnHeader
    Friend WithEvents DriveUsedSpace As System.Windows.Forms.ColumnHeader
    Friend WithEvents DriveFreeSpace As System.Windows.Forms.ColumnHeader
    Friend WithEvents DriveInfectionStaus As System.Windows.Forms.ColumnHeader
    Friend WithEvents DirectoryDetailPage As System.Windows.Forms.TabPage
    Friend WithEvents DirectoryFileListView As System.Windows.Forms.ListView
    Friend WithEvents FileNameSubPage As System.Windows.Forms.ColumnHeader
    Friend WithEvents FileSizeColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents FileExtention As System.Windows.Forms.ColumnHeader
    Friend WithEvents ShowAllHiddenFile As System.Windows.Forms.Button
    Friend WithEvents FullPathTab As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents FileAttributeArchive As System.Windows.Forms.CheckBox
    Friend WithEvents FileAtttributeHidden As System.Windows.Forms.CheckBox
    Friend WithEvents FileAttributeReadOnly As System.Windows.Forms.CheckBox
    Friend WithEvents FileAttributeSystem As System.Windows.Forms.CheckBox
    Friend WithEvents ShowAllFile As System.Windows.Forms.Button
    Friend WithEvents BrowseDir As System.Windows.Forms.Button
    Friend WithEvents DirectoryPath As System.Windows.Forms.TextBox
    Friend WithEvents IncludeSubFolder As System.Windows.Forms.CheckBox
    Friend WithEvents ShowAlllSytemFile As System.Windows.Forms.Button
    Friend WithEvents OnlySystemHidden As System.Windows.Forms.Button
    Friend WithEvents FileAttributeOffLine As System.Windows.Forms.CheckBox
    Friend WithEvents FileAttributeCompressed As System.Windows.Forms.CheckBox
    Friend WithEvents FileAttributeEncripted As System.Windows.Forms.CheckBox
    Friend WithEvents FileAttributeTemporary As System.Windows.Forms.CheckBox
    Friend WithEvents FileAttributeApply As System.Windows.Forms.Button
    Friend WithEvents RenameFileInList As System.Windows.Forms.Button
    Friend WithEvents DeleteFileInList As System.Windows.Forms.Button
    Friend WithEvents ReleaseDrive As System.Windows.Forms.Button
    Friend WithEvents RemoveSystemHidden As System.Windows.Forms.Button
    Friend WithEvents VisualiseAllFile As System.Windows.Forms.Button
    Friend WithEvents FormateDrive As System.Windows.Forms.Button
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents DelFilePage As System.Windows.Forms.TabPage
    Friend WithEvents StartTimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopTimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutorunPanelPage As System.Windows.Forms.TabPage
    Friend WithEvents ListView1Strip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents KillProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetRelatedModuleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListView2Strip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GetModuleDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetGenralDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Tp0 As System.Windows.Forms.TabPage
    Friend WithEvents TP1 As System.Windows.Forms.TabPage
    Friend WithEvents PathLable As System.Windows.Forms.TextBox
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents IdLable As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents NameLable As System.Windows.Forms.Label
    Friend WithEvents ModuleList As System.Windows.Forms.ListView
    Friend WithEvents ModuleName As System.Windows.Forms.ColumnHeader
    Friend WithEvents modulePathPan As System.Windows.Forms.ColumnHeader
    Friend WithEvents ModuleListStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GetAllProcessUsingThisModuleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenLocationOfModuleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcessModuleListStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents KillProcessToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KillProcessAndDeleteParentFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenLocationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TP3 As System.Windows.Forms.TabPage
    Friend WithEvents KillEventListBox As System.Windows.Forms.ListBox
    Friend WithEvents ClearKillEventList As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents KillProcessToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents ModuleBaseAddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents GetRelatedProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MOduleDescription As System.Windows.Forms.ColumnHeader
    Friend WithEvents EnableProcessFilter As System.Windows.Forms.CheckBox
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents ReleseCurrentModuleFromThisProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnlockerPage As System.Windows.Forms.TabPage
    Friend WithEvents GenDetail As System.Windows.Forms.CheckBox
    Friend WithEvents ProcessListOfModule As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ProcessModuleBaseAddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents Unlockerbrowse As System.Windows.Forms.Button
    Friend WithEvents ModuleAbsolutePathBox As System.Windows.Forms.TextBox
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents RestratProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuspendProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResumeProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuspendProcessToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResumeProcessToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GetGeneralDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AffinityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PriorityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IdleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NormalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BelowNormalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboveNormalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HighToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RealTimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReleaseSelectedModuleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReleaseModuleFromAllProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReleaseDeleteModuleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SecurityPermissionPage As System.Windows.Forms.TabPage
    Friend WithEvents LocationPathSecurity As System.Windows.Forms.TextBox
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents TabControl5 As System.Windows.Forms.TabControl
    Friend WithEvents RemMDetail As System.Windows.Forms.TabPage
    Friend WithEvents ChangeRemDetail As System.Windows.Forms.TabPage
    Friend WithEvents RemDetailTextbox As System.Windows.Forms.TextBox
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents UnlockerGo As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ProTree As System.Windows.Forms.TreeView
    Friend WithEvents ProTreeTimer As System.Windows.Forms.Timer
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReloadFullProcessTreeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Run_remover As C_Button.CButton
    Friend WithEvents OptionButton As C_Button.CButton
    Friend WithEvents SecurityPermissionsButton As C_Button.CButton
    Friend WithEvents UnlockModuleButton As C_Button.CButton
    Friend WithEvents MediaInfoButton As C_Button.CButton
    Friend WithEvents FolderInfoButton As C_Button.CButton
    Friend WithEvents FindCloneButton As C_Button.CButton
    Friend WithEvents GenerateprocessListButton As C_Button.CButton
    Friend WithEvents RunNewProcessButton As C_Button.CButton
    Friend WithEvents ScanStartupButton As C_Button.CButton
    Friend WithEvents ScanServiceButton As C_Button.CButton
    Friend WithEvents SFC As C_Button.CButton
    Friend WithEvents OpenLocationToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AffinityToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Enable_taskmgr As C_Button.CButton
    Friend WithEvents Enable_regedit As C_Button.CButton
    Friend WithEvents enable_msconfig As C_Button.CButton
    Friend WithEvents find_autorun As C_Button.CButton
    Friend WithEvents Enable_autorun As C_Button.CButton
    Friend WithEvents Sys_Hidden_Show As C_Button.CButton
    Friend WithEvents Protectdrive As C_Button.CButton
    Friend WithEvents RefreshButtonMain As C_Button.CButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ShowFolderOption As C_Button.CButton
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents OnlyKillProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KillProcessToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProTreeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TrackBar2 As System.Windows.Forms.TrackBar
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents RenameIEButton As C_Button.CButton
    Friend WithEvents Form1Panel As System.Windows.Forms.Panel
    Friend WithEvents MinimizeButton As System.Windows.Forms.Button
    Friend WithEvents TitleBarPanel As System.Windows.Forms.Panel
    Friend WithEvents HideButton As System.Windows.Forms.Button
    Friend WithEvents EndButton As System.Windows.Forms.Button
    Friend WithEvents BorderPanel4 As System.Windows.Forms.Panel
    Friend WithEvents BorderPanel5 As System.Windows.Forms.Panel
    Friend WithEvents BorderPanel1 As System.Windows.Forms.Panel
    Friend WithEvents BorderPanel2 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TitleName As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents BlogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator22 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FolderOptionsButton As Virus_Effect_Remover.C_Button.CButton
    Friend WithEvents CopyFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyFilePathToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyFileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyFilePathToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyFileToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyFilePathToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilityBox As System.Windows.Forms.GroupBox
    Friend WithEvents RegistryOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents USBStorageDeviceOption As Virus_Effect_Remover.C_Button.CButton
    Friend WithEvents CommandPromptButton As Virus_Effect_Remover.C_Button.CButton
    Friend WithEvents DXDiagButton As Virus_Effect_Remover.C_Button.CButton
    Friend WithEvents RetriveAccessRuleButton As Virus_Effect_Remover.C_Button.CButton
    Friend WithEvents AccessRuleListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents NTFSTabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents DirectoryRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents FileRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents FileFolderBr As Virus_Effect_Remover.C_Button.CButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents TabPage12 As System.Windows.Forms.TabPage
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents GetFullControlButton As Virus_Effect_Remover.C_Button.CButton
    Friend WithEvents CButton19 As Virus_Effect_Remover.C_Button.CButton
    Friend WithEvents CButton18 As Virus_Effect_Remover.C_Button.CButton
    Friend WithEvents CButton16 As Virus_Effect_Remover.C_Button.CButton
    Friend WithEvents CButton22 As Virus_Effect_Remover.C_Button.CButton
    Friend WithEvents CButton21 As Virus_Effect_Remover.C_Button.CButton
    Friend WithEvents CButton20 As Virus_Effect_Remover.C_Button.CButton
    Friend WithEvents RemoveFullControlButton As Virus_Effect_Remover.C_Button.CButton
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents AuditRuleListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage13 As System.Windows.Forms.TabPage
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents OwnerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents OwnerApplyButton As Virus_Effect_Remover.C_Button.CButton
    Friend WithEvents ProcessDetailList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents BlockAVirusbutton As Virus_Effect_Remover.C_Button.CButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ProListContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FileFoundLVContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ImLAutoRT As System.Windows.Forms.ImageList
    Friend WithEvents LocateFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyFileToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyPathToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetCompleteDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocateProcessInProcessListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KillProcessToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetModuleListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FixedImageList As System.Windows.Forms.ImageList
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents LocateThisProcessInProcessListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents CopyExecutablePathToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyExecutableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocateExecutableFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KillProcessAndDeleteProcessFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator18 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator19 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator21 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator20 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator23 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator24 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RemoveThisEntryFromListToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveThisEntryFromListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModuleListImage As System.Windows.Forms.ImageList
    Friend WithEvents WindowsManagementConsoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerformanceConsoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalUsersAndGroupsConsoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SharedFoldersManagementConsoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EventViewerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiskManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WMIControlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SecuritySettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComputerManagementConsoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeviceManagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiskDefragmenterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator25 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ServiceManagementConsoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetProcessFilePropertyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetProcessFilePropertyToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetProcessFilePropertyToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetModuleFilePropertyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetdrvProperty As System.Windows.Forms.Button
    Friend WithEvents DDFileDetail As System.Windows.Forms.Button
    Friend WithEvents GetProToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator26 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator27 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents MSInfoButton As Virus_Effect_Remover.C_Button.CButton
    Friend WithEvents ProcessCommandLine As Virus_Effect_Remover.C_Button.CButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents HideDriveButton As Virus_Effect_Remover.C_Button.CButton
    Friend WithEvents UDTabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents UDTabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents RemSFL As System.Windows.Forms.Button
    Friend WithEvents LocateFile As System.Windows.Forms.TextBox
    Friend WithEvents DelSF As System.Windows.Forms.Button
    Friend WithEvents DelList As System.Windows.Forms.ListView
    Friend WithEvents SerialDelList As System.Windows.Forms.ColumnHeader
    Friend WithEvents FileDelList As System.Windows.Forms.ColumnHeader
    Friend WithEvents SizeDelList As System.Windows.Forms.ColumnHeader
    Friend WithEvents AttributeDelList As System.Windows.Forms.ColumnHeader
    Friend WithEvents PathDelList As System.Windows.Forms.ColumnHeader
    Friend WithEvents ADDfile2 As System.Windows.Forms.Button
    Friend WithEvents DelACF As System.Windows.Forms.Button
    Friend WithEvents ClrList As System.Windows.Forms.Button
    Friend WithEvents SendToRecycleFile As System.Windows.Forms.CheckBox
    Friend WithEvents ForceToDeleteFile As System.Windows.Forms.CheckBox
    Friend WithEvents BT1 As System.Windows.Forms.Button
    Friend WithEvents UDTabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BR2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents DelEmptyDir2 As System.Windows.Forms.CheckBox
    Friend WithEvents IncSubDir2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ExtBox As System.Windows.Forms.TextBox
    Friend WithEvents DelFileWithExt As System.Windows.Forms.Button
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents REDir1 As System.Windows.Forms.CheckBox
    Friend WithEvents IncSd1 As System.Windows.Forms.CheckBox
    Friend WithEvents delAF As System.Windows.Forms.Button
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents RecycleBinBox As System.Windows.Forms.CheckBox
    Friend WithEvents FDel As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents FilesAllowedToDeleteBox As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DelAllEmptyDir As System.Windows.Forms.Button
    Friend WithEvents DirLocation As System.Windows.Forms.TextBox
    Friend WithEvents UDTabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents EventListview As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents WCleanButton As Virus_Effect_Remover.C_Button.CButton
    Friend WithEvents FileProtectorButton As Virus_Effect_Remover.C_Button.CButton
    Friend WithEvents MaximizeButton As System.Windows.Forms.Button
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents GreenTheme As System.Windows.Forms.RadioButton
    Friend WithEvents BlueTheme As System.Windows.Forms.RadioButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents EnglishToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents GetRemovalMedia As System.Windows.Forms.Button
    Friend WithEvents RedTheme As System.Windows.Forms.RadioButton
    Friend WithEvents DisableExitDialog As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExpandToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel


End Class
