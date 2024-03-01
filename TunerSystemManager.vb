Public Structure TunerSystemManager
    Private _strikepoint As Double
    Private _strikepointChanged As Boolean
    Private _runpoint As Double
    Private _runpointChanged As Boolean
    Private _current_position As Double

    ' Strikepoint is used for the matching networks strikepoint delta.
    Public Property Strikepoint() As Double
        Get
            Return _strikepoint
        End Get
        Set(value As Double)
            ' Check if the value is different from the current one
            If value <> _strikepoint Then
                _strikepointChanged = True
            End If

            ' Update the strikepoint
            _strikepoint = value
        End Set
    End Property

    ' Property to check if the strikepoint has changed
    Public ReadOnly Property StrikepointChanged() As Boolean
        Get
            Return _strikepointChanged
        End Get
    End Property

    ' Method to reset the strikepoint changed flag
    Public Sub ResetStrikepointChanged()
        _strikepointChanged = False
    End Sub
    ' Runpoint is used for the matching networks strikepoint delta.
    Public Property Runpoint() As Double
        Get
            Return _runpoint
        End Get
        Set(value As Double)
            ' Check if the value is different from the current one
            If value <> _runpoint Then
                _runpointChanged = True
            End If

            ' Update the runpoint
            _runpoint = value
        End Set
    End Property

    ' Property to check if the runpoint has changed
    Public ReadOnly Property RunpointChanged() As Boolean
        Get
            Return _runpointChanged
        End Get
    End Property

    ' Method to reset the runpoint changed flag
    Public Sub ResetRunpointChanged()
        _runpointChanged = False
    End Sub
    Public Property CurrentPosition() As Double
        Get
            Return _current_position
        End Get
        Set(value As Double)
            _current_position = value
        End Set
    End Property

End Structure
