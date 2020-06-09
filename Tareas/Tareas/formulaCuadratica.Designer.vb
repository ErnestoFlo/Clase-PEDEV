<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formulaCuadratica
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtRespuestaB = New System.Windows.Forms.MaskedTextBox()
        Me.txtRespuesta = New System.Windows.Forms.MaskedTextBox()
        Me.txtValorB = New System.Windows.Forms.MaskedTextBox()
        Me.txtValorC = New System.Windows.Forms.MaskedTextBox()
        Me.txtValorA = New System.Windows.Forms.MaskedTextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.txtRespuestaB)
        Me.GroupBox1.Controls.Add(Me.txtRespuesta)
        Me.GroupBox1.Controls.Add(Me.txtValorB)
        Me.GroupBox1.Controls.Add(Me.txtValorC)
        Me.GroupBox1.Controls.Add(Me.txtValorA)
        Me.GroupBox1.Controls.Add(Me.btnCalcular)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 176)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese los valores"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(6, 136)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 9
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'txtRespuestaB
        '
        Me.txtRespuestaB.Location = New System.Drawing.Point(101, 136)
        Me.txtRespuestaB.Mask = "99999"
        Me.txtRespuestaB.Name = "txtRespuestaB"
        Me.txtRespuestaB.ReadOnly = True
        Me.txtRespuestaB.Size = New System.Drawing.Size(100, 20)
        Me.txtRespuestaB.TabIndex = 8
        Me.txtRespuestaB.ValidatingType = GetType(Integer)
        '
        'txtRespuesta
        '
        Me.txtRespuesta.Location = New System.Drawing.Point(101, 110)
        Me.txtRespuesta.Mask = "99999"
        Me.txtRespuesta.Name = "txtRespuesta"
        Me.txtRespuesta.ReadOnly = True
        Me.txtRespuesta.Size = New System.Drawing.Size(100, 20)
        Me.txtRespuesta.TabIndex = 7
        Me.txtRespuesta.ValidatingType = GetType(Integer)
        '
        'txtValorB
        '
        Me.txtValorB.Location = New System.Drawing.Point(101, 44)
        Me.txtValorB.Mask = "99999"
        Me.txtValorB.Name = "txtValorB"
        Me.txtValorB.Size = New System.Drawing.Size(100, 20)
        Me.txtValorB.TabIndex = 6
        Me.txtValorB.ValidatingType = GetType(Integer)
        '
        'txtValorC
        '
        Me.txtValorC.Location = New System.Drawing.Point(101, 70)
        Me.txtValorC.Mask = "99999"
        Me.txtValorC.Name = "txtValorC"
        Me.txtValorC.Size = New System.Drawing.Size(100, 20)
        Me.txtValorC.TabIndex = 5
        Me.txtValorC.ValidatingType = GetType(Integer)
        '
        'txtValorA
        '
        Me.txtValorA.Location = New System.Drawing.Point(101, 18)
        Me.txtValorA.Mask = "99999"
        Me.txtValorA.Name = "txtValorA"
        Me.txtValorA.Size = New System.Drawing.Size(100, 20)
        Me.txtValorA.TabIndex = 4
        Me.txtValorA.ValidatingType = GetType(Integer)
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(6, 107)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 3
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Valor C"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valor B"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor A"
        '
        'formulaCuadratica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 241)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formulaCuadratica"
        Me.Text = "formulaCuadratica"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtRespuesta As MaskedTextBox
    Friend WithEvents txtValorB As MaskedTextBox
    Friend WithEvents txtValorC As MaskedTextBox
    Friend WithEvents txtValorA As MaskedTextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRespuestaB As MaskedTextBox
    Friend WithEvents btnLimpiar As Button
End Class
