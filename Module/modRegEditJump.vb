Imports System.Runtime.InteropServices

Module modRegEditJump
   
    '=========================================================
    'Win32 API Declaration
    '=========================================================
    '
    'ShellExecute API
    <DllImport("shell32.dll", SetLastError:=True)> _
    Private Function ShellExecuteEx(ByRef lpExecInfo As SHELLEXECUTEINFO) As Integer
    End Function

    Private Const SW_NORMAL As Integer = 1
    Private Const SW_SHOW As Integer = 5
    Private Const SEE_MASK_NOCLOSEPROCESS As Integer = &H40

    Private Structure SHELLEXECUTEINFO
        Dim cbSize As Integer
        Dim fMask As Integer
        Dim hwnd As Integer
        Dim lpVerb As String
        Dim lpFile As String
        Dim lpParameters As String
        Dim lpDirectory As String
        Dim nShow As Integer
        Dim hInstApp As Integer
        ' fields
        Dim lpIDList As Integer
        Dim lpClass As String
        Dim hkeyClass As Integer
        Dim dwHotKey As Integer
        Dim hIcon As Integer
        Dim hProcess As Integer
    End Structure


    'Window API
    <DllImport("user32.dll", SetLastError:=True)> _
    Private Function FindWindow(ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
    End Function
    <DllImport("user32.dll", SetLastError:=True)> _
    Private Function FindWindowEx(ByVal hWnd1 As Integer, ByVal hWnd2 As Integer, ByVal lpsz1 As String, ByVal lpsz2 As String) As Integer
    End Function
    <DllImport("user32.dll", SetLastError:=True)> _
    Private Function SetForegroundWindow(ByVal hwnd As Integer) As Integer
    End Function
    <DllImport("user32.dll", SetLastError:=True)> _
    Private Function ShowWindow(ByVal hwnd As Integer, ByVal nCmdShow As Integer) As Integer
    End Function
    <DllImport("user32.dll", SetLastError:=True)> _
    Private Function SetFocus(ByVal hwnd As Integer) As Integer
    End Function



    'Message API
    <DllImport("user32.dll", SetLastError:=True)> _
    Private Function SendMessage(ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As Long) As Integer
    End Function

    Private Const WM_KEYDOWN As Integer = &H100 'when any key pressed with out ALT 'http://msdn.microsoft.com/en-us/library/ms646280(VS.85).aspx
    Private Const WM_KEYUP As Integer = &H101 'when any key is released 'http://msdn.microsoft.com/en-us/library/ms646281%28VS.85%29.aspx
    Private Const WM_CHAR As Integer = &H102 'send charecter code with WM_KEYDOWN 'http://msdn.microsoft.com/en-us/library/ms646276%28VS.85%29.aspx



    Private Const VK_LEFT As Integer = &H25
    Private Const VK_RIGHT As Integer = &H27
    Private Const VK_HOME As Integer = &H24

    'Process API
    <DllImport("user32.dll", SetLastError:=True)> _
    Private Function GetWindowThreadProcessId(ByVal hwnd As Integer, ByRef lpdwProcessId As Integer) As Integer
    End Function
    <DllImport("kernel32.dll", SetLastError:=True)> _
    Private Function OpenProcess(ByVal dwDesiredAccess As Integer, ByVal bInheritHandle As Integer, ByVal dwProcessId As Integer) As Integer
    End Function
    <DllImport("kernel32.dll", SetLastError:=True)> _
    Private Function CloseHandle(ByVal hObject As Integer) As Integer
    End Function
    <DllImport("user32.dll", SetLastError:=True)> _
    Private Function WaitForInputIdle(ByVal hProcess As Integer, ByVal dwMilliseconds As Integer) As Integer
    End Function

    Private Const SYNCHRONIZE As Integer = &H100000
    Private Const INFINITE As Integer = &HFFFFFFFF
    Private Const STANDARD_RIGHTS_REQUIRED As Integer = &HF0000
    Private Const PROCESS_ALL_ACCESS As Integer = (STANDARD_RIGHTS_REQUIRED Or SYNCHRONIZE Or &HFFF)

    'Sleep
    <DllImport("kernel32.dll", SetLastError:=True)> _
    Private Sub Sleep(ByVal dwMilliseconds As Integer)
    End Sub



    '==========================================================
    Public Function RegEditJump(ByVal strRegKey As String, Optional ByVal strValueName As String = "") As Object  ' here strValueName is set to default 
        'Function RegEditJump
        '
        'Input values:
        'strRegKey As String : Registry key to open
        'strValueName As String : Registry Value name to select[optional]  ' originally set to default 
        '==========================================================
        Dim hndRegEdit As Integer 'Regedit Window's Handle
        Dim hndTreeView As Integer 'TreeView in Regedit's Handle
        'Dim hndListView As Integer 'ListView Handle

        Dim hndProcess As Integer 'RegEdit Process

        Dim SHInfo As New SHELLEXECUTEINFO

        'Dim j As Short
        ' Dim lngVK As Integer
        Dim ret As Integer

        'First we check if RegEdit is running or not?
        'If not we start it.
        'To see if it is running, try to find Window with class
        'RegEdit_RegEdit
        '-----------Open RegEdit-------------------------------
        hndRegEdit = FindWindow("RegEdit_RegEdit" & vbNullChar, vbNullString)  'note here RegEdit_RegEdit is a class to regEdit

        If hndRegEdit = 0 Then 'Not running
            With SHInfo
                .cbSize = Len(SHInfo)
                .lpVerb = "open" & vbNullChar
                .lpFile = "regedit.exe" & vbNullChar
                .fMask = SEE_MASK_NOCLOSEPROCESS
                .nShow = SW_NORMAL
            End With
            ShellExecuteEx(SHInfo) 'ShellExecute RegEdit
        End If

        'Sleep for about one second, so RegEdit can start
        'Because we will check for its Window again
        Sleep((750))

        'Check for RegEdit window
        hndRegEdit = FindWindow("RegEdit_RegEdit" & vbNullChar, vbNullString)

        'If still not running then show message that we cannot run it
        'And exit :(
        If hndRegEdit = 0 Then
            MsgBox("Unable to launch RegEdit.", MsgBoxStyle.Critical, "Error")
            Return Nothing
            'Exit Function
        End If


        'If now RegEdit is running then put its window in foreground
        ret = ShowWindow(hndRegEdit, SW_SHOW)
        ret = SetForegroundWindow(hndRegEdit)


        'Now we will get handle of TreeView in RegEdit's main Window
        'This we do by finding a child window with class SysTreeView32
        '------------Get TreeView------------------------------
        hndTreeView = FindWindowEx(hndRegEdit, 0, "SysTreeView32" & vbNullChar, vbNullString)

        'Set focus to treeview
        ret = SetForegroundWindow(hndTreeView)
        ret = SetFocus(hndTreeView)

        'We need Process Handle of TreeView so we can make it wait
        'after inputing KeyStrokes in it.

        'Get ProcessID of TreeView
        ret = GetWindowThreadProcessId(hndTreeView, hndProcess)
        'Get Process Handle of TreeView
        ret = OpenProcess(PROCESS_ALL_ACCESS, False, hndProcess)

        'close intire treeview 
        CloseRegEditTreeView(hndProcess, hndTreeView)

        'now open path of registry in tree view list
        OpenPathInRegEditTreeView(strRegKey, hndProcess, hndTreeView)

        'Close TreeView Process Handle
        ret = CloseHandle(hndProcess)

        'now locate Value in listview
        SetKeyValueInRegeditKeyView(strValueName, hndRegEdit)

        'Finally again set focus to Main RegEdit window
        ret = SetForegroundWindow(hndRegEdit)
        ret = SetFocus(hndRegEdit)
        Return Nothing
    End Function

    'this will open path in regedit 
    Private Function OpenPathInRegEditTreeView(ByVal strRegKey As String, ByVal hndProcess As Integer, ByVal hndTreeView As Integer) As Boolean
        Dim strTmp As String
        Dim j As Short
        Dim ret As Integer
        Dim lngVk As Integer

        'Now we will open Registry Path by inputing key strokes in TreeView
        'We send equivalent Virtual Key codes  for all chars
        'And a 'Right' Key stroke for '\', to open a node
        '------------Open Path---------------------------------
        strRegKey = "My Computer\" + strRegKey 'because here tree is closed so we have to travers from root node

        For j = 1 To Len(strRegKey)
            'terversing charecter one by one 
            strTmp = Mid(strRegKey, j, 1) 'Get a char
            'If '\' then send 'Right' 'this will open subtree of that tree
            If strTmp = "\" Then
                ret = SendMessage(hndTreeView, WM_KEYDOWN, VK_RIGHT, 0)
                ret = WaitForInputIdle(hndProcess, INFINITE)

            Else 'Send VirtualKey Code
                lngVk = Asc(UCase(strTmp))
                ret = SendMessage(hndTreeView, WM_CHAR, lngVk, 0)
            End If
        Next
        Return True
    End Function

    'this wil locate registry value in listview of regedit
    'In this function on bug is still there 
    'if we select any valuse which have identical initiation like 
    'BitTorretn
    'Bittorrent DNA
    '
    'then if we select Bittorrent then it will Select Bittorrent DNA
    '
    Private Function SetKeyValueInRegeditKeyView(ByVal strValueName As String, ByVal hndRegEdit As Integer) As Boolean
        Dim hndlistView As Integer
        Dim Ret As Integer
        Dim j As Short
        Dim lngVK As Integer

        'If strValueName is specified. Select ValueName in ListView
        '-----------------Select Registry Value------------------
        If strValueName <> "" Then
            'if value is not blank
            'First Get Handle of ListView in RegEdit
            hndlistView = FindWindowEx(hndRegEdit, 0, "SysListView32" & vbNullChar, vbNullString)
            'Set ListView in focus
            Ret = SetForegroundWindow(hndlistView)
            Ret = SetFocus(hndlistView)

            'Give time to adjust
            Sleep((1000))

            'Select first item in ListView
            Ret = SendMessage(hndlistView, WM_KEYDOWN, VK_HOME, 0)

            'Select Value
            For j = 1 To Len(strValueName)
                lngVK = Asc(UCase(strValueName))
                Ret = SendMessage(hndlistView, WM_CHAR, lngVK, 0)
            Next
        End If
        Return True
    End Function

    'this will collaps regedit tree view
    Private Function CloseRegEditTreeView(ByVal hndProcess As Integer, ByVal hndTreeView As Integer) As Boolean
        'Now we close TreeView by sending 'right' keys to it.
        'This we do as a precaution, in case treeview is already open
        Dim ret As Integer
        Dim j As Short

        '------------Close TreeView----------------------------
        'Just send 30 'left' Keys to TreeView
        For j = 1 To 30
            ret = SendMessage(hndTreeView, WM_KEYDOWN, VK_LEFT, 0)
        Next
        ret = WaitForInputIdle(hndProcess, INFINITE) 'Wait for input process to finish
        Return True
    End Function

End Module