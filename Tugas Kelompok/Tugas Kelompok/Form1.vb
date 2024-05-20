Public Class Form1

    Dim borderWidth As Integer = 1170 ' Lebar kertas
    Dim borderHeight As Integer = 827 ' Tinggi kertas
    Dim jurusan, gelar, predikat As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler PrintDocument1.PrintPage, AddressOf Me.printDocument1_PrintPage
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        'logo
        Try
            PictureBoxLogo.Image = Image.FromFile("D:\Data\Documents\Kuliah\S4\PemrogramanVisual\Tugas Kelompok\Tugas Kelompok\Tugas Kelompok\Resources\LogoUnmul-1.png")
            PictureBoxBorder.Image = Image.FromFile("D:\Data\Documents\Kuliah\S4\PemrogramanVisual\Tugas Kelompok\Tugas Kelompok\Tugas Kelompok\Resources\border.png") ' ini border sertifikat
            ttd.Image = Image.FromFile("D:\Data\Documents\Kuliah\S4\PemrogramanVisual\Tugas Kelompok\Tugas Kelompok\Tugas Kelompok\Resources\ttd.png")
        Catch ex As Exception
            MessageBox.Show("Failed to load image.")
        End Try
    End Sub
    Sub Kosong()
        txtNama.Clear()
        txtIpk.Clear()
        cmbJurusan.Text = ""
        Ya.Checked = False
        Tidak.Checked = False
        txtNama.Focus()
    End Sub

    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Dim f As Font = New Font("Times New Roman", 12, FontStyle.Regular)
        Dim f2 As Font = New Font("Times New Roman", 20, FontStyle.Bold)
        Dim f3 As Font = New Font("Times New Roman", 15, FontStyle.Bold)
        Dim fnama As Font = New Font("Kunstler Script", 40, FontStyle.Bold) ' font nama
        Dim br As SolidBrush = New SolidBrush(Color.Black)
        Dim brNama As SolidBrush = New SolidBrush(Color.DarkGoldenrod)
        Dim brPr As SolidBrush = New SolidBrush(Color.DarkGoldenrod)
        Dim p As Pen = New Pen(Color.Black) ' warna garis

        jurusan = cmbJurusan.Text

        If jurusan = "Informatika" Then
            gelar = "SARJANA KOMPUTER (S.Kom.)"
        ElseIf jurusan = "Sistem Informasi" Then
            gelar = "SARJANA SISTEM INFORMASI (S.Si.)"
        ElseIf jurusan = "Teknik Industri" Then
            gelar = "SARJANA TEKNIK INDUSTRI (S.T.I.)"
        ElseIf jurusan = "Pendidikan Biologi" Then
            gelar = "SARJANA PENDIDIKAN (S.Pd.)"
        ElseIf jurusan = "Kehutanan" Then
            gelar = "SARJANA KEHUTANAN (S.Hut.)"
        ElseIf jurusan = "Hukum" Then
            gelar = "SARJANA HUKUM (S.H.)"
        ElseIf jurusan = "Kedokteran" Then
            gelar = "SARJANA KEDOKTERAN (S.Ked.)"
        End If

        Dim ipk = Val(txtIpk.Text)
        If ipk = 4.0 And Tidak.Checked Then
            predikat = "Summa Cumlaude"
        ElseIf ipk = 4.0 And Ya.Checked Then
            predikat = "Sangat Memuaskan"
        ElseIf ipk >= 3.79 And ipk <= 3.99 And Tidak.Checked Then
            predikat = "Magna Cumlaude"
        ElseIf ipk >= 3.79 And ipk <= 3.99 And Ya.Checked Then
            predikat = "Sangat Memuaskan"
        ElseIf ipk >= 3.5 And ipk < 3.79 And Tidak.Checked Then
            predikat = "Cumlaude"
        ElseIf ipk >= 3.5 And ipk < 3.79 And Ya.Checked Then
            predikat = "Sangat Memuaskan"
        ElseIf ipk > 3.5 And Ya.Checked Then
            predikat = "Memuaskan"
        ElseIf ipk >= 2.75 And ipk < 3.0 Then
            predikat = "Memuaskan"
        ElseIf ipk >= 2.0 And ipk <= 2.75 Then
            predikat = "Cukup"
        ElseIf ipk < 2.0 Then
            MessageBox.Show("Ipk Kurang")
        Else
            MessageBox.Show("Masukkan IPK yang valid.")
        End If

        Dim tanggal As Date = DateTimePicker1.Value
        Dim formattedDate As String = tanggal.ToString("dd MMMM yyyy")


        ' Draw border
        If PictureBoxBorder.Image IsNot Nothing Then
            e.Graphics.DrawImage(PictureBoxBorder.Image, New Rectangle(0, 0, borderWidth, borderHeight))
        End If

        Dim textY As Integer = 120 ' Posisi awal y untuk teks sertifikat
        Dim lineHeight As Integer = 25

        ' Draw logo
        If PictureBoxLogo.Image IsNot Nothing Then
            Dim xLogo As Integer = (borderWidth - 100) / 2
            e.Graphics.DrawImage(PictureBoxLogo.Image, New Rectangle(xLogo, textY, 100, 100))
        End If

        ' Draw certificate content...
        textY += (4.5 * lineHeight)
        Dim certificateText As String = "S E R T I F I K A T"
        Dim textSize As SizeF = e.Graphics.MeasureString(certificateText, f)
        Dim textXCentered As Integer = (borderWidth - 1.8 * textSize.Width) / 2
        e.Graphics.DrawString(certificateText, f2, br, textXCentered, textY)

        textY += 1.5 * lineHeight
        certificateText = "KELULUSAN"
        textSize = e.Graphics.MeasureString(certificateText, f)
        textXCentered = (borderWidth - textSize.Width) / 2
        e.Graphics.DrawString(certificateText, f, br, textXCentered, textY)

        textY += lineHeight
        certificateText = "menyatakan bahwa"
        textSize = e.Graphics.MeasureString(certificateText, f)
        textXCentered = (borderWidth - textSize.Width) / 2
        e.Graphics.DrawString(certificateText, f, br, textXCentered, textY)

        textY += (1.5 * lineHeight)
        certificateText = txtNama.Text
        textSize = e.Graphics.MeasureString(certificateText, f)
        textXCentered = (borderWidth - 2 * textSize.Width) / 2 - 50
        e.Graphics.DrawString(certificateText, fnama, brNama, textXCentered, textY)

        textY += (2 * lineHeight)

        textY += 10
        certificateText = "NIM. " + txtNim.Text
        textSize = e.Graphics.MeasureString(certificateText, f)
        textXCentered = (borderWidth - textSize.Width) / 2
        e.Graphics.DrawString(certificateText, f, br, textXCentered, textY)

        textY += (1.5 * lineHeight)
        certificateText = "Telah menyelesaikan studi dan memenuhi syarat pendidikan Strata Satu Program Studi " + jurusan
        textSize = e.Graphics.MeasureString(certificateText, f)
        textXCentered = (borderWidth - textSize.Width) / 2
        e.Graphics.DrawString(certificateText, f, br, textXCentered, textY)

        textY += lineHeight
        certificateText = "Lulus pada tanggal " + formattedDate
        textSize = e.Graphics.MeasureString(certificateText, f)
        textXCentered = (borderWidth - textSize.Width) / 2
        e.Graphics.DrawString(certificateText, f, br, textXCentered, textY)

        textY += lineHeight
        certificateText = "Oleh sebab itu, kepadanya diberikan gelar"
        textSize = e.Graphics.MeasureString(certificateText, f)
        textXCentered = (borderWidth - textSize.Width) / 2
        e.Graphics.DrawString(certificateText, f, br, textXCentered, textY)

        textY += lineHeight
        certificateText = gelar
        textSize = e.Graphics.MeasureString(certificateText, f)
        textXCentered = (borderWidth - 1.8 * textSize.Width) / 2
        e.Graphics.DrawString(certificateText, f2, br, textXCentered, textY)

        textY += (1.5 * lineHeight)
        certificateText = "Predikat " + predikat
        textSize = e.Graphics.MeasureString(certificateText, f)
        textXCentered = (borderWidth - textSize.Width) / 2 - 25
        e.Graphics.DrawString(certificateText, f3, brPr, textXCentered, textY)

        textY += (3 * lineHeight)
        If ttd.Image IsNot Nothing Then
            Dim xLogo As Integer = (borderWidth - 100) / 2
            e.Graphics.DrawImage(ttd.Image, New Rectangle(xLogo, 575, 80, 80))
        End If

        textY += lineHeight
        Dim lineX1 As Integer = (borderWidth - 200) / 2
        Dim lineX2 As Integer = (borderWidth + 200) / 2
        e.Graphics.DrawLine(p, lineX1, textY, lineX2, textY)

        textY += 10
        certificateText = "Ahmad Nur Azam"
        textSize = e.Graphics.MeasureString(certificateText, f)
        textXCentered = (borderWidth - textSize.Width) / 2
        e.Graphics.DrawString(certificateText, f, br, textXCentered, textY)

        textY += lineHeight
        certificateText = "Rektor Universitas Mulawarman"
        textSize = e.Graphics.MeasureString(certificateText, f)
        textXCentered = (borderWidth - textSize.Width) / 2
        e.Graphics.DrawString(certificateText, f, br, textXCentered, textY)
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        If txtNama.Text = "" Or txtIpk.Text = "" Or cmbJurusan.Text = "" Or (Not Ya.Checked And Not Tidak.Checked) Then
            MsgBox("Data belum lengkap!")
        Else
            Dim paperSizeA4 As New Printing.PaperSize("A4", 827, 1170) ' 827 x 1170 pixels = 210 x 297 mm (A4 size)

            ' Set PrintDocument properties
            Me.PrintDocument1.DefaultPageSettings.PaperSize = paperSizeA4
            Me.PrintDocument1.DefaultPageSettings.Landscape = True

            ' Show PrintPreviewDialog
            Me.PrintPreviewDialog1.ShowDialog()
        End If
    End Sub

    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        Dim tombol As Integer = Asc(e.KeyChar)
        If Not (((tombol >= 65) And (tombol <= 90)) Or ((tombol >= 97) And
       (tombol <= 122)) Or (tombol = 8) Or (tombol = 32) Or (tombol = 46)) Then
            e.Handled = True
        End If
    End Sub
    Public Sub HanyaAngka(e As KeyPressEventArgs)
        Dim tombol As Integer = Asc(e.KeyChar)
        If Not (((tombol >= 48) And (tombol <= 57)) Or (tombol = 8)) Then
            e.Handled = True
        End If
    End Sub

    Public Sub khususipk(e As KeyPressEventArgs)
        Dim tombol As Integer = Asc(e.KeyChar)
        If Not (((tombol >= 48) And (tombol <= 57)) Or (tombol = 8) Or (tombol = 46)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtNim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNim.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Kosong()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub txtIpk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIpk.KeyPress
        khususipk(e)
    End Sub
End Class
