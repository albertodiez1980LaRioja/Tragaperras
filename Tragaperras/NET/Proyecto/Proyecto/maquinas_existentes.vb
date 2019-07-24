Public Class maquinas_existentes
    'esto hay que cambiarlo todo pero todabia no hemos llegado hasta aqui
    Dim clase_modelo As New clase_tabla
    Dim clase_modeloA As New clase_tabla
    Dim filtrar As New clase_tabla
    Dim clase_B As New clase_tabla
    Dim clase_guardar, datos_empresa, maquinasA, maquinasB As New clase_tabla
    Dim borrar_celdas As Integer = 0
    Dim bares, comunidades, recaudaciones, empresas As New ArrayList
    Sub inicializa_datagrid()
        borrar_celdas = 0
        clase_modelo.inicializa(Form1.clase_datos_global, "select modelo_maquina.nombre_modelo as modelo,modelo_maquina.año,B.premio_maximo as premio,B.carga as carga from modelo_maquina,B where (modelo_maquina.nombre_modelo=B.nombre_modelo) order by B.nombre_modelo", 2)
        clase_modelo.enlaza_datagrid(Me.DataGridView1)
        clase_modeloA.inicializa(Form1.clase_datos_global, "(select modelo_maquina.nombre_modelo,modelo_maquina.año from modelo_maquina where modelo_maquina.nombre_modelo not in(select modelo_maquina.nombre_modelo from modelo_maquina,B where modelo_maquina.nombre_modelo=B.nombre_modelo)order by nombre_modelo)", 2)
        'MsgBox(Microsoft.VisualBasic.Right(Now.Year.ToString, 2))
        Me.serie_año.Text = Microsoft.VisualBasic.Right(Now.Year.ToString, 2)
        Me.filtrar.inicializa(Form1.clase_datos_global, "select nombre,n_fiscal_bar from bar", 2)
        Me.filtrar.almacena_arraylist(Me.bares)
        Me.filtrar.inicializa(Form1.clase_datos_global, "select nombre_comunidad from comunidad_autonoma", 1)
        Me.filtrar.almacena_combobox(Me.comunidad, 0)

        Me.filtrar.almacena_arraylist(Me.comunidades)
        Me.filtrar.inicializa(Form1.clase_datos_global, "select distinct fecha from albaran", 1)
        Me.filtrar.almacena_arraylist(Me.recaudaciones)
        Me.datos_empresa.inicializa(Form1.clase_datos_global, "select nombre,n_fiscal_empresa,nombre_comunidad from empresa", 3)
        Me.datos_empresa.almacena_arraylist(Me.empresas)
        Me.datos_empresa.almacena_combobox(Me.empresa, 0)
        
        Me.maquinasA.inicializa(Form1.clase_datos_global, "select n_serie as serie,nombre_modelo as modelo,empresa.nombre_comunidad as comunidad,empresa.nombre as empresa from maquina,empresa where maquina.n_fiscal_empresa=empresa.n_fiscal_empresa and maquina.nombre_modelo not in(select nombre_modelo from B) order by n_serie", 2)
        Me.maquinasB.inicializa(Form1.clase_datos_global, "select n_serie as serie,nombre_modelo as modelo,empresa.nombre_comunidad as comunidad,empresa.nombre as empresa from maquina,empresa where maquina.n_fiscal_empresa=empresa.n_fiscal_empresa and maquina.nombre_modelo  in(select nombre_modelo from B) order by n_serie", 2)
        Me.maquinasB.enlaza_datagrid(Me.DataGridView2)

        borrar_celdas = 1
    End Sub
    Sub inicializa_datagrid2()
        borrar_celdas = 0
        '        Me.filtrar.inicializa(Form1.clase_datos_global, "select n_serie as serie,nombre_modelo as modelo,maquina.nombre_comunidad as comunidad,empresa.nombre as empresa from maquina,empresa where maquina.n_fiscal_empresa=empresa.n_fiscal_empresa order by n_serie", 2)
        '       Me.filtrar.enlaza_datagrid(Me.DataGridView2)

        Me.maquinasA.inicializa(Form1.clase_datos_global, "select n_serie as serie,nombre_modelo as modelo,empresa.nombre_comunidad as comunidad,empresa.nombre as empresa from maquina,empresa where maquina.n_fiscal_empresa=empresa.n_fiscal_empresa and maquina.nombre_modelo not in(select nombre_modelo from B) order by n_serie", 2)
        Me.maquinasB.inicializa(Form1.clase_datos_global, "select n_serie as serie,nombre_modelo as modelo,empresa.nombre_comunidad as comunidad,empresa.nombre as empresa from maquina,empresa where maquina.n_fiscal_empresa=empresa.n_fiscal_empresa and maquina.nombre_modelo  in(select nombre_modelo from B) order by n_serie", 2)
        If Me.tipo_maquina.SelectedIndex = 0 Then
            Me.clase_modeloA.enlaza_datagrid(Me.DataGridView1)
            Me.maquinasA.enlaza_datagrid(Me.DataGridView2)
        ElseIf Me.tipo_maquina.SelectedIndex = 1 Then
            Me.clase_modelo.enlaza_datagrid(Me.DataGridView1)
            Me.maquinasB.enlaza_datagrid(Me.DataGridView2)
        End If
        borrar_celdas = 1
    End Sub


    Private Sub Agregar_modelo_maquina_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Form1.Show()
    End Sub

    Private Sub Agregar_modelo_maquina_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        inicializa_datagrid()
        Me.comunidad.SelectedIndex = 0
        Me.empresa.SelectedIndex = 0
        Me.tipo_maquina.SelectedIndex = 1
        Me.filtrar_por.SelectedIndex = 0
        Me.l_nombre.Text = ""
    End Sub

    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        If e.RowIndex < Me.DataGridView1.RowCount - 1 Then
            Me.l_nombre.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
        End If
    End Sub





    Private Sub DataGridView1_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGridView1.UserDeletedRow
        inicializa_datagrid2()
    End Sub


    'Private Sub DataGridView1_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DataGridView2.UserDeletingRow
    '    Dim texto As String
    '    Dim r1, r2 As Integer
    '    If (e.Row.Cells.Count > 0) Then
    '        texto = e.Row.Cells.Item(0).Value.ToString
    '        r1 = clase_guardar.inicializa(Form1.clase_datos_global, "delete from B where nombre_modelo='" + texto + "'", 2)
    '        r2 = clase_guardar.inicializa(Form1.clase_datos_global, "delete from modelo_maquina where nombre_modelo='" + texto + "'", 2)
    '        If (r1 = 0 Or r2 = 0) Then
    '            MsgBox("Ha habido un fallo en la base de datos, probablemente la maquina ya este registrada")
    '        End If
    '        'inicializa_datagrid()
    '    End If
    'End Sub
    Private Sub DataGridView2_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DataGridView2.UserDeletingRow
        Dim texto As String
        Dim r1 As Integer

        If (e.Row.Cells.Count > 0) Then
            texto = e.Row.Cells.Item(0).Value.ToString
            '            MsgBox(texto)
            r1 = clase_guardar.inicializa(Form1.clase_datos_global, "delete from maquina where n_serie='" + texto + "'", 2)
            If (r1 = 0) Then
                MsgBox("Ha habido un fallo en la base de datos, probablemente la maquina ya este registrada")
            End If
        End If
    End Sub



    Private Sub B_cambiar_datos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_cambiar_datos.Click
        Dim r1, i As Integer
        Dim encontrado As Integer = 0
        Dim texto As String
        If Me.comunidad.Items(Me.comunidad.SelectedIndex).ToString = Me.datos_empresa.dato_dt(Me.empresa.SelectedIndex, 2) Then
            If Me.serie_numero.Text.Length = 6 Then
                If (Me.l_nombre.Text <> "" And Me.serie_año.Text <> "" And Me.serie_numero.Text <> "") Then
                    'Me.empresas.Item(Me.empresa.SelectedIndex * 2 + 1) 
                    'MsgBox(Me.empresa.SelectedIndex)
                    i = 0
                    encontrado = 0
                    While i < Me.maquinasA.num_datos And encontrado = 0
                        If Me.maquinasA.dato_dt(i, 0).ToString = (Me.serie_año.Text.ToString + Me.serie_numero.Text.ToString) Then
                            encontrado = 1
                        End If
                        i = i + 1
                    End While
                    i = 0
                    While i < Me.maquinasB.num_datos And encontrado = 0
                        If Me.maquinasB.dato_dt(i, 0).ToString = (Me.serie_año.Text.ToString + Me.serie_numero.Text.ToString) Then
                            encontrado = 1
                        End If
                        i = i + 1
                    End While

                    If encontrado = 1 Then
                        texto = "update maquina set nombre_modelo='" + Me.l_nombre.Text + "',nombre_comunidad='" + Me.comunidad.Items(Me.comunidad.SelectedIndex).ToString + "',n_fiscal_empresa='" + Me.datos_empresa.dato_dt(Me.empresa.SelectedIndex, 1) + "' where n_serie='" + Me.serie_año.Text + Me.serie_numero.Text + "'"
                        r1 = clase_guardar.inicializa(Form1.clase_datos_global, texto, 2)
                    End If
                    If encontrado = 0 Then
                        r1 = clase_guardar.inicializa(Form1.clase_datos_global, "insert into maquina values('" + Me.serie_año.Text + Me.serie_numero.Text + "','" + Me.l_nombre.Text + "','" + Me.comunidad.Text + "','" + Me.datos_empresa.dato_dt(Me.empresa.SelectedIndex, 1) + "')", 2)
                    End If
                    Me.serie_numero.Text = ""
                    inicializa_datagrid2()
                End If
            Else
                MsgBox("El numero de serie no esta completo")
            End If
        Else
            MsgBox("No coincide la comunidad con la comunidad de la empresa")
        End If

    End Sub

    Private Sub tipo_maquina_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tipo_maquina.SelectedIndexChanged
        If Me.tipo_maquina.SelectedIndex = 0 Then
            Me.clase_modeloA.enlaza_datagrid(Me.DataGridView1)
            Me.maquinasA.enlaza_datagrid(Me.DataGridView2)
        ElseIf Me.tipo_maquina.SelectedIndex = 1 Then
            Me.clase_modelo.enlaza_datagrid(Me.DataGridView1)
            Me.maquinasB.enlaza_datagrid(Me.DataGridView2)
        End If
    End Sub

    Private Sub filtrar_por_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles filtrar_por.SelectedIndexChanged
        Dim i As Integer
        Me.valor_filtro.Items.Clear()
        If Me.filtrar_por.SelectedIndex = 0 Then
            Me.maquinasA.quitar_filtro()
            Me.maquinasB.quitar_filtro()
        End If
        If Me.filtrar_por.SelectedIndex = 1 Then
            While i < Me.datos_empresa.num_datos()
                Me.valor_filtro.Items.Add(Me.datos_empresa.dato_dt(i, 0))
                i = i + 1
            End While
        End If
        If Me.filtrar_por.SelectedIndex = 2 Then
            While i < Me.comunidades.Count
                Me.valor_filtro.Items.Add(Me.comunidades.Item(i))
                i = i + 1
            End While
        End If
    End Sub

    Private Sub valor_filtro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles valor_filtro.SelectedIndexChanged
        Dim texto As String
        If Me.filtrar_por.SelectedIndex = 0 Then
            filtrar.quitar_filtro()
        End If
        If Me.tipo_maquina.SelectedItem = "A" Then
            If Me.filtrar_por.SelectedIndex = 1 Then 'por empresa
                texto = Me.valor_filtro.SelectedItem.ToString
                'la linea de abajo hay que cambiarla
                Me.maquinasA.filtro("empresa='" + texto + "'")
            End If
            If Me.filtrar_por.SelectedIndex = 2 Then 'por comunidad
                texto = Me.valor_filtro.SelectedItem.ToString
                Me.maquinasA.filtro("comunidad='" + texto + "'")
            End If
        ElseIf Me.tipo_maquina.SelectedItem = "B" Then
            If Me.filtrar_por.SelectedIndex = 1 Then 'por empresa
                texto = Me.valor_filtro.SelectedItem.ToString
                'la linea de abajo hay que cambiarla
                Me.maquinasB.filtro("empresa='" + texto + "'")
            End If
            If Me.filtrar_por.SelectedIndex = 2 Then 'por comunidad
                texto = Me.valor_filtro.SelectedItem.ToString
                Me.maquinasB.filtro("comunidad='" + texto + "'")
            End If
        End If
    End Sub

    Private Sub eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminar.Click
        Dim texto As String
        Dim seleccionado, r1 As Integer
        If (Me.DataGridView2.SelectedCells.Count > 0) Then
            If Me.DataGridView2.SelectedCells(0).RowIndex < Me.DataGridView2.Rows.Count - 1 Then
                seleccionado = Me.DataGridView2.SelectedCells(0).RowIndex
                texto = Me.DataGridView2.Rows(seleccionado).Cells(0).Value.ToString
                r1 = clase_guardar.inicializa(Form1.clase_datos_global, "delete from maquina where n_serie='" + texto + "'", 2)
                If r1 = 0 Then
                    MsgBox("No se ha podido eliminar la maquina, estara relacionada con otra tabla")
                End If
                inicializa_datagrid()
            End If
            'texto = e.Row.Cells.Item(0).Value.ToString

            '       texto=

        End If
    End Sub

    Private Sub empresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles empresa.SelectedIndexChanged
        'ponemos en la comunidad la comunidad de la empresa
        Dim i, encontrado As Integer
        i = 0
        encontrado = 0
        While i < Me.comunidad.Items.Count And encontrado = 0
            If Me.comunidad.Items(i).ToString = Me.datos_empresa.dato_dt(Me.empresa.SelectedIndex, 2).ToString Then
                encontrado = 1
                Me.comunidad.SelectedIndex = i
            End If
            i = i + 1
        End While
    End Sub
    Private Sub DataGridView2_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.SelectionChanged
        'ponemos los datos de la fila seleccionada en los controles
        Dim seleccionado As Integer
        If Me.DataGridView2.SelectedCells.Count > 0 Then
            If Me.DataGridView2.SelectedCells(0).RowIndex < Me.DataGridView2.Rows.Count - 1 Then
                seleccionado = Me.DataGridView2.SelectedCells(0).RowIndex
                'el tipo de maquina no lo cambiamos
                Me.comunidad.Text = Me.DataGridView2.Rows(seleccionado).Cells(2).Value.ToString
                Me.empresa.Text = Me.DataGridView2.Rows(seleccionado).Cells(3).Value.ToString
                Me.serie_año.Text = Microsoft.VisualBasic.Left(Me.DataGridView2.Rows(seleccionado).Cells(0).Value.ToString, 2)
                Me.serie_numero.Text = Mid(Me.DataGridView2.Rows(seleccionado).Cells(0).Value.ToString, 3)
                Me.l_nombre.Text = Me.DataGridView2.Rows(seleccionado).Cells(1).Value.ToString
            End If
        End If
    End Sub




End Class