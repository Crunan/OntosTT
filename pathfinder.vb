
Public Class PathFinder
    Public Property FilePath As String
    Public Property FileName As String

    Public ReadOnly Property GetPath() As String
        Get
            Return FilePath & FileName
        End Get
    End Property


End Class
