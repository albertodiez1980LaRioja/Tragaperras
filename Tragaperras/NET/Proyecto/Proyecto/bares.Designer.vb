<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bares
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
        Me.tab_bares = New System.Windows.Forms.TabPage
        Me.Label30 = New System.Windows.Forms.Label
        Me.filtro_valor = New System.Windows.Forms.ComboBox
        Me.nuevo = New System.Windows.Forms.Button
        Me.B_eliminar = New System.Windows.Forms.Button
        Me.m_i_c_año = New System.Windows.Forms.MaskedTextBox
        Me.m_f_l_dia = New System.Windows.Forms.MaskedTextBox
        Me.m_i_l_dia = New System.Windows.Forms.MaskedTextBox
        Me.m_f_c_dia = New System.Windows.Forms.MaskedTextBox
        Me.m_i_c_dia = New System.Windows.Forms.MaskedTextBox
        Me.m_f_l_mes = New System.Windows.Forms.MaskedTextBox
        Me.m_i_l_mes = New System.Windows.Forms.MaskedTextBox
        Me.m_f_c_mes = New System.Windows.Forms.MaskedTextBox
        Me.m_i_c_mes = New System.Windows.Forms.MaskedTextBox
        Me.m_f_l_año = New System.Windows.Forms.MaskedTextBox
        Me.m_i_l_año = New System.Windows.Forms.MaskedTextBox
        Me.m_f_c_año = New System.Windows.Forms.MaskedTextBox
        Me.m_cif = New System.Windows.Forms.MaskedTextBox
        Me.b_insertar = New System.Windows.Forms.Button
        Me.c_filtrar_por = New System.Windows.Forms.ComboBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.tipo_via = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.numero = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.calle = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.empresa = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.comunidad = New System.Windows.Forms.ComboBox
        Me.l = New System.Windows.Forms.Label
        Me.nombre_bar = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tab_dueños = New System.Windows.Forms.TabPage
        Me.nuevo_dueño = New System.Windows.Forms.Button
        Me.Label32 = New System.Windows.Forms.Label
        Me.filtro_valor_dueños = New System.Windows.Forms.ComboBox
        Me.c_mostrar_enparentados = New System.Windows.Forms.CheckBox
        Me.B_desenparentar = New System.Windows.Forms.Button
        Me.B_enparentar = New System.Windows.Forms.Button
        Me.B_eliminar_dueño = New System.Windows.Forms.Button
        Me.B_actualizar = New System.Windows.Forms.Button
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.t_dni_propietario = New System.Windows.Forms.TextBox
        Me.t_nombre_propietario = New System.Windows.Forms.TextBox
        Me.t_telefono_dni = New System.Windows.Forms.MaskedTextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.filtrar_por = New System.Windows.Forms.ComboBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.DataGridView3 = New System.Windows.Forms.DataGridView
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.TabControl1.SuspendLayout()
        Me.tab_bares.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_dueños.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_bares)
        Me.TabControl1.Controls.Add(Me.tab_dueños)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1064, 799)
        Me.TabControl1.TabIndex = 0
        '
        'tab_bares
        '
        Me.tab_bares.Controls.Add(Me.Label30)
        Me.tab_bares.Controls.Add(Me.filtro_valor)
        Me.tab_bares.Controls.Add(Me.nuevo)
        Me.tab_bares.Controls.Add(Me.B_eliminar)
        Me.tab_bares.Controls.Add(Me.m_i_c_año)
        Me.tab_bares.Controls.Add(Me.m_f_l_dia)
        Me.tab_bares.Controls.Add(Me.m_i_l_dia)
        Me.tab_bares.Controls.Add(Me.m_f_c_dia)
        Me.tab_bares.Controls.Add(Me.m_i_c_dia)
        Me.tab_bares.Controls.Add(Me.m_f_l_mes)
        Me.tab_bares.Controls.Add(Me.m_i_l_mes)
        Me.tab_bares.Controls.Add(Me.m_f_c_mes)
        Me.tab_bares.Controls.Add(Me.m_i_c_mes)
        Me.tab_bares.Controls.Add(Me.m_f_l_año)
        Me.tab_bares.Controls.Add(Me.m_i_l_año)
        Me.tab_bares.Controls.Add(Me.m_f_c_año)
        Me.tab_bares.Controls.Add(Me.m_cif)
        Me.tab_bares.Controls.Add(Me.b_insertar)
        Me.tab_bares.Controls.Add(Me.c_filtrar_por)
        Me.tab_bares.Controls.Add(Me.Label23)
        Me.tab_bares.Controls.Add(Me.DataGridView1)
        Me.tab_bares.Controls.Add(Me.Label20)
        Me.tab_bares.Controls.Add(Me.Label21)
        Me.tab_bares.Controls.Add(Me.Label22)
        Me.tab_bares.Controls.Add(Me.Label17)
        Me.tab_bares.Controls.Add(Me.Label18)
        Me.tab_bares.Controls.Add(Me.Label19)
        Me.tab_bares.Controls.Add(Me.Label14)
        Me.tab_bares.Controls.Add(Me.Label15)
        Me.tab_bares.Controls.Add(Me.Label16)
        Me.tab_bares.Controls.Add(Me.Label13)
        Me.tab_bares.Controls.Add(Me.Label12)
        Me.tab_bares.Controls.Add(Me.Label11)
        Me.tab_bares.Controls.Add(Me.Label10)
        Me.tab_bares.Controls.Add(Me.Label9)
        Me.tab_bares.Controls.Add(Me.Label8)
        Me.tab_bares.Controls.Add(Me.Label7)
        Me.tab_bares.Controls.Add(Me.tipo_via)
        Me.tab_bares.Controls.Add(Me.Label6)
        Me.tab_bares.Controls.Add(Me.numero)
        Me.tab_bares.Controls.Add(Me.Label5)
        Me.tab_bares.Controls.Add(Me.calle)
        Me.tab_bares.Controls.Add(Me.Label4)
        Me.tab_bares.Controls.Add(Me.empresa)
        Me.tab_bares.Controls.Add(Me.Label3)
        Me.tab_bares.Controls.Add(Me.comunidad)
        Me.tab_bares.Controls.Add(Me.l)
        Me.tab_bares.Controls.Add(Me.nombre_bar)
        Me.tab_bares.Controls.Add(Me.Label2)
        Me.tab_bares.Controls.Add(Me.Label1)
        Me.tab_bares.Location = New System.Drawing.Point(4, 25)
        Me.tab_bares.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tab_bares.Name = "tab_bares"
        Me.tab_bares.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tab_bares.Size = New System.Drawing.Size(1056, 770)
        Me.tab_bares.TabIndex = 0
        Me.tab_bares.Text = "Bares"
        Me.tab_bares.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(575, 348)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(99, 17)
        Me.Label30.TabIndex = 93
        Me.Label30.Text = "Valor del filtro:"
        '
        'filtro_valor
        '
        Me.filtro_valor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.filtro_valor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.filtro_valor.FormattingEnabled = True
        Me.filtro_valor.Location = New System.Drawing.Point(685, 345)
        Me.filtro_valor.Name = "filtro_valor"
        Me.filtro_valor.Size = New System.Drawing.Size(199, 24)
        Me.filtro_valor.TabIndex = 92
        '
        'nuevo
        '
        Me.nuevo.Location = New System.Drawing.Point(741, 148)
        Me.nuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(177, 54)
        Me.nuevo.TabIndex = 91
        Me.nuevo.Text = "Nuevo"
        Me.nuevo.UseVisualStyleBackColor = True
        '
        'B_eliminar
        '
        Me.B_eliminar.Location = New System.Drawing.Point(741, 38)
        Me.B_eliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.B_eliminar.Name = "B_eliminar"
        Me.B_eliminar.Size = New System.Drawing.Size(177, 54)
        Me.B_eliminar.TabIndex = 90
        Me.B_eliminar.Text = "Eliminar"
        Me.B_eliminar.UseVisualStyleBackColor = True
        '
        'm_i_c_año
        '
        Me.m_i_c_año.Location = New System.Drawing.Point(412, 210)
        Me.m_i_c_año.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.m_i_c_año.Mask = "9999"
        Me.m_i_c_año.Name = "m_i_c_año"
        Me.m_i_c_año.Size = New System.Drawing.Size(57, 22)
        Me.m_i_c_año.TabIndex = 7
        '
        'm_f_l_dia
        '
        Me.m_f_l_dia.Location = New System.Drawing.Point(212, 341)
        Me.m_f_l_dia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.m_f_l_dia.Mask = "99"
        Me.m_f_l_dia.Name = "m_f_l_dia"
        Me.m_f_l_dia.Size = New System.Drawing.Size(57, 22)
        Me.m_f_l_dia.TabIndex = 14
        '
        'm_i_l_dia
        '
        Me.m_i_l_dia.Location = New System.Drawing.Point(212, 297)
        Me.m_i_l_dia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.m_i_l_dia.Mask = "99"
        Me.m_i_l_dia.Name = "m_i_l_dia"
        Me.m_i_l_dia.Size = New System.Drawing.Size(57, 22)
        Me.m_i_l_dia.TabIndex = 11
        '
        'm_f_c_dia
        '
        Me.m_f_c_dia.Location = New System.Drawing.Point(211, 254)
        Me.m_f_c_dia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.m_f_c_dia.Mask = "99"
        Me.m_f_c_dia.Name = "m_f_c_dia"
        Me.m_f_c_dia.Size = New System.Drawing.Size(57, 22)
        Me.m_f_c_dia.TabIndex = 8
        '
        'm_i_c_dia
        '
        Me.m_i_c_dia.Location = New System.Drawing.Point(212, 210)
        Me.m_i_c_dia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.m_i_c_dia.Mask = "99"
        Me.m_i_c_dia.Name = "m_i_c_dia"
        Me.m_i_c_dia.Size = New System.Drawing.Size(57, 22)
        Me.m_i_c_dia.TabIndex = 5
        '
        'm_f_l_mes
        '
        Me.m_f_l_mes.Location = New System.Drawing.Point(311, 341)
        Me.m_f_l_mes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.m_f_l_mes.Mask = "99"
        Me.m_f_l_mes.Name = "m_f_l_mes"
        Me.m_f_l_mes.Size = New System.Drawing.Size(57, 22)
        Me.m_f_l_mes.TabIndex = 15
        '
        'm_i_l_mes
        '
        Me.m_i_l_mes.Location = New System.Drawing.Point(311, 297)
        Me.m_i_l_mes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.m_i_l_mes.Mask = "99"
        Me.m_i_l_mes.Name = "m_i_l_mes"
        Me.m_i_l_mes.Size = New System.Drawing.Size(57, 22)
        Me.m_i_l_mes.TabIndex = 12
        '
        'm_f_c_mes
        '
        Me.m_f_c_mes.Location = New System.Drawing.Point(311, 254)
        Me.m_f_c_mes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.m_f_c_mes.Mask = "99"
        Me.m_f_c_mes.Name = "m_f_c_mes"
        Me.m_f_c_mes.Size = New System.Drawing.Size(57, 22)
        Me.m_f_c_mes.TabIndex = 9
        '
        'm_i_c_mes
        '
        Me.m_i_c_mes.Location = New System.Drawing.Point(311, 210)
        Me.m_i_c_mes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.m_i_c_mes.Mask = "99"
        Me.m_i_c_mes.Name = "m_i_c_mes"
        Me.m_i_c_mes.Size = New System.Drawing.Size(57, 22)
        Me.m_i_c_mes.TabIndex = 6
        '
        'm_f_l_año
        '
        Me.m_f_l_año.Location = New System.Drawing.Point(412, 341)
        Me.m_f_l_año.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.m_f_l_año.Mask = "9999"
        Me.m_f_l_año.Name = "m_f_l_año"
        Me.m_f_l_año.Size = New System.Drawing.Size(57, 22)
        Me.m_f_l_año.TabIndex = 16
        '
        'm_i_l_año
        '
        Me.m_i_l_año.Location = New System.Drawing.Point(412, 297)
        Me.m_i_l_año.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.m_i_l_año.Mask = "9999"
        Me.m_i_l_año.Name = "m_i_l_año"
        Me.m_i_l_año.Size = New System.Drawing.Size(57, 22)
        Me.m_i_l_año.TabIndex = 13
        '
        'm_f_c_año
        '
        Me.m_f_c_año.Location = New System.Drawing.Point(412, 254)
        Me.m_f_c_año.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.m_f_c_año.Mask = "9999"
        Me.m_f_c_año.Name = "m_f_c_año"
        Me.m_f_c_año.Size = New System.Drawing.Size(57, 22)
        Me.m_f_c_año.TabIndex = 10
        '
        'm_cif
        '
        Me.m_cif.Location = New System.Drawing.Point(212, 76)
        Me.m_cif.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.m_cif.Mask = "999999999"
        Me.m_cif.Name = "m_cif"
        Me.m_cif.Size = New System.Drawing.Size(195, 22)
        Me.m_cif.TabIndex = 2
        '
        'b_insertar
        '
        Me.b_insertar.Location = New System.Drawing.Point(493, 38)
        Me.b_insertar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.b_insertar.Name = "b_insertar"
        Me.b_insertar.Size = New System.Drawing.Size(184, 54)
        Me.b_insertar.TabIndex = 20
        Me.b_insertar.Text = "Insertar/actualizar"
        Me.b_insertar.UseVisualStyleBackColor = True
        '
        'c_filtrar_por
        '
        Me.c_filtrar_por.FormattingEnabled = True
        Me.c_filtrar_por.Items.AddRange(New Object() {"todos", "empresa", "comunidad"})
        Me.c_filtrar_por.Location = New System.Drawing.Point(685, 278)
        Me.c_filtrar_por.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.c_filtrar_por.Name = "c_filtrar_por"
        Me.c_filtrar_por.Size = New System.Drawing.Size(199, 24)
        Me.c_filtrar_por.TabIndex = 21
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(575, 281)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(73, 17)
        Me.Label23.TabIndex = 89
        Me.Label23.Text = "Filtrar por:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(35, 534)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(973, 222)
        Me.DataGridView1.TabIndex = 88
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(375, 345)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(32, 17)
        Me.Label20.TabIndex = 87
        Me.Label20.Text = "año"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(276, 345)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(34, 17)
        Me.Label21.TabIndex = 86
        Me.Label21.Text = "mes"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(177, 345)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(27, 17)
        Me.Label22.TabIndex = 85
        Me.Label22.Text = "dia"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(375, 300)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 17)
        Me.Label17.TabIndex = 81
        Me.Label17.Text = "año"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(276, 300)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(34, 17)
        Me.Label18.TabIndex = 80
        Me.Label18.Text = "mes"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(177, 300)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(27, 17)
        Me.Label19.TabIndex = 79
        Me.Label19.Text = "dia"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(375, 256)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 17)
        Me.Label14.TabIndex = 75
        Me.Label14.Text = "año"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(276, 256)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 17)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "mes"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(177, 256)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(27, 17)
        Me.Label16.TabIndex = 73
        Me.Label16.Text = "dia"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(375, 214)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 17)
        Me.Label13.TabIndex = 69
        Me.Label13.Text = "año"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(276, 214)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 17)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "mes"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(177, 214)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 17)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "dia"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(49, 345)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 17)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Fin licencia"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(49, 300)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 17)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Fecha licencia"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(49, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 17)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Contrato finalizar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(49, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 17)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Fecha contrato"
        '
        'tipo_via
        '
        Me.tipo_via.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tipo_via.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.tipo_via.FormattingEnabled = True
        Me.tipo_via.Items.AddRange(New Object() {"Calle", "Plaza", "Parque"})
        Me.tipo_via.Location = New System.Drawing.Point(211, 482)
        Me.tipo_via.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tipo_via.Name = "tipo_via"
        Me.tipo_via.Size = New System.Drawing.Size(199, 24)
        Me.tipo_via.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(101, 482)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Tipo vía"
        '
        'numero
        '
        Me.numero.Location = New System.Drawing.Point(211, 437)
        Me.numero.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.numero.Name = "numero"
        Me.numero.Size = New System.Drawing.Size(199, 22)
        Me.numero.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(101, 437)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Numero"
        '
        'calle
        '
        Me.calle.Location = New System.Drawing.Point(211, 391)
        Me.calle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.calle.Name = "calle"
        Me.calle.Size = New System.Drawing.Size(199, 22)
        Me.calle.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(101, 391)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Calle"
        '
        'empresa
        '
        Me.empresa.FormattingEnabled = True
        Me.empresa.Location = New System.Drawing.Point(211, 164)
        Me.empresa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.empresa.Name = "empresa"
        Me.empresa.Size = New System.Drawing.Size(199, 24)
        Me.empresa.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Empresa"
        '
        'comunidad
        '
        Me.comunidad.FormattingEnabled = True
        Me.comunidad.Location = New System.Drawing.Point(211, 121)
        Me.comunidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.comunidad.Name = "comunidad"
        Me.comunidad.Size = New System.Drawing.Size(199, 24)
        Me.comunidad.TabIndex = 3
        '
        'l
        '
        Me.l.AutoSize = True
        Me.l.Location = New System.Drawing.Point(101, 124)
        Me.l.Name = "l"
        Me.l.Size = New System.Drawing.Size(79, 17)
        Me.l.TabIndex = 50
        Me.l.Text = "Comunidad"
        '
        'nombre_bar
        '
        Me.nombre_bar.Location = New System.Drawing.Point(211, 38)
        Me.nombre_bar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nombre_bar.Name = "nombre_bar"
        Me.nombre_bar.Size = New System.Drawing.Size(199, 22)
        Me.nombre_bar.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 17)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "CIF"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Nombre de bar"
        '
        'tab_dueños
        '
        Me.tab_dueños.Controls.Add(Me.nuevo_dueño)
        Me.tab_dueños.Controls.Add(Me.Label32)
        Me.tab_dueños.Controls.Add(Me.filtro_valor_dueños)
        Me.tab_dueños.Controls.Add(Me.c_mostrar_enparentados)
        Me.tab_dueños.Controls.Add(Me.B_desenparentar)
        Me.tab_dueños.Controls.Add(Me.B_enparentar)
        Me.tab_dueños.Controls.Add(Me.B_eliminar_dueño)
        Me.tab_dueños.Controls.Add(Me.B_actualizar)
        Me.tab_dueños.Controls.Add(Me.Label29)
        Me.tab_dueños.Controls.Add(Me.Label28)
        Me.tab_dueños.Controls.Add(Me.t_dni_propietario)
        Me.tab_dueños.Controls.Add(Me.t_nombre_propietario)
        Me.tab_dueños.Controls.Add(Me.t_telefono_dni)
        Me.tab_dueños.Controls.Add(Me.Label27)
        Me.tab_dueños.Controls.Add(Me.Label26)
        Me.tab_dueños.Controls.Add(Me.Label25)
        Me.tab_dueños.Controls.Add(Me.filtrar_por)
        Me.tab_dueños.Controls.Add(Me.Label24)
        Me.tab_dueños.Controls.Add(Me.DataGridView3)
        Me.tab_dueños.Controls.Add(Me.DataGridView2)
        Me.tab_dueños.Location = New System.Drawing.Point(4, 25)
        Me.tab_dueños.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tab_dueños.Name = "tab_dueños"
        Me.tab_dueños.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tab_dueños.Size = New System.Drawing.Size(1056, 770)
        Me.tab_dueños.TabIndex = 1
        Me.tab_dueños.Text = "Dueños de bares"
        Me.tab_dueños.UseVisualStyleBackColor = True
        '
        'nuevo_dueño
        '
        Me.nuevo_dueño.Location = New System.Drawing.Point(690, 679)
        Me.nuevo_dueño.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nuevo_dueño.Name = "nuevo_dueño"
        Me.nuevo_dueño.Size = New System.Drawing.Size(153, 53)
        Me.nuevo_dueño.TabIndex = 112
        Me.nuevo_dueño.Text = "Nuevo dueño"
        Me.nuevo_dueño.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(33, 527)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(99, 17)
        Me.Label32.TabIndex = 111
        Me.Label32.Text = "Valor del filtro:"
        '
        'filtro_valor_dueños
        '
        Me.filtro_valor_dueños.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.filtro_valor_dueños.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.filtro_valor_dueños.FormattingEnabled = True
        Me.filtro_valor_dueños.Items.AddRange(New Object() {"ninguno", "empresa", "comunidad", "dueño"})
        Me.filtro_valor_dueños.Location = New System.Drawing.Point(137, 524)
        Me.filtro_valor_dueños.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.filtro_valor_dueños.Name = "filtro_valor_dueños"
        Me.filtro_valor_dueños.Size = New System.Drawing.Size(199, 24)
        Me.filtro_valor_dueños.TabIndex = 109
        '
        'c_mostrar_enparentados
        '
        Me.c_mostrar_enparentados.AutoSize = True
        Me.c_mostrar_enparentados.Location = New System.Drawing.Point(424, 636)
        Me.c_mostrar_enparentados.Name = "c_mostrar_enparentados"
        Me.c_mostrar_enparentados.Size = New System.Drawing.Size(192, 21)
        Me.c_mostrar_enparentados.TabIndex = 108
        Me.c_mostrar_enparentados.Text = "Mostrar los enparentados"
        Me.c_mostrar_enparentados.UseVisualStyleBackColor = True
        '
        'B_desenparentar
        '
        Me.B_desenparentar.Location = New System.Drawing.Point(424, 531)
        Me.B_desenparentar.Name = "B_desenparentar"
        Me.B_desenparentar.Size = New System.Drawing.Size(162, 68)
        Me.B_desenparentar.TabIndex = 107
        Me.B_desenparentar.Text = "Desenparentar"
        Me.B_desenparentar.UseVisualStyleBackColor = True
        '
        'B_enparentar
        '
        Me.B_enparentar.Location = New System.Drawing.Point(424, 435)
        Me.B_enparentar.Name = "B_enparentar"
        Me.B_enparentar.Size = New System.Drawing.Size(162, 68)
        Me.B_enparentar.TabIndex = 106
        Me.B_enparentar.Text = "Enparentar"
        Me.B_enparentar.UseVisualStyleBackColor = True
        '
        'B_eliminar_dueño
        '
        Me.B_eliminar_dueño.Location = New System.Drawing.Point(877, 591)
        Me.B_eliminar_dueño.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.B_eliminar_dueño.Name = "B_eliminar_dueño"
        Me.B_eliminar_dueño.Size = New System.Drawing.Size(153, 53)
        Me.B_eliminar_dueño.TabIndex = 105
        Me.B_eliminar_dueño.Text = "Elimininar"
        Me.B_eliminar_dueño.UseVisualStyleBackColor = True
        '
        'B_actualizar
        '
        Me.B_actualizar.Location = New System.Drawing.Point(690, 591)
        Me.B_actualizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.B_actualizar.Name = "B_actualizar"
        Me.B_actualizar.Size = New System.Drawing.Size(153, 53)
        Me.B_actualizar.TabIndex = 103
        Me.B_actualizar.Text = "Insertar/actualizar"
        Me.B_actualizar.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(648, 23)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(84, 17)
        Me.Label29.TabIndex = 103
        Me.Label29.Text = "Propietarios"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(33, 23)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(45, 17)
        Me.Label28.TabIndex = 102
        Me.Label28.Text = "Bares"
        '
        't_dni_propietario
        '
        Me.t_dni_propietario.Location = New System.Drawing.Point(784, 483)
        Me.t_dni_propietario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.t_dni_propietario.Name = "t_dni_propietario"
        Me.t_dni_propietario.Size = New System.Drawing.Size(100, 22)
        Me.t_dni_propietario.TabIndex = 101
        '
        't_nombre_propietario
        '
        Me.t_nombre_propietario.Location = New System.Drawing.Point(784, 445)
        Me.t_nombre_propietario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.t_nombre_propietario.Name = "t_nombre_propietario"
        Me.t_nombre_propietario.Size = New System.Drawing.Size(100, 22)
        Me.t_nombre_propietario.TabIndex = 100
        '
        't_telefono_dni
        '
        Me.t_telefono_dni.Location = New System.Drawing.Point(784, 524)
        Me.t_telefono_dni.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.t_telefono_dni.Mask = "99999999999999"
        Me.t_telefono_dni.Name = "t_telefono_dni"
        Me.t_telefono_dni.Size = New System.Drawing.Size(100, 22)
        Me.t_telefono_dni.TabIndex = 102
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(690, 527)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 17)
        Me.Label27.TabIndex = 97
        Me.Label27.Text = "Teléfono"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(690, 486)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(31, 17)
        Me.Label26.TabIndex = 96
        Me.Label26.Text = "DNI"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(690, 448)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(58, 17)
        Me.Label25.TabIndex = 95
        Me.Label25.Text = "Nombre"
        '
        'filtrar_por
        '
        Me.filtrar_por.FormattingEnabled = True
        Me.filtrar_por.Items.AddRange(New Object() {"ninguno", "empresa", "comunidad", "dueño", "bar"})
        Me.filtrar_por.Location = New System.Drawing.Point(137, 430)
        Me.filtrar_por.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.filtrar_por.Name = "filtrar_por"
        Me.filtrar_por.Size = New System.Drawing.Size(199, 24)
        Me.filtrar_por.TabIndex = 93
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(33, 433)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(73, 17)
        Me.Label24.TabIndex = 92
        Me.Label24.Text = "Filtrar por:"
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(652, 57)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(369, 353)
        Me.DataGridView3.TabIndex = 3
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(36, 57)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(550, 353)
        Me.DataGridView2.TabIndex = 2
        '
        'bares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 799)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "bares"
        Me.Text = "bares"
        Me.TabControl1.ResumeLayout(False)
        Me.tab_bares.ResumeLayout(False)
        Me.tab_bares.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_dueños.ResumeLayout(False)
        Me.tab_dueños.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tab_bares As System.Windows.Forms.TabPage
    Friend WithEvents tab_dueños As System.Windows.Forms.TabPage
    Friend WithEvents c_filtrar_por As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tipo_via As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents numero As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents calle As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents empresa As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents comunidad As System.Windows.Forms.ComboBox
    Friend WithEvents l As System.Windows.Forms.Label
    Friend WithEvents nombre_bar As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents t_telefono_dni As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents filtrar_por As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents t_dni_propietario As System.Windows.Forms.TextBox
    Friend WithEvents t_nombre_propietario As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents B_actualizar As System.Windows.Forms.Button
    Friend WithEvents b_insertar As System.Windows.Forms.Button
    Friend WithEvents m_f_l_dia As System.Windows.Forms.MaskedTextBox
    Friend WithEvents m_i_l_dia As System.Windows.Forms.MaskedTextBox
    Friend WithEvents m_f_c_dia As System.Windows.Forms.MaskedTextBox
    Friend WithEvents m_i_c_dia As System.Windows.Forms.MaskedTextBox
    Friend WithEvents m_f_l_mes As System.Windows.Forms.MaskedTextBox
    Friend WithEvents m_i_l_mes As System.Windows.Forms.MaskedTextBox
    Friend WithEvents m_f_c_mes As System.Windows.Forms.MaskedTextBox
    Friend WithEvents m_i_c_mes As System.Windows.Forms.MaskedTextBox
    Friend WithEvents m_f_l_año As System.Windows.Forms.MaskedTextBox
    Friend WithEvents m_i_l_año As System.Windows.Forms.MaskedTextBox
    Friend WithEvents m_f_c_año As System.Windows.Forms.MaskedTextBox
    Friend WithEvents m_cif As System.Windows.Forms.MaskedTextBox
    Friend WithEvents m_i_c_año As System.Windows.Forms.MaskedTextBox
    Friend WithEvents B_eliminar As System.Windows.Forms.Button
    Friend WithEvents B_eliminar_dueño As System.Windows.Forms.Button
    Friend WithEvents c_mostrar_enparentados As System.Windows.Forms.CheckBox
    Friend WithEvents B_desenparentar As System.Windows.Forms.Button
    Friend WithEvents B_enparentar As System.Windows.Forms.Button
    Friend WithEvents nuevo As System.Windows.Forms.Button
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents filtro_valor As System.Windows.Forms.ComboBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents filtro_valor_dueños As System.Windows.Forms.ComboBox
    Friend WithEvents nuevo_dueño As System.Windows.Forms.Button
End Class
