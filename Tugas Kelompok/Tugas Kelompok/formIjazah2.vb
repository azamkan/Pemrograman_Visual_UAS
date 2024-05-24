Public Class formIjazah2
    Sub childform(ByVal panel As Form)
        panelOutput.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        panelOutput.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        childform(formIjazah)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        childform(formLaporan)
    End Sub

    Private Sub formIjazah2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnCetak.PerformClick()
    End Sub
End Class