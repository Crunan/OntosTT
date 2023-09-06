Public Class TestSerialPortManager
    Implements ISerialPortManager

    Public Sub OpenPort() Implements ISerialPortManager.OpenPort
        Throw New NotImplementedException()
    End Sub

    Public Sub ClosePort() Implements ISerialPortManager.ClosePort
        Throw New NotImplementedException()
    End Sub

    Public Sub WriteData(data As String) Implements ISerialPortManager.WriteData
        Throw New NotImplementedException()
    End Sub

    Public Function ReadData() As String Implements ISerialPortManager.ReadData
        Throw New NotImplementedException()
    End Function
End Class
