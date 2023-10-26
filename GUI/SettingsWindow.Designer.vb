<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsWindow
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
        Me.SettingsConfirmBTN = New Guna.UI2.WinForms.Guna2Button()
        Me.AutoScanChkBox = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ExitBTN = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CollisionTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CollisionCheckbox = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SettingsConfirmBTN
        '
        Me.SettingsConfirmBTN.AutoRoundedCorners = True
        Me.SettingsConfirmBTN.BorderRadius = 20
        Me.SettingsConfirmBTN.CheckedState.Parent = Me.SettingsConfirmBTN
        Me.SettingsConfirmBTN.CustomImages.Parent = Me.SettingsConfirmBTN
        Me.SettingsConfirmBTN.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.SettingsConfirmBTN.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsConfirmBTN.ForeColor = System.Drawing.Color.White
        Me.SettingsConfirmBTN.HoverState.Parent = Me.SettingsConfirmBTN
        Me.SettingsConfirmBTN.Location = New System.Drawing.Point(170, 222)
        Me.SettingsConfirmBTN.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SettingsConfirmBTN.Name = "SettingsConfirmBTN"
        Me.SettingsConfirmBTN.ShadowDecoration.Parent = Me.SettingsConfirmBTN
        Me.SettingsConfirmBTN.Size = New System.Drawing.Size(119, 43)
        Me.SettingsConfirmBTN.TabIndex = 0
        Me.SettingsConfirmBTN.Text = "CONFIRM"
        '
        'AutoScanChkBox
        '
        Me.AutoScanChkBox.Checked = True
        Me.AutoScanChkBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.AutoScanChkBox.CheckedState.BorderRadius = 2
        Me.AutoScanChkBox.CheckedState.BorderThickness = 0
        Me.AutoScanChkBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.AutoScanChkBox.CheckedState.Parent = Me.AutoScanChkBox
        Me.AutoScanChkBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AutoScanChkBox.Enabled = False
        Me.AutoScanChkBox.Location = New System.Drawing.Point(34, 81)
        Me.AutoScanChkBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AutoScanChkBox.Name = "AutoScanChkBox"
        Me.AutoScanChkBox.ShadowDecoration.Parent = Me.AutoScanChkBox
        Me.AutoScanChkBox.Size = New System.Drawing.Size(30, 29)
        Me.AutoScanChkBox.TabIndex = 1
        Me.AutoScanChkBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.AutoScanChkBox.UncheckedState.BorderRadius = 2
        Me.AutoScanChkBox.UncheckedState.BorderThickness = 0
        Me.AutoScanChkBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.AutoScanChkBox.UncheckedState.Parent = Me.AutoScanChkBox
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = "Auto Start Scan"
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.HoverState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Location = New System.Drawing.Point(72, 81)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.SelectionStart = 15
        Me.Guna2TextBox1.ShadowDecoration.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Size = New System.Drawing.Size(161, 29)
        Me.Guna2TextBox1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(215, 26)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Recipe Configuration"
        '
        'ExitBTN
        '
        Me.ExitBTN.AutoRoundedCorners = True
        Me.ExitBTN.BorderRadius = 20
        Me.ExitBTN.CheckedState.Parent = Me.ExitBTN
        Me.ExitBTN.CustomImages.Parent = Me.ExitBTN
        Me.ExitBTN.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.ExitBTN.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBTN.ForeColor = System.Drawing.Color.White
        Me.ExitBTN.HoverState.Parent = Me.ExitBTN
        Me.ExitBTN.Location = New System.Drawing.Point(294, 222)
        Me.ExitBTN.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ExitBTN.Name = "ExitBTN"
        Me.ExitBTN.ShadowDecoration.Parent = Me.ExitBTN
        Me.ExitBTN.Size = New System.Drawing.Size(71, 43)
        Me.ExitBTN.TabIndex = 74
        Me.ExitBTN.Text = "EXIT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(327, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 26)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Tool Settings"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2GradientPanel1.BorderColor = System.Drawing.Color.Red
        Me.Guna2GradientPanel1.BorderRadius = 2
        Me.Guna2GradientPanel1.BorderThickness = 2
        Me.Guna2GradientPanel1.Controls.Add(Me.Label2)
        Me.Guna2GradientPanel1.CustomBorderColor = System.Drawing.Color.Red
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(23, 70)
        Me.Guna2GradientPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(541, 50)
        Me.Guna2GradientPanel1.TabIndex = 76
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(216, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 30)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Engineer " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Only"
        '
        'CollisionTextBox
        '
        Me.CollisionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CollisionTextBox.DefaultText = "Crash Avoidance System"
        Me.CollisionTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CollisionTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CollisionTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CollisionTextBox.DisabledState.Parent = Me.CollisionTextBox
        Me.CollisionTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CollisionTextBox.FillColor = System.Drawing.SystemColors.Control
        Me.CollisionTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CollisionTextBox.FocusedState.Parent = Me.CollisionTextBox
        Me.CollisionTextBox.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CollisionTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CollisionTextBox.HoverState.Parent = Me.CollisionTextBox
        Me.CollisionTextBox.Location = New System.Drawing.Point(367, 81)
        Me.CollisionTextBox.Name = "CollisionTextBox"
        Me.CollisionTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CollisionTextBox.PlaceholderText = ""
        Me.CollisionTextBox.SelectedText = ""
        Me.CollisionTextBox.SelectionStart = 22
        Me.CollisionTextBox.ShadowDecoration.Parent = Me.CollisionTextBox
        Me.CollisionTextBox.Size = New System.Drawing.Size(189, 29)
        Me.CollisionTextBox.TabIndex = 78
        '
        'CollisionCheckbox
        '
        Me.CollisionCheckbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CollisionCheckbox.CheckedState.BorderRadius = 2
        Me.CollisionCheckbox.CheckedState.BorderThickness = 0
        Me.CollisionCheckbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CollisionCheckbox.CheckedState.Parent = Me.CollisionCheckbox
        Me.CollisionCheckbox.Enabled = False
        Me.CollisionCheckbox.Location = New System.Drawing.Point(332, 81)
        Me.CollisionCheckbox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CollisionCheckbox.Name = "CollisionCheckbox"
        Me.CollisionCheckbox.ShadowDecoration.Parent = Me.CollisionCheckbox
        Me.CollisionCheckbox.Size = New System.Drawing.Size(30, 29)
        Me.CollisionCheckbox.TabIndex = 77
        Me.CollisionCheckbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CollisionCheckbox.UncheckedState.BorderRadius = 2
        Me.CollisionCheckbox.UncheckedState.BorderThickness = 0
        Me.CollisionCheckbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CollisionCheckbox.UncheckedState.Parent = Me.CollisionCheckbox
        '
        'SettingsWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(566, 282)
        Me.Controls.Add(Me.CollisionTextBox)
        Me.Controls.Add(Me.CollisionCheckbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitBTN)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.Controls.Add(Me.AutoScanChkBox)
        Me.Controls.Add(Me.SettingsConfirmBTN)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "SettingsWindow"
        Me.Text = "Settings"
        Me.Guna2GradientPanel1.ResumeLayout(false)
        Me.Guna2GradientPanel1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents SettingsConfirmBTN As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AutoScanChkBox As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ExitBTN As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents CollisionTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CollisionCheckbox As Guna.UI2.WinForms.Guna2CustomCheckBox
End Class
