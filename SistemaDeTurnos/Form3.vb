Imports System.Data.OleDb
Public Class Form3
    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub ListMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListMenu.SelectedIndexChanged
        'Castear Objeto a ListBox, para poder acceder al Selected Item
        Dim listBox As ListBox
        listBox = CType(sender, ListBox)

        'Cambiar la pestania del TabElementos en base al elemento seleccionado de la lsita
        If listBox.SelectedItem Is "Ventanillas" Then
            TabElementos.SelectedIndex = 0
        ElseIf listBox.SelectedItem Is "Tab2" Then
            TabElementos.SelectedIndex = 1
        ElseIf listBox.SelectedItem Is "Tab3" Then
            TabElementos.SelectedIndex = 2
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenargrid()
        Me.TxtNumeroDeVentanilla.Enabled = True
        Me.TxtTipoVentanilla.Enabled = True
    End Sub
    Private Sub llenargrid()
        Dim strConect As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=sistemadeturnos.mdb"
        Dim sql As String = "select Numero,TipoVentanilla from Ventanillas"
        Dim cnn As New OleDbConnection(strConect)
        cnn.Open()

        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter(sql, cnn)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        cnn.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim numero As Double
        Dim tipo As String

        'Obtener los datos del text box
        numero = TxtNumeroDeVentanilla.Text
        tipo = TxtTipoVentanilla.Text

        Dim sql As String = ""

        '       insert into Ventanillas(Numero, TipoVentanilla) 
        '        values(numero , 'tipo')

        '       Ejemplo
        '       insert into Ventanillas(Numero, TipoVentanilla) 
        '        values(5 , 'caja')
        sql = "insert into Ventanillas(TipoVentanilla,Numero) 
                values('" + TxtTipoVentanilla.Text + "'," + TxtNumeroDeVentanilla.Text + ")"

        ejecutarComando(sql)
    End Sub

    Private Sub ejecutarComando(Sql As String)
        Try
            Dim strConect As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=sistemadeturnos.mdb"
            Dim cnn As New OleDbConnection(strConect)
            Dim cmd As New OleDbCommand(Sql, cnn)
            cnn.Open()
            cmd.ExecuteNonQuery()
            cnn.Close()
        Catch ex As OleDbException
            MsgBox("Error Interno, consulte a keren")
            'logearError(ex)
        End Try
        llenargrid()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        Dim sql As String = "delete from Ventanillas where Numero=" &
            DataGridView1.Item(0, DataGridView1.CurrentRow().Index).Value()
        ejecutarComando(sql)

    End Sub
End Class