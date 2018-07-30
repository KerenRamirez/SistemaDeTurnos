<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BtnCaja = New System.Windows.Forms.Button()
        Me.BtnVentas = New System.Windows.Forms.Button()
        Me.BtnServicio = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnCaja
        '
        Me.BtnCaja.Location = New System.Drawing.Point(80, 61)
        Me.BtnCaja.Name = "BtnCaja"
        Me.BtnCaja.Size = New System.Drawing.Size(75, 23)
        Me.BtnCaja.TabIndex = 0
        Me.BtnCaja.Text = "Caja"
        Me.BtnCaja.UseVisualStyleBackColor = True
        '
        'BtnVentas
        '
        Me.BtnVentas.Location = New System.Drawing.Point(80, 112)
        Me.BtnVentas.Name = "BtnVentas"
        Me.BtnVentas.Size = New System.Drawing.Size(75, 23)
        Me.BtnVentas.TabIndex = 1
        Me.BtnVentas.Text = "Ventas"
        Me.BtnVentas.UseVisualStyleBackColor = True
        '
        'BtnServicio
        '
        Me.BtnServicio.Location = New System.Drawing.Point(62, 169)
        Me.BtnServicio.Name = "BtnServicio"
        Me.BtnServicio.Size = New System.Drawing.Size(114, 27)
        Me.BtnServicio.TabIndex = 2
        Me.BtnServicio.Text = "Servicio Al Cliente"
        Me.BtnServicio.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 248)
        Me.Controls.Add(Me.BtnServicio)
        Me.Controls.Add(Me.BtnVentas)
        Me.Controls.Add(Me.BtnCaja)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnCaja As Button
    Friend WithEvents BtnVentas As Button
    Friend WithEvents BtnServicio As Button
End Class
