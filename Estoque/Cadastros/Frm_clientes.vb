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
        Txt_numero_endereco.Text = ""
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
    Private Sub Txt_nome_TextChanged(sender As Object, e As EventArgs) Handles Txt_nome.TextChanged
        If Txt_nome.Text = "" Then
            Lbl_mensagem.Text = "Informe um nome para cadastrar!"
            Txt_nome.Focus()
        Else
            Lbl_mensagem.Text = ""
        End If
    End Sub
    Private Sub Txt_data_de_nascimento_TextChanged(sender As Object, e As EventArgs)
        If Txt_data_de_nascimento.Text = "" Then
            Lbl_mensagem.Text = "Informe uma data de nascimento para cadastrar!"
            Txt_data_de_nascimento.Focus()
        Else
            Lbl_mensagem.Text = ""
        End If
    End Sub
    Private Sub Txt_cpf_TextChanged(sender As Object, e As EventArgs)
        If Txt_cpf.Text = "" Then
            Lbl_mensagem.Text = "Informe um cpf para cadastrar!"
            Txt_cpf.Focus()
        Else
            Lbl_mensagem.Text = ""
        End If
    End Sub
    Private Sub Txt_logradouro_TextChanged(sender As Object, e As EventArgs) Handles Txt_logradouro.TextChanged
        If Txt_logradouro.Text = "" Then
            Lbl_mensagem.Text = "Informe um endereço para cadastrar!"
            Txt_logradouro.Focus()
        Else
            Lbl_mensagem.Text = ""
        End If
    End Sub
    Private Sub Txt_numero_TextChanged(sender As Object, e As EventArgs) Handles Txt_numero_endereco.TextChanged
        If Txt_numero_endereco.Text = "" Then
            Lbl_mensagem.Text = "Informe um número do endereço para cadastrar!"
            Txt_numero_endereco.Focus()
        Else
            Lbl_mensagem.Text = ""
        End If
    End Sub
    Private Sub Txt_cep_TextChanged(sender As Object, e As EventArgs)
        If Txt_cep.Text = "" Then
            Lbl_mensagem.Text = "Informe um cep para cadastrar!"
            Txt_cep.Focus()
        Else
            Lbl_mensagem.Text = ""
        End If
    End Sub
    Private Sub Txt_cidade_TextChanged(sender As Object, e As EventArgs) Handles Txt_cidade.TextChanged
        If Txt_cidade.Text = "" Then
            Lbl_mensagem.Text = "Informe uma cidade para cadastrar!"
            Txt_cidade.Focus()
        Else
            Lbl_mensagem.Text = ""
        End If
    End Sub
    Private Sub Txt_uf_TextChanged(sender As Object, e As EventArgs) Handles Txt_uf.TextChanged
        If Txt_uf.Text = "" Then
            Lbl_mensagem.Text = "Informe um estado para cadastrar!"
            Txt_uf.Focus()
        Else
            Lbl_mensagem.Text = ""
        End If
    End Sub
    Private Sub Txt_celular_TextChanged(sender As Object, e As EventArgs)
        If Txt_celular.Text = "" Then
            Lbl_mensagem.Text = "Informe um número de contato para cadastrar!"
            Txt_celular.Focus()
        Else
            Lbl_mensagem.Text = ""
        End If
    End Sub
    Private Sub Txt_email_TextChanged(sender As Object, e As EventArgs) Handles Txt_email.TextChanged
        If Txt_email.Text = "" Then
            Lbl_mensagem.Text = "Informe um email para cadastrar!"
            Txt_email.Focus()
        Else
            Lbl_mensagem.Text = ""
        End If
    End Sub
    Private Sub Btn_sair_Click(sender As Object, e As EventArgs) Handles Btn_sair.Click
        If MsgBox("Deseja sair da tela de cadastro de clientes?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Btn_salvar_Click(sender As Object, e As EventArgs) Handles Btn_salvar.Click
        sql = "SELECT * FROM clientes WHERE cpf = "
        sql += "'" & Txt_cpf.Text & "'"
        conectar.Open()
        adaptar = New NpgsqlDataAdapter(sql, conectar)
        conectar.Close()
        local = New DataSet
        adaptar.Fill(local, "clientes")
        resultado = local.Tables("clientes").Rows.Count

        If resultado > 0 Then
            registro = local.Tables("clientes").Rows(0)
            Txt_nome.Text = registro("nome")
            Txt_data_de_nascimento.Text = registro("nascimento")
            Txt_cpf.Text = registro("cpf")
            Txt_logradouro.Text = registro("endereco")
            Txt_numero_endereco.Text = registro("numero_endereco")
            Txt_cep.Text = registro("cep")
            Txt_cidade.Text = registro("cidade")
            Txt_uf.Text = registro("uf")
            Txt_complemento.Text = registro("complemento")
            Txt_telefone.Text = registro("telefone")
            Txt_celular.Text = registro("celular")

            If registro("sexo") = "masculino" Then
                Chb_masculino.Checked = True
            ElseIf registro("sexo") = "feminino" Then
                Chb_feminino.Checked = True
            Else
                Chb_outro.Checked = True
            End If

        End If
    End Sub
    'TODO Arrumar os estados dos checkbox
    Private Sub Chb_outro_CheckStateChanged(sender As Object, e As EventArgs) Handles Chb_outro.CheckStateChanged
        Chb_masculino.Checked = False
        Chb_feminino.Checked = False
        Chb_outro.Checked = True

        If Chb_outro.Checked = True Then
            Lbl_outro.Visible = True
            Txt_outro.Visible = True
        Else
            Lbl_outro.Visible = False
            Txt_outro.Visible = False
        End If
    End Sub

    Private Sub Chb_feminino_CheckStateChanged(sender As Object, e As EventArgs) Handles Chb_feminino.CheckStateChanged
        Chb_masculino.Checked = False
        Chb_feminino.Checked = True
        Chb_outro.Checked = False
    End Sub

    Private Sub Chb_masculino_CheckedChanged(sender As Object, e As EventArgs) Handles Chb_masculino.CheckedChanged
        Chb_masculino.Checked = True
        Chb_feminino.Checked = False
        Chb_outro.Checked = False
    End Sub
End Class