Imports System.IO.Ports
Imports System.Text
Public Class Device
    Implements IDevice

    Private serialPort As ISerialPortWrapper

    Public Sub New(serialPort As ISerialPortWrapper)
        Me.serialPort = serialPort
    End Sub

    Public Sub Connect() Implements IDevice.Connect
        Try
            serialPort.Open()
        Catch ex As Exception
            MsgBox("Unable to connect: " & ex.Message)
        End Try
    End Sub

    Public Sub Disconnect() Implements IDevice.Disconnect
        Try
            serialPort.Close()
        Catch ex As Exception
            MsgBox("Unable to disconnect: " & ex.Message)
        End Try
    End Sub

    Public Sub Write(data As String) Implements IDevice.Write
        Try
            serialPort.Write(data)
        Catch ex As Exception
            MsgBox("Unable to write to device: " & ex.Message)
        End Try
    End Sub

    Public Function Read() As String Implements IDevice.Read
        Dim dataFromDevice As String = ""
        Try
            serialPort.Read()
        Catch ex As Exception
            MsgBox("Unable to read from device: " & ex.Message)
        End Try
    End Function

    Public Function isConnected() As Boolean Implements IDevice.isConnected
        Return serialPort.isConnected()
    End Function
End Class
