Imports System.Runtime.InteropServices
Imports Domain

Public Class RegistroUsuario

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub btnCerrarRegistroUsuario_Click(sender As Object, e As EventArgs) Handles btnCerrarRegistroUsuario.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub btnMinimizarRegistroUsuario_Click(sender As Object, e As EventArgs) Handles btnMinimizarRegistroUsuario.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    ' Variables para almacenar la posición inicial del formulario y la posición inicial del mouse al hacer clic en el panel de título.
    Private isDragging As Boolean = False
    Private startPoint As New Point(0, 0)

    ' Evento MouseDown del panel de título
    Private Sub PanelTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            startPoint = New Point(e.X, e.Y)
        End If
    End Sub

    ' Evento MouseMove del panel de título
    Private Sub PanelTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseMove
        If isDragging Then
            Dim p As Point = Me.PointToScreen(New Point(e.X, e.Y))
            Me.Location = New Point(p.X - Me.startPoint.X, p.Y - Me.startPoint.Y)
        End If
    End Sub

    ' Evento MouseUp del panel de título
    Private Sub PanelTitulo_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseUp
        If e.Button = MouseButtons.Left Then
            isDragging = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub


    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        ' Obtener los datos del usuario desde los campos del formulario
        Dim usuario As String = txtRegistroUsuario.Text
        Dim contraseña As String = txtRegistroContrasena.Text
        Dim email As String = txtRegistroEmail.Text

        ' Validar que los campos no estén vacíos
        If String.IsNullOrEmpty(usuario) OrElse String.IsNullOrEmpty(contraseña) OrElse String.IsNullOrEmpty(email) Then
            MessageBox.Show("Por favor, complete todos los campos.")
            Return
        End If

        ' Encriptar la contraseña antes de registrar el usuario
        Dim usuarioModelo As New UsuarioModelo()

        ' Llamar al método dominio_Registrar para registrar el nuevo usuario con la contraseña encriptada
        Dim registroExitoso As Boolean = usuarioModelo.dominio_Registrar(usuario, contraseña, email)

        ' Verificar si el registro fue exitoso
        If registroExitoso Then
            MessageBox.Show("Usuario registrado correctamente.")
            ' Limpia los campos después de registrar el usuario
            LimpiarCampos()
        Else
            MessageBox.Show("Error al registrar el usuario. Inténtelo de nuevo.")
        End If
    End Sub
    Private Sub LimpiarCampos()
        ' Limpiar los campos del formulario
        txtRegistroUsuario.Clear()
        txtRegistroContrasena.Clear()
        txtRegistroEmail.Clear()

        ' Colocar el foco en el campo de usuario para una nueva entrada
        txtRegistroUsuario.Focus()
    End Sub

End Class