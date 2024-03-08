Imports System.IO
Imports Newtonsoft.Json
Public Class ExeConfig
    Public Property MFC_Label_1 As String
    Public Property MFC_Label_2 As String
    Public Property MFC_Label_3 As String
    Public Property MFC_Label_4 As String
    Public Property KNOWN_PORT As String

    Public Shared Function LoadExeConfigData(filePath As String) As ExeConfig
        Dim exeConfig As New ExeConfig()

        Try
            ' Read the entire content of the file
            Dim jsonString As String = File.ReadAllText(filePath)

            ' Deserialize the JSON content into an ExeConfig object
            exeConfig = JsonConvert.DeserializeObject(Of ExeConfig)(jsonString)

        Catch ex As Exception
            ' Handle exceptions, such as file not found or invalid JSON format
            Console.WriteLine($"Error loading ExeConfig data from file: {ex.Message}")
        End Try

        Return exeConfig
    End Function
End Class
