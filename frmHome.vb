Public Class frmHome

    Dim patient As New Patient
    Dim appointment As New Appointment
    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Patient DataGridView
            patient.ViewRecord(dgvPatientList)
            dgvPatientList.Columns("id").HeaderText = "ID"
            dgvPatientList.Columns("firstname").HeaderText = "First Name"
            dgvPatientList.Columns("middlename").HeaderText = "Middle Name"
            dgvPatientList.Columns("lastname").HeaderText = "Last Name"
            dgvPatientList.Columns("marital_status").HeaderText = "Marital Status"
            dgvPatientList.Columns("sex").HeaderText = "Sex"
            dgvPatientList.Columns("weight_lbs").HeaderText = "Weight(lbs)"
            dgvPatientList.Columns("height_inch").HeaderText = "Height(inch)"
            dgvPatientList.Columns("birthdate").HeaderText = "Birthdate"
            dgvPatientList.Columns("email_address").HeaderText = "Email Address"
            dgvPatientList.Columns("contact_number").HeaderText = "Contact Number"
            dgvPatientList.Columns("house_street_road").HeaderText = "House/Street/Road"
            dgvPatientList.Columns("country").HeaderText = "Country"
            dgvPatientList.Columns("city").HeaderText = "City"
            dgvPatientList.Columns("state_province").HeaderText = "State/Province"
            dgvPatientList.Columns("postal_code").HeaderText = "Postal Code"
            dgvPatientList.Columns("med_allergies").HeaderText = "Medical Allergies"
            dgvPatientList.Columns("med_using_tobacco").HeaderText = "Using/Used Tobacco"
            dgvPatientList.Columns("med_using_illegal_drugs").HeaderText = "Using/Used Illegal Drugs"
            dgvPatientList.Columns("emergency_contact_name").HeaderText = "Emergency Contact Name"
            dgvPatientList.Columns("emergency_relationship").HeaderText = "Emergency Relationship"
            dgvPatientList.Columns("emergency_contact_number").HeaderText = "Emergency ContactNumber"

            dgvPatientList.Columns("id").Width = 50
            dgvPatientList.Columns("firstname").Width = 150
            dgvPatientList.Columns("middlename").Width = 150
            dgvPatientList.Columns("lastname").Width = 150
            dgvPatientList.Columns("marital_status").Width = 150
            dgvPatientList.Columns("sex").Width = 70
            dgvPatientList.Columns("weight_lbs").Width = 100
            dgvPatientList.Columns("height_inch").Width = 100
            dgvPatientList.Columns("birthdate").Width = 150
            dgvPatientList.Columns("email_address").Width = 150
            dgvPatientList.Columns("contact_number").Width = 150
            dgvPatientList.Columns("house_street_road").Width = 150
            dgvPatientList.Columns("country").Width = 150
            dgvPatientList.Columns("city").Width = 150
            dgvPatientList.Columns("state_province").Width = 150
            dgvPatientList.Columns("postal_code").Width = 150
            dgvPatientList.Columns("med_allergies").Width = 150
            dgvPatientList.Columns("med_using_tobacco").Width = 150
            dgvPatientList.Columns("med_using_illegal_drugs").Width = 150
            dgvPatientList.Columns("emergency_contact_name").Width = 150
            dgvPatientList.Columns("emergency_relationship").Width = 150
            dgvPatientList.Columns("emergency_contact_number").Width = 150

            'Appointment DataGridView
            appointment.ViewRecord(dgvAppointmentList)
            dgvAppointmentList.Columns("id").HeaderText = "ID"
            dgvAppointmentList.Columns("patient_id").HeaderText = "Patient ID"
            dgvAppointmentList.Columns("case_type").HeaderText = "Case Type"
            dgvAppointmentList.Columns("appointment_date").HeaderText = "Date"
            dgvAppointmentList.Columns("appointment_time").HeaderText = "Time"
            dgvAppointmentList.Columns("location").HeaderText = "Location"
            dgvAppointmentList.Columns("doctor").HeaderText = "Doctor"

            dgvAppointmentList.Columns("id").Width = 50
            dgvAppointmentList.Columns("patient_id").Width = 50
            dgvAppointmentList.Columns("case_type").Width = 200
            dgvAppointmentList.Columns("appointment_date").Width = 150
            dgvAppointmentList.Columns("appointment_time").Width = 150
            dgvAppointmentList.Columns("location").Width = 150
            dgvAppointmentList.Columns("doctor").Width = 200

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        MessageBox.Show("Name of the Database System: Hospital Document Tracker System" & vbNewLine & vbNewLine & "Developers: Raven Andan, Ckeanu Richer Locson, Franz Nuluddin, Morfydd Alar, Mark Ronnie Emata, Dannadane Cruz, Brennan Espinosa and Jameson Faustino of BSCS-2B of Western Mindanao State University" & vbNewLine & vbNewLine & "Description: Hospital Document Tracker System is a database system that is capable of tracking a hospital's patients documents. The user interface is simple and clean in order to achieve maximum efficiency.", "Hospital Document Tracker System")
    End Sub

    Private Sub btnAddPatient_Click(sender As Object, e As EventArgs) Handles btnAddPatient.Click
        Dim A = New frmAddPatient()
        Try
            A.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvPatientList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPatientList.CellContentClick
        Dim form As New frmUpdateDelete
        Try
            form.txtPatientId.Text = dgvPatientList.CurrentRow.Cells(0).Value.ToString()
            form.txtFirstName.Text = dgvPatientList.CurrentRow.Cells(1).Value.ToString()
            form.txtMiddleName.Text = dgvPatientList.CurrentRow.Cells(2).Value.ToString()
            form.txtLastName.Text = dgvPatientList.CurrentRow.Cells(3).Value.ToString()
            form.comboxMaritalStatus.Text = dgvPatientList.CurrentRow.Cells(4).Value.ToString()
            form.comboxSex.Text = dgvPatientList.CurrentRow.Cells(5).Value.ToString()
            form.txtWeight.Text = dgvPatientList.CurrentRow.Cells(6).Value.ToString()
            form.txtHeight.Text = dgvPatientList.CurrentRow.Cells(7).Value.ToString()
            form.dateTimePickerBirthdate.Text = dgvPatientList.CurrentRow.Cells(8).Value.ToString()
            form.txtEmailAddress.Text = dgvPatientList.CurrentRow.Cells(9).Value.ToString()
            form.txtContactNumber.Text = dgvPatientList.CurrentRow.Cells(10).Value.ToString()
            form.txtHomeAddress.Text = dgvPatientList.CurrentRow.Cells(11).Value.ToString()
            form.txtCountry.Text = dgvPatientList.CurrentRow.Cells(12).Value.ToString()
            form.txtCity.Text = dgvPatientList.CurrentRow.Cells(13).Value.ToString()
            form.txtStateProvince.Text = dgvPatientList.CurrentRow.Cells(14).Value.ToString()
            form.txtPostalCode.Text = dgvPatientList.CurrentRow.Cells(15).Value.ToString()
            form.comboxMedAllergies.Text = dgvPatientList.CurrentRow.Cells(16).Value.ToString()
            form.comboxTobacco.Text = dgvPatientList.CurrentRow.Cells(17).Value.ToString()
            form.comboxDrugs.Text = dgvPatientList.CurrentRow.Cells(18).Value.ToString()
            form.txtEmergencyContactName.Text = dgvPatientList.CurrentRow.Cells(19).Value.ToString()
            form.txtEmergencyRelationship.Text = dgvPatientList.CurrentRow.Cells(20).Value.ToString()
            form.txtEmergencyContactNumber.Text = dgvPatientList.CurrentRow.Cells(21).Value.ToString()

            form.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A = New frmAddAppointment()
        Try
            A.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvAppointmentList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAppointmentList.CellContentClick
        Dim form As New frmAppointmentUpdateDelete
        Try
            form.txtAppointmentId.Text = dgvAppointmentList.CurrentRow.Cells(0).Value.ToString()
            form.txtAppointmentPatientId.Text = dgvAppointmentList.CurrentRow.Cells(1).Value.ToString()
            form.txtAppointmentCase.Text = dgvAppointmentList.CurrentRow.Cells(2).Value.ToString()
            form.dtpAppointmentDate.Text = dgvAppointmentList.CurrentRow.Cells(3).Value.ToString()
            form.dtpAppointmentTime.Text = dgvAppointmentList.CurrentRow.Cells(4).Value.ToString()
            form.txtAppointmentLocation.Text = dgvAppointmentList.CurrentRow.Cells(5).Value.ToString()
            form.txtAppointmentDoctor.Text = dgvAppointmentList.CurrentRow.Cells(6).Value.ToString()

            form.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
