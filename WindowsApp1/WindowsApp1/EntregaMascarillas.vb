Public Class EntregaMascarillas

    Private Sub evaluacionMunicipios(municipios As Integer, itemDepartamento As String, cantEntrega As Integer)
        For i = 1 To municipios Step 1
            While (itemDepartamento > 0)
                cantEntrega = InputBox("Ingrese la cantidad de entrega", "Entrega de mascarillas")
                If (itemDepartamento > cantEntrega) Then
                    municipios += 1
                    itemDepartamento -= cantEntrega
                    txtStock.Text = itemDepartamento
                Else
                    MessageBox.Show("NO hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End While
        Next
    End Sub

    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        Dim departamentos, mascarillas As Integer
        departamentos = Val(txtDepartamento.Text)
        For i = 1 To departamentos Step 1
            Do
                mascarillas = InputBox("Ingresar la cantidad de mascarillas " & i, "Ingresar")

            Loop While (mascarillas < 0 Or mascarillas > 10000)
            cmbDepartamento.Items.Add(mascarillas)
        Next
    End Sub

    Private Sub btnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click
        Dim idDepartamento, municipios, cantEntrega As Integer
        Dim itemDepartamento As String
        idDepartamento = cmbDepartamento.SelectedIndex
        itemDepartamento = cmbDepartamento.SelectedItem.ToString
        municipios = Val(txtMunicipio.Text)

        Select Case idDepartamento
            Case 0
                Call evaluacionMunicipios(municipios, itemDepartamento, cantEntrega)
            Case 1
                Call evaluacionMunicipios(municipios, itemDepartamento, cantEntrega)
            Case 2
                Call evaluacionMunicipios(municipios, itemDepartamento, cantEntrega)
            Case 3
                Call evaluacionMunicipios(municipios, itemDepartamento, cantEntrega)
            Case 4
                Call evaluacionMunicipios(municipios, itemDepartamento, cantEntrega)
            Case 5
                Call evaluacionMunicipios(municipios, itemDepartamento, cantEntrega)
            Case 6
                Call evaluacionMunicipios(municipios, itemDepartamento, cantEntrega)
            Case 7
                Call evaluacionMunicipios(municipios, itemDepartamento, cantEntrega)
            Case 8
                Call evaluacionMunicipios(municipios, itemDepartamento, cantEntrega)
            Case 9
                Call evaluacionMunicipios(municipios, itemDepartamento, cantEntrega)
            Case 10
                Call evaluacionMunicipios(municipios, itemDepartamento, cantEntrega)
            Case 11
                Call evaluacionMunicipios(municipios, itemDepartamento, cantEntrega)
            Case 12
                Call evaluacionMunicipios(municipios, itemDepartamento, cantEntrega)
            Case 13
                Call evaluacionMunicipios(municipios, itemDepartamento, cantEntrega)
            Case 14
                Call evaluacionMunicipios(municipios, itemDepartamento, cantEntrega)
            Case 15
                Call evaluacionMunicipios(municipios, itemDepartamento, cantEntrega)
            Case 16
                Call evaluacionMunicipios(municipios, itemDepartamento, cantEntrega)
            Case 17
                Call evaluacionMunicipios(municipios, itemDepartamento, cantEntrega)
        End Select
    End Sub

    Private Sub EntregaMascarillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
End Class


