''' <summary>
''' Represents an interface for managing the serial port of a device.
''' </summary>
Public Interface ISerialPortManager
    ''' <summary>
    ''' Attempts to set the port name.
    ''' </summary>
    ''' <param name="name">The name of the port.</param>
    Sub SetPort(name As String)

    ''' <summary>
    ''' Attempts to open the serial port connection.
    ''' </summary>
    Sub OpenPort()

    ''' <summary>
    ''' Attempts to close the serial port connection.
    ''' </summary>
    Sub ClosePort()

    ''' <summary>
    ''' Attempts to use the write protocol on the port.
    ''' </summary>
    ''' <param name="data">Write data to the port</param>
    Sub WriteData(data As String)

    ''' <summary>
    ''' Attempts to use the read protocol on the port.
    ''' </summary>
    ''' <returns>Returns the data from the port protocol as a string.</returns>
    Function ReadData() As String

End Interface
