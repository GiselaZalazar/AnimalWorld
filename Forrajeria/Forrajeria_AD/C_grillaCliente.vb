Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class C_grillaCliente
    Dim odatabase As Database
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    Public Sub New()
        odatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub
    Public Function BuscarTodosC() As DataSet
        Try
            Return odatabase.ExecuteDataSet("Grilla_Cliente")
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw ex
        End Try
    End Function
End Class
