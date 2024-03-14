Public Class PlasmaController
    Private _serial As SerialController
    Private _commands As CommandManager
    Private _status As SystemStatus
    Private _logger As Logger

    Public Sub New(logger As Logger)
        _commands = New CommandManager
        _status = New SystemStatus
        _logger = logger
    End Sub

    Public Sub SetupComms(serial As ISerialCommunication)
        _serial = serial
    End Sub
    Public Sub ReadStatusKeysFromFile(filepath As String)
        _status.ReadStatusKeysFromFile(filepath, _logger)
    End Sub

    Public Sub LoadCommandsFromFile(filepath As String)
        _commands.LoadCommandsFromFile(filepath, _logger)
    End Sub

    Public Sub RunStartup()
        ' Loop through each startup command
        For Each cmd In _commands.GetCommands()
            ' Send command
            _serial.SendCommand(cmd.Command)

            ' Read response
            Dim response As String = _serial.ReadResponse()

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
        _serial.SendCommand(command.Command)

        'Read the response from the controller and store it
        command.Value = _serial.ReadResponse()

        'Store the parsed data in the status
        _status.ParseStatus(command.Value)
    End Sub
End Class
