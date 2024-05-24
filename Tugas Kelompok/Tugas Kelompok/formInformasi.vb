Imports System.IO
Imports MySql.Data.MySqlClient

Public Class formInformasi
    Sub childform(ByVal panel As Form)
        panelOutput.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        panelOutput.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub FormKelulusan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        btnInfoIpk.PerformClick()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnInfoIpk.Click
        childform(formInfoIpk)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        childform(formIpk)
    End Sub
End Class
