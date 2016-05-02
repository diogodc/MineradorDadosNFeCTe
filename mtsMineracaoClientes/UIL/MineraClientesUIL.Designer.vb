<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MineraClientesUIL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MineraClientesUIL))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.cboTipoXML = New System.Windows.Forms.ComboBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.tssMinerarClientes = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblTipo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblInfo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnProcCamXml = New System.Windows.Forms.Button
        Me.txtCaminhoLeitura = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnMinerarClientes = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.pgrProgresso = New System.Windows.Forms.ProgressBar
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.cboTipoXML)
        Me.KryptonPanel.Controls.Add(Me.StatusStrip1)
        Me.KryptonPanel.Controls.Add(Me.lblTipo)
        Me.KryptonPanel.Controls.Add(Me.lblInfo)
        Me.KryptonPanel.Controls.Add(Me.btnProcCamXml)
        Me.KryptonPanel.Controls.Add(Me.txtCaminhoLeitura)
        Me.KryptonPanel.Controls.Add(Me.btnMinerarClientes)
        Me.KryptonPanel.Controls.Add(Me.pgrProgresso)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderForm
        Me.KryptonPanel.Size = New System.Drawing.Size(652, 161)
        Me.KryptonPanel.TabIndex = 0
        '
        'cboTipoXML
        '
        Me.cboTipoXML.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoXML.FormattingEnabled = True
        Me.cboTipoXML.Location = New System.Drawing.Point(528, 43)
        Me.cboTipoXML.Name = "cboTipoXML"
        Me.cboTipoXML.Size = New System.Drawing.Size(112, 21)
        Me.cboTipoXML.TabIndex = 9
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssMinerarClientes})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 139)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(652, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssMinerarClientes
        '
        Me.tssMinerarClientes.Name = "tssMinerarClientes"
        Me.tssMinerarClientes.Size = New System.Drawing.Size(114, 17)
        Me.tssMinerarClientes.Text = "Minerar clientes (F5)"
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(524, 17)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(82, 20)
        Me.lblTipo.TabIndex = 7
        Me.lblTipo.Values.Text = "Tipo de XML:"
        '
        'lblInfo
        '
        Me.lblInfo.Location = New System.Drawing.Point(12, 18)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(217, 20)
        Me.lblInfo.TabIndex = 5
        Me.lblInfo.Values.Text = "Informe o caminho dos arquivos XML:"
        '
        'btnProcCamXml
        '
        Me.btnProcCamXml.BackColor = System.Drawing.Color.White
        Me.btnProcCamXml.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnProcCamXml.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnProcCamXml.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnProcCamXml.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnProcCamXml.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProcCamXml.Image = CType(resources.GetObject("btnProcCamXml.Image"), System.Drawing.Image)
        Me.btnProcCamXml.Location = New System.Drawing.Point(499, 43)
        Me.btnProcCamXml.Name = "btnProcCamXml"
        Me.btnProcCamXml.Size = New System.Drawing.Size(25, 20)
        Me.btnProcCamXml.TabIndex = 4
        Me.btnProcCamXml.TabStop = False
        Me.btnProcCamXml.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnProcCamXml.UseVisualStyleBackColor = False
        '
        'txtCaminhoLeitura
        '
        Me.txtCaminhoLeitura.Location = New System.Drawing.Point(12, 43)
        Me.txtCaminhoLeitura.Name = "txtCaminhoLeitura"
        Me.txtCaminhoLeitura.Size = New System.Drawing.Size(487, 20)
        Me.txtCaminhoLeitura.TabIndex = 3
        '
        'btnMinerarClientes
        '
        Me.btnMinerarClientes.Location = New System.Drawing.Point(286, 98)
        Me.btnMinerarClientes.Name = "btnMinerarClientes"
        Me.btnMinerarClientes.Size = New System.Drawing.Size(104, 25)
        Me.btnMinerarClientes.TabIndex = 1
        Me.btnMinerarClientes.Values.Text = "Minerar Clientes"
        '
        'pgrProgresso
        '
        Me.pgrProgresso.Location = New System.Drawing.Point(12, 69)
        Me.pgrProgresso.Name = "pgrProgresso"
        Me.pgrProgresso.Size = New System.Drawing.Size(628, 23)
        Me.pgrProgresso.TabIndex = 0
        '
        'MineraClientesUIL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 161)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MineraClientesUIL"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mineração de clientes"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
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
    Friend WithEvents lblTipo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblInfo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tssMinerarClientes As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents txtCaminhoLeitura As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Public WithEvents btnMinerarClientes As ComponentFactory.Krypton.Toolkit.KryptonButton
    Public WithEvents pgrProgresso As System.Windows.Forms.ProgressBar
    Public WithEvents btnProcCamXml As System.Windows.Forms.Button
    Public WithEvents cboTipoXML As System.Windows.Forms.ComboBox
End Class
