Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class C_Clientes

    Dim odatabase As Database
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    

    Public Sub New()
        odatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub
    Public Function Agregar(ByVal RazonSocial As String, _
                            ByVal NombreFantacia As String, _
                            ByVal Localidad As String, _
                            ByVal domicilio As String, _
                            ByVal TelefonoParticular As String, _
                            ByVal TelefonoComercial As String, _
                            ByVal Email As String, _
                            ByVal Categoriaiva As String, _
                            ByVal NumerodeCuit As String, _
                            ByVal Vendedor As Integer, _
                            ByVal Zona As Integer, _
                            ByVal Secuencia As String, _
                            ByVal Estado As Integer) As Double

        Return odatabase.ExecuteScalar("Clientes_Agregar", RazonSocial, _
                                                         NombreFantacia, _
                                                         Localidad, _
                                                         domicilio, _
                                                         TelefonoParticular, _
                                                         TelefonoComercial, _
                                                         Email, _
                                                         Categoriaiva, _
                                                         NumerodeCuit, _
                                                         Vendedor, _
                                                         Zona, _
                                                         Secuencia, _
                                                         Estado)

    End Function
    Public Function Modificar(ByVal Idcliente As Integer, _
                              ByVal RazonSocial As String, _
                              ByVal NombreFantacia As String, _
                              ByVal Localidad As Integer, _
                              ByVal Domicilio As String, _
                              ByVal TelefonoParticular As String, _
                              ByVal TelefonoComercial As String, _
                              ByVal Email As String, _
                              ByVal Categoriaiva As Integer, _
                              ByVal NumerodeCuit As String, _
                              ByVal Vendedor As Integer, _
                              ByVal Zona As Integer, _
                              ByVal Secuencia As String, _
                              ByVal Estado As Integer) As DataSet
        Return odatabase.ExecuteDataSet("Clientes_Modificar", Idcliente, RazonSocial, NombreFantacia, Localidad, Domicilio, TelefonoParticular, TelefonoComercial, Email, Categoriaiva, NumerodeCuit, Vendedor, Zona, Secuencia, Estado)
    End Function
    Public Function Eliminar(ByVal Idcliente As Integer) As Double
        Return odatabase.ExecuteScalar("Clientes_Eliminar", Idcliente)
    End Function
    Public Function BuscarTodos() As DataSet
        Return odatabase.ExecuteDataSet("Clientes_BuscarTodos")
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
    Public Function Vendedor_Buscartodos() As DataSet
        Try
            Return odatabase.ExecuteDataSet("Vendedor_Buscartodos")
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
    Public Function Estado_Buscartodos() As DataSet
        Try
            Return odatabase.ExecuteDataSet("Estado_Buscartodos")
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw ex
        End Try
    End Function

End Class
