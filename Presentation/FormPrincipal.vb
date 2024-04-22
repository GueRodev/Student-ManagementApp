Imports System.ComponentModel.Design
Imports System.Runtime.InteropServices
Imports Common

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
        Me.StartPosition = FormStartPosition.CenterScreen
        AjustarFormulario()

        lbl_Usuario.Text = ActiveUser.Usuario
        lbl_Rol.Text = ActiveUser.Rol

        'Instanciar
        Dim panelInicio As New Panel_Inicio()
        ' Llamar al método AddUserControl para mostrar el control Panel_Inicio
        AddUserControl(panelInicio)


    End Sub

    'Ajustar el formulario con la barra de tareas 
    Private Sub AjustarFormulario()
        Dim workingArea As Rectangle = Screen.GetWorkingArea(Me)
        Me.MaximumSize = New Size(workingArea.Width, workingArea.Height)
        Me.Size = New Size(835, 459) 'ajustar tamano original
        Me.Location = New Point(workingArea.X + (workingArea.Width - Me.Width) \ 2, workingArea.Y + (workingArea.Height - Me.Height) \ 2)
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        Me.WindowState = FormWindowState.Maximized
        AjustarFormulario()
        btnMaximizar.Visible = False ' Si la ventana está maximizada, oculta el botón de maximizar
        btnRestaurar.Visible = True  ' Muestra el símbolo restaurar
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.WindowState = FormWindowState.Normal
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

    'Menu lateral
    Private Sub tmrMostrarMenu_Tick(sender As Object, e As EventArgs) Handles tmrMostrarMenu.Tick
        If PanelMenu.Width >= 110 Then
            Me.tmrMostrarMenu.Enabled = False
        Else
            Me.PanelMenu.Width += 20 ' Aumentar el ancho del panel en 20 unidades
        End If
    End Sub

    Private Sub tmrOcultarMenu_Tick(sender As Object, e As EventArgs) Handles tmrOcultarMenu.Tick
        If PanelMenu.Width <= 40 Then
            Me.tmrOcultarMenu.Enabled = False
        Else
            Me.PanelMenu.Width -= 20 ' Reducir el ancho del panel en 20 unidades
        End If
    End Sub

    Private Sub btnMenuBar_Click(sender As Object, e As EventArgs) Handles btnMenuBar.Click
        If PanelMenu.Width = 40 Then
            tmrMostrarMenu.Enabled = True ' Si el ancho del panel es 40, comenzar a mostrarlo
        ElseIf PanelMenu.Width = 110 Then
            tmrOcultarMenu.Enabled = True ' Si el ancho del panel es 122, comenzar a ocultarlo
        Else
            tmrOcultarMenu.Enabled = True
        End If
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("Esta seguro que desea Cerrar Sesion?", "Cerrar Sesion",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub

    Private Sub btnApagar_Click(sender As Object, e As EventArgs) Handles btnApagar.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("Esta seguro que desea salir?", "Salir del programa",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then
            End
        End If
    End Sub

    Private Sub AddUserControl(ByVal userControl As UserControl)
        ' Crear una lista para almacenar los controles que se mantendrán
        Dim controlesMantener As New List(Of Control)

        ' Iterar a través de los controles en panelContainer
        For Each ctrl As Control In panelContainer.Controls
            ' Verificar si el control es el PanelMenu o el PanelAbajo y agregarlos a la lista de controles a mantener
            If ctrl.Name = "PanelMenu" OrElse ctrl.Name = "PanelAbajo" Then
                controlesMantener.Add(ctrl)
            End If
        Next

        ' Limpiar los controles en panelContainer, excluyendo los controles que se mantendrán
        For Each ctrl As Control In panelContainer.Controls
            If Not controlesMantener.Contains(ctrl) Then
                ctrl.Dispose() ' Dispose() elimina el control del formulario
            End If
        Next

        ' Establecer el dock y agregar el nuevo control
        userControl.Dock = DockStyle.Fill
        panelContainer.Controls.Add(userControl)
        PanelMenu.Visible = True

    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs)
        'Instanciar
        Dim panelInicio As New Panel_Inicio()
        ' Llamar al método AddUserControl para mostrar el control Panel_Inicio
        AddUserControl(panelInicio)
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click

        Dim panelUsuarios As New Panel_Usuarios()
        ' Llamar al método AddUserControl para mostrar el control Panel_Usuarios
        AddUserControl(panelUsuarios)
    End Sub

    Private Sub btnEstudiantes_Click(sender As Object, e As EventArgs) Handles btnEstudiantes.Click
        Dim panelEstudiantes As New Panel_Estudiantes()
        ' Llamar al método AddUserControl para mostrar el control Panel_Estudiantes
        AddUserControl(panelEstudiantes)
    End Sub

    Private Sub btnMaterias_Click(sender As Object, e As EventArgs) Handles btnMaterias.Click
        Dim panelMaterias As New Panel_Materias()
        ' Llamar al método AddUserControl para mostrar el control Panel_Materias
        AddUserControl(panelMaterias)
    End Sub

    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        'Instanciar
        Dim panelAsignar As New Panel_Asignar()
        ' Llamar al método AddUserControl para mostrar el control Panel_Materias
        AddUserControl(panelAsignar)
    End Sub

    Private Sub btnEstados_Click(sender As Object, e As EventArgs) Handles btnEstados.Click

        'Instanciar
        Dim panelEstados As New Panel_Estados()
        ' Llamar al método AddUserControl para mostrar el control Panel_Materias
        AddUserControl(panelEstados)

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        'Instanciar
        Dim panelInicio As New Panel_Inicio()
        ' Llamar al método AddUserControl para mostrar el control Panel_Inicio
        AddUserControl(panelInicio)
    End Sub


End Class