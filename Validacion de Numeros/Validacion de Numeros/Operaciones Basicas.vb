Public Class Operaciones_Basicas
    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnEvaluarSuma_Click(sender As Object, e As EventArgs) Handles btnEvaluarSuma.Click
        'comentario

        'inicio (decalracion de variables)
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim suma As Integer

        valor1 = Val(txtvalorA.Text)
        valor2 = Val(txtvalorB.Text)

        'Proceso
        suma = valor1 + valor2

        'salida
        txtresultado.Text = suma
    End Sub

    Private Sub btnEvaluarResta_Click(sender As Object, e As EventArgs) Handles btnEvaluarResta.Click
        'comentario

        'Incio
        Dim valorAresta As Integer
        Dim valorBresta As Integer
        Dim resta As Integer

        valorAresta = Val(txtvalorAresta.Text)
        valorBresta = Val(txtvalorBresta.Text)

        'Proceso
        resta = valorAresta - valorBresta

        'salida
        txtrespuestaResta.Text = resta
    End Sub

    Private Sub btnEvaluarMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnEvaluarMultiplicacion.Click
        'comentario

        'Inicio
        Dim valorAmultiplicacion As Integer
        Dim valorBmultiplicacion As Integer
        Dim multiplicacion As Integer

        valorAmultiplicacion = Val(txtvalorAmulti.Text)
        valorBmultiplicacion = Val(txtvalorBmulti.Text)

        'Proceso
        multiplicacion = valorAmultiplicacion * valorBmultiplicacion

        'Salida
        txtrespuestaMulti.Text = multiplicacion
    End Sub

    Private Sub btnDivi_Click(sender As Object, e As EventArgs) Handles btnDivi.Click
        'comentario

        'Inicio
        Dim valorAdivision As Integer
        Dim valorBdivision As Integer
        Dim division As Integer

        valorAdivision = Val(txtvalorAdivi.Text)
        valorBdivision = Val(txtvalorBdivi.Text)

        'Proceso
        division = valorAdivision / valorBdivision

        If valorBdivision = 0 Then

            MsgBox("Math Error")

        ElseIf valorBdivision <> 0 Then

            txtrespuestaDivi.Text = division

        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtvalorA.Clear()
        txtvalorB.Clear()
        txtresultado.Clear()

        txtvalorAresta.Clear()
        txtvalorBresta.Clear()
        txtrespuestaResta.Clear()

        txtvalorAmulti.Clear()
        txtvalorBmulti.Clear()
        txtrespuestaMulti.Clear()

        txtvalorAdivi.Clear()
        txtvalorBdivi.Clear()
        txtrespuestaDivi.Clear()
    End Sub
End Class