<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClasificacionDeNumeros
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbListaNumeros = New System.Windows.Forms.ComboBox()
        Me.txtImpar = New System.Windows.Forms.TextBox()
        Me.txtPositivo = New System.Windows.Forms.TextBox()
        Me.txtNegativo = New System.Windows.Forms.TextBox()
        Me.txtPar = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIngresoDeNumeros = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtIngresoDeNumeros)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbListaNumeros)
        Me.GroupBox1.Controls.Add(Me.txtImpar)
        Me.GroupBox1.Controls.Add(Me.txtPositivo)
        Me.GroupBox1.Controls.Add(Me.txtNegativo)
        Me.GroupBox1.Controls.Add(Me.txtPar)
        Me.GroupBox1.Controls.Add(Me.btnIngresar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 161)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(166, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(221, 129)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(166, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Negativo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(166, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Positivo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(166, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Impar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Par"
        '
        'cmbListaNumeros
        '
        Me.cmbListaNumeros.FormattingEnabled = True
        Me.cmbListaNumeros.Location = New System.Drawing.Point(21, 99)
        Me.cmbListaNumeros.Name = "cmbListaNumeros"
        Me.cmbListaNumeros.Size = New System.Drawing.Size(121, 21)
        Me.cmbListaNumeros.TabIndex = 7
        '
        'txtImpar
        '
        Me.txtImpar.Location = New System.Drawing.Point(221, 51)
        Me.txtImpar.Name = "txtImpar"
        Me.txtImpar.ReadOnly = True
        Me.txtImpar.Size = New System.Drawing.Size(100, 20)
        Me.txtImpar.TabIndex = 6
        '
        'txtPositivo
        '
        Me.txtPositivo.Location = New System.Drawing.Point(221, 77)
        Me.txtPositivo.Name = "txtPositivo"
        Me.txtPositivo.ReadOnly = True
        Me.txtPositivo.Size = New System.Drawing.Size(100, 20)
        Me.txtPositivo.TabIndex = 5
        '
        'txtNegativo
        '
        Me.txtNegativo.Location = New System.Drawing.Point(221, 103)
        Me.txtNegativo.Name = "txtNegativo"
        Me.txtNegativo.ReadOnly = True
        Me.txtNegativo.Size = New System.Drawing.Size(100, 20)
        Me.txtNegativo.TabIndex = 4
        '
        'txtPar
        '
        Me.txtPar.Location = New System.Drawing.Point(221, 25)
        Me.txtPar.Name = "txtPar"
        Me.txtPar.ReadOnly = True
        Me.txtPar.Size = New System.Drawing.Size(100, 20)
        Me.txtPar.TabIndex = 3
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(21, 70)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresar.TabIndex = 2
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese Numeros"
        '
        'txtIngresoDeNumeros
        '
        Me.txtIngresoDeNumeros.Location = New System.Drawing.Point(21, 44)
        Me.txtIngresoDeNumeros.Name = "txtIngresoDeNumeros"
        Me.txtIngresoDeNumeros.Size = New System.Drawing.Size(121, 20)
        Me.txtIngresoDeNumeros.TabIndex = 14
        '
        'ClasificacionDeNumeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 190)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ClasificacionDeNumeros"
        Me.Text = "ClasificacionDeNumeros"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbListaNumeros As ComboBox
    Friend WithEvents txtImpar As TextBox
    Friend WithEvents txtPositivo As TextBox
    Friend WithEvents txtNegativo As TextBox
    Friend WithEvents txtPar As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtIngresoDeNumeros As TextBox
End Class
