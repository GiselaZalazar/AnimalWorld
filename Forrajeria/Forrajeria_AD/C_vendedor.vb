Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class C_vendedor

    Dim odatabase As Database
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    Public Sub New()
        odatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub
    Public Function Agregar(ByVal Nombre As String, _
                    ByVal Estado As Integer, _
                     ByVal DocumentoTipo As Integer, _
                    ByVal Apellido As String, _
                    ByVal DNI As String) As Double

        Return odatabase.ExecuteScalar("Vendedor_Agregar", Nombre, _
                                                         Estado, _
                                                        DocumentoTipo, _
                                                        Apellido, _
                                                           DNI)
    End Function
    Public Function Modificar(ByVal Iddocumentotipo As Integer, _
                     ByVal Nombre As String, _
                    ByVal Estado As Integer, _
                     ByVal DocumentoTipo As Integer, _
                    ByVal Apellido As String, _
                    ByVal DNI As String) As DataSet
        Return odatabase.ExecuteDataSet("Vendedor_Modificar", Iddocumentotipo, Nombre, Estado, DocumentoTipo, Apellido, DNI)
    End Function
    Public Function Eliminar(ByVal Iddocumentotipo As Integer) As Double
        Return odatabase.ExecuteScalar("Vendedor_Eliminar", Iddocumentotipo)
    End Function
    Public Function BuscarTodos() As DataSet
        Return odatabase.ExecuteDataSet("Vendedor_BuscarTodos")
    End Function
    Public Function Estado_Buscartodos() As DataSet
        Try
            Return odatabase.ExecuteDataSet("Estado_Buscartodos")
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw ex
        End Try
    End Function
    Public Function DocumentoTipo_BuscarTodos() As DataSet
        Try
            Return odatabase.ExecuteDataSet("DocumentoTipo_BuscarTodos")
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw ex
        End Try
    End Function
End Class
