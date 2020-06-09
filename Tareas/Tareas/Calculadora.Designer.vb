<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
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
        Me.txtValores = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ltbHistorial = New System.Windows.Forms.ListBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btnMultiplicacion = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.btnPunto = New System.Windows.Forms.Button()
        Me.btnEntreNegativo = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnIgual = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtValores
        '
        Me.txtValores.Location = New System.Drawing.Point(12, 22)
        Me.txtValores.Name = "txtValores"
        Me.txtValores.Size = New System.Drawing.Size(231, 20)
        Me.txtValores.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(249, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Historial"
        '
        'ltbHistorial
        '
        Me.ltbHistorial.FormattingEnabled = True
        Me.ltbHistorial.Location = New System.Drawing.Point(252, 37)
        Me.ltbHistorial.Name = "ltbHistorial"
        Me.ltbHistorial.Size = New System.Drawing.Size(148, 121)
        Me.ltbHistorial.TabIndex = 2
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(12, 48)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(34, 23)
        Me.btn1.TabIndex = 3
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btnMultiplicacion
        '
        Me.btnMultiplicacion.Location = New System.Drawing.Point(132, 77)
        Me.btnMultiplicacion.Name = "btnMultiplicacion"
        Me.btnMultiplicacion.Size = New System.Drawing.Size(34, 23)
        Me.btnMultiplicacion.TabIndex = 4
        Me.btnMultiplicacion.Text = "x"
        Me.btnMultiplicacion.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        Me.btnDivision.Location = New System.Drawing.Point(132, 48)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(34, 23)
        Me.btnDivision.TabIndex = 5
        Me.btnDivision.Text = "/"
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'btnPunto
        '
        Me.btnPunto.Location = New System.Drawing.Point(92, 135)
        Me.btnPunto.Name = "btnPunto"
        Me.btnPunto.Size = New System.Drawing.Size(34, 23)
        Me.btnPunto.TabIndex = 6
        Me.btnPunto.Text = "."
        Me.btnPunto.UseVisualStyleBackColor = True
        '
        'btnEntreNegativo
        '
        Me.btnEntreNegativo.Location = New System.Drawing.Point(52, 135)
        Me.btnEntreNegativo.Name = "btnEntreNegativo"
        Me.btnEntreNegativo.Size = New System.Drawing.Size(34, 23)
        Me.btnEntreNegativo.TabIndex = 7
        Me.btnEntreNegativo.Text = "+/-"
        Me.btnEntreNegativo.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(12, 135)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(34, 23)
        Me.btn0.TabIndex = 8
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(92, 106)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(34, 23)
        Me.btn9.TabIndex = 9
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(52, 106)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(34, 23)
        Me.btn8.TabIndex = 10
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(12, 106)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(34, 23)
        Me.btn7.TabIndex = 11
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(92, 77)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(34, 23)
        Me.btn6.TabIndex = 12
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(52, 77)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(34, 23)
        Me.btn5.TabIndex = 13
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(12, 77)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(34, 23)
        Me.btn4.TabIndex = 14
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(92, 48)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(34, 23)
        Me.btn3.TabIndex = 15
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(52, 48)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(34, 23)
        Me.btn2.TabIndex = 16
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btnSuma
        '
        Me.btnSuma.Location = New System.Drawing.Point(132, 135)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(34, 23)
        Me.btnSuma.TabIndex = 17
        Me.btnSuma.Text = "+"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'btnResta
        '
        Me.btnResta.Location = New System.Drawing.Point(132, 106)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(34, 23)
        Me.btnResta.TabIndex = 18
        Me.btnResta.Text = "-"
        Me.btnResta.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(172, 48)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(74, 52)
        Me.btnLimpiar.TabIndex = 19
        Me.btnLimpiar.Text = "LImpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnIgual
        '
        Me.btnIgual.Location = New System.Drawing.Point(172, 106)
        Me.btnIgual.Name = "btnIgual"
        Me.btnIgual.Size = New System.Drawing.Size(74, 52)
        Me.btnIgual.TabIndex = 20
        Me.btnIgual.Text = "="
        Me.btnIgual.UseVisualStyleBackColor = True
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 180)
        Me.Controls.Add(Me.btnIgual)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnResta)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btnEntreNegativo)
        Me.Controls.Add(Me.btnPunto)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btnMultiplicacion)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.ltbHistorial)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtValores)
        Me.Name = "Calculadora"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtValores As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ltbHistorial As ListBox
    Friend WithEvents btn1 As Button
    Friend WithEvents btnMultiplicacion As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents btnPunto As Button
    Friend WithEvents btnEntreNegativo As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnResta As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnIgual As Button
End Class
