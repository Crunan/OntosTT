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

    Public Sub New(statusKeys As List(Of String))
        _status = New Dictionary(Of String, String)()
        _statusChanged = False
        _parser = New SystemStatusParser(statusKeys)
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
