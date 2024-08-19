Imports System.Data
Imports Domain
Imports Common

Public Class Panel_Asignar

    ' Inicializar Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Panel_Asignar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar estudiantes con sus carreras
        CargarEstudiantesConCarrera()
    End Sub

    Private Sub CargarEstudiantesConCarrera()
        Dim asignarModelo As New AsignarModelo()
        Dim dtEstudiantes As DataTable = asignarModelo.Dominio_ObtenerEstudiantesConCarrera()

        If dtEstudiantes IsNot Nothing AndAlso dtEstudiantes.Rows.Count > 0 Then
            dgv_EstudiantesMaterias.DataSource = dtEstudiantes
            ConfigurarColumnasDataGridViewEstudiantes()
        End If
    End Sub

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

    ' Evento que se dispara cuando se hace clic en una celda del DataGridView
    Private Sub dgv_EstudiantesMaterias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_EstudiantesMaterias.CellClick
        ' Verificar que la fila seleccionada es válida
        If e.RowIndex >= 0 Then
            ' Obtener la identificación del estudiante seleccionado
            Dim identificacion As String = dgv_EstudiantesMaterias.Rows(e.RowIndex).Cells("Identificacion").Value.ToString()

            ' Cargar las materias asociadas a ese estudiante
            CargarMateriasPorEstudiante(identificacion)
        End If
    End Sub

    ' Método para cargar las materias del estudiante seleccionado
    Private Sub CargarMateriasPorEstudiante(identificacion As String)
        Dim asignarModelo As New AsignarModelo()
        Dim dtMaterias As DataTable = asignarModelo.ObtenerMateriasPorEstudiante(identificacion)

        If dtMaterias IsNot Nothing AndAlso dtMaterias.Rows.Count > 0 Then
            ' Asigna el DataTable al DataGridView u otro control donde mostrar las materias
            dgv_Materias.DataSource = dtMaterias
            ConfigurarColumnasDataGridViewMaterias()
        Else
            dgv_Materias.DataSource = Nothing
        End If
    End Sub

    Private Sub ConfigurarColumnasDataGridViewMaterias()
        dgv_Materias.Columns.Clear()
        dgv_Materias.AutoGenerateColumns = False

        Dim colMateria As New DataGridViewTextBoxColumn()
        colMateria.DataPropertyName = "Materia"
        colMateria.HeaderText = "Materia"
        colMateria.Name = "Materia"
        dgv_Materias.Columns.Add(colMateria)

        Dim colEstado As New DataGridViewTextBoxColumn()
        colEstado.DataPropertyName = "Estado"
        colEstado.HeaderText = "Estado"
        colEstado.Name = "Estado"
        dgv_Materias.Columns.Add(colEstado)

        Dim colNota As New DataGridViewTextBoxColumn()
        colNota.DataPropertyName = "Nota"
        colNota.HeaderText = "Nota"
        colNota.Name = "Nota"
        dgv_Materias.Columns.Add(colNota)
    End Sub
End Class
