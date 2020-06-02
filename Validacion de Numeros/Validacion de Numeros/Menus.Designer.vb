<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menus
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.cmbSuma = New System.Windows.Forms.ComboBox()
        Me.cmbDivision = New System.Windows.Forms.ComboBox()
        Me.cmbMultiplicacion = New System.Windows.Forms.ComboBox()
        Me.cmbResta = New System.Windows.Forms.ComboBox()
        Me.txtIngresar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Opción2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValidacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErrorProviderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CondicionalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtIngresar)
        Me.GroupBox1.Controls.Add(Me.btnIngresar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 53)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar Valor"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmbDivision)
        Me.GroupBox2.Controls.Add(Me.cmbMultiplicacion)
        Me.GroupBox2.Controls.Add(Me.cmbResta)
        Me.GroupBox2.Controls.Add(Me.cmbSuma)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 190)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(280, 168)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCalcular)
        Me.GroupBox3.Controls.Add(Me.btnSalir)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 117)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(280, 58)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones"
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(6, 28)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresar.TabIndex = 10
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(92, 31)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(6, 31)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 12
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'cmbSuma
        '
        Me.cmbSuma.FormattingEnabled = True
        Me.cmbSuma.Location = New System.Drawing.Point(6, 52)
        Me.cmbSuma.Name = "cmbSuma"
        Me.cmbSuma.Size = New System.Drawing.Size(121, 21)
        Me.cmbSuma.TabIndex = 13
        '
        'cmbDivision
        '
        Me.cmbDivision.FormattingEnabled = True
        Me.cmbDivision.Location = New System.Drawing.Point(133, 117)
        Me.cmbDivision.Name = "cmbDivision"
        Me.cmbDivision.Size = New System.Drawing.Size(121, 21)
        Me.cmbDivision.TabIndex = 14
        '
        'cmbMultiplicacion
        '
        Me.cmbMultiplicacion.FormattingEnabled = True
        Me.cmbMultiplicacion.Location = New System.Drawing.Point(6, 117)
        Me.cmbMultiplicacion.Name = "cmbMultiplicacion"
        Me.cmbMultiplicacion.Size = New System.Drawing.Size(121, 21)
        Me.cmbMultiplicacion.TabIndex = 15
        '
        'cmbResta
        '
        Me.cmbResta.FormattingEnabled = True
        Me.cmbResta.Location = New System.Drawing.Point(133, 52)
        Me.cmbResta.Name = "cmbResta"
        Me.cmbResta.Size = New System.Drawing.Size(121, 21)
        Me.cmbResta.TabIndex = 16
        '
        'txtIngresar
        '
        Me.txtIngresar.Location = New System.Drawing.Point(92, 30)
        Me.txtIngresar.Name = "txtIngresar"
        Me.txtIngresar.Size = New System.Drawing.Size(100, 20)
        Me.txtIngresar.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Multiplicación "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(130, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "División"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(130, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Resta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Suma "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.Opción2ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(309, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'Opción2ToolStripMenuItem
        '
        Me.Opción2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ValidacionesToolStripMenuItem})
        Me.Opción2ToolStripMenuItem.Name = "Opción2ToolStripMenuItem"
        Me.Opción2ToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.Opción2ToolStripMenuItem.Text = "Opción 2"
        '
        'ValidacionesToolStripMenuItem
        '
        Me.ValidacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ErrorProviderToolStripMenuItem, Me.CondicionalesToolStripMenuItem})
        Me.ValidacionesToolStripMenuItem.Name = "ValidacionesToolStripMenuItem"
        Me.ValidacionesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ValidacionesToolStripMenuItem.Text = "Validaciones"
        '
        'ErrorProviderToolStripMenuItem
        '
        Me.ErrorProviderToolStripMenuItem.Name = "ErrorProviderToolStripMenuItem"
        Me.ErrorProviderToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ErrorProviderToolStripMenuItem.Text = "Error Provider"
        '
        'CondicionalesToolStripMenuItem
        '
        Me.CondicionalesToolStripMenuItem.Name = "CondicionalesToolStripMenuItem"
        Me.CondicionalesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CondicionalesToolStripMenuItem.Text = "Condicionales"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Menus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 388)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menus"
        Me.Text = "Menus"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents cmbSuma As Windows.Forms.ComboBox
    Friend WithEvents cmbDivision As Windows.Forms.ComboBox
    Friend WithEvents cmbMultiplicacion As Windows.Forms.ComboBox
    Friend WithEvents cmbResta As Windows.Forms.ComboBox
    Friend WithEvents txtIngresar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Opción2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ValidacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ErrorProviderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CondicionalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
