Public Class InventarioTiendaDeMusica
    Private Sub chkGuitarra_CheckedChanged(sender As Object, e As EventArgs) Handles chkGuitarra.CheckedChanged
        If chkGuitarra.Checked = True Then
            cmbGuitarra.Enabled = True
        Else
            cmbGuitarra.Enabled = False
        End If
    End Sub

    Private Sub chkPiano_CheckedChanged(sender As Object, e As EventArgs) Handles chkPiano.CheckedChanged
        If chkPiano.Checked = True Then
            cmbPiano.Enabled = True
        Else
            cmbPiano.Enabled = False
        End If
    End Sub

    Private Sub chkBajo_CheckedChanged(sender As Object, e As EventArgs) Handles chkBajo.CheckedChanged
        If chkBajo.Checked = True Then
            cmbBajo.Enabled = True
        Else
            cmbBajo.Enabled = False
        End If
    End Sub

    Private Sub InventarioTiendaDeMusica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbGuitarra.Items.Add("Classic Martin Smith  50$")
        cmbGuitarra.Items.Add("Electric Fender  80$")
        cmbGuitarra.Items.Add("Gretsch G5422TG  200$")

        cmbPiano.Items.Add("Yamaha PR 200  100$")
        cmbPiano.Items.Add("Casio CSK 2400  120$")
        cmbPiano.Items.Add("Clairevoire Grandeur  250$")

        cmbBajo.Items.Add("Fender Deluxe 80$")
        cmbBajo.Items.Add("Sterling Bass 100$")
        cmbBajo.Items.Add("Cort Jeff Berlin 150$")

        cmbAccesorioGuitarra.Items.Add("Capotraste 6 Cuer  15$")
        cmbAccesorioGuitarra.Items.Add("Soporte Guitarra  20$")
        cmbAccesorioGuitarra.Items.Add("Amplificador  25$")

        cmbAccesorioPiano.Items.Add("Soporte 10$")
        cmbAccesorioPiano.Items.Add("Repuesto Teclas 25$")
        cmbAccesorioPiano.Items.Add("Repuesto Cuerda 30$")

        cmbAccesorioBajo.Items.Add("Capotrate 4 Cuer  10$")
        cmbAccesorioBajo.Items.Add("Pack Uñas  5$")
        cmbAccesorioBajo.Items.Add("Repuesto Cuerdas 12$")
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        chkGuitarra.Checked = False
        chkPiano.Checked = False
        chkBajo.Checked = False

        cmbGuitarra.ResetText()
        cmbPiano.ResetText()
        cmbBajo.ResetText()

        cmbAccesorioGuitarra.ResetText()
        cmbAccesorioPiano.ResetText()
        cmbAccesorioBajo.ResetText()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Try
            Dim Cuenta, Pago, cambio, Piano, Guitarra, Bajo, AccesorioPiano, AccesorioGuitarra, AccesorioBajo As Integer

            Select Case cmbGuitarra.SelectedIndex
                Case 0
                    Guitarra = 50
                Case 1
                    Guitarra = 80
                Case 2
                    Guitarra = 200
            End Select

            Select Case cmbPiano.SelectedIndex
                Case 0
                    Piano = 100
                Case 1
                    Piano = 120
                Case 2
                    Piano = 250
            End Select

            Select Case cmbBajo.SelectedIndex
                Case 0
                    Bajo = 80
                Case 1
                    Bajo = 100
                Case 2
                    Bajo = 150
            End Select

            Select Case cmbAccesorioGuitarra.SelectedIndex
                Case 0
                    AccesorioGuitarra = 15
                Case 1
                    AccesorioGuitarra = 20
                Case 2
                    AccesorioGuitarra = 25
            End Select

            Select Case cmbAccesorioPiano.SelectedIndex
                Case 0
                    AccesorioPiano = 10
                Case 1
                    AccesorioPiano = 25
                Case 2
                    AccesorioPiano = 30
            End Select

            Select Case cmbAccesorioBajo.SelectedIndex
                Case 0
                    AccesorioBajo = 10
                Case 1
                    AccesorioBajo = 5
                Case 2
                    AccesorioBajo = 12
            End Select

            Cuenta = Guitarra + Piano + Bajo + AccesorioGuitarra + AccesorioPiano + AccesorioBajo
            Pago = InputBox("Su compra es de " & Cuenta, "Ingreso Del pago")

            If Pago < Cuenta Then
                MsgBox("Ingreso menos de lo esperado...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                cambio = Pago - Cuenta
                cambio.ToString()
                MessageBox.Show("Su cambio es de " & cambio, "!Gracias Por Su Compra!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        Dim curiosidad As Integer
        opcion = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then

            Randomize()
            curiosidad = Int(Rnd() * 4)
            Select Case curiosidad
                Case 0
                    MessageBox.Show("La guitarra de Eric Clapton Fue vendida por 2 millones de dolares", "Curiosidad", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case 1
                    MessageBox.Show("El primer Piano se contruyó en el año 1698", "Curiosidad", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case 2
                    MessageBox.Show("Tocar un instrumento mejora la agilidad mental", "Curiosidad", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case 3
                    MessageBox.Show("El bajo electrico es la combinación de una guitarra y un violonchelo", "Curiosidad", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select

            Me.Close()
        End If
    End Sub

    Private Sub AfinadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfinadorToolStripMenuItem.Click
        Afinador.Show()
    End Sub

    Private Sub PrimerosPasosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrimerosPasosToolStripMenuItem.Click
        PrimerosPasos.Show()
    End Sub

    Private Sub cmbGuitarra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGuitarra.SelectedIndexChanged

    End Sub
End Class