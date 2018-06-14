<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DriveIgnoreform
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
        Me.DrvListView = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ApplyButton = New System.Windows.Forms.Button
        Me.RefreshButtorn = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'DrvListView
        '
        Me.DrvListView.CheckBoxes = True
        Me.DrvListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader5, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.DrvListView.FullRowSelect = True
        Me.DrvListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.DrvListView.Location = New System.Drawing.Point(12, 12)
        Me.DrvListView.MultiSelect = False
        Me.DrvListView.Name = "DrvListView"
        Me.DrvListView.Size = New System.Drawing.Size(402, 219)
        Me.DrvListView.TabIndex = 1
        Me.DrvListView.UseCompatibleStateImageBehavior = False
        Me.DrvListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Drive(s]"
        Me.ColumnHeader1.Width = 52
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Drive Type"
        Me.ColumnHeader5.Width = 73
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Volume Lable"
        Me.ColumnHeader2.Width = 90
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Total Size"
        Me.ColumnHeader3.Width = 88
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Status"
        Me.ColumnHeader4.Width = 83
        '
        'ApplyButton
        '
        Me.ApplyButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ApplyButton.Location = New System.Drawing.Point(42, 243)
        Me.ApplyButton.Name = "ApplyButton"
        Me.ApplyButton.Size = New System.Drawing.Size(75, 44)
        Me.ApplyButton.TabIndex = 2
        Me.ApplyButton.Text = "Apply"
        Me.ApplyButton.UseVisualStyleBackColor = True
        '
        'RefreshButtorn
        '
        Me.RefreshButtorn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RefreshButtorn.Location = New System.Drawing.Point(302, 243)
        Me.RefreshButtorn.Name = "RefreshButtorn"
        Me.RefreshButtorn.Size = New System.Drawing.Size(75, 44)
        Me.RefreshButtorn.TabIndex = 3
        Me.RefreshButtorn.Text = "Refresh"
        Me.RefreshButtorn.UseVisualStyleBackColor = True
        '
        'DriveIgnoreform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 299)
        Me.Controls.Add(Me.RefreshButtorn)
        Me.Controls.Add(Me.ApplyButton)
        Me.Controls.Add(Me.DrvListView)
        Me.Name = "DriveIgnoreform"
        Me.Text = "DriveIgnoreform"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DrvListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ApplyButton As System.Windows.Forms.Button
    Friend WithEvents RefreshButtorn As System.Windows.Forms.Button
End Class
