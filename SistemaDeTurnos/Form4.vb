Public Class Form4
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaClientesCaja.SelectedIndexChanged

    End Sub


    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ListaClientesCaja.Items.Add("p")
        Me.ListaClientesCaja.Items.RemoveAt(0)


    End Sub

    'Tipo Ventanilla
    'C      = Caja
    'V      = Ventas
    'S      = Servicio al cliente

    Public Function agregarCliente(tipoVentanilla As String) As Integer
        If tipoVentanilla Is "C" Then
            Me.ListaClientesCaja.Items.Add(
                tipoVentanilla & (Me.ListaClientesCaja.Items.Count + 1).ToString)
            Return Me.ListaClientesCaja.Items.Count

        ElseIf tipoVentanilla Is "V" Then
            Me.ListaClientesVentas.Items.Add(
                tipoVentanilla & (Me.ListaClientesVentas.Items.Count + 1).ToString)
            Return Me.ListaClientesVentas.Items.Count
        ElseIf tipoVentanilla Is "S" Then
            Me.ListaClientesServicios.Items.Add(
                tipoVentanilla & (Me.ListaClientesServicios.Items.Count + 1).ToString)
            Return Me.ListaClientesServicios.Items.Count
        End If
        Return -1
    End Function

    Public Function removerCliente(tipoVentanilla As String) As Integer
        Me.ListaClientesCaja.Items.RemoveAt(0)
        Return 1
    End Function
End Class