Public Class ComboBox
	Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

	End Sub

	Private Sub btnMostraEqu_Click(sender As Object, e As EventArgs) Handles btnMostraEqu.Click
		Dim itemId As Integer
		Dim itemNombre As String

		'Codigo del item
		itemId = cmbListaEquipos.SelectedIndex
		'retorna el valor del item
		itemNombre = cmbListaEquipos.SelectedItem.ToString

		Select Case itemId
			Case 0
				MsgBox(itemNombre)
			Case 1
				MsgBox(itemNombre)
			Case 2
				MsgBox(itemNombre)
			Case 3
				MsgBox(itemNombre)
			Case 4
				MsgBox(itemNombre)
			Case 5
				MsgBox(itemNombre)
			Case Else
				MsgBox("Selecciona un valor correcto")
		End Select
	End Sub
End Class