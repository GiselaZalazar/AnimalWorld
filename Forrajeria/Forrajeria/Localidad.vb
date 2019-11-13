Imports System.Data
Imports Forrajeria_AD
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frm_localidad

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
                    txt_idlocalidad.Enabled = False
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
                    txt_idlocalidad.Enabled = True
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
                    txt_idlocalidad.Enabled = True
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


        txt_idlocalidad.Enabled = True
        txt_nombre.Enabled = True
        cbo_provincia.Enabled = True
        txt_codigo.Enabled = True
        chk_activo.Enabled = True



    End Sub

    Private Sub DesHabililarEdicion()

        txt_idlocalidad.Enabled = False
        txt_nombre.Enabled = False
        cbo_provincia.Enabled = False
        txt_codigo.Enabled = False
        chk_activo.Enabled = False




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
        txt_idlocalidad.Text = ""
        cbo_provincia.Text = ""
        txt_codigo.Text = ""
        txt_nombre.Text = ""
        chk_activo.Checked = True
    End Sub
    Private Sub CargarGrilla()

        BuscarTodos()

    End Sub
    Private Function Validar() As Boolean

        If txt_nombre.Text = "" And cbo_provincia.SelectedValue = "1" And txt_codigo.Text = "" And chk_activo.Checked = True Then

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



#Region "Grilla"

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grilla.CellContentClick
        cmd_modificar.Enabled = True

    End Sub

#End Region

    Private Sub BuscarTodos()

        Dim oDs As New DataSet
        Dim Olocalidad As New C_localidad

        oDs = Olocalidad.BuscarTodos

        Grilla.DataSource = oDs.Tables(0)

        Grilla.Columns(0).HeaderText = "Cod."
        Grilla.Columns(0).Width = 50




        oDs = Nothing
        Olocalidad = Nothing


    End Sub
    Private Sub frm_provincia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarprovincia()

        CargarGrilla()
    End Sub

    Private Sub cmd_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_aceptar.Click
        Try

            If Validar() = True Then


                Dim Olocalidad As New C_localidad


                If Me.Estado = EstadodelFormulario.eEditar Then
                    Olocalidad.Modificar(txt_idlocalidad.Text, _
                                       txt_nombre.Text, _
                                       cbo_provincia.SelectedValue, _
                                       txt_codigo.Text, _
                                       chk_activo.Checked)



                    MsgBox("Se modificaron correctamente los datos " + txt_idlocalidad.Text, MsgBoxStyle.Information, "Exitos!")
                End If
                If Me.Estado = EstadodelFormulario.eAgregar Then
                    Dim resultado As Integer
                    resultado = Olocalidad.Agregar(txt_nombre.Text, cbo_provincia.SelectedValue, txt_codigo.Text, chk_activo.Checked)
                    MsgBox("Se agregaron correctamente los datos" + txt_nombre.Text + " con el código Nro: " + resultado.ToString, MsgBoxStyle.Information, "Exitos!")
                End If

                If Me.Estado = EstadodelFormulario.eEliminar Then
                    Dim resultado As Integer
                    resultado = Olocalidad.Eliminar(txt_idlocalidad.Text)
                    MsgBox("Se eliminó correctamente la localidad" + txt_nombre.Text, MsgBoxStyle.Information, "Exitos!")

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

    Private Sub cargarprovincia()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = USUARIO-PC; initial catalog = BD_GRUPO4; user id = sa; integrated Security = True ")
        'conexion = New SqlConnection("data source = 2CI809B2007251D\SQLEXPRESS; initial catalog = BD_GRUPO4; user id = sa; integrated Security = True ")
        conexion.Open()

        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Provincia_BuscarTodos")

        Dim adaptador As New SqlDataAdapter(comando)
        Dim ods As New DataSet

        adaptador.Fill(ods)

        If ods.Tables(0).Rows.Count > 0 Then

            cbo_provincia.DataSource = ods.Tables(0)
            cbo_provincia.DisplayMember = "Nombre"
            cbo_provincia.ValueMember = "id_provincia"
        End If
    End Sub



End Class