''' <summary>
''' Represents a class that communicates with a microcontroller.
''' </summary>
Public Class MicrocontrollerCommunicator
    Implements IDeviceCommunicator

    Public Property PortManager As IPortManager Implements IDeviceCommunicator.PortManager
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As IPortManager)
            Throw New NotImplementedException()
        End Set
    End Property

    Public ReadOnly Property ResponseData As String Implements IDeviceCommunicator.ResponseData
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public ReadOnly Property LastCommandSent As String Implements IDeviceCommunicator.LastCommandSent
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Sub WriteData(command As String) Implements IDeviceCommunicator.WriteData
        Throw New NotImplementedException()
    End Sub

    Public Sub ReadResponse() Implements IDeviceCommunicator.ReadResponse
        Throw New NotImplementedException()
    End Sub
End Class
