'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date : 07/12/2009                               '
'                                                                  '
'******************************************************************'

Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports Virus_Effect_Remover.My.Resources



Public Class WindowCleanerForm
    'this function will collect fooder to clean
    Private Function Collectfolders() As ArrayList
        'error controls 
        On Error Resume Next

        ''collect folders as directory info
        Dim Dirs As New ArrayList
        If TempCh.Checked Then
            If System.Environment.GetEnvironmentVariable("TMP").ToLower = _
            System.Environment.GetEnvironmentVariable("TEMP").ToLower Then
                Dirs.Add(New IO.DirectoryInfo(System.Environment.GetEnvironmentVariable("Temp")))
            Else
                Dirs.Add(New IO.DirectoryInfo(System.Environment.GetEnvironmentVariable("Temp")))
                Dirs.Add(New IO.DirectoryInfo(System.Environment.GetEnvironmentVariable("TMP")))
            End If

            Dirs.Add(New IO.DirectoryInfo(System.Environment.GetEnvironmentVariable("systemdrive") + "\TEMP"))
            Dirs.Add(New IO.DirectoryInfo(System.Environment.GetEnvironmentVariable("systemdrive") + "\TMP"))

        End If

        If InternetCatchCh.Checked Then
            Dirs.Add(New IO.DirectoryInfo(System.Environment.GetFolderPath(Environment.SpecialFolder.InternetCache)))
        End If

        If HistoryCh.Checked Then
            Dirs.Add(New IO.DirectoryInfo(System.Environment.GetFolderPath(Environment.SpecialFolder.History)))
        End If

        If CookiesCh.Checked Then
            Dirs.Add(New IO.DirectoryInfo(System.Environment.GetFolderPath(Environment.SpecialFolder.Cookies)))
        End If

        If RecentCh.Checked Then
            Dirs.Add(New IO.DirectoryInfo(System.Environment.GetFolderPath(Environment.SpecialFolder.Recent)))
        End If

        If WindowsTempCh.Checked Then
            ' Dirs.Add(New IO.DirectoryInfo(System.Environment.GetEnvironmentVariable("Windir") + "\temp"))
            Dirs.Add(New IO.DirectoryInfo(windir + "\TEMP"))
            Dirs.Add(New IO.DirectoryInfo(windir + "\TMP"))
        End If

        If WindowsPrefetchCh.Checked Then
            Dirs.Add(New IO.DirectoryInfo(System.Environment.GetEnvironmentVariable("Windir") + "\Prefetch"))
        End If

        Return Dirs

    End Function


    Private Sub WinCleanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WinCleanButton.Click

        'first coferm
        If Not MsgBox("Click [OK] to clean selected items.", MsgBoxStyle.Information Or MsgBoxStyle.OkCancel, "Confirm Please.") = MsgBoxResult.Ok Then
            MsgBox("Action cancled by User.", MsgBoxStyle.Information)
            Return
        End If

        'no need for try 
        On Error Resume Next
        Dim FoldersToClean As New ArrayList
        FoldersToClean.AddRange(Collectfolders())

       
        If FoldersToClean.Count <= 0 And RecycleBinCh.Checked = False Then
            MsgBox("Nothing selected to clean.", MsgBoxStyle.Information)
            Return
        End If


        'For Each item As DirectoryInfo In FoldersToClean
        '    MsgBox(item.FullName)
        'Next

        'now send all selected folder to clean
        If FoldersToClean.Count > 0 Then
            CleanWindowsfolder(FoldersToClean)
        End If

        'here check if recycle bin is checked or not
        If RecycleBinCh.Checked Then
            RecycleBin.EmptyRecycleBin()
        End If

        'Here  display msgbox to tell that all folders are clean
        MsgBox("All selected items & folders have been cleaned.", MsgBoxStyle.Information)

    End Sub


    Private Sub WindowCleanerForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        On Error Resume Next
        'this piece of code initially set all checkbox to its optimal values

        If Not (My.Computer.Registry.GetValue(VERKey + "\WinClean", "FEntry", 0) = 1) Then
            My.Computer.Registry.SetValue(VERKey + "\WinClean", "FEntry", 1, RegistryValueKind.DWord)
            TempCh.Checked = True
            InternetCatchCh.Checked = True
            HistoryCh.Checked = True
            CookiesCh.Checked = True
            RecentCh.Checked = True
            WindowsTempCh.Checked = True
            WindowsPrefetchCh.Checked = False
            RecycleBinCh.Checked = True
            'say your user to select their folders
            MsgBox("If you are using this function for the first time." + vbNewLineVER(2) + _
                   "Please select the folder(s) &/or item(s) that you want cleaned.", MsgBoxStyle.Information)
        End If



        TempCh.Checked = My.Computer.Registry.GetValue(VERKey + "\WinClean", "TempCh", 1)
        InternetCatchCh.Checked = My.Computer.Registry.GetValue(VERKey + "\WinClean", "InternetCatchCh", 1)
        HistoryCh.Checked = My.Computer.Registry.GetValue(VERKey + "\WinClean", "HistoryCh", 1)
        CookiesCh.Checked = My.Computer.Registry.GetValue(VERKey + "\WinClean", "CookiesCh", 1)
        RecentCh.Checked = My.Computer.Registry.GetValue(VERKey + "\WinClean", "RecentCh", 1)
        WindowsTempCh.Checked = My.Computer.Registry.GetValue(VERKey + "\WinClean", "WindowsTempCh", 1)
        WindowsPrefetchCh.Checked = My.Computer.Registry.GetValue(VERKey + "\WinClean", "WindowsPrefetchCh", 0)
        RecycleBinCh.Checked = My.Computer.Registry.GetValue(VERKey + "\WinClean", "RecycleBinCh", 0)

    End Sub


    Public Sub CleanWindowsfolder(ByVal FoldersToClean As ArrayList)
        On Error Resume Next

        'there was a bug in this function when progressbar value is greater that 100
        'then sub crashes ....

        ' MsgBox("before : " + FoldersToClean.Count.ToString)

        ' RemoveCloneImageInArrayList(FoldersToClean, FoldersToClean)
        ' MsgBox("after : " + FoldersToClean.Count.ToString)


        'For Each item As DirectoryInfo In FoldersToClean
        '    MsgBox(item.FullName)
        'Next

        ProgressBar1.Step = 100 / FoldersToClean.Count

        'start cleaning 
        'make marker reset and visible
        ProgressBar1.Value = 0

        For Each folder As DirectoryInfo In FoldersToClean
            ' MsgBox(folder.FullName)
            DeleteAllFilesInDir(folder, F2del.Checked, Form1.EnableProcessFilter.Checked, _
                                 True, False, SendToRclCh.Checked, , , True)
            'MsgBox(folder.FullName)
            ProgressBar1.Value = ProgressBar1.Value + ProgressBar1.Step
        Next

        'hide progress bar
        ProgressBar1.Value = 0
        'ProgressBar2.Style = ProgressBarStyle.Blocks



    End Sub

#Region "   selected folders"


    Private Sub TempCh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TempCh.Click
        My.Computer.Registry.SetValue(VERKey + "\WinClean", "TempCh", TempCh.Checked, RegistryValueKind.DWord)
    End Sub
    Private Sub InternetCatchCh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles InternetCatchCh.Click
        My.Computer.Registry.SetValue(VERKey + "\WinClean", "InternetCatchCh", InternetCatchCh.Checked, RegistryValueKind.DWord)
    End Sub
    Private Sub HistoryCh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HistoryCh.Click
        My.Computer.Registry.SetValue(VERKey + "\WinClean", "HistoryCh", HistoryCh.Checked, RegistryValueKind.DWord)
    End Sub
    Private Sub CookiesCh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CookiesCh.Click
        My.Computer.Registry.SetValue(VERKey + "\WinClean", "CookiesCh", CookiesCh.Checked, RegistryValueKind.DWord)
    End Sub
    Private Sub RecentCh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RecentCh.Click
        My.Computer.Registry.SetValue(VERKey + "\WinClean", "RecentCh", RecentCh.Checked, RegistryValueKind.DWord)
    End Sub
    Private Sub WindowsTempCh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles WindowsTempCh.Click
        My.Computer.Registry.SetValue(VERKey + "\WinClean", "WindowsTempCh", WindowsTempCh.Checked, RegistryValueKind.DWord)
    End Sub
    Private Sub WindowsPrefetchCh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles WindowsPrefetchCh.Click
        My.Computer.Registry.SetValue(VERKey + "\WinClean", "WindowsPrefetchCh", WindowsPrefetchCh.Checked, RegistryValueKind.DWord)
    End Sub
    Private Sub RecycleBinCh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RecycleBinCh.Click
        My.Computer.Registry.SetValue(VERKey + "\WinClean", "RecycleBinCh", RecycleBinCh.Checked, RegistryValueKind.DWord)
    End Sub

#End Region


    Private Sub SendToRclCh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SendToRclCh.Click
        If SendToRclCh.Checked Then
            If MsgBox("Sending deleted file(s) to Recycle Bin will be a very slow process." + vbNewLine + _
                      "If error occure during file deletion, It will also prompt Error Message." + vbNewLine + vbNewLine + _
                      "Would you like to send these file to Recycle Bin?", _
                      MsgBoxStyle.OkCancel Or MsgBoxStyle.Information, "Information") <> MsgBoxResult.Ok Then
                SendToRclCh.Checked = False
                Return
            End If
        Else
            'do nothing 
        End If
    End Sub

    Private Sub RecycleBinCh_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecycleBinCh.CheckedChanged
        If Me.RecycleBinCh.Checked Then
            Me.SendToRclCh.Checked = False
            Me.SendToRclCh.Enabled = False
        Else
            Me.SendToRclCh.Enabled = True
        End If
       

    End Sub
End Class


Public Class RecycleBin
    <DllImport("shell32.dll", SetLastError:=True)> _
   Private Shared Function SHEmptyRecycleBin(ByVal hWnd As IntPtr, ByVal pszRootPath As String, ByVal dwFlags As UInteger) As Integer
    End Function

    '     No dialog box confirming the deletion of the objects will be displayed.
    Private Const SHERB_NOCONFIRMATION As Integer = &H1
    '     No dialog box indicating the progress will be displayed. 
    Private Const SHERB_NOPROGRESSUI As Integer = &H2
    '     No sound will be played when the operation is complete. 
    Private Const SHERB_NOSOUND As Integer = &H4

    Public Shared Sub EmptyRecycleBin()
        EmptyRecycleBin(String.Empty)
    End Sub

    Private Shared Sub EmptyRecycleBin(ByVal rootPath As String)
        Dim hresult As Integer = SHEmptyRecycleBin(IntPtr.Zero, rootPath, SHERB_NOCONFIRMATION Or SHERB_NOPROGRESSUI Or SHERB_NOSOUND)
        'System.Diagnostics.Debug.Write(hresult)
    End Sub
End Class