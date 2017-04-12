<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.ButtonHibernate = New System.Windows.Forms.Button()
        Me.ButtonSleep = New System.Windows.Forms.Button()
        Me.ButtonLock = New System.Windows.Forms.Button()
        Me.ButtonLogOff = New System.Windows.Forms.Button()
        Me.ButtonRestart = New System.Windows.Forms.Button()
        Me.ButtonPowerOff = New System.Windows.Forms.Button()
        Me.ButtonShutdown = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxForceOption = New System.Windows.Forms.ComboBox()
        Me.LabelForceOption = New System.Windows.Forms.Label()
        Me.GroupBoxSuspend = New System.Windows.Forms.GroupBox()
        Me.LabelHibernateInfo = New System.Windows.Forms.Label()
        Me.LabelSleepInfo = New System.Windows.Forms.Label()
        Me.ButtonCheckSupport = New System.Windows.Forms.Button()
        Me.CheckBoxForceSuspend = New System.Windows.Forms.CheckBox()
        Me.GroupBoxLock = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelResultNote = New System.Windows.Forms.Label()
        Me.TextBoxResult = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelTop = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxSuspend.SuspendLayout()
        Me.GroupBoxLock.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonHibernate
        '
        Me.ButtonHibernate.Enabled = False
        Me.ButtonHibernate.Location = New System.Drawing.Point(19, 90)
        Me.ButtonHibernate.Name = "ButtonHibernate"
        Me.ButtonHibernate.Size = New System.Drawing.Size(101, 27)
        Me.ButtonHibernate.TabIndex = 2
        Me.ButtonHibernate.Text = "Hibernate"
        Me.ButtonHibernate.UseVisualStyleBackColor = True
        '
        'ButtonSleep
        '
        Me.ButtonSleep.Enabled = False
        Me.ButtonSleep.Location = New System.Drawing.Point(19, 56)
        Me.ButtonSleep.Name = "ButtonSleep"
        Me.ButtonSleep.Size = New System.Drawing.Size(101, 27)
        Me.ButtonSleep.TabIndex = 1
        Me.ButtonSleep.Text = "Sleep"
        Me.ButtonSleep.UseVisualStyleBackColor = True
        '
        'ButtonLock
        '
        Me.ButtonLock.Location = New System.Drawing.Point(19, 21)
        Me.ButtonLock.Name = "ButtonLock"
        Me.ButtonLock.Size = New System.Drawing.Size(101, 27)
        Me.ButtonLock.TabIndex = 0
        Me.ButtonLock.Text = "Lock"
        Me.ButtonLock.UseVisualStyleBackColor = True
        '
        'ButtonLogOff
        '
        Me.ButtonLogOff.Location = New System.Drawing.Point(437, 72)
        Me.ButtonLogOff.Name = "ButtonLogOff"
        Me.ButtonLogOff.Size = New System.Drawing.Size(101, 27)
        Me.ButtonLogOff.TabIndex = 4
        Me.ButtonLogOff.Text = "Log Off"
        Me.ButtonLogOff.UseVisualStyleBackColor = True
        '
        'ButtonRestart
        '
        Me.ButtonRestart.Location = New System.Drawing.Point(298, 72)
        Me.ButtonRestart.Name = "ButtonRestart"
        Me.ButtonRestart.Size = New System.Drawing.Size(101, 27)
        Me.ButtonRestart.TabIndex = 3
        Me.ButtonRestart.Text = "Restart"
        Me.ButtonRestart.UseVisualStyleBackColor = True
        '
        'ButtonPowerOff
        '
        Me.ButtonPowerOff.Location = New System.Drawing.Point(159, 72)
        Me.ButtonPowerOff.Name = "ButtonPowerOff"
        Me.ButtonPowerOff.Size = New System.Drawing.Size(101, 27)
        Me.ButtonPowerOff.TabIndex = 2
        Me.ButtonPowerOff.Text = "Power Off"
        Me.ButtonPowerOff.UseVisualStyleBackColor = True
        '
        'ButtonShutdown
        '
        Me.ButtonShutdown.Location = New System.Drawing.Point(20, 72)
        Me.ButtonShutdown.Name = "ButtonShutdown"
        Me.ButtonShutdown.Size = New System.Drawing.Size(101, 27)
        Me.ButtonShutdown.TabIndex = 1
        Me.ButtonShutdown.Text = "Shutdown"
        Me.ButtonShutdown.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxForceOption)
        Me.GroupBox1.Controls.Add(Me.LabelForceOption)
        Me.GroupBox1.Controls.Add(Me.ButtonShutdown)
        Me.GroupBox1.Controls.Add(Me.ButtonPowerOff)
        Me.GroupBox1.Controls.Add(Me.ButtonRestart)
        Me.GroupBox1.Controls.Add(Me.ButtonLogOff)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(558, 121)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Shutdown Functions"
        '
        'ComboBoxForceOption
        '
        Me.ComboBoxForceOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxForceOption.FormattingEnabled = True
        Me.ComboBoxForceOption.Items.AddRange(New Object() {"Never", "Force If Hung", "Force All"})
        Me.ComboBoxForceOption.Location = New System.Drawing.Point(111, 31)
        Me.ComboBoxForceOption.Name = "ComboBoxForceOption"
        Me.ComboBoxForceOption.Size = New System.Drawing.Size(149, 22)
        Me.ComboBoxForceOption.TabIndex = 0
        '
        'LabelForceOption
        '
        Me.LabelForceOption.AutoSize = True
        Me.LabelForceOption.Location = New System.Drawing.Point(19, 34)
        Me.LabelForceOption.Name = "LabelForceOption"
        Me.LabelForceOption.Size = New System.Drawing.Size(86, 14)
        Me.LabelForceOption.TabIndex = 9
        Me.LabelForceOption.Text = "Force Option :"
        '
        'GroupBoxSuspend
        '
        Me.GroupBoxSuspend.Controls.Add(Me.LabelHibernateInfo)
        Me.GroupBoxSuspend.Controls.Add(Me.LabelSleepInfo)
        Me.GroupBoxSuspend.Controls.Add(Me.ButtonCheckSupport)
        Me.GroupBoxSuspend.Controls.Add(Me.CheckBoxForceSuspend)
        Me.GroupBoxSuspend.Controls.Add(Me.ButtonHibernate)
        Me.GroupBoxSuspend.Controls.Add(Me.ButtonSleep)
        Me.GroupBoxSuspend.Location = New System.Drawing.Point(20, 224)
        Me.GroupBoxSuspend.Name = "GroupBoxSuspend"
        Me.GroupBoxSuspend.Size = New System.Drawing.Size(558, 134)
        Me.GroupBoxSuspend.TabIndex = 1
        Me.GroupBoxSuspend.TabStop = False
        Me.GroupBoxSuspend.Text = "Suspend Functions"
        '
        'LabelHibernateInfo
        '
        Me.LabelHibernateInfo.AutoSize = True
        Me.LabelHibernateInfo.Location = New System.Drawing.Point(138, 96)
        Me.LabelHibernateInfo.Name = "LabelHibernateInfo"
        Me.LabelHibernateInfo.Size = New System.Drawing.Size(140, 14)
        Me.LabelHibernateInfo.TabIndex = 6
        Me.LabelHibernateInfo.Text = "Check System Support !"
        '
        'LabelSleepInfo
        '
        Me.LabelSleepInfo.AutoSize = True
        Me.LabelSleepInfo.Location = New System.Drawing.Point(138, 62)
        Me.LabelSleepInfo.Name = "LabelSleepInfo"
        Me.LabelSleepInfo.Size = New System.Drawing.Size(140, 14)
        Me.LabelSleepInfo.TabIndex = 5
        Me.LabelSleepInfo.Text = "Check System Support !"
        '
        'ButtonCheckSupport
        '
        Me.ButtonCheckSupport.Location = New System.Drawing.Point(388, 74)
        Me.ButtonCheckSupport.Name = "ButtonCheckSupport"
        Me.ButtonCheckSupport.Size = New System.Drawing.Size(152, 27)
        Me.ButtonCheckSupport.TabIndex = 3
        Me.ButtonCheckSupport.Text = "Check System Support"
        Me.ButtonCheckSupport.UseVisualStyleBackColor = True
        '
        'CheckBoxForceSuspend
        '
        Me.CheckBoxForceSuspend.AutoSize = True
        Me.CheckBoxForceSuspend.Location = New System.Drawing.Point(20, 26)
        Me.CheckBoxForceSuspend.Name = "CheckBoxForceSuspend"
        Me.CheckBoxForceSuspend.Size = New System.Drawing.Size(56, 18)
        Me.CheckBoxForceSuspend.TabIndex = 0
        Me.CheckBoxForceSuspend.Text = "Force"
        Me.CheckBoxForceSuspend.UseVisualStyleBackColor = True
        '
        'GroupBoxLock
        '
        Me.GroupBoxLock.Controls.Add(Me.ButtonLock)
        Me.GroupBoxLock.Location = New System.Drawing.Point(20, 372)
        Me.GroupBoxLock.Name = "GroupBoxLock"
        Me.GroupBoxLock.Size = New System.Drawing.Size(558, 61)
        Me.GroupBoxLock.TabIndex = 2
        Me.GroupBoxLock.TabStop = False
        Me.GroupBoxLock.Text = "Lock Function"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelResultNote)
        Me.GroupBox2.Controls.Add(Me.TextBoxResult)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 449)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(558, 90)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Result"
        '
        'LabelResultNote
        '
        Me.LabelResultNote.AutoSize = True
        Me.LabelResultNote.Location = New System.Drawing.Point(6, 67)
        Me.LabelResultNote.Name = "LabelResultNote"
        Me.LabelResultNote.Size = New System.Drawing.Size(545, 14)
        Me.LabelResultNote.TabIndex = 7
        Me.LabelResultNote.Text = "Note: You may not see return result if the system immediately enters shutdown or " &
    "suspend state"
        '
        'TextBoxResult
        '
        Me.TextBoxResult.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBoxResult.Location = New System.Drawing.Point(20, 27)
        Me.TextBoxResult.Name = "TextBoxResult"
        Me.TextBoxResult.ReadOnly = True
        Me.TextBoxResult.Size = New System.Drawing.Size(101, 27)
        Me.TextBoxResult.TabIndex = 0
        Me.TextBoxResult.TabStop = False
        Me.TextBoxResult.Text = "-"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LabelTop)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(604, 76)
        Me.Panel1.TabIndex = 13
        '
        'LabelTop
        '
        Me.LabelTop.AutoSize = True
        Me.LabelTop.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelTop.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LabelTop.Location = New System.Drawing.Point(25, 24)
        Me.LabelTop.Name = "LabelTop"
        Me.LabelTop.Size = New System.Drawing.Size(352, 25)
        Me.LabelTop.TabIndex = 0
        Me.LabelTop.Text = "WPC Example - Visual Basic.Net"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 552)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBoxLock)
        Me.Controls.Add(Me.GroupBoxSuspend)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.Text = "WPC Example - Visual Basic.Net"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxSuspend.ResumeLayout(False)
        Me.GroupBoxSuspend.PerformLayout()
        Me.GroupBoxLock.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonHibernate As Button
    Friend WithEvents ButtonSleep As Button
    Friend WithEvents ButtonLock As Button
    Friend WithEvents ButtonLogOff As Button
    Friend WithEvents ButtonRestart As Button
    Friend WithEvents ButtonPowerOff As Button
    Friend WithEvents ButtonShutdown As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBoxForceOption As ComboBox
    Friend WithEvents LabelForceOption As Label
    Friend WithEvents GroupBoxSuspend As GroupBox
    Friend WithEvents ButtonCheckSupport As Button
    Friend WithEvents CheckBoxForceSuspend As CheckBox
    Friend WithEvents LabelHibernateInfo As Label
    Friend WithEvents LabelSleepInfo As Label
    Friend WithEvents GroupBoxLock As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LabelResultNote As Label
    Friend WithEvents TextBoxResult As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelTop As Label
End Class
