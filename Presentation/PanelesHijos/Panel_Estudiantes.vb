Imports System.Data
Imports System.Text.RegularExpressions
Imports Domain
Imports Common


Public Class Panel_Estudiantes

    'Inicializar Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Panel_Estudiantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarEstudiantes()
    End Sub

    Private Sub MostrarEstudiantes()
        ' Instanciar EstudianteModelo
        Dim estudianteModelo As New EstudianteModelo()

        ' Obtener los datos de los estudiantes
        Dim dtEstudiantes As New DataTable()
        dtEstudiantes = estudianteModelo.dominio_ObtenerEstudiantes()

        ' Configurar las columnas del DataGridView
        dgv_estudiantes.Columns.Clear() ' Limpiar las columnas existentes
        dgv_estudiantes.AutoGenerateColumns = False ' Deshabilitar la generación automática de columnas

        ' Agregar las columnas necesarias
        Dim colID As New DataGridViewTextBoxColumn()
        colID.DataPropertyName = "ID"
        colID.HeaderText = "ID"
        dgv_estudiantes.Columns.Add(colID)

        Dim colNombre As New DataGridViewTextBoxColumn()
        colNombre.DataPropertyName = "Nombre"
        colNombre.HeaderText = "Nombre"
        dgv_estudiantes.Columns.Add(colNombre)

        Dim colApellidos As New DataGridViewTextBoxColumn()
        colApellidos.DataPropertyName = "Apellidos"
        colApellidos.HeaderText = "Apellidos"
        dgv_estudiantes.Columns.Add(colApellidos)

        Dim colIdentificacion As New DataGridViewTextBoxColumn()
        colIdentificacion.DataPropertyName = "Identificacion"
        colIdentificacion.HeaderText = "Identificación"
        dgv_estudiantes.Columns.Add(colIdentificacion)

        Dim colCorreo As New DataGridViewTextBoxColumn()
        colCorreo.DataPropertyName = "Correo"
        colCorreo.HeaderText = "Correo"
        dgv_estudiantes.Columns.Add(colCorreo)

        Dim colCarrera As New DataGridViewTextBoxColumn()
        colCarrera.DataPropertyName = "Carrera"
        colCarrera.HeaderText = "Carrera"
        dgv_estudiantes.Columns.Add(colCarrera)

        Dim colFechaIngreso As New DataGridViewTextBoxColumn()
        colFechaIngreso.DataPropertyName = "Fecha_Ingreso"
        colFechaIngreso.HeaderText = "Fecha de Ingreso"
        dgv_estudiantes.Columns.Add(colFechaIngreso)

        ' Asignar los datos al DataGridView
        dgv_estudiantes.DataSource = dtEstudiantes
    End Sub
    Private Sub btnGuardarEstudiante_Click(sender As Object, e As EventArgs) Handles btnGuardarEstudiante.Click
        ' Validar si el usuario está seguro de guardar el estudiante
        Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de que desea guardar este estudiante?", "Confirmar Guardar Estudiante", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmacion = DialogResult.No Then
            Return ' Cancelar la operación si el usuario no está seguro
        End If

        ' Obtener los datos del estudiante desde los campos del formulario
        Dim nombre As String = txtNombreEstudiante.Text
        Dim apellidos As String = txtApellidosEstudiante.Text
        Dim identificacion As String = txtIdentificacionEstudiante.Text
        Dim correo As String = txtCorreoEstudiante.Text
        Dim carrera As String = txtCarreraEstudiante.Text


        ' Validar que el nombre y el apellido no contengan números enteros y no excedan los 16 caracteres
        If Not EsNombreValido(nombre) Or Not EsNombreValido(apellidos) Then
            MessageBox.Show("El nombre y el apellido no pueden contener números enteros y deben tener máximo 16 caracteres.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Cancelar la operación si no se cumple la validación
        End If

        ' Validar el formato del correo electrónico
        If Not EsCorreoValido(correo) Then
            MessageBox.Show("Ingrese un correo electrónico válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Cancelar la operación si no se cumple la validación
        End If

        ' Validar que la identificación sea válida
        If Not EsIdentificacionValida(identificacion) Then
            MessageBox.Show("La identificación debe ser un número entero de máximo 10 dígitos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Cancelar la operación si no se cumple la validación
        End If

        ' Validar que el campo de carrera no esté vacío y cumpla con los requisitos de longitud y contenido
        If String.IsNullOrWhiteSpace(carrera) OrElse carrera.Length > 30 OrElse Not EsNombreValido(carrera) Then
            MessageBox.Show("Ingrese Datos Validos para la carrera.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Cancelar la operación si no se cumple la validación
        End If

        ' Convertir el campo de fecha de ingreso a tipo Date
        Dim fechaIngreso As Date
        If Not String.IsNullOrEmpty(txtFechaEstudiante.Text) Then
            If Date.TryParse(txtFechaEstudiante.Text, fechaIngreso) Then
                ' La conversión fue exitosa, la fecha se asignó correctamente
            Else
                MessageBox.Show("Ingrese una fecha de ingreso válida en formato dd/MM/yyyy.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Cancelar la operación si no se cumple la validación
            End If
        Else
            MessageBox.Show("El campo de fecha de ingreso no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Cancelar la operación si no se cumple la validación
        End If
        ' Instanciar EstudianteModelo
        Dim estudianteModelo As New EstudianteModelo()

        ' Llamar al método Dominio_InsertarEstudiante para guardar el nuevo estudiante
        Dim insercionExitosa As Boolean = estudianteModelo.dominio_InsertarEstudiante(nombre, apellidos, identificacion, correo, carrera, fechaIngreso)

        ' Verificar si la inserción fue exitosa
        If insercionExitosa Then
            MessageBox.Show("Estudiante guardado correctamente.")
            ' Recargar los datos del DataGridView para reflejar los cambios en tiempo real
            CargarDatosEstudiantes()
            ' Limpiar los campos después de guardar el estudiante
            LimpiarCampos()
        Else
            MessageBox.Show("Error al guardar el estudiante. Inténtelo de nuevo.")
        End If
    End Sub

    Private Function EsNombreValido(nombre As String) As Boolean
        ' Validar que el nombre no contenga números enteros y no exceda los 16 caracteres
        Return Not nombre.Any(Function(c) Char.IsDigit(c)) AndAlso nombre.Length <= 16
    End Function

    Private Function EsCorreoValido(correo As String) As Boolean
        ' Validar el formato del correo electrónico
        Return correo.Contains("@") AndAlso correo.EndsWith(".com")
    End Function

    Private Function EsIdentificacionValida(identificacion As String) As Boolean
        ' Validar que la identificación tenga máximo 10 dígitos enteros y solo contenga números enteros
        Dim esNumerico As Boolean = Integer.TryParse(identificacion, Nothing)
        Return esNumerico AndAlso identificacion.Length <= 10
    End Function


    Private Sub LimpiarCampos()
        ' Limpiar los campos del formulario
        txtNombreEstudiante.Clear()
        txtApellidosEstudiante.Clear()
        txtIdentificacionEstudiante.Clear()
        txtCorreoEstudiante.Clear()
        txtCarreraEstudiante.Clear()
        txtFechaEstudiante.Clear()
        txtNombreEstudiante.Focus()
    End Sub

    Private Sub dgv_estudiantes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_estudiantes.CellClick
        ' Verificar si la celda seleccionada no es el encabezado de la fila
        If e.RowIndex >= 0 Then
            ' Obtener los valores de la fila seleccionada y mostrarlos en los campos de texto
            Dim selectedRow As DataGridViewRow = dgv_estudiantes.Rows(e.RowIndex)
            txt_ID_Estudiante.Text = selectedRow.Cells(0).Value.ToString()
            txtNombreEstudiante.Text = selectedRow.Cells(1).Value.ToString()
            txtApellidosEstudiante.Text = selectedRow.Cells(2).Value.ToString()
            txtIdentificacionEstudiante.Text = selectedRow.Cells(3).Value.ToString()
            txtCorreoEstudiante.Text = selectedRow.Cells(4).Value.ToString()
            txtCarreraEstudiante.Text = selectedRow.Cells(5).Value.ToString()
            txtFechaEstudiante.Text = selectedRow.Cells(6).Value.ToString()
        End If
    End Sub


    Private Sub btnEditarEstudiante_Click(sender As Object, e As EventArgs) Handles btnEditarEstudiante.Click
        ' Obtener el ID del estudiante seleccionado en el DataGridView
        Dim idEstudiante As Integer
        If Integer.TryParse(txt_ID_Estudiante.Text, idEstudiante) AndAlso idEstudiante > 0 Then
            ' Obtener los datos del estudiante desde los campos del formulario
            Dim nombre As String = txtNombreEstudiante.Text
            Dim apellidos As String = txtApellidosEstudiante.Text
            Dim identificacion As String = txtIdentificacionEstudiante.Text
            Dim correo As String = txtCorreoEstudiante.Text
            Dim carrera As String = txtCarreraEstudiante.Text


            ' Validar que los campos no estén vacíos
            If String.IsNullOrWhiteSpace(nombre) OrElse String.IsNullOrWhiteSpace(apellidos) OrElse String.IsNullOrWhiteSpace(identificacion) OrElse String.IsNullOrWhiteSpace(correo) OrElse String.IsNullOrWhiteSpace(carrera) Then
                MessageBox.Show("Por favor, complete todos los campos.")
                Return
            End If

            ' Validar que la identificación sea válida
            If Not EsIdentificacionValida(identificacion) Then
                MessageBox.Show("La identificación debe ser un número entero de máximo 10 dígitos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Validar que el nombre y el apellido no contengan números enteros y no excedan los 16 caracteres
            If Not EsNombreValido(nombre) Or Not EsNombreValido(apellidos) Then
                MessageBox.Show("El nombre y el apellido no pueden contener números enteros y deben tener máximo 16 caracteres.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Validar el formato del correo electrónico
            If Not EsCorreoValido(correo) Then
                MessageBox.Show("Ingrese un correo electrónico válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Validar que el campo de carrera no esté vacío y cumpla con los requisitos de longitud y contenido
            If String.IsNullOrWhiteSpace(carrera) OrElse carrera.Length > 30 OrElse Not EsNombreValido(carrera) Then
                MessageBox.Show("Ingrese Datos Validos para la carrera.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Cancelar la operación si no se cumple la validación
            End If

            ' Convertir el campo de fecha de ingreso a tipo Date
            Dim fechaIngreso As Date
            If Not String.IsNullOrEmpty(txtFechaEstudiante.Text) Then
                If Date.TryParse(txtFechaEstudiante.Text, fechaIngreso) Then
                    ' La conversión fue exitosa, la fecha se asignó correctamente
                Else
                    MessageBox.Show("Ingrese una fecha de ingreso válida en formato dd/MM/yyyy.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return ' Cancelar la operación si no se cumple la validación
                End If
            Else
                MessageBox.Show("El campo de fecha de ingreso no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Cancelar la operación si no se cumple la validación
            End If

            ' Instanciar EstudianteModelo
            Dim estudianteModelo As New EstudianteModelo()

            ' Llamar al método dominio_ActualizarEstudiante para actualizar los datos del estudiante
            Dim actualizacionExitosa As Boolean = estudianteModelo.dominio_ActualizarEstudiante(idEstudiante, nombre, apellidos, identificacion, correo, carrera, fechaIngreso)

            ' Verificar si la actualización fue exitosa
            If actualizacionExitosa Then
                MessageBox.Show("Estudiante actualizado correctamente.")

                ' Recargar los datos del DataGridView para reflejar los cambios en tiempo real
                CargarDatosEstudiantes()

                ' Limpiar los campos después de actualizar el estudiante
                LimpiarCampos()
            Else
                MessageBox.Show("Error al actualizar el estudiante. Inténtelo de nuevo.")
            End If
        Else
            MessageBox.Show("Por favor, seleccione un estudiante de la lista para editar.")
        End If
    End Sub

    Private Sub btnEliminarEstudiante_Click(sender As Object, e As EventArgs) Handles btnEliminarEstudiante.Click
        ' Obtener el ID del estudiante seleccionado en el DataGridView
        Dim idEstudiante As Integer
        If Integer.TryParse(txt_ID_Estudiante.Text, idEstudiante) AndAlso idEstudiante > 0 Then
            ' Mostrar un cuadro de diálogo de confirmación
            Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este estudiante?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Verificar si se confirmó la eliminación
            If respuesta = DialogResult.Yes Then
                ' Instanciar EstudianteModelo
                Dim estudianteModelo As New EstudianteModelo()

                ' Llamar al método dominio_EliminarEstudiante para eliminar el estudiante
                Dim eliminacionExitosa As Boolean = estudianteModelo.dominio_EliminarEstudiante(idEstudiante)

                ' Verificar si la eliminación fue exitosa
                If eliminacionExitosa Then
                    MessageBox.Show("Estudiante eliminado correctamente.")

                    ' Recargar los datos del DataGridView para reflejar los cambios en tiempo real
                    CargarDatosEstudiantes()

                    ' Limpiar los campos después de eliminar el estudiante
                    LimpiarCampos()
                Else
                    MessageBox.Show("Error al eliminar el estudiante. Inténtelo de nuevo.")
                End If
            End If
        Else
            MessageBox.Show("Por favor, seleccione un estudiante de la lista para eliminar.")
        End If
    End Sub

    Private Sub CargarDatosEstudiantes()
        ' Obtener los datos actualizados de los estudiantes y cargarlos en el DataGridView
        Dim estudianteModelo As New EstudianteModelo()
        Dim dtEstudiantes As DataTable = estudianteModelo.dominio_ObtenerEstudiantes()
        dgv_estudiantes.DataSource = dtEstudiantes
    End Sub

End Class
