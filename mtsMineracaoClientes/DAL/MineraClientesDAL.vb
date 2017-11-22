Imports System.Text
Imports System.Data.SqlClient

Public Class MineraClientesDAL
    Private ClientesDML As ClientesDML

    Public Sub New(ByVal ClientesDML As ClientesDML)
        Me.ClientesDML = ClientesDML
    End Sub

    Public Function SalvaClientes() As Boolean
        Try
            Dim sbSql As New StringBuilder
            sbSql.AppendLine(" IF NOT EXISTS (SELECT MINERACAO_CLIENTES.CNPJ FROM MINERACAO_CLIENTES WHERE MINERACAO_CLIENTES.CNPJ = @CNPJ) ")
            sbSql.AppendLine(" BEGIN ")
            sbSql.AppendLine(" 	INSERT INTO	MINERACAO_CLIENTES ")
            sbSql.AppendLine(" 	        ( RAZAOSOCIAL , ")
            sbSql.AppendLine(" 	          NOMEFANTASIA , ")
            sbSql.AppendLine(" 	          CNPJ , ")
            sbSql.AppendLine(" 	          INSCRICAO_ESTADUAL , ")
            sbSql.AppendLine(" 	          EMAIL , ")
            sbSql.AppendLine(" 	          RUA , ")
            sbSql.AppendLine(" 	          NUMERO , ")
            sbSql.AppendLine(" 	          BAIRRO , ")
            sbSql.AppendLine(" 	          CIDADE , ")
            sbSql.AppendLine(" 	          UF, ")
            sbSql.AppendLine(" 	          CEP, ")
            sbSql.AppendLine(" 	          TELEFONE ")
            sbSql.AppendLine(" 	        ) ")
            sbSql.AppendLine(" 	VALUES ")
            sbSql.AppendLine(" 	        ( @RAZAOSOCIAL ,")
            sbSql.AppendLine(" 	          @NOMEFANTASIA ,")
            sbSql.AppendLine(" 	          @CNPJ ,")
            sbSql.AppendLine(" 	          @INSCRICAO_ESTADUAL , ")
            sbSql.AppendLine(" 	          @EMAIL , ")
            sbSql.AppendLine(" 	          @RUA , ")
            sbSql.AppendLine(" 	          @NUMERO ,")
            sbSql.AppendLine(" 	          @BAIRRO ,")
            sbSql.AppendLine(" 	          @CIDADE , ")
            sbSql.AppendLine(" 	          @UF,")
            sbSql.AppendLine(" 	          @CEP,")
            sbSql.AppendLine(" 	          @TELEFONE ")
            sbSql.AppendLine(" 	        ) ")
            sbSql.AppendLine(" END ")

            Dim cmd As New SqlCommand(sbSql.ToString, conn)
            cmd.Parameters.AddWithValue("@RAZAOSOCIAL", ClientesDML.RazaoSocial)
            cmd.Parameters.AddWithValue("@NOMEFANTASIA", ClientesDML.NomeFantasia)
            cmd.Parameters.AddWithValue("@CNPJ", ClientesDML.CNPJ.ToString)
            cmd.Parameters.AddWithValue("@INSCRICAO_ESTADUAL", ClientesDML.InscricaoEstadual)
            cmd.Parameters.AddWithValue("@EMAIL", ClientesDML.Email)
            cmd.Parameters.AddWithValue("@RUA", ClientesDML.Rua)
            cmd.Parameters.AddWithValue("@NUMERO", ClientesDML.Numero)
            cmd.Parameters.AddWithValue("@BAIRRO", ClientesDML.Bairro)
            cmd.Parameters.AddWithValue("@CIDADE", ClientesDML.Cidade)
            cmd.Parameters.AddWithValue("@UF", ClientesDML.UF)
            cmd.Parameters.AddWithValue("@CEP", ClientesDML.CEP)
            cmd.Parameters.AddWithValue("@TELEFONE", ClientesDML.Fone)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
        
    End Function
    
End Class
