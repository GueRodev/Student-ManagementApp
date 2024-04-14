'Import System.Data
Imports MySql.Data.MySqlClient

Public Class Datos_Usuario

    Inherits ConnMySql

    Public Function Login(Usuario As String, Password As String) As Boolean
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
                    Return True 'si la consulta existe retornamos true 
                Else
                    Return False
                End If

            End Using 'no es necesario cerrar conexion 

        End Using 'al utilizar el EndUsing simplemente libera los recursos utilizados 

    End Function

    Public Function RegistrarUsuario(Usuario As String, Password As String, Email As String) As Boolean
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
    End Function




End Class
