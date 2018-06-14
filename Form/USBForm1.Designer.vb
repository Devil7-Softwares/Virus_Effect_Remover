<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USBForm1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.USBCheckBox = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBoxWRPro = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'USBCheckBox
        '
        Me.USBCheckBox.AutoSize = True
        Me.USBCheckBox.Location = New System.Drawing.Point(9, 31)
        Me.USBCheckBox.Name = "USBCheckBox"
        Me.USBCheckBox.Size = New System.Drawing.Size(211, 17)
        Me.USBCheckBox.TabIndex = 1
        Me.USBCheckBox.Text = "Disable all USB drive (or media) access"
        Me.USBCheckBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(57, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Under Development"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.USBCheckBox)
        Me.GroupBox1.Controls.Add(Me.CheckBoxWRPro)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 116)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "USB Storage / Access"
        '
        'CheckBoxWRPro
        '
        Me.CheckBoxWRPro.AutoSize = True
        Me.CheckBoxWRPro.Location = New System.Drawing.Point(9, 54)
        Me.CheckBoxWRPro.Name = "CheckBoxWRPro"
        Me.CheckBoxWRPro.Size = New System.Drawing.Size(213, 17)
        Me.CheckBoxWRPro.TabIndex = 0
        Me.CheckBoxWRPro.Text = "Write Protect USB drive (or USB media)"
        Me.CheckBoxWRPro.UseVisualStyleBackColor = True
        '
        'USBForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 130)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "USBForm1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "  USB storage"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents USBCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxWRPro As System.Windows.Forms.CheckBox
End Class
