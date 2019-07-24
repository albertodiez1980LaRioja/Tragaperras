Public Class empresa
    Dim datos_empresa As New clase_tabla
    Dim datos_comunidad As New clase_tabla
    Dim datos_guardar As New clase_tabla
    Private Sub empresa_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Form1.Show()
    End Sub

    Private Sub empresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        datos_comunidad.inicializa(Form1.clase_datos_global, "select nombre_comunidad from comunidad_autonoma", 1)
        datos_comunidad.almacena_combobox(Me.c_comunidad, 0)
        inicializa_datagrid()
    End Sub

    Sub inicializa_datagrid()
        datos_empresa.inicializa(Form1.clase_datos_global, "select nombre,nombre_comunidad as comunidad,n_fiscal_empresa as [numero fiscal]  from empresa", 3)
        datos_empresa.enlaza_datagrid(Me.DataGridView1)
    End Sub

    Function validar() As Integer
        If Me.t_nombre_empresa.Text = "" Or Me.c_comunidad.SelectedItem = "" Or Me.M_cif.Text = "" Then
            MsgBox("Te has dejado datos sin rellenar")
            Return 0
        End If
        Return 1
    End Function

    Private Sub b_incluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_incluir.Click
        Dim encontrado As Integer
        Dim i As Integer
        Dim r1 As Integer
        i = 0
        encontrado = 0
        If validar() = 1 Then
            While (i < Me.DataGridView1.RowCount - 1 And encontrado = 0)
                If (Me.M_cif.Text = Me.DataGridView1.Rows(i).Cells(2).Value.ToString) Then
                    encontrado = 1
                End If
                i = i + 1
            End While
            'al cambiar la comunidad de la empresa se pueden dar datos erroneos, ya que las maquinas que pertenecen a 
            'esa empresa tendran la comunidad anterior, habria que actualizar toda la tabla de maquinas
            'de momento lo bamos a dejar asi
            If encontrado = 0 Then
                r1 = datos_guardar.inicializa(Form1.clase_datos_global, "insert into empresa values ('" + Me.M_cif.Text + "','" + Me.t_nombre_empresa.Text + "','" + Me.c_comunidad.SelectedItem + "')", 2)
            End If
            If encontrado = 1 Then
                r1 = datos_guardar.inicializa(Form1.clase_datos_global, "update empresa set nombre='" + Me.t_nombre_empresa.Text + "',nombre_comunidad='" + Me.c_comunidad.SelectedItem + "' where n_fiscal_empresa='" + Me.M_cif.Text + "'", 2)
            End If
            If r1 = 0 Then
                MsgBox("Ha habido un fallo con la base de datos, probablemente el nombre de la maquina este repetido")
            End If
            Me.t_nombre_empresa.Focus()
            Me.c_comunidad.SelectedIndex  =0
            Me.t_nombre_empresa.Text = ""
            Me.M_cif.Text = ""
            inicializa_datagrid()
        End If
    End Sub

    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        If (Me.DataGridView1.Rows.Count - 1 > e.RowIndex) Then
            Me.c_comunidad.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            Me.t_nombre_empresa.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            Me.M_cif.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
        End If

    End Sub

    Private Sub DataGridView1_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGridView1.UserDeletedRow
        inicializa_datagrid()
    End Sub

    Private Sub DataGridView1_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DataGridView1.UserDeletingRow
        Dim r As Integer
        Dim texto As String
        If (e.Row.Cells.Count > 0) Then
            texto = e.Row.Cells.Item(2).Value.ToString
            r = datos_guardar.inicializa(Form1.clase_datos_global, "delete from empresa where n_fiscal_empresa='" + texto + "'", 2)
            If (r = 0) Then
                MsgBox("Ha habido un fallo en la base de datos, probablemente la maquina ya este registrada")
            Else
                inicializa_datagrid() 'no haria falta pero bueno
            End If
        End If
    End Sub

    Private Sub eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminar.Click
        Dim seleccionado As Integer
        Dim texto As String
        If Me.DataGridView1.SelectedCells.Count > 0 Then
            If Me.DataGridView1.SelectedCells(0).RowIndex < Me.DataGridView1.Rows.Count - 1 Then
                seleccionado = Me.DataGridView1.SelectedCells(0).RowIndex
                texto = Me.DataGridView1.Rows(seleccionado).Cells(2).Value.ToString
                texto = "delete from empresa where n_fiscal_empresa='" + texto + "'"
                seleccionado = Me.datos_guardar.inicializa(Form1.clase_datos_global, texto, 1)
                If seleccionado = 0 Then
                    MsgBox("No se ha podido eliminar, probablemente la empresa estara relacionada con otra tabla")
                Else
                    inicializa_datagrid()
                End If
            End If
        End If
    End Sub

    Private Sub nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevo.Click
        Me.t_nombre_empresa.Focus()
        Me.c_comunidad.SelectedIndex = 0
        Me.t_nombre_empresa.Text = ""
        Me.M_cif.Text = ""
    End Sub

    
End Class