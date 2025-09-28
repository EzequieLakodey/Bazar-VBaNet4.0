Public Class Bazar

    Private Sub Bazar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub MenuItemClientes_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemClientes.Click
        Me.Hide()
        Clientes.Show()
    End Sub

    Private Sub MenuItemVentas_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemVentas.Click
        Me.Hide()
        Ventas.Show()
    End Sub

    Private Sub MenuItemProveedores_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemProveedores.Click
        Me.Hide()
        Proveedores.Show()
    End Sub

    Private Sub MenuItemCompras_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemCompras.Click
        Me.Hide()
        Compras.Show()
    End Sub

    Private Sub MenuItemBalance_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemBalance.Click
        Me.Hide()
        Balance.Show()
    End Sub

    Private Sub MenuItemOtrosDirecciones_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemOtrosDirecciones.Click
        Me.Hide()
        Productos.Show()
    End Sub

    Private Sub MenuItemOtrosCategorias_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemOtrosCategorias.Click
        Me.Hide()
        Categorias.Show()
    End Sub

    Private Sub MenuItemContacto_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemContacto.Click
        Me.Hide()
        Contacto.Show()
    End Sub

    Private Sub MenuItemSalir_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemSalir.Click
        End
    End Sub
End Class
