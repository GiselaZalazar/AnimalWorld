Imports Forrajeria_AD
Public Class grillaProducto

    Private Sub BuscarTodos()

        Dim oDs As New DataSet
        Dim ogrilla As New C_grillaProducto

        oDs = ogrilla.BuscarTodosP
        grl_PROD.DataSource = oDs.Tables(0)
        grl_PROD.Columns(0).HeaderText = "Cod."
        grl_PROD.Columns(0).Width = 50

        oDs = Nothing
        ogrilla = Nothing
    End Sub

    Private Sub grl_PROD_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grl_PROD.CellContentClick
        BuscarTodos()
    End Sub

    Private Sub grillaProducto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        BuscarTodos()
    End Sub
End Class