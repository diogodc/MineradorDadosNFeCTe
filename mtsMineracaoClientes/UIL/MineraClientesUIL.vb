Public Class MineraClientesUIL

    Private MineraClientesBLL As MineraClientesBLL

    Private Sub MineraClientesUIL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            MineraClientesBLL = New MineraClientesBLL(Me)
            MineraClientesBLL.PreencherCombo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnProcCamXml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcCamXml.Click
        Try
            MineraClientesBLL.ProcuraArquivo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMinerarClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinerarClientes.Click
        Try
            MineraClientesBLL.MinerarClientes()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MineraClientesUIL_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.Shift = False And e.Control = False And e.Alt = False And e.KeyCode = Keys.F5 Then
                MineraClientesBLL.MinerarClientes()
            ElseIf e.Shift = False And e.Control = False And e.Alt = False And e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
