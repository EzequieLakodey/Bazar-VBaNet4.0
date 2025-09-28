Public Class Clientes

    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

    End Sub

    Private Sub Clientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BazarDataSet.Detalles_Ventas' Puede moverla o quitarla según sea necesario.
        Me.Detalles_VentasTableAdapter.Fill(Me.BazarDataSet.Detalles_Ventas)
        'TODO: esta línea de código carga datos en la tabla 'BazarDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.BazarDataSet.Ventas)
        'TODO: esta línea de código carga datos en la tabla 'BazarDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BazarDataSet.Clientes)
    End Sub

End Class