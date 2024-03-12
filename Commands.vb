Imports System.IO
Imports System.IO.Ports
Imports Newtonsoft.Json

Public Interface ICommand
    Sub Execute(serialPort As SerialPort, data As Object)
End Interface

Public Class CommandMetadata
    Public Property Command As String
    Public Property Name As String
    Public Property Description As String
    Public Property LogMessage As String
    Public Property RequiresUserData As Boolean
    Public Property UserDataPlaceholder As String
End Class



Public Class CommandManager
    Private _commands As List(Of CommandMetadata)

    Public Sub LoadCommandsFromFile(filePath As String, logger As Logger)
        Try
            ' Read the entire content of the file
            Dim jsonString As String = File.ReadAllText(filePath)

            ' Deserialize the JSON content into a list of CommandMetadata objects
            _commands = JsonConvert.DeserializeObject(Of List(Of CommandMetadata))(jsonString)

        Catch ex As Exception
            ' Handle exceptions by calling the error handling function
            HandleErrorsFromFileRead(ex, logger)
        End Try
    End Sub

    Private Sub HandleErrorsFromFileRead(ex As Exception, logger As Logger)
        ' Handle errors by logging them
        logger.WriteLogLine($"Error loading commands from file: {ex.Message}")
    End Sub


    Public Function FormatCommand(commandToExecute As CommandMetadata, userData As String, logger As Logger) As String
        ' Replace the placeholder with the actual user data
        Dim fullCommand As String = String.Format(commandToExecute.Command, userData)

        ' Log the formatted command
        logger.WriteLogLine($"Executing command: {fullCommand}")

        Return fullCommand
    End Function
    Public Function GetCommandByName(name As String, userData As String, logger As Logger) As String
        ' Find the command based on the provided name
        Dim commandToExecute = _commands.FirstOrDefault(Function(cmd) cmd.Name = name)

        If commandToExecute Is Nothing Then
            ' Handle the case where the command is not found
            logger.WriteLogLine($"Command not found for name: {name}")
            Return ""
        End If

        ' Check if the command requires user data
        If commandToExecute.RequiresUserData Then
            ' Use the FormatCommand function to get the formatted command
            Return FormatCommand(commandToExecute, userData, logger)
        Else
            ' If no user data is required, return the command as is
            Return commandToExecute.Command
        End If
    End Function



End Class

