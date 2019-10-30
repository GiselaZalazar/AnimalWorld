<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class grillaProducto
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
        Me.grl_PROD = New System.Windows.Forms.DataGridView()
        CType(Me.grl_PROD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grl_PROD
        '
        Me.grl_PROD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grl_PROD.Location = New System.Drawing.Point(12, 12)
        Me.grl_PROD.Name = "grl_PROD"
        Me.grl_PROD.Size = New System.Drawing.Size(714, 261)
        Me.grl_PROD.TabIndex = 0
        '
        'grillaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(755, 320)
        Me.Controls.Add(Me.grl_PROD)
        Me.MaximizeBox = False
        Me.Name = "grillaProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "grillaProducto"
        CType(Me.grl_PROD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grl_PROD As System.Windows.Forms.DataGridView
End Class
