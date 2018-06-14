'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date : 07/12/2009                               '
'                                                                  '
'******************************************************************'

'Declaretion of lib function
Imports System
Imports System.Diagnostics
Imports System.IO



Public Class KillProcessClass


    'setting windir to c:\windows  here c:\windows is installed xp drive
    Public Shared windir As String = My.Application.GetEnvironmentVariable("WinDir")

    'Danger process of windows which should not killed.
    'Public _DangerousNames() As String = {"csrss.exe", "dwm.exe", "lsass.exe", "lsm.exe", "services.exe", _
    '                                 "smss.exe", "wininit.exe", "winlogon.exe"}


    'this function return false if process is critical and return true if process is not critical 
    'detection of  same name process is done by root path .
    'two root path of csrss and winlogon contain   /??/  at starting 

    Shared Function DangerListOfProcess(ByVal P As Process) As Boolean

        'Dont perform check if filter checkbox is unchecked
        If Form1.EnableProcessFilter.Checked = False Then
            Return True
        End If


        'setting process path to propath
        Dim propath As String

        'many critical process do not return process path
        Try
            propath = P.MainModule.FileName.ToLower()
        Catch ex As Exception
            Return False
        End Try


        Select Case P.ProcessName.ToLower
            Case "csrss"
                Try
                    If propath = (("\??\" + windir + "\system32\csrss.exe").ToLower) Then
                        Return False
                    Else
                        Return True
                    End If
                Catch
                    Return False
                End Try

            Case "services"
                Try
                    If propath = ((windir + "\system32\services.exe").ToLower) Then
                        Return False
                    Else
                        Return True
                    End If
                Catch
                    Return False
                End Try

            Case "svchost"
                Try
                    If propath = ((windir + "\system32\svchost.exe").ToLower) Then
                        Return False
                    Else
                        Return True
                    End If
                Catch
                    Return False
                End Try
            Case "lsass"
                Try
                    If propath = ((windir + "\system32\lsass.exe").ToLower) Then
                        Return False
                    Else
                        Return True
                    End If
                Catch
                    Return False
                End Try
            Case "smss"
                Try
                    If propath = ((windir + "\system32\smss.exe").ToLower) Then
                        Return False
                    Else
                        Return True
                    End If
                Catch
                    Return False
                End Try
            Case "winlogon"
                Try
                    If propath = (("\??\" + windir + "\system32\winlogon.exe").ToLower) Then
                        Return False
                    Else
                        Return True
                    End If
                Catch
                    Return False
                End Try


            Case "system"
                Try
                    If P.Id = 4 Then
                        Return False
                    Else
                        Return True
                    End If
                Catch
                    Return False
                End Try
            Case "idle"
                Try
                    If P.Id = 0 Then
                        Return False
                    Else
                        Return True
                    End If
                Catch
                    Return False
                End Try

            Case Else
                Return True
        End Select
    End Function


    ' this function is defined as killprocessbyid(  pid , will_file_delete , detail) as integer
    ' will_file_delete = false -> not delete
    ' Will_file_delete = true -> delete attached file
    'return 0 if process not terminated and file not deleted.
    'return 1 if process trminated but file is not deleted
    'return 2 if process terinated and file deleted.
    'return -1 if process do not exist
    'return -2 if process is dangerous
    'return -3 if exception in process termination

    'if this function return value >0 then it means process is terminated
    'we can use this in process restart type function

    Shared Function killProcessById(ByVal ProcessId As Integer, _
                                    Optional ByVal DelState As Boolean = False, _
                                    Optional ByVal EnableProcessFilter As Boolean = True, _
                                    Optional ByRef Responce As ArrayList = Nothing) As Integer

        'Creating Information source
        Responce = New ArrayList
        Responce.Clear()

        'Taking Process Control and alloting variable to it as process
        Dim P As System.Diagnostics.Process
        Try
            P = System.Diagnostics.Process.GetProcessById(ProcessId)
        Catch ex As Exception
            Responce.Add("Process having ProcessId : " + ProcessId + "  does not exist.")
            Return -1
        End Try


        'Checking For critical process 
        If EnableProcessFilter Then
            If KillProcessClass.DangerListOfProcess(P) = False Then
                Responce.Add("Process : " + P.ProcessName.ToUpper + " : PID :" + P.Id.ToString + " is a critical process. Termination Skipped.")
                Responce.Add("To Terminate this process Uncheck 'Enable Process Filter' in Options Tab.")
                'this tab will work at DangerListOfProcess Function and return true if unchecked
                Return -2
            End If
        End If


        'here we are going to terminate process
        ' Try
        Dim path As String = P.MainModule.FileName.ToString
        Responce.Add("Attempt To Kill Process : " + P.ProcessName + "  : PID : " + P.Id.ToString + "  begun.")
        '*************************************************************************
        'killing process
        Try
            P.Kill()
            Responce.Add("Process : " + P.ProcessName + " :  PID : " + P.Id.ToString + "  Terminated successfully..")
        Catch ex As Exception
            Responce.Add(ex.Message)
            Return -3
        End Try

        '**************************************************************************
        'deleteing file if DelState is true
        If DelState = True Then
            If System.IO.File.Exists(path) Then
                Try
                    'First we wait for Complite Process Exit from memory 
                    'So that we can delete file associated with it
                    P.WaitForExit()

                    'First Attempt to delte the file ' 
                    'Actualy We uses P.WaitForExit() So there is no need 
                    'For second attemp but for safe Side we also use second attemp
                    '
                    'Here also need of NTFS  Security privilage but it is not neccessory to do so.


                    'setting file attribute
                    System.IO.File.SetAttributes(path, IO.FileAttributes.Normal)
                    System.IO.File.Delete(path)
                    Responce.Add("Finally File deleted : " + path)
                    Return 2
                Catch

                    'Now  we are making an other attempt
                    Try
                        'Second Attempt
                        System.Threading.Thread.Sleep(100)
                        System.IO.File.SetAttributes(path, IO.FileAttributes.Normal)
                        System.IO.File.Delete(path)
                        Responce.Add("Finally File deleted : " + path)
                        Return 2
                    Catch exb As Exception
                        Responce.Add("Can not delete File : " + exb.Message)
                        Return 1
                    End Try
                End Try

            Else
                Responce.Add("File not found : " + path)
                Return 1
            End If
        Else
            Return 1
        End If

    End Function

End Class

Public Class ModuleClass
    'this function is used to retrive all process  which is using a specified module
    'but now we are not using this function
    'we will use this function in deletefile  function

    Friend Function GetProcessesOfModule(ByVal ModuleName As String) As ArrayList
        Dim myProcessArray As New ArrayList
        myProcessArray.Clear()
        Dim processes As Process() = Process.GetProcesses
        Dim i As Integer
        For i = 0 To processes.GetUpperBound(0) - 1

            Dim myProcess As Process = processes(i)
            Try
                If Not myProcess.HasExited Then

                    Dim modules As ProcessModuleCollection = myProcess.Modules

                    Dim j As Integer
                    For j = 0 To modules.Count - 1
                        If (modules.Item(j).FileName.ToLower.CompareTo(ModuleName.ToLower) = 0) Then
                            myProcessArray.Add(myProcess)
                            Exit For
                        End If
                    Next j

                End If

            Catch exception As Exception
                'MsgBox(("Error : " & exception.Message))
            End Try
        Next i
        Return myProcessArray
    End Function

End Class


