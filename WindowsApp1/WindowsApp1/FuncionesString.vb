Public Class FuncionesString
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim cadena As String
        cadena = txtCadena.Text
        txtLongitud.Text = cadena.Length
        txtUltimoCaracter.Text = cadena.Substring(cadena.Length - 1, 1)
        txtPrimerCaracter.Text = cadena.Substring(0, 1)
        txt3y8.Text = cadena.Substring(2, 5)
        txtPosicionB.Text = cadena.IndexOf("B", 0) + 1
        txtMayuscula.Text = cadena.ToUpper
        txtMinuscula.Text = cadena.ToLower
        txtBorrarDatos.Text = cadena.Replace(" ", "")
    End Sub
End Class