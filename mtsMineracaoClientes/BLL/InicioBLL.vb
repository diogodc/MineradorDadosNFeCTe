Public Class InicioBLL
    Public Sub CarregaConsultaClientes()
        Dim ConsultaClientesUIL As New ConsultaClientesUIL
        ConsultaClientesUIL.WindowState = FormWindowState.Maximized
        ConsultaClientesUIL.ShowDialog()
    End Sub

    Public Sub CarregaMineraClientes()
        Dim MineraClientesUIL As New MineraClientesUIL
        MineraClientesUIL.WindowState = FormWindowState.Normal
        MineraClientesUIL.ShowDialog()
    End Sub
End Class
