Imports System.Data
Imports Forrajeria_AD
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frm_vendedor
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
        txt_apellido.Enabled = True
        txt_dni.Enabled = True
        cbo_estado.Enabled = True
        cbo_tipodedocumento.Enabled = True



    End Sub

    Private Sub DesHabililarEdicion()

        txt_id.Enabled = False
        txt_nombre.Enabled = False
        txt_apellido.Enabled = False
        txt_dni.Enabled = False
        cbo_estado.Enabled = False
        cbo_tipodedocumento.Enabled = False




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
        txt_apellido.Text = ""
        txt_dni.Text = ""
        cbo_estado.Text = ""
        cbo_tipodedocumento.Text = ""
        txt_nombre.Text = ""
    End Sub
    Private Sub CargarGrilla()

        BuscarTodos()

    End Sub
    Private Function Validar() As Boolean

        If txt_nombre.Text = "" And cbo_estado.SelectedValue = "1" And cbo_tipodedocumento.SelectedValue = "1" And txt_apellido.Text = "" And txt_dni.Text = "" Then

            MsgBox("Complete datos", MsgBoxStyle.Exclamation, "Mensaje")
            Return False

        End If


        Return True

    End Function
    Private Sub cmd_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_limpiar.Click
        Me.Estado = EstadodelFormulario.eConsulta
        CargarGrilla()
    End Sub
    Private Sub cmd_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_modificar.Click
        Me.Estado = EstadodelFormulario.eEditar
        CargarGrilla()
    End Sub

    Private Sub cmd_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_agregar.Click
        Me.Estado = EstadodelFormulario.eAgregar
        CargarGrilla()
    End Sub

    Private Sub cmd_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click
        Me.Estado = EstadodelFormulario.eEliminar
        CargarGrilla()
    End Sub
    Private Sub cmd_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_aceptar.Click
        Try

            If Validar() = True Then


                Dim Ovendedor As New C_vendedor


                If Me.Estado = EstadodelFormulario.eEditar Then
                    Ovendedor.Modificar(txt_id.Text, _
                                       txt_nombre.Text, _
                                       txt_apellido.Text, _
                                       txt_dni.Text, _
                                       cbo_estado.SelectedValue, _
                                       cbo_tipodedocumento.SelectedValue)



                    MsgBox("Se modificaron correctamente los datos " + txt_id.Text, MsgBoxStyle.Information, "Exitos!")
                End If
                If Me.Estado = EstadodelFormulario.eAgregar Then
                    Dim resultado As Integer
                    resultado = Ovendedor.Agregar(txt_nombre.Text, cbo_estado.SelectedValue, cbo_tipodedocumento.SelectedValue, txt_apellido.Text, txt_dni.Text)
                    MsgBox("Se agregaron correctamente los datos" + txt_nombre.Text + " con el código Nro: " + resultado.ToString, MsgBoxStyle.Information, "Exitos!")
                End If

                If Me.Estado = EstadodelFormulario.eEliminar Then
                    Dim resultado As Integer
                    resultado = Ovendedor.Eliminar(txt_id.Text)
                    MsgBox("Se eliminó correctamente el cliente" + txt_nombre.Text, MsgBoxStyle.Information, "Exitos!")

                End If



                Me.Estado = EstadodelFormulario.eConsulta

            End If

        Catch

            MsgBox("Sucedió un error", MsgBoxStyle.Critical, "Error")

        End Try
    End Sub


#Region "Grilla"

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grilla.CellContentClick
        cmd_modificar.Enabled = True

    End Sub

#End Region

    Private Sub BuscarTodos()

        Dim oDs As New DataSet
        Dim Ovendedor As New C_vendedor

        oDs = Ovendedor.BuscarTodos

        Grilla.DataSource = oDs.Tables(0)

        Grilla.Columns(0).HeaderText = "Cod."
        Grilla.Columns(0).Width = 50




        oDs = Nothing
        Ovendedor = Nothing


    End Sub
    Private Sub frm_vendedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarestado()
        cargartipodocumento()
        CargarGrilla()
    End Sub

    Private Sub cmd_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancelar.Click
        If MsgBox("Esta seguro de Cancelar?" & vbCrLf & _
                "Se perderán las ultimas modificaciones", _
                vbYesNo, "Confirmacion de Accion") = MsgBoxResult.Yes Then

            Me.Estado = EstadodelFormulario.eConsulta

        End If


        Exit Sub
    End Sub

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
    Private Sub cargartipodocumento()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = 2CI809B2007251D\SQLEXPRESS; initial catalog = BD_GRUPO4; user id = sa; integrated Security = True ")
        conexion.Open()

        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("DocumentoTipo_BuscarTodos")

        Dim adaptador As New SqlDataAdapter(comando)
        Dim ods As New DataSet

        adaptador.Fill(ods)

        If ods.Tables(0).Rows.Count > 0 Then

            cbo_tipodedocumento.DataSource = ods.Tables(0)
            cbo_tipodedocumento.DisplayMember = "Nombre"
            cbo_tipodedocumento.ValueMember = "idDocumentoTipo"
        End If
    End Sub
End Class