Imports Newtonsoft.Json
Imports System.IO

Public Class StatusKeysData
    Private _statusKeys As List(Of String)

    ' Read-only property to get the status keys
    Public ReadOnly Property Keys As List(Of String)
        Get
            Return _statusKeys
        End Get
    End Property
    ' Read JSON data from file and set the status keys
    Public Sub ReadStatusKeysFromFile(filePath As String, logger As Logger)
        Try
            ' Read JSON content from file
            Dim jsonContent As String = File.ReadAllText(filePath)

            ' Deserialize JSON array into List(Of String)
            _statusKeys = JsonConvert.DeserializeObject(Of List(Of String))(jsonContent)

            ' Log the header
            logger.WriteLogLine($"CTL_Status Keys: ")

            ' Log each status key individually
            For Each key As String In _statusKeys
                logger.WriteLogLine($"{key}")
            Next
        Catch ex As Exception
            ' Handle exceptions here
            logger.WriteLogLine($"CTL_Status Keys could not be loaded: {ex.Message}")
        End Try
    End Sub

End Class



Public Class SystemStatusParser
    Private _statusKeys As List(Of String)

    Public Sub New(statusKeys As List(Of String))
        If statusKeys Is Nothing OrElse statusKeys.Count = 0 Then
            Throw New ArgumentException("statusKeys must be provided and cannot be empty.")
        End If

        _statusKeys = statusKeys
    End Sub
    Public Function ParseSystemStatus(statusString As String) As Dictionary(Of String, String)
        Dim statusDictionary As New Dictionary(Of String, String)()

        ' Split the status string based on ";" delimiter
        Dim statusParts As String() = statusString.Split(";"c)

        ' Loop through each part and assign it to the corresponding key
        For i As Integer = 0 To Math.Min(statusParts.Length - 1, _statusKeys.Count - 1)
            statusDictionary(_statusKeys(i)) = statusParts(i).Trim()
        Next

        Return statusDictionary
    End Function
End Class

Public Class SystemStatus
    Private _status As Dictionary(Of String, String)
    Private _statusChanged As Boolean
    Private _parser As SystemStatusParser

    Public Sub New(parser As SystemStatusParser)
        _status = New Dictionary(Of String, String)()
        _statusChanged = False
        _parser = parser
    End Sub

    Public ReadOnly Property Status As Dictionary(Of String, String)
        Get
            Return _status
        End Get
    End Property

    Public ReadOnly Property StatusChanged As Boolean
        Get
            Return _statusChanged
        End Get
    End Property

    Private Sub SetStatus(status As Dictionary(Of String, String))
        ' Check if the new status is different from the current status
        If Not _status.SequenceEqual(status) Then
            _status = New Dictionary(Of String, String)(status)
            _statusChanged = True
        End If
    End Sub

    Public Sub ParseStatus(unparsedStatus As String)
        SetStatus(_parser.ParseSystemStatus(unparsedStatus))
    End Sub
End Class
