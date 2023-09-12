''' <summary>
''' an interface that abstracts the communication with devices.
''' </summary>
Public Interface IDeviceCommunicator

    ''' <summary>
    ''' Writes a command to a device.
    ''' </summary>
    ''' <param name="data">The data to send as a string.</param>
    Sub WriteData(data As String)

    ''' <summary>
    ''' Reads the data from a device.
    ''' </summary>
    Sub ReadData()
End Interface
