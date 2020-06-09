Public Class ClasificacionDeNumeros
    Dim eva As String
    Dim par, impar, positivo, negativo, total, valor As Integer
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If txtIngresoDeNumeros.Text = "" Then
            MsgBox("Ingrese un valor en la casilla", vbInformation)
        ElseIf Not IsNumeric(txtIngresoDeNumeros.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
        End If

        valor = txtIngresoDeNumeros.Text
        eva = txtIngresoDeNumeros.Text
        txtIngresoDeNumeros.Text = eva.Substring(eva.Length - 1, 1)

        If eva = 0 Or eva = 2 Or eva = 4 Or eva = 6 Or eva = 8 Then
            par = par + 1
        Else
            impar = impar + 1
        End If

        If eva > 0 Then
            positivo = positivo + 1
        Else
            negativo = negativo + 1
        End If

        total = total + valor

        cmbListaNumeros.Items.Add(valor)
        txtPar.Text = par
        txtImpar.Text = impar
        txtPositivo.Text = positivo
        txtNegativo.Text = negativo
        txtTotal.Text = total

    End Sub
End Class