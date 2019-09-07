'
' Created by SharpDevelop.
' User: E19
' Date: 06/09/2019
' Time: 07:31 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.txtEditor = New System.Windows.Forms.TextBox()
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.nuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnNuevo = New System.Windows.Forms.ToolStripMenuItem()
		Me.ventanaNuevaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.abrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.guardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.guardarComoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.configurarPáginaToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
		Me.imprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.imprimirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnSalir = New System.Windows.Forms.ToolStripMenuItem()
		Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.toolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.toolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.toolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.menuStrip1.SuspendLayout
		Me.statusStrip1.SuspendLayout
		Me.SuspendLayout
		'
		'txtEditor
		'
		Me.txtEditor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.txtEditor.Location = New System.Drawing.Point(12, 27)
		Me.txtEditor.Multiline = true
		Me.txtEditor.Name = "txtEditor"
		Me.txtEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtEditor.Size = New System.Drawing.Size(978, 450)
		Me.txtEditor.TabIndex = 0
		AddHandler Me.txtEditor.TextChanged, AddressOf Me.TxtEditorTextChanged
		'
		'menuStrip1
		'
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nuevoToolStripMenuItem})
		Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.Size = New System.Drawing.Size(1002, 24)
		Me.menuStrip1.TabIndex = 1
		Me.menuStrip1.Text = "menuStrip1"
		'
		'nuevoToolStripMenuItem
		'
		Me.nuevoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnNuevo, Me.ventanaNuevaToolStripMenuItem, Me.abrirToolStripMenuItem, Me.guardarToolStripMenuItem, Me.guardarComoToolStripMenuItem, Me.configurarPáginaToolStripMenuItem, Me.imprimirToolStripMenuItem, Me.imprimirToolStripMenuItem1, Me.toolStripMenuItem1, Me.mnSalir})
		Me.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem"
		Me.nuevoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
		Me.nuevoToolStripMenuItem.Text = "Archivo"
		'
		'mnNuevo
		'
		Me.mnNuevo.Name = "mnNuevo"
		Me.mnNuevo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N),System.Windows.Forms.Keys)
		Me.mnNuevo.Size = New System.Drawing.Size(231, 22)
		Me.mnNuevo.Text = "Nuevo"
		AddHandler Me.mnNuevo.Click, AddressOf Me.MnNuevoClick
		'
		'ventanaNuevaToolStripMenuItem
		'
		Me.ventanaNuevaToolStripMenuItem.Name = "ventanaNuevaToolStripMenuItem"
		Me.ventanaNuevaToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift)  _
						Or System.Windows.Forms.Keys.N),System.Windows.Forms.Keys)
		Me.ventanaNuevaToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
		Me.ventanaNuevaToolStripMenuItem.Text = "Ventana nueva"
		'
		'abrirToolStripMenuItem
		'
		Me.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem"
		Me.abrirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A),System.Windows.Forms.Keys)
		Me.abrirToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
		Me.abrirToolStripMenuItem.Text = "Abrir..."
		'
		'guardarToolStripMenuItem
		'
		Me.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem"
		Me.guardarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G),System.Windows.Forms.Keys)
		Me.guardarToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
		Me.guardarToolStripMenuItem.Text = "Guardar"
		'
		'guardarComoToolStripMenuItem
		'
		Me.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem"
		Me.guardarComoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift)  _
						Or System.Windows.Forms.Keys.S),System.Windows.Forms.Keys)
		Me.guardarComoToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
		Me.guardarComoToolStripMenuItem.Text = "Guardar como..."
		'
		'configurarPáginaToolStripMenuItem
		'
		Me.configurarPáginaToolStripMenuItem.Name = "configurarPáginaToolStripMenuItem"
		Me.configurarPáginaToolStripMenuItem.Size = New System.Drawing.Size(228, 6)
		'
		'imprimirToolStripMenuItem
		'
		Me.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem"
		Me.imprimirToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
		Me.imprimirToolStripMenuItem.Text = "Configurar página..."
		'
		'imprimirToolStripMenuItem1
		'
		Me.imprimirToolStripMenuItem1.Name = "imprimirToolStripMenuItem1"
		Me.imprimirToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P),System.Windows.Forms.Keys)
		Me.imprimirToolStripMenuItem1.Size = New System.Drawing.Size(231, 22)
		Me.imprimirToolStripMenuItem1.Text = "Imprimir"
		'
		'toolStripMenuItem1
		'
		Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
		Me.toolStripMenuItem1.Size = New System.Drawing.Size(228, 6)
		'
		'mnSalir
		'
		Me.mnSalir.Name = "mnSalir"
		Me.mnSalir.Size = New System.Drawing.Size(231, 22)
		Me.mnSalir.Text = "Salir"
		AddHandler Me.mnSalir.Click, AddressOf Me.MnSalirClick
		'
		'statusStrip1
		'
		Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1, Me.toolStripStatusLabel2, Me.toolStripStatusLabel3, Me.toolStripStatusLabel4})
		Me.statusStrip1.Location = New System.Drawing.Point(0, 480)
		Me.statusStrip1.Name = "statusStrip1"
		Me.statusStrip1.Size = New System.Drawing.Size(1002, 24)
		Me.statusStrip1.TabIndex = 2
		'
		'toolStripStatusLabel1
		'
		Me.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
		Me.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
		Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
		Me.toolStripStatusLabel1.Size = New System.Drawing.Size(75, 19)
		Me.toolStripStatusLabel1.Text = "Line 1, Col 1"
		'
		'toolStripStatusLabel2
		'
		Me.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
		Me.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
		Me.toolStripStatusLabel2.Name = "toolStripStatusLabel2"
		Me.toolStripStatusLabel2.Size = New System.Drawing.Size(39, 19)
		Me.toolStripStatusLabel2.Text = "100%"
		'
		'toolStripStatusLabel3
		'
		Me.toolStripStatusLabel3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
		Me.toolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
		Me.toolStripStatusLabel3.Name = "toolStripStatusLabel3"
		Me.toolStripStatusLabel3.Size = New System.Drawing.Size(95, 19)
		Me.toolStripStatusLabel3.Text = "Windows(CRLF)"
		'
		'toolStripStatusLabel4
		'
		Me.toolStripStatusLabel4.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
		Me.toolStripStatusLabel4.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
		Me.toolStripStatusLabel4.Name = "toolStripStatusLabel4"
		Me.toolStripStatusLabel4.Size = New System.Drawing.Size(42, 19)
		Me.toolStripStatusLabel4.Text = "UTF-8"
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1002, 504)
		Me.Controls.Add(Me.statusStrip1)
		Me.Controls.Add(Me.txtEditor)
		Me.Controls.Add(Me.menuStrip1)
		Me.MainMenuStrip = Me.menuStrip1
		Me.MinimumSize = New System.Drawing.Size(400, 300)
		Me.Name = "MainForm"
		Me.Text = "Sin nombre.txt"
		AddHandler FormClosing, AddressOf Me.MainFormFormClosing
		Me.menuStrip1.ResumeLayout(false)
		Me.menuStrip1.PerformLayout
		Me.statusStrip1.ResumeLayout(false)
		Me.statusStrip1.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private toolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
	Private toolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
	Private toolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
	Private toolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
	Private statusStrip1 As System.Windows.Forms.StatusStrip
	Private mnSalir As System.Windows.Forms.ToolStripMenuItem
	Private toolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
	Private imprimirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private imprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private configurarPáginaToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
	Private guardarComoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private guardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private abrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private ventanaNuevaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private mnNuevo As System.Windows.Forms.ToolStripMenuItem
	Private nuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private menuStrip1 As System.Windows.Forms.MenuStrip
	Private txtEditor As System.Windows.Forms.TextBox
End Class
