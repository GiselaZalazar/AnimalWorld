Imports System.Data
Imports Forrajeria_AD
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frm_roveedores
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
                    txt_idproveedor.Enabled = False
                    cmd_aceptar.Enabled = True
                    cmd_cancelar.Enabled = True
                    cmd_eliminar.Enabled = False
                    cmd_modificar.Enabled = False
                    DesHabililarComandos()
                    Grilla.Enabled = False
                    Limpiar()
                    txt_razonsocial.Focus()
                    Panel1.BackColor = Color.Red
                    lbl_accion.Text = "Agregando"
                    lbl_accion.ForeColor = Color.White

                Case EstadodelFormulario.eEditar

                    HabililarEdicion()
                    txt_idproveedor.Enabled = True
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
                    txt_idproveedor.Enabled = True
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


        txt_idproveedor.Enabled = True
        txt_razonsocial.Enabled = True
        txt_nombreyapellido.Enabled = True
        cbo_localidad.Enabled = True
        txt_domicilio.Enabled = True
        txt_telefono.Enabled = True
        txt_email.Enabled = True
        cbo_categoriaiva.Enabled = True
        cbo_estado.Enabled = True
        txt_numerocuit.Enabled = True
        txt_ciudad.Enabled = True
        txt_codigopostal.Enabled = True
        cbo_producto.Enabled = True
        cbo_provincia.Enabled = True


    End Sub

    Private Sub DesHabililarEdicion()

        txt_idproveedor.Enabled = False
        txt_razonsocial.Enabled = False
        txt_nombreyapellido.Enabled = False
        cbo_localidad.Enabled = False
        txt_domicilio.Enabled = False
        txt_telefono.Enabled = False
        txt_email.Enabled = False
        cbo_categoriaiva.Enabled = False
        txt_numerocuit.Enabled = False
        cbo_estado.Enabled = False
        txt_ciudad.Enabled = False
        txt_codigopostal.Enabled = False
        cbo_producto.Enabled = False
        cbo_provincia.Enabled = False



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
    Private Sub Limpiar()

        CargarGrilla()
        txt_idproveedor.Text = ""
        cbo_localidad.Text = ""
        cbo_categoriaiva.Text = ""
        txt_domicilio.Text = ""
        txt_email.Text = ""
        txt_telefono.Text = ""
        txt_numerocuit.Text = ""
        txt_razonsocial.Text = ""
        txt_codigopostal.Text = ""
        txt_ciudad.Text = ""
        cbo_estado.Text = ""
        cbo_producto.Text = ""
        cbo_provincia.Text = ""



    End Sub
    Private Sub CargarGrilla()

        BuscarTodos()

    End Sub
#Region "Funciones"

    Private Function Validar() As Boolean

        If txt_razonsocial.Text = "" And txt_nombreyapellido.Text = "" And cbo_localidad.SelectedValue = "1" And txt_domicilio.Text = "" And txt_telefono.Text = "" And txt_email.Text = "" And cbo_categoriaiva.SelectedValue = "1" And txt_numerocuit.Text = "" And cbo_producto.SelectedValue = "1" And cbo_provincia.SelectedValue = "1" And txt_ciudad.Text = "" And cbo_estado.SelectedValue = "1" And txt_codigopostal.Text = "" Then

            MsgBox("Complete datos", MsgBoxStyle.Exclamation, "Mensaje")
            Return False

        End If


        Return True

    End Function

#End Region
#Region "Botones de Comando"

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

    Private Sub cmd_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_limpiar.Click
        Me.Estado = EstadodelFormulario.eConsulta
    End Sub

    Private Sub cmd_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_aceptar.Click
        Try

            If Validar() = True Then


                Dim Oproveedor As New C_proveedor


                If Me.Estado = EstadodelFormulario.eEditar Then
                    Oproveedor.Modificar(txt_idproveedor.Text, _
                                       txt_razonsocial.Text, _
                                       txt_nombreyapellido.Text, _
                                       cbo_localidad.SelectedValue, _
                                       txt_domicilio.Text, _
                                       txt_telefono.Text, _
                                       txt_email.Text, _
                                       cbo_categoriaiva.SelectedValue, _
                                       txt_numerocuit.Text, _
                                       cbo_provincia.SelectedValue, _
                                       cbo_producto.SelectedValue, _
                                       txt_ciudad.Text, _
                                       cbo_estado.SelectedValue, _
                                       txt_codigopostal.Text)



                    MsgBox("Se modificaron correctamente los datos " + txt_idproveedor.Text, MsgBoxStyle.Information, "Exitos!")
                End If
                If Me.Estado = EstadodelFormulario.eAgregar Then
                    Dim resultado As Integer
                    resultado = Oproveedor.Agregar(cbo_localidad.SelectedValue, txt_nombreyapellido.Text, txt_razonsocial.Text, txt_domicilio.Text, txt_telefono.Text, txt_email.Text, cbo_categoriaiva.SelectedValue, txt_numerocuit.Text, cbo_producto.SelectedValue, cbo_provincia.SelectedValue, txt_ciudad.Text, cbo_estado.SelectedValue, txt_codigopostal.Text)
                    MsgBox("Se agregaron correctamente los datos" + txt_nombreyapellido.Text + " con el código Nro: " + resultado.ToString, MsgBoxStyle.Information, "Exitos!")
                End If

                If Me.Estado = EstadodelFormulario.eEliminar Then
                    Dim resultado As Integer
                    resultado = Oproveedor.Eliminar(txt_idproveedor.Text)
                    MsgBox("Se eliminó correctamente el Proverdor" + txt_nombreyapellido.Text, MsgBoxStyle.Information, "Exitos!")

                End If



                Me.Estado = EstadodelFormulario.eConsulta

            End If

        Catch

            MsgBox("Sucedió un error", MsgBoxStyle.Critical, "Error")

        End Try
    End Sub

#End Region

#Region "Grilla"
    Private Sub BuscarTodos()

        Dim oDs As New DataSet
        Dim Oproveedor As New C_proveedor

        oDs = Oproveedor.BuscarTodos

        Grilla.DataSource = oDs.Tables(0)

        Grilla.Columns(0).HeaderText = "Cod."
        Grilla.Columns(0).Width = 50




        oDs = Nothing
        Oproveedor = Nothing
    End Sub
    Private Sub cargarLocalidad()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = 2CI809B2007251D\SQLEXPRESS; initial catalog = BD_GRUPO4; user id = sa; integrated Security = True ")
        conexion.Open()

        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Localidades_BuscarTodos")

        Dim adaptador As New SqlDataAdapter(comando)
        Dim ods As New DataSet

        adaptador.Fill(ods)

        If ods.Tables(0).Rows.Count > 0 Then

            cbo_localidad.DataSource = ods.Tables(0)
            cbo_localidad.DisplayMember = "Nombre"
            cbo_localidad.ValueMember = "id_localidad"
        End If
    End Sub

    Private Sub cargarCategortiaiva()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = 2CI809B2007251D\SQLEXPRESS; initial catalog = BD_GRUPO4; user id = sa; integrated Security = True ")
        conexion.Open()

        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("CategoriaIva_Buscartodas")

        Dim adaptador As New SqlDataAdapter(comando)
        Dim ods As New DataSet

        adaptador.Fill(ods)

        If ods.Tables(0).Rows.Count > 0 Then

            cbo_categoriaiva.DataSource = ods.Tables(0)
            cbo_categoriaiva.DisplayMember = "Nombre"
            cbo_categoriaiva.ValueMember = "id_categoria"
        End If
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
    Private Sub cargarprovincia()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = 2CI809B2007251D\SQLEXPRESS; initial catalog = BD_GRUPO4; user id = sa; integrated Security = True ")
        conexion.Open()

        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Provincia_Buscartodos")

        Dim adaptador As New SqlDataAdapter(comando)
        Dim ods As New DataSet

        adaptador.Fill(ods)

        If ods.Tables(0).Rows.Count > 0 Then

            cbo_provincia.DataSource = ods.Tables(0)
            cbo_provincia.DisplayMember = "Nombre"
            cbo_provincia.ValueMember = "id_provincia"
        End If
    End Sub
    Private Sub cargarproducto()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = 2CI809B2007251D\SQLEXPRESS; initial catalog = BD_GRUPO4; user id = sa; integrated Security = True ")
        conexion.Open()

        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Producto_BuscarTodos")

        Dim adaptador As New SqlDataAdapter(comando)
        Dim ods As New DataSet

        adaptador.Fill(ods)

        If ods.Tables(0).Rows.Count > 0 Then

            cbo_producto.DataSource = ods.Tables(0)
            cbo_producto.DisplayMember = "nombreproducto"
            cbo_producto.ValueMember = "id_prodcto"
        End If
    End Sub

#End Region

    Private Sub frm_roveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarGrilla()
        cargarproducto()
        cargarLocalidad()
        cargarCategortiaiva()
        cargarprovincia()
        cargarestado()
        cargarprovincia()


    End Sub


End Class