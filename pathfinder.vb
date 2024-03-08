Imports System.IO
Imports Newtonsoft.Json

Public Class PathFinder
    Public Property FilePath As String
    Public Property FileName As String
End Class

Public Class ConfigPaths
    Public Property Logs As List(Of PathFinder)
    Public Property Commands As List(Of PathFinder)
    Public Property ExeConfig As List(Of PathFinder)

    Public Shared Function LoadPathsFromFile(filePath As String) As ConfigPaths
        Dim configPaths As New ConfigPaths()

        Try
            ' Read the entire content of the file
            Dim jsonString As String = File.ReadAllText(filePath)

            ' Deserialize the JSON content into a ConfigPaths object
            configPaths = JsonConvert.DeserializeObject(Of ConfigPaths)(jsonString)

        Catch ex As Exception
            ' Handle exceptions, such as file not found or invalid JSON format
            Console.WriteLine($"Error loading paths from file: {ex.Message}")
        End Try

        Return configPaths
    End Function
End Class
