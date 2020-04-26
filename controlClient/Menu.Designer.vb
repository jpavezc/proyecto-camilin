<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.COnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CondominioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CondominioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarUnNuevoCondominioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarPorUnCondominioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MapaDeCondominiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComitéToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearUnComitéToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarUnComitéToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CasaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PuntoCardinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarUnPuntoCardinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarUnPuntoCardinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarUnPuntoCardinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarUnaUbicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarLaCalleDeUnPuntoCardinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarUnaUbicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CondominiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComitésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HabitantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COnToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(99, 26)
        '
        'COnToolStripMenuItem
        '
        Me.COnToolStripMenuItem.Name = "COnToolStripMenuItem"
        Me.COnToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.COnToolStripMenuItem.Text = "COn"
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CondominioToolStripMenuItem})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(142, 26)
        '
        'CondominioToolStripMenuItem
        '
        Me.CondominioToolStripMenuItem.Name = "CondominioToolStripMenuItem"
        Me.CondominioToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.CondominioToolStripMenuItem.Text = "Condominio"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccionesToolStripMenuItem, Me.MantenciónToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AccionesToolStripMenuItem
        '
        Me.AccionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CondominioToolStripMenuItem1})
        Me.AccionesToolStripMenuItem.Name = "AccionesToolStripMenuItem"
        Me.AccionesToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.AccionesToolStripMenuItem.Text = "Condominio"
        '
        'CondominioToolStripMenuItem1
        '
        Me.CondominioToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarUnNuevoCondominioToolStripMenuItem, Me.ConsultarPorUnCondominioToolStripMenuItem, Me.MapaDeCondominiosToolStripMenuItem})
        Me.CondominioToolStripMenuItem1.Name = "CondominioToolStripMenuItem1"
        Me.CondominioToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
        Me.CondominioToolStripMenuItem1.Text = "Acciones"
        '
        'IngresarUnNuevoCondominioToolStripMenuItem
        '
        Me.IngresarUnNuevoCondominioToolStripMenuItem.Name = "IngresarUnNuevoCondominioToolStripMenuItem"
        Me.IngresarUnNuevoCondominioToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.IngresarUnNuevoCondominioToolStripMenuItem.Text = "Ingresar un nuevo condominio"
        '
        'ConsultarPorUnCondominioToolStripMenuItem
        '
        Me.ConsultarPorUnCondominioToolStripMenuItem.Name = "ConsultarPorUnCondominioToolStripMenuItem"
        Me.ConsultarPorUnCondominioToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.ConsultarPorUnCondominioToolStripMenuItem.Text = "Consultar por un condominio"
        '
        'MapaDeCondominiosToolStripMenuItem
        '
        Me.MapaDeCondominiosToolStripMenuItem.Name = "MapaDeCondominiosToolStripMenuItem"
        Me.MapaDeCondominiosToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.MapaDeCondominiosToolStripMenuItem.Text = "Mapa de condominios"
        '
        'MantenciónToolStripMenuItem
        '
        Me.MantenciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComitéToolStripMenuItem, Me.CasaToolStripMenuItem, Me.CargoToolStripMenuItem, Me.PuntoCardinalToolStripMenuItem, Me.UbicaciónToolStripMenuItem})
        Me.MantenciónToolStripMenuItem.Name = "MantenciónToolStripMenuItem"
        Me.MantenciónToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.MantenciónToolStripMenuItem.Text = "Mantención"
        '
        'ComitéToolStripMenuItem
        '
        Me.ComitéToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearUnComitéToolStripMenuItem, Me.ModificarUnComitéToolStripMenuItem})
        Me.ComitéToolStripMenuItem.Name = "ComitéToolStripMenuItem"
        Me.ComitéToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ComitéToolStripMenuItem.Text = "Comité"
        '
        'CrearUnComitéToolStripMenuItem
        '
        Me.CrearUnComitéToolStripMenuItem.Name = "CrearUnComitéToolStripMenuItem"
        Me.CrearUnComitéToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.CrearUnComitéToolStripMenuItem.Text = "Crear un comité"
        '
        'ModificarUnComitéToolStripMenuItem
        '
        Me.ModificarUnComitéToolStripMenuItem.Name = "ModificarUnComitéToolStripMenuItem"
        Me.ModificarUnComitéToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ModificarUnComitéToolStripMenuItem.Text = "Modificar un comité"
        '
        'CasaToolStripMenuItem
        '
        Me.CasaToolStripMenuItem.Name = "CasaToolStripMenuItem"
        Me.CasaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CasaToolStripMenuItem.Text = "Casa"
        '
        'CargoToolStripMenuItem
        '
        Me.CargoToolStripMenuItem.Name = "CargoToolStripMenuItem"
        Me.CargoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CargoToolStripMenuItem.Text = "Cargo"
        '
        'PuntoCardinalToolStripMenuItem
        '
        Me.PuntoCardinalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarUnPuntoCardinalToolStripMenuItem, Me.ModificarUnPuntoCardinalToolStripMenuItem, Me.EliminarUnPuntoCardinalToolStripMenuItem})
        Me.PuntoCardinalToolStripMenuItem.Name = "PuntoCardinalToolStripMenuItem"
        Me.PuntoCardinalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PuntoCardinalToolStripMenuItem.Text = "Punto cardinal"
        '
        'AgregarUnPuntoCardinalToolStripMenuItem
        '
        Me.AgregarUnPuntoCardinalToolStripMenuItem.Name = "AgregarUnPuntoCardinalToolStripMenuItem"
        Me.AgregarUnPuntoCardinalToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.AgregarUnPuntoCardinalToolStripMenuItem.Text = "Agregar un punto cardinal"
        '
        'ModificarUnPuntoCardinalToolStripMenuItem
        '
        Me.ModificarUnPuntoCardinalToolStripMenuItem.Name = "ModificarUnPuntoCardinalToolStripMenuItem"
        Me.ModificarUnPuntoCardinalToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ModificarUnPuntoCardinalToolStripMenuItem.Text = "Modificar un punto cardinal"
        '
        'EliminarUnPuntoCardinalToolStripMenuItem
        '
        Me.EliminarUnPuntoCardinalToolStripMenuItem.Name = "EliminarUnPuntoCardinalToolStripMenuItem"
        Me.EliminarUnPuntoCardinalToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.EliminarUnPuntoCardinalToolStripMenuItem.Text = "Eliminar un punto cardinal"
        '
        'UbicaciónToolStripMenuItem
        '
        Me.UbicaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarUnaUbicaciónToolStripMenuItem, Me.ModificarLaCalleDeUnPuntoCardinalToolStripMenuItem, Me.EliminarUnaUbicaciónToolStripMenuItem})
        Me.UbicaciónToolStripMenuItem.Name = "UbicaciónToolStripMenuItem"
        Me.UbicaciónToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UbicaciónToolStripMenuItem.Text = "Ubicación"
        '
        'AgregarUnaUbicaciónToolStripMenuItem
        '
        Me.AgregarUnaUbicaciónToolStripMenuItem.Name = "AgregarUnaUbicaciónToolStripMenuItem"
        Me.AgregarUnaUbicaciónToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.AgregarUnaUbicaciónToolStripMenuItem.Text = "Agregar una ubicación"
        '
        'ModificarLaCalleDeUnPuntoCardinalToolStripMenuItem
        '
        Me.ModificarLaCalleDeUnPuntoCardinalToolStripMenuItem.Name = "ModificarLaCalleDeUnPuntoCardinalToolStripMenuItem"
        Me.ModificarLaCalleDeUnPuntoCardinalToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.ModificarLaCalleDeUnPuntoCardinalToolStripMenuItem.Text = "Modificar la calle de un punto cardinal"
        '
        'EliminarUnaUbicaciónToolStripMenuItem
        '
        Me.EliminarUnaUbicaciónToolStripMenuItem.Name = "EliminarUnaUbicaciónToolStripMenuItem"
        Me.EliminarUnaUbicaciónToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.EliminarUnaUbicaciónToolStripMenuItem.Text = "Eliminar una ubicación"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CondominiosToolStripMenuItem, Me.ComitésToolStripMenuItem, Me.HabitantesToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'CondominiosToolStripMenuItem
        '
        Me.CondominiosToolStripMenuItem.Name = "CondominiosToolStripMenuItem"
        Me.CondominiosToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.CondominiosToolStripMenuItem.Text = "Condominios"
        '
        'ComitésToolStripMenuItem
        '
        Me.ComitésToolStripMenuItem.Name = "ComitésToolStripMenuItem"
        Me.ComitésToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ComitésToolStripMenuItem.Text = "Comités"
        '
        'HabitantesToolStripMenuItem
        '
        Me.HabitantesToolStripMenuItem.Name = "HabitantesToolStripMenuItem"
        Me.HabitantesToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.HabitantesToolStripMenuItem.Text = "Habitantes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(252, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Sistema integrado de gestion de condominos"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(225, 136)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(299, 170)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents COnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip3 As ContextMenuStrip
    Friend WithEvents CondominioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CondominioToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents IngresarUnNuevoCondominioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarPorUnCondominioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MapaDeCondominiosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComitéToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearUnComitéToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarUnComitéToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CasaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PuntoCardinalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarUnPuntoCardinalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarUnPuntoCardinalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarUnPuntoCardinalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UbicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarUnaUbicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarLaCalleDeUnPuntoCardinalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarUnaUbicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CondominiosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComitésToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HabitantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
End Class
