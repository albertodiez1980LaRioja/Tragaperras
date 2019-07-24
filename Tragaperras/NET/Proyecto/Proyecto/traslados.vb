Public Class traslados
    Dim datos_bar, datos_maquina, datos_guardar, datos_m_b, datos_maquinas_instaladas, datos_maquinas_antiguas As New clase_tabla
    Dim datos_empresas, datos_comunidad As New clase_tabla
    Dim datos_visualizar As New clase_tabla
    Dim actualizando = 0
    Dim texto_filtro As String = "hola"
    Private Sub traslados_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Form1.Show()
    End Sub

    Sub inicializa_datagrid()
        actualizando = 1
        Me.datos_maquinas_antiguas.inicializa(Form1.clase_datos_global, "select maquina.nombre_modelo as maquina,maquina.n_serie as [serie maquina],bar.nombre as bar,bar.n_fiscal_bar as [cif bar],fecha_instalacion as [fecha instalacion],fecha_retirada as [retirada],tasas_pagadas as [tasas pagadas],empresa.nombre as empresa,empresa.nombre_comunidad as comunidad from m_b,bar,maquina,empresa where bar.n_fiscal_bar=m_b.n_fiscal_bar and m_b.n_serie=maquina.n_serie and maquina.n_fiscal_empresa=empresa.n_fiscal_empresa and fecha_retirada>=fecha_instalacion", 3)
        Me.datos_maquinas_antiguas.enlaza_datagrid(Me.D_maquinas_antiguas)
        Me.datos_maquina.inicializa(Form1.clase_datos_global, "select nombre_modelo,n_serie,maquina.nombre_comunidad as comunidad,empresa.nombre as [empresa],maquina.n_fiscal_empresa as [cif empresa] from maquina,empresa where maquina.n_fiscal_empresa=empresa.n_fiscal_empresa", 5)
        Me.datos_maquina.enlaza_datagrid(Me.D_maquinas)
        Me.datos_maquinas_instaladas.inicializa(Form1.clase_datos_global, "select n_fiscal_bar,n_serie,fecha_instalacion from m_b where fecha_retirada<fecha_instalacion", 3)
        Me.datos_visualizar.inicializa(Form1.clase_datos_global, "select maquina.nombre_modelo as maquina,maquina.n_serie as [serie maquina],bar.nombre as bar,bar.n_fiscal_bar as [cif bar],m_b.n_serie as [num maquina],fecha_instalacion as [fecha instalacion],tasas_pagadas as [tasas pagadas],empresa.nombre as empresa,empresa.nombre_comunidad as comunidad from m_b,bar,maquina,empresa where maquina.n_fiscal_empresa=empresa.n_fiscal_empresa and bar.n_fiscal_bar=m_b.n_fiscal_bar and m_b.n_serie=maquina.n_serie and fecha_retirada<fecha_instalacion", 2)
        Me.datos_visualizar.enlaza_datagrid(Me.D_maquina_desistalar) 'aqui habra que hacer una selección
        Me.datos_m_b.inicializa(Form1.clase_datos_global, "select * from m_b", 6)
        actualizando = 0
        cambia_filtros_retirar()
    End Sub

    Private Sub traslados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.datos_bar.inicializa(Form1.clase_datos_global, "select bar.nombre as [Bar],n_fiscal_bar as cif,bar.nombre_comunidad as comunidad,empresa.nombre as empresa from bar,empresa where bar.n_fiscal_empresa=empresa.n_fiscal_empresa", 3)
        Me.datos_bar.enlaza_datagrid(Me.D_bares)
        Me.datos_bar.enlaza_datagrid(Me.D_antiguos_bares)
        Me.datos_bar.enlaza_datagrid(Me.D_bar_desistalar)
        Me.datos_comunidad.inicializa(Form1.clase_datos_global, "select nombre_comunidad from comunidad_autonoma", 1)
        Me.datos_empresas.inicializa(Form1.clase_datos_global, "select nombre,n_fiscal_empresa,nombre_comunidad from empresa", 3)
        inicializa_datagrid()
        Me.r_bares.Checked = True
        Me.r_bares2.Checked = True
        cambia_filtros_retirar()
        cambia_filtros_retirar2()
        Me.filtrar_desistalacion.SelectedIndex = 0
        Me.filtrar_desistalado.SelectedIndex = 0
        Me.filtrar_instalacion.SelectedIndex = 0
    End Sub

    Function mete_cero(ByVal s As String) As String
        Dim n As Integer
        If IsNumeric(s) Then
            n = CType(s, Integer)
            If n < 10 Then
                Return "0" + s
            Else
                Return s
            End If
        Else
            Return s
        End If
    End Function

    Sub B_instalar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_instalar.Click
        'en este form no hay eliminaciones, aunque tenemos que comprobar que la maquina no este en otro bar, si lo esta
        'hay que crear un aviso y desistalar la maquina de ese var
        'tambien es muy importante que la empresa de la maquina corresponda con la empresa que 
        'tiene contratado el bar (por hacer)
        Dim n_serie, n_fiscal_bar_encontrada, fecha, fecha_encontrada_s, texto As String
        Dim encontrado, i, salir As Integer
        Dim fecha_encontrada As Date
        encontrado = 0
        i = 0
        salir = 0
        n_serie = ""
        n_fiscal_bar_encontrada = ""
        fecha_encontrada_s = ""
        If Me.D_bares.SelectedCells(0).RowIndex < Me.D_bares.Rows.Count - 1 Then
            If Me.D_maquinas.SelectedCells(0).RowIndex < Me.D_maquinas.Rows.Count - 1 Then
                salir = 0
                n_serie = Me.D_maquinas.Rows(Me.D_maquinas.SelectedCells(0).RowIndex).Cells(1).Value.ToString
                While encontrado = 0 And i < Me.datos_maquinas_instaladas.num_datos()
                    If Me.datos_maquinas_instaladas.dato_dt(i, 1) = n_serie Then
                        encontrado = 1
                        n_fiscal_bar_encontrada = Me.datos_maquinas_instaladas.dato_dt(i, 0)
                        'MsgBox(Me.datos_maquinas_instaladas.dato_dt(i, 1).ToString + " " + Me.datos_maquinas_instaladas.num_datos().ToString)
                        fecha_encontrada = Me.datos_maquinas_instaladas.dato_dt(i, 2)
                        fecha_encontrada_s = mete_cero(fecha_encontrada.Day.ToString) + "/" + mete_cero(fecha_encontrada.Month.ToString) + "/" + mete_cero(fecha_encontrada.Year.ToString)
                    End If
                    i = i + 1
                End While
            End If
        End If
        If Me.D_maquinas.Rows(Me.D_maquinas.SelectedCells(0).RowIndex).Cells(2).Value.ToString <> Me.D_bares.Rows(Me.D_bares.SelectedCells(0).RowIndex).Cells(2).Value.ToString Then
            MsgBox("Error, el bar y la maquina no pertenecen a la misma comunidad")
        ElseIf Me.D_maquinas.Rows(Me.D_maquinas.SelectedCells(0).RowIndex).Cells(3).Value.ToString <> Me.D_bares.Rows(Me.D_bares.SelectedCells(0).RowIndex).Cells(3).Value.ToString Then
            MsgBox("Error, el bar y la maquina no pertenecen a la misma empresa")

        ElseIf encontrado = 1 Then
            If MsgBox("Esta maquina ya esta en una ubicación, ¿retirarla?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                salir = 1
            Else
                fecha = mete_cero(Me.f_instalacion.SelectionStart.Day.ToString) + "/" + mete_cero(Me.f_instalacion.SelectionStart.Month.ToString) + "/" + mete_cero(CType(Me.f_instalacion.SelectionStart.Year, String)).ToString
                texto = "update m_b set fecha_retirada='" + fecha.ToString + "'  where (n_serie='" + n_serie.ToString + "' and n_fiscal_bar='" + n_fiscal_bar_encontrada.ToString + "'  and YEAR(fecha_instalacion)=" + fecha_encontrada.Year.ToString + " and YEAR(fecha_retirada)+1=" + fecha_encontrada.Year.ToString + ")"
                Me.datos_guardar.inicializa(Form1.clase_datos_global, texto, 2)
                inicializa_datagrid()
                '    MsgBox(texto)
            End If
        End If
        If salir = 0 Then
            'creamos la instalacion con un insert, la fecha de retirada es menor que la de instalacion
            Dim n_fiscal_bar, fecha_instalacion, fecha_retirada, tasas_pagadas As String
            Dim id As Integer
            tasas_pagadas = 0
            n_fiscal_bar = Me.D_bares.Rows(Me.D_bares.SelectedCells(0).RowIndex).Cells(1).Value.ToString
            fecha_instalacion = mete_cero(Me.f_instalacion.SelectionStart.Day.ToString) + "/" + mete_cero(Me.f_instalacion.SelectionStart.Month.ToString) + "/" + mete_cero(CType(Me.f_instalacion.SelectionStart.Year, String).ToString)
            fecha_retirada = mete_cero(Me.f_instalacion.SelectionStart.Day.ToString) + "/" + mete_cero(Me.f_instalacion.SelectionStart.Month.ToString) + "/" + mete_cero(CType(Me.f_instalacion.SelectionStart.Year - 1, String).ToString)
            id = Me.datos_m_b.num_datos()
            texto = "insert into m_b values ('" + n_fiscal_bar + "','" + n_serie + "','" + fecha_instalacion + "','" + fecha_retirada + "'," + tasas_pagadas.ToString + "," + id.ToString + ")"
            'MsgBox(texto)
            Me.datos_guardar.inicializa(Form1.clase_datos_global, texto, 2)
            inicializa_datagrid()
        End If
    End Sub

    Function encuentra_indice() As Integer
        'esto se podria mejorar, pero vale
        Dim i, indice As Integer
        indice = 0
        For i = 0 To Me.datos_m_b.num_datos
            If indice <= Me.datos_m_b.dato_dt(i, 5) Then
                indice = Me.datos_m_b.dato_dt(i, 5) + 1
            End If
        Next
        Return indice
    End Function

    Private Sub r_bares_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r_bares.CheckedChanged
        cambia_filtros_retirar()
    End Sub

    Sub cambia_filtros_retirar()
        Dim texto As String
        Dim seleccionado = 0
        If Me.actualizando = 0 And Me.TabControl1.SelectedIndex = 1 Then
            If Me.r_bares.Checked = True Then
                Me.datos_bar.quitar_filtro()
            Else
                Me.datos_visualizar.quitar_filtro()
            End If
            If Me.r_bares.Checked = True And Me.D_bar_desistalar.SelectedCells.Count > 0 Then
                If Me.D_bar_desistalar.SelectedCells(0).RowIndex < Me.D_bar_desistalar.Rows.Count - 1 Then
                    texto = Me.D_bar_desistalar.Rows(Me.D_bar_desistalar.SelectedCells(0).RowIndex).Cells(1).Value.ToString
                    texto = "[cif bar]='" + texto + "'"
                    Me.datos_bar.quitar_filtro()
                    Me.datos_visualizar.filtro(texto)
                End If
            ElseIf Me.D_maquina_desistalar.SelectedCells.Count > 0 And Me.r_bares.Checked = False Then
                If Me.D_maquina_desistalar.SelectedCells(0).RowIndex < Me.D_maquina_desistalar.Rows.Count - 1 Then
                    texto = "[cif]='" + Me.D_maquina_desistalar.Rows(Me.D_maquina_desistalar.SelectedCells(0).RowIndex).Cells(3).Value.ToString + "'"
                    Me.datos_bar.filtro(texto.ToString)
                    Me.datos_visualizar.quitar_filtro()
                End If

            End If
        End If
    End Sub

    Private Sub D_bar_desistalar_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles D_bar_desistalar.SelectionChanged
        cambia_filtros_retirar()
    End Sub
    Private Sub D_bar_desistalar_SelectionChanged2(ByVal sender As Object, ByVal e As System.EventArgs) Handles D_maquina_desistalar.SelectionChanged
        cambia_filtros_retirar()
    End Sub

    Private Sub B_retirar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_retirar.Click
        Dim fecha, texto As String
        Dim n_serie, n_fiscal_bar_encontrada, fecha_encontrada_s As String
        If Me.D_maquina_desistalar.SelectedCells.Count > 0 Then
            'Me.datos_visualizar.inicializa(Form1.clase_datos_global, "select maquina.nombre_modelo as maquina,maquina.n_serie as [serie maquina],bar.nombre as bar,bar.n_fiscal_bar as [cif bar],m_b.n_serie as [num maquina],fecha_instalacion as [fecha instalacion],tasas_pagadas as [tasas pagadas] from m_b,bar,maquina where bar.n_fiscal_bar=m_b.n_fiscal_bar and m_b.n_serie=maquina.n_serie and fecha_retirada<fecha_instalacion", 2)
            n_serie = Me.D_maquina_desistalar.Rows(Me.D_maquina_desistalar.SelectedCells(0).RowIndex).Cells(1).Value.ToString
            n_fiscal_bar_encontrada = Me.D_maquina_desistalar.Rows(Me.D_maquina_desistalar.SelectedCells(0).RowIndex).Cells(3).Value.ToString
            fecha_encontrada_s = Me.D_maquina_desistalar.Rows(Me.D_maquina_desistalar.SelectedCells(0).RowIndex).Cells(5).Value.ToString
            fecha = mete_cero(Me.retiron_mc.SelectionStart.Day.ToString) + "/" + mete_cero(Me.retiron_mc.SelectionStart.Month.ToString) + "/" + mete_cero(CType(Me.retiron_mc.SelectionStart.Year, String)).ToString
            texto = "update m_b set fecha_retirada='" + fecha.ToString + "'  where (n_serie='" + n_serie.ToString + "' and n_fiscal_bar='" + n_fiscal_bar_encontrada.ToString + "'  and YEAR(fecha_instalacion)=YEAR('" + fecha_encontrada_s + "') and YEAR(fecha_retirada)+1=YEAR('" + fecha_encontrada_s + "'))"
            MsgBox(texto)
            Me.datos_guardar.inicializa(Form1.clase_datos_global, texto, 2)
            '   Me.datos_bar.quitar_filtro()
            inicializa_datagrid()
        Else
            MsgBox("No hay filas seleccionadas para hacer el proceso")
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Me.r_bares.Checked = True
        Me.r_bares2.Checked = True
        cambia_filtros_retirar()
        cambia_filtros_retirar2()
        Me.filtrar_desistalacion.SelectedIndex = 0
        Me.filtrar_desistalado.SelectedIndex = 0
        Me.filtrar_instalacion.SelectedIndex = 0
    End Sub

    Sub cambia_filtros_retirar2()
        Dim texto As String
        If Me.actualizando = 0 And Me.TabControl1.SelectedIndex = 2 Then
            If Me.r_bares2.Checked = True Then
                Me.datos_bar.quitar_filtro()
            Else
                Me.datos_maquinas_antiguas.quitar_filtro()
            End If
            If Me.r_bares2.Checked = True And Me.D_antiguos_bares.SelectedCells.Count > 0 Then
                If Me.D_antiguos_bares.SelectedCells(0).RowIndex < Me.D_antiguos_bares.Rows.Count - 1 Then
                    texto = Me.D_antiguos_bares.Rows(Me.D_antiguos_bares.SelectedCells(0).RowIndex).Cells(1).Value.ToString
                    texto = "[cif bar]='" + texto + "'"
                    Me.datos_maquinas_antiguas.filtro(texto)
                End If
            ElseIf Me.D_maquinas_antiguas.SelectedCells.Count > 0 And Me.r_bares2.Checked = False Then
                If Me.D_maquinas_antiguas.SelectedCells(0).RowIndex < Me.D_maquinas_antiguas.Rows.Count - 1 Then
                    texto = Me.D_maquinas_antiguas.Rows(Me.D_maquinas_antiguas.SelectedCells(0).RowIndex).Cells(3).Value.ToString
                    Me.datos_bar.filtro("[cif]='" + texto + "'")
                End If
            End If
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r_bares2.CheckedChanged
        cambia_filtros_retirar2()
    End Sub

    

    Private Sub D_antiguos_bares_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles D_antiguos_bares.SelectionChanged, D_maquinas_antiguas.SelectionChanged
        cambia_filtros_retirar2()
    End Sub

    Private Sub Tab_instalacion_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tab_instalacion.Enter
        Me.r_bares.Checked = True
        Me.r_bares2.Checked = True
        cambia_filtros_retirar()
        cambia_filtros_retirar2()
        Me.datos_bar.quitar_filtro()
    End Sub

    
    Private Sub filtro_inslalar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filtro_inslalar.SelectedIndexChanged, filtro_desistalado.SelectedIndexChanged, filtro_desistalar.SelectedIndexChanged
        Dim s As ComboBox
        s = CType(sender, ComboBox)
        If s.Name = "filtro_inslalar" Then
            'datos_bar y datos_maquina
            Me.datos_bar.filtro(Me.texto_filtro + "'" + s.SelectedItem.ToString + "'")
            If Me.texto_filtro <> "bar=" Then
                Me.datos_maquina.filtro(Me.texto_filtro + "'" + s.SelectedItem.ToString + "'")
            End If
        ElseIf s.Name = "filtro_desistalar" Then
            Me.datos_bar.filtro(Me.texto_filtro + "'" + s.SelectedItem.ToString + "'")
            Me.datos_visualizar.filtro(Me.texto_filtro + "'" + s.SelectedItem.ToString + "'")
        ElseIf s.Name = "filtro_desistalado" Then
            Me.datos_bar.filtro(Me.texto_filtro + "'" + s.SelectedItem.ToString + "'")
            Me.datos_maquinas_antiguas.filtro(Me.texto_filtro + "'" + s.SelectedItem.ToString + "'")
            'este si que tiene campo bar
        End If

    End Sub

    Private Sub filtrar_instalacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filtrar_instalacion.SelectedIndexChanged, filtrar_desistalado.SelectedIndexChanged, filtrar_desistalacion.SelectedIndexChanged
        Dim combo, s As ComboBox
        s = CType(sender, ComboBox)
        If s.Name = "filtrar_instalacion" Then
            combo = Me.filtro_inslalar
        ElseIf s.Name = "filtrar_desistalacion" Then
            combo = Me.filtro_desistalar
        Else
            combo = Me.filtro_desistalado
        End If
        Me.actualizando = 1
        If s.SelectedItem <> Nothing Then
            If s.SelectedItem.ToString = "Comunidad" Then
                Me.texto_filtro = "comunidad="
                Me.datos_comunidad.almacena_combobox_completa(combo, 0)
            ElseIf s.SelectedItem.ToString = "Empresa" Then
                Me.texto_filtro = "empresa="
                Me.datos_empresas.almacena_combobox_completa(combo, 0)
            ElseIf s.SelectedItem.ToString = "Bar" Then
                Me.texto_filtro = "bar="
                '      Me.texto_filtro = "empresa="
                Me.datos_bar.almacena_combobox_completa(combo, 0)
            Else
                combo.Items.Clear()
                combo.AutoCompleteCustomSource.Clear()
                combo.Text = ""
                Me.datos_bar.quitar_filtro()
                Me.datos_maquina.quitar_filtro()
                Me.actualizando = 0
            End If
        End If
    End Sub

    
End Class