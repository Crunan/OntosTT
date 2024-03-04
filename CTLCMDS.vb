Public Class CTL
    Private _commandToSend As String

    Public Sub sendRunpointCommand(runpointChanged As Boolean, runpoint As String)
        If runpointChanged Then
            'TODO: Use emmetts new command to send runpoint value
            _commandToSend = "$43" & runpoint & "%"     'SET_RCP_MS_POS  $43xxxx$ xxxx = Base10 MB Motor Pos; resp[!43xxxx#]
            'WriteCommand(StrVar, Len(StrVar))
            'ResponseLen = ReadResponse(0)
            'TUNER.ResetRunpointChanged()
        End If
    End Sub

End Class
