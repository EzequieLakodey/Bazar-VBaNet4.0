<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categorias
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
        Me.PanelMain = New System.Windows.Forms.Panel()
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
        Me.PanelMain.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMain
        '
        Me.PanelMain.AllowDrop = True
        Me.PanelMain.BackColor = System.Drawing.Color.SteelBlue
        Me.PanelMain.Controls.Add(Me.MenuStrip)
        Me.PanelMain.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PanelMain.Location = New System.Drawing.Point(0, 0)
        Me.PanelMain.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(1176, 699)
        Me.PanelMain.TabIndex = 5
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
        Me.MenuStrip.MinimumSize = New System.Drawing.Size(300, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuStrip.Size = New System.Drawing.Size(300, 699)
        Me.MenuStrip.TabIndex = 4
        Me.MenuStrip.Text = "Menu"
        '
        'MenuItemVolver
        '
        Me.MenuItemVolver.Font = New System.Drawing.Font("Liberation Mono", 40.0!, System.Drawing.FontStyle.Bold)
        Me.MenuItemVolver.ForeColor = System.Drawing.Color.Black
        Me.MenuItemVolver.Name = "MenuItemVolver"
        Me.MenuItemVolver.Padding = New System.Windows.Forms.Padding(154, 45, 0, 0)
        Me.MenuItemVolver.Size = New System.Drawing.Size(298, 110)
        Me.MenuItemVolver.Text = "🡐"
        '
        'MenuItemClientes
        '
        Me.MenuItemClientes.Font = New System.Drawing.Font("Liberation Mono", 20.0!, System.Drawing.FontStyle.Bold)
        Me.MenuItemClientes.ForeColor = System.Drawing.Color.Black
        Me.MenuItemClientes.Name = "MenuItemClientes"
        Me.MenuItemClientes.Padding = New System.Windows.Forms.Padding(154, 45, 0, 0)
        Me.MenuItemClientes.Size = New System.Drawing.Size(298, 79)
        Me.MenuItemClientes.Text = "Clientes"
        '
        'MenuItemVentas
        '
        Me.MenuItemVentas.Font = New System.Drawing.Font("Liberation Mono", 20.0!, System.Drawing.FontStyle.Bold)
        Me.MenuItemVentas.Name = "MenuItemVentas"
        Me.MenuItemVentas.Padding = New System.Windows.Forms.Padding(154, 45, 0, 0)
        Me.MenuItemVentas.Size = New System.Drawing.Size(298, 79)
        Me.MenuItemVentas.Text = "Ventas"
        '
        'MenuItemCompras
        '
        Me.MenuItemCompras.Font = New System.Drawing.Font("Liberation Mono", 20.0!, System.Drawing.FontStyle.Bold)
        Me.MenuItemCompras.Name = "MenuItemCompras"
        Me.MenuItemCompras.Padding = New System.Windows.Forms.Padding(154, 45, 0, 0)
        Me.MenuItemCompras.Size = New System.Drawing.Size(298, 79)
        Me.MenuItemCompras.Text = "Compras"
        '
        'MenuItemBalance
        '
        Me.MenuItemBalance.Font = New System.Drawing.Font("Liberation Mono", 20.0!, System.Drawing.FontStyle.Bold)
        Me.MenuItemBalance.ForeColor = System.Drawing.Color.Black
        Me.MenuItemBalance.Name = "MenuItemBalance"
        Me.MenuItemBalance.Padding = New System.Windows.Forms.Padding(154, 45, 0, 0)
        Me.MenuItemBalance.Size = New System.Drawing.Size(298, 79)
        Me.MenuItemBalance.Text = "Balance"
        '
        'MenuItemOtros
        '
        Me.MenuItemOtros.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemOtrosDirecciones, Me.MenuItemOtrosCategorias})
        Me.MenuItemOtros.Font = New System.Drawing.Font("Liberation Mono", 20.0!, System.Drawing.FontStyle.Bold)
        Me.MenuItemOtros.Name = "MenuItemOtros"
        Me.MenuItemOtros.Padding = New System.Windows.Forms.Padding(154, 45, 0, 0)
        Me.MenuItemOtros.Size = New System.Drawing.Size(298, 79)
        Me.MenuItemOtros.Text = "Otros"
        '
        'MenuItemOtrosDirecciones
        '
        Me.MenuItemOtrosDirecciones.Name = "MenuItemOtrosDirecciones"
        Me.MenuItemOtrosDirecciones.Size = New System.Drawing.Size(262, 34)
        Me.MenuItemOtrosDirecciones.Text = "Direcciones"
        '
        'MenuItemOtrosCategorias
        '
        Me.MenuItemOtrosCategorias.Name = "MenuItemOtrosCategorias"
        Me.MenuItemOtrosCategorias.Size = New System.Drawing.Size(262, 34)
        Me.MenuItemOtrosCategorias.Text = " Categorias"
        '
        'MenuItemContacto
        '
        Me.MenuItemContacto.Font = New System.Drawing.Font("Liberation Mono", 20.0!, System.Drawing.FontStyle.Bold)
        Me.MenuItemContacto.ForeColor = System.Drawing.Color.Black
        Me.MenuItemContacto.Name = "MenuItemContacto"
        Me.MenuItemContacto.Padding = New System.Windows.Forms.Padding(154, 45, 0, 0)
        Me.MenuItemContacto.Size = New System.Drawing.Size(298, 79)
        Me.MenuItemContacto.Text = "Contacto"
        '
        'MenuItemSalir
        '
        Me.MenuItemSalir.Font = New System.Drawing.Font("Liberation Mono", 20.0!, System.Drawing.FontStyle.Bold)
        Me.MenuItemSalir.ForeColor = System.Drawing.Color.Black
        Me.MenuItemSalir.Name = "MenuItemSalir"
        Me.MenuItemSalir.Padding = New System.Windows.Forms.Padding(154, 45, 0, 0)
        Me.MenuItemSalir.Size = New System.Drawing.Size(298, 79)
        Me.MenuItemSalir.Text = "Salir"
        '
        'Categorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1176, 699)
        Me.Controls.Add(Me.PanelMain)
        Me.Name = "Categorias"
        Me.Text = "Categorias"
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMain As System.Windows.Forms.Panel
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
