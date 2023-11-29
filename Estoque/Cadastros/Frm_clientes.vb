Imports System.Configuration
Imports Npgsql
Public Class Frm_clientes
    Private Sub Frm_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar = New NpgsqlConnection
        conectar.ConnectionString = cnn
    End Sub
    Private Sub Btn_limpar_Click(sender As Object, e As EventArgs) Handles Btn_limpar.Click
        Txt_nome.Text = ""
        Txt_data_de_nascimento.Text = ""
        Txt_cpf.Text = ""
        Txt_outro.Text = ""
        Txt_logradouro.Text = ""
        Txt_numero.Text = ""
        Txt_cep.Text = ""
        Txt_cidade.Text = ""
        Txt_uf.Text = ""
        Txt_complemento.Text = ""
        Txt_telefone.Text = ""
        Txt_celular.Text = ""
        Txt_email.Text = ""
        Chb_feminino.Checked = False
        Chb_masculino.Checked = False
        Chb_outro.Checked = False
    End Sub
    Private Sub Txt_nome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_nome.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Txt_data_de_nascimento.Focus()
        End If
    End Sub
    Private Sub Txt_data_de_nascimento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_data_de_nascimento.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Txt_cpf.Focus()
        End If
    End Sub
    Private Sub Txt_cpf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_cpf.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Txt_logradouro.Focus()
        End If
    End Sub
    Private Sub Txt_logradouro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_logradouro.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Txt_numero.Focus()
        End If
    End Sub
    Private Sub Txt_numero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_numero.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Txt_cep.Focus()
        End If
    End Sub
    Private Sub Txt_cep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_cep.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Txt_cidade.Focus()
        End If
    End Sub
    Private Sub Txt_cidade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_cidade.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Txt_uf.Focus()
        End If
    End Sub
    Private Sub Txt_uf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_uf.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Txt_complemento.Focus()
        End If
    End Sub
    Private Sub Txt_complemento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_complemento.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Txt_telefone.Focus()
        End If
    End Sub
    Private Sub Txt_telefone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_telefone.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Txt_celular.Focus()
        End If
    End Sub

    Private Sub Txt_celular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_celular.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Txt_email.Focus()
        End If
    End Sub
    Private Sub Txt_nome_Validated(sender As Object, e As EventArgs) Handles Txt_nome.Validated
        If Txt_nome.Text = "" Then
            Lbl_mensagem.Text = "Informe um nome para cadastrar!"
            Txt_nome.Focus()
        End If
    End Sub
    Private Sub Txt_data_de_nascimento_Validated(sender As Object, e As EventArgs) Handles Txt_data_de_nascimento.Validated
        If Txt_data_de_nascimento.Text = "" Then
            Lbl_mensagem.Text = "Informe uma data de nascimento para cadastrar!"
            Txt_data_de_nascimento.Focus()
        End If
    End Sub
    Private Sub Txt_cpf_Validated(sender As Object, e As EventArgs) Handles Txt_cpf.Validated
        If Txt_cpf.Text = "" Then
            Lbl_mensagem.Text = "Informe um cpf para cadastrar!"
            Txt_cpf.Focus()
        End If
    End Sub
    Private Sub Txt_logradouro_Validated(sender As Object, e As EventArgs) Handles Txt_logradouro.Validated
        If Txt_logradouro.Text = "" Then
            Lbl_mensagem.Text = "Informe um logradouro para cadastrar!"
            Txt_logradouro.Focus()
        End If
    End Sub
    Private Sub Txt_numero_Validated(sender As Object, e As EventArgs) Handles Txt_numero.Validated
        If Txt_numero.Text = "" Then
            Lbl_mensagem.Text = "Informe um número para cadastrar!"
            Txt_numero.Focus()
        End If
    End Sub
    Private Sub Txt_cep_Validated(sender As Object, e As EventArgs) Handles Txt_cep.Validated
        If Txt_cep.Text = "" Then
            Lbl_mensagem.Text = "Informe um cep para cadastrar!"
            Txt_cep.Focus()
        End If
    End Sub
    Private Sub Txt_cidade_Validated(sender As Object, e As EventArgs) Handles Txt_cidade.Validated
        If Txt_cidade.Text = "" Then
            Lbl_mensagem.Text = "Informe um cidade para cadastrar!"
            Txt_cidade.Focus()
        End If
    End Sub
    Private Sub Txt_uf_Validated(sender As Object, e As EventArgs) Handles Txt_uf.Validated
        If Txt_uf.Text = "" Then
            Lbl_mensagem.Text = "Informe um estado para cadastrar!"
            Txt_uf.Focus()
        End If
    End Sub
    Private Sub Txt_celular_Validated(sender As Object, e As EventArgs) Handles Txt_celular.Validated
        If Txt_celular.Text = "" Then
            Lbl_mensagem.Text = "Informe um número de celular para cadastrar!"
            Txt_celular.Focus()
        End If
    End Sub
End Class