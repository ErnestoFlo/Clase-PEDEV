Public Class Afinador
    Private Sub chkGuitarra_CheckedChanged(sender As Object, e As EventArgs) Handles chkGuitarra.CheckedChanged
        If chkGuitarra.Checked = True Then
            btnCalcular.Enabled = True
        Else
            btnCalcular.Enabled = False
        End If
    End Sub

    Private Sub chkPiano_CheckedChanged(sender As Object, e As EventArgs) Handles chkPiano.CheckedChanged
        If chkPiano.Checked = True Then
            btnCalcular.Enabled = True
        Else
            btnCalcular.Enabled = False
        End If
    End Sub

    Private Sub chkBajo_CheckedChanged(sender As Object, e As EventArgs) Handles chkBajo.CheckedChanged
        If chkBajo.Checked = True Then
            btnCalcular.Enabled = True
        Else
            btnCalcular.Enabled = False
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim GE, B, G, D, A, ei As Double
        Dim PD, Re, Mi, Fa, Sol, La, Si As Double
        Dim BG, BD, BA, BE As Integer

        GE = 329.6
        B = 246.9
        G = 196.0
        D = 146.8
        A = 110.0
        ei = 82.4

        PD = 261.62
        Re = 293.66
        Mi = 329.32
        Fa = 349.22
        Sol = 391.99
        La = 440.0
        Si = 493.88

        BG = 130
        BD = 196
        BA = 262
        BE = 327

        MessageBox.Show("Se necesita un medidor de HZ para esta funcion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Try
            If chkGuitarra.Checked = True Then
                txtEguitarra.Text = GE
                txtBguitarra.Text = B
                txtGguitarra.Text = G
                txtDguitarra.Text = D
                txtAguitarra.Text = A
                txteiGuitarra.Text = ei
            End If

            If chkPiano.Checked = True Then
                txtDo.Text = PD
                txtRe.Text = Re
                txtMi.Text = Mi
                txtFa.Text = Fa
                txtSol.Text = Sol
                txtLa.Text = La
                txtSi.Text = Si
            End If

            If chkBajo.Checked = True Then
                txtDbajo.Text = BD
                txtGbajo.Text = BG
                txtAbajo.Text = BA
                txtEbajo.Text = BE
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class