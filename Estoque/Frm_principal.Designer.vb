<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_principal))
        MenuStrip1 = New MenuStrip()
        CadastrosToolStripMenuItem = New ToolStripMenuItem()
        ConsultasToolStripMenuItem = New ToolStripMenuItem()
        RelatóriosToolStripMenuItem = New ToolStripMenuItem()
        AjudaToolStripMenuItem = New ToolStripMenuItem()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        RegistrosToolStripMenuItem = New ToolStripMenuItem()
        FaturasToolStripMenuItem = New ToolStripMenuItem()
        UsuáriosToolStripMenuItem = New ToolStripMenuItem()
        ConsultaGeralToolStripMenuItem = New ToolStripMenuItem()
        ConsultaEspecíficaToolStripMenuItem = New ToolStripMenuItem()
        RelatórioGeralToolStripMenuItem = New ToolStripMenuItem()
        RelatórioEspecíficoToolStripMenuItem = New ToolStripMenuItem()
        AjudaToolStripMenuItem1 = New ToolStripMenuItem()
        SairToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ControlLight
        MenuStrip1.Items.AddRange(New ToolStripItem() {CadastrosToolStripMenuItem, ConsultasToolStripMenuItem, RelatóriosToolStripMenuItem, AjudaToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(784, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' CadastrosToolStripMenuItem
        ' 
        CadastrosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ClientesToolStripMenuItem, RegistrosToolStripMenuItem, FaturasToolStripMenuItem, UsuáriosToolStripMenuItem})
        CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem"
        CadastrosToolStripMenuItem.Size = New Size(71, 20)
        CadastrosToolStripMenuItem.Text = "Cadastros"
        ' 
        ' ConsultasToolStripMenuItem
        ' 
        ConsultasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ConsultaGeralToolStripMenuItem, ConsultaEspecíficaToolStripMenuItem})
        ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        ConsultasToolStripMenuItem.Size = New Size(71, 20)
        ConsultasToolStripMenuItem.Text = "Consultas"
        ' 
        ' RelatóriosToolStripMenuItem
        ' 
        RelatóriosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RelatórioGeralToolStripMenuItem, RelatórioEspecíficoToolStripMenuItem})
        RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        RelatóriosToolStripMenuItem.Size = New Size(71, 20)
        RelatóriosToolStripMenuItem.Text = "Relatórios"
        ' 
        ' AjudaToolStripMenuItem
        ' 
        AjudaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AjudaToolStripMenuItem1, SairToolStripMenuItem})
        AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        AjudaToolStripMenuItem.Size = New Size(50, 20)
        AjudaToolStripMenuItem.Text = "Ajuda"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(180, 22)
        ClientesToolStripMenuItem.Text = "Clientes"
        ' 
        ' RegistrosToolStripMenuItem
        ' 
        RegistrosToolStripMenuItem.Name = "RegistrosToolStripMenuItem"
        RegistrosToolStripMenuItem.Size = New Size(180, 22)
        RegistrosToolStripMenuItem.Text = "Registros"
        ' 
        ' FaturasToolStripMenuItem
        ' 
        FaturasToolStripMenuItem.Name = "FaturasToolStripMenuItem"
        FaturasToolStripMenuItem.Size = New Size(180, 22)
        FaturasToolStripMenuItem.Text = "Faturas"
        ' 
        ' UsuáriosToolStripMenuItem
        ' 
        UsuáriosToolStripMenuItem.Name = "UsuáriosToolStripMenuItem"
        UsuáriosToolStripMenuItem.Size = New Size(180, 22)
        UsuáriosToolStripMenuItem.Text = "Usuários"
        ' 
        ' ConsultaGeralToolStripMenuItem
        ' 
        ConsultaGeralToolStripMenuItem.Name = "ConsultaGeralToolStripMenuItem"
        ConsultaGeralToolStripMenuItem.Size = New Size(180, 22)
        ConsultaGeralToolStripMenuItem.Text = "Consulta Geral"
        ' 
        ' ConsultaEspecíficaToolStripMenuItem
        ' 
        ConsultaEspecíficaToolStripMenuItem.Name = "ConsultaEspecíficaToolStripMenuItem"
        ConsultaEspecíficaToolStripMenuItem.Size = New Size(180, 22)
        ConsultaEspecíficaToolStripMenuItem.Text = "Consulta Específica"
        ' 
        ' RelatórioGeralToolStripMenuItem
        ' 
        RelatórioGeralToolStripMenuItem.Name = "RelatórioGeralToolStripMenuItem"
        RelatórioGeralToolStripMenuItem.Size = New Size(180, 22)
        RelatórioGeralToolStripMenuItem.Text = "Relatório Geral"
        ' 
        ' RelatórioEspecíficoToolStripMenuItem
        ' 
        RelatórioEspecíficoToolStripMenuItem.Name = "RelatórioEspecíficoToolStripMenuItem"
        RelatórioEspecíficoToolStripMenuItem.Size = New Size(180, 22)
        RelatórioEspecíficoToolStripMenuItem.Text = "Relatório Específico"
        ' 
        ' AjudaToolStripMenuItem1
        ' 
        AjudaToolStripMenuItem1.Name = "AjudaToolStripMenuItem1"
        AjudaToolStripMenuItem1.Size = New Size(180, 22)
        AjudaToolStripMenuItem1.Text = "Ajuda"
        ' 
        ' SairToolStripMenuItem
        ' 
        SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        SairToolStripMenuItem.Size = New Size(180, 22)
        SairToolStripMenuItem.Text = "Sair"
        ' 
        ' Frm_principal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(784, 561)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Frm_principal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Estoque"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatóriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FaturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaGeralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaEspecíficaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatórioGeralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatórioEspecíficoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
End Class
