

Public Class Form5
    Public form1 As New Form1()
    Public form4 As New Form4()
    Public form3 As New Form3()

    '<DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    '<DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub mostrarmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mostrarmenu.Click
        If mostrarmenu.Width = 250 Then
            mostrarmenu.Width = 73
        Else
            mostrarmenu.Width = 250
        End If
    End Sub

    Private Sub iconcerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iconcerrar.Click
        Application.Exit()
    End Sub

    Private Sub iconmaximizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iconmaximizar.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

        iconmaximizar.Visible = False
        iconrestaurar.Visible = True
    End Sub

    Private Sub iconrestaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iconrestaurar.Click
        Me.WindowState = FormWindowState.Normal

        iconrestaurar.Visible = False
        iconmaximizar.Visible = True
    End Sub

    Private Sub iconminimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iconminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub barratitulo_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BarraTitulo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub AbrirFormHija(ByVal formhija)
    End Sub

    Private Sub btnbasico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbasico.Click
        If mostrarmenu.Width = 250 Then
            mostrarmenu.Width = 73
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If form1.Visible = False Then form1.Visible = True Else form1.Visible = False
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'configuranciones de form1 (entrada)
        form1.TopLevel = False
        form1.FormBorderStyle = FormBorderStyle.FixedSingle
        form1.Size = New System.Drawing.Size(250, 250)
        form1.Location = New System.Drawing.Point(20, 20)
        form1.WindowState = FormWindowState.Normal
        form1.Visible = False

        'configuranciones de form4 (pantallas)
        form4.TopLevel = False
        form4.FormBorderStyle = FormBorderStyle.FixedSingle
        form4.Size = New System.Drawing.Size(550, 400)
        form4.Location = New System.Drawing.Point(20, 20)
        form4.WindowState = FormWindowState.Normal
        form4.Visible = False

        'configuranciones de form3 (ventanilla)
        form3.TopLevel = False
        form3.FormBorderStyle = FormBorderStyle.FixedSingle
        form3.Size = New System.Drawing.Size(750, 400)
        form3.Location = New System.Drawing.Point(20, 20)
        form3.WindowState = FormWindowState.Normal
        form3.Visible = False

        'agregar los formularios a el contenedor
        PanelContenedor.Controls.Add(form1)
        PanelContenedor.Controls.Add(form4)
        PanelContenedor.Controls.Add(form3)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If form4.Visible = False Then form4.Visible = True Else form4.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If form3.Visible = False Then form3.Visible = True Else form3.Visible = False
    End Sub
End Class