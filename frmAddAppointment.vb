Public Class frmAddAppointment

    Dim appointment As New Appointment
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim msgReply = MessageBox.Show("Clear All Fields?", "CLEAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Dim intControls() As Control = {txtAppointmentPatientId, txtAppointmentCase, dtpAppointmentDate, dtpAppointmentTime, txtAppointmentLocation, txtAppointmentDoctor}
        If msgReply = Windows.Forms.DialogResult.Yes Then
            For Each ctrl As Control In intControls
                ctrl.Text = ""
            Next

        End If
    End Sub

    Private Sub dtpAppointmentTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpAppointmentTime.ValueChanged

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            appointment.AddNew(txtAppointmentPatientId.Text, txtAppointmentCase.Text, dtpAppointmentDate.Text, dtpAppointmentTime.Text, txtAppointmentLocation.Text, txtAppointmentDoctor.Text)
        Catch ex As Exception
            MessageBox.Show("Add New", ex.Message)
        End Try
        appointment.ViewRecord(frmHome.dgvAppointmentList)
        Close()
    End Sub
End Class