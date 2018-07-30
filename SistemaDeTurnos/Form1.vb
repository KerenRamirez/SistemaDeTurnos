Public Class Form1
    Private Sub BtnCaja_Click(sender As Object, e As EventArgs) Handles BtnCaja.Click
        Dim myForm As New Form2("Caja")
        myForm.Show()
        'Me.Hide()
    End Sub

    Private Sub BtnVentas_Click(sender As Object, e As EventArgs) Handles BtnVentas.Click
        Dim myForm As New Form2("Ventas")
        myForm.Show()
        'Me.Hide()
    End Sub

    Private Sub BtnServicio_Click(sender As Object, e As EventArgs) Handles BtnServicio.Click
        Dim myForm As New Form2("Servicio al cliente")
        myForm.Show()
        'Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myForm As New Form3()
        myForm.Show()

        'Dim myForm2 As New Form4()
        'myForm2.Show()
    End Sub
End Class
