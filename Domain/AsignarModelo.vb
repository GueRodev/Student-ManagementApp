Imports System.Data
Imports DataAcces

Public Class AsignarModelo
    Private datosAsignar As New Datos_Asignar()

    ' Método para obtener los estudiantes con sus carreras
    Public Function Dominio_ObtenerEstudiantesConCarrera() As DataTable
        Return datosAsignar.ObtenerEstudiantesConCarrera()
    End Function

    ' Método para obtener las materias asociadas a un estudiante
    Public Function ObtenerMateriasPorEstudiante(identificacion As String) As DataTable
        Return datosAsignar.ObtenerMateriasPorEstudiante(identificacion)
    End Function

    ' Método para editar el estado y la nota de una materia asignada a un estudiante
    Public Function EditarEstadoYNota(estudianteId As Integer, materiaId As Integer, estadoId As Integer, nota As Integer) As Boolean

        ' Validación de datos antes de enviar a la capa de acceso a datos
        If estudianteId <= 0 Then
            Throw New ArgumentException("El ID del estudiante no es válido.")
        End If

        If materiaId <= 0 Then
            Throw New ArgumentException("El ID de la materia no es válido.")
        End If

        If estadoId < 1 OrElse estadoId > 3 Then
            Throw New ArgumentException("El ID del estado no es válido.")
        End If

        If nota < 0 OrElse nota > 100 Then
            Throw New ArgumentException("La nota debe estar entre 0 y 100.")
        End If

        ' Llamada al método de la capa de acceso a datos
        Return datosAsignar.EditarEstadoYNota(estudianteId, materiaId, estadoId, nota)
    End Function
End Class
