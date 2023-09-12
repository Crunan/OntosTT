''' <summary>
''' This class acts as a bridge between the communication port management and device communication.
''' </summary>
Public Class DeviceManager
    Private portManager As IPortManager
    Private deviceCommunicator As IDeviceCommunicator

    Public Sub New(portManager As IPortManager, deviceCommunicator As IDeviceCommunicator)
        Me.portManager = portManager
        Me.deviceCommunicator = deviceCommunicator
    End Sub


End Class
