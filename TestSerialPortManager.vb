Public Class TestSerialPortManager
    Implements IPortManager
    Public Sub SetPort(name As String) Implements IPortManager.SetPort
        Throw New NotImplementedException()
    End Sub
    Public Sub OpenPort() Implements IPortManager.OpenPort
        Throw New NotImplementedException()
    End Sub

    Public Sub ClosePort() Implements IPortManager.ClosePort
        Throw New NotImplementedException()
    End Sub

    Public Sub WriteData(data As String) Implements IPortManager.WriteData
        Throw New NotImplementedException()
    End Sub

    Public Function ReadData() As String Implements IPortManager.ReadData
        Throw New NotImplementedException()
    End Function
End Class
