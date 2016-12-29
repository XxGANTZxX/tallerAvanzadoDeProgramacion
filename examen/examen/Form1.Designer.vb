<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSecionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirAplicacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SucursalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarPedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.PedidosClienteToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.CerrarSecionToolStripMenuItem, Me.SalirAplicacionToolStripMenuItem})
        Me.AgregarToolStripMenuItem.Image = CType(resources.GetObject("AgregarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AgregarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Image = CType(resources.GetObject("ProductosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'CerrarSecionToolStripMenuItem
        '
        Me.CerrarSecionToolStripMenuItem.Image = CType(resources.GetObject("CerrarSecionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CerrarSecionToolStripMenuItem.Name = "CerrarSecionToolStripMenuItem"
        Me.CerrarSecionToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.CerrarSecionToolStripMenuItem.Text = "Cerrar Secion"
        '
        'SalirAplicacionToolStripMenuItem
        '
        Me.SalirAplicacionToolStripMenuItem.Image = CType(resources.GetObject("SalirAplicacionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirAplicacionToolStripMenuItem.Name = "SalirAplicacionToolStripMenuItem"
        Me.SalirAplicacionToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SalirAplicacionToolStripMenuItem.Text = "Salir Aplicacion"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneralToolStripMenuItem, Me.SucursalToolStripMenuItem})
        Me.InventarioToolStripMenuItem.Image = CType(resources.GetObject("InventarioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'GeneralToolStripMenuItem
        '
        Me.GeneralToolStripMenuItem.Image = CType(resources.GetObject("GeneralToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GeneralToolStripMenuItem.Name = "GeneralToolStripMenuItem"
        Me.GeneralToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.GeneralToolStripMenuItem.Text = "General"
        '
        'SucursalToolStripMenuItem
        '
        Me.SucursalToolStripMenuItem.Image = CType(resources.GetObject("SucursalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SucursalToolStripMenuItem.Name = "SucursalToolStripMenuItem"
        Me.SucursalToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.SucursalToolStripMenuItem.Text = "Sucursal"
        '
        'PedidosClienteToolStripMenuItem
        '
        Me.PedidosClienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarPedidoToolStripMenuItem, Me.ContactarClienteToolStripMenuItem})
        Me.PedidosClienteToolStripMenuItem.Image = CType(resources.GetObject("PedidosClienteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PedidosClienteToolStripMenuItem.Name = "PedidosClienteToolStripMenuItem"
        Me.PedidosClienteToolStripMenuItem.Size = New System.Drawing.Size(117, 20)
        Me.PedidosClienteToolStripMenuItem.Text = "Pedidos Cliente"
        '
        'GenerarPedidoToolStripMenuItem
        '
        Me.GenerarPedidoToolStripMenuItem.Image = CType(resources.GetObject("GenerarPedidoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GenerarPedidoToolStripMenuItem.Name = "GenerarPedidoToolStripMenuItem"
        Me.GenerarPedidoToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.GenerarPedidoToolStripMenuItem.Text = "Generar pedido"
        '
        'ContactarClienteToolStripMenuItem
        '
        Me.ContactarClienteToolStripMenuItem.Image = CType(resources.GetObject("ContactarClienteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ContactarClienteToolStripMenuItem.Name = "ContactarClienteToolStripMenuItem"
        Me.ContactarClienteToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ContactarClienteToolStripMenuItem.Text = "Contactar Cliente"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContactoToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Image = CType(resources.GetObject("AyudaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'ContactoToolStripMenuItem
        '
        Me.ContactoToolStripMenuItem.Image = CType(resources.GetObject("ContactoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ContactoToolStripMenuItem.Name = "ContactoToolStripMenuItem"
        Me.ContactoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ContactoToolStripMenuItem.Text = "Soporte"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Image = CType(resources.GetObject("AcercaDeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(632, 380)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuPrincipal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSecionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirAplicacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeneralToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SucursalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PedidosClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarPedidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
