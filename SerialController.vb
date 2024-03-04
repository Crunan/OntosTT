Imports System.IO.Ports
Imports System.Text.RegularExpressions

Public Class SerialController
    Private _serialPort As SerialPort
    Private _RCV As String
    Private _parsedResponse As String
    Private _lastCommand As String


    Private Property ParsedResponse() As String
        Get
            Return _parsedResponse
        End Get
        Set(data As String)
            _parsedResponse = data
        End Set
    End Property

    Private Sub WriteCommand(command As String)
        ' Implementation of WriteCommand
        If _serialPort.IsOpen Then
            _lastCommand = command

            For Index As Integer = 0 To (command.Length - 1)
                _serialPort.Write(command, Index, 1)
            Next
        End If
        ' You may want to handle exceptions or other error conditions
    End Sub

    Private Sub ReadResponse()
        _RCV = ""

        While True
            Dim currentByte As Integer = _serialPort.ReadByte()

            If currentByte = Asc("#") Then
                Exit While ' Exit the loop when "#" is found
            End If

            ' Process the current byte (if needed)
            If currentByte > 31 AndAlso currentByte < 127 Then
                _RCV += Chr(currentByte)
            End If
        End While
    End Sub

    Private Function ParseResponse() As Boolean
        Dim pattern As String = "!" & Regex.Escape(_lastCommand) & "(\d+)#"
        Dim match = Regex.Match(_RCV, pattern)

        _parsedResponse = ""
        If match.Success Then
            ParsedResponse = match.Groups(1).Value
        End If
    End Function
    ' Constructor that takes a SerialPort instance
    Public Sub SetPort(port As SerialPort)
        _serialPort = port
    End Sub

    Public Function SendCommandAndParseResponse(command As String) As Boolean
        WriteCommand(command)
        ReadResponse()
        Return ParseResponse()
    End Function

    Public Function getParsedResponse() As String
        Return ParsedResponse
    End Function

End Class
