Imports System.Text
Imports System.Data.SqlClient

Public Class ConsultaClientesDAL
    Private ConsultaDML As ConsultaDML

    Public Sub New(ByVal ConsultaDML As ConsultaDML)
        Me.ConsultaDML = ConsultaDML
    End Sub

    Public Function ConsultaClientes() As DataTable
        Dim sbSql As New StringBuilder
        sbSql.AppendLine(" SELECT ")
        sbSql.AppendLine("	 MINERACAO_CLIENTES.CLIENTE_ID,")
        sbSql.AppendLine("	 MINERACAO_CLIENTES.RAZAOSOCIAL,")
        sbSql.AppendLine("	 MINERACAO_CLIENTES.NOMEFANTASIA,")
        sbSql.AppendLine("	 MINERACAO_CLIENTES.CNPJ,")
        sbSql.AppendLine("	 MINERACAO_CLIENTES.INSCRICAO_ESTADUAL,")
        sbSql.AppendLine("	 MINERACAO_CLIENTES.EMAIL,")
        sbSql.AppendLine("	 MINERACAO_CLIENTES.RUA,")
        sbSql.AppendLine("	 MINERACAO_CLIENTES.NUMERO,")
        sbSql.AppendLine("	 MINERACAO_CLIENTES.BAIRRO,")
        sbSql.AppendLine("	 MINERACAO_CLIENTES.CIDADE,")
        sbSql.AppendLine("	 MINERACAO_CLIENTES.UF,")
        sbSql.AppendLine("	 MINERACAO_CLIENTES.TELEFONE,")
        sbSql.AppendLine("	 MINERACAO_CLIENTES.CEP")
        sbSql.AppendLine(" FROM MINERACAO_CLIENTES ")
        If ConsultaDML.Pesquisa.Trim <> "" Then
            Dim sTipoOperadorIni As String = ""
            Dim sTipoOperadorFim As String = ""
            If ConsultaDML.TipoPesquisa = 0 Then
                sTipoOperadorIni = "LIKE '"
                sTipoOperadorFim = "%'"
            Else
                sTipoOperadorIni = "LIKE '%"
                sTipoOperadorFim = "%'"
            End If
            sbSql.AppendLine(" WHERE ")
            If ConsultaDML.CampoPesquisa = 0 Then
                sbSql.AppendLine(" MINERACAO_CLIENTES.CLIENTE_ID " & sTipoOperadorIni & ConsultaDML.Pesquisa & sTipoOperadorFim)
            ElseIf ConsultaDML.CampoPesquisa = 1 Then
                sbSql.AppendLine(" MINERACAO_CLIENTES.RAZAOSOCIAL " & sTipoOperadorIni & ConsultaDML.Pesquisa & sTipoOperadorFim)
            ElseIf ConsultaDML.CampoPesquisa = 2 Then
                sbSql.AppendLine(" MINERACAO_CLIENTES.NOMEFANTASIA " & sTipoOperadorIni & ConsultaDML.Pesquisa & sTipoOperadorFim)
            ElseIf ConsultaDML.CampoPesquisa = 3 Then
                sbSql.AppendLine(" MINERACAO_CLIENTES.CNPJ " & sTipoOperadorIni & ConsultaDML.Pesquisa & sTipoOperadorFim)
            ElseIf ConsultaDML.CampoPesquisa = 4 Then
                sbSql.AppendLine(" MINERACAO_CLIENTES.INSCRICAO_ESTADUAL " & sTipoOperadorIni & ConsultaDML.Pesquisa & sTipoOperadorFim)
            ElseIf ConsultaDML.CampoPesquisa = 5 Then
                sbSql.AppendLine(" MINERACAO_CLIENTES.EMAIL " & sTipoOperadorIni & ConsultaDML.Pesquisa & sTipoOperadorFim)
            ElseIf ConsultaDML.CampoPesquisa = 6 Then
                sbSql.AppendLine(" MINERACAO_CLIENTES.RUA " & sTipoOperadorIni & ConsultaDML.Pesquisa & sTipoOperadorFim)
            ElseIf ConsultaDML.CampoPesquisa = 7 Then
                sbSql.AppendLine(" MINERACAO_CLIENTES.NUMERO " & sTipoOperadorIni & ConsultaDML.Pesquisa & sTipoOperadorFim)
            ElseIf ConsultaDML.CampoPesquisa = 8 Then
                sbSql.AppendLine(" MINERACAO_CLIENTES.BAIRRO " & sTipoOperadorIni & ConsultaDML.Pesquisa & sTipoOperadorFim)
            ElseIf ConsultaDML.CampoPesquisa = 9 Then
                sbSql.AppendLine(" MINERACAO_CLIENTES.CIDADE " & sTipoOperadorIni & ConsultaDML.Pesquisa & sTipoOperadorFim)
            ElseIf ConsultaDML.CampoPesquisa = 10 Then
                sbSql.AppendLine(" MINERACAO_CLIENTES.UF " & sTipoOperadorIni & ConsultaDML.Pesquisa & sTipoOperadorFim)
            ElseIf ConsultaDML.CampoPesquisa = 11 Then
                sbSql.AppendLine(" MINERACAO_CLIENTES.TELEFONE " & sTipoOperadorIni & ConsultaDML.Pesquisa & sTipoOperadorFim)
            ElseIf ConsultaDML.CampoPesquisa = 12 Then
                sbSql.AppendLine(" MINERACAO_CLIENTES.CEP " & sTipoOperadorIni & ConsultaDML.Pesquisa & sTipoOperadorFim)
            End If
        End If

        Dim cmd As New SqlCommand(sbSql.ToString, conn)

        Dim dataAdapter As New SqlDataAdapter(cmd)
        Dim dataTable As New DataTable

        dataAdapter.Fill(dataTable)

        Return dataTable
        
    End Function
    
End Class
