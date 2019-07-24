<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class traslados
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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Tab_instalacion = New System.Windows.Forms.TabPage
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.filtro_inslalar = New System.Windows.Forms.ComboBox
        Me.filtrar_instalacion = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.B_instalar = New System.Windows.Forms.Button
        Me.f_instalacion = New System.Windows.Forms.MonthCalendar
        Me.D_maquinas = New System.Windows.Forms.DataGridView
        Me.D_bares = New System.Windows.Forms.DataGridView
        Me.Tab_retiro = New System.Windows.Forms.TabPage
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.filtro_desistalar = New System.Windows.Forms.ComboBox
        Me.filtrar_desistalacion = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.buscar_por = New System.Windows.Forms.GroupBox
        Me.r_maquinas = New System.Windows.Forms.RadioButton
        Me.r_bares = New System.Windows.Forms.RadioButton
        Me.B_retirar = New System.Windows.Forms.Button
        Me.retiron_mc = New System.Windows.Forms.MonthCalendar
        Me.D_maquina_desistalar = New System.Windows.Forms.DataGridView
        Me.D_bar_desistalar = New System.Windows.Forms.DataGridView
        Me.Tab_traslados_antiguos = New System.Windows.Forms.TabPage
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.filtro_desistalado = New System.Windows.Forms.ComboBox
        Me.filtrar_desistalado = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.r_maquinas2 = New System.Windows.Forms.RadioButton
        Me.r_bares2 = New System.Windows.Forms.RadioButton
        Me.D_maquinas_antiguas = New System.Windows.Forms.DataGridView
        Me.D_antiguos_bares = New System.Windows.Forms.DataGridView
        Me.TabControl1.SuspendLayout()
        Me.Tab_instalacion.SuspendLayout()
        CType(Me.D_maquinas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D_bares, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_retiro.SuspendLayout()
        Me.buscar_por.SuspendLayout()
        CType(Me.D_maquina_desistalar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D_bar_desistalar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_traslados_antiguos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.D_maquinas_antiguas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D_antiguos_bares, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Tab_instalacion)
        Me.TabControl1.Controls.Add(Me.Tab_retiro)
        Me.TabControl1.Controls.Add(Me.Tab_traslados_antiguos)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(934, 553)
        Me.TabControl1.TabIndex = 0
        '
        'Tab_instalacion
        '
        Me.Tab_instalacion.Controls.Add(Me.Label4)
        Me.Tab_instalacion.Controls.Add(Me.Label2)
        Me.Tab_instalacion.Controls.Add(Me.filtro_inslalar)
        Me.Tab_instalacion.Controls.Add(Me.filtrar_instalacion)
        Me.Tab_instalacion.Controls.Add(Me.Label1)
        Me.Tab_instalacion.Controls.Add(Me.B_instalar)
        Me.Tab_instalacion.Controls.Add(Me.f_instalacion)
        Me.Tab_instalacion.Controls.Add(Me.D_maquinas)
        Me.Tab_instalacion.Controls.Add(Me.D_bares)
        Me.Tab_instalacion.Location = New System.Drawing.Point(4, 22)
        Me.Tab_instalacion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Tab_instalacion.Name = "Tab_instalacion"
        Me.Tab_instalacion.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Tab_instalacion.Size = New System.Drawing.Size(926, 527)
        Me.Tab_instalacion.TabIndex = 0
        Me.Tab_instalacion.Text = "Instalacion"
        Me.Tab_instalacion.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(652, 415)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Valor del filtro:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(652, 331)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Filtrar por:"
        '
        'filtro_inslalar
        '
        Me.filtro_inslalar.FormattingEnabled = True
        Me.filtro_inslalar.Location = New System.Drawing.Point(733, 412)
        Me.filtro_inslalar.Name = "filtro_inslalar"
        Me.filtro_inslalar.Size = New System.Drawing.Size(121, 21)
        Me.filtro_inslalar.TabIndex = 6
        '
        'filtrar_instalacion
        '
        Me.filtrar_instalacion.FormattingEnabled = True
        Me.filtrar_instalacion.Items.AddRange(New Object() {"Ninguno", "Comunidad", "Empresa", "Bar"})
        Me.filtrar_instalacion.Location = New System.Drawing.Point(733, 328)
        Me.filtrar_instalacion.Name = "filtrar_instalacion"
        Me.filtrar_instalacion.Size = New System.Drawing.Size(121, 21)
        Me.filtrar_instalacion.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 310)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Fecha de instalacion"
        '
        'B_instalar
        '
        Me.B_instalar.Location = New System.Drawing.Point(394, 328)
        Me.B_instalar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.B_instalar.Name = "B_instalar"
        Me.B_instalar.Size = New System.Drawing.Size(144, 54)
        Me.B_instalar.TabIndex = 3
        Me.B_instalar.Text = "Instalar"
        Me.B_instalar.UseVisualStyleBackColor = True
        '
        'f_instalacion
        '
        Me.f_instalacion.Location = New System.Drawing.Point(95, 353)
        Me.f_instalacion.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.f_instalacion.Name = "f_instalacion"
        Me.f_instalacion.TabIndex = 2
        '
        'D_maquinas
        '
        Me.D_maquinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.D_maquinas.Location = New System.Drawing.Point(394, 24)
        Me.D_maquinas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.D_maquinas.Name = "D_maquinas"
        Me.D_maquinas.ReadOnly = True
        Me.D_maquinas.RowTemplate.Height = 24
        Me.D_maquinas.Size = New System.Drawing.Size(511, 251)
        Me.D_maquinas.TabIndex = 1
        '
        'D_bares
        '
        Me.D_bares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.D_bares.Location = New System.Drawing.Point(18, 24)
        Me.D_bares.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.D_bares.Name = "D_bares"
        Me.D_bares.ReadOnly = True
        Me.D_bares.RowTemplate.Height = 24
        Me.D_bares.Size = New System.Drawing.Size(351, 251)
        Me.D_bares.TabIndex = 0
        '
        'Tab_retiro
        '
        Me.Tab_retiro.Controls.Add(Me.Label5)
        Me.Tab_retiro.Controls.Add(Me.Label6)
        Me.Tab_retiro.Controls.Add(Me.filtro_desistalar)
        Me.Tab_retiro.Controls.Add(Me.filtrar_desistalacion)
        Me.Tab_retiro.Controls.Add(Me.Label3)
        Me.Tab_retiro.Controls.Add(Me.buscar_por)
        Me.Tab_retiro.Controls.Add(Me.B_retirar)
        Me.Tab_retiro.Controls.Add(Me.retiron_mc)
        Me.Tab_retiro.Controls.Add(Me.D_maquina_desistalar)
        Me.Tab_retiro.Controls.Add(Me.D_bar_desistalar)
        Me.Tab_retiro.Location = New System.Drawing.Point(4, 22)
        Me.Tab_retiro.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Tab_retiro.Name = "Tab_retiro"
        Me.Tab_retiro.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Tab_retiro.Size = New System.Drawing.Size(926, 527)
        Me.Tab_retiro.TabIndex = 1
        Me.Tab_retiro.Text = "Ubicaciones actuales"
        Me.Tab_retiro.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(671, 405)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Valor del filtro:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(671, 321)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Filtrar por:"
        '
        'filtro_desistalar
        '
        Me.filtro_desistalar.FormattingEnabled = True
        Me.filtro_desistalar.Location = New System.Drawing.Point(752, 402)
        Me.filtro_desistalar.Name = "filtro_desistalar"
        Me.filtro_desistalar.Size = New System.Drawing.Size(121, 21)
        Me.filtro_desistalar.TabIndex = 12
        '
        'filtrar_desistalacion
        '
        Me.filtrar_desistalacion.FormattingEnabled = True
        Me.filtrar_desistalacion.Items.AddRange(New Object() {"Ninguno", "Comunidad", "Empresa", "Bar"})
        Me.filtrar_desistalacion.Location = New System.Drawing.Point(752, 318)
        Me.filtrar_desistalacion.Name = "filtrar_desistalacion"
        Me.filtrar_desistalacion.Size = New System.Drawing.Size(121, 21)
        Me.filtrar_desistalacion.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 306)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Fecha de retirada"
        '
        'buscar_por
        '
        Me.buscar_por.Controls.Add(Me.r_maquinas)
        Me.buscar_por.Controls.Add(Me.r_bares)
        Me.buscar_por.Location = New System.Drawing.Point(331, 405)
        Me.buscar_por.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.buscar_por.Name = "buscar_por"
        Me.buscar_por.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.buscar_por.Size = New System.Drawing.Size(303, 68)
        Me.buscar_por.TabIndex = 8
        Me.buscar_por.TabStop = False
        Me.buscar_por.Text = "Buscar por (desactivado con el filtro):"
        '
        'r_maquinas
        '
        Me.r_maquinas.AutoSize = True
        Me.r_maquinas.Location = New System.Drawing.Point(148, 26)
        Me.r_maquinas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.r_maquinas.Name = "r_maquinas"
        Me.r_maquinas.Size = New System.Drawing.Size(124, 17)
        Me.r_maquinas.TabIndex = 1
        Me.r_maquinas.Text = "Buscar por maquinas"
        Me.r_maquinas.UseVisualStyleBackColor = True
        '
        'r_bares
        '
        Me.r_bares.AutoSize = True
        Me.r_bares.Checked = True
        Me.r_bares.Location = New System.Drawing.Point(26, 26)
        Me.r_bares.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.r_bares.Name = "r_bares"
        Me.r_bares.Size = New System.Drawing.Size(105, 17)
        Me.r_bares.TabIndex = 0
        Me.r_bares.TabStop = True
        Me.r_bares.Text = "Buscar por bares"
        Me.r_bares.UseVisualStyleBackColor = True
        '
        'B_retirar
        '
        Me.B_retirar.Location = New System.Drawing.Point(331, 318)
        Me.B_retirar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.B_retirar.Name = "B_retirar"
        Me.B_retirar.Size = New System.Drawing.Size(144, 54)
        Me.B_retirar.TabIndex = 7
        Me.B_retirar.Text = "Retirar"
        Me.B_retirar.UseVisualStyleBackColor = True
        '
        'retiron_mc
        '
        Me.retiron_mc.Location = New System.Drawing.Point(88, 337)
        Me.retiron_mc.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.retiron_mc.Name = "retiron_mc"
        Me.retiron_mc.TabIndex = 6
        '
        'D_maquina_desistalar
        '
        Me.D_maquina_desistalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.D_maquina_desistalar.Location = New System.Drawing.Point(406, 24)
        Me.D_maquina_desistalar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.D_maquina_desistalar.Name = "D_maquina_desistalar"
        Me.D_maquina_desistalar.ReadOnly = True
        Me.D_maquina_desistalar.RowTemplate.Height = 24
        Me.D_maquina_desistalar.Size = New System.Drawing.Size(513, 251)
        Me.D_maquina_desistalar.TabIndex = 5
        '
        'D_bar_desistalar
        '
        Me.D_bar_desistalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.D_bar_desistalar.Location = New System.Drawing.Point(17, 24)
        Me.D_bar_desistalar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.D_bar_desistalar.Name = "D_bar_desistalar"
        Me.D_bar_desistalar.ReadOnly = True
        Me.D_bar_desistalar.RowTemplate.Height = 24
        Me.D_bar_desistalar.Size = New System.Drawing.Size(360, 251)
        Me.D_bar_desistalar.TabIndex = 4
        '
        'Tab_traslados_antiguos
        '
        Me.Tab_traslados_antiguos.Controls.Add(Me.Label7)
        Me.Tab_traslados_antiguos.Controls.Add(Me.Label8)
        Me.Tab_traslados_antiguos.Controls.Add(Me.filtro_desistalado)
        Me.Tab_traslados_antiguos.Controls.Add(Me.filtrar_desistalado)
        Me.Tab_traslados_antiguos.Controls.Add(Me.GroupBox1)
        Me.Tab_traslados_antiguos.Controls.Add(Me.D_maquinas_antiguas)
        Me.Tab_traslados_antiguos.Controls.Add(Me.D_antiguos_bares)
        Me.Tab_traslados_antiguos.Location = New System.Drawing.Point(4, 22)
        Me.Tab_traslados_antiguos.Name = "Tab_traslados_antiguos"
        Me.Tab_traslados_antiguos.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.Tab_traslados_antiguos.Size = New System.Drawing.Size(926, 527)
        Me.Tab_traslados_antiguos.TabIndex = 3
        Me.Tab_traslados_antiguos.Text = "Ubicaciones antiguas"
        Me.Tab_traslados_antiguos.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(73, 468)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Valor del filtro:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(73, 384)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Filtrar por:"
        '
        'filtro_desistalado
        '
        Me.filtro_desistalado.FormattingEnabled = True
        Me.filtro_desistalado.Location = New System.Drawing.Point(154, 465)
        Me.filtro_desistalado.Name = "filtro_desistalado"
        Me.filtro_desistalado.Size = New System.Drawing.Size(121, 21)
        Me.filtro_desistalado.TabIndex = 11
        '
        'filtrar_desistalado
        '
        Me.filtrar_desistalado.FormattingEnabled = True
        Me.filtrar_desistalado.Items.AddRange(New Object() {"Ninguno", "Comunidad", "Empresa", "Bar"})
        Me.filtrar_desistalado.Location = New System.Drawing.Point(154, 381)
        Me.filtrar_desistalado.Name = "filtrar_desistalado"
        Me.filtrar_desistalado.Size = New System.Drawing.Size(121, 21)
        Me.filtrar_desistalado.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.r_maquinas2)
        Me.GroupBox1.Controls.Add(Me.r_bares2)
        Me.GroupBox1.Location = New System.Drawing.Point(387, 439)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(303, 68)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por (desactivado con el filtro):"
        '
        'r_maquinas2
        '
        Me.r_maquinas2.AutoSize = True
        Me.r_maquinas2.Location = New System.Drawing.Point(148, 26)
        Me.r_maquinas2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.r_maquinas2.Name = "r_maquinas2"
        Me.r_maquinas2.Size = New System.Drawing.Size(124, 17)
        Me.r_maquinas2.TabIndex = 1
        Me.r_maquinas2.Text = "Buscar por maquinas"
        Me.r_maquinas2.UseVisualStyleBackColor = True
        '
        'r_bares2
        '
        Me.r_bares2.AutoSize = True
        Me.r_bares2.Checked = True
        Me.r_bares2.Location = New System.Drawing.Point(26, 26)
        Me.r_bares2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.r_bares2.Name = "r_bares2"
        Me.r_bares2.Size = New System.Drawing.Size(105, 17)
        Me.r_bares2.TabIndex = 0
        Me.r_bares2.TabStop = True
        Me.r_bares2.Text = "Buscar por bares"
        Me.r_bares2.UseVisualStyleBackColor = True
        '
        'D_maquinas_antiguas
        '
        Me.D_maquinas_antiguas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.D_maquinas_antiguas.Location = New System.Drawing.Point(387, 37)
        Me.D_maquinas_antiguas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.D_maquinas_antiguas.Name = "D_maquinas_antiguas"
        Me.D_maquinas_antiguas.ReadOnly = True
        Me.D_maquinas_antiguas.RowTemplate.Height = 24
        Me.D_maquinas_antiguas.Size = New System.Drawing.Size(499, 369)
        Me.D_maquinas_antiguas.TabIndex = 7
        '
        'D_antiguos_bares
        '
        Me.D_antiguos_bares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.D_antiguos_bares.Location = New System.Drawing.Point(16, 37)
        Me.D_antiguos_bares.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.D_antiguos_bares.Name = "D_antiguos_bares"
        Me.D_antiguos_bares.ReadOnly = True
        Me.D_antiguos_bares.RowTemplate.Height = 24
        Me.D_antiguos_bares.Size = New System.Drawing.Size(345, 296)
        Me.D_antiguos_bares.TabIndex = 6
        '
        'traslados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 553)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "traslados"
        Me.Text = "traslados"
        Me.TabControl1.ResumeLayout(False)
        Me.Tab_instalacion.ResumeLayout(False)
        Me.Tab_instalacion.PerformLayout()
        CType(Me.D_maquinas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D_bares, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_retiro.ResumeLayout(False)
        Me.Tab_retiro.PerformLayout()
        Me.buscar_por.ResumeLayout(False)
        Me.buscar_por.PerformLayout()
        CType(Me.D_maquina_desistalar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D_bar_desistalar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_traslados_antiguos.ResumeLayout(False)
        Me.Tab_traslados_antiguos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.D_maquinas_antiguas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D_antiguos_bares, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Tab_instalacion As System.Windows.Forms.TabPage
    Friend WithEvents B_instalar As System.Windows.Forms.Button
    Friend WithEvents f_instalacion As System.Windows.Forms.MonthCalendar
    Friend WithEvents D_maquinas As System.Windows.Forms.DataGridView
    Friend WithEvents D_bares As System.Windows.Forms.DataGridView
    Friend WithEvents Tab_retiro As System.Windows.Forms.TabPage
    Friend WithEvents B_retirar As System.Windows.Forms.Button
    Friend WithEvents retiron_mc As System.Windows.Forms.MonthCalendar
    Friend WithEvents D_maquina_desistalar As System.Windows.Forms.DataGridView
    Friend WithEvents D_bar_desistalar As System.Windows.Forms.DataGridView
    Friend WithEvents buscar_por As System.Windows.Forms.GroupBox
    Friend WithEvents r_maquinas As System.Windows.Forms.RadioButton
    Friend WithEvents r_bares As System.Windows.Forms.RadioButton
    Friend WithEvents Tab_traslados_antiguos As System.Windows.Forms.TabPage
    Friend WithEvents D_maquinas_antiguas As System.Windows.Forms.DataGridView
    Friend WithEvents D_antiguos_bares As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents r_maquinas2 As System.Windows.Forms.RadioButton
    Friend WithEvents r_bares2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents filtro_inslalar As System.Windows.Forms.ComboBox
    Friend WithEvents filtrar_instalacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents filtro_desistalar As System.Windows.Forms.ComboBox
    Friend WithEvents filtrar_desistalacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents filtro_desistalado As System.Windows.Forms.ComboBox
    Friend WithEvents filtrar_desistalado As System.Windows.Forms.ComboBox
End Class
