
Imports MySql.Data.MySqlClient
Imports Common
Imports System.Data

Public Class Datos_Estudiantes
    'Herencia
    Inherits ConnMySql
    Public Function InsertarEstudiante(nombre As String, apellidos As String, identificacion As String, correo As String, carrera As String, fechaIngreso As Date) As Boolean
        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand()
                    command.Connection = connection
                    command.CommandText = "INSERT INTO Estudiantes (Nombre, Apellidos, Identificacion, Correo, Carrera, Fecha_Ingreso) VALUES (@Nombre, @Apellidos, @Identificacion, @Correo, @Carrera, @FechaIngreso)"
                    command.Parameters.AddWithValue("@Nombre", nombre)
                    command.Parameters.AddWithValue("@Apellidos", apellidos)
                    command.Parameters.AddWithValue("@Identificacion", identificacion)
                    command.Parameters.AddWithValue("@Correo", correo)
                    command.Parameters.AddWithValue("@Carrera", carrera)
                    command.Parameters.AddWithValue("@FechaIngreso", fechaIngreso)
                    command.CommandType = CommandType.Text
                    Dim rowsAffected = command.ExecuteNonQuery()
                    Return rowsAffected > 0
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function ObtenerEstudiantes() As DataTable
        Dim dtEstudiantes As New DataTable()

        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand()
                    command.Connection = connection
                    command.CommandText = "SELECT * FROM Estudiantes"
                    command.CommandType = CommandType.Text

                    Dim adapter As New MySqlDataAdapter(command)
                    adapter.Fill(dtEstudiantes)
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return dtEstudiantes
    End Function
    Public Function ActualizarEstudiante(id As Integer, nombre As String, apellidos As String, identificacion As String, correo As String, carrera As String, fechaIngreso As Date) As Boolean
        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand()
                    command.Connection = connection
                    command.CommandText = "UPDATE Estudiantes SET Nombre = @Nombre, Apellidos = @Apellidos, Identificacion = @Identificacion, Correo = @Correo, Carrera = @Carrera, Fecha_Ingreso = @FechaIngreso WHERE ID = @ID"
                    command.Parameters.AddWithValue("@ID", id)
                    command.Parameters.AddWithValue("@Nombre", nombre)
                    command.Parameters.AddWithValue("@Apellidos", apellidos)
                    command.Parameters.AddWithValue("@Identificacion", identificacion)
                    command.Parameters.AddWithValue("@Correo", correo)
                    command.Parameters.AddWithValue("@Carrera", carrera)
                    command.Parameters.AddWithValue("@FechaIngreso", fechaIngreso)
                    command.CommandType = CommandType.Text
                    Dim rowsAffected = command.ExecuteNonQuery()
                    Return rowsAffected > 0
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function EliminarEstudiante(id As Integer) As Boolean
        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand()
                    command.Connection = connection
                    command.CommandText = "DELETE FROM Estudiantes WHERE ID = @ID"
                    command.Parameters.AddWithValue("@ID", id)
                    command.CommandType = CommandType.Text
                    Dim rowsAffected = command.ExecuteNonQuery()

                    ' Reiniciar el valor del auto incremento después de eliminar el estudiante
                    Dim cmdResetAutoIncrement As New MySqlCommand("ALTER TABLE Estudiantes AUTO_INCREMENT = 1", connection)
                    cmdResetAutoIncrement.ExecuteNonQuery()

                    Return rowsAffected > 0
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function ContarEstudiantes() As Integer
        Dim count As Integer = 0
        Using connection = GetConnection()
            connection.Open()
            Using command = New MySqlCommand("SELECT COUNT(*) FROM Estudiantes", connection)
                count = Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using
        Return count
    End Function



End Class
