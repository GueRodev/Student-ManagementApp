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

    ' Método para verificar si un correo ya existe
    Public Function Dominio_CorreoExiste(correo As String) As Boolean
        Dim dataMatricular As New Data_Matricular()
        Return dataMatricular.CorreoExiste(correo)
    End Function

    Public Function Dominio_TelefonoExiste(telefono As String) As Boolean
        Dim dataMatricular As New Data_Matricular()
        Return dataMatricular.TelefonoExiste(telefono)
    End Function

    Public Function Dominio_CarnetExiste(carnet As String) As Boolean
        Dim dataMatricular As New Data_Matricular()
        Return dataMatricular.CarnetExiste(carnet)
    End Function

    Public Function Dominio_IdentificacionExiste(identificacion As String) As Boolean
        Dim dataMatricular As New Data_Matricular()
        Return dataMatricular.IdentificacionExiste(identificacion)
    End Function




End Class
