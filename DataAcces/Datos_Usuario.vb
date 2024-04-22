'Import System.Data
Imports MySql.Data.MySqlClient
Imports Common
Imports System.Data

Public Class Datos_Usuario

    Inherits ConnMySql

    Public Function Login(Usuario As String, Password As String) As Boolean

        Try
            Using connection = GetConnection() 'Existira hasta que las filas de using terminen de ejecutarse
                connection.Open()
                Using command = New MySqlCommand() 'Existira hasta que las filas de using terminen de ejecutarse
                    command.Connection = connection
                    command.CommandText = "SELECT * FROM usuarios WHERE Usuario=@Usuario AND Password = @Password"
                    command.Parameters.AddWithValue("@Usuario", Usuario)
                    command.Parameters.AddWithValue("@Password", Password)
                    command.CommandType = CommandType.Text

                    Dim reader = command.ExecuteReader() 'metodo que ejecuta una consulta Sql, devuelve conjunto de resultados
                    If reader.HasRows Then 'seleccion de filas de una tabla
                        While reader.Read()
                            ActiveUser.ID = reader.GetInt32(0)
                            ActiveUser.Usuario = reader.GetString(1)
                            ActiveUser.Email = reader.GetString(3)
                            ActiveUser.Rol = reader.GetString(4)
                        End While
                        reader.Dispose()
                        Return True 'si la consulta existe retornamos true 
                    Else
                        Return False
                    End If

                End Using 'no es necesario cerrar conexion 

            End Using 'al utilizar el EndUsing simplemente libera los recursos utilizados
            ' es una práctica recomendada para asegurar la liberación adecuada de recursos como conexiones a la base de datos

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Public Function RegistrarUsuario(Usuario As String, Password As String, Email As String) As Boolean

        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand()
                    command.Connection = connection
                    command.CommandText = "INSERT INTO usuarios (Usuario, Password, Email) VALUES (@Usuario, @Password, @Email)"
                    command.Parameters.AddWithValue("@Usuario", Usuario)
                    command.Parameters.AddWithValue("@Password", Password)
                    command.Parameters.AddWithValue("@Email", Email)
                    command.CommandType = CommandType.Text

                    Dim rowsAffected = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        Return True ' Registro exitoso
                    Else
                        Return False ' Error al registrar usuario
                    End If

                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    'Mostrar Datos
    Public Function ObtenerUsuarios() As DataTable
        Dim dtUsuarios As New DataTable()

        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand()
                    command.Connection = connection
                    command.CommandText = "SELECT * FROM usuarios"
                    command.CommandType = CommandType.Text

                    Dim adapter As New MySqlDataAdapter(command)
                    adapter.Fill(dtUsuarios)
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return dtUsuarios
    End Function

    Public Function ActualizarUsuario(id As Integer, usuario As String, email As String) As Boolean
        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand()
                    command.Connection = connection
                    command.CommandText = "UPDATE usuarios SET Usuario = @Usuario, Email = @Email WHERE ID = @ID"
                    command.Parameters.AddWithValue("@ID", id)
                    command.Parameters.AddWithValue("@Usuario", usuario)
                    command.Parameters.AddWithValue("@Email", email)
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



End Class
