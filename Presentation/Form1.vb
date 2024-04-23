﻿
Imports System.Runtime.InteropServices
Imports Domain 'Importar la capa de dominio
Imports System.Threading

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

    Private Sub btn_IniciarSesion_Click(sender As Object, e As EventArgs) Handles btn_IniciarSesion.Click
        Dim usuarioModelo As New UsuarioModelo()
        Dim validLogin = usuarioModelo.dominio_Login(txt_Usuario.Text, txt_Contrasena.Text)

        If validLogin Then
            Dim pantallaBienvenida As New PantallaBienvenida()
            pantallaBienvenida.Show()

            Dim delayThread As New Thread(
            Sub()
                Thread.Sleep(3000)
                pantallaBienvenida.Invoke(Sub() pantallaBienvenida.Close())

                ' Abrir el FormPrincipal en el hilo principal después de cerrar la pantalla de bienvenida
                Me.Invoke(Sub()
                              Dim frmPrincipal As New FormPrincipal()
                              frmPrincipal.Show()
                              AddHandler frmPrincipal.FormClosed, AddressOf Me.Cerrar_Sesion
                              Me.Hide()
                          End Sub)
            End Sub
        )
            delayThread.Start()
        Else
            MessageBox.Show("Datos Incorrectos" + vbNewLine + "Intente de Nuevo")
            txt_Contrasena.Clear()
            txt_Contrasena.Focus()
        End If
    End Sub



    Private Sub CerrarForm1()
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf CerrarForm1))
        Else
            Me.Hide()
        End If
    End Sub


    Private Sub Cerrar_Sesion(sender As Object, e As FormClosedEventArgs)
        txt_Contrasena.Clear()
        txt_Usuario.Clear()
        Me.Show()
    End Sub

End Class