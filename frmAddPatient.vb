Public Class frmAddPatient
    Dim patient As New Patient
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            patient.AddNew(txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, comboxMaritalStatus.Text, comboxSex.Text, txtWeight.Text, txtHeight.Text, dateTimePickerBirthdate.Text, txtEmailAddress.Text, txtContactNumber.Text, txtHomeAddress.Text, txtCountry.Text, txtCity.Text, txtStateProvince.Text, txtPostalCode.Text, comboxMedAllergies.Text, comboxTobacco.Text, comboxDrugs.Text, txtEmergencyContactName.Text, txtEmergencyRelationship.Text, txtEmergencyContactNumber.Text)
        Catch ex As Exception
            MessageBox.Show("Add New", ex.Message)
        End Try
        patient.ViewRecord(frmHome.dgvPatientList)
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim msgReply = MessageBox.Show("Clear All Fields?", "CLEAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Dim intControls() As Control = {txtFirstName, txtMiddleName, txtLastName, comboxMaritalStatus, comboxSex, txtWeight, txtHeight, dateTimePickerBirthdate, txtEmailAddress, txtHomeAddress, txtContactNumber, txtCountry, txtCity, txtStateProvince, txtPostalCode, comboxMedAllergies, comboxTobacco, comboxDrugs, txtEmergencyContactName, txtEmergencyRelationship, txtEmergencyContactNumber}
        If msgReply = Windows.Forms.DialogResult.Yes Then
            For Each ctrl As Control In intControls
                ctrl.Text = ""
            Next

        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub frmAddPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class