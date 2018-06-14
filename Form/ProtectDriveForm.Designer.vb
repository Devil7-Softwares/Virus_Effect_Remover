<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProtectDriveForm
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
        Me.DrvListView = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ApplyButton = New System.Windows.Forms.Button
        Me.RefreshButtorn = New System.Windows.Forms.Button
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.FileAttributeSystem = New System.Windows.Forms.CheckBox
        Me.FileAttributeArchive = New System.Windows.Forms.CheckBox
        Me.FileAtttributeHidden = New System.Windows.Forms.CheckBox
        Me.FileAttributeReadOnly = New System.Windows.Forms.CheckBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox11.SuspendLayout()
        Me.SuspendLayout()
        '
        'DrvListView
        '
        Me.DrvListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrvListView.CheckBoxes = True
        Me.DrvListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader5, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.DrvListView.FullRowSelect = True
        Me.DrvListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.DrvListView.Location = New System.Drawing.Point(12, 23)
        Me.DrvListView.MultiSelect = False
        Me.DrvListView.Name = "DrvListView"
        Me.DrvListView.Size = New System.Drawing.Size(394, 219)
        Me.DrvListView.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.DrvListView, "Check drive(s) to protect.")
        Me.DrvListView.UseCompatibleStateImageBehavior = False
        Me.DrvListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Drive(s)"
        Me.ColumnHeader1.Width = 52
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Drive Type"
        Me.ColumnHeader5.Width = 73
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Volume Lable"
        Me.ColumnHeader2.Width = 90
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Total Size"
        Me.ColumnHeader3.Width = 88
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Status"
        Me.ColumnHeader4.Width = 83
        '
        'ApplyButton
        '
        Me.ApplyButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ApplyButton.Location = New System.Drawing.Point(23, 266)
        Me.ApplyButton.Name = "ApplyButton"
        Me.ApplyButton.Size = New System.Drawing.Size(75, 44)
        Me.ApplyButton.TabIndex = 1
        Me.ApplyButton.Text = "Apply"
        Me.ToolTip1.SetToolTip(Me.ApplyButton, "Click to apply current setting.")
        Me.ApplyButton.UseVisualStyleBackColor = True
        '
        'RefreshButtorn
        '
        Me.RefreshButtorn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RefreshButtorn.Location = New System.Drawing.Point(121, 266)
        Me.RefreshButtorn.Name = "RefreshButtorn"
        Me.RefreshButtorn.Size = New System.Drawing.Size(75, 44)
        Me.RefreshButtorn.TabIndex = 2
        Me.RefreshButtorn.Text = "Refresh"
        Me.ToolTip1.SetToolTip(Me.RefreshButtorn, "Refresh Current Status.")
        Me.RefreshButtorn.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox11.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox11.Controls.Add(Me.FileAttributeSystem)
        Me.GroupBox11.Controls.Add(Me.FileAttributeArchive)
        Me.GroupBox11.Controls.Add(Me.FileAtttributeHidden)
        Me.GroupBox11.Controls.Add(Me.FileAttributeReadOnly)
        Me.GroupBox11.ForeColor = System.Drawing.Color.Black
        Me.GroupBox11.Location = New System.Drawing.Point(206, 251)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(189, 72)
        Me.GroupBox11.TabIndex = 17
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Folder Attribute:"
        Me.ToolTip1.SetToolTip(Me.GroupBox11, "Set Attribute of autorun.inf folder.")
        '
        'FileAttributeSystem
        '
        Me.FileAttributeSystem.AutoSize = True
        Me.FileAttributeSystem.Checked = True
        Me.FileAttributeSystem.CheckState = System.Windows.Forms.CheckState.Checked
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
        Me.FileAtttributeHidden.Checked = True
        Me.FileAtttributeHidden.CheckState = System.Windows.Forms.CheckState.Checked
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
        Me.FileAttributeReadOnly.Checked = True
        Me.FileAttributeReadOnly.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FileAttributeReadOnly.Location = New System.Drawing.Point(9, 21)
        Me.FileAttributeReadOnly.Name = "FileAttributeReadOnly"
        Me.FileAttributeReadOnly.Size = New System.Drawing.Size(76, 17)
        Me.FileAttributeReadOnly.TabIndex = 0
        Me.FileAttributeReadOnly.Text = "Read Only"
        Me.FileAttributeReadOnly.UseVisualStyleBackColor = True
        '
        'ProtectDriveForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 335)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.RefreshButtorn)
        Me.Controls.Add(Me.ApplyButton)
        Me.Controls.Add(Me.DrvListView)
        Me.MaximumSize = New System.Drawing.Size(431, 800)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(431, 369)
        Me.Name = "ProtectDriveForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Protect Drive(s)"
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DrvListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ApplyButton As System.Windows.Forms.Button
    Friend WithEvents RefreshButtorn As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents FileAttributeSystem As System.Windows.Forms.CheckBox
    Friend WithEvents FileAttributeArchive As System.Windows.Forms.CheckBox
    Friend WithEvents FileAtttributeHidden As System.Windows.Forms.CheckBox
    Friend WithEvents FileAttributeReadOnly As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
