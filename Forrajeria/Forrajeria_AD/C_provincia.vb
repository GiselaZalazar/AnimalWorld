Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class C_provincia
    Dim odatabase As Database
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader


    Public Sub New()
        odatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub
    Public Function Agregar(ByVal Nombre As String, _
                        ByVal Localidad As Integer, _
                        ByVal Zona As Integer) As Double

        Return odatabase.ExecuteScalar("Provincia_Agregar", Nombre, _
                                                         Localidad, _
                                                         Zona)

    End Function
    Public Function Modificar(ByVal Idprovincia As Integer, _
                          ByVal Nombre As String, _
                          ByVal Localidad As Integer, _
                          ByVal Zona As Integer) As DataSet
        Return odatabase.ExecuteDataSet("Provincia_Modificar", Idprovincia, Nombre, Localidad, Zona)
    End Function
    Public Function Eliminar(ByVal Idprovincia As Integer) As Double
        Return odatabase.ExecuteScalar("Provincia_Eliminar", Idprovincia)
    End Function
    Public Function BuscarTodos() As DataSet
        Return odatabase.ExecuteDataSet("Provincia_BuscarTodos")
    End Function
    Public Function Localidad_BuscarTodos() As DataSet
        Try
            Return Odatabase.ExecuteDataSet("Localidades_BuscarTodos")
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw ex
        End Try
    End Function
    Public Function Zona_Buscartodos() As DataSet
        Try
            Return odatabase.ExecuteDataSet("Zona_Buscartodos")
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw ex
        End Try
    End Function
End Class
