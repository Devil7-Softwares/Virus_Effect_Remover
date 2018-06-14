'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date : 26/12/2009                               '
'                                                                  '
'******************************************************************'
Public Class Sys_Hidden_Show_Form

    Private Sub CopyFilePathToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyFilePathToolStripMenuItem.Click
        Try
            Clipboard.SetText(ListView1.Items(ListView1.SelectedIndices(0)).SubItems(6).Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try


    End Sub

    Private Sub CopyFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyFileToolStripMenuItem.Click
        Try
            CopyToClipboard(ListView1.Items(ListView1.SelectedIndices(0)).SubItems(6).Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try


    End Sub

    Private Function CopyToClipboard(ByVal FileName As String) As Boolean
        'check for file or folder exist
        Try
            If System.IO.File.Exists(FileName) Or System.IO.Directory.Exists(FileName) Then
                Dim FilePaths As New System.Collections.Specialized.StringCollection
                FilePaths.Add(FileName)
                Clipboard.SetFileDropList(FilePaths)
                Return True
            Else
                Return False
            End If
        Catch
            Return False
        End Try
    End Function

    Private Sub DeleteFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteFileToolStripMenuItem.Click
        Try
            Dim FName As String = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(6).Text

            If System.IO.File.Exists(FName) Then
                Dim exs As New Exception
                If Not DeleteFile(New FileInfo(FName), SendToRecycleBinToolStripMenuItem.Checked, ForceToDeleteToolStripMenuItem.Checked, True, , exs) Then
                    MsgBox(exs.Message, MsgBoxStyle.Exclamation)
                    ToolStripButton1_Click(Nothing, Nothing)
                    Return
                End If
            ElseIf System.IO.Directory.Exists(FName) Then
                Dim exs As New Exception
                If Not DeleteDirectory(New DirectoryInfo(FName), SendToRecycleBinToolStripMenuItem.Checked, ForceToDeleteToolStripMenuItem.Checked, True, , exs) Then
                    MsgBox(exs.Message, MsgBoxStyle.Exclamation)
                    ToolStripButton1_Click(Nothing, Nothing)
                    Return
                End If
            Else
                MsgBox("Path does not exist.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        ToolStripButton1_Click(Nothing, Nothing)

    End Sub

    Private Sub LocateFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocateFileToolStripMenuItem.Click
        Try
            Dim FName As String = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(6).Text

            If System.IO.File.Exists(FName) Then
                Dim FileName As New IO.FileInfo(FName)
                'FileName.Attributes = IO.FileAttributes.Normal
                System.Diagnostics.Process.Start(FileName.DirectoryName)
            ElseIf System.IO.Directory.Exists(FName) Then
                Dim folderName As New IO.DirectoryInfo(FName)
                'folderName.Attributes = IO.FileAttributes.Normal
                System.Diagnostics.Process.Start(folderName.Parent.FullName)

            Else
                MsgBox("Path does not exist.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub MakeAttributeNormalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MakeAttributeNormalToolStripMenuItem.Click
        Try
            Dim FName As String = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(6).Text

            If System.IO.File.Exists(FName) Then
                Dim FileName As New IO.FileInfo(FName)
                'add NTFS security
                NTFS.AddFullcontrolToFile(FName)
                FileName.Attributes = IO.FileAttributes.Normal
            ElseIf System.IO.Directory.Exists(FName) Then
                Dim folderName As New IO.DirectoryInfo(FName)
                NTFS.AddFullControlToDirectory(FName)
                folderName.Attributes = IO.FileAttributes.Normal
            Else
                MsgBox("Path does not exist.", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Exclamation)
        End Try
        ToolStripButton1_Click(Nothing, Nothing)
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'setting form checklist

        Try
            SendToRecycleBinToolStripMenuItem.Checked = My.Computer.Registry.GetValue _
                                                        (My.Resources.VERKey + "\syshide", "SendToRecycleBin", 0)
            ForceToDeleteToolStripMenuItem.Checked = My.Computer.Registry.GetValue _
                                                        (My.Resources.VERKey + "\syshide", "ForceToDelete", 0)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

        ToolStripButton1_Click(Nothing, Nothing)
    End Sub


#Region "File And Folder from dir "


    'by this function we collect all SystHide file
    Private Function GetFilesWithAttribute(ByVal DirName As String, ByVal AttributeOfFile As IO.FileAttributes) As ArrayList

        Try
            Dim FileCollection As New ArrayList
            Dim Dir As New System.IO.DirectoryInfo(DirName)
            For Each item As System.IO.FileInfo In Dir.GetFiles

                If (item.Attributes And AttributeOfFile) = AttributeOfFile Then
                    FileCollection.Add(item)
                End If


                'If (item.Attributes And IO.FileAttributes.Hidden) = IO.FileAttributes.Hidden Then
                'If (item.Attributes And IO.FileAttributes.System) = IO.FileAttributes.System Then
                'FileCollection.Add(item)
                'End If
                'End If

            Next
            Return FileCollection

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return Nothing
        End Try

    End Function

    'By this function we collect all system + hidden folder
    Private Function GetFolderWithAttribute(ByVal DirName As String, ByVal AttributeOfFile As IO.FileAttributes) As ArrayList

        Try
            Dim FileCollection As New ArrayList
            Dim Dir As New System.IO.DirectoryInfo(DirName)
            For Each item As System.IO.DirectoryInfo In Dir.GetDirectories

                If (item.Attributes And AttributeOfFile) = AttributeOfFile Then
                    FileCollection.Add(item)
                End If

                ' If (item.Attributes And IO.FileAttributes.Hidden) = IO.FileAttributes.Hidden Then
                'If (item.Attributes And IO.FileAttributes.System) = IO.FileAttributes.System Then
                ' 'FileCollection.Add(item)
                'End If
                '  End If

            Next
            Return FileCollection

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return Nothing
        End Try

    End Function

    Private Sub BuildListOfSpecificAttribute(ByVal dir As String, ByVal AttributeOfTarget As IO.FileAttributes)

        Dim FileCollection As New ArrayList
        Dim FolderCollection As New ArrayList

        'getting list of root drive
        FileCollection = GetFilesWithAttribute(dir, AttributeOfTarget)
        FolderCollection = GetFolderWithAttribute(dir, AttributeOfTarget)
        'sending these file list to list in list box
        AddToList(dir, FileCollection, FolderCollection, Me.ListView1)


    End Sub

    Private Function AddToList(ByVal Dir As String, ByVal FileCollection As ArrayList, ByVal FolderCollection As ArrayList, ByRef ListView1 As ListView) As Boolean
        'Gr is the groupname of current dir 
        Dim gr As New ListViewGroup
        gr.Header = Dir
        gr.Name = Dir
        ListView1.Groups.Add(gr)

        'adding files in this group
        For Each file As System.IO.FileInfo In FileCollection
            Dim item As New ListViewItem
            item.BackColor = Color.BlanchedAlmond
            item.Text = file.Name
            item.SubItems.Add("File")
            item.SubItems.Add(file.Extension)
            item.SubItems.Add(ByteSizeOptimaized(file.Length))
            item.SubItems.Add(file.Attributes.ToString)
            item.SubItems.Add("")
            item.SubItems.Add(file.FullName)

            'now add this item to listview with this directory group
            ListView1.Items.Add(item).Group = ListView1.Groups(ListView1.Groups.Count - 1)

        Next

        'adding folder

        For Each folder As System.IO.DirectoryInfo In FolderCollection
            Dim item As New ListViewItem
            item.BackColor = Color.Beige
            item.Text = folder.Name
            item.SubItems.Add("Folder")
            item.SubItems.Add("")
            item.SubItems.Add("")
            item.SubItems.Add(folder.Attributes.ToString)
            item.SubItems.Add("")
            item.SubItems.Add(folder.FullName)

            ListView1.Items.Add(item).Group = ListView1.Groups(ListView1.Groups.Count - 1)
        Next


    End Function

#End Region

#Region "Copy , paste from and to clipboard"

    'Retrive text from Clipboard

    Private Function GetClipboardText() As String
        Dim objClipboard As IDataObject = Clipboard.GetDataObject()
        With objClipboard
            If .GetDataPresent(DataFormats.Text) Then Return _
               .GetData(DataFormats.Text)
        End With
        Return Nothing
    End Function


#End Region

    Private Sub GetProcessFilePropertiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetProcessFilePropertiesToolStripMenuItem.Click
        If NothingSelectedInlistView(ListView1) Then Return
        Try
            win32.PropertyShow.ShowProperties(ListView1.Items(ListView1.SelectedIndices(0)).SubItems(6).Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub SendToRecycleBinToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendToRecycleBinToolStripMenuItem.Click
        Try
            SendToRecycleBinToolStripMenuItem.Checked = Not SendToRecycleBinToolStripMenuItem.Checked
            My.Computer.Registry.SetValue(My.Resources.VERKey + "\syshide", "SendToRecycleBin", SendToRecycleBinToolStripMenuItem.Checked, RegistryValueKind.DWord)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ForceToDeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForceToDeleteToolStripMenuItem.Click
        Try
            ForceToDeleteToolStripMenuItem.Checked = Not ForceToDeleteToolStripMenuItem.Checked
            My.Computer.Registry.SetValue(My.Resources.VERKey + "\syshide", "ForceToDelete", ForceToDeleteToolStripMenuItem.Checked, RegistryValueKind.DWord)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        ListView1.Items.Clear()
        Dim AttributeOfTarget As IO.FileAttributes = FileAttributes.Hidden + FileAttributes.System
        'setting nothing attribute will list all files and folder
        'now collect selected file and folder attribute

        Try
            Dim dir As String
            dir = System.Environment.GetEnvironmentVariable("systemdrive")
            BuildListOfSpecificAttribute(dir + "\", AttributeOfTarget)
            dir = System.Environment.GetEnvironmentVariable("systemroot")
            BuildListOfSpecificAttribute(dir, AttributeOfTarget)
            BuildListOfSpecificAttribute(dir + "\system32", AttributeOfTarget)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub

    Private Sub ContextMenuStripForSysHide_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStripForSysHide.Opening
        If ListViewIsEmptyOrNotSelected(ListView1, False) Then
            e.Cancel = True
        End If
    End Sub
End Class