Imports System.Data
Imports Forrajeria_AD
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frm_producto
    Private eEstado As EstadodelFormulario
    Public Enum EstadodelFormulario
        eConsulta = 1
        eAgregar = 2
        eEditar = 3
        eEliminar = 4
    End Enum

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
                    cmd_modificar.Enabled = True
                    cmd_eliminar.Enabled = True
                    Grilla.Enabled = True
                    Panel1.BackColor = Color.White
                    lbl_accion.Text = "Consultando"
                    lbl_accion.ForeColor = Color.Black

                Case EstadodelFormulario.eAgregar

                    HabililarEdicion()
                    txt_id.Enabled = False
                    cmd_aceptar.Enabled = True
                    cmd_cancelar.Enabled = True
                    cmd_eliminar.Enabled = False
                    cmd_modificar.Enabled = False
                    DesHabililarComandos()
                    Grilla.Enabled = False
                    Limpiar()
                    txt_nombre.Focus()
                    Panel1.BackColor = Color.Red
                    lbl_accion.Text = "Agregando"
                    lbl_accion.ForeColor = Color.White

                Case EstadodelFormulario.eEditar

                    HabililarEdicion()
                    txt_id.Enabled = True
                    cmd_aceptar.Enabled = True
                    cmd_cancelar.Enabled = True
                    cmd_modificar.Enabled = True
                    cmd_eliminar.Enabled = False
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
    Private Sub HabililarEdicion()


        txt_id.Enabled = True
        txt_nombre.Enabled = True
        txt_descripcion.Enabled = True
        cbo_subrubro.Enabled = True
        txt_cantidad.Enabled = True
        txt_preciounitario.Enabled = True
        cbo_unidaddemedida.Enabled = True
        cbo_estado.Enabled = True



    End Sub

    Private Sub DesHabililarEdicion()

        txt_id.Enabled = False
        txt_nombre.Enabled = False
        txt_descripcion.Enabled = False
        cbo_subrubro.Enabled = False
        txt_cantidad.Enabled = False
        txt_preciounitario.Enabled = False
        cbo_unidaddemedida.Enabled = False
        cbo_estado.Enabled = False



    End Sub

    Private Sub HabililarComandos()

        cmd_agregar.Enabled = True
        cmd_modificar.Enabled = True


    End Sub

    Private Sub DesHabililarComandos()

        cmd_agregar.Enabled = False
        cmd_modificar.Enabled = False


    End Sub
    Private Sub Limpiar()

        CargarGrilla()
        txt_id.Text = ""
        cbo_estado.Text = ""
        cbo_subrubro.Text = ""
        cbo_unidaddemedida.Text = ""
        txt_nombre.Text = ""
        txt_descripcion.Text = ""
        txt_cantidad.Text = ""
        txt_preciounitario.Text = ""
        cbo_estado.Text = ""


    End Sub
    Private Sub CargarGrilla()



    End Sub
    Private Sub Producto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Estado = EstadodelFormulario.eConsulta
        CargarGrilla()
        cargarestado()
    End Sub
#Region "Funciones"

    Private Function Validar() As Boolean

        If txt_nombre.Text = "" And txt_descripcion.Text = "" And cbo_subrubro.SelectedValue = "1" And txt_cantidad.Text = "" And txt_preciounitario.Text = "" And cbo_unidaddemedida.SelectedValue = "1" And cbo_estado.SelectedValue = "1" Then

            MsgBox("Complete datos", MsgBoxStyle.Exclamation, "Mensaje")
            Return False

        End If


        Return True

    End Function

#End Region
#Region "Botones de Comando"

    Private Sub cmd_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_limpiar.Click
        Me.Estado = EstadodelFormulario.eConsulta
    End Sub

    Private Sub cmd_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_agregar.Click
        Me.Estado = EstadodelFormulario.eAgregar

        CargarGrilla()
    End Sub

    Private Sub cmd_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_modificar.Click
        Me.Estado = EstadodelFormulario.eEditar
        CargarGrilla()
    End Sub

    Private Sub cmd_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click
        Me.Estado = EstadodelFormulario.eEliminar

        CargarGrilla()
    End Sub

    Private Sub cmd_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_aceptar.Click
        Try

            If Validar() = True Then


                Dim Oproducto As New C_producto


                If Me.Estado = EstadodelFormulario.eEditar Then
                    Oproducto.Modificar(txt_id.Text, _
                                       txt_nombre.Text, _
                                       txt_descripcion.Text, _
                                       cbo_subrubro.SelectedValue, _
                                       txt_cantidad.Text, _
                                       txt_preciounitario.Text, _
                                       cbo_unidaddemedida.SelectedValue, _
                                       cbo_estado.SelectedValue)



                    MsgBox("Se modificaron correctamente los datos " + txt_id.Text, MsgBoxStyle.Information, "Exitos!")
                End If
                If Me.Estado = EstadodelFormulario.eAgregar Then
                    Dim resultado As Integer
                    resultado = Oproducto.Agregar(txt_nombre.Text, txt_descripcion.Text, cbo_subrubro.SelectedValue, txt_cantidad.Text, txt_preciounitario.Text, cbo_unidaddemedida.SelectedValue, cbo_estado.SelectedValue)
                    MsgBox("Se agregaron correctamente los datos" + txt_nombre.Text + " con el código Nro: " + resultado.ToString, MsgBoxStyle.Information, "Exitos!")
                End If

                If Me.Estado = EstadodelFormulario.eEliminar Then
                    Dim resultado As Integer
                    resultado = Oproducto.Eliminar(txt_id.Text)
                    MsgBox("Se eliminó correctamente el cliente" + txt_nombre.Text, MsgBoxStyle.Information, "Exitos!")

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


        Exit Sub
    End Sub

#End Region
#Region "Grilla"
    Private Sub BuscarTodos()

        Dim oDs As New DataSet
        Dim Oproducto As New C_producto

        oDs = Oproducto.BuscarTodos

        Grilla.DataSource = oDs.Tables(0)

        Grilla.Columns(0).HeaderText = "Cod."
        Grilla.Columns(0).Width = 50




        oDs = Nothing
        Oproducto = Nothing


    End Sub
#End Region
#Region "Combos"
    Private Sub cargarestado()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = 2CI809B2007251D\SQLEXPRESS; initial catalog = BD_GRUPO4; user id = sa; integrated Security = True ")
        conexion.Open()

        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Estado_Buscartodos")

        Dim adaptador As New SqlDataAdapter(comando)
        Dim ods As New DataSet

        adaptador.Fill(ods)

        If ods.Tables(0).Rows.Count > 0 Then

            cbo_estado.DataSource = ods.Tables(0)
            cbo_estado.DisplayMember = "Nombre"
            cbo_estado.ValueMember = "id_estado"
        End If
    End Sub
#End Region


End Class