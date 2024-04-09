Public Class Form1
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
    Private Sub Panel_InicioSesion_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_InicioSesion.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            startPoint = New Point(e.X, e.Y)
        End If
    End Sub

    ' Evento MouseMove del panel de título
    Private Sub Panel_InicioSesion_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_InicioSesion.MouseMove
        If isDragging Then
            Dim p As Point = Me.PointToScreen(New Point(e.X, e.Y))
            Me.Location = New Point(p.X - Me.startPoint.X, p.Y - Me.startPoint.Y)
        End If
    End Sub

    ' Evento MouseUp del panel de título
    Private Sub Panel_InicioSesion_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel_InicioSesion.MouseUp
        If e.Button = MouseButtons.Left Then
            isDragging = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class