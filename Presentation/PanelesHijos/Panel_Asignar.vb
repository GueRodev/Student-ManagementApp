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
        MostrarMaterias() ' Llamar a la función para mostrar las materias al cargar el formulario
    End Sub

    Private Sub MostrarEstudiantes()
        ' Instanciar EstudianteModelo
        Dim estudianteModelo As New EstudianteModelo()

        ' Obtener los datos de los estudiantes
        Dim dtEstudiantes As New DataTable()
        dtEstudiantes = estudianteModelo.dominio_ObtenerEstudiantes()

        ' Configurar las columnas del DataGridView
        dgv_Estudiantes_Mostrar.Columns.Clear() ' Limpiar las columnas existentes
        dgv_Estudiantes_Mostrar.AutoGenerateColumns = False ' Deshabilitar la generación automática de columnas

        ' Agregar las columnas necesarias

        Dim colNombre As New DataGridViewTextBoxColumn()
        colNombre.DataPropertyName = "Nombre"
        colNombre.HeaderText = "Nombre"
        dgv_Estudiantes_Mostrar.Columns.Add(colNombre)

        Dim colIdentificacion As New DataGridViewTextBoxColumn()
        colIdentificacion.DataPropertyName = "Identificacion"
        colIdentificacion.HeaderText = "Identificacion"
        dgv_Estudiantes_Mostrar.Columns.Add(colIdentificacion)

        ' Asignar los datos al DataGridView
        dgv_Estudiantes_Mostrar.DataSource = dtEstudiantes
    End Sub


    Private Sub MostrarMaterias()
        ' Instanciar el modelo de materia
        Dim materiaModelo As New MateriaModelo()

        ' Obtener los datos de las materias
        Dim dtMaterias As New DataTable()
        dtMaterias = materiaModelo.VistaMateriasID()

        ' Configurar las columnas del DataGridView
        dgv_materias_Asignar.Columns.Clear() ' Limpiar las columnas existentes
        dgv_materias_Asignar.AutoGenerateColumns = False ' Deshabilitar la generación automática de columnas

        ' Agregar las columnas necesarias

        Dim colID As New DataGridViewTextBoxColumn()
        colID.DataPropertyName = "ID"
        colID.HeaderText = "ID"
        dgv_materias_Asignar.Columns.Add(colID)

        Dim colMateria As New DataGridViewTextBoxColumn()
        colMateria.DataPropertyName = "Materia"
        colMateria.HeaderText = "Materia"
        dgv_materias_Asignar.Columns.Add(colMateria)

        ' Asignar los datos al DataGridView
        dgv_materias_Asignar.DataSource = dtMaterias
    End Sub


End Class
