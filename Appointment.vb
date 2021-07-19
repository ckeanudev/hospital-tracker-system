Public Class Appointment

    Private txtAppointmentId As Integer
    Private txtAppointmentPatientId As Integer
    Private txtAppointmentCase As String
    Private dtpAppointmentDate As String
    Private dtpAppointmentTime As String
    Private txtAppointmentLocation As String
    Private txtAppointmentDoctor As String

    Dim sql As String

    Public Property AppointmentId() As Integer
        Get
            Return txtAppointmentId
        End Get
        Set(value As Integer)
            txtAppointmentId = value
        End Set
    End Property

    Public Property AppointmentPatientId() As Integer
        Get
            Return txtAppointmentPatientId
        End Get
        Set(value As Integer)
            txtAppointmentPatientId = value
        End Set
    End Property

    Public Property AppointmentCase() As String
        Get
            Return txtAppointmentCase
        End Get
        Set(ByVal value As String)
            txtAppointmentCase = value
        End Set
    End Property

    Public Property AppointmentDate() As String
        Get
            Return dtpAppointmentDate
        End Get
        Set(ByVal value As String)
            dtpAppointmentDate = value
        End Set
    End Property

    Public Property AppointmentTime() As String
        Get
            Return dtpAppointmentTime
        End Get
        Set(ByVal value As String)
            dtpAppointmentTime = value
        End Set
    End Property

    Public Property AppointmentLocation() As String
        Get
            Return txtAppointmentLocation
        End Get
        Set(ByVal value As String)
            txtAppointmentLocation = value
        End Set
    End Property

    Public Property AppointmentDoctor() As String
        Get
            Return txtAppointmentDoctor
        End Get
        Set(ByVal value As String)
            txtAppointmentDoctor = value
        End Set
    End Property

    Public Sub AddNew(txtAppointmentPatientId, txtAppointmentCase, dtpAppointmentDate, dtpAppointmentTime, txtAppointmentLocation, txtAppointmentDoctor)
        Try
            sql = "INSERT INTO appointment (patient_id, case_type, appointment_date, appointment_time, location, doctor) VALUES ('" & txtAppointmentPatientId & "', '" & txtAppointmentCase & "', '" & dtpAppointmentDate & "', '" & dtpAppointmentTime & "', '" & txtAppointmentLocation & "', '" & txtAppointmentDoctor & "')"
            Dim msg As DialogResult = MessageBox.Show("Add New Appointment Information?", "Add Appointment", MessageBoxButtons.YesNo)
            If msg = DialogResult.Yes Then
                create(sql)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ADD NEW SUB")
        End Try
    End Sub

    Public Sub UpdateRecord(txtAppointmentPatientId, txtAppointmentCase, dtpAppointmentDate, dtpAppointmentTime, txtAppointmentLocation, txtAppointmentDoctor)
        Try
            sql = "UPDATE appointment SET patient_id ='" & txtAppointmentPatientId & "', case_type = '" & txtAppointmentCase & "', appointment_date = '" & dtpAppointmentDate & "' , appointment_time = '" & dtpAppointmentTime & "' , location = '" & txtAppointmentLocation & "' , doctor = '" & txtAppointmentDoctor & "' WHERE id = " & txtAppointmentId
            Dim msg As DialogResult = MessageBox.Show("Update Appointment Information?", "Update Appointment", MessageBoxButtons.YesNo)
            If msg = DialogResult.Yes Then
                updates(sql)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ADD NEW SUB")
        End Try
    End Sub

    Public Sub DeleteRecord(id As Integer)
        Try
            sql = "DELETE FROM appointment WHERE id=" & id
            delete(sql)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR ON DELETE RECORD")
        End Try
    End Sub

    Public Sub ViewRecord(dgv As DataGridView)
        sql = "SELECT * FROM appointment"
        reload(sql, dgv)
    End Sub


End Class
