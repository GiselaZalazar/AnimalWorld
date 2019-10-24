Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class C_producto
    Dim odatabase As Database
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader


    Public Sub New()
        odatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub
    Public Function Agregar(ByVal Nombre As String, _
                            ByVal Descripcion As String, _
                            ByVal Cantidad As Integer, _
                            ByVal Preciounitario As Integer, _
                            ByVal Subrubro As Integer, _
                            ByVal Unidaddemediad As Integer, _
                            ByVal Estado As Integer) As Double
        Return odatabase.ExecuteScalar("Producto_Agregar", Nombre, Descripcion, Cantidad, Preciounitario, Subrubro, Unidaddemediad, Estado)
    End Function
    Public Function Modificar(ByVal Idproducto As Integer, _
                             ByVal Nombre As String, _
                             ByVal Descripcion As String, _
                             ByVal Cantidad As Integer, _
                             ByVal Preciounitario As Integer, _
                             ByVal Subrubro As Integer, _
                            ByVal Unidaddemediad As Integer, _
                           ByVal Estado As Integer) As DataSet
        Return odatabase.ExecuteDataSet("Producto_Modificar", Idproducto, Nombre, Descripcion, Cantidad, Preciounitario, Subrubro, Unidaddemediad, Estado)
    End Function
    Public Function Eliminar(ByVal Idproducto As Integer) As Double
        Return odatabase.ExecuteScalar("Producto_Eliminar", Idproducto)
    End Function
    Public Function BuscarTodos() As DataSet
        Return odatabase.ExecuteDataSet("Producto_BuscarTodos")
    End Function
    Public Function Estado_Buscartodos() As DataSet
        Try
            Return odatabase.ExecuteDataSet("Estado_Buscartodos")
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw ex
        End Try
    End Function
End Class