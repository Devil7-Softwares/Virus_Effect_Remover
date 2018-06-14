<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CloneForm
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"File Name", Global.Virus_Effect_Remover.My.Resources.EngResource.String1, Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Size(in byte)", Global.Virus_Effect_Remover.My.Resources.EngResource.String1, Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Extension", Global.Virus_Effect_Remover.My.Resources.EngResource.String1, Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Attribute", Global.Virus_Effect_Remover.My.Resources.EngResource.String1, Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"CreationTime", Global.Virus_Effect_Remover.My.Resources.EngResource.String1, Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"LastAccessTime", Global.Virus_Effect_Remover.My.Resources.EngResource.String1, Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"LastWriteTime", Global.Virus_Effect_Remover.My.Resources.EngResource.String1, Global.Virus_Effect_Remover.My.Resources.EngResource.String1}, -1)
        Me.Label59 = New System.Windows.Forms.Label
        Me.FirstFilePath = New System.Windows.Forms.TextBox
        Me.BrowseFile1 = New System.Windows.Forms.Button
        Me.TabControl3 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.DetailListView = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.Label21 = New System.Windows.Forms.Label
        Me.SecondFilePath = New System.Windows.Forms.TextBox
        Me.ResultsRichTextBox = New System.Windows.Forms.TextBox
        Me.BrowseFile2 = New System.Windows.Forms.Button
        Me.CompareButton = New System.Windows.Forms.Button
        Me.Label44 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.CollectPath = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TimeBox = New System.Windows.Forms.TextBox
        Me.CancleBAckGroundWorker = New System.Windows.Forms.Button
        Me.FindInDirrectory = New System.Windows.Forms.Button
        Me.RenameAllDuplicate = New System.Windows.Forms.Button
        Me.TabControl4 = New System.Windows.Forms.TabControl
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.DirecoryTreeView = New System.Windows.Forms.TreeView
        Me.CollectedPathListview = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.DuplicateFileList = New System.Windows.Forms.ListView
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.OpenDuplicateDirectory = New System.Windows.Forms.Button
        Me.RenameDuplicate = New System.Windows.Forms.Button
        Me.DeleteDuplicateFile = New System.Windows.Forms.Button
        Me.DeleteAllDuplicateFile = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.TabControl3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabControl4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(35, 14)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(49, 13)
        Me.Label59.TabIndex = 30
        Me.Label59.Text = "Main File"
        '
        'FirstFilePath
        '
        Me.FirstFilePath.ForeColor = System.Drawing.SystemColors.GrayText
        Me.FirstFilePath.Location = New System.Drawing.Point(99, 12)
        Me.FirstFilePath.Name = "FirstFilePath"
        Me.FirstFilePath.Size = New System.Drawing.Size(414, 20)
        Me.FirstFilePath.TabIndex = 31
        Me.FirstFilePath.Tag = "Enter reference File name here."
        Me.FirstFilePath.Text = "Enter reference File name here."
        '
        'BrowseFile1
        '
        Me.BrowseFile1.Location = New System.Drawing.Point(519, 12)
        Me.BrowseFile1.Name = "BrowseFile1"
        Me.BrowseFile1.Size = New System.Drawing.Size(63, 20)
        Me.BrowseFile1.TabIndex = 32
        Me.BrowseFile1.Text = "Browse"
        Me.BrowseFile1.UseVisualStyleBackColor = True
        '
        'TabControl3
        '
        Me.TabControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl3.Controls.Add(Me.TabPage2)
        Me.TabControl3.Controls.Add(Me.TabPage3)
        Me.TabControl3.Location = New System.Drawing.Point(11, 38)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(615, 344)
        Me.TabControl3.TabIndex = 33
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabPage2.Controls.Add(Me.DetailListView)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.SecondFilePath)
        Me.TabPage2.Controls.Add(Me.ResultsRichTextBox)
        Me.TabPage2.Controls.Add(Me.BrowseFile2)
        Me.TabPage2.Controls.Add(Me.CompareButton)
        Me.TabPage2.Controls.Add(Me.Label44)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(607, 318)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Compare Files"
        '
        'DetailListView
        '
        Me.DetailListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.DetailListView.GridLines = True
        Me.DetailListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.DetailListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7})
        Me.DetailListView.Location = New System.Drawing.Point(20, 80)
        Me.DetailListView.Name = "DetailListView"
        Me.DetailListView.Size = New System.Drawing.Size(554, 133)
        Me.DetailListView.TabIndex = 40
        Me.DetailListView.UseCompatibleStateImageBehavior = False
        Me.DetailListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Parameter"
        Me.ColumnHeader1.Width = 142
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Main File"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Other File"
        Me.ColumnHeader3.Width = 202
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(7, 235)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(70, 13)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "Event Viewer"
        '
        'SecondFilePath
        '
        Me.SecondFilePath.ForeColor = System.Drawing.SystemColors.GrayText
        Me.SecondFilePath.Location = New System.Drawing.Point(85, 12)
        Me.SecondFilePath.Name = "SecondFilePath"
        Me.SecondFilePath.Size = New System.Drawing.Size(282, 20)
        Me.SecondFilePath.TabIndex = 4
        Me.SecondFilePath.Tag = "Enter target File name here."
        Me.SecondFilePath.Text = "Enter target File name here."
        '
        'ResultsRichTextBox
        '
        Me.ResultsRichTextBox.BackColor = System.Drawing.Color.White
        Me.ResultsRichTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ResultsRichTextBox.Location = New System.Drawing.Point(3, 254)
        Me.ResultsRichTextBox.Multiline = True
        Me.ResultsRichTextBox.Name = "ResultsRichTextBox"
        Me.ResultsRichTextBox.ReadOnly = True
        Me.ResultsRichTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ResultsRichTextBox.Size = New System.Drawing.Size(601, 38)
        Me.ResultsRichTextBox.TabIndex = 38
        Me.ResultsRichTextBox.TabStop = False
        Me.ResultsRichTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BrowseFile2
        '
        Me.BrowseFile2.Location = New System.Drawing.Point(402, 10)
        Me.BrowseFile2.Name = "BrowseFile2"
        Me.BrowseFile2.Size = New System.Drawing.Size(63, 24)
        Me.BrowseFile2.TabIndex = 5
        Me.BrowseFile2.Text = "Browse"
        Me.BrowseFile2.UseVisualStyleBackColor = True
        '
        'CompareButton
        '
        Me.CompareButton.Location = New System.Drawing.Point(189, 51)
        Me.CompareButton.Name = "CompareButton"
        Me.CompareButton.Size = New System.Drawing.Size(149, 23)
        Me.CompareButton.TabIndex = 6
        Me.CompareButton.Text = "Compare File Binary"
        Me.CompareButton.UseVisualStyleBackColor = True
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(17, 17)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(52, 13)
        Me.Label44.TabIndex = 13
        Me.Label44.Text = "Other File"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabPage3.Controls.Add(Me.CollectPath)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.TimeBox)
        Me.TabPage3.Controls.Add(Me.CancleBAckGroundWorker)
        Me.TabPage3.Controls.Add(Me.FindInDirrectory)
        Me.TabPage3.Controls.Add(Me.RenameAllDuplicate)
        Me.TabPage3.Controls.Add(Me.TabControl4)
        Me.TabPage3.Controls.Add(Me.OpenDuplicateDirectory)
        Me.TabPage3.Controls.Add(Me.RenameDuplicate)
        Me.TabPage3.Controls.Add(Me.DeleteDuplicateFile)
        Me.TabPage3.Controls.Add(Me.DeleteAllDuplicateFile)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(607, 318)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "Search in folder"
        '
        'CollectPath
        '
        Me.CollectPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CollectPath.Location = New System.Drawing.Point(514, 246)
        Me.CollectPath.Name = "CollectPath"
        Me.CollectPath.Size = New System.Drawing.Size(75, 21)
        Me.CollectPath.TabIndex = 41
        Me.CollectPath.Text = "Collect Path"
        Me.CollectPath.UseVisualStyleBackColor = True
        Me.CollectPath.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(511, 271)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "-Time Elapsed-"
        '
        'TimeBox
        '
        Me.TimeBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TimeBox.Location = New System.Drawing.Point(504, 288)
        Me.TimeBox.Name = "TimeBox"
        Me.TimeBox.Size = New System.Drawing.Size(100, 20)
        Me.TimeBox.TabIndex = 39
        '
        'CancleBAckGroundWorker
        '
        Me.CancleBAckGroundWorker.Enabled = False
        Me.CancleBAckGroundWorker.Location = New System.Drawing.Point(510, 6)
        Me.CancleBAckGroundWorker.Name = "CancleBAckGroundWorker"
        Me.CancleBAckGroundWorker.Size = New System.Drawing.Size(91, 35)
        Me.CancleBAckGroundWorker.TabIndex = 1
        Me.CancleBAckGroundWorker.Tag = "This Button is used for Stoping thred but not working."
        Me.CancleBAckGroundWorker.Text = "Scanning "
        Me.CancleBAckGroundWorker.UseVisualStyleBackColor = True
        Me.CancleBAckGroundWorker.Visible = False
        '
        'FindInDirrectory
        '
        Me.FindInDirrectory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FindInDirrectory.Location = New System.Drawing.Point(510, 71)
        Me.FindInDirrectory.Name = "FindInDirrectory"
        Me.FindInDirrectory.Size = New System.Drawing.Size(78, 32)
        Me.FindInDirrectory.TabIndex = 9
        Me.FindInDirrectory.Text = "Find"
        Me.FindInDirrectory.UseVisualStyleBackColor = True
        '
        'RenameAllDuplicate
        '
        Me.RenameAllDuplicate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RenameAllDuplicate.Enabled = False
        Me.RenameAllDuplicate.Location = New System.Drawing.Point(511, 192)
        Me.RenameAllDuplicate.Name = "RenameAllDuplicate"
        Me.RenameAllDuplicate.Size = New System.Drawing.Size(75, 23)
        Me.RenameAllDuplicate.TabIndex = 36
        Me.RenameAllDuplicate.Text = "Rename All"
        Me.RenameAllDuplicate.UseVisualStyleBackColor = True
        '
        'TabControl4
        '
        Me.TabControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl4.Controls.Add(Me.TabPage5)
        Me.TabControl4.Controls.Add(Me.TabPage1)
        Me.TabControl4.Controls.Add(Me.TabPage4)
        Me.TabControl4.Location = New System.Drawing.Point(3, 3)
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(495, 312)
        Me.TabControl4.TabIndex = 38
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.SplitContainer1)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(487, 286)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Select Folders"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DirecoryTreeView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.CollectedPathListview)
        Me.SplitContainer1.Size = New System.Drawing.Size(487, 286)
        Me.SplitContainer1.SplitterDistance = 318
        Me.SplitContainer1.TabIndex = 0
        '
        'DirecoryTreeView
        '
        Me.DirecoryTreeView.CheckBoxes = True
        Me.DirecoryTreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DirecoryTreeView.Location = New System.Drawing.Point(0, 0)
        Me.DirecoryTreeView.Name = "DirecoryTreeView"
        Me.DirecoryTreeView.Size = New System.Drawing.Size(318, 286)
        Me.DirecoryTreeView.TabIndex = 0
        '
        'CollectedPathListview
        '
        Me.CollectedPathListview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4})
        Me.CollectedPathListview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CollectedPathListview.Location = New System.Drawing.Point(0, 0)
        Me.CollectedPathListview.Name = "CollectedPathListview"
        Me.CollectedPathListview.Size = New System.Drawing.Size(165, 286)
        Me.CollectedPathListview.TabIndex = 3
        Me.CollectedPathListview.UseCompatibleStateImageBehavior = False
        Me.CollectedPathListview.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Collected Path"
        Me.ColumnHeader4.Width = 250
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DuplicateFileList)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(487, 286)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Duplicate Files"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DuplicateFileList
        '
        Me.DuplicateFileList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DuplicateFileList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader15})
        Me.DuplicateFileList.FullRowSelect = True
        Me.DuplicateFileList.GridLines = True
        Me.DuplicateFileList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.DuplicateFileList.Location = New System.Drawing.Point(3, 3)
        Me.DuplicateFileList.MultiSelect = False
        Me.DuplicateFileList.Name = "DuplicateFileList"
        Me.DuplicateFileList.Size = New System.Drawing.Size(481, 280)
        Me.DuplicateFileList.TabIndex = 0
        Me.DuplicateFileList.UseCompatibleStateImageBehavior = False
        Me.DuplicateFileList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "*"
        Me.ColumnHeader9.Width = 46
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Duplicate File"
        Me.ColumnHeader15.Width = 407
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.TextBox2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(487, 286)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Error List"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox2.Location = New System.Drawing.Point(3, 3)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(481, 280)
        Me.TextBox2.TabIndex = 0
        '
        'OpenDuplicateDirectory
        '
        Me.OpenDuplicateDirectory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpenDuplicateDirectory.Location = New System.Drawing.Point(511, 217)
        Me.OpenDuplicateDirectory.Name = "OpenDuplicateDirectory"
        Me.OpenDuplicateDirectory.Size = New System.Drawing.Size(75, 23)
        Me.OpenDuplicateDirectory.TabIndex = 34
        Me.OpenDuplicateDirectory.Text = "Open Folder"
        Me.OpenDuplicateDirectory.UseVisualStyleBackColor = True
        '
        'RenameDuplicate
        '
        Me.RenameDuplicate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RenameDuplicate.Location = New System.Drawing.Point(511, 167)
        Me.RenameDuplicate.Name = "RenameDuplicate"
        Me.RenameDuplicate.Size = New System.Drawing.Size(75, 23)
        Me.RenameDuplicate.TabIndex = 35
        Me.RenameDuplicate.Text = "Rename"
        Me.RenameDuplicate.UseVisualStyleBackColor = True
        '
        'DeleteDuplicateFile
        '
        Me.DeleteDuplicateFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteDuplicateFile.Location = New System.Drawing.Point(511, 115)
        Me.DeleteDuplicateFile.Name = "DeleteDuplicateFile"
        Me.DeleteDuplicateFile.Size = New System.Drawing.Size(75, 23)
        Me.DeleteDuplicateFile.TabIndex = 32
        Me.DeleteDuplicateFile.Text = "Delete"
        Me.DeleteDuplicateFile.UseVisualStyleBackColor = True
        '
        'DeleteAllDuplicateFile
        '
        Me.DeleteAllDuplicateFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteAllDuplicateFile.Location = New System.Drawing.Point(511, 141)
        Me.DeleteAllDuplicateFile.Name = "DeleteAllDuplicateFile"
        Me.DeleteAllDuplicateFile.Size = New System.Drawing.Size(75, 23)
        Me.DeleteAllDuplicateFile.TabIndex = 33
        Me.DeleteAllDuplicateFile.Text = "Delete All"
        Me.DeleteAllDuplicateFile.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 394)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(640, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 34
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(111, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel2.Visible = False
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        Me.ToolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ToolStripProgressBar1.Visible = False
        '
        'BackgroundWorker1
        '
        '
        'CloneForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 416)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl3)
        Me.Controls.Add(Me.BrowseFile1)
        Me.Controls.Add(Me.FirstFilePath)
        Me.Controls.Add(Me.Label59)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CloneForm"
        Me.ShowIcon = False
        Me.Text = "Clone Scanner"
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabControl4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents FirstFilePath As System.Windows.Forms.TextBox
    Friend WithEvents BrowseFile1 As System.Windows.Forms.Button
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents SecondFilePath As System.Windows.Forms.TextBox
    Friend WithEvents ResultsRichTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BrowseFile2 As System.Windows.Forms.Button
    Friend WithEvents CompareButton As System.Windows.Forms.Button
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents CancleBAckGroundWorker As System.Windows.Forms.Button
    Friend WithEvents FindInDirrectory As System.Windows.Forms.Button
    Friend WithEvents TabControl4 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DuplicateFileList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents RenameAllDuplicate As System.Windows.Forms.Button
    Friend WithEvents OpenDuplicateDirectory As System.Windows.Forms.Button
    Friend WithEvents RenameDuplicate As System.Windows.Forms.Button
    Friend WithEvents DeleteDuplicateFile As System.Windows.Forms.Button
    Friend WithEvents DeleteAllDuplicateFile As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DetailListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TimeBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DirecoryTreeView As System.Windows.Forms.TreeView
    Friend WithEvents CollectedPathListview As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents CollectPath As System.Windows.Forms.Button

End Class
