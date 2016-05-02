Imports System.Xml
Imports System.IO

Public Class MineraClientesBLL
    Private form As MineraClientesUIL
    Private arqXMLCTe As CTeDML.cteProc
    Private arqXMLNFe As NFeDML.TNfeProc

    Public Sub New(ByVal form As MineraClientesUIL)
        Me.form = form
    End Sub

    Public Sub ProcuraArquivo()
        Dim fbdPath As New FolderBrowserDialog
        fbdPath.Description = "Selecione a pasta que contem os arquivos XML:"
        fbdPath.RootFolder = Environment.SpecialFolder.Desktop
        fbdPath.ShowDialog()

        If fbdPath.SelectedPath <> "" Then
            form.txtCaminhoLeitura.Text = fbdPath.SelectedPath
        End If
    End Sub

    Public Sub PreencherCombo()
        Dim sDados() As String = {"NFe", "CTe"}
        form.cboTipoXML.DataSource = sDados
    End Sub

    Private Function SerealizarXML(ByVal sArquivo As String, ByVal iTipoXML As Integer) As Boolean
        Try
            Dim fiArquivo As New FileInfo(sArquivo)
            If fiArquivo.FullName.ToUpper.IndexOf(".XML") <> -1 Then
                If iTipoXML = 1 Then
                    Dim xsDeserializer As New Serialization.XmlSerializer(GetType(NFeDML.TNfeProc))
                    Dim fsData As New FileStream(fiArquivo.FullName, FileMode.Open, FileAccess.Read, FileShare.None)
                    arqXMLNFe = CType(xsDeserializer.Deserialize(fsData), NFeDML.TNfeProc)

                    fsData.Close()
                    fsData = Nothing
                    xsDeserializer = Nothing

                    Return True
                ElseIf iTipoXML = 2 Then
                    Dim xsDeserializer As New Serialization.XmlSerializer(GetType(CTeDML.cteProc))
                    Dim fsData As New FileStream(fiArquivo.FullName, FileMode.Open, FileAccess.Read, FileShare.None)
                    arqXMLCTe = CType(xsDeserializer.Deserialize(fsData), CTeDML.cteProc)

                    fsData.Close()
                    fsData = Nothing
                    xsDeserializer = Nothing

                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function ValidaCampos() As Boolean
        If form.txtCaminhoLeitura.Text.Trim = "" Then
            form.txtCaminhoLeitura.Focus()
            MessageBox.Show("Informe o caminho dos arquivos!", form.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf form.cboTipoXML.SelectedIndex = -1 Then
            form.cboTipoXML.Focus()
            MessageBox.Show("Informe o tipo de XML!", form.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Function CarregaArquivo() As DirectoryInfo
        Dim fFolder As New DirectoryInfo(form.txtCaminhoLeitura.Text.Trim)
        If fFolder.Exists Then
            If fFolder.GetFiles.Count = 0 Then
                MessageBox.Show("Não contem Arquivos na pasta indicada!", form.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                form.txtCaminhoLeitura.Focus()
                Return Nothing
            End If
        Else
            MessageBox.Show("O caminho especificado não existe!", form.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            form.txtCaminhoLeitura.Focus()
            Return Nothing
        End If
        Return fFolder
    End Function

    Public Sub MinerarClientes()
        If ValidaCampos() = False Then Exit Sub

        form.Enabled = False

        Dim ArqInfo As FileInfo
        Dim Folder As DirectoryInfo = CarregaArquivo()
        Dim ClientesDML As New ClientesDML

        If Folder Is Nothing Then Exit Sub

        form.pgrProgresso.Maximum = Folder.GetFiles.Count

        If form.cboTipoXML.SelectedIndex = 0 Then
            For Each ArqInfo In Folder.GetFiles
                form.pgrProgresso.Value = form.pgrProgresso.Value + 1
                If SerealizarXML(ArqInfo.FullName, 1) = False Then Continue For

                ClientesDML.CNPJ = arqXMLNFe.NFe.infNFe.dest.Item
                ClientesDML.RazaoSocial = arqXMLNFe.NFe.infNFe.dest.xNome
                ClientesDML.NomeFantasia = arqXMLNFe.NFe.infNFe.dest.xNome
                ClientesDML.InscricaoEstadual = arqXMLNFe.NFe.infNFe.dest.IE
                ClientesDML.Email = arqXMLNFe.NFe.infNFe.dest.email
                ClientesDML.Rua = arqXMLNFe.NFe.infNFe.dest.enderDest.xLgr
                ClientesDML.Numero = arqXMLNFe.NFe.infNFe.dest.enderDest.nro
                ClientesDML.Bairro = arqXMLNFe.NFe.infNFe.dest.enderDest.xBairro
                ClientesDML.Cidade = arqXMLNFe.NFe.infNFe.dest.enderDest.xMun
                ClientesDML.UF = arqXMLNFe.NFe.infNFe.dest.enderDest.UF.ToString
                ClientesDML.CEP = arqXMLNFe.NFe.infNFe.dest.enderDest.CEP
                ClientesDML.Fone = arqXMLNFe.NFe.infNFe.dest.enderDest.fone
                If ClientesDML.CNPJ IsNot Nothing Then
                    Dim MineraClientesDAL As New MineraClientesDAL(ClientesDML)
                    MineraClientesDAL.SalvaClientes()
                End If
            Next
        ElseIf form.cboTipoXML.SelectedIndex = 1 Then
            For Each ArqInfo In Folder.GetFiles
                form.pgrProgresso.Value = form.pgrProgresso.Value + 1
                If SerealizarXML(ArqInfo.FullName, 2) = False Then Continue For

                'Destinatario
                ClientesDML.CNPJ = IIf(arqXMLCTe.CTe.infCte.dest.Item = Nothing, "", arqXMLCTe.CTe.infCte.dest.Item)
                ClientesDML.RazaoSocial = IIf(arqXMLCTe.CTe.infCte.dest.xNome = Nothing, "", arqXMLCTe.CTe.infCte.dest.xNome)
                ClientesDML.NomeFantasia = IIf(arqXMLCTe.CTe.infCte.dest.xNome = Nothing, "", arqXMLCTe.CTe.infCte.dest.xNome)
                ClientesDML.InscricaoEstadual = IIf(arqXMLCTe.CTe.infCte.dest.IE = Nothing, "", arqXMLCTe.CTe.infCte.dest.IE)
                ClientesDML.Email = IIf(arqXMLCTe.CTe.infCte.dest.email = Nothing, "", arqXMLCTe.CTe.infCte.dest.email)
                ClientesDML.Rua = IIf(arqXMLCTe.CTe.infCte.dest.enderDest.xLgr = Nothing, "", arqXMLCTe.CTe.infCte.dest.enderDest.xLgr)
                ClientesDML.Numero = IIf(arqXMLCTe.CTe.infCte.dest.enderDest.nro = Nothing, "", arqXMLCTe.CTe.infCte.dest.enderDest.nro)
                ClientesDML.Bairro = IIf(arqXMLCTe.CTe.infCte.dest.enderDest.xBairro = Nothing, "", arqXMLCTe.CTe.infCte.dest.enderDest.xBairro)
                ClientesDML.Cidade = IIf(arqXMLCTe.CTe.infCte.dest.enderDest.xMun = Nothing, "", arqXMLCTe.CTe.infCte.dest.enderDest.xMun)
                ClientesDML.UF = IIf(arqXMLCTe.CTe.infCte.dest.enderDest.UF = Nothing, "", arqXMLCTe.CTe.infCte.dest.enderDest.UF.ToString)
                ClientesDML.Fone = IIf(arqXMLCTe.CTe.infCte.dest.fone = Nothing, "", arqXMLCTe.CTe.infCte.dest.fone)
                ClientesDML.CEP = IIf(arqXMLCTe.CTe.infCte.dest.enderDest.CEP = Nothing, "", arqXMLCTe.CTe.infCte.dest.fone)
                If ClientesDML.CNPJ IsNot Nothing Then
                    Dim MineraClientesDAL As New MineraClientesDAL(ClientesDML)
                    MineraClientesDAL.SalvaClientes()
                End If

                'Remetente
                ClientesDML.CNPJ = IIf(arqXMLCTe.CTe.infCte.[rem].Item = Nothing, "", arqXMLCTe.CTe.infCte.[rem].Item)
                ClientesDML.RazaoSocial = IIf(arqXMLCTe.CTe.infCte.[rem].xNome = Nothing, "", arqXMLCTe.CTe.infCte.[rem].xNome)
                ClientesDML.NomeFantasia = IIf(arqXMLCTe.CTe.infCte.[rem].xNome = Nothing, "", arqXMLCTe.CTe.infCte.[rem].xNome)
                ClientesDML.InscricaoEstadual = IIf(arqXMLCTe.CTe.infCte.[rem].IE = Nothing, "", arqXMLCTe.CTe.infCte.[rem].IE)
                ClientesDML.Email = IIf(arqXMLCTe.CTe.infCte.[rem].email = Nothing, "", arqXMLCTe.CTe.infCte.[rem].email)
                ClientesDML.Rua = IIf(arqXMLCTe.CTe.infCte.[rem].enderReme.xLgr = Nothing, "", arqXMLCTe.CTe.infCte.[rem].enderReme.xLgr)
                ClientesDML.Numero = IIf(arqXMLCTe.CTe.infCte.[rem].enderReme.nro = Nothing, "", arqXMLCTe.CTe.infCte.[rem].enderReme.nro)
                ClientesDML.Bairro = IIf(arqXMLCTe.CTe.infCte.[rem].enderReme.xBairro = Nothing, "", arqXMLCTe.CTe.infCte.[rem].enderReme.xBairro)
                ClientesDML.Cidade = IIf(arqXMLCTe.CTe.infCte.[rem].enderReme.xMun = Nothing, "", arqXMLCTe.CTe.infCte.[rem].enderReme.xMun)
                ClientesDML.UF = IIf(arqXMLCTe.CTe.infCte.[rem].enderReme.UF = Nothing, "", arqXMLCTe.CTe.infCte.[rem].enderReme.UF.ToString)
                ClientesDML.Fone = IIf(arqXMLCTe.CTe.infCte.[rem].fone = Nothing, "", arqXMLCTe.CTe.infCte.[rem].fone)
                ClientesDML.CEP = IIf(arqXMLCTe.CTe.infCte.[rem].enderReme.CEP = Nothing, "", arqXMLCTe.CTe.infCte.[rem].fone)
                If ClientesDML.CNPJ IsNot Nothing Then
                    Dim MineraClientesDAL As New MineraClientesDAL(ClientesDML)
                    MineraClientesDAL.SalvaClientes()
                End If
            Next
        End If
        form.pgrProgresso.Value = 0
        MessageBox.Show("Sucesso!", form.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        form.Enabled = True
    End Sub
End Class
