<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrimerosPasos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnNoobGuitarra = New System.Windows.Forms.Button()
        Me.btnMedioGuitarra = New System.Windows.Forms.Button()
        Me.btnProGuitarra = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnProBajo = New System.Windows.Forms.Button()
        Me.btnMedioBajo = New System.Windows.Forms.Button()
        Me.btnNoobBajo = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnProPiano = New System.Windows.Forms.Button()
        Me.btnMedioPiano = New System.Windows.Forms.Button()
        Me.btnNoobPiano = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(170, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Recomendaciones"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnProGuitarra)
        Me.GroupBox1.Controls.Add(Me.btnMedioGuitarra)
        Me.GroupBox1.Controls.Add(Me.btnNoobGuitarra)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 125)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Guitarra"
        '
        'btnNoobGuitarra
        '
        Me.btnNoobGuitarra.Location = New System.Drawing.Point(22, 28)
        Me.btnNoobGuitarra.Name = "btnNoobGuitarra"
        Me.btnNoobGuitarra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnNoobGuitarra.Size = New System.Drawing.Size(75, 23)
        Me.btnNoobGuitarra.TabIndex = 2
        Me.btnNoobGuitarra.Text = "Noob"
        Me.btnNoobGuitarra.UseVisualStyleBackColor = True
        '
        'btnMedioGuitarra
        '
        Me.btnMedioGuitarra.Location = New System.Drawing.Point(22, 57)
        Me.btnMedioGuitarra.Name = "btnMedioGuitarra"
        Me.btnMedioGuitarra.Size = New System.Drawing.Size(75, 23)
        Me.btnMedioGuitarra.TabIndex = 3
        Me.btnMedioGuitarra.Text = "Medium"
        Me.btnMedioGuitarra.UseVisualStyleBackColor = True
        '
        'btnProGuitarra
        '
        Me.btnProGuitarra.Location = New System.Drawing.Point(22, 86)
        Me.btnProGuitarra.Name = "btnProGuitarra"
        Me.btnProGuitarra.Size = New System.Drawing.Size(75, 23)
        Me.btnProGuitarra.TabIndex = 4
        Me.btnProGuitarra.Text = "Pro"
        Me.btnProGuitarra.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnProBajo)
        Me.GroupBox2.Controls.Add(Me.btnMedioBajo)
        Me.GroupBox2.Controls.Add(Me.btnNoobBajo)
        Me.GroupBox2.Location = New System.Drawing.Point(292, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(120, 125)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bajo"
        '
        'btnProBajo
        '
        Me.btnProBajo.Location = New System.Drawing.Point(22, 86)
        Me.btnProBajo.Name = "btnProBajo"
        Me.btnProBajo.Size = New System.Drawing.Size(75, 23)
        Me.btnProBajo.TabIndex = 4
        Me.btnProBajo.Text = "Pro"
        Me.btnProBajo.UseVisualStyleBackColor = True
        '
        'btnMedioBajo
        '
        Me.btnMedioBajo.Location = New System.Drawing.Point(22, 57)
        Me.btnMedioBajo.Name = "btnMedioBajo"
        Me.btnMedioBajo.Size = New System.Drawing.Size(75, 23)
        Me.btnMedioBajo.TabIndex = 3
        Me.btnMedioBajo.Text = "Medium"
        Me.btnMedioBajo.UseVisualStyleBackColor = True
        '
        'btnNoobBajo
        '
        Me.btnNoobBajo.Location = New System.Drawing.Point(22, 28)
        Me.btnNoobBajo.Name = "btnNoobBajo"
        Me.btnNoobBajo.Size = New System.Drawing.Size(75, 23)
        Me.btnNoobBajo.TabIndex = 2
        Me.btnNoobBajo.Text = "Noob"
        Me.btnNoobBajo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnProPiano)
        Me.GroupBox3.Controls.Add(Me.btnMedioPiano)
        Me.GroupBox3.Controls.Add(Me.btnNoobPiano)
        Me.GroupBox3.Location = New System.Drawing.Point(151, 57)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(120, 125)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Piano"
        '
        'btnProPiano
        '
        Me.btnProPiano.Location = New System.Drawing.Point(22, 86)
        Me.btnProPiano.Name = "btnProPiano"
        Me.btnProPiano.Size = New System.Drawing.Size(75, 23)
        Me.btnProPiano.TabIndex = 4
        Me.btnProPiano.Text = "Pro"
        Me.btnProPiano.UseVisualStyleBackColor = True
        '
        'btnMedioPiano
        '
        Me.btnMedioPiano.Location = New System.Drawing.Point(22, 57)
        Me.btnMedioPiano.Name = "btnMedioPiano"
        Me.btnMedioPiano.Size = New System.Drawing.Size(75, 23)
        Me.btnMedioPiano.TabIndex = 3
        Me.btnMedioPiano.Text = "Medium"
        Me.btnMedioPiano.UseVisualStyleBackColor = True
        '
        'btnNoobPiano
        '
        Me.btnNoobPiano.Location = New System.Drawing.Point(22, 28)
        Me.btnNoobPiano.Name = "btnNoobPiano"
        Me.btnNoobPiano.Size = New System.Drawing.Size(75, 23)
        Me.btnNoobPiano.TabIndex = 2
        Me.btnNoobPiano.Text = "Noob"
        Me.btnNoobPiano.UseVisualStyleBackColor = True
        '
        'PrimerosPasos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 204)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PrimerosPasos"
        Me.Text = "PrimerosPasos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnProGuitarra As Button
    Friend WithEvents btnMedioGuitarra As Button
    Friend WithEvents btnNoobGuitarra As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnProBajo As Button
    Friend WithEvents btnMedioBajo As Button
    Friend WithEvents btnNoobBajo As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnProPiano As Button
    Friend WithEvents btnMedioPiano As Button
    Friend WithEvents btnNoobPiano As Button
End Class
