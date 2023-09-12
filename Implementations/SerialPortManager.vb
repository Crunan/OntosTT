Imports System.IO.Ports

Public Class SerialPortManager
    Implements IPortManager

    Private ReadOnly Serial As New SerialPort()
    Private ResponseData As String = ""

    Public Sub SetPortName(name As String) Implements IPortManager.SetPortName
        Serial.PortName = name
    End Sub

    Public Sub SetPortSettings() Implements IPortManager.SetPortSettings
        Serial.BaudRate = 57600
        Serial.DataBits = 8
        Serial.StopBits = StopBits.One
        Serial.Parity = Parity.None
        Serial.Handshake = Handshake.None
        Serial.ReadTimeout = 1000
        Serial.WriteTimeout = 2000
    End Sub

    Public Sub OpenPort() Implements IPortManager.OpenPort
        Try
            If Not Serial.IsOpen Then
                Serial.Open()
            End If
        Catch ex As Exception
            Throw New Exception("An error occurred while opening the serial port:" & ex.Message, ex)
        End Try
    End Sub

    Public Sub ClosePort() Implements IPortManager.ClosePort
        Try
            If Serial.IsOpen Then Serial.Close()
        Catch ex As Exception
            Throw New Exception("An error occurred while trying to close the serial port:" & ex.Message, ex)
        End Try
    End Sub


    Public Sub ReadData() Implements IPortManager.ReadData

    End Sub

    Public Sub WriteData(data As String) Implements IPortManager.WriteData
        Serial.Write(data)
    End Sub
End Class
