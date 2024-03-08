Imports System.IO

Public Class Logger
    Private _timeStamp As String
    Private _filepath As String
    Private _logLineOut As StreamWriter
    Private _logOpen As Boolean = False


    Public Sub OpenLogFile(file As PathFinder)
        If Not _logOpen Then
            _filepath = Path.Combine(file.FilePath, $"{file.FileName}_{System.DateTime.Now.ToString("yyyy-MM-dd")}.log")
            _logLineOut = New StreamWriter(_filepath, True) ' open with append rights
            _logLineOut.AutoFlush = True ' constantly flush to the file so can tail the log file
            _logOpen = True
        End If
    End Sub

    Public Sub WriteLogLine(line As String)
        If _logOpen Then
            _timeStamp = System.DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss.fff | ")
            _logLineOut.WriteLine(_timeStamp + line) ' Log File Line
        End If
    End Sub

    Public Sub CloseLogFile()
        If _logOpen Then
            _logLineOut.Close()
            _logOpen = False
        End If
    End Sub
End Class
