Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class C_compras
    Dim odatabase As Database

    Public Sub New()
        odatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub
End Class
