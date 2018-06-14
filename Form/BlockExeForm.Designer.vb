<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlockExeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BlockExeForm))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Ristrictedvalues = New System.Windows.Forms.ListBox
        Me.RefreshButton = New System.Windows.Forms.Button
        Me.allow_status = New System.Windows.Forms.Button
        Me.DelFile = New System.Windows.Forms.Button
        Me.BrowseFileBlock = New System.Windows.Forms.Button
        Me.AddFile = New System.Windows.Forms.Button
        Me.AddBox = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(617, 377)
        Me.Panel1.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Ristrictedvalues)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RefreshButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.allow_status)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DelFile)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BrowseFileBlock)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AddFile)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AddBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(615, 375)
        Me.SplitContainer1.SplitterDistance = 308
        Me.SplitContainer1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(14, 273)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(278, 87)
        Me.TextBox2.TabIndex = 18
        Me.TextBox2.Text = "Note:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     This feature is still under development, it may not work in some rare" & _
            " cases." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bugs:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Please e-mail us if you find any bugs or problems with this" & _
            " software. See the help file."
        '
        'Ristrictedvalues
        '
        Me.Ristrictedvalues.FormattingEnabled = True
        Me.Ristrictedvalues.Location = New System.Drawing.Point(14, 68)
        Me.Ristrictedvalues.Name = "Ristrictedvalues"
        Me.Ristrictedvalues.Size = New System.Drawing.Size(167, 199)
        Me.Ristrictedvalues.TabIndex = 17
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(195, 221)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(97, 23)
        Me.RefreshButton.TabIndex = 16
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'allow_status
        '
        Me.allow_status.Location = New System.Drawing.Point(195, 181)
        Me.allow_status.Name = "allow_status"
        Me.allow_status.Size = New System.Drawing.Size(97, 23)
        Me.allow_status.TabIndex = 15
        Me.allow_status.Text = "Status"
        Me.allow_status.UseVisualStyleBackColor = True
        '
        'DelFile
        '
        Me.DelFile.Location = New System.Drawing.Point(195, 141)
        Me.DelFile.Name = "DelFile"
        Me.DelFile.Size = New System.Drawing.Size(97, 23)
        Me.DelFile.TabIndex = 14
        Me.DelFile.Text = "Remove"
        Me.DelFile.UseVisualStyleBackColor = True
        '
        'BrowseFileBlock
        '
        Me.BrowseFileBlock.Location = New System.Drawing.Point(195, 101)
        Me.BrowseFileBlock.Name = "BrowseFileBlock"
        Me.BrowseFileBlock.Size = New System.Drawing.Size(97, 23)
        Me.BrowseFileBlock.TabIndex = 13
        Me.BrowseFileBlock.Text = "Browse File"
        Me.BrowseFileBlock.UseVisualStyleBackColor = True
        '
        'AddFile
        '
        Me.AddFile.Location = New System.Drawing.Point(228, 32)
        Me.AddFile.Name = "AddFile"
        Me.AddFile.Size = New System.Drawing.Size(64, 23)
        Me.AddFile.TabIndex = 12
        Me.AddFile.Text = "Add File"
        Me.AddFile.UseVisualStyleBackColor = True
        '
        'AddBox
        '
        Me.AddBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.AddBox.Location = New System.Drawing.Point(14, 32)
        Me.AddBox.Name = "AddBox"
        Me.AddBox.Size = New System.Drawing.Size(208, 20)
        Me.AddBox.TabIndex = 11
        Me.AddBox.Tag = "Enter file or virus name with Extension"
        Me.AddBox.Text = "Enter file or virus name with Extension"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(6, 17)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(288, 344)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'BlockExeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 377)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(623, 430)
        Me.Name = "BlockExeForm"
        Me.ShowIcon = False
        Me.Text = "   Block A Virus"
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AddBox As System.Windows.Forms.TextBox
    Friend WithEvents AddFile As System.Windows.Forms.Button
    Friend WithEvents BrowseFileBlock As System.Windows.Forms.Button
    Friend WithEvents DelFile As System.Windows.Forms.Button
    Friend WithEvents allow_status As System.Windows.Forms.Button
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents Ristrictedvalues As System.Windows.Forms.ListBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
End Class
