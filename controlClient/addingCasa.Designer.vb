<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addingCasa
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
        Me.cntAddCasa = New System.Windows.Forms.Panel()
        Me.agregarCasabtn = New System.Windows.Forms.Button()
        Me.anioCasaTxtBox = New System.Windows.Forms.TextBox()
        Me.nCasatxtBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cntAddCasa.SuspendLayout()
        Me.SuspendLayout()
        '
        'cntAddCasa
        '
        Me.cntAddCasa.Controls.Add(Me.agregarCasabtn)
        Me.cntAddCasa.Controls.Add(Me.anioCasaTxtBox)
        Me.cntAddCasa.Controls.Add(Me.nCasatxtBox)
        Me.cntAddCasa.Controls.Add(Me.Label2)
        Me.cntAddCasa.Controls.Add(Me.Label1)
        Me.cntAddCasa.Location = New System.Drawing.Point(175, 49)
        Me.cntAddCasa.Name = "cntAddCasa"
        Me.cntAddCasa.Size = New System.Drawing.Size(401, 291)
        Me.cntAddCasa.TabIndex = 0
        '
        'agregarCasabtn
        '
        Me.agregarCasabtn.Location = New System.Drawing.Point(178, 116)
        Me.agregarCasabtn.Name = "agregarCasabtn"
        Me.agregarCasabtn.Size = New System.Drawing.Size(75, 23)
        Me.agregarCasabtn.TabIndex = 7
        Me.agregarCasabtn.Text = "Aceptar"
        Me.agregarCasabtn.UseVisualStyleBackColor = True
        '
        'anioCasaTxtBox
        '
        Me.anioCasaTxtBox.Location = New System.Drawing.Point(178, 67)
        Me.anioCasaTxtBox.Name = "anioCasaTxtBox"
        Me.anioCasaTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.anioCasaTxtBox.TabIndex = 5
        '
        'nCasatxtBox
        '
        Me.nCasatxtBox.Location = New System.Drawing.Point(178, 35)
        Me.nCasatxtBox.Name = "nCasatxtBox"
        Me.nCasatxtBox.Size = New System.Drawing.Size(100, 20)
        Me.nCasatxtBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Año"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero de Casa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(312, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Agregar Casa"
        '
        'addingCasa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cntAddCasa)
        Me.Name = "addingCasa"
        Me.Text = "addCasa"
        Me.cntAddCasa.ResumeLayout(False)
        Me.cntAddCasa.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cntAddCasa As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents anioCasaTxtBox As TextBox
    Friend WithEvents nCasatxtBox As TextBox
    Friend WithEvents agregarCasabtn As Button
    Friend WithEvents Label3 As Label
End Class
