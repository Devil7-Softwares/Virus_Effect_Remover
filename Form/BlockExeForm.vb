'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date : 13/01/2010                               '
'                                                                  '
'******************************************************************'

Imports Virus_Effect_Remover.My.Resources

Public Class BlockExeForm

#Region "Used Functions"
    Private Function Refress_blocked() As Boolean
        On Error Resume Next
        'Clearing the Box
        Ristrictedvalues.Items.Clear()

        'Scan & pach For Msconfig.exe Ristriction
        Dim registryKey As Microsoft.Win32.RegistryKey = My.Computer.Registry.CurrentUser
        Dim registryPath As String = "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun"

        'This will assign the actual hive key value
        registryKey = registryKey.OpenSubKey(registryPath)
        ' ----- This is the right key.
        For Each oneValue As String In registryKey.GetValueNames()
            If registryKey.GetValue(oneValue) <> "" Then
                Ristrictedvalues.Items.Add(oneValue + ":-> " + registryKey.GetValue(oneValue))
            Else
                Ristrictedvalues.Items.Add(oneValue + ":-> Value Data is Blank")
            End If
        Next oneValue
    End Function
#End Region

#Region "Form Event"

    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        Refress_blocked()
    End Sub

    Private Sub AddFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddFile.Click

        If TextBoxIsIdle(AddBox) Then Return

        If AddBox.Text = "" Then
            MsgBox("Enter file or virus name with Extension")
            Return
        End If
        Dim i As Integer = 1
        For i = 1 To 1000
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun", i, Nothing) Is Nothing Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun", i, AddBox.Text)
                Refress_blocked()
                Return
            End If
        Next

    End Sub

    Private Sub AddBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AddBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddFile_Click(sender, Nothing)
        End If
    End Sub

    Private Sub BrowseFileBlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseFileBlock.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.Filter = "Program files (*.exe)|*.exe|All files (*.*)|*.*"
        OpenFileDialog.Multiselect = False
        OpenFileDialog.FileName = ""
        If OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            AddBox.Text = My.Computer.FileSystem.GetName(OpenFileDialog.FileName.ToString)
        End If
    End Sub

    Private Sub DelFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelFile.Click
        On Error Resume Next
        'Scan & pach For Msconfig.exe Ristriction
        Dim registryKey As Microsoft.Win32.RegistryKey = My.Computer.Registry.CurrentUser
        Dim registryPath As String = "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun"
        'MsgBox(Ristrictedvalues.SelectedItem)
        'This will assign the actual hive key value
        registryKey = registryKey.OpenSubKey(registryPath, True)

        ' ----- This is the right key.
        'MsgBox(registryKey.ToString)

        'geting Key Name
        Dim valuename() As String = Ristrictedvalues.SelectedItem.ToString.Split(":-> ")
        'MsgBox(valuename(0))
        registryKey.DeleteValue(valuename(0))
        registryKey.Close()
        Refress_blocked()

        Exit Sub

err:

    End Sub

    Private Sub allow_status_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles allow_status.Click
        On Error Resume Next

        If My.Computer.Registry.GetValue(HKCUPolicyExplorerKey, "DisallowRun", Nothing) = 1 Then
            My.Computer.Registry.SetValue(HKCUPolicyExplorerKey, "DisallowRun", 0)
            'MsgBox("found")
            allow_status.Text = "Start Ristriction"
        Else
            My.Computer.Registry.SetValue(HKCUPolicyExplorerKey, "DisallowRun", 1)
            allow_status.Text = "Stop Ristriction"
            'MsgBox("not")
        End If
       
        If MsgBox("You must reboot your system to take effect.", _
                  MsgBoxStyle.Information Or MsgBoxStyle.OkCancel Or _
                  MsgBoxStyle.DefaultButton2, "Important") _
                  = MsgBoxResult.Ok Then
            System.Diagnostics.Process.Start("ShutDown", "-t 0 /r")
        End If

    End Sub

    Private Sub BlockExeForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'handlers  for text boxs
        AddHandler Me.AddBox.Enter, AddressOf TextBox_Enter
        AddHandler Me.AddBox.Leave, AddressOf TextBox_Leave
        AddHandler Me.AddBox.TextChanged, AddressOf TextBox_TextChanged


        'Block Virus Section
        If My.Computer.Registry.GetValue _
        ("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
         "DisallowRun", Nothing) = 1 Then 'right now it is allowed
            allow_status.Text = "Stop Restriction"
        Else
            allow_status.Text = "Start Restriction"
        End If
    End Sub

#End Region


End Class