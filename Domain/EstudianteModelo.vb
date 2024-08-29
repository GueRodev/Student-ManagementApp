
Imports System.Text
Imports DataAcces

Public Class EstudianteModelo


    Public Function dominio_ObtenerEstudiantes() As DataTable
        Dim datos_estudiante As New Datos_Estudiantes()
        Return datos_estudiante.ObtenerEstudiantes()
    End Function

    Public Function dominio_ActualizarEstudiante(id As Integer, nombre As String, apellidos As String, identificacion As String, carnet As String, correo As String, telefono As String) As Boolean
        Dim datos_estudiante As New Datos_Estudiantes()
        Return datos_estudiante.ActualizarEstudiante(id, nombre, apellidos, identificacion, carnet, correo, telefono)
    End Function

    Public Function Dominio_EliminarEstudiante(id As Integer) As Boolean
        Dim datosEstudiante As New Datos_Estudiantes()
        Return datosEstudiante.EliminarEstudiante(id)
    End Function


    Public Function dominio_ContarEstudiantes() As Integer
        Dim datosEstudiante As New Datos_Estudiantes()
        Return datosEstudiante.ContarEstudiantes()
    End Function

    Public Function ExisteEstudiantePorIdentificacion(identificacion As String) As Boolean
        Dim datosEstudiantes As New Datos_Estudiantes()
        Return datosEstudiantes.ExisteEstudiantePorIdentificacion(identificacion)
    End Function

    Public Function dominio_ObtenerEstudiantePorId(id As Integer) As DataRow
        Dim datosEstudiante As New Datos_Estudiantes()
        Return datosEstudiante.ObtenerEstudiantePorId(id)
    End Function

    Public Function ExisteEstudiantePorCorreo(correo As String) As Boolean
        Dim datosEstudiantes As New Datos_Estudiantes()
        Return datosEstudiantes.ExisteEstudiantePorCorreo(correo)
    End Function

    Public Function ExisteEstudiantePorCorreoExcluyendoId(correo As String, id As Integer) As Boolean
        Dim datosEstudiantes As New Datos_Estudiantes()
        Return datosEstudiantes.ExisteEstudiantePorCorreoExcluyendoId(correo, id)
    End Function

    Public Function ExisteTelefonoExcluyendoId(telefono As String, id As Integer) As Boolean
        Dim datosEstudiante As New Datos_Estudiantes()
        Return datosEstudiante.ExisteTelefonoExcluyendoId(telefono, id)
    End Function

    Public Function ExisteCarnetExcluyendoId(carnet As String, id As Integer) As Boolean
        Dim datosEstudiante As New Datos_Estudiantes()
        Return datosEstudiante.ExisteCarnetExcluyendoId(carnet, id)
    End Function


End Class
