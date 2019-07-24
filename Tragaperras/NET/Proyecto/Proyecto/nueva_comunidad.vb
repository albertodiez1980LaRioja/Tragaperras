Public Class nueva_comunidad
    Dim comunidades As New clase_tabla
    Dim guardar As New clase_tabla
    Dim usuario As Integer = 0
    Sub carga_comunidades()
        usuario = 0
        comunidades.inicializa(Form1.clase_datos_global, "select nombre_comunidad as nombre,impuesto_B as [impuesto B],n_maquinas_A as [maquinas A],n_maquinas_B as [maquinas B],n_maquinas_total as [maquinas total] from comunidad_autonoma", 2)
        comunidades.enlaza_datagrid(Me.DataGridView1)
        Me.DataGridView1.Columns(0).Width = 100
        Me.DataGridView1.Columns(1).Width = 110
        Me.DataGridView1.Columns(2).Width = 110
        Me.DataGridView1.Columns(3).Width = 110
        Me.DataGridView1.Columns(4).Width = 160
        usuario = 1
    End Sub
    Private Sub Agregar_modelo_maquina_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Form1.Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_añadir.Click
        Dim r, i, encontrado As Integer
        If (Me.c_nombre.Text <> "" And IsNumeric(Me.impuesto.Text)) Then
            'hay que comprobar si es una actualizacion o una insercion, asi que hay que comprobar si esta la clave o no
            encontrado = 0
            i = 0
            While (i < Me.DataGridView1.RowCount - 1 And encontrado = 0)
                'el -1 es por que la ultima fila esta vacia
                'MsgBox(Me.DataGridView1.Rows(i).Cells(0).Value.ToString)
                If (Me.c_nombre.Text = Me.DataGridView1.Rows(i).Cells(0).Value.ToString) Then
                    encontrado = 1
                End If
                i = i + 1
            End While
            If (encontrado = 0) Then
                r = guardar.inicializa(Form1.clase_datos_global, "insert into comunidad_autonoma values ('" + Me.c_nombre.Text + "','" + Me.impuesto.Text + "','" + Me.max_a.Text + "','" + Me.max_b.Text + "','" + Me.max_total.Text + "')", 2)

            ElseIf (encontrado = 1) Then
                r = guardar.inicializa(Form1.clase_datos_global, "update comunidad_autonoma set impuesto_B='" + Me.impuesto.Text + "',n_maquinas_A='" + Me.max_a.Text + "',n_maquinas_B='" + Me.max_b.Text + "',n_maquinas_total='" + Me.max_total.Text + "' where nombre_comunidad='" + Me.c_nombre.Text + "'", 2)
            End If
            carga_comunidades()
        End If
        Me.c_nombre.Focus()
        Me.c_nombre.Text = ""
        Me.impuesto.Text = ""
    End Sub

    Private Sub nueva_comunidad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        carga_comunidades()
    End Sub

    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        If usuario = 1 And e.RowIndex < Me.DataGridView1.RowCount - 1 Then
            'MsgBox("se entra en la fila")
            'ponemos los datos en las cajas de texto
            Me.c_nombre.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            Me.impuesto.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            Me.max_a.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
            Me.max_b.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
            Me.max_total.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
        End If
    End Sub

    Private Sub DataGridView1_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGridView1.UserDeletedRow
        carga_comunidades()
    End Sub

    Private Sub DataGridView1_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DataGridView1.UserDeletingRow
        Dim texto As String
        Dim r1 As Integer
        If (e.Row.Cells.Count > 0) Then
            texto = e.Row.Cells.Item(0).Value.ToString
            r1 = guardar.inicializa(Form1.clase_datos_global, "delete from comunidad_autonoma where nombre_comunidad='" + texto + "'", 2)
            If (r1 = 0) Then
                MsgBox("Ha habido un fallo en la base de datos, probablemente la maquina ya este registrada")
            End If
        End If
    End Sub

    Private Sub eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminar.Click
        Dim seleccionado As Integer
        Dim texto As String
        If Me.DataGridView1.SelectedCells.Count > 0 Then
            If Me.DataGridView1.SelectedCells(0).RowIndex < Me.DataGridView1.Rows.Count - 1 Then
                seleccionado = Me.DataGridView1.SelectedCells(0).RowIndex
                texto = Me.DataGridView1.Rows(seleccionado).Cells(0).Value.ToString
                texto = "delete from comunidad_autonoma where nombre_comunidad='" + texto + "'"
                seleccionado = Me.guardar.inicializa(Form1.clase_datos_global, texto, 1)
                If seleccionado = 0 Then
                    MsgBox("Ha habido un fallo y no se pudo eliminar, probablemente este relacionado con otras tablas")
                Else
                    Me.c_nombre.Focus()
                    Me.c_nombre.Text = ""
                    Me.impuesto.Text = ""
                    carga_comunidades()
                End If
            End If
        End If
    End Sub
End Class