<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bazar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bazar))
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuItemClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemVentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemProveedores = New System.Windows.Forms.ToolStripMenuItem()
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
        resources.ApplyResources(Me.PanelMain, "PanelMain")
        Me.PanelMain.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PanelMain.Name = "PanelMain"
        '
        'MenuStrip
        '
        Me.MenuStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.MenuStrip.BackColor = System.Drawing.Color.LemonChiffon
        resources.ApplyResources(Me.MenuStrip, "MenuStrip")
        Me.MenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemClientes, Me.MenuItemVentas, Me.MenuItemProveedores, Me.MenuItemCompras, Me.MenuItemBalance, Me.MenuItemOtros, Me.MenuItemContacto, Me.MenuItemSalir})
        Me.MenuStrip.Name = "MenuStrip"
        '
        'MenuItemClientes
        '
        resources.ApplyResources(Me.MenuItemClientes, "MenuItemClientes")
        Me.MenuItemClientes.ForeColor = System.Drawing.Color.Black
        Me.MenuItemClientes.Name = "MenuItemClientes"
        Me.MenuItemClientes.Padding = New System.Windows.Forms.Padding(35, 39, 0, 0)
        '
        'MenuItemVentas
        '
        resources.ApplyResources(Me.MenuItemVentas, "MenuItemVentas")
        Me.MenuItemVentas.Name = "MenuItemVentas"
        Me.MenuItemVentas.Padding = New System.Windows.Forms.Padding(35, 39, 0, 0)
        '
        'MenuItemProveedores
        '
        resources.ApplyResources(Me.MenuItemProveedores, "MenuItemProveedores")
        Me.MenuItemProveedores.Name = "MenuItemProveedores"
        Me.MenuItemProveedores.Padding = New System.Windows.Forms.Padding(35, 39, 0, 0)
        '
        'MenuItemCompras
        '
        resources.ApplyResources(Me.MenuItemCompras, "MenuItemCompras")
        Me.MenuItemCompras.Name = "MenuItemCompras"
        Me.MenuItemCompras.Padding = New System.Windows.Forms.Padding(35, 39, 0, 0)
        '
        'MenuItemBalance
        '
        resources.ApplyResources(Me.MenuItemBalance, "MenuItemBalance")
        Me.MenuItemBalance.ForeColor = System.Drawing.Color.Black
        Me.MenuItemBalance.Name = "MenuItemBalance"
        Me.MenuItemBalance.Padding = New System.Windows.Forms.Padding(35, 39, 0, 0)
        '
        'MenuItemOtros
        '
        Me.MenuItemOtros.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemOtrosDirecciones, Me.MenuItemOtrosCategorias})
        resources.ApplyResources(Me.MenuItemOtros, "MenuItemOtros")
        Me.MenuItemOtros.Name = "MenuItemOtros"
        Me.MenuItemOtros.Padding = New System.Windows.Forms.Padding(35, 39, 0, 0)
        '
        'MenuItemOtrosDirecciones
        '
        Me.MenuItemOtrosDirecciones.Name = "MenuItemOtrosDirecciones"
        resources.ApplyResources(Me.MenuItemOtrosDirecciones, "MenuItemOtrosDirecciones")
        '
        'MenuItemOtrosCategorias
        '
        Me.MenuItemOtrosCategorias.Name = "MenuItemOtrosCategorias"
        resources.ApplyResources(Me.MenuItemOtrosCategorias, "MenuItemOtrosCategorias")
        '
        'MenuItemContacto
        '
        resources.ApplyResources(Me.MenuItemContacto, "MenuItemContacto")
        Me.MenuItemContacto.ForeColor = System.Drawing.Color.Black
        Me.MenuItemContacto.Name = "MenuItemContacto"
        Me.MenuItemContacto.Padding = New System.Windows.Forms.Padding(35, 39, 0, 0)
        '
        'MenuItemSalir
        '
        resources.ApplyResources(Me.MenuItemSalir, "MenuItemSalir")
        Me.MenuItemSalir.ForeColor = System.Drawing.Color.Black
        Me.MenuItemSalir.Name = "MenuItemSalir"
        Me.MenuItemSalir.Padding = New System.Windows.Forms.Padding(35, 39, 0, 0)
        '
        'Bazar
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Bazar"
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMain As System.Windows.Forms.Panel
    Public WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuItemClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemVentas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemProveedores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemCompras As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemBalance As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemOtros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemOtrosDirecciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemOtrosCategorias As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemContacto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemSalir As System.Windows.Forms.ToolStripMenuItem

End Class
