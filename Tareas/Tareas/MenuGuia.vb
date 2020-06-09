Public Class MenuGuia
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Calculadora.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        formulaCuadratica.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AlmacenesEmpresa.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ClasificacionDeNumeros.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ImpuestoSAR.Show()
    End Sub
End Class