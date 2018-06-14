'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date : 07/12/2009                               '
'                                                                  '
'******************************************************************'

Option Explicit On
Imports System.Diagnostics
Imports Virus_Effect_Remover.My.Resources


Public Class RegInfection

    'Used For Registry Eror Remove Process
    Public Shared Function Remove_Effect() As Boolean

        On Error Resume Next

        'File Hidden Keys 
        My.Computer.Registry.SetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\Folder\Hidden\SHOWALL", _
         "CheckedValue", 1, RegistryValueKind.DWord)
        My.Computer.Registry.SetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\Folder\SuperHidden", _
         "UncheckedValue", 1)


        'CMD Key
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\System", "DisableCMD", 0)

       
        'MSCONFIG
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\MMC", "RestrictToPermittedSnapins", 0)


        'HKCU Policy Explorer  key
        My.Computer.Registry.SetValue(HKCUPolicyExplorerKey, "NoFolderOptions", 0, RegistryValueKind.DWord)
        My.Computer.Registry.SetValue(HKCUPolicyExplorerKey, "NoFileUrl", 0, RegistryValueKind.DWord)
        My.Computer.Registry.SetValue(HKCUPolicyExplorerKey, "NoRun", 0, RegistryValueKind.DWord)
        My.Computer.Registry.SetValue(HKCUPolicyExplorerKey, "NoLogoff", 0, RegistryValueKind.DWord)
        My.Computer.Registry.SetValue(HKCUPolicyExplorerKey, "NoClose", 0, RegistryValueKind.DWord)
        My.Computer.Registry.SetValue(HKCUPolicyExplorerKey, "NoSetFolders", 0, RegistryValueKind.DWord)
        My.Computer.Registry.SetValue(HKCUPolicyExplorerKey, "NoNetHood", 0, RegistryValueKind.DWord)
        My.Computer.Registry.SetValue(HKCUPolicyExplorerKey, "NoFileMenu", 0, RegistryValueKind.DWord)
        My.Computer.Registry.SetValue(HKCUPolicyExplorerKey, "NoFind", 0, RegistryValueKind.DWord)
        My.Computer.Registry.SetValue(HKCUPolicyExplorerKey, "NoSetTaskBar", 0, RegistryValueKind.DWord)
        My.Computer.Registry.SetValue(HKCUPolicyExplorerKey, "NoDrives", 0, RegistryValueKind.DWord)
        My.Computer.Registry.SetValue(HKCUPolicyExplorerKey, "NoDesktop", 0, RegistryValueKind.DWord)

        'security tab in property tab
        My.Computer.Registry.SetValue(HKCUPolicyExplorerKey, "Nosecuritytab", 0, RegistryValueKind.DWord)


        'Keys for windows update
        My.Computer.Registry.SetValue(HKCUPolicyExplorerKey, "NoUpdateCheck", 0, RegistryValueKind.DWord)
        My.Computer.Registry.SetValue(HKCUPolicyExplorerKey, "NoWindowsUpdate", 0, RegistryValueKind.DWord)
        My.Computer.Registry.SetValue _
        ("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\WindowsUpdate", _
         "DisableWindowsUpdateAccess", 0, RegistryValueKind.DWord)






        'HKCU Policy System
        My.Computer.Registry.SetValue(HKCUPolicySystemKey, "DisableTaskmgr", 0)
        My.Computer.Registry.SetValue(HKCUPolicySystemKey, "DisableRegistryTools", 0)
        My.Computer.Registry.SetValue(HKCUPolicySystemKey, "DisableChangePassword", 0)
        My.Computer.Registry.SetValue(HKCUPolicySystemKey, "DisableLockWorkstation", 0)
        My.Computer.Registry.SetValue(HKCUPolicySystemKey, "NoDispSettingsPage", 0)
        My.Computer.Registry.SetValue(HKCUPolicySystemKey, "NoDispAppearancePage", 0)


        On Error GoTo handler

        'Scaning  for msconfig
        If RegDisallowKey() Is Nothing Then
            'do nothing 
        Else
            For Each oneValue As String In RegDisallowKey.GetValueNames()
                If RegDisallowKey.GetValue(oneValue).ToString.ToUpper = ("msconfig.exe").ToUpper Then
                    'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun", oneValue, "msconfig.exe0")
                    RegDisallowKey.DeleteValue(oneValue)
                End If
            Next oneValue
        End If




        '****************
        'logon key are sncitive key so confirm before replace
        '****************
        '
        Dim StrValue As String = ""
        '
        'userinit of logon key
        'My.Application.GetEnvironmentVariable("WinDir") + "\system32\userinit.exe,"
        '
        'set user value
        Dim UsrValue As String = My.Application.GetEnvironmentVariable("WinDir") + "\system32\userinit.exe,"

        StrValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", _
                                                     "Userinit", UsrValue).ToString
        If Not StrValue.ToUpper = UsrValue.ToUpper Then
            'confirm
            If MsgBox("Logon key : Userinit is altered." + _
                      vbNewLine + vbNewLine + "Current Value is :  " + StrValue + _
                      vbNewLine + vbNewLine + "Would you like to reset it to original state?", _
                      MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                'setting key
                My.Computer.Registry.SetValue _
                ("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", _
                 "Userinit", UsrValue, RegistryValueKind.String)
            End If
        End If
        '
        'logoni of logon key
        '
        StrValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", _
                                                    "UIHost", "logonui.exe").ToString
        If Not StrValue.ToUpper = "logonui.exe".ToUpper Then
            'conform
            If MsgBox("Logon key : UIHost is altered." + _
                     vbNewLine + vbNewLine + "Current Value is :  " + StrValue + _
                     vbNewLine + vbNewLine + "Would you like to reset it to original state?", _
                                          MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                'setting key
                My.Computer.Registry.SetValue _
                ("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", _
                                                                "UIHost", "logonui.exe", RegistryValueKind.ExpandString)
            End If
        End If
        '
        'Sell key of logon
        '
        StrValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", _
                                                     "Shell", "Explorer.exe").ToString
        If Not StrValue.ToUpper = "Explorer.exe".ToUpper Then
            'confirm
            If MsgBox("Logon key : Shell is altered." + _
                      vbNewLine + vbNewLine + "Current Value is :  " + StrValue + _
                     vbNewLine + vbNewLine + "Would you like to reset it to original state?", _
                     MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                'setting key
                My.Computer.Registry.SetValue _
                ("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", _
                                                                             "Shell", "Explorer.exe", RegistryValueKind.String)
            End If
        End If


        Return True

        Exit Function
handler:
        MsgBox("Error correcting registry restriction.", MsgBoxStyle.Critical, "Msconfig.exe")
        Return True
    End Function


    'For Error Detection
    Public Shared Function DetectRegError(ByRef InfoCollection As ArrayList) As ArrayList


        On Error Resume Next
        InfoCollection = New ArrayList
        InfoCollection.Clear()

        If (scanregvalue(HKCUPolicyExplorerKey, _
                         "NoFolderOptions") = 1) Then
            InfoCollection.Add("Folder Option Disabled.")
        End If

        If (scanregvalue(HKCUPolicySystemKey, _
                         "DisableTaskmgr") = 1) Then
            InfoCollection.Add("Task Manager Disabled.")
        End If

        If (scanregvalue(HKCUPolicySystemKey, _
                         "DisableRegistryTools") = 1) Then
            InfoCollection.Add("Registry Editer Disabled.")
        End If

        If (scanregvalue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\Folder\SuperHidden", _
                         "UncheckedValue") <> 1) Then
            InfoCollection.Add("Super Hidden CheckBox Disabled.")
        End If

        If (scanregvalue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\Folder\Hidden\SHOWALL", _
                        "CheckedValue") = 0) Then
            InfoCollection.Add("Show Hidden Radio Button Disabled.")
        End If

        Dim Cmd_tab As String = scanregvalue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\System", "DisableCMD")
        If (Cmd_tab = 1) Then
            InfoCollection.Add("Command Prompt Disabled.")
        End If
        If (Cmd_tab = 2) Then
            InfoCollection.Add("Command Prompt And Scripting Disabled.")
        End If


        'Scan For Msconfig.exe Ristriction
        'scan for msconfig.exe string
        On Error GoTo ls ' this will jump directly to ls header ig registry not exist

        If RegDisallowKey() Is Nothing Then
        Else
            For Each oneValue As String In RegDisallowKey.GetValueNames()
                If RegDisallowKey.GetValue(oneValue).ToString.ToUpper = "msconfig.exe".ToUpper Then
                    InfoCollection.Add("Msconfig.exe Disabled.")
                End If
            Next oneValue
        End If
ls:



        'regshowmsg(HKCUPolicyExplorerKey, "NoDriveTypeAutoRun", "Drive Type Autorun Disabled")
        regshowmsg("HKEY_CURRENT_USER\Software\Policies\Microsoft\MMC", "RestrictToPermittedSnapins", "Group Policy Disabled", InfoCollection)
        regshowmsg(HKCUPolicyExplorerKey, "NoFileUrl", "File Url Disabled", InfoCollection)
        regshowmsg(HKCUPolicyExplorerKey, "NoRun", "Run Option Disabled", InfoCollection)
        regshowmsg(HKCUPolicyExplorerKey, "NoUpdateCheck", "Update Check Disabled", InfoCollection)
        regshowmsg(HKCUPolicyExplorerKey, "NoLogoff", "Log Off Option Disabled", InfoCollection)
        regshowmsg(HKCUPolicyExplorerKey, "NoClose", "Close Disabled", InfoCollection)
        regshowmsg(HKCUPolicyExplorerKey, "NoSetFolders", "Folder Option Setting Disabled ", InfoCollection)
        regshowmsg(HKCUPolicyExplorerKey, "NoNetHood", "NetWorking Disabled", InfoCollection)
        regshowmsg(HKCUPolicyExplorerKey, "NoFileMenu", "File Menu  Disabled", InfoCollection)
        regshowmsg(HKCUPolicyExplorerKey, "NoFind", "Find Disabled", InfoCollection)
        regshowmsg(HKCUPolicyExplorerKey, "NoSetTaskBar", "Taskbar Setting Disabled", InfoCollection)
        regshowmsg(HKCUPolicyExplorerKey, "NoDrives", "Drives option Disabled", InfoCollection)
        regshowmsg(HKCUPolicyExplorerKey, "NoDesktop", "Desktop Disabled", InfoCollection)

        'Security Tab Disable in property grid
        regshowmsg(HKCUPolicyExplorerKey, "Nosecuritytab", "Security Tab is Disabled", InfoCollection)

        'Windos update Key Scan
        regshowmsg(HKCUPolicyExplorerKey, "NoWindowsUpdate", "Windows Update is disabled.", InfoCollection)
        regshowmsg("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\WindowsUpdate", _
                   "DisableWindowsUpdateAccess", "Windows Update Disabled.", InfoCollection)


        regshowmsg(HKCUPolicySystemKey, "DisableChangePassword", "Account Password Changing Disabled", InfoCollection)
        regshowmsg(HKCUPolicySystemKey, "DisableLockWorkstation", "Work Satation Lock Disabled", InfoCollection)
        regshowmsg(HKCUPolicySystemKey, "NoDispSettingsPage", "Display Setiing Page Disabled", InfoCollection)
        regshowmsg(HKCUPolicySystemKey, "NoDispAppearancePage", "Display Appearince Page Disabled", InfoCollection)

        'TODO // here need to change c:\ and add for seven
        If Not My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", _
                                                     "Userinit", "C:\WINDOWS\system32\userinit.exe,").ToString.ToUpper _
                                         = "C:\WINDOWS\system32\userinit.exe,".ToUpper Then
            InfoCollection.Add("Logon key : Userinit is altered.")
        End If

        If Not My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", _
                                                     "UIHost", "logonui.exe").ToString.ToUpper _
                                         = "logonui.exe".ToUpper Then
            InfoCollection.Add("Logon key : UIHost is altered.")
        End If


        If Not My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", _
                                                     "Shell", "Explorer.exe").ToString.ToUpper _
                                         = "Explorer.exe".ToUpper Then
            InfoCollection.Add("Logon key : Shell is altered.")
        End If

        Return InfoCollection

    End Function

    Public Shared Function RegDisallowKey() As Microsoft.Win32.RegistryKey
        'Scan For Msconfig.exe Ristriction
        Dim registryKey As Microsoft.Win32.RegistryKey = My.Computer.Registry.CurrentUser
        'This will assign the actual hive key value
        registryKey = registryKey.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun", True)
        ' ----- This is the right key.
        Return registryKey
    End Function


    Shared Function scanregvalue(ByVal reg As String, ByVal value As String) As String
        If My.Computer.Registry.GetValue(reg, value, Nothing) Is Nothing Then
            scanregvalue = -1
        Else
            scanregvalue = My.Computer.Registry.GetValue(reg, value, Nothing)
        End If
    End Function

    Shared Function regshowmsg(ByVal reg As String, ByVal value As String, ByVal msg As String, _
                               ByRef InfoCollection As ArrayList) As Boolean

        Dim data As String = Nothing

        data = My.Computer.Registry.GetValue(reg, value, Nothing)
        If data Is Nothing Then
            'do nothing
        ElseIf data = 1 Then
            InfoCollection.Add(msg)
        End If

    End Function

End Class
