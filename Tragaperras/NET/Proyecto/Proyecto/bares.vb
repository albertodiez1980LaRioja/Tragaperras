Public Class bares
    Dim datos_comunidad, datos_empresas, datos_bares, datos_b_d, datos_guardar, datos_dueños, datos_enparentados As New clase_tabla
    Dim numeros_empresas As New ArrayList
    Dim indice_seleccionado As Integer = -1
    Sub inicializa_datagrid()
        datos_bares.inicializa(Form1.clase_datos_global, "select bar.nombre,n_fiscal_bar as [numero fiscal],empresa.nombre as [empresa explotadora],bar.nombre_comunidad as comunidad,calle,numero,tipo_via as tipo,fecha_i_contrato as [fecha de contrato],fecha_f_contrato as [finalizacion de contrato],fecha_i_licencia as [fecha de licencia],fecha_f_licencia as [fin de licencia]  from bar,empresa where bar.n_fiscal_empresa=empresa.n_fiscal_empresa", 3)
        datos_bares.enlaza_datagrid(Me.DataGridView1)
        datos_bares.enlaza_datagrid(Me.DataGridView2)
        datos_dueños.inicializa(Form1.clase_datos_global, "select nombre,dni_dueño as [dni],tlf as telefono from dueño", 3)
        datos_dueños.enlaza_datagrid(Me.DataGridView3)
        datos_enparentados.inicializa(Form1.clase_datos_global, "select bar.nombre as [nombre],bar.nombre_comunidad as comunidad,dueño.nombre as [nombre del dueño],dueño.tlf as telefono,dueño.dni_dueño as dni,bar.n_fiscal_bar as cif,empresa.nombre as [empresa explotadora] from bar,b_d,dueño,empresa where bar.n_fiscal_empresa=empresa.n_fiscal_empresa  and bar.n_fiscal_bar=b_d.n_fiscal_bar and b_d.dni_dueño=dueño.dni_dueño order by bar.nombre", 5)
        datos_b_d.inicializa(Form1.clase_datos_global, "select * from b_d", 2)
        Me.tipo_via.SelectedIndex = 0
        If Me.c_mostrar_enparentados.Checked = True Then
            Me.datos_enparentados.enlaza_datagrid(Me.DataGridView2)
        End If
    End Sub

    Private Sub bares_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Form1.Show()
    End Sub

    Private Sub bares_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'las tablas comunidad y empresa no cambian en este formulario
        datos_comunidad.inicializa(Form1.clase_datos_global, "select nombre_comunidad from comunidad_autonoma", 1)
        datos_empresas.inicializa(Form1.clase_datos_global, "select nombre,n_fiscal_empresa,nombre_comunidad from empresa", 3)
        datos_comunidad.almacena_combobox(Me.comunidad, 0)
        datos_empresas.almacena_combobox(Me.empresa, 0)
        inicializa_datagrid()
        ' Me.comunidad.SelectedIndex = 0
        Me.c_filtrar_por.SelectedIndex = 0
        Me.filtrar_por.SelectedIndex = 0
    End Sub

    Private Sub comunidad_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comunidad.SelectedIndexChanged
        'si marcamos una comunidad solo hay que mostrar las empresas de esa comunidad
        Dim i As Integer = 0
        Dim num_empresas As Integer
        Dim puesto As Integer = 0
        num_empresas = Me.datos_empresas.num_datos
        Me.empresa.Items.Clear()
        Me.numeros_empresas.Clear()
        While i < num_empresas
            If Me.comunidad.SelectedItem.ToString = Me.datos_empresas.dato_dt(i, 2) Then
                Me.empresa.Items.Add(Me.datos_empresas.dato_dt(i, 0))
                Me.numeros_empresas.Add(Me.datos_empresas.dato_dt(i, 1))
                puesto = 1
            End If
            i = i + 1
        End While
        If puesto = 1 Then
            Me.empresa.SelectedIndex = 0
        End If
    End Sub

    Private Sub empresa_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles empresa.SelectedIndexChanged
        'seleccionamos la comunidad de esa empresa
        Dim i As Integer = 0
        Dim encontrado As Integer = 0
        While (i < Me.comunidad.Items.Count And encontrado = 0)
            If Me.comunidad.Items(i).ToString = Me.empresa.SelectedItem.ToString Then
                encontrado = 1
                Me.comunidad.SelectedIndex = i
            End If
            i = i + 1
        End While
    End Sub

    Function validar()
        'comprobamos que todos los datos estan bien
        'evidentemente esto se podria mejorar
        'comprobamos que encajan la comunidad del bar con la comunidad de la empresa
        Dim fechatext As String
        If (Me.nombre_bar.Text = "" Or Me.m_cif.Text = "" Or Me.comunidad.Text = "") Then
            MsgBox("No estan todos los campos completos")
            Return 0
        End If
        If (Me.empresa.Text = "" Or Me.calle.Text = "" Or Me.numero.Text = "" Or Me.tipo_via.Text = "") Then
            MsgBox("No estan todos los campos completos")
            Return 0
        End If
        'comprobamos que las fechas estan bien
        fechatext = Me.m_i_c_dia.Text + "/" + m_i_c_mes.Text + "/" + m_i_c_año.Text
        If (Not IsDate(fechatext)) Then
            MsgBox("la fecha de inicio de contrato no es valida")
            Return 0
        End If
        fechatext = Me.m_f_c_dia.Text + "/" + m_f_c_mes.Text + "/" + m_f_c_año.Text
        If (Not IsDate(fechatext)) Then
            MsgBox("la fecha de fin de contrato no es valida")
            Return 0
        End If
        fechatext = Me.m_i_l_dia.Text + "/" + m_i_l_mes.Text + "/" + m_i_l_año.Text
        If (Not IsDate(fechatext)) Then
            MsgBox("la fecha de inicio de licencia no es valida")
            Return 0
        End If
        fechatext = Me.m_f_l_dia.Text + "/" + m_f_l_mes.Text + "/" + m_f_l_año.Text
        If (Not IsDate(fechatext)) Then
            MsgBox("la fecha de fin de licencia no es valida")
            Return 0
        End If
        'MsgBox(Me.comunidad.SelectedItem.ToString + " " + Me.numeros_empresas.Item(Me.empresa.SelectedIndex).ToString)
        'If Me.comunidad.SelectedItem.ToString <> Me.numeros_empresas.Item(Me.empresa.SelectedIndex).ToString Then
        '    MsgBox("No coincide la comunidad del bar con la comunidad de la empresa")
        '    Return 0
        'End If
        Return 1

    End Function

    Private Sub b_insertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_insertar.Click
        Dim i As Integer
        Dim texto As String
        Dim encontrado As Integer = 0
        Dim fecha_i_contrato, fecha_f_contrato, fecha_i_licencia, fecha_f_licencia As String
        If validar() = 1 Then
            'hacemos lo correspondiente
            fecha_i_contrato = Me.m_i_c_dia.Text + "/" + m_i_c_mes.Text + "/" + m_i_c_año.Text
            fecha_f_contrato = Me.m_f_c_dia.Text + "/" + m_f_c_mes.Text + "/" + m_f_c_año.Text
            fecha_i_licencia = Me.m_i_l_dia.Text + "/" + m_i_l_mes.Text + "/" + m_i_l_año.Text
            fecha_f_licencia = Me.m_f_l_dia.Text + "/" + m_f_l_mes.Text + "/" + m_f_l_año.Text
            i = 0
            While i < Me.datos_bares.num_datos() And encontrado = 0
                If Me.datos_bares.dato_dt(i, 1) = Me.m_cif.Text Then
                    encontrado = 1
                End If
                i = i + 1
            End While

            If encontrado = 1 Then
                texto = "update bar set nombre='" + Me.nombre_bar.Text + "',n_fiscal_empresa='" + (Me.numeros_empresas.Item(Me.empresa.SelectedIndex)).ToString + "',nombre_comunidad='" + Me.comunidad.Text + "',calle='" + Me.calle.Text + "',numero=" + numero.Text + ",tipo_via=" + tipo_via.SelectedIndex.ToString + ",fecha_i_contrato='" + fecha_i_contrato.ToString + "',fecha_f_contrato='" + fecha_f_contrato.ToString + "',fecha_i_licencia='" + fecha_i_licencia.ToString + "',fecha_f_licencia='" + fecha_f_licencia.ToString + "' where n_fiscal_bar='" + Me.m_cif.Text + "'"
                'MsgBox(texto)
                Me.datos_guardar.inicializa(Form1.clase_datos_global, texto, 1)
            End If
            If encontrado = 0 Then
                texto = "insert into bar values ('" + Me.m_cif.Text + "','" + Me.nombre_bar.Text + "','" + (Me.numeros_empresas.Item(Me.empresa.SelectedIndex)).ToString + "','" + Me.comunidad.Text + "','" + Me.calle.Text + "'," + numero.Text + "," + tipo_via.SelectedIndex.ToString + ",'" + fecha_i_contrato.ToString + "','" + fecha_f_contrato.ToString + "','" + fecha_i_licencia.ToString + "','" + fecha_f_licencia.ToString + "')"
                Me.datos_guardar.inicializa(Form1.clase_datos_global, texto, 2)
            End If
            inicializa_datagrid()
            'una vez que esta hecho hay que eliminar los datos y poner el foco al principio
            vacia()
        End If
    End Sub

    Sub vacia()
        Dim c As Control
        For Each c In Me.tab_bares.Controls
            If (0 < CType(c.TabIndex, Integer) And 19 > CType(c.TabIndex, Integer)) Then
                c.Text = ""
            End If
        Next
        Me.tipo_via.SelectedIndex = 0 'que sea tipo calle es lo mas tipico
        Me.nombre_bar.Focus()
    End Sub
    
    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        Dim fecha As Date
        If e.RowIndex < Me.DataGridView1.RowCount - 1 Then
            Me.indice_seleccionado = e.RowIndex
            Me.nombre_bar.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            Me.m_cif.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            Me.comunidad.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
            Me.calle.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
            Me.numero.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
            Me.tipo_via.SelectedIndex = Me.DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
            fecha = Me.DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
            Me.m_i_c_dia.Text = fecha.Day.ToString
            Me.m_i_c_mes.Text = fecha.Month.ToString
            Me.m_i_c_año.Text = fecha.Year.ToString
            fecha = Me.DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString
            Me.m_f_c_dia.Text = fecha.Day.ToString
            Me.m_f_c_mes.Text = fecha.Month.ToString
            Me.m_f_c_año.Text = fecha.Year.ToString
            fecha = Me.DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString
            Me.m_i_l_dia.Text = fecha.Day.ToString
            Me.m_i_l_mes.Text = fecha.Month.ToString
            Me.m_i_l_año.Text = fecha.Year.ToString
            fecha = Me.DataGridView1.Rows(e.RowIndex).Cells(10).Value.ToString
            Me.m_f_l_dia.Text = fecha.Day.ToString
            Me.m_f_l_mes.Text = fecha.Month.ToString
            Me.m_f_l_año.Text = fecha.Year.ToString
            Me.empresa.SelectedItem = Me.DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
        End If
    End Sub

    Sub elimina_fila(ByVal indice As Integer)
        Dim texto As String
        texto = "delete from bar where n_fiscal_bar='" + Me.DataGridView1.Rows(indice).Cells(1).Value.ToString + "'"
        Me.datos_guardar.inicializa(Form1.clase_datos_global, texto, 1)
        inicializa_datagrid()
    End Sub

    Private Sub B_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_eliminar.Click
        elimina_fila(Me.indice_seleccionado)
    End Sub

    Private Sub DataGridView1_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGridView1.UserDeletedRow
        inicializa_datagrid()
    End Sub

    Private Sub DataGridView1_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DataGridView1.UserDeletingRow
        Dim texto As String
        If e.Row.Cells.Count > 0 Then
            texto = e.Row.Cells(1).Value.ToString
            Me.datos_guardar.inicializa(Form1.clase_datos_global, "delete from bar where n_fiscal_bar='" + texto.ToString + "'", 1)
        End If
    End Sub

    Private Sub B_actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_actualizar.Click
        Dim validado, i, encontrado As Integer
        'primero hay que validar
        validado = 1
        If Me.t_nombre_propietario.Text = "" Or Me.t_dni_propietario.Text = "" Or Me.t_telefono_dni.Text = "" Then
            MsgBox("Hay campos incompletos")
            validado = 0
        End If
        If validado = 1 Then
            i = 0
            encontrado = 0
            While i < Me.datos_dueños.num_datos And encontrado = 0
                If (Me.t_dni_propietario.Text = Me.datos_dueños.dato_dt(i, 1)) Then
                    encontrado = 1
                End If
                i = i + 1
            End While
            If encontrado = 1 Then
                Me.datos_guardar.inicializa(Form1.clase_datos_global, "update dueño set nombre='" + Me.t_nombre_propietario.Text + "',tlf='" + Me.t_telefono_dni.Text + "' where dni_dueño='" + Me.t_dni_propietario.Text + "'", 2)
            End If
            If encontrado = 0 Then
                Me.datos_guardar.inicializa(Form1.clase_datos_global, "insert into dueño values ('" + Me.t_dni_propietario.Text + "','" + Me.t_nombre_propietario.Text + "','" + Me.t_telefono_dni.Text + "')", 3)
            End If
            vacia_dueño()
            inicializa_datagrid()
        End If
    End Sub


    Private Sub nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevo.Click
        vacia()
    End Sub

    Private Sub c_filtrar_por_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c_filtrar_por.SelectedIndexChanged
        'hacemos los cambios en el listbox
        Dim i As Integer
        If Me.c_filtrar_por.SelectedItem <> Nothing Then
            If Me.c_filtrar_por.SelectedItem.ToString = "empresa" Then
                Me.filtro_valor.Items.Clear()
                For i = 0 To Me.datos_empresas.num_datos - 1
                    Me.filtro_valor.Items.Add(Me.datos_empresas.dato_dt(i, 0).ToString)
                Next
                Me.filtro_valor.SelectedIndex = 0
            ElseIf Me.c_filtrar_por.SelectedItem.ToString = "comunidad" Then
                Me.filtro_valor.Items.Clear()
                For i = 0 To Me.datos_comunidad.num_datos - 1
                    Me.filtro_valor.Items.Add(Me.datos_comunidad.dato_dt(i, 0).ToString)
                Next
                Me.filtro_valor.SelectedIndex = 0
            Else
                'damos por hecho que se ha escogido "todos"
                Me.datos_bares.quitar_filtro()
                Me.filtro_valor.Items.Clear()
                Me.filtro_valor.Text = ""
            End If
        End If
    End Sub

    Private Sub filtro_valor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filtro_valor.SelectedIndexChanged
        If Me.c_filtrar_por.SelectedItem <> Nothing And Me.filtro_valor.SelectedItem <> Nothing Then
            If Me.c_filtrar_por.SelectedItem.ToString = "empresa" Then
                Me.datos_bares.filtro("[empresa explotadora]='" + Me.filtro_valor.SelectedItem.ToString + "'")
            ElseIf Me.c_filtrar_por.SelectedItem.ToString = "comunidad" Then
                Me.datos_bares.filtro("comunidad='" + Me.filtro_valor.SelectedItem.ToString + "'")
            End If
        End If

    End Sub

    'AHORA LE TOCA EL TURNO AL OTRO TABPAGE, EL DE LOS DUEÑOS

    Private Sub tab_dueños_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tab_dueños.Enter
        Me.c_filtrar_por.SelectedIndex = 0
        'con esto se origina el evento que llama a la funcion de arriba y quita el filtro
    End Sub


    Private Sub B_enparentar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_enparentar.Click
        'detectamos las filas seleccionadas y creamos la fila en la tabla b_d
        Dim bar, dueño, i As Integer
        Dim texto As String
        Dim existe As String
        If Me.DataGridView2.SelectedCells.Count > 0 And Me.DataGridView3.SelectedCells.Count > 0 Then
            bar = Me.DataGridView2.SelectedCells(0).RowIndex
            dueño = Me.DataGridView3.SelectedCells(0).RowIndex
            existe = 0
            i = 0
            If bar < Me.DataGridView2.Rows.Count - 1 And dueño < Me.DataGridView3.Rows.Count - 1 And Me.c_mostrar_enparentados.Checked = False Then
                While i < Me.datos_b_d.num_datos And existe = 0
                    If (Me.datos_b_d.dato_dt(i, 1) = Me.DataGridView3.Rows(dueño).Cells(1).Value.ToString) Then
                        If (Me.datos_b_d.dato_dt(i, 0) = Me.DataGridView2.Rows(bar).Cells(1).Value.ToString) Then
                            existe = 1
                        End If
                    End If
                    i = i + 1
                End While
                If (existe = 0) Then
                    texto = "insert into b_d values('" + Me.DataGridView2.Rows(bar).Cells(1).Value.ToString + "','" + Me.DataGridView3.Rows(dueño).Cells(1).Value.ToString + "')"
                    'MsgBox(texto)
                    Me.datos_guardar.inicializa(Form1.clase_datos_global, texto, 4)
                    inicializa_datagrid()
                End If
            End If
        End If
    End Sub


    Private Sub c_mostrar_enparentados_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles c_mostrar_enparentados.CheckedChanged
        'lo primero de todo tenemos que comprobar que es true
        If Me.c_mostrar_enparentados.Checked = True Then
            Me.datos_enparentados.enlaza_datagrid(Me.DataGridView2)
            Me.B_enparentar.Visible = False
        Else
            Me.datos_bares.enlaza_datagrid(Me.DataGridView2)
            Me.B_enparentar.Visible = True
        End If
    End Sub

    Private Sub B_desenparentar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_desenparentar.Click
        'detectamos las filas seleccionadas y creamos la fila en la tabla b_d
        Dim bar, dueño, i As Integer
        Dim existe As String
        bar = Me.DataGridView2.SelectedCells(0).RowIndex
        dueño = Me.DataGridView3.SelectedCells(0).RowIndex
        existe = 0
        i = 0
        If bar < Me.DataGridView2.Rows.Count - 1 And dueño < Me.DataGridView3.Rows.Count - 1 And Me.c_mostrar_enparentados.Checked = False Then
            While i < Me.datos_b_d.num_datos And existe = 0
                If (Me.datos_b_d.dato_dt(i, 1) = Me.DataGridView3.Rows(dueño).Cells(1).Value.ToString) Then
                    If (Me.datos_b_d.dato_dt(i, 0) = Me.DataGridView2.Rows(bar).Cells(1).Value.ToString) Then
                        existe = 1
                    End If
                End If
                i = i + 1
            End While
            If (existe = 1) Then
                Me.datos_guardar.inicializa(Form1.clase_datos_global, "delete from b_d where b_d.n_fiscal_bar='" + Me.DataGridView2.Rows(bar).Cells(1).Value.ToString + "' and b_d.dni_dueño='" + Me.DataGridView3.Rows(dueño).Cells(1).Value.ToString + "'", 2)
                inicializa_datagrid()
            End If
        End If
        If bar < Me.DataGridView2.Rows.Count - 1 And Me.c_mostrar_enparentados.Checked = True Then
            'en este caso tenemos que eliminar la fila
            '    MsgBox("se llega")
            Me.datos_guardar.inicializa(Form1.clase_datos_global, "delete from b_d where b_d.n_fiscal_bar='" + Me.DataGridView2.Rows(bar).Cells(5).Value.ToString + "' and b_d.dni_dueño='" + Me.DataGridView2.Rows(bar).Cells(4).Value.ToString + "'", 2)
            inicializa_datagrid()
        End If
    End Sub

    Private Sub B_eliminar_dueño_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_eliminar_dueño.Click
        Dim i, encontrado, dueño As Integer
        i = 0
        encontrado = 0
        dueño = Me.DataGridView3.SelectedCells(0).RowIndex
        If dueño < Me.DataGridView3.Rows.Count - 1 Then
            While i < Me.datos_b_d.num_datos() And encontrado = 0
                'ahi que asegurarse de que no hay ninguna relacion
                If (Me.datos_b_d.dato_dt(i, 1) = Me.DataGridView3.Rows(dueño).Cells(1).Value.ToString) Then
                    encontrado = 1
                End If
                i = i + 1
            End While
            If encontrado = 0 Then
                Me.datos_guardar.inicializa(Form1.clase_datos_global, "delete from dueño where dni_dueño='" + Me.DataGridView3.Rows(dueño).Cells(1).Value.ToString + "'", 2)
            Else
                MsgBox("No se puede eliminar por que es usuario de un bar")
            End If
        End If
        inicializa_datagrid()
        vacia_dueño()
    End Sub



    Private Sub DataGridView2_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.RowEnter
        'MsgBox("Se ha entrado")
        If Me.c_mostrar_enparentados.Checked = True Then
            'hacemos un filter con los dueños de ese bar
        End If
    End Sub

    Private Sub filtrar_por_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filtrar_por.SelectedIndexChanged
        If Me.filtrar_por.SelectedItem <> Nothing Then
            If Me.filtrar_por.SelectedItem.ToString = "empresa" Then
                Me.datos_empresas.almacena_combobox_completa(Me.filtro_valor_dueños, 0)
                If Me.filtro_valor_dueños.Items.Count > 0 Then
                    Me.filtro_valor_dueños.SelectedIndex = 0
                End If
            ElseIf Me.filtrar_por.SelectedItem.ToString = "comunidad" Then
                Me.datos_comunidad.almacena_combobox_completa(Me.filtro_valor_dueños, 0)
                If Me.filtro_valor_dueños.Items.Count > 0 Then
                    Me.filtro_valor_dueños.SelectedIndex = 0
                End If
            ElseIf Me.filtrar_por.SelectedItem.ToString = "dueño" Then
                Me.datos_dueños.almacena_combobox_completa(Me.filtro_valor_dueños, 0)
                If Me.filtro_valor_dueños.Items.Count > 0 Then
                    Me.filtro_valor_dueños.SelectedIndex = 0
                End If
            ElseIf Me.filtrar_por.SelectedItem.ToString = "bar" Then
                Me.datos_bares.almacena_combobox_completa(Me.filtro_valor_dueños, 0)
                If Me.filtro_valor_dueños.Items.Count > 0 Then
                    Me.filtro_valor_dueños.SelectedIndex = 0
                End If

            Else
                Me.filtro_valor_dueños.Items.Clear()
                Me.filtro_valor_dueños.AutoCompleteCustomSource.Clear()
                Me.filtro_valor_dueños.Text = ""
                Me.datos_bares.quitar_filtro()
                Me.datos_enparentados.quitar_filtro()
            End If


        End If
    End Sub

    Private Sub filtro_valor_dueños_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filtro_valor_dueños.SelectedIndexChanged
        If Me.filtro_valor_dueños.SelectedItem <> Nothing And Me.filtrar_por.SelectedItem <> Nothing And Me.c_mostrar_enparentados.Checked = False Then
            If Me.filtrar_por.SelectedItem.ToString = "empresa" Then
                Me.datos_bares.filtro("[empresa explotadora]='" + Me.filtro_valor_dueños.SelectedItem + "'")
            ElseIf Me.filtrar_por.SelectedItem.ToString = "comunidad" Then
                Me.datos_bares.filtro("[comunidad]='" + Me.filtro_valor_dueños.SelectedItem + "'")
            ElseIf Me.filtrar_por.SelectedItem.ToString = "dueño" Then
                Me.c_mostrar_enparentados.Checked = True
                Me.datos_enparentados.enlaza_datagrid(Me.DataGridView2)
                Me.B_enparentar.Visible = False
            ElseIf Me.filtrar_por.SelectedItem.ToString = "bar" Then
                Me.datos_bares.filtro("[nombre]='" + Me.filtro_valor_dueños.SelectedItem + "'")
            End If
        End If

        If Me.filtro_valor_dueños.SelectedItem <> Nothing And Me.filtrar_por.SelectedItem <> Nothing And Me.c_mostrar_enparentados.Checked = True Then
            If Me.filtrar_por.SelectedItem.ToString = "empresa" Then
                Me.datos_enparentados.filtro("[empresa explotadora]='" + Me.filtro_valor_dueños.SelectedItem + "'")
            ElseIf Me.filtrar_por.SelectedItem.ToString = "comunidad" Then
                Me.datos_enparentados.filtro("[comunidad]='" + Me.filtro_valor_dueños.SelectedItem + "'")
            ElseIf Me.filtrar_por.SelectedItem.ToString = "dueño" Then
                Me.datos_enparentados.filtro("[nombre del Dueño]='" + Me.filtro_valor_dueños.SelectedItem + "'")
            ElseIf Me.filtrar_por.SelectedItem.ToString = "bar" Then
                Me.datos_enparentados.filtro("[nombre]='" + Me.filtro_valor_dueños.SelectedItem + "'")
            End If
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Me.datos_bares.quitar_filtro()
        Me.datos_enparentados.quitar_filtro()
        Me.filtrar_por.SelectedIndex = 0
    End Sub

    Private Sub DataGridView3_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView3.SelectionChanged
        Dim seleccionado As Integer
        If Me.DataGridView3.SelectedCells.Count > 0 Then
            If Me.DataGridView3.SelectedCells(0).RowIndex < Me.DataGridView3.Rows.Count - 1 Then
                seleccionado = Me.DataGridView3.SelectedCells(0).RowIndex
                Me.t_nombre_propietario.Text = Me.DataGridView3.Rows(seleccionado).Cells(0).Value.ToString
                Me.t_dni_propietario.Text = Me.DataGridView3.Rows(seleccionado).Cells(1).Value.ToString
                Me.t_telefono_dni.Text = Me.DataGridView3.Rows(seleccionado).Cells(2).Value.ToString
            End If

        End If
    End Sub

    Sub vacia_dueño()
        Me.t_nombre_propietario.Text = ""
        Me.t_dni_propietario.Text = ""
        Me.t_telefono_dni.Text = ""
        Me.t_nombre_propietario.Focus()
    End Sub

    Private Sub nuevo_dueño_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevo_dueño.Click
        vacia_dueño()
    End Sub
End Class