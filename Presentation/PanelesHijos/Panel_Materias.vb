Imports System.Data
Imports System.Text.RegularExpressions
Imports Domain
Imports Common

Public Class Panel_Materias

    'Inicializar Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Panel_Materias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarMaterias()
    End Sub

    Private Sub MostrarMaterias()
        ' Instanciar MateriaModelo
        Dim materiaModelo As New MateriaModelo()

        ' Obtener los datos de las materias
        Dim dtMaterias As New DataTable()
        dtMaterias = materiaModelo.Dominio_ObtenerMaterias()

        ' Configurar las columnas del DataGridView
        dgv_materias.Columns.Clear() ' Limpiar las columnas existentes
        dgv_materias.AutoGenerateColumns = False ' Deshabilitar la generación automática de columnas

        ' Agregar las columnas necesarias
        Dim colID As New DataGridViewTextBoxColumn()
        colID.DataPropertyName = "ID"
        colID.HeaderText = "ID"
        dgv_materias.Columns.Add(colID)

        Dim colNombre As New DataGridViewTextBoxColumn()
        colNombre.DataPropertyName = "Nombre"
        colNombre.HeaderText = "Nombre"
        dgv_materias.Columns.Add(colNombre)

        Dim colCodigo As New DataGridViewTextBoxColumn()
        colCodigo.DataPropertyName = "Codigo"
        colCodigo.HeaderText = "Codigo"
        dgv_materias.Columns.Add(colCodigo)

        Dim colCreditos As New DataGridViewTextBoxColumn()
        colCreditos.DataPropertyName = "Creditos"
        colCreditos.HeaderText = "Creditos"
        dgv_materias.Columns.Add(colCreditos)

        ' Asignar los datos al DataGridView
        dgv_materias.DataSource = dtMaterias
    End Sub

    Private Sub btnGuardarMateria_Click(sender As Object, e As EventArgs) Handles btnGuardarMateria.Click
        ' Validar si el usuario está seguro de guardar la materia
        Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de que desea guardar esta materia?", "Confirmar Guardar Materia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmacion = DialogResult.No Then
            Return ' Cancelar la operación si el usuario no está seguro
        End If

        ' Obtener los datos de la materia desde los campos del formulario
        Dim nombre As String = txtNombreMateria.Text
        Dim codigo As String = txtCodigoMateria.Text
        Dim creditosStr As String = txtCreditosMateria.Text

        ' Validar que los campos no estén vacíos
        If String.IsNullOrWhiteSpace(nombre) OrElse String.IsNullOrWhiteSpace(codigo) OrElse String.IsNullOrWhiteSpace(creditosStr) Then
            MessageBox.Show("Por favor, complete todos los campos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Cancelar la operación si algún campo está vacío
        End If

        ' Validar que el nombre de la materia no contenga números enteros
        If Not EsNombreValido(nombre) Then
            MessageBox.Show("El nombre de la materia no puede contener números y sobre pasar los 100 caracteres.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Cancelar la operación si no se cumple la validación
        End If

        ' Validar el formato del código de la materia
        If Not EsCodigoValido(codigo) Then
            MessageBox.Show("Formato Incorrecto. Ingrese un formato de 2 Mayusculas, 1 guion '-' y 4 números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Cancelar la operación si no se cumple la validación
        End If

        ' Validar que los créditos de la materia sean un número entero entre 3 y 6
        Dim creditos As Integer
        If Not Integer.TryParse(creditosStr, creditos) OrElse creditos < 3 OrElse creditos > 6 Then
            MessageBox.Show("Los créditos deben ser un número entre 3 y 6.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Cancelar la operación si no se cumple la validación
        End If

        ' Instanciar MateriaModelo
        Dim materiaModelo As New MateriaModelo()

        ' Llamar al método dominio_InsertarMateria para guardar la nueva materia
        Dim insercionExitosa As Boolean = materiaModelo.Dominio_InsertarMateria(nombre, codigo, creditos)

        ' Verificar si la inserción fue exitosa
        If insercionExitosa Then
            MessageBox.Show("Materia guardada correctamente.")
            ' Recargar los datos del DataGridView para reflejar los cambios en tiempo real
            CargarDatosMaterias()
            ' Limpiar los campos después de guardar la materia
            LimpiarCamposMateria()
        Else
            MessageBox.Show("Error al guardar la materia. Inténtelo de nuevo.")
        End If
    End Sub

    Private Function EsNombreValido(nombre As String) As Boolean
        ' Establecer un límite máximo para la longitud del nombre de la materia
        Const longitudMaxima As Integer = 100

        ' Validar que el nombre no contenga números enteros y no exceda la longitud máxima
        Return Not nombre.Any(Function(c) Char.IsDigit(c)) AndAlso nombre.Length <= longitudMaxima
    End Function


    Private Function EsCodigoValido(codigo As String) As Boolean
        ' Validar el formato del código de la materia (2 letras mayúsculas, 1 caracter "-", y 4 números)
        Dim formatoEsperado As String = "XX-0000" ' XX representa letras mayúsculas y 0000 representa dígitos

        If codigo.Length <> formatoEsperado.Length Then
            Return False
        End If

        For i As Integer = 0 To codigo.Length - 1
            Select Case i
                Case 0, 1 ' Letras mayúsculas
                    If Not Char.IsLetter(codigo(i)) OrElse Not Char.IsUpper(codigo(i)) Then
                        Return False
                    End If
                Case 2 ' Guion
                    If codigo(i) <> "-"c Then
                        Return False
                    End If
                Case 3 To 6 ' Dígitos
                    If Not Char.IsDigit(codigo(i)) Then
                        Return False
                    End If
            End Select
        Next

        Return True
    End Function
    Private Sub btnEditarMateria_Click(sender As Object, e As EventArgs) Handles btnEditarMateria.Click
        ' Validar si el usuario está seguro de editar la materia
        Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de que desea editar esta materia?", "Confirmar Edición de Materia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmacion = DialogResult.No Then
            Return ' Cancelar la operación si el usuario no está seguro
        End If

        ' Obtener el ID de la materia seleccionada en el DataGridView
        Dim idMateria As Integer
        If Integer.TryParse(txt_ID_Materias.Text, idMateria) AndAlso idMateria > 0 Then
            ' Obtener los datos de la materia desde los campos del formulario
            Dim nombre As String = txtNombreMateria.Text
            Dim codigo As String = txtCodigoMateria.Text
            Dim creditosStr As String = txtCreditosMateria.Text

            ' Validar que los campos no estén vacíos
            If String.IsNullOrWhiteSpace(nombre) OrElse String.IsNullOrWhiteSpace(codigo) OrElse String.IsNullOrWhiteSpace(creditosStr) Then
                MessageBox.Show("Por favor, complete todos los campos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Cancelar la operación si algún campo está vacío
            End If

            ' Validar que el nombre de la materia no contenga números enteros
            If Not EsNombreValido(nombre) Then
                MessageBox.Show("El nombre de la materia no puede contener números y sobre pasar los 100 caracteres.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Cancelar la operación si no se cumple la validación
            End If

            ' Validar el formato del código de la materia
            If Not EsCodigoValido(codigo) Then
                MessageBox.Show("Formato Incorrecto. Ingrese un formato de 2 Mayúsculas, 1 guion '-' y 4 números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Cancelar la operación si no se cumple la validación
            End If

            ' Validar que los créditos de la materia sean un número entero entre 3 y 6
            Dim creditos As Integer
            If Not Integer.TryParse(creditosStr, creditos) OrElse creditos < 3 OrElse creditos > 6 Then
                MessageBox.Show("Los créditos deben ser un número entre 3 y 6.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Cancelar la operación si no se cumple la validación
            End If

            ' Instanciar MateriaModelo
            Dim materiaModelo As New MateriaModelo()

            ' Llamar al método Dominio_ActualizarMateria para actualizar la materia
            Dim actualizacionExitosa As Boolean = materiaModelo.Dominio_ActualizarMateria(idMateria, nombre, codigo, creditos)

            ' Verificar si la actualización fue exitosa
            If actualizacionExitosa Then
                MessageBox.Show("Materia actualizada correctamente.")
                ' Recargar los datos del DataGridView para reflejar los cambios en tiempo real
                CargarDatosMaterias()
                ' Limpiar los campos después de editar la materia
                LimpiarCamposMateria()
            Else
                MessageBox.Show("Error al actualizar la materia. Inténtelo de nuevo.")
            End If
        Else
            MessageBox.Show("Por favor, seleccione una materia de la lista para editar.")
        End If
    End Sub



    Private Sub btnEliminarMateria_Click(sender As Object, e As EventArgs) Handles btnEliminarMateria.Click
        ' Obtener el ID de la materia seleccionada en el DataGridView
        Dim idMateria As Integer
        If Integer.TryParse(txt_ID_Materias.Text, idMateria) AndAlso idMateria > 0 Then
            ' Confirmar con el usuario si realmente desea eliminar la materia
            Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar esta materia?", "Confirmar Eliminar Materia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmacion = DialogResult.Yes Then
                ' Instanciar MateriaModelo
                Dim materiaModelo As New MateriaModelo()

                ' Llamar al método Dominio_EliminarMateria para eliminar la materia
                Dim eliminacionExitosa As Boolean = materiaModelo.Dominio_EliminarMateria(idMateria)

                ' Verificar si la eliminación fue exitosa
                If eliminacionExitosa Then
                    MessageBox.Show("Materia eliminada correctamente.")
                    ' Recargar los datos del DataGridView para reflejar los cambios en tiempo real
                    CargarDatosMaterias()
                    ' Limpiar los campos después de eliminar la materia
                    LimpiarCamposMateria()
                Else
                    MessageBox.Show("Error al eliminar la materia. Inténtelo de nuevo.")
                End If
            End If
        Else
            MessageBox.Show("Por favor, seleccione una materia de la lista para eliminar.")
        End If
    End Sub

    Private Sub LimpiarCamposMateria()
        ' Limpiar los campos del formulario de materias
        txtNombreMateria.Clear()
        txtCodigoMateria.Clear()
        txtCreditosMateria.Clear()
        txtNombreMateria.Focus()
    End Sub

    Private Sub dgv_materias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_materias.CellClick
        ' Verificar si la celda seleccionada no es el encabezado de la fila
        If e.RowIndex >= 0 Then
            ' Obtener los valores de la fila seleccionada y mostrarlos en los campos de texto
            Dim selectedRow As DataGridViewRow = dgv_materias.Rows(e.RowIndex)
            txt_ID_Materias.Text = selectedRow.Cells(0).Value.ToString()
            txtNombreMateria.Text = selectedRow.Cells(1).Value.ToString()
            txtCodigoMateria.Text = selectedRow.Cells(2).Value.ToString()
            txtCreditosMateria.Text = selectedRow.Cells(3).Value.ToString()
        End If
    End Sub

    Private Sub CargarDatosMaterias()
        ' Obtener los datos actualizados de las materias y cargarlos en el DataGridView
        Dim materiaModelo As New MateriaModelo()
        Dim dtMaterias As DataTable = materiaModelo.Dominio_ObtenerMaterias()
        dgv_materias.DataSource = dtMaterias
    End Sub



End Class
