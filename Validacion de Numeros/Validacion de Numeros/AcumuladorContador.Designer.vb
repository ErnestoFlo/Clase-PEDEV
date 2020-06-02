<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AcumuladorContador
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOrden = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalPago = New System.Windows.Forms.TextBox()
        Me.txtPagoIndividual = New System.Windows.Forms.TextBox()
        Me.btnSolicitarOrden = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtOrden)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(222, 69)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pedido"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtPagoIndividual)
        Me.GroupBox2.Controls.Add(Me.txtTotalPago)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(222, 100)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pago"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total a Pagar"
        '
        'txtOrden
        '
        Me.txtOrden.Location = New System.Drawing.Point(100, 27)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Size = New System.Drawing.Size(100, 20)
        Me.txtOrden.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Orden Combos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Individual"
        '
        'txtTotalPago
        '
        Me.txtTotalPago.Location = New System.Drawing.Point(100, 27)
        Me.txtTotalPago.Name = "txtTotalPago"
        Me.txtTotalPago.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalPago.TabIndex = 6
        '
        'txtPagoIndividual
        '
        Me.txtPagoIndividual.Location = New System.Drawing.Point(100, 59)
        Me.txtPagoIndividual.Name = "txtPagoIndividual"
        Me.txtPagoIndividual.Size = New System.Drawing.Size(100, 20)
        Me.txtPagoIndividual.TabIndex = 7
        '
        'btnSolicitarOrden
        '
        Me.btnSolicitarOrden.Location = New System.Drawing.Point(261, 58)
        Me.btnSolicitarOrden.Name = "btnSolicitarOrden"
        Me.btnSolicitarOrden.Size = New System.Drawing.Size(75, 40)
        Me.btnSolicitarOrden.TabIndex = 8
        Me.btnSolicitarOrden.Text = "Solicitar Orden"
        Me.btnSolicitarOrden.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(261, 114)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 9
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'AcumuladorContador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 219)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnSolicitarOrden)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AcumuladorContador"
        Me.Text = "AcumuladorContador"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOrden As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotalPago As TextBox
    Friend WithEvents txtPagoIndividual As TextBox
    Friend WithEvents btnSolicitarOrden As Button
    Friend WithEvents btnLimpiar As Button
End Class
