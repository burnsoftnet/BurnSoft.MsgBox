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
    ''' <param name="AutoClose">The automatic close.</param>
    ''' <param name="AlwaysOnTop">if set to <c>true</c> [always on top].</param>
    ''' <param name="MsgText">The MSG text.</param>
    ''' <param name="ShowOptWrEvtLog">if set to <c>true</c> [show opt wr evt log].</param>
    ''' <returns>System.Object.</returns>
    Public Function DoMessage(ByVal mPrompt As String, Optional ByVal mButtons As MgboxStyle = MgboxStyle.Inf_OK, _
                              Optional ByVal mStyle As MgBtnStyle = MgBtnStyle.mb_Information, _
                              Optional ByVal mTitle As String = "My Application", _
                              Optional ByVal AutoClose As AutoCloseTimer = AutoCloseTimer.ac_0Sec, _
                              Optional ByVal AlwaysOnTop As Boolean = False, _
                              Optional ByVal MsgText As String = "", _
                              Optional ByVal ShowOptWrEvtLog As Boolean = False)
        Dim lForm As New frmMsgBox

        With lForm
            .MsgMsg = MsgText
            .lblMessageTitle.Text = MsgText
            .txtMessage.Text = mPrompt
            .LoadMsgStyle(mButtons)
            .LoadmbStyle(mStyle)
            .AutoCloseMe(AutoClose)
            .Text = mTitle
            .TopMost = AlwaysOnTop
            .chkReport.Visible = ShowOptWrEvtLog
            .txtMessage.SelectionLength = 0
            .ShowDialog()
        End With
        Return MsgTag
    End Function
End Class
