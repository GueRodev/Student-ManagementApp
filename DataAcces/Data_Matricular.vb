Imports MySql.Data.MySqlClient
Imports Common
Imports System.Data

Public Class Data_Matricular
    'Herencia
    Inherits ConnMySql

    Public Function InsertarEstudiante(nombre As String, apellidos As String, identificacion As String, carnet As String, correo As String, telefono As String, carreraID As Integer, fechaIngreso As Date) As Boolean
        Dim transaction As MySqlTransaction = Nothing
        Try
            Using connection = GetConnection()
                connection.Open()
                transaction = connection.BeginTransaction()

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
            End Using
        Catch ex As Exception
            If transaction IsNot Nothing Then transaction.Rollback()
            MsgBox(ex.Message)
            Return False
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


End Class
