Public Class FormPrincipal
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("Esta seguro que desea salir?", "Salir del programa",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then
            End
        End If
    End Sub

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AjustarFormulario()
        RestaurarTamanoNormal()
    End Sub


    'Ajustar el formulario con la barra de tareas 
    Private Sub AjustarFormulario()
        Dim workingArea As Rectangle = Screen.GetWorkingArea(Me)
        Me.MaximumSize = New Size(workingArea.Width, workingArea.Height)
        Me.Location = New Point(workingArea.X, workingArea.Y)
        Me.Size = New Size(workingArea.Width, workingArea.Height)
    End Sub 

    Private Sub RestaurarTamanoNormal()
        Me.Size = New Size(835, 459) ' Restaurar el formulario al tamaño especificado en las propiedades
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        Me.WindowState = FormWindowState.Maximized

        AjustarFormulario()
        btnMaximizar.Visible = False ' Si la ventana está maximizada, oculta el botón de maximizar
        btnRestaurar.Visible = True  ' Muestra el símbolo restaurar
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.WindowState = FormWindowState.Normal

        RestaurarTamanoNormal() ' Restaurar el formulario al tamaño especificado
        btnMaximizar.Visible = True ' Si la ventana no está maximizada, muestra el botón de maximizar
        btnRestaurar.Visible = False  ' Oculta el botón de restaurar
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
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

End Class