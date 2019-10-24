Imports System.Data
Imports Forrajeria_AD
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frm_rubros
#Region "Variables"

    Private eEstado As EstadodelFormulario

#End Region

#Region "Enumeraciones"

    Public Enum EstadodelFormulario
        eConsulta = 1
        eAgregar = 2
        eEditar = 3
        eEliminar = 4
    End Enum

#End Region

#Region "Propiedades"


    Public Property Estado() As EstadodelFormulario
        Get
            Return eEstado
        End Get
        Set(ByVal vNewValue As EstadodelFormulario)


            Select Case vNewValue

                Case EstadodelFormulario.eConsulta

                    Limpiar()
                    DesHabililarEdicion()
                    DesHabililarComandos()
                    cmd_agregar.Enabled = True
                    cmd_aceptar.Enabled = False
                    cmd_cancelar.Enabled = False
                    Grilla.Enabled = True
                    Panel1.BackColor = Color.White
                    lbl_accion.Text = "Consultando"
                    lbl_accion.ForeColor = Color.Black

                Case EstadodelFormulario.eAgregar

                    HabililarEdicion()
                    txt_id.Enabled = False
                    cmd_aceptar.Enabled = True
                    cmd_cancelar.Enabled = True
                    DesHabililarComandos()
                    Grilla.Enabled = False
                    Limpiar()
                    txt_nombre.Focus()
                    Panel1.BackColor = Color.Red
                    lbl_accion.Text = "Agregando"
                    lbl_accion.ForeColor = Color.White

                Case EstadodelFormulario.eEditar

                    HabililarEdicion()
                    txt_id.Enabled = False
                    cmd_aceptar.Enabled = True
                    cmd_cancelar.Enabled = True
                    DesHabililarComandos()
                    Grilla.Enabled = False
                    Panel1.BackColor = Color.Red
                    lbl_accion.Text = "Modificando"
                    lbl_accion.ForeColor = Color.White

                Case EstadodelFormulario.eEliminar

                    HabililarEdicion()
                    txt_id.Enabled = True
                    cmd_aceptar.Enabled = True
                    cmd_cancelar.Enabled = True
                    cmd_modificar.Enabled = False
                    cmd_eliminar.Enabled = True
                    DesHabililarComandos()
                    Grilla.Enabled = False
                    Panel1.BackColor = Color.Red
                    lbl_accion.Text = "Eliminando"
                    lbl_accion.ForeColor = Color.White


            End Select


            eEstado = vNewValue
        End Set
    End Property

#End Region
#Region "Formulario"
    Private Sub frm_rubros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Estado = EstadodelFormulario.eConsulta
    End Sub
#End Region
#Region "Procedimientos"
    Public Sub CargarGrilla()
        BuscarTodos()
    End Sub

    Private Sub BuscarTodos()

        Dim oDs As New DataSet
        Dim Orubros As New C_rubros

        oDs = Orubros.BuscarTodos

        Grilla.DataSource = oDs.Tables(0)

        Grilla.Columns(0).HeaderText = "Cod."
        Grilla.Columns(0).Width = 50




        oDs = Nothing
        Orubros = Nothing


    End Sub
    Private Sub BuscarPorID(ByVal ID As Integer)


        Dim oDs As New DataSet
        Dim oRubro As New C_rubros

        oDs = oRubro.BuscarPorID(ID)
        txt_id.Text = oDs.Tables(0).Rows(0).Item("ID_Rubro")
        txt_nombre.Text = oDs.Tables(0).Rows(0).Item("Nombre")
        chk_activo.Checked = oDs.Tables(0).Rows(0).Item("Activo")

        oDs = Nothing
        oRubro = Nothing

    End Sub

    Private Sub Limpiar()

        CargarGrilla()
        txt_id.Text = ""
        txt_nombre.Text = ""
        chk_activo.Checked = True

    End Sub

    Private Sub HabililarEdicion()

        txt_id.Enabled = True
        txt_nombre.Enabled = True
        chk_activo.Enabled = True

    End Sub

    Private Sub DesHabililarEdicion()

        txt_id.Enabled = False
        txt_nombre.Enabled = False
        chk_activo.Enabled = False

    End Sub

    Private Sub HabililarComandos()

        cmd_agregar.Enabled = True
        cmd_modificar.Enabled = True
        cmd_eliminar.Enabled = True



    End Sub

    Private Sub DesHabililarComandos()

        cmd_agregar.Enabled = False
        cmd_modificar.Enabled = False
        cmd_eliminar.Enabled = False

    End Sub

#End Region
#Region "Botones de Comando"

#End Region

    Private Sub cmd_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_limpiar.Click
        Me.Estado = EstadodelFormulario.eConsulta
    End Sub

    Private Sub cmd_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_agregar.Click
        Me.Estado = EstadodelFormulario.eAgregar
    End Sub

    Private Sub cmd_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_modificar.Click
        Me.Estado = EstadodelFormulario.eEditar
    End Sub

    Private Sub cmd_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click
        Me.Estado = EstadodelFormulario.eEliminar
    End Sub

    Private Sub cmd_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_aceptar.Click
        Try

            If Validar() = True Then


                Dim oRubro As New C_rubros


                If Me.Estado = EstadodelFormulario.eEditar Then
                    oRubro.Modificar(txt_id.Text, txt_nombre.Text, chk_activo.Checked)
                    MsgBox("Se modificó correctamente el rubro el código Nro: " + txt_id.Text, MsgBoxStyle.Information, "Exitos!")
                End If

                If Me.Estado = EstadodelFormulario.eAgregar Then
                    Dim resultado As Integer
                    resultado = oRubro.Agregar(txt_nombre.Text, chk_activo.Checked)
                    MsgBox("Se agregó correctamente el rubro " + txt_nombre.Text + " con el código Nro: " + resultado.ToString, MsgBoxStyle.Information, "Exitos!")
                End If

                Me.Estado = EstadodelFormulario.eConsulta

            End If

        Catch

            MsgBox("Sucedió un error", MsgBoxStyle.Critical, "Error")

        End Try
    End Sub

    Private Sub cmd_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancelar.Click
        If MsgBox("Esta seguro de Cancelar?" & vbCrLf & _
       "Se perderán las ultimas modificaciones", _
       vbYesNo, "Confirmacion de Accion") = MsgBoxResult.Yes Then

            Me.Estado = EstadodelFormulario.eConsulta

        End If

    End Sub
#Region "Funciones"
    Private Function Validar() As Boolean

        If txt_nombre.Text = "" Then

            MsgBox("Complete el nombre del rubro", MsgBoxStyle.Exclamation, "Mensaje")
            Return False

        End If


        Return True

    End Function
#End Region

    Private Sub Grilla_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grilla.CellContentClick

        cmd_modificar.Enabled = True
        cmd_eliminar.Enabled = True
    End Sub
End Class