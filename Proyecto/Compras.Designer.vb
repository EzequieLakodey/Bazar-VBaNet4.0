<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compras
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ID_ProveedorLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim ID_CompraLabel As System.Windows.Forms.Label
        Dim ID_ProductoLabel As System.Windows.Forms.Label
        Dim NombreLabel1 As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim ID_CategoriaLabel As System.Windows.Forms.Label
        Dim NombreLabel2 As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim ID_DetalleCompraLabel As System.Windows.Forms.Label
        Dim StockLabel As System.Windows.Forms.Label
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.StockTextBox = New System.Windows.Forms.TextBox()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BazarDataSet = New Proyecto.BazarDataSet()
        Me.ButtonEliminarTodos = New System.Windows.Forms.Button()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonAgregarAlCarro = New System.Windows.Forms.Button()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.Detalles_ComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.ID_DetalleCompraTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox1 = New System.Windows.Forms.TextBox()
        Me.CategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_CategoriaTextBox = New System.Windows.Forms.TextBox()
        Me.ID_ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.ID_CompraTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ComprasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_ProveedorNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.NombreListBox = New System.Windows.Forms.ListBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ComprasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Detalles_ComprasDataGridView = New System.Windows.Forms.DataGridView()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuItemVolver = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemProductos = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemProveedores = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemVentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemOtros = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemOtrosDirecciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemContacto = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasTableAdapter = New Proyecto.BazarDataSetTableAdapters.ComprasTableAdapter()
        Me.TableAdapterManager = New Proyecto.BazarDataSetTableAdapters.TableAdapterManager()
        Me.CategoriasTableAdapter = New Proyecto.BazarDataSetTableAdapters.CategoriasTableAdapter()
        Me.Detalles_ComprasTableAdapter = New Proyecto.BazarDataSetTableAdapters.Detalles_ComprasTableAdapter()
        Me.ProductosTableAdapter = New Proyecto.BazarDataSetTableAdapters.ProductosTableAdapter()
        Me.ProveedoresTableAdapter = New Proyecto.BazarDataSetTableAdapters.ProveedoresTableAdapter()
        Me.Detalles_ComprasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        NombreLabel = New System.Windows.Forms.Label()
        ID_ProveedorLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        ID_CompraLabel = New System.Windows.Forms.Label()
        ID_ProductoLabel = New System.Windows.Forms.Label()
        NombreLabel1 = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        ID_CategoriaLabel = New System.Windows.Forms.Label()
        NombreLabel2 = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        ID_DetalleCompraLabel = New System.Windows.Forms.Label()
        StockLabel = New System.Windows.Forms.Label()
        Me.PanelMain.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BazarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detalles_ComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ID_ProveedorNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.ComprasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detalles_ComprasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        CType(Me.Detalles_ComprasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(18, 8)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(98, 18)
        NombreLabel.TabIndex = 0
        NombreLabel.Text = "Proveedor"
        '
        'ID_ProveedorLabel
        '
        ID_ProveedorLabel.AutoSize = True
        ID_ProveedorLabel.Location = New System.Drawing.Point(18, 99)
        ID_ProveedorLabel.Name = "ID_ProveedorLabel"
        ID_ProveedorLabel.Size = New System.Drawing.Size(38, 18)
        ID_ProveedorLabel.TabIndex = 2
        ID_ProveedorLabel.Text = "ID:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(18, 158)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(68, 18)
        FechaLabel.TabIndex = 4
        FechaLabel.Text = "Fecha:"
        '
        'ID_CompraLabel
        '
        ID_CompraLabel.AutoSize = True
        ID_CompraLabel.Location = New System.Drawing.Point(18, 211)
        ID_CompraLabel.Name = "ID_CompraLabel"
        ID_CompraLabel.Size = New System.Drawing.Size(108, 18)
        ID_CompraLabel.TabIndex = 6
        ID_CompraLabel.Text = "ID Compra:"
        '
        'ID_ProductoLabel
        '
        ID_ProductoLabel.AutoSize = True
        ID_ProductoLabel.Location = New System.Drawing.Point(255, 8)
        ID_ProductoLabel.Name = "ID_ProductoLabel"
        ID_ProductoLabel.Size = New System.Drawing.Size(128, 18)
        ID_ProductoLabel.TabIndex = 8
        ID_ProductoLabel.Text = "ID Producto:"
        '
        'NombreLabel1
        '
        NombreLabel1.AutoSize = True
        NombreLabel1.Location = New System.Drawing.Point(255, 58)
        NombreLabel1.Name = "NombreLabel1"
        NombreLabel1.Size = New System.Drawing.Size(78, 18)
        NombreLabel1.TabIndex = 10
        NombreLabel1.Text = "Nombre:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(255, 107)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(128, 18)
        DescripcionLabel.TabIndex = 12
        DescripcionLabel.Text = "Descripcion:"
        '
        'ID_CategoriaLabel
        '
        ID_CategoriaLabel.AutoSize = True
        ID_CategoriaLabel.Location = New System.Drawing.Point(475, 58)
        ID_CategoriaLabel.Name = "ID_CategoriaLabel"
        ID_CategoriaLabel.Size = New System.Drawing.Size(138, 18)
        ID_CategoriaLabel.TabIndex = 20
        ID_CategoriaLabel.Text = "ID Categoria:"
        '
        'NombreLabel2
        '
        NombreLabel2.AutoSize = True
        NombreLabel2.Location = New System.Drawing.Point(475, 9)
        NombreLabel2.Name = "NombreLabel2"
        NombreLabel2.Size = New System.Drawing.Size(108, 18)
        NombreLabel2.TabIndex = 22
        NombreLabel2.Text = "Categoria:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(255, 158)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(98, 18)
        CantidadLabel.TabIndex = 28
        CantidadLabel.Text = "Cantidad:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(255, 266)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(78, 18)
        PrecioLabel.TabIndex = 30
        PrecioLabel.Text = "Precio:"
        '
        'ID_DetalleCompraLabel
        '
        ID_DetalleCompraLabel.AutoSize = True
        ID_DetalleCompraLabel.Location = New System.Drawing.Point(18, 266)
        ID_DetalleCompraLabel.Name = "ID_DetalleCompraLabel"
        ID_DetalleCompraLabel.Size = New System.Drawing.Size(188, 18)
        ID_DetalleCompraLabel.TabIndex = 34
        ID_DetalleCompraLabel.Text = "ID Detalle Compra:"
        '
        'StockLabel
        '
        StockLabel.AutoSize = True
        StockLabel.Location = New System.Drawing.Point(255, 211)
        StockLabel.Name = "StockLabel"
        StockLabel.Size = New System.Drawing.Size(68, 18)
        StockLabel.TabIndex = 106
        StockLabel.Text = "Stock:"
        '
        'PanelMain
        '
        Me.PanelMain.AllowDrop = True
        Me.PanelMain.BackColor = System.Drawing.Color.SteelBlue
        Me.PanelMain.Controls.Add(Me.SplitContainer1)
        Me.PanelMain.Controls.Add(Me.MenuStrip)
        Me.PanelMain.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Font = New System.Drawing.Font("Liberation Mono", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelMain.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PanelMain.Location = New System.Drawing.Point(0, 0)
        Me.PanelMain.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(1274, 691)
        Me.PanelMain.TabIndex = 4
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 34)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(StockLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.StockTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonEliminarTodos)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonActualizar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonEliminar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonAgregarAlCarro)
        Me.SplitContainer1.Panel1.Controls.Add(CantidadLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CantidadTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(PrecioLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PrecioTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(ID_DetalleCompraLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ID_DetalleCompraTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(NombreLabel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NombreTextBox1)
        Me.SplitContainer1.Panel1.Controls.Add(ID_CategoriaLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ID_CategoriaTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(ID_ProductoLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ID_ProductoTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(NombreLabel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NombreTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(DescripcionLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DescripcionTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(ID_CompraLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ID_CompraTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(FechaLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FechaDateTimePicker)
        Me.SplitContainer1.Panel1.Controls.Add(ID_ProveedorLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ID_ProveedorNumericUpDown)
        Me.SplitContainer1.Panel1.Controls.Add(NombreLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NombreListBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1274, 657)
        Me.SplitContainer1.SplitterDistance = 348
        Me.SplitContainer1.TabIndex = 5
        '
        'StockTextBox
        '
        Me.StockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Stock", True))
        Me.StockTextBox.Location = New System.Drawing.Point(258, 232)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.Size = New System.Drawing.Size(192, 26)
        Me.StockTextBox.TabIndex = 107
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.BazarDataSet
        '
        'BazarDataSet
        '
        Me.BazarDataSet.DataSetName = "BazarDataSet"
        Me.BazarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ButtonEliminarTodos
        '
        Me.ButtonEliminarTodos.BackColor = System.Drawing.Color.Crimson
        Me.ButtonEliminarTodos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonEliminarTodos.Location = New System.Drawing.Point(764, 266)
        Me.ButtonEliminarTodos.Name = "ButtonEliminarTodos"
        Me.ButtonEliminarTodos.Size = New System.Drawing.Size(150, 34)
        Me.ButtonEliminarTodos.TabIndex = 106
        Me.ButtonEliminarTodos.Text = "Eliminar Todo"
        Me.ButtonEliminarTodos.UseVisualStyleBackColor = False
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.BackColor = System.Drawing.Color.Yellow
        Me.ButtonActualizar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonActualizar.Location = New System.Drawing.Point(764, 224)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(150, 34)
        Me.ButtonActualizar.TabIndex = 105
        Me.ButtonActualizar.Text = "Actualizar"
        Me.ButtonActualizar.UseVisualStyleBackColor = False
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.BackColor = System.Drawing.Color.DarkOrange
        Me.ButtonEliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonEliminar.Location = New System.Drawing.Point(764, 309)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(150, 34)
        Me.ButtonEliminar.TabIndex = 103
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = False
        '
        'ButtonAgregarAlCarro
        '
        Me.ButtonAgregarAlCarro.BackColor = System.Drawing.Color.Lime
        Me.ButtonAgregarAlCarro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonAgregarAlCarro.Location = New System.Drawing.Point(478, 125)
        Me.ButtonAgregarAlCarro.Name = "ButtonAgregarAlCarro"
        Me.ButtonAgregarAlCarro.Size = New System.Drawing.Size(150, 32)
        Me.ButtonAgregarAlCarro.TabIndex = 104
        Me.ButtonAgregarAlCarro.Text = "Agregar"
        Me.ButtonAgregarAlCarro.UseVisualStyleBackColor = False
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalles_ComprasBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(258, 179)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(192, 26)
        Me.CantidadTextBox.TabIndex = 29
        '
        'Detalles_ComprasBindingSource
        '
        Me.Detalles_ComprasBindingSource.DataMember = "FK_DetallesCompras_IDCompra"
        Me.Detalles_ComprasBindingSource.DataSource = Me.ComprasBindingSource
        '
        'ComprasBindingSource
        '
        Me.ComprasBindingSource.DataMember = "Compras"
        Me.ComprasBindingSource.DataSource = Me.BazarDataSet
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalles_ComprasBindingSource, "Precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(258, 287)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(192, 26)
        Me.PrecioTextBox.TabIndex = 31
        '
        'ID_DetalleCompraTextBox
        '
        Me.ID_DetalleCompraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalles_ComprasBindingSource, "ID_DetalleCompra", True))
        Me.ID_DetalleCompraTextBox.Location = New System.Drawing.Point(21, 287)
        Me.ID_DetalleCompraTextBox.Name = "ID_DetalleCompraTextBox"
        Me.ID_DetalleCompraTextBox.Size = New System.Drawing.Size(192, 26)
        Me.ID_DetalleCompraTextBox.TabIndex = 35
        '
        'NombreTextBox1
        '
        Me.NombreTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriasBindingSource, "Nombre", True))
        Me.NombreTextBox1.Location = New System.Drawing.Point(478, 29)
        Me.NombreTextBox1.Name = "NombreTextBox1"
        Me.NombreTextBox1.Size = New System.Drawing.Size(192, 26)
        Me.NombreTextBox1.TabIndex = 23
        '
        'CategoriasBindingSource
        '
        Me.CategoriasBindingSource.DataMember = "Categorias"
        Me.CategoriasBindingSource.DataSource = Me.BazarDataSet
        '
        'ID_CategoriaTextBox
        '
        Me.ID_CategoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriasBindingSource, "ID_Categoria", True))
        Me.ID_CategoriaTextBox.Location = New System.Drawing.Point(478, 79)
        Me.ID_CategoriaTextBox.Name = "ID_CategoriaTextBox"
        Me.ID_CategoriaTextBox.Size = New System.Drawing.Size(192, 26)
        Me.ID_CategoriaTextBox.TabIndex = 21
        '
        'ID_ProductoTextBox
        '
        Me.ID_ProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "ID_Producto", True))
        Me.ID_ProductoTextBox.Location = New System.Drawing.Point(258, 29)
        Me.ID_ProductoTextBox.Name = "ID_ProductoTextBox"
        Me.ID_ProductoTextBox.Size = New System.Drawing.Size(192, 26)
        Me.ID_ProductoTextBox.TabIndex = 9
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(258, 79)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(192, 26)
        Me.NombreTextBox.TabIndex = 11
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(258, 129)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(192, 26)
        Me.DescripcionTextBox.TabIndex = 13
        '
        'ID_CompraTextBox
        '
        Me.ID_CompraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalles_ComprasBindingSource, "ID_Compra", True))
        Me.ID_CompraTextBox.Location = New System.Drawing.Point(21, 232)
        Me.ID_CompraTextBox.Name = "ID_CompraTextBox"
        Me.ID_CompraTextBox.Size = New System.Drawing.Size(192, 26)
        Me.ID_CompraTextBox.TabIndex = 7
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ComprasBindingSource1, "Fecha", True))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(21, 176)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(192, 26)
        Me.FechaDateTimePicker.TabIndex = 5
        '
        'ComprasBindingSource1
        '
        Me.ComprasBindingSource1.DataMember = "FK_Compras_IDProveedor"
        Me.ComprasBindingSource1.DataSource = Me.ProveedoresBindingSource
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.BazarDataSet
        '
        'ID_ProveedorNumericUpDown
        '
        Me.ID_ProveedorNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProveedoresBindingSource, "ID_Proveedor", True))
        Me.ID_ProveedorNumericUpDown.Location = New System.Drawing.Point(21, 120)
        Me.ID_ProveedorNumericUpDown.Name = "ID_ProveedorNumericUpDown"
        Me.ID_ProveedorNumericUpDown.Size = New System.Drawing.Size(192, 26)
        Me.ID_ProveedorNumericUpDown.TabIndex = 3
        '
        'NombreListBox
        '
        Me.NombreListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProveedoresBindingSource, "Nombre", True))
        Me.NombreListBox.DataSource = Me.ProveedoresBindingSource
        Me.NombreListBox.DisplayMember = "Nombre"
        Me.NombreListBox.FormattingEnabled = True
        Me.NombreListBox.ItemHeight = 18
        Me.NombreListBox.Location = New System.Drawing.Point(21, 29)
        Me.NombreListBox.Name = "NombreListBox"
        Me.NombreListBox.Size = New System.Drawing.Size(192, 58)
        Me.NombreListBox.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.Controls.Add(Me.ComprasDataGridView)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Detalles_ComprasDataGridView)
        Me.SplitContainer2.Size = New System.Drawing.Size(1274, 305)
        Me.SplitContainer2.SplitterDistance = 551
        Me.SplitContainer2.TabIndex = 0
        '
        'ComprasDataGridView
        '
        Me.ComprasDataGridView.AutoGenerateColumns = False
        Me.ComprasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ComprasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ComprasDataGridView.DataSource = Me.ComprasBindingSource
        Me.ComprasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComprasDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ComprasDataGridView.Name = "ComprasDataGridView"
        Me.ComprasDataGridView.Size = New System.Drawing.Size(551, 305)
        Me.ComprasDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ID_Compra"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ID_Compra"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID_Proveedor"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID_Proveedor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SubTotal"
        Me.DataGridViewTextBoxColumn3.HeaderText = "SubTotal"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Detalles_ComprasDataGridView
        '
        Me.Detalles_ComprasDataGridView.AutoGenerateColumns = False
        Me.Detalles_ComprasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Detalles_ComprasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.Detalles_ComprasDataGridView.DataSource = Me.Detalles_ComprasBindingSource
        Me.Detalles_ComprasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Detalles_ComprasDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Detalles_ComprasDataGridView.Name = "Detalles_ComprasDataGridView"
        Me.Detalles_ComprasDataGridView.Size = New System.Drawing.Size(719, 305)
        Me.Detalles_ComprasDataGridView.TabIndex = 0
        '
        'MenuStrip
        '
        Me.MenuStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.MenuStrip.BackColor = System.Drawing.Color.LemonChiffon
        Me.MenuStrip.Font = New System.Drawing.Font("Liberation Mono", 20.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemVolver, Me.MenuItemClientes, Me.MenuItemVentas, Me.MenuItemProveedores, Me.MenuItemProductos, Me.MenuItemOtros, Me.MenuItemContacto, Me.MenuItemSalir})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MinimumSize = New System.Drawing.Size(200, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuStrip.Size = New System.Drawing.Size(1274, 34)
        Me.MenuStrip.TabIndex = 4
        Me.MenuStrip.Text = "Menu"
        '
        'MenuItemVolver
        '
        Me.MenuItemVolver.Font = New System.Drawing.Font("Liberation Mono", 20.0!, System.Drawing.FontStyle.Bold)
        Me.MenuItemVolver.ForeColor = System.Drawing.Color.Black
        Me.MenuItemVolver.Margin = New System.Windows.Forms.Padding(31, 0, 0, 0)
        Me.MenuItemVolver.Name = "MenuItemVolver"
        Me.MenuItemVolver.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuItemVolver.Size = New System.Drawing.Size(36, 34)
        Me.MenuItemVolver.Text = "🡐"
        '
        'MenuItemClientes
        '
        Me.MenuItemClientes.Font = New System.Drawing.Font("Liberation Mono", 20.0!, System.Drawing.FontStyle.Bold)
        Me.MenuItemClientes.ForeColor = System.Drawing.Color.Black
        Me.MenuItemClientes.Margin = New System.Windows.Forms.Padding(31, 0, 0, 0)
        Me.MenuItemClientes.Name = "MenuItemClientes"
        Me.MenuItemClientes.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuItemClientes.Size = New System.Drawing.Size(145, 34)
        Me.MenuItemClientes.Text = "Clientes"
        '
        'MenuItemProductos
        '
        Me.MenuItemProductos.Font = New System.Drawing.Font("Liberation Mono", 20.0!, System.Drawing.FontStyle.Bold)
        Me.MenuItemProductos.ForeColor = System.Drawing.Color.Black
        Me.MenuItemProductos.Margin = New System.Windows.Forms.Padding(31, 0, 0, 0)
        Me.MenuItemProductos.Name = "MenuItemProductos"
        Me.MenuItemProductos.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuItemProductos.Size = New System.Drawing.Size(161, 34)
        Me.MenuItemProductos.Text = "Productos"
        '
        'MenuItemProveedores
        '
        Me.MenuItemProveedores.Font = New System.Drawing.Font("Liberation Mono", 20.0!, System.Drawing.FontStyle.Bold)
        Me.MenuItemProveedores.ForeColor = System.Drawing.Color.Black
        Me.MenuItemProveedores.Margin = New System.Windows.Forms.Padding(31, 0, 0, 0)
        Me.MenuItemProveedores.Name = "MenuItemProveedores"
        Me.MenuItemProveedores.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuItemProveedores.Size = New System.Drawing.Size(193, 34)
        Me.MenuItemProveedores.Text = "Proveedores"
        '
        'MenuItemVentas
        '
        Me.MenuItemVentas.Font = New System.Drawing.Font("Liberation Mono", 20.0!, System.Drawing.FontStyle.Bold)
        Me.MenuItemVentas.Margin = New System.Windows.Forms.Padding(31, 0, 0, 0)
        Me.MenuItemVentas.Name = "MenuItemVentas"
        Me.MenuItemVentas.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuItemVentas.Size = New System.Drawing.Size(113, 34)
        Me.MenuItemVentas.Text = "Ventas"
        '
        'MenuItemOtros
        '
        Me.MenuItemOtros.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemOtrosDirecciones})
        Me.MenuItemOtros.Font = New System.Drawing.Font("Liberation Mono", 20.0!, System.Drawing.FontStyle.Bold)
        Me.MenuItemOtros.Margin = New System.Windows.Forms.Padding(31, 0, 0, 0)
        Me.MenuItemOtros.Name = "MenuItemOtros"
        Me.MenuItemOtros.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuItemOtros.Size = New System.Drawing.Size(97, 34)
        Me.MenuItemOtros.Text = "Otros"
        '
        'MenuItemOtrosDirecciones
        '
        Me.MenuItemOtrosDirecciones.Name = "MenuItemOtrosDirecciones"
        Me.MenuItemOtrosDirecciones.Size = New System.Drawing.Size(262, 34)
        Me.MenuItemOtrosDirecciones.Text = "Direcciones"
        '
        'MenuItemContacto
        '
        Me.MenuItemContacto.Font = New System.Drawing.Font("Liberation Mono", 20.0!, System.Drawing.FontStyle.Bold)
        Me.MenuItemContacto.ForeColor = System.Drawing.Color.Black
        Me.MenuItemContacto.Margin = New System.Windows.Forms.Padding(31, 0, 0, 0)
        Me.MenuItemContacto.Name = "MenuItemContacto"
        Me.MenuItemContacto.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuItemContacto.Size = New System.Drawing.Size(145, 34)
        Me.MenuItemContacto.Text = "Contacto"
        '
        'MenuItemSalir
        '
        Me.MenuItemSalir.Font = New System.Drawing.Font("Liberation Mono", 20.0!, System.Drawing.FontStyle.Bold)
        Me.MenuItemSalir.ForeColor = System.Drawing.Color.Black
        Me.MenuItemSalir.Margin = New System.Windows.Forms.Padding(31, 0, 0, 0)
        Me.MenuItemSalir.Name = "MenuItemSalir"
        Me.MenuItemSalir.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuItemSalir.Size = New System.Drawing.Size(97, 34)
        Me.MenuItemSalir.Text = "Salir"
        '
        'ComprasTableAdapter
        '
        Me.ComprasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriasTableAdapter = Me.CategoriasTableAdapter
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.CodigosPostalesTableAdapter = Nothing
        Me.TableAdapterManager.ComprasTableAdapter = Me.ComprasTableAdapter
        Me.TableAdapterManager.Detalles_ComprasTableAdapter = Me.Detalles_ComprasTableAdapter
        Me.TableAdapterManager.Detalles_VentasTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Me.ProductosTableAdapter
        Me.TableAdapterManager.ProveedoresTableAdapter = Me.ProveedoresTableAdapter
        Me.TableAdapterManager.UpdateOrder = Proyecto.BazarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'CategoriasTableAdapter
        '
        Me.CategoriasTableAdapter.ClearBeforeFill = True
        '
        'Detalles_ComprasTableAdapter
        '
        Me.Detalles_ComprasTableAdapter.ClearBeforeFill = True
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'Detalles_ComprasBindingSource1
        '
        Me.Detalles_ComprasBindingSource1.DataMember = "FK_DetallesCompras_IDProducto"
        Me.Detalles_ComprasBindingSource1.DataSource = Me.ProductosBindingSource
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ID_DetalleCompra"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ID_DetalleCompra"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ID_Compra"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ID_Compra"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ID_Producto"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ID_Producto"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Precio"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "SubTotal"
        Me.DataGridViewTextBoxColumn10.HeaderText = "SubTotal"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 691)
        Me.Controls.Add(Me.PanelMain)
        Me.Font = New System.Drawing.Font("Liberation Mono", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Compras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras"
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BazarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detalles_ComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ID_ProveedorNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.ComprasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detalles_ComprasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.Detalles_ComprasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMain As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents BazarDataSet As Proyecto.BazarDataSet
    Friend WithEvents ComprasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComprasTableAdapter As Proyecto.BazarDataSetTableAdapters.ComprasTableAdapter
    Friend WithEvents TableAdapterManager As Proyecto.BazarDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ComprasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Detalles_ComprasTableAdapter As Proyecto.BazarDataSetTableAdapters.Detalles_ComprasTableAdapter
    Friend WithEvents Detalles_ComprasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Detalles_ComprasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ProveedoresTableAdapter As Proyecto.BazarDataSetTableAdapters.ProveedoresTableAdapter
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComprasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As Proyecto.BazarDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_ProveedorNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents NombreListBox As System.Windows.Forms.ListBox
    Friend WithEvents Detalles_ComprasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ID_ProductoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_CompraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CategoriasTableAdapter As Proyecto.BazarDataSetTableAdapters.CategoriasTableAdapter
    Friend WithEvents CategoriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CantidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrecioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_DetalleCompraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ID_CategoriaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StockTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ButtonEliminarTodos As System.Windows.Forms.Button
    Friend WithEvents ButtonActualizar As System.Windows.Forms.Button
    Friend WithEvents ButtonEliminar As System.Windows.Forms.Button
    Friend WithEvents ButtonAgregarAlCarro As System.Windows.Forms.Button
    Public WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuItemVolver As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemProductos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemProveedores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemVentas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemOtros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemOtrosDirecciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemContacto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
