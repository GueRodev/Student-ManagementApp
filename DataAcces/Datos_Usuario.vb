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

End Class
