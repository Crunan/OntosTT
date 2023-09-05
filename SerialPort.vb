Public Class SerialPort
    Private port As System.IO.Ports.SerialPort
    Private lastCommandSent As String
    Private Command As String
    Private errorActive As Boolean

    Private Sub SetLastRecieved(cmd As String)
        lastCommandSent = cmd
    End Sub

    Public Sub WritesubCommand()
        Dim Index As Integer
        If port.IsOpen Then 'if the connection is closed, dont run the code
            SetLastRecieved(Command)    'for debug, esp when have read timeout
            port.DiscardInBuffer() 'clear receive buffer
            If (Command > 90) Then Command = 90 'don't overrun CTLer input buffers
            For Index = 0 To (Command.Length() - 1) 'one char at a time
                port.Write(Command, Index, 1)
            Next
        Else
            errorActive = True
        End If
    End Sub
End Class
