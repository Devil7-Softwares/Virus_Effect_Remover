<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartupAddForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.HKLMKey = New System.Windows.Forms.RadioButton
        Me.HKCUKey = New System.Windows.Forms.RadioButton
        Me.CommonStartupfolder = New System.Windows.Forms.RadioButton
        Me.StartupFolder = New System.Windows.Forms.RadioButton
        Me.TargetFileLocation = New System.Windows.Forms.TextBox
        Me.BrowseStartupFile = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.WorkingDir = New System.Windows.Forms.TextBox
        Me.TargetFolderLocation = New System.Windows.Forms.Button
        Me.AddStartUp = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ShortcutNameBox = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.HKLMKey)
        Me.GroupBox1.Controls.Add(Me.HKCUKey)
        Me.GroupBox1.Controls.Add(Me.CommonStartupfolder)
        Me.GroupBox1.Controls.Add(Me.StartupFolder)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(180, 118)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Location"
        '
        'HKLMKey
        '
        Me.HKLMKey.AutoSize = True
        Me.HKLMKey.Location = New System.Drawing.Point(6, 88)
        Me.HKLMKey.Name = "HKLMKey"
        Me.HKLMKey.Size = New System.Drawing.Size(167, 17)
        Me.HKLMKey.TabIndex = 3
        Me.HKLMKey.Text = "For All User. (Add To Registry)"
        Me.HKLMKey.UseVisualStyleBackColor = True
        '
        'HKCUKey
        '
        Me.HKCUKey.AutoSize = True
        Me.HKCUKey.Checked = True
        Me.HKCUKey.Location = New System.Drawing.Point(6, 65)
        Me.HKCUKey.Name = "HKCUKey"
        Me.HKCUKey.Size = New System.Drawing.Size(166, 17)
        Me.HKCUKey.TabIndex = 2
        Me.HKCUKey.TabStop = True
        Me.HKCUKey.Text = "Only For me.(Add To Registry)"
        Me.HKCUKey.UseVisualStyleBackColor = True
        '
        'CommonStartupfolder
        '
        Me.CommonStartupfolder.AutoSize = True
        Me.CommonStartupfolder.Location = New System.Drawing.Point(6, 42)
        Me.CommonStartupfolder.Name = "CommonStartupfolder"
        Me.CommonStartupfolder.Size = New System.Drawing.Size(171, 17)
        Me.CommonStartupfolder.TabIndex = 1
        Me.CommonStartupfolder.Text = "Add to All User's Startup Folder"
        Me.CommonStartupfolder.UseVisualStyleBackColor = True
        '
        'StartupFolder
        '
        Me.StartupFolder.AutoSize = True
        Me.StartupFolder.Location = New System.Drawing.Point(6, 19)
        Me.StartupFolder.Name = "StartupFolder"
        Me.StartupFolder.Size = New System.Drawing.Size(160, 17)
        Me.StartupFolder.TabIndex = 0
        Me.StartupFolder.Text = "Add to User's Startup Folder."
        Me.StartupFolder.UseVisualStyleBackColor = True
        '
        'TargetFileLocation
        '
        Me.TargetFileLocation.Location = New System.Drawing.Point(194, 37)
        Me.TargetFileLocation.Name = "TargetFileLocation"
        Me.TargetFileLocation.Size = New System.Drawing.Size(146, 20)
        Me.TargetFileLocation.TabIndex = 1
        '
        'BrowseStartupFile
        '
        Me.BrowseStartupFile.Location = New System.Drawing.Point(346, 37)
        Me.BrowseStartupFile.Name = "BrowseStartupFile"
        Me.BrowseStartupFile.Size = New System.Drawing.Size(56, 20)
        Me.BrowseStartupFile.TabIndex = 2
        Me.BrowseStartupFile.Text = "Browse"
        Me.BrowseStartupFile.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(197, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Target File Location"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(195, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Working Folder"
        '
        'WorkingDir
        '
        Me.WorkingDir.Location = New System.Drawing.Point(194, 87)
        Me.WorkingDir.Name = "WorkingDir"
        Me.WorkingDir.Size = New System.Drawing.Size(146, 20)
        Me.WorkingDir.TabIndex = 5
        Me.WorkingDir.Text = "C:\Windows"
        '
        'TargetFolderLocation
        '
        Me.TargetFolderLocation.Location = New System.Drawing.Point(346, 86)
        Me.TargetFolderLocation.Name = "TargetFolderLocation"
        Me.TargetFolderLocation.Size = New System.Drawing.Size(56, 20)
        Me.TargetFolderLocation.TabIndex = 6
        Me.TargetFolderLocation.Text = "Browse"
        Me.TargetFolderLocation.UseVisualStyleBackColor = True
        '
        'AddStartUp
        '
        Me.AddStartUp.Location = New System.Drawing.Point(261, 157)
        Me.AddStartUp.Name = "AddStartUp"
        Me.AddStartUp.Size = New System.Drawing.Size(102, 23)
        Me.AddStartUp.TabIndex = 7
        Me.AddStartUp.Text = "Add To Startup"
        Me.AddStartUp.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(18, 159)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(193, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(196, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Shortcut Name"
        '
        'ShortcutNameBox
        '
        Me.ShortcutNameBox.Location = New System.Drawing.Point(194, 130)
        Me.ShortcutNameBox.Name = "ShortcutNameBox"
        Me.ShortcutNameBox.Size = New System.Drawing.Size(143, 20)
        Me.ShortcutNameBox.TabIndex = 12
        '
        'StartupAddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 189)
        Me.Controls.Add(Me.ShortcutNameBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.AddStartUp)
        Me.Controls.Add(Me.TargetFolderLocation)
        Me.Controls.Add(Me.WorkingDir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BrowseStartupFile)
        Me.Controls.Add(Me.TargetFileLocation)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StartupAddForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add To Startup"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents HKLMKey As System.Windows.Forms.RadioButton
    Friend WithEvents HKCUKey As System.Windows.Forms.RadioButton
    Friend WithEvents CommonStartupfolder As System.Windows.Forms.RadioButton
    Friend WithEvents StartupFolder As System.Windows.Forms.RadioButton
    Friend WithEvents TargetFileLocation As System.Windows.Forms.TextBox
    Friend WithEvents BrowseStartupFile As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents WorkingDir As System.Windows.Forms.TextBox
    Friend WithEvents TargetFolderLocation As System.Windows.Forms.Button
    Friend WithEvents AddStartUp As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ShortcutNameBox As System.Windows.Forms.TextBox
End Class
