Imports System.IO

Public Class Logger
    Private _timeStamp As String
    Private _filePath As String
    Private _fileName As String
    Private _logLineOut As StreamWriter
    Private _logOpen As Boolean = False

    ' Properties for file path and file name
    Public ReadOnly Property LogFilePath As String
        Get
            Return _filePath
        End Get
    End Property

    Public Property LogFileName As String
        Get
            Return _fileName
        End Get
        Private Set(value As String)
            _fileName = value
        End Set
    End Property

    ' Constructor with filename and filepath arguments
    Public Sub New(fileName As String, filePath As String)
        _fileName = fileName
        _filePath = Path.Combine(filePath, $"{fileName}_{System.DateTime.Now.ToString("yyyy-MM-dd")}.log")
    End Sub

    Public Sub OpenLogFile()
        If Not _logOpen Then
            _logLineOut = New StreamWriter(LogFilePath, True) ' open with append rights
            _logLineOut.AutoFlush = True ' constantly flush to the file so can tail the log file
            _logOpen = True
        End If
    End Sub

    Public Sub WriteLogLine(st_Line As String)
        If _logOpen Then
            _timeStamp = System.DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss.fff | ")
            _logLineOut.WriteLine(_timeStamp + st_Line) ' Log File Line
        End If
    End Sub

    Public Sub CloseLogFile()
        If _logOpen Then
            _logLineOut.Close()
            _logOpen = False
        End If
    End Sub
End Class
