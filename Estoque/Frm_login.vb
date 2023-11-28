Imports Npgsql

Public Class Frm_login
    Private Sub Frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar = New NpgsqlConnection
        conectar.ConnectionString = cnn

    End Sub
    Private Sub Btn_login_Click(sender As Object, e As EventArgs) Handles Btn_login.Click
        'Frm_principal.Show()

    End Sub


    Private Sub Btn_sair_Click(sender As Object, e As EventArgs) Handles Btn_sair.Click
        If MsgBox("Deseja sair do sistema?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If

    End Sub
    Private Sub Btn_limpar_Click(sender As Object, e As EventArgs) Handles Btn_limpar.Click
        Txt_usuario.Clear()
        Txt_senha.Clear()
    End Sub

    Private Sub Txt_usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_usuario.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Txt_usuario.Focus()
        End If
    End Sub

    Private Sub Txt_senha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_senha.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Txt_senha_Validated(sender, e)
        End If
    End Sub

    Private Sub Txt_senha_Validated(sender As Object, e As EventArgs) Handles Txt_senha.Validated
        If Txt_usuario.Text = "" Or Txt_senha.Text = "" Then
            Lbl_aviso.Text = "Insira um usuário e uma senha para logar no sistema!"
            Txt_usuario.Focus()
            Exit Sub
        End If

        sql = "SELECT * FROM login WHERE usuario = "
        sql += "'" & Txt_usuario.Text & "'"
        sql += " AND senha = "
        sql += "'" & Txt_senha.Text & "'"
        conectar.Open()
        adaptar = New NpgsqlDataAdapter(sql, conectar)
        local = New DataSet
        conectar.Close()
        adaptar.Fill(local, "login")
        resultado = local.Tables("login").Rows.Count

        If resultado > 0 Then
            registro = local.Tables("login").Rows(0)
            vnivel = registro("nivel")
            Btn_login.Enabled = True
            Btn_login.Focus()
        ElseIf resultado = 0 Then
            Btn_login.Enabled = False
            Btn_sair.Focus()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Txt_usuario.Text = "admin" And Txt_senha.Text = "1234" Then
            ProgressBar1.Increment(40)
            If ProgressBar1.Value = ProgressBar1.Maximum Then
                Timer1.Stop()
                MsgBox("Bem vindo ao sistema de estoque")
                Frm_principal.Show()
                Me.Hide()
            End If
        End If
    End Sub
End Class
