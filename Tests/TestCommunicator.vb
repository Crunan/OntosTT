''' <summary>
''' Represents a class for testing the IDeviceCommunication protocols.
''' </summary>
Public Class TestCommunicator
    Implements IDeviceCommunicator
    Public Sub WriteData(command As String) Implements IDeviceCommunicator.WriteData
        Throw New NotImplementedException()
    End Sub

    Public Sub ReadData() Implements IDeviceCommunicator.ReadData
        Throw New NotImplementedException()
    End Sub
End Class
