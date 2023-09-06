''' <summary>
''' Represents a class for testing communication with a microcontroller.
''' </summary>
Public Class TestCommunicator
    Implements IControllerCommunicator

    Private lastSentCommand As String
    Private command As String
    Private receiver As String

    ''' <summary>
    ''' Gets the last command that was sent to the microcontroller.
    ''' </summary>
    ''' <returns>The last command sent to the microcontroller as a string.</returns>
    Public Function getLastSentCommand()
        Return lastSentCommand
    End Function
    Public Sub WriteData(command As String) Implements IControllerCommunicator.WriteData
        ' Simulate sending the command for testing purposes.
        ' This can be a placeholder for testing without actual communication.
        Throw New NotImplementedException()
    End Sub


    Public Function ReadResponse() As String Implements IControllerCommunicator.ReadResponse
        ' Simulate sending the command for testing purposes.
        ' This can be a placeholder for testing without actual communication.
        Return "Test response"
    End Function
End Class
