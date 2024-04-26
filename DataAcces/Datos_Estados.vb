Imports MySql.Data.MySqlClient
Imports Common
Imports System.Data

Public Class Datos_Estados
    Inherits ConnMySql

    Public Function ObtenerEstudiantesPorIdentificacion(identificacion As String) As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String = "SELECT * FROM uta_database.vista_estudiante_materia WHERE Identificacion = @Identificacion"

            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Identificacion", identificacion)
                    Using adapter As New MySqlDataAdapter(command)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Manejo de excepciones
            MsgBox("Error al obtener los datos de los estudiantes: " & ex.Message)
        End Try

        Return dt
    End Function
End Class

