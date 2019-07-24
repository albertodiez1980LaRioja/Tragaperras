<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empresa
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.M_cif = New System.Windows.Forms.MaskedTextBox
        Me.t_nombre_empresa = New System.Windows.Forms.TextBox
        Me.c_comunidad = New System.Windows.Forms.ComboBox
        Me.b_incluir = New System.Windows.Forms.Button
        Me.eliminar = New System.Windows.Forms.Button
        Me.nuevo = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(376, 44)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(421, 559)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre empresa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Comunidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CIF empresa"
        '
        'M_cif
        '
        Me.M_cif.Location = New System.Drawing.Point(140, 173)
        Me.M_cif.Mask = "999999999"
        Me.M_cif.Name = "M_cif"
        Me.M_cif.Size = New System.Drawing.Size(203, 22)
        Me.M_cif.TabIndex = 3
        '
        't_nombre_empresa
        '
        Me.t_nombre_empresa.Location = New System.Drawing.Point(140, 44)
        Me.t_nombre_empresa.Name = "t_nombre_empresa"
        Me.t_nombre_empresa.Size = New System.Drawing.Size(203, 22)
        Me.t_nombre_empresa.TabIndex = 1
        '
        'c_comunidad
        '
        Me.c_comunidad.FormattingEnabled = True
        Me.c_comunidad.Location = New System.Drawing.Point(140, 108)
        Me.c_comunidad.Name = "c_comunidad"
        Me.c_comunidad.Size = New System.Drawing.Size(203, 24)
        Me.c_comunidad.TabIndex = 2
        '
        'b_incluir
        '
        Me.b_incluir.Location = New System.Drawing.Point(85, 273)
        Me.b_incluir.Name = "b_incluir"
        Me.b_incluir.Size = New System.Drawing.Size(214, 82)
        Me.b_incluir.TabIndex = 4
        Me.b_incluir.Text = "Incluir/actulizar"
        Me.b_incluir.UseVisualStyleBackColor = True
        '
        'eliminar
        '
        Me.eliminar.Location = New System.Drawing.Point(85, 398)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(214, 82)
        Me.eliminar.TabIndex = 5
        Me.eliminar.Text = "Eliminar empresa"
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'nuevo
        '
        Me.nuevo.Location = New System.Drawing.Point(85, 521)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(214, 82)
        Me.nuevo.TabIndex = 6
        Me.nuevo.Text = "Nuevo"
        Me.nuevo.UseVisualStyleBackColor = True
        '
        'empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 670)
        Me.Controls.Add(Me.nuevo)
        Me.Controls.Add(Me.eliminar)
        Me.Controls.Add(Me.b_incluir)
        Me.Controls.Add(Me.c_comunidad)
        Me.Controls.Add(Me.t_nombre_empresa)
        Me.Controls.Add(Me.M_cif)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "empresa"
        Me.Text = "empresa"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents M_cif As System.Windows.Forms.MaskedTextBox
    Friend WithEvents t_nombre_empresa As System.Windows.Forms.TextBox
    Friend WithEvents c_comunidad As System.Windows.Forms.ComboBox
    Friend WithEvents b_incluir As System.Windows.Forms.Button
    Friend WithEvents eliminar As System.Windows.Forms.Button
    Friend WithEvents nuevo As System.Windows.Forms.Button
End Class
