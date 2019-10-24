Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class C_subrubro
    Dim odatabase As Database
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader


    Public Sub New()
        odatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function Agregar(ByVal Nombre As String, ByVal ID_Rubro As Integer, ByVal Activo As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("SubRubros_Agregar", Nombre, ID_Rubro, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Modificar(ByVal ID_Subrubro As Integer, ByVal Nombre As String, ByVal ID_Rubro As Integer, ByVal Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("SubRubros_Modificar", ID_Subrubro, Nombre, ID_Rubro, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("SubRubros_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
End Class
