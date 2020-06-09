Public Class ImpuestoSAR
    Private Sub btnSalario_Click(sender As Object, e As EventArgs) Handles btnSalario.Click
        Dim sueldo, SAR As Double
        Dim mensaje, sueldoNeto As DialogResult

        sueldo = Val(txtSalario.Text)

        If sueldo > 0 And sueldo < 158995.06 Then
            mensaje = MessageBox.Show("Su sueldo esta EXENTO", "Informacion", MessageBoxButtons.OK)
            sueldoNeto = MessageBox.Show("El sueldo neto es de : " & sueldo, "Sueldo Neto", MessageBoxButtons.OK)

        ElseIf sueldo > 158995.06 And sueldo < 242439.28 Then
            mensaje = MessageBox.Show("Su sueldo sera aplicado a 15% de SAR", "Informacion", MessageBoxButtons.OK)
            SAR = sueldo - (sueldo * 0.15)
            sueldoNeto = MessageBox.Show("El sueldo neto es de : " & SAR, "Sueldo Neto", MessageBoxButtons.OK)

        ElseIf sueldo > 242439.28 And sueldo < 563812.3 Then
            mensaje = MessageBox.Show("Su sueldo sera aplicado a 20% de SAR", "Informacion", MessageBoxButtons.OK)
            SAR = sueldo - (sueldo * 0.2)
            sueldoNeto = MessageBox.Show("El sueldo neto es de : " & SAR, "Sueldo Neto", MessageBoxButtons.OK)

        ElseIf sueldo > 563812.3 Then
            mensaje = MessageBox.Show("Su sueldo sera aplicado a 25% de SAR", "Informacion", MessageBoxButtons.OK)
            SAR = sueldo - (sueldo * 0.25)
            sueldoNeto = MessageBox.Show("El sueldo neto es de : " & SAR, "Sueldo Neto", MessageBoxButtons.OK)

        End If

    End Sub
End Class