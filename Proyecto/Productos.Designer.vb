<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Dim Label1 As System.Windows.Forms.Label
        Dim CodigoPostalLabel As System.Windows.Forms.Label
        Dim LocalidadLabel As System.Windows.Forms.Label
        Dim ProvinciaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim ID_ProveedorLabel As System.Windows.Forms.Label
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
        Me.ButtonEliminarTodos = New System.Windows.Forms.Button()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.CodigoPostalTextBox = New System.Windows.Forms.TextBox()
        Me.LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinciaTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonBuscarSiguiente = New System.Windows.Forms.Button()
        Me.ButtonBuscarAnterior = New System.Windows.Forms.Button()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.ID_ProveedorTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.TextBoxConsulta = New System.Windows.Forms.TextBox()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Label1 = New System.Windows.Forms.Label()
        CodigoPostalLabel = New System.Windows.Forms.Label()
        LocalidadLabel = New System.Windows.Forms.Label()
        ProvinciaLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        ID_ProveedorLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Controls.Add(Me.ButtonEliminarTodos)
        Me.Panel1.Controls.Add(Me.ButtonActualizar)
        Me.Panel1.Controls.Add(CodigoPostalLabel)
        Me.Panel1.Controls.Add(Me.CodigoPostalTextBox)
        Me.Panel1.Controls.Add(LocalidadLabel)
        Me.Panel1.Controls.Add(Me.LocalidadTextBox)
        Me.Panel1.Controls.Add(ProvinciaLabel)
        Me.Panel1.Controls.Add(Me.ProvinciaTextBox)
        Me.Panel1.Controls.Add(Me.ButtonBuscarSiguiente)
        Me.Panel1.Controls.Add(Me.ButtonBuscarAnterior)
        Me.Panel1.Controls.Add(NombreLabel)
        Me.Panel1.Controls.Add(Me.NombreTextBox)
        Me.Panel1.Controls.Add(TelefonoLabel)
        Me.Panel1.Controls.Add(Me.TelefonoTextBox)
        Me.Panel1.Controls.Add(EmailLabel)
        Me.Panel1.Controls.Add(Me.EmailTextBox)
        Me.Panel1.Controls.Add(DireccionLabel)
        Me.Panel1.Controls.Add(Me.DireccionTextBox)
        Me.Panel1.Controls.Add(ID_ProveedorLabel)
        Me.Panel1.Controls.Add(Me.ID_ProveedorTextBox)
        Me.Panel1.Controls.Add(Me.ButtonBuscar)
        Me.Panel1.Controls.Add(Me.TextBoxConsulta)
        Me.Panel1.Controls.Add(Me.ButtonEliminar)
        Me.Panel1.Controls.Add(Me.ButtonGuardar)
        Me.Panel1.Controls.Add(Me.MenuStrip)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1274, 691)
        Me.Panel1.TabIndex = 1
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
        'Label1
        '
        Label1.AutoSize = True
        Label1.ForeColor = System.Drawing.SystemColors.Window
        Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Label1.Location = New System.Drawing.Point(362, 445)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(198, 18)
        Label1.TabIndex = 78
        Label1.Text = "Buscar ID Proveedor"
        '
        'ButtonEliminarTodos
        '
        Me.ButtonEliminarTodos.BackColor = System.Drawing.Color.Crimson
        Me.ButtonEliminarTodos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonEliminarTodos.Location = New System.Drawing.Point(762, 371)
        Me.ButtonEliminarTodos.Name = "ButtonEliminarTodos"
        Me.ButtonEliminarTodos.Size = New System.Drawing.Size(150, 34)
        Me.ButtonEliminarTodos.TabIndex = 77
        Me.ButtonEliminarTodos.Text = "Eliminar Todo"
        Me.ButtonEliminarTodos.UseVisualStyleBackColor = False
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.BackColor = System.Drawing.Color.Yellow
        Me.ButtonActualizar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonActualizar.Location = New System.Drawing.Point(762, 242)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(150, 34)
        Me.ButtonActualizar.TabIndex = 76
        Me.ButtonActualizar.Text = "Actualizar"
        Me.ButtonActualizar.UseVisualStyleBackColor = False
        '
        'CodigoPostalLabel
        '
        CodigoPostalLabel.AutoSize = True
        CodigoPostalLabel.ForeColor = System.Drawing.SystemColors.Window
        CodigoPostalLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        CodigoPostalLabel.Location = New System.Drawing.Point(412, 348)
        CodigoPostalLabel.Name = "CodigoPostalLabel"
        CodigoPostalLabel.Size = New System.Drawing.Size(148, 18)
        CodigoPostalLabel.TabIndex = 70
        CodigoPostalLabel.Text = "Codigo Postal:"
        '
        'CodigoPostalTextBox
        '
        Me.CodigoPostalTextBox.Location = New System.Drawing.Point(567, 344)
        Me.CodigoPostalTextBox.Name = "CodigoPostalTextBox"
        Me.CodigoPostalTextBox.Size = New System.Drawing.Size(171, 26)
        Me.CodigoPostalTextBox.TabIndex = 71
        '
        'LocalidadLabel
        '
        LocalidadLabel.AutoSize = True
        LocalidadLabel.ForeColor = System.Drawing.SystemColors.Window
        LocalidadLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        LocalidadLabel.Location = New System.Drawing.Point(412, 379)
        LocalidadLabel.Name = "LocalidadLabel"
        LocalidadLabel.Size = New System.Drawing.Size(108, 18)
        LocalidadLabel.TabIndex = 72
        LocalidadLabel.Text = "Localidad:"
        '
        'LocalidadTextBox
        '
        Me.LocalidadTextBox.Location = New System.Drawing.Point(567, 376)
        Me.LocalidadTextBox.Name = "LocalidadTextBox"
        Me.LocalidadTextBox.Size = New System.Drawing.Size(171, 26)
        Me.LocalidadTextBox.TabIndex = 73
        '
        'ProvinciaLabel
        '
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.ForeColor = System.Drawing.SystemColors.Window
        ProvinciaLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        ProvinciaLabel.Location = New System.Drawing.Point(412, 411)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(108, 18)
        ProvinciaLabel.TabIndex = 74
        ProvinciaLabel.Text = "Provincia:"
        '
        'ProvinciaTextBox
        '
        Me.ProvinciaTextBox.Location = New System.Drawing.Point(567, 408)
        Me.ProvinciaTextBox.Name = "ProvinciaTextBox"
        Me.ProvinciaTextBox.Size = New System.Drawing.Size(171, 26)
        Me.ProvinciaTextBox.TabIndex = 75
        '
        'ButtonBuscarSiguiente
        '
        Me.ButtonBuscarSiguiente.BackColor = System.Drawing.Color.LightGreen
        Me.ButtonBuscarSiguiente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonBuscarSiguiente.Location = New System.Drawing.Point(653, 478)
        Me.ButtonBuscarSiguiente.Name = "ButtonBuscarSiguiente"
        Me.ButtonBuscarSiguiente.Size = New System.Drawing.Size(59, 34)
        Me.ButtonBuscarSiguiente.TabIndex = 69
        Me.ButtonBuscarSiguiente.Text = ">"
        Me.ButtonBuscarSiguiente.UseVisualStyleBackColor = False
        '
        'ButtonBuscarAnterior
        '
        Me.ButtonBuscarAnterior.BackColor = System.Drawing.Color.LightGreen
        Me.ButtonBuscarAnterior.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonBuscarAnterior.Location = New System.Drawing.Point(589, 478)
        Me.ButtonBuscarAnterior.Name = "ButtonBuscarAnterior"
        Me.ButtonBuscarAnterior.Size = New System.Drawing.Size(59, 34)
        Me.ButtonBuscarAnterior.TabIndex = 68
        Me.ButtonBuscarAnterior.Text = "<"
        Me.ButtonBuscarAnterior.UseVisualStyleBackColor = False
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.ForeColor = System.Drawing.SystemColors.Window
        NombreLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        NombreLabel.Location = New System.Drawing.Point(412, 218)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(78, 18)
        NombreLabel.TabIndex = 57
        NombreLabel.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Location = New System.Drawing.Point(567, 215)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(172, 26)
        Me.NombreTextBox.TabIndex = 59
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.ForeColor = System.Drawing.SystemColors.Window
        TelefonoLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        TelefonoLabel.Location = New System.Drawing.Point(412, 250)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(98, 18)
        TelefonoLabel.TabIndex = 60
        TelefonoLabel.Text = "Telefono:"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.Location = New System.Drawing.Point(567, 247)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(172, 26)
        Me.TelefonoTextBox.TabIndex = 61
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.ForeColor = System.Drawing.SystemColors.Window
        EmailLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        EmailLabel.Location = New System.Drawing.Point(412, 282)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(68, 18)
        EmailLabel.TabIndex = 62
        EmailLabel.Text = "Email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(567, 279)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(172, 26)
        Me.EmailTextBox.TabIndex = 63
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.ForeColor = System.Drawing.SystemColors.Window
        DireccionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        DireccionLabel.Location = New System.Drawing.Point(412, 314)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(108, 18)
        DireccionLabel.TabIndex = 64
        DireccionLabel.Text = "Direccion:"
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.Location = New System.Drawing.Point(567, 311)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(172, 26)
        Me.DireccionTextBox.TabIndex = 65
        '
        'ID_ProveedorLabel
        '
        ID_ProveedorLabel.AutoSize = True
        ID_ProveedorLabel.ForeColor = System.Drawing.SystemColors.Window
        ID_ProveedorLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        ID_ProveedorLabel.Location = New System.Drawing.Point(412, 187)
        ID_ProveedorLabel.Name = "ID_ProveedorLabel"
        ID_ProveedorLabel.Size = New System.Drawing.Size(138, 18)
        ID_ProveedorLabel.TabIndex = 66
        ID_ProveedorLabel.Text = "ID Proveedor:"
        '
        'ID_ProveedorTextBox
        '
        Me.ID_ProveedorTextBox.Enabled = False
        Me.ID_ProveedorTextBox.Location = New System.Drawing.Point(567, 183)
        Me.ID_ProveedorTextBox.Name = "ID_ProveedorTextBox"
        Me.ID_ProveedorTextBox.Size = New System.Drawing.Size(172, 26)
        Me.ID_ProveedorTextBox.TabIndex = 67
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.BackColor = System.Drawing.Color.Cyan
        Me.ButtonBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonBuscar.Location = New System.Drawing.Point(762, 437)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(150, 34)
        Me.ButtonBuscar.TabIndex = 58
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = False
        '
        'TextBoxConsulta
        '
        Me.TextBoxConsulta.Location = New System.Drawing.Point(566, 442)
        Me.TextBoxConsulta.Name = "TextBoxConsulta"
        Me.TextBoxConsulta.Size = New System.Drawing.Size(173, 26)
        Me.TextBoxConsulta.TabIndex = 56
        Me.TextBoxConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.BackColor = System.Drawing.Color.DarkOrange
        Me.ButtonEliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonEliminar.Location = New System.Drawing.Point(762, 306)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(150, 34)
        Me.ButtonEliminar.TabIndex = 54
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = False
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.BackColor = System.Drawing.Color.Lime
        Me.ButtonGuardar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonGuardar.Location = New System.Drawing.Point(762, 179)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(150, 34)
        Me.ButtonGuardar.TabIndex = 55
        Me.ButtonGuardar.Text = "Guardar"
        Me.ButtonGuardar.UseVisualStyleBackColor = False
        '
        'Direcciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1274, 691)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Liberation Mono", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Direcciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Direcciones"
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
    Friend WithEvents ButtonEliminarTodos As System.Windows.Forms.Button
    Friend WithEvents ButtonActualizar As System.Windows.Forms.Button
    Friend WithEvents CodigoPostalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProvinciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ButtonBuscarSiguiente As System.Windows.Forms.Button
    Friend WithEvents ButtonBuscarAnterior As System.Windows.Forms.Button
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_ProveedorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ButtonBuscar As System.Windows.Forms.Button
    Friend WithEvents TextBoxConsulta As System.Windows.Forms.TextBox
    Friend WithEvents ButtonEliminar As System.Windows.Forms.Button
    Friend WithEvents ButtonGuardar As System.Windows.Forms.Button
End Class
