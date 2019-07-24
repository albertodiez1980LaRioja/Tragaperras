<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class albaranes
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
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.insertar_albaran = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.total_contadores = New System.Windows.Forms.TextBox
        Me.debe = New System.Windows.Forms.TextBox
        Me.pre_establecimiento = New System.Windows.Forms.TextBox
        Me.operadora_total = New System.Windows.Forms.TextBox
        Me.Establecimiento_total = New System.Windows.Forms.TextBox
        Me.paga = New System.Windows.Forms.TextBox
        Me.pre_operadora = New System.Windows.Forms.TextBox
        Me.efectivo = New System.Windows.Forms.TextBox
        Me.x_contadores = New System.Windows.Forms.TextBox
        Me.tasas_pagadas = New System.Windows.Forms.MaskedTextBox
        Me.tasa2 = New System.Windows.Forms.MaskedTextBox
        Me.tasa1 = New System.Windows.Forms.MaskedTextBox
        Me.s_total = New System.Windows.Forms.MaskedTextBox
        Me.s_anterior = New System.Windows.Forms.MaskedTextBox
        Me.s_ultimas = New System.Windows.Forms.MaskedTextBox
        Me.e_total = New System.Windows.Forms.MaskedTextBox
        Me.e_anterior = New System.Windows.Forms.MaskedTextBox
        Me.e_ultimas = New System.Windows.Forms.MaskedTextBox
        Me.nuevo = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.observaciones = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.fecha = New System.Windows.Forms.DateTimePicker
        Me.Establecimiento = New System.Windows.Forms.TextBox
        Me.recaudador = New System.Windows.Forms.TextBox
        Me.maquina = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.guardar = New System.Windows.Forms.Button
        Me.lista_albaranes = New System.Windows.Forms.TabPage
        Me.eliminar = New System.Windows.Forms.Button
        Me.modificar = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.filtrar_comunidad = New System.Windows.Forms.ComboBox
        Me.filtrar_bar = New System.Windows.Forms.ComboBox
        Me.filtrar_empresa = New System.Windows.Forms.ComboBox
        Me.mostrar_ultimos = New System.Windows.Forms.CheckBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.insertar_albaran.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.lista_albaranes.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'insertar_albaran
        '
        Me.insertar_albaran.Controls.Add(Me.TabPage1)
        Me.insertar_albaran.Controls.Add(Me.lista_albaranes)
        Me.insertar_albaran.Dock = System.Windows.Forms.DockStyle.Fill
        Me.insertar_albaran.Location = New System.Drawing.Point(0, 0)
        Me.insertar_albaran.Name = "insertar_albaran"
        Me.insertar_albaran.SelectedIndex = 0
        Me.insertar_albaran.Size = New System.Drawing.Size(860, 688)
        Me.insertar_albaran.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.total_contadores)
        Me.TabPage1.Controls.Add(Me.debe)
        Me.TabPage1.Controls.Add(Me.pre_establecimiento)
        Me.TabPage1.Controls.Add(Me.operadora_total)
        Me.TabPage1.Controls.Add(Me.Establecimiento_total)
        Me.TabPage1.Controls.Add(Me.paga)
        Me.TabPage1.Controls.Add(Me.pre_operadora)
        Me.TabPage1.Controls.Add(Me.efectivo)
        Me.TabPage1.Controls.Add(Me.x_contadores)
        Me.TabPage1.Controls.Add(Me.tasas_pagadas)
        Me.TabPage1.Controls.Add(Me.tasa2)
        Me.TabPage1.Controls.Add(Me.tasa1)
        Me.TabPage1.Controls.Add(Me.s_total)
        Me.TabPage1.Controls.Add(Me.s_anterior)
        Me.TabPage1.Controls.Add(Me.s_ultimas)
        Me.TabPage1.Controls.Add(Me.e_total)
        Me.TabPage1.Controls.Add(Me.e_anterior)
        Me.TabPage1.Controls.Add(Me.e_ultimas)
        Me.TabPage1.Controls.Add(Me.nuevo)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.observaciones)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.fecha)
        Me.TabPage1.Controls.Add(Me.Establecimiento)
        Me.TabPage1.Controls.Add(Me.recaudador)
        Me.TabPage1.Controls.Add(Me.maquina)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.guardar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(852, 659)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Insertar albaran"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'total_contadores
        '
        Me.total_contadores.Location = New System.Drawing.Point(511, 148)
        Me.total_contadores.Name = "total_contadores"
        Me.total_contadores.Size = New System.Drawing.Size(170, 22)
        Me.total_contadores.TabIndex = 116
        '
        'debe
        '
        Me.debe.Location = New System.Drawing.Point(301, 531)
        Me.debe.Name = "debe"
        Me.debe.Size = New System.Drawing.Size(144, 22)
        Me.debe.TabIndex = 115
        '
        'pre_establecimiento
        '
        Me.pre_establecimiento.Location = New System.Drawing.Point(275, 369)
        Me.pre_establecimiento.Name = "pre_establecimiento"
        Me.pre_establecimiento.Size = New System.Drawing.Size(170, 22)
        Me.pre_establecimiento.TabIndex = 114
        '
        'operadora_total
        '
        Me.operadora_total.Location = New System.Drawing.Point(25, 457)
        Me.operadora_total.Name = "operadora_total"
        Me.operadora_total.Size = New System.Drawing.Size(170, 22)
        Me.operadora_total.TabIndex = 113
        '
        'Establecimiento_total
        '
        Me.Establecimiento_total.Location = New System.Drawing.Point(275, 457)
        Me.Establecimiento_total.Name = "Establecimiento_total"
        Me.Establecimiento_total.Size = New System.Drawing.Size(170, 22)
        Me.Establecimiento_total.TabIndex = 112
        '
        'paga
        '
        Me.paga.Location = New System.Drawing.Point(53, 531)
        Me.paga.Name = "paga"
        Me.paga.Size = New System.Drawing.Size(142, 22)
        Me.paga.TabIndex = 111
        '
        'pre_operadora
        '
        Me.pre_operadora.Location = New System.Drawing.Point(25, 369)
        Me.pre_operadora.Name = "pre_operadora"
        Me.pre_operadora.Size = New System.Drawing.Size(170, 22)
        Me.pre_operadora.TabIndex = 110
        '
        'efectivo
        '
        Me.efectivo.Location = New System.Drawing.Point(511, 250)
        Me.efectivo.Name = "efectivo"
        Me.efectivo.Size = New System.Drawing.Size(170, 22)
        Me.efectivo.TabIndex = 109
        '
        'x_contadores
        '
        Me.x_contadores.Location = New System.Drawing.Point(511, 201)
        Me.x_contadores.Name = "x_contadores"
        Me.x_contadores.Size = New System.Drawing.Size(170, 22)
        Me.x_contadores.TabIndex = 108
        '
        'tasas_pagadas
        '
        Me.tasas_pagadas.Location = New System.Drawing.Point(130, 583)
        Me.tasas_pagadas.Mask = "999999999"
        Me.tasas_pagadas.Name = "tasas_pagadas"
        Me.tasas_pagadas.Size = New System.Drawing.Size(144, 22)
        Me.tasas_pagadas.TabIndex = 107
        '
        'tasa2
        '
        Me.tasa2.Location = New System.Drawing.Point(294, 412)
        Me.tasa2.Mask = "999999999"
        Me.tasa2.Name = "tasa2"
        Me.tasa2.Size = New System.Drawing.Size(151, 22)
        Me.tasa2.TabIndex = 104
        '
        'tasa1
        '
        Me.tasa1.Location = New System.Drawing.Point(44, 416)
        Me.tasa1.Mask = "999999999"
        Me.tasa1.Name = "tasa1"
        Me.tasa1.Size = New System.Drawing.Size(151, 22)
        Me.tasa1.TabIndex = 9
        '
        's_total
        '
        Me.s_total.Location = New System.Drawing.Point(275, 250)
        Me.s_total.Mask = "999999999"
        Me.s_total.Name = "s_total"
        Me.s_total.Size = New System.Drawing.Size(170, 22)
        Me.s_total.TabIndex = 95
        '
        's_anterior
        '
        Me.s_anterior.Location = New System.Drawing.Point(275, 201)
        Me.s_anterior.Mask = "999999999"
        Me.s_anterior.Name = "s_anterior"
        Me.s_anterior.Size = New System.Drawing.Size(170, 22)
        Me.s_anterior.TabIndex = 8
        '
        's_ultimas
        '
        Me.s_ultimas.Location = New System.Drawing.Point(275, 148)
        Me.s_ultimas.Mask = "999999999"
        Me.s_ultimas.Name = "s_ultimas"
        Me.s_ultimas.Size = New System.Drawing.Size(170, 22)
        Me.s_ultimas.TabIndex = 7
        '
        'e_total
        '
        Me.e_total.Location = New System.Drawing.Point(27, 250)
        Me.e_total.Mask = "999999999"
        Me.e_total.Name = "e_total"
        Me.e_total.Size = New System.Drawing.Size(170, 22)
        Me.e_total.TabIndex = 92
        '
        'e_anterior
        '
        Me.e_anterior.Location = New System.Drawing.Point(27, 201)
        Me.e_anterior.Mask = "999999999"
        Me.e_anterior.Name = "e_anterior"
        Me.e_anterior.Size = New System.Drawing.Size(170, 22)
        Me.e_anterior.TabIndex = 6
        '
        'e_ultimas
        '
        Me.e_ultimas.Location = New System.Drawing.Point(27, 148)
        Me.e_ultimas.Mask = "999999999"
        Me.e_ultimas.Name = "e_ultimas"
        Me.e_ultimas.Size = New System.Drawing.Size(170, 22)
        Me.e_ultimas.TabIndex = 5
        '
        'nuevo
        '
        Me.nuevo.Location = New System.Drawing.Point(556, 571)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(182, 78)
        Me.nuevo.TabIndex = 14
        Me.nuevo.Text = "Nuevo"
        Me.nuevo.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(-1, 586)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 17)
        Me.Label14.TabIndex = 87
        Me.Label14.Text = "Tasas pagadas"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(698, 201)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 17)
        Me.Label13.TabIndex = 86
        Me.Label13.Text = "X contadores"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(698, 250)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 17)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "Efectivo maquina"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(484, 334)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 17)
        Me.Label11.TabIndex = 84
        Me.Label11.Text = "Observaciones"
        '
        'observaciones
        '
        Me.observaciones.Location = New System.Drawing.Point(487, 369)
        Me.observaciones.Multiline = True
        Me.observaciones.Name = "observaciones"
        Me.observaciones.Size = New System.Drawing.Size(333, 181)
        Me.observaciones.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(-1, 531)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 17)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "Paga"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(253, 531)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 17)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "Debe"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(272, 419)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 17)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "-"
        '
        'fecha
        '
        Me.fecha.Location = New System.Drawing.Point(566, 64)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(200, 22)
        Me.fecha.TabIndex = 4
        '
        'Establecimiento
        '
        Me.Establecimiento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Establecimiento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Establecimiento.Location = New System.Drawing.Point(566, 18)
        Me.Establecimiento.Name = "Establecimiento"
        Me.Establecimiento.Size = New System.Drawing.Size(160, 22)
        Me.Establecimiento.TabIndex = 3
        '
        'recaudador
        '
        Me.recaudador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.recaudador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.recaudador.Location = New System.Drawing.Point(114, 64)
        Me.recaudador.Name = "recaudador"
        Me.recaudador.Size = New System.Drawing.Size(160, 22)
        Me.recaudador.TabIndex = 2
        '
        'maquina
        '
        Me.maquina.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.maquina.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.maquina.Location = New System.Drawing.Point(114, 21)
        Me.maquina.Name = "maquina"
        Me.maquina.Size = New System.Drawing.Size(160, 22)
        Me.maquina.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(24, 417)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(16, 17)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "+"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(298, 334)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(124, 17)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "E. Establecimiento"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(50, 334)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 17)
        Me.Label17.TabIndex = 56
        Me.Label17.Text = "E. operadora"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(570, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 17)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "SALDO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(324, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 17)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "SALIDAS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(76, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 17)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "ENTRADAS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(454, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 17)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Recaudador"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(453, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 17)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Establecimiento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Maquina"
        '
        'guardar
        '
        Me.guardar.Location = New System.Drawing.Point(338, 571)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(182, 78)
        Me.guardar.TabIndex = 13
        Me.guardar.Text = "Guardar"
        Me.guardar.UseVisualStyleBackColor = True
        '
        'lista_albaranes
        '
        Me.lista_albaranes.Controls.Add(Me.eliminar)
        Me.lista_albaranes.Controls.Add(Me.modificar)
        Me.lista_albaranes.Controls.Add(Me.Label20)
        Me.lista_albaranes.Controls.Add(Me.Label19)
        Me.lista_albaranes.Controls.Add(Me.Label18)
        Me.lista_albaranes.Controls.Add(Me.filtrar_comunidad)
        Me.lista_albaranes.Controls.Add(Me.filtrar_bar)
        Me.lista_albaranes.Controls.Add(Me.filtrar_empresa)
        Me.lista_albaranes.Controls.Add(Me.mostrar_ultimos)
        Me.lista_albaranes.Controls.Add(Me.DataGridView1)
        Me.lista_albaranes.Location = New System.Drawing.Point(4, 25)
        Me.lista_albaranes.Name = "lista_albaranes"
        Me.lista_albaranes.Padding = New System.Windows.Forms.Padding(3)
        Me.lista_albaranes.Size = New System.Drawing.Size(852, 659)
        Me.lista_albaranes.TabIndex = 1
        Me.lista_albaranes.Text = "Lista albaranes"
        Me.lista_albaranes.UseVisualStyleBackColor = True
        '
        'eliminar
        '
        Me.eliminar.Location = New System.Drawing.Point(530, 398)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(188, 52)
        Me.eliminar.TabIndex = 9
        Me.eliminar.Text = "Eliminar albarán"
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'modificar
        '
        Me.modificar.Location = New System.Drawing.Point(277, 398)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(188, 52)
        Me.modificar.TabIndex = 8
        Me.modificar.Text = "Modificar los datos"
        Me.modificar.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(502, 492)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(154, 17)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "Mostrar por comunidad"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(274, 492)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(106, 17)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Mostrar por bar"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(38, 492)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(140, 17)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Mostrar por empresa"
        '
        'filtrar_comunidad
        '
        Me.filtrar_comunidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.filtrar_comunidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.filtrar_comunidad.FormattingEnabled = True
        Me.filtrar_comunidad.Location = New System.Drawing.Point(505, 526)
        Me.filtrar_comunidad.Name = "filtrar_comunidad"
        Me.filtrar_comunidad.Size = New System.Drawing.Size(121, 24)
        Me.filtrar_comunidad.TabIndex = 4
        '
        'filtrar_bar
        '
        Me.filtrar_bar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.filtrar_bar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.filtrar_bar.FormattingEnabled = True
        Me.filtrar_bar.Location = New System.Drawing.Point(277, 526)
        Me.filtrar_bar.Name = "filtrar_bar"
        Me.filtrar_bar.Size = New System.Drawing.Size(121, 24)
        Me.filtrar_bar.TabIndex = 3
        '
        'filtrar_empresa
        '
        Me.filtrar_empresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.filtrar_empresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.filtrar_empresa.FormattingEnabled = True
        Me.filtrar_empresa.Location = New System.Drawing.Point(41, 526)
        Me.filtrar_empresa.Name = "filtrar_empresa"
        Me.filtrar_empresa.Size = New System.Drawing.Size(121, 24)
        Me.filtrar_empresa.TabIndex = 2
        '
        'mostrar_ultimos
        '
        Me.mostrar_ultimos.AutoSize = True
        Me.mostrar_ultimos.Location = New System.Drawing.Point(41, 398)
        Me.mostrar_ultimos.Name = "mostrar_ultimos"
        Me.mostrar_ultimos.Size = New System.Drawing.Size(178, 21)
        Me.mostrar_ultimos.TabIndex = 1
        Me.mostrar_ultimos.Text = "Mostrar solo los últimos"
        Me.mostrar_ultimos.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(804, 340)
        Me.DataGridView1.TabIndex = 0
        '
        'albaranes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(860, 688)
        Me.Controls.Add(Me.insertar_albaran)
        Me.Name = "albaranes"
        Me.Text = "albaranes"
        Me.insertar_albaran.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.lista_albaranes.ResumeLayout(False)
        Me.lista_albaranes.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents insertar_albaran As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents observaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Establecimiento As System.Windows.Forms.TextBox
    Friend WithEvents recaudador As System.Windows.Forms.TextBox
    Friend WithEvents maquina As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents guardar As System.Windows.Forms.Button
    Friend WithEvents lista_albaranes As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents filtrar_comunidad As System.Windows.Forms.ComboBox
    Friend WithEvents filtrar_bar As System.Windows.Forms.ComboBox
    Friend WithEvents filtrar_empresa As System.Windows.Forms.ComboBox
    Friend WithEvents mostrar_ultimos As System.Windows.Forms.CheckBox
    Friend WithEvents modificar As System.Windows.Forms.Button
    Friend WithEvents eliminar As System.Windows.Forms.Button
    Friend WithEvents nuevo As System.Windows.Forms.Button
    Friend WithEvents tasas_pagadas As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tasa2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tasa1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents s_total As System.Windows.Forms.MaskedTextBox
    Friend WithEvents s_anterior As System.Windows.Forms.MaskedTextBox
    Friend WithEvents s_ultimas As System.Windows.Forms.MaskedTextBox
    Friend WithEvents e_total As System.Windows.Forms.MaskedTextBox
    Friend WithEvents e_anterior As System.Windows.Forms.MaskedTextBox
    Friend WithEvents e_ultimas As System.Windows.Forms.MaskedTextBox
    Friend WithEvents x_contadores As System.Windows.Forms.TextBox
    Friend WithEvents efectivo As System.Windows.Forms.TextBox
    Friend WithEvents pre_establecimiento As System.Windows.Forms.TextBox
    Friend WithEvents operadora_total As System.Windows.Forms.TextBox
    Friend WithEvents Establecimiento_total As System.Windows.Forms.TextBox
    Friend WithEvents paga As System.Windows.Forms.TextBox
    Friend WithEvents pre_operadora As System.Windows.Forms.TextBox
    Friend WithEvents debe As System.Windows.Forms.TextBox
    Friend WithEvents total_contadores As System.Windows.Forms.TextBox
End Class
