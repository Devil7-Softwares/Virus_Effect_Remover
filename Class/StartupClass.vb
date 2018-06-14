Imports System
Imports System.Windows.Forms
Imports System.Diagnostics.Process

Public Class StartupClass


    Shared Sub main()

        If (Environment.Version.Major < 2) Then
            MessageBox.Show("Applicatipn need Framework vertion 2 or higher. Plz Install to run Application.", "Framework Needed.")
            Return
        End If

        For Each p As Process In Process.GetProcesses
            Try
                If My.Computer.FileSystem.GetParentPath(p.MainModule.FileName.ToUpper) = Application.StartupPath.ToUpper Then

                    If Process.GetCurrentProcess.Id = p.Id Then
                        'MsgBox("same")  ' do nothiing
                    Else
                        MsgBox("Virus Effect Remover is Already Running.")
                        Return
                    End If
                End If
            Catch
            End Try
        Next

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New SplashScreen1())


    End Sub

End Class
