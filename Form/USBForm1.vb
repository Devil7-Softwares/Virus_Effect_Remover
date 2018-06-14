'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date : 07/12/2009                               '
'                                                                  '
'******************************************************************'
Imports Virus_Effect_Remover.NTFS

Public Class USBForm1

#Region "USB restriction process"

    'This function is used to restrict USB storage
    Private Function RestrictUSBStorage() As Boolean
        'apply NTFS restriction in files
        '%SystemRoot%\Inf\Usbstor.pnf
        '%SystemRoot%\Inf\Usbstor.inf 
        'System.Environment.GetEnvironmentVariable("systemroot")+"\Inf\Usbstor.pnf"
        Dim usbstor_pnf As String = System.Environment.GetEnvironmentVariable("systemroot") + "\Inf\Usbstor.pnf"
        Dim usbstor_inf As String = System.Environment.GetEnvironmentVariable("systemroot") + "\Inf\Usbstor.inf"

        ' MsgBox(usbstor_inf + vbNewLine + usbstor_pnf)

        'return if file not exist
        If Not (My.Computer.FileSystem.FileExists(usbstor_pnf) _
        And My.Computer.FileSystem.FileExists(usbstor_pnf)) Then
            MsgBox("Requiered File Missing.", MsgBoxStyle.Exclamation, "File Not Found")
            Return False
        End If

        'Add NTFS permisstion Deny  to "users"
        NTFS.RemoveFullControlToFile(usbstor_pnf)
        NTFS.RemoveFullControlToFile(usbstor_inf)

        ' Note Also add the System account to the Deny list.
        NTFS.RemoveFileSecurity(usbstor_inf, "SYSTEM", Security.AccessControl.FileSystemRights.FullControl, _
                                Security.AccessControl.AccessControlType.Allow)
        'ADDING SYSTEM ACCOUNT DENY PERMISSION
        NTFS.AddFileSecurity(usbstor_inf, "SYSTEM", Security.AccessControl.FileSystemRights.FullControl, _
                             Security.AccessControl.AccessControlType.Deny)


        'again  for next file usbstor_pnf

        NTFS.RemoveFileSecurity(usbstor_pnf, "SYSTEM", Security.AccessControl.FileSystemRights.FullControl, _
                                Security.AccessControl.AccessControlType.Allow)
        'ADDING SYSTEM ACCOUNT DENY PERMISSION
        NTFS.AddFileSecurity(usbstor_pnf, "SYSTEM", Security.AccessControl.FileSystemRights.FullControl, _
                             Security.AccessControl.AccessControlType.Deny)

        'change registry value 3 to 4
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", _
                                      "Start", 4, RegistryValueKind.DWord)
        Return True

    End Function

    'This function is used to allow USB storage
    Private Function AllowUSBStorage() As Boolean
        'apply NTFS restriction in files
        '%SystemRoot%\Inf\Usbstor.pnf
        '%SystemRoot%\Inf\Usbstor.inf 
        'System.Environment.GetEnvironmentVariable("systemroot")+"\Inf\Usbstor.pnf"
        Dim usbstor_pnf As String = System.Environment.GetEnvironmentVariable("systemroot") + "\Inf\Usbstor.pnf"
        Dim usbstor_inf As String = System.Environment.GetEnvironmentVariable("systemroot") + "\Inf\Usbstor.inf"

        'MsgBox(usbstor_inf + vbNewLine + usbstor_pnf)

        'return if file not exist
        If Not (My.Computer.FileSystem.FileExists(usbstor_pnf) _
        And My.Computer.FileSystem.FileExists(usbstor_pnf)) Then
            MsgBox("Requiered File Missing.", MsgBoxStyle.Exclamation, "File Not Found")
            Return False
        End If

        'Add NTFS permisstion allow  to "users"
        NTFS.AddFullcontrolToFile(usbstor_pnf)
        NTFS.AddFullcontrolToFile(usbstor_inf)


        ' Note Also add the System account to the allow list.


        NTFS.RemoveFileSecurity(usbstor_inf, "SYSTEM", Security.AccessControl.FileSystemRights.FullControl, _
                                Security.AccessControl.AccessControlType.Deny)
        'ADDING SYSTEM ACCOUNT allow PERMISSION
        NTFS.AddFileSecurity(usbstor_inf, "SYSTEM", Security.AccessControl.FileSystemRights.FullControl, _
                             Security.AccessControl.AccessControlType.Allow)


        'again  for next file usbstor_pnf

        NTFS.RemoveFileSecurity(usbstor_pnf, "SYSTEM", Security.AccessControl.FileSystemRights.FullControl, _
                                Security.AccessControl.AccessControlType.Deny)
        'ADDING SYSTEM ACCOUNT Allow PERMISSION
        NTFS.AddFileSecurity(usbstor_pnf, "SYSTEM", Security.AccessControl.FileSystemRights.FullControl, _
                             Security.AccessControl.AccessControlType.Allow)

        'change registry value 4 to 3
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", _
                                      "Start", 3, RegistryValueKind.DWord)
        Return True

    End Function

#End Region


    Private Sub USBForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'changing  detecting check box status
        If My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", "Start", Nothing) = 4 Then
            USBCheckBox.Checked = True
        Else
            USBCheckBox.Checked = False
        End If

        CheckBoxWRPro.Checked = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\StorageDevicePolicies", "WriteProtect", 0)



    End Sub

    Private Sub CheckBoxWRPro_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBoxWRPro.Click
        Try

            My.Computer.Registry.SetValue _
             ("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\StorageDevicePolicies", _
              "WriteProtect", CheckBoxWRPro.Checked, RegistryValueKind.DWord)


            'reboot option
            MsgBox("Reboot system to take effect...", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub USBCheckBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles USBCheckBox.Click
        If USBCheckBox.Checked Then
            'start restriction....
            'Check for already Restricted..
            'if registry is existed means restricted
            If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", _
                                             "Start", Nothing) = 4 Then
                If MsgBox("USB storage is already restricted." + vbNewLine + "Do you want to refresh Status?", _
                         MsgBoxStyle.Exclamation Or MsgBoxStyle.OkCancel, "Stoping USB storage.") _
                         = MsgBoxResult.Cancel Then
                    Return
                End If

            End If
            'else start Restriction process

            If Not RestrictUSBStorage() Then
                MsgBox("Error occured during USB storage Device Restriction.", MsgBoxStyle.Exclamation, "Error")
            Else
                MsgBox("Reboot system to take effect...", MsgBoxStyle.Information)
            End If


        Else
            'stop restricion .....
            If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", _
                                             "Start", Nothing) <> 4 Then
                If MsgBox("USB storage is not restricted." + vbNewLine + "Do you want to refresh Status?", _
                          MsgBoxStyle.Exclamation Or MsgBoxStyle.OkCancel, "Allowing USB storage.") _
                          = MsgBoxResult.Cancel Then
                    Return
                End If

            End If


            If Not AllowUSBStorage() Then
                MsgBox("Error occured during starting  USB storage Device.", MsgBoxStyle.Exclamation, "Error")
            Else
                MsgBox("Reboot system to take effect...", MsgBoxStyle.Information)
            End If

        End If
    End Sub

End Class