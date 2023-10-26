Public Class SettingsWindow     

    Private Sub SettingsConfirmBTN_Click(sender As Object, e As EventArgs) Handles SettingsConfirmBTN.Click
        if AutoScanChkBox.Checked = True then            
            MainWindow.b_autoScanActive = true
            MainWindow.st_AutoScanSave = "1"
            MainWindow.b_toggleAutoScan = true
        else 
            MainWindow.b_autoScanActive = false
            MainWindow.st_AutoScanSave = "0"
        End If


        If CollisionCheckBox.Checked = true then
            MainWindow.b_HasCollision = true
        else
            MainWindow.b_HasCollision = False  
        End If


        Me.Close
    End Sub

    Private Sub ExitBTN_Click(sender As Object, e As EventArgs) Handles ExitBTN.Click
        Me.Close
    End Sub

End Class