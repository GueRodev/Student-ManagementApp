﻿Imports DataAcces

Public Class MateriaModelo
    Public Function Dominio_InsertarMateria(nombre As String, codigo As String, creditos As Integer, requisitos As String) As Boolean
        Dim datosMateria As New Datos_Materias()
        Return datosMateria.InsertarMateria(nombre, codigo, creditos, requisitos)
    End Function

    Public Function Dominio_ObtenerMaterias() As DataTable
        Dim datosMateria As New Datos_Materias()
        Return datosMateria.ObtenerMaterias()
    End Function

    Public Function Dominio_ActualizarMateria(id As Integer, nombre As String, codigo As String, creditos As Integer, requisitos As String) As Boolean
        Dim datosMateria As New Datos_Materias()
        Return datosMateria.ActualizarMateria(id, nombre, codigo, creditos, requisitos)
    End Function

    Public Function Dominio_EliminarMateria(id As Integer) As Boolean
        Dim datosMateria As New Datos_Materias()
        Return datosMateria.EliminarMateria(id)
    End Function

    Public Function Dominio_ContarMaterias() As Integer
        Dim datosMateria As New Datos_Materias()
        Return datosMateria.ContarMaterias()
    End Function

End Class
