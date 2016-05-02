Public Class ConsultaClientesUIL
    Dim ConsultaClientesBLL As ConsultaClientesBLL
    Private Sub ConsultaClientesUIL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ConsultaClientesBLL = New ConsultaClientesBLL(Me)
            ConsultaClientesBLL.PreencherComboCampoPesquisa()
            ConsultaClientesBLL.PreencherComboTipoPesquisa()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPesquisa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisa.Click
        Try
            ConsultaClientesBLL.ConsultaClientes()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ConsultaClientesUIL_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.Shift = False And e.Control = False And e.Alt = False And e.KeyCode = Keys.F5 Then
                ConsultaClientesBLL.ConsultaClientes()
            ElseIf e.Control = False And e.Shift = False And e.Alt = False And e.KeyCode = Keys.F10 Then
                ConsultaClientesBLL.Exportar()
            ElseIf e.Control = False And e.Shift = False And e.Alt = False And e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
