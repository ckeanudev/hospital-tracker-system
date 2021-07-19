Public Class Patient

    Private txtPatientId As Integer
    Private txtFirstName As String
    Private txtMiddleName As String
    Private txtLastName As String
    Private comboxSex As String
    Private comboxMaritalStatus As String
    Private txtWeight As String
    Private txtHeight As String
    Private dateTimePickerBirthdate As String
    Private txtEmailAddress As String
    Private txtContactNumber As String
    Private txtHomeAddress As String
    Private txtCountry As String
    Private txtCity As String
    Private txtStateProvince As String
    Private txtPostalCode As String
    Private comboxMedAllergies As String
    Private comboxTobacco As String
    Private comboxDrugs As String
    Private txtEmergencyContactName As String
    Private txtEmergencyRelationship As String
    Private txtEmergencyContactNumber As String

    Dim sql As String
    Public Property PatientId() As Integer
        Get
            Return txtPatientId
        End Get
        Set(value As Integer)
            txtPatientId = value
        End Set
    End Property

    Public Property FirstName() As String
        Get
            Return txtFirstName
        End Get
        Set(ByVal value As String)
            txtFirstName = value
        End Set
    End Property

    Public Property MiddleName() As String
        Get
            Return txtMiddleName
        End Get
        Set(ByVal value As String)
            txtMiddleName = value
        End Set
    End Property

    Public Property LastName() As String
        Get
            Return txtLastName
        End Get
        Set(ByVal value As String)
            txtLastName = value
        End Set
    End Property

    Public Property Sex() As String
        Get
            Return comboxSex
        End Get
        Set(ByVal value As String)
            comboxSex = value
        End Set
    End Property

    Public Property MaritalStatus() As String
        Get
            Return comboxMaritalStatus
        End Get
        Set(ByVal value As String)
            comboxMaritalStatus = value
        End Set
    End Property

    Public Property Weight() As String
        Get
            Return txtWeight
        End Get
        Set(ByVal value As String)
            txtWeight = value
        End Set
    End Property

    Public Property Height() As String
        Get
            Return txtHeight
        End Get
        Set(ByVal value As String)
            txtHeight = value
        End Set
    End Property

    Public Property Birthdate() As String
        Get
            Return dateTimePickerBirthdate
        End Get
        Set(ByVal value As String)
            dateTimePickerBirthdate = value
        End Set
    End Property

    Public Property EmailAddress() As String
        Get
            Return txtEmailAddress
        End Get
        Set(ByVal value As String)
            txtEmailAddress = value
        End Set
    End Property

    Public Property ContactNumber() As String
        Get
            Return txtContactNumber
        End Get
        Set(ByVal value As String)
            txtContactNumber = value
        End Set
    End Property

    Public Property HomeAddress() As String
        Get
            Return txtHomeAddress
        End Get
        Set(ByVal value As String)
            txtHomeAddress = value
        End Set
    End Property

    Public Property Country() As String
        Get
            Return txtCountry
        End Get
        Set(ByVal value As String)
            txtCountry = value
        End Set
    End Property

    Public Property City() As String
        Get
            Return txtCity
        End Get
        Set(ByVal value As String)
            txtCity = value
        End Set
    End Property

    Public Property StateProvince() As String
        Get
            Return txtStateProvince
        End Get
        Set(ByVal value As String)
            txtStateProvince = value
        End Set
    End Property

    Public Property PostalCode() As String
        Get
            Return txtPostalCode
        End Get
        Set(ByVal value As String)
            txtPostalCode = value
        End Set
    End Property

    Public Property MedAllergies() As String
        Get
            Return comboxMedAllergies
        End Get
        Set(ByVal value As String)
            comboxMedAllergies = value
        End Set
    End Property

    Public Property UseTobacco() As String
        Get
            Return comboxTobacco
        End Get
        Set(ByVal value As String)
            comboxTobacco = value
        End Set
    End Property

    Public Property UseDrugs() As String
        Get
            Return comboxDrugs
        End Get
        Set(ByVal value As String)
            comboxDrugs = value
        End Set
    End Property

    Public Property EmergencyName() As String
        Get
            Return txtEmergencyContactName
        End Get
        Set(ByVal value As String)
            txtEmergencyContactName = value
        End Set
    End Property

    Public Property EmergencyRelationship() As String
        Get
            Return txtEmergencyRelationship
        End Get
        Set(ByVal value As String)
            txtEmergencyRelationship = value
        End Set
    End Property

    Public Property EmergencyContactNumber() As String
        Get
            Return txtEmergencyContactNumber
        End Get
        Set(ByVal value As String)
            txtEmergencyContactNumber = value
        End Set
    End Property

    Public Sub AddNew(txtFirstName, txtMiddleName, txtLastName, comboxMaritalStatus, comboxSex, txtWeight, txtHeight, dateTimePickerBirthdate, txtEmailAddress, txtContactNumber, txtHomeAddress, txtCountry, txtCity, txtStateProvince, txtPostalCode, comboxMedAllergies, comboxTobacco, comboxDrugs, txtEmergencyContactName, txtEmergencyRelationship, txtEmergencyContactNumber)
        Try
            sql = "INSERT INTO patient (firstname, middlename, lastname, marital_status, sex, weight_lbs, height_inch, birthdate, email_address, contact_number, house_street_road, country, city, state_province, postal_code, med_allergies, med_using_tobacco, med_using_illegal_drugs, emergency_contact_name, emergency_relationship, emergency_contact_number) VALUES ('" & txtFirstName & "', '" & txtMiddleName & "', '" & txtLastName & "', '" & comboxMaritalStatus & "', '" & comboxSex & "', '" & txtWeight & "', '" & txtHeight & "', '" & dateTimePickerBirthdate & "', '" & txtEmailAddress & "', '" & txtContactNumber & "', '" & txtHomeAddress & "', '" & txtCountry & "', '" & txtCity & "', '" & txtStateProvince & "', '" & txtPostalCode & "', '" & comboxMedAllergies & "', '" & comboxTobacco & "', '" & comboxDrugs & "', '" & txtEmergencyContactName & "', '" & txtEmergencyRelationship & "', '" & txtEmergencyContactNumber & "')"
            Dim msg As DialogResult = MessageBox.Show("Add New Patient Information?", "Add Patient", MessageBoxButtons.YesNo)
            If msg = DialogResult.Yes Then
                create(sql)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ADD NEW SUB")
        End Try
    End Sub

    Public Sub UpdateRecord(txtFirstName, txtMiddleName, txtLastName, comboxMaritalStatus, comboxSex, txtWeight, txtHeight, dateTimePickerBirthdate, txtEmailAddress, txtContactNumber, txtHomeAddress, txtCountry, txtCity, txtStateProvince, txtPostalCode, comboxMedAllergies, comboxTobacco, comboxDrugs, txtEmergencyContactName, txtEmergencyRelationship, txtEmergencyContactNumber)
        Try
            sql = "UPDATE patient SET firstname ='" & txtFirstName & "', middleName = '" & txtMiddleName & "', lastname = '" & txtLastName & "' , marital_status = '" & comboxMaritalStatus & "' , sex = '" & comboxSex & "' , weight_lbs = '" & txtWeight & "' , height_inch = '" & txtHeight & "' , birthdate = '" & dateTimePickerBirthdate & "' , email_address = '" & txtEmailAddress & "' , contact_number = '" & txtContactNumber & "' , house_street_road = '" & txtHomeAddress & "' , country = '" & txtCountry & "' , city = '" & txtCity & "' , state_province = '" & txtStateProvince & "' , postal_code = '" & txtPostalCode & "' , med_allergies = '" & comboxMedAllergies & "' , med_using_tobacco = '" & comboxTobacco & "' , med_using_illegal_drugs = '" & comboxDrugs & "' , emergency_contact_name = '" & txtEmergencyContactName & "' , emergency_relationship = '" & txtEmergencyRelationship & "' , emergency_contact_number = '" & txtEmergencyContactNumber & "' WHERE id = " & txtPatientId
            Dim msg As DialogResult = MessageBox.Show("Update Patient Information?", "Update Information", MessageBoxButtons.YesNo)
            If msg = DialogResult.Yes Then
                updates(sql)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ADD NEW SUB")
        End Try
    End Sub

    Public Sub DeleteRecord(id As Integer)
        Try
            sql = "DELETE FROM patient WHERE id=" & id
            delete(sql)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR ON DELETE RECORD")
        End Try
    End Sub

    Public Sub ViewRecord(dgv As DataGridView)
        sql = "SELECT * FROM patient"
        reload(sql, dgv)
    End Sub


End Class

