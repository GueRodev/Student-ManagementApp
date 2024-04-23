Imports Domain
Imports System

Public Class Panel_Inicio
    Private Sub Panel_Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Crear una instancia de UsuarioModelo
        Dim usuarioModelo As New UsuarioModelo()
        ' Llamar al método para contar usuarios desde la instancia creada
        Dim cantidadUsuarios As Integer = usuarioModelo.dominio_ContarUsuarios()
        ' Asignar el valor al Label
        lblCantidadUsuarios.Text = cantidadUsuarios.ToString()

        MostrarHoraActual()
        tmrHora.Start()
    End Sub

    Private Sub MostrarHoraActual()
        ' Obtener la hora actual
        Dim horaActual As String = DateTime.Now.ToString("hh:mm:ss tt")

        ' Mostrar la hora actual en el Label
        lbl_HORA.Text = horaActual
    End Sub

    Private Sub tmrHora_Tick(sender As Object, e As EventArgs) Handles tmrHora.Tick
        MostrarHoraActual()
    End Sub
End Class
