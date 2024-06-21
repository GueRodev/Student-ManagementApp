Imports System.Data
Imports System.Text.RegularExpressions
Imports Domain
Imports Common

Public Class Panel_Asignar

    ' Inicializar Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Panel_Asignar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarEstudiantes()
        MostrarMaterias()
    End Sub

    Private Sub MostrarEstudiantes()
        ' Instanciar EstudianteModelo
        Dim estudianteModelo As New EstudianteModelo()

        ' Obtener los datos de los estudiantes
        Dim dtEstudiantes As New DataTable()
        dtEstudiantes = estudianteModelo.dominio_ObtenerEstudiantes()

        ' Configurar las columnas del DataGridView
        dgv_AsignarEstudiante.Columns.Clear() ' Limpiar las columnas existentes
        dgv_AsignarEstudiante.AutoGenerateColumns = False ' Deshabilitar la generación automática de columnas

        ' Agregar las columnas necesarias
        Dim colID As New DataGridViewTextBoxColumn()
        colID.DataPropertyName = "ID"
        colID.HeaderText = "ID"
        dgv_AsignarEstudiante.Columns.Add(colID)

        Dim colNombre As New DataGridViewTextBoxColumn()
        colNombre.DataPropertyName = "Nombre"
        colNombre.HeaderText = "Nombre"
        dgv_AsignarEstudiante.Columns.Add(colNombre)

        dgv_AsignarEstudiante.DataSource = dtEstudiantes
    End Sub

    Private Sub MostrarMaterias()
        ' Instanciar MateriaModelo
        Dim materiaModelo As New MateriaModelo()

        ' Obtener los datos de las materias
        Dim dtMaterias As New DataTable()
        dtMaterias = materiaModelo.Dominio_ObtenerMaterias()

        ' Configurar las columnas del DataGridView
        dgv_AsignarMateria.Columns.Clear() ' Limpiar las columnas existentes
        dgv_AsignarMateria.AutoGenerateColumns = False ' Deshabilitar la generación automática de columnas

        ' Agregar las columnas necesarias
        Dim colID As New DataGridViewTextBoxColumn()
        colID.DataPropertyName = "ID"
        colID.HeaderText = "ID"
        dgv_AsignarMateria.Columns.Add(colID)

        Dim colNombre As New DataGridViewTextBoxColumn()
        colNombre.DataPropertyName = "Nombre"
        colNombre.HeaderText = "Nombre"
        dgv_AsignarMateria.Columns.Add(colNombre)

        ' Asignar los datos al DataGridView
        dgv_AsignarMateria.DataSource = dtMaterias
    End Sub

    Private Sub dgv_AsignarEstudiante_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_AsignarEstudiante.CellClick
        ' Verificar si la celda seleccionada no es el encabezado de la fila
        If e.RowIndex >= 0 Then
            ' Obtener los valores de la fila seleccionada y mostrarlos en los campos de texto
            Dim selectedRow As DataGridViewRow = dgv_AsignarEstudiante.Rows(e.RowIndex)

            ' Verificar si la celda contiene un valor válido antes de asignarlo
            If Not IsDBNull(selectedRow.Cells(0).Value) Then
                lbl_IDEstudiante.Text = selectedRow.Cells(0).Value.ToString()
            Else
                lbl_IDEstudiante.Text = String.Empty
            End If

            If Not IsDBNull(selectedRow.Cells(1).Value) Then
                txt_Asignar_Estudiante.Text = selectedRow.Cells(1).Value.ToString()
            Else
                txt_Asignar_Estudiante.Text = String.Empty
            End If
        End If
    End Sub

    Private Sub dgv_AsignarMateria_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_AsignarMateria.CellClick
        ' Verificar si la celda seleccionada no es el encabezado de la fila
        If e.RowIndex >= 0 Then
            ' Obtener los valores de la fila seleccionada y mostrarlos en los campos de texto
            Dim selectedRow As DataGridViewRow = dgv_AsignarMateria.Rows(e.RowIndex)

            ' Verificar si la celda contiene un valor válido antes de asignarlo
            If Not IsDBNull(selectedRow.Cells(0).Value) Then
                lbl_IDMateria.Text = selectedRow.Cells(0).Value.ToString()
            Else
                lbl_IDMateria.Text = String.Empty
            End If

            If Not IsDBNull(selectedRow.Cells(1).Value) Then
                txt_Asignar_Materia.Text = selectedRow.Cells(1).Value.ToString()
            Else
                txt_Asignar_Materia.Text = String.Empty
            End If
        End If
    End Sub

    Private Sub btnAsignarMateria_Click(sender As Object, e As EventArgs) Handles btnAsignarMateria.Click
        ' Obtener el ID del estudiante y la materia seleccionados desde los labels
        Dim idEstudiante As String = lbl_IDEstudiante.Text
        Dim idMateria As String = lbl_IDMateria.Text

        If Not String.IsNullOrEmpty(idEstudiante) AndAlso Not String.IsNullOrEmpty(idMateria) Then
            ' Verificar si hay un elemento seleccionado en el ComboBox
            If cbo_AsignarEstado.SelectedItem IsNot Nothing Then
                ' Obtener el estado seleccionado
                Dim estado As String = cbo_AsignarEstado.SelectedItem.ToString()

                ' Confirmar la asignación con el usuario
                Dim confirmResult As DialogResult = MessageBox.Show("¿Estás seguro de asignar esta materia al estudiante?", "Confirmar Asignación", MessageBoxButtons.YesNo)
                If confirmResult = DialogResult.Yes Then
                    ' Instanciar el modelo y llamar al método para asignar la materia al estudiante
                    Dim asignarModelo As New AsignarModelo()
                    Dim exito As Boolean = asignarModelo.AsignarMateriaAEstudiante(idEstudiante, idMateria, estado)

                    If exito Then
                        MessageBox.Show("Materia asignada correctamente.")

                        ' Limpiar los campos después de agregar el registro
                        LimpiarCampos()
                    Else
                        MessageBox.Show("Error al asignar la materia.")
                    End If
                End If
            Else
                MessageBox.Show("Por favor, seleccione un estado.")
            End If
        Else
            MessageBox.Show("Por favor, seleccione un estudiante y una materia.")
        End If
    End Sub

    Private Sub btnDeshacerUltimoRegistro_Click(sender As Object, e As EventArgs) Handles btnDeshacerUltimoRegistro.Click
        ' Confirmar con el usuario antes de deshacer el último registro
        Dim confirmResult As DialogResult = MessageBox.Show("¿Estás seguro de deshacer el último registro de asignación?", "Confirmar Deshacer Registro", MessageBoxButtons.YesNo)
        If confirmResult = DialogResult.Yes Then
            Try
                Dim asignarModelo As New AsignarModelo()
                Dim exito As Boolean = asignarModelo.EliminarUltimaAsignacion()

                If exito Then
                    MessageBox.Show("Última asignación eliminada correctamente.")

                    ' Limpiar los campos después de deshacer el registro
                    LimpiarCampos()
                Else
                    MessageBox.Show("Error al eliminar la última asignación.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error al eliminar la última asignación: " & ex.Message)
            End Try
        End If
    End Sub


    Private Sub LimpiarCampos()
        ' Limpiar los campos de texto
        txt_Asignar_Estudiante.Clear()
        txt_Asignar_Materia.Clear()

        ' Limpiar los labels
        lbl_IDEstudiante.Text = ""
        lbl_IDMateria.Text = ""

        ' Limpiar el ComboBox
        cbo_AsignarEstado.SelectedIndex = -1
    End Sub

End Class

