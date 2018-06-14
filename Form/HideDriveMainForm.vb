'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date :10/12/2009                                '
'                                                                  '
'******************************************************************'
Public Class HideDriveMainForm

#Region "   Form Event  "

    Private Sub ApplyChangeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyChangeButton.Click

        If Not SetNoDrive(ListView1) Then
            MsgBox("Some thing wrong.", MsgBoxStyle.Exclamation)
        Else
            MsgBox("Selected drives are hidden." + vbNewLine + _
                   "Click [Restart Explorer to Activate] button to activate.", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        If Not GetNoDrives(ListView1) Then
            MsgBox("Error")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Not MsgBox("Click [Yes] button to restart Explorer!", _
                      MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Return
        End If

        Try
            'terminating Explorer
            Dim p() As Process = Process.GetProcessesByName("Explorer")
            For Each item In p
                item.Kill()
                item.WaitForExit()
            Next

            'restarting 
            Try
                Process.Start("Explorer")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
            End Try


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshButton_Click(Nothing, Nothing)
    End Sub

#End Region

#Region "   Functions  "
    'this function calculate value of nodrive registry and set it to registry
    Private Function SetNoDrive(ByRef Lv As ListView) As Boolean

        If Lv.Items.Count <= 0 Then
            MsgBox("List is Empty...", MsgBoxStyle.Exclamation)
            Return False
        End If

        Dim RegValueData As Integer = 0

        For Each item As ListViewItem In Lv.Items
            'check if item is checked
            If item.Checked Then
                'get Drive Letter
                Dim dr As String = item.Text.Remove(1, 2)
                'MsgBox(dr)
                'calculate value
                'MsgBox((Asc(dr) - 65).ToString)
                ' MsgBox(2 ^ (Asc(dr) - 65))
                RegValueData += (2 ^ (Asc(dr) - 65))
            End If
        Next

        'adding this value to registry
        Try
            'Now add thid value to registry
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoDrives", RegValueData, Microsoft.Win32.RegistryValueKind.DWord)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return False
        End Try

        'now func. is ok
        Return True
    End Function

    'retrive value of NoDrive registry and refresh list according to it.
    Private Function GetNoDrives(ByRef Lv As ListView) As Boolean

        'Collecting and adding drive leter to Listview
        'clearing listview
        Lv.Items.Clear()

        'now getting driveletter
        Dim HideDrives As New ArrayList
        If Not DriveLettersFromNodrive(HideDrives) Then
            MsgBox("Some thing wronge...", MsgBoxStyle.Exclamation)
        End If


        For Each dr As IO.DriveInfo In IO.DriveInfo.GetDrives

            'here we are ignoring floppy , if it is egnored then scan
            If Not Form1.CheckBox4.Checked = True Then
                'here i am scaning checkbox in place of registry value
                'this can generate a problem if i will dispose form1
                If dr.Name.ToLower = "a:\" Or dr.Name.ToLower = "b:\" Then
                    Continue For
                End If
            End If


            Dim lvItem As New ListViewItem
            lvItem.Text = dr.Name


            'if drice is cdrom and it is empty it return error
            If dr.IsReady Then
                lvItem.SubItems.Add(dr.VolumeLabel)
                lvItem.SubItems.Add(dr.DriveType.ToString)
                lvItem.SubItems.Add(dr.DriveFormat.ToString)
                lvItem.SubItems.Add(ByteSizeOptimaized(dr.TotalSize))
                lvItem.SubItems.Add(ByteSizeOptimaized(dr.TotalFreeSpace))

            Else
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add(dr.DriveType.ToString)
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("")
            End If




            For Each item As String In HideDrives
                If dr.Name.ToUpper = item.ToUpper Then
                    lvItem.Checked = True
                    Exit For
                End If
            Next

            Lv.Items.Add(lvItem)
        Next
        'now function is true
        Return True
    End Function

    'this function getvaluee of NoDrive registry and return array of drive latters of hidden drives
    Private Function DriveLettersFromNodrive(ByRef DriveLetterCollection As ArrayList) As Boolean
        DriveLetterCollection.Clear()

        Dim a As Integer
        Try
            a = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoDrives", 0)
            If a = 0 Then
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try

        Dim count As Integer = 0
        Do
            'Dim m As Integer
            If (a Mod 2 = 1) Then
                'MsgBox(ChrW(65 + count))
                DriveLetterCollection.Add(ChrW(65 + count) + ":\")
            End If
            a = a \ 2
            count += 1
        Loop While (a >= 1)

        Return True

    End Function


#End Region

End Class
