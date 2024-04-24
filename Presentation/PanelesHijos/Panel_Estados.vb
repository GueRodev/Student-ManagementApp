
Imports System.Data
Imports System.Text.RegularExpressions
Imports Domain
Imports Common

Public Class Panel_Estados

    'Inicializar Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Panel_Estados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarEstudiantes()

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


End Class
