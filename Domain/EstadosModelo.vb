Imports System.Text
Imports DataAcces

Public Class EstadosModelo
    Public Function ObtenerEstudiantesPorIdentificacion(identificacion As String) As DataTable
        Dim datosEstados As New Datos_Estados()
        Return datosEstados.ObtenerEstudiantesPorIdentificacion(identificacion)
    End Function


End Class
