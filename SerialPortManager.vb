Imports System.IO.Ports

Public Class SerialPortManager
    Implements ISerialPortManager

    Private serialPort As New SerialPort()
    Private communicator As IControllerCommunicator

    Public Sub New(comms As IControllerCommunicator)
        serialPort.BaudRate = 57600
        serialPort.DataBits = 8
        serialPort.StopBits = StopBits.One
        serialPort.Parity = Parity.None
        serialPort.Handshake = Handshake.None
        serialPort.ReadTimeout = 2000
        serialPort.WriteTimeout = 2000 '
        communicator = comms
    End Sub

    Public Sub SetPort(name As String) Implements ISerialPortManager.SetPort
        serialPort.PortName = name
    End Sub

    Public Sub OpenPort() Implements ISerialPortManager.OpenPort
        Try
            If Not serialPort.IsOpen Then serialPort.Open()
        Catch ex As Exception
            Throw New Exception("An error occurred while opening the serial port:" & ex.Message, ex)
        End Try
    End Sub

    Public Sub ClosePort() Implements ISerialPortManager.ClosePort
        Try
            If serialPort.IsOpen Then serialPort.Close()
        Catch ex As Exception
            Throw New Exception("An error occurred while trying to close the serial port:" & ex.Message, ex)
        End Try
    End Sub

    Public Sub WriteData(data As String) Implements ISerialPortManager.WriteData
        Try
            communicator.WriteData(data)
        Catch ex As Exception
            Throw New Exception("An error occurred while trying to write data to the port.")
        End Try
    End Sub


    Public Function ReadData() As String Implements ISerialPortManager.ReadData
        Try
            Return communicator.ReadResponse()
        Catch ex As Exception
            Throw New Exception("An error occurred while trying to read data from the port.")
        End Try
    End Function
End Class
