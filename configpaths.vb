Imports System.IO
Imports Newtonsoft.Json


Public Class ConfigPaths
    Public Property Logs As PathFinder
    Public Property Startup_Commands As PathFinder
    Public Property Runtime_Commands As PathFinder
    Public Property ExeConfig As PathFinder
    Public Property CTL_Keys As PathFinder

    ' Define a shared constant for the known location of the file containing other file locations
    Public Shared ReadOnly KnownLocationFilePath As String = "C:\OTT_PLUS\ConfigPath\paths.json"

    Public Shared Function LoadPathsFromFile() As ConfigPaths
        Dim configPaths As New ConfigPaths()

        Try
            ' Read the entire content of the file from the known location
            Dim jsonString As String = File.ReadAllText(KnownLocationFilePath)

            ' Deserialize the JSON content into a ConfigPaths object
            configPaths = JsonConvert.DeserializeObject(Of ConfigPaths)(jsonString)

        Catch ex As Exception
            ' Handle exceptions, such as file not found or invalid JSON format
            Console.WriteLine($"Error loading paths from file: {ex.Message}")
        End Try

        Return configPaths
    End Function
End Class
