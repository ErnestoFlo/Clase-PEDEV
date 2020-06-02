Public Class AcumuladorContador
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSolicitarOrden_Click(sender As Object, e As EventArgs) Handles btnSolicitarOrden.Click

        Try
            Dim precio, total, totalPagar, orden As Integer

            orden = txtOrden.Text

            For i = 1 To orden Step 1
                precio = InputBox("Ingresa el precio del platillo No." & i, "Precio del platillo")
                totalPagar += precio
            Next

            total = totalPagar / orden

            txtTotalPago.Text = totalPagar
            txtPagoIndividual.Text = total

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtOrden.Clear()
        txtPagoIndividual.Clear()
        txtTotalPago.Clear()
    End Sub
End Class