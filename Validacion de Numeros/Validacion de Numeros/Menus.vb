Public Class Menus
    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim suma, resta, multiplicacion, valor As Integer
        Dim division As Double
        valor = Val(txtIngresar.Text)
        For i = 1 To 10 Step 1
            suma = valor + i
            resta = valor - i
            multiplicacion = valor * i
            division = (valor / i)
            cmbSuma.Items.Add(valor & " + " & i & "=" & suma)
            cmbResta.Items.Add(valor & " - " & i & "=" & resta)
            cmbMultiplicacion.Items.Add(valor & " x " & i & "=" & multiplicacion)
            cmbDivision.Items.Add(valor & " / " & i & "=" & division)
        Next
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim valor As Integer
        valor = InputBox("Ingrese numero", "Ingreso")
        txtIngresar.Text = valor
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class