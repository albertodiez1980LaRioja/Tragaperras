<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.B_m_existente = New System.Windows.Forms.Button
        Me.B_agregar_modelo_maquina = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.B_reportar_iva = New System.Windows.Forms.Button
        Me.B_traslados = New System.Windows.Forms.Button
        Me.B_albaranes = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.B_n_robo = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.B_pedido_anterior = New System.Windows.Forms.Button
        Me.B_nuevo_pedido = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.B_datos_aseguradora = New System.Windows.Forms.Button
        Me.B_datos_furgonetas = New System.Windows.Forms.Button
        Me.B_operario_datos = New System.Windows.Forms.Button
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.B_nueva_comunidad = New System.Windows.Forms.Button
        Me.B_datos_empresa = New System.Windows.Forms.Button
        Me.B_datos_bar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.B_m_existente)
        Me.GroupBox1.Controls.Add(Me.B_agregar_modelo_maquina)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 158)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(464, 122)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestion maquinas"
        '
        'B_m_existente
        '
        Me.B_m_existente.Location = New System.Drawing.Point(248, 42)
        Me.B_m_existente.Margin = New System.Windows.Forms.Padding(4)
        Me.B_m_existente.Name = "B_m_existente"
        Me.B_m_existente.Size = New System.Drawing.Size(193, 44)
        Me.B_m_existente.TabIndex = 2
        Me.B_m_existente.Text = "Maquinas existentes"
        Me.B_m_existente.UseVisualStyleBackColor = True
        '
        'B_agregar_modelo_maquina
        '
        Me.B_agregar_modelo_maquina.Location = New System.Drawing.Point(20, 42)
        Me.B_agregar_modelo_maquina.Margin = New System.Windows.Forms.Padding(4)
        Me.B_agregar_modelo_maquina.Name = "B_agregar_modelo_maquina"
        Me.B_agregar_modelo_maquina.Size = New System.Drawing.Size(193, 44)
        Me.B_agregar_modelo_maquina.TabIndex = 1
        Me.B_agregar_modelo_maquina.Text = "Modelo maquinas"
        Me.B_agregar_modelo_maquina.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.B_reportar_iva)
        Me.GroupBox2.Controls.Add(Me.B_traslados)
        Me.GroupBox2.Controls.Add(Me.B_albaranes)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(753, 123)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gestion cuentas"
        '
        'B_reportar_iva
        '
        Me.B_reportar_iva.Location = New System.Drawing.Point(506, 41)
        Me.B_reportar_iva.Margin = New System.Windows.Forms.Padding(4)
        Me.B_reportar_iva.Name = "B_reportar_iva"
        Me.B_reportar_iva.Size = New System.Drawing.Size(193, 47)
        Me.B_reportar_iva.TabIndex = 2
        Me.B_reportar_iva.Text = "Hoja IVA"
        Me.B_reportar_iva.UseVisualStyleBackColor = True
        '
        'B_traslados
        '
        Me.B_traslados.Location = New System.Drawing.Point(275, 41)
        Me.B_traslados.Margin = New System.Windows.Forms.Padding(4)
        Me.B_traslados.Name = "B_traslados"
        Me.B_traslados.Size = New System.Drawing.Size(193, 47)
        Me.B_traslados.TabIndex = 1
        Me.B_traslados.Text = "Traslados"
        Me.B_traslados.UseVisualStyleBackColor = True
        '
        'B_albaranes
        '
        Me.B_albaranes.Location = New System.Drawing.Point(47, 41)
        Me.B_albaranes.Margin = New System.Windows.Forms.Padding(4)
        Me.B_albaranes.Name = "B_albaranes"
        Me.B_albaranes.Size = New System.Drawing.Size(193, 47)
        Me.B_albaranes.TabIndex = 0
        Me.B_albaranes.Text = "Albaranes"
        Me.B_albaranes.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.B_n_robo)
        Me.GroupBox3.Location = New System.Drawing.Point(520, 439)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(249, 122)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gestion de robos"
        Me.GroupBox3.Visible = False
        '
        'B_n_robo
        '
        Me.B_n_robo.Location = New System.Drawing.Point(25, 43)
        Me.B_n_robo.Margin = New System.Windows.Forms.Padding(4)
        Me.B_n_robo.Name = "B_n_robo"
        Me.B_n_robo.Size = New System.Drawing.Size(196, 43)
        Me.B_n_robo.TabIndex = 0
        Me.B_n_robo.Text = "Nuevo robo"
        Me.B_n_robo.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.B_pedido_anterior)
        Me.GroupBox4.Controls.Add(Me.B_nuevo_pedido)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 439)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(479, 122)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Gestion de pedidos"
        Me.GroupBox4.Visible = False
        '
        'B_pedido_anterior
        '
        Me.B_pedido_anterior.Location = New System.Drawing.Point(248, 43)
        Me.B_pedido_anterior.Margin = New System.Windows.Forms.Padding(4)
        Me.B_pedido_anterior.Name = "B_pedido_anterior"
        Me.B_pedido_anterior.Size = New System.Drawing.Size(193, 43)
        Me.B_pedido_anterior.TabIndex = 1
        Me.B_pedido_anterior.Text = "Pedido anterior"
        Me.B_pedido_anterior.UseVisualStyleBackColor = True
        '
        'B_nuevo_pedido
        '
        Me.B_nuevo_pedido.Location = New System.Drawing.Point(20, 43)
        Me.B_nuevo_pedido.Margin = New System.Windows.Forms.Padding(4)
        Me.B_nuevo_pedido.Name = "B_nuevo_pedido"
        Me.B_nuevo_pedido.Size = New System.Drawing.Size(193, 43)
        Me.B_nuevo_pedido.TabIndex = 0
        Me.B_nuevo_pedido.Text = "Nuevo pedido"
        Me.B_nuevo_pedido.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.B_datos_aseguradora)
        Me.GroupBox5.Controls.Add(Me.B_datos_furgonetas)
        Me.GroupBox5.Controls.Add(Me.B_operario_datos)
        Me.GroupBox5.Location = New System.Drawing.Point(495, 158)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(274, 122)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Gestion trabajadores"
        '
        'B_datos_aseguradora
        '
        Me.B_datos_aseguradora.Location = New System.Drawing.Point(239, 80)
        Me.B_datos_aseguradora.Margin = New System.Windows.Forms.Padding(4)
        Me.B_datos_aseguradora.Name = "B_datos_aseguradora"
        Me.B_datos_aseguradora.Size = New System.Drawing.Size(193, 41)
        Me.B_datos_aseguradora.TabIndex = 4
        Me.B_datos_aseguradora.Text = "Datos aseguradoras"
        Me.B_datos_aseguradora.UseVisualStyleBackColor = True
        Me.B_datos_aseguradora.Visible = False
        '
        'B_datos_furgonetas
        '
        Me.B_datos_furgonetas.Location = New System.Drawing.Point(239, 13)
        Me.B_datos_furgonetas.Margin = New System.Windows.Forms.Padding(4)
        Me.B_datos_furgonetas.Name = "B_datos_furgonetas"
        Me.B_datos_furgonetas.Size = New System.Drawing.Size(193, 41)
        Me.B_datos_furgonetas.TabIndex = 2
        Me.B_datos_furgonetas.Text = "Datos de vehiculos"
        Me.B_datos_furgonetas.UseVisualStyleBackColor = True
        Me.B_datos_furgonetas.Visible = False
        '
        'B_operario_datos
        '
        Me.B_operario_datos.Location = New System.Drawing.Point(38, 42)
        Me.B_operario_datos.Margin = New System.Windows.Forms.Padding(4)
        Me.B_operario_datos.Name = "B_operario_datos"
        Me.B_operario_datos.Size = New System.Drawing.Size(193, 44)
        Me.B_operario_datos.TabIndex = 0
        Me.B_operario_datos.Text = "Datos de trabajador"
        Me.B_operario_datos.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.B_nueva_comunidad)
        Me.GroupBox6.Controls.Add(Me.B_datos_empresa)
        Me.GroupBox6.Controls.Add(Me.B_datos_bar)
        Me.GroupBox6.Location = New System.Drawing.Point(16, 302)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Size = New System.Drawing.Size(753, 114)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Gestion de bares,empresas y comunidades"
        '
        'B_nueva_comunidad
        '
        Me.B_nueva_comunidad.Location = New System.Drawing.Point(506, 39)
        Me.B_nueva_comunidad.Margin = New System.Windows.Forms.Padding(4)
        Me.B_nueva_comunidad.Name = "B_nueva_comunidad"
        Me.B_nueva_comunidad.Size = New System.Drawing.Size(193, 41)
        Me.B_nueva_comunidad.TabIndex = 6
        Me.B_nueva_comunidad.Text = "Datos de comunidades"
        Me.B_nueva_comunidad.UseVisualStyleBackColor = True
        '
        'B_datos_empresa
        '
        Me.B_datos_empresa.Location = New System.Drawing.Point(275, 39)
        Me.B_datos_empresa.Margin = New System.Windows.Forms.Padding(4)
        Me.B_datos_empresa.Name = "B_datos_empresa"
        Me.B_datos_empresa.Size = New System.Drawing.Size(193, 41)
        Me.B_datos_empresa.TabIndex = 3
        Me.B_datos_empresa.Text = "Datos empresa"
        Me.B_datos_empresa.UseVisualStyleBackColor = True
        '
        'B_datos_bar
        '
        Me.B_datos_bar.Location = New System.Drawing.Point(47, 39)
        Me.B_datos_bar.Margin = New System.Windows.Forms.Padding(4)
        Me.B_datos_bar.Name = "B_datos_bar"
        Me.B_datos_bar.Size = New System.Drawing.Size(193, 41)
        Me.B_datos_bar.TabIndex = 1
        Me.B_datos_bar.Text = "Datos de bar"
        Me.B_datos_bar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 463)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Menu inicial"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents B_agregar_modelo_maquina As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents B_reportar_iva As System.Windows.Forms.Button
    Friend WithEvents B_traslados As System.Windows.Forms.Button
    Friend WithEvents B_albaranes As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents B_n_robo As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents B_pedido_anterior As System.Windows.Forms.Button
    Friend WithEvents B_nuevo_pedido As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents B_datos_aseguradora As System.Windows.Forms.Button
    Friend WithEvents B_datos_furgonetas As System.Windows.Forms.Button
    Friend WithEvents B_operario_datos As System.Windows.Forms.Button
    Friend WithEvents B_m_existente As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents B_nueva_comunidad As System.Windows.Forms.Button
    Friend WithEvents B_datos_empresa As System.Windows.Forms.Button
    Friend WithEvents B_datos_bar As System.Windows.Forms.Button

End Class
