Imports MySql.Data.MySqlClient
Imports Common
Imports System.Data
Imports System.Data.SqlClient

Public Class Datos_Asignar
    Inherits ConnMySql

    ' Método para obtener la lista de estudiantes con sus carreras
    Public Function ObtenerEstudiantesConCarrera() As DataTable
        Dim dtEstudiantes As New DataTable()
        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand()
                    command.Connection = connection
                    command.CommandText = "SELECT " &
                                          "Estudiantes.Identificacion, " &
                                          "Estudiantes.Nombre, " &
                                          "Estudiantes.Apellidos, " &
                                          "Carreras.Nombre AS Carrera " &
                                          "FROM Estudiantes " &
                                          "JOIN Carreras ON Estudiantes.CarreraID = Carreras.ID"

                    Dim adapter As New MySqlDataAdapter(command)
                    adapter.Fill(dtEstudiantes)
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return dtEstudiantes
    End Function

    ' Método para obtener la lista de materias asociadas a un estudiante
    ' Método para obtener la lista de materias asociadas a un estudiante
    Public Function ObtenerMateriasPorEstudiante(identificacion As String) As DataTable
        Dim dtMaterias As New DataTable()
        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand()
                    command.Connection = connection
                    command.CommandText = "SELECT EstudianteMateria.MateriaID, " &
                                      "EstudianteMateria.EstudianteID, " &
                                      "Materias.Nombre AS Materia, " &
                                      "EstadoMateria.Estado, " &
                                      "EstudianteMateria.Nota " &
                                      "FROM EstudianteMateria " &
                                      "JOIN Estudiantes ON EstudianteMateria.EstudianteID = Estudiantes.ID " &
                                      "JOIN Materias ON EstudianteMateria.MateriaID = Materias.ID " &
                                      "JOIN EstadoMateria ON EstudianteMateria.EstadoID = EstadoMateria.ID " &
                                      "WHERE Estudiantes.Identificacion = @identificacion"
                    command.Parameters.AddWithValue("@identificacion", identificacion)

                    Dim adapter As New MySqlDataAdapter(command)
                    adapter.Fill(dtMaterias)
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return dtMaterias
    End Function


    ' Método para editar las columnas Estado y Nota en la tabla EstudianteMateria
    Public Function EditarEstadoYNota(estudianteId As Integer, materiaId As Integer, estadoId As Integer, nota As Integer) As Boolean
        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand()
                    command.Connection = connection
                    command.CommandText = "UPDATE EstudianteMateria SET EstadoID = @EstadoID, Nota = @Nota " &
                                      "WHERE EstudianteID = @EstudianteID AND MateriaID = @MateriaID"
                    command.Parameters.AddWithValue("@EstadoID", estadoId)
                    command.Parameters.AddWithValue("@Nota", nota)
                    command.Parameters.AddWithValue("@EstudianteID", estudianteId)
                    command.Parameters.AddWithValue("@MateriaID", materiaId)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    Return rowsAffected > 0
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al editar el estado y la nota en la tabla EstudianteMateria", ex)
        End Try
    End Function




End Class