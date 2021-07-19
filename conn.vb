Imports MySql.Data
Imports MySql.Data.MySqlClient
Module conn

    Dim constr = "server = localhost;" & "username = root;" & "password = ckeanu.lars12;" & "database = hospital_document_tracker;" & "charset=utf8;"
    Dim con As New MySqlConnection(constr)
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Private dt As New DataTable
    Private result As String
    Public token As String
    Public id As Integer

    Public Sub create(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("FAILED TO SAVE DATA.")
                Else
                    MessageBox.Show("DATA HAS BEEN SAVE IN THE DATABASE.")
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        con.Close()
    End Sub

    Public Sub reload(ByVal sql As String, ByVal DTG As Object)
        Try
            dt = New DataTable
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, "Load Data Failed.")
            con.Close()
        End Try
        con.Close()
        da.Dispose()
    End Sub

    Public Sub search(ByVal sql As String, ByVal dt As DataTable)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Search Query Failed.")
        End Try
        con.Close()
        da.Dispose()
    End Sub

    Public Sub updates(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("DATA IS FAILED UPDATE.")
                Else
                    MessageBox.Show("THE DATA HAS BEEN UPDATED IN THE DATABASE.")
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        con.Close()
    End Sub

    Public Sub delete(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("FAILED TO DELETE THE DATA IN THE DATABASE.")
                Else
                    MessageBox.Show("DATA HAS BEEN DELETE IN THE DATABASE.")
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        con.Close()
    End Sub

End Module
