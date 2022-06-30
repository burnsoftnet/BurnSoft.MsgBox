<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsgBox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsgBox))
        Me.chkReport = New System.Windows.Forms.CheckBox
        Me.lblAutoClose = New System.Windows.Forms.Label
        Me.picInfomation = New System.Windows.Forms.PictureBox
        Me.lblMessageTitle = New System.Windows.Forms.Label
        Me.btnMess_3 = New System.Windows.Forms.Button
        Me.btnMess_2 = New System.Windows.Forms.Button
        Me.btnMess_1 = New System.Windows.Forms.Button
        Me.txtMessage = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.tmrAutoClose = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picInfomation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkReport
        '
        Me.chkReport.AutoSize = True
        Me.chkReport.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkReport.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkReport.Location = New System.Drawing.Point(270, 43)
        Me.chkReport.Name = "chkReport"
        Me.chkReport.Size = New System.Drawing.Size(115, 17)
        Me.chkReport.TabIndex = 29
        Me.chkReport.Text = "Save to Event Log"
        Me.chkReport.UseVisualStyleBackColor = False
        '
        'lblAutoClose
        '
        Me.lblAutoClose.AutoSize = True
        Me.lblAutoClose.Location = New System.Drawing.Point(13, 244)
        Me.lblAutoClose.Name = "lblAutoClose"
        Me.lblAutoClose.Size = New System.Drawing.Size(54, 13)
        Me.lblAutoClose.TabIndex = 28
        Me.lblAutoClose.Text = "Autoclose"
        Me.lblAutoClose.Visible = False
        '
        'picInfomation
        '
        Me.picInfomation.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.picInfomation.Image = CType(resources.GetObject("picInfomation.Image"), System.Drawing.Image)
        Me.picInfomation.Location = New System.Drawing.Point(12, 12)
        Me.picInfomation.Name = "picInfomation"
        Me.picInfomation.Size = New System.Drawing.Size(48, 48)
        Me.picInfomation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picInfomation.TabIndex = 27
        Me.picInfomation.TabStop = False
        '
        'lblMessageTitle
        '
        Me.lblMessageTitle.AutoSize = True
        Me.lblMessageTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMessageTitle.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessageTitle.Location = New System.Drawing.Point(90, 25)
        Me.lblMessageTitle.Name = "lblMessageTitle"
        Me.lblMessageTitle.Size = New System.Drawing.Size(57, 14)
        Me.lblMessageTitle.TabIndex = 26
        Me.lblMessageTitle.Text = "#####"
        '
        'btnMess_3
        '
        Me.btnMess_3.Location = New System.Drawing.Point(170, 239)
        Me.btnMess_3.Name = "btnMess_3"
        Me.btnMess_3.Size = New System.Drawing.Size(78, 22)
        Me.btnMess_3.TabIndex = 25
        Me.btnMess_3.Text = "###"
        Me.btnMess_3.UseVisualStyleBackColor = True
        '
        'btnMess_2
        '
        Me.btnMess_2.Location = New System.Drawing.Point(254, 239)
        Me.btnMess_2.Name = "btnMess_2"
        Me.btnMess_2.Size = New System.Drawing.Size(78, 22)
        Me.btnMess_2.TabIndex = 24
        Me.btnMess_2.Text = "###"
        Me.btnMess_2.UseVisualStyleBackColor = True
        '
        'btnMess_1
        '
        Me.btnMess_1.Location = New System.Drawing.Point(338, 239)
        Me.btnMess_1.Name = "btnMess_1"
        Me.btnMess_1.Size = New System.Drawing.Size(78, 22)
        Me.btnMess_1.TabIndex = 23
        Me.btnMess_1.Text = "###"
        Me.btnMess_1.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtMessage.Location = New System.Drawing.Point(12, 79)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ReadOnly = True
        Me.txtMessage.Size = New System.Drawing.Size(404, 150)
        Me.txtMessage.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(433, 73)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'tmrAutoClose
        '
        Me.tmrAutoClose.Interval = 1000
        '
        'frmMsgBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 266)
        Me.Controls.Add(Me.chkReport)
        Me.Controls.Add(Me.lblAutoClose)
        Me.Controls.Add(Me.picInfomation)
        Me.Controls.Add(Me.lblMessageTitle)
        Me.Controls.Add(Me.btnMess_3)
        Me.Controls.Add(Me.btnMess_2)
        Me.Controls.Add(Me.btnMess_1)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsgBox"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmMsgBox"
        CType(Me.picInfomation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkReport As System.Windows.Forms.CheckBox
    Friend WithEvents lblAutoClose As System.Windows.Forms.Label
    Friend WithEvents picInfomation As System.Windows.Forms.PictureBox
    Friend WithEvents lblMessageTitle As System.Windows.Forms.Label
    Friend WithEvents btnMess_3 As System.Windows.Forms.Button
    Friend WithEvents btnMess_2 As System.Windows.Forms.Button
    Friend WithEvents btnMess_1 As System.Windows.Forms.Button
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrAutoClose As System.Windows.Forms.Timer
End Class
