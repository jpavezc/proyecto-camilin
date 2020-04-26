<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cargo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.agregarCargo = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.nombreCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eliminar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nbCargoInput = New System.Windows.Forms.TextBox()
        Me.nbCargo = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(266, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Agregar Cargo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.UseWaitCursor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.agregarCargo)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.nbCargoInput)
        Me.Panel1.Controls.Add(Me.nbCargo)
        Me.Panel1.Location = New System.Drawing.Point(120, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(481, 278)
        Me.Panel1.TabIndex = 1
        '
        'agregarCargo
        '
        Me.agregarCargo.Location = New System.Drawing.Point(159, 38)
        Me.agregarCargo.Name = "agregarCargo"
        Me.agregarCargo.Size = New System.Drawing.Size(75, 23)
        Me.agregarCargo.TabIndex = 3
        Me.agregarCargo.Text = "Agregar"
        Me.agregarCargo.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombreCargo, Me.editar, Me.eliminar})
        Me.DataGridView1.Location = New System.Drawing.Point(56, 112)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(344, 143)
        Me.DataGridView1.TabIndex = 2
        '
        'nombreCargo
        '
        Me.nombreCargo.HeaderText = "Nombre"
        Me.nombreCargo.Name = "nombreCargo"
        '
        'editar
        '
        Me.editar.HeaderText = "Editar"
        Me.editar.Name = "editar"
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.Name = "eliminar"
        '
        'nbCargoInput
        '
        Me.nbCargoInput.Location = New System.Drawing.Point(159, 12)
        Me.nbCargoInput.Name = "nbCargoInput"
        Me.nbCargoInput.Size = New System.Drawing.Size(100, 20)
        Me.nbCargoInput.TabIndex = 1
        '
        'nbCargo
        '
        Me.nbCargo.AutoSize = True
        Me.nbCargo.Location = New System.Drawing.Point(38, 19)
        Me.nbCargo.Name = "nbCargo"
        Me.nbCargo.Size = New System.Drawing.Size(90, 13)
        Me.nbCargo.TabIndex = 0
        Me.nbCargo.Text = "Nombre de Cargo"
        '
        'cargo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "cargo"
        Me.Text = "cargo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents nbCargoInput As TextBox
    Friend WithEvents nbCargo As Label
    Friend WithEvents agregarCargo As Button
    Friend WithEvents nombreCargo As DataGridViewTextBoxColumn
    Friend WithEvents editar As DataGridViewTextBoxColumn
    Friend WithEvents eliminar As DataGridViewTextBoxColumn
End Class
