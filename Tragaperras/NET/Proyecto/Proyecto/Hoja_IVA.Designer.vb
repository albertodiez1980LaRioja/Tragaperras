<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hoja_IVA
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
        Me.imprimir = New System.Windows.Forms.Button
        Me.filtrar_por = New System.Windows.Forms.ComboBox
        Me.valor_filtro = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Semestre = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.año = New System.Windows.Forms.MaskedTextBox
        Me.n_copias = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imprimir
        '
        Me.imprimir.Location = New System.Drawing.Point(96, 444)
        Me.imprimir.Name = "imprimir"
        Me.imprimir.Size = New System.Drawing.Size(217, 78)
        Me.imprimir.TabIndex = 0
        Me.imprimir.Text = "Imprimir"
        Me.imprimir.UseVisualStyleBackColor = True
        '
        'filtrar_por
        '
        Me.filtrar_por.FormattingEnabled = True
        Me.filtrar_por.Items.AddRange(New Object() {"Todos", "Empresa", "Bar"})
        Me.filtrar_por.Location = New System.Drawing.Point(162, 50)
        Me.filtrar_por.Name = "filtrar_por"
        Me.filtrar_por.Size = New System.Drawing.Size(121, 24)
        Me.filtrar_por.TabIndex = 1
        '
        'valor_filtro
        '
        Me.valor_filtro.FormattingEnabled = True
        Me.valor_filtro.Location = New System.Drawing.Point(162, 150)
        Me.valor_filtro.Name = "valor_filtro"
        Me.valor_filtro.Size = New System.Drawing.Size(121, 24)
        Me.valor_filtro.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Valor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Filtrar por:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(374, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Número de copias:"
        '
        'Semestre
        '
        Me.Semestre.FormattingEnabled = True
        Me.Semestre.Items.AddRange(New Object() {"Primero", "Segundo", "Tercero", "Cuarto"})
        Me.Semestre.Location = New System.Drawing.Point(162, 257)
        Me.Semestre.Name = "Semestre"
        Me.Semestre.Size = New System.Drawing.Size(121, 24)
        Me.Semestre.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Semestre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 363)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Año:"
        '
        'año
        '
        Me.año.Location = New System.Drawing.Point(162, 363)
        Me.año.Mask = "9999"
        Me.año.Name = "año"
        Me.año.Size = New System.Drawing.Size(121, 22)
        Me.año.TabIndex = 9
        '
        'n_copias
        '
        Me.n_copias.AutoSize = True
        Me.n_copias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.n_copias.Location = New System.Drawing.Point(556, 57)
        Me.n_copias.Name = "n_copias"
        Me.n_copias.Size = New System.Drawing.Size(23, 25)
        Me.n_copias.TabIndex = 10
        Me.n_copias.Text = "0"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(409, 168)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(642, 354)
        Me.DataGridView1.TabIndex = 11
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Hoja_IVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 576)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.n_copias)
        Me.Controls.Add(Me.año)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Semestre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.valor_filtro)
        Me.Controls.Add(Me.filtrar_por)
        Me.Controls.Add(Me.imprimir)
        Me.Name = "Hoja_IVA"
        Me.Text = "Hoja IVA"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imprimir As System.Windows.Forms.Button
    Friend WithEvents filtrar_por As System.Windows.Forms.ComboBox
    Friend WithEvents valor_filtro As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Semestre As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents año As System.Windows.Forms.MaskedTextBox
    Friend WithEvents n_copias As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
End Class
