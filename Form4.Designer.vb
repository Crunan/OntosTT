<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.PreheatChkBox = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.BatchChkBox = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BatchTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PreheatTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ExitBTN = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CollisionTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CollisionCheckbox = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.Guna2GradientPanel1.SuspendLayout
        Me.SuspendLayout
        '
        'SettingsConfirmBTN
        '
        Me.SettingsConfirmBTN.AutoRoundedCorners = true
        Me.SettingsConfirmBTN.BorderRadius = 25
        Me.SettingsConfirmBTN.CheckedState.Parent = Me.SettingsConfirmBTN
        Me.SettingsConfirmBTN.CustomImages.Parent = Me.SettingsConfirmBTN
        Me.SettingsConfirmBTN.FillColor = System.Drawing.Color.FromArgb(CType(CType(201,Byte),Integer), CType(CType(42,Byte),Integer), CType(CType(38,Byte),Integer))
        Me.SettingsConfirmBTN.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.SettingsConfirmBTN.ForeColor = System.Drawing.Color.White
        Me.SettingsConfirmBTN.HoverState.Parent = Me.SettingsConfirmBTN
        Me.SettingsConfirmBTN.Location = New System.Drawing.Point(226, 273)
        Me.SettingsConfirmBTN.Name = "SettingsConfirmBTN"
        Me.SettingsConfirmBTN.ShadowDecoration.Parent = Me.SettingsConfirmBTN
        Me.SettingsConfirmBTN.Size = New System.Drawing.Size(159, 53)
        Me.SettingsConfirmBTN.TabIndex = 0
        Me.SettingsConfirmBTN.Text = "CONFIRM"
        '
        'AutoScanChkBox
        '
        Me.AutoScanChkBox.Checked = true
        Me.AutoScanChkBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201,Byte),Integer), CType(CType(42,Byte),Integer), CType(CType(38,Byte),Integer))
        Me.AutoScanChkBox.CheckedState.BorderRadius = 2
        Me.AutoScanChkBox.CheckedState.BorderThickness = 0
        Me.AutoScanChkBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(201,Byte),Integer), CType(CType(42,Byte),Integer), CType(CType(38,Byte),Integer))
        Me.AutoScanChkBox.CheckedState.Parent = Me.AutoScanChkBox
        Me.AutoScanChkBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AutoScanChkBox.Enabled = false
        Me.AutoScanChkBox.Location = New System.Drawing.Point(46, 152)
        Me.AutoScanChkBox.Name = "AutoScanChkBox"
        Me.AutoScanChkBox.ShadowDecoration.Parent = Me.AutoScanChkBox
        Me.AutoScanChkBox.Size = New System.Drawing.Size(40, 36)
        Me.AutoScanChkBox.TabIndex = 1
        Me.AutoScanChkBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125,Byte),Integer), CType(CType(137,Byte),Integer), CType(CType(149,Byte),Integer))
        Me.AutoScanChkBox.UncheckedState.BorderRadius = 2
        Me.AutoScanChkBox.UncheckedState.BorderThickness = 0
        Me.AutoScanChkBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125,Byte),Integer), CType(CType(137,Byte),Integer), CType(CType(149,Byte),Integer))
        Me.AutoScanChkBox.UncheckedState.Parent = Me.AutoScanChkBox
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = "Auto Start Scan"
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208,Byte),Integer), CType(CType(208,Byte),Integer), CType(CType(208,Byte),Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226,Byte),Integer), CType(CType(226,Byte),Integer), CType(CType(226,Byte),Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138,Byte),Integer), CType(CType(138,Byte),Integer), CType(CType(138,Byte),Integer))
        Me.Guna2TextBox1.DisabledState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138,Byte),Integer), CType(CType(138,Byte),Integer), CType(CType(138,Byte),Integer))
        Me.Guna2TextBox1.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Guna2TextBox1.FocusedState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Guna2TextBox1.HoverState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Location = New System.Drawing.Point(96, 152)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.SelectionStart = 15
        Me.Guna2TextBox1.ShadowDecoration.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Size = New System.Drawing.Size(215, 36)
        Me.Guna2TextBox1.TabIndex = 2
        '
        'PreheatChkBox
        '
        Me.PreheatChkBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201,Byte),Integer), CType(CType(42,Byte),Integer), CType(CType(38,Byte),Integer))
        Me.PreheatChkBox.CheckedState.BorderRadius = 2
        Me.PreheatChkBox.CheckedState.BorderThickness = 0
        Me.PreheatChkBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(201,Byte),Integer), CType(CType(42,Byte),Integer), CType(CType(38,Byte),Integer))
        Me.PreheatChkBox.CheckedState.Parent = Me.PreheatChkBox
        Me.PreheatChkBox.Location = New System.Drawing.Point(46, 92)
        Me.PreheatChkBox.Name = "PreheatChkBox"
        Me.PreheatChkBox.ShadowDecoration.Parent = Me.PreheatChkBox
        Me.PreheatChkBox.Size = New System.Drawing.Size(40, 36)
        Me.PreheatChkBox.TabIndex = 7
        Me.PreheatChkBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125,Byte),Integer), CType(CType(137,Byte),Integer), CType(CType(149,Byte),Integer))
        Me.PreheatChkBox.UncheckedState.BorderRadius = 2
        Me.PreheatChkBox.UncheckedState.BorderThickness = 0
        Me.PreheatChkBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125,Byte),Integer), CType(CType(137,Byte),Integer), CType(CType(149,Byte),Integer))
        Me.PreheatChkBox.UncheckedState.Parent = Me.PreheatChkBox
        '
        'BatchChkBox
        '
        Me.BatchChkBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201,Byte),Integer), CType(CType(42,Byte),Integer), CType(CType(38,Byte),Integer))
        Me.BatchChkBox.CheckedState.BorderRadius = 2
        Me.BatchChkBox.CheckedState.BorderThickness = 0
        Me.BatchChkBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(201,Byte),Integer), CType(CType(42,Byte),Integer), CType(CType(38,Byte),Integer))
        Me.BatchChkBox.CheckedState.Parent = Me.BatchChkBox
        Me.BatchChkBox.Location = New System.Drawing.Point(442, 92)
        Me.BatchChkBox.Name = "BatchChkBox"
        Me.BatchChkBox.ShadowDecoration.Parent = Me.BatchChkBox
        Me.BatchChkBox.Size = New System.Drawing.Size(40, 36)
        Me.BatchChkBox.TabIndex = 9
        Me.BatchChkBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125,Byte),Integer), CType(CType(137,Byte),Integer), CType(CType(149,Byte),Integer))
        Me.BatchChkBox.UncheckedState.BorderRadius = 2
        Me.BatchChkBox.UncheckedState.BorderThickness = 0
        Me.BatchChkBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125,Byte),Integer), CType(CType(137,Byte),Integer), CType(CType(149,Byte),Integer))
        Me.BatchChkBox.UncheckedState.Parent = Me.BatchChkBox
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 34)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(282, 32)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Recipe Configuration"
        '
        'BatchTextBox
        '
        Me.BatchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BatchTextBox.DefaultText = "Batch ID Logging"
        Me.BatchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208,Byte),Integer), CType(CType(208,Byte),Integer), CType(CType(208,Byte),Integer))
        Me.BatchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226,Byte),Integer), CType(CType(226,Byte),Integer), CType(CType(226,Byte),Integer))
        Me.BatchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138,Byte),Integer), CType(CType(138,Byte),Integer), CType(CType(138,Byte),Integer))
        Me.BatchTextBox.DisabledState.Parent = Me.BatchTextBox
        Me.BatchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138,Byte),Integer), CType(CType(138,Byte),Integer), CType(CType(138,Byte),Integer))
        Me.BatchTextBox.FillColor = System.Drawing.SystemColors.Control
        Me.BatchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.BatchTextBox.FocusedState.Parent = Me.BatchTextBox
        Me.BatchTextBox.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BatchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.BatchTextBox.HoverState.Parent = Me.BatchTextBox
        Me.BatchTextBox.Location = New System.Drawing.Point(489, 92)
        Me.BatchTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BatchTextBox.Name = "BatchTextBox"
        Me.BatchTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BatchTextBox.PlaceholderText = ""
        Me.BatchTextBox.SelectedText = ""
        Me.BatchTextBox.SelectionStart = 16
        Me.BatchTextBox.ShadowDecoration.Parent = Me.BatchTextBox
        Me.BatchTextBox.Size = New System.Drawing.Size(252, 36)
        Me.BatchTextBox.TabIndex = 73
        '
        'PreheatTextBox
        '
        Me.PreheatTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PreheatTextBox.DefaultText = "Preheat Plasma Head"
        Me.PreheatTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208,Byte),Integer), CType(CType(208,Byte),Integer), CType(CType(208,Byte),Integer))
        Me.PreheatTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226,Byte),Integer), CType(CType(226,Byte),Integer), CType(CType(226,Byte),Integer))
        Me.PreheatTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138,Byte),Integer), CType(CType(138,Byte),Integer), CType(CType(138,Byte),Integer))
        Me.PreheatTextBox.DisabledState.Parent = Me.PreheatTextBox
        Me.PreheatTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138,Byte),Integer), CType(CType(138,Byte),Integer), CType(CType(138,Byte),Integer))
        Me.PreheatTextBox.FillColor = System.Drawing.SystemColors.Control
        Me.PreheatTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.PreheatTextBox.FocusedState.Parent = Me.PreheatTextBox
        Me.PreheatTextBox.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.PreheatTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.PreheatTextBox.HoverState.Parent = Me.PreheatTextBox
        Me.PreheatTextBox.Location = New System.Drawing.Point(96, 92)
        Me.PreheatTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PreheatTextBox.Name = "PreheatTextBox"
        Me.PreheatTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PreheatTextBox.PlaceholderText = ""
        Me.PreheatTextBox.SelectedText = ""
        Me.PreheatTextBox.SelectionStart = 19
        Me.PreheatTextBox.ShadowDecoration.Parent = Me.PreheatTextBox
        Me.PreheatTextBox.Size = New System.Drawing.Size(252, 36)
        Me.PreheatTextBox.TabIndex = 72
        '
        'ExitBTN
        '
        Me.ExitBTN.AutoRoundedCorners = true
        Me.ExitBTN.BorderRadius = 25
        Me.ExitBTN.CheckedState.Parent = Me.ExitBTN
        Me.ExitBTN.CustomImages.Parent = Me.ExitBTN
        Me.ExitBTN.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.ExitBTN.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ExitBTN.ForeColor = System.Drawing.Color.White
        Me.ExitBTN.HoverState.Parent = Me.ExitBTN
        Me.ExitBTN.Location = New System.Drawing.Point(392, 273)
        Me.ExitBTN.Name = "ExitBTN"
        Me.ExitBTN.ShadowDecoration.Parent = Me.ExitBTN
        Me.ExitBTN.Size = New System.Drawing.Size(95, 53)
        Me.ExitBTN.TabIndex = 74
        Me.ExitBTN.Text = "EXIT"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(436, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 32)
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
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(31, 139)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(721, 62)
        Me.Guna2GradientPanel1.TabIndex = 76
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(288, 13)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 36)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Engineer "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Only"
        '
        'CollisionTextBox
        '
        Me.CollisionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CollisionTextBox.DefaultText = "Crash Avoidance System"
        Me.CollisionTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208,Byte),Integer), CType(CType(208,Byte),Integer), CType(CType(208,Byte),Integer))
        Me.CollisionTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226,Byte),Integer), CType(CType(226,Byte),Integer), CType(CType(226,Byte),Integer))
        Me.CollisionTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138,Byte),Integer), CType(CType(138,Byte),Integer), CType(CType(138,Byte),Integer))
        Me.CollisionTextBox.DisabledState.Parent = Me.CollisionTextBox
        Me.CollisionTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138,Byte),Integer), CType(CType(138,Byte),Integer), CType(CType(138,Byte),Integer))
        Me.CollisionTextBox.FillColor = System.Drawing.SystemColors.Control
        Me.CollisionTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.CollisionTextBox.FocusedState.Parent = Me.CollisionTextBox
        Me.CollisionTextBox.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CollisionTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.CollisionTextBox.HoverState.Parent = Me.CollisionTextBox
        Me.CollisionTextBox.Location = New System.Drawing.Point(489, 152)
        Me.CollisionTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CollisionTextBox.Name = "CollisionTextBox"
        Me.CollisionTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CollisionTextBox.PlaceholderText = ""
        Me.CollisionTextBox.SelectedText = ""
        Me.CollisionTextBox.SelectionStart = 22
        Me.CollisionTextBox.ShadowDecoration.Parent = Me.CollisionTextBox
        Me.CollisionTextBox.Size = New System.Drawing.Size(252, 36)
        Me.CollisionTextBox.TabIndex = 78
        '
        'CollisionCheckbox
        '
        Me.CollisionCheckbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201,Byte),Integer), CType(CType(42,Byte),Integer), CType(CType(38,Byte),Integer))
        Me.CollisionCheckbox.CheckedState.BorderRadius = 2
        Me.CollisionCheckbox.CheckedState.BorderThickness = 0
        Me.CollisionCheckbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(201,Byte),Integer), CType(CType(42,Byte),Integer), CType(CType(38,Byte),Integer))
        Me.CollisionCheckbox.CheckedState.Parent = Me.CollisionCheckbox
        Me.CollisionCheckbox.Enabled = false
        Me.CollisionCheckbox.Location = New System.Drawing.Point(442, 152)
        Me.CollisionCheckbox.Name = "CollisionCheckbox"
        Me.CollisionCheckbox.ShadowDecoration.Parent = Me.CollisionCheckbox
        Me.CollisionCheckbox.Size = New System.Drawing.Size(40, 36)
        Me.CollisionCheckbox.TabIndex = 77
        Me.CollisionCheckbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125,Byte),Integer), CType(CType(137,Byte),Integer), CType(CType(149,Byte),Integer))
        Me.CollisionCheckbox.UncheckedState.BorderRadius = 2
        Me.CollisionCheckbox.UncheckedState.BorderThickness = 0
        Me.CollisionCheckbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125,Byte),Integer), CType(CType(137,Byte),Integer), CType(CType(149,Byte),Integer))
        Me.CollisionCheckbox.UncheckedState.Parent = Me.CollisionCheckbox
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(754, 347)
        Me.Controls.Add(Me.CollisionTextBox)
        Me.Controls.Add(Me.CollisionCheckbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitBTN)
        Me.Controls.Add(Me.BatchTextBox)
        Me.Controls.Add(Me.PreheatTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BatchChkBox)
        Me.Controls.Add(Me.PreheatChkBox)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.Controls.Add(Me.AutoScanChkBox)
        Me.Controls.Add(Me.SettingsConfirmBTN)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Name = "Form4"
        Me.Text = "Settings"
        Me.Guna2GradientPanel1.ResumeLayout(false)
        Me.Guna2GradientPanel1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents SettingsConfirmBTN As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AutoScanChkBox As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PreheatChkBox As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents BatchChkBox As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BatchTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PreheatTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ExitBTN As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents CollisionTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CollisionCheckbox As Guna.UI2.WinForms.Guna2CustomCheckBox
End Class
