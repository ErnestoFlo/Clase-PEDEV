<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComboBox
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
        Me.cmbListaEquipos = New System.Windows.Forms.ComboBox()
        Me.btnMostraEqu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbListaEquipos
        '
        Me.cmbListaEquipos.FormattingEnabled = True
        Me.cmbListaEquipos.Items.AddRange(New Object() {"Real Madrid", "Barcelona", "Liverpool", "Juventus", "B.Dortmund"})
        Me.cmbListaEquipos.Location = New System.Drawing.Point(77, 74)
        Me.cmbListaEquipos.Name = "cmbListaEquipos"
        Me.cmbListaEquipos.Size = New System.Drawing.Size(121, 21)
        Me.cmbListaEquipos.TabIndex = 0
        '
        'btnMostraEqu
        '
        Me.btnMostraEqu.Location = New System.Drawing.Point(100, 116)
        Me.btnMostraEqu.Name = "btnMostraEqu"
        Me.btnMostraEqu.Size = New System.Drawing.Size(75, 23)
        Me.btnMostraEqu.TabIndex = 1
        Me.btnMostraEqu.Text = "Mostrar"
        Me.btnMostraEqu.UseVisualStyleBackColor = True
        '
        'ComboBox
        '
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnMostraEqu)
        Me.Controls.Add(Me.cmbListaEquipos)
        Me.Name = "ComboBox"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMostrar As Button
    Friend WithEvents cmbEquipos As Windows.Forms.ComboBox
    Friend WithEvents cmbListaEquipos As Windows.Forms.ComboBox
    Friend WithEvents btnMostraEqu As Button
End Class
