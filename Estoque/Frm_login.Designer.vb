<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_login))
        Lbl_usuario = New Label()
        Lbl_senha = New Label()
        Txt_usuario = New TextBox()
        Txt_senha = New TextBox()
        Btn_login = New Button()
        Btn_limpar = New Button()
        Btn_sair = New Button()
        Lbl_aviso = New Label()
        ProgressBar1 = New ProgressBar()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Lbl_usuario
        ' 
        Lbl_usuario.AutoSize = True
        Lbl_usuario.BackColor = Color.Transparent
        Lbl_usuario.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_usuario.ForeColor = Color.White
        Lbl_usuario.Location = New Point(55, 38)
        Lbl_usuario.Name = "Lbl_usuario"
        Lbl_usuario.Size = New Size(70, 18)
        Lbl_usuario.TabIndex = 0
        Lbl_usuario.Text = "Usuário"
        ' 
        ' Lbl_senha
        ' 
        Lbl_senha.AutoSize = True
        Lbl_senha.BackColor = Color.Transparent
        Lbl_senha.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_senha.ForeColor = Color.White
        Lbl_senha.Location = New Point(55, 86)
        Lbl_senha.Name = "Lbl_senha"
        Lbl_senha.Size = New Size(59, 18)
        Lbl_senha.TabIndex = 1
        Lbl_senha.Text = "Senha"
        ' 
        ' Txt_usuario
        ' 
        Txt_usuario.Location = New Point(131, 38)
        Txt_usuario.Name = "Txt_usuario"
        Txt_usuario.Size = New Size(166, 23)
        Txt_usuario.TabIndex = 2
        ' 
        ' Txt_senha
        ' 
        Txt_senha.Location = New Point(131, 81)
        Txt_senha.Name = "Txt_senha"
        Txt_senha.Size = New Size(166, 23)
        Txt_senha.TabIndex = 3
        ' 
        ' Btn_login
        ' 
        Btn_login.BackColor = Color.Transparent
        Btn_login.FlatAppearance.BorderColor = Color.White
        Btn_login.FlatAppearance.BorderSize = 2
        Btn_login.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue
        Btn_login.FlatAppearance.MouseOverBackColor = Color.Gray
        Btn_login.FlatStyle = FlatStyle.Flat
        Btn_login.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_login.ForeColor = Color.White
        Btn_login.Location = New Point(55, 155)
        Btn_login.Name = "Btn_login"
        Btn_login.Size = New Size(75, 28)
        Btn_login.TabIndex = 4
        Btn_login.Text = "Login"
        Btn_login.UseVisualStyleBackColor = False
        ' 
        ' Btn_limpar
        ' 
        Btn_limpar.BackColor = Color.Transparent
        Btn_limpar.FlatAppearance.BorderColor = Color.White
        Btn_limpar.FlatAppearance.BorderSize = 2
        Btn_limpar.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue
        Btn_limpar.FlatAppearance.MouseOverBackColor = Color.Gray
        Btn_limpar.FlatStyle = FlatStyle.Flat
        Btn_limpar.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_limpar.ForeColor = Color.White
        Btn_limpar.Location = New Point(161, 155)
        Btn_limpar.Name = "Btn_limpar"
        Btn_limpar.Size = New Size(75, 28)
        Btn_limpar.TabIndex = 5
        Btn_limpar.Text = "Limpar"
        Btn_limpar.UseVisualStyleBackColor = False
        ' 
        ' Btn_sair
        ' 
        Btn_sair.BackColor = Color.Transparent
        Btn_sair.FlatAppearance.BorderColor = Color.White
        Btn_sair.FlatAppearance.BorderSize = 2
        Btn_sair.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue
        Btn_sair.FlatAppearance.MouseOverBackColor = Color.Gray
        Btn_sair.FlatStyle = FlatStyle.Flat
        Btn_sair.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_sair.ForeColor = Color.White
        Btn_sair.Location = New Point(264, 155)
        Btn_sair.Name = "Btn_sair"
        Btn_sair.Size = New Size(75, 28)
        Btn_sair.TabIndex = 6
        Btn_sair.Text = "Sair"
        Btn_sair.UseVisualStyleBackColor = False
        ' 
        ' Lbl_aviso
        ' 
        Lbl_aviso.AutoSize = True
        Lbl_aviso.BackColor = Color.Transparent
        Lbl_aviso.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_aviso.ForeColor = Color.White
        Lbl_aviso.Location = New Point(167, 121)
        Lbl_aviso.Name = "Lbl_aviso"
        Lbl_aviso.Size = New Size(0, 18)
        Lbl_aviso.TabIndex = 7
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(55, 192)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(284, 10)
        ProgressBar1.TabIndex = 8
        ' 
        ' Timer1
        ' 
        ' 
        ' Frm_login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(384, 211)
        Controls.Add(ProgressBar1)
        Controls.Add(Lbl_aviso)
        Controls.Add(Btn_sair)
        Controls.Add(Btn_limpar)
        Controls.Add(Btn_login)
        Controls.Add(Txt_senha)
        Controls.Add(Txt_usuario)
        Controls.Add(Lbl_senha)
        Controls.Add(Lbl_usuario)
        Name = "Frm_login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_usuario As Label
    Friend WithEvents Lbl_senha As Label
    Friend WithEvents Txt_usuario As TextBox
    Friend WithEvents Txt_senha As TextBox
    Friend WithEvents Btn_login As Button
    Friend WithEvents Btn_limpar As Button
    Friend WithEvents Btn_sair As Button
    Friend WithEvents Lbl_aviso As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer

End Class
