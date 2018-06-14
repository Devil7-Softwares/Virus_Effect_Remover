'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date : 07/12/2009                               '
'                                                                  '
'******************************************************************'

Imports System
Imports System.IO

Public Class FileProtectorMainForm

#Region "   form events "

    Private Sub FileAttributeApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileAttributeApply.Click
        'adding a watch to this function

        If TextBoxIsIdle(TextBox1, True) Then Return


        Dim owatch As New Stopwatch
        owatch.Start()

        'collect attribute
        Dim fAttrib As FileAttributes
        fAttrib = FileAttributes.Normal

        Try
            'Nomalizing file attribute
            fAttrib = FileAttributes.Normal
            If FileAttributeReadOnly.Checked = True Then
                fAttrib += FileAttributes.ReadOnly
            End If

            If FileAttributeSystem.Checked = True Then
                fAttrib += FileAttributes.System
            End If

            If FileAtttributeHidden.Checked = True Then
                fAttrib += FileAttributes.Hidden
            End If

            If FileAttributeArchive.Checked = True Then
                fAttrib += FileAttributes.Archive
            End If

            If FileAttributeCompressed.Checked = True Then
                fAttrib += FileAttributes.Compressed
            End If

            If FileAttributeEncripted.Checked = True Then
                fAttrib += FileAttributes.Encrypted
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        'here collected attribute is Fatt

        'If TextBox1.Text.Contains(",") Then
        Dim str1() As String = TextBox1.Text.Split("|")
        'End If


        ListBox1.Items.Clear()
        ListboxSeperator()
        ListBox1.Items.Add("Attribute selected : " + fAttrib.ToString)
        ListboxSeperator()



        For Each str2 As String In str1
            str2 = str2.Trim
            'for last blanck...
            If str2 = "" Then
                Continue For
            End If


            'Now get File\Directory Which you want to reset
            If My.Computer.FileSystem.FileExists(str2) Then
                '
                'send this to normalize
                'get file info
                Dim finfo As New FileInfo(str2)
                Dim Exs As New Exception
                If Not SetFileAttribute(finfo, fAttrib, Exs) Then
                    ListBox1.Items.Add(Exs.Message + "  - Failed to set attribute.")
                Else
                    ListBox1.Items.Add("Successfully added Attribute.  " + finfo.FullName)
                End If
                Continue For
            ElseIf My.Computer.FileSystem.DirectoryExists(str2) Then
                'set folder attribute to given atribute
                Dim DirInfo As New DirectoryInfo(str2)
                Dim exp As New Exception
                Dim EventLog As New ArrayList
                SetDirAttribute(DirInfo, fAttrib, EventLog, exp)

                For Each lin As String In EventLog
                    ListBox1.Items.Add(lin)
                Next

                ListboxSeperator()
                ListBox1.Items.Add("Operation done in " + DirInfo.FullName)
                ListboxSeperator()

                Continue For
            Else
                ListBox1.Items.Add("Path is not correct. : " + str2)
            End If
        Next
        owatch.Stop()
        ListboxSeperator()
        ListBox1.Items.Add("Time elapsed (in Milli Seconds)  :  " + owatch.ElapsedMilliseconds.ToString)
        ListboxSeperator()
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub ListboxSeperator()
        ListBox1.Items.Add("                  ")
        ListBox1.Items.Add("---------------------------------------------------------------------------------------------------------------")
        ListBox1.Items.Add("                  ")
    End Sub

    'browse file or folder
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If FileRadioButton.Checked Then
            Dim OpenFileDialog1 As New OpenFileDialog
            OpenFileDialog1.ShowDialog()
            'TextBox1.Text = OpenFileDialog1.FileName
            Dim files As String() = OpenFileDialog1.FileNames
            TextBox1.Text = String.Empty
            For Each fl As String In files
                TextBox1.Text += fl + "|"
            Next

        Else
            Dim FolderBrowserDialog1 As New FolderBrowserDialog
            FolderBrowserDialog1.ShowDialog()
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
        End If

        'here we are dealing with morte than one files so it will  be ok to reset all checkbox
        ResetCheckBox()

    End Sub

#End Region

#Region "    function used    "

    'this function return false if false
    Private Function SetFileAttribute(ByVal finfo As FileInfo, ByVal FileAttributeR As FileAttributes, _
                                      Optional ByRef Ex As Exception = Nothing) As Boolean
        Try
            'setting file attribute as recieved
            finfo.Attributes = FileAttributeR
            Return True
        Catch Ex
            'MsgBox(Exception.Message)
            Return False
        End Try
    End Function

    'this function will set all files attribute and all directory attribute to as selected.

    Private Function SetDirAttribute(ByVal DirInfo As DirectoryInfo, ByVal FileAttributeR As FileAttributes, _
                                       Optional ByRef EventLog As ArrayList = Nothing, Optional ByRef Ex As Exception = Nothing) As Boolean

        Try
            'setting attribute as recieved
            DirInfo.Attributes = FileAttributeR
        Catch Ex
            'if Here Exception occure , that means either NTFS Permission is not present to current Domain and User
            'or media is write protected
            EventLog.Add("File inside " + DirInfo.FullName + "  will not be changed. Error : " + Ex.Message)
            Return False
        End Try

        'here directory is reseted to current fileattribute
        'now do it with all files of this dir
        For Each Finfo As FileInfo In DirInfo.GetFiles
            Dim Exp As New Exception
            If SetFileAttribute(Finfo, FileAttributeR, Exp) Then
                EventLog.Add("Successfully added Attribute.  " + Finfo.FullName)
            Else
                EventLog.Add(Exp.Message + "  - Failed to set attribute.")
            End If
        Next


        'now get other dir in this dir
        For Each Dinfo As DirectoryInfo In DirInfo.GetDirectories
            Dim Exp As New Exception
            Dim Event1 As New ArrayList
            If Not SetDirAttribute(Dinfo, FileAttributeR, Event1, Exp) Then
                MsgBox("File inside " + Dinfo.FullName + " will not changed.")
            End If
            EventLog.AddRange(Event1)
        Next

        Return True

    End Function

    'reset all check box to false
    Private Sub ResetCheckBox()
        'Making all block unchecked
        FileAttributeReadOnly.Checked = False
        FileAtttributeHidden.Checked = False
        FileAttributeArchive.Checked = False
        FileAttributeSystem.Checked = False
        FileAttributeCompressed.Checked = False
       FileAttributeEncripted.Checked = False
    End Sub

    'this function is used to check and uncheck attribute box[s] 
    'which provide information about file's current attribute
    'currentlly we are not using this function because form now we are dealing 
    'with multy file selecion and every file has same attribute is not neccessory
    Private Sub FSelected(ByVal aFile As FileInfo)
        'seting file name 
        Try
            If My.Computer.FileSystem.FileExists(aFile.FullName) Then
                'getting attribute of file
                Dim afile_attrib() As String = aFile.Attributes.ToString.Split(",")

                'first clear all check box
                ResetCheckBox()

                'now from here check all active attributes
                For Each item As String In afile_attrib
                    item = item.TrimStart(" ")
                    Select Case item.ToLower
                        Case "readonly"
                            FileAttributeReadOnly.Checked = True
                        Case "hidden"
                            FileAtttributeHidden.Checked = True
                        Case "archive"
                            FileAttributeArchive.Checked = True
                        Case "system"
                            FileAttributeSystem.Checked = True
                        Case "compressed"
                            FileAttributeCompressed.Checked = True
                        Case "encripted"
                            FileAttributeEncripted.Checked = True
                    End Select
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

#End Region

    Private Sub FileProtectorMainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TextBox1
        'handlers  for text boxs
        AddHandler Me.TextBox1.Enter, AddressOf TextBox_Enter
        AddHandler Me.TextBox1.Leave, AddressOf TextBox_Leave
        AddHandler Me.TextBox1.TextChanged, AddressOf TextBox_TextChanged
    End Sub
End Class
