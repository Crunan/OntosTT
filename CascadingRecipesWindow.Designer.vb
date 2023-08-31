<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CascadingRecipesWindow
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
        Me.AddRecipeBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.RemoveRecipeBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.ConfirmRecipeBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CascadeRecipeListBox = New System.Windows.Forms.ListBox()
        Me.SaveRecipeBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout
        '
        'AddRecipeBtn
        '
        Me.AddRecipeBtn.AutoRoundedCorners = true
        Me.AddRecipeBtn.BorderRadius = 21
        Me.AddRecipeBtn.CheckedState.Parent = Me.AddRecipeBtn
        Me.AddRecipeBtn.CustomImages.Parent = Me.AddRecipeBtn
        Me.AddRecipeBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(201,Byte),Integer), CType(CType(42,Byte),Integer), CType(CType(38,Byte),Integer))
        Me.AddRecipeBtn.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.AddRecipeBtn.ForeColor = System.Drawing.Color.White
        Me.AddRecipeBtn.HoverState.Parent = Me.AddRecipeBtn
        Me.AddRecipeBtn.Location = New System.Drawing.Point(47, 375)
        Me.AddRecipeBtn.Name = "AddRecipeBtn"
        Me.AddRecipeBtn.ShadowDecoration.Parent = Me.AddRecipeBtn
        Me.AddRecipeBtn.Size = New System.Drawing.Size(94, 45)
        Me.AddRecipeBtn.TabIndex = 0
        Me.AddRecipeBtn.Text = "ADD"
        '
        'RemoveRecipeBtn
        '
        Me.RemoveRecipeBtn.AutoRoundedCorners = true
        Me.RemoveRecipeBtn.BorderRadius = 21
        Me.RemoveRecipeBtn.CheckedState.Parent = Me.RemoveRecipeBtn
        Me.RemoveRecipeBtn.CustomImages.Parent = Me.RemoveRecipeBtn
        Me.RemoveRecipeBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(201,Byte),Integer), CType(CType(42,Byte),Integer), CType(CType(38,Byte),Integer))
        Me.RemoveRecipeBtn.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.RemoveRecipeBtn.ForeColor = System.Drawing.Color.White
        Me.RemoveRecipeBtn.HoverState.Parent = Me.RemoveRecipeBtn
        Me.RemoveRecipeBtn.Location = New System.Drawing.Point(148, 375)
        Me.RemoveRecipeBtn.Name = "RemoveRecipeBtn"
        Me.RemoveRecipeBtn.ShadowDecoration.Parent = Me.RemoveRecipeBtn
        Me.RemoveRecipeBtn.Size = New System.Drawing.Size(94, 45)
        Me.RemoveRecipeBtn.TabIndex = 1
        Me.RemoveRecipeBtn.Text = "REMOVE"
        '
        'ConfirmRecipeBtn
        '
        Me.ConfirmRecipeBtn.AutoRoundedCorners = true
        Me.ConfirmRecipeBtn.BorderRadius = 21
        Me.ConfirmRecipeBtn.CheckedState.Parent = Me.ConfirmRecipeBtn
        Me.ConfirmRecipeBtn.CustomImages.Parent = Me.ConfirmRecipeBtn
        Me.ConfirmRecipeBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(201,Byte),Integer), CType(CType(42,Byte),Integer), CType(CType(38,Byte),Integer))
        Me.ConfirmRecipeBtn.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ConfirmRecipeBtn.ForeColor = System.Drawing.Color.White
        Me.ConfirmRecipeBtn.HoverState.Parent = Me.ConfirmRecipeBtn
        Me.ConfirmRecipeBtn.Location = New System.Drawing.Point(148, 426)
        Me.ConfirmRecipeBtn.Name = "ConfirmRecipeBtn"
        Me.ConfirmRecipeBtn.ShadowDecoration.Parent = Me.ConfirmRecipeBtn
        Me.ConfirmRecipeBtn.Size = New System.Drawing.Size(94, 45)
        Me.ConfirmRecipeBtn.TabIndex = 3
        Me.ConfirmRecipeBtn.Text = "OK"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(17, 53)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(261, 12)
        Me.Guna2Separator1.TabIndex = 6
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.Location = New System.Drawing.Point(17, 356)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(261, 10)
        Me.Guna2Separator2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "CASCADE RECIPE LIST"
        '
        'CascadeRecipeListBox
        '
        Me.CascadeRecipeListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CascadeRecipeListBox.FormattingEnabled = true
        Me.CascadeRecipeListBox.ItemHeight = 20
        Me.CascadeRecipeListBox.Location = New System.Drawing.Point(22, 71)
        Me.CascadeRecipeListBox.Name = "CascadeRecipeListBox"
        Me.CascadeRecipeListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.CascadeRecipeListBox.Size = New System.Drawing.Size(261, 264)
        Me.CascadeRecipeListBox.TabIndex = 8
        '
        'SaveRecipeBtn
        '
        Me.SaveRecipeBtn.AutoRoundedCorners = true
        Me.SaveRecipeBtn.BorderRadius = 21
        Me.SaveRecipeBtn.CheckedState.Parent = Me.SaveRecipeBtn
        Me.SaveRecipeBtn.CustomImages.Parent = Me.SaveRecipeBtn
        Me.SaveRecipeBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(201,Byte),Integer), CType(CType(42,Byte),Integer), CType(CType(38,Byte),Integer))
        Me.SaveRecipeBtn.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.SaveRecipeBtn.ForeColor = System.Drawing.Color.White
        Me.SaveRecipeBtn.HoverState.Parent = Me.SaveRecipeBtn
        Me.SaveRecipeBtn.Location = New System.Drawing.Point(47, 426)
        Me.SaveRecipeBtn.Name = "SaveRecipeBtn"
        Me.SaveRecipeBtn.ShadowDecoration.Parent = Me.SaveRecipeBtn
        Me.SaveRecipeBtn.Size = New System.Drawing.Size(94, 45)
        Me.SaveRecipeBtn.TabIndex = 9
        Me.SaveRecipeBtn.Text = "SAVE"
        '
        'CascadingRecipesDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 483)
        Me.Controls.Add(Me.SaveRecipeBtn)
        Me.Controls.Add(Me.CascadeRecipeListBox)
        Me.Controls.Add(Me.Guna2Separator2)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ConfirmRecipeBtn)
        Me.Controls.Add(Me.RemoveRecipeBtn)
        Me.Controls.Add(Me.AddRecipeBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "CascadingRecipesDialog"
        Me.Text = "Cascading Recipes"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents AddRecipeBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RemoveRecipeBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ConfirmRecipeBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label1 As Label
    Friend WithEvents CascadeRecipeListBox As ListBox
    Friend WithEvents SaveRecipeBtn As Guna.UI2.WinForms.Guna2Button
End Class
