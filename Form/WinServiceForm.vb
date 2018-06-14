'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date : 08/01/2010                               '
'                                                                  '
'******************************************************************'
Imports System.ServiceProcess

Public Class WinServiceForm

#Region " Used function.."
    Friend Sub RefreshServiceList()
        Try
            ServiceList.Items.Clear()
            'This will get you started, but make sure you add a reference to
            ' System.ServiceProcess.
            Dim services() As System.ServiceProcess.ServiceController
            Dim i As Integer
            services = System.ServiceProcess.ServiceController.GetServices()

            For i = 0 To services.Length - 1
                ServiceList.Items.Add(services(i).ServiceName)
                ServiceList.Items(ServiceList.Items.Count - 1).SubItems.Add(services(i).DisplayName.ToString)
                ServiceList.Items(ServiceList.Items.Count - 1).SubItems.Add(services(i).Status.ToString)
                'Adding color according to the status of the service
                Select Case services(i).Status
                    Case ServiceControllerStatus.Running
                        ServiceList.Items(ServiceList.Items.Count - 1).BackColor = Color.PaleGreen
                    Case ServiceControllerStatus.Stopped
                        ServiceList.Items(ServiceList.Items.Count - 1).BackColor = Color.Plum
                    Case ServiceControllerStatus.Paused
                        ServiceList.Items(ServiceList.Items.Count - 1).BackColor = Color.LightGreen
                    Case ServiceControllerStatus.StartPending
                        ServiceList.Items(ServiceList.Items.Count - 1).BackColor = Color.LawnGreen
                    Case ServiceControllerStatus.PausePending
                        ServiceList.Items(ServiceList.Items.Count - 1).BackColor = Color.GreenYellow
                    Case ServiceControllerStatus.StopPending
                        ServiceList.Items(ServiceList.Items.Count - 1).BackColor = Color.HotPink
                    Case Else
                        ServiceList.Items(ServiceList.Items.Count - 1).BackColor = Color.Aqua
                End Select
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "Context menu Item Events"
    Private Sub StartServiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartServiceToolStripMenuItem.Click

        If NothingSelectedInlistView(ServiceList) Then Return

        Try
            Dim service As New ServiceController(ServiceList.Items(ServiceList.SelectedIndices(0)).SubItems(0).Text)
            service.Refresh()
            If service.Status <> ServiceControllerStatus.Running Then

                If service.Status = ServiceControllerStatus.Paused Then
                    service.Continue()
                Else
                    service.Start()
                End If

                service.WaitForStatus(ServiceControllerStatus.Running)
                ServiceList.Items(ServiceList.SelectedIndices(0)).SubItems(2).Text = service.Status.ToString
                ServiceList.Items(ServiceList.SelectedIndices(0)).BackColor = Color.PaleGreen
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub StopServiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopServiceToolStripMenuItem.Click

        If NothingSelectedInlistView(ServiceList) Then Return


        Try
            Dim service As New ServiceController(ServiceList.Items(ServiceList.SelectedIndices(0)).SubItems(0).Text)
            service.Refresh()
            If service.Status <> ServiceControllerStatus.Stopped Then
                service.Stop()
                service.WaitForStatus(ServiceControllerStatus.Stopped)
                ServiceList.Items(ServiceList.SelectedIndices(0)).SubItems(2).Text = service.Status.ToString
                ServiceList.Items(ServiceList.SelectedIndices(0)).BackColor = Color.Plum
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub PauseServiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PauseServiceToolStripMenuItem.Click

       If NothingSelectedInlistView(ServiceList) Then Return

        Try
            Dim service As New ServiceController(ServiceList.Items(ServiceList.SelectedIndices(0)).SubItems(0).Text)
            service.Refresh()
            If service.Status <> ServiceControllerStatus.Paused Then
                service.Pause()
                service.WaitForStatus(ServiceControllerStatus.Paused)
                ServiceList.Items(ServiceList.SelectedIndices(0)).SubItems(2).Text = service.Status.ToString
                ServiceList.Items(ServiceList.SelectedIndices(0)).BackColor = Color.LightGreen
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ResumeServiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumeServiceToolStripMenuItem.Click
        If NothingSelectedInlistView(ServiceList) Then Return

        Try
            Dim service As New ServiceController(ServiceList.Items(ServiceList.SelectedIndices(0)).SubItems(0).Text)
            service.Refresh()
            If service.Status = ServiceControllerStatus.Paused Then
                service.Continue()
                service.WaitForStatus(ServiceControllerStatus.Running)
                ServiceList.Items(ServiceList.SelectedIndices(0)).SubItems(2).Text = service.Status.ToString
                ServiceList.Items(ServiceList.SelectedIndices(0)).BackColor = Color.PaleGreen
            Else
                'do nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ServiceListMenu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ServiceListMenu.Opening
        If ListViewIsEmptyOrNotSelected(ServiceList, False) Then
            e.Cancel = True
        End If
    End Sub

#End Region

    Private Sub ServiceManagementConsoleToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiceManagementConsoleToolStripButton.Click
        Try
            System.Diagnostics.Process.Start("services.msc")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub RefreshServiceListToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshServiceListToolStripButton.Click
        RefreshServiceList()
    End Sub

    Private Sub WinServiceForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshServiceList()
    End Sub

End Class