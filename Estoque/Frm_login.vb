Imports Npgsql
Public Class Frm_login
    Private Sub Frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar = New NpgsqlConnection
        conectar.ConnectionString = cnn
    End Sub
    Private Sub Btn_login_Click(sender As Object, e As EventArgs) Handles Btn_login.Click
        ProgressBar1.Show()
        Timer1.Start()
    End Sub
    Private Sub Btn_sair_Click(sender As Object, e As EventArgs) Handles Btn_sair.Click
        If MsgBox("Deseja sair do sistema?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub Btn_limpar_Click(sender As Object, e As EventArgs) Handles Btn_limpar.Click
        Txt_usuario.Clear()
        Txt_senha.Clear()
        Btn_login.Enabled = False
        Lbl_aviso.Text = ""
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(15)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            Frm_principal.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Txt_senha_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_senha.KeyUp
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
        End If
    End Sub
End Class
