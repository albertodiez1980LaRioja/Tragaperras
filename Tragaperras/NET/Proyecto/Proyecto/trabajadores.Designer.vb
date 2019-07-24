<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class trabajadores
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.B_nuevo = New System.Windows.Forms.Button
        Me.B_insertar = New System.Windows.Forms.Button
        Me.B_eliminar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.i_año = New System.Windows.Forms.MaskedTextBox
        Me.f_dia = New System.Windows.Forms.MaskedTextBox
        Me.i_dia = New System.Windows.Forms.MaskedTextBox
        Me.f_mes = New System.Windows.Forms.MaskedTextBox
        Me.i_mes = New System.Windows.Forms.MaskedTextBox
        Me.f_año = New System.Windows.Forms.MaskedTextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.sueldo = New System.Windows.Forms.MaskedTextBox
        Me.telefono = New System.Windows.Forms.MaskedTextBox
        Me.nombre = New System.Windows.Forms.TextBox
        Me.empresa = New System.Windows.Forms.ComboBox
        Me.DNI = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(40, 26)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1024, 249)
        Me.DataGridView1.TabIndex = 0
        '
        'B_nuevo
        '
        Me.B_nuevo.Location = New System.Drawing.Point(367, 315)
        Me.B_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.B_nuevo.Name = "B_nuevo"
        Me.B_nuevo.Size = New System.Drawing.Size(224, 59)
        Me.B_nuevo.TabIndex = 13
        Me.B_nuevo.Text = "Nuevo"
        Me.B_nuevo.UseVisualStyleBackColor = True
        '
        'B_insertar
        '
        Me.B_insertar.Location = New System.Drawing.Point(72, 315)
        Me.B_insertar.Margin = New System.Windows.Forms.Padding(4)
        Me.B_insertar.Name = "B_insertar"
        Me.B_insertar.Size = New System.Drawing.Size(224, 59)
        Me.B_insertar.TabIndex = 12
        Me.B_insertar.Text = "Insertar/Actualizar"
        Me.B_insertar.UseVisualStyleBackColor = True
        '
        'B_eliminar
        '
        Me.B_eliminar.Location = New System.Drawing.Point(676, 315)
        Me.B_eliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.B_eliminar.Name = "B_eliminar"
        Me.B_eliminar.Size = New System.Drawing.Size(224, 59)
        Me.B_eliminar.TabIndex = 14
        Me.B_eliminar.Text = "Eliminar"
        Me.B_eliminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 453)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(104, 501)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 17)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "DNI:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 553)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Fecha inicio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(104, 604)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 17)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Fecha fin:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(565, 453)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Sueldo:"
        '
        'i_año
        '
        Me.i_año.Location = New System.Drawing.Point(421, 549)
        Me.i_año.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.i_año.Mask = "9999"
        Me.i_año.Name = "i_año"
        Me.i_año.Size = New System.Drawing.Size(57, 22)
        Me.i_año.TabIndex = 5
        '
        'f_dia
        '
        Me.f_dia.Location = New System.Drawing.Point(221, 601)
        Me.f_dia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.f_dia.Mask = "99"
        Me.f_dia.Name = "f_dia"
        Me.f_dia.Size = New System.Drawing.Size(57, 22)
        Me.f_dia.TabIndex = 6
        '
        'i_dia
        '
        Me.i_dia.Location = New System.Drawing.Point(221, 549)
        Me.i_dia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.i_dia.Mask = "99"
        Me.i_dia.Name = "i_dia"
        Me.i_dia.Size = New System.Drawing.Size(57, 22)
        Me.i_dia.TabIndex = 3
        '
        'f_mes
        '
        Me.f_mes.Location = New System.Drawing.Point(321, 601)
        Me.f_mes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.f_mes.Mask = "99"
        Me.f_mes.Name = "f_mes"
        Me.f_mes.Size = New System.Drawing.Size(57, 22)
        Me.f_mes.TabIndex = 7
        '
        'i_mes
        '
        Me.i_mes.Location = New System.Drawing.Point(320, 549)
        Me.i_mes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.i_mes.Mask = "99"
        Me.i_mes.Name = "i_mes"
        Me.i_mes.Size = New System.Drawing.Size(57, 22)
        Me.i_mes.TabIndex = 4
        '
        'f_año
        '
        Me.f_año.Location = New System.Drawing.Point(423, 601)
        Me.f_año.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.f_año.Mask = "9999"
        Me.f_año.Name = "f_año"
        Me.f_año.Size = New System.Drawing.Size(57, 22)
        Me.f_año.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(385, 603)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 17)
        Me.Label14.TabIndex = 87
        Me.Label14.Text = "año"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(287, 603)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 17)
        Me.Label15.TabIndex = 86
        Me.Label15.Text = "mes"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(188, 603)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(27, 17)
        Me.Label16.TabIndex = 85
        Me.Label16.Text = "dia"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(384, 553)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 17)
        Me.Label13.TabIndex = 84
        Me.Label13.Text = "año"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(285, 553)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 17)
        Me.Label12.TabIndex = 83
        Me.Label12.Text = "mes"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(187, 553)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 17)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "dia"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(565, 501)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Empresa:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(565, 553)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 17)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Telefono:"
        '
        'sueldo
        '
        Me.sueldo.Location = New System.Drawing.Point(661, 449)
        Me.sueldo.Margin = New System.Windows.Forms.Padding(4)
        Me.sueldo.Mask = "999999999"
        Me.sueldo.Name = "sueldo"
        Me.sueldo.Size = New System.Drawing.Size(160, 22)
        Me.sueldo.TabIndex = 9
        '
        'telefono
        '
        Me.telefono.Location = New System.Drawing.Point(661, 549)
        Me.telefono.Margin = New System.Windows.Forms.Padding(4)
        Me.telefono.Mask = "999999999"
        Me.telefono.Name = "telefono"
        Me.telefono.Size = New System.Drawing.Size(160, 22)
        Me.telefono.TabIndex = 11
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(221, 449)
        Me.nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(132, 22)
        Me.nombre.TabIndex = 1
        '
        'empresa
        '
        Me.empresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.empresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.empresa.FormattingEnabled = True
        Me.empresa.Location = New System.Drawing.Point(661, 497)
        Me.empresa.Margin = New System.Windows.Forms.Padding(4)
        Me.empresa.Name = "empresa"
        Me.empresa.Size = New System.Drawing.Size(160, 24)
        Me.empresa.TabIndex = 10
        '
        'DNI
        '
        Me.DNI.Location = New System.Drawing.Point(221, 497)
        Me.DNI.Margin = New System.Windows.Forms.Padding(4)
        Me.DNI.Name = "DNI"
        Me.DNI.Size = New System.Drawing.Size(132, 22)
        Me.DNI.TabIndex = 2
        '
        'trabajadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 668)
        Me.Controls.Add(Me.DNI)
        Me.Controls.Add(Me.empresa)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.telefono)
        Me.Controls.Add(Me.sueldo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.i_año)
        Me.Controls.Add(Me.f_dia)
        Me.Controls.Add(Me.i_dia)
        Me.Controls.Add(Me.f_mes)
        Me.Controls.Add(Me.i_mes)
        Me.Controls.Add(Me.f_año)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.B_eliminar)
        Me.Controls.Add(Me.B_insertar)
        Me.Controls.Add(Me.B_nuevo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "trabajadores"
        Me.Text = "Trabajadores"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents B_nuevo As System.Windows.Forms.Button
    Friend WithEvents B_insertar As System.Windows.Forms.Button
    Friend WithEvents B_eliminar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents i_año As System.Windows.Forms.MaskedTextBox
    Friend WithEvents f_dia As System.Windows.Forms.MaskedTextBox
    Friend WithEvents i_dia As System.Windows.Forms.MaskedTextBox
    Friend WithEvents f_mes As System.Windows.Forms.MaskedTextBox
    Friend WithEvents i_mes As System.Windows.Forms.MaskedTextBox
    Friend WithEvents f_año As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents sueldo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents telefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents nombre As System.Windows.Forms.TextBox
    Friend WithEvents empresa As System.Windows.Forms.ComboBox
    Friend WithEvents DNI As System.Windows.Forms.TextBox
End Class
