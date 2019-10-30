Imports System.Data
Imports Forrajeria_AD
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frm_cliente
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
                    cmd_agregarcliente.Enabled = True
                    cmd_aceptar.Enabled = False
                    cmd_cancelar.Enabled = False
                    cmd_modificarcliente.Enabled = True
                    cmd_eliminar.Enabled = True
                    Grilla.Enabled = True
                    Panel1.BackColor = Color.White
                    lbl_accion.Text = "Consultando"
                    lbl_accion.ForeColor = Color.Black

                Case EstadodelFormulario.eAgregar

                    HabililarEdicion()
                    txt_idcliente.Enabled = False
                    cmd_aceptar.Enabled = True
                    cmd_cancelar.Enabled = True
                    cmd_eliminar.Enabled = False
                    cmd_modificarcliente.Enabled = False
                    DesHabililarComandos()
                    Grilla.Enabled = False
                    Limpiar()
                    txt_razonsocial.Focus()
                    Panel1.BackColor = Color.Red
                    lbl_accion.Text = "Agregando"
                    lbl_accion.ForeColor = Color.White

                Case EstadodelFormulario.eEditar

                    HabililarEdicion()
                    txt_idcliente.Enabled = True
                    cmd_aceptar.Enabled = True
                    cmd_cancelar.Enabled = True
                    cmd_modificarcliente.Enabled = True
                    cmd_eliminar.Enabled = False
                    DesHabililarComandos()
                    Grilla.Enabled = False
                    Panel1.BackColor = Color.Red
                    lbl_accion.Text = "Modificando"
                    lbl_accion.ForeColor = Color.White

                Case EstadodelFormulario.eEliminar

                    HabililarEdicion()
                    txt_idcliente.Enabled = True
                    cmd_aceptar.Enabled = True
                    cmd_cancelar.Enabled = True
                    cmd_modificarcliente.Enabled = False
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


        txt_idcliente.Enabled = True
        txt_razonsocial.Enabled = True
        txt_nombrefantacia.Enabled = True
        cbo_localidad.Enabled = True
        txt_domicilio.Enabled = True
        txt_telefonoparticular.Enabled = True
        txt_teledonocomercial.Enabled = True
        txt_email.Enabled = True
        cbo_categoriaiva.Enabled = True
        txt_numerodecuit.Enabled = True
        cbo_vendedor.Enabled = True
        cbo_zona.Enabled = True
        txt_secuencia.Enabled = True
        cbo_estado.Enabled = True

     

    End Sub

    Private Sub DesHabililarEdicion()

        txt_idcliente.Enabled = False
        txt_razonsocial.Enabled = False
        txt_nombrefantacia.Enabled = False
        cbo_localidad.Enabled = False
        txt_domicilio.Enabled = False
        txt_telefonoparticular.Enabled = False
        txt_teledonocomercial.Enabled = False
        txt_email.Enabled = False
        cbo_categoriaiva.Enabled = False
        txt_numerodecuit.Enabled = False
        cbo_vendedor.Enabled = False
        cbo_zona.Enabled = False
        txt_secuencia.Enabled = False
        cbo_estado.Enabled = False

     

    End Sub

    Private Sub HabililarComandos()

        cmd_agregarcliente.Enabled = True
        cmd_modificarcliente.Enabled = True


    End Sub

    Private Sub DesHabililarComandos()

        cmd_agregarcliente.Enabled = False
        cmd_modificarcliente.Enabled = False


    End Sub
    Private Sub Limpiar()

        CargarGrilla()
        txt_idcliente.Text = ""
        cbo_localidad.Text = ""
        cbo_categoriaiva.Text = ""
        cbo_vendedor.Text = ""
        cbo_zona.Text = ""
        txt_domicilio.Text = ""
        txt_email.Text = ""
        txt_telefonoparticular.Text = ""
        txt_teledonocomercial.Text = ""
        txt_numerodecuit.Text = ""
        txt_razonsocial.Text = ""
        txt_nombrefantacia.Text = ""
        txt_secuencia.Text = ""
        cbo_estado.Text = ""


    End Sub
    Private Sub CargarGrilla()

        BuscarTodos()

    End Sub


    Private Sub frm_cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Estado = EstadodelFormulario.eConsulta
        cargarLocalidad()
        cargarzona()
        cargarCategortiaiva()
        cargarvendedor()

        cargarestado()

    End Sub
#Region "Funciones"

    Private Function Validar() As Boolean

        If txt_razonsocial.Text = "" And txt_nombrefantacia.Text = "" And cbo_localidad.SelectedValue = "1" And txt_domicilio.Text = "" And txt_telefonoparticular.Text = "" And txt_teledonocomercial.Text = "" And txt_email.Text = "" And cbo_categoriaiva.SelectedValue = "1" And txt_numerodecuit.Text = "" And cbo_vendedor.SelectedValue = "1" And cbo_zona.SelectedValue = "1" And txt_secuencia.Text = "1" And cbo_estado.SelectedValue = "1" Then

            MsgBox("Complete datos", MsgBoxStyle.Exclamation, "Mensaje")
            Return False

        End If


        Return True

    End Function

#End Region
#Region "Botones de Comando"


    Private Sub cmd_limpiarcliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_limpiarcliente.Click
        Me.Estado = EstadodelFormulario.eConsulta
    End Sub

    Private Sub cmd_modificarcliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_modificarcliente.Click
        Me.Estado = EstadodelFormulario.eEditar
        CargarGrilla()
    End Sub

    Private Sub cmd_agregarcliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_agregarcliente.Click
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


                Dim Ocliente As New C_Clientes


                If Me.Estado = EstadodelFormulario.eEditar Then
                    Ocliente.Modificar(txt_idcliente.Text, _
                                       txt_razonsocial.Text, _
                                       txt_nombrefantacia.Text, _
                                       cbo_localidad.SelectedValue, _
                                       txt_domicilio.Text, _
                                       txt_teledonocomercial.Text, _
                                       txt_telefonoparticular.Text, _
                                       txt_email.Text, _
                                       cbo_categoriaiva.SelectedValue, _
                                       txt_numerodecuit.Text, _
                                       cbo_vendedor.SelectedValue, _
                                       cbo_zona.SelectedValue, _
                                       txt_secuencia.Text, _
                                       cbo_estado.SelectedValue)



                    MsgBox("Se modificaron correctamente los datos " + txt_idcliente.Text, MsgBoxStyle.Information, "Exitos!")
                End If
            If Me.Estado = EstadodelFormulario.eAgregar Then
                    Dim resultado As Integer
                    resultado = Ocliente.Agregar(txt_razonsocial.Text, txt_nombrefantacia.Text, cbo_localidad.SelectedValue, txt_domicilio.Text, txt_telefonoparticular.Text, txt_teledonocomercial.Text, txt_email.Text, cbo_categoriaiva.SelectedValue, txt_numerodecuit.Text, cbo_vendedor.SelectedValue, cbo_zona.SelectedValue, txt_secuencia.Text, cbo_estado.SelectedValue)
                    MsgBox("Se agregaron correctamente los datos" + txt_razonsocial.Text + " con el código Nro: " + resultado.ToString, MsgBoxStyle.Information, "Exitos!")
                End If

                If Me.Estado = EstadodelFormulario.eEliminar Then
                    Dim resultado As Integer
                    resultado = Ocliente.Eliminar(txt_idcliente.Text)
                    MsgBox("Se eliminó correctamente el cliente" + txt_razonsocial.Text, MsgBoxStyle.Information, "Exitos!")

                End If


       
            Me.Estado = EstadodelFormulario.eConsulta

            End If

        Catch

            MsgBox("Sucedió un error", MsgBoxStyle.Critical, "Error")

        End Try
    End Sub

#End Region
#Region "Grilla"

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grilla.CellContentClick
        'Try
        txt_idcliente.Text = Grilla.CurrentRow.Cells(0).Value.ToString()
        txt_nombrefantacia.Text = Grilla.CurrentRow.Cells(1).Value.ToString()
        txt_razonsocial.Text = Grilla.CurrentRow.Cells(2).Value.ToString()

        cbo_localidad.Text = Grilla.CurrentRow.Cells(3).Value.ToString()


        txt_domicilio.Text = Grilla.CurrentRow.Cells(4).Value.ToString()
        txt_numerodecuit.Text = Grilla.CurrentRow.Cells(5).Value.ToString()
        txt_teledonocomercial.Text = Grilla.CurrentRow.Cells(6).Value.ToString()
        txt_telefonoparticular.Text = Grilla.CurrentRow.Cells(7).Value.ToString()
        txt_email.Text = Grilla.CurrentRow.Cells(8).Value.ToString()
        cbo_vendedor.Text = Grilla.CurrentRow.Cells(9).Value.ToString()
        cbo_estado.Text = Grilla.CurrentRow.Cells(10).Value.ToString()
        cbo_categoriaiva.Text = Grilla.CurrentRow.Cells(11).Value.ToString()
        cbo_zona.Text = Grilla.CurrentRow.Cells(12).Value.ToString()
        txt_secuencia.Text = Grilla.CurrentRow.Cells(13).Value.ToString()

        'Catch
        'End Try


    End Sub

#End Region

    Private Sub BuscarTodos()

        Dim oDs As New DataSet
        Dim Oclientes As New C_Clientes

        oDs = Oclientes.BuscarTodos

        Grilla.DataSource = oDs.Tables(0)

        Grilla.Columns(0).HeaderText = "Cod."
        Grilla.Columns(0).Width = 50




        oDs = Nothing
        Oclientes = Nothing


    End Sub

    Private Sub cmd_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancelar.Click
        If MsgBox("Esta seguro de Cancelar?" & vbCrLf & _
       "Se perderán las ultimas modificaciones", _
       vbYesNo, "Confirmacion de Accion") = MsgBoxResult.Yes Then

            Me.Estado = EstadodelFormulario.eConsulta

        End If


        Exit Sub
    End Sub

    Private Sub cargarLocalidad()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = USUARIO-PC; initial catalog = BD_GRUPO4; user id = sa; integrated Security = True ")
        'conexion = New SqlConnection("data source = 2CI809B2007251D\SQLEXPRESS; initial catalog = BD_GRUPO4; user id = sa; integrated Security = True ")
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

        conexion = New SqlConnection("data source = USUARIO-PC; initial catalog = BD_GRUPO4; user id = sa; integrated Security = True ")
        'conexion = New SqlConnection("data source = 2CI809B2007251D\SQLEXPRESS; initial catalog = BD_GRUPO4; user id = sa; integrated Security = True ")
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

    Private Sub cargarvendedor()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = USUARIO-PC; initial catalog = BD_GRUPO4; user id = sa; integrated Security = True ")
        'conexion = New SqlConnection("data source = 2CI809B2007251D\SQLEXPRESS; initial catalog = BD_GRUPO4; user id = sa; integrated Security = True ")
        conexion.Open()

        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Vendedor_Buscartodos")

        Dim adaptador As New SqlDataAdapter(comando)
        Dim ods As New DataSet

        adaptador.Fill(ods)

        If ods.Tables(0).Rows.Count > 0 Then

            cbo_vendedor.DataSource = ods.Tables(0)
            cbo_vendedor.DisplayMember = "Nombre"
            cbo_vendedor.ValueMember = "id_vendedor"
        End If
    End Sub
    Private Sub cargarzona()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = USUARIO-PC; initial catalog = BD_GRUPO4; user id = sa; integrated Security = True ")
        ' conexion = New SqlConnection("data source = 2CI809B2007251D\SQLEXPRESS; initial catalog = BD_GRUPO4; user id = sa; integrated Security = True ")
        conexion.Open()

        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Zona_Buscartodos")

        Dim adaptador As New SqlDataAdapter(comando)
        Dim ods As New DataSet

        adaptador.Fill(ods)

        If ods.Tables(0).Rows.Count > 0 Then

            cbo_zona.DataSource = ods.Tables(0)
            cbo_zona.DisplayMember = "Nombre"
            cbo_zona.ValueMember = "id_zona"
        End If
    End Sub
    Private Sub cargarestado()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = USUARIO-PC; initial catalog = BD_GRUPO4; user id = sa; integrated Security = True ")
        ' conexion = New SqlConnection("data source = 2CI809B2007251D\SQLEXPRESS; initial catalog = BD_GRUPO4; user id = sa; integrated Security = True ")
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
End Class