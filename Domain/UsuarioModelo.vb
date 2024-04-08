Imports DataAcces

Public Class UsuarioModelo
    Dim datos_usuario As New Datos_Usuario 'Instanciar el objeto de acceso a datos del usuario

    Public Function dominio_Login(usuario As String, password As String) As Boolean
        Return datos_usuario.Login(usuario, password)
    End Function

End Class