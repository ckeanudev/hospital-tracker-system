Public Class frmUpdateDelete
    Dim patient As New Patient
    Private Sub frmUpdateDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
            GroupBox4.Enabled = False
            btnSave.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            GroupBox4.Enabled = True
            btnSave.Enabled = True
            btnUpdate.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim i = txtPatientId.Text
            patient.PatientId = i
            patient.UpdateRecord(txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, comboxMaritalStatus.SelectedItem, comboxSex.SelectedItem, txtWeight.Text, txtHeight.Text, dateTimePickerBirthdate.Value, txtEmailAddress.Text, txtContactNumber.Text, txtHomeAddress.Text, txtCountry.Text, txtCity.Text, txtStateProvince.Text, txtPostalCode.Text, comboxMedAllergies.SelectedItem, comboxTobacco.SelectedItem, comboxDrugs.SelectedItem, txtEmergencyContactName.Text, txtEmergencyRelationship.Text, txtEmergencyContactNumber.Text)
        Catch ex As Exception
            MessageBox.Show("Update", ex.Message)
        End Try
        patient.ViewRecord(frmHome.dgvPatientList)
        Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            patient.DeleteRecord(txtPatientId.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        patient.ViewRecord(frmHome.dgvPatientList)
        Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub txtPatientId_TextChanged(sender As Object, e As EventArgs) Handles txtPatientId.TextChanged

    End Sub
End Class