<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_forrajeria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_forrajeria))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DatosImportantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProvinciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubrubrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosImportantesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(595, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DatosImportantesToolStripMenuItem
        '
        Me.DatosImportantesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.ProvinciaToolStripMenuItem, Me.LocalidadToolStripMenuItem, Me.VendedorToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.MarcasToolStripMenuItem, Me.FacturacionToolStripMenuItem})
        Me.DatosImportantesToolStripMenuItem.Name = "DatosImportantesToolStripMenuItem"
        Me.DatosImportantesToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.DatosImportantesToolStripMenuItem.Text = "COMPLETAR"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'ProvinciaToolStripMenuItem
        '
        Me.ProvinciaToolStripMenuItem.Name = "ProvinciaToolStripMenuItem"
        Me.ProvinciaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProvinciaToolStripMenuItem.Text = "Provincia"
        '
        'LocalidadToolStripMenuItem
        '
        Me.LocalidadToolStripMenuItem.Name = "LocalidadToolStripMenuItem"
        Me.LocalidadToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LocalidadToolStripMenuItem.Text = "Localidad"
        '
        'VendedorToolStripMenuItem
        '
        Me.VendedorToolStripMenuItem.Name = "VendedorToolStripMenuItem"
        Me.VendedorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VendedorToolStripMenuItem.Text = "Vendedor"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'MarcasToolStripMenuItem
        '
        Me.MarcasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubrubrosToolStripMenuItem})
        Me.MarcasToolStripMenuItem.Name = "MarcasToolStripMenuItem"
        Me.MarcasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MarcasToolStripMenuItem.Text = "Rubros"
        '
        'SubrubrosToolStripMenuItem
        '
        Me.SubrubrosToolStripMenuItem.Name = "SubrubrosToolStripMenuItem"
        Me.SubrubrosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SubrubrosToolStripMenuItem.Text = "Subrubros"
        '
        'FacturacionToolStripMenuItem
        '
        Me.FacturacionToolStripMenuItem.Name = "FacturacionToolStripMenuItem"
        Me.FacturacionToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FacturacionToolStripMenuItem.Text = "Facturacion"
        '
        'frm_forrajeria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(595, 368)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_forrajeria"
        Me.Text = "Forrajeria"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DatosImportantesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProvinciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarcasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubrubrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
