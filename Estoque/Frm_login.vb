Public Class Frm_login
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Frm_principal.Show()
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Me.Close()
    End Sub

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        txt_usuario.Clear()
        txt_senha.Clear()
    End Sub
End Class
