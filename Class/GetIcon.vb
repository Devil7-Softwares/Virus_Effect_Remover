'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date : 07/12/2009                               '
'                                                                  '
'******************************************************************'
Imports System.Runtime.InteropServices

#Region "Bug Detail"
'bug can occure due to in sufficient privilage for file access
'If this occures then try to get icon getting file rights
'but right now i am not added this function
'i will return red icon to show errro
#End Region


Public Class GetICON

    Public Shared ErrorIcon As Icon = (Icon.FromHandle(My.Resources.block_32.GetHicon))

#Region "Windows API and delaration"
    Private Structure SHFILEINFO
        Public hIcon As IntPtr ' : icon
        Public iIcon As Integer ' : icondex
        Public dwAttributes As Integer ' : SFGAO_ flags
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)> _
        Public szDisplayName As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=80)> _
        Public szTypeName As String
    End Structure

    Private Declare Ansi Function SHGetFileInfo Lib "shell32.dll" (ByVal pszPath As String, _
    ByVal dwFileAttributes As Integer, ByRef psfi As SHFILEINFO, ByVal cbFileInfo As Integer, _
    ByVal uFlags As Integer) As IntPtr

    Private Const SHGFI_ICON = &H100
    Private Const SHGFI_SMALLICON = &H1         ' Samll Icon
    Private Const SHGFI_LARGEICON = &H0         ' Large icon
    'Private nIndex = 0
    'zero for  Large 
    'one for small
#End Region

    Shared Function GetFileIcon(ByVal FilePath As String, ByVal IconSize As Boolean, _
                                Optional ByRef ex As Exception = Nothing) As Icon

        Try
            If Not My.Computer.FileSystem.FileExists(FilePath) Then
                Return ErrorIcon
            End If

            Dim hImgSmall As IntPtr  'The handle to the system image list.
            Dim hImgLarge As IntPtr  'The handle to the system image list.
            'Dim fName As String      'The file name to get the icon from.
            Dim shinfo As SHFILEINFO
            shinfo = New SHFILEINFO()

            shinfo.szDisplayName = New String(Chr(0), 260)
            shinfo.szTypeName = New String(Chr(0), 80)

            If IconSize = 1 Then
                'Use this to get the small icon.
                hImgSmall = SHGetFileInfo(FilePath, 0, shinfo, Marshal.SizeOf(shinfo), _
                 SHGFI_ICON Or SHGFI_SMALLICON)
            Else
                'Use this to get the Large icon.
                hImgLarge = SHGetFileInfo(FilePath, 0, shinfo, Marshal.SizeOf(shinfo), _
                  SHGFI_ICON Or SHGFI_LARGEICON)
            End If



            'Use this to get the small icon.
            'hImgSmall = SHGetFileInfo(FilePath, 0, shinfo, Marshal.SizeOf(shinfo), _
            ' SHGFI_ICON Or SHGFI_SMALLICON)


            'Use this to get the large icon.
            'hImgLarge = SHGetFileInfo(fName, 0, 
            'ref shinfo, (uint)Marshal.SizeOf(shinfo), 
            'SHGFI_ICON | SHGFI_LARGEICON);

            'The icon is returned in the hIcon member of the shinfo struct.
            ' Dim myIcon As System.Drawing.Icon
            ' myIcon = System.Drawing.Icon.FromHandle(shinfo.hIcon)
            ' Return myIcon

            Return System.Drawing.Icon.FromHandle(shinfo.hIcon)
            'quiting from function
        Catch ex 'As Exception
            Return ErrorIcon
        End Try


    End Function

End Class