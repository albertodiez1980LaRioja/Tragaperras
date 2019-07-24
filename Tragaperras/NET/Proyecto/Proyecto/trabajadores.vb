'aqui quedarian cosas por hacer, como comprobar que el dni este bien
Public Class trabajadores
    Dim datos_trabajadores, datos_empresas, datos_guardar As New clase_tabla
    Private Sub trabajadores_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Form1.Show()
    End Sub

    Sub inicializa_datagrid()
        Me.datos_trabajadores.inicializa(Form1.clase_datos_global, "select operario.nombre as [nombre],empresa.nombre as [empresa],sueldo,telefono,fecha_alta,fecha_baja,operario.dni_operario as DNI from operario,empresa where operario.n_fiscal_empresa=empresa.n_fiscal_empresa", 7)
        Me.datos_trabajadores.enlaza_datagrid(Me.DataGridView1)
    End Sub

    Function valida() As Integer
        Dim c As Control
        Dim validado As Integer = 1
        Dim fechatext As String
        For Each c In Me.Controls
            If c.TabIndex > 0 And c.TabIndex < 12 And c.TabIndex <> 10 And c.TabIndex <> 6 And c.TabIndex <> 7 And c.TabIndex <> 8 Then
                If c.ToString = "" Then
                    validado = 0
                    MsgBox("No estan todos los campos completos")
                    Return validado
                End If
            End If
        Next
        fechatext = Me.i_dia.Text + "/" + i_mes.Text + "/" + i_año.Text
        If (Not IsDate(fechatext)) Then
            MsgBox("la fecha de inicio de contrato no es valida " + fechatext)
            Return 0
        End If
        fechatext = Me.f_dia.Text + "/" + f_mes.Text + "/" + f_año.Text
        If fechatext = "//" Then
            'el contrato es indefinido
            'Me.f_dia.Text = Me.i_dia.Text
            'Me.f_mes.Text = Me.i_mes.Text
            'Me.f_año.Text = CType(CType(Me.i_año.Text, Integer) - 1, String)
            Me.f_dia.Text = "1"
            Me.f_mes.Text = "1"
            Me.f_año.Text = "3000"
        ElseIf (Not IsDate(fechatext)) Then
            MsgBox("la fecha de fin de contrato no es valida " + fechatext)
            Return 0
        End If
        Return validado
    End Function

    Sub vacia()
        Dim c As Control
        For Each c In Me.Controls
            If c.TabIndex > 0 And c.TabIndex < 12 And c.TabIndex <> 10 Then
                c.Text = ""
            End If
        Next
        Me.nombre.Focus()
    End Sub

    Private Sub trabajadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.datos_empresas.inicializa(Form1.clase_datos_global, "select nombre,n_fiscal_empresa from empresa", 2)
        Me.datos_empresas.almacena_combobox(Me.empresa, 0)
        Me.empresa.SelectedIndex = 0
        inicializa_datagrid()
    End Sub


    Private Sub B_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_nuevo.Click
        vacia()
    End Sub

    Private Sub B_insertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_insertar.Click
        Dim texto, fecha_alta, fecha_baja, n_fiscal_empresa As String
        Dim encontrado, i As Integer
        If valida() = 1 Then
            'primero buscamos el dni
            encontrado = 0
            i = 0
            While (i < Me.datos_trabajadores.num_datos And encontrado = 0)
                If Me.datos_trabajadores.dato_dt(i, 6).ToString = Me.DNI.Text Then
                    encontrado = 1
                End If
                i = i + 1
            End While
            n_fiscal_empresa = Me.datos_empresas.dato_dt(Me.empresa.SelectedIndex, 1)
            fecha_alta = Me.i_dia.Text + "/" + i_mes.Text + "/" + i_año.Text
            fecha_baja = Me.f_dia.Text + "/" + f_mes.Text + "/" + f_año.Text
            If encontrado = 1 Then
                texto = "update operario set nombre='" + Me.nombre.Text + "',sueldo=" + Me.sueldo.Text + ",fecha_alta='" + fecha_alta + "',fecha_baja='" + fecha_baja + "',n_fiscal_empresa='" + n_fiscal_empresa + "',telefono='" + telefono.Text + "' where dni_operario='" + Me.DNI.Text + "'"
                datos_guardar.inicializa(Form1.clase_datos_global, texto, 3)
            End If
            If encontrado = 0 Then
                texto = "insert into operario values('" + Me.DNI.Text + "','" + Me.nombre.Text + "'," + sueldo.Text + ",'" + fecha_alta + "','" + fecha_baja + "','" + n_fiscal_empresa + "','" + telefono.Text + "')"
                datos_guardar.inicializa(Form1.clase_datos_global, texto, 3)
            End If
            vacia()
            inicializa_datagrid()
        End If
    End Sub

    Private Sub B_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_eliminar.Click
        'cojemos el seleccionado y lo eliminamos
        Dim seleccionada As Integer
        Dim dni, texto As String
        If Me.DataGridView1.SelectedCells.Count > 0 Then
            seleccionada = Me.DataGridView1.SelectedCells(0).RowIndex
            If seleccionada < Me.DataGridView1.Rows.Count - 1 Then
                dni = Me.DataGridView1.Rows(seleccionada).Cells(6).Value.ToString
                texto = "delete from operario where dni_operario='" + dni + "'"
                Me.datos_guardar.inicializa(Form1.clase_datos_global, texto, 3)
                inicializa_datagrid()
                vacia()
            End If
        End If
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        'ponemos en las cajas los valores de la fila seleccionada
        Dim seleccionada As Integer
        If Me.DataGridView1.SelectedCells.Count > 0 Then
            seleccionada = Me.DataGridView1.SelectedCells(0).RowIndex
            If seleccionada < Me.DataGridView1.Rows.Count - 1 Then
                Me.nombre.Text = Me.DataGridView1.Rows(seleccionada).Cells(0).Value.ToString
                Me.DNI.Text = Me.DataGridView1.Rows(seleccionada).Cells(6).Value.ToString
                Me.sueldo.Text = Me.DataGridView1.Rows(seleccionada).Cells(2).Value.ToString
                Me.telefono.Text = Me.DataGridView1.Rows(seleccionada).Cells(3).Value.ToString
                Me.empresa.Text = Me.DataGridView1.Rows(seleccionada).Cells(1).Value.ToString
                Me.i_año.Text = Year(Me.DataGridView1.Rows(seleccionada).Cells(4).Value.ToString)
                Me.i_mes.Text = Month(Me.DataGridView1.Rows(seleccionada).Cells(4).Value.ToString)
                Me.i_dia.Text = Microsoft.VisualBasic.DateAndTime.Day(Me.DataGridView1.Rows(seleccionada).Cells(4).Value.ToString)
                Me.f_año.Text = Year(Me.DataGridView1.Rows(seleccionada).Cells(5).Value.ToString)
                Me.f_mes.Text = Month(Me.DataGridView1.Rows(seleccionada).Cells(5).Value.ToString)
                Me.f_dia.Text = Microsoft.VisualBasic.DateAndTime.Day(Me.DataGridView1.Rows(seleccionada).Cells(5).Value.ToString)
            End If
        End If
    End Sub
End Class