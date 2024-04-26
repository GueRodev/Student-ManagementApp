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

            ' Verificar si ya existe un usuario con el mismo nombre de usuario o correo electrónico
            If ExisteUsuarioPorNombreUsuario(Usuario) Then
                MsgBox("Error al guardar el usuario.")
                Return False
            End If

            If ExisteUsuarioPorCorreoElectronico(Email) Then
                MsgBox("Error al guardar el correo.")
                Return False
            End If

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

            ' Verificar si ya existe un usuario con el mismo correo electrónico, excluyendo al usuario actual
            If ExisteUsuarioPorCorreoElectronicoExcluyendoId(email, id) Then
                MsgBox("Error al actualizar el correo.")
                Return False
            End If

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

    Public Function EliminarUsuario(id As Integer) As Boolean
        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand()
                    command.Connection = connection
                    command.CommandText = "DELETE FROM usuarios WHERE ID = @ID"
                    command.Parameters.AddWithValue("@ID", id)
                    command.CommandType = CommandType.Text
                    Dim rowsAffected = command.ExecuteNonQuery()

                    ' Reiniciar el valor del auto incremento después de eliminar el usuario
                    Dim cmdResetAutoIncrement As New MySqlCommand("ALTER TABLE usuarios AUTO_INCREMENT = 1", connection)
                    cmdResetAutoIncrement.ExecuteNonQuery()

                    Return rowsAffected > 0
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function ContarUsuarios() As Integer
        Dim count As Integer = 0
        Using connection = GetConnection()
            connection.Open()
            Using command = New MySqlCommand("SELECT COUNT(*) FROM Usuarios", connection)
                count = Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using
        Return count
    End Function


    Public Function ExisteUsuarioPorNombreUsuario(Usuario As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM usuarios WHERE Usuario = @Usuario"
        Dim count As Integer

        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Usuario", Usuario)
                    count = Convert.ToInt32(command.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error al verificar la existencia del usuario por nombre de usuario: " & ex.Message)
            Return False
        End Try

        Return count > 0
    End Function

    Public Function ExisteUsuarioPorCorreoElectronico(Email As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM usuarios WHERE Email = @Email"
        Dim count As Integer

        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Email", Email)
                    count = Convert.ToInt32(command.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error al verificar la existencia del usuario por correo electrónico: " & ex.Message)
            Return False
        End Try

        Return count > 0
    End Function

    Public Function ExisteUsuarioPorCorreoElectronicoExcluyendoId(Email As String, id As Integer) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM usuarios WHERE Email = @Email AND ID != @ID"
        Dim count As Integer

        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Email", Email)
                    command.Parameters.AddWithValue("@ID", id)
                    count = Convert.ToInt32(command.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error al verificar la existencia del usuario por correo electrónico excluyendo ID: " & ex.Message)
            Return False
        End Try

        Return count > 0
    End Function


End Class
