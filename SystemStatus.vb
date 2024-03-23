Imports Newtonsoft.Json
Imports System.IO

Public Class SystemStatusParser
    Private _statusKeys As List(Of String)

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
    Public _parser As SystemStatusParser

    Public Sub New()
        _status = New Dictionary(Of String, String)()
        _statusChanged = False
        _parser = New SystemStatusParser()
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
    Public Function GetValueByKey(key As String) As String
        If _status.ContainsKey(key) Then
            Return _status(key)
        Else
            ' Key not found, you can handle this case as needed
            ' For example, you could throw an exception, return a default value, or log a message
            Return Nothing ' Or throw New KeyNotFoundException("Key not found: " & key)
        End If
    End Function

    Public Sub ParseStatus(unparsedStatus As String)
        SetStatus(_parser.ParseSystemStatus(unparsedStatus))
    End Sub
    Public Sub ReadStatusKeysFromFile(filepath As String, logger As Logger)
        _parser.ReadStatusKeysFromFile(filepath, logger)
    End Sub
End Class
