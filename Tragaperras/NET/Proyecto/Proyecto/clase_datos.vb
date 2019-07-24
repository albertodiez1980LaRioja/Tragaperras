Imports System.Data.OleDb

Public Class clase_datos
    Dim _cadcon As String
    Public _cnn As OleDb.OleDbConnection
    Sub inicializa(ByVal s As String)
        _cadcon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
        _cadcon = _cadcon & s
        _cnn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _cadcon)
        '?el cnn.open, parece que no hace falta
    End Sub

End Class
Public Class clase_tabla
    Dim IMPORTANTE As Integer = 1 'es 1 si es debug
    Dim _bs As New BindingSource
    Dim _cmd As OleDb.OleDbDataAdapter
    Dim _dt As DataTable
    Dim _s As String
    Dim _num_campos As Integer
    Dim tiene_filtro As Integer = 0
    Function inicializa(ByRef enlace As clase_datos, ByRef s As String, ByVal n As Integer)
        Dim retorno As Integer = 1
        'Try
        '     el código que puede producir error
        'Catch [tipo de error a capturar]
        '     código cuando se produzca un error
        'Finally
        '     código se produzca o no un error
        'End Try
        Try
            _num_campos = n
            _s = s
            _cmd = New OleDbDataAdapter(_s, CType(enlace, clase_datos)._cnn)
            _dt = New DataTable
            _cmd.Fill(_dt)
            '_cmd.Update()
            '        Catch
            ' MsgBox("ha habido un fallo")
        Catch e As OleDbException
            Dim errorMessages As String = ""
            Dim i As Integer
            For i = 0 To e.Errors.Count - 1
                errorMessages += "Index #" & i.ToString() & ControlChars.Cr _
                               & "Message: " & e.Errors(i).Message & ControlChars.Cr _
                               & "NativeError: " & e.Errors(i).NativeError & ControlChars.Cr _
                               & "Source: " & e.Errors(i).Source & ControlChars.Cr _
                               & "SQLState: " & e.Errors(i).SQLState & ControlChars.Cr
            Next i

            Dim log As System.Diagnostics.EventLog = New System.Diagnostics.EventLog()
            log.Source = "My Application"
            log.WriteEntry(errorMessages)
            If (IMPORTANTE = 1) Then
                '                MsgBox("An exception occurred. Please contact your system administrator.")
                MsgBox("Ha ocurrido un error con la base de datos sql " + s)
                MsgBox(errorMessages)
            End If

            retorno = 0
        Catch
            'ha ocurrido otro tipo de error, se supone que poco probable
            retorno = 0
        Finally
        End Try
        _bs.DataSource = _dt
        '_num_campos =
        Return (retorno)
    End Function
    Sub enlaza_datagrid(ByRef grid As System.Windows.Forms.DataGridView)
        grid.DataSource = _dt
    End Sub
    Sub enlaza_listview(ByRef list As System.Windows.Forms.ListView)
        'aqui se da por hecho que los campos estan inicializados
        Dim i, i2 As Integer
        list.Items.Clear()
        list.View = View.Details
        For i = 0 To _dt.Rows.Count - 1
            list.Items.Add(_dt.Rows(i).Item(0).ToString)
            For i2 = 1 To _num_campos - 1
                list.Items(i).SubItems.Add(_dt.Rows(i).Item(i2).ToString)
            Next
        Next
    End Sub
    Sub almacena_arraylist(ByRef lista As ArrayList)
        Dim i, i2 As Integer
        lista.Clear()
        For i = 0 To _dt.Rows.Count - 1
            For i2 = 0 To _num_campos - 1
                'lista.Add(_dt.Rows.Item(i).Item(i2))
                lista.Add(_dt.Rows(i).Item(i2))
            Next
        Next
    End Sub
    Sub almacena_combobox(ByRef combo As ComboBox, ByVal t As Integer)
        Dim i As Integer
        combo.Items.Clear()
        For i = 0 To _dt.Rows.Count - 1
            combo.Items.Add(_dt.Rows(i).Item(t))
        Next
    End Sub

    Sub almacena_combobox_completa(ByRef combo As ComboBox, ByVal t As Integer)
        Dim i As Integer
        combo.AutoCompleteCustomSource.Clear()
        combo.Items.Clear()
        combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        combo.AutoCompleteSource = AutoCompleteSource.CustomSource
        For i = 0 To _dt.Rows.Count - 1
            combo.Items.Add(_dt.Rows(i).Item(t))
            combo.AutoCompleteCustomSource.Add(_dt.Rows(i).Item(t))
        Next
        If combo.Items.Count > 0 Then
            combo.SelectedIndex = 0
        End If
    End Sub

    Sub almacena_textbox_completa(ByRef textbox As TextBox, ByVal t As Integer)
        Dim i As Integer
        textbox.AutoCompleteCustomSource.Clear()
        '     textbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        '    textbox.AutoCompleteSource = AutoCompleteSource.CustomSource
        'esto llaman al enter del textbox, rarooooooooooooooooooooooooooo
        For i = 0 To _dt.Rows.Count - 1
            textbox.AutoCompleteCustomSource.Add(_dt.Rows(i).Item(t))
        Next
    End Sub

    Function dato_arraylist(ByRef lista As ArrayList, ByRef num_registro As Integer, ByRef num_campo As Integer) As Object
        dato_arraylist = lista(num_registro * _num_campos + num_campo)
    End Function
    Function dato_dt(ByVal fila, ByVal columna) As Object
        If fila < _dt.Rows.Count And columna < _num_campos Then
            Return _dt.Rows(fila).Item(columna)
        End If
        Return -1
    End Function
    Function num_datos()
        Return _dt.Rows.Count
    End Function

    Sub filtro(ByVal texto As String)
        tiene_filtro = 1
        _bs.Filter = texto
    End Sub
    Sub quitar_filtro()
        If (tiene_filtro = 1) Then
            _bs.RemoveFilter()
            tiene_filtro = 0
        End If
    End Sub
End Class
