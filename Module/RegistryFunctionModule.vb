'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date : 07/12/2009                               '
'                                                                  '
'******************************************************************'

Module RegistryFunctionModule


#Region "Registry option"

    'collecting keys name of required registrykey

    Friend Function CollectRegistryKeyValue(ByVal RegKey As Microsoft.Win32.RegistryKey, _
                                        ByRef RegValueCollection As ArrayList) As Boolean
        'by this way we cann add more item to array list with out removing 
        'previos content
        'if we want to remove previous content remove it before calling this function
        'RegValueCollection = New ArrayList
        Try
            For Each Key As String In RegKey.GetValueNames
                RegValueCollection.Add(Key)
            Next
        Catch 'ex As Exception
            Return False
        End Try


        Return True
    End Function

    'this function convert registry string to win32 formate
    Friend Function _RegistryWin32Formate _
    (ByVal RegKey As String, ByRef RegKeyOut As Microsoft.Win32.RegistryKey) _
    As Boolean

        Dim Reg_parts As New ArrayList
        Reg_parts.AddRange(RegKey.Split("\"))

        RegKeyOut = Nothing

        Select Case (Reg_parts.Item(0).ToString.ToUpper)
            Case ("HKEY_CURRENT_USER")
                RegKeyOut = My.Computer.Registry.CurrentUser
            Case ("HKCU")
                RegKeyOut = My.Computer.Registry.CurrentUser
            Case ("HKEY_LOCAL_MACHINE")
                RegKeyOut = My.Computer.Registry.LocalMachine
            Case ("HKLM")
                RegKeyOut = My.Computer.Registry.LocalMachine
            Case ("HKEY_USERS")
                RegKeyOut = My.Computer.Registry.Users
            Case ("HKU")
                RegKeyOut = My.Computer.Registry.Users
            Case ("HKEY_CURRENT_CONFIG")
                RegKeyOut = My.Computer.Registry.CurrentConfig
            Case ("HKEY_CLASSES_ROOT")
                RegKeyOut = My.Computer.Registry.ClassesRoot
            Case Else
                'return if regkey out is not in list
                MsgBox("Problem to detect Root Key.")
                Return False
        End Select


        'again building key without root key (SubKey)
        Dim i As Integer
        Dim Subkey As String = ""

        'building SubKey without root key leaving i=0
        For i = 1 To Reg_parts.Count - 1
            Subkey += Reg_parts(i).ToString
            'to remove last "\" from sub key
            If i <> Reg_parts.Count - 1 Then
                Subkey = Subkey + "\"
            End If
        Next

        Try
            RegKeyOut = RegKeyOut.OpenSubKey(Subkey, True)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        'Function is SuccessFull
        Return True
    End Function   'old function

    'this function convert registry string to win32 formate
    'here we will always get a real Registry Key string 
    Friend Function RegistryWin32Formate(ByVal RegKey As String, ByRef RegKeyOut As Microsoft.Win32.RegistryKey, Optional ByVal ShowMsg As Boolean = True) As Boolean
        'if regKey is nothing
        If RegKey = "" Or RegKey = " " Or RegKey = Nothing Then
            Return False
        End If
        'it will remove last "\" if supplide accidently
        RegKey = RegKey.TrimEnd("\")

        Dim Reg_parts As New ArrayList
        Reg_parts.AddRange(RegKey.Split("\"))

        RegKeyOut = Nothing

        Select Case (Reg_parts.Item(0).ToString.ToUpper)
            Case ("HKEY_CURRENT_USER")
                RegKeyOut = My.Computer.Registry.CurrentUser
            Case ("HKCU")
                RegKeyOut = My.Computer.Registry.CurrentUser
            Case ("HKEY_LOCAL_MACHINE")
                RegKeyOut = My.Computer.Registry.LocalMachine
            Case ("HKLM")
                RegKeyOut = My.Computer.Registry.LocalMachine
            Case ("HKEY_USERS")
                RegKeyOut = My.Computer.Registry.Users
            Case ("HKU")
                RegKeyOut = My.Computer.Registry.Users
            Case ("HKEY_CURRENT_CONFIG")
                RegKeyOut = My.Computer.Registry.CurrentConfig
            Case ("HKCC")
                RegKeyOut = My.Computer.Registry.CurrentConfig
            Case ("HKEY_CLASSES_ROOT")
                RegKeyOut = My.Computer.Registry.ClassesRoot
            Case ("HKCR")
                RegKeyOut = My.Computer.Registry.ClassesRoot
            'Case ("HKEY_DYN_DATA")
            '    RegKeyOut = My.Computer.Registry.DynData
            'Case ("HKDD")
            '    RegKeyOut = My.Computer.Registry.DynData
            Case ("HKEY_PERFORMANCE_DATA")
                RegKeyOut = My.Computer.Registry.PerformanceData
            Case ("HKPD")
                RegKeyOut = My.Computer.Registry.PerformanceData
            Case Else
                'return if regkey out is not in list
                If ShowMsg Then MsgBox("Problem to detect Root Key." + vbNewLine + _
                       "Root Key Recieved : " + Reg_parts.Item(0).ToString + vbNewLine + _
                       "It is not a Standard root key." + vbNewLine + _
                       "Please check your registry Entry.", MsgBoxStyle.Exclamation)
                Return False
        End Select

        'here if root registry key is selected then return
        If Reg_parts.Count <= 1 Then
            Return True
        End If

        'here is any slace is supplied at last 
        If Reg_parts.Item(1).ToString = "" Then
            Return True
        End If


        'again building key without root key (SubKey)
        Dim i As Integer
        Dim Subkey As String = ""

        'building SubKey without root key leaving i=0
        For i = 1 To Reg_parts.Count - 1
            Subkey += Reg_parts(i).ToString + "\"
        Next
        'triming last "\"
        Subkey = Subkey.TrimEnd("\")
        ' MsgBox(Subkey)

        'this will open key in write mode and return success
        Try
            RegKeyOut = RegKeyOut.OpenSubKey(Subkey, True)
            'Here this only added to check if RegKeyOut is valid key 
            'because it is not rising any bug or exception if subkey do not exist
            Dim finalstr As String = RegKeyOut.Name
            Return True  'return happily
        Catch ex As Exception
            If ShowMsg Then MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return False '   :(
        End Try

        'Function is SuccessFull
        'Return True
    End Function

    'This function is Designed to build a string which  we can use in .reg file
    Friend Function GetRegStr(ByVal Key As String, ByRef StrOut As String, _
                               Optional ByVal ScanSubKeyOfThisKey As Boolean = False, _
                               Optional ByVal ScanAllKeyOfThisKey As Boolean = False) As Boolean


        Dim regKey As Microsoft.Win32.RegistryKey = Nothing
        If Not RegistryWin32Formate(Key, regKey, False) Then
            '  MsgBox("Problem in registry conversion.")
            Return False
        Else
            'registry found and open

            'now collecting value and data
            Dim RegValueCollection As New ArrayList
            If Not CollectRegistryKeyValue(regKey, RegValueCollection) Then
                Return False
            Else
                'add this registry to file 
                StrOut += vbNewLine + "[" + Key + "]" + vbNewLine
                For Each item As String In RegValueCollection
                    'MsgBox(item.ToString + "    Data :" + My.Computer.Registry.GetValue(regKey.ToString, item, Nothing).ToString)


                    'Dim data As String
                    'data = My.Computer.Registry.GetValue(regKey.ToString, item, Nothing).ToString


                    Select Case regKey.GetValueKind(item)

                        Case RegistryValueKind.String
                            StrOut += """" + item + """" + "=" + """" + regKey.GetValue(item).ToString + """" + vbNewLine

                        Case RegistryValueKind.Binary
                            StrOut += """" + item + """" + "=" + "hex:"
                            Dim ByteReg() As Byte = regKey.GetValue(item)
                            Dim i As Long
                            For i = 0 To ByteReg.LongLength - 1
                                If i <> ByteReg.LongLength - 1 Then
                                    StrOut += Hex(ByteReg(i)).ToString + ","
                                Else
                                    StrOut += Hex(ByteReg(i)).ToString + vbNewLine
                                End If
                            Next
                            'if key is nothing then it will make a new line ....
                            'bug fixed at date 11-10-2009
                            StrOut += vbNewLine
                        Case RegistryValueKind.DWord
                            StrOut += """" + item + """" + "=" + "dword:" + Hex(regKey.GetValue(item)).ToString + vbNewLine

                        Case RegistryValueKind.ExpandString
                            StrOut += """" + item + """" + "=" + "hex(2):"
                            Dim CharReg() As Char = regKey.GetValue(item)

                            Dim i As Long
                            For i = 0 To CharReg.LongLength - 1
                                StrOut += Hex(AscW(CharReg(i))).ToString + ",00,"
                            Next
                            StrOut += "00,00" + vbNewLine

                        Case RegistryValueKind.MultiString
                            StrOut += """" + item + """" + "=" + "hex(7):"
                            Dim StrArr() As String = regKey.GetValue(item)
                            For Each i As String In StrArr
                                For Each SubStr As Char In i.ToCharArray
                                    StrOut += Hex(AscW(SubStr)) + ",00,"
                                Next
                                StrOut += "00,00,"
                            Next
                            StrOut += "00,00" + vbNewLine
                        Case Else
                            'StrOut += """" + item + """" + "=" + """" + regKey.GetValue(item).ToString + """" + vbNewLine
                    End Select


                Next
            End If

            '/''''
            'Again collecting SubKey of this existing key
            'now again sacning this registry for sub key of parrent function allow it
            If ScanSubKeyOfThisKey = True Then
                For Each item As String In regKey.GetSubKeyNames
                    GetRegStr(Key + "\" + item, StrOut, ScanAllKeyOfThisKey, ScanAllKeyOfThisKey)
                Next
            End If

        End If
        Return True
    End Function

#End Region

End Module
