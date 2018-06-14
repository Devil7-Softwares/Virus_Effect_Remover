<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartupForm
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartupForm))
        Dim ListViewGroup4 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup5 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup6 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.StartupStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveSelectedEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveEntryOnlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveEntryAndAssociatedFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator20 = New System.Windows.Forms.ToolStripSeparator
        Me.OpenLocationOfSelectedEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewRegistryInRegistryEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator23 = New System.Windows.Forms.ToolStripSeparator
        Me.CopyFileToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyFilePathToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.AddNewStartupEntryToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ScanStartupEntryToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.OpenCommonStartupFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenUsersStartupFolderToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton
        Me.ExplorerAssociatedFileDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UserinitAssociatedFileDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton
        Me.SendToRecycleBinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ForcedDeletionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StartupListView = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.StartupStrip.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 423)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(725, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StartupStrip
        '
        Me.StartupStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveSelectedEntryToolStripMenuItem, Me.ToolStripSeparator20, Me.OpenLocationOfSelectedEntryToolStripMenuItem, Me.ViewRegistryInRegistryEditorToolStripMenuItem, Me.ToolStripSeparator23, Me.CopyFileToolStripMenuItem3, Me.CopyFilePathToolStripMenuItem3})
        Me.StartupStrip.Name = "StartupStrip"
        Me.StartupStrip.Size = New System.Drawing.Size(241, 126)
        '
        'RemoveSelectedEntryToolStripMenuItem
        '
        Me.RemoveSelectedEntryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveEntryOnlyToolStripMenuItem, Me.RemoveEntryAndAssociatedFileToolStripMenuItem})
        Me.RemoveSelectedEntryToolStripMenuItem.Image = CType(resources.GetObject("RemoveSelectedEntryToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RemoveSelectedEntryToolStripMenuItem.Name = "RemoveSelectedEntryToolStripMenuItem"
        Me.RemoveSelectedEntryToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.RemoveSelectedEntryToolStripMenuItem.Text = "Remove Selected Entry"
        '
        'RemoveEntryOnlyToolStripMenuItem
        '
        Me.RemoveEntryOnlyToolStripMenuItem.Image = CType(resources.GetObject("RemoveEntryOnlyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RemoveEntryOnlyToolStripMenuItem.Name = "RemoveEntryOnlyToolStripMenuItem"
        Me.RemoveEntryOnlyToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.RemoveEntryOnlyToolStripMenuItem.Text = "Remove Entry Only"
        '
        'RemoveEntryAndAssociatedFileToolStripMenuItem
        '
        Me.RemoveEntryAndAssociatedFileToolStripMenuItem.Image = CType(resources.GetObject("RemoveEntryAndAssociatedFileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RemoveEntryAndAssociatedFileToolStripMenuItem.Name = "RemoveEntryAndAssociatedFileToolStripMenuItem"
        Me.RemoveEntryAndAssociatedFileToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.RemoveEntryAndAssociatedFileToolStripMenuItem.Text = "Remove Entry and Associated File"
        Me.RemoveEntryAndAssociatedFileToolStripMenuItem.ToolTipText = "If Path detected then file will be deleted. Otherwise you have to delete file man" & _
            "ualy."
        '
        'ToolStripSeparator20
        '
        Me.ToolStripSeparator20.Name = "ToolStripSeparator20"
        Me.ToolStripSeparator20.Size = New System.Drawing.Size(237, 6)
        '
        'OpenLocationOfSelectedEntryToolStripMenuItem
        '
        Me.OpenLocationOfSelectedEntryToolStripMenuItem.Image = CType(resources.GetObject("OpenLocationOfSelectedEntryToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenLocationOfSelectedEntryToolStripMenuItem.Name = "OpenLocationOfSelectedEntryToolStripMenuItem"
        Me.OpenLocationOfSelectedEntryToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.OpenLocationOfSelectedEntryToolStripMenuItem.Text = "Open Location of Selected Entry"
        '
        'ViewRegistryInRegistryEditorToolStripMenuItem
        '
        Me.ViewRegistryInRegistryEditorToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.System_Registry_48x48
        Me.ViewRegistryInRegistryEditorToolStripMenuItem.Name = "ViewRegistryInRegistryEditorToolStripMenuItem"
        Me.ViewRegistryInRegistryEditorToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ViewRegistryInRegistryEditorToolStripMenuItem.Text = "View Registry in Registry Editor"
        '
        'ToolStripSeparator23
        '
        Me.ToolStripSeparator23.Name = "ToolStripSeparator23"
        Me.ToolStripSeparator23.Size = New System.Drawing.Size(237, 6)
        '
        'CopyFileToolStripMenuItem3
        '
        Me.CopyFileToolStripMenuItem3.Image = Global.Virus_Effect_Remover.My.Resources.Resources.page
        Me.CopyFileToolStripMenuItem3.Name = "CopyFileToolStripMenuItem3"
        Me.CopyFileToolStripMenuItem3.Size = New System.Drawing.Size(240, 22)
        Me.CopyFileToolStripMenuItem3.Text = "Copy File"
        '
        'CopyFilePathToolStripMenuItem3
        '
        Me.CopyFilePathToolStripMenuItem3.Image = Global.Virus_Effect_Remover.My.Resources.Resources.page_copy
        Me.CopyFilePathToolStripMenuItem3.Name = "CopyFilePathToolStripMenuItem3"
        Me.CopyFilePathToolStripMenuItem3.Size = New System.Drawing.Size(240, 22)
        Me.CopyFilePathToolStripMenuItem3.Text = "Copy File Path"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(18, 18)
        Me.ImageList1.Tag = "Used in startup list"
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator4, Me.AddNewStartupEntryToolStripButton, Me.ScanStartupEntryToolStripButton, Me.ToolStripSeparator1, Me.ToolStripDropDownButton1, Me.ToolStripSeparator2, Me.ToolStripDropDownButton2, Me.ToolStripSeparator3, Me.ToolStripDropDownButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(725, 44)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 44)
        '
        'AddNewStartupEntryToolStripButton
        '
        Me.AddNewStartupEntryToolStripButton.Image = Global.Virus_Effect_Remover.My.Resources.Resources.add1_48
        Me.AddNewStartupEntryToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddNewStartupEntryToolStripButton.Name = "AddNewStartupEntryToolStripButton"
        Me.AddNewStartupEntryToolStripButton.Size = New System.Drawing.Size(87, 41)
        Me.AddNewStartupEntryToolStripButton.Text = " Add To Startup"
        Me.AddNewStartupEntryToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ScanStartupEntryToolStripButton
        '
        Me.ScanStartupEntryToolStripButton.Image = Global.Virus_Effect_Remover.My.Resources.Resources.refresh32
        Me.ScanStartupEntryToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ScanStartupEntryToolStripButton.Name = "ScanStartupEntryToolStripButton"
        Me.ScanStartupEntryToolStripButton.Size = New System.Drawing.Size(107, 41)
        Me.ScanStartupEntryToolStripButton.Text = "Refresh Startup List"
        Me.ScanStartupEntryToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 44)
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenCommonStartupFolderToolStripMenuItem, Me.OpenUsersStartupFolderToolStripMenuItem1})
        Me.ToolStripDropDownButton1.Image = Global.Virus_Effect_Remover.My.Resources.Resources.folder_32
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(89, 41)
        Me.ToolStripDropDownButton1.Text = "Open Location"
        Me.ToolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'OpenCommonStartupFolderToolStripMenuItem
        '
        Me.OpenCommonStartupFolderToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.group
        Me.OpenCommonStartupFolderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.OpenCommonStartupFolderToolStripMenuItem.Name = "OpenCommonStartupFolderToolStripMenuItem"
        Me.OpenCommonStartupFolderToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.OpenCommonStartupFolderToolStripMenuItem.Text = "Open Common Startup Folder"
        '
        'OpenUsersStartupFolderToolStripMenuItem1
        '
        Me.OpenUsersStartupFolderToolStripMenuItem1.Image = Global.Virus_Effect_Remover.My.Resources.Resources.user
        Me.OpenUsersStartupFolderToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.OpenUsersStartupFolderToolStripMenuItem1.Name = "OpenUsersStartupFolderToolStripMenuItem1"
        Me.OpenUsersStartupFolderToolStripMenuItem1.Size = New System.Drawing.Size(227, 22)
        Me.OpenUsersStartupFolderToolStripMenuItem1.Text = "Open User's Startup Folder"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 44)
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExplorerAssociatedFileDetailToolStripMenuItem, Me.UserinitAssociatedFileDetailToolStripMenuItem})
        Me.ToolStripDropDownButton2.Image = Global.Virus_Effect_Remover.My.Resources.Resources.info_32
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(97, 41)
        Me.ToolStripDropDownButton2.Text = "Hidden Startups"
        Me.ToolStripDropDownButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ExplorerAssociatedFileDetailToolStripMenuItem
        '
        Me.ExplorerAssociatedFileDetailToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.table
        Me.ExplorerAssociatedFileDetailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExplorerAssociatedFileDetailToolStripMenuItem.Name = "ExplorerAssociatedFileDetailToolStripMenuItem"
        Me.ExplorerAssociatedFileDetailToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.ExplorerAssociatedFileDetailToolStripMenuItem.Text = "Explorer associated file details."
        '
        'UserinitAssociatedFileDetailToolStripMenuItem
        '
        Me.UserinitAssociatedFileDetailToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.table_relationship
        Me.UserinitAssociatedFileDetailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UserinitAssociatedFileDetailToolStripMenuItem.Name = "UserinitAssociatedFileDetailToolStripMenuItem"
        Me.UserinitAssociatedFileDetailToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.UserinitAssociatedFileDetailToolStripMenuItem.Text = "Userinit associated file details."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 44)
        '
        'ToolStripDropDownButton3
        '
        Me.ToolStripDropDownButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SendToRecycleBinToolStripMenuItem, Me.ForcedDeletionToolStripMenuItem})
        Me.ToolStripDropDownButton3.Image = Global.Virus_Effect_Remover.My.Resources.Resources.Windows_Tools_48x48
        Me.ToolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton3.Name = "ToolStripDropDownButton3"
        Me.ToolStripDropDownButton3.Size = New System.Drawing.Size(96, 41)
        Me.ToolStripDropDownButton3.Text = "Startup Options"
        Me.ToolStripDropDownButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SendToRecycleBinToolStripMenuItem
        '
        Me.SendToRecycleBinToolStripMenuItem.Checked = True
        Me.SendToRecycleBinToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SendToRecycleBinToolStripMenuItem.Name = "SendToRecycleBinToolStripMenuItem"
        Me.SendToRecycleBinToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.SendToRecycleBinToolStripMenuItem.Text = "Send To Recycle Bin"
        '
        'ForcedDeletionToolStripMenuItem
        '
        Me.ForcedDeletionToolStripMenuItem.Checked = True
        Me.ForcedDeletionToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ForcedDeletionToolStripMenuItem.Enabled = False
        Me.ForcedDeletionToolStripMenuItem.Name = "ForcedDeletionToolStripMenuItem"
        Me.ForcedDeletionToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ForcedDeletionToolStripMenuItem.Text = "Forced Deletion"
        Me.ForcedDeletionToolStripMenuItem.Visible = False
        '
        'StartupListView
        '
        Me.StartupListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.StartupListView.ContextMenuStrip = Me.StartupStrip
        Me.StartupListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StartupListView.FullRowSelect = True
        ListViewGroup4.Header = "ListViewGroup"
        ListViewGroup4.Name = "ListViewGroup1"
        ListViewGroup5.Header = "ListViewGroup"
        ListViewGroup5.Name = "ListViewGroup2"
        ListViewGroup6.Header = "ListViewGroup"
        ListViewGroup6.Name = "ListViewGroup3"
        Me.StartupListView.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup4, ListViewGroup5, ListViewGroup6})
        Me.StartupListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.StartupListView.Location = New System.Drawing.Point(0, 44)
        Me.StartupListView.MultiSelect = False
        Me.StartupListView.Name = "StartupListView"
        Me.StartupListView.ShowItemToolTips = True
        Me.StartupListView.Size = New System.Drawing.Size(725, 379)
        Me.StartupListView.SmallImageList = Me.ImageList1
        Me.StartupListView.TabIndex = 5
        Me.StartupListView.UseCompatibleStateImageBehavior = False
        Me.StartupListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Startup Name"
        Me.ColumnHeader1.Width = 153
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Command Line"
        Me.ColumnHeader2.Width = 240
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Startup Path"
        Me.ColumnHeader3.Width = 209
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Argument"
        Me.ColumnHeader4.Width = 104
        '
        'StartupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 445)
        Me.Controls.Add(Me.StartupListView)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "StartupForm"
        Me.ShowIcon = False
        Me.Text = "Startup Programs"
        Me.StartupStrip.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents StartupStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveSelectedEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveEntryOnlyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveEntryAndAssociatedFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator20 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenLocationOfSelectedEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator23 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CopyFileToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyFilePathToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents AddNewStartupEntryToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ScanStartupEntryToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ViewRegistryInRegistryEditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents OpenCommonStartupFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenUsersStartupFolderToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ExplorerAssociatedFileDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserinitAssociatedFileDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton3 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents SendToRecycleBinToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForcedDeletionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StartupListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
End Class
