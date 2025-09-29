Public Class Compras

    Dim subtotal As System.Decimal
    Dim total As System.Decimal
    Dim cantidad As System.Int32

    Function BuscarProveedor() As Integer
        Try

            Dim valorBuscado As Integer = Convert.ToInt64(ID_ProveedorNumericUpDown)

            Dim posicion As Integer = ProveedoresBindingSource.Find("ID_Proveedor", valorBuscado)

            If posicion >= 0 Then
                ProveedoresBindingSource.Position = posicion
                Return valorBuscado
            Else
                MsgBox("No se encontro Proveedor con ID: " & valorBuscado)
                Return -1
            End If

        Catch ex As FormatException
            MessageBox.Show("Por favor ingrese un número de ID válido")
            Return -1
        Catch ex As Exception
            MsgBox("Error al buscar Proveedor por ID : " & ex.Message)
            Return -1
        End Try
    End Function

    Private Sub ComprasBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.ComprasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)
    End Sub

    Private Sub Compras_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BazarDataSet.Categorias' Puede moverla o quitarla según sea necesario.
        Me.CategoriasTableAdapter.Fill(Me.BazarDataSet.Categorias)
        'TODO: esta línea de código carga datos en la tabla 'BazarDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)
        'TODO: esta línea de código carga datos en la tabla 'BazarDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.BazarDataSet.Proveedores)
        'TODO: esta línea de código carga datos en la tabla 'BazarDataSet.Detalles_Compras' Puede moverla o quitarla según sea necesario.
        Me.Detalles_ComprasTableAdapter.Fill(Me.BazarDataSet.Detalles_Compras)
        'TODO: esta línea de código carga datos en la tabla 'BazarDataSet.Compras' Puede moverla o quitarla según sea necesario.
        Me.ComprasTableAdapter.Fill(Me.BazarDataSet.Compras)
    End Sub

    Private Sub ButtonAgregarAlCarro_Click(sender As System.Object, e As System.EventArgs) Handles ButtonAgregarAlCarro.Click

        Try

            Dim idProveedor As Integer = BuscarProveedor()

        Catch ex As Exception

        End Try

    End Sub


    Private Sub MenuItemVolver_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemVolver.Click
        Me.Hide()
        Bazar.Show()
    End Sub

    Private Sub MenuItemClientes_Click(sender As System.Object, e As System.EventArgs)
        Clientes.Show()
        Me.Hide()
    End Sub

    Private Sub MenuItemProveedores_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemProveedores.Click
        Me.Hide()
        Proveedores.Show()
    End Sub


    Private Sub MenuItemVentas_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemVentas.Click
        Me.Hide()
        Ventas.Show()
    End Sub

    Private Sub MenuItemOtrosDirecciones_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemOtrosDirecciones.Click
        Me.Hide()
        Productos.Show()
    End Sub


    Private Sub MenuItemContacto_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemContacto.Click
        Me.Hide()
        Contacto.Show()
    End Sub

    Private Sub MenuItemSalir_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemSalir.Click
        End
    End Sub

    Private Sub MenuItemProductos_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemProductos.Click
        Me.Hide()
        Productos.Show()
    End Sub
End Class