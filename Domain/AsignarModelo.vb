Imports System.Data
Imports DataAcces

Public Class AsignarModelo
    ' Método para obtener los estudiantes con sus carreras
    Public Function Dominio_ObtenerEstudiantesConCarrera() As DataTable
        Dim datosAsignar As New Datos_Asignar()
        Return datosAsignar.ObtenerEstudiantesConCarrera()
    End Function

    ' Método para obtener las materias asociadas a un estudiante
    Public Function ObtenerMateriasPorEstudiante(identificacion As String) As DataTable
        Dim datosAsignar As New Datos_Asignar()
        Return datosAsignar.ObtenerMateriasPorEstudiante(identificacion)
    End Function
End Class
