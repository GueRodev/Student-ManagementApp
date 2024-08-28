Imports MySql.Data.MySqlClient
Imports Common
Imports System.Data


Public Class Data_Matricular
    'Herencia
    Inherits ConnMySql

    Public Function InsertarEstudiante(nombre As String, apellidos As String, identificacion As String, carnet As String, correo As String, telefono As String, carreraID As Integer, fechaIngreso As Date) As Boolean
        Dim transaction As MySqlTransaction = Nothing
        Dim connection As MySqlConnection = Nothing
        Try
            connection = GetConnection()
            connection.Open()
            If connection.State = ConnectionState.Open Then
                transaction = connection.BeginTransaction()
            Else
                Throw New InvalidOperationException("La conexión a la base de datos no se pudo abrir.")
            End If

            Using command = New MySqlCommand()
                command.Connection = connection
                command.Transaction = transaction

                ' Inserción del estudiante
                command.CommandText = "INSERT INTO Estudiantes (Nombre, Apellidos, Identificacion, Carnet, Correo, Telefono, CarreraID, Fecha_Ingreso) VALUES (@Nombre, @Apellidos, @Identificacion, @Carnet, @Correo, @Telefono, @CarreraID, @FechaIngreso)"
                command.Parameters.AddWithValue("@Nombre", nombre)
                command.Parameters.AddWithValue("@Apellidos", apellidos)
                command.Parameters.AddWithValue("@Identificacion", identificacion)
                command.Parameters.AddWithValue("@Carnet", carnet)
                command.Parameters.AddWithValue("@Correo", correo)
                command.Parameters.AddWithValue("@Telefono", telefono)
                command.Parameters.AddWithValue("@CarreraID", carreraID)
                command.Parameters.AddWithValue("@FechaIngreso", fechaIngreso)
                command.ExecuteNonQuery()

                ' Obtener el ID del estudiante insertado
                command.CommandText = "SELECT LAST_INSERT_ID()"
                Dim estudianteID As Integer = Convert.ToInt32(command.ExecuteScalar())

                ' Inserción de las materias del estudiante
                command.CommandText = "INSERT INTO EstudianteMateria (EstudianteID, MateriaID, EstadoID, Nota) SELECT @EstudianteID, MateriaID, 3, 0 FROM CarreraMateria WHERE CarreraID = @CarreraID"
                command.Parameters.AddWithValue("@EstudianteID", estudianteID)
                command.ExecuteNonQuery()

                ' Confirmar la transacción
                transaction.Commit()
                Return True
            End Using
        Catch ex As Exception
            If transaction IsNot Nothing AndAlso connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                transaction.Rollback()
            End If
            MsgBox(ex.Message)
            Return False
        Finally
            If connection IsNot Nothing Then
                connection.Close()
                connection.Dispose()
            End If
        End Try
    End Function


    Public Function ObtenerMaterias_PorCarrera(carreraID As Integer) As DataTable
        Dim dtMaterias As New DataTable()

        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand()
                    command.Connection = connection
                    command.CommandText = "SELECT Materias.Nombre, Materias.Codigo, Materias.Creditos, Materias.Requisitos FROM Materias INNER JOIN CarreraMateria ON Materias.ID = CarreraMateria.MateriaID WHERE CarreraMateria.CarreraID = @CarreraID"
                    command.Parameters.AddWithValue("@CarreraID", carreraID)
                    Dim adapter As New MySqlDataAdapter(command)
                    adapter.Fill(dtMaterias)
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return dtMaterias
    End Function

    Public Function ObtenerIDEstudiante_PorIdentificacion(identificacion As String) As Integer
        Dim idEstudiante As Integer = 0

        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand()
                    command.Connection = connection
                    command.CommandText = "SELECT ID FROM Estudiantes WHERE Identificacion = @Identificacion"
                    command.Parameters.AddWithValue("@Identificacion", identificacion)
                    Dim result = command.ExecuteScalar()
                    If result IsNot Nothing Then
                        idEstudiante = Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return idEstudiante
    End Function

    Public Function CorreoExiste(correo As String) As Boolean
        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand()
                    command.Connection = connection
                    command.CommandText = "SELECT COUNT(*) FROM Estudiantes WHERE Correo = @Correo"
                    command.Parameters.AddWithValue("@Correo", correo)
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                    ' Si el conteo es mayor a 0, el correo ya existe
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error al verificar el correo: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function TelefonoExiste(telefono As String) As Boolean
        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand()
                    command.Connection = connection
                    command.CommandText = "SELECT COUNT(*) FROM Estudiantes WHERE Telefono = @Telefono"
                    command.Parameters.AddWithValue("@Telefono", telefono)
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                    ' Si el conteo es mayor a 0, el teléfono ya existe
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error al verificar el teléfono: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function CarnetExiste(carnet As String) As Boolean
        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand()
                    command.Connection = connection
                    command.CommandText = "SELECT COUNT(*) FROM Estudiantes WHERE Carnet = @Carnet"
                    command.Parameters.AddWithValue("@Carnet", carnet)
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                    ' Si el conteo es mayor a 0, el carnet ya existe
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error al verificar el carnet: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function IdentificacionExiste(identificacion As String) As Boolean
        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand()
                    command.Connection = connection
                    command.CommandText = "SELECT COUNT(*) FROM Estudiantes WHERE Identificacion = @Identificacion"
                    command.Parameters.AddWithValue("@Identificacion", identificacion)
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                    ' Si el conteo es mayor a 0, la identificación ya existe
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error al verificar la identificación: " & ex.Message)
            Return False
        End Try
    End Function




End Class
