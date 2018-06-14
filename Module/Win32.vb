Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Diagnostics
Imports System.Runtime.InteropServices

Namespace Win32Process

    Public Class Win32

#Region "Suspend And Resume Function"

        'This Class is used to suspend and resume process
        Const THREAD_SUSPEND_RESUME As Integer = &H2

#Region "Imported Functions"
        <DllImport("kernel32.dll")> _
        Private Shared Function OpenThread(ByVal DesiredAccess As Integer, ByVal InheritHandle As Integer, ByVal ThreadId As Integer) As Integer
        End Function
        <DllImport("kernel32.dll")> _
        Private Shared Function SuspendThread(ByVal ThreadHandle As Integer) As Integer
        End Function
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Private Shared Function CloseHandle(ByVal Handle As Integer) As Integer
        End Function
        <DllImport("kernel32.dll")> _
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

                    If SuspendThread(handle) = -1 Then
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
                    If ResumeThread(handle) = -1 Then
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



#Region "Module Release Related Difinition and function"

        Private Declare Function OpenProcess Lib "Kernel32.dll" (ByVal dwDesiredAccess As Integer, ByVal bInheritHandle As Integer, ByVal dwProcessId As Integer) As Integer
        Private Const PROCESS_CREATE_THREAD As Integer = &H2
        Private Const PROCESS_VM_OPERATION As Integer = &H8
        Private Const PROCESS_VM_WRITE As Integer = &H20
        Private Const PROCESS_VM_READ As Integer = &H10
        Private Declare Function GetModuleHandle Lib "kernel32" Alias "GetModuleHandleA" (ByVal lpModuleName As String) As Integer
        Private Declare Function GetProcAddress Lib "kernel32" (ByVal hModule As Integer, ByVal lpProcName As String) As Integer
        Private Declare Function CreateRemoteThread Lib "kernel32" (ByVal hProcess As Integer, ByVal lpThreadAttributes As Integer, ByVal dwStackSize As Integer, ByVal lpStartAddress As Integer, ByVal lpParameter As Integer, ByVal dwCreationFlags As Integer, ByRef lpThreadId As Integer) As Integer


        Public Shared Function UnLoadModuleFromProcess(ByVal ProcessId As Integer, ByVal ModuleBaseAddress As Integer) As Integer
            Dim hProc As Integer = OpenProcess(PROCESS_CREATE_THREAD Or PROCESS_VM_OPERATION Or PROCESS_VM_WRITE Or PROCESS_VM_READ, 0, ProcessId)
            Dim kernel32 As Integer = GetModuleHandle("kernel32.dll")
            Dim freeLibrary As Integer = GetProcAddress(kernel32, "FreeLibrary")
            Dim threadId As Integer
            CreateRemoteThread(hProc, 0, 0, freeLibrary, ModuleBaseAddress, 0, threadId)
        End Function
#End Region


    End Class

End Namespace
