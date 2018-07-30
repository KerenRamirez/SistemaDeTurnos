Public Class Form2
    Dim Tipo As String
    Dim SiguienteCaja As Integer = 1
    Dim SiguienteVentas As Integer = 1
    Dim SiguienteServicio As Integer = 1


    Public Sub New(ByVal TipoVentanilla As String)
        Tipo = TipoVentanilla
        InitializeComponent()
        'MsgBox(TipoVentanilla)
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If Tipo Is "Caja" Then
            MsgBox(Tipo & " " & SiguienteCaja & vbCrLf &
               txtIdentidad.Text & vbCrLf &
               DateTime.Now())
            SiguienteCaja = SiguienteCaja + 1

        ElseIf Tipo Is "Ventas" Then
            MsgBox(Tipo & " " & SiguienteVentas & vbCrLf &
            txtIdentidad.Text & vbCrLf &
            DateTime.Now())
            SiguienteVentas = SiguienteVentas + 1

        Else
            MsgBox(Tipo & " " & SiguienteServicio & vbCrLf &
            txtIdentidad.Text & vbCrLf &
            DateTime.Now())
            SiguienteServicio = SiguienteServicio + 1
        End If


    End Sub
End Class