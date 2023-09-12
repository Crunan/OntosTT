''' <summary>
''' Represents a class that communicates with a microcontroller.
''' </summary>
Public Class MicrocontrollerCommunicator
    Implements IDeviceCommunicator

    Public Sub WriteData(command As String) Implements IDeviceCommunicator.WriteData
        Throw New NotImplementedException()
    End Sub

    Public Sub ReadData() Implements IDeviceCommunicator.ReadData
        Throw New NotImplementedException()
    End Sub
End Class
