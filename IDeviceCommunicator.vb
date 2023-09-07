''' <summary>
''' Represents an interface for communicating with a device.
''' </summary>
Public Interface IDeviceCommunicator
    ''' <summary>
    ''' The interface that manages the port.
    ''' </summary>
    ''' <returns>The port manager object.</returns>
    Property PortManager As IPortManager

    ''' <summary>
    ''' The data that was read from ReadResponse().
    ''' </summary>
    ''' <returns>The response from the device as a string.</returns>
    ReadOnly Property ResponseData As String

    ''' <summary>
    ''' The data that was sent from the 
    ''' </summary>
    ''' <returns>The last command that was sent to the device as a string.</returns>
    ReadOnly Property LastCommandSent As String

    ''' <summary>
    ''' Writes a command to the device.
    ''' </summary>
    ''' <param name="command">The command to send as a string.</param>
    Sub WriteData(command As String)

    ''' <summary>
    ''' Reads the response from the device and stores the data.
    ''' </summary>
    Sub ReadResponse()
End Interface
