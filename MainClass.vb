'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date : 15/12/2009                               '
'                                                                  '
'******************************************************************'
Imports System
Imports System.Windows.Forms
Imports System.ComponentModel
Imports Virus_Effect_Remover.My.Resources
Imports Microsoft.Win32




Public MustInherit Class MainClass
    'i am using this to run splace screen in different thread
    Public Shared spl_th As New System.Threading.Thread(AddressOf ThreadStart)
    Public Shared VERName As String = My.Application.Info.ProductName.ToString + " " _
                                       + My.Application.Info.Version.ToString

    ' Public Shared _DefaultProfile As EngResource



    Public Shared Sub main()

        '
        On Error Resume Next

        ' MsgBox(Application.ExecutablePath.ToUpper)

        If SeachDuplicate() Then
            Application.EnableVisualStyles()
            MsgBox("Process already running.", MsgBoxStyle.Information)
            Return
        End If

        Application.EnableVisualStyles()
        'first time running of ver
        firstTime()

        'running thread to execute splace screen
        spl_th.SetApartmentState(System.Threading.ApartmentState.STA)
        spl_th.Start()


        ' System.Threading.Thread.Sleep(1000)


        'now start main form
        Application.Run(Form1)
        Form1.Dispose()
    End Sub

    Private Shared Sub firstTime()
        'first we will check for first run 
        If My.Computer.Registry.GetValue(VERKey, "firstrun", 0) = 0 Then
            'set this key to high
            My.Computer.Registry.SetValue(VERKey, "firstrun", 1)
            MsgBox("Thank you, for using Virus Effects Remover (V.E.R.)." + vbNewLine + _
                   "Some parts of V.E.R. are still under development. See Help." + vbNewLine + _
                   "Please let me have any comments you may have about this project." + vbNewLine + _
                   "Thanks." + vbNewLine + vbNewLine + _
                   "Avinash Sachan" + vbNewLine + vbNewLine + _
                   "You can E-mail me at:-" + vbNewLine + _
                   "avinashsachan@gmail.com", MsgBoxStyle.Information)
        End If
    End Sub
    'we are using this thread to run splace screen
    Shared Sub ThreadStart()
        'Dim f As New SplashScreen1()
        Application.Run(SplashScreen1)
    End Sub

#Region "  Search For duplicate process "
    'search duplicate process
    'if found return true
    Private Shared Function SeachDuplicate(Optional ByRef RunningProc As Process = Nothing) As Boolean
        For Each p As Process In Process.GetProcesses
            Try
                'MsgBox(p.MainModule.FileName.ToUpper + vbNewLine + Application.ExecutablePath.ToUpper)
                If p.MainModule.FileName.ToUpper = Application.ExecutablePath.ToUpper Then
                    If p.Id <> Process.GetCurrentProcess.Id Then
                        'MsgBox("Process Already running.", MsgBoxStyle.Information)
                        RunningProc = p
                        Return True
                    End If
                End If
            Catch 'ex As Exception
                'do nothing
            End Try
        Next
        Return False
    End Function
#End Region




End Class
