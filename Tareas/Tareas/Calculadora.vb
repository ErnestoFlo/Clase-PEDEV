Public Class Calculadora

    Dim Operacion As String
    Dim respuesta As Nullable(Of Double) = Nothing
    Dim valor2 As Nullable(Of Double) = Nothing
    Dim presionarBoton As Boolean

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        evaluarOperacion()
        Operacion = "*"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtValores.Text = ""
        valor2 = Nothing
        respuesta = Nothing

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim Uno As String
        evaluarRestricciones()
        Uno = txtValores.Text & "1"
        txtValores.Text = Uno
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim Dos As String
        evaluarRestricciones()
        Dos = txtValores.Text & "2"
        txtValores.Text = Dos
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Dim Tres As String
        evaluarRestricciones()
        Tres = txtValores.Text & "3"
        txtValores.Text = Tres
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Dim Cuatro As String
        evaluarRestricciones()
        Cuatro = txtValores.Text & "4"
        txtValores.Text = Cuatro
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        Dim Cinco As String
        evaluarRestricciones()
        Cinco = txtValores.Text & "5"
        txtValores.Text = Cinco
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        Dim Seis As String
        evaluarRestricciones()
        Seis = txtValores.Text & "6"
        txtValores.Text = Seis
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        Dim Siete As String
        evaluarRestricciones()
        Siete = txtValores.Text & "7"
        txtValores.Text = Siete
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        Dim Ocho As String
        evaluarRestricciones()
        Ocho = txtValores.Text & "8"
        txtValores.Text = Ocho
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        Dim Nueve As String
        evaluarRestricciones()
        Nueve = txtValores.Text & "9"
        txtValores.Text = Nueve
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        Dim Cero As String
        evaluarRestricciones()
        Cero = txtValores.Text & "0"
        txtValores.Text = Cero
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        evaluarOperacion()
        Operacion = "/"
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        evaluarOperacion()
        Operacion = "+"
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        evaluarOperacion()
        Operacion = ""
        txtValores.Text = respuesta
    End Sub

    Private Sub Calculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub evaluarOperacion()
        presionarBoton = True
        valor2 = Val(txtValores.Text)
        If respuesta IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    respuesta = respuesta + valor2
                Case "-"
                    respuesta = respuesta - valor2
                Case "*"
                    respuesta = respuesta * valor2
                Case "/"
                    respuesta = respuesta / valor2
            End Select
        Else
            respuesta = valor2
        End If
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        evaluarOperacion()
        Operacion = "-"
    End Sub

    Public Sub evaluarRestricciones()
        If presionarBoton = True Then
            txtValores.Text = ""
            presionarBoton = False
        ElseIf txtValores.Text = "0" Then
            txtValores.Text = ""
        End If

    End Sub

    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnPunto.Click
        evaluarRestricciones()
        If InStr(txtValores.Text, ".", CompareMethod.Text) = 0 Then
            txtValores.Text &= "."
        End If
    End Sub
End Class