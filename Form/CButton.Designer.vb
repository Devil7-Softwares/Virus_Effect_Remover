Namespace C_Button
    Partial Class CButton
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.timerFade = New System.Windows.Forms.Timer(Me.components)
            Me.SuspendLayout()
            ' 
            ' timerFade
            ' 
            Me.timerFade.Interval = 10
            AddHandler Me.timerFade.Tick, AddressOf Me.timerFade_Tick
            ' 
            ' CloudButton
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Name = "CloudButton"
            Me.Size = New System.Drawing.Size(150, 52)
            AddHandler Me.MouseDown, AddressOf Me.CloudButtonOwn_MouseDown
            AddHandler Me.Leave, AddressOf Me.CloudButton_Leave
            AddHandler Me.MouseEnter, AddressOf Me.CloudButtonOwn_MouseEnter
            AddHandler Me.MouseLeave, AddressOf Me.CloudButtonOwn_MouseLeave
            AddHandler Me.MouseUp, AddressOf Me.CloudButtonOwn_MouseUp
            AddHandler Me.EnabledChanged, AddressOf Me.CloudButton_EnabledChanged

            Me.ResumeLayout(False)
        End Sub

#End Region

        Private timerFade As System.Windows.Forms.Timer
    End Class
End Namespace
