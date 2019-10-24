Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class C_facturacion
    Dim odatabase As Database
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader


    Public Sub New()
        odatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function Agregar(ByVal id_factura As Integer, ByVal fecha As String, ByVal Tipo As String, ByVal PuntoVenta As String, ByVal CompNo As String) As Double
        Try
            Return odatabase.ExecuteScalar("Facturacion_Agregar", id_factura, fecha, Tipo, PuntoVenta, CompNo)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw ex
        End Try
    End Function

    Public Function modificar(ByVal id_factura As Integer, ByVal fecha As String, ByVal Tipo As String, ByVal PuntoVenta As String, ByVal CompNo As String) As DataSet
        Try
            Return odatabase.ExecuteScalar("Facturacion_Modificar", id_factura, fecha, Tipo, PuntoVenta, CompNo)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw ex
        End Try
    End Function

    Public Function eliminar(ByVal id_factura As Integer) As Double
        Try
            Return odatabase.ExecuteScalar("Facturacion_Eliminar", id_factura)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw ex
        End Try
    End Function

    Public Function BuscarTodos() As DataSet
        Try
            Return odatabase.ExecuteDataSet("Facturacion_BuscarTodos")
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw ex
        End Try
    End Function

    Public Function BuscarTodos(ByVal id_factura As Integer) As DataSet
        Try
            Return odatabase.ExecuteDataSet("Facturacion_BuscarTodos", id_factura)
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw ex
        End Try
    End Function
End Class
