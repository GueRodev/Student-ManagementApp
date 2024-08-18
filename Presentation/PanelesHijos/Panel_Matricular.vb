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
        ' Validar si el usuario está seguro de matricular al estudiante
        Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de que desea matricular a este estudiante?", "Confirmar Matricula", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmacion = DialogResult.No Then
            Return ' Cancelar la operación si el usuario no está seguro
        End If

        ' Obtener los datos del estudiante desde los campos del formulario
        Dim nombre As String = txtNombre_Matricular.Text
        Dim apellidos As String = txtApellidos_Matricular.Text
        Dim identificacion As String = txtIdentificacion_Matricular.Text
        Dim carnet As String = txtCarnet_Matricular.Text
        Dim correo As String = txtCorreo_Matricular.Text
        Dim telefono As String = txtTelefono_Matricular.Text
        Dim carreraID As Integer = DirectCast(cbo_Carreras.SelectedItem, KeyValuePair(Of String, Integer)).Value
        Dim fechaIngreso As Date = DateTime_Matricular.Value

        ' Instanciar MatricularModelo
        Dim matricularModelo As New MatricularModelo()

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

