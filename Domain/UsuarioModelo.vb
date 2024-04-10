Imports DataAcces

Public Class UsuarioModelo
    Dim datos_usuario As New Datos_Usuario 'Instanciar el objeto de acceso a datos del usuario

    Public Function dominio_Login(Usuario As String, Password As String) As Boolean
        Return datos_usuario.Login(Usuario, Password)
    End Function

End Class