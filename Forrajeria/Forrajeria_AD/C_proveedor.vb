Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class C_proveedor
    Dim odatabase As Database
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader


    Public Sub New()
        odatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub
    Public Function Agregar(ByVal RazonSocial As String, _
                        ByVal NombreyApellido As String, _
                        ByVal Localidad As String, _
                        ByVal domicilio As String, _
                        ByVal Telefono As String, _
                        ByVal Email As String, _
                        ByVal Categoriaiva As String, _
                        ByVal NumeroCuit As String, _
                        ByVal Provincia As Integer, _
                        ByVal Producto As Integer, _
                        ByVal Ciudad As String, _
                        ByVal Estado As Integer, _
                        ByVal CodigoPostal As String
                        ) As Double

        Return odatabase.ExecuteScalar("ProveedorAgregar", RazonSocial, _
                                                         NombreyApellido, _
                                                         Localidad, _
                                                         domicilio, _
                                                         Telefono, _
                                                         Email, _
                                                         Categoriaiva, _
                                                         NumeroCuit, _
                                                         Provincia, _
                                                         Producto, _
                                                         Ciudad, _
                                                         Estado, _
                                                         CodigoPostal
                                                         )

    End Function
    Public Function Modificar(ByVal Idproveedor As Integer, _
                          ByVal RazonSocial As String, _
                          ByVal NombreyApellido As String, _
                          ByVal Localidad As Integer, _
                          ByVal Domicilio As String, _
                          ByVal Telefono As String, _
                          ByVal Email As String, _
                          ByVal Categoriaiva As Integer, _
                          ByVal NumeroCuit As String, _
                          ByVal Provincia As Integer, _
                          ByVal Producto As Integer, _
                          ByVal Ciudad As String, _
                          ByVal Codigopostal As String, _
                          ByVal Estado As Integer) As DataSet
        Return odatabase.ExecuteDataSet("Proveedor_Modificar", Idproveedor, RazonSocial, NombreyApellido, Localidad, Domicilio, Telefono, Email, Categoriaiva, NumeroCuit, Provincia, Producto, Ciudad, Estado, Codigopostal)
    End Function
    Public Function Eliminar(ByVal IdProveedor As Integer) As Double
        Return odatabase.ExecuteScalar("Provedor_Eliminar", IdProveedor)
    End Function
    Public Function BuscarTodos() As DataSet
        Return odatabase.ExecuteDataSet("Proveedor_BuscarTodos")
    End Function
    Public Function Localidad_BuscarTodos() As DataSet
        Try
            Return Odatabase.ExecuteDataSet("Localidades_BuscarTodos")
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw ex
        End Try
    End Function
    Public Function CategoriaIva_Buscartodas() As DataSet
        Try
            Return odatabase.ExecuteDataSet("CategoriaIva_Buscartodas")
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw ex
        End Try
    End Function
    Public Function Estado_Buscartodos() As DataSet
        Try
            Return odatabase.ExecuteDataSet("Estado_Buscartodos")
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw ex
        End Try
    End Function
    Public Function Provincia_Buscartodos() As DataSet
        Try
            Return odatabase.ExecuteDataSet("Provincia_Buscartodos")
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw ex
        End Try
    End Function
    Public Function Producto_Buscartodos() As DataSet
        Try
            Return odatabase.ExecuteDataSet("Producto_BuscarTodos")
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw ex
        End Try
    End Function
End Class
