Imports System.Data.SqlClient
Public Class Form1
    Dim server = "Phoenix", database = "Miko Borgar", mensajeInf = True, mensajeErr = True
    Function connect(com)
        Dim conn = New SqlConnection("server=" & server & " ; database=" & database & " ; integrated security = True")
        conn.Open()
        Dim reg As SqlDataReader = New SqlCommand(com, conn).ExecuteReader()
        Return {conn, reg}
    End Function

    Sub msg(texto, tipo)
        If mensajeInf And tipo = "inf" Then
            MessageBox.Show(texto, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf mensajeErr And tipo = "err" Then
            MessageBox.Show(texto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub Upd(indx)
        If indx = 0 Then
            Dim req() As Object = connect("SELECT Nombre FROM Categorias")
            cbVCategoria.Items.Clear()
            nudVCantidad.Value = 1
            While req(1).Read()
                cbVCategoria.Items.Add(req(1)("Nombre"))
            End While
            req(0).Close()
            cbVCategoria.SelectedIndex = 0
        ElseIf indx = 1 Then
            Dim req() As Object = connect("SELECT Producto FROM Carrito")
            lbCProductos.Items.Clear()
            While req(1).Read()
                lbCProductos.Items.Add(req(1)("Producto"))
            End While
            req(0).Close()
        ElseIf indx = 2 Then
            Dim req() As Object = connect("SELECT Producto, Cantidad FROM Carrito")
            Dim productos(0)() As Object
            While req(1).Read()
                productos(productos.Length - 1) = {req(1)("Producto"), req(1)("Cantidad")}
                Array.Resize(productos, productos.Length + 1)
            End While
            Array.Resize(productos, productos.Length - 1)
            req(0).Close()
            Dim subtotal As Double = 0
            For i = 0 To productos.GetUpperBound(0)
                req = connect("SELECT Precio FROM Productos WHERE Nombre = '" & productos(i)(0) & "'")
                If req(1).Read() Then
                    subtotal += req(1)("Precio") * productos(i)(1)
                End If
            Next
            tbFSubtotal.Text = subtotal.ToString.Replace(",", ".")
            tbFCDescuento.Text = tbFSubtotal.Text * (nudFDescuento.Value / 100)
            tbFImpuesto.Text = (tbFSubtotal.Text - tbFCDescuento.Text) * 0.05
            tbFTotal.Text = (tbFSubtotal.Text - tbFCDescuento.Text + tbFImpuesto.Text).ToString.Replace(",", ".")
        ElseIf indx = 3 Then
            cbIECategoria.Items.Clear()
            cbIEProducto.Items.Clear()
            cbINCategoria.Items.Clear()
            Dim req() As Object = connect("SELECT Nombre FROM Categorias")
            While req(1).Read()
                cbIECategoria.Items.Add(req(1)("Nombre"))
                cbINCategoria.Items.Add(req(1)("Nombre"))
            End While
            req(0).Close()
            req = connect("SELECT Nombre FROM Productos")
            While req(1).Read()
                cbIEProducto.Items.Add(req(1)("Nombre"))
            End While
            req(0).Close()
            cbVCategoria.SelectedItem = 0
            cbIEProducto.SelectedIndex = 0
            cbINCategoria.SelectedIndex = 0
            cbIECategoria.SelectedIndex = 0
        ElseIf indx = 4 Then
            cbCAECategoria.Items.Clear()
            Dim req() As Object = connect("SELECT Nombre FROM Categorias")
            While req(1).Read()
                cbCAECategoria.Items.Add(req(1)("Nombre"))
            End While
            req(0).Close
            cbCAECategoria.SelectedItem = 0
        ElseIf indx = 5 Then
            tbFCBuscar.Text = ""
            rtbFCFacturas.Text = ""
            Dim req() As Object = connect("SELECT * FROM Facturas")
            While req(1).Read()
                rtbFCFacturas.Text = rtbFCFacturas.Text & vbCrLf &
                                       "Factura:    " & req(1)("ID") & vbCrLf &
                                       "Fecha:      " & req(1)("Fecha") & vbCrLf &
                                       "Nombre:     " & req(1)("Nombre") & vbCrLf &
                                       "Telefono:   " & req(1)("Telefono") & vbCrLf &
                                       "Dirección:  " & req(1)("Direccion") & vbCrLf &
                                       "Productos:  " & vbCrLf & req(1)("Productos") & vbCrLf &
                                       "Total:      " & req(1)("Total") & vbCrLf &
                                       "--------------------------------"
            End While
        End If
    End Sub

    Private Sub btnINGuardar_Click(sender As Object, e As EventArgs) Handles btnINGuardar.Click
        If tbINNombre.Text <> "" And rtbINDescripcion.Text <> "" Then
            Dim req() As Object = connect("SELECT Nombre FROM Productos WHERE Nombre = '" & tbINNombre.Text & "'")
            If req(1).Read() Then
                req(0).Close()
                msg("Producto Repetido", "err")
            ElseIf cbINCategoria.Text = "TODO" Then
                msg("'TODO' es una Categoria Reservada Para el Sistema", "err")
            Else
                req(0).Close()
                req = connect("INSERT INTO Productos VALUES ('" & tbINNombre.Text & "', '" & cbINCategoria.SelectedItem & "', '" & rtbINDescripcion.Text & "', " & nudINPrecio.Value & ")")
                msg("Producto Agregado Exitosamente", "inf")
            End If
            req(0).Close()
            Else
            msg("Todos los espacios tienen que estar rellenados", "err")
        End If
    End Sub

    Private Sub cbIEProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIEProducto.SelectedIndexChanged
        Dim req() As Object = connect("SELECT * FROM Productos WHERE Nombre LIKE '" & cbIEProducto.SelectedItem & "'")
        If req(1).Read() Then
            tbIENombre.Text = req(1)("Nombre")
            rtbIEDescripcion.Text = req(1)("Descripcion")
            nudIEPrecio.Value = req(1)("Precio")
            cbIECategoria.SelectedItem = req(1)("Categoria")
        End If
        req(0).Close()
    End Sub

    Private Sub cbVCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbVCategoria.SelectedIndexChanged
        Dim req() As Object
        If tbVBuscar.Text = "" Then
            If cbVCategoria.Text = "TODO" Then
                req = connect("SELECT Nombre FROM Productos")
            Else
                req = connect("SELECT Nombre FROM Productos WHERE Categoria LIKE '" & cbVCategoria.Text & "'")
            End If
        Else
            If cbVCategoria.Text = "TODO" Then
                req = connect("SELECT Nombre FROM Productos WHERE Nombre LIKE '" & tbVBuscar.Text & "'")
            Else
                req = connect("SELECT Nombre FROM Productos WHERE Nombre LIKE '" & tbVBuscar.Text & "' AND Categoria LIKE '" & cbVCategoria.Text & "'")
            End If
        End If
        lbVProductos.Items.Clear()
        While req(1).Read()
            lbVProductos.Items.Add(req(1)("Nombre"))
        End While
        req(0).Close()
        lbVProductos.SelectedIndex = 0
    End Sub

    Private Sub tbVBuscar_TextChanged(sender As Object, e As EventArgs) Handles tbVBuscar.TextChanged
        Dim req() As Object
        If tbVBuscar.Text = "" Then
            req = connect("SELECT Nombre FROM Productos")
        Else
            If cbVCategoria.SelectedItem = "TODO" Then
                req = connect("SELECT Nombre FROM Productos WHERE Nombre LIKE '" & tbVBuscar.Text & "'")
            Else
                req = connect("SELECT Nombre FROM Productos WHERE Nombre LIKE '" & tbVBuscar.Text & "' AND Categoria LIKE '" & cbVCategoria.Text & "'")
            End If
        End If
            lbVProductos.Items.Clear()
        While req(1).Read()
            lbVProductos.Items.Add(req(1)("Nombre"))
        End While
        req(0).Close()
    End Sub

    Private Sub lbVProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbVProductos.SelectedIndexChanged
        Dim req() As Object = connect("SELECT Descripcion, Precio FROM Productos WHERE Nombre LIKE '" & lbVProductos.SelectedItem & "'")
        If req(1).Read() Then
            rtbVDescripcion.Text = "(" & req(1)("Precio") & ")" & vbCrLf & req(1)("Descripcion")
        End If
        req(0).Close()
    End Sub

    Private Sub btnVAgregar_Click(sender As Object, e As EventArgs) Handles btnVAgregar.Click
        If lbVProductos.SelectedIndex > -1 Then
            Dim req() As Object
            req = connect("INSERT INTO Carrito VALUES ('" & lbVProductos.SelectedItem & "', " & nudVCantidad.Value & ")")
            req(0).Close()
            msg("Producto Agregado Exitosamente", "inf")
        Else
            msg("Seleccione un Producto", "err")
        End If
    End Sub

    Private Sub lbCProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbCProductos.SelectedIndexChanged
        Dim req() As Object = connect("SELECT Cantidad FROM Carrito WHERE ID = " & lbCProductos.SelectedIndex)
        Dim cant = 0
        If req(1).Read() Then
            cant = req(1)("Cantidad")
        End If
        req(0).Close()
        req = connect("SELECT Descripcion, Precio FROM Productos WHERE Nombre LIKE '" & lbCProductos.SelectedItem & "'")
        If req(1).Read() Then
            rtbCDescripcion.Text = "Precio: " & req(1)("Precio") & vbCrLf & "Cantidad: " & cant & vbCrLf & req(1)("Descripcion")
        End If
        req(0).Close()
    End Sub

    Private Sub btnCEliminar_Click(sender As Object, e As EventArgs) Handles btnCEliminar.Click
        If lbCProductos.SelectedIndex > -1 Then
            Dim req() As Object = connect("DELETE FROM Carrito WHERE ID = " & lbCProductos.SelectedIndex)
            req(0).Close()
            Upd(1)
            msg("Producto Eliminado del Carrito Exitosamente", "inf")
        End If
    End Sub

    Private Sub btnCVaciar_Click(sender As Object, e As EventArgs) Handles btnCVaciar.Click
        Dim req() As Object = connect("TRUNCATE TABLE Carrito")
        req(0).Close()
        Upd(1)
        rtbCDescripcion.Text = ""
        msg("Carrito Vaciado Exitosamente", "inf")
    End Sub

    Private Sub nudFDescuento_ValueChanged(sender As Object, e As EventArgs) Handles nudFDescuento.ValueChanged
        tbFCDescuento.Text = tbFSubtotal.Text * (nudFDescuento.Value / 100)
        tbFImpuesto.Text = (tbFSubtotal.Text - tbFCDescuento.Text) * 0.05
        tbFTotal.Text = (tbFSubtotal.Text - tbFCDescuento.Text + tbFImpuesto.Text).ToString.Replace(",", ".")
    End Sub

    Private Sub btnFPagar_Click(sender As Object, e As EventArgs) Handles btnFPagar.Click
        If tbFNombre.Text = "" Or tbFTelefono.Text = "" Or rtbFDireccion.Text = "" Then
            msg("Necesita Rellenar Todos los Campos", "err")
        Else
            Dim producto(0)() As String
            Dim req() As Object = connect("SELECT Producto, Cantidad FROM Carrito")
            While req(1).Read()
                producto(producto.Length - 1) = {req(1)("Producto"), req(1)("Cantidad"), 0}
                Array.Resize(producto, producto.Length + 1)
            End While
            Array.Resize(producto, producto.Length - 1)
            Dim secProductos As String = ""
            req(0).Close()
            For i = 0 To producto.GetUpperBound(0)
                req = connect("SELECT Precio FROM Productos WHERE Nombre = '" & producto(i)(0) & "'")
                If req(1).Read() Then
                    producto(i)(2) = req(1)("Precio")
                End If
                req(0).Close()
                secProductos = secProductos & producto(i)(0) & "(Precio: " & producto(i)(2) & ") (Cantidad: " & producto(i)(1) & ")" & vbCrLf
            Next
            req(0).Close()
            Dim fecha = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
            req = connect("INSERT INTO Facturas VALUES ('" & tbFNombre.Text & "', '" & tbFTelefono.Text & "', '" & rtbFDireccion.Text & "', '" & secProductos & "', '" & fecha & "', " & tbFTotal.Text & ")")
            req(0).Close()
            req = connect("TRUNCATE TABLE Carrito")
            req(0).Close()
            Upd(2)
            tbFNombre.Text = ""
            tbFTelefono.Text = ""
            rtbFDireccion.Text = ""
            msg("Facturado con Exito", "inf")
        End If
    End Sub

    Private Sub cbCAECategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCAECategoria.SelectedIndexChanged
        tbCAENombre.Text = cbCAECategoria.Text
    End Sub

    Private Sub btnCANGuardar_Click(sender As Object, e As EventArgs) Handles btnCANGuardar.Click
        Dim req() As Object = connect("SELECT Nombre FROM Categorias WHERE Nombre LIKE '" & tbCANNombre.Text & "'")
        If req(1).Read() Then
            msg("Nombre de Categoria Repetido", "err")
        Else
            req(0).Close()
            req = connect("INSERT INTO Categorias VALUES ('" & tbCANNombre.Text & "')")
            msg("Categoria Guardada Exitosamente", "inf")
            tbCANNombre.Text = ""
            tbCAENombre.Text = ""
            cbCAECategoria.SelectedIndex = 0
        End If
        req(0).Close()
    End Sub

    Private Sub btnCAEGuardar_Click(sender As Object, e As EventArgs) Handles btnCAEGuardar.Click
        Dim req() As Object = connect("SELECT Categoria FROM Productos WHERE Categoria = '" & tbCAENombre.Text & "'")
        If req(1).Read() Then
            msg("Categoria en Uso, No Puede Ser Modificada", "err")
        Else
            req(0).Close()
            req = connect("UPDATE Categorias SET Nombre = '" & tbCAENombre.Text & "' WHERE Nombre = '" & cbCAECategoria.Text & "'")
            msg("Categoria Modificada Exitosamente", "inf")
            tbCANNombre.Text = ""
            tbCAENombre.Text = ""
            cbCAECategoria.SelectedIndex = 0
        End If
        req(0).Close()
    End Sub

    Private Sub btnCAEBorrar_Click(sender As Object, e As EventArgs) Handles btnCAEBorrar.Click
        Dim req() As Object = connect("SELECT Categoria FROM Productos WHERE Categoria = '" & tbCAENombre.Text & "'")
        If tbCAENombre.Text = "TODO" Then
            msg("'TODO' es una Categoria Reservada Para el Sistema", "err")
        ElseIf req(1).Read() Then
            msg("Categoria en Uso, No Puede Ser Eliminada", "err")
        Else
            req(0).Close()
            req = connect("DELETE FROM Categorias WHERE Nombre = '" & cbCAECategoria.Text & "'")
            msg("Categoria Eliminada Exitosamente", "inf")
            tbCANNombre.Text = ""
            tbCAENombre.Text = ""
            cbCAECategoria.SelectedIndex = 0
        End If
        req(0).Close()
    End Sub

    Private Sub tbFCBuscar_TextChanged(sender As Object, e As EventArgs) Handles tbFCBuscar.TextChanged
        Dim req() As Object
        rtbFCFacturas.Text = ""
        If tbFCBuscar.Text <> "" Then
            req = connect("SELECT * FROM Facturas WHERE Fecha LIKE '" & tbFCBuscar.Text & "' OR Nombre LIKE '" & tbFCBuscar.Text & "' OR Telefono LIKE '" & tbFCBuscar.Text & "' OR Direccion LIKE '" & tbFCBuscar.Text & "' OR Productos LIKE '" & tbFCBuscar.Text & "'")
        Else
            req = connect("SELECT * FROM Facturas")
        End If
        While req(1).Read()
            rtbFCFacturas.Text = rtbFCFacturas.Text & vbCrLf &
                                   "Factura:    " & req(1)("ID") & vbCrLf &
                                   "Fecha:      " & req(1)("Fecha") & vbCrLf &
                                   "Nombre:     " & req(1)("Nombre") & vbCrLf &
                                   "Telefono:   " & req(1)("Telefono") & vbCrLf &
                                   "Dirección:  " & req(1)("Direccion") & vbCrLf &
                                   "Productos:  " & vbCrLf & req(1)("Productos") & vbCrLf &
                                   "Total:      " & req(1)("Total") & vbCrLf &
                                   "--------------------------------"
        End While
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim req() As Object = connect("SELECT * FROM Categorias")
        If req(1).Read() = False Then
            req(0).Close()
            req = connect("INSERT INTO Categorias VALUES ('TODO')")
            req(0).Close()
            req = connect("INSERT INTO Categorias VALUES ('Borgars')")
            req(0).Close()
            req = connect("INSERT INTO Categorias VALUES ('Fryes')")
            req(0).Close()
            req = connect("INSERT INTO Categorias VALUES ('Combs')")
            req(0).Close()
            msg("No Se Detectaron Categorias, Se Crearon los Predeterminados", "inf")
        End If
        req(0).Close()
        req = connect("SELECT * FROM Productos")
        If req(1).Read() = False Then
            req(0).Close()
            req = connect("INSERT INTO Productos VALUES ('Big Borgar', 'Borgars', 'It is a borgar but big', 1000)")
            req(0).Close()
            req = connect("INSERT INTO Productos VALUES ('Star Fryes', 'Fryes', 'Epic Fryes!', 500)")
            req(0).Close()
            req = connect("INSERT INTO Productos VALUES ('Ultimate Comb', 'Combs', 'Big Borgar + Star Fryes', 1200)")
            req(0).Close()
            msg("No Se Detectaron Productos, Se Crearon los Predeterminados", "inf")
        End If
        Upd(0)
    End Sub

    Private Sub btnIEEliminar_Click(sender As Object, e As EventArgs) Handles btnIEEliminar.Click
        Dim req() As Object = connect("DELETE FROM Productos WHERE Nombre = '" & cbIEProducto.Text & "'")
        req(0).Close()
        msg("Producto Eliminado Exitosamente", "inf")
    End Sub

    Private Sub btnIEGuardar_Click(sender As Object, e As EventArgs) Handles btnIEGuardar.Click
        If cbIECategoria.Text = "TODO" Then
            msg("'TODO' es una Categoria Reservada Para el Sistema", "err")
        Else
            Dim req() As Object = connect("UPDATE Productos SET Nombre = '" & tbIENombre.Text & "', Categoria = '" & cbIECategoria.Text & "', Descripcion = '" & rtbIEDescripcion.Text & "', Precio = " & nudIEPrecio.Value)
            req(0).Close()
            msg("Producto Modificado Exitosamente", "inf")
        End If
    End Sub

    Private Sub MyTabControl_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl.SelectedIndexChanged
        Dim tIndx = TabControl.SelectedIndex
        Upd(tIndx)
    End Sub
End Class