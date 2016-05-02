<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InicioUIL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InicioUIL))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tssMinerarClientes = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblInfo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnMinerarClientes = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnBuscarClientes = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.StatusStrip1)
        Me.KryptonPanel.Controls.Add(Me.lblInfo)
        Me.KryptonPanel.Controls.Add(Me.btnMinerarClientes)
        Me.KryptonPanel.Controls.Add(Me.btnBuscarClientes)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(358, 141)
        Me.KryptonPanel.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tssMinerarClientes})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 119)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(358, 22)
        Me.StatusStrip1.TabIndex = 23
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(171, 17)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "Minerar Clientes (F5)"
        '
        'tssMinerarClientes
        '
        Me.tssMinerarClientes.Name = "tssMinerarClientes"
        Me.tssMinerarClientes.Size = New System.Drawing.Size(171, 17)
        Me.tssMinerarClientes.Spring = True
        Me.tssMinerarClientes.Text = "Consultar Clientes (F10)"
        '
        'lblInfo
        '
        Me.lblInfo.Location = New System.Drawing.Point(103, 39)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(146, 20)
        Me.lblInfo.TabIndex = 2
        Me.lblInfo.Values.Text = "Escolha uma das opções:"
        '
        'btnMinerarClientes
        '
        Me.btnMinerarClientes.Location = New System.Drawing.Point(71, 65)
        Me.btnMinerarClientes.Name = "btnMinerarClientes"
        Me.btnMinerarClientes.Size = New System.Drawing.Size(110, 25)
        Me.btnMinerarClientes.TabIndex = 1
        Me.btnMinerarClientes.Values.Text = "Minerar Clientes"
        '
        'btnBuscarClientes
        '
        Me.btnBuscarClientes.Location = New System.Drawing.Point(187, 65)
        Me.btnBuscarClientes.Name = "btnBuscarClientes"
        Me.btnBuscarClientes.Size = New System.Drawing.Size(108, 25)
        Me.btnBuscarClientes.TabIndex = 0
        Me.btnBuscarClientes.Values.Text = "Buscar Clientes"
        '
        'InicioUIL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 141)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InicioUIL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
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
    Friend WithEvents lblInfo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnMinerarClientes As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnBuscarClientes As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssMinerarClientes As System.Windows.Forms.ToolStripStatusLabel
End Class
