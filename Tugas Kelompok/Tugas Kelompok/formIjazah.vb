Imports MySql.Data.MySqlClient

Public Class formIjazah
    Dim borderWidth As Integer = 1170 ' Lebar kertas
    Dim borderHeight As Integer = 827 ' Tinggi kertas
    Dim nama, nim, ipk1, jurusan, gelar, predikat As String
    Dim selectProdi As String = ""
    Dim pictureBoxLogo As New PictureBox()
    Dim pictureBoxBorder As New PictureBox()
    Dim ttd As New PictureBox()
    Dim headerPanel As Panel

    Private Sub formIjazah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lineLabel As New Label()
        lineLabel.BorderStyle = BorderStyle.FixedSingle ' Atur gaya garis
        lineLabel.Width = 400 ' Sesuaikan panjang dengan lebar form
        lineLabel.Height = 2 ' Atur ketebalan garis
        lineLabel.BackColor = Color.Black ' Atur warna garis
        lineLabel.Location = New Point(22, 110) ' Atur posisi
        Me.Controls.Add(lineLabel) ' Tambahkan label ke form

        AddHandler PrintDocument1.PrintPage, AddressOf Me.PrintDocument1_PrintPage
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1

        Try
            pictureBoxLogo.Image = Image.FromFile("D:\Data\Documents\Kuliah\S4\PemrogramanVisual\UAS\fromgit\fix1\Pemrograman_Visual_UAS\Tugas Kelompok\Tugas Kelompok\Resources\LogoUnmul-1.png")
            pictureBoxBorder.Image = Image.FromFile("D:\Data\Documents\Kuliah\S4\PemrogramanVisual\UAS\fromgit\fix1\Pemrograman_Visual_UAS\Tugas Kelompok\Tugas Kelompok\Resources\border.png") ' ini border sertifikat
            ttd.Image = Image.FromFile("D:\Data\Documents\Kuliah\S4\PemrogramanVisual\UAS\fromgit\fix1\Pemrograman_Visual_UAS\Tugas Kelompok\Tugas Kelompok\Resources\ttd.png")
        Catch ex As Exception
            MessageBox.Show("Failed to load image.")
        End Try

        ' Load data prodi ke dalam ComboBox
        LoadProdi()
    End Sub

    Private Sub cbProdi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProdi.SelectedIndexChanged
        If cbProdi.SelectedIndex >= 0 Then
            selectProdi = cbProdi.SelectedItem.ToString()
            LoadMhs()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form1.childform(formLaporan)
    End Sub

    Public Sub LoadProdi()
        Try
            koneksi()

            ' Query untuk mendapatkan data prodi
            Dim query As String = "SELECT DISTINCT prodi FROM tbmhs"
            Dim cmd As New MySqlCommand(query, CONN)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Mengisi ComboBox dengan data prodi
            While reader.Read()
                cbProdi.Items.Add(reader("prodi").ToString())
            End While
            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If CONN IsNot Nothing AndAlso CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try
    End Sub
    Public Sub LoadMhs()
        panelProduk.Controls.Clear()
        panelProduk.AutoScroll = True ' Mengaktifkan scroll bar
        panelProduk.FlowDirection = FlowDirection.TopDown ' Mengatur flow direction ke vertikal

        Try
            koneksi()

            ' Query untuk mendapatkan data mahasiswa berdasarkan prodi
            Dim query As String = "SELECT * FROM tbmhs WHERE prodi = @prodi"
            Dim cmd As New MySqlCommand(query, CONN)
            cmd.Parameters.AddWithValue("@prodi", selectProdi)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Tambahkan header ke panelProduk
            Dim headerPanel As New Panel With {
            .Width = panelProduk.Width - 20,
            .Height = 40,
            .BackColor = Color.LightGray} 'Optional: Change background color for better visibility

            AddHeaderLabel(headerPanel, "No", 10)
            AddHeaderLabel(headerPanel, "NIM", 50)
            AddHeaderLabel(headerPanel, "Nama", 200)
            AddHeaderLabel(headerPanel, "IPK", 360)
            AddHeaderLabel(headerPanel, "Aksi", 450)

            panelProduk.Controls.Add(headerPanel)

            Dim rowIndex As Integer = 1
            While reader.Read()
                Dim panelProdukItem As New Panel With {
                .Width = panelProduk.Width - 20,
                .Height = 40,
                .BackColor = If(rowIndex Mod 2 = 0, Color.White, Color.LightBlue),
                .Margin = New Padding(5)
            }

                Dim labelNo As New Label With {
                .Text = rowIndex.ToString(),
                .Font = Font,
                .AutoSize = True,
                .Location = New Point(10, 10)
            }

                Dim labelNim As New Label With {
                .Text = reader("nim").ToString(),
                .Font = Font,
                .AutoSize = True,
                .Location = New Point(50, 10)
            }

                Dim labelNama As New Label With {
                .Text = reader("nama").ToString(),
                .Font = Font,
                .AutoSize = True,
                .Location = New Point(200, 10)
            }

                Dim labelIpk As New Label With {
                .Text = reader("ipk").ToString(),
                .Font = Font,
                .AutoSize = True,
                .Location = New Point(360, 10)
            }

                Dim Cetak As New Button With {
                .Text = "Cetak",
                .Font = Font,
                .Tag = reader("idMhs").ToString(),
                .Size = New Size(75, 30),
                .Location = New Point(450, 5),
                .BackColor = Color.ForestGreen,
                .ForeColor = Color.White
            }
                AddHandler Cetak.Click, AddressOf cetak_Click

                panelProdukItem.Controls.Add(labelNo)
                panelProdukItem.Controls.Add(labelNim)
                panelProdukItem.Controls.Add(labelNama)
                panelProdukItem.Controls.Add(labelIpk)
                panelProdukItem.Controls.Add(Cetak)

                panelProduk.Controls.Add(panelProdukItem)

                ' Tambahkan garis horizontal di bawah setiap panel data
                Dim line As New Label With {
                .Width = panelProduk.Width - 40,
                .Height = 2,
                .BorderStyle = BorderStyle.Fixed3D,
                .BackColor = Color.Black,
                .Location = New Point(10, panelProdukItem.Bottom + 2)
            }
                panelProduk.Controls.Add(line)

                rowIndex += 1
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If CONN IsNot Nothing AndAlso CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try
    End Sub

    Private Sub AddHeaderLabel(panel As Panel, text As String, left As Integer)
        Dim lbl As New Label With {
        .Text = text,
        .AutoSize = True,
        .Top = 10,
        .Left = left,
        .Font = New Font("Arial", 12, FontStyle.Bold)
    }
        panel.Controls.Add(lbl)
    End Sub

    Private Sub cetak_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim idMhs As String = btn.Tag.ToString()
        LoadStudentData(idMhs)
        Dim paperSizeA4 As New Printing.PaperSize("A4", 827, 1170) ' 827 x 1170 pixels = 210 x 297 mm (A4 size)

        ' Set PrintDocument properties
        Me.PrintDocument1.DefaultPageSettings.PaperSize = paperSizeA4
        Me.PrintDocument1.DefaultPageSettings.Landscape = True

        ' Show PrintPreviewDialog
        Me.PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub LoadStudentData(idMhs As String)
        Try
            CONN.Open()
            Dim query As String = "SELECT * FROM tbmhs WHERE idMhs = @idMhs"
            Dim cmd As New MySqlCommand(query, CONN)
            cmd.Parameters.AddWithValue("@idMhs", idMhs)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                nama = reader("nama").ToString()
                nim = reader("nim").ToString()
                ipk1 = reader("ipk").ToString()
                jurusan = reader("prodi").ToString()
                Dim ulang As String = reader("ulang").ToString()

                ' Set gelar berdasarkan jurusan
                Select Case jurusan
                    Case "Informatika"
                        gelar = "SARJANA KOMPUTER (S.Kom.)"
                    Case "Sistem Informasi"
                        gelar = "SARJANA SISTEM INFORMASI (S.Si.)"
                    Case "Teknik Industri"
                        gelar = "SARJANA TEKNIK INDUSTRI (S.T.I.)"
                    Case "Pendidikan Biologi"
                        gelar = "SARJANA PENDIDIKAN (S.Pd.)"
                    Case "Kehutanan"
                        gelar = "SARJANA KEHUTANAN (S.Hut.)"
                    Case "Hukum"
                        gelar = "SARJANA HUKUM (S.H.)"
                    Case "Kedokteran"
                        gelar = "SARJANA KEDOKTERAN (S.Ked.)"
                End Select

                ' Logika untuk menentukan predikat
                Dim ipk = Val(ipk1)
                If ipk = 4.0 AndAlso ulang = "Tidak" Then
                    predikat = "Summa Cumlaude"
                ElseIf ipk = 4.0 AndAlso ulang = "Ya" Then
                    predikat = "Sangat Memuaskan"
                ElseIf ipk >= 3.79 And ipk <= 3.99 AndAlso ulang = "Tidak" Then
                    predikat = "Magna Cumlaude"
                ElseIf ipk >= 3.79 And ipk <= 3.99 AndAlso ulang = "Ya" Then
                    predikat = "Sangat Memuaskan"
                ElseIf ipk >= 3.5 And ipk < 3.79 AndAlso ulang = "Tidak" Then
                    predikat = "Cumlaude"
                ElseIf ipk >= 3.5 And ipk < 3.79 AndAlso ulang = "Ya" Then
                    predikat = "Sangat Memuaskan"
                ElseIf ipk >= 3.0 AndAlso ulang = "Ya" Then
                    predikat = "Memuaskan"
                ElseIf ipk >= 2.75 And ipk < 3.0 Then
                    predikat = "Memuaskan"
                ElseIf ipk >= 2.0 And ipk <= 2.75 Then
                    predikat = "Cukup"
                    Exit Sub
                Else
                    Exit Sub
                End If
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If CONN IsNot Nothing AndAlso CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim f As Font = New Font("Times New Roman", 12, FontStyle.Regular)
        Dim f2 As Font = New Font("Times New Roman", 20, FontStyle.Bold)
        Dim f3 As Font = New Font("Times New Roman", 15, FontStyle.Bold)
        Dim fnama As Font = New Font("Kunstler Script", 40, FontStyle.Bold) ' font nama
        Dim br As SolidBrush = New SolidBrush(Color.Black)
        Dim brNama As SolidBrush = New SolidBrush(Color.DarkGoldenrod)
        Dim brPr As SolidBrush = New SolidBrush(Color.DarkGoldenrod)
        Dim p As Pen = New Pen(Color.Black) ' warna garis

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
        certificateText = nama
        textSize = e.Graphics.MeasureString(certificateText, f)
        textXCentered = (borderWidth - 2 * textSize.Width) / 2 - 50
        e.Graphics.DrawString(certificateText, fnama, brNama, textXCentered, textY)

        textY += (2 * lineHeight)

        textY += 10
        certificateText = "NIM. " + nim
        textSize = e.Graphics.MeasureString(certificateText, f)
        textXCentered = (borderWidth - textSize.Width) / 2
        e.Graphics.DrawString(certificateText, f, br, textXCentered, textY)

        textY += (1.5 * lineHeight)
        certificateText = "Telah menyelesaikan studi dan memenuhi syarat pendidikan Strata Satu Program Studi " + jurusan
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
            e.Graphics.DrawImage(ttd.Image, New Rectangle(xLogo, 550, 80, 80))
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

End Class
