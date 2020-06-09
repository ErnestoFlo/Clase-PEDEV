Public Class AlmacenesEmpresa

    Dim almA, almB, almC, almD, almE As Double
    Dim almF, almG, almH, almI, almJ As Double
    Dim MediaVentasMensual As Double

    Public Sub MayorQueMedia(Almacen As Double, sector As String)
        Dim media As DialogResult

        If MediaVentasMensual > Almacen Then
            media = MessageBox.Show("El almacen " & sector & " tiene un valor mayor que la media")
        End If

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim opcion As DialogResult

        almA = Val(txtVentaMesA.Text)
        almB = Val(txtVentaMesB.Text)
        almC = Val(txtVentaMesC.Text)
        almD = Val(txtVentaMesD.Text)
        almE = Val(txtVentaMesE.Text)
        almF = Val(txtVentaMesF.Text)
        almG = Val(txtVentaMesG.Text)
        almH = Val(txtVentaMesH.Text)
        almI = Val(txtVentaMesI.Text)
        almJ = Val(txtVentaMesJ.Text)

        MediaVentasMensual = (almA + almB + almC + almD + almE + almF + almG + almH + almI + almJ) / 10

        opcion = MessageBox.Show("EL promedio de ventas mensual es de : " & MediaVentasMensual)

        Select Case 9
            Case 0
                Call MayorQueMedia(almA, "A")
            Case 1
                Call MayorQueMedia(almB, "B")
            Case 2
                Call MayorQueMedia(almC, "C")
            Case 3
                Call MayorQueMedia(almD, "D")
            Case 4
                Call MayorQueMedia(almE, "E")
            Case 5
                Call MayorQueMedia(almF, "F")
            Case 6
                Call MayorQueMedia(almG, "G")
            Case 7
                Call MayorQueMedia(almH, "H")
            Case 8
                Call MayorQueMedia(almI, "I")
            Case 9
                Call MayorQueMedia(almJ, "J")
        End Select

    End Sub
    End Class