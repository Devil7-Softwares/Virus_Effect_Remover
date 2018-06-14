<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileProtectorMainForm
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
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.FileAttributeEncripted = New System.Windows.Forms.CheckBox
        Me.FileAttributeCompressed = New System.Windows.Forms.CheckBox
        Me.FileAttributeSystem = New System.Windows.Forms.CheckBox
        Me.FileAttributeArchive = New System.Windows.Forms.CheckBox
        Me.FileAtttributeHidden = New System.Windows.Forms.CheckBox
        Me.FileAttributeReadOnly = New System.Windows.Forms.CheckBox
        Me.FileAttributeApply = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.DirectoryRadioButton = New System.Windows.Forms.RadioButton
        Me.FileRadioButton = New System.Windows.Forms.RadioButton
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.GroupBox11.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox11
        '
        Me.GroupBox11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox11.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox11.Controls.Add(Me.FileAttributeEncripted)
        Me.GroupBox11.Controls.Add(Me.FileAttributeCompressed)
        Me.GroupBox11.Controls.Add(Me.FileAttributeSystem)
        Me.GroupBox11.Controls.Add(Me.FileAttributeArchive)
        Me.GroupBox11.Controls.Add(Me.FileAtttributeHidden)
        Me.GroupBox11.Controls.Add(Me.FileAttributeReadOnly)
        Me.GroupBox11.ForeColor = System.Drawing.Color.Black
        Me.GroupBox11.Location = New System.Drawing.Point(126, 88)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(189, 93)
        Me.GroupBox11.TabIndex = 16
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "File Attributes:"
        '
        'FileAttributeEncripted
        '
        Me.FileAttributeEncripted.AutoSize = True
        Me.FileAttributeEncripted.Location = New System.Drawing.Point(107, 67)
        Me.FileAttributeEncripted.Name = "FileAttributeEncripted"
        Me.FileAttributeEncripted.Size = New System.Drawing.Size(74, 17)
        Me.FileAttributeEncripted.TabIndex = 6
        Me.FileAttributeEncripted.Text = "Encrypted"
        Me.FileAttributeEncripted.UseVisualStyleBackColor = True
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
        'FileAttributeApply
        '
        Me.FileAttributeApply.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FileAttributeApply.Location = New System.Drawing.Point(163, 193)
        Me.FileAttributeApply.Name = "FileAttributeApply"
        Me.FileAttributeApply.Size = New System.Drawing.Size(110, 23)
        Me.FileAttributeApply.TabIndex = 8
        Me.FileAttributeApply.Text = "Apply"
        Me.FileAttributeApply.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DirectoryRadioButton)
        Me.Panel2.Controls.Add(Me.FileRadioButton)
        Me.Panel2.Location = New System.Drawing.Point(22, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(143, 28)
        Me.Panel2.TabIndex = 17
        '
        'DirectoryRadioButton
        '
        Me.DirectoryRadioButton.AutoSize = True
        Me.DirectoryRadioButton.Location = New System.Drawing.Point(78, 5)
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
        Me.FileRadioButton.Location = New System.Drawing.Point(14, 5)
        Me.FileRadioButton.Name = "FileRadioButton"
        Me.FileRadioButton.Size = New System.Drawing.Size(52, 17)
        Me.FileRadioButton.TabIndex = 0
        Me.FileRadioButton.TabStop = True
        Me.FileRadioButton.Text = "File(s)"
        Me.FileRadioButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TextBox1.Location = New System.Drawing.Point(22, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(329, 20)
        Me.TextBox1.TabIndex = 18
        Me.TextBox1.Tag = "Enter target path here"
        Me.TextBox1.Text = "Enter target path here"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(357, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ItemSize = New System.Drawing.Size(1, 18)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(438, 256)
        Me.TabControl1.TabIndex = 20
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.FileAttributeApply)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.GroupBox11)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(430, 230)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "File Protector"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ListBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(431, 230)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Event Log"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(3, 3)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(425, 221)
        Me.ListBox1.TabIndex = 0
        '
        'FileProtectorMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 256)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FileProtectorMainForm"
        Me.ShowIcon = False
        Me.Text = "File Protector"
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents FileAttributeApply As System.Windows.Forms.Button
    Friend WithEvents FileAttributeEncripted As System.Windows.Forms.CheckBox
    Friend WithEvents FileAttributeCompressed As System.Windows.Forms.CheckBox
    Friend WithEvents FileAttributeSystem As System.Windows.Forms.CheckBox
    Friend WithEvents FileAttributeArchive As System.Windows.Forms.CheckBox
    Friend WithEvents FileAtttributeHidden As System.Windows.Forms.CheckBox
    Friend WithEvents FileAttributeReadOnly As System.Windows.Forms.CheckBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DirectoryRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents FileRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
