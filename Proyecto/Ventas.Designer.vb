<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuItemVolver = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemVentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemCompras = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemBalance = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemOtros = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemOtrosDirecciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemOtrosCategorias = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemContacto = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MenuStrip)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1274, 691)
        Me.Panel1.TabIndex = 0
        '
        'MenuStrip
        '
        Me.MenuStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.MenuStrip.BackColor = System.Drawing.Color.LemonChiffon
        Me.MenuStrip.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip.Font = New System.Drawing.Font("Liberation Mono", 20.25!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemVolver, Me.MenuItemClientes, Me.MenuItemVentas, Me.MenuItemCompras, Me.MenuItemBalance, Me.MenuItemOtros, Me.MenuItemContacto, Me.MenuItemSalir})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MinimumSize = New System.Drawing.Size(200, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuStrip.Size = New System.Drawing.Size(325, 691)
        Me.MenuStrip.TabIndex = 4
        Me.MenuStrip.Text = "Menu"
        '
        'MenuItemVolver
        '
        Me.MenuItemVolver.Font = New System.Drawing.Font("Liberation Mono", 23.0!, System.Drawing.FontStyle.Bold)
        Me.MenuItemVolver.ForeColor = System.Drawing.Color.Black
        Me.MenuItemVolver.Name = "MenuItemVolver"
        Me.MenuItemVolver.Padding = New System.Windows.Forms.Padding(154, 45, 0, 0)
        Me.MenuItemVolver.Size = New System.Drawing.Size(324, 84)
        Me.MenuItemVolver.Text = "🡐"
        '
        'MenuItemClientes
        '
        Me.MenuItemClientes.Font = New System.Drawing.Font("Liberation Mono", 23.0!, System.Drawing.FontStyle.Bold)
        Me.MenuItemClientes.ForeColor = System.Drawing.Color.Black
        Me.MenuItemClientes.Name = "MenuItemClientes"
        Me.MenuItemClientes.Padding = New System.Windows.Forms.Padding(154, 45, 0, 0)
        Me.MenuItemClientes.Size = New System.Drawing.Size(324, 84)
        Me.MenuItemClientes.Text = "Clientes"
        '
        'MenuItemVentas
        '
        Me.MenuItemVentas.Font = New System.Drawing.Font("Liberation Mono", 23.0!, System.Drawing.FontStyle.Bold)
        Me.MenuItemVentas.Name = "MenuItemVentas"
        Me.MenuItemVentas.Padding = New System.Windows.Forms.Padding(154, 45, 0, 0)
        Me.MenuItemVentas.Size = New System.Drawing.Size(324, 84)
        Me.MenuItemVentas.Text = "Ventas"
        '
        'MenuItemCompras
        '
        Me.MenuItemCompras.Font = New System.Drawing.Font("Liberation Mono", 23.0!, System.Drawing.FontStyle.Bold)
        Me.MenuItemCompras.Name = "MenuItemCompras"
        Me.MenuItemCompras.Padding = New System.Windows.Forms.Padding(154, 45, 0, 0)
        Me.MenuItemCompras.Size = New System.Drawing.Size(324, 84)
        Me.MenuItemCompras.Text = "Compras"
        '
        'MenuItemBalance
        '
        Me.MenuItemBalance.Font = New System.Drawing.Font("Liberation Mono", 23.0!, System.Drawing.FontStyle.Bold)
        Me.MenuItemBalance.ForeColor = System.Drawing.Color.Black
        Me.MenuItemBalance.Name = "MenuItemBalance"
        Me.MenuItemBalance.Padding = New System.Windows.Forms.Padding(154, 45, 0, 0)
        Me.MenuItemBalance.Size = New System.Drawing.Size(324, 84)
        Me.MenuItemBalance.Text = "Balance"
        '
        'MenuItemOtros
        '
        Me.MenuItemOtros.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemOtrosDirecciones, Me.MenuItemOtrosCategorias})
        Me.MenuItemOtros.Font = New System.Drawing.Font("Liberation Mono", 23.0!, System.Drawing.FontStyle.Bold)
        Me.MenuItemOtros.Name = "MenuItemOtros"
        Me.MenuItemOtros.Padding = New System.Windows.Forms.Padding(154, 45, 0, 0)
        Me.MenuItemOtros.Size = New System.Drawing.Size(324, 84)
        Me.MenuItemOtros.Text = "Otros"
        '
        'MenuItemOtrosDirecciones
        '
        Me.MenuItemOtrosDirecciones.Name = "MenuItemOtrosDirecciones"
        Me.MenuItemOtrosDirecciones.Size = New System.Drawing.Size(299, 40)
        Me.MenuItemOtrosDirecciones.Text = "Direcciones"
        '
        'MenuItemOtrosCategorias
        '
        Me.MenuItemOtrosCategorias.Name = "MenuItemOtrosCategorias"
        Me.MenuItemOtrosCategorias.Size = New System.Drawing.Size(299, 40)
        Me.MenuItemOtrosCategorias.Text = " Categorias"
        '
        'MenuItemContacto
        '
        Me.MenuItemContacto.Font = New System.Drawing.Font("Liberation Mono", 23.0!, System.Drawing.FontStyle.Bold)
        Me.MenuItemContacto.ForeColor = System.Drawing.Color.Black
        Me.MenuItemContacto.Name = "MenuItemContacto"
        Me.MenuItemContacto.Padding = New System.Windows.Forms.Padding(154, 45, 0, 0)
        Me.MenuItemContacto.Size = New System.Drawing.Size(324, 84)
        Me.MenuItemContacto.Text = "Contacto"
        '
        'MenuItemSalir
        '
        Me.MenuItemSalir.Font = New System.Drawing.Font("Liberation Mono", 23.0!, System.Drawing.FontStyle.Bold)
        Me.MenuItemSalir.ForeColor = System.Drawing.Color.Black
        Me.MenuItemSalir.Name = "MenuItemSalir"
        Me.MenuItemSalir.Padding = New System.Windows.Forms.Padding(154, 45, 0, 0)
        Me.MenuItemSalir.Size = New System.Drawing.Size(324, 84)
        Me.MenuItemSalir.Text = "Salir"
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1274, 691)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Liberation Mono", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuItemVolver As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemVentas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemCompras As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemBalance As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemOtros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemOtrosDirecciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemOtrosCategorias As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemContacto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemSalir As System.Windows.Forms.ToolStripMenuItem
End Class
