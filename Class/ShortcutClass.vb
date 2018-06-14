Imports System.Text
Imports System.Runtime.InteropServices

Public Class ShortcutClass
    Private Const STGM_READ As UInteger = 0
    Private Const MAX_PATH As Integer = 260

    ' CLSID_ShellLink from ShlGuid.h 
    <ComImport(), Guid("00021401-0000-0000-C000-000000000046")> _
    Private Class ShellLink
    End Class

    ''' <summary>The IShellLink interface allows Shell links to be created, modified, and resolved</summary>
    <ComImport(), InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("000214F9-0000-0000-C000-000000000046")> _
   Private Interface IShellLinkW
        ''' <summary>Retrieves the path and file name of a Shell link object</summary>
        Sub GetPath(<Out(), MarshalAs(UnmanagedType.LPWStr)> ByVal pszFile As StringBuilder, ByVal cchMaxPath As Integer, <System.Runtime.InteropServices.Out()> ByRef pfd As WIN32_FIND_DATAW, ByVal fFlags As SLGP_FLAGS)
        ''' <summary>Retrieves the list of item identifiers for a Shell link object</summary>
        Sub GetIDList(<System.Runtime.InteropServices.Out()> ByRef ppidl As IntPtr)
        ''' <summary>Sets the pointer to an item identifier list (PIDL) for a Shell link object.</summary>
        Sub SetIDList(ByVal pidl As IntPtr)
        ''' <summary>Retrieves the description string for a Shell link object</summary>
        Sub GetDescription(<Out(), MarshalAs(UnmanagedType.LPWStr)> ByVal pszName As StringBuilder, ByVal cchMaxName As Integer)
        ''' <summary>Sets the description for a Shell link object. The description can be any application-defined string</summary>
        Sub SetDescription(<MarshalAs(UnmanagedType.LPWStr)> ByVal pszName As String)
        ''' <summary>Retrieves the name of the working directory for a Shell link object</summary>
        Sub GetWorkingDirectory(<Out(), MarshalAs(UnmanagedType.LPWStr)> ByVal pszDir As StringBuilder, ByVal cchMaxPath As Integer)
        ''' <summary>Sets the name of the working directory for a Shell link object</summary>
        Sub SetWorkingDirectory(<MarshalAs(UnmanagedType.LPWStr)> ByVal pszDir As String)
        ''' <summary>Retrieves the command-line arguments associated with a Shell link object</summary>
        Sub GetArguments(<Out(), MarshalAs(UnmanagedType.LPWStr)> ByVal pszArgs As StringBuilder, ByVal cchMaxPath As Integer)
        ''' <summary>Sets the command-line arguments for a Shell link object</summary>
        Sub SetArguments(<MarshalAs(UnmanagedType.LPWStr)> ByVal pszArgs As String)
        ''' <summary>Retrieves the hot key for a Shell link object</summary>
        Sub GetHotkey(<System.Runtime.InteropServices.Out()> ByRef pwHotkey As Short)
        ''' <summary>Sets a hot key for a Shell link object</summary>
        Sub SetHotkey(ByVal wHotkey As Short)
        ''' <summary>Retrieves the show command for a Shell link object</summary>
        Sub GetShowCmd(<System.Runtime.InteropServices.Out()> ByRef piShowCmd As Integer)
        ''' <summary>Sets the show command for a Shell link object. The show command sets the initial show state of the window.</summary>
        Sub SetShowCmd(ByVal iShowCmd As Integer)
        ''' <summary>Retrieves the location (path and index) of the icon for a Shell link object</summary>
        Sub GetIconLocation(<Out(), MarshalAs(UnmanagedType.LPWStr)> ByVal pszIconPath As StringBuilder, ByVal cchIconPath As Integer, <System.Runtime.InteropServices.Out()> ByRef piIcon As Integer)
        ''' <summary>Sets the location (path and index) of the icon for a Shell link object</summary>
        Sub SetIconLocation(<MarshalAs(UnmanagedType.LPWStr)> ByVal pszIconPath As String, ByVal iIcon As Integer)
        ''' <summary>Sets the relative path to the Shell link object</summary>
        Sub SetRelativePath(<MarshalAs(UnmanagedType.LPWStr)> ByVal pszPathRel As String, ByVal dwReserved As Integer)
        ''' <summary>Attempts to find the target of a Shell link, even if it has been moved or renamed</summary>
        Sub Resolve(ByVal hwnd As IntPtr, ByVal fFlags As SLR_FLAGS)
        ''' <summary>Sets the path and file name of a Shell link object</summary>
        Sub SetPath(<MarshalAs(UnmanagedType.LPWStr)> ByVal pszFile As String)

    End Interface

    <Flags()> _
    Private Enum SLR_FLAGS
        ''' <summary>
        ''' Do not display a dialog box if the link cannot be resolved. When SLR_NO_UI is set,
        ''' the high-order word of fFlags can be set to a time-out value that specifies the
        ''' maximum amount of time to be spent resolving the link. The function returns if the
        ''' link cannot be resolved within the time-out duration. If the high-order word is set
        ''' to zero, the time-out duration will be set to the default value of 3,000 milliseconds
        ''' (3 seconds). To specify a value, set the high word of fFlags to the desired time-out
        ''' duration, in milliseconds.
        ''' </summary>
        SLR_NO_UI = &H1
        ''' <summary>Obsolete and no longer used</summary>
        SLR_ANY_MATCH = &H2
        ''' <summary>If the link object has changed, update its path and list of identifiers.
        ''' If SLR_UPDATE is set, you do not need to call IPersistFile::IsDirty to determine
        ''' whether or not the link object has changed.</summary>
        SLR_UPDATE = &H4
        ''' <summary>Do not update the link information</summary>
        SLR_NOUPDATE = &H8
        ''' <summary>Do not execute the search heuristics</summary>
        SLR_NOSEARCH = &H10
        ''' <summary>Do not use distributed link tracking</summary>
        SLR_NOTRACK = &H20
        ''' <summary>Disable distributed link tracking. By default, distributed link tracking tracks
        ''' removable media across multiple devices based on the volume name. It also uses the
        ''' Universal Naming Convention (UNC) path to track remote file systems whose drive letter
        ''' has changed. Setting SLR_NOLINKINFO disables both types of tracking.</summary>
        SLR_NOLINKINFO = &H40
        ''' <summary>Call the Microsoft Windows Installer</summary>
        SLR_INVOKE_MSI = &H80
    End Enum

    <ComImport(), Guid("0000010c-0000-0000-c000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)> _
    Public Interface IPersist
        <PreserveSig()> _
        Sub GetClassID(<System.Runtime.InteropServices.Out()> ByRef pClassID As Guid)
    End Interface

    <Flags()> _
    Private Enum SLGP_FLAGS
        ''' <summary>Retrieves the standard short (8.3 format) file name</summary>
        SLGP_SHORTPATH = &H1
        ''' <summary>Retrieves the Universal Naming Convention (UNC) path name of the file</summary>
        SLGP_UNCPRIORITY = &H2
        ''' <summary>Retrieves the raw path name. A raw path is something that might not exist and may include environment variables that need to be expanded</summary>
        SLGP_RAWPATH = &H4
    End Enum

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Auto)> _
    Private Structure WIN32_FIND_DATAW
        Public dwFileAttributes As UInteger
        Public ftCreationTime As Long
        Public ftLastAccessTime As Long
        Public ftLastWriteTime As Long
        Public nFileSizeHigh As UInteger
        Public nFileSizeLow As UInteger
        Public dwReserved0 As UInteger
        Public dwReserved1 As UInteger
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)> _
        Public cFileName As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=14)> _
        Public cAlternateFileName As String
    End Structure

    <ComImport(), Guid("0000010b-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)> _
    Private Interface IPersistFile
        Inherits IPersist
        Shadows Sub GetClassID(<System.Runtime.InteropServices.Out()> ByRef pClassID As Guid)
        <PreserveSig()> _
        Function IsDirty() As Integer

        <PreserveSig()> _
        Sub Load(<[In](), MarshalAs(UnmanagedType.LPWStr)> ByVal pszFileName As String, ByVal dwMode As UInteger)

        <PreserveSig()> _
        Sub Save(<[In](), MarshalAs(UnmanagedType.LPWStr)> ByVal pszFileName As String, <[In](), MarshalAs(UnmanagedType.Bool)> ByVal fRemember As Boolean)

        <PreserveSig()> _
        Sub SaveCompleted(<[In](), MarshalAs(UnmanagedType.LPWStr)> ByVal pszFileName As String)

        <PreserveSig()> _
        Sub GetCurFile(<[In](), MarshalAs(UnmanagedType.LPWStr)> ByVal ppszFileName As String)
    End Interface

    ''' <summary>
    ''' Resolves path to .lnk shortcut
    ''' </summary>
    ''' <param name="shortcut">The path to the shortcut</param>
    ''' <param name="filepath">Returns the file path</param>
    ''' <param name="arguments">Returns the shortcuts arguments</param>
    ''' <returns>Returns false if the filepath doesnt exist</returns>
    Public Shared Function ResolveShortcut(ByVal shortcut As String, <System.Runtime.InteropServices.Out()> ByRef filepath As String, <System.Runtime.InteropServices.Out()> ByRef arguments As String) As Boolean
        Dim link As New ShellLink()
        CType(link, IPersistFile).Load(shortcut, STGM_READ)
        ' TODO: if I can get hold of the hwnd call resolve first. This handles moved and renamed files.  
        ' ((IShellLinkW)link).Resolve(hwnd, 0) 
        Dim path As New StringBuilder(MAX_PATH)
        Dim data As New WIN32_FIND_DATAW()
        CType(link, IShellLinkW).GetPath(path, path.Capacity, data, 0)

        Dim args As New StringBuilder(MAX_PATH)
        CType(link, IShellLinkW).GetArguments(args, args.Capacity)

        filepath = path.ToString()
        arguments = args.ToString()

        ' If (Not Utils.FileExists(filepath)) Then
        'Return False
        'End If

        Return True
    End Function
End Class
