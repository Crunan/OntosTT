Imports System.IO
Imports Newtonsoft.Json

Public Class CommandInfo
    Public Property Command As String
    Public Property Variable As String
    Public Property LogMessage As String

    Private Function LoadCommandsFromFile(filepath As String) As List(Of CommandInfo)
        Dim commands As New List(Of CommandInfo)

        Try
            ' Read the entire content of the file
            Dim jsonString As String = File.ReadAllText(filepath)

            ' Deserialize the JSON content into a list of CommandInfo objects
            commands = JsonConvert.DeserializeObject(Of List(Of CommandInfo))(jsonString)

        Catch ex As Exception
            ' Handle exceptions, such as file not found or invalid JSON format
            Console.Write($"Error loading commands from file: (ex.Message)")
        End Try

        Return commands
    End Function
End Class
