<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregarCasa
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
        Me.agregarCasaPanel = New System.Windows.Forms.Panel()
        Me.addCasa = New System.Windows.Forms.LinkLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adultos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.anio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.buscarCondominio = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.comboCondominio = New System.Windows.Forms.Label()
        Me.casaAdd = New System.Windows.Forms.Button()
        Me.agregarCasaPanel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'agregarCasaPanel
        '
        Me.agregarCasaPanel.Controls.Add(Me.casaAdd)
        Me.agregarCasaPanel.Controls.Add(Me.addCasa)
        Me.agregarCasaPanel.Controls.Add(Me.DataGridView1)
        Me.agregarCasaPanel.Controls.Add(Me.buscarCondominio)
        Me.agregarCasaPanel.Controls.Add(Me.ComboBox1)
        Me.agregarCasaPanel.Controls.Add(Me.comboCondominio)
        Me.agregarCasaPanel.Location = New System.Drawing.Point(84, 30)
        Me.agregarCasaPanel.Name = "agregarCasaPanel"
        Me.agregarCasaPanel.Size = New System.Drawing.Size(554, 298)
        Me.agregarCasaPanel.TabIndex = 0
        '
        'addCasa
        '
        Me.addCasa.AutoSize = True
        Me.addCasa.Location = New System.Drawing.Point(21, 109)
        Me.addCasa.Name = "addCasa"
        Me.addCasa.Size = New System.Drawing.Size(0, 13)
        Me.addCasa.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero, Me.adultos, Me.anio, Me.Modificar, Me.Eliminar})
        Me.DataGridView1.Location = New System.Drawing.Point(3, 142)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(548, 141)
        Me.DataGridView1.TabIndex = 3
        '
        'numero
        '
        Me.numero.HeaderText = "numero"
        Me.numero.Name = "numero"
        '
        'adultos
        '
        Me.adultos.HeaderText = "adultos"
        Me.adultos.Name = "adultos"
        '
        'anio
        '
        Me.anio.HeaderText = "año"
        Me.anio.Name = "anio"
        '
        'Modificar
        '
        Me.Modificar.HeaderText = "Modificar"
        Me.Modificar.Name = "Modificar"
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        '
        'buscarCondominio
        '
        Me.buscarCondominio.Location = New System.Drawing.Point(182, 63)
        Me.buscarCondominio.Name = "buscarCondominio"
        Me.buscarCondominio.Size = New System.Drawing.Size(75, 23)
        Me.buscarCondominio.TabIndex = 2
        Me.buscarCondominio.Text = "Buscar"
        Me.buscarCondominio.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(182, 25)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'comboCondominio
        '
        Me.comboCondominio.AutoSize = True
        Me.comboCondominio.Location = New System.Drawing.Point(34, 28)
        Me.comboCondominio.Name = "comboCondominio"
        Me.comboCondominio.Size = New System.Drawing.Size(121, 13)
        Me.comboCondominio.TabIndex = 0
        Me.comboCondominio.Text = "Seleccionar Condominio"
        '
        'casaAdd
        '
        Me.casaAdd.Location = New System.Drawing.Point(3, 104)
        Me.casaAdd.Name = "casaAdd"
        Me.casaAdd.Size = New System.Drawing.Size(75, 23)
        Me.casaAdd.TabIndex = 5
        Me.casaAdd.Text = "Agregar Casa"
        Me.casaAdd.UseVisualStyleBackColor = True
        '
        'agregarCasa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.agregarCasaPanel)
        Me.Name = "agregarCasa"
        Me.Text = "agregarCasa"
        Me.agregarCasaPanel.ResumeLayout(False)
        Me.agregarCasaPanel.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents agregarCasaPanel As Panel
    Friend WithEvents comboCondominio As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents buscarCondominio As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents addCasa As LinkLabel
    Friend WithEvents numero As DataGridViewTextBoxColumn
    Friend WithEvents adultos As DataGridViewTextBoxColumn
    Friend WithEvents anio As DataGridViewTextBoxColumn
    Friend WithEvents Modificar As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewTextBoxColumn
    Friend WithEvents casaAdd As Button
End Class
