''' <summary>
''' Represents an interface for managing the port of a device.
''' </summary>
Public Interface IPortManager
    ''' <summary>
    ''' Sets the port settings.
    ''' </summary>
    Sub SetPortSettings()

    ''' <summary>
    ''' Attempts to set the port name.
    ''' </summary>
    ''' <param name="name">The name of the port.</param>
    Sub SetPortName(name As String)

    ''' <summary>
    ''' Attempts to open the port connection.
    ''' </summary>
    Sub OpenPort()

    ''' <summary>
    ''' Attempts to close the port connection.
    ''' </summary>
    Sub ClosePort()
End Interface
