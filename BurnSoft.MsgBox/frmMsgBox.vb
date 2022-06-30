''' <summary>
''' Main Display Box
''' </summary>
Public Class frmMsgBox
    ''' <summary>
    ''' The automatic close delay
    ''' </summary>
    Dim _autoCloseDelay As Long
    ''' <summary>
    ''' The MSG style
    ''' </summary>
    Dim _msgStyle As Long
    ''' <summary>
    ''' The MSG MSG
    ''' </summary>
    Public MsgMsg As String
    ''' <summary>
    ''' Handles the FormClosing event of the frmMsgBox control. Check to see if this should be logged
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.Windows.Forms.FormClosingEventArgs"/> instance containing the event data.</param>
    Private Sub frmMsgBox_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If chkReport.Checked = True Then
            Select Case _msgStyle
                Case 1 ' Critical
                    WriteEventLog(Me.Text, txtMessage.Text, EventLogEntryType.Error)
                Case 2 ' Exlamation
                    WriteEventLog(Me.Text, txtMessage.Text, EventLogEntryType.Warning)
                Case 3 'Information
                    WriteEventLog(Me.Text, txtMessage.Text, EventLogEntryType.Information)
                Case 4
                    WriteEventLog(Me.Text, txtMessage.Text, EventLogEntryType.Information)
            End Select
        End If
    End Sub
    ''' <summary>
    ''' Set the Buttons on the From
    ''' Add a Tag number to each type of button so that it can reconised
    ''' </summary>
    ''' <param name="MsgStyle">The MSG style.</param>
    Public Sub LoadMsgStyle(Optional ByVal MsgStyle As MgboxStyle = MgboxStyle.Inf_OK)
        Select Case MsgStyle
            Case MgboxStyle.Inf_OK
                btnMess_1.Text = "&OK"
                Me.AcceptButton = btnMess_1
                Me.CancelButton = btnMess_1
                btnMess_1.Tag = "10001"
                btnMess_2.Visible = False
                btnMess_3.Visible = False
                btnMess_1.Focus()
            Case MgboxStyle.Inf_Retry
                btnMess_1.Text = "&Ignore"
                btnMess_1.Tag = "10010"
                btnMess_2.Text = "&Retry"
                btnMess_2.Tag = "10011"
                btnMess_3.Text = "&Abort"
                btnMess_3.Tag = "10012"
                Me.AcceptButton = btnMess_2
                Me.CancelButton = btnMess_1
            Case MgboxStyle.Inf_YesNo
                btnMess_1.Text = "&No"
                btnMess_1.Tag = "10002"
                btnMess_2.Text = "&Yes"
                btnMess_2.Tag = "10003"
                btnMess_3.Visible = False
                Me.AcceptButton = btnMess_2
                Me.CancelButton = btnMess_1
            Case MgboxStyle.Inf_OKCancel
                btnMess_1.Text = "&Cancel"
                btnMess_1.Tag = "10004"
                btnMess_2.Text = "&OK"
                btnMess_2.Tag = "10001"
                btnMess_3.Visible = False
                Me.AcceptButton = btnMess_2
                Me.CancelButton = btnMess_1
                btnMess_1.Focus()
            Case MgboxStyle.Inf_RetryCancel
                btnMess_1.Text = "&Cancel"
                btnMess_1.Tag = "10004"
                btnMess_2.Text = "&Retry"
                btnMess_2.Tag = "10011"
                Me.AcceptButton = btnMess_2
                Me.CancelButton = btnMess_1
                btnMess_3.Visible = False
            Case MgboxStyle.Inf_YesNoCancel
                btnMess_1.Text = "&Cancel"
                btnMess_1.Tag = "10004"
                btnMess_2.Text = "&No"
                btnMess_2.Tag = "10002"
                btnMess_3.Text = "&Yes"
                btnMess_3.Tag = "10003"
                Me.AcceptButton = btnMess_3
                Me.CancelButton = btnMess_1
        End Select
    End Sub
    ''' <summary>
    ''' Set the type of image to be displayed
    ''' </summary>
    ''' <param name="mbStyle">The mb style.</param>
    Public Sub LoadmbStyle(ByVal mbStyle As MgBtnStyle)
        Select Case mbStyle
            Case MgBtnStyle.mb_Critical
                picInfomation.Image = My.Resources.critical
                If Len(MsgMsg) = 0 Then MsgMsg = "Error Found"
                lblMessageTitle.Text = MsgMsg
                _msgStyle = 1
            Case MgBtnStyle.mb_Exclamantion
                picInfomation.Image = My.Resources.Exclamation_ico
                If Len(MsgMsg) = 0 Then MsgMsg = ""
                lblMessageTitle.Text = MsgMsg
                _msgStyle = 2
            Case MgBtnStyle.mb_Information
                picInfomation.Image = My.Resources.info
                If Len(MsgMsg) = 0 Then MsgMsg = "Information"
                lblMessageTitle.Text = MsgMsg
                _msgStyle = 3
            Case MgBtnStyle.mb_Question
                picInfomation.Image = My.Resources.Question
                If Len(MsgMsg) = 0 Then MsgMsg = "?"
                lblMessageTitle.Text = MsgMsg
                _msgStyle = 4
        End Select
    End Sub
    ''' <summary>
    ''' et the Auto Timer delay
    ''' </summary>
    ''' <param name="AutoClse">The automatic clse.</param>
    Public Sub AutoCloseMe(ByVal AutoClse As AutoCloseTimer)
        Select Case AutoClse
            Case AutoCloseTimer.ac_10Secs
                _autoCloseDelay = 10
            Case AutoCloseTimer.ac_20Secs
                _autoCloseDelay = 20
            Case AutoCloseTimer.ac_30Secs
                _autoCloseDelay = 30
            Case AutoCloseTimer.ac_40Secs
                _autoCloseDelay = 40
        End Select

        ' Enable the Timer
        If _autoCloseDelay <> 0 Then
            tmrAutoClose.Enabled = True
            lblAutoClose.Text = "Auto Close in " & _autoCloseDelay
            lblAutoClose.Visible = True
        End If
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnMess_3 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnMess_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMess_3.Click
        MsgTag = btnMess_3.Tag
        Me.Close()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnMess_2 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnMess_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMess_2.Click
        MsgTag = btnMess_2.Tag
        Me.Close()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnMess_1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnMess_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMess_1.Click
        MsgTag = btnMess_1.Tag
        Me.Close()
    End Sub
    ''' <summary>
    ''' Handles the Tick event of the tmrAutoClose control. Auto Close Form if enabled
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub tmrAutoClose_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAutoClose.Tick
        If _autoCloseDelay > 0 Then
            _autoCloseDelay = _autoCloseDelay - 1
            lblAutoClose.Text = "Auto Close in " & _autoCloseDelay
            lblAutoClose.Refresh()
        End If

        If _autoCloseDelay = 0 Then
            Me.Close()
        End If
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmMsgBox control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmMsgBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class