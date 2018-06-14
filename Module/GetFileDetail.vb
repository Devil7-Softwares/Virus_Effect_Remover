'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date : 10/12/2009                               '
'                                                                  '
'******************************************************************'

Imports System
Imports System.IO
Imports System.Text


Module GetFileDetail


    'Return File size
    Friend Function GetFileSize(ByVal MyFilePath As String) As Long

        Try
            Dim MyFile As New System.IO.FileInfo(MyFilePath)
            Dim FileSize As Long = MyFile.Length
            Return FileSize
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Friend Function _PathByID(ByVal id) As String
        On Error Resume Next
        Dim pro = Nothing
        Dim colpro

        colpro = GetObject("winmgmts:").ExecQuery("Select * from Win32_Process where processid=" & id)
        If colpro.count <> 0 Then
            For Each pro In colpro
                Return pro.executablepath
            Next
            Return Nothing
        Else
            Return Nothing
        End If

    End Function

    Friend Function _NameByID(ByVal id) As String
        On Error Resume Next
        Dim pro = Nothing
        Dim colpro
        colpro = GetObject("winmgmts:").ExecQuery("Select * from Win32_Process where processid=" & id)

        If colpro.count <> 0 Then
            For Each pro In colpro
                Return pro.name.ToString
            Next
            Return Nothing
        Else
            Return Nothing
        End If

    End Function


    




    'This Sub NotepadDetail Generate a notepad file and send detail to that file

    ' application name like notepad or word pad
    ' ComplitePath "c:\Temp\Detail.text"
    ' TextKeys :- Text which is be send
    ' ClearText :- Previous text will be cleared if True vice-versa
    ' AtStaring :- Text inserted  at the starting if true  if Clearetext value is false

#Region "NotePadDetail"


    '    Friend Sub _NotepadDetail(ByVal ApplicationName As String, ByVal ComplitePath As String, _
    '                              ByVal TextKeys As String, ByVal ClearText As Boolean, _
    '                              ByVal AtStarting As Boolean)
    '        'Creating a new process
    '        Dim p As Process
    '        p = New Process

    '        'Check for allready Existance of file
    '        If My.Computer.FileSystem.FileExists(ComplitePath) Then     '    "c:\Temp\Detail.txt") Then
    '            'If Exixt then run this File
    '            p = Process.Start(ComplitePath)                         '    "c:\Temp\Detail.txt")

    '            'this label stands for again attempt after a short period
    'AttemptAgain1:

    '            'Activate This Process
    '            Try
    '                AppActivate(p.Id)
    '            Catch ex As System.ArgumentException
    '                'Holding for some time and again try
    '                System.Threading.Thread.Sleep(100)
    '                GoTo AttemptAgain1
    '            End Try

    '        Else
    '            'First Creating Directory  if not Exist
    '            If Not My.Computer.FileSystem.DirectoryExists( _
    '                My.Computer.FileSystem.GetParentPath(ComplitePath)) Then                                 '      "C:\Temp") Then
    '                My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.GetParentPath(ComplitePath))
    '            End If

    '            'Now Starting Process Defined in Application name
    '            p = Process.Start(ApplicationName)

    '            'this label stands for again attempt after a short period
    'AttemptAgain2:
    '            Try
    '                AppActivate(p.Id)
    '            Catch ex As System.ArgumentException
    '                System.Threading.Thread.Sleep(100)
    '                GoTo AttemptAgain2
    '            End Try

    '            'This Line function  is to  Save the file at   ComplitePath  like c:\detail.txt  
    '            System.Windows.Forms.SendKeys.SendWait("^s" + ComplitePath + "~")
    '        End If
    '        '  System.Threading.Thread.Sleep(300)

    '        'Clearing text 
    '        If ClearText = True Then
    '            'This Will Select All Text 
    '            System.Windows.Forms.SendKeys.SendWait("^a")
    '            'This Will Delete
    '            System.Windows.Forms.SendKeys.SendWait("{DEL}")
    '        Else
    '            If AtStarting = False Then
    '                'This Key send Curser to last   Ctrl + End
    '                System.Windows.Forms.SendKeys.SendWait("^{END}")
    '                'This Start A new line Enter
    '                System.Windows.Forms.SendKeys.SendWait("~")
    '            Else
    '                'Adding an Enter key At Last of the recieved text 
    '                'it makes a new line starting for old text
    '                TextKeys = TextKeys + "~"
    '            End If
    '        End If

    '        'formatiing textbox text because Eachline appeare after 2 line .
    '        'THen We eliminate 1 Enter Strok  by splitting it 
    '        Dim TotalText As String = ""
    '        For Each line In TextKeys.Split(ChrW(10).ToString)
    '            TotalText += line
    '        Next
    '        'now totaltext is complitely formated

    '        'Adding Sent keys
    '        System.Windows.Forms.SendKeys.Send(TotalText)

    '        'Saving file
    '        System.Windows.Forms.SendKeys.SendWait("^s")
    '    End Sub


    'Advance Notepad generation of file detail
    Friend Sub NotePadDetail(ByVal ComplitePath As String, ByVal TextString As String, _
                             ByVal ClearText As Boolean, ByVal OpenFile As Boolean)
        'before doing any thing 
        'first we will check that the path is ready to write file or not
        'i.e. drive is not read only 
        Dim DriveName As New DriveInfo(ComplitePath)
        If (DriveName.DriveType = DriveType.CDRom) Or _
           (DriveName.DriveType = DriveType.Ram) Then
            'let user select what he want to do.
            If MsgBox("Target Drive is ReadOnly." + vbNewLine + "Do you want to continue any way?", _
                      MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                'if yes selected function will proceed as it is .
                'but there will be great chance to get a exception.

                'if no selected then ask user if he want to store file in other place
                If MsgBox("Would you like to store File in other place?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    'if user do not want to save it return..
                    MsgBox("File is not stored...", MsgBoxStyle.Information)
                    Return
                Else
                    'if user want to store , open folder browser
                    Dim FolderBrowserDialog As New FolderBrowserDialog
                    FolderBrowserDialog.ShowNewFolderButton = True
                    FolderBrowserDialog.ShowDialog()

                    'getting folder name 
                    Dim FolderName As String = FolderBrowserDialog.SelectedPath
                    'check if path is not correct
                    If My.Computer.FileSystem.DirectoryExists(FolderName) Then
                        'resend file generate function to current selected root
                        Dim FileName As New IO.FileInfo(ComplitePath)
                        NotePadDetail(FolderName + "\" + FileName.Name, TextString, ClearText, OpenFile)
                        Return
                    Else
                        'if path is not exist , return.
                        MsgBox("Invalid Folder Path.", MsgBoxStyle.Exclamation)
                        Return
                    End If


                End If
            End If
        End If



        '**************************
        'Storing file 
        Try

            'Parent Dir where we will store file
            Dim Dir As String = My.Computer.FileSystem.GetParentPath(ComplitePath)

            ' Checking for file and directory Existance
            If File.Exists(ComplitePath) = False Then
                'check for directory
                If Not System.IO.Directory.Exists(Dir) Then
                    System.IO.Directory.CreateDirectory(Dir)
                End If
                'First time File Creation with Nothing text

                'if the directory is read only or system then access Eror will occure.
                'so by setting attribute to normal we can add any content to file .
                Dim dirInfo As New IO.DirectoryInfo _
                (My.Computer.FileSystem.GetParentPath(ComplitePath))
                dirInfo.Attributes = FileAttributes.Normal
                'creating file
                File.WriteAllText(ComplitePath, "")
            End If

            ' Create a file to write to.
            If ClearText = True Then
                File.WriteAllText(ComplitePath, TextString)
            Else
                File.AppendAllText(ComplitePath, TextString)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return
        End Try


        'Opening File
        If OpenFile = True Then
            Try
                Dim p As New ProcessStartInfo("notepad.exe")
                p.Arguments = ComplitePath
                p.WindowStyle = ProcessWindowStyle.Maximized
                System.Diagnostics.Process.Start(p)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

#End Region

    'This Function Uses ForceDel.exe to delete file 
    'http://www.codeguru.com/Cpp/W-P/files/fileio/article.php/c1287/
    ' Dim str as String  = ForceToDelete("c:\ForceDel.exe", "c:\1.mp3")

    'FORCEDEL.EXE [/S] filename
    '/S             Soft delete. Like the "del" command
    'filename       File name you want to delete

    'Here we do not use soft Delete

    'now it is  not use ful because forcedel.exe was infected by virus


    'Friend Function ForceToDelete(ByVal strFileName As String, ByVal strArguments As String) As String
    '    'mainly strFileNAme = Application .ExecutablePath +"\FORCEDEL.EXE"
    '    'If ForceDel.exe file is not Present In the Given Location
    '    If Not System.IO.File.Exists(strFileName) Then
    '        'Disabling Force to delete tab and other related control
    '        '****** Add control here
    '        '
    '        Return "ForceDel.exe File is not Found"
    '    End If

    '    'testing for target file
    '    If Not IO.File.Exists(strArguments) Then
    '        Return "Target File not Exist."
    '    End If

    '    'Here We can also normalize attribute of file and can get NTFS security privilage
    '    '********
    '    '

    '    Dim psi As ProcessStartInfo = New ProcessStartInfo()
    '    Dim sb As StringBuilder = New StringBuilder()               ' use system.text

    '    Try
    '        psi.WindowStyle = ProcessWindowStyle.Normal

    '        '//Need to include this for Executable version (appears not to be needed if UseShellExecute=true)
    '        'YOu can say Runnig it silently
    '        psi.CreateNoWindow = True
    '        psi.FileName = strFileName
    '        psi.Arguments = strArguments
    '        psi.UseShellExecute = False
    '        psi.RedirectStandardOutput = True
    '        psi.RedirectStandardError = True

    '        'Now running forceDel to delete the file 
    '        Dim p As Process = Process.Start(psi)
    '        'now save the responce to the string builder
    '        sb.Append(p.StandardOutput.ReadToEnd())
    '        sb.Append(p.StandardError.ReadToEnd())
    '        'wait to properly ending of forceDel 
    '        p.WaitForExit()
    '    Catch ex As Exception
    '        sb.Append("\r\nPROCESS_ERROR:" + ex.ToString())
    '    End Try

    '    Return sb.ToString()
    'End Function

    'this function is returning any size in GB, MB, KB or as byte
    

    Friend Function ByteSizeOptimaized(ByVal DrvSz As Long) As String

        On Error Resume Next
        'this will help if after "." i.e.decimal point there will be less than one digit

        Dim DrvSzStr As String = DrvSz.ToString

        'in Gb
        If (DrvSz >= (1024 * 1024 * 1024)) Then
            DrvSzStr = (DrvSz / (1024 * 1024 * 1024)).ToString
            If DrvSzStr.IndexOf(".") < 0 Then
                DrvSzStr += " GB"
            Else
                DrvSzStr = DrvSzStr.Remove(DrvSzStr.IndexOf(".") + 3, DrvSzStr.Length - DrvSzStr.IndexOf(".") - 3)
                DrvSzStr += " GB"
            End If
            Return DrvSzStr
        End If

        'in mb
        If (DrvSz >= (1024 * 1024)) Then
            DrvSzStr = (DrvSz / (1024 * 1024)).ToString
            If DrvSzStr.IndexOf(".") < 0 Then
                DrvSzStr += " MB"
            Else
                DrvSzStr = DrvSzStr.Remove(DrvSzStr.IndexOf(".") + 3, DrvSzStr.Length - DrvSzStr.IndexOf(".") - 3)
                DrvSzStr += " MB"
            End If
            Return DrvSzStr
        End If

        'in Kb
        If (DrvSz >= (1024)) Then
            DrvSzStr = (DrvSz / 1024).ToString
            If DrvSzStr.IndexOf(".") < 0 Then
                DrvSzStr += " KB"
            Else
                DrvSzStr = DrvSzStr.Remove(DrvSzStr.IndexOf(".") + 3, DrvSzStr.Length - DrvSzStr.IndexOf(".") - 3)
                DrvSzStr += " KB"
            End If
            Return DrvSzStr
        End If

        Return DrvSzStr + " Byte"
    End Function

    'this function will help tu extract path and arg
    Friend Function ExtactPathAndArgument(ByVal CommandLine As String, ByRef path As String, Optional ByRef ArgumentString As String = "") As Boolean
        '  Try
        On Error Resume Next
        'first try to get path by api methode
        path = CommandLine
        ArgumentString = ""
        '-----------------------------------
        'removing "/" which is added to use command line  like  c:\str.exe /all
        If Not CommandLine.IndexOf("/") < 0 Then
            path = CommandLine.Split("/")(0).Trim.Trim("""")  'removing "" will be help full
            ArgumentString = CommandLine.Remove(0, CommandLine.IndexOf("/"))
            If My.Computer.FileSystem.FileExists(path) Then
                'GoTo StartBuild
                Return True
            End If
        End If


        'removing """"  which is used to incapsulate file path like "c:\sys.exe"
        path = path.Trim("""").Trim
        If My.Computer.FileSystem.FileExists(path) Then
            'GoTo StartBuild
            ArgumentString = String.Empty
            Return True
        End If


        'removaing - from file name is not standard but os have seen some startup containing this 
        'so at last removing - is dont to get an other attemp to get file path
        path = path.Split("-")(0).Trim
        If My.Computer.FileSystem.FileExists(path) Then
            ArgumentString = path.Remove(0, path.IndexOf("-"))
            Return True
            'GoTo StartBuild
        End If

        '2nd see if path is not a only file name ( like :  "Soundman.exe"   not "C:\windows\SoundMan.exe")
        'search "\" in string
        If SearchFileInSystemDir(path) Then
            Return True
        End If

        'atlasr call api
        ArgumentString = VERAPI.Win32.PathGetArgs(CommandLine)
        Dim pathstr As New StringBuilder(CommandLine)
        VERAPI.Win32.PathRemoveArgs(pathstr)
        path = pathstr.ToString.Trim("""")
        If My.Computer.FileSystem.FileExists(path) Then
            Return True
        End If

        If SearchFileInSystemDir(path) Then
            Return True
        End If

        'if path is %windir%\system32\taskmgr.exe
        'then
        path = VERAPI.Win32.UnqouteSpaces(path)
        path = Environment.ExpandEnvironmentVariables(path)

        If My.Computer.FileSystem.FileExists(path) Then
            Return True
        End If

        'here file is not found any where so this will be usefull to make path as empty string
        path = String.Empty

        Return False
        '  Catch ex As Exception
        ' path = ""
        ' ArgumentString = ""
        'Return False
        ' End Try
    End Function

    'search for only file name
    Friend Function SearchFileInSystemDir(ByRef path As String) As Boolean
        If Not Path.Contains("\") Then
            'search in windows
            If My.Computer.FileSystem.FileExists(windir + "\" + Path) Then
                Path = windir + "\" + Path
                Return True
                'GoTo StartBuild
            End If
            'search in system32
            If My.Computer.FileSystem.FileExists(windir + "\System32\" + Path) Then
                Path = windir + "\System32\" + Path
                Return True
                'GoTo StartBuild
            End If
        End If
        Return False
    End Function



End Module
