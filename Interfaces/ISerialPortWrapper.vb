Public Interface ISerialPortWrapper
    Property isConnected As Boolean

    Sub Open()
    Sub Close()
    Function Read() As String
    Sub Write(data As String)

End Interface