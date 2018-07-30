<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListaClientesCaja = New System.Windows.Forms.ListBox()
        Me.ListaClientesVentas = New System.Windows.Forms.ListBox()
        Me.ListaClientesServicios = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListaClientesCaja
        '
        Me.ListaClientesCaja.FormattingEnabled = True
        Me.ListaClientesCaja.Location = New System.Drawing.Point(27, 44)
        Me.ListaClientesCaja.Name = "ListaClientesCaja"
        Me.ListaClientesCaja.Size = New System.Drawing.Size(118, 264)
        Me.ListaClientesCaja.TabIndex = 0
        '
        'ListaClientesVentas
        '
        Me.ListaClientesVentas.FormattingEnabled = True
        Me.ListaClientesVentas.Location = New System.Drawing.Point(154, 42)
        Me.ListaClientesVentas.Name = "ListaClientesVentas"
        Me.ListaClientesVentas.Size = New System.Drawing.Size(118, 264)
        Me.ListaClientesVentas.TabIndex = 1
        '
        'ListaClientesServicios
        '
        Me.ListaClientesServicios.FormattingEnabled = True
        Me.ListaClientesServicios.Location = New System.Drawing.Point(297, 44)
        Me.ListaClientesServicios.Name = "ListaClientesServicios"
        Me.ListaClientesServicios.Size = New System.Drawing.Size(118, 264)
        Me.ListaClientesServicios.TabIndex = 2
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 348)
        Me.Controls.Add(Me.ListaClientesServicios)
        Me.Controls.Add(Me.ListaClientesVentas)
        Me.Controls.Add(Me.ListaClientesCaja)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListaClientesCaja As ListBox
    Friend WithEvents ListaClientesVentas As ListBox
    Friend WithEvents ListaClientesServicios As ListBox
End Class
