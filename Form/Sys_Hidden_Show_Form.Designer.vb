<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sys_Hidden_Show_Form
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
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ContextMenuStripForSysHide = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MakeAttributeNormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyFilePathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.LocateFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GetProcessFilePropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SendToRecycleBinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ForceToDeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.ContextMenuStripForSysHide.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader6, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader7})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStripForSysHide
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(0, 44)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(670, 339)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 154
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "File/Dir"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Type"
        Me.ColumnHeader2.Width = 62
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Size"
        Me.ColumnHeader3.Width = 88
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Attribute"
        Me.ColumnHeader4.Width = 161
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Status"
        Me.ColumnHeader5.Width = 120
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Full Name"
        Me.ColumnHeader7.Width = 200
        '
        'ContextMenuStripForSysHide
        '
        Me.ContextMenuStripForSysHide.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MakeAttributeNormalToolStripMenuItem, Me.DeleteFileToolStripMenuItem, Me.OptionToolStripMenuItem, Me.ToolStripSeparator2, Me.LocateFileToolStripMenuItem, Me.GetProcessFilePropertiesToolStripMenuItem})
        Me.ContextMenuStripForSysHide.Name = "ContextMenuStripForSysHide"
        Me.ContextMenuStripForSysHide.Size = New System.Drawing.Size(208, 120)
        '
        'MakeAttributeNormalToolStripMenuItem
        '
        Me.MakeAttributeNormalToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.tick_32
        Me.MakeAttributeNormalToolStripMenuItem.Name = "MakeAttributeNormalToolStripMenuItem"
        Me.MakeAttributeNormalToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.MakeAttributeNormalToolStripMenuItem.Text = "Make Attributes Normal"
        '
        'DeleteFileToolStripMenuItem
        '
        Me.DeleteFileToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources._001_30
        Me.DeleteFileToolStripMenuItem.Name = "DeleteFileToolStripMenuItem"
        Me.DeleteFileToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.DeleteFileToolStripMenuItem.Text = "Delete File \ Folder"
        '
        'OptionToolStripMenuItem
        '
        Me.OptionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyFileToolStripMenuItem, Me.CopyFilePathToolStripMenuItem})
        Me.OptionToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.application
        Me.OptionToolStripMenuItem.Name = "OptionToolStripMenuItem"
        Me.OptionToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.OptionToolStripMenuItem.Text = "Copy"
        '
        'CopyFileToolStripMenuItem
        '
        Me.CopyFileToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.door_out
        Me.CopyFileToolStripMenuItem.Name = "CopyFileToolStripMenuItem"
        Me.CopyFileToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.CopyFileToolStripMenuItem.Text = "Copy File\Folder"
        '
        'CopyFilePathToolStripMenuItem
        '
        Me.CopyFilePathToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.page_white_text
        Me.CopyFilePathToolStripMenuItem.Name = "CopyFilePathToolStripMenuItem"
        Me.CopyFilePathToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.CopyFilePathToolStripMenuItem.Text = "Copy File \ Folder Path"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(204, 6)
        '
        'LocateFileToolStripMenuItem
        '
        Me.LocateFileToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.folder_go
        Me.LocateFileToolStripMenuItem.Name = "LocateFileToolStripMenuItem"
        Me.LocateFileToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.LocateFileToolStripMenuItem.Text = "Locate File\Folder"
        '
        'GetProcessFilePropertiesToolStripMenuItem
        '
        Me.GetProcessFilePropertiesToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.information
        Me.GetProcessFilePropertiesToolStripMenuItem.Name = "GetProcessFilePropertiesToolStripMenuItem"
        Me.GetProcessFilePropertiesToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.GetProcessFilePropertiesToolStripMenuItem.Text = "Get File\Folder Properties"
        '
        'SendToRecycleBinToolStripMenuItem
        '
        Me.SendToRecycleBinToolStripMenuItem.Name = "SendToRecycleBinToolStripMenuItem"
        Me.SendToRecycleBinToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.SendToRecycleBinToolStripMenuItem.Text = "Send To Recycle Bin"
        '
        'ForceToDeleteToolStripMenuItem
        '
        Me.ForceToDeleteToolStripMenuItem.Name = "ForceToDeleteToolStripMenuItem"
        Me.ForceToDeleteToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ForceToDeleteToolStripMenuItem.Text = "Forced Deletion"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator4, Me.ToolStripButton1, Me.ToolStripSeparator5, Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(670, 44)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 44)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.Virus_Effect_Remover.My.Resources.Resources.arrow_refresh
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(49, 41)
        Me.ToolStripButton1.Text = "Refresh"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 44)
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SendToRecycleBinToolStripMenuItem, Me.ForceToDeleteToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = Global.Virus_Effect_Remover.My.Resources.Resources.Windows_Tools_48x48
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(57, 41)
        Me.ToolStripDropDownButton1.Text = "Options"
        Me.ToolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Sys_Hidden_Show_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 383)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Sys_Hidden_Show_Form"
        Me.ShowIcon = False
        Me.Text = "System+Hidden File(s)"
        Me.ContextMenuStripForSysHide.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStripForSysHide As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MakeAttributeNormalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyFilePathToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocateFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GetProcessFilePropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SendToRecycleBinToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForceToDeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
End Class
