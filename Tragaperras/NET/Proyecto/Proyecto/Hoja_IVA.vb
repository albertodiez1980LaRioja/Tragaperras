Public Class Hoja_IVA
    Dim datos_empresas, datos_bares, datos_albaranes As New clase_tabla
    Dim inicializado As Integer = 0
    Dim numpaginas As Integer = 2
    Dim semestre_texto As String
    Private Sub Hoja_IVA_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Form1.Show()
    End Sub

    Private Sub Hoja_IVA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.datos_bares.inicializa(Form1.clase_datos_global, "select nombre,n_fiscal_bar from bar", 2)
        Me.datos_empresas.inicializa(Form1.clase_datos_global, "select nombre,n_fiscal_empresa from empresa", 2)
        Me.año.Text = Now().Year.ToString

        Me.filtrar_por.SelectedIndex = 0
        If Now().Month < 4 Then
            Me.Semestre.SelectedIndex = 0
        ElseIf Now().Month < 7 Then
            Me.Semestre.SelectedIndex = 1
        ElseIf Now().Month < 10 Then
            Me.Semestre.SelectedIndex = 2
        ElseIf Now().Month <= 12 Then
            Me.Semestre.SelectedIndex = 3
        End If
        inicializado = 1
        calcula_copias()
    End Sub


    Sub calcula_copias()
        Dim texto, fi, ff, aux As String
        Dim fecha_inicio, fecha_fin As Date
        aux = CType(Me.año.Text, Integer)
        fi = ""
        ff = ""
        If Me.Semestre.SelectedIndex = 0 Then
            fi = "01" + "/" + "01" + "/" + aux
            ff = "31" + "/" + "03" + "/" + aux
            Me.semestre_texto = "primero"
        End If
        If Me.Semestre.SelectedIndex = 1 Then
            fi = "01" + "/" + "04" + "/" + aux
            ff = "30" + "/" + "06" + "/" + aux
            Me.semestre_texto = "segundo"
        End If
        If Me.Semestre.SelectedIndex = 2 Then
            fi = "01" + "/" + "07" + "/" + aux
            ff = "30" + "/" + "09" + "/" + aux
            Me.semestre_texto = "tercero"
        End If
        If Me.Semestre.SelectedIndex = 3 Then
            fi = "01" + "/" + "10" + "/" + aux
            ff = "31" + "/" + "12" + "/" + aux
            Me.semestre_texto = "cuarto"
        End If
        fecha_inicio = fi
        fecha_fin = ff
        texto = "select sum(entrada_bar) as [Recaudacion total], bar.nombre as bar,empresa.nombre as empresa,empresa.nombre_comunidad as comunidad,'" + fi + "' as [fecha inicio],'" + ff + "' as [fecha fin],'" + Me.semestre_texto + "' as Semestre "
        texto = texto + "from albaran,maquina,m_b,bar,empresa where albaran.n_serie=maquina.n_serie and m_b.n_serie=maquina.n_serie "
        texto = texto + " and m_b.n_fiscal_bar=bar.n_fiscal_bar and albaran.fecha>=m_b.fecha_instalacion and (m_b.fecha_instalacion>m_b.fecha_retirada or albaran.fecha<m_b.fecha_retirada)"
        texto = texto + " and maquina.n_fiscal_empresa=empresa.n_fiscal_empresa "
        '        texto = texto + " and year(albaran.fecha)>='" + fecha_inicio.Year.ToString + "' and month(albaran.fecha)>='" + fecha_inicio.Month.ToString + "' and day(albaran.fecha)>='" + fecha_inicio.Day.ToString + "' "
        '       texto = texto + " and year(albaran.fecha)<='" + fecha_fin.Year.ToString + "' and month(albaran.fecha)<='" + fecha_fin.Month.ToString + "' and day(albaran.fecha)<='" + fecha_fin.Day.ToString + "' "
        texto = texto + " and year(albaran.fecha)>=" + fecha_inicio.Year.ToString + " and month(albaran.fecha)>=" + fecha_inicio.Month.ToString + " and day(albaran.fecha)>=" + fecha_inicio.Day.ToString + " "
        texto = texto + " and year(albaran.fecha)<=" + fecha_fin.Year.ToString + " and month(albaran.fecha)<=" + fecha_fin.Month.ToString + " and day(albaran.fecha)<=" + fecha_fin.Day.ToString + " "

        If Me.filtrar_por.SelectedIndex <> 0 Then
            'hay que meter mas condiciones
            If Me.filtrar_por.SelectedItem = "Empresa" Then
                texto = texto + " and empresa.nombre='" + Me.valor_filtro.SelectedItem.ToString + "'"
            End If
            If Me.filtrar_por.SelectedItem = "Bar" Then
                texto = texto + " and bar.nombre='" + Me.valor_filtro.SelectedItem.ToString + "'"
            End If

        End If
        texto = texto + "  group by bar.nombre,empresa.nombre,empresa.nombre_comunidad"
        Me.datos_albaranes.inicializa(Form1.clase_datos_global, texto, 7)

        Me.datos_albaranes.enlaza_datagrid(Me.DataGridView1)
        Me.n_copias.Text = Me.datos_albaranes.num_datos().ToString
    End Sub

    Private Sub valor_filtro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles valor_filtro.SelectedIndexChanged
        'calcula_copias()
        If Me.filtrar_por.SelectedItem <> Nothing And Me.valor_filtro.SelectedItem <> Nothing Then
            If Me.filtrar_por.SelectedItem.ToString = "Empresa" Then
                Me.datos_albaranes.filtro("empresa='" + Me.valor_filtro.SelectedItem + "'")
            End If
            If Me.filtrar_por.SelectedItem.ToString = "Bar" Then
                Me.datos_albaranes.filtro("bar='" + Me.valor_filtro.SelectedItem + "'")
            End If
        End If
        Me.n_copias.Text = Me.DataGridView1.Rows.Count - 1
    End Sub

    Private Sub filtrar_por_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filtrar_por.SelectedIndexChanged
        If Me.filtrar_por.SelectedItem <> Nothing Then
            If Me.filtrar_por.SelectedItem.ToString = "Empresa" Then
                Me.datos_empresas.almacena_combobox_completa(Me.valor_filtro, 0)
                If Me.valor_filtro.Items.Count > 0 Then
                    Me.valor_filtro.SelectedIndex = 0
                End If
            ElseIf Me.filtrar_por.SelectedItem.ToString = "Bar" Then
                Me.datos_bares.almacena_combobox_completa(Me.valor_filtro, 0)
                If Me.valor_filtro.Items.Count > 0 Then
                    Me.valor_filtro.SelectedIndex = 0
                End If
            Else
                Me.valor_filtro.Items.Clear()
                If inicializado <> 0 Then
                    Me.datos_albaranes.quitar_filtro()
                    Me.valor_filtro.Text = ""
                    'calcula_copias()
                End If
            End If
        End If
        Me.n_copias.Text = Me.DataGridView1.Rows.Count - 1
    End Sub

  

    Private Sub Semestre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Semestre.SelectedIndexChanged
        calcula_copias()
    End Sub


    Private Sub año_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles año.Validated
        calcula_copias()
    End Sub


    Private Sub imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imprimir.Click
        If Me.numpaginas > 0 Then
            If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.numpaginas = Me.datos_albaranes.num_datos() - 1
                Me.PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
                Me.PrintDocument1.Print()
            End If
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'e.Graphics.DrawString("Hola caracola", New Font("Verdana", 18, FontStyle.Bold), Brushes.Black, 10, 10)
        'For i As Integer = 1 To 10
        '    e.Graphics.DrawString("Ejemplo de linea: " & i, New Font("Tahoma", 10, FontStyle.Bold), Brushes.Black, 10, 20 + (i * 30))
        'Next
        'texto = "select sum(entrada_bar) as [Recaudacion total], bar.nombre as bar,empresa.nombre as empresa,
        'empresa.nombre_comunidad as comunidad,'" + fi + "' as [fecha inicio],'" + ff + "' as [fecha fin],'" + Me.semestre_texto + "' as Semestre "
        e.Graphics.DrawString("Nombre del bar: " + Me.datos_albaranes.dato_dt(Me.numpaginas, 1).ToString, New Font("Verdana", 18, FontStyle.Bold), Brushes.Black, 10, 10)
        e.Graphics.DrawString("Nombre de la empresa asociada: " + Me.datos_albaranes.dato_dt(Me.numpaginas, 2).ToString, New Font("Verdana", 18, FontStyle.Bold), Brushes.Black, 10, 50)
        e.Graphics.DrawString("Nombre de la comunidad: " + Me.datos_albaranes.dato_dt(Me.numpaginas, 3).ToString, New Font("Verdana", 18, FontStyle.Bold), Brushes.Black, 10, 90)
        e.Graphics.DrawString("Cuatrimestre: " + Me.datos_albaranes.dato_dt(Me.numpaginas, 6).ToString, New Font("Verdana", 18, FontStyle.Bold), Brushes.Black, 10, 130)
        e.Graphics.DrawString("La base imponible es:" + Me.datos_albaranes.dato_dt(Me.numpaginas, 0).ToString + " €", New Font("Verdana", 18, FontStyle.Bold), Brushes.Black, 10, 170)
        e.Graphics.DrawString("El IVA (18%) es: " + (CType(Me.datos_albaranes.dato_dt(Me.numpaginas, 0), Single) * 0.18).ToString + " €", New Font("Verdana", 18, FontStyle.Bold), Brushes.Black, 10, 210)

        ' e.Graphics.DrawString(Me.datos_albaranes.dato_dt(Me.numpaginas, 0).ToString, New Font("Verdana", 18, FontStyle.Bold), Brushes.Black, 10, 30)
        If Me.numpaginas > 0 Then
            e.HasMorePages = True
        End If
        Me.numpaginas = Me.numpaginas - 1
        'e.Graphics.DrawString("Hola caracola", New Font("Verdana", 18, FontStyle.Bold), Brushes.Black, 10, 10)
        'e.Graphics.DrawString("Hola caracola", New Font("Verdana", 18, FontStyle.Bold), Brushes.Black, 10, 10)
    End Sub
End Class