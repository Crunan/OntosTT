''' <summary>
''' Represents an interface for communicating with a microcontroller.
''' </summary>
Public Interface IControllerCommunicator
    ''' <summary>
    ''' Writes a command to the microcontroller.
    ''' </summary>
    ''' <param name="command">The command to send as a string.</param>
    Sub Write(command As String)

    ''' <summary>
    ''' Reads the response from the microcontroller.
    ''' </summary>
    ''' <return>The response from the microcontroller as a string.</return>
    Function Read() As String

End Interface
