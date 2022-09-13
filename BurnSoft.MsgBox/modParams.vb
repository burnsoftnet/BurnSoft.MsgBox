''' <summary>
''' Message Box Style for the bottom buttons
''' </summary>
Public Enum MgboxStyle
    Ok = 0
    YesNo = 1
    Retry = 2
    OkCancel = 3
    RetryCancel = 4
    YesNoCancel = 5
    PassFailed = 6
End Enum
''' <summary>
''' Enum AutoCloseTimer Message box after x many seconds 0 - 40 seconds
''' </summary>
Public Enum AutoCloseTimer
    ac_0Sec = 0
    ac_10Secs = 1
    ac_20Secs = 2
    ac_30Secs = 3
    ac_40Secs = 4
End Enum
''' <summary>
''' Enum Style of bot, information, warning, error etc
''' </summary>
Public Enum MgBtnStyle
    Information = 0
    Critical = 1
    Exclamantion = 2
    Question = 3
End Enum
''' <summary>
''' Class modParams for event log writing.
''' </summary>
Module ModParams
    ''' <summary>
    ''' The message tag
    ''' </summary>
    Public MsgTag As Long
    ''' <summary>
    ''' Writes the event log.
    ''' </summary>
    ''' <param name="eSource">The e source.</param>
    ''' <param name="eDescription">The e description.</param>
    ''' <param name="eLogType">Type of the e log.</param>
    Public Sub WriteEventLog(ByVal eSource As String, ByVal eDescription As String, ByVal eLogType As EventLogEntryType)
        EventLog.WriteEntry(eSource, eDescription, eLogType)
    End Sub
End Module
