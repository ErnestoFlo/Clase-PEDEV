Imports System.ComponentModel

Public Class PruebasRealizadas
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try
            ltbNombre.Items.Add(txtNombre.Text)
            ltbEdad.Items.Add(txtEdad.Text)
            ltbMunicipio.Items.Add(txtMunicipio.Text)

            If txtNombre.Text = "" Then
                MsgBox("Olvido rellenar una casilla", vbInformation)
            ElseIf IsNumeric(txtNombre.Text) Then
                MsgBox("No ingrese valores numericos en su nombre", vbInformation)
            End If

            If Not IsNumeric(txtEdad.Text) Then
                MsgBox("Ingrese un valor numerico para su edad", vbInformation)
            End If

            If txtMunicipio.Text = "" Then
                MsgBox("Olvido rellenar una casilla", vbInformation)
            ElseIf IsNumeric(txtMunicipio.Text) Then
                MsgBox("No ingrese valores numericos en su municipio", vbInformation)
            End If

            Select Case cmbDepartamento.SelectedIndex
                Case 0
                    ltbDepartamento.Items.Add("Atlántida")

                Case 1
                    ltbDepartamento.Items.Add("Choluteca")

                Case 2
                    ltbDepartamento.Items.Add("Colón")

                Case 3
                    ltbDepartamento.Items.Add("Comayagua")

                Case 4
                    ltbDepartamento.Items.Add("Copán")

                Case 5
                    ltbDepartamento.Items.Add("Cortés")

                Case 6
                    ltbDepartamento.Items.Add("El Paraíso")

                Case 7
                    ltbDepartamento.Items.Add("Francisco Morazán")

                Case 8
                    ltbDepartamento.Items.Add("Gracias a Dios")

                Case 9
                    ltbDepartamento.Items.Add("Intibucá")

                Case 10
                    ltbDepartamento.Items.Add("Islas de la Bahía")

                Case 11
                    ltbDepartamento.Items.Add("La Paz")

                Case 12
                    ltbDepartamento.Items.Add("Lempira")

                Case 13
                    ltbDepartamento.Items.Add("Ocotepeque")

                Case 14
                    ltbDepartamento.Items.Add("Olancho")

                Case 15
                    ltbDepartamento.Items.Add("Santa Bárbar")

                Case 16
                    ltbDepartamento.Items.Add("Valle")

                Case 17
                    ltbDepartamento.Items.Add("Yoro")
            End Select

            Select Case cmbResultado.SelectedIndex
                Case 0
                    ltbResultado.Items.Add("P")

                Case 1
                    ltbResultado.Items.Add("N")

            End Select

            Select Case cmbEstado.SelectedIndex
                Case 0
                    ltbEstado.Items.Add("Activo")

                Case 1
                    ltbEstado.Items.Add("Recuperado")

                Case 2
                    ltbEstado.Items.Add("Fallecido")

            End Select


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub chkEstado_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstado.CheckedChanged
        If chkEstado.Checked = True Then
            cmbEstado.Enabled = True
        Else
            cmbEstado.Enabled = False
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If opcion = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtDescripcion.Clear()
        txtEdad.Clear()
        txtMunicipio.Clear()
        txtNombre.Clear()
        cmbDepartamento.ResetText()
        cmbEstado.ResetText()
        cmbResultado.ResetText()
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip1.SetToolTip(txtNombre, "Ingresar nombre de paciente. Ejem(Oscar Hernandez Manzanares)")
        ToolTip1.ToolTipTitle = "Informacion Nombre"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEdad_MouseHover(sender As Object, e As EventArgs) Handles txtEdad.MouseHover
        ToolTip1.SetToolTip(txtEdad, "Ingresar Edad de paciente *solo numerico*.")
        ToolTip1.ToolTipTitle = "Informacion Edad"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbDepartamento_MouseHover(sender As Object, e As EventArgs) Handles cmbDepartamento.MouseHover
        ToolTip1.SetToolTip(cmbDepartamento, "Ingresar nombre Departamento. Zona en donde Habita")
        ToolTip1.ToolTipTitle = "Informacion Departamento"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtMunicipio_MouseHover(sender As Object, e As EventArgs) Handles txtMunicipio.MouseHover
        ToolTip1.SetToolTip(txtMunicipio, "Ingresar nombre de Municipio.Zona especifica de paciente")
        ToolTip1.ToolTipTitle = "Informacion Municipio"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbResultado_MouseHover(sender As Object, e As EventArgs) Handles cmbResultado.MouseHover
        ToolTip1.SetToolTip(cmbResultado, "Ingresar resultado de la prueba. NO omitir este paso")
        ToolTip1.ToolTipTitle = "Informacion Resultado"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub chkEstado_MouseHover(sender As Object, e As EventArgs) Handles chkEstado.MouseHover
        ToolTip1.SetToolTip(chkEstado, "ACTIVAR SOLO SI ES POSITIVO)")
        ToolTip1.ToolTipTitle = "Informacion Estado"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbEstado_MouseHover(sender As Object, e As EventArgs) Handles cmbEstado.MouseHover
        ToolTip1.SetToolTip(cmbEstado, "Ingresar estado del paciente.")
        ToolTip1.ToolTipTitle = "Informacion Estado"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDescripcion_MouseHover(sender As Object, e As EventArgs) Handles txtDescripcion.MouseHover
        ToolTip1.SetToolTip(txtDescripcion, "Ingrese breve descripcion del paciente")
        ToolTip1.ToolTipTitle = ""
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Espacio Obligatorio")
        End If
    End Sub

    Private Sub txtEdad_TextChanged(sender As Object, e As EventArgs) Handles txtEdad.TextChanged

    End Sub

    Private Sub txtMunicipio_TextChanged(sender As Object, e As EventArgs) Handles txtMunicipio.TextChanged

    End Sub

    Private Sub txtEdad_Validating(sender As Object, e As CancelEventArgs) Handles txtEdad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Espacio Obligatorio")
        End If
    End Sub

    Private Sub txtMunicipio_Validating(sender As Object, e As CancelEventArgs) Handles txtMunicipio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Espacio Obligatorio")
        End If
    End Sub

    Private Sub cmbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartamento.SelectedIndexChanged

    End Sub

    Private Sub cmbDepartamento_Validating(sender As Object, e As CancelEventArgs) Handles cmbDepartamento.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Espacio Obligatorio")
        End If
    End Sub

    Private Sub cmbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEstado.SelectedIndexChanged

    End Sub

    Private Sub cmbEstado_Validating(sender As Object, e As CancelEventArgs) Handles cmbEstado.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Espacio Obligatorio")
        End If
    End Sub
End Class