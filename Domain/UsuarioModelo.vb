Imports System.Text
Imports DataAcces

Public Class UsuarioModelo
    Dim datos_usuario As New Datos_Usuario 'Instanciar el objeto de acceso a datos del usuario

    Public Function dominio_Registrar(Usuario As String, Password As String, Email As String) As Boolean
        ' Encriptar la contraseña antes de registrar el usuario
        Dim contraseñaEncriptada As String = Encrypt(Password)
        ' Llamar al método RegistrarUsuario con la contraseña encriptada
        Return datos_usuario.RegistrarUsuario(Usuario, contraseñaEncriptada, Email)
    End Function

    Public Function dominio_Login(Usuario As String, Password As String) As Boolean
        ' Encriptar la contraseña proporcionada durante el inicio de sesión
        Dim contraseñaEncriptada As String = Encrypt(Password)
        ' Llamar al método Login con la contraseña encriptada
        Return datos_usuario.Login(Usuario, contraseñaEncriptada)

    End Function

    Public Function dominio_ObtenerUsuarios() As DataTable
        Dim datos_usuario As New Datos_Usuario()
        Return datos_usuario.ObtenerUsuarios()
    End Function

    Public Function dominio_ActualizarUsuario(id As Integer, usuario As String, email As String) As Boolean
        Dim datos_usuario As New Datos_Usuario()
        Return datos_usuario.ActualizarUsuario(id, usuario, email)
    End Function

    Public Function dominio_EliminarUsuario(id As Integer) As Boolean
        Dim datos_usuario As New Datos_Usuario()
        Return datos_usuario.EliminarUsuario(id)
    End Function
    Public Function dominio_ContarUsuarios() As Integer
        Dim datosUsuario As New Datos_Usuario()
        Return datosUsuario.ContarUsuarios()
    End Function

    Public Function ExisteUsuarioPorNombreUsuario(Usuario As String) As Boolean
        Return datos_usuario.ExisteUsuarioPorNombreUsuario(Usuario)
    End Function

    Public Function ExisteUsuarioPorCorreoElectronico(Email As String) As Boolean
        Return datos_usuario.ExisteUsuarioPorCorreoElectronico(Email)
    End Function

    Public Function ExisteUsuarioPorCorreoElectronicoExcluyendoId(Email As String, id As Integer) As Boolean
        Return datos_usuario.ExisteUsuarioPorCorreoElectronicoExcluyendoId(Email, id)
    End Function


    Public Function Encrypt(Encryptation As String) As String
        Dim msg As String = String.Empty
        Dim encode As Byte() = New Byte(Encryptation.Length - 1) {}
        encode = Encoding.UTF8.GetBytes(Encryptation)
        msg = Convert.ToBase64String(encode)
        Return msg
    End Function


End Class