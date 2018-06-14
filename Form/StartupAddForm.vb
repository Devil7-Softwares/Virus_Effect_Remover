'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date : 07/12/2009                               '
'                                                                  '
'******************************************************************'
Option Explicit Off

Public Class StartupAddForm

    ' Routine to create "mylink.lnk" on the Windows desktop.

    Sub CreateShortCut()
        On Error GoTo err

        'return if invalid name
        If ShortcutNameBox.Text = "" Then
            MsgBox("Shortcutname not defined.", MsgBoxStyle.Information, "Error")
            ShortcutNameBox.Focus()
            Me.Text = "Add Startup  : Failed!"
            Return
        End If

        If My.Computer.FileSystem.DirectoryExists(WorkingDir.Text) = False Then
            WorkingDir.Text = "C:\Windows"
        End If

        ' Make sure variables are declared.
        Dim objShell, strDesktopPath, objLink
        objShell = CreateObject("WScript.Shell")


        'Shortcut Placing Location
        If StartupFolder.Checked = True Then
            strDesktopPath = objShell.SpecialFolders("Startup")

            If My.Computer.FileSystem.FileExists(TargetFileLocation.Text.ToString) Then

                objLink = objShell.CreateShortcut(strDesktopPath & "\" _
                & ShortcutNameBox.Text & ".lnk")
                objLink.TargetPath = TargetFileLocation.Text.ToString
                objLink.WorkingDirectory = WorkingDir.Text.ToString
                objLink.Description = "" + TextBox1.Text
                objLink.WindowStyle = 1
                'objLink.Arguments = "c:\windows\tips.txt"
                objLink.Save()
                Me.Text = "Add Startup  : Added!"
                Return
            Else
                MsgBox("File Missing or path Error.", MsgBoxStyle.Information, "Error")
                Return
            End If
        ElseIf CommonStartupfolder.Checked = True Then
            strDesktopPath = objShell.SpecialFolders("AllUsersStartup")

            If My.Computer.FileSystem.FileExists(TargetFileLocation.Text.ToString) Then
                objLink = objShell.CreateShortcut(strDesktopPath & "\" _
                & ShortcutNameBox.Text & ".lnk")
                objLink.TargetPath = TargetFileLocation.Text.ToString
                objLink.WorkingDirectory = WorkingDir.Text.ToString
                objLink.Description = "" + TextBox1.Text
                objLink.WindowStyle = 1
                'objLink.Arguments = "c:\windows\tips.txt"
                objLink.Save()
                Me.Text = "Add Startup  : Added!"
                Return
            Else
                MsgBox("File Missing or path Error.", MsgBoxStyle.Information, "Error")
                Me.Text = "Add Startup  : Failed!"
                Return
            End If

            'for registry insertion
        ElseIf HKCUKey.Checked = True Then
            If My.Computer.FileSystem.FileExists(TargetFileLocation.Text.ToString) Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", ShortcutNameBox.Text, TargetFileLocation.Text.ToString)
                Me.Text = "Add Startup  : Added!"
                Return
            Else
                MsgBox("File Not Found.", MsgBoxStyle.Information)
                Me.Text = "Add Startup  : Failed!"
                Return
            End If

        ElseIf HKLMKey.Checked = True Then
            If My.Computer.FileSystem.FileExists(TargetFileLocation.Text.ToString) Then
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run", ShortcutNameBox.Text, TargetFileLocation.Text.ToString)
                Me.Text = "Add Startup  : Added!"
                Return
            Else
                MsgBox("File Not Found.", MsgBoxStyle.Information)
                Me.Text = "Add Startup  : Failed!"
                Return
            End If
        Else
            MsgBox("Shortcut Placing Location Not Defined.", MsgBoxStyle.Information, "Error")
            Me.Text = "Add Startup  : Failed!"
            Return
        End If
        Exit Sub
err:
        MsgBox("Error During Process.", MsgBoxStyle.Information, "Error")
        Me.Text = "Add Startup  : Failed!"
        Return



    End Sub

    Private Sub BrowseStartupFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseStartupFile.Click
        On Error Resume Next
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Multiselect = False

        If Not OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Return
        End If

        Dim flinfo As New FileInfo(OpenFileDialog1.FileName)
        TargetFileLocation.Text = flinfo.FullName
        WorkingDir.Text = flinfo.Directory.FullName  'My.Computer.FileSystem.GetParentPath(OpenFileDialog1.FileName.ToString).ToString

        ShortcutNameBox.Text = Mid(flinfo.Name, 1, flinfo.Name.Length - flinfo.Extension.Length)

    End Sub

    Private Sub TargetFolderLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TargetFolderLocation.Click
        Dim FolderBrowserDialog1 As New FolderBrowserDialog
        FolderBrowserDialog1.ShowDialog()
        WorkingDir.Text = FolderBrowserDialog1.SelectedPath.ToString
        If My.Computer.FileSystem.DirectoryExists(WorkingDir.Text) = False Then
            WorkingDir.Text = "C:\Windows"
        End If
    End Sub

    Private Sub AddStartUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStartUp.Click
        CreateShortCut()
        StartupForm.GetstartupListNew()
    End Sub

End Class