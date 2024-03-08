Imports System.IO
Imports Newtonsoft.Json

Public Class CommandCategory
    Public Property StartupCommands As List(Of CommandInfo)
    Public Property RuntimeCommands As List(Of CommandInfo)

    Public Class CommandInfo
        Public Property Command As String
        Public Property Variable_Name As String
        Public Property Value As String
        Public Property LogMessage As String
    End Class

    Public Function LoadCommandsFromFile(filepath As String) As CommandCategory
        Dim commandCategory As New CommandCategory()

        Try
            ' Read the entire content of the file
            Dim jsonString As String = File.ReadAllText(filepath)

            ' Deserialize the JSON content into a CommandCategory object
            commandCategory = JsonConvert.DeserializeObject(Of CommandCategory)(jsonString)

        Catch ex As Exception
            ' Handle exceptions, such as file not found or invalid JSON format
            Console.Write($"Error loading commands from file: {ex.Message}")
        End Try

        Return commandCategory
    End Function
End Class
