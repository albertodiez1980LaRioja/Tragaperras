<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_modelo_maquina
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
        Me.m_año = New System.Windows.Forms.MaskedTextBox
        Me.t_nombre = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.B_insertar_modelo = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.M_premio = New System.Windows.Forms.MaskedTextBox
        Me.B_insertar_a = New System.Windows.Forms.Button
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.M_carga = New System.Windows.Forms.MaskedTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 311)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(448, 335)
        Me.DataGridView1.TabIndex = 7
        '
        'm_año
        '
        Me.m_año.Location = New System.Drawing.Point(177, 71)
        Me.m_año.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.m_año.Mask = "0000"
        Me.m_año.Name = "m_año"
        Me.m_año.Size = New System.Drawing.Size(89, 22)
        Me.m_año.TabIndex = 2
        Me.m_año.Text = "2011"
        '
        't_nombre
        '
        Me.t_nombre.Location = New System.Drawing.Point(177, 25)
        Me.t_nombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.t_nombre.Name = "t_nombre"
        Me.t_nombre.Size = New System.Drawing.Size(415, 22)
        Me.t_nombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nombre modelo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Año del modelo"
        '
        'B_insertar_modelo
        '
        Me.B_insertar_modelo.Location = New System.Drawing.Point(68, 170)
        Me.B_insertar_modelo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.B_insertar_modelo.Name = "B_insertar_modelo"
        Me.B_insertar_modelo.Size = New System.Drawing.Size(197, 54)
        Me.B_insertar_modelo.TabIndex = 5
        Me.B_insertar_modelo.Text = "Insertar modelo B"
        Me.B_insertar_modelo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Premio maximo"
        '
        'M_premio
        '
        Me.M_premio.Location = New System.Drawing.Point(177, 114)
        Me.M_premio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.M_premio.Mask = "99999"
        Me.M_premio.Name = "M_premio"
        Me.M_premio.Size = New System.Drawing.Size(89, 22)
        Me.M_premio.TabIndex = 3
        Me.M_premio.Text = "240"
        Me.M_premio.ValidatingType = GetType(Integer)
        '
        'B_insertar_a
        '
        Me.B_insertar_a.Location = New System.Drawing.Point(309, 170)
        Me.B_insertar_a.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.B_insertar_a.Name = "B_insertar_a"
        Me.B_insertar_a.Size = New System.Drawing.Size(197, 54)
        Me.B_insertar_a.TabIndex = 6
        Me.B_insertar_a.Text = "Insertar modelo A"
        Me.B_insertar_a.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(549, 311)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(341, 335)
        Me.DataGridView2.TabIndex = 8
        '
        'M_carga
        '
        Me.M_carga.Location = New System.Drawing.Point(432, 112)
        Me.M_carga.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.M_carga.Mask = "99999"
        Me.M_carga.Name = "M_carga"
        Me.M_carga.Size = New System.Drawing.Size(89, 22)
        Me.M_carga.TabIndex = 4
        Me.M_carga.Text = "500"
        Me.M_carga.ValidatingType = GetType(Integer)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(320, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Carga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Maquinas B"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(547, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Maquinas A"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(560, 170)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(197, 54)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Eliminar modelo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Agregar_modelo_maquina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 682)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.M_carga)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.B_insertar_a)
        Me.Controls.Add(Me.M_premio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.B_insertar_modelo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.m_año)
        Me.Controls.Add(Me.t_nombre)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Agregar_modelo_maquina"
        Me.Text = "Modelo maquina"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents m_año As System.Windows.Forms.MaskedTextBox
    Friend WithEvents t_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents B_insertar_modelo As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents M_premio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents B_insertar_a As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents M_carga As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
