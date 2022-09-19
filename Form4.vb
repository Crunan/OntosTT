Public Class Form4     

    Private Sub SettingsConfirmBTN_Click(sender As Object, e As EventArgs) Handles SettingsConfirmBTN.Click
        if AutoScanChkBox.Checked = True then            
            MainWindow.b_autoScanActive = true
            MainWindow.st_AutoScanSave = "1"
            MainWindow.b_toggleAutoScan = true
        else 
            MainWindow.b_autoScanActive = false
            MainWindow.st_AutoScanSave = "0"
        End If

        if PreheatChkBox.Checked = true then
            MainWindow.b_heaterActive = true     
            MainWindow.st_HasHeatSave = "1"
            MainWindow.b_toggleHeater = true
        else
            MainWindow.b_heaterActive = False   
            MainWindow.st_HasHeatSave = "0"
            MainWindow.b_toggleHeater = true
        End If

        if CollisionCheckBox.Checked = true then
            MainWindow.b_HasCollision = true
        else
            MainWindow.b_HasCollision = False  
        End If

        if BatchChkBox.Checked = true then
            MainWindow.b_batchActive = True
            MainWindow.b_togglebatchIDLogging = True            
        Else 
            MainWindow.b_batchActive = false
            MainWindow.b_togglebatchIDLogging = true 
        End If
        Me.Close
    End Sub

    Private Sub ExitBTN_Click(sender As Object, e As EventArgs) Handles ExitBTN.Click
        Me.Close
    End Sub

End Class