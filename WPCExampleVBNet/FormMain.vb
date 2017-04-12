
Public Class FormMain

    Private WinPowerControl As New WPC.WindowsPowerControl
    Private ReturnedResult As Boolean

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxForceOption.SelectedIndex = 0
    End Sub

#Region "Shutdown Functions"
    Private Sub ButtonShutdown_Click(sender As Object, e As EventArgs) Handles ButtonShutdown.Click
        'WinPowerControl.Shutdown() 'Parameterless call
        ReturnedResult = WinPowerControl.Shutdown(GetSelectedForceType())
        WriteReturnedResult()
    End Sub

    Private Sub ButtonPowerOff_Click(sender As Object, e As EventArgs) Handles ButtonPowerOff.Click
        'WinPowerControl.PowerOff() 'Parameterless call
        ReturnedResult = WinPowerControl.PowerOff(GetSelectedForceType())
        WriteReturnedResult()
    End Sub

    Private Sub ButtonRestart_Click(sender As Object, e As EventArgs) Handles ButtonRestart.Click
        'WinPowerControl.Restart() 'Parameterless call
        ReturnedResult = WinPowerControl.Restart(GetSelectedForceType())
        WriteReturnedResult()
    End Sub

    Private Sub ButtonLogOff_Click(sender As Object, e As EventArgs) Handles ButtonLogOff.Click
        'WinPowerControl.LogOff() 'Parameterless call
        ReturnedResult = WinPowerControl.LogOff(GetSelectedForceType())
        WriteReturnedResult()
    End Sub
#End Region

#Region "Suspend Functions"

    Private Sub ButtonCheckSupport_Click(sender As Object, e As EventArgs) Handles ButtonCheckSupport.Click
        Dim SleepSupported As Boolean
        Dim HibernateSupported As Boolean

        SleepSupported = WinPowerControl.SleepSupported
        HibernateSupported = WinPowerControl.HibernateSupported

        ButtonSleep.Enabled = SleepSupported
        ButtonHibernate.Enabled = HibernateSupported

        If SleepSupported Then
            LabelSleepInfo.Text = "Sleep is supported by this system"
        Else
            LabelSleepInfo.Text = "Sleep is not supported by this system"
        End If

        If HibernateSupported Then
            LabelHibernateInfo.Text = "Hibernate is supported by this system"
        Else
            LabelHibernateInfo.Text = "Hibernate is not supported by this system"
        End If

        MessageBox.Show("Sleep Status: " + LabelSleepInfo.Text + Environment.NewLine + "Hibernate Status: " + LabelHibernateInfo.Text, "Suspend Status", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub ButtonSleep_Click(sender As Object, e As EventArgs) Handles ButtonSleep.Click

        If WinPowerControl.SleepSupported Then
            'WinPowerControl.Sleep() 'Parameterless call
            ReturnedResult = WinPowerControl.Sleep(CheckBoxForceSuspend.Checked)
        Else
            ReturnedResult = False
            MessageBox.Show("Sleep is not supported by this system", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        WriteReturnedResult()
    End Sub

    Private Sub ButtonHibernate_Click(sender As Object, e As EventArgs) Handles ButtonHibernate.Click

        If WinPowerControl.HibernateSupported Then
            'WinPowerControl.Hibernate() 'Parameterless call
            ReturnedResult = WinPowerControl.Hibernate(CheckBoxForceSuspend.Checked)
        Else
            ReturnedResult = False
            MessageBox.Show("Hibernate is not supported by this system", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        WriteReturnedResult()
    End Sub

#End Region

#Region "Lock Function"
    Private Sub ButtonLock_Click(sender As Object, e As EventArgs) Handles ButtonLock.Click
        ReturnedResult = WinPowerControl.Lock()
        WriteReturnedResult()
    End Sub
#End Region

    Private Function GetSelectedForceType() As WPC.Core.ShutdownCore.ForceType
        Dim ForceType As WPC.Core.ShutdownCore.ForceType
        ForceType = CType(ComboBoxForceOption.SelectedIndex, WPC.Core.ShutdownCore.ForceType)
        Return ForceType
    End Function

    Private Sub WriteReturnedResult()
        TextBoxResult.Text = ReturnedResult.ToString()
    End Sub

End Class
