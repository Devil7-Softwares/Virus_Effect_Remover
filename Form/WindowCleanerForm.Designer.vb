<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WindowCleanerForm
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
        Me.WinCleanButton = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RecycleBinCh = New System.Windows.Forms.CheckBox
        Me.WindowsPrefetchCh = New System.Windows.Forms.CheckBox
        Me.WindowsTempCh = New System.Windows.Forms.CheckBox
        Me.RecentCh = New System.Windows.Forms.CheckBox
        Me.CookiesCh = New System.Windows.Forms.CheckBox
        Me.HistoryCh = New System.Windows.Forms.CheckBox
        Me.InternetCatchCh = New System.Windows.Forms.CheckBox
        Me.TempCh = New System.Windows.Forms.CheckBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.F2del = New System.Windows.Forms.CheckBox
        Me.SendToRclCh = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'WinCleanButton
        '
        Me.WinCleanButton.Location = New System.Drawing.Point(230, 22)
        Me.WinCleanButton.Name = "WinCleanButton"
        Me.WinCleanButton.Size = New System.Drawing.Size(142, 86)
        Me.WinCleanButton.TabIndex = 0
        Me.WinCleanButton.Text = "Clean Windows"
        Me.WinCleanButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RecycleBinCh)
        Me.GroupBox1.Controls.Add(Me.WindowsPrefetchCh)
        Me.GroupBox1.Controls.Add(Me.WindowsTempCh)
        Me.GroupBox1.Controls.Add(Me.RecentCh)
        Me.GroupBox1.Controls.Add(Me.CookiesCh)
        Me.GroupBox1.Controls.Add(Me.HistoryCh)
        Me.GroupBox1.Controls.Add(Me.InternetCatchCh)
        Me.GroupBox1.Controls.Add(Me.TempCh)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(172, 200)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Locations"
        '
        'RecycleBinCh
        '
        Me.RecycleBinCh.AutoSize = True
        Me.RecycleBinCh.Checked = True
        Me.RecycleBinCh.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RecycleBinCh.Location = New System.Drawing.Point(6, 177)
        Me.RecycleBinCh.Name = "RecycleBinCh"
        Me.RecycleBinCh.Size = New System.Drawing.Size(83, 17)
        Me.RecycleBinCh.TabIndex = 22
        Me.RecycleBinCh.Text = "Recycle Bin"
        Me.RecycleBinCh.UseVisualStyleBackColor = True
        '
        'WindowsPrefetchCh
        '
        Me.WindowsPrefetchCh.AutoSize = True
        Me.WindowsPrefetchCh.Location = New System.Drawing.Point(6, 154)
        Me.WindowsPrefetchCh.Name = "WindowsPrefetchCh"
        Me.WindowsPrefetchCh.Size = New System.Drawing.Size(115, 17)
        Me.WindowsPrefetchCh.TabIndex = 6
        Me.WindowsPrefetchCh.Text = "Windows\Prefetch"
        Me.WindowsPrefetchCh.UseVisualStyleBackColor = True
        '
        'WindowsTempCh
        '
        Me.WindowsTempCh.AutoSize = True
        Me.WindowsTempCh.Checked = True
        Me.WindowsTempCh.CheckState = System.Windows.Forms.CheckState.Checked
        Me.WindowsTempCh.Location = New System.Drawing.Point(6, 131)
        Me.WindowsTempCh.Name = "WindowsTempCh"
        Me.WindowsTempCh.Size = New System.Drawing.Size(102, 17)
        Me.WindowsTempCh.TabIndex = 5
        Me.WindowsTempCh.Text = "Windows\Temp"
        Me.WindowsTempCh.UseVisualStyleBackColor = True
        '
        'RecentCh
        '
        Me.RecentCh.AutoSize = True
        Me.RecentCh.Checked = True
        Me.RecentCh.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RecentCh.Location = New System.Drawing.Point(6, 108)
        Me.RecentCh.Name = "RecentCh"
        Me.RecentCh.Size = New System.Drawing.Size(61, 17)
        Me.RecentCh.TabIndex = 4
        Me.RecentCh.Text = "Recent"
        Me.RecentCh.UseVisualStyleBackColor = True
        '
        'CookiesCh
        '
        Me.CookiesCh.AutoSize = True
        Me.CookiesCh.Checked = True
        Me.CookiesCh.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CookiesCh.Location = New System.Drawing.Point(6, 88)
        Me.CookiesCh.Name = "CookiesCh"
        Me.CookiesCh.Size = New System.Drawing.Size(64, 17)
        Me.CookiesCh.TabIndex = 3
        Me.CookiesCh.Text = "Cookies"
        Me.CookiesCh.UseVisualStyleBackColor = True
        '
        'HistoryCh
        '
        Me.HistoryCh.AutoSize = True
        Me.HistoryCh.Checked = True
        Me.HistoryCh.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HistoryCh.Location = New System.Drawing.Point(6, 65)
        Me.HistoryCh.Name = "HistoryCh"
        Me.HistoryCh.Size = New System.Drawing.Size(58, 17)
        Me.HistoryCh.TabIndex = 2
        Me.HistoryCh.Text = "History"
        Me.HistoryCh.UseVisualStyleBackColor = True
        '
        'InternetCatchCh
        '
        Me.InternetCatchCh.AutoSize = True
        Me.InternetCatchCh.Checked = True
        Me.InternetCatchCh.CheckState = System.Windows.Forms.CheckState.Checked
        Me.InternetCatchCh.Location = New System.Drawing.Point(6, 42)
        Me.InternetCatchCh.Name = "InternetCatchCh"
        Me.InternetCatchCh.Size = New System.Drawing.Size(96, 17)
        Me.InternetCatchCh.TabIndex = 1
        Me.InternetCatchCh.Text = "Internet Cache"
        Me.InternetCatchCh.UseVisualStyleBackColor = True
        '
        'TempCh
        '
        Me.TempCh.AutoSize = True
        Me.TempCh.Checked = True
        Me.TempCh.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TempCh.Location = New System.Drawing.Point(6, 19)
        Me.TempCh.Name = "TempCh"
        Me.TempCh.Size = New System.Drawing.Size(100, 17)
        Me.TempCh.TabIndex = 0
        Me.TempCh.Text = "Temporary Files"
        Me.TempCh.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(44, 222)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(316, 16)
        Me.ProgressBar1.TabIndex = 20
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.F2del)
        Me.GroupBox2.Controls.Add(Me.SendToRclCh)
        Me.GroupBox2.Location = New System.Drawing.Point(230, 132)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(142, 78)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Options"
        '
        'F2del
        '
        Me.F2del.AutoSize = True
        Me.F2del.Location = New System.Drawing.Point(6, 46)
        Me.F2del.Name = "F2del"
        Me.F2del.Size = New System.Drawing.Size(101, 17)
        Me.F2del.TabIndex = 1
        Me.F2del.Text = "Forced Deletion"
        Me.F2del.UseVisualStyleBackColor = True
        '
        'SendToRclCh
        '
        Me.SendToRclCh.AutoSize = True
        Me.SendToRclCh.Enabled = False
        Me.SendToRclCh.Location = New System.Drawing.Point(6, 24)
        Me.SendToRclCh.Name = "SendToRclCh"
        Me.SendToRclCh.Size = New System.Drawing.Size(127, 17)
        Me.SendToRclCh.TabIndex = 0
        Me.SendToRclCh.Text = "Send To Recycle Bin"
        Me.SendToRclCh.UseVisualStyleBackColor = True
        '
        'WindowCleanerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 248)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.WinCleanButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(402, 299)
        Me.Name = "WindowCleanerForm"
        Me.ShowIcon = False
        Me.Text = "Windows Cleaner"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WinCleanButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TempCh As System.Windows.Forms.CheckBox
    Friend WithEvents CookiesCh As System.Windows.Forms.CheckBox
    Friend WithEvents HistoryCh As System.Windows.Forms.CheckBox
    Friend WithEvents InternetCatchCh As System.Windows.Forms.CheckBox
    Friend WithEvents WindowsPrefetchCh As System.Windows.Forms.CheckBox
    Friend WithEvents WindowsTempCh As System.Windows.Forms.CheckBox
    Friend WithEvents RecentCh As System.Windows.Forms.CheckBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents F2del As System.Windows.Forms.CheckBox
    Friend WithEvents SendToRclCh As System.Windows.Forms.CheckBox
    Friend WithEvents RecycleBinCh As System.Windows.Forms.CheckBox
End Class
