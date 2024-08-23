Imports MySql.Data.MySqlClient
Imports Common
Imports System.Data

Public Class Datos_Estados
    Inherits ConnMySql


    ' Método para obtener las materias de un estudiante por estado
    Public Function ObtenerMateriasPorEstudianteYEstado(identificacion As String, estadoId As Integer) As DataTable
        Dim dtMaterias As New DataTable()
        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand()
                    command.Connection = connection
                    command.CommandText = "SELECT EstudianteMateria.MateriaID, " &
                                          "Materias.Nombre AS Materia, " &
                                          "EstudianteMateria.Nota " &
                                          "FROM EstudianteMateria " &
                                          "JOIN Estudiantes ON EstudianteMateria.EstudianteID = Estudiantes.ID " &
                                          "JOIN Materias ON EstudianteMateria.MateriaID = Materias.ID " &
                                          "WHERE Estudiantes.Identificacion = @identificacion AND EstudianteMateria.EstadoID = @estadoId"
                    command.Parameters.AddWithValue("@identificacion", identificacion)
                    command.Parameters.AddWithValue("@estadoId", estadoId)

                    Dim adapter As New MySqlDataAdapter(command)
                    adapter.Fill(dtMaterias)
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return dtMaterias
    End Function

    Public Function ObtenerCreditosAprobados(identificacion As String) As Integer
        Dim totalCreditosAprobados As Integer = 0
        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand()
                    command.Connection = connection
                    command.CommandText = "SELECT SUM(m.Creditos) AS TotalCreditosAprobados " &
                                      "FROM EstudianteMateria em " &
                                      "JOIN Materias m ON em.MateriaID = m.ID " &
                                      "JOIN Estudiantes e ON em.EstudianteID = e.ID " &
                                      "WHERE e.Identificacion = @identificacion AND em.EstadoID = 2" ' EstadoID = 2 es para "Aprobadas"
                    command.Parameters.AddWithValue("@identificacion", identificacion)

                    Dim result = command.ExecuteScalar()
                    If Not IsDBNull(result) Then
                        totalCreditosAprobados = Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return totalCreditosAprobados
    End Function




End Class

