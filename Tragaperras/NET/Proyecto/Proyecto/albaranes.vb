Public Class albaranes
    Dim datos_empresa, datos_bares, datos_operarios, datos_comunidad, datos_albaranes, datos_maquina, datos_ultimos_albaranes, datos_maquinas_instaladas, datos_guardar, datos_albaranes_mostrar, datos_albaranes_mostrar_ultimo As New clase_tabla
    Dim modificar_i As Integer = -1
    Dim autocompletados As Integer = 0
    Dim rellenar_anteriores_e, rellenar_anteriores_s As Integer
    Dim todas_maquinas_auto, todos_bares_auto, maquinas_auto, bares_auto As New AutoCompleteStringCollection
    Private Sub albaranes_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Form1.Show()
    End Sub

    Sub inicializa_datagrid()
        datos_albaranes.inicializa(Form1.clase_datos_global, "select * from albaran", 15)
        datos_albaranes_mostrar.inicializa(Form1.clase_datos_global, "select bar.nombre as bar,maquina.nombre_modelo as maquina,albaran.fecha as fecha,entrada_operadora as recaudacion,entrada_bar as [recaudacion bar],tasas as [tasas pagadas],operario.nombre as recaudador,albaran.id_albaran as numero,empresa.nombre as empresa,bar.nombre_comunidad as comunidad,E as entradas,S as salidas  from bar,m_b,maquina,albaran,operario,empresa where  operario.dni_operario=albaran.dni_operario and albaran.n_serie=maquina.n_serie and maquina.n_serie=m_b.n_serie and m_b.n_fiscal_bar=bar.n_fiscal_bar and  albaran.fecha>=m_b.fecha_instalacion  and maquina.n_fiscal_empresa=empresa.n_fiscal_empresa and ( m_b.fecha_instalacion>m_b.fecha_retirada or albaran.fecha<=m_b.fecha_retirada)", 12)
        datos_albaranes_mostrar_ultimo.inicializa(Form1.clase_datos_global, "SELECT bar.nombre as bar,maquina.nombre_modelo as maquina,albaran.fecha as fecha,entrada_operadora as recaudacion,entrada_bar as [recaudacion bar],tasas as [tasas pagadas],operario.nombre as recaudador,albaran.id_albaran as numero,empresa.nombre as empresa,bar.nombre_comunidad as comunidad,E as entradas,S as salidas FROM bar,m_b,maquina,albaran,operario,empresa where operario.dni_operario=albaran.dni_operario and albaran.n_serie=maquina.n_serie and maquina.n_serie=m_b.n_serie and m_b.n_fiscal_bar=bar.n_fiscal_bar and  albaran.fecha>=m_b.fecha_instalacion  and maquina.n_fiscal_empresa=empresa.n_fiscal_empresa and ( m_b.fecha_instalacion>m_b.fecha_retirada or albaran.fecha<=m_b.fecha_retirada)and albaran.fecha>= all(select fecha from albaran a where a.n_serie=albaran.n_serie)", 12)
        If Me.mostrar_ultimos.Checked = True Then
            Me.datos_albaranes_mostrar_ultimo.enlaza_datagrid(Me.DataGridView1)
        Else
            Me.datos_albaranes_mostrar.enlaza_datagrid(Me.DataGridView1)
        End If
    End Sub

    Sub vacia()
        Dim c As Control
        For Each c In Me.TabPage1.Controls
            If TypeOf c Is TextBox Or TypeOf c Is MaskedTextBox Then
                c.Text = ""
                If c.Name = "observaciones" Then
                    c.Text = " "
                End If
                If c.Name = "paga" Or c.Name = "debe" Then
                    c.Text = "0"
                End If
            End If
        Next
        Me.Establecimiento.AutoCompleteCustomSource = Me.todos_bares_auto
        Me.maquina.AutoCompleteCustomSource = Me.todas_maquinas_auto
        Me.modificar_i = -1
        Me.maquina.Focus()
    End Sub

    Private Sub albaranes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim c As Control
        datos_empresa.inicializa(Form1.clase_datos_global, "select * from empresa", 3)
        datos_bares.inicializa(Form1.clase_datos_global, "select n_fiscal_bar,empresa.n_fiscal_empresa,bar.nombre from bar,empresa where bar.n_fiscal_empresa=empresa.n_fiscal_empresa", 3)
        datos_operarios.inicializa(Form1.clase_datos_global, "select nombre,dni_operario from operario", 2)
        datos_comunidad.inicializa(Form1.clase_datos_global, "select nombre_comunidad from comunidad_autonoma", 1)
        datos_maquina.inicializa(Form1.clase_datos_global, "select nombre_modelo from modelo_maquina", 1)
        Me.datos_maquinas_instaladas.inicializa(Form1.clase_datos_global, "select maquina.n_serie,bar.nombre,bar.n_fiscal_bar,nombre_modelo,m_b.fecha_instalacion,m_b.fecha_retirada from maquina,m_b,bar where bar.n_fiscal_bar=m_b.n_fiscal_bar and m_b.n_serie=maquina.n_serie and fecha_instalacion>fecha_retirada", 6)
        Me.maquina.AutoCompleteCustomSource.Clear()
        Me.Establecimiento.AutoCompleteCustomSource.Clear()
        Me.recaudador.AutoCompleteCustomSource.Clear()
        For Each c In Me.lista_albaranes.Controls
            If TypeOf c Is ComboBox Then
                CType(c, ComboBox).AutoCompleteCustomSource.Clear()
                CType(c, ComboBox).Items.Clear()
                CType(c, ComboBox).AutoCompleteCustomSource.Add("Todos")
                CType(c, ComboBox).Items.Add("Todos")
                CType(c, ComboBox).SelectedIndex = 0
            End If
        Next
        For i = 0 To Me.datos_maquina.num_datos - 1
            '  Me.maquina.AutoCompleteCustomSource.Add(Me.datos_maquina.dato_dt(i, 0))
            Me.todas_maquinas_auto.Add(Me.datos_maquina.dato_dt(i, 0))
        Next
        For i = 0 To Me.datos_bares.num_datos() - 1
            Me.filtrar_bar.Items.Add(Me.datos_bares.dato_dt(i, 2))
            Me.filtrar_bar.AutoCompleteCustomSource.Add(Me.datos_bares.dato_dt(i, 2))
            Me.Establecimiento.AutoCompleteCustomSource.Add(Me.datos_bares.dato_dt(i, 2))
            Me.todos_bares_auto.Add(Me.datos_bares.dato_dt(i, 2))
        Next
        For i = 0 To Me.datos_operarios.num_datos() - 1
            Me.recaudador.AutoCompleteCustomSource.Add(Me.datos_operarios.dato_dt(i, 0))
        Next
        'Me.datos_empresa.almacena_combobox(Me.filtrar_empresa, 1)
        For i = 0 To Me.datos_empresa.num_datos() - 1
            Me.filtrar_empresa.AutoCompleteCustomSource.Add(Me.datos_empresa.dato_dt(i, 1))
            Me.filtrar_empresa.Items.Add(Me.datos_empresa.dato_dt(i, 1))
        Next
        For i = 0 To Me.datos_comunidad.num_datos - 1
            Me.filtrar_comunidad.AutoCompleteCustomSource.Add(Me.datos_comunidad.dato_dt(i, 0))
            Me.filtrar_comunidad.Items.Add(Me.datos_comunidad.dato_dt(i, 0))
        Next
        inicializa_datagrid()
        vacia()
        Me.modificar_i = -1
    End Sub

 
    Private Sub nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevo.Click
        vacia()
        Me.modificar_i = -1
        Me.guardar.Text = "Guardar"
    End Sub

    Private Sub modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modificar.Click
        Dim seleccion, indice As Integer
        If Me.DataGridView1.SelectedCells.Count > 0 Then
            seleccion = Me.DataGridView1.SelectedCells(0).RowIndex
            If seleccion < Me.DataGridView1.Rows.Count - 1 Then
                'datos_albaranes.inicializa(Form1.clase_datos_global, "select * from albaran", 15)
                indice = Me.DataGridView1.Rows(seleccion).Cells(7).Value.ToString
                Me.guardar.Text = "Modificar"
                Me.modificar_i = indice
                Me.insertar_albaran.SelectedIndex = 0
                Me.maquina.Text = Me.DataGridView1.Rows(seleccion).Cells(1).Value.ToString
                Me.recaudador.Text = Me.DataGridView1.Rows(seleccion).Cells(6).Value.ToString
                Me.Establecimiento.Text = Me.DataGridView1.Rows(seleccion).Cells(0).Value.ToString
                Me.fecha.Value = Me.DataGridView1.Rows(seleccion).Cells(2).Value.ToString
                Me.e_ultimas.Text = Me.datos_albaranes.dato_dt(indice, 4).ToString
                Me.s_ultimas.Text = Me.datos_albaranes.dato_dt(indice, 5).ToString
                Me.e_anterior.Text = Me.datos_albaranes.dato_dt(indice, 12).ToString
                Me.s_anterior.Text = Me.datos_albaranes.dato_dt(indice, 13).ToString
                If 0 > ((CType(Me.datos_albaranes.dato_dt(indice, 10), Single) + CType(Me.datos_albaranes.dato_dt(indice, 11), Single))) Then
                    Me.efectivo.Text = "0"
                    Me.tasas_pagadas.Text = "0"
                    Me.tasa1.Text = "0"
                Else
                    Me.efectivo.Text = ((CType(Me.datos_albaranes.dato_dt(indice, 10), Single) + CType(Me.datos_albaranes.dato_dt(indice, 11), Single))).ToString
                    Me.tasas_pagadas.Text = Me.datos_albaranes.dato_dt(indice, 9).ToString
                    Me.tasa1.Text = ((CType(Me.datos_albaranes.dato_dt(indice, 10), Single) - CType(Me.datos_albaranes.dato_dt(indice, 11), Single)) / 2).ToString
                End If
                Me.tasa2.Text = Me.tasa1.Text
                Me.observaciones.Text = Me.datos_albaranes.dato_dt(indice, 6).ToString
                Me.debe.Text = Me.datos_albaranes.dato_dt(indice, 7).ToString
                Me.paga.Text = Me.datos_albaranes.dato_dt(indice, 8).ToString
                'aqui generamos los eventos, no es muy elegante pero no se nota
                Me.e_anterior.Focus()
                Me.s_anterior.Focus()
                Me.tasa1.Focus()
                Me.guardar.Focus()
            End If
        End If

    End Sub


    Function valida() As Integer
        Dim c As Control
        'aqui quedarian de hacer varias cosas, como que las recaudaciones no sean negativas
        'o como que la maquina esta puesta en ese var
        For Each c In Me.TabPage1.Controls
            If TypeOf c Is TextBox Or TypeOf c Is MaskedTextBox Then
                If c.Text = "" Then
                    MsgBox("No se han rellenado todos los campos")
                    Return 0
                End If
            End If
        Next
        If -1 = comprueba_ubicacion() Then
            MsgBox("Ese modelo de maquina no esta ubicado en ese bar, revisa el albaran o la base de datos")
            Return (0)
        End If
        If -1 = comprueba_ubicacion_fecha() Then
            MsgBox("La fecha es incorrecta ya que en ese dia la maquina no estaba ahi en ese dia")
            Return (0)
        End If
        If (CType(Me.e_ultimas.Text, Integer) < CType(Me.e_anterior.Text, Integer)) Then
            MsgBox("Hay un fallo en las entradas, las ultimas son menores que las anteriores")
            Return (0)
        End If

        If (CType(Me.s_ultimas.Text, Integer) < CType(Me.s_anterior.Text, Integer)) Then
            MsgBox("Hay un fallo en las salidas, las ultimas son menores que las anteriores")
            Return (0)
        End If
        'también hay que comprobar otras cosas, como los contadores
        If CType(Me.e_anterior.Text, Integer) > CType(Me.e_ultimas.Text, Integer) Then
            MsgBox("Revisa las entradas, ya que las anteriores son mayores que las ultimas")
            Return 0
        End If
        If CType(Me.s_anterior.Text, Integer) > CType(Me.s_ultimas.Text, Integer) Then
            MsgBox("Revisa las salidas, ya que las anteriores son mayores que las ultimas")
            Return 0
        End If
        If CType(Me.pre_establecimiento.Text, Single) < CType(Me.tasa1.Text, Single) Then
            MsgBox("Revisa las casillas de tasas , ya que la cantidad es demasiado alta para la recaudación")
            Return 0
        End If
        'aqui estaria bien hacer todas las cuentas otra vez, pero bueno
        Return 1
    End Function

    Private Sub guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardar.Click
        Dim i As Integer
        Dim texto As String
        Dim id_albaran As Integer
        Dim dni_operario, n_serie As String
        If valida() = 1 Then
            i = 0
            'hacer el encontrado es complicado, ya que la identificación es autonumerico
            'lo suyo seria comprobar la fecha y los contadores
            If Me.guardar.Text = "Modificar" Then
                ' MsgBox("Se modifica " + Me.modificar_i.ToString)
                dni_operario = encuentra_dni()
                n_serie = encuentra_serie_maquina()
                texto = "update albaran set fecha='" + Me.fecha.Value.Date.ToString + "',dni_operario='" + dni_operario.ToString + "',n_serie='"
                texto = texto + n_serie + "',E=" + Me.e_ultimas.Text + ",S=" + Me.s_ultimas.Text + ",observaciones='" + Me.observaciones.Text + "',debe=" + retorna_punto(Me.debe.Text) + ",haber="
                texto = texto + retorna_punto(Me.paga.Text) + ",tasas=" + Me.tasas_pagadas.Text + ",entrada_operadora=" + retorna_punto(Me.operadora_total.Text) + ",entrada_bar="
                texto = texto + retorna_punto(Me.Establecimiento_total.Text) + ",E_anterior=" + Me.e_anterior.Text + ",S_anterior=" + Me.s_anterior.Text + ""
                texto = texto + " where id_albaran=" + Me.modificar_i.ToString + ""
                Me.datos_guardar.inicializa(Form1.clase_datos_global, texto, 1)
                Me.guardar.Text = "Guardar"
                Me.modificar_i = -1
            Else
                id_albaran = encuentra_indice()
                dni_operario = encuentra_dni()
                n_serie = encuentra_serie_maquina()
                'aqui habria que modificar tambien lo de las tasas
                texto = "insert into albaran values(" + id_albaran.ToString + ",'" + Me.fecha.Value.Date.ToString + "','" + dni_operario.ToString + "','"
                texto = texto + n_serie + "'," + Me.e_ultimas.Text + "," + Me.s_ultimas.Text + ",'" + Me.observaciones.Text + "'," + retorna_punto(Me.debe.Text) + ","
                texto = texto + retorna_punto(Me.paga.Text) + "," + Me.tasas_pagadas.Text + "," + retorna_punto(Me.operadora_total.Text) + ","
                texto = texto + retorna_punto(Me.Establecimiento_total.Text) + "," + Me.e_anterior.Text + "," + Me.s_anterior.Text + ")"
                Me.datos_guardar.inicializa(Form1.clase_datos_global, texto, 1)
            End If
            inicializa_datagrid()
            vacia()
        End If
    End Sub

    Function retorna_punto(ByVal s As String) As String
        Dim ret As String
        ret = Replace(s, ",", ".")
        Return ret
    End Function

    Function encuentra_indice() As Integer
        'esto se podria mejorar, pero vale
        Dim i, indice As Integer
        indice = 0
        For i = 0 To Me.datos_albaranes.num_datos
            If indice <= Me.datos_albaranes.dato_dt(i, 0) Then
                indice = Me.datos_albaranes.dato_dt(i, 0) + 1
            End If
        Next
        Return indice
    End Function

    Function encuentra_serie_maquina() As String
        Dim i As Integer
        i = 0
        'aqui hay que buscar entre las maquinas instaladas
        'Me.datos_maquinas_instaladas.inicializa(Form1.clase_datos_global, "select maquina.n_serie,bar.nombre,bar.n_fiscal_bar,nombre_modelo from maquina,m_b,bar where bar.n_fiscal_bar=m_b.n_fiscal_bar and m_b.n_serie=maquina.n_serie and fecha_instalacion>fecha_retirada", 4)
        While i < Me.datos_maquinas_instaladas.num_datos()
            If Me.datos_maquinas_instaladas.dato_dt(i, 3).ToString.ToLower = Me.maquina.Text.ToLower Then
                If Me.Establecimiento.Text.ToLower = Me.datos_maquinas_instaladas.dato_dt(i, 1).ToString.ToLower Then
                    Return Me.datos_maquinas_instaladas.dato_dt(i, 0).ToString
                End If
            End If
            i = i + 1
        End While
        Return ("No en")
    End Function

    Function encuentra_dni() As String
        'encuentra el dni
        Dim i, encontrado As Integer
        i = 0
        encontrado = 0
        While i < Me.datos_operarios.num_datos() And encontrado = 0
            If (Me.datos_operarios.dato_dt(i, 0).ToString.ToLower) = (Me.recaudador.Text.ToLower) Then
                encontrado = 1
                Return Me.datos_operarios.dato_dt(i, 1)
            End If
            i = i + 1
        End While
        Return "No en"
    End Function

    Private Sub mostrar_ultimos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mostrar_ultimos.CheckedChanged
        If Me.mostrar_ultimos.Checked = True Then
            Me.datos_albaranes_mostrar_ultimo.enlaza_datagrid(Me.DataGridView1)
        Else
            Me.datos_albaranes_mostrar.enlaza_datagrid(Me.DataGridView1)
        End If

    End Sub


    Sub resta_texto(ByVal arriba As String, ByVal abajo As String, ByRef resultado As String)
        'hacemos la resta
        Dim resta As Integer
        If IsNumeric(arriba) And IsNumeric(abajo) Then
            resta = CType(arriba, Integer) - CType(abajo, Integer)
            resultado = resta.ToString
        End If
    End Sub

    Private Sub e_anterior_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles e_anterior.Enter
        If Me.e_anterior.Text <> "" Then
            'ya han sido rellenados los contadores, pasamos a la siguiente casilla
            If (CType(Me.e_ultimas.Text, Integer) < CType(Me.e_anterior.Text, Integer)) Then
                MsgBox("Hay un fallo en las entradas, las ultimas son menores que las anteriores")
            Else
                resta_texto(Me.e_ultimas.Text, Me.e_anterior.Text, Me.e_total.Text)
            End If
            If Me.rellenar_anteriores_e = 1 Then
                Me.s_ultimas.Focus() 'solo pasamos a la siguiente una vez
            End If
            Me.rellenar_anteriores_e = 0
        End If
    End Sub

    Private Sub e_anterior_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles e_anterior.Leave
        If (CType(Me.e_ultimas.Text, Integer) < CType(Me.e_anterior.Text, Integer)) Then
            MsgBox("Hay un fallo en las entradas, las ultimas son menores que las anteriores")
        Else
            resta_texto(Me.e_ultimas.Text, Me.e_anterior.Text, Me.e_total.Text)
        End If
    End Sub

    Private Sub s_anterior_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles s_anterior.Enter
        If Me.s_anterior.Text <> "" Then
            'los contadores ya han sido rellenados
            Dim total As Single
            If (CType(Me.s_ultimas.Text, Integer) < CType(Me.s_anterior.Text, Integer)) Then
                MsgBox("Hay un fallo en las salidas, las ultimas son menores que las anteriores")
            End If
            resta_texto(Me.s_ultimas.Text, Me.s_anterior.Text, Me.s_total.Text)
            resta_texto(Me.e_total.Text, Me.s_total.Text, Me.total_contadores.Text)
            If IsNumeric(Me.total_contadores.Text) Then
                total = CType(Me.total_contadores.Text, Single) / 5
                If CType(total, Single) < 0 Then
                    total = "0"
                End If
                Me.x_contadores.Text = total.ToString
                Me.efectivo.Text = total.ToString
                Me.pre_operadora.Text = (total / 2).ToString
                Me.pre_establecimiento.Text = (total / 2).ToString
                If Me.rellenar_anteriores_s = 1 Then
                    Me.tasa1.Focus()
                End If
                Me.rellenar_anteriores_s = 0
            End If
        End If
    End Sub

    Private Sub s_anterior_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles s_anterior.Leave
        Dim total As Single
        resta_texto(Me.s_ultimas.Text, Me.s_anterior.Text, Me.s_total.Text)
        resta_texto(Me.e_total.Text, Me.s_total.Text, Me.total_contadores.Text)
        If IsNumeric(Me.total_contadores.Text) Then
            total = CType(Me.total_contadores.Text, Single) / 5
            If CType(total, Single) < 0 Then
                total = "0"
            End If
            Me.x_contadores.Text = total.ToString
            Me.efectivo.Text = total.ToString
            Me.pre_operadora.Text = (total / 2).ToString
            Me.pre_establecimiento.Text = (total / 2).ToString
        End If
    End Sub



    Private Sub tasa1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tasa1.Leave
        Dim s As Integer
        If IsNumeric(Me.tasa1.Text) Then
            Me.tasa2.Text = Me.tasa1.Text
            If IsNumeric(Me.pre_establecimiento.Text) And IsNumeric(Me.pre_operadora.Text) Then
                Me.operadora_total.Text = (CType(Me.pre_operadora.Text, Single) + CType(Me.tasa1.Text, Single)).ToString
                Me.Establecimiento_total.Text = (CType(Me.pre_establecimiento.Text, Single) - CType(Me.tasa2.Text, Single)).ToString
                If CType(Me.Establecimiento_total.Text, Single) < 0 Then
                    Me.Establecimiento_total.Text = "0"
                    Me.operadora_total.Text = (CType(Me.pre_operadora.Text, Single)).ToString
                    'aquí se podría dar un mensaje de error
                End If
            End If
            'hay que resolber el numero de las tasas
            If CType(Me.tasa1.Text, Single) Mod 45 = 0 Then
                s = CType(Me.tasa1.Text, Single) / 45
                Me.tasas_pagadas.Text = s.ToString

            ElseIf CType(Me.tasa1.Text, Single) Mod 40 = 0 Then
                s = CType(Me.tasa1.Text, Single) / 40
                Me.tasas_pagadas.Text = s.ToString

            ElseIf CType(Me.tasa1.Text, Single) Mod 35 = 0 Then
                s = CType(Me.tasa1.Text, Single) / 35
                Me.tasas_pagadas.Text = s.ToString
            Else
                Me.tasas_pagadas.Text = "0"
            End If
        End If
    End Sub

    Private Sub eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminar.Click
        Dim seleccionado As Integer
        Dim valor As String
        If Me.DataGridView1.SelectedCells.Count > 0 Then
            seleccionado = Me.DataGridView1.SelectedCells(0).RowIndex
            If seleccionado < Me.DataGridView1.Rows.Count - 1 Then
                valor = Me.DataGridView1.Rows(seleccionado).Cells(7).Value.ToString
                'MsgBox(valor)
                Me.datos_guardar.inicializa(Form1.clase_datos_global, "delete from albaran where id_albaran=" + valor + "", 1)
                inicializa_datagrid()
            End If
        End If
    End Sub

    Private Sub TabPage1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage1.Enter
        If Me.modificar_i = -1 Then
            Me.guardar.Text = "Guardar"
            vacia()
        End If
        '   MsgBox(Me.modificar_i.ToString)
    End Sub

    Private Sub filtrar_bar_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles filtrar_bar.SelectedIndexChanged, filtrar_comunidad.SelectedIndexChanged, filtrar_empresa.SelectedIndexChanged
        'aqui realizamos los filtros
        Dim texto As String = ""
        Dim iniciado As Integer = 0
        If Me.filtrar_empresa.SelectedIndex <> 0 Then
            texto = "empresa='" + Me.filtrar_empresa.Text + "'"
            iniciado = 1
        End If
        If Me.filtrar_comunidad.SelectedIndex <> 0 Then
            If iniciado = 1 Then
                texto = texto + " and comunidad='" + Me.filtrar_comunidad.Text + "'"
            Else
                texto = "comunidad='" + Me.filtrar_comunidad.Text + "'"
                iniciado = 1
            End If
        End If
        If Me.filtrar_bar.SelectedIndex <> 0 Then
            If iniciado = 1 Then
                texto = texto + " and bar='" + Me.filtrar_bar.Text + "'"
            Else
                texto = "bar='" + Me.filtrar_bar.Text + "'"
                iniciado = 1
            End If
        End If
        If iniciado = 1 Then
            Me.datos_albaranes_mostrar.filtro(texto)
            Me.datos_albaranes_mostrar_ultimo.filtro(texto)
        Else
            Me.datos_albaranes_mostrar.quitar_filtro()
            Me.datos_albaranes_mostrar_ultimo.quitar_filtro()
        End If
    End Sub

    Function comprueba_ubicacion() As Integer
        'comprobamos que esa maquina esta ubicada en ese bar
        Dim encontrado, i As Integer
        encontrado = 0
        i = 0
        '        Me.datos_maquinas_instaladas.inicializa(Form1.clase_datos_global, "select maquina.n_serie,bar.nombre,bar.n_fiscal_bar,nombre_modelo,m_b.fecha_instalacion,m_b.fecha_retirada from maquina,m_b,bar where bar.n_fiscal_bar=m_b.n_fiscal_bar and m_b.n_serie=maquina.n_serie and fecha_instalacion>fecha_retirada", 4)
        While i < Me.datos_maquinas_instaladas.num_datos() And encontrado = 0
            If Me.datos_maquinas_instaladas.dato_dt(i, 3).ToString.ToLower = Me.maquina.Text.ToLower Then
                If Me.datos_maquinas_instaladas.dato_dt(i, 1).ToString.ToLower = Me.Establecimiento.Text.ToLower Then
                    encontrado = 1
                    encuentra_contadores(i)
                    'lo hemos encontrado, ahora toca buscar entre los ultimos albaranes para poner los contadores anteriores
                    Return i
                End If
            End If
            i = i + 1
        End While
        Return -1
    End Function

    Function comprueba_ubicacion_fecha()
        Dim encontrado As Integer
        Dim fecha, fecha_retirada As Date
        encontrado = comprueba_ubicacion()
        If encontrado = -1 Then
            Return -1
        End If
        fecha = CType(Me.datos_maquinas_instaladas.dato_dt(encontrado, 4), Date)
        fecha_retirada = CType(Me.datos_maquinas_instaladas.dato_dt(encontrado, 5), Date)
        '        MsgBox(fecha.ToString + " " + fecha_retirada.ToString)
        If fecha_retirada < fecha Then 'la maquina todabia esta en el bar
            If Me.fecha.Value.Year >= fecha.Year Then
                If Me.fecha.Value.Month >= fecha.Month Then
                    If Me.fecha.Value.Day >= fecha.Day Then
                        Return encontrado
                    End If
                End If
            End If
        End If
        If fecha <= fecha_retirada Then 'la maquina ya no esta en el bar
            If Me.fecha.Value.Year >= fecha.Year And Me.fecha.Value.Year <= fecha_retirada.Year Then
                If Me.fecha.Value.Month >= fecha.Month And Me.fecha.Value.Month <= fecha_retirada.Month Then
                    If Me.fecha.Value.Day >= fecha.Day And Me.fecha.Value.Day <= fecha_retirada.Day Then
                        Return encontrado
                    End If
                End If
            End If
        End If
        Return -1
    End Function

    Function encuentra_contadores(ByVal e As Integer) As Integer
        'busca entre los ultimos albaranes para buscar la coincidencia entre maquina y bar
        Dim encontrado, i As Integer
        encontrado = e
        If encontrado = -1 Then
            Return -1
        End If
        'ahora busca entre los ultimos albaranes
        encontrado = 0
        i = 0
        If Me.guardar.Text = "Modificar" Then 'no hay que cambiar los contadores
            Return -1
        End If
        While i < Me.datos_albaranes_mostrar_ultimo.num_datos And encontrado = 0
            If Me.datos_albaranes_mostrar_ultimo.dato_dt(i, 0).ToString.ToLower = Me.Establecimiento.Text.ToLower Then
                If Me.datos_albaranes_mostrar_ultimo.dato_dt(i, 1).ToString.ToLower = Me.maquina.Text.ToLower Then
                    'se podria comprobar tambien la fecha
                    Me.rellenar_anteriores_s = 1
                    Me.rellenar_anteriores_e = 1
                    Me.e_anterior.Text = Me.datos_albaranes_mostrar_ultimo.dato_dt(i, 10).ToString
                    Me.s_anterior.Text = Me.datos_albaranes_mostrar_ultimo.dato_dt(i, 11).ToString

                End If
            End If
            i = i + 1
        End While

        Return -1
    End Function


    Private Sub fecha_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles fecha.Leave
        If -1 = comprueba_ubicacion_fecha() Then
            '      MsgBox("La maquina no estaba en esa ubicacion en esa fecha")
        End If
    End Sub

   
    Private Sub maquina_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles maquina.Enter
        Dim i, puesto As Integer
        'Me.datos_maquinas_instaladas.inicializa(Form1.clase_datos_global, "select maquina.n_serie,bar.nombre,bar.n_fiscal_bar,nombre_modelo,m_b.fecha_instalacion,m_b.fecha_retirada from maquina,m_b,bar where bar.n_fiscal_bar=m_b.n_fiscal_bar and m_b.n_serie=maquina.n_serie and fecha_instalacion>fecha_retirada", 6)
        If Me.Establecimiento.Text = "" Then
            Me.maquina.AutoCompleteCustomSource = Me.todas_maquinas_auto
        Else
            'se ha introducido un establecimiento, hay que introducir todos los modelos de maquina de ese bar
            Me.maquinas_auto.Clear()
            puesto = 0
            For i = 0 To Me.datos_bares.num_datos() - 1
                If Me.datos_maquinas_instaladas.dato_dt(i, 1).ToString.ToLower = Me.Establecimiento.Text.ToLower Then
                    Me.maquinas_auto.Add(Me.datos_maquinas_instaladas.dato_dt(i, 3))
                    puesto = 1
                End If
            Next
            If puesto = 1 Then
                Me.maquina.AutoCompleteCustomSource = Me.maquinas_auto
            End If
            If puesto = 0 Then 'el establecimiento no es valido, por lo menos ponemos todas las maquinas
                Me.maquina.AutoCompleteCustomSource = Me.todas_maquinas_auto
            End If
        End If
    End Sub

    Private Sub Establecimiento_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Establecimiento.Enter
        Dim i, puesto As Integer
        puesto = 0
        If Me.maquina.Text = "" Then
            Me.Establecimiento.AutoCompleteCustomSource = Me.todos_bares_auto
        Else
            Me.bares_auto.Clear()
            puesto = 0
            For i = 0 To Me.datos_maquina.num_datos() - 1
                If Me.datos_maquinas_instaladas.dato_dt(i, 3).ToString.ToLower = Me.maquina.Text.ToLower Then
                    Me.bares_auto.Add(Me.datos_maquinas_instaladas.dato_dt(i, 1))
                    puesto = 1
                End If
            Next
            If puesto = 1 Then
                Me.Establecimiento.AutoCompleteCustomSource = Me.bares_auto
            Else
                Me.Establecimiento.AutoCompleteCustomSource = Me.todos_bares_auto
            End If
        End If
    End Sub

    Private Sub tasa2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tasa2.Leave
        Me.tasa1.Text = Me.tasa2.Text
        tasa1_Leave(sender, e)
    End Sub
End Class