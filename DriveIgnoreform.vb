Public Class DriveIgnoreform

    Private Sub DriveIgnoreform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshList()
    End Sub

    Private Sub RefreshList()

        Try
            '1st clear listvierw
            DrvListView.Items.Clear()

            'here collect all drives of system and list them in listview
            'With DrvListView
            'now buield it
            For Each drv As DriveInfo In DriveInfo.GetDrives
                'here we are ignoring floppy , if it is egnored then scan
                If Not Form1.CheckBox4.Checked = True Then
                    'here i am scaning checkbox in place of registry value
                    'this can generate a problem if i will dispose form1
                    If drv.Name.ToLower = "a:\" Or drv.Name.ToLower = "b:\" Then
                        Continue For
                    End If
                End If

                Dim LvItem As New ListViewItem(drv.Name)
                LvItem.Tag = drv.Name 'i will use this to get 
                LvItem.Checked = True ' initialy  all check box are checked 

                LvItem.Text = drv.Name
                LvItem.SubItems.Add(drv.DriveType.ToString)

                If drv.IsReady Then
                    LvItem.SubItems.Add(drv.VolumeLabel)
                    LvItem.SubItems.Add(ByteSizeOptimaized(drv.TotalSize))
                Else
                    'here drive is not ready so make all sub entry empty
                    LvItem.SubItems.Add(String.Empty)
                    LvItem.SubItems.Add(String.Empty)
                End If
                'add this drive to listview
                DrvListView.Items.Add(LvItem)
            Next
            'End With

            'now i will uncheck allowed drives

            Dim AllowedDrives As New ArrayList
            AllowedDrives = _GetAllowedDrives()

            For Each LvItem As ListViewItem In DrvListView.Items
                For Each drv As DriveInfo In DriveInfo.GetDrives
                    If LvItem.Tag.ToString.ToLower = drv.Name.ToLower Then
                        'this is allowed 
                        LvItem.Checked = False ' i am not jumping to next lvitem 
                    End If
                Next
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ApplyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyButton.Click
        'first remo


        Dim ignoredDerArraylist As New ArrayList


        For Each Lvitem As ListViewItem In DrvListView.Items
            If Lvitem.Checked Then
                ignoredDerArraylist.Add(Lvitem.Text)
            End If
        Next

        Try
            'now leave floppy
            For Each st As String In My.Computer.Registry.GetValue(My.Resources.VERKey, "IgnoreFloppy", Nothing)
                For Each itm As String In ignoredDerArraylist
                    If itm.ToLower = st.ToLower Then
                        'found floppy entry in "IgnoreFloppy"
                        ignoredDerArraylist.Remove(itm)
                        GoTo nextSt
                    End If
                Next
nextSt:
            Next
        Catch 'ex As Exception
        End Try
       


        If ignoredDerArraylist.Count <= 0 Then
            Return
        End If

        'now build string array
        Dim IgnoredDrv(0) As String

        For Each itm1 As String In ignoredDerArraylist
            If itm1 = Nothing Then
                Continue For
            End If
            Array.Resize(IgnoredDrv, IgnoredDrv.Length)
            IgnoredDrv.SetValue(itm1, IgnoredDrv.Length - 1)
        Next

        If IgnoredDrv.Length <= 0 Then
            My.Computer.Registry.SetValue(My.Resources.VERKey, "IgnoredDrv", "", RegistryValueKind.MultiString)
        Else
            My.Computer.Registry.SetValue(My.Resources.VERKey, "IgnoredDrv", IgnoredDrv, RegistryValueKind.MultiString)
        End If

        

        'Now set this string array to new multiString registry


    End Sub

    Private Sub RefreshButtorn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButtorn.Click
        RefreshList()
    End Sub
End Class