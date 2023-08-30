<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiameterEntryDialog
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
        Me.RadioButton2Inch = New System.Windows.Forms.RadioButton()
        Me.RadioButton4Inch = New System.Windows.Forms.RadioButton()
        Me.RadioButton6Inch = New System.Windows.Forms.RadioButton()
        Me.RadioButton8Inch = New System.Windows.Forms.RadioButton()
        Me.DiamDlgOKBtn = New System.Windows.Forms.Button()
        Me.RadioButton12Inch = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout
        '
        'RadioButton2Inch
        '
        Me.RadioButton2Inch.AutoSize = true
        Me.RadioButton2Inch.Location = New System.Drawing.Point(34, 29)
        Me.RadioButton2Inch.Name = "RadioButton2Inch"
        Me.RadioButton2Inch.Size = New System.Drawing.Size(122, 21)
        Me.RadioButton2Inch.TabIndex = 0
        Me.RadioButton2Inch.Text = "2 inch - 50 mm"
        Me.RadioButton2Inch.UseVisualStyleBackColor = true
        '
        'RadioButton4Inch
        '
        Me.RadioButton4Inch.AutoSize = true
        Me.RadioButton4Inch.Location = New System.Drawing.Point(34, 57)
        Me.RadioButton4Inch.Name = "RadioButton4Inch"
        Me.RadioButton4Inch.Size = New System.Drawing.Size(130, 21)
        Me.RadioButton4Inch.TabIndex = 1
        Me.RadioButton4Inch.Text = "4 inch - 100 mm"
        Me.RadioButton4Inch.UseVisualStyleBackColor = true
        '
        'RadioButton6Inch
        '
        Me.RadioButton6Inch.AutoSize = true
        Me.RadioButton6Inch.Location = New System.Drawing.Point(34, 84)
        Me.RadioButton6Inch.Name = "RadioButton6Inch"
        Me.RadioButton6Inch.Size = New System.Drawing.Size(130, 21)
        Me.RadioButton6Inch.TabIndex = 2
        Me.RadioButton6Inch.Text = "6 inch - 150 mm"
        Me.RadioButton6Inch.UseVisualStyleBackColor = true
        '
        'RadioButton8Inch
        '
        Me.RadioButton8Inch.AutoSize = true
        Me.RadioButton8Inch.Location = New System.Drawing.Point(34, 111)
        Me.RadioButton8Inch.Name = "RadioButton8Inch"
        Me.RadioButton8Inch.Size = New System.Drawing.Size(130, 21)
        Me.RadioButton8Inch.TabIndex = 3
        Me.RadioButton8Inch.Text = "8 inch - 200 mm"
        Me.RadioButton8Inch.UseVisualStyleBackColor = true
        '
        'DiamDlgOKBtn
        '
        Me.DiamDlgOKBtn.BackColor = System.Drawing.Color.Gold
        Me.DiamDlgOKBtn.Location = New System.Drawing.Point(94, 197)
        Me.DiamDlgOKBtn.Name = "DiamDlgOKBtn"
        Me.DiamDlgOKBtn.Size = New System.Drawing.Size(70, 33)
        Me.DiamDlgOKBtn.TabIndex = 21
        Me.DiamDlgOKBtn.Text = "OK"
        Me.DiamDlgOKBtn.UseVisualStyleBackColor = false
        '
        'RadioButton12Inch
        '
        Me.RadioButton12Inch.AutoSize = true
        Me.RadioButton12Inch.Checked = true
        Me.RadioButton12Inch.Location = New System.Drawing.Point(34, 137)
        Me.RadioButton12Inch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton12Inch.Name = "RadioButton12Inch"
        Me.RadioButton12Inch.Size = New System.Drawing.Size(138, 21)
        Me.RadioButton12Inch.TabIndex = 23
        Me.RadioButton12Inch.TabStop = true
        Me.RadioButton12Inch.Text = "12 inch - 300 mm"
        Me.RadioButton12Inch.UseVisualStyleBackColor = true
        '
        'DiameterEntryDialog
        '
        Me.AcceptButton = Me.DiamDlgOKBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 242)
        Me.Controls.Add(Me.RadioButton12Inch)
        Me.Controls.Add(Me.DiamDlgOKBtn)
        Me.Controls.Add(Me.RadioButton8Inch)
        Me.Controls.Add(Me.RadioButton6Inch)
        Me.Controls.Add(Me.RadioButton4Inch)
        Me.Controls.Add(Me.RadioButton2Inch)
        Me.Name = "DiameterEntryDialog"
        Me.Text = "Substrate Diameter"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents RadioButton2Inch As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4Inch As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6Inch As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton8Inch As System.Windows.Forms.RadioButton
    Public WithEvents DiamDlgOKBtn As System.Windows.Forms.Button
    Friend WithEvents RadioButton12Inch As RadioButton
End Class
