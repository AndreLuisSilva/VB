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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_login))
        lbl_usuario = New Label()
        lvl_senha = New Label()
        txt_usuario = New TextBox()
        txt_senha = New TextBox()
        btn_login = New Button()
        btn_limpar = New Button()
        btn_sair = New Button()
        SuspendLayout()
        ' 
        ' lbl_usuario
        ' 
        lbl_usuario.AutoSize = True
        lbl_usuario.BackColor = Color.Transparent
        lbl_usuario.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_usuario.ForeColor = Color.White
        lbl_usuario.Location = New Point(53, 61)
        lbl_usuario.Name = "lbl_usuario"
        lbl_usuario.Size = New Size(70, 18)
        lbl_usuario.TabIndex = 0
        lbl_usuario.Text = "Usuário"
        ' 
        ' lvl_senha
        ' 
        lvl_senha.AutoSize = True
        lvl_senha.BackColor = Color.Transparent
        lvl_senha.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lvl_senha.ForeColor = Color.White
        lvl_senha.Location = New Point(53, 109)
        lvl_senha.Name = "lvl_senha"
        lvl_senha.Size = New Size(59, 18)
        lvl_senha.TabIndex = 1
        lvl_senha.Text = "Senha"
        ' 
        ' txt_usuario
        ' 
        txt_usuario.Location = New Point(129, 61)
        txt_usuario.Name = "txt_usuario"
        txt_usuario.Size = New Size(166, 23)
        txt_usuario.TabIndex = 2
        ' 
        ' txt_senha
        ' 
        txt_senha.Location = New Point(129, 104)
        txt_senha.Name = "txt_senha"
        txt_senha.Size = New Size(166, 23)
        txt_senha.TabIndex = 3
        ' 
        ' btn_login
        ' 
        btn_login.BackColor = Color.Transparent
        btn_login.FlatAppearance.BorderColor = Color.White
        btn_login.FlatAppearance.BorderSize = 2
        btn_login.FlatAppearance.MouseDownBackColor = Color.LightCoral
        btn_login.FlatAppearance.MouseOverBackColor = Color.SpringGreen
        btn_login.FlatStyle = FlatStyle.Flat
        btn_login.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_login.ForeColor = Color.White
        btn_login.Location = New Point(53, 178)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(75, 28)
        btn_login.TabIndex = 4
        btn_login.Text = "Login"
        btn_login.UseVisualStyleBackColor = False
        ' 
        ' btn_limpar
        ' 
        btn_limpar.BackColor = Color.Transparent
        btn_limpar.FlatAppearance.BorderColor = Color.White
        btn_limpar.FlatAppearance.BorderSize = 2
        btn_limpar.FlatAppearance.MouseDownBackColor = Color.LightCoral
        btn_limpar.FlatAppearance.MouseOverBackColor = Color.SpringGreen
        btn_limpar.FlatStyle = FlatStyle.Flat
        btn_limpar.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_limpar.ForeColor = Color.White
        btn_limpar.Location = New Point(159, 178)
        btn_limpar.Name = "btn_limpar"
        btn_limpar.Size = New Size(75, 28)
        btn_limpar.TabIndex = 5
        btn_limpar.Text = "Limpar"
        btn_limpar.UseVisualStyleBackColor = False
        ' 
        ' btn_sair
        ' 
        btn_sair.BackColor = Color.Transparent
        btn_sair.FlatAppearance.BorderColor = Color.White
        btn_sair.FlatAppearance.BorderSize = 2
        btn_sair.FlatAppearance.MouseDownBackColor = Color.LightCoral
        btn_sair.FlatAppearance.MouseOverBackColor = Color.SpringGreen
        btn_sair.FlatStyle = FlatStyle.Flat
        btn_sair.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_sair.ForeColor = Color.White
        btn_sair.Location = New Point(262, 178)
        btn_sair.Name = "btn_sair"
        btn_sair.Size = New Size(75, 28)
        btn_sair.TabIndex = 6
        btn_sair.Text = "Sair"
        btn_sair.UseVisualStyleBackColor = False
        ' 
        ' Frm_login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(405, 277)
        Controls.Add(btn_sair)
        Controls.Add(btn_limpar)
        Controls.Add(btn_login)
        Controls.Add(txt_senha)
        Controls.Add(txt_usuario)
        Controls.Add(lvl_senha)
        Controls.Add(lbl_usuario)
        Name = "Frm_login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_usuario As Label
    Friend WithEvents lvl_senha As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_limpar As Button
    Friend WithEvents btn_sair As Button

End Class
