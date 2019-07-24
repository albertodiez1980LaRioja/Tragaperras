<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class maquinas_existentes
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.B_cambiar_datos = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.serie_año = New System.Windows.Forms.MaskedTextBox
        Me.serie_numero = New System.Windows.Forms.MaskedTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.filtrar_por = New System.Windows.Forms.ComboBox
        Me.tipo_maquina = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.valor_filtro = New System.Windows.Forms.ListBox
        Me.comunidad = New System.Windows.Forms.ComboBox
        Me.empresa = New System.Windows.Forms.ComboBox
        Me.l_nombre = New System.Windows.Forms.Label
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.eliminar = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nombre modelo:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(19, 60)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(448, 274)
        Me.DataGridView1.TabIndex = 21
        '
        'B_cambiar_datos
        '
        Me.B_cambiar_datos.Location = New System.Drawing.Point(19, 570)
        Me.B_cambiar_datos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.B_cambiar_datos.Name = "B_cambiar_datos"
        Me.B_cambiar_datos.Size = New System.Drawing.Size(227, 82)
        Me.B_cambiar_datos.TabIndex = 23
        Me.B_cambiar_datos.Text = "Insertar/actualizar datos"
        Me.B_cambiar_datos.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 416)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Comunidad autónoma:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 472)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Empresa:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 519)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 17)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Numero de serie:"
        '
        'serie_año
        '
        Me.serie_año.Location = New System.Drawing.Point(177, 512)
        Me.serie_año.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.serie_año.Mask = "99"
        Me.serie_año.Name = "serie_año"
        Me.serie_año.Size = New System.Drawing.Size(35, 22)
        Me.serie_año.TabIndex = 27
        '
        'serie_numero
        '
        Me.serie_numero.Location = New System.Drawing.Point(237, 512)
        Me.serie_numero.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.serie_numero.Mask = "999999"
        Me.serie_numero.Name = "serie_numero"
        Me.serie_numero.Size = New System.Drawing.Size(65, 22)
        Me.serie_numero.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(217, 517)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 17)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "--"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(532, 455)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 17)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Filtrar por:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(532, 505)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 17)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Valor del filtro:"
        '
        'filtrar_por
        '
        Me.filtrar_por.FormattingEnabled = True
        Me.filtrar_por.Items.AddRange(New Object() {"Ninguno", "Empresa", "Comunidad autonoma"})
        Me.filtrar_por.Location = New System.Drawing.Point(652, 455)
        Me.filtrar_por.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.filtrar_por.Name = "filtrar_por"
        Me.filtrar_por.Size = New System.Drawing.Size(214, 24)
        Me.filtrar_por.TabIndex = 32
        '
        'tipo_maquina
        '
        Me.tipo_maquina.FormattingEnabled = True
        Me.tipo_maquina.Items.AddRange(New Object() {"A", "B"})
        Me.tipo_maquina.Location = New System.Drawing.Point(177, 366)
        Me.tipo_maquina.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tipo_maquina.Name = "tipo_maquina"
        Me.tipo_maquina.Size = New System.Drawing.Size(121, 24)
        Me.tipo_maquina.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 369)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 17)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Tipo de maquina:"
        '
        'valor_filtro
        '
        Me.valor_filtro.FormattingEnabled = True
        Me.valor_filtro.ItemHeight = 16
        Me.valor_filtro.Location = New System.Drawing.Point(652, 505)
        Me.valor_filtro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.valor_filtro.Name = "valor_filtro"
        Me.valor_filtro.Size = New System.Drawing.Size(214, 148)
        Me.valor_filtro.TabIndex = 37
        '
        'comunidad
        '
        Me.comunidad.FormattingEnabled = True
        Me.comunidad.Items.AddRange(New Object() {"A", "B"})
        Me.comunidad.Location = New System.Drawing.Point(177, 416)
        Me.comunidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.comunidad.Name = "comunidad"
        Me.comunidad.Size = New System.Drawing.Size(121, 24)
        Me.comunidad.TabIndex = 38
        '
        'empresa
        '
        Me.empresa.FormattingEnabled = True
        Me.empresa.Items.AddRange(New Object() {"A", "B"})
        Me.empresa.Location = New System.Drawing.Point(177, 469)
        Me.empresa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.empresa.Name = "empresa"
        Me.empresa.Size = New System.Drawing.Size(121, 24)
        Me.empresa.TabIndex = 39
        '
        'l_nombre
        '
        Me.l_nombre.AutoSize = True
        Me.l_nombre.Location = New System.Drawing.Point(132, 23)
        Me.l_nombre.Name = "l_nombre"
        Me.l_nombre.Size = New System.Drawing.Size(51, 17)
        Me.l_nombre.TabIndex = 40
        Me.l_nombre.Text = "Label9"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(541, 34)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(501, 398)
        Me.DataGridView2.TabIndex = 41
        '
        'eliminar
        '
        Me.eliminar.Location = New System.Drawing.Point(284, 570)
        Me.eliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(227, 82)
        Me.eliminar.TabIndex = 42
        Me.eliminar.Text = "Eliminar"
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'maquinas_existentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 679)
        Me.Controls.Add(Me.eliminar)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.l_nombre)
        Me.Controls.Add(Me.empresa)
        Me.Controls.Add(Me.comunidad)
        Me.Controls.Add(Me.valor_filtro)
        Me.Controls.Add(Me.tipo_maquina)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.filtrar_por)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.serie_numero)
        Me.Controls.Add(Me.serie_año)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.B_cambiar_datos)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "maquinas_existentes"
        Me.Text = "Maquinas existentes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents B_cambiar_datos As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents serie_año As System.Windows.Forms.MaskedTextBox
    Friend WithEvents serie_numero As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents filtrar_por As System.Windows.Forms.ComboBox
    Friend WithEvents tipo_maquina As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents valor_filtro As System.Windows.Forms.ListBox
    Friend WithEvents comunidad As System.Windows.Forms.ComboBox
    Friend WithEvents empresa As System.Windows.Forms.ComboBox
    Friend WithEvents l_nombre As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents eliminar As System.Windows.Forms.Button
End Class
