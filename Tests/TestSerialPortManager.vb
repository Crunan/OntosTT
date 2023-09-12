Public Class TestSerialPortManager
    Implements IPortManager

    Public Sub ReadData() Implements IPortManager.ReadData
        Throw New NotImplementedException()
    End Sub

    Public Sub WriteData(data As String) Implements IPortManager.WriteData
        Throw New NotImplementedException()
    End Sub

    Public Sub SetPortSettings() Implements IPortManager.SetPortSettings
        Throw New NotImplementedException()
    End Sub

    Public Sub SetPortName(name As String) Implements IPortManager.SetPortName
        Throw New NotImplementedException()
    End Sub

    Public Sub OpenPort() Implements IPortManager.OpenPort
        Throw New NotImplementedException()
    End Sub

    Public Sub ClosePort() Implements IPortManager.ClosePort
        Throw New NotImplementedException()
    End Sub
End Class
