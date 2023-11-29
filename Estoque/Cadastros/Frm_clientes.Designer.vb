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
        Label15 = New Label()
        Txt_outro = New TextBox()
        Label6 = New Label()
        Chb_outro = New CheckBox()
        Chb_feminino = New CheckBox()
        Chb_masculino = New CheckBox()
        Txt_cpf = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Txt_data_de_nascimento = New TextBox()
        Label2 = New Label()
        Txt_nome = New TextBox()
        Label3 = New Label()
        Panel2 = New Panel()
        Txt_uf = New TextBox()
        Txt_cidade = New TextBox()
        Txt_complemento = New TextBox()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Txt_cep = New TextBox()
        Label10 = New Label()
        Txt_numero = New TextBox()
        Label9 = New Label()
        Label7 = New Label()
        Txt_logradouro = New TextBox()
        Label8 = New Label()
        Panel3 = New Panel()
        Txt_email = New TextBox()
        Label14 = New Label()
        Txt_celular = New TextBox()
        Label18 = New Label()
        Label19 = New Label()
        Txt_telefone = New TextBox()
        Label20 = New Label()
        Btn_salvar = New Button()
        Btn_cancelar = New Button()
        Btn_limpar = New Button()
        Btn_sair = New Button()
        Lbl_mensagem = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(302, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(179, 20)
        Label1.TabIndex = 0
        Label1.Text = "Cadastro de Clientes"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientInactiveCaption
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(Txt_outro)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Chb_outro)
        Panel1.Controls.Add(Chb_feminino)
        Panel1.Controls.Add(Chb_masculino)
        Panel1.Controls.Add(Txt_cpf)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Txt_data_de_nascimento)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Txt_nome)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(12, 30)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(760, 168)
        Panel1.TabIndex = 1
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.Black
        Label15.Location = New Point(187, 133)
        Label15.Name = "Label15"
        Label15.Size = New Size(428, 18)
        Label15.TabIndex = 15
        Label15.Text = "Informe qual o genero a ser cadastrado no sistema"
        ' 
        ' Txt_outro
        ' 
        Txt_outro.Location = New Point(621, 131)
        Txt_outro.Name = "Txt_outro"
        Txt_outro.Size = New Size(119, 23)
        Txt_outro.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(453, 78)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 18)
        Label6.TabIndex = 13
        Label6.Text = "Sexo"
        ' 
        ' Chb_outro
        ' 
        Chb_outro.AutoSize = True
        Chb_outro.Location = New Point(654, 101)
        Chb_outro.Name = "Chb_outro"
        Chb_outro.Size = New Size(57, 19)
        Chb_outro.TabIndex = 12
        Chb_outro.Text = "Outro"
        Chb_outro.UseVisualStyleBackColor = True
        ' 
        ' Chb_feminino
        ' 
        Chb_feminino.AutoSize = True
        Chb_feminino.Location = New Point(556, 101)
        Chb_feminino.Name = "Chb_feminino"
        Chb_feminino.Size = New Size(76, 19)
        Chb_feminino.TabIndex = 11
        Chb_feminino.Text = "Feminino"
        Chb_feminino.UseVisualStyleBackColor = True
        ' 
        ' Chb_masculino
        ' 
        Chb_masculino.AutoSize = True
        Chb_masculino.Location = New Point(453, 101)
        Chb_masculino.Name = "Chb_masculino"
        Chb_masculino.Size = New Size(81, 19)
        Chb_masculino.TabIndex = 10
        Chb_masculino.Text = "Masculino"
        Chb_masculino.UseVisualStyleBackColor = True
        ' 
        ' Txt_cpf
        ' 
        Txt_cpf.Location = New Point(224, 99)
        Txt_cpf.Name = "Txt_cpf"
        Txt_cpf.Size = New Size(119, 23)
        Txt_cpf.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(3, 1)
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
        Label4.Location = New Point(224, 78)
        Label4.Name = "Label4"
        Label4.Size = New Size(40, 18)
        Label4.TabIndex = 7
        Label4.Text = "CPF"
        ' 
        ' Txt_data_de_nascimento
        ' 
        Txt_data_de_nascimento.Location = New Point(12, 99)
        Txt_data_de_nascimento.Name = "Txt_data_de_nascimento"
        Txt_data_de_nascimento.Size = New Size(115, 23)
        Txt_data_de_nascimento.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(12, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 18)
        Label2.TabIndex = 5
        Label2.Text = "Nascimento"
        ' 
        ' Txt_nome
        ' 
        Txt_nome.Location = New Point(12, 47)
        Txt_nome.Name = "Txt_nome"
        Txt_nome.Size = New Size(728, 23)
        Txt_nome.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(12, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 18)
        Label3.TabIndex = 3
        Label3.Text = "Nome"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.GradientInactiveCaption
        Panel2.Controls.Add(Txt_uf)
        Panel2.Controls.Add(Txt_cidade)
        Panel2.Controls.Add(Txt_complemento)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Txt_cep)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Txt_numero)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Txt_logradouro)
        Panel2.Controls.Add(Label8)
        Panel2.Location = New Point(15, 208)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(760, 129)
        Panel2.TabIndex = 2
        ' 
        ' Txt_uf
        ' 
        Txt_uf.Location = New Point(449, 90)
        Txt_uf.Name = "Txt_uf"
        Txt_uf.Size = New Size(148, 23)
        Txt_uf.TabIndex = 26
        ' 
        ' Txt_cidade
        ' 
        Txt_cidade.Location = New Point(224, 90)
        Txt_cidade.Name = "Txt_cidade"
        Txt_cidade.Size = New Size(116, 23)
        Txt_cidade.TabIndex = 25
        ' 
        ' Txt_complemento
        ' 
        Txt_complemento.Location = New Point(621, 90)
        Txt_complemento.Name = "Txt_complemento"
        Txt_complemento.Size = New Size(119, 23)
        Txt_complemento.TabIndex = 24
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(621, 69)
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
        Label12.Location = New Point(449, 69)
        Label12.Name = "Label12"
        Label12.Size = New Size(30, 18)
        Label12.TabIndex = 21
        Label12.Text = "UF"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(224, 69)
        Label11.Name = "Label11"
        Label11.Size = New Size(63, 18)
        Label11.TabIndex = 19
        Label11.Text = "Cidade"
        ' 
        ' Txt_cep
        ' 
        Txt_cep.Location = New Point(12, 90)
        Txt_cep.Name = "Txt_cep"
        Txt_cep.Size = New Size(115, 23)
        Txt_cep.TabIndex = 18
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(12, 69)
        Label10.Name = "Label10"
        Label10.Size = New Size(40, 18)
        Label10.TabIndex = 17
        Label10.Text = "CEP"
        ' 
        ' Txt_numero
        ' 
        Txt_numero.Location = New Point(621, 43)
        Txt_numero.Name = "Txt_numero"
        Txt_numero.Size = New Size(119, 23)
        Txt_numero.TabIndex = 16
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(621, 22)
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
        Label7.Location = New Point(12, 22)
        Label7.Name = "Label7"
        Label7.Size = New Size(102, 18)
        Label7.TabIndex = 14
        Label7.Text = "Logradouro"
        ' 
        ' Txt_logradouro
        ' 
        Txt_logradouro.Location = New Point(12, 43)
        Txt_logradouro.Name = "Txt_logradouro"
        Txt_logradouro.Size = New Size(585, 23)
        Txt_logradouro.TabIndex = 9
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
        Panel3.Controls.Add(Txt_email)
        Panel3.Controls.Add(Label14)
        Panel3.Controls.Add(Txt_celular)
        Panel3.Controls.Add(Label18)
        Panel3.Controls.Add(Label19)
        Panel3.Controls.Add(Txt_telefone)
        Panel3.Controls.Add(Label20)
        Panel3.Location = New Point(15, 348)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(760, 85)
        Panel3.TabIndex = 3
        ' 
        ' Txt_email
        ' 
        Txt_email.Location = New Point(449, 43)
        Txt_email.Name = "Txt_email"
        Txt_email.Size = New Size(290, 23)
        Txt_email.TabIndex = 18
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(449, 22)
        Label14.Name = "Label14"
        Label14.Size = New Size(59, 18)
        Label14.TabIndex = 17
        Label14.Text = "E-mail"
        ' 
        ' Txt_celular
        ' 
        Txt_celular.Location = New Point(224, 43)
        Txt_celular.Name = "Txt_celular"
        Txt_celular.Size = New Size(119, 23)
        Txt_celular.TabIndex = 16
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.Transparent
        Label18.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = Color.Black
        Label18.Location = New Point(224, 22)
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
        Label19.Location = New Point(12, 22)
        Label19.Name = "Label19"
        Label19.Size = New Size(78, 18)
        Label19.TabIndex = 14
        Label19.Text = "Telefone"
        ' 
        ' Txt_telefone
        ' 
        Txt_telefone.Location = New Point(12, 43)
        Txt_telefone.Name = "Txt_telefone"
        Txt_telefone.Size = New Size(115, 23)
        Txt_telefone.TabIndex = 9
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
        ' Btn_salvar
        ' 
        Btn_salvar.BackColor = Color.Transparent
        Btn_salvar.FlatAppearance.BorderSize = 2
        Btn_salvar.FlatAppearance.MouseDownBackColor = Color.MidnightBlue
        Btn_salvar.FlatAppearance.MouseOverBackColor = Color.Gray
        Btn_salvar.FlatStyle = FlatStyle.Flat
        Btn_salvar.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_salvar.ForeColor = Color.White
        Btn_salvar.Image = CType(resources.GetObject("Btn_salvar.Image"), Image)
        Btn_salvar.ImageAlign = ContentAlignment.TopCenter
        Btn_salvar.Location = New Point(111, 484)
        Btn_salvar.Name = "Btn_salvar"
        Btn_salvar.Size = New Size(88, 65)
        Btn_salvar.TabIndex = 4
        Btn_salvar.Text = "Salvar"
        Btn_salvar.TextAlign = ContentAlignment.BottomCenter
        Btn_salvar.UseVisualStyleBackColor = False
        ' 
        ' Btn_cancelar
        ' 
        Btn_cancelar.BackColor = Color.Transparent
        Btn_cancelar.FlatAppearance.BorderSize = 2
        Btn_cancelar.FlatAppearance.MouseDownBackColor = Color.MidnightBlue
        Btn_cancelar.FlatAppearance.MouseOverBackColor = Color.Gray
        Btn_cancelar.FlatStyle = FlatStyle.Flat
        Btn_cancelar.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_cancelar.ForeColor = Color.White
        Btn_cancelar.Image = CType(resources.GetObject("Btn_cancelar.Image"), Image)
        Btn_cancelar.ImageAlign = ContentAlignment.TopCenter
        Btn_cancelar.Location = New Point(265, 484)
        Btn_cancelar.Name = "Btn_cancelar"
        Btn_cancelar.Size = New Size(88, 65)
        Btn_cancelar.TabIndex = 5
        Btn_cancelar.Text = "Cancelar"
        Btn_cancelar.TextAlign = ContentAlignment.BottomCenter
        Btn_cancelar.UseVisualStyleBackColor = False
        ' 
        ' Btn_limpar
        ' 
        Btn_limpar.BackColor = Color.Transparent
        Btn_limpar.FlatAppearance.BorderSize = 2
        Btn_limpar.FlatAppearance.MouseDownBackColor = Color.MidnightBlue
        Btn_limpar.FlatAppearance.MouseOverBackColor = Color.Gray
        Btn_limpar.FlatStyle = FlatStyle.Flat
        Btn_limpar.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_limpar.ForeColor = Color.White
        Btn_limpar.Image = CType(resources.GetObject("Btn_limpar.Image"), Image)
        Btn_limpar.ImageAlign = ContentAlignment.TopCenter
        Btn_limpar.Location = New Point(419, 484)
        Btn_limpar.Name = "Btn_limpar"
        Btn_limpar.Size = New Size(88, 65)
        Btn_limpar.TabIndex = 6
        Btn_limpar.Text = "Limpar"
        Btn_limpar.TextAlign = ContentAlignment.BottomCenter
        Btn_limpar.UseVisualStyleBackColor = False
        ' 
        ' Btn_sair
        ' 
        Btn_sair.BackColor = Color.Transparent
        Btn_sair.FlatAppearance.BorderSize = 2
        Btn_sair.FlatAppearance.MouseDownBackColor = Color.MidnightBlue
        Btn_sair.FlatAppearance.MouseOverBackColor = Color.Gray
        Btn_sair.FlatStyle = FlatStyle.Flat
        Btn_sair.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_sair.ForeColor = Color.White
        Btn_sair.Image = CType(resources.GetObject("Btn_sair.Image"), Image)
        Btn_sair.ImageAlign = ContentAlignment.TopCenter
        Btn_sair.Location = New Point(573, 484)
        Btn_sair.Name = "Btn_sair"
        Btn_sair.Size = New Size(88, 65)
        Btn_sair.TabIndex = 7
        Btn_sair.Text = "Sair"
        Btn_sair.TextAlign = ContentAlignment.BottomCenter
        Btn_sair.UseVisualStyleBackColor = False
        ' 
        ' Lbl_mensagem
        ' 
        Lbl_mensagem.AutoSize = True
        Lbl_mensagem.BackColor = Color.White
        Lbl_mensagem.BorderStyle = BorderStyle.FixedSingle
        Lbl_mensagem.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_mensagem.ForeColor = Color.Black
        Lbl_mensagem.Location = New Point(302, 448)
        Lbl_mensagem.Name = "Lbl_mensagem"
        Lbl_mensagem.Size = New Size(2, 20)
        Lbl_mensagem.TabIndex = 8
        ' 
        ' Frm_clientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(784, 561)
        Controls.Add(Lbl_mensagem)
        Controls.Add(Btn_sair)
        Controls.Add(Btn_limpar)
        Controls.Add(Btn_cancelar)
        Controls.Add(Btn_salvar)
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
    Friend WithEvents Txt_data_de_nascimento As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_nome As TextBox
    Friend WithEvents Txt_cpf As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Chb_outro As CheckBox
    Friend WithEvents Chb_feminino As CheckBox
    Friend WithEvents Chb_masculino As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Txt_cep As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Txt_numero As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_logradouro As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Txt_complemento As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Txt_celular As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Txt_telefone As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Txt_email As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Btn_salvar As Button
    Friend WithEvents Btn_cancelar As Button
    Friend WithEvents Btn_limpar As Button
    Friend WithEvents Btn_sair As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Txt_outro As TextBox
    Friend WithEvents Txt_uf As TextBox
    Friend WithEvents Txt_cidade As TextBox
    Friend WithEvents Lbl_mensagem As Label
End Class
