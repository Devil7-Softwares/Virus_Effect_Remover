'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date : 10/12/2009                               '
'                                                                  '
'******************************************************************'
Imports System.Runtime.InteropServices

Namespace Win32Process
    Public Class Win32

#Region "Suspend And Resume Function using kernel32.dll "

        'This Class is used to suspend and resume process
        Const THREAD_SUSPEND_RESUME As Integer = &H2

#Region "Imported Functions For Threads"

        <DllImport("kernel32.dll", SetLastError := True)>
        Private Shared Function OpenThread(ByVal DesiredAccess As Integer, ByVal InheritHandle As Integer,
                                           ByVal ThreadId As Integer) As Integer
        End Function

        <DllImport("kernel32.dll", SetLastError := True)>
        Private Shared Function SuspendThread(ByVal ThreadHandle As Integer) As Integer
        End Function

        <DllImport("kernel32.dll", SetLastError := True)>
        Private Shared Function CloseHandle(ByVal Handle As Integer) As Integer
        End Function

        <DllImport("kernel32.dll", SetLastError := True)>
        Private Shared Function ResumeThread(ByVal ThreadHandle As Integer) As Integer
        End Function

#End Region

        Public Shared Function SuspendProcess(ByVal pid As Integer) As Boolean
            Dim process__1 As Process
            Try
                process__1 = Process.GetProcessById(pid)
            Catch
                Return False
            End Try

            Try
                For Each thread As ProcessThread In process__1.Threads
                    Dim handle As Integer = OpenThread(THREAD_SUSPEND_RESUME, 0, thread.Id)
                    If handle = 0 Then
                        Throw New Exception("Could not open process handle.")
                    End If

                    If SuspendThread(handle) = - 1 Then
                        Throw New Exception("Could not suspend thread.")
                    End If
                    CloseHandle(handle)
                Next
            Catch
                Return False
            End Try
            'process successfully suspend
            Return True
        End Function

        Public Shared Function ResumeProcess(ByVal pid As Integer) As Boolean
            Dim process__1 As Process
            Try
                process__1 = Process.GetProcessById(pid)
            Catch
                Return False
            End Try
            Try
                For Each thread As ProcessThread In process__1.Threads
                    Dim handle As Integer = OpenThread(THREAD_SUSPEND_RESUME, 0, thread.Id)
                    If handle = 0 Then
                        Throw New Exception("Could not open process handle.")
                    End If
                    If ResumeThread(handle) = - 1 Then
                        Throw New Exception("Could not resume thread.")
                    End If
                    CloseHandle(handle)
                Next
            Catch
                Return False
            End Try
            'process successfilly resumed
            Return True
        End Function

#End Region

#Region " using ntdll.dll .. ZwResumeProcess/ZwSuspendProcess"

        Const PROCESS_SUSPEND_RESUME As Integer = &H800

        <DllImport("ntdll.dll", SetLastError := True)>
        Private Shared Function ZwResumeProcess(ByVal ProcessHandle As Integer) As Integer
        End Function

        <DllImport("ntdll.dll", SetLastError := True)>
        Private Shared Function ZwSuspendProcess(ByVal ProcessHandle As Integer) As Integer
        End Function


        Public Shared Function _SuspendProcess(ByVal pid As Integer) As Boolean
            Dim pHandle As Integer = OpenProcess(PROCESS_SUSPEND_RESUME, 0, pid)
            If (ZwSuspendProcess(pHandle) <> 0) Then
                CloseHandle(pHandle)
                Return False
            Else
                CloseHandle(pHandle)
                Return True
            End If
        End Function

        Public Shared Function _ResumeProcess(ByVal pid As Integer) As Boolean
            Dim pHandle As Integer = OpenProcess(PROCESS_SUSPEND_RESUME, 0, pid)
            If (ZwResumeProcess(pHandle) <> 0) Then
                CloseHandle(pHandle)
                Return False
            Else
                CloseHandle(pHandle)
                Return True
            End If
        End Function

#End Region


#Region "Module Release Related Difinition and function"

#Region "  Constants  "

        Private Const PROCESS_CREATE_THREAD As Integer = &H2
        Private Const PROCESS_VM_OPERATION As Integer = &H8
        Private Const PROCESS_VM_WRITE As Integer = &H20
        Private Const PROCESS_VM_READ As Integer = &H10

#End Region

        <DllImport("Kernel32.dll", SetLastError := True)>
        Private Shared Function OpenProcess(ByVal dwDesiredAccess As Integer,
                                            ByVal bInheritHandle As Integer,
                                            ByVal dwProcessId As Integer) As Integer
        End Function

        <DllImport("Kernel32.dll", SetLastError := True)>
        Private Shared Function GetModuleHandle(ByVal lpModuleName As String) As Integer
        End Function

        <DllImport("Kernel32.dll", SetLastError := True)>
        Private Shared Function GetProcAddress(ByVal hModule As Integer,
                                               ByVal lpProcName As String) As Integer
        End Function

        <DllImport("Kernel32.dll", SetLastError := True)>
        Private Shared Function CreateRemoteThread(ByVal hProcess As Integer,
                                                   ByVal lpThreadAttributes As Integer,
                                                   ByVal dwStackSize As Integer,
                                                   ByVal lpStartAddress As Integer,
                                                   ByVal lpParameter As Integer,
                                                   ByVal dwCreationFlags As Integer,
                                                   ByRef lpThreadId As Integer) As Integer
        End Function


        Public Shared Function UnLoadModuleFromProcess(ByVal ProcessId As Integer,
                                                       ByVal ModuleBaseAddress As Integer) As Integer
            'first get a valid handle of this pid
            Dim hProc As Integer = OpenProcess(PROCESS_CREATE_THREAD Or
                                               PROCESS_VM_OPERATION Or
                                               PROCESS_VM_WRITE Or
                                               PROCESS_VM_READ, 0, ProcessId)

            'here this is for getting handle of kernel32 module
            Dim kernel32 As Integer = GetModuleHandle("kernel32.dll")

            '?
            Dim freeLibrary As Integer = GetProcAddress(kernel32, "FreeLibrary")

            'by creating remot thread we will free this module from this PID
            Dim threadId As Integer
            CreateRemoteThread(hProc, 0, 0, freeLibrary, ModuleBaseAddress, 0, threadId)
        End Function

#End Region
    End Class
End Namespace


