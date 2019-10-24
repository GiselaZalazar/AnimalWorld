Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class C_rubros
    Dim odatabase As Database
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader


    Public Sub New()
        odatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub
    Public Function Agregar(ByVal Nombre As String, ByVal Activo As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("Rubros_Agregar", Nombre, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Modificar(ByVal ID_Rubro As Integer, ByVal Nombre As String, ByVal Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Rubros_Modificar", ID_Rubro, Nombre, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Eliminar(ByVal Idrubro As Integer) As Double
        Return odatabase.ExecuteScalar("Rubros_Eliminar", Idrubro)
    End Function
    Public Function BuscarTodos() As DataSet
        Return odatabase.ExecuteDataSet("Rubros_BuscarTodos")
    End Function
    Public Function BuscarPorID(ByVal ID_Rubro As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Rubros_BuscarPorID", ID_Rubro)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

End Class
