<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_clientes
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_clientes))
        Label1 = New Label()
        Panel1 = New Panel()
        Label6 = New Label()
        chb_outro = New CheckBox()
        chb_feminino = New CheckBox()
        chb_masculino = New CheckBox()
        txt_cpf = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        txt_data_de_nascimento = New TextBox()
        Label2 = New Label()
        txt_nome = New TextBox()
        Label3 = New Label()
        Panel2 = New Panel()
        txt_complemento = New TextBox()
        cob_uf = New ComboBox()
        Label13 = New Label()
        Label12 = New Label()
        cob_cidade = New ComboBox()
        Label11 = New Label()
        txt_cep = New TextBox()
        Label10 = New Label()
        txt_numero = New TextBox()
        Label9 = New Label()
        Label7 = New Label()
        txt_logradouro = New TextBox()
        Label8 = New Label()
        Panel3 = New Panel()
        txt_email = New TextBox()
        Label14 = New Label()
        txt_celular = New TextBox()
        Label18 = New Label()
        Label19 = New Label()
        txt_telefone = New TextBox()
        Label20 = New Label()
        btn_salvar = New Button()
        btn_cancelar = New Button()
        btn_limpar = New Button()
        btn_sair = New Button()
        txt_outro = New TextBox()
        Label15 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(207, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(177, 18)
        Label1.TabIndex = 0
        Label1.Text = "Cadastro de Clientes"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientInactiveCaption
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(txt_outro)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(chb_outro)
        Panel1.Controls.Add(chb_feminino)
        Panel1.Controls.Add(chb_masculino)
        Panel1.Controls.Add(txt_cpf)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txt_data_de_nascimento)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txt_nome)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(12, 30)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(560, 154)
        Panel1.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(266, 80)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 18)
        Label6.TabIndex = 13
        Label6.Text = "Sexo"
        ' 
        ' chb_outro
        ' 
        chb_outro.AutoSize = True
        chb_outro.Location = New Point(431, 99)
        chb_outro.Name = "chb_outro"
        chb_outro.Size = New Size(57, 19)
        chb_outro.TabIndex = 12
        chb_outro.Text = "Outro"
        chb_outro.UseVisualStyleBackColor = True
        ' 
        ' chb_feminino
        ' 
        chb_feminino.AutoSize = True
        chb_feminino.Location = New Point(353, 99)
        chb_feminino.Name = "chb_feminino"
        chb_feminino.Size = New Size(76, 19)
        chb_feminino.TabIndex = 11
        chb_feminino.Text = "Feminino"
        chb_feminino.UseVisualStyleBackColor = True
        ' 
        ' chb_masculino
        ' 
        chb_masculino.AutoSize = True
        chb_masculino.Location = New Point(266, 99)
        chb_masculino.Name = "chb_masculino"
        chb_masculino.Size = New Size(81, 19)
        chb_masculino.TabIndex = 10
        chb_masculino.Text = "Masculino"
        chb_masculino.UseVisualStyleBackColor = True
        ' 
        ' txt_cpf
        ' 
        txt_cpf.Location = New Point(122, 99)
        txt_cpf.Name = "txt_cpf"
        txt_cpf.Size = New Size(117, 23)
        txt_cpf.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(3, 4)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 18)
        Label5.TabIndex = 8
        Label5.Text = "DADOS "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(122, 80)
        Label4.Name = "Label4"
        Label4.Size = New Size(40, 18)
        Label4.TabIndex = 7
        Label4.Text = "CPF"
        ' 
        ' txt_data_de_nascimento
        ' 
        txt_data_de_nascimento.Location = New Point(3, 99)
        txt_data_de_nascimento.Name = "txt_data_de_nascimento"
        txt_data_de_nascimento.Size = New Size(102, 23)
        txt_data_de_nascimento.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(3, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 18)
        Label2.TabIndex = 5
        Label2.Text = "Nascimento"
        ' 
        ' txt_nome
        ' 
        txt_nome.Location = New Point(3, 47)
        txt_nome.Name = "txt_nome"
        txt_nome.Size = New Size(547, 23)
        txt_nome.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(3, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 18)
        Label3.TabIndex = 3
        Label3.Text = "Nome"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.GradientInactiveCaption
        Panel2.Controls.Add(txt_complemento)
        Panel2.Controls.Add(cob_uf)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(cob_cidade)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(txt_cep)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(txt_numero)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(txt_logradouro)
        Panel2.Controls.Add(Label8)
        Panel2.Location = New Point(12, 204)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(560, 127)
        Panel2.TabIndex = 2
        ' 
        ' txt_complemento
        ' 
        txt_complemento.Location = New Point(431, 90)
        txt_complemento.Name = "txt_complemento"
        txt_complemento.Size = New Size(119, 23)
        txt_complemento.TabIndex = 24
        ' 
        ' cob_uf
        ' 
        cob_uf.FormattingEnabled = True
        cob_uf.Location = New Point(287, 90)
        cob_uf.Name = "cob_uf"
        cob_uf.Size = New Size(128, 23)
        cob_uf.TabIndex = 23
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(431, 69)
        Label13.Name = "Label13"
        Label13.Size = New Size(122, 18)
        Label13.TabIndex = 22
        Label13.Text = "Complemento"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(285, 69)
        Label12.Name = "Label12"
        Label12.Size = New Size(30, 18)
        Label12.TabIndex = 21
        Label12.Text = "UF"
        ' 
        ' cob_cidade
        ' 
        cob_cidade.FormattingEnabled = True
        cob_cidade.Location = New Point(122, 90)
        cob_cidade.Name = "cob_cidade"
        cob_cidade.Size = New Size(159, 23)
        cob_cidade.TabIndex = 20
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(122, 69)
        Label11.Name = "Label11"
        Label11.Size = New Size(63, 18)
        Label11.TabIndex = 19
        Label11.Text = "Cidade"
        ' 
        ' txt_cep
        ' 
        txt_cep.Location = New Point(3, 90)
        txt_cep.Name = "txt_cep"
        txt_cep.Size = New Size(96, 23)
        txt_cep.TabIndex = 18
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(3, 69)
        Label10.Name = "Label10"
        Label10.Size = New Size(40, 18)
        Label10.TabIndex = 17
        Label10.Text = "CEP"
        ' 
        ' txt_numero
        ' 
        txt_numero.Location = New Point(431, 43)
        txt_numero.Name = "txt_numero"
        txt_numero.Size = New Size(119, 23)
        txt_numero.TabIndex = 16
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(431, 22)
        Label9.Name = "Label9"
        Label9.Size = New Size(73, 18)
        Label9.TabIndex = 15
        Label9.Text = "Número"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(3, 22)
        Label7.Name = "Label7"
        Label7.Size = New Size(102, 18)
        Label7.TabIndex = 14
        Label7.Text = "Logradouro"
        ' 
        ' txt_logradouro
        ' 
        txt_logradouro.Location = New Point(3, 43)
        txt_logradouro.Name = "txt_logradouro"
        txt_logradouro.Size = New Size(410, 23)
        txt_logradouro.TabIndex = 9
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(3, 1)
        Label8.Name = "Label8"
        Label8.Size = New Size(98, 18)
        Label8.TabIndex = 8
        Label8.Text = "ENDEREÇO"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.GradientInactiveCaption
        Panel3.Controls.Add(txt_email)
        Panel3.Controls.Add(Label14)
        Panel3.Controls.Add(txt_celular)
        Panel3.Controls.Add(Label18)
        Panel3.Controls.Add(Label19)
        Panel3.Controls.Add(txt_telefone)
        Panel3.Controls.Add(Label20)
        Panel3.Location = New Point(12, 352)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(560, 85)
        Panel3.TabIndex = 3
        ' 
        ' txt_email
        ' 
        txt_email.Location = New Point(270, 43)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(280, 23)
        txt_email.TabIndex = 18
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(270, 22)
        Label14.Name = "Label14"
        Label14.Size = New Size(59, 18)
        Label14.TabIndex = 17
        Label14.Text = "E-mail"
        ' 
        ' txt_celular
        ' 
        txt_celular.Location = New Point(136, 43)
        txt_celular.Name = "txt_celular"
        txt_celular.Size = New Size(119, 23)
        txt_celular.TabIndex = 16
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.Transparent
        Label18.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = Color.Black
        Label18.Location = New Point(136, 22)
        Label18.Name = "Label18"
        Label18.Size = New Size(64, 18)
        Label18.TabIndex = 15
        Label18.Text = "Celular"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.Transparent
        Label19.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = Color.Black
        Label19.Location = New Point(3, 22)
        Label19.Name = "Label19"
        Label19.Size = New Size(78, 18)
        Label19.TabIndex = 14
        Label19.Text = "Telefone"
        ' 
        ' txt_telefone
        ' 
        txt_telefone.Location = New Point(3, 43)
        txt_telefone.Name = "txt_telefone"
        txt_telefone.Size = New Size(115, 23)
        txt_telefone.TabIndex = 9
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BackColor = Color.Transparent
        Label20.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.ForeColor = Color.Black
        Label20.Location = New Point(3, 0)
        Label20.Name = "Label20"
        Label20.Size = New Size(89, 18)
        Label20.TabIndex = 8
        Label20.Text = "CONTATO"
        ' 
        ' btn_salvar
        ' 
        btn_salvar.BackColor = Color.Transparent
        btn_salvar.FlatAppearance.BorderSize = 2
        btn_salvar.FlatAppearance.MouseDownBackColor = Color.MidnightBlue
        btn_salvar.FlatAppearance.MouseOverBackColor = Color.Gray
        btn_salvar.FlatStyle = FlatStyle.Flat
        btn_salvar.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_salvar.ForeColor = Color.White
        btn_salvar.Image = CType(resources.GetObject("btn_salvar.Image"), Image)
        btn_salvar.ImageAlign = ContentAlignment.TopCenter
        btn_salvar.Location = New Point(12, 456)
        btn_salvar.Name = "btn_salvar"
        btn_salvar.Size = New Size(88, 65)
        btn_salvar.TabIndex = 4
        btn_salvar.Text = "Salvar"
        btn_salvar.TextAlign = ContentAlignment.BottomCenter
        btn_salvar.UseVisualStyleBackColor = False
        ' 
        ' btn_cancelar
        ' 
        btn_cancelar.BackColor = Color.Transparent
        btn_cancelar.FlatAppearance.BorderSize = 2
        btn_cancelar.FlatAppearance.MouseDownBackColor = Color.MidnightBlue
        btn_cancelar.FlatAppearance.MouseOverBackColor = Color.Gray
        btn_cancelar.FlatStyle = FlatStyle.Flat
        btn_cancelar.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_cancelar.ForeColor = Color.White
        btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), Image)
        btn_cancelar.ImageAlign = ContentAlignment.TopCenter
        btn_cancelar.Location = New Point(166, 456)
        btn_cancelar.Name = "btn_cancelar"
        btn_cancelar.Size = New Size(88, 65)
        btn_cancelar.TabIndex = 5
        btn_cancelar.Text = "Cancelar"
        btn_cancelar.TextAlign = ContentAlignment.BottomCenter
        btn_cancelar.UseVisualStyleBackColor = False
        ' 
        ' btn_limpar
        ' 
        btn_limpar.BackColor = Color.Transparent
        btn_limpar.FlatAppearance.BorderSize = 2
        btn_limpar.FlatAppearance.MouseDownBackColor = Color.MidnightBlue
        btn_limpar.FlatAppearance.MouseOverBackColor = Color.Gray
        btn_limpar.FlatStyle = FlatStyle.Flat
        btn_limpar.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_limpar.ForeColor = Color.White
        btn_limpar.Image = CType(resources.GetObject("btn_limpar.Image"), Image)
        btn_limpar.ImageAlign = ContentAlignment.TopCenter
        btn_limpar.Location = New Point(320, 456)
        btn_limpar.Name = "btn_limpar"
        btn_limpar.Size = New Size(88, 65)
        btn_limpar.TabIndex = 6
        btn_limpar.Text = "Limpar"
        btn_limpar.TextAlign = ContentAlignment.BottomCenter
        btn_limpar.UseVisualStyleBackColor = False
        ' 
        ' btn_sair
        ' 
        btn_sair.BackColor = Color.Transparent
        btn_sair.FlatAppearance.BorderSize = 2
        btn_sair.FlatAppearance.MouseDownBackColor = Color.MidnightBlue
        btn_sair.FlatAppearance.MouseOverBackColor = Color.Gray
        btn_sair.FlatStyle = FlatStyle.Flat
        btn_sair.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_sair.ForeColor = Color.White
        btn_sair.Image = CType(resources.GetObject("btn_sair.Image"), Image)
        btn_sair.ImageAlign = ContentAlignment.TopCenter
        btn_sair.Location = New Point(474, 456)
        btn_sair.Name = "btn_sair"
        btn_sair.Size = New Size(88, 65)
        btn_sair.TabIndex = 7
        btn_sair.Text = "Sair"
        btn_sair.TextAlign = ContentAlignment.BottomCenter
        btn_sair.UseVisualStyleBackColor = False
        ' 
        ' txt_outro
        ' 
        txt_outro.Location = New Point(431, 123)
        txt_outro.Name = "txt_outro"
        txt_outro.Size = New Size(119, 23)
        txt_outro.TabIndex = 14
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.Black
        Label15.Location = New Point(3, 125)
        Label15.Name = "Label15"
        Label15.Size = New Size(428, 18)
        Label15.TabIndex = 15
        Label15.Text = "Informe qual o genero a ser cadastrado no sistema"
        ' 
        ' Frm_clientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(584, 533)
        Controls.Add(btn_sair)
        Controls.Add(btn_limpar)
        Controls.Add(btn_cancelar)
        Controls.Add(btn_salvar)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Name = "Frm_clientes"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Clientes"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_data_de_nascimento As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_cpf As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents chb_outro As CheckBox
    Friend WithEvents chb_feminino As CheckBox
    Friend WithEvents chb_masculino As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cob_cidade As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_cep As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_logradouro As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cob_uf As ComboBox
    Friend WithEvents txt_complemento As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_celular As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_telefone As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btn_salvar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_limpar As Button
    Friend WithEvents btn_sair As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_outro As TextBox
End Class
