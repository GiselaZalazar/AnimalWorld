<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_roveedores
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbo_producto = New System.Windows.Forms.ComboBox()
        Me.cbo_localidad = New System.Windows.Forms.ComboBox()
        Me.cbo_categoriaiva = New System.Windows.Forms.ComboBox()
        Me.txt_razonsocial = New System.Windows.Forms.TextBox()
        Me.txt_idproveedor = New System.Windows.Forms.TextBox()
        Me.txt_nombreyapellido = New System.Windows.Forms.TextBox()
        Me.txt_domicilio = New System.Windows.Forms.TextBox()
        Me.txt_ciudad = New System.Windows.Forms.TextBox()
        Me.txt_codigopostal = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_numerocuit = New System.Windows.Forms.TextBox()
        Me.cbo_provincia = New System.Windows.Forms.ComboBox()
        Me.cbo_estado = New System.Windows.Forms.ComboBox()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_aceptar = New System.Windows.Forms.Button()
        Me.cmd_modificar = New System.Windows.Forms.Button()
        Me.cmd_agregar = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_accion = New System.Windows.Forms.Label()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Proveedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Localidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Categoría IVA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(179, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nombre y Apellido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(190, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Domicilio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(190, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Ciudad"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(190, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Provincia"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(395, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Codigo Postal"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(395, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Telefóno"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(395, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Email"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(5, 111)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Razón Social"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(395, 93)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Estado"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(395, 119)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 13)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Número de CUIT"
        '
        'cbo_producto
        '
        Me.cbo_producto.FormattingEnabled = True
        Me.cbo_producto.Location = New System.Drawing.Point(63, 31)
        Me.cbo_producto.Name = "cbo_producto"
        Me.cbo_producto.Size = New System.Drawing.Size(89, 21)
        Me.cbo_producto.TabIndex = 15
        '
        'cbo_localidad
        '
        Me.cbo_localidad.FormattingEnabled = True
        Me.cbo_localidad.Location = New System.Drawing.Point(63, 58)
        Me.cbo_localidad.Name = "cbo_localidad"
        Me.cbo_localidad.Size = New System.Drawing.Size(91, 21)
        Me.cbo_localidad.TabIndex = 16
        '
        'cbo_categoriaiva
        '
        Me.cbo_categoriaiva.FormattingEnabled = True
        Me.cbo_categoriaiva.Location = New System.Drawing.Point(85, 82)
        Me.cbo_categoriaiva.Name = "cbo_categoriaiva"
        Me.cbo_categoriaiva.Size = New System.Drawing.Size(99, 21)
        Me.cbo_categoriaiva.TabIndex = 17
        '
        'txt_razonsocial
        '
        Me.txt_razonsocial.Location = New System.Drawing.Point(81, 108)
        Me.txt_razonsocial.Name = "txt_razonsocial"
        Me.txt_razonsocial.Size = New System.Drawing.Size(100, 20)
        Me.txt_razonsocial.TabIndex = 18
        '
        'txt_idproveedor
        '
        Me.txt_idproveedor.Location = New System.Drawing.Point(63, 5)
        Me.txt_idproveedor.Name = "txt_idproveedor"
        Me.txt_idproveedor.Size = New System.Drawing.Size(58, 20)
        Me.txt_idproveedor.TabIndex = 19
        '
        'txt_nombreyapellido
        '
        Me.txt_nombreyapellido.Location = New System.Drawing.Point(277, 9)
        Me.txt_nombreyapellido.Name = "txt_nombreyapellido"
        Me.txt_nombreyapellido.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombreyapellido.TabIndex = 20
        '
        'txt_domicilio
        '
        Me.txt_domicilio.Location = New System.Drawing.Point(277, 37)
        Me.txt_domicilio.Name = "txt_domicilio"
        Me.txt_domicilio.Size = New System.Drawing.Size(100, 20)
        Me.txt_domicilio.TabIndex = 21
        '
        'txt_ciudad
        '
        Me.txt_ciudad.Location = New System.Drawing.Point(277, 60)
        Me.txt_ciudad.Name = "txt_ciudad"
        Me.txt_ciudad.Size = New System.Drawing.Size(100, 20)
        Me.txt_ciudad.TabIndex = 22
        '
        'txt_codigopostal
        '
        Me.txt_codigopostal.Location = New System.Drawing.Point(488, 4)
        Me.txt_codigopostal.Name = "txt_codigopostal"
        Me.txt_codigopostal.Size = New System.Drawing.Size(100, 20)
        Me.txt_codigopostal.TabIndex = 23
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(488, 33)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(100, 20)
        Me.txt_telefono.TabIndex = 24
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(488, 59)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(100, 20)
        Me.txt_email.TabIndex = 25
        '
        'txt_numerocuit
        '
        Me.txt_numerocuit.Location = New System.Drawing.Point(488, 112)
        Me.txt_numerocuit.Name = "txt_numerocuit"
        Me.txt_numerocuit.Size = New System.Drawing.Size(85, 20)
        Me.txt_numerocuit.TabIndex = 27
        '
        'cbo_provincia
        '
        Me.cbo_provincia.FormattingEnabled = True
        Me.cbo_provincia.Location = New System.Drawing.Point(277, 86)
        Me.cbo_provincia.Name = "cbo_provincia"
        Me.cbo_provincia.Size = New System.Drawing.Size(100, 21)
        Me.cbo_provincia.TabIndex = 28
        '
        'cbo_estado
        '
        Me.cbo_estado.FormattingEnabled = True
        Me.cbo_estado.Location = New System.Drawing.Point(488, 85)
        Me.cbo_estado.Name = "cbo_estado"
        Me.cbo_estado.Size = New System.Drawing.Size(94, 21)
        Me.cbo_estado.TabIndex = 29
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Location = New System.Drawing.Point(542, 246)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_eliminar.TabIndex = 37
        Me.cmd_eliminar.Text = "Eliminar"
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Location = New System.Drawing.Point(236, 277)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cancelar.TabIndex = 36
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_aceptar
        '
        Me.cmd_aceptar.Location = New System.Drawing.Point(155, 277)
        Me.cmd_aceptar.Name = "cmd_aceptar"
        Me.cmd_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_aceptar.TabIndex = 35
        Me.cmd_aceptar.Text = "Aceptar"
        Me.cmd_aceptar.UseVisualStyleBackColor = True
        '
        'cmd_modificar
        '
        Me.cmd_modificar.Location = New System.Drawing.Point(461, 246)
        Me.cmd_modificar.Name = "cmd_modificar"
        Me.cmd_modificar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_modificar.TabIndex = 34
        Me.cmd_modificar.Text = "Modificar"
        Me.cmd_modificar.UseVisualStyleBackColor = True
        '
        'cmd_agregar
        '
        Me.cmd_agregar.Location = New System.Drawing.Point(380, 246)
        Me.cmd_agregar.Name = "cmd_agregar"
        Me.cmd_agregar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_agregar.TabIndex = 33
        Me.cmd_agregar.Text = "Agregar"
        Me.cmd_agregar.UseVisualStyleBackColor = True
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.Location = New System.Drawing.Point(12, 246)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_limpiar.TabIndex = 32
        Me.cmd_limpiar.Text = "Limpiar"
        Me.cmd_limpiar.UseVisualStyleBackColor = True
        '
        'Grilla
        '
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Location = New System.Drawing.Point(0, 145)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.Size = New System.Drawing.Size(635, 95)
        Me.Grilla.TabIndex = 30
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_accion)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 306)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(635, 22)
        Me.Panel1.TabIndex = 31
        '
        'lbl_accion
        '
        Me.lbl_accion.AutoSize = True
        Me.lbl_accion.Location = New System.Drawing.Point(3, 9)
        Me.lbl_accion.Name = "lbl_accion"
        Me.lbl_accion.Size = New System.Drawing.Size(0, 13)
        Me.lbl_accion.TabIndex = 38
        '
        'frm_roveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(635, 328)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_aceptar)
        Me.Controls.Add(Me.cmd_modificar)
        Me.Controls.Add(Me.cmd_agregar)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.Grilla)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cbo_estado)
        Me.Controls.Add(Me.cbo_provincia)
        Me.Controls.Add(Me.txt_numerocuit)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.txt_codigopostal)
        Me.Controls.Add(Me.txt_ciudad)
        Me.Controls.Add(Me.txt_domicilio)
        Me.Controls.Add(Me.txt_nombreyapellido)
        Me.Controls.Add(Me.txt_idproveedor)
        Me.Controls.Add(Me.txt_razonsocial)
        Me.Controls.Add(Me.cbo_categoriaiva)
        Me.Controls.Add(Me.cbo_localidad)
        Me.Controls.Add(Me.cbo_producto)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frm_roveedores"
        Me.Text = "Proveedores"
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbo_producto As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_localidad As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_categoriaiva As System.Windows.Forms.ComboBox
    Friend WithEvents txt_razonsocial As System.Windows.Forms.TextBox
    Friend WithEvents txt_idproveedor As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombreyapellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_domicilio As System.Windows.Forms.TextBox
    Friend WithEvents txt_ciudad As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigopostal As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_numerocuit As System.Windows.Forms.TextBox
    Friend WithEvents cbo_provincia As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_estado As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_aceptar As System.Windows.Forms.Button
    Friend WithEvents cmd_modificar As System.Windows.Forms.Button
    Friend WithEvents cmd_agregar As System.Windows.Forms.Button
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents Grilla As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_accion As System.Windows.Forms.Label
End Class
