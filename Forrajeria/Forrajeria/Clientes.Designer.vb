<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cliente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_idcliente = New System.Windows.Forms.Label()
        Me.lbl_idlocalidad = New System.Windows.Forms.Label()
        Me.lbl_idcuitiva = New System.Windows.Forms.Label()
        Me.lbl_idvendedoranual = New System.Windows.Forms.Label()
        Me.lbl_idzona = New System.Windows.Forms.Label()
        Me.lbl_domiciliocliente = New System.Windows.Forms.Label()
        Me.lbl_emailcliente = New System.Windows.Forms.Label()
        Me.lbl_telefonoparticularcliente = New System.Windows.Forms.Label()
        Me.lbl_telefonocomercialcliente = New System.Windows.Forms.Label()
        Me.lbl_numerodclienteecuit = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_idcliente = New System.Windows.Forms.TextBox()
        Me.txt_domicilio = New System.Windows.Forms.TextBox()
        Me.txt_telefonoparticular = New System.Windows.Forms.TextBox()
        Me.txt_teledonocomercial = New System.Windows.Forms.TextBox()
        Me.txt_numerodecuit = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_razonsocial = New System.Windows.Forms.TextBox()
        Me.txt_secuencia = New System.Windows.Forms.TextBox()
        Me.txt_nombrefantacia = New System.Windows.Forms.TextBox()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.cmd_limpiarcliente = New System.Windows.Forms.Button()
        Me.cmd_agregarcliente = New System.Windows.Forms.Button()
        Me.cmd_modificarcliente = New System.Windows.Forms.Button()
        Me.cmd_aceptar = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_accion = New System.Windows.Forms.Label()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cbo_localidad = New System.Windows.Forms.ComboBox()
        Me.cbo_categoriaiva = New System.Windows.Forms.ComboBox()
        Me.cbo_vendedor = New System.Windows.Forms.ComboBox()
        Me.cbo_zona = New System.Windows.Forms.ComboBox()
        Me.cbo_estado = New System.Windows.Forms.ComboBox()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_idcliente
        '
        Me.lbl_idcliente.AutoSize = True
        Me.lbl_idcliente.Location = New System.Drawing.Point(24, 9)
        Me.lbl_idcliente.Name = "lbl_idcliente"
        Me.lbl_idcliente.Size = New System.Drawing.Size(16, 13)
        Me.lbl_idcliente.TabIndex = 0
        Me.lbl_idcliente.Text = "Id"
        '
        'lbl_idlocalidad
        '
        Me.lbl_idlocalidad.AutoSize = True
        Me.lbl_idlocalidad.Location = New System.Drawing.Point(24, 37)
        Me.lbl_idlocalidad.Name = "lbl_idlocalidad"
        Me.lbl_idlocalidad.Size = New System.Drawing.Size(53, 13)
        Me.lbl_idlocalidad.TabIndex = 1
        Me.lbl_idlocalidad.Text = "Localidad"
        '
        'lbl_idcuitiva
        '
        Me.lbl_idcuitiva.AutoSize = True
        Me.lbl_idcuitiva.Location = New System.Drawing.Point(24, 62)
        Me.lbl_idcuitiva.Name = "lbl_idcuitiva"
        Me.lbl_idcuitiva.Size = New System.Drawing.Size(72, 13)
        Me.lbl_idcuitiva.TabIndex = 2
        Me.lbl_idcuitiva.Text = "Categoria IVA"
        '
        'lbl_idvendedoranual
        '
        Me.lbl_idvendedoranual.AutoSize = True
        Me.lbl_idvendedoranual.Location = New System.Drawing.Point(24, 89)
        Me.lbl_idvendedoranual.Name = "lbl_idvendedoranual"
        Me.lbl_idvendedoranual.Size = New System.Drawing.Size(56, 13)
        Me.lbl_idvendedoranual.TabIndex = 3
        Me.lbl_idvendedoranual.Text = "Vendedor "
        '
        'lbl_idzona
        '
        Me.lbl_idzona.AutoSize = True
        Me.lbl_idzona.Location = New System.Drawing.Point(24, 116)
        Me.lbl_idzona.Name = "lbl_idzona"
        Me.lbl_idzona.Size = New System.Drawing.Size(32, 13)
        Me.lbl_idzona.TabIndex = 4
        Me.lbl_idzona.Text = "Zona"
        '
        'lbl_domiciliocliente
        '
        Me.lbl_domiciliocliente.AutoSize = True
        Me.lbl_domiciliocliente.Location = New System.Drawing.Point(277, 6)
        Me.lbl_domiciliocliente.Name = "lbl_domiciliocliente"
        Me.lbl_domiciliocliente.Size = New System.Drawing.Size(49, 13)
        Me.lbl_domiciliocliente.TabIndex = 5
        Me.lbl_domiciliocliente.Text = "Domicilio"
        '
        'lbl_emailcliente
        '
        Me.lbl_emailcliente.AutoSize = True
        Me.lbl_emailcliente.Location = New System.Drawing.Point(277, 34)
        Me.lbl_emailcliente.Name = "lbl_emailcliente"
        Me.lbl_emailcliente.Size = New System.Drawing.Size(32, 13)
        Me.lbl_emailcliente.TabIndex = 6
        Me.lbl_emailcliente.Text = "Email"
        '
        'lbl_telefonoparticularcliente
        '
        Me.lbl_telefonoparticularcliente.AutoSize = True
        Me.lbl_telefonoparticularcliente.Location = New System.Drawing.Point(277, 62)
        Me.lbl_telefonoparticularcliente.Name = "lbl_telefonoparticularcliente"
        Me.lbl_telefonoparticularcliente.Size = New System.Drawing.Size(95, 13)
        Me.lbl_telefonoparticularcliente.TabIndex = 7
        Me.lbl_telefonoparticularcliente.Text = "Telefono particular"
        '
        'lbl_telefonocomercialcliente
        '
        Me.lbl_telefonocomercialcliente.AutoSize = True
        Me.lbl_telefonocomercialcliente.Location = New System.Drawing.Point(277, 89)
        Me.lbl_telefonocomercialcliente.Name = "lbl_telefonocomercialcliente"
        Me.lbl_telefonocomercialcliente.Size = New System.Drawing.Size(97, 13)
        Me.lbl_telefonocomercialcliente.TabIndex = 8
        Me.lbl_telefonocomercialcliente.Text = "Telefono comercial"
        '
        'lbl_numerodclienteecuit
        '
        Me.lbl_numerodclienteecuit.AutoSize = True
        Me.lbl_numerodclienteecuit.Location = New System.Drawing.Point(277, 116)
        Me.lbl_numerodclienteecuit.Name = "lbl_numerodclienteecuit"
        Me.lbl_numerodclienteecuit.Size = New System.Drawing.Size(87, 13)
        Me.lbl_numerodclienteecuit.TabIndex = 9
        Me.lbl_numerodclienteecuit.Text = "Numero de CUIT"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(496, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Razón social"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(496, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Nombre fantacia"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(496, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Secuencia"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(496, 86)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Estado"
        '
        'txt_idcliente
        '
        Me.txt_idcliente.Location = New System.Drawing.Point(69, 6)
        Me.txt_idcliente.Name = "txt_idcliente"
        Me.txt_idcliente.Size = New System.Drawing.Size(100, 20)
        Me.txt_idcliente.TabIndex = 14
        '
        'txt_domicilio
        '
        Me.txt_domicilio.Location = New System.Drawing.Point(322, 6)
        Me.txt_domicilio.Name = "txt_domicilio"
        Me.txt_domicilio.Size = New System.Drawing.Size(166, 20)
        Me.txt_domicilio.TabIndex = 19
        '
        'txt_telefonoparticular
        '
        Me.txt_telefonoparticular.Location = New System.Drawing.Point(380, 60)
        Me.txt_telefonoparticular.Name = "txt_telefonoparticular"
        Me.txt_telefonoparticular.Size = New System.Drawing.Size(97, 20)
        Me.txt_telefonoparticular.TabIndex = 20
        '
        'txt_teledonocomercial
        '
        Me.txt_teledonocomercial.Location = New System.Drawing.Point(380, 89)
        Me.txt_teledonocomercial.Name = "txt_teledonocomercial"
        Me.txt_teledonocomercial.Size = New System.Drawing.Size(97, 20)
        Me.txt_teledonocomercial.TabIndex = 21
        '
        'txt_numerodecuit
        '
        Me.txt_numerodecuit.Location = New System.Drawing.Point(367, 116)
        Me.txt_numerodecuit.Name = "txt_numerodecuit"
        Me.txt_numerodecuit.Size = New System.Drawing.Size(110, 20)
        Me.txt_numerodecuit.TabIndex = 22
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(322, 30)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(166, 20)
        Me.txt_email.TabIndex = 23
        '
        'txt_razonsocial
        '
        Me.txt_razonsocial.Location = New System.Drawing.Point(597, 8)
        Me.txt_razonsocial.Name = "txt_razonsocial"
        Me.txt_razonsocial.Size = New System.Drawing.Size(110, 20)
        Me.txt_razonsocial.TabIndex = 24
        '
        'txt_secuencia
        '
        Me.txt_secuencia.Location = New System.Drawing.Point(594, 60)
        Me.txt_secuencia.Name = "txt_secuencia"
        Me.txt_secuencia.Size = New System.Drawing.Size(100, 20)
        Me.txt_secuencia.TabIndex = 25
        '
        'txt_nombrefantacia
        '
        Me.txt_nombrefantacia.Location = New System.Drawing.Point(597, 34)
        Me.txt_nombrefantacia.Name = "txt_nombrefantacia"
        Me.txt_nombrefantacia.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombrefantacia.TabIndex = 26
        '
        'Grilla
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Grilla.DefaultCellStyle = DataGridViewCellStyle2
        Me.Grilla.Location = New System.Drawing.Point(1, 148)
        Me.Grilla.Name = "Grilla"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grilla.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Grilla.Size = New System.Drawing.Size(904, 84)
        Me.Grilla.TabIndex = 28
        '
        'cmd_limpiarcliente
        '
        Me.cmd_limpiarcliente.Location = New System.Drawing.Point(10, 238)
        Me.cmd_limpiarcliente.Name = "cmd_limpiarcliente"
        Me.cmd_limpiarcliente.Size = New System.Drawing.Size(75, 23)
        Me.cmd_limpiarcliente.TabIndex = 29
        Me.cmd_limpiarcliente.Text = "Limpiar"
        Me.cmd_limpiarcliente.UseVisualStyleBackColor = True
        '
        'cmd_agregarcliente
        '
        Me.cmd_agregarcliente.Location = New System.Drawing.Point(506, 238)
        Me.cmd_agregarcliente.Name = "cmd_agregarcliente"
        Me.cmd_agregarcliente.Size = New System.Drawing.Size(75, 23)
        Me.cmd_agregarcliente.TabIndex = 30
        Me.cmd_agregarcliente.Text = "Agregar"
        Me.cmd_agregarcliente.UseVisualStyleBackColor = True
        '
        'cmd_modificarcliente
        '
        Me.cmd_modificarcliente.Location = New System.Drawing.Point(594, 238)
        Me.cmd_modificarcliente.Name = "cmd_modificarcliente"
        Me.cmd_modificarcliente.Size = New System.Drawing.Size(75, 23)
        Me.cmd_modificarcliente.TabIndex = 31
        Me.cmd_modificarcliente.Text = "Modificar"
        Me.cmd_modificarcliente.UseVisualStyleBackColor = True
        '
        'cmd_aceptar
        '
        Me.cmd_aceptar.Location = New System.Drawing.Point(222, 286)
        Me.cmd_aceptar.Name = "cmd_aceptar"
        Me.cmd_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_aceptar.TabIndex = 33
        Me.cmd_aceptar.Text = "Aceptar"
        Me.cmd_aceptar.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Location = New System.Drawing.Point(322, 286)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cancelar.TabIndex = 34
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_accion)
        Me.Panel1.Location = New System.Drawing.Point(1, 315)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(904, 19)
        Me.Panel1.TabIndex = 35
        '
        'lbl_accion
        '
        Me.lbl_accion.AutoSize = True
        Me.lbl_accion.Location = New System.Drawing.Point(0, 0)
        Me.lbl_accion.Name = "lbl_accion"
        Me.lbl_accion.Size = New System.Drawing.Size(0, 13)
        Me.lbl_accion.TabIndex = 0
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Location = New System.Drawing.Point(700, 238)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_eliminar.TabIndex = 36
        Me.cmd_eliminar.Text = "Eliminar"
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'cbo_localidad
        '
        Me.cbo_localidad.FormattingEnabled = True
        Me.cbo_localidad.Location = New System.Drawing.Point(83, 31)
        Me.cbo_localidad.Name = "cbo_localidad"
        Me.cbo_localidad.Size = New System.Drawing.Size(96, 21)
        Me.cbo_localidad.TabIndex = 39
        '
        'cbo_categoriaiva
        '
        Me.cbo_categoriaiva.FormattingEnabled = True
        Me.cbo_categoriaiva.Location = New System.Drawing.Point(102, 56)
        Me.cbo_categoriaiva.Name = "cbo_categoriaiva"
        Me.cbo_categoriaiva.Size = New System.Drawing.Size(110, 21)
        Me.cbo_categoriaiva.TabIndex = 40
        '
        'cbo_vendedor
        '
        Me.cbo_vendedor.FormattingEnabled = True
        Me.cbo_vendedor.Location = New System.Drawing.Point(83, 86)
        Me.cbo_vendedor.Name = "cbo_vendedor"
        Me.cbo_vendedor.Size = New System.Drawing.Size(121, 21)
        Me.cbo_vendedor.TabIndex = 41
        '
        'cbo_zona
        '
        Me.cbo_zona.FormattingEnabled = True
        Me.cbo_zona.Location = New System.Drawing.Point(69, 108)
        Me.cbo_zona.Name = "cbo_zona"
        Me.cbo_zona.Size = New System.Drawing.Size(110, 21)
        Me.cbo_zona.TabIndex = 42
        '
        'cbo_estado
        '
        Me.cbo_estado.FormattingEnabled = True
        Me.cbo_estado.Location = New System.Drawing.Point(573, 83)
        Me.cbo_estado.Name = "cbo_estado"
        Me.cbo_estado.Size = New System.Drawing.Size(121, 21)
        Me.cbo_estado.TabIndex = 43
        '
        'frm_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(907, 331)
        Me.Controls.Add(Me.cbo_estado)
        Me.Controls.Add(Me.cbo_zona)
        Me.Controls.Add(Me.cbo_vendedor)
        Me.Controls.Add(Me.cbo_categoriaiva)
        Me.Controls.Add(Me.cbo_localidad)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_aceptar)
        Me.Controls.Add(Me.cmd_modificarcliente)
        Me.Controls.Add(Me.cmd_agregarcliente)
        Me.Controls.Add(Me.cmd_limpiarcliente)
        Me.Controls.Add(Me.Grilla)
        Me.Controls.Add(Me.txt_nombrefantacia)
        Me.Controls.Add(Me.txt_secuencia)
        Me.Controls.Add(Me.txt_razonsocial)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_numerodecuit)
        Me.Controls.Add(Me.txt_teledonocomercial)
        Me.Controls.Add(Me.txt_telefonoparticular)
        Me.Controls.Add(Me.txt_domicilio)
        Me.Controls.Add(Me.txt_idcliente)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lbl_numerodclienteecuit)
        Me.Controls.Add(Me.lbl_telefonocomercialcliente)
        Me.Controls.Add(Me.lbl_telefonoparticularcliente)
        Me.Controls.Add(Me.lbl_emailcliente)
        Me.Controls.Add(Me.lbl_domiciliocliente)
        Me.Controls.Add(Me.lbl_idzona)
        Me.Controls.Add(Me.lbl_idvendedoranual)
        Me.Controls.Add(Me.lbl_idcuitiva)
        Me.Controls.Add(Me.lbl_idlocalidad)
        Me.Controls.Add(Me.lbl_idcliente)
        Me.MaximizeBox = False
        Me.Name = "frm_cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_idcliente As System.Windows.Forms.Label
    Friend WithEvents lbl_idlocalidad As System.Windows.Forms.Label
    Friend WithEvents lbl_idcuitiva As System.Windows.Forms.Label
    Friend WithEvents lbl_idvendedoranual As System.Windows.Forms.Label
    Friend WithEvents lbl_idzona As System.Windows.Forms.Label
    Friend WithEvents lbl_domiciliocliente As System.Windows.Forms.Label
    Friend WithEvents lbl_emailcliente As System.Windows.Forms.Label
    Friend WithEvents lbl_telefonoparticularcliente As System.Windows.Forms.Label
    Friend WithEvents lbl_telefonocomercialcliente As System.Windows.Forms.Label
    Friend WithEvents lbl_numerodclienteecuit As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_idcliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_domicilio As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefonoparticular As System.Windows.Forms.TextBox
    Friend WithEvents txt_teledonocomercial As System.Windows.Forms.TextBox
    Friend WithEvents txt_numerodecuit As System.Windows.Forms.TextBox
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_razonsocial As System.Windows.Forms.TextBox
    Friend WithEvents txt_secuencia As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombrefantacia As System.Windows.Forms.TextBox
    Friend WithEvents Grilla As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_limpiarcliente As System.Windows.Forms.Button
    Friend WithEvents cmd_agregarcliente As System.Windows.Forms.Button
    Friend WithEvents cmd_modificarcliente As System.Windows.Forms.Button
    Friend WithEvents cmd_aceptar As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_accion As System.Windows.Forms.Label
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cbo_localidad As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_categoriaiva As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_vendedor As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_zona As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_estado As System.Windows.Forms.ComboBox
End Class
