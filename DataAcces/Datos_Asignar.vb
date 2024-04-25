Imports MySql.Data.MySqlClient
Imports Common
Imports System.Data
Public Class Datos_Asignar
    'Herencia
    Inherits ConnMySql

    Public Function InsertarMateriaAsignada(idEstudiante As String, idMateria As String, estado As String) As Boolean
        Try
            ' Verificar si el estudiante ya tiene la materia asignada
            If Not EstudianteTieneMateria(idEstudiante, idMateria) Then
                ' Si el estudiante no tiene la materia asignada, realizar la inserción
                Using connection = GetConnection()
                    connection.Open()
                    Using command = New MySqlCommand()
                        command.Connection = connection
                        command.CommandText = "INSERT INTO materiasasignadas (EstudianteID, MateriaID, Estado) VALUES (@EstudianteID, @MateriaID, @Estado)"
                        command.Parameters.AddWithValue("@EstudianteID", idEstudiante)
                        command.Parameters.AddWithValue("@MateriaID", idMateria)
                        command.Parameters.AddWithValue("@Estado", estado)
                        command.CommandType = CommandType.Text

                        Dim rowsAffected = command.ExecuteNonQuery()
                        Return rowsAffected > 0
                    End Using
                End Using
            Else
                ' Si el estudiante ya tiene la materia asignada, mostrar un mensaje de error
                MsgBox("El estudiante ya tiene asignada esta materia.")
                Return False
            End If
        Catch ex As Exception
            ' Manejo de excepciones
            MsgBox("Error al asignar la materia: " & ex.Message)
            Return False
        End Try
    End Function

    Private Function EstudianteTieneMateria(idEstudiante As String, idMateria As String) As Boolean
        ' Consulta SQL para verificar si el estudiante ya tiene la materia asignada
        Dim query As String = "SELECT COUNT(*) FROM materiasasignadas WHERE EstudianteID = @EstudianteID AND MateriaID = @MateriaID"

        ' Variables para almacenar el resultado de la consulta
        Dim count As Integer

        Try
            ' Ejecutar la consulta
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@EstudianteID", idEstudiante)
                    command.Parameters.AddWithValue("@MateriaID", idMateria)

                    ' Obtener el resultado de la consulta
                    count = Convert.ToInt32(command.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            ' Manejo de excepciones
            MsgBox("Error al verificar la asignación de materia: " & ex.Message)
            Return False
        End Try

        ' Si count es mayor que cero, significa que el estudiante ya tiene la materia asignada
        Return count > 0
    End Function

End Class

