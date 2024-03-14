Imports System.IO.Ports

Public Interface ISerialCommunication
    Sub Open()
    Sub Close()
    Sub SendCommand(command As String, logger As Logger)
    Function ReadResponse(logger As Logger) As String
End Interface

Public Class SerialCommunication
    Implements ISerialCommunication
    Private _serialPort As SerialPort

    Public Sub New(serialPort As SerialPort)
        _serialPort = serialPort
    End Sub

    Public Sub Open() Implements ISerialCommunication.Open
        If Not _serialPort.IsOpen Then
            _serialPort.Open()

        End If
    End Sub

    Public Sub Close() Implements ISerialCommunication.Close
        If _serialPort.IsOpen Then
            _serialPort.Close()
        End If
    End Sub

    Public Sub SendCommand(command As String, logger As Logger) Implements ISerialCommunication.SendCommand
        If _serialPort.IsOpen Then
            _serialPort.Write(command)
        Else
            ' Handle error or log message
            logger.WriteLogLine($"Unable to send command: {command}, check serial communication")
        End If
    End Sub

    Public Function ReadResponse(logger As Logger) As String Implements ISerialCommunication.ReadResponse
        Dim response As String = ""

        If _serialPort.IsOpen Then
            response = _serialPort.ReadLine()
        Else
            logger.WriteLogLine($"Unable to read response, check serial communication")
        End If

        Return response
    End Function
End Class

Public Class SerialController
    Private _serialCommunication As ISerialCommunication

    Public Sub New(serialCommunication As ISerialCommunication)
        _serialCommunication = serialCommunication
    End Sub

    Public Sub SendCommand(command As String, logger As Logger)
        _serialCommunication.SendCommand(command, logger)
    End Sub

    Public Function ReadResponse(logger As Logger) As String
        Return _serialCommunication.ReadResponse(logger)
    End Function

    Public Sub OpenConnection()
        _serialCommunication.Open()
    End Sub

    Public Sub CloseConnection()
        _serialCommunication.Close()
    End Sub
End Class
