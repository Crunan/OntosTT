''' <summary>
''' an interface that abstracts the management of communication ports.
''' </summary>
Public Interface IPortManager
    ''' <summary>
    ''' Performs initialization tasks for setting up a communication port.
    ''' </summary>
    Sub Initialize(name As String)

    ''' <summary>
    ''' Attempts to open the port connection.
    ''' </summary>
    Sub OpenPort()

    ''' <summary>
    ''' Attempts to close the port connection.
    ''' </summary>
    Sub ClosePort()

    ''' <summary>
    ''' Performs cleanup tasks when you're finished using the communication ports 
    ''' </summary>
    Sub Dispose(name As String)

End Interface
