'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date : 08/01/2010                               '
'                   Form ID : AU                                   '
'******************************************************************'
Public Class AboutUsForm

    Private Sub AboutUsForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub AboutUsForm_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Me.Close()
    End Sub

    Private Sub AboutUsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Me.Label1.Click, AddressOf Me.AboutUsForm_Click
        AddHandler Me.Label2.Click, AddressOf Me.AboutUsForm_Click
        AddHandler Me.Label3.Click, AddressOf Me.AboutUsForm_Click
        AddHandler Me.LostFocus, AddressOf Me.AboutUsForm_Click
        AddHandler Me.PictureBox1.Click, AddressOf Me.AboutUsForm_Click
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Try
            Process.Start("http://virussecurelab.com/")
        Catch ex As Exception
        End Try
        Me.Close()
    End Sub
End Class