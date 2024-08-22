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

        ' Columna EstudianteId (oculta)
        Dim colEstudianteId As New DataGridViewTextBoxColumn()
        colEstudianteId.DataPropertyName = "EstudianteId"
        colEstudianteId.HeaderText = "EstudianteId"
        colEstudianteId.Name = "EstudianteId"
        dgv_Materias.Columns.Add(colEstudianteId)

        ' Columna MateriaId (oculta)
        Dim colMateriaId As New DataGridViewTextBoxColumn()
        colMateriaId.DataPropertyName = "MateriaId"
        colMateriaId.HeaderText = "MateriaId"
        colMateriaId.Name = "MateriaId"
        dgv_Materias.Columns.Add(colMateriaId)

        ' Columna Materia
        Dim colMateria As New DataGridViewTextBoxColumn()
        colMateria.DataPropertyName = "Materia"
        colMateria.HeaderText = "Materia"
        colMateria.Name = "Materia"
        dgv_Materias.Columns.Add(colMateria)

        ' Columna Estado
        Dim colEstado As New DataGridViewTextBoxColumn()
        colEstado.DataPropertyName = "Estado"
        colEstado.HeaderText = "Estado"
        colEstado.Name = "Estado"
        dgv_Materias.Columns.Add(colEstado)

        ' Columna Nota
        Dim colNota As New DataGridViewTextBoxColumn()
        colNota.DataPropertyName = "Nota"
        colNota.HeaderText = "Nota"
        colNota.Name = "Nota"
        dgv_Materias.Columns.Add(colNota)

        ' Forzar la ocultación de las columnas EstudianteId y MateriaId
        dgv_Materias.Columns("EstudianteId").Visible = False
        dgv_Materias.Columns("MateriaId").Visible = False
    End Sub



    'Obtener los valores de los DGV
    Private Sub dgv_Materias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Materias.CellClick
        ' Verificar que se ha hecho clic en una fila válida
        If e.RowIndex >= 0 Then
            ' Obtener la fila seleccionada
            Dim selectedRow As DataGridViewRow = dgv_Materias.Rows(e.RowIndex)

            ' Asignar los valores de las celdas a los TextBox correspondientes
            txt_Materia.Text = selectedRow.Cells("Materia").Value.ToString()
            txt_Estado.Text = selectedRow.Cells("Estado").Value.ToString()
            txt_Nota.Text = selectedRow.Cells("Nota").Value.ToString()
        End If
    End Sub

    Private Sub btn_Asignar_Estado_Nota_Click(sender As Object, e As EventArgs) Handles btn_Asignar_Estado_Nota.Click
        Try
            ' Obtener los valores de los TextBox
            Dim materiaId As Integer = CInt(dgv_Materias.CurrentRow.Cells("MateriaId").Value) ' Asumiendo que tienes el ID de la materia en una columna oculta o visible
            Dim estudianteId As Integer = CInt(dgv_Materias.CurrentRow.Cells("EstudianteId").Value) ' Asumiendo que tienes el ID del estudiante en una columna oculta o visible
            Dim estadoId As Integer = ObtenerEstadoId(txt_Estado.Text) ' Método que convierte el texto en el ID correspondiente
            Dim nota As Integer = CInt(txt_Nota.Text)

            ' Llamar al método de la capa de dominio para actualizar los datos
            Dim asignarModelo As New AsignarModelo()
            If asignarModelo.EditarEstadoYNota(estudianteId, materiaId, estadoId, nota) Then
                MessageBox.Show("Los datos se han actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Aquí puedes agregar código para refrescar el DataGridView si es necesario
                ' Volver a cargar las materias del estudiante seleccionado
                CargarMateriasPorEstudiante(dgv_EstudiantesMaterias.CurrentRow.Cells("Identificacion").Value.ToString())
            Else
                MessageBox.Show("No se pudo actualizar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Método auxiliar para convertir el texto del estado en su correspondiente ID
    Private Function ObtenerEstadoId(estado As String) As Integer
        Select Case estado
            Case "Matriculada"
                Return 1
            Case "Aprobada"
                Return 2
            Case "Pendiente"
                Return 3
            Case Else
                Throw New ArgumentException("Estado no válido.")
        End Select
    End Function



    'txt_Materia
    'txt_Estado
    'txt_Nota

    'btn_Asignar_Estado_Nota



End Class