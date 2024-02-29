Public Structure TunerSystemManager
    Private _strikepoint As Integer
    Private _runpoint As Integer
    Private _current_position As Integer

    ' Strikepoint is used for the matching networks strikepoint delta.
    Public Property Strikepoint() As Integer
        Get
            Return _strikepoint
        End Get
        Set(value As Integer)
            _strikepoint = value
        End Set
    End Property
    ' Runpoint is used for the matching networks strikepoint delta.
    Public Property Runpoint() As Integer
        Get
            Return _runpoint
        End Get
        Set(value As Integer)
            _runpoint = value
        End Set
    End Property

    Public Property CurrentPosition() As Integer
        Get
            Return _current_position
        End Get
        Set(value As Integer)
            _current_position = value
        End Set
    End Property

End Structure
