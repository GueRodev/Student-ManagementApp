Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
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
        ' Mostrar un cuadro de diálogo de confirmación
        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que deseas crear un nuevo usuario?", "Confirmar creación de usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Verificar si se confirmó la creación de usuario
        If respuesta = DialogResult.Yes Then
            ' Obtener los datos del usuario desde los campos del formulario
            Dim usuario As String = txtRegistroUsuario.Text
            Dim contraseña As String = txtRegistroContrasena.Text
            Dim email As String = txtRegistroEmail.Text

            ' Validar que los campos no estén vacíos
            If String.IsNullOrEmpty(usuario) OrElse String.IsNullOrEmpty(contraseña) OrElse String.IsNullOrEmpty(email) Then
                MessageBox.Show("Por favor, complete todos los campos.")
                Return
            End If

            ' Validar el nombre de usuario
            If Not ValidarUsuario(usuario) Then
                MessageBox.Show("El nombre de usuario debe tener máximo 8 caracteres y como máximo 2 números.", "Error de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Validar la contraseña
            If Not ValidarContraseña(contraseña) Then
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres y contener al menos una letra mayúscula, una letra minúscula, un número y un carácter especial.", "Error de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Validar el correo electrónico
            If Not ValidarCorreo(email) Then
                MessageBox.Show("Ingrese un correo electrónico válido.", "Error de correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            'Instanciar UsuarioModelo
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
        End If
    End Sub

    Private Function ValidarUsuario(usuario As String) As Boolean
        ' Verificar que el usuario no tenga más de 8 caracteres
        If usuario.Length > 8 Then
            Return False
        End If

        ' Contador para contar números
        Dim numerosCount As Integer = 0

        ' Iterar sobre cada carácter del usuario
        For Each c As Char In usuario
            ' Verificar si el carácter es un número
            If Char.IsDigit(c) Then
                ' Incrementar el contador de números
                numerosCount += 1

                ' Verificar si se excede el límite de números permitidos
                If numerosCount > 2 Then
                    Return False
                End If
            End If
        Next

        ' Validación exitosa si se cumplen todas las condiciones
        Return True
    End Function


    Private Function ValidarCorreo(correo As String) As Boolean
        ' Verificar si el correo electrónico contiene un "@" y termina con ".com"
        Return correo.Contains("@") AndAlso correo.EndsWith(".com")
    End Function

    Private Function ValidarContraseña(contraseña As String) As Boolean
        ' Verificar si la contraseña cumple con los criterios de seguridad
        If contraseña.Length < 8 Then
            Return False
        End If

        ' Verificar si la contraseña contiene al menos una letra mayúscula, una letra minúscula, un número y un carácter especial
        If Not Regex.IsMatch(contraseña, "(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}") Then
            Return False
        End If

        Return True
    End Function

    Private Sub LimpiarCampos()
        ' Limpiar los campos del formulario
        txtRegistroUsuario.Clear()
        txtRegistroContrasena.Clear()
        txtRegistroEmail.Clear()
        txtRegistroUsuario.Focus()
    End Sub

End Class