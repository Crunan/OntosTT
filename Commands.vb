Imports System.IO
Imports Newtonsoft.Json


Public Class CommandMetadata
    Public ReadOnly Property Command As String
    Public Property Formatted_Command As String
    Public Property Name As String
    Public Property Description As String
    Public Property LogMessage As String
    Public Property RequiresUserData As Boolean
    Public Property UserDataPlaceholder As String
    Public Property Value As String
End Class

Public Class CommandFileReader
    Public Function ReadCommandsFromFile(filePath As String, logger As Logger) As List(Of CommandMetadata)
        Dim commands As New List(Of CommandMetadata)

        Try
            ' Read the entire content of the file
            Dim jsonString As String = File.ReadAllText(filePath)

            ' Deserialize the JSON content into a list of CommandMetadata objects
            commands = JsonConvert.DeserializeObject(Of List(Of CommandMetadata))(jsonString)
        Catch ex As Exception
            ' Handle exceptions by logging them
            HandleErrorsFromFileRead(ex, logger)
        End Try

        Return commands
    End Function

    Private Sub HandleErrorsFromFileRead(ex As Exception, logger As Logger)
        ' Handle errors by logging them
        logger.WriteLogLine($"Error loading commands from file: {ex.Message}")
    End Sub
End Class

Public Class CommandManager
    Private _commands As List(Of CommandMetadata)
    Private _fileReader As CommandFileReader

    Public Sub New()
        _fileReader = New CommandFileReader
    End Sub

    Public Sub LoadCommandsFromFile(filePath As String, logger As Logger)
        _commands = _fileReader.ReadCommandsFromFile(filePath, logger)
    End Sub

    Public Function GetCommands() As List(Of CommandMetadata)
        Return _commands
    End Function


    Public Function FormatCommand(commandToExecute As CommandMetadata, userData As String, logger As Logger) As String
        ' Replace the placeholder with the actual user data
        Dim fullCommand As String = String.Format(commandToExecute.Command, userData)

        ' Log the formatted command
        logger.WriteLogLine($"Executing command: {fullCommand}")

        Return fullCommand
    End Function
    Public Function GetCommandByName(name As String, logger As Logger, Optional userData As String = "") As CommandMetadata
        ' Find the command based on the provided name
        Dim commandToExecute = _commands.FirstOrDefault(Function(cmd) cmd.Name = name)

        If commandToExecute Is Nothing Then
            ' Handle the case where the command is not found
            logger.WriteLogLine($"Command not found for name: {name}")
            Return Nothing
        End If

        ' Check if the command requires user data
        If commandToExecute.RequiresUserData Then
            ' Use the FormatCommand function to get the formatted command
            commandToExecute.Formatted_Command = FormatCommand(commandToExecute, userData, logger)
        End If

        ' Return the CommandMetadata object
        Return commandToExecute
    End Function

End Class

