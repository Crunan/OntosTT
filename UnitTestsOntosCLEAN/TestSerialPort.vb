Imports OntosCLEAN
Imports Moq

<TestClass()> Public Class TestSerialPort

    <TestMethod()>
    Public Sub TestOpen()
        ' Arrange 
        Dim mockSerialPort As New Mock(Of ISerialPortWrapper)()

        ' Act
        mockSerialPort.Object.Open()

        ' Assert
        mockSerialPort.Verify(Sub(serialport) serialport.Open(), Times.Once())
    End Sub

    <TestMethod>
    Public Sub TestClose()
        ' Arrange
        Dim mockSerialPort As New Mock(Of ISerialPortWrapper)

        ' Act 
        mockSerialPort.Object.Close()

        ' Assert 
        mockSerialPort.Verify(Sub(serialport) serialport.Close(), Times.Once())

    End Sub

    <TestMethod()>
    Public Sub TestIsConnected()
        ' Arrange
        Dim mockSerialPort As New Mock(Of ISerialPortWrapper)()
        mockSerialPort.Setup(Function(sp) sp.isConnected).Returns(True)

        ' Act
        Dim isConnected As Boolean = mockSerialPort.Object.isConnected

        ' Assert
        Assert.IsTrue(isConnected, "The port is not reported as open when it should be.")
        mockSerialPort.Verify(Function(sp) sp.isConnected, Times.Once(), "The IsOpen method was not called exactly once.")
    End Sub



End Class