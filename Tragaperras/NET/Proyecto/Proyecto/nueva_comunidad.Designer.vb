<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nueva_comunidad
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.B_añadir = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.c_nombre = New System.Windows.Forms.TextBox
        Me.max_a = New System.Windows.Forms.MaskedTextBox
        Me.max_b = New System.Windows.Forms.MaskedTextBox
        Me.max_total = New System.Windows.Forms.MaskedTextBox
        Me.impuesto = New System.Windows.Forms.TextBox
        Me.eliminar = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'B_añadir
        '
        Me.B_añadir.Location = New System.Drawing.Point(486, 346)
        Me.B_añadir.Name = "B_añadir"
        Me.B_añadir.Size = New System.Drawing.Size(199, 65)
        Me.B_añadir.TabIndex = 6
        Me.B_añadir.Text = "Añadir/actualizar comunidad"
        Me.B_añadir.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(34, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(688, 289)
        Me.DataGridView1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 346)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre comunidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 384)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Impuesto anual por maquina B:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 420)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Máximo de maquinas A:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 460)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Máximo de maquinas B"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 504)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Máximo de maquinas en total:"
        '
        'c_nombre
        '
        Me.c_nombre.Location = New System.Drawing.Point(249, 343)
        Me.c_nombre.Name = "c_nombre"
        Me.c_nombre.Size = New System.Drawing.Size(181, 22)
        Me.c_nombre.TabIndex = 1
        '
        'max_a
        '
        Me.max_a.Location = New System.Drawing.Point(249, 417)
        Me.max_a.Mask = "999"
        Me.max_a.Name = "max_a"
        Me.max_a.Size = New System.Drawing.Size(181, 22)
        Me.max_a.TabIndex = 3
        Me.max_a.Text = "2"
        '
        'max_b
        '
        Me.max_b.Location = New System.Drawing.Point(249, 457)
        Me.max_b.Mask = "999"
        Me.max_b.Name = "max_b"
        Me.max_b.Size = New System.Drawing.Size(181, 22)
        Me.max_b.TabIndex = 4
        Me.max_b.Text = "2"
        '
        'max_total
        '
        Me.max_total.Location = New System.Drawing.Point(249, 501)
        Me.max_total.Mask = "999"
        Me.max_total.Name = "max_total"
        Me.max_total.Size = New System.Drawing.Size(181, 22)
        Me.max_total.TabIndex = 5
        Me.max_total.Text = "2"
        '
        'impuesto
        '
        Me.impuesto.Location = New System.Drawing.Point(249, 381)
        Me.impuesto.Name = "impuesto"
        Me.impuesto.Size = New System.Drawing.Size(181, 22)
        Me.impuesto.TabIndex = 2
        '
        'eliminar
        '
        Me.eliminar.Location = New System.Drawing.Point(486, 444)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(199, 65)
        Me.eliminar.TabIndex = 8
        Me.eliminar.Text = "Eliminar comunidad"
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'nueva_comunidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 558)
        Me.Controls.Add(Me.eliminar)
        Me.Controls.Add(Me.impuesto)
        Me.Controls.Add(Me.max_total)
        Me.Controls.Add(Me.max_b)
        Me.Controls.Add(Me.max_a)
        Me.Controls.Add(Me.c_nombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.B_añadir)
        Me.Name = "nueva_comunidad"
        Me.Text = "nueva comunidad"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B_añadir As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents c_nombre As System.Windows.Forms.TextBox
    Friend WithEvents max_a As System.Windows.Forms.MaskedTextBox
    Friend WithEvents max_b As System.Windows.Forms.MaskedTextBox
    Friend WithEvents max_total As System.Windows.Forms.MaskedTextBox
    Friend WithEvents impuesto As System.Windows.Forms.TextBox
    Friend WithEvents eliminar As System.Windows.Forms.Button
End Class
