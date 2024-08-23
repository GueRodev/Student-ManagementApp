Imports System.Text
Imports DataAcces

Public Class EstadosModelo

    Private datosEstados As New Datos_Estados()

    ' Método para obtener las materias de un estudiante por estado
    Public Function ObtenerMateriasPorEstudianteYEstado(identificacion As String, estadoId As Integer) As DataTable
        Return datosEstados.ObtenerMateriasPorEstudianteYEstado(identificacion, estadoId)
    End Function

    Public Function CalcularPorcentajeCarreraAprobada(identificacion As String, carrera As String) As Double
        Dim datosEstados As New Datos_Estados()
        Dim creditosAprobados As Integer = datosEstados.ObtenerCreditosAprobados(identificacion)

        ' Definir el total de créditos requeridos para completar la carrera
        Dim totalCreditosCarrera As Integer
        Select Case carrera
            Case "Ingeniería en Sistemas"
                totalCreditosCarrera = 130
            Case "Ingeniería Industrial"
                totalCreditosCarrera = 142
            Case "Administración de Negocios"
                totalCreditosCarrera = 143
            Case "Contaduría"
                totalCreditosCarrera = 149
            Case Else
                Throw New ArgumentException("Carrera no reconocida.")
        End Select

        ' Calcular el porcentaje
        Dim porcentajeAprobado As Double = (creditosAprobados / totalCreditosCarrera) * 100
        Return porcentajeAprobado
    End Function

End Class
