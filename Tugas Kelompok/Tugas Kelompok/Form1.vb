Public Class Form1
    Private lastClickedPanel As Panel = Nothing
    ' Warna default untuk panel
    Private defaultColor As Color = Color.LightGray
    ' Warna yang ditetapkan saat panel ditekan
    Private clickedColor As Color = Color.LightBlue
    Sub childform(ByVal panel As Form)
        panelOutput.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        panelOutput.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
    Private lastButtonClicked As Button

    Private Sub ChangeButtonColor(ByVal newButton As Button)
        ' Mengembalikan warna tombol sebelumnya menjadi kuning
        If lastButtonClicked IsNot Nothing Then
            lastButtonClicked.BackColor = Color.Yellow
        End If

        ' Mengatur warna tombol baru menjadi hijau
        newButton.BackColor = Color.Green
        ' Memperbarui tombol terakhir yang ditekan
        lastButtonClicked = newButton
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        childform(formMhs)
        ChangeButtonColor(DirectCast(sender, Button))
    End Sub

    Private Sub btnGrafik_Click_1(sender As Object, e As EventArgs) Handles btnGrafik.Click
        childform(formGrafik)
        ChangeButtonColor(DirectCast(sender, Button))
    End Sub

    Private Sub btnInformasi_Click_1(sender As Object, e As EventArgs) Handles btnInformasi.Click
        childform(formInformasi)
        ChangeButtonColor(DirectCast(sender, Button))
    End Sub

    Private Sub btnIjazah_Click_1(sender As Object, e As EventArgs) Handles btnIjazah.Click
        childform(formIjazah2)
        ChangeButtonColor(DirectCast(sender, Button))
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnInput.PerformClick()
    End Sub
End Class
