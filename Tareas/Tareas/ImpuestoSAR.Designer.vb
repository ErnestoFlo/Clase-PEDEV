<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImpuestoSAR
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
        Me.txtSalario = New System.Windows.Forms.MaskedTextBox()
        Me.btnSalario = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSalario
        '
        Me.txtSalario.Location = New System.Drawing.Point(40, 60)
        Me.txtSalario.Mask = "999999999999999999999"
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(100, 20)
        Me.txtSalario.TabIndex = 0
        Me.txtSalario.ValidatingType = GetType(Integer)
        '
        'btnSalario
        '
        Me.btnSalario.Location = New System.Drawing.Point(52, 86)
        Me.btnSalario.Name = "btnSalario"
        Me.btnSalario.Size = New System.Drawing.Size(75, 23)
        Me.btnSalario.TabIndex = 1
        Me.btnSalario.Text = "calcular"
        Me.btnSalario.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Salario"
        '
        'ImpuestoSAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(188, 138)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalario)
        Me.Controls.Add(Me.txtSalario)
        Me.Name = "ImpuestoSAR"
        Me.Text = "ImpuestoSAR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSalario As MaskedTextBox
    Friend WithEvents btnSalario As Button
    Friend WithEvents Label1 As Label
End Class
