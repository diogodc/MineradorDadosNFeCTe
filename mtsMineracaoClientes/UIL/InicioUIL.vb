Public Class InicioUIL
    Private InicioBLL As InicioBLL

    Private Sub InicioUIL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            InicioBLL = New InicioBLL
            openBD()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMinerarClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinerarClientes.Click
        Try
            InicioBLL.CarregaMineraClientes()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscarClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarClientes.Click
        Try
            InicioBLL.CarregaConsultaClientes()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InicioUIL_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.Shift = False And e.Control = False And e.Alt = False And e.KeyCode = Keys.F5 Then
                InicioBLL.CarregaMineraClientes()
            ElseIf e.Control = False And e.Shift = False And e.Alt = False And e.KeyCode = Keys.F10 Then
                InicioBLL.CarregaConsultaClientes()
            ElseIf e.Control = False And e.Shift = False And e.Alt = False And e.KeyCode = Keys.F12 Then
                openBD()
            ElseIf e.Control = False And e.Shift = False And e.Alt = False And e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
