''' <summary>
'''  Main Message Class
''' </summary>
Public Class MsgClass
    ''' <summary>
    ''' Does the message.
    ''' </summary>
    ''' <param name="mPrompt">The m prompt.</param>
    ''' <param name="mButtons">The m buttons.</param>
    ''' <param name="mStyle">The m style.</param>
    ''' <param name="mTitle">The m title.</param>
    ''' <param name="autoClose">The automatic close.</param>
    ''' <param name="alwaysOnTop">if set to <c>true</c> [always on top].</param>
    ''' <param name="msgText">The MSG text.</param>
    ''' <param name="showOptWrEvtLog">if set to <c>true</c> [show opt wr evt log].</param>
    ''' <returns>System.Object.</returns>
    Public Function DoMessage(ByVal mPrompt As String, Optional ByVal mButtons As MgboxStyle = MgboxStyle.Ok, _
                              Optional ByVal mStyle As MgBtnStyle = MgBtnStyle.Information, _
                              Optional ByVal mTitle As String = "My Application", _
                              Optional ByVal autoClose As AutoCloseTimer = AutoCloseTimer.ac_0Sec, _
                              Optional ByVal alwaysOnTop As Boolean = False, _
                              Optional ByVal msgText As String = "", _
                              Optional ByVal showOptWrEvtLog As Boolean = False) As Long
        Dim lForm As New frmMsgBox

        With lForm
            .MsgMsg = msgText
            .lblMessageTitle.Text = msgText
            .txtMessage.Text = mPrompt
            .LoadMsgStyle(mButtons)
            .LoadmbStyle(mStyle)
            .AutoCloseMe(autoClose)
            .Text = mTitle
            .TopMost = alwaysOnTop
            .chkReport.Visible = showOptWrEvtLog
            .txtMessage.SelectionLength = 0
            .ShowDialog()
        End With
        Return MsgTag
    End Function
End Class
