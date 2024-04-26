Imports System.Text
Imports DataAcces

Public Class AsignarModelo

    Public Function AsignarMateriaAEstudiante(idEstudiante As String, idMateria As String, estado As String) As Boolean
        Dim datosAsignar As New Datos_Asignar()
        Return datosAsignar.InsertarMateriaAsignada(idEstudiante, idMateria, estado)
    End Function

    Public Function dominio_ObtenerEstudiantes() As DataTable
        Dim datos_estudiante As New Datos_Estudiantes()
        Return datos_estudiante.ObtenerEstudiantes()
    End Function

    Public Function Dominio_ObtenerMaterias() As DataTable
        Dim datosMateria As New Datos_Materias()
        Return datosMateria.ObtenerMaterias()
    End Function

    Public Function EliminarUltimaAsignacion() As Boolean
        Dim datosAsignar As New Datos_Asignar()
        Return datosAsignar.EliminarUltimaAsignacion()
    End Function


End Class
