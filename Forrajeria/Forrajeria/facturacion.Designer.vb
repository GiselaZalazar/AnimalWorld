<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_facturacion
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_CompN = New System.Windows.Forms.TextBox()
        Me.txt_puntoVenta = New System.Windows.Forms.TextBox()
        Me.cbo_tipoFactura = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_limpiar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmb_idCliente = New System.Windows.Forms.Button()
        Me.txt_estadp = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_localidad = New System.Windows.Forms.TextBox()
        Me.txtx_direccion = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_idCliente = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmb_idproducto = New System.Windows.Forms.Button()
        Me.cmb_cancelar = New System.Windows.Forms.Button()
        Me.cmb_aceptar = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_comprobante = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_descuento = New System.Windows.Forms.TextBox()
        Me.txt_SubTotal = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmb_menos = New System.Windows.Forms.Button()
        Me.cmb_mas = New System.Windows.Forms.Button()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_PrecioUnitario = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_producto = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_idProducto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_panel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_CompN)
        Me.GroupBox1.Controls.Add(Me.txt_puntoVenta)
        Me.GroupBox1.Controls.Add(Me.cbo_tipoFactura)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(351, 129)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Facturación"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(59, 76)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(175, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Comp. N"
        '
        'txt_CompN
        '
        Me.txt_CompN.Location = New System.Drawing.Point(229, 48)
        Me.txt_CompN.Name = "txt_CompN"
        Me.txt_CompN.Size = New System.Drawing.Size(65, 20)
        Me.txt_CompN.TabIndex = 4
        '
        'txt_puntoVenta
        '
        Me.txt_puntoVenta.Location = New System.Drawing.Point(100, 48)
        Me.txt_puntoVenta.Name = "txt_puntoVenta"
        Me.txt_puntoVenta.Size = New System.Drawing.Size(65, 20)
        Me.txt_puntoVenta.TabIndex = 3
        '
        'cbo_tipoFactura
        '
        Me.cbo_tipoFactura.FormattingEnabled = True
        Me.cbo_tipoFactura.Location = New System.Drawing.Point(100, 20)
        Me.cbo_tipoFactura.Name = "cbo_tipoFactura"
        Me.cbo_tipoFactura.Size = New System.Drawing.Size(65, 21)
        Me.cbo_tipoFactura.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Punto de Venta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de Factura"
        '
        'cmb_limpiar
        '
        Me.cmb_limpiar.Location = New System.Drawing.Point(28, 12)
        Me.cmb_limpiar.Name = "cmb_limpiar"
        Me.cmb_limpiar.Size = New System.Drawing.Size(164, 23)
        Me.cmb_limpiar.TabIndex = 1
        Me.cmb_limpiar.Text = "Limpiar"
        Me.cmb_limpiar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmb_idCliente)
        Me.GroupBox2.Controls.Add(Me.txt_estadp)
        Me.GroupBox2.Controls.Add(Me.txt_telefono)
        Me.GroupBox2.Controls.Add(Me.txt_localidad)
        Me.GroupBox2.Controls.Add(Me.txtx_direccion)
        Me.GroupBox2.Controls.Add(Me.txt_apellido)
        Me.GroupBox2.Controls.Add(Me.txt_nombre)
        Me.GroupBox2.Controls.Add(Me.txt_idCliente)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(387, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(497, 233)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente "
        '
        'cmb_idCliente
        '
        Me.cmb_idCliente.Location = New System.Drawing.Point(182, 19)
        Me.cmb_idCliente.Name = "cmb_idCliente"
        Me.cmb_idCliente.Size = New System.Drawing.Size(31, 28)
        Me.cmb_idCliente.TabIndex = 11
        Me.cmb_idCliente.Text = "..."
        Me.cmb_idCliente.UseVisualStyleBackColor = True
        '
        'txt_estadp
        '
        Me.txt_estadp.Location = New System.Drawing.Point(76, 197)
        Me.txt_estadp.Name = "txt_estadp"
        Me.txt_estadp.Size = New System.Drawing.Size(191, 20)
        Me.txt_estadp.TabIndex = 10
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(76, 169)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(191, 20)
        Me.txt_telefono.TabIndex = 9
        '
        'txt_localidad
        '
        Me.txt_localidad.Location = New System.Drawing.Point(76, 142)
        Me.txt_localidad.Name = "txt_localidad"
        Me.txt_localidad.Size = New System.Drawing.Size(191, 20)
        Me.txt_localidad.TabIndex = 7
        '
        'txtx_direccion
        '
        Me.txtx_direccion.Location = New System.Drawing.Point(76, 111)
        Me.txtx_direccion.Name = "txtx_direccion"
        Me.txtx_direccion.Size = New System.Drawing.Size(191, 20)
        Me.txtx_direccion.TabIndex = 8
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(76, 80)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(191, 20)
        Me.txt_apellido.TabIndex = 7
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(76, 53)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(191, 20)
        Me.txt_nombre.TabIndex = 6
        '
        'txt_idCliente
        '
        Me.txt_idCliente.Location = New System.Drawing.Point(76, 25)
        Me.txt_idCliente.Name = "txt_idCliente"
        Me.txt_idCliente.Size = New System.Drawing.Size(100, 20)
        Me.txt_idCliente.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 204)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Estado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Localidad"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Telefono"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Direccion "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Apellido "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ID cliente"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmb_idproducto)
        Me.GroupBox3.Controls.Add(Me.cmb_cancelar)
        Me.GroupBox3.Controls.Add(Me.cmb_aceptar)
        Me.GroupBox3.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txt_comprobante)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txt_descuento)
        Me.GroupBox3.Controls.Add(Me.txt_SubTotal)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Controls.Add(Me.cmb_menos)
        Me.GroupBox3.Controls.Add(Me.cmb_mas)
        Me.GroupBox3.Controls.Add(Me.txt_total)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.txt_PrecioUnitario)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txt_cantidad)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txt_producto)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txt_idProducto)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 251)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(871, 447)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Productos"
        '
        'cmb_idproducto
        '
        Me.cmb_idproducto.Location = New System.Drawing.Point(202, 15)
        Me.cmb_idproducto.Name = "cmb_idproducto"
        Me.cmb_idproducto.Size = New System.Drawing.Size(33, 23)
        Me.cmb_idproducto.TabIndex = 24
        Me.cmb_idproducto.Text = "..."
        Me.cmb_idproducto.UseVisualStyleBackColor = True
        '
        'cmb_cancelar
        '
        Me.cmb_cancelar.Location = New System.Drawing.Point(774, 413)
        Me.cmb_cancelar.Name = "cmb_cancelar"
        Me.cmb_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmb_cancelar.TabIndex = 23
        Me.cmb_cancelar.Text = "Cancelar"
        Me.cmb_cancelar.UseVisualStyleBackColor = True
        '
        'cmb_aceptar
        '
        Me.cmb_aceptar.Location = New System.Drawing.Point(774, 383)
        Me.cmb_aceptar.Name = "cmb_aceptar"
        Me.cmb_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmb_aceptar.TabIndex = 22
        Me.cmb_aceptar.Text = "Aceptar"
        Me.cmb_aceptar.UseVisualStyleBackColor = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(93, 390)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(642, 20)
        Me.MaskedTextBox1.TabIndex = 20
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(24, 393)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(63, 13)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "Descripción"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(619, 352)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 13)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Total Comprobante "
        '
        'txt_comprobante
        '
        Me.txt_comprobante.Location = New System.Drawing.Point(725, 345)
        Me.txt_comprobante.Name = "txt_comprobante"
        Me.txt_comprobante.Size = New System.Drawing.Size(124, 20)
        Me.txt_comprobante.TabIndex = 17
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(343, 352)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 13)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Descuento"
        '
        'txt_descuento
        '
        Me.txt_descuento.Location = New System.Drawing.Point(408, 345)
        Me.txt_descuento.Name = "txt_descuento"
        Me.txt_descuento.Size = New System.Drawing.Size(131, 20)
        Me.txt_descuento.TabIndex = 15
        '
        'txt_SubTotal
        '
        Me.txt_SubTotal.Location = New System.Drawing.Point(83, 345)
        Me.txt_SubTotal.Name = "txt_SubTotal"
        Me.txt_SubTotal.Size = New System.Drawing.Size(123, 20)
        Me.txt_SubTotal.TabIndex = 14
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(24, 352)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 13)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Sub Total"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 167)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(853, 167)
        Me.DataGridView1.TabIndex = 12
        '
        'cmb_menos
        '
        Me.cmb_menos.Location = New System.Drawing.Point(385, 138)
        Me.cmb_menos.Name = "cmb_menos"
        Me.cmb_menos.Size = New System.Drawing.Size(41, 23)
        Me.cmb_menos.TabIndex = 11
        Me.cmb_menos.Text = "-"
        Me.cmb_menos.UseVisualStyleBackColor = True
        '
        'cmb_mas
        '
        Me.cmb_mas.Location = New System.Drawing.Point(335, 138)
        Me.cmb_mas.Name = "cmb_mas"
        Me.cmb_mas.Size = New System.Drawing.Size(41, 23)
        Me.cmb_mas.TabIndex = 10
        Me.cmb_mas.Text = "+"
        Me.cmb_mas.UseVisualStyleBackColor = True
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(94, 138)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(222, 20)
        Me.txt_total.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(13, 138)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 13)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Total"
        '
        'txt_PrecioUnitario
        '
        Me.txt_PrecioUnitario.Location = New System.Drawing.Point(94, 104)
        Me.txt_PrecioUnitario.Name = "txt_PrecioUnitario"
        Me.txt_PrecioUnitario.Size = New System.Drawing.Size(222, 20)
        Me.txt_PrecioUnitario.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(13, 111)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Precio Unitario"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(96, 75)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(220, 20)
        Me.txt_cantidad.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 82)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Cantidad"
        '
        'txt_producto
        '
        Me.txt_producto.Location = New System.Drawing.Point(96, 48)
        Me.txt_producto.Name = "txt_producto"
        Me.txt_producto.Size = New System.Drawing.Size(220, 20)
        Me.txt_producto.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Producto"
        '
        'txt_idProducto
        '
        Me.txt_idProducto.Location = New System.Drawing.Point(96, 18)
        Me.txt_idProducto.Name = "txt_idProducto"
        Me.txt_idProducto.Size = New System.Drawing.Size(100, 20)
        Me.txt_idProducto.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "ID Producto  "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_panel)
        Me.Panel1.Location = New System.Drawing.Point(-6, 716)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(903, 37)
        Me.Panel1.TabIndex = 4
        '
        'lbl_panel
        '
        Me.lbl_panel.AutoSize = True
        Me.lbl_panel.Location = New System.Drawing.Point(43, 11)
        Me.lbl_panel.Name = "lbl_panel"
        Me.lbl_panel.Size = New System.Drawing.Size(0, 13)
        Me.lbl_panel.TabIndex = 0
        '
        'frm_facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(896, 749)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmb_limpiar)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "frm_facturacion"
        Me.Text = "facturacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_CompN As System.Windows.Forms.TextBox
    Friend WithEvents txt_puntoVenta As System.Windows.Forms.TextBox
    Friend WithEvents cbo_tipoFactura As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_limpiar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_idCliente As System.Windows.Forms.Button
    Friend WithEvents txt_estadp As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents txt_localidad As System.Windows.Forms.TextBox
    Friend WithEvents txtx_direccion As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_idCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmb_aceptar As System.Windows.Forms.Button
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_comprobante As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_descuento As System.Windows.Forms.TextBox
    Friend WithEvents txt_SubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_menos As System.Windows.Forms.Button
    Friend WithEvents cmb_mas As System.Windows.Forms.Button
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_PrecioUnitario As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_idProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_panel As System.Windows.Forms.Label
    Friend WithEvents cmb_idproducto As System.Windows.Forms.Button
End Class
