<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores
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
        Me.components = New System.ComponentModel.Container()
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proveedores))
        Dim CodigoPostalLabel As System.Windows.Forms.Label
        Dim LocalidadLabel As System.Windows.Forms.Label
        Dim ProvinciaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim ID_ProveedorLabel As System.Windows.Forms.Label
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ComprasDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FKComprasIDProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BazarDataSet = New Proyecto.BazarDataSet()
        Me.ProveedoresDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigosPostalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodigosPostalesTableAdapter = New Proyecto.BazarDataSetTableAdapters.CodigosPostalesTableAdapter()
        Me.TableAdapterManager = New Proyecto.BazarDataSetTableAdapters.TableAdapterManager()
        Me.ProveedoresTableAdapter = New Proyecto.BazarDataSetTableAdapters.ProveedoresTableAdapter()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuItemVolver = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemVentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemCompras = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemProductos = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemOtros = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemOtrosDirecciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemOtrosCategorias = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemContacto = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
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
        Me.ComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComprasTableAdapter = New Proyecto.BazarDataSetTableAdapters.ComprasTableAdapter()
        Label1 = New System.Windows.Forms.Label()
        CodigoPostalLabel = New System.Windows.Forms.Label()
        LocalidadLabel = New System.Windows.Forms.Label()
        ProvinciaLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        ID_ProveedorLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.ComprasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKComprasIDProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BazarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigosPostalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Label1, "Label1")
        Label1.ForeColor = System.Drawing.SystemColors.Window
        Label1.Name = "Label1"
        '
        'SplitContainer2
        '
        resources.ApplyResources(Me.SplitContainer2, "SplitContainer2")
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        resources.ApplyResources(Me.SplitContainer2.Panel1, "SplitContainer2.Panel1")
        Me.SplitContainer2.Panel1.Controls.Add(Me.ComprasDataGridView)
        '
        'SplitContainer2.Panel2
        '
        resources.ApplyResources(Me.SplitContainer2.Panel2, "SplitContainer2.Panel2")
        Me.SplitContainer2.Panel2.Controls.Add(Me.ProveedoresDataGridView)
        '
        'ComprasDataGridView
        '
        Me.ComprasDataGridView.AutoGenerateColumns = False
        Me.ComprasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ComprasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDProveedorDataGridViewTextBoxColumn, Me.IDCompraDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.SubTotalDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.ComprasDataGridView.DataSource = Me.FKComprasIDProveedorBindingSource
        resources.ApplyResources(Me.ComprasDataGridView, "ComprasDataGridView")
        Me.ComprasDataGridView.Name = "ComprasDataGridView"
        '
        'IDProveedorDataGridViewTextBoxColumn
        '
        Me.IDProveedorDataGridViewTextBoxColumn.DataPropertyName = "ID_Proveedor"
        resources.ApplyResources(Me.IDProveedorDataGridViewTextBoxColumn, "IDProveedorDataGridViewTextBoxColumn")
        Me.IDProveedorDataGridViewTextBoxColumn.Name = "IDProveedorDataGridViewTextBoxColumn"
        '
        'IDCompraDataGridViewTextBoxColumn
        '
        Me.IDCompraDataGridViewTextBoxColumn.DataPropertyName = "ID_Compra"
        resources.ApplyResources(Me.IDCompraDataGridViewTextBoxColumn, "IDCompraDataGridViewTextBoxColumn")
        Me.IDCompraDataGridViewTextBoxColumn.Name = "IDCompraDataGridViewTextBoxColumn"
        Me.IDCompraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        resources.ApplyResources(Me.FechaDataGridViewTextBoxColumn, "FechaDataGridViewTextBoxColumn")
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'SubTotalDataGridViewTextBoxColumn
        '
        Me.SubTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal"
        resources.ApplyResources(Me.SubTotalDataGridViewTextBoxColumn, "SubTotalDataGridViewTextBoxColumn")
        Me.SubTotalDataGridViewTextBoxColumn.Name = "SubTotalDataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        resources.ApplyResources(Me.TotalDataGridViewTextBoxColumn, "TotalDataGridViewTextBoxColumn")
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'FKComprasIDProveedorBindingSource
        '
        Me.FKComprasIDProveedorBindingSource.DataMember = "FK_Compras_IDProveedor"
        Me.FKComprasIDProveedorBindingSource.DataSource = Me.ProveedoresBindingSource
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.BazarDataSet
        '
        'BazarDataSet
        '
        Me.BazarDataSet.DataSetName = "BazarDataSet"
        Me.BazarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedoresDataGridView
        '
        Me.ProveedoresDataGridView.AutoGenerateColumns = False
        Me.ProveedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProveedoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ProveedoresDataGridView.DataSource = Me.ProveedoresBindingSource
        resources.ApplyResources(Me.ProveedoresDataGridView, "ProveedoresDataGridView")
        Me.ProveedoresDataGridView.Name = "ProveedoresDataGridView"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ID_Proveedor"
        resources.ApplyResources(Me.DataGridViewTextBoxColumn6, "DataGridViewTextBoxColumn6")
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Nombre"
        resources.ApplyResources(Me.DataGridViewTextBoxColumn1, "DataGridViewTextBoxColumn1")
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Telefono"
        resources.ApplyResources(Me.DataGridViewTextBoxColumn2, "DataGridViewTextBoxColumn2")
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Email"
        resources.ApplyResources(Me.DataGridViewTextBoxColumn3, "DataGridViewTextBoxColumn3")
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Direccion"
        resources.ApplyResources(Me.DataGridViewTextBoxColumn4, "DataGridViewTextBoxColumn4")
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CodigoPostal"
        resources.ApplyResources(Me.DataGridViewTextBoxColumn5, "DataGridViewTextBoxColumn5")
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'CodigoPostalLabel
        '
        resources.ApplyResources(CodigoPostalLabel, "CodigoPostalLabel")
        CodigoPostalLabel.ForeColor = System.Drawing.SystemColors.Window
        CodigoPostalLabel.Name = "CodigoPostalLabel"
        '
        'LocalidadLabel
        '
        resources.ApplyResources(LocalidadLabel, "LocalidadLabel")
        LocalidadLabel.ForeColor = System.Drawing.SystemColors.Window
        LocalidadLabel.Name = "LocalidadLabel"
        '
        'ProvinciaLabel
        '
        resources.ApplyResources(ProvinciaLabel, "ProvinciaLabel")
        ProvinciaLabel.ForeColor = System.Drawing.SystemColors.Window
        ProvinciaLabel.Name = "ProvinciaLabel"
        '
        'NombreLabel
        '
        resources.ApplyResources(NombreLabel, "NombreLabel")
        NombreLabel.ForeColor = System.Drawing.SystemColors.Window
        NombreLabel.Name = "NombreLabel"
        '
        'TelefonoLabel
        '
        resources.ApplyResources(TelefonoLabel, "TelefonoLabel")
        TelefonoLabel.ForeColor = System.Drawing.SystemColors.Window
        TelefonoLabel.Name = "TelefonoLabel"
        '
        'EmailLabel
        '
        resources.ApplyResources(EmailLabel, "EmailLabel")
        EmailLabel.ForeColor = System.Drawing.SystemColors.Window
        EmailLabel.Name = "EmailLabel"
        '
        'DireccionLabel
        '
        resources.ApplyResources(DireccionLabel, "DireccionLabel")
        DireccionLabel.ForeColor = System.Drawing.SystemColors.Window
        DireccionLabel.Name = "DireccionLabel"
        '
        'ID_ProveedorLabel
        '
        resources.ApplyResources(ID_ProveedorLabel, "ID_ProveedorLabel")
        ID_ProveedorLabel.ForeColor = System.Drawing.SystemColors.Window
        ID_ProveedorLabel.Name = "ID_ProveedorLabel"
        '
        'CodigosPostalesBindingSource
        '
        Me.CodigosPostalesBindingSource.DataMember = "CodigosPostales"
        Me.CodigosPostalesBindingSource.DataSource = Me.BazarDataSet
        '
        'CodigosPostalesTableAdapter
        '
        Me.CodigosPostalesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriasTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.CodigosPostalesTableAdapter = Me.CodigosPostalesTableAdapter
        Me.TableAdapterManager.ComprasTableAdapter = Nothing
        Me.TableAdapterManager.Detalles_ComprasTableAdapter = Nothing
        Me.TableAdapterManager.Detalles_VentasTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Me.ProveedoresTableAdapter
        Me.TableAdapterManager.UpdateOrder = Proyecto.BazarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip
        '
        Me.MenuStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.MenuStrip.BackColor = System.Drawing.Color.LemonChiffon
        resources.ApplyResources(Me.MenuStrip, "MenuStrip")
        Me.MenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemVolver, Me.MenuItemClientes, Me.MenuItemVentas, Me.MenuItemCompras, Me.MenuItemProductos, Me.MenuItemOtros, Me.MenuItemContacto, Me.MenuItemSalir})
        Me.MenuStrip.Name = "MenuStrip"
        '
        'MenuItemVolver
        '
        resources.ApplyResources(Me.MenuItemVolver, "MenuItemVolver")
        Me.MenuItemVolver.ForeColor = System.Drawing.Color.Black
        Me.MenuItemVolver.Margin = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.MenuItemVolver.Name = "MenuItemVolver"
        Me.MenuItemVolver.Padding = New System.Windows.Forms.Padding(0)
        '
        'MenuItemClientes
        '
        resources.ApplyResources(Me.MenuItemClientes, "MenuItemClientes")
        Me.MenuItemClientes.ForeColor = System.Drawing.Color.Black
        Me.MenuItemClientes.Margin = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.MenuItemClientes.Name = "MenuItemClientes"
        Me.MenuItemClientes.Padding = New System.Windows.Forms.Padding(0)
        '
        'MenuItemVentas
        '
        resources.ApplyResources(Me.MenuItemVentas, "MenuItemVentas")
        Me.MenuItemVentas.Margin = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.MenuItemVentas.Name = "MenuItemVentas"
        Me.MenuItemVentas.Padding = New System.Windows.Forms.Padding(0)
        '
        'MenuItemCompras
        '
        resources.ApplyResources(Me.MenuItemCompras, "MenuItemCompras")
        Me.MenuItemCompras.Margin = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.MenuItemCompras.Name = "MenuItemCompras"
        Me.MenuItemCompras.Padding = New System.Windows.Forms.Padding(0)
        '
        'MenuItemProductos
        '
        resources.ApplyResources(Me.MenuItemProductos, "MenuItemProductos")
        Me.MenuItemProductos.ForeColor = System.Drawing.Color.Black
        Me.MenuItemProductos.Margin = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.MenuItemProductos.Name = "MenuItemProductos"
        Me.MenuItemProductos.Padding = New System.Windows.Forms.Padding(0)
        '
        'MenuItemOtros
        '
        Me.MenuItemOtros.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemOtrosDirecciones, Me.MenuItemOtrosCategorias})
        resources.ApplyResources(Me.MenuItemOtros, "MenuItemOtros")
        Me.MenuItemOtros.Margin = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.MenuItemOtros.Name = "MenuItemOtros"
        Me.MenuItemOtros.Padding = New System.Windows.Forms.Padding(0)
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
        Me.MenuItemContacto.Margin = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.MenuItemContacto.Name = "MenuItemContacto"
        Me.MenuItemContacto.Padding = New System.Windows.Forms.Padding(0)
        '
        'MenuItemSalir
        '
        resources.ApplyResources(Me.MenuItemSalir, "MenuItemSalir")
        Me.MenuItemSalir.ForeColor = System.Drawing.Color.Black
        Me.MenuItemSalir.Margin = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.MenuItemSalir.Name = "MenuItemSalir"
        Me.MenuItemSalir.Padding = New System.Windows.Forms.Padding(0)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'SplitContainer1
        '
        resources.ApplyResources(Me.SplitContainer1, "SplitContainer1")
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonEliminarTodos)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonActualizar)
        Me.SplitContainer1.Panel1.Controls.Add(CodigoPostalLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CodigoPostalTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(LocalidadLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LocalidadTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(ProvinciaLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ProvinciaTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonBuscarSiguiente)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonBuscarAnterior)
        Me.SplitContainer1.Panel1.Controls.Add(NombreLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NombreTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(TelefonoLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TelefonoTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(EmailLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.EmailTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(DireccionLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DireccionTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(ID_ProveedorLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ID_ProveedorTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonBuscar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxConsulta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonEliminar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonGuardar)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        '
        'ButtonEliminarTodos
        '
        Me.ButtonEliminarTodos.BackColor = System.Drawing.Color.Crimson
        resources.ApplyResources(Me.ButtonEliminarTodos, "ButtonEliminarTodos")
        Me.ButtonEliminarTodos.Name = "ButtonEliminarTodos"
        Me.ButtonEliminarTodos.UseVisualStyleBackColor = False
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.BackColor = System.Drawing.Color.Yellow
        resources.ApplyResources(Me.ButtonActualizar, "ButtonActualizar")
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.UseVisualStyleBackColor = False
        '
        'CodigoPostalTextBox
        '
        resources.ApplyResources(Me.CodigoPostalTextBox, "CodigoPostalTextBox")
        Me.CodigoPostalTextBox.Name = "CodigoPostalTextBox"
        '
        'LocalidadTextBox
        '
        resources.ApplyResources(Me.LocalidadTextBox, "LocalidadTextBox")
        Me.LocalidadTextBox.Name = "LocalidadTextBox"
        '
        'ProvinciaTextBox
        '
        resources.ApplyResources(Me.ProvinciaTextBox, "ProvinciaTextBox")
        Me.ProvinciaTextBox.Name = "ProvinciaTextBox"
        '
        'ButtonBuscarSiguiente
        '
        Me.ButtonBuscarSiguiente.BackColor = System.Drawing.Color.LightGreen
        resources.ApplyResources(Me.ButtonBuscarSiguiente, "ButtonBuscarSiguiente")
        Me.ButtonBuscarSiguiente.Name = "ButtonBuscarSiguiente"
        Me.ButtonBuscarSiguiente.UseVisualStyleBackColor = False
        '
        'ButtonBuscarAnterior
        '
        Me.ButtonBuscarAnterior.BackColor = System.Drawing.Color.LightGreen
        resources.ApplyResources(Me.ButtonBuscarAnterior, "ButtonBuscarAnterior")
        Me.ButtonBuscarAnterior.Name = "ButtonBuscarAnterior"
        Me.ButtonBuscarAnterior.UseVisualStyleBackColor = False
        '
        'NombreTextBox
        '
        resources.ApplyResources(Me.NombreTextBox, "NombreTextBox")
        Me.NombreTextBox.Name = "NombreTextBox"
        '
        'TelefonoTextBox
        '
        resources.ApplyResources(Me.TelefonoTextBox, "TelefonoTextBox")
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        '
        'EmailTextBox
        '
        resources.ApplyResources(Me.EmailTextBox, "EmailTextBox")
        Me.EmailTextBox.Name = "EmailTextBox"
        '
        'DireccionTextBox
        '
        resources.ApplyResources(Me.DireccionTextBox, "DireccionTextBox")
        Me.DireccionTextBox.Name = "DireccionTextBox"
        '
        'ID_ProveedorTextBox
        '
        resources.ApplyResources(Me.ID_ProveedorTextBox, "ID_ProveedorTextBox")
        Me.ID_ProveedorTextBox.Name = "ID_ProveedorTextBox"
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.BackColor = System.Drawing.Color.Cyan
        resources.ApplyResources(Me.ButtonBuscar, "ButtonBuscar")
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = False
        '
        'TextBoxConsulta
        '
        resources.ApplyResources(Me.TextBoxConsulta, "TextBoxConsulta")
        Me.TextBoxConsulta.Name = "TextBoxConsulta"
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.BackColor = System.Drawing.Color.DarkOrange
        resources.ApplyResources(Me.ButtonEliminar, "ButtonEliminar")
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = False
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.BackColor = System.Drawing.Color.Lime
        resources.ApplyResources(Me.ButtonGuardar, "ButtonGuardar")
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.UseVisualStyleBackColor = False
        '
        'ComprasBindingSource
        '
        Me.ComprasBindingSource.DataMember = "FK_Compras_IDProveedor"
        Me.ComprasBindingSource.DataSource = Me.ProveedoresBindingSource
        '
        'ComprasTableAdapter
        '
        Me.ComprasTableAdapter.ClearBeforeFill = True
        '
        'Proveedores
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Proveedores"
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.ComprasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKComprasIDProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BazarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigosPostalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BazarDataSet As Proyecto.BazarDataSet
    Friend WithEvents CodigosPostalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CodigosPostalesTableAdapter As Proyecto.BazarDataSetTableAdapters.CodigosPostalesTableAdapter
    Friend WithEvents TableAdapterManager As Proyecto.BazarDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProveedoresTableAdapter As Proyecto.BazarDataSetTableAdapters.ProveedoresTableAdapter
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Public WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuItemVolver As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemVentas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemCompras As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemProductos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemOtros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemOtrosDirecciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemOtrosCategorias As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemContacto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
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
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ComprasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ProveedoresDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComprasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComprasTableAdapter As Proyecto.BazarDataSetTableAdapters.ComprasTableAdapter
    Friend WithEvents IDProveedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDCompraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FKComprasIDProveedorBindingSource As System.Windows.Forms.BindingSource
End Class
