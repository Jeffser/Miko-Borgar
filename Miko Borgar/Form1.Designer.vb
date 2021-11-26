<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tpCarrito = New System.Windows.Forms.TabPage()
        Me.gbCOpciones = New System.Windows.Forms.GroupBox()
        Me.btnCVaciar = New System.Windows.Forms.Button()
        Me.btnCEliminar = New System.Windows.Forms.Button()
        Me.gbCProductos = New System.Windows.Forms.GroupBox()
        Me.rtbCDescripcion = New System.Windows.Forms.RichTextBox()
        Me.lbCProductos = New System.Windows.Forms.ListBox()
        Me.tpVenta = New System.Windows.Forms.TabPage()
        Me.gbVAgregar = New System.Windows.Forms.GroupBox()
        Me.btnVAgregar = New System.Windows.Forms.Button()
        Me.nudVCantidad = New System.Windows.Forms.NumericUpDown()
        Me.lblVCantidad = New System.Windows.Forms.Label()
        Me.gbVProductos = New System.Windows.Forms.GroupBox()
        Me.rtbVDescripcion = New System.Windows.Forms.RichTextBox()
        Me.lbVProductos = New System.Windows.Forms.ListBox()
        Me.cbVCategoria = New System.Windows.Forms.ComboBox()
        Me.tbVBuscar = New System.Windows.Forms.TextBox()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.tpFacturar = New System.Windows.Forms.TabPage()
        Me.gbFCliente = New System.Windows.Forms.GroupBox()
        Me.rtbFDireccion = New System.Windows.Forms.RichTextBox()
        Me.lblFDireccion = New System.Windows.Forms.Label()
        Me.lblFTelefono = New System.Windows.Forms.Label()
        Me.tbFTelefono = New System.Windows.Forms.TextBox()
        Me.tbFNombre = New System.Windows.Forms.TextBox()
        Me.lblFNombre = New System.Windows.Forms.Label()
        Me.gbFCalculo = New System.Windows.Forms.GroupBox()
        Me.lblFPorcentaje = New System.Windows.Forms.Label()
        Me.lblFCDescuento = New System.Windows.Forms.Label()
        Me.tbFCDescuento = New System.Windows.Forms.TextBox()
        Me.btnFPagar = New System.Windows.Forms.Button()
        Me.nudFDescuento = New System.Windows.Forms.NumericUpDown()
        Me.tbFTotal = New System.Windows.Forms.TextBox()
        Me.tbFImpuesto = New System.Windows.Forms.TextBox()
        Me.tbFSubtotal = New System.Windows.Forms.TextBox()
        Me.lblFTotal = New System.Windows.Forms.Label()
        Me.lblImpuesto = New System.Windows.Forms.Label()
        Me.lblFDescuento = New System.Windows.Forms.Label()
        Me.lblFSubtotal = New System.Windows.Forms.Label()
        Me.tpInventario = New System.Windows.Forms.TabPage()
        Me.gbINNuevo = New System.Windows.Forms.GroupBox()
        Me.btnINGuardar = New System.Windows.Forms.Button()
        Me.rtbINDescripcion = New System.Windows.Forms.RichTextBox()
        Me.lblINDescripcion = New System.Windows.Forms.Label()
        Me.nudINPrecio = New System.Windows.Forms.NumericUpDown()
        Me.lblINPrecio = New System.Windows.Forms.Label()
        Me.cbINCategoria = New System.Windows.Forms.ComboBox()
        Me.lblINCategoria = New System.Windows.Forms.Label()
        Me.tbINNombre = New System.Windows.Forms.TextBox()
        Me.lblINNombre = New System.Windows.Forms.Label()
        Me.gbIEEditar = New System.Windows.Forms.GroupBox()
        Me.btnIEGuardar = New System.Windows.Forms.Button()
        Me.btnIEEliminar = New System.Windows.Forms.Button()
        Me.rtbIEDescripcion = New System.Windows.Forms.RichTextBox()
        Me.lblIEDescripcion = New System.Windows.Forms.Label()
        Me.nudIEPrecio = New System.Windows.Forms.NumericUpDown()
        Me.lblIEPrecio = New System.Windows.Forms.Label()
        Me.cbIECategoria = New System.Windows.Forms.ComboBox()
        Me.lblIECategoria = New System.Windows.Forms.Label()
        Me.tbIENombre = New System.Windows.Forms.TextBox()
        Me.lblIENombre = New System.Windows.Forms.Label()
        Me.lblIEProducto = New System.Windows.Forms.Label()
        Me.cbIEProducto = New System.Windows.Forms.ComboBox()
        Me.tpCategorias = New System.Windows.Forms.TabPage()
        Me.gbCAEditar = New System.Windows.Forms.GroupBox()
        Me.btnCAEBorrar = New System.Windows.Forms.Button()
        Me.cbCAECategoria = New System.Windows.Forms.ComboBox()
        Me.btnCAEGuardar = New System.Windows.Forms.Button()
        Me.tbCAENombre = New System.Windows.Forms.TextBox()
        Me.gbCANueva = New System.Windows.Forms.GroupBox()
        Me.btnCANGuardar = New System.Windows.Forms.Button()
        Me.tbCANNombre = New System.Windows.Forms.TextBox()
        Me.tbFacturas = New System.Windows.Forms.TabPage()
        Me.gbFCFacturas = New System.Windows.Forms.GroupBox()
        Me.rtbFCFacturas = New System.Windows.Forms.RichTextBox()
        Me.tbFCBuscar = New System.Windows.Forms.TextBox()
        Me.tpCreditos = New System.Windows.Forms.TabPage()
        Me.lblCCreditos = New System.Windows.Forms.Label()
        Me.Banner2 = New System.Windows.Forms.Panel()
        Me.Banner = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.tpCarrito.SuspendLayout()
        Me.gbCOpciones.SuspendLayout()
        Me.gbCProductos.SuspendLayout()
        Me.tpVenta.SuspendLayout()
        Me.gbVAgregar.SuspendLayout()
        CType(Me.nudVCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbVProductos.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.tpFacturar.SuspendLayout()
        Me.gbFCliente.SuspendLayout()
        Me.gbFCalculo.SuspendLayout()
        CType(Me.nudFDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpInventario.SuspendLayout()
        Me.gbINNuevo.SuspendLayout()
        CType(Me.nudINPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbIEEditar.SuspendLayout()
        CType(Me.nudIEPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpCategorias.SuspendLayout()
        Me.gbCAEditar.SuspendLayout()
        Me.gbCANueva.SuspendLayout()
        Me.tbFacturas.SuspendLayout()
        Me.gbFCFacturas.SuspendLayout()
        Me.tpCreditos.SuspendLayout()
        Me.SuspendLayout()
        '
        'tpCarrito
        '
        Me.tpCarrito.Controls.Add(Me.gbCOpciones)
        Me.tpCarrito.Controls.Add(Me.gbCProductos)
        Me.tpCarrito.Location = New System.Drawing.Point(4, 22)
        Me.tpCarrito.Name = "tpCarrito"
        Me.tpCarrito.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCarrito.Size = New System.Drawing.Size(393, 406)
        Me.tpCarrito.TabIndex = 1
        Me.tpCarrito.Text = "Carrito"
        Me.tpCarrito.UseVisualStyleBackColor = True
        '
        'gbCOpciones
        '
        Me.gbCOpciones.Controls.Add(Me.btnCVaciar)
        Me.gbCOpciones.Controls.Add(Me.btnCEliminar)
        Me.gbCOpciones.Location = New System.Drawing.Point(6, 353)
        Me.gbCOpciones.Name = "gbCOpciones"
        Me.gbCOpciones.Size = New System.Drawing.Size(381, 47)
        Me.gbCOpciones.TabIndex = 2
        Me.gbCOpciones.TabStop = False
        Me.gbCOpciones.Text = " Opciones"
        '
        'btnCVaciar
        '
        Me.btnCVaciar.Location = New System.Drawing.Point(234, 18)
        Me.btnCVaciar.Name = "btnCVaciar"
        Me.btnCVaciar.Size = New System.Drawing.Size(141, 23)
        Me.btnCVaciar.TabIndex = 3
        Me.btnCVaciar.Text = " Vaciar Carrito"
        Me.btnCVaciar.UseVisualStyleBackColor = True
        '
        'btnCEliminar
        '
        Me.btnCEliminar.Location = New System.Drawing.Point(6, 18)
        Me.btnCEliminar.Name = "btnCEliminar"
        Me.btnCEliminar.Size = New System.Drawing.Size(222, 23)
        Me.btnCEliminar.TabIndex = 2
        Me.btnCEliminar.Text = " Eliminar Seleccionado"
        Me.btnCEliminar.UseVisualStyleBackColor = True
        '
        'gbCProductos
        '
        Me.gbCProductos.Controls.Add(Me.rtbCDescripcion)
        Me.gbCProductos.Controls.Add(Me.lbCProductos)
        Me.gbCProductos.Location = New System.Drawing.Point(6, 6)
        Me.gbCProductos.Name = "gbCProductos"
        Me.gbCProductos.Size = New System.Drawing.Size(381, 341)
        Me.gbCProductos.TabIndex = 0
        Me.gbCProductos.TabStop = False
        Me.gbCProductos.Text = " Productos"
        '
        'rtbCDescripcion
        '
        Me.rtbCDescripcion.Location = New System.Drawing.Point(6, 224)
        Me.rtbCDescripcion.Name = "rtbCDescripcion"
        Me.rtbCDescripcion.Size = New System.Drawing.Size(369, 111)
        Me.rtbCDescripcion.TabIndex = 1
        Me.rtbCDescripcion.Text = ""
        '
        'lbCProductos
        '
        Me.lbCProductos.FormattingEnabled = True
        Me.lbCProductos.Location = New System.Drawing.Point(6, 19)
        Me.lbCProductos.Name = "lbCProductos"
        Me.lbCProductos.Size = New System.Drawing.Size(369, 199)
        Me.lbCProductos.TabIndex = 0
        '
        'tpVenta
        '
        Me.tpVenta.Controls.Add(Me.gbVAgregar)
        Me.tpVenta.Controls.Add(Me.gbVProductos)
        Me.tpVenta.Location = New System.Drawing.Point(4, 22)
        Me.tpVenta.Name = "tpVenta"
        Me.tpVenta.Padding = New System.Windows.Forms.Padding(3)
        Me.tpVenta.Size = New System.Drawing.Size(393, 406)
        Me.tpVenta.TabIndex = 0
        Me.tpVenta.Text = "Venta"
        Me.tpVenta.UseVisualStyleBackColor = True
        '
        'gbVAgregar
        '
        Me.gbVAgregar.Controls.Add(Me.btnVAgregar)
        Me.gbVAgregar.Controls.Add(Me.nudVCantidad)
        Me.gbVAgregar.Controls.Add(Me.lblVCantidad)
        Me.gbVAgregar.Location = New System.Drawing.Point(6, 353)
        Me.gbVAgregar.Name = "gbVAgregar"
        Me.gbVAgregar.Size = New System.Drawing.Size(381, 47)
        Me.gbVAgregar.TabIndex = 1
        Me.gbVAgregar.TabStop = False
        Me.gbVAgregar.Text = " Agregar al Carrito"
        '
        'btnVAgregar
        '
        Me.btnVAgregar.Location = New System.Drawing.Point(129, 16)
        Me.btnVAgregar.Name = "btnVAgregar"
        Me.btnVAgregar.Size = New System.Drawing.Size(246, 23)
        Me.btnVAgregar.TabIndex = 2
        Me.btnVAgregar.Text = " Agregar"
        Me.btnVAgregar.UseVisualStyleBackColor = True
        '
        'nudVCantidad
        '
        Me.nudVCantidad.Location = New System.Drawing.Point(67, 19)
        Me.nudVCantidad.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.nudVCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudVCantidad.Name = "nudVCantidad"
        Me.nudVCantidad.Size = New System.Drawing.Size(56, 20)
        Me.nudVCantidad.TabIndex = 1
        Me.nudVCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblVCantidad
        '
        Me.lblVCantidad.AutoSize = True
        Me.lblVCantidad.Location = New System.Drawing.Point(6, 21)
        Me.lblVCantidad.Name = "lblVCantidad"
        Me.lblVCantidad.Size = New System.Drawing.Size(55, 13)
        Me.lblVCantidad.TabIndex = 0
        Me.lblVCantidad.Text = " Cantidad:"
        '
        'gbVProductos
        '
        Me.gbVProductos.Controls.Add(Me.rtbVDescripcion)
        Me.gbVProductos.Controls.Add(Me.lbVProductos)
        Me.gbVProductos.Controls.Add(Me.cbVCategoria)
        Me.gbVProductos.Controls.Add(Me.tbVBuscar)
        Me.gbVProductos.Location = New System.Drawing.Point(6, 6)
        Me.gbVProductos.Name = "gbVProductos"
        Me.gbVProductos.Size = New System.Drawing.Size(381, 341)
        Me.gbVProductos.TabIndex = 0
        Me.gbVProductos.TabStop = False
        Me.gbVProductos.Text = " Productos"
        '
        'rtbVDescripcion
        '
        Me.rtbVDescripcion.Location = New System.Drawing.Point(6, 264)
        Me.rtbVDescripcion.Name = "rtbVDescripcion"
        Me.rtbVDescripcion.Size = New System.Drawing.Size(369, 71)
        Me.rtbVDescripcion.TabIndex = 3
        Me.rtbVDescripcion.Text = ""
        '
        'lbVProductos
        '
        Me.lbVProductos.FormattingEnabled = True
        Me.lbVProductos.Location = New System.Drawing.Point(6, 72)
        Me.lbVProductos.Name = "lbVProductos"
        Me.lbVProductos.Size = New System.Drawing.Size(369, 186)
        Me.lbVProductos.TabIndex = 2
        '
        'cbVCategoria
        '
        Me.cbVCategoria.FormattingEnabled = True
        Me.cbVCategoria.Location = New System.Drawing.Point(6, 45)
        Me.cbVCategoria.Name = "cbVCategoria"
        Me.cbVCategoria.Size = New System.Drawing.Size(369, 21)
        Me.cbVCategoria.TabIndex = 1
        '
        'tbVBuscar
        '
        Me.tbVBuscar.Location = New System.Drawing.Point(6, 19)
        Me.tbVBuscar.Name = "tbVBuscar"
        Me.tbVBuscar.Size = New System.Drawing.Size(369, 20)
        Me.tbVBuscar.TabIndex = 0
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.tpVenta)
        Me.TabControl.Controls.Add(Me.tpCarrito)
        Me.TabControl.Controls.Add(Me.tpFacturar)
        Me.TabControl.Controls.Add(Me.tpInventario)
        Me.TabControl.Controls.Add(Me.tpCategorias)
        Me.TabControl.Controls.Add(Me.tbFacturas)
        Me.TabControl.Controls.Add(Me.tpCreditos)
        Me.TabControl.Location = New System.Drawing.Point(12, 121)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(401, 432)
        Me.TabControl.TabIndex = 0
        '
        'tpFacturar
        '
        Me.tpFacturar.Controls.Add(Me.gbFCliente)
        Me.tpFacturar.Controls.Add(Me.gbFCalculo)
        Me.tpFacturar.Location = New System.Drawing.Point(4, 22)
        Me.tpFacturar.Name = "tpFacturar"
        Me.tpFacturar.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFacturar.Size = New System.Drawing.Size(393, 406)
        Me.tpFacturar.TabIndex = 2
        Me.tpFacturar.Text = "Facturar"
        Me.tpFacturar.UseVisualStyleBackColor = True
        '
        'gbFCliente
        '
        Me.gbFCliente.Controls.Add(Me.rtbFDireccion)
        Me.gbFCliente.Controls.Add(Me.lblFDireccion)
        Me.gbFCliente.Controls.Add(Me.lblFTelefono)
        Me.gbFCliente.Controls.Add(Me.tbFTelefono)
        Me.gbFCliente.Controls.Add(Me.tbFNombre)
        Me.gbFCliente.Controls.Add(Me.lblFNombre)
        Me.gbFCliente.Location = New System.Drawing.Point(6, 6)
        Me.gbFCliente.Name = "gbFCliente"
        Me.gbFCliente.Size = New System.Drawing.Size(381, 207)
        Me.gbFCliente.TabIndex = 1
        Me.gbFCliente.TabStop = False
        Me.gbFCliente.Text = " Cliente"
        '
        'rtbFDireccion
        '
        Me.rtbFDireccion.Location = New System.Drawing.Point(6, 71)
        Me.rtbFDireccion.Name = "rtbFDireccion"
        Me.rtbFDireccion.Size = New System.Drawing.Size(369, 130)
        Me.rtbFDireccion.TabIndex = 5
        Me.rtbFDireccion.Text = ""
        '
        'lblFDireccion
        '
        Me.lblFDireccion.AutoSize = True
        Me.lblFDireccion.Location = New System.Drawing.Point(6, 55)
        Me.lblFDireccion.Name = "lblFDireccion"
        Me.lblFDireccion.Size = New System.Drawing.Size(55, 13)
        Me.lblFDireccion.TabIndex = 4
        Me.lblFDireccion.Text = " Dirección"
        '
        'lblFTelefono
        '
        Me.lblFTelefono.AutoSize = True
        Me.lblFTelefono.Location = New System.Drawing.Point(240, 16)
        Me.lblFTelefono.Name = "lblFTelefono"
        Me.lblFTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblFTelefono.TabIndex = 3
        Me.lblFTelefono.Text = " Teléfono"
        '
        'tbFTelefono
        '
        Me.tbFTelefono.Location = New System.Drawing.Point(243, 32)
        Me.tbFTelefono.Name = "tbFTelefono"
        Me.tbFTelefono.Size = New System.Drawing.Size(132, 20)
        Me.tbFTelefono.TabIndex = 2
        '
        'tbFNombre
        '
        Me.tbFNombre.Location = New System.Drawing.Point(9, 32)
        Me.tbFNombre.Name = "tbFNombre"
        Me.tbFNombre.Size = New System.Drawing.Size(228, 20)
        Me.tbFNombre.TabIndex = 1
        '
        'lblFNombre
        '
        Me.lblFNombre.AutoSize = True
        Me.lblFNombre.Location = New System.Drawing.Point(6, 16)
        Me.lblFNombre.Name = "lblFNombre"
        Me.lblFNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblFNombre.TabIndex = 0
        Me.lblFNombre.Text = " Nombre"
        '
        'gbFCalculo
        '
        Me.gbFCalculo.Controls.Add(Me.lblFPorcentaje)
        Me.gbFCalculo.Controls.Add(Me.lblFCDescuento)
        Me.gbFCalculo.Controls.Add(Me.tbFCDescuento)
        Me.gbFCalculo.Controls.Add(Me.btnFPagar)
        Me.gbFCalculo.Controls.Add(Me.nudFDescuento)
        Me.gbFCalculo.Controls.Add(Me.tbFTotal)
        Me.gbFCalculo.Controls.Add(Me.tbFImpuesto)
        Me.gbFCalculo.Controls.Add(Me.tbFSubtotal)
        Me.gbFCalculo.Controls.Add(Me.lblFTotal)
        Me.gbFCalculo.Controls.Add(Me.lblImpuesto)
        Me.gbFCalculo.Controls.Add(Me.lblFDescuento)
        Me.gbFCalculo.Controls.Add(Me.lblFSubtotal)
        Me.gbFCalculo.Location = New System.Drawing.Point(6, 219)
        Me.gbFCalculo.Name = "gbFCalculo"
        Me.gbFCalculo.Size = New System.Drawing.Size(381, 181)
        Me.gbFCalculo.TabIndex = 0
        Me.gbFCalculo.TabStop = False
        Me.gbFCalculo.Text = " Calculo"
        '
        'lblFPorcentaje
        '
        Me.lblFPorcentaje.AutoSize = True
        Me.lblFPorcentaje.Location = New System.Drawing.Point(351, 100)
        Me.lblFPorcentaje.Name = "lblFPorcentaje"
        Me.lblFPorcentaje.Size = New System.Drawing.Size(24, 13)
        Me.lblFPorcentaje.TabIndex = 12
        Me.lblFPorcentaje.Text = " 5%"
        '
        'lblFCDescuento
        '
        Me.lblFCDescuento.AutoSize = True
        Me.lblFCDescuento.Location = New System.Drawing.Point(6, 74)
        Me.lblFCDescuento.Name = "lblFCDescuento"
        Me.lblFCDescuento.Size = New System.Drawing.Size(52, 13)
        Me.lblFCDescuento.TabIndex = 11
        Me.lblFCDescuento.Text = " A rebajar"
        '
        'tbFCDescuento
        '
        Me.tbFCDescuento.Enabled = False
        Me.tbFCDescuento.Location = New System.Drawing.Point(74, 71)
        Me.tbFCDescuento.Name = "tbFCDescuento"
        Me.tbFCDescuento.Size = New System.Drawing.Size(301, 20)
        Me.tbFCDescuento.TabIndex = 10
        '
        'btnFPagar
        '
        Me.btnFPagar.Location = New System.Drawing.Point(6, 149)
        Me.btnFPagar.Name = "btnFPagar"
        Me.btnFPagar.Size = New System.Drawing.Size(369, 26)
        Me.btnFPagar.TabIndex = 9
        Me.btnFPagar.Text = "Pagar"
        Me.btnFPagar.UseVisualStyleBackColor = True
        '
        'nudFDescuento
        '
        Me.nudFDescuento.Location = New System.Drawing.Point(74, 45)
        Me.nudFDescuento.Name = "nudFDescuento"
        Me.nudFDescuento.Size = New System.Drawing.Size(301, 20)
        Me.nudFDescuento.TabIndex = 7
        '
        'tbFTotal
        '
        Me.tbFTotal.Enabled = False
        Me.tbFTotal.Location = New System.Drawing.Point(74, 123)
        Me.tbFTotal.Name = "tbFTotal"
        Me.tbFTotal.Size = New System.Drawing.Size(301, 20)
        Me.tbFTotal.TabIndex = 6
        '
        'tbFImpuesto
        '
        Me.tbFImpuesto.Enabled = False
        Me.tbFImpuesto.Location = New System.Drawing.Point(74, 97)
        Me.tbFImpuesto.Name = "tbFImpuesto"
        Me.tbFImpuesto.Size = New System.Drawing.Size(271, 20)
        Me.tbFImpuesto.TabIndex = 5
        '
        'tbFSubtotal
        '
        Me.tbFSubtotal.Enabled = False
        Me.tbFSubtotal.Location = New System.Drawing.Point(74, 19)
        Me.tbFSubtotal.Name = "tbFSubtotal"
        Me.tbFSubtotal.Size = New System.Drawing.Size(301, 20)
        Me.tbFSubtotal.TabIndex = 4
        '
        'lblFTotal
        '
        Me.lblFTotal.AutoSize = True
        Me.lblFTotal.Location = New System.Drawing.Point(6, 126)
        Me.lblFTotal.Name = "lblFTotal"
        Me.lblFTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblFTotal.TabIndex = 3
        Me.lblFTotal.Text = " Total"
        '
        'lblImpuesto
        '
        Me.lblImpuesto.AutoSize = True
        Me.lblImpuesto.Location = New System.Drawing.Point(6, 100)
        Me.lblImpuesto.Name = "lblImpuesto"
        Me.lblImpuesto.Size = New System.Drawing.Size(53, 13)
        Me.lblImpuesto.TabIndex = 2
        Me.lblImpuesto.Text = " Impuesto"
        '
        'lblFDescuento
        '
        Me.lblFDescuento.AutoSize = True
        Me.lblFDescuento.Location = New System.Drawing.Point(6, 47)
        Me.lblFDescuento.Name = "lblFDescuento"
        Me.lblFDescuento.Size = New System.Drawing.Size(62, 13)
        Me.lblFDescuento.TabIndex = 1
        Me.lblFDescuento.Text = " Descuento"
        '
        'lblFSubtotal
        '
        Me.lblFSubtotal.AutoSize = True
        Me.lblFSubtotal.Location = New System.Drawing.Point(6, 22)
        Me.lblFSubtotal.Name = "lblFSubtotal"
        Me.lblFSubtotal.Size = New System.Drawing.Size(49, 13)
        Me.lblFSubtotal.TabIndex = 0
        Me.lblFSubtotal.Text = " Subtotal"
        '
        'tpInventario
        '
        Me.tpInventario.Controls.Add(Me.gbINNuevo)
        Me.tpInventario.Controls.Add(Me.gbIEEditar)
        Me.tpInventario.Location = New System.Drawing.Point(4, 22)
        Me.tpInventario.Name = "tpInventario"
        Me.tpInventario.Padding = New System.Windows.Forms.Padding(3)
        Me.tpInventario.Size = New System.Drawing.Size(393, 406)
        Me.tpInventario.TabIndex = 3
        Me.tpInventario.Text = "Inventario"
        Me.tpInventario.UseVisualStyleBackColor = True
        '
        'gbINNuevo
        '
        Me.gbINNuevo.Controls.Add(Me.btnINGuardar)
        Me.gbINNuevo.Controls.Add(Me.rtbINDescripcion)
        Me.gbINNuevo.Controls.Add(Me.lblINDescripcion)
        Me.gbINNuevo.Controls.Add(Me.nudINPrecio)
        Me.gbINNuevo.Controls.Add(Me.lblINPrecio)
        Me.gbINNuevo.Controls.Add(Me.cbINCategoria)
        Me.gbINNuevo.Controls.Add(Me.lblINCategoria)
        Me.gbINNuevo.Controls.Add(Me.tbINNombre)
        Me.gbINNuevo.Controls.Add(Me.lblINNombre)
        Me.gbINNuevo.Location = New System.Drawing.Point(6, 222)
        Me.gbINNuevo.Name = "gbINNuevo"
        Me.gbINNuevo.Size = New System.Drawing.Size(381, 178)
        Me.gbINNuevo.TabIndex = 1
        Me.gbINNuevo.TabStop = False
        Me.gbINNuevo.Text = " Nuevo"
        '
        'btnINGuardar
        '
        Me.btnINGuardar.Location = New System.Drawing.Point(6, 149)
        Me.btnINGuardar.Name = "btnINGuardar"
        Me.btnINGuardar.Size = New System.Drawing.Size(369, 23)
        Me.btnINGuardar.TabIndex = 13
        Me.btnINGuardar.Text = " Guardar"
        Me.btnINGuardar.UseVisualStyleBackColor = True
        '
        'rtbINDescripcion
        '
        Me.rtbINDescripcion.Location = New System.Drawing.Point(6, 77)
        Me.rtbINDescripcion.Name = "rtbINDescripcion"
        Me.rtbINDescripcion.Size = New System.Drawing.Size(369, 66)
        Me.rtbINDescripcion.TabIndex = 7
        Me.rtbINDescripcion.Text = ""
        '
        'lblINDescripcion
        '
        Me.lblINDescripcion.AutoSize = True
        Me.lblINDescripcion.Location = New System.Drawing.Point(6, 61)
        Me.lblINDescripcion.Name = "lblINDescripcion"
        Me.lblINDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lblINDescripcion.TabIndex = 6
        Me.lblINDescripcion.Text = " Descripción"
        '
        'nudINPrecio
        '
        Me.nudINPrecio.Location = New System.Drawing.Point(268, 38)
        Me.nudINPrecio.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.nudINPrecio.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudINPrecio.Name = "nudINPrecio"
        Me.nudINPrecio.Size = New System.Drawing.Size(107, 20)
        Me.nudINPrecio.TabIndex = 5
        Me.nudINPrecio.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblINPrecio
        '
        Me.lblINPrecio.AutoSize = True
        Me.lblINPrecio.Location = New System.Drawing.Point(265, 22)
        Me.lblINPrecio.Name = "lblINPrecio"
        Me.lblINPrecio.Size = New System.Drawing.Size(40, 13)
        Me.lblINPrecio.TabIndex = 4
        Me.lblINPrecio.Text = " Precio"
        '
        'cbINCategoria
        '
        Me.cbINCategoria.FormattingEnabled = True
        Me.cbINCategoria.Location = New System.Drawing.Point(138, 38)
        Me.cbINCategoria.Name = "cbINCategoria"
        Me.cbINCategoria.Size = New System.Drawing.Size(121, 21)
        Me.cbINCategoria.TabIndex = 3
        '
        'lblINCategoria
        '
        Me.lblINCategoria.AutoSize = True
        Me.lblINCategoria.Location = New System.Drawing.Point(135, 22)
        Me.lblINCategoria.Name = "lblINCategoria"
        Me.lblINCategoria.Size = New System.Drawing.Size(55, 13)
        Me.lblINCategoria.TabIndex = 2
        Me.lblINCategoria.Text = " Categoria"
        '
        'tbINNombre
        '
        Me.tbINNombre.Location = New System.Drawing.Point(9, 38)
        Me.tbINNombre.Name = "tbINNombre"
        Me.tbINNombre.Size = New System.Drawing.Size(120, 20)
        Me.tbINNombre.TabIndex = 1
        '
        'lblINNombre
        '
        Me.lblINNombre.AutoSize = True
        Me.lblINNombre.Location = New System.Drawing.Point(6, 22)
        Me.lblINNombre.Name = "lblINNombre"
        Me.lblINNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblINNombre.TabIndex = 0
        Me.lblINNombre.Text = " Nombre"
        '
        'gbIEEditar
        '
        Me.gbIEEditar.Controls.Add(Me.btnIEGuardar)
        Me.gbIEEditar.Controls.Add(Me.btnIEEliminar)
        Me.gbIEEditar.Controls.Add(Me.rtbIEDescripcion)
        Me.gbIEEditar.Controls.Add(Me.lblIEDescripcion)
        Me.gbIEEditar.Controls.Add(Me.nudIEPrecio)
        Me.gbIEEditar.Controls.Add(Me.lblIEPrecio)
        Me.gbIEEditar.Controls.Add(Me.cbIECategoria)
        Me.gbIEEditar.Controls.Add(Me.lblIECategoria)
        Me.gbIEEditar.Controls.Add(Me.tbIENombre)
        Me.gbIEEditar.Controls.Add(Me.lblIENombre)
        Me.gbIEEditar.Controls.Add(Me.lblIEProducto)
        Me.gbIEEditar.Controls.Add(Me.cbIEProducto)
        Me.gbIEEditar.Location = New System.Drawing.Point(6, 6)
        Me.gbIEEditar.Name = "gbIEEditar"
        Me.gbIEEditar.Size = New System.Drawing.Size(381, 210)
        Me.gbIEEditar.TabIndex = 0
        Me.gbIEEditar.TabStop = False
        Me.gbIEEditar.Text = " Editar"
        '
        'btnIEGuardar
        '
        Me.btnIEGuardar.Location = New System.Drawing.Point(87, 179)
        Me.btnIEGuardar.Name = "btnIEGuardar"
        Me.btnIEGuardar.Size = New System.Drawing.Size(288, 23)
        Me.btnIEGuardar.TabIndex = 12
        Me.btnIEGuardar.Text = " Guardar"
        Me.btnIEGuardar.UseVisualStyleBackColor = True
        '
        'btnIEEliminar
        '
        Me.btnIEEliminar.Location = New System.Drawing.Point(6, 179)
        Me.btnIEEliminar.Name = "btnIEEliminar"
        Me.btnIEEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnIEEliminar.TabIndex = 11
        Me.btnIEEliminar.Text = "Eliminar"
        Me.btnIEEliminar.UseVisualStyleBackColor = True
        '
        'rtbIEDescripcion
        '
        Me.rtbIEDescripcion.Location = New System.Drawing.Point(6, 104)
        Me.rtbIEDescripcion.Name = "rtbIEDescripcion"
        Me.rtbIEDescripcion.Size = New System.Drawing.Size(369, 69)
        Me.rtbIEDescripcion.TabIndex = 10
        Me.rtbIEDescripcion.Text = ""
        '
        'lblIEDescripcion
        '
        Me.lblIEDescripcion.AutoSize = True
        Me.lblIEDescripcion.Location = New System.Drawing.Point(6, 88)
        Me.lblIEDescripcion.Name = "lblIEDescripcion"
        Me.lblIEDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lblIEDescripcion.TabIndex = 9
        Me.lblIEDescripcion.Text = " Descripción"
        '
        'nudIEPrecio
        '
        Me.nudIEPrecio.Location = New System.Drawing.Point(268, 64)
        Me.nudIEPrecio.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.nudIEPrecio.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudIEPrecio.Name = "nudIEPrecio"
        Me.nudIEPrecio.Size = New System.Drawing.Size(107, 20)
        Me.nudIEPrecio.TabIndex = 8
        Me.nudIEPrecio.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblIEPrecio
        '
        Me.lblIEPrecio.AutoSize = True
        Me.lblIEPrecio.Location = New System.Drawing.Point(265, 49)
        Me.lblIEPrecio.Name = "lblIEPrecio"
        Me.lblIEPrecio.Size = New System.Drawing.Size(40, 13)
        Me.lblIEPrecio.TabIndex = 7
        Me.lblIEPrecio.Text = " Precio"
        '
        'cbIECategoria
        '
        Me.cbIECategoria.FormattingEnabled = True
        Me.cbIECategoria.Location = New System.Drawing.Point(138, 64)
        Me.cbIECategoria.Name = "cbIECategoria"
        Me.cbIECategoria.Size = New System.Drawing.Size(121, 21)
        Me.cbIECategoria.TabIndex = 6
        '
        'lblIECategoria
        '
        Me.lblIECategoria.AutoSize = True
        Me.lblIECategoria.Location = New System.Drawing.Point(135, 49)
        Me.lblIECategoria.Name = "lblIECategoria"
        Me.lblIECategoria.Size = New System.Drawing.Size(55, 13)
        Me.lblIECategoria.TabIndex = 5
        Me.lblIECategoria.Text = " Categoria"
        '
        'tbIENombre
        '
        Me.tbIENombre.Location = New System.Drawing.Point(9, 65)
        Me.tbIENombre.Name = "tbIENombre"
        Me.tbIENombre.Size = New System.Drawing.Size(120, 20)
        Me.tbIENombre.TabIndex = 4
        '
        'lblIENombre
        '
        Me.lblIENombre.AutoSize = True
        Me.lblIENombre.Location = New System.Drawing.Point(6, 49)
        Me.lblIENombre.Name = "lblIENombre"
        Me.lblIENombre.Size = New System.Drawing.Size(47, 13)
        Me.lblIENombre.TabIndex = 3
        Me.lblIENombre.Text = " Nombre"
        '
        'lblIEProducto
        '
        Me.lblIEProducto.AutoSize = True
        Me.lblIEProducto.Location = New System.Drawing.Point(6, 22)
        Me.lblIEProducto.Name = "lblIEProducto"
        Me.lblIEProducto.Size = New System.Drawing.Size(56, 13)
        Me.lblIEProducto.TabIndex = 2
        Me.lblIEProducto.Text = " Producto:"
        '
        'cbIEProducto
        '
        Me.cbIEProducto.FormattingEnabled = True
        Me.cbIEProducto.Location = New System.Drawing.Point(68, 19)
        Me.cbIEProducto.Name = "cbIEProducto"
        Me.cbIEProducto.Size = New System.Drawing.Size(307, 21)
        Me.cbIEProducto.TabIndex = 1
        '
        'tpCategorias
        '
        Me.tpCategorias.Controls.Add(Me.gbCAEditar)
        Me.tpCategorias.Controls.Add(Me.gbCANueva)
        Me.tpCategorias.Location = New System.Drawing.Point(4, 22)
        Me.tpCategorias.Name = "tpCategorias"
        Me.tpCategorias.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCategorias.Size = New System.Drawing.Size(393, 406)
        Me.tpCategorias.TabIndex = 5
        Me.tpCategorias.Text = "Categorias"
        Me.tpCategorias.UseVisualStyleBackColor = True
        '
        'gbCAEditar
        '
        Me.gbCAEditar.Controls.Add(Me.btnCAEBorrar)
        Me.gbCAEditar.Controls.Add(Me.cbCAECategoria)
        Me.gbCAEditar.Controls.Add(Me.btnCAEGuardar)
        Me.gbCAEditar.Controls.Add(Me.tbCAENombre)
        Me.gbCAEditar.Location = New System.Drawing.Point(6, 91)
        Me.gbCAEditar.Name = "gbCAEditar"
        Me.gbCAEditar.Size = New System.Drawing.Size(381, 79)
        Me.gbCAEditar.TabIndex = 2
        Me.gbCAEditar.TabStop = False
        Me.gbCAEditar.Text = "Editar"
        '
        'btnCAEBorrar
        '
        Me.btnCAEBorrar.Location = New System.Drawing.Point(6, 45)
        Me.btnCAEBorrar.Name = "btnCAEBorrar"
        Me.btnCAEBorrar.Size = New System.Drawing.Size(121, 28)
        Me.btnCAEBorrar.TabIndex = 4
        Me.btnCAEBorrar.Text = " Borrar"
        Me.btnCAEBorrar.UseVisualStyleBackColor = True
        '
        'cbCAECategoria
        '
        Me.cbCAECategoria.FormattingEnabled = True
        Me.cbCAECategoria.Location = New System.Drawing.Point(6, 19)
        Me.cbCAECategoria.Name = "cbCAECategoria"
        Me.cbCAECategoria.Size = New System.Drawing.Size(121, 21)
        Me.cbCAECategoria.TabIndex = 3
        '
        'btnCAEGuardar
        '
        Me.btnCAEGuardar.Location = New System.Drawing.Point(133, 45)
        Me.btnCAEGuardar.Name = "btnCAEGuardar"
        Me.btnCAEGuardar.Size = New System.Drawing.Size(242, 28)
        Me.btnCAEGuardar.TabIndex = 1
        Me.btnCAEGuardar.Text = " Guardar"
        Me.btnCAEGuardar.UseVisualStyleBackColor = True
        '
        'tbCAENombre
        '
        Me.tbCAENombre.Location = New System.Drawing.Point(133, 19)
        Me.tbCAENombre.Name = "tbCAENombre"
        Me.tbCAENombre.Size = New System.Drawing.Size(242, 20)
        Me.tbCAENombre.TabIndex = 0
        '
        'gbCANueva
        '
        Me.gbCANueva.Controls.Add(Me.btnCANGuardar)
        Me.gbCANueva.Controls.Add(Me.tbCANNombre)
        Me.gbCANueva.Location = New System.Drawing.Point(6, 6)
        Me.gbCANueva.Name = "gbCANueva"
        Me.gbCANueva.Size = New System.Drawing.Size(381, 79)
        Me.gbCANueva.TabIndex = 0
        Me.gbCANueva.TabStop = False
        Me.gbCANueva.Text = " Nueva"
        '
        'btnCANGuardar
        '
        Me.btnCANGuardar.Location = New System.Drawing.Point(6, 45)
        Me.btnCANGuardar.Name = "btnCANGuardar"
        Me.btnCANGuardar.Size = New System.Drawing.Size(369, 28)
        Me.btnCANGuardar.TabIndex = 1
        Me.btnCANGuardar.Text = " Guardar"
        Me.btnCANGuardar.UseVisualStyleBackColor = True
        '
        'tbCANNombre
        '
        Me.tbCANNombre.Location = New System.Drawing.Point(6, 19)
        Me.tbCANNombre.Name = "tbCANNombre"
        Me.tbCANNombre.Size = New System.Drawing.Size(369, 20)
        Me.tbCANNombre.TabIndex = 0
        '
        'tbFacturas
        '
        Me.tbFacturas.Controls.Add(Me.gbFCFacturas)
        Me.tbFacturas.Location = New System.Drawing.Point(4, 22)
        Me.tbFacturas.Name = "tbFacturas"
        Me.tbFacturas.Padding = New System.Windows.Forms.Padding(3)
        Me.tbFacturas.Size = New System.Drawing.Size(393, 406)
        Me.tbFacturas.TabIndex = 6
        Me.tbFacturas.Text = "Facturas"
        Me.tbFacturas.UseVisualStyleBackColor = True
        '
        'gbFCFacturas
        '
        Me.gbFCFacturas.Controls.Add(Me.rtbFCFacturas)
        Me.gbFCFacturas.Controls.Add(Me.tbFCBuscar)
        Me.gbFCFacturas.Location = New System.Drawing.Point(6, 6)
        Me.gbFCFacturas.Name = "gbFCFacturas"
        Me.gbFCFacturas.Size = New System.Drawing.Size(381, 394)
        Me.gbFCFacturas.TabIndex = 0
        Me.gbFCFacturas.TabStop = False
        Me.gbFCFacturas.Text = "Facturas"
        '
        'rtbFCFacturas
        '
        Me.rtbFCFacturas.Location = New System.Drawing.Point(6, 45)
        Me.rtbFCFacturas.Name = "rtbFCFacturas"
        Me.rtbFCFacturas.Size = New System.Drawing.Size(369, 343)
        Me.rtbFCFacturas.TabIndex = 1
        Me.rtbFCFacturas.Text = ""
        '
        'tbFCBuscar
        '
        Me.tbFCBuscar.Location = New System.Drawing.Point(6, 19)
        Me.tbFCBuscar.Name = "tbFCBuscar"
        Me.tbFCBuscar.Size = New System.Drawing.Size(369, 20)
        Me.tbFCBuscar.TabIndex = 0
        '
        'tpCreditos
        '
        Me.tpCreditos.Controls.Add(Me.lblCCreditos)
        Me.tpCreditos.Controls.Add(Me.Banner2)
        Me.tpCreditos.Location = New System.Drawing.Point(4, 22)
        Me.tpCreditos.Name = "tpCreditos"
        Me.tpCreditos.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCreditos.Size = New System.Drawing.Size(393, 406)
        Me.tpCreditos.TabIndex = 4
        Me.tpCreditos.Text = "Creditos"
        Me.tpCreditos.UseVisualStyleBackColor = True
        '
        'lblCCreditos
        '
        Me.lblCCreditos.AutoSize = True
        Me.lblCCreditos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCCreditos.Location = New System.Drawing.Point(22, 374)
        Me.lblCCreditos.Name = "lblCCreditos"
        Me.lblCCreditos.Size = New System.Drawing.Size(348, 29)
        Me.lblCCreditos.TabIndex = 1
        Me.lblCCreditos.Text = " © Jeffry Samuel Eduarte Rojas"
        '
        'Banner2
        '
        Me.Banner2.BackgroundImage = Global.Miko_Borgar.My.Resources.Resources.Miko_Borgar_Banner_2
        Me.Banner2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Banner2.Location = New System.Drawing.Point(6, 6)
        Me.Banner2.Name = "Banner2"
        Me.Banner2.Size = New System.Drawing.Size(381, 365)
        Me.Banner2.TabIndex = 0
        '
        'Banner
        '
        Me.Banner.BackgroundImage = Global.Miko_Borgar.My.Resources.Resources.Miko_Borgar_Banner
        Me.Banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Banner.Location = New System.Drawing.Point(228, 12)
        Me.Banner.Name = "Banner"
        Me.Banner.Size = New System.Drawing.Size(185, 103)
        Me.Banner.TabIndex = 1
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTitulo.Location = New System.Drawing.Point(12, 5)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(175, 110)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Miko" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Borgar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Miko_Borgar.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(425, 565)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.Banner)
        Me.Controls.Add(Me.TabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Miko Borgar"
        Me.tpCarrito.ResumeLayout(False)
        Me.gbCOpciones.ResumeLayout(False)
        Me.gbCProductos.ResumeLayout(False)
        Me.tpVenta.ResumeLayout(False)
        Me.gbVAgregar.ResumeLayout(False)
        Me.gbVAgregar.PerformLayout()
        CType(Me.nudVCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbVProductos.ResumeLayout(False)
        Me.gbVProductos.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.tpFacturar.ResumeLayout(False)
        Me.gbFCliente.ResumeLayout(False)
        Me.gbFCliente.PerformLayout()
        Me.gbFCalculo.ResumeLayout(False)
        Me.gbFCalculo.PerformLayout()
        CType(Me.nudFDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpInventario.ResumeLayout(False)
        Me.gbINNuevo.ResumeLayout(False)
        Me.gbINNuevo.PerformLayout()
        CType(Me.nudINPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbIEEditar.ResumeLayout(False)
        Me.gbIEEditar.PerformLayout()
        CType(Me.nudIEPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpCategorias.ResumeLayout(False)
        Me.gbCAEditar.ResumeLayout(False)
        Me.gbCAEditar.PerformLayout()
        Me.gbCANueva.ResumeLayout(False)
        Me.gbCANueva.PerformLayout()
        Me.tbFacturas.ResumeLayout(False)
        Me.gbFCFacturas.ResumeLayout(False)
        Me.gbFCFacturas.PerformLayout()
        Me.tpCreditos.ResumeLayout(False)
        Me.tpCreditos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tpCarrito As TabPage
    Friend WithEvents gbCProductos As GroupBox
    Friend WithEvents tpVenta As TabPage
    Friend WithEvents gbVAgregar As GroupBox
    Friend WithEvents btnVAgregar As Button
    Friend WithEvents nudVCantidad As NumericUpDown
    Friend WithEvents lblVCantidad As Label
    Friend WithEvents gbVProductos As GroupBox
    Friend WithEvents rtbVDescripcion As RichTextBox
    Friend WithEvents lbVProductos As ListBox
    Friend WithEvents cbVCategoria As ComboBox
    Friend WithEvents tbVBuscar As TextBox
    Friend WithEvents TabControl As TabControl
    Friend WithEvents gbCOpciones As GroupBox
    Friend WithEvents btnCVaciar As Button
    Friend WithEvents btnCEliminar As Button
    Friend WithEvents rtbCDescripcion As RichTextBox
    Friend WithEvents lbCProductos As ListBox
    Friend WithEvents tpFacturar As TabPage
    Friend WithEvents gbFCliente As GroupBox
    Friend WithEvents lblFDireccion As Label
    Friend WithEvents lblFTelefono As Label
    Friend WithEvents tbFTelefono As TextBox
    Friend WithEvents tbFNombre As TextBox
    Friend WithEvents lblFNombre As Label
    Friend WithEvents gbFCalculo As GroupBox
    Friend WithEvents btnFPagar As Button
    Friend WithEvents nudFDescuento As NumericUpDown
    Friend WithEvents tbFTotal As TextBox
    Friend WithEvents tbFImpuesto As TextBox
    Friend WithEvents tbFSubtotal As TextBox
    Friend WithEvents lblFTotal As Label
    Friend WithEvents lblImpuesto As Label
    Friend WithEvents lblFDescuento As Label
    Friend WithEvents lblFSubtotal As Label
    Friend WithEvents rtbFDireccion As RichTextBox
    Friend WithEvents tpInventario As TabPage
    Friend WithEvents gbINNuevo As GroupBox
    Friend WithEvents btnINGuardar As Button
    Friend WithEvents rtbINDescripcion As RichTextBox
    Friend WithEvents lblINDescripcion As Label
    Friend WithEvents nudINPrecio As NumericUpDown
    Friend WithEvents lblINPrecio As Label
    Friend WithEvents cbINCategoria As ComboBox
    Friend WithEvents lblINCategoria As Label
    Friend WithEvents tbINNombre As TextBox
    Friend WithEvents lblINNombre As Label
    Friend WithEvents gbIEEditar As GroupBox
    Friend WithEvents btnIEGuardar As Button
    Friend WithEvents btnIEEliminar As Button
    Friend WithEvents rtbIEDescripcion As RichTextBox
    Friend WithEvents lblIEDescripcion As Label
    Friend WithEvents nudIEPrecio As NumericUpDown
    Friend WithEvents lblIEPrecio As Label
    Friend WithEvents cbIECategoria As ComboBox
    Friend WithEvents lblIECategoria As Label
    Friend WithEvents tbIENombre As TextBox
    Friend WithEvents lblIENombre As Label
    Friend WithEvents lblIEProducto As Label
    Friend WithEvents cbIEProducto As ComboBox
    Friend WithEvents tpCreditos As TabPage
    Friend WithEvents Banner As Panel
    Friend WithEvents Banner2 As Panel
    Friend WithEvents lblCCreditos As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblFCDescuento As Label
    Friend WithEvents tbFCDescuento As TextBox
    Friend WithEvents lblFPorcentaje As Label
    Friend WithEvents tpCategorias As TabPage
    Friend WithEvents gbCANueva As GroupBox
    Friend WithEvents btnCANGuardar As Button
    Friend WithEvents tbCANNombre As TextBox
    Friend WithEvents gbCAEditar As GroupBox
    Friend WithEvents btnCAEBorrar As Button
    Friend WithEvents cbCAECategoria As ComboBox
    Friend WithEvents btnCAEGuardar As Button
    Friend WithEvents tbCAENombre As TextBox
    Friend WithEvents tbFacturas As TabPage
    Friend WithEvents gbFCFacturas As GroupBox
    Friend WithEvents tbFCBuscar As TextBox
    Friend WithEvents rtbFCFacturas As RichTextBox
End Class
