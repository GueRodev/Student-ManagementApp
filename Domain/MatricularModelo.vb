Imports DataAcces

Public Class MatricularModelo

    ' Método para matricular a un estudiante y asignarle las materias correspondientes
    Public Function Dominio_MatricularEstudiante(nombre As String, apellidos As String, identificacion As String, carnet As String, correo As String, telefono As String, carreraID As Integer, fechaIngreso As Date) As Boolean
        Dim dataMatricular As New Data_Matricular()
        Return dataMatricular.InsertarEstudiante(nombre, apellidos, identificacion, carnet, correo, telefono, carreraID, fechaIngreso)
    End Function

    ' Método para obtener las materias por carrera
    Public Function Dominio_ObtenerMateriasPorCarrera(carreraID As Integer) As DataTable
        Dim dataMatricular As New Data_Matricular()
        Return dataMatricular.ObtenerMaterias_PorCarrera(carreraID)
    End Function

End Class
