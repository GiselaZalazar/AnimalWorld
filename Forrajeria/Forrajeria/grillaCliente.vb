Imports Forrajeria_AD
Public Class frm_grillaCliente
    Private Sub BuscarTodos()

        Dim oDs As New DataSet
        Dim ogrilla As New C_grillaCliente

        oDs = ogrilla.BuscarTodosC
        grl_CLIENTE.DataSource = oDs.Tables(0)
        grl_CLIENTE.Columns(0).HeaderText = "Cod."
        grl_CLIENTE.Columns(0).Width = 50

        oDs = Nothing
        ogrilla = Nothing

    End Sub

    Private Sub grl_CLIENTE_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grl_CLIENTE.CellContentClick
        BuscarTodos()
    End Sub
End Class