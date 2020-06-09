<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlmacenesEmpresa
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
        Me.Almacenes = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtVentaMesG = New System.Windows.Forms.MaskedTextBox()
        Me.txtVentaMesH = New System.Windows.Forms.MaskedTextBox()
        Me.txtVentaMesI = New System.Windows.Forms.MaskedTextBox()
        Me.txtVentaMesJ = New System.Windows.Forms.MaskedTextBox()
        Me.txtVentaMesF = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVentaMesB = New System.Windows.Forms.MaskedTextBox()
        Me.txtVentaMesC = New System.Windows.Forms.MaskedTextBox()
        Me.txtVentaMesD = New System.Windows.Forms.MaskedTextBox()
        Me.txtVentaMesE = New System.Windows.Forms.MaskedTextBox()
        Me.txtVentaMesA = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Almacenes.SuspendLayout()
        Me.SuspendLayout()
        '
        'Almacenes
        '
        Me.Almacenes.Controls.Add(Me.btnLimpiar)
        Me.Almacenes.Controls.Add(Me.Label2)
        Me.Almacenes.Controls.Add(Me.btnCalcular)
        Me.Almacenes.Controls.Add(Me.Label7)
        Me.Almacenes.Controls.Add(Me.Label8)
        Me.Almacenes.Controls.Add(Me.Label9)
        Me.Almacenes.Controls.Add(Me.txtVentaMesG)
        Me.Almacenes.Controls.Add(Me.txtVentaMesH)
        Me.Almacenes.Controls.Add(Me.txtVentaMesI)
        Me.Almacenes.Controls.Add(Me.txtVentaMesJ)
        Me.Almacenes.Controls.Add(Me.txtVentaMesF)
        Me.Almacenes.Controls.Add(Me.Label10)
        Me.Almacenes.Controls.Add(Me.Label6)
        Me.Almacenes.Controls.Add(Me.Label5)
        Me.Almacenes.Controls.Add(Me.Label4)
        Me.Almacenes.Controls.Add(Me.Label3)
        Me.Almacenes.Controls.Add(Me.txtVentaMesB)
        Me.Almacenes.Controls.Add(Me.txtVentaMesC)
        Me.Almacenes.Controls.Add(Me.txtVentaMesD)
        Me.Almacenes.Controls.Add(Me.txtVentaMesE)
        Me.Almacenes.Controls.Add(Me.txtVentaMesA)
        Me.Almacenes.Controls.Add(Me.Label1)
        Me.Almacenes.Location = New System.Drawing.Point(23, 22)
        Me.Almacenes.Name = "Almacenes"
        Me.Almacenes.Size = New System.Drawing.Size(433, 164)
        Me.Almacenes.TabIndex = 0
        Me.Almacenes.TabStop = False
        Me.Almacenes.Text = "Almacenes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(182, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Almac. G"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(182, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Almac. H"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(182, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Almac. I"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(182, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Almac. J"
        '
        'txtVentaMesG
        '
        Me.txtVentaMesG.Location = New System.Drawing.Point(242, 52)
        Me.txtVentaMesG.Mask = "99999"
        Me.txtVentaMesG.Name = "txtVentaMesG"
        Me.txtVentaMesG.Size = New System.Drawing.Size(100, 20)
        Me.txtVentaMesG.TabIndex = 16
        Me.txtVentaMesG.ValidatingType = GetType(Integer)
        '
        'txtVentaMesH
        '
        Me.txtVentaMesH.Location = New System.Drawing.Point(242, 78)
        Me.txtVentaMesH.Mask = "99999"
        Me.txtVentaMesH.Name = "txtVentaMesH"
        Me.txtVentaMesH.Size = New System.Drawing.Size(100, 20)
        Me.txtVentaMesH.TabIndex = 15
        Me.txtVentaMesH.ValidatingType = GetType(Integer)
        '
        'txtVentaMesI
        '
        Me.txtVentaMesI.Location = New System.Drawing.Point(242, 104)
        Me.txtVentaMesI.Mask = "99999"
        Me.txtVentaMesI.Name = "txtVentaMesI"
        Me.txtVentaMesI.Size = New System.Drawing.Size(100, 20)
        Me.txtVentaMesI.TabIndex = 14
        Me.txtVentaMesI.ValidatingType = GetType(Integer)
        '
        'txtVentaMesJ
        '
        Me.txtVentaMesJ.Location = New System.Drawing.Point(242, 130)
        Me.txtVentaMesJ.Mask = "99999"
        Me.txtVentaMesJ.Name = "txtVentaMesJ"
        Me.txtVentaMesJ.Size = New System.Drawing.Size(100, 20)
        Me.txtVentaMesJ.TabIndex = 13
        Me.txtVentaMesJ.ValidatingType = GetType(Integer)
        '
        'txtVentaMesF
        '
        Me.txtVentaMesF.Location = New System.Drawing.Point(242, 26)
        Me.txtVentaMesF.Mask = "99999"
        Me.txtVentaMesF.Name = "txtVentaMesF"
        Me.txtVentaMesF.Size = New System.Drawing.Size(100, 20)
        Me.txtVentaMesF.TabIndex = 12
        Me.txtVentaMesF.ValidatingType = GetType(Integer)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(182, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Almac. F"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Almac. B"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Almac. C"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Almac. D"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Almac. E"
        '
        'txtVentaMesB
        '
        Me.txtVentaMesB.Location = New System.Drawing.Point(66, 52)
        Me.txtVentaMesB.Mask = "99999"
        Me.txtVentaMesB.Name = "txtVentaMesB"
        Me.txtVentaMesB.Size = New System.Drawing.Size(100, 20)
        Me.txtVentaMesB.TabIndex = 5
        Me.txtVentaMesB.ValidatingType = GetType(Integer)
        '
        'txtVentaMesC
        '
        Me.txtVentaMesC.Location = New System.Drawing.Point(66, 78)
        Me.txtVentaMesC.Mask = "99999"
        Me.txtVentaMesC.Name = "txtVentaMesC"
        Me.txtVentaMesC.Size = New System.Drawing.Size(100, 20)
        Me.txtVentaMesC.TabIndex = 4
        Me.txtVentaMesC.ValidatingType = GetType(Integer)
        '
        'txtVentaMesD
        '
        Me.txtVentaMesD.Location = New System.Drawing.Point(66, 104)
        Me.txtVentaMesD.Mask = "99999"
        Me.txtVentaMesD.Name = "txtVentaMesD"
        Me.txtVentaMesD.Size = New System.Drawing.Size(100, 20)
        Me.txtVentaMesD.TabIndex = 3
        Me.txtVentaMesD.ValidatingType = GetType(Integer)
        '
        'txtVentaMesE
        '
        Me.txtVentaMesE.Location = New System.Drawing.Point(66, 130)
        Me.txtVentaMesE.Mask = "99999"
        Me.txtVentaMesE.Name = "txtVentaMesE"
        Me.txtVentaMesE.Size = New System.Drawing.Size(100, 20)
        Me.txtVentaMesE.TabIndex = 2
        Me.txtVentaMesE.ValidatingType = GetType(Integer)
        '
        'txtVentaMesA
        '
        Me.txtVentaMesA.Location = New System.Drawing.Point(66, 26)
        Me.txtVentaMesA.Mask = "99999"
        Me.txtVentaMesA.Name = "txtVentaMesA"
        Me.txtVentaMesA.Size = New System.Drawing.Size(100, 20)
        Me.txtVentaMesA.TabIndex = 1
        Me.txtVentaMesA.ValidatingType = GetType(Integer)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Almac. A"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(348, 24)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 48)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(348, 104)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 46)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'AlmacenesEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 210)
        Me.Controls.Add(Me.Almacenes)
        Me.Name = "AlmacenesEmpresa"
        Me.Text = "AlmacenesEmpresa"
        Me.Almacenes.ResumeLayout(False)
        Me.Almacenes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Almacenes As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtVentaMesB As MaskedTextBox
    Friend WithEvents txtVentaMesC As MaskedTextBox
    Friend WithEvents txtVentaMesD As MaskedTextBox
    Friend WithEvents txtVentaMesE As MaskedTextBox
    Friend WithEvents txtVentaMesA As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtVentaMesG As MaskedTextBox
    Friend WithEvents txtVentaMesH As MaskedTextBox
    Friend WithEvents txtVentaMesI As MaskedTextBox
    Friend WithEvents txtVentaMesJ As MaskedTextBox
    Friend WithEvents txtVentaMesF As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnCalcular As Button
End Class
