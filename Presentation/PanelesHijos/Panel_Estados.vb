
Imports System.Data
Imports System.Text.RegularExpressions
Imports Domain
Imports Common

Public Class Panel_Estados

    ' Inicializar Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Panel_Estados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar estudiantes con sus carreras al iniciar el formulario
        CargarEstudiantesConCarrera()

        ' Ocultar el Label de porcentaje al iniciar
        lbl_Porcentaje_Aprobado.Visible = False
    End Sub

    ' Método para cargar la lista de estudiantes con sus carreras
    Private Sub CargarEstudiantesConCarrera()
        Dim asignarModelo As New AsignarModelo()
        Dim dtEstudiantes As DataTable = asignarModelo.Dominio_ObtenerEstudiantesConCarrera()

        If dtEstudiantes IsNot Nothing AndAlso dtEstudiantes.Rows.Count > 0 Then
            dgv_EstudiantesMaterias.DataSource = dtEstudiantes
            ConfigurarColumnasDataGridViewEstudiantes()
        End If
    End Sub

    ' Método para configurar las columnas del DataGridView de estudiantes
    Private Sub ConfigurarColumnasDataGridViewEstudiantes()
        dgv_EstudiantesMaterias.Columns.Clear()
        dgv_EstudiantesMaterias.AutoGenerateColumns = False

        Dim colIdentificacion As New DataGridViewTextBoxColumn()
        colIdentificacion.DataPropertyName = "Identificacion"
        colIdentificacion.HeaderText = "Identificación"
        colIdentificacion.Name = "Identificacion"
        dgv_EstudiantesMaterias.Columns.Add(colIdentificacion)

        Dim colNombre As New DataGridViewTextBoxColumn()
        colNombre.DataPropertyName = "Nombre"
        colNombre.HeaderText = "Nombre"
        colNombre.Name = "Nombre"
        dgv_EstudiantesMaterias.Columns.Add(colNombre)

        Dim colApellidos As New DataGridViewTextBoxColumn()
        colApellidos.DataPropertyName = "Apellidos"
        colApellidos.HeaderText = "Apellidos"
        colApellidos.Name = "Apellidos"
        dgv_EstudiantesMaterias.Columns.Add(colApellidos)

        Dim colCarrera As New DataGridViewTextBoxColumn()
        colCarrera.DataPropertyName = "Carrera"
        colCarrera.HeaderText = "Carrera"
        colCarrera.Name = "Carrera"
        dgv_EstudiantesMaterias.Columns.Add(colCarrera)
    End Sub

    ' Evento Click del botón de búsqueda
    Private Sub btnBuscarIdentificacion_Click(sender As Object, e As EventArgs) Handles btnBuscarIdentificacion.Click
        ' Obtener la identificación del TextBox
        Dim identificacion As String = txt_Buscar_Identificacion.Text.Trim()

        ' Verificar que la identificación no esté vacía
        If String.IsNullOrEmpty(identificacion) Then
            MessageBox.Show("Por favor, ingrese una identificación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Cargar los estados de las materias para el estudiante con la identificación proporcionada
        CargarEstadosMateriasPorIdentificacion(identificacion)

        ' Calcular y mostrar el porcentaje de carrera aprobada
        CalcularYMostrarPorcentajeAprobado()
    End Sub

    ' Método para cargar las materias del estudiante, agrupadas por estado
    Private Sub CargarEstadosMateriasPorIdentificacion(identificacion As String)
        Dim estadosModelo As New EstadosModelo()

        ' Crear un nuevo DataTable para organizar los datos
        Dim dtEstados As New DataTable()
        dtEstados.Columns.Add("Aprobadas", GetType(String))
        dtEstados.Columns.Add("Pendientes", GetType(String))
        dtEstados.Columns.Add("Matriculadas", GetType(String))

        ' Obtener materias Aprobadas
        Dim dtAprobadas As DataTable = estadosModelo.ObtenerMateriasPorEstudianteYEstado(identificacion, 2) ' EstadoID = 2 para Aprobadas

        ' Obtener materias Pendientes
        Dim dtPendientes As DataTable = estadosModelo.ObtenerMateriasPorEstudianteYEstado(identificacion, 3) ' EstadoID = 3 para Pendientes

        ' Obtener materias Matriculadas
        Dim dtMatriculadas As DataTable = estadosModelo.ObtenerMateriasPorEstudianteYEstado(identificacion, 1) ' EstadoID = 1 para Matriculadas

        ' Encontrar el máximo número de filas entre los tres DataTables
        Dim maxRows As Integer = Math.Max(dtAprobadas.Rows.Count, Math.Max(dtPendientes.Rows.Count, dtMatriculadas.Rows.Count))

        ' Rellenar el DataTable con los datos
        For i As Integer = 0 To maxRows - 1
            Dim newRow As DataRow = dtEstados.NewRow()

            If i < dtAprobadas.Rows.Count Then
                newRow("Aprobadas") = dtAprobadas.Rows(i)("Materia").ToString()
            End If

            If i < dtPendientes.Rows.Count Then
                newRow("Pendientes") = dtPendientes.Rows(i)("Materia").ToString()
            End If

            If i < dtMatriculadas.Rows.Count Then
                newRow("Matriculadas") = dtMatriculadas.Rows(i)("Materia").ToString()
            End If

            dtEstados.Rows.Add(newRow)
        Next

        ' Configurar el DataGridView antes de asignar el DataTable
        dgv_Estudiantes_Estados.AutoGenerateColumns = False
        ConfigurarColumnasDataGridViewMaterias() ' Configurar las columnas manualmente

        ' Asignar el DataTable al DataGridView
        dgv_Estudiantes_Estados.DataSource = dtEstados

        ' Forzar la ocultación de cualquier columna adicional no deseada
        For Each column As DataGridViewColumn In dgv_Estudiantes_Estados.Columns
            If column.Name <> "Aprobadas" AndAlso column.Name <> "Pendientes" AndAlso column.Name <> "Matriculadas" Then
                column.Visible = False
            End If
        Next
    End Sub

    Private Sub CalcularYMostrarPorcentajeAprobado()
        Dim estadosModelo As New EstadosModelo()
        Dim identificacion As String = txt_Buscar_Identificacion.Text.Trim()
        Dim carrera As String = dgv_EstudiantesMaterias.CurrentRow.Cells("Carrera").Value.ToString()

        Dim porcentajeAprobado As Double = estadosModelo.CalcularPorcentajeCarreraAprobada(identificacion, carrera)

        ' Mostrar el porcentaje en el Label
        lbl_Porcentaje_Aprobado.Text = "Porcentaje de carrera aprobado: " & porcentajeAprobado.ToString("F2") & " %"
        lbl_Porcentaje_Aprobado.Visible = True
    End Sub


    ' Método para configurar las columnas del DataGridView de estados
    Private Sub ConfigurarColumnasDataGridViewMaterias()
        dgv_Estudiantes_Estados.Columns.Clear()
        dgv_Estudiantes_Estados.AutoGenerateColumns = False

        ' Columna Aprobadas
        Dim colAprobadas As New DataGridViewTextBoxColumn()
        colAprobadas.DataPropertyName = "Aprobadas"
        colAprobadas.HeaderText = "Aprobadas"
        colAprobadas.Name = "Aprobadas"
        dgv_Estudiantes_Estados.Columns.Add(colAprobadas)

        ' Columna Pendientes
        Dim colPendientes As New DataGridViewTextBoxColumn()
        colPendientes.DataPropertyName = "Pendientes"
        colPendientes.HeaderText = "Pendientes"
        colPendientes.Name = "Pendientes"
        dgv_Estudiantes_Estados.Columns.Add(colPendientes)

        ' Columna Matriculadas
        Dim colMatriculadas As New DataGridViewTextBoxColumn()
        colMatriculadas.DataPropertyName = "Matriculadas"
        colMatriculadas.HeaderText = "Matriculadas"
        colMatriculadas.Name = "Matriculadas"
        dgv_Estudiantes_Estados.Columns.Add(colMatriculadas)
    End Sub
End Class