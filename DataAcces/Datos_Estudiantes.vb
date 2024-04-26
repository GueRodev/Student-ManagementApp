
Imports MySql.Data.MySqlClient
Imports Common
Imports System.Data

Public Class Datos_Estudiantes
    'Herencia
    Inherits ConnMySql
    Public Function InsertarEstudiante(nombre As String, apellidos As String, identificacion As String, correo As String, carrera As String, fechaIngreso As Date) As Boolean
        Try

            ' Verificar si ya existe un estudiante con el mismo correo electrónico
            If ExisteEstudiantePorCorreo(correo) Then
                MsgBox("Error al guardar correo.")
                Return False
            End If

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

            ' Verificar si ya existe un estudiante con el mismo correo electrónico, excluyendo al estudiante actual
            If ExisteEstudiantePorCorreoExcluyendoId(correo, id) Then
                MsgBox("Error al actualizar correo.")
                Return False
            End If


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

    Public Function ExisteEstudiantePorIdentificacion(identificacion As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Estudiantes WHERE Identificacion = @Identificacion"
        Dim count As Integer

        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Identificacion", identificacion)
                    count = Convert.ToInt32(command.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error al verificar la existencia del estudiante: " & ex.Message)
            Return False
        End Try

        Return count > 0
    End Function



    Public Function ObtenerEstudiantePorId(id As Integer) As DataRow
        Dim dtEstudiante As New DataTable()

        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand()
                    command.Connection = connection
                    command.CommandText = "SELECT * FROM Estudiantes WHERE ID = @ID"
                    command.Parameters.AddWithValue("@ID", id)
                    command.CommandType = CommandType.Text

                    Dim adapter As New MySqlDataAdapter(command)
                    adapter.Fill(dtEstudiante)
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error al obtener el estudiante: " & ex.Message)
        End Try

        If dtEstudiante.Rows.Count > 0 Then
            Return dtEstudiante.Rows(0)
        Else
            Return Nothing
        End If
    End Function

    Public Function ExisteEstudiantePorCorreo(correo As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Estudiantes WHERE Correo = @Correo"
        Dim count As Integer

        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Correo", correo)
                    count = Convert.ToInt32(command.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error al verificar la existencia del estudiante por correo: " & ex.Message)
            Return False
        End Try

        Return count > 0
    End Function

    Public Function ExisteEstudiantePorCorreoExcluyendoId(correo As String, id As Integer) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Estudiantes WHERE Correo = @Correo AND ID != @ID"
        Dim count As Integer

        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Correo", correo)
                    command.Parameters.AddWithValue("@ID", id)
                    count = Convert.ToInt32(command.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error al verificar la existencia del estudiante por correo: " & ex.Message)
            Return False
        End Try

        Return count > 0
    End Function


End Class
