<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventarioTiendaDeMusica
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbPiano = New System.Windows.Forms.ComboBox()
        Me.cmbGuitarra = New System.Windows.Forms.ComboBox()
        Me.cmbBajo = New System.Windows.Forms.ComboBox()
        Me.chkBajo = New System.Windows.Forms.CheckBox()
        Me.chkPiano = New System.Windows.Forms.CheckBox()
        Me.chkGuitarra = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbAccesorioBajo = New System.Windows.Forms.ComboBox()
        Me.cmbAccesorioPiano = New System.Windows.Forms.ComboBox()
        Me.cmbAccesorioGuitarra = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExtrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfinadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrimerosPasosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbPiano)
        Me.GroupBox1.Controls.Add(Me.cmbGuitarra)
        Me.GroupBox1.Controls.Add(Me.cmbBajo)
        Me.GroupBox1.Controls.Add(Me.chkBajo)
        Me.GroupBox1.Controls.Add(Me.chkPiano)
        Me.GroupBox1.Controls.Add(Me.chkGuitarra)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 110)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Instrumentos"
        '
        'cmbPiano
        '
        Me.cmbPiano.Enabled = False
        Me.cmbPiano.FormattingEnabled = True
        Me.cmbPiano.Location = New System.Drawing.Point(79, 52)
        Me.cmbPiano.Name = "cmbPiano"
        Me.cmbPiano.Size = New System.Drawing.Size(151, 21)
        Me.cmbPiano.TabIndex = 7
        '
        'cmbGuitarra
        '
        Me.cmbGuitarra.Enabled = False
        Me.cmbGuitarra.FormattingEnabled = True
        Me.cmbGuitarra.Location = New System.Drawing.Point(79, 25)
        Me.cmbGuitarra.Name = "cmbGuitarra"
        Me.cmbGuitarra.Size = New System.Drawing.Size(151, 21)
        Me.cmbGuitarra.TabIndex = 6
        '
        'cmbBajo
        '
        Me.cmbBajo.Enabled = False
        Me.cmbBajo.FormattingEnabled = True
        Me.cmbBajo.Location = New System.Drawing.Point(79, 79)
        Me.cmbBajo.Name = "cmbBajo"
        Me.cmbBajo.Size = New System.Drawing.Size(151, 21)
        Me.cmbBajo.TabIndex = 5
        '
        'chkBajo
        '
        Me.chkBajo.AutoSize = True
        Me.chkBajo.Location = New System.Drawing.Point(6, 83)
        Me.chkBajo.Name = "chkBajo"
        Me.chkBajo.Size = New System.Drawing.Size(47, 17)
        Me.chkBajo.TabIndex = 3
        Me.chkBajo.Text = "Bajo"
        Me.chkBajo.UseVisualStyleBackColor = True
        '
        'chkPiano
        '
        Me.chkPiano.AutoSize = True
        Me.chkPiano.Location = New System.Drawing.Point(6, 56)
        Me.chkPiano.Name = "chkPiano"
        Me.chkPiano.Size = New System.Drawing.Size(53, 17)
        Me.chkPiano.TabIndex = 4
        Me.chkPiano.Text = "Piano"
        Me.chkPiano.UseVisualStyleBackColor = True
        '
        'chkGuitarra
        '
        Me.chkGuitarra.AutoSize = True
        Me.chkGuitarra.Location = New System.Drawing.Point(6, 29)
        Me.chkGuitarra.Name = "chkGuitarra"
        Me.chkGuitarra.Size = New System.Drawing.Size(63, 17)
        Me.chkGuitarra.TabIndex = 2
        Me.chkGuitarra.Text = "Guitarra"
        Me.chkGuitarra.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbAccesorioBajo)
        Me.GroupBox2.Controls.Add(Me.cmbAccesorioPiano)
        Me.GroupBox2.Controls.Add(Me.cmbAccesorioGuitarra)
        Me.GroupBox2.Location = New System.Drawing.Point(59, 177)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(237, 107)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Accesorios"
        '
        'cmbAccesorioBajo
        '
        Me.cmbAccesorioBajo.FormattingEnabled = True
        Me.cmbAccesorioBajo.Location = New System.Drawing.Point(62, 73)
        Me.cmbAccesorioBajo.Name = "cmbAccesorioBajo"
        Me.cmbAccesorioBajo.Size = New System.Drawing.Size(121, 21)
        Me.cmbAccesorioBajo.TabIndex = 5
        Me.cmbAccesorioBajo.Text = "Bajo"
        '
        'cmbAccesorioPiano
        '
        Me.cmbAccesorioPiano.FormattingEnabled = True
        Me.cmbAccesorioPiano.Location = New System.Drawing.Point(62, 46)
        Me.cmbAccesorioPiano.Name = "cmbAccesorioPiano"
        Me.cmbAccesorioPiano.Size = New System.Drawing.Size(121, 21)
        Me.cmbAccesorioPiano.TabIndex = 4
        Me.cmbAccesorioPiano.Text = "Piano"
        '
        'cmbAccesorioGuitarra
        '
        Me.cmbAccesorioGuitarra.FormattingEnabled = True
        Me.cmbAccesorioGuitarra.Location = New System.Drawing.Point(62, 19)
        Me.cmbAccesorioGuitarra.Name = "cmbAccesorioGuitarra"
        Me.cmbAccesorioGuitarra.Size = New System.Drawing.Size(121, 21)
        Me.cmbAccesorioGuitarra.TabIndex = 3
        Me.cmbAccesorioGuitarra.Text = "Guitarra"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tienda de Musica Chopin"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(59, 293)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 3
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(140, 293)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(221, 293)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExtrasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(375, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExtrasToolStripMenuItem
        '
        Me.ExtrasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AfinadorToolStripMenuItem, Me.PrimerosPasosToolStripMenuItem})
        Me.ExtrasToolStripMenuItem.Name = "ExtrasToolStripMenuItem"
        Me.ExtrasToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.ExtrasToolStripMenuItem.Text = "Extras"
        '
        'AfinadorToolStripMenuItem
        '
        Me.AfinadorToolStripMenuItem.Name = "AfinadorToolStripMenuItem"
        Me.AfinadorToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.AfinadorToolStripMenuItem.Text = "Afinador"
        '
        'PrimerosPasosToolStripMenuItem
        '
        Me.PrimerosPasosToolStripMenuItem.Name = "PrimerosPasosToolStripMenuItem"
        Me.PrimerosPasosToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.PrimerosPasosToolStripMenuItem.Text = "Primeros Pasos"
        '
        'InventarioTiendaDeMusica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 328)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "InventarioTiendaDeMusica"
        Me.Text = "InventarioTiendaDeMusica"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbPiano As ComboBox
    Friend WithEvents cmbGuitarra As ComboBox
    Friend WithEvents cmbBajo As ComboBox
    Friend WithEvents chkBajo As CheckBox
    Friend WithEvents chkPiano As CheckBox
    Friend WithEvents chkGuitarra As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbAccesorioBajo As ComboBox
    Friend WithEvents cmbAccesorioPiano As ComboBox
    Friend WithEvents cmbAccesorioGuitarra As ComboBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExtrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AfinadorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrimerosPasosToolStripMenuItem As ToolStripMenuItem
End Class
