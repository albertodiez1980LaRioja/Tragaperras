
Public Class Form1
    Public clase_datos_global As New clase_datos
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        clase_datos_global.inicializa("proyecto_recreativo_2003_2.mdb")
    End Sub

    Private Sub B_agregar_modelo_maquina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_agregar_modelo_maquina.Click
        Agregar_modelo_maquina.Show()
        Me.Hide()
    End Sub

    Private Sub B_m_existente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_m_existente.Click
        maquinas_existentes.Show()
        Me.Hide()
    End Sub

    Private Sub B_nueva_comunidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_nueva_comunidad.Click
        nueva_comunidad.Show()
        Me.Hide()
    End Sub

    Private Sub B_datos_bar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_datos_bar.Click
        bares.Show()
        Me.Hide()
    End Sub

    Private Sub B_datos_empresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_datos_empresa.Click
        empresa.Show()
        Me.Hide()
    End Sub

    Private Sub B_traslados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_traslados.Click
        traslados.Show()
        Me.Hide()
    End Sub

    Private Sub B_operario_datos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_operario_datos.Click
        trabajadores.Show()
        Me.Hide()
    End Sub

    Private Sub B_albaranes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_albaranes.Click
        albaranes.Show()
        Me.Hide()
    End Sub

    Private Sub B_reportar_iva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_reportar_iva.Click
        Hoja_IVA.Show()
        Me.Hide()
    End Sub
End Class
