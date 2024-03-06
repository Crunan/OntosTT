Imports System.IO.Ports
Imports System.Text.RegularExpressions

Public Class SerialController
    Implements IDevice
    Implements IDisposable

    Private _serialPort As SerialPort
    Private _rawResponse As String
    Private _responseValue As String
    Private _lastCommand As String

    Public Sub New(serial As SerialPort)
        _serialPort = serial
    End Sub

    Public Property ResponseValue() As String
        Get
            Return _responseValue
        End Get
        Set(data As String)
            _responseValue = data
        End Set
    End Property

    Private Sub Send(command As String) Implements IDevice.Send
        ' Implementation of WriteCommand
        If _serialPort.IsOpen Then
            _lastCommand = command

            For Index As Integer = 0 To (command.Length - 1)
                _serialPort.Write(command, Index, 1)
            Next
        End If
        ' You may want to handle exceptions or other error conditions
    End Sub

    Private Sub Read() Implements IDevice.Read
        _rawResponse = ""

        While True
            Dim currentByte As Integer = _serialPort.ReadByte()

            If currentByte = Asc("#") Then
                Exit While ' Exit the loop when "#" is found
            End If

            ' Process the current byte (if needed)
            If currentByte > 31 AndAlso currentByte < 127 Then
                _rawResponse += Chr(currentByte)
            End If
        End While
    End Sub

    Private Function Parse() As Boolean
        Dim pattern As String = "!" & Regex.Escape(_lastCommand) & "(\d+)#"
        Dim match = Regex.Match(_rawResponse, pattern)

        ResponseValue = ""
        If match.Success Then
            ResponseValue = match.Groups(1).Value
            Return True
        Else
            ' Log the information when the match is not succesful
            Console.WriteLine("Failed to parse the response for command: " & _lastCommand)
            Return false
        End If
    End Function

    Public Sub connect() Implements IDevice.Connect
        Try
            If Not _serialPort.IsOpen Then _serialPort.Open()
        Catch ex As Exception
            ' Handle the exception or log the error
        End Try

    End Sub

    Public Function SendCommandAndParseResponse(command As String) As Boolean
        Send(command)
        Read()
        Return Parse()
    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
        ' Dispose of any resources here
        If _serialPort IsNot Nothing Then
            If _serialPort.IsOpen Then
                _serialPort.Close()
            End If
            _serialPort.Dispose()
        End If
    End Sub


End Class
