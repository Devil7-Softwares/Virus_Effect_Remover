'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date : 08/01/2010                               '
'                      form code is CS                             '
'******************************************************************'
Imports System.IO

Public Class CloneForm

    Private Oclock As New Stopwatch


#Region "Form Event "

    Private Function BuildDetailListView(ByRef Finfo As FileInfo, ByVal SubitemIndex As Integer) As Boolean
        'here sub item index stand for front page listview of file details in clone page
        'it must be 1 or 2

        'If SubitemIndex < 1 Or SubitemIndex > 2 Then
        '    MsgBox("Index is not valid.", MsgBoxStyle.Exclamation)
        '    Return False
        'End If


        'now add this file spacification to listview
        With DetailListView
            .Items(0).SubItems(SubitemIndex).Text = Finfo.Name
            .Items(1).SubItems(SubitemIndex).Text = ByteSizeOptimaized(Finfo.Length)
            .Items(2).SubItems(SubitemIndex).Text = Finfo.Extension.ToString
            .Items(3).SubItems(SubitemIndex).Text = Finfo.Attributes.ToString
            .Items(4).SubItems(SubitemIndex).Text = Finfo.CreationTime.ToString
            .Items(5).SubItems(SubitemIndex).Text = Finfo.LastAccessTime.ToString
            .Items(6).SubItems(SubitemIndex).Text = Finfo.LastWriteTime.ToString
        End With
        Return True
    End Function

    Private Sub BrowseFile1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseFile1.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.Filter = "All files (*.*)|*.*|Executable files (*.exe)|*.exe|DLL files (*.dll)|*.dll"
        OpenFileDialog.Multiselect = False
        OpenFileDialog.FileName = ""

        'check if file is selected or not
        If Not OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Return
        End If

        FirstFilePath.Text = OpenFileDialog.FileName

        If Not File_Exists(OpenFileDialog.FileName.ToString) Then Return
        'check if file Exist
        Dim Finfo As New FileInfo(OpenFileDialog.FileName)

        If Not BuildDetailListView(Finfo, 1) Then
            MsgBox("Failed to build list!", MsgBoxStyle.Exclamation)
        End If


    End Sub

    Private Sub BrowseFile2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseFile2.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.Multiselect = False
        OpenFileDialog.FileName = ""
        'OpenFileDialog.Filter = "All files (*.*)|*.*"
        OpenFileDialog.Filter = "All files (*.*)|*.*|Executable files (*.exe)|*.exe|DLL files (*.dll)|*.dll"
        If Not OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Return
        End If

        SecondFilePath.Text = OpenFileDialog.FileName.ToString

        If Not File_Exists(OpenFileDialog.FileName.ToString) Then Return

        'check if file Exist
        Dim Finfo As New FileInfo(OpenFileDialog.FileName.ToString)

        'now add this file spacification to listview
        If Not BuildDetailListView(Finfo, 2) Then
            MsgBox("Failed to build list!", MsgBoxStyle.Exclamation)
        End If

    End Sub

    'Private Sub BrowseFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseFolder.Click
    '    Dim FolderBrowserDialog As New FolderBrowserDialog
    '    FolderBrowserDialog.ShowNewFolderButton = False

    '    If Not FolderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '        Return
    '    End If

    '    DirectoryName.Text = FolderBrowserDialog.SelectedPath.ToString

    'End Sub

    Private Sub FindInDirrectory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindInDirrectory.Click

        If TextBoxIsIdle(FirstFilePath, False) Then
            MsgBox("Reference file path is blank.", MsgBoxStyle.Exclamation)
            Return
        End If


        'If TextBoxIsIdle(DirectoryName, False) Then
        '    MsgBox("Target folder path is blank.", MsgBoxStyle.Exclamation)
        '    Return
        'End If

        'now update path list 
        CollectPath_Click(Nothing, Nothing)

        'now confirm all paths  and sayt user if he want to scan 
        If Not MsgBox("Scanning process will take time according to size of drive(s) and data." + _
                vbNewLine + "(Sub-Folders will be scanned.)" + vbNewLineVER(2) + "Do you want to scan all selected folders.", MsgBoxStyle.Information Or MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Return
        End If
        ErrorCollection = New ArrayList
        ErrorCollection.Clear()
        DirClone = New ArrayList
        DirClone.Clear()

        For Each item As ListViewItem In CollectedPathListview.Items
            If Directory_Exists(item.Text) Then
                DirClone.Add(item.Text)
            Else
                '                Continue For
                item.Remove()
            End If
        Next


        '  If My.Computer.FileSystem.DirectoryExists(DirectoryName.Text) = True _
        '  And My.Computer.FileSystem.FileExists(FirstFilePath.Text) = True Then

        'clearing ListView
        DuplicateFileList.Items.Clear()

        'New Code for BackGround Worker
        ''''''''''''''''''''''''''''''''''''
        'Setting Initial file name And Initial Dir to globalVAriable
        FileNameClone = FirstFilePath.Text
       
        'Used for Indication that the Background worker is running
        'Starting ProgressBar
        ToolStripProgressBar1.Visible = True
        ToolStripStatusLabel2.Text = "Scanning folder  :  "
        ToolStripStatusLabel2.Visible = True

        'Disableing & Enabling The control
        FindInDirrectory.Enabled = False
        CancleBAckGroundWorker.Visible = True
        TimeBox.Text = ""

        Oclock.Reset()
        Oclock.Start()
        'RUnnning the back ground Worker
        BackgroundWorker1.RunWorkerAsync()

        '  Else
        'MsgBox("Error occured during detection of path.", MsgBoxStyle.Information)
        ' End If
    End Sub

    Private Sub CompareButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompareButton.Click
        ErrorCollection.Clear()

        Me.ResultsRichTextBox.Text = ""

        If TextBoxIsIdle(FirstFilePath, False) Then
            MsgBox("Reference file path is blank.", MsgBoxStyle.Exclamation)
            Return
        Else
            'setting file path detail
            If My.Computer.FileSystem.FileExists(FirstFilePath.Text) = True Then
                Dim Finfo As New FileInfo(FirstFilePath.Text)
                'now add this file spacification to listview
                If Not BuildDetailListView(Finfo, 1) Then
                    MsgBox("Failed to build list", MsgBoxStyle.Exclamation)
                End If

            Else
                Me.ResultsRichTextBox.Text = "Error occured during detection of path." + vbNewLine _
                        + "--------------------------------" + vbNewLine
                MsgBox("Check source file name. path does not exist.")
                Return
            End If
        End If

        If TextBoxIsIdle(SecondFilePath, False) Then
            MsgBox("Target file path is blank.", MsgBoxStyle.Exclamation)
            Return
        Else
            If My.Computer.FileSystem.FileExists(SecondFilePath.Text) = True Then
                Dim Finfo As New FileInfo(SecondFilePath.Text)
                'now add this file spacification to listview
                If Not BuildDetailListView(Finfo, 2) Then
                    MsgBox("Failed to build list", MsgBoxStyle.Exclamation)
                End If

            Else
                Me.ResultsRichTextBox.Text = "Error occurred during detection of path." + vbNewLine _
                        + "--------------------------------" + vbNewLine
                MsgBox("Check target file name. Path does not exist.", MsgBoxStyle.Exclamation)
                Return
            End If
        End If

        'Now getting detail...
        Try
            'it return 3 if path is equal
            'it return 2 if path is diffrent but file is same
            'it return 1 if file is same size but Not Equal
            'it return 0 if file is not equal and size is diffrent
            'it return -1 if error Occured
            Dim Ex As New Exception
            Select Case CompareFiles(New FileInfo(FirstFilePath.Text), New FileInfo(SecondFilePath.Text), Ex)
                Case 3
                    Me.ResultsRichTextBox.Text = "You have selected same path...." + vbNewLine _
                                          + "--------------------------------" + vbNewLine
                    Exit Try
                Case 2
                    Me.ResultsRichTextBox.Text = "Files are equal." + vbNewLine + _
                                      "--------------------------------------------------" + vbNewLine
                    Exit Try
                Case 1
                    Me.ResultsRichTextBox.Text = "Both files have same size. But they are not equal." + vbNewLine + _
                                                 "--------------------------------" + vbNewLine
                    Exit Try
                Case 0
                    Me.ResultsRichTextBox.Text = "Files are not equal." + vbNewLine + _
                    "--------------------------------" + vbNewLine
                    Exit Try
                Case (-1)
                    ResultsRichTextBox.Text = Ex.Message + vbNewLine + _
                                              "--------------------------------" + vbNewLine
                    Exit Try
                Case Else
                    MsgBox("Unknown Result, probably it is an error." + vbNewLine + _
                           "please send this detail to avinashsachan@gmail.com")
            End Select

        Catch ex As Exception
            ResultsRichTextBox.Text = ""
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Function ArrayListToString(ByRef ArrList As ArrayList, Optional ByVal EachInNewline As Boolean = True) As String

        Dim str As String = String.Empty
        If EachInNewline Then
            For Each item As String In ArrList
                str += item + vbNewLine
            Next
            Return str
        Else
            For Each item As String In ArrList
                str += item
            Next
            Return str
        End If

    End Function

#Region "  Side buttons   "

    Private Sub DeleteDuplicateFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteDuplicateFile.Click

        If ListViewIsEmptyOrNotSelected(DuplicateFileList) Then Return

        Try

            Dim afile As String
            afile = DuplicateFileList.Items(DuplicateFileList.SelectedIndices(0)).SubItems(1).Text.ToString

            If My.Computer.FileSystem.FileExists(afile) Then
                Dim es As New Exception
                If DeleteFile(New FileInfo(afile), False, True, True, , es) Then
                    DuplicateFileList.Items(DuplicateFileList.SelectedIndices(0)).Remove()
                Else
                    MsgBox(es.Message, MsgBoxStyle.Exclamation)
                    DuplicateFileList.Items(DuplicateFileList.SelectedIndices(0)).BackColor = Color.Red
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RenameDuplicate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenameDuplicate.Click

        If ListViewIsEmptyOrNotSelected(DuplicateFileList) Then Return

        Try
            Dim afile As System.IO.FileInfo
            afile = New System.IO.FileInfo(DuplicateFileList.Items _
                                          (DuplicateFileList.SelectedIndices(0)).SubItems(1).Text.ToString)

            Try
                'setting Attribute to normal
                afile.Attributes = IO.FileAttributes.Normal
            Catch  'second attempt
                Try
                    'taking control of file access
                    NTFS.AddFullcontrolToFile(afile.Name)
                    'setting Attribute to normal
                    afile.Attributes = IO.FileAttributes.Normal
                Catch es As Exception
                    MsgBox(es.Message, MsgBoxStyle.Exclamation)
                    Return
                End Try
            End Try


            Dim NewName As String = afile.DirectoryName + "\Renamed " + afile.Name
            Rename(afile.FullName, NewName)
            afile = New System.IO.FileInfo(NewName)
            DuplicateFileList.Items(DuplicateFileList.SelectedIndices(0)).SubItems(1).Text = afile.FullName

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub

    Private Sub OpenDuplicateDirectory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenDuplicateDirectory.Click

        If ListViewIsEmptyOrNotSelected(DuplicateFileList) Then Return

        Try
            System.Diagnostics.Process.Start( _
                My.Computer.FileSystem.GetParentPath( _
                DuplicateFileList.Items(DuplicateFileList.SelectedIndices(0)).SubItems(1).Text.ToString()))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub

    Private Sub DeleteAllDuplicateFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteAllDuplicateFile.Click

        If Not EmptyListView(DuplicateFileList) Then
            Dim afile As IO.FileInfo
            For count = 0 To DuplicateFileList.Items.Count - 1

                Try
                    afile = New IO.FileInfo(DuplicateFileList.Items(count).SubItems(1).Text.ToString())
                    'taking control

                    'Setting Atribute to Normal
                    afile.Attributes = IO.FileAttributes.Normal
                    'Deleting file
                    afile.Delete()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next
            'Clearing total list
            DuplicateFileList.Items.Clear()
        End If


        If Not TextBoxIsIdle(FirstFilePath, False) Then
            If MsgBox("Do you also want to delete Main File ?", MsgBoxStyle.YesNo, "Deleting Main File") = MsgBoxResult.Yes Then
                Try
                    My.Computer.FileSystem.DeleteFile(FirstFilePath.Text)
                    FirstFilePath.Text = ""
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If
        End If


    End Sub


#End Region


#End Region

    'This Back Ground Worker IS for Clone File Search in directory
#Region "     Back ground worker    "

#Region "  Back Ground Worker Parameter   "
    'this value used to collect duplicate files
    Private CollectionArrayList As New ArrayList
    'this hold File name and dir name Which we want to send to thread
    Private FileNameClone As String
    Private DirClone As ArrayList
    'Exception Collection 
    Private ErrorCollection As New ArrayList

#End Region

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        CollectionArrayList = New ArrayList
        CollectionArrayList.Clear()
        ErrorCollection.Clear()

        '''''''''''''''''''''''''''''''''''
        'Calling Worker Function
        '.......
        For Each item As String In DirClone
            '  MsgBox("scaning drive : " + item)
            ' FindDuplicateFileWorker(DirClone, New FileInfo(FileNameClone), ErrorCollection)
            FindDuplicateFileWorker(item, New FileInfo(FileNameClone), ErrorCollection)

        Next
        
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        Oclock.Stop()
        TimeBox.Text = (Oclock.ElapsedMilliseconds / 1000).ToString + "  Sec."



        'Adding All Retrive File from BackGround Worker
        For Each item In CollectionArrayList
            Me.DuplicateFileList.Items.Add((Me.DuplicateFileList.Items.Count + 1).ToString)
            Me.DuplicateFileList.Items(Me.DuplicateFileList.Items.Count - 1).SubItems.Add(item.ToString)
        Next

       

        'Collecting Error Report
        TextBox2.Text = ArrayListToString(ErrorCollection, True)



        'Disableing & Enabling The control
        FindInDirrectory.Enabled = True
        CancleBAckGroundWorker.Visible = False

        'Used for indication that the background worker is running
        'Stopiing ProgressBAr
        ToolStripProgressBar1.Visible = False
        'resetting The text so that it can not appeare in other process 
        ToolStripStatusLabel2.Text = ""
        ToolStripStatusLabel2.Visible = False


        If CollectionArrayList.Count <= 0 Then
            MsgBox("No clone file found in selected path(s).")
        Else
            Me.TabControl3.SelectedTab = TabPage3
            Me.TabControl4.SelectedTab = TabPage1
        End If
        ErrorCollection.Clear()
        CollectionArrayList.Clear()
    End Sub

    Private Sub CancleBAckGroundWorker_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancleBAckGroundWorker.Click
        'Stoping BAckground Worker
        If BackgroundWorker1.WorkerSupportsCancellation Then
            BackgroundWorker1.CancelAsync()
            ' Collecting Collected Information

            'Adding All Retrive File from BackGround Worker
            For Each item In CollectionArrayList
                Me.DuplicateFileList.Items.Add((Me.DuplicateFileList.Items.Count + 1).ToString)
                Me.DuplicateFileList.Items(Me.DuplicateFileList.Items.Count - 1).SubItems.Add(item.ToString)
            Next

            'Collecting Error Report
            TextBox2.Text = ArrayListToString(ErrorCollection, True)


            'Disableing & Enabling The control
            FindInDirrectory.Enabled = True
            CancleBAckGroundWorker.Visible = False

            'Used for indication that the background worker is running
            'Stopiing ProgressBAr
            ToolStripProgressBar1.Visible = False
            'resetting The text so that it can not appeare in other process 
            ToolStripStatusLabel2.Text = ""
            ToolStripStatusLabel2.Visible = False
            CollectionArrayList.Clear()
            ErrorCollection.Clear()
        Else
            MsgBox("Error in cancellation of process!", MsgBoxStyle.Exclamation)
        End If

    End Sub

    

#End Region


#Region "  Function Used "

    'this function compare both files and it is assumed that both file Exist
    'error can be occure due to file permission
    '
    'it return 3 if path is equal
    'it return 2 if path is diffrent but file is same
    'it return 1 if file is same size but Not Equal
    'it return 0 if file is not equal and size is diffrent
    'it return -1 if error Occured

    Friend Function CompareFiles(ByVal FPOne As FileInfo, ByVal FPTwo As FileInfo, Optional ByRef Ex As Exception = Nothing) As Integer

        Try
            'first check file size
            'now create file info to compare length , if it is not equal then file are not same
            If (FPOne.Length <> FPTwo.Length) Then
                'size is diff. and file is not equal
                Return 0
            End If

            'when we search in a directory there will be one chance to get same path
            'So we are using this code when it is verified that file have same size
            'If user has selected the same file as file one and file two....
            If (FPOne.FullName.ToUpper = FPTwo.FullName.ToUpper) Then
                '"Files are the same. file one is file two."
                Return 3
            End If
        Catch ex
            'this can be file not found exception
            Return -1
        End Try


        Try
            Dim fileOneByte As Integer
            Dim fileTwoByte As Integer
            Dim fileOneStream As FileStream
            Dim fileTwoStream As FileStream



            ' Open a FileStream for each file.
            fileOneStream = New FileStream(FPOne.FullName, FileMode.Open, FileAccess.Read)
            fileTwoStream = New FileStream(FPTwo.FullName, FileMode.Open, FileAccess.Read)

            ' If the files are not the same length...
            'If (fileOneStream.Length <> fileTwoStream.Length) Then
            'fileOneStream.Close()
            'fileTwoStream.Close()
            '"Files are not the same length. they are not equal."
            'Return 4
            'End If


            ' Loop through bytes in the files until
            '  a byte in file one <> a byte in file two
            ' works untill  end of the file one is reached.

            Do
                ' Read one byte from each file.
                fileOneByte = fileOneStream.ReadByte()
                fileTwoByte = fileTwoStream.ReadByte()
                'MsgBox(fileOneByte.ToString + "  =   " + fileTwoByte.ToString)

                If fileOneByte <> fileTwoByte Then
                    ' Files are not equal; byte in file one <> byte in file two.
                    '"Files are not equal. contents are different."
                    'Closing both file stream
                    fileOneStream.Close()
                    fileTwoStream.Close()

                    'returning 1 which stand for same size but different content
                    Return 1
                End If
            Loop While (fileOneByte <> -1)

            'Close the FileStreams.
            fileOneStream.Close()
            fileTwoStream.Close()
            'Me.ResultsRichTextBox.Text = "Files are totaly equal."
            Return 2

        Catch Ex
            Return -1
        End Try

    End Function


    Friend Function FindDuplicateFileWorker(ByVal dir As String, ByVal filename As FileInfo, _
                                            Optional ByRef EventCollection As ArrayList = Nothing) As Boolean
        ' EventCollection = New ArrayList
        ' EventCollection.Clear()

        ' Some directories are not assesible like System Volume Informatiion
        Try

            'Scaning for current directory file
            For Each FileAtDir As String In System.IO.Directory.GetFiles(dir)
                'MsgBox(FileAtDir)


                'it return 3 if path is equal
                'it return 2 if path is diffrent but file is same
                'it return 1 if file is same size but Not Equal
                'it return 0 if file is not equal and size is diffrent
                'it return -1 if error Occured
                Dim Ex As New Exception
                Select Case CompareFiles(New FileInfo(FileAtDir), filename, Ex)
                    Case 3
                        Exit Select
                    Case 2
                        CollectionArrayList.Add(FileAtDir.ToString)
                        Exit Select
                    Case 1
                        Exit Select
                    Case 0
                        Exit Select
                    Case -1
                        EventCollection.Add(Ex.Message)
                        Exit Select
                    Case Else
                        EventCollection.Add("Unknown...")
                End Select

            Next

            'scaning for subDirectory 
            For Each DirectoryName As String In System.IO.Directory.GetDirectories(dir)
                Dim event1 As New ArrayList
                FindDuplicateFileWorker(DirectoryName, filename, event1)
                EventCollection.AddRange(event1)
            Next

        Catch ex As Exception
            EventCollection.Add(ex.GetType.ToString + "      " + ex.Message.ToString)
        End Try

    End Function

#End Region

    Private Sub CloneForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If BackgroundWorker1.IsBusy Then
            If MsgBox("Scanning process is working." + vbNewLineVER(2) + "Are you sure you want to close?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information, "Working..") <> MsgBoxResult.Yes Then
                e.Cancel = True
            End If
        End If
    End Sub


    Private Sub CloneForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'add handlers
        'handlers  for text boxs
        AddHandler Me.FirstFilePath.Enter, AddressOf TextBox_Enter
        AddHandler Me.FirstFilePath.Leave, AddressOf TextBox_Leave
        AddHandler Me.FirstFilePath.TextChanged, AddressOf TextBox_TextChanged

        'handlers  for text boxs
        AddHandler Me.SecondFilePath.Enter, AddressOf TextBox_Enter
        AddHandler Me.SecondFilePath.Leave, AddressOf TextBox_Leave
        AddHandler Me.SecondFilePath.TextChanged, AddressOf TextBox_TextChanged

        ''handlers  for text boxs
        'AddHandler Me.DirectoryName.Enter, AddressOf TextBox_Enter
        'AddHandler Me.DirectoryName.Leave, AddressOf TextBox_Leave
        'AddHandler Me.DirectoryName.TextChanged, AddressOf TextBox_TextChanged


        'now add drives to listview
        DirecoryTreeView.Nodes.Clear()
        With DirecoryTreeView
            For Each drv As IO.DriveInfo In IO.DriveInfo.GetDrives
                If IgnoreDrive(drv) Then Continue For
                Dim tr As New TreeNode
                tr.Text = drv.Name  '.TrimEnd("\")
                DirecoryTreeView.Nodes.Add(tr)
            Next
        End With

    End Sub



    '/*************************************************
    Private Sub DirecoryTreeView_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles DirecoryTreeView.AfterCheck

        ' MsgBox(e.Node.ToString)
        'i have to remove handlerbecause it will execute all nodes
        'but because i will trevers all chield so no need toremove
        'RemoveHandler TreeView1.AfterCheck, AddressOf TreeView1_AfterCheck
        If e.Node.Checked = True Then
            TreeNodeIsChecked(e.Node)
        Else
            TreeNodeIsUnchecked(e.Node)
        End If

    End Sub

    Private Function TreeNodeIsChecked(ByVal node As TreeNode) As Boolean
        For Each nd As TreeNode In node.Nodes
            nd.Checked = True
        Next
    End Function

    Private Function TreeNodeIsUnchecked(ByVal node As TreeNode) As Boolean
        If node.Parent Is Nothing Then
            Return True
        Else
            node.Parent.Checked = False
        End If
    End Function

    Private Sub DirecoryTreeView_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles DirecoryTreeView.AfterSelect

        'get path 

        With DirecoryTreeView.SelectedNode
            For Each Dir As DirectoryInfo In New DirectoryInfo(DirecoryTreeView.SelectedNode.FullPath).GetDirectories
                'scan if node is present
                For Each nd As TreeNode In .Nodes
                    If nd.Text.ToLower = Dir.Name.ToLower Then
                        GoTo alreadyExist
                    End If
                Next

                'here get that it is selected or not
                If Not .Parent Is Nothing Then
                    .Nodes.Add(Dir.Name).Checked = .Parent.Checked
                Else
                    .Nodes.Add(Dir.Name).Checked = False
                End If

alreadyExist:
            Next
        End With

    End Sub

    Private Sub DirecoryTreeView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DirecoryTreeView.DoubleClick
        On Error Resume Next
        DirecoryTreeView.SelectedNode.Expand()

    End Sub

    Private Sub CollectPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CollectPath.Click

        Dim CollectedPath As New ArrayList
        'thse are root drives of treeview so sending them one by one 
        For Each nd As TreeNode In DirecoryTreeView.Nodes
            StorePath(nd, CollectedPath)
        Next

        CollectedPathListview.Items.Clear()
        For Each Path As String In CollectedPath
            CollectedPathListview.Items.Add(Path)
        Next

    End Sub

    Private Function StorePath(ByVal node As TreeNode, ByRef CollectedPath As ArrayList) As Boolean

        If node.Checked Then
            CollectedPath.Add(node.FullPath)
            Return True
        End If

        For Each nd As TreeNode In node.Nodes
            StorePath(nd, CollectedPath)
        Next

    End Function
    '/********************************************

End Class
