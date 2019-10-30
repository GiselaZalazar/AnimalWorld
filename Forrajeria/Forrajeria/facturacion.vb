Imports System.Data
Imports Forrajeria_AD
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frm_facturacion

    Private Sub facturacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cmb_idproducto.Show()

    End Sub

    Private Sub cmb_idproducto_Click(sender As System.Object, e As System.EventArgs) Handles cmb_idproducto.Click
        grillaProducto.ShowDialog()
    End Sub

    Private Sub cmb_idCliente_Click(sender As System.Object, e As System.EventArgs) Handles cmb_idCliente.Click
        frm_grillaCliente.ShowDialog()
    End Sub


End Class