Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class C_localidad
    Dim odatabase As Database
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader


    Public Sub New()
        odatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub
    Public Function Agregar(ByVal Nombre As String, _
                        ByVal Provincia As Integer, _
                        ByVal Codigo As String, _
                        ByVal Activo As Boolean) As Double

        Return odatabase.ExecuteScalar("Localidades_Agregar", Nombre, _
                                                         Provincia, _
                                                        Codigo, _
                                                        Activo)

    End Function
    Public Function Modificar(ByVal Idlocalidad As Integer, _
                          ByVal Nombre As String, _
                          ByVal Provincia As Integer, _
                          ByVal Codigo As String, _
                          ByVal Activo As Boolean) As DataSet
        Return odatabase.ExecuteDataSet("Localidades_Modificar", Idlocalidad, Nombre, Provincia, Codigo, Activo)
    End Function
    Public Function Eliminar(ByVal Idlocalidad As Integer) As Double
        Return odatabase.ExecuteScalar("Localidades_Eliminar", Idlocalidad)
    End Function
    Public Function BuscarTodos() As DataSet
        Return odatabase.ExecuteDataSet("Localidades_BuscarTodos")
    End Function
    Public Function Provincia_BuscarTodos() As DataSet
        Try
            Return odatabase.ExecuteDataSet("Provincia_BuscarTodos")
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw ex
        End Try
    End Function

End Class

