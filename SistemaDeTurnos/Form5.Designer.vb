<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.mostrarmenu = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BarraTitulo = New System.Windows.Forms.Panel()
        Me.iconrestaurar = New System.Windows.Forms.PictureBox()
        Me.iconminimizar = New System.Windows.Forms.PictureBox()
        Me.iconmaximizar = New System.Windows.Forms.PictureBox()
        Me.iconcerrar = New System.Windows.Forms.PictureBox()
        Me.btnbasico = New System.Windows.Forms.PictureBox()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.mostrarmenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraTitulo.SuspendLayout()
        CType(Me.iconrestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconminimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconmaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconcerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnbasico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mostrarmenu
        '
        Me.mostrarmenu.BackColor = System.Drawing.Color.Blue
        Me.mostrarmenu.Controls.Add(Me.Button3)
        Me.mostrarmenu.Controls.Add(Me.Button2)
        Me.mostrarmenu.Controls.Add(Me.Button1)
        Me.mostrarmenu.Controls.Add(Me.PictureBox1)
        Me.mostrarmenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.mostrarmenu.Location = New System.Drawing.Point(0, 0)
        Me.mostrarmenu.Name = "mostrarmenu"
        Me.mostrarmenu.Size = New System.Drawing.Size(250, 525)
        Me.mostrarmenu.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(0, 248)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(250, 40)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "ventanilla"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 183)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(250, 40)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "pantalla"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(250, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "entrada"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaDeTurnos.My.Resources.Resources.banco
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BarraTitulo
        '
        Me.BarraTitulo.BackColor = System.Drawing.Color.Silver
        Me.BarraTitulo.Controls.Add(Me.iconrestaurar)
        Me.BarraTitulo.Controls.Add(Me.iconminimizar)
        Me.BarraTitulo.Controls.Add(Me.iconmaximizar)
        Me.BarraTitulo.Controls.Add(Me.iconcerrar)
        Me.BarraTitulo.Controls.Add(Me.btnbasico)
        Me.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTitulo.Location = New System.Drawing.Point(250, 0)
        Me.BarraTitulo.Name = "BarraTitulo"
        Me.BarraTitulo.Size = New System.Drawing.Size(792, 50)
        Me.BarraTitulo.TabIndex = 1
        '
        'iconrestaurar
        '
        Me.iconrestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iconrestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconrestaurar.Image = Global.SistemaDeTurnos.My.Resources.Resources.icon_restaurar
        Me.iconrestaurar.Location = New System.Drawing.Point(706, 9)
        Me.iconrestaurar.Name = "iconrestaurar"
        Me.iconrestaurar.Size = New System.Drawing.Size(34, 32)
        Me.iconrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconrestaurar.TabIndex = 3
        Me.iconrestaurar.TabStop = False
        '
        'iconminimizar
        '
        Me.iconminimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iconminimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconminimizar.Image = Global.SistemaDeTurnos.My.Resources.Resources.icon_minimizar
        Me.iconminimizar.Location = New System.Drawing.Point(666, 9)
        Me.iconminimizar.Name = "iconminimizar"
        Me.iconminimizar.Size = New System.Drawing.Size(34, 32)
        Me.iconminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconminimizar.TabIndex = 4
        Me.iconminimizar.TabStop = False
        '
        'iconmaximizar
        '
        Me.iconmaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconmaximizar.Image = Global.SistemaDeTurnos.My.Resources.Resources.icon_maximizar
        Me.iconmaximizar.Location = New System.Drawing.Point(706, 9)
        Me.iconmaximizar.Name = "iconmaximizar"
        Me.iconmaximizar.Size = New System.Drawing.Size(34, 32)
        Me.iconmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconmaximizar.TabIndex = 2
        Me.iconmaximizar.TabStop = False
        '
        'iconcerrar
        '
        Me.iconcerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconcerrar.Image = Global.SistemaDeTurnos.My.Resources.Resources.icon_cerrar2
        Me.iconcerrar.Location = New System.Drawing.Point(746, 9)
        Me.iconcerrar.Name = "iconcerrar"
        Me.iconcerrar.Size = New System.Drawing.Size(34, 32)
        Me.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconcerrar.TabIndex = 1
        Me.iconcerrar.TabStop = False
        '
        'btnbasico
        '
        Me.btnbasico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbasico.Image = Global.SistemaDeTurnos.My.Resources.Resources.Mobile_Menu_Icon
        Me.btnbasico.Location = New System.Drawing.Point(6, 9)
        Me.btnbasico.Name = "btnbasico"
        Me.btnbasico.Size = New System.Drawing.Size(35, 35)
        Me.btnbasico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnbasico.TabIndex = 0
        Me.btnbasico.TabStop = False
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(250, 50)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(792, 475)
        Me.PanelContenedor.TabIndex = 2
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1042, 525)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.BarraTitulo)
        Me.Controls.Add(Me.mostrarmenu)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.mostrarmenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraTitulo.ResumeLayout(False)
        CType(Me.iconrestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconminimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconmaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconcerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnbasico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mostrarmenu As Panel
    Friend WithEvents BarraTitulo As Panel
    Friend WithEvents btnbasico As PictureBox
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents iconcerrar As PictureBox
    Friend WithEvents iconminimizar As PictureBox
    Friend WithEvents iconrestaurar As PictureBox
    Friend WithEvents iconmaximizar As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
