Public Class Agregar_modelo_maquina
    Dim clase_modelo As New clase_tabla
    Dim clase_modeloA As New clase_tabla
    '    Dim clase_B As New clase_tabla
    Dim clase_guardar As New clase_tabla
    Dim usuario As Integer = 0
    Sub inicializa_datagrid()
        usuario = 0
        clase_modelo.inicializa(Form1.clase_datos_global, "select modelo_maquina.nombre_modelo as modelo,modelo_maquina.año,B.premio_maximo as premio,B.carga as carga from modelo_maquina,B where modelo_maquina.nombre_modelo=B.nombre_modelo order by año desc", 2)
        clase_modelo.enlaza_datagrid(Me.DataGridView1)
        clase_modeloA.inicializa(Form1.clase_datos_global, "(select modelo_maquina.nombre_modelo,modelo_maquina.año from modelo_maquina where modelo_maquina.nombre_modelo not in(select modelo_maquina.nombre_modelo from modelo_maquina,B where modelo_maquina.nombre_modelo=B.nombre_modelo)order by año desc)", 2)
        clase_modeloA.enlaza_datagrid(Me.DataGridView2)
        usuario = 1
    End Sub
    Private Sub B_insertar_modelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_insertar_modelo.Click
        Dim r1, r2, i, encontrado As Integer
        If Me.t_nombre.Text = "" Then
            Return
        End If
        i = 0
        encontrado = 0
        While (i < Me.DataGridView1.RowCount - 1 And encontrado = 0)
            If (Me.t_nombre.Text = Me.DataGridView1.Rows(i).Cells(0).Value.ToString) Then
                encontrado = 1
            End If
            i = i + 1
        End While
        If encontrado = 0 Then
            r1 = clase_guardar.inicializa(Form1.clase_datos_global, "insert into modelo_maquina values ('" + Me.t_nombre.Text + "','" + Me.m_año.Text + "')", 2)
            r2 = clase_guardar.inicializa(Form1.clase_datos_global, "insert into B values('" + Me.t_nombre.Text + "','" + Me.M_premio.Text + "','" + Me.M_carga.Text + "')", 2)
        ElseIf encontrado = 1 Then
            'lo hago asi por que la relacion no me deja hacer el update
            r1 = clase_guardar.inicializa(Form1.clase_datos_global, "update modelo_maquina set año='" + Me.m_año.Text + "' where nombre_modelo='" + Me.t_nombre.Text + "'", 2)
            r2 = clase_guardar.inicializa(Form1.clase_datos_global, "update B set premio_maximo='" + Me.M_premio.Text + "',carga='" + Me.M_carga.Text + "' where nombre_modelo='" + Me.t_nombre.Text + "'", 2)
            'r1 = clase_guardar.inicializa(Form1.clase_datos_global, "delete from B where nombre_modelo='" + Me.t_nombre.Text + "'", 2)
            'r2 = clase_guardar.inicializa(Form1.clase_datos_global, "delete from modelo_maquina where nombre_modelo='" + Me.t_nombre.Text + "'", 2)
            'r1 = clase_guardar.inicializa(Form1.clase_datos_global, "insert into modelo_maquina values ('" + Me.t_nombre.Text + "','" + Me.m_año.Text + "')", 2)
            'r2 = clase_guardar.inicializa(Form1.clase_datos_global, "insert into B values('" + Me.t_nombre.Text + "','" + Me.M_premio.Text + "','" + Me.M_carga.Text + "')", 2)
        End If
        'volvemos a escanear la tabla
        If (r1 = 0 And r2 = 0) Then
            MsgBox("Ha habido un fallo con la base de datos, probablemente el nombre de la maquina este repetido")
        End If
        Me.t_nombre.Text = ""
        inicializa_datagrid()
    End Sub

    Private Sub Agregar_modelo_maquina_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Form1.Show()
    End Sub

    Private Sub Agregar_modelo_maquina_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        inicializa_datagrid()
    End Sub

    Private Sub B_insertar_a_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_insertar_a.Click
        Dim r1, i, encontrado As Integer
        If Me.t_nombre.Text = "" Then
            Return
        End If
        i = 0
        encontrado = 0
        While (i < Me.DataGridView2.RowCount - 1 And encontrado = 0)
            If (Me.t_nombre.Text = Me.DataGridView2.Rows(i).Cells(0).Value.ToString) Then
                encontrado = 1
            End If
            i = i + 1
        End While
        If encontrado = 0 Then
            r1 = clase_guardar.inicializa(Form1.clase_datos_global, "insert into modelo_maquina values ('" + Me.t_nombre.Text + "','" + Me.m_año.Text + "')", 2)
        ElseIf encontrado = 1 Then
            r1 = clase_guardar.inicializa(Form1.clase_datos_global, "update modelo_maquina set año='" + Me.m_año.Text + "' where nombre_modelo='" + Me.t_nombre.Text + "'", 2)
        End If
        If r1 = 0 Then
            MsgBox("Ha habido un fallo con la base de datos, probablemente el nombre de la maquina este repetido")
        End If
        'volvemos a escanear la tabla
        Me.t_nombre.Text = ""
        inicializa_datagrid()
    End Sub

    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        If usuario = 1 And Me.DataGridView1.Rows.Count - 1 > e.RowIndex Then
            Me.t_nombre.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            Me.m_año.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            Me.M_premio.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
            Me.M_carga.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
        End If
    End Sub

    Private Sub DataGridView2_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.RowEnter
        If usuario = 1 And Me.DataGridView2.Rows.Count - 1 > e.RowIndex Then
            Me.t_nombre.Text = Me.DataGridView2.Rows(e.RowIndex).Cells(0).Value.ToString
            Me.m_año.Text = Me.DataGridView2.Rows(e.RowIndex).Cells(1).Value.ToString
        End If
    End Sub

    Private Sub DataGridView1_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGridView1.UserDeletedRow, DataGridView2.UserDeletedRow
        inicializa_datagrid()
    End Sub

    Private Sub DataGridView1_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DataGridView1.UserDeletingRow
        Dim texto As String
        Dim r1, r2 As Integer
        If (e.Row.Cells.Count > 0) Then
            texto = e.Row.Cells.Item(0).Value.ToString
            r1 = clase_guardar.inicializa(Form1.clase_datos_global, "delete from B where nombre_modelo='" + texto + "'", 2)
            r2 = clase_guardar.inicializa(Form1.clase_datos_global, "delete from modelo_maquina where nombre_modelo='" + texto + "'", 2)
            If (r1 = 0 Or r2 = 0) Then
                MsgBox("Ha habido un fallo en la base de datos, probablemente la maquina ya este registrada")
            End If
            'inicializa_datagrid()
        End If
    End Sub
    Private Sub DataGridView2_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DataGridView2.UserDeletingRow
        Dim texto As String
        Dim r1 As Integer
        If (e.Row.Cells.Count > 0) Then
            texto = e.Row.Cells.Item(0).Value.ToString
            r1 = clase_guardar.inicializa(Form1.clase_datos_global, "delete from modelo_maquina where nombre_modelo='" + texto + "'", 2)
            If (r1 = 0) Then
                MsgBox("Ha habido un fallo en la base de datos, probablemente la maquina ya enlazada con otra tabla")
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'este es un caso especial, ya que tenemos dos posible tablas para eliminar el modelo
        'lo que se hara sera buscar el modelo que esta en el cuadro de texto y eliminarlo
        Dim encontrado, i, r1, r2 As Integer
        Dim texto As String
        encontrado = 0
        i = 0
        While i < Me.clase_modelo.num_datos() And encontrado = 0
            If Me.clase_modelo.dato_dt(i, 0).ToString = Me.t_nombre.Text Then
                encontrado = 1
            End If
            i = i + 1
        End While
        If encontrado = 1 Then
            texto = Me.t_nombre.Text
            r1 = clase_guardar.inicializa(Form1.clase_datos_global, "delete from B where nombre_modelo='" + texto + "'", 2)
            r2 = clase_guardar.inicializa(Form1.clase_datos_global, "delete from modelo_maquina where nombre_modelo='" + texto + "'", 2)
            If (r1 = 0 Or r2 = 0) Then
                MsgBox("Ha habido un fallo en la base de datos, probablemente la maquina este enlazada en otra tabla")
            End If
            inicializa_datagrid()
            Me.t_nombre.Text = ""
        Else 'ahora buscamos en las A
            i = 0
            While i < Me.clase_modeloA.num_datos() And encontrado = 0
                If Me.t_nombre.Text = Me.clase_modeloA.dato_dt(i, 0) Then
                    encontrado = 1
                    texto = Me.t_nombre.Text
                    r1 = clase_guardar.inicializa(Form1.clase_datos_global, "delete from modelo_maquina where nombre_modelo='" + texto + "'", 2)
                    If r1 = 0 Then
                        MsgBox("Ha habido un fallo en la base de datos, probablemente la maquina este enlazada en otra tabla")
                    End If
                    inicializa_datagrid()
                    Me.t_nombre.Text = ""
                End If
                i = i + 1
            End While
        End If
    End Sub
End Class