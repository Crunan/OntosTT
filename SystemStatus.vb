Public Class SystemStatus
    Private _status As Dictionary(Of String, String)
    Private _statusChanged As Boolean

    Public Sub New()
        _status = New Dictionary(Of String, String)()
        _statusChanged = False
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

    Public Sub SetStatus(status As Dictionary(Of String, String))
        ' Check if the new status is different from the current status
        If Not _status.SequenceEqual(status) Then
            _status = New Dictionary(Of String, String)(status)
            _statusChanged = True
        End If
    End Sub
End Class
