<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinServiceForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WinServiceForm))
        Me.ServiceList = New System.Windows.Forms.ListView
        Me.ServiceNamePan = New System.Windows.Forms.ColumnHeader
        Me.ServiceDescriptionPan = New System.Windows.Forms.ColumnHeader
        Me.ServiceStatusPan = New System.Windows.Forms.ColumnHeader
        Me.ServiceEcentialPan = New System.Windows.Forms.ColumnHeader
        Me.ServiceManufacturePan = New System.Windows.Forms.ColumnHeader
        Me.ServiceListMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StartServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StopServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator
        Me.PauseServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResumeServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.UnstallServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DisableServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.RefreshServiceListToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ServiceManagementConsoleToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ServiceListMenu.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ServiceList
        '
        Me.ServiceList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ServiceNamePan, Me.ServiceDescriptionPan, Me.ServiceStatusPan, Me.ServiceEcentialPan, Me.ServiceManufacturePan})
        Me.ServiceList.ContextMenuStrip = Me.ServiceListMenu
        Me.ServiceList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ServiceList.FullRowSelect = True
        Me.ServiceList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ServiceList.Location = New System.Drawing.Point(0, 44)
        Me.ServiceList.MultiSelect = False
        Me.ServiceList.Name = "ServiceList"
        Me.ServiceList.Size = New System.Drawing.Size(645, 375)
        Me.ServiceList.TabIndex = 3
        Me.ServiceList.UseCompatibleStateImageBehavior = False
        Me.ServiceList.View = System.Windows.Forms.View.Details
        '
        'ServiceNamePan
        '
        Me.ServiceNamePan.Text = "Service Name"
        Me.ServiceNamePan.Width = 126
        '
        'ServiceDescriptionPan
        '
        Me.ServiceDescriptionPan.Text = "Service Description"
        Me.ServiceDescriptionPan.Width = 192
        '
        'ServiceStatusPan
        '
        Me.ServiceStatusPan.Text = "Status"
        Me.ServiceStatusPan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ServiceStatusPan.Width = 86
        '
        'ServiceEcentialPan
        '
        Me.ServiceEcentialPan.Text = "Essential"
        Me.ServiceEcentialPan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ServiceEcentialPan.Width = 62
        '
        'ServiceManufacturePan
        '
        Me.ServiceManufacturePan.Text = "Manufacturer"
        Me.ServiceManufacturePan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ServiceManufacturePan.Width = 131
        '
        'ServiceListMenu
        '
        Me.ServiceListMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartServiceToolStripMenuItem, Me.StopServiceToolStripMenuItem, Me.ToolStripSeparator15, Me.PauseServiceToolStripMenuItem, Me.ResumeServiceToolStripMenuItem, Me.ToolStripSeparator3, Me.UnstallServiceToolStripMenuItem, Me.DisableServiceToolStripMenuItem})
        Me.ServiceListMenu.Name = "ServiceListMenu"
        Me.ServiceListMenu.Size = New System.Drawing.Size(164, 148)
        '
        'StartServiceToolStripMenuItem
        '
        Me.StartServiceToolStripMenuItem.Image = CType(resources.GetObject("StartServiceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StartServiceToolStripMenuItem.Name = "StartServiceToolStripMenuItem"
        Me.StartServiceToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.StartServiceToolStripMenuItem.Text = "Start Service"
        '
        'StopServiceToolStripMenuItem
        '
        Me.StopServiceToolStripMenuItem.Image = CType(resources.GetObject("StopServiceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StopServiceToolStripMenuItem.Name = "StopServiceToolStripMenuItem"
        Me.StopServiceToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.StopServiceToolStripMenuItem.Text = "Stop Service"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(160, 6)
        '
        'PauseServiceToolStripMenuItem
        '
        Me.PauseServiceToolStripMenuItem.Image = CType(resources.GetObject("PauseServiceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PauseServiceToolStripMenuItem.Name = "PauseServiceToolStripMenuItem"
        Me.PauseServiceToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.PauseServiceToolStripMenuItem.Text = "Pause Service"
        '
        'ResumeServiceToolStripMenuItem
        '
        Me.ResumeServiceToolStripMenuItem.Image = Global.Virus_Effect_Remover.My.Resources.Resources.control_equalizer_blue
        Me.ResumeServiceToolStripMenuItem.Name = "ResumeServiceToolStripMenuItem"
        Me.ResumeServiceToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ResumeServiceToolStripMenuItem.Text = "Resume Service"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(160, 6)
        '
        'UnstallServiceToolStripMenuItem
        '
        Me.UnstallServiceToolStripMenuItem.Enabled = False
        Me.UnstallServiceToolStripMenuItem.Image = CType(resources.GetObject("UnstallServiceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UnstallServiceToolStripMenuItem.Name = "UnstallServiceToolStripMenuItem"
        Me.UnstallServiceToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.UnstallServiceToolStripMenuItem.Text = "Uninstall Service"
        '
        'DisableServiceToolStripMenuItem
        '
        Me.DisableServiceToolStripMenuItem.Enabled = False
        Me.DisableServiceToolStripMenuItem.Image = CType(resources.GetObject("DisableServiceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DisableServiceToolStripMenuItem.Name = "DisableServiceToolStripMenuItem"
        Me.DisableServiceToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.DisableServiceToolStripMenuItem.Text = "Disable Service"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 419)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(645, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.RefreshServiceListToolStripButton, Me.ToolStripSeparator2, Me.ServiceManagementConsoleToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(645, 44)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 44)
        '
        'RefreshServiceListToolStripButton
        '
        Me.RefreshServiceListToolStripButton.Image = Global.Virus_Effect_Remover.My.Resources.Resources.arrow_refresh
        Me.RefreshServiceListToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshServiceListToolStripButton.Name = "RefreshServiceListToolStripButton"
        Me.RefreshServiceListToolStripButton.Size = New System.Drawing.Size(92, 41)
        Me.RefreshServiceListToolStripButton.Text = "Refresh Services"
        Me.RefreshServiceListToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 44)
        '
        'ServiceManagementConsoleToolStripButton
        '
        Me.ServiceManagementConsoleToolStripButton.Image = Global.Virus_Effect_Remover.My.Resources.Resources.cog_edit
        Me.ServiceManagementConsoleToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ServiceManagementConsoleToolStripButton.Name = "ServiceManagementConsoleToolStripButton"
        Me.ServiceManagementConsoleToolStripButton.Size = New System.Drawing.Size(152, 41)
        Me.ServiceManagementConsoleToolStripButton.Text = "Service Management Console"
        Me.ServiceManagementConsoleToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'WinServiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 441)
        Me.Controls.Add(Me.ServiceList)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "WinServiceForm"
        Me.ShowIcon = False
        Me.Text = "Windows Services"
        Me.ServiceListMenu.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ServiceList As System.Windows.Forms.ListView
    Friend WithEvents ServiceNamePan As System.Windows.Forms.ColumnHeader
    Friend WithEvents ServiceDescriptionPan As System.Windows.Forms.ColumnHeader
    Friend WithEvents ServiceStatusPan As System.Windows.Forms.ColumnHeader
    Friend WithEvents ServiceEcentialPan As System.Windows.Forms.ColumnHeader
    Friend WithEvents ServiceManufacturePan As System.Windows.Forms.ColumnHeader
    Friend WithEvents ServiceListMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents StartServiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PauseServiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopServiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UnstallServiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisableServiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents RefreshServiceListToolStripButton As System.Windows.Forms.ToolStripButton
    Private WithEvents ServiceManagementConsoleToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ResumeServiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
End Class
