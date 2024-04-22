
Imports System.Runtime.InteropServices
Imports Domain 'Importar la capa de dominio

Public Class Form1
    Public Sub New()

        InitializeComponent()

    End Sub

    Private Sub btnCerrarLogin_Click(sender As Object, e As EventArgs) Handles btnCerrarLogin.Click
        Me.Close()
    End Sub

    Private Sub btnMinimizarLogin_Click(sender As Object, e As EventArgs) Handles btnMinimizarLogin.Click
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

    Private Sub btnCuentaNueva_Click(sender As Object, e As EventArgs) Handles btnCuentaNueva.Click
        Me.Hide()
        RegistroUsuario.Show()
    End Sub

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        'Instanciamos la clase UsuarioModelo
        Dim usuarioModelo As New UsuarioModelo()
        'Mostrar Encriptacion'
        ' Dim contraseñaEncriptada As String = usuarioModelo.Encrypt(txtContrasena.Text) '
        'txtMostrarEncrypt.Text = contraseñaEncriptada'

        Dim validLogin = usuarioModelo.dominio_Login(txtUsuario.Text, txtContrasena.Text) 'Asignamos el metodo login de la capa dominio que retorna los valores de iniciar sesion
        If validLogin = True Then
            Dim frm As New FormPrincipal() 'Instanciamos el formulario Principal
            frm.Show()
            AddHandler frm.FormClosed, AddressOf Me.Cerrar_Sesion
            Me.Hide()
        Else
            MessageBox.Show("Datos Incorrectos" + vbNewLine + "Intente de Nuevo")
            txtContrasena.Clear()
            txtContrasena.Focus()
        End If
    End Sub

    Private Sub Cerrar_Sesion(sender As Object, e As FormClosedEventArgs)
        txtContrasena.Clear()
        txtUsuario.Clear()
        Me.Show()

    End Sub


End Class