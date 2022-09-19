Public Class DiameterEntryDialog
    Dim WaferDiameter As Integer = 0 'in case cancel without selection

    Private Sub RadioButton2Inch_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2Inch.CheckedChanged
        WaferDiameter = 50
    End Sub

    Private Sub RadioButton4Inch_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4Inch.CheckedChanged
        WaferDiameter = 100
    End Sub

    Private Sub RadioButton6Inch_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6Inch.CheckedChanged
        WaferDiameter = 150
    End Sub

    Private Sub RadioButton8Inch_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8Inch.CheckedChanged
        WaferDiameter = 200
    End Sub

    Private Sub DiamDlgOKBtn_Click(sender As Object, e As EventArgs) Handles DiamDlgOKBtn.Click
        MainWindow.SelectedWaferSize = WaferDiameter
        Me.Close()
    End Sub

    Private Sub RadioButton12Inch_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12Inch.CheckedChanged
        WaferDiameter = 300
    End Sub
End Class