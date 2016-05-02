<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaClientesUIL
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaClientesUIL))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.cboCampoPesquisar = New System.Windows.Forms.ComboBox
        Me.cboTipoPesquisa = New System.Windows.Forms.ComboBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.tssTotal = New System.Windows.Forms.ToolStripStatusLabel
        Me.tssExportar = New System.Windows.Forms.ToolStripStatusLabel
        Me.cboCampoPesquisa = New ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
        Me.lblTipoPesquisa = New ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
        Me.lblPesquisa = New ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
        Me.btnPesquisa = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtCampoPesquisa = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.gridClientes = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CLIENTEID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RAZAOSOCIAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOMEFANTASIA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CNPJ = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.INSCRICAO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TELEFONE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RUA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NUMERO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BAIRRO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CIDADE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CEP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.gridClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.cboCampoPesquisar)
        Me.KryptonPanel.Controls.Add(Me.cboTipoPesquisa)
        Me.KryptonPanel.Controls.Add(Me.StatusStrip1)
        Me.KryptonPanel.Controls.Add(Me.cboCampoPesquisa)
        Me.KryptonPanel.Controls.Add(Me.lblTipoPesquisa)
        Me.KryptonPanel.Controls.Add(Me.lblPesquisa)
        Me.KryptonPanel.Controls.Add(Me.btnPesquisa)
        Me.KryptonPanel.Controls.Add(Me.txtCampoPesquisa)
        Me.KryptonPanel.Controls.Add(Me.gridClientes)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1149, 406)
        Me.KryptonPanel.TabIndex = 0
        '
        'cboCampoPesquisar
        '
        Me.cboCampoPesquisar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCampoPesquisar.FormattingEnabled = True
        Me.cboCampoPesquisar.Location = New System.Drawing.Point(711, 25)
        Me.cboCampoPesquisar.Name = "cboCampoPesquisar"
        Me.cboCampoPesquisar.Size = New System.Drawing.Size(104, 21)
        Me.cboCampoPesquisar.TabIndex = 27
        '
        'cboTipoPesquisa
        '
        Me.cboTipoPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoPesquisa.FormattingEnabled = True
        Me.cboTipoPesquisa.Location = New System.Drawing.Point(594, 25)
        Me.cboTipoPesquisa.Name = "cboTipoPesquisa"
        Me.cboTipoPesquisa.Size = New System.Drawing.Size(104, 21)
        Me.cboTipoPesquisa.TabIndex = 26
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssTotal, Me.ToolStripStatusLabel1, Me.tssExportar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 384)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1149, 22)
        Me.StatusStrip1.TabIndex = 22
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssTotal
        '
        Me.tssTotal.Name = "tssTotal"
        Me.tssTotal.Size = New System.Drawing.Size(378, 17)
        Me.tssTotal.Spring = True
        Me.tssTotal.Text = "Total: 0"
        '
        'tssExportar
        '
        Me.tssExportar.Name = "tssExportar"
        Me.tssExportar.Size = New System.Drawing.Size(378, 17)
        Me.tssExportar.Spring = True
        Me.tssExportar.Text = "Exportar (F10)"
        '
        'cboCampoPesquisa
        '
        Me.cboCampoPesquisa.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboCampoPesquisa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.cboCampoPesquisa.Location = New System.Drawing.Point(711, 8)
        Me.cboCampoPesquisa.Name = "cboCampoPesquisa"
        Me.cboCampoPesquisa.Size = New System.Drawing.Size(95, 15)
        Me.cboCampoPesquisa.Text = "Campo pesquisa"
        '
        'lblTipoPesquisa
        '
        Me.lblTipoPesquisa.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTipoPesquisa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblTipoPesquisa.Location = New System.Drawing.Point(592, 7)
        Me.lblTipoPesquisa.Name = "lblTipoPesquisa"
        Me.lblTipoPesquisa.Size = New System.Drawing.Size(80, 15)
        Me.lblTipoPesquisa.Text = "Tipo pesquisa"
        '
        'lblPesquisa
        '
        Me.lblPesquisa.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPesquisa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblPesquisa.Location = New System.Drawing.Point(12, 8)
        Me.lblPesquisa.Name = "lblPesquisa"
        Me.lblPesquisa.Size = New System.Drawing.Size(56, 15)
        Me.lblPesquisa.Text = "Pesquisa:"
        '
        'btnPesquisa
        '
        Me.btnPesquisa.Location = New System.Drawing.Point(821, 21)
        Me.btnPesquisa.Name = "btnPesquisa"
        Me.btnPesquisa.Size = New System.Drawing.Size(104, 25)
        Me.btnPesquisa.TabIndex = 14
        Me.btnPesquisa.Values.Text = "Pesquisa"
        '
        'txtCampoPesquisa
        '
        Me.txtCampoPesquisa.Location = New System.Drawing.Point(12, 26)
        Me.txtCampoPesquisa.Name = "txtCampoPesquisa"
        Me.txtCampoPesquisa.Size = New System.Drawing.Size(576, 20)
        Me.txtCampoPesquisa.TabIndex = 13
        '
        'gridClientes
        '
        Me.gridClientes.AllowUserToAddRows = False
        Me.gridClientes.AllowUserToDeleteRows = False
        Me.gridClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLIENTEID, Me.RAZAOSOCIAL, Me.NOMEFANTASIA, Me.CNPJ, Me.INSCRICAO, Me.TELEFONE, Me.EMAIL, Me.RUA, Me.NUMERO, Me.BAIRRO, Me.CIDADE, Me.UF, Me.CEP})
        Me.gridClientes.Location = New System.Drawing.Point(12, 52)
        Me.gridClientes.Name = "gridClientes"
        Me.gridClientes.ReadOnly = True
        Me.gridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridClientes.Size = New System.Drawing.Size(1125, 329)
        Me.gridClientes.TabIndex = 12
        '
        'CLIENTEID
        '
        Me.CLIENTEID.DataPropertyName = "CLIENTE_ID"
        Me.CLIENTEID.HeaderText = "Cód. Cliente"
        Me.CLIENTEID.Name = "CLIENTEID"
        Me.CLIENTEID.ReadOnly = True
        Me.CLIENTEID.Width = 75
        '
        'RAZAOSOCIAL
        '
        Me.RAZAOSOCIAL.DataPropertyName = "RAZAOSOCIAL"
        Me.RAZAOSOCIAL.HeaderText = "Razão social"
        Me.RAZAOSOCIAL.Name = "RAZAOSOCIAL"
        Me.RAZAOSOCIAL.ReadOnly = True
        Me.RAZAOSOCIAL.Width = 200
        '
        'NOMEFANTASIA
        '
        Me.NOMEFANTASIA.DataPropertyName = "NOMEFANTASIA"
        Me.NOMEFANTASIA.HeaderText = "Nome fantasia"
        Me.NOMEFANTASIA.Name = "NOMEFANTASIA"
        Me.NOMEFANTASIA.ReadOnly = True
        Me.NOMEFANTASIA.Width = 200
        '
        'CNPJ
        '
        Me.CNPJ.DataPropertyName = "CNPJ"
        Me.CNPJ.HeaderText = "CNPJ"
        Me.CNPJ.Name = "CNPJ"
        Me.CNPJ.ReadOnly = True
        Me.CNPJ.Width = 90
        '
        'INSCRICAO
        '
        Me.INSCRICAO.DataPropertyName = "INSCRICAO_ESTADUAL"
        Me.INSCRICAO.HeaderText = "Insc. Estadual"
        Me.INSCRICAO.Name = "INSCRICAO"
        Me.INSCRICAO.ReadOnly = True
        Me.INSCRICAO.Width = 80
        '
        'TELEFONE
        '
        Me.TELEFONE.DataPropertyName = "TELEFONE"
        Me.TELEFONE.HeaderText = "Telefone"
        Me.TELEFONE.Name = "TELEFONE"
        Me.TELEFONE.ReadOnly = True
        Me.TELEFONE.Width = 80
        '
        'EMAIL
        '
        Me.EMAIL.DataPropertyName = "EMAIL"
        Me.EMAIL.HeaderText = "Email"
        Me.EMAIL.Name = "EMAIL"
        Me.EMAIL.ReadOnly = True
        Me.EMAIL.Width = 120
        '
        'RUA
        '
        Me.RUA.DataPropertyName = "RUA"
        Me.RUA.HeaderText = "Rua"
        Me.RUA.Name = "RUA"
        Me.RUA.ReadOnly = True
        '
        'NUMERO
        '
        Me.NUMERO.DataPropertyName = "NUMERO"
        Me.NUMERO.HeaderText = "Numero"
        Me.NUMERO.Name = "NUMERO"
        Me.NUMERO.ReadOnly = True
        Me.NUMERO.Width = 60
        '
        'BAIRRO
        '
        Me.BAIRRO.DataPropertyName = "BAIRRO"
        Me.BAIRRO.HeaderText = "Bairro"
        Me.BAIRRO.Name = "BAIRRO"
        Me.BAIRRO.ReadOnly = True
        '
        'CIDADE
        '
        Me.CIDADE.DataPropertyName = "CIDADE"
        Me.CIDADE.HeaderText = "Cidade"
        Me.CIDADE.Name = "CIDADE"
        Me.CIDADE.ReadOnly = True
        Me.CIDADE.Width = 80
        '
        'UF
        '
        Me.UF.DataPropertyName = "UF"
        Me.UF.HeaderText = "UF"
        Me.UF.Name = "UF"
        Me.UF.ReadOnly = True
        Me.UF.Width = 50
        '
        'CEP
        '
        Me.CEP.DataPropertyName = "CEP"
        Me.CEP.HeaderText = "CEP"
        Me.CEP.Name = "CEP"
        Me.CEP.ReadOnly = True
        Me.CEP.Width = 65
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(378, 17)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "Consultar Clientes (F5)"
        '
        'ConsultaClientesUIL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1149, 406)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "ConsultaClientesUIL"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Clientes"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.gridClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents lblPesquisa As ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
    Friend WithEvents cboCampoPesquisa As ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
    Friend WithEvents lblTipoPesquisa As ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tssExportar As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents btnPesquisa As ComponentFactory.Krypton.Toolkit.KryptonButton
    Public WithEvents txtCampoPesquisa As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Public WithEvents gridClientes As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Public WithEvents cboCampoPesquisar As System.Windows.Forms.ComboBox
    Public WithEvents cboTipoPesquisa As System.Windows.Forms.ComboBox
    Friend WithEvents CLIENTEID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RAZAOSOCIAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMEFANTASIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CNPJ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INSCRICAO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TELEFONE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMAIL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RUA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMERO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BAIRRO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CIDADE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CEP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tssTotal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
End Class
