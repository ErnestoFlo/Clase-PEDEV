Public Class formulaCuadratica

    Dim A, B, C, RespuestaA, RespuestaB, temporalA, temporalB, temporalC As Double

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Try
            A = Val(txtValorA.Text)
            B = Val(txtValorB.Text)
            C = Val(txtValorC.Text)

            temporalA = (B ^ 2)
            temporalB = 4 * A * C
            temporalC = (temporalA - temporalB) ^ (1 / 2)

            RespuestaA = -B + temporalC
            RespuestaB = -B - temporalC

            txtRespuesta.Text = RespuestaA
            txtRespuestaB.Text = RespuestaB
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        temporalA = 0
        temporalB = 0
        temporalC = 0
        A = 0
        B = 0
        C = 0
        RespuestaB = 0
        RespuestaA = 0

        txtRespuesta.Clear()
        txtRespuestaB.Clear()
        txtValorA.Clear()
        txtValorB.Clear()
        txtValorC.Clear()

    End Sub
End Class