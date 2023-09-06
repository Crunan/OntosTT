''' <summary>
''' Represents a class that communicates with a microcontroller.
''' </summary>
Public Class MicrocontrollerCommunicator
    Implements IControllerCommunicator

    Private ReadOnly lastSentCommand As String
    Private ReadOnly receiver As String

    ''' <summary>
    ''' Gets the last command that was sent to the microcontroller.
    ''' </summary>
    ''' <returns>The last command sent to the microcontroller as a string.</returns>
    Public Function getLastSentCommand()
        Return lastSentCommand
    End Function

    Public Sub WriteData(command As String) Implements IControllerCommunicator.WriteData
        ' Write the command to the microcontroller
        ' Implementation specific to your microcontroller communication. 
        Throw New NotImplementedException()
    End Sub

    Public Function ReadResponse() As String Implements IControllerCommunicator.ReadResponse
        ' Read the response from the microcontroller.
        ' Implementation specific to your microcontroller communication.
        Return receiver
        Throw New NotImplementedException()
    End Function
End Class
