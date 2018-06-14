Public Class ClassGet

    Public Shared Function GetStartupList() As Boolean
        Form1.StartupList.Sorting = SortOrder.None
        'On Error Resume Next
        Form1.StartupList.Items.Clear()
        Form1.ImageList1.Images.Clear()
        Dim colStartup = GetObject("winmgmts:").ExecQuery("SELECT * From Win32_StartupCommand")

        For Each Startups In colStartup
            'get icon from file and store it in imagelist1 making Caption that icon key 
            'First we extract path from commond
            Dim path As String = Startups.Command.ToString

            path = path.Split("/")(0).Trim
            path = path.Split("-")(0).Trim
            path = path.Trim("""").Trim


            'Building list

            Form1.StartupList.Items.Add((Form1.StartupList.Items.Count + 1).ToString).ToolTipText = path

            'Adding Icon to list
            If My.Computer.FileSystem.FileExists(path) Then
                'MsgBox(path + "    Exist")
                Form1.ImageList1.Images.Add(Startups.Caption.ToString, GetICON.GetFileIcon(path, 0).ToBitmap)
                Form1.StartupList.Items(Form1.StartupList.Items.Count - 1).ToolTipText = path
                Form1.StartupList.Items(Form1.StartupList.Items.Count - 1).ImageKey = Startups.Caption.ToString
            End If

            Form1.StartupList.Items(Form1.StartupList.Items.Count - 1).SubItems.Add(Startups.Caption)
            Form1.StartupList.Items(Form1.StartupList.Items.Count - 1).SubItems.Add(Startups.Command)
            Form1.StartupList.Items(Form1.StartupList.Items.Count - 1).SubItems.Add(Startups.User)
            Form1.StartupList.Items(Form1.StartupList.Items.Count - 1).SubItems.Add(Startups.Description)
            Form1.StartupList.Items(Form1.StartupList.Items.Count - 1).SubItems.Add(Startups.Location)
            Form1.StartupList.Items(Form1.StartupList.Items.Count - 1).SubItems.Add(Startups.Name)
            Form1.StartupList.Items(Form1.StartupList.Items.Count - 1).SubItems.Add(Startups.SettingId.ToString)
        Next
    End Function


    Shared Function GetProcessModule(ByVal Pid As String) As ArrayList
        myProcessArray.Clear()
        Dim pi As System.Diagnostics.Process
        pi = System.Diagnostics.Process.GetProcessById(Pid)
        Dim counter As Integer = 0
        'MsgBox(pi.ProcessName)
        Try
            For Each item As System.Diagnostics.ProcessModule In pi.Modules
                myProcessArray.Add(item)
                counter += 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return myProcessArray
    End Function

    Shared Function GetServiceList() As Boolean
        Try
            Form1.ServiceList.Items.Clear()
            'This will get you started, but make sure you add a reference to
            ' System.ServiceProcess.
            Dim services() As System.ServiceProcess.ServiceController
            Dim i As Integer
            services = System.ServiceProcess.ServiceController.GetServices()

            For i = 0 To services.Length - 1
                Form1.ServiceList.Items.Add(services(i).ServiceName)
                Form1.ServiceList.Items(Form1.ServiceList.Items.Count - 1).SubItems.Add(services(i).DisplayName.ToString)
                Form1.ServiceList.Items(Form1.ServiceList.Items.Count - 1).SubItems.Add(services(i).Status.ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
End Class
