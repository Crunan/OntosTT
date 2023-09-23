''' <summary>
''' An abstract interface for bridging connection and communication with a device. 
''' </summary>
Public Interface IDevice
    ''' <summary>
    ''' Connects to a device.
    ''' </summary>
    Sub Connect()

    ''' <summary>
    ''' Disconnects from a device.
    ''' </summary>
    Sub Disconnect()

    ''' <summary>
    ''' Gives the status of the device connection.
    ''' </summary>
    ''' <returns>The status of the connection as a boolean.</returns>
    Function isConnected() As Boolean

    ''' <summary>
    ''' Read from the device.
    ''' </summary>
    ''' <returns></returns>
    Function Read() As String

    ''' <summary>
    ''' Write to the device.
    ''' </summary>
    ''' <param name="data">Data written to the device as a string.</param>
    Sub Write(data As String)
End Interface
