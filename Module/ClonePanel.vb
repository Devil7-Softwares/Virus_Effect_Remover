
Imports System.IO

Module ClonePanel
    Friend TotalErrorInformaition As String = ""
    Public FileCollection As ArrayList
    Friend i As Integer = 0
    ' return 0 if error occured
    ' return 1 if File is equal and have Differentpath
    ' return 2 if file is equal an hv same path
    ' return 3 if File is same size but different
    ' return 4 if File is completely different

    Friend Function CompareFiles(ByVal filePathOne As String, ByVal filePathTwo As String) As Integer
        Try
            Dim fileOneByte As Integer
            Dim fileTwoByte As Integer
            Dim fileOneStream As FileStream
            Dim fileTwoStream As FileStream

            ' If user has selected the same file as file one and file two....
            If (filePathOne = filePathTwo) Then
                '"Files are the same. file one is file two."
                Return 2
            End If


            ' Open a FileStream for each file.
            fileOneStream = New FileStream(filePathOne, FileMode.Open, FileAccess.Read)
            fileTwoStream = New FileStream(filePathTwo, FileMode.Open, FileAccess.Read)

            ' If the files are not the same length...
            If (fileOneStream.Length <> fileTwoStream.Length) Then
                fileOneStream.Close()
                fileTwoStream.Close()
                '"Files are not the same length. they are not equal."
                Return 4
            End If


            ' Loop through bytes in the files until
            '  a byte in file one <> a byte in file two
            ' works untill  end of the file one is reached.

            Do
                ' Read one byte from each file.
                fileOneByte = fileOneStream.ReadByte()
                fileTwoByte = fileTwoStream.ReadByte()
                'MsgBox(fileOneByte.ToString + "  =   " + fileTwoByte.ToString)

                If fileOneByte <> fileTwoByte Then
                    ' Files are not equal; byte in file one <> byte in file two.
                    '"Files are not equal. contents are different."
                    'Closing both file stream
                    fileOneStream.Close()
                    fileTwoStream.Close()

                    'returning 3 which stand for same size but different content
                    Return 3
                End If
            Loop While (fileOneByte <> -1)

            'Close the FileStreams.
            fileOneStream.Close()
            fileTwoStream.Close()
            'Me.ResultsRichTextBox.Text = "Files are totaly equal."
            Return 1

        Catch ex As Exception
            TotalErrorInformaition += ex.GetType.ToString + "      " + ex.Message.ToString + vbNewLine
            Return 0
        End Try
    End Function

    Friend Function FindDuplicateFile(ByVal dir As String, ByVal filename As String) As Boolean

        ' Some directories are not assesible like System Volume Informatiion
        Try
            Dim Files As String() = System.IO.Directory.GetFiles(dir)
            Dim Dirs As String() = System.IO.Directory.GetDirectories(dir)

            'Scaning for current directory file
            For Each FileAtDir As String In Files
                'MsgBox(FileAtDir)
                If CompareFiles(FileAtDir, filename) = 1 Then
                    Form1.DuplicateFileList.Items.Add(Form1.DuplicateFileList.Items.Count + 1)
                    Form1.DuplicateFileList.Items(Form1.DuplicateFileList.Items.Count - 1).SubItems.Add(FileAtDir.ToString)
                End If
            Next

            'scaning for subDirectory 
            For Each DirectoryName As String In Dirs
                FindDuplicateFile(DirectoryName, filename)
            Next


        Catch ex As Exception
            TotalErrorInformaition += ex.GetType.ToString + "      " + ex.Message.ToString + vbNewLine
        End Try

    End Function

End Module
