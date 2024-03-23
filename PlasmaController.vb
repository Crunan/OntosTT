Public Class PlasmaController
    Private _serial As SerialCommunication
    Private _commands As CommandManager
    Private _status As SystemStatus
    Private _logger As Logger

    Public Sub New(logger As Logger)
        _commands = New CommandManager
        _status = New SystemStatus
        _logger = logger
    End Sub

    Public Sub ConnectToPlasmaTool(serialPortName As String)
        ' Initialize SerialCommunication object
        _serial = New SerialCommunication(serialPortName)

        ' Perform connection steps (open port, send initialization commands, etc.)
        _serial.Open()

        ' Once connected, send a reset command
        ExecuteCommand("Reset")
    End Sub
    Public Sub DisconnectToPlasmaTool()
        ' Before disconnection, send a reset command
        ExecuteCommand("Reset")

        'Close the port
        _serial.Close()
    End Sub
    Public Sub ReadStatusKeysFromFile(filepath As String)
        _status.ReadStatusKeysFromFile(filepath, _logger)
    End Sub

    Public Function ExecuteCommand(commandName As String, Optional data As String = "") As String
        Dim command As CommandMetadata

        command = _commands.GetCommandByName(commandName, _logger, data)

        If command.RequiresUserData Then
            _serial.SendCommand(command.Formatted_Command, _logger)
        Else
            _serial.SendCommand(command.Command, _logger)
        End If

        Dim response As String = _serial.ReadResponse(_logger)

        command.Value = response

        Return response
    End Function

    Public Sub LoadCommandsFromFile(filepath As String)
        _commands.LoadCommandsFromFile(filepath, _logger)
    End Sub

    Public Sub RunStartup()
        ' Loop through each startup command
        For Each cmd In _commands.GetCommands()
            ' Send command
            _serial.SendCommand(cmd.Command, _logger)

            ' Read response
            Dim response As String = _serial.ReadResponse(_logger)

            ' Store response in CommandMetadata object
            cmd.Value = response

            ' Log the response
            _logger.WriteLogLine($"{cmd.LogMessage}{response}")
        Next
    End Sub

    Public Sub PollSystemStatus() 'Poll the Control and Axis PCBs for status (every 1 second)
        Dim command As CommandMetadata

        'Get the status command for the PCB
        command = _commands.GetCommandByName("Get_PCB_Status", _logger)

        'Send the status command for the PCB
        _serial.SendCommand(command.Command, _logger)

        'Read the response from the controller and store it
        command.Value = _serial.ReadResponse(_logger)

        'Store the parsed data in the status
        _status.ParseStatus(command.Value)
    End Sub

    Public Function GetStatusValueByKey(key As String) As String
        Return _status.GetValueByKey(key)
    End Function

End Class
