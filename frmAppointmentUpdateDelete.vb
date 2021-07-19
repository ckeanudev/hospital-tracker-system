Public Class frmAppointmentUpdateDelete
    Dim appointment As New Appointment
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub frmAppointmentUpdateDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            GroupBox1.Enabled = False
            btnSave.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            appointment.DeleteRecord(txtAppointmentId.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        appointment.ViewRecord(frmHome.dgvAppointmentList)
        Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            GroupBox1.Enabled = True
            btnSave.Enabled = True
            btnUpdate.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim i = txtAppointmentId.Text
            appointment.AppointmentId = i
            appointment.UpdateRecord(txtAppointmentPatientId.Text, txtAppointmentCase.Text, dtpAppointmentDate.Text, dtpAppointmentTime.Text, txtAppointmentLocation.Text, txtAppointmentDoctor.Text)
        Catch ex As Exception
            MessageBox.Show("Update", ex.Message)
        End Try
        appointment.ViewRecord(frmHome.dgvAppointmentList)
        Close()
    End Sub
End Class