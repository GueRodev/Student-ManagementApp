Imports System.Data
Imports System.Text.RegularExpressions
Imports Domain
Imports Common

Public Class Panel_Matricular

    ' Inicializar Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Panel_Matricular_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configura el ComboBox con las opciones de carreras y sus respectivos IDs
        Dim carreras As New Dictionary(Of String, Integer) From {
            {"Seleccione una carrera", -1},  ' Opción por defecto
            {"Ingeniería en Sistemas", 2},
            {"Ingeniería Industrial", 1},
            {"Administración de Negocios", 4},
            {"Contaduría", 3}
        }
        cbo_Carreras.DataSource = New BindingSource(carreras, Nothing)
        cbo_Carreras.DisplayMember = "Key"
        cbo_Carreras.ValueMember = "Value"

        ' Configura las columnas del DataGridView
        ConfigurarColumnasDataGridView()
    End Sub

    Private Sub ConfigurarColumnasDataGridView()
        dgv_Matricular.Columns.Clear()
        dgv_Matricular.AutoGenerateColumns = False

        Dim colNombre As New DataGridViewTextBoxColumn()
        colNombre.DataPropertyName = "Nombre"
        colNombre.HeaderText = "Materia"
        dgv_Matricular.Columns.Add(colNombre)

        Dim colCodigo As New DataGridViewTextBoxColumn()
        colCodigo.DataPropertyName = "Codigo"
        colCodigo.HeaderText = "Código"
        dgv_Matricular.Columns.Add(colCodigo)

        Dim colCreditos As New DataGridViewTextBoxColumn()
        colCreditos.DataPropertyName = "Creditos"
        colCreditos.HeaderText = "Créditos"
        dgv_Matricular.Columns.Add(colCreditos)

        Dim colRequisitos As New DataGridViewTextBoxColumn()
        colRequisitos.DataPropertyName = "Requisitos"
        colRequisitos.HeaderText = "Requisitos"
        dgv_Matricular.Columns.Add(colRequisitos)
    End Sub

    Private Sub cbo_Carreras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Carreras.SelectedIndexChanged
        ' Limpia el DataGridView cada vez que cambie la selección en el ComboBox
        dgv_Matricular.DataSource = Nothing

        ' Verificar si hay un elemento seleccionado
        If cbo_Carreras.SelectedItem Is Nothing Then
            Exit Sub
        End If

        ' Obtener el ID de la carrera seleccionada
        Dim carreraSeleccionada As KeyValuePair(Of String, Integer) = DirectCast(cbo_Carreras.SelectedItem, KeyValuePair(Of String, Integer))
        Dim carreraSeleccionadaID As Integer = carreraSeleccionada.Value

        ' Si se selecciona la opción por defecto, no cargar datos
        If carreraSeleccionadaID = -1 Then
            Exit Sub
        End If

        ' Instanciar MatricularModelo
        Dim matricularModelo As New MatricularModelo()

        ' Obtener las materias de la carrera seleccionada
        Dim dtMaterias As DataTable = matricularModelo.Dominio_ObtenerMateriasPorCarrera(carreraSeleccionadaID)

        ' Verifica que haya materias antes de cargarlas en el DataGridView
        If dtMaterias IsNot Nothing AndAlso dtMaterias.Rows.Count > 0 Then
            dgv_Matricular.DataSource = dtMaterias
        End If
    End Sub

    Private Sub btn_Matricular_Click(sender As Object, e As EventArgs) Handles btn_Matricular.Click

        ' Instanciar MatricularModelo
        Dim matricularModelo As New MatricularModelo()

        ' Validar que los campos no estén vacíos
        If Not ValidarCamposNoVacios() Then
            Return ' Cancelar la operación si algún campo está vacío
        End If

        ' Validar que el nombre y el apellido no contengan números enteros y no excedan los 16 caracteres
        If Not EsNombreValido(txtNombre_Matricular.Text) Or Not EsNombreValido(txtApellidos_Matricular.Text) Then
            MessageBox.Show("El nombre y el apellido no pueden contener números y deben tener máximo 16 caracteres.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Cancelar la operación si no se cumple la validación
        End If

        ' Validar el formato del correo electrónico
        If Not EsCorreoValido(txtCorreo_Matricular.Text) Then
            MessageBox.Show("Ingrese un correo electrónico válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Cancelar la operación si no se cumple la validación
        End If

        ' Verificar si el correo ya existe
        If matricularModelo.Dominio_CorreoExiste(txtCorreo_Matricular.Text) Then
            MessageBox.Show("El correo electrónico ya está registrado en el sistema.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCorreo_Matricular.Focus()
            Return ' Cancelar la operación si el correo ya existe
        End If

        ' Verificar si el número de teléfono ya existe
        If matricularModelo.Dominio_TelefonoExiste(txtTelefono_Matricular.Text) Then
            MessageBox.Show("El número de teléfono ya está registrado en el sistema.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTelefono_Matricular.Focus()
            Return ' Cancelar la operación si el teléfono ya existe
        End If

        ' Verificar si el carnet ya existe
        If matricularModelo.Dominio_CarnetExiste(txtCarnet_Matricular.Text) Then
            MessageBox.Show("El carnet ya está registrado en el sistema.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCarnet_Matricular.Focus()
            Return ' Cancelar la operación si el carnet ya existe
        End If

        ' Verificar si la identificación ya existe
        If matricularModelo.Dominio_IdentificacionExiste(txtIdentificacion_Matricular.Text) Then
            MessageBox.Show("La identificación ya está registrada en el sistema.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtIdentificacion_Matricular.Focus()
            Return ' Cancelar la operación si la identificación ya existe
        End If

        ' Validar que la identificación sea válida
        If Not EsIdentificacionValida(txtIdentificacion_Matricular.Text) Then
            MessageBox.Show("La identificación debe ser un número de máximo 10 dígitos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Cancelar la operación si no se cumple la validación
        End If

        ' Validar el teléfono antes de continuar
        If Not ValidarTelefono(txtTelefono_Matricular.Text) Then
            Return ' Cancelar la operación si el teléfono no es válido
        End If

        ' Validar el formato del carnet antes de continuar
        If Not ValidarFormatoCarnet(txtCarnet_Matricular.Text) Then
            Return ' Cancelar la operación si el carnet no tiene el formato correcto
        End If

        ' Validar si el usuario está seguro de matricular al estudiante
        Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de que desea matricular a este estudiante?", "Confirmar Matricula", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmacion = DialogResult.No Then
            Return ' Cancelar la operación si el usuario no está seguro
        End If

        ' Si todas las validaciones son exitosas, proceder con la matriculación
        Dim nombre As String = txtNombre_Matricular.Text
        Dim apellidos As String = txtApellidos_Matricular.Text
        Dim identificacion As String = txtIdentificacion_Matricular.Text
        Dim carnet As String = txtCarnet_Matricular.Text
        Dim correo As String = txtCorreo_Matricular.Text
        Dim telefono As String = txtTelefono_Matricular.Text
        Dim carreraID As Integer = DirectCast(cbo_Carreras.SelectedItem, KeyValuePair(Of String, Integer)).Value
        Dim fechaIngreso As Date = DateTime_Matricular.Value

        ' Llamar al método Dominio_MatricularEstudiante para guardar el nuevo estudiante y sus materias
        Dim matriculaExitosa As Boolean = matricularModelo.Dominio_MatricularEstudiante(nombre, apellidos, identificacion, carnet, correo, telefono, carreraID, fechaIngreso)

        ' Verificar si la matrícula fue exitosa
        If matriculaExitosa Then
            MessageBox.Show("Estudiante matriculado correctamente.")
            ' Limpiar los campos después de matricular al estudiante
            LimpiarCampos()
        Else
            MessageBox.Show("Error al matricular al estudiante. Inténtelo de nuevo.")
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

    Private Function ValidarTelefono(telefono As String) As Boolean
        ' Eliminar espacios en blanco al principio y al final del número de teléfono
        telefono = telefono.Trim()

        ' Verificar que el teléfono solo contenga números
        If Not telefono.All(Function(c) Char.IsDigit(c)) Then
            MessageBox.Show("El campo 'Teléfono' solo puede contener números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTelefono_Matricular.Focus()
            Return False
        End If

        ' Verificar la longitud del teléfono (por ejemplo, entre 8 y 10 dígitos)
        If telefono.Length < 8 OrElse telefono.Length > 10 Then
            MessageBox.Show("El número de teléfono debe tener entre 8 y 10 dígitos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTelefono_Matricular.Focus()
            Return False
        End If

        ' Si el teléfono es válido, devolver True
        Return True
    End Function



    Private Function ValidarFormatoCarnet(carnet As String) As Boolean
        ' Verificar que el carnet tenga exactamente 5 caracteres
        If carnet.Length <> 5 Then
            MessageBox.Show("El carnet debe tener el formato 44-13.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCarnet_Matricular.Focus()
            Return False
        End If

        ' Verificar que los primeros dos caracteres sean números
        If Not Char.IsDigit(carnet(0)) OrElse Not Char.IsDigit(carnet(1)) Then
            MessageBox.Show("El carnet debe empezar con dos números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCarnet_Matricular.Focus()
            Return False
        End If

        ' Verificar que el tercer carácter sea un guion '-'
        If carnet(2) <> "-"c Then
            MessageBox.Show("El tercer carácter del carnet debe ser un guion '-'.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCarnet_Matricular.Focus()
            Return False
        End If

        ' Verificar que los últimos dos caracteres sean números
        If Not Char.IsDigit(carnet(3)) OrElse Not Char.IsDigit(carnet(4)) Then
            MessageBox.Show("El carnet debe terminar con dos números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCarnet_Matricular.Focus()
            Return False
        End If

        ' Si el formato es válido, devolver True
        Return True
    End Function

    Private Function ValidarCamposNoVacios() As Boolean
        ' Verificar que los campos de texto no estén vacíos
        If String.IsNullOrWhiteSpace(txtNombre_Matricular.Text) Then
            MessageBox.Show("El campo 'Nombre' no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNombre_Matricular.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtApellidos_Matricular.Text) Then
            MessageBox.Show("El campo 'Apellidos' no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtApellidos_Matricular.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtIdentificacion_Matricular.Text) Then
            MessageBox.Show("El campo 'Identificación' no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtIdentificacion_Matricular.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtCarnet_Matricular.Text) Then
            MessageBox.Show("El campo 'Carnet' no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCarnet_Matricular.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtCorreo_Matricular.Text) Then
            MessageBox.Show("El campo 'Correo' no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCorreo_Matricular.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtTelefono_Matricular.Text) Then
            MessageBox.Show("El campo 'Teléfono' no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTelefono_Matricular.Focus()
            Return False
        End If

        ' Verificar que se haya seleccionado una carrera válida
        If cbo_Carreras.SelectedIndex = 0 Then
            MessageBox.Show("Debe seleccionar una carrera.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbo_Carreras.Focus()
            Return False
        End If

        ' Si todos los campos son válidos, devolver True
        Return True
    End Function


    Private Sub LimpiarCampos()
        ' Limpiar los campos del formulario de matrícula
        txtNombre_Matricular.Clear()
        txtApellidos_Matricular.Clear()
        txtIdentificacion_Matricular.Clear()
        txtCarnet_Matricular.Clear()
        txtTelefono_Matricular.Clear()

        ' Establecer el índice seleccionado del ComboBox a -1 (ninguna selección)
        If cbo_Carreras.Items.Count > 0 Then
            cbo_Carreras.SelectedIndex = 0 ' Seleccionar "Seleccione una carrera"
        End If

        DateTime_Matricular.Value = DateTime.Now
        dgv_Matricular.DataSource = Nothing
        txtNombre_Matricular.Focus()
    End Sub

    Private Sub btnLimpiar_Matricula_Click(sender As Object, e As EventArgs) Handles btnLimpiar_Matricula.Click
        LimpiarCampos()
    End Sub

End Class

