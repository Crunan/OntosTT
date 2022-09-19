<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TSSBForm
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
        Me.Label37 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.White
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label37.Location = New System.Drawing.Point(129, 81)
        Me.Label37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(317, 25)
        Me.Label37.TabIndex = 14
        Me.Label37.Text = "Joy Stick Enabled Select First Spot"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TSSBForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 209)
        Me.Controls.Add(Me.Label37)
        Me.Name = "TSSBForm"
        Me.Text = "Set Two Spot Scan Box"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label37 As System.Windows.Forms.Label
End Class
