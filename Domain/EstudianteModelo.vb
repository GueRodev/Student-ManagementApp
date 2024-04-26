
Imports System.Text
Imports DataAcces

Public Class EstudianteModelo

    Public Function dominio_InsertarEstudiante(nombre As String, apellidos As String, identificacion As String, correo As String, carrera As String, fechaIngreso As Date) As Boolean
        Dim datosEstudiante As New Datos_Estudiantes()
        Return datosEstudiante.InsertarEstudiante(nombre, apellidos, identificacion, correo, carrera, fechaIngreso)
    End Function

    Public Function dominio_ObtenerEstudiantes() As DataTable
        Dim datos_estudiante As New Datos_Estudiantes()
        Return datos_estudiante.ObtenerEstudiantes()
    End Function

    Public Function dominio_ActualizarEstudiante(id As Integer, nombre As String, apellidos As String, identificacion As String, correo As String, carrera As String, fechaIngreso As Date) As Boolean
        Dim datos_estudiante As New Datos_Estudiantes()
        Return datos_estudiante.ActualizarEstudiante(id, nombre, apellidos, identificacion, correo, carrera, fechaIngreso)
    End Function

    Public Function dominio_EliminarEstudiante(id As Integer) As Boolean
        Dim datos_estudiante As New Datos_Estudiantes()
        Return datos_estudiante.EliminarEstudiante(id)
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



End Class
