Public Class ConsultaClientesBLL
    Private form As ConsultaClientesUIL

    Public Sub New(ByVal ConsultaClientesUIL As ConsultaClientesUIL)
        Me.form = ConsultaClientesUIL
    End Sub
    Public Sub PreencherComboTipoPesquisa()
        Dim sDados() As String = {"Iniciado por", "Contendo"}
        form.cboTipoPesquisa.DataSource = sDados
    End Sub
    Public Sub PreencherComboCampoPesquisa()
        Dim sDados() As String = {"Cód. Cliente", "Razão Social", "Nome Fantasia", "CNPJ", "Inscrição Est.", "Email", "Rua", "Numero", "Bairro", "Cidade", "UF", "Telefone", "CEP"}
        form.cboCampoPesquisar.DataSource = sDados
    End Sub
    Public Sub ConsultaClientes()
        form.Enabled = False
        Dim ConsultaClientesDAL As New ConsultaClientesDAL(New ConsultaDML(form.cboCampoPesquisar.SelectedIndex, form.txtCampoPesquisa.Text, form.cboTipoPesquisa.SelectedIndex))
        form.gridClientes.DataSource = ConsultaClientesDAL.ConsultaClientes()
        form.tssTotal.Text = "Total: " & form.gridClientes.RowCount
        form.Enabled = True
    End Sub
    Public Sub Exportar()
        ExportGridToExcel(form.gridClientes, xlsOption.xlsOpen, form, form.tssExportar)
    End Sub
End Class
