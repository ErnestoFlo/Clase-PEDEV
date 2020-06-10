Imports System.ComponentModel

Public Class Form1
    Dim usuario, contraseña, confirmacion As String

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If opcion = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            Dim logUsuario, LogContraseña As String
            Dim mensaje As DialogResult

            logUsuario = txtUsuario.Text
            LogContraseña = txtContraseña.Text

            logUsuario.ToUpper()

            If logUsuario = usuario Then
            Else
                mensaje = MessageBox.Show("Su usuario es incorrecto", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            If LogContraseña = contraseña Then
            Else
                mensaje = MessageBox.Show("Su contraseña es incorrecta", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

            If logUsuario = usuario And LogContraseña = contraseña Then
                mensaje = MessageBox.Show("Ingreso Correctamente!", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                PruebasRealizadas.Show()
            End If

            txtContraseña.Clear()
            txtUsuario.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        Try
            Dim mensaje As DialogResult

            usuario = txtUsuarioIng.Text
            contraseña = txtContraIng.Text
            confirmacion = txtConfirmaContra.Text

            If contraseña = confirmacion Then
                mensaje = MessageBox.Show("Se ha registrado exitosamente!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                mensaje = MessageBox.Show("Su contraseña parece no ser la misma", "Resgistro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            usuario.ToUpper()
            txtUsuarioIng.Clear()
            txtContraIng.Clear()
            txtConfirmaContra.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub txtUsuario_MouseHover(sender As Object, e As EventArgs) Handles txtUsuario.MouseHover
        ToolTip1.SetToolTip(txtUsuario, "Ingrese un nombre de usuario valido")
        ToolTip1.ToolTipTitle = "Nombre de usuario"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtContraIng_TextChanged(sender As Object, e As EventArgs) Handles txtContraIng.TextChanged

    End Sub

    Private Sub txtContraseña_MouseHover(sender As Object, e As EventArgs) Handles txtContraseña.MouseHover
        ToolTip1.SetToolTip(txtContraseña, "Ingrese una contraseña deacuerdo a su usuario")
        ToolTip1.ToolTipTitle = "Contraseña"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtConfirmaContra_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmaContra.TextChanged

    End Sub

    Private Sub txtUsuarioIng_MouseHover(sender As Object, e As EventArgs) Handles txtUsuarioIng.MouseHover
        ToolTip1.SetToolTip(txtUsuarioIng, "Ejemplo (Administrador)")
        ToolTip1.ToolTipTitle = "Nuevo Usuario"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub txtContraIng_MouseHover(sender As Object, e As EventArgs) Handles txtContraIng.MouseHover
        ToolTip1.SetToolTip(txtContraIng, "Asegurese sea segura")
        ToolTip1.ToolTipTitle = "Contraseña"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged

    End Sub

    Private Sub txtConfirmaContra_MouseHover(sender As Object, e As EventArgs) Handles txtConfirmaContra.MouseHover
        ToolTip1.SetToolTip(txtConfirmaContra, "Asegurese sea igual con el apso anterior")
        ToolTip1.ToolTipTitle = "Confirmacion contraseña"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtUsuarioIng_TextChanged(sender As Object, e As EventArgs) Handles txtUsuarioIng.TextChanged

    End Sub

    Private Sub txtUsuario_Validating(sender As Object, e As CancelEventArgs) Handles txtUsuario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Espacio Obligatorio")
        End If
    End Sub

    Private Sub txtContraseña_Validating(sender As Object, e As CancelEventArgs) Handles txtContraseña.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Espacio Obligatorio")
        End If
    End Sub
End Class
