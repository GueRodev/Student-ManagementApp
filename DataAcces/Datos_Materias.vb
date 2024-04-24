Imports MySql.Data.MySqlClient
Imports Common
Imports System.Data

Public Class Datos_Materias
    ' Hereda la conexión a MySQL de ConnMySql
    Inherits ConnMySql

    ' Método para insertar una nueva materia
    Public Function InsertarMateria(nombre As String, codigo As String, creditos As Integer) As Boolean
        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand()
                    command.Connection = connection
                    command.CommandText = "INSERT INTO Materias (Nombre, Codigo, Creditos) VALUES (@Nombre, @Codigo, @Creditos)"
                    command.Parameters.AddWithValue("@Nombre", nombre)
                    command.Parameters.AddWithValue("@Codigo", codigo)
                    command.Parameters.AddWithValue("@Creditos", creditos)
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

    ' Método para obtener todas las materias
    Public Function ObtenerMaterias() As DataTable
        Dim dtMaterias As New DataTable()

        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand()
                    command.Connection = connection
                    command.CommandText = "SELECT * FROM Materias"
                    command.CommandType = CommandType.Text

                    Dim adapter As New MySqlDataAdapter(command)
                    adapter.Fill(dtMaterias)
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return dtMaterias
    End Function

    ' Método para actualizar una materia existente
    Public Function ActualizarMateria(id As Integer, nombre As String, codigo As String, creditos As Integer) As Boolean
        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand()
                    command.Connection = connection
                    command.CommandText = "UPDATE Materias SET Nombre = @Nombre, Codigo = @Codigo, Creditos = @Creditos WHERE ID = @ID"
                    command.Parameters.AddWithValue("@ID", id)
                    command.Parameters.AddWithValue("@Nombre", nombre)
                    command.Parameters.AddWithValue("@Codigo", codigo)
                    command.Parameters.AddWithValue("@Creditos", creditos)
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

    ' Método para eliminar una materia
    Public Function EliminarMateria(id As Integer) As Boolean
        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand()
                    command.Connection = connection
                    command.CommandText = "DELETE FROM Materias WHERE ID = @ID"
                    command.Parameters.AddWithValue("@ID", id)
                    command.CommandType = CommandType.Text
                    Dim rowsAffected = command.ExecuteNonQuery()

                    ' Reiniciar el valor del auto incremento después de eliminar la materia
                    Dim cmdResetAutoIncrement As New MySqlCommand("ALTER TABLE Materias AUTO_INCREMENT = 1", connection)
                    cmdResetAutoIncrement.ExecuteNonQuery()

                    Return rowsAffected > 0
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    ' Método para contar la cantidad de materias
    Public Function ContarMaterias() As Integer
        Dim count As Integer = 0
        Using connection = GetConnection()
            connection.Open()
            Using command = New MySqlCommand("SELECT COUNT(*) FROM Materias", connection)
                count = Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using
        Return count
    End Function
End Class
