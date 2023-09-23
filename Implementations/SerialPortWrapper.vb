Imports System.IO.Ports

Public Class SerialPortWrapper
    Implements ISerialPortWrapper

    Private serialPort As SerialPort

    Public Sub New()
        serialPort = New SerialPort()
    End Sub

    Public Property isConnected As Boolean Implements ISerialPortWrapper.isConnected
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Boolean)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Sub Open() Implements ISerialPortWrapper.Open
        serialPort.Open()
    End Sub

    Public Sub Close() Implements ISerialPortWrapper.Close
        serialPort.Close()
    End Sub
    Public Sub Write(data As String) Implements ISerialPortWrapper.Write
        Throw New NotImplementedException()
    End Sub

    Public Function Read() As String Implements ISerialPortWrapper.Read
        Throw New NotImplementedException()
    End Function

    ' Implement other members of ISerialPortWrapper as needed
End Class
