'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date : 24/12/2009                               '
'                                                                  '
'******************************************************************'

Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text

Namespace VERAPI

    Public Class Win32

#Region "        Shlwapi.dll       "
#Region "   Declared Function      "
        <DllImport("Shlwapi.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
        Public Shared Function PathGetArgs(ByVal path As String) As String
        End Function
        <DllImport("Shlwapi.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
        Public Shared Sub PathRemoveArgs(<[In](), Out()> ByVal path As StringBuilder)
        End Sub
        <DllImport("Shlwapi.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
        Public Shared Function PathParseIconLocation(<[In](), Out()> ByVal path As StringBuilder) As Integer
        End Function
        <DllImport("Shlwapi.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
        Public Shared Sub PathUnquoteSpaces(<[In](), Out()> ByVal path As StringBuilder)
        End Sub
        <DllImport("Shlwapi.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
        Public Shared Function PathFileExists(ByVal path As String) As Boolean
        End Function
        <DllImport("Shlwapi.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
        Public Shared Function PathStripToRoot(<[In](), Out()> ByVal path As StringBuilder) As Boolean
        End Function
        <DllImport("Shlwapi.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
        Public Shared Function PathRemoveFileSpec(<[In](), Out()> ByVal path As StringBuilder) As Boolean
        End Function
#End Region

#Region "  Related Function  "
        ''' <summary>
        ''' Removes quotes from the path
        ''' </summary>
        ''' <param name="Path">Path w/ quotes</param>
        ''' <returns>Path w/o quotes</returns>
        Public Shared Function UnqouteSpaces(ByVal Path As String) As String
            Dim sb As New StringBuilder(Path)
            PathUnquoteSpaces(sb)
            Return String.Copy(sb.ToString())
        End Function
#End Region

#End Region



    End Class

End Namespace
