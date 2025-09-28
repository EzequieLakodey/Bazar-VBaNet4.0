Public Class Proveedores

    Function BuscarProveedor() As Integer
        Try

            Dim valorBuscado As Integer = Convert.ToInt64(TextBoxConsulta.Text)

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


    Private Sub Proveedores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BazarDataSet.Compras' Puede moverla o quitarla según sea necesario.
        Me.ComprasTableAdapter.Fill(Me.BazarDataSet.Compras)
        'TODO: esta línea de código carga datos en la tabla 'BazarDataSet.Compras' Puede moverla o quitarla según sea necesario.
        Me.ComprasTableAdapter.Fill(Me.BazarDataSet.Compras)
        'TODO: esta línea de código carga datos en la tabla 'BazarDataSet.CodigosPostales' Puede moverla o quitarla según sea necesario.
        Me.CodigosPostalesTableAdapter.Fill(Me.BazarDataSet.CodigosPostales)
        'TODO: esta línea de código carga datos en la tabla 'BazarDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.BazarDataSet.Proveedores)

        ' Obtener el directorio desde donde se ejecuta la aplicación (que es \bin\Debug)
        'Dim directorioBase As String = System.IO.Path.GetFullPath          (AppDomain.CurrentDomain.BaseDirectory)
        'MessageBox.Show("La aplicación ejecuta desde: " & directorioBase)

        ' Construir la ruta completa al archivo de base de datos
        'Dim rutaCompletaBD As String = System.IO.Path.Combine(directorioBase, "Bazar.sdf")
        'MessageBox.Show("Ruta completa a la BD: " & rutaCompletaBD)
    End Sub

    Private Sub ProveedoresBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)
    End Sub

    Private Sub ButtonBuscarAnterior_Click(sender As System.Object, e As System.EventArgs)
        Me.ProveedoresBindingSource.MovePrevious()
    End Sub

    Private Sub ButtonBuscarSiguiente_Click(sender As System.Object, e As System.EventArgs)
        Me.ProveedoresBindingSource.MoveNext()
    End Sub

    Private Sub ButtonBuscar_Click(sender As System.Object, e As System.EventArgs)
        BuscarProveedor()
    End Sub

    Private Sub ButtonGuardar_Click(sender As System.Object, e As System.EventArgs)

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' Codigos Postales 

        Dim codigoPostal As Integer
        ' Validar que el campo del codigo postal no este en blanco, sino asignarle automaticamente el valor 1 para que no nos rechace la base de datos

        If String.IsNullOrWhiteSpace(CodigoPostalTextBox.Text) Then
            codigoPostal = 1  ' Valor por defecto
        Else
            codigoPostal = Convert.ToInt32(CodigoPostalTextBox.Text)
        End If

        ' Verificamos si el codigo postal ya existe:
        Dim existe As Boolean = False

        ' Iteramos en el dataset para validar
        Try
            ' Insertamos
            Me.CodigosPostalesTableAdapter.Insert(
                codigoPostal,
                LocalidadTextBox.Text,
                ProvinciaTextBox.Text
            )
            Me.CodigosPostalesTableAdapter.Update(Me.BazarDataSet.CodigosPostales)
        Catch ex As Exception
            ' continuar
        End Try

        Me.ProveedoresTableAdapter.Insert(NombreTextBox.Text, DireccionTextBox.Text, TelefonoTextBox.Text, EmailTextBox.Text, codigoPostal)
        ' Actualizar dataset de proveedores

        ' Actualizar TODOS los dataset
        Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)
        ' Recargar datos
        Me.CodigosPostalesTableAdapter.Fill(Me.BazarDataSet.CodigosPostales)
        Me.ProveedoresTableAdapter.Fill(Me.BazarDataSet.Proveedores)

    End Sub

    Private Sub ButtonActualizar_Click(sender As System.Object, e As System.EventArgs)

        Dim idEncontrado As Integer = BuscarProveedor()

        Try

            Me.Validate()

            Me.ProveedoresBindingSource.EndEdit()

            Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

            MessageBox.Show("Proveedor actualizado correctamente!")

        Catch ex As Exception
            MsgBox("Error al actualizar proveedor: " & ex.Message)
        End Try

    End Sub


    Private Sub ButtonEliminar_Click(sender As System.Object, e As System.EventArgs)

        Dim idEncontrado As Integer = BuscarProveedor()

        Try

            Dim confirmarEliminacion As Boolean = MsgBox("Esta seguro que desea eliminar el registro con ID = " & idEncontrado, MsgBoxStyle.YesNo)

            If confirmarEliminacion = True Then
                ProveedoresBindingSource.RemoveCurrent()
                TableAdapterManager.UpdateAll(Me.BazarDataSet)
                ProveedoresTableAdapter.Fill(Me.BazarDataSet.Proveedores)
            End If

            MsgBox("Registro eliminado satisfactoriamente")
        Catch ex As Exception
            MsgBox("Error al eliminar registro: " & ex.Message)
        End Try

    End Sub

    Private Sub ButtonEliminarTodos_Click(sender As System.Object, e As System.EventArgs)

        Dim confirmarBorrado As Boolean

        confirmarBorrado = MsgBox("Esta seguro que desea eliminar todos los registros? Esta accion es PERMANENTE y NO se puede DESHACER", MsgBoxStyle.YesNoCancel)

        If (confirmarBorrado) Then
            Try
                Me.ProveedoresTableAdapter.BorrarTodosProveedores()
                Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)
                Me.ProveedoresTableAdapter.Fill(Me.BazarDataSet.Proveedores)
            Catch ex As Exception
                MsgBox("Error al intentar borrar todos los registros: " & ex.Message)
            End Try
            MsgBox("Registros eliminados satisfactoriamente")
        End If
    End Sub

    Private Sub ID_ProveedorTextBox_TextChanged(sender As System.Object, e As System.EventArgs)
        TextBoxConsulta.Text = ID_ProveedorTextBox.Text
    End Sub

    Private Sub MenuItemVolver_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemVolver.Click
        Me.Hide()
        Bazar.Show()
    End Sub

    Private Sub MenuItemClientes_Click(sender As System.Object, e As System.EventArgs)
        Clientes.Show()
        Me.Hide()
    End Sub

    Private Sub MenuItemVentas_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemVentas.Click
        Me.Hide()
        Ventas.Show()
    End Sub

    Private Sub MenuItemCompras_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemCompras.Click
        Me.Hide()
        Compras.Show()
    End Sub

    Private Sub MenuItemProductos_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemProductos.Click
        Me.Hide()
        Productos.Show()
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


End Class