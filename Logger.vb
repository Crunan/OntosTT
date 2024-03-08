Imports System.IO

Public Class Logger
    Private _timeStamp As String
    Private _filePath As String
    Private _fileName As String
    Private _logLineOut As StreamWriter
    Private _logOpen As Boolean = False

    ' Properties for file path and file name
    Public Property LogFilePath As String
        Get
            Return _filePath
        End Get
        Private Set(value As String)
            _filePath = value
        End Set
    End Property

    Public Property LogFileName As String
        Get
            Return _fileName
        End Get
        Private Set(value As String)
            _fileName = value
        End Set
    End Property

    Public Sub OpenLogFile()
        _timeStamp = System.DateTime.Now.ToString("yyyy-MM-dd")
        LogFilePath = Path.Combine(LogFilePath, $"{LogFileName}_{_timeStamp}.log")
        _logLineOut = New StreamWriter(LogFilePath, True) ' open with append rights
        _logLineOut.AutoFlush = True ' constantly flush to the file so can tail the log file
        _logOpen = True
    End Sub

    Public Sub WriteLogLine(line As String)
        _timeStamp = System.DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss.fff | ")
        If _logOpen Then
            _logLineOut.WriteLine(_timeStamp + line) ' Log File Line
        End If
    End Sub

    Public Sub CloseLogFile()
        _logOpen = False
        _logLineOut.Close()
    End Sub
End Class
