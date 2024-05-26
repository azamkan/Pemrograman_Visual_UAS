Imports MySql.Data.MySqlClient

Public Class formLaporan
    Dim selectProdi As String
    Dim predikat As String
    Dim listBoxMhs As New ListBox()

    Private Sub formLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inisialisasi koneksi ke database
        koneksi()
        LoadProdi()
    End Sub

    Private Sub LoadProdi()
        koneksi()
        Dim query As String = "SELECT DISTINCT prodi FROM tbmhs"
        CMD = New MySqlCommand(query, CONN)
        Try
            RD = CMD.ExecuteReader()
            While RD.Read()
                cbProdi.Items.Add(RD("prodi").ToString())
            End While
            RD.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data program studi: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadMhs()
        Dim query As String = "SELECT * FROM tbmhs WHERE prodi = @prodi"
        CMD = New MySqlCommand(query, CONN)
        CMD.Parameters.AddWithValue("@prodi", selectProdi)
        Try
            RD = CMD.ExecuteReader()
            ' Clear existing items
            listBoxMhs.Items.Clear()
            While RD.Read()
                Dim item As String = "NIM: " & RD("nim").ToString() & ", Nama: " & RD("nama").ToString() & ", IPK: " & RD("ipk").ToString() & ", Ulang: " & RD("ulang").ToString()
                listBoxMhs.Items.Add(item)
            End While
            RD.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data mahasiswa: " & ex.Message)
        End Try
    End Sub

    Private Sub cbProdi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProdi.SelectedIndexChanged
        koneksi()
        If cbProdi.SelectedIndex >= 0 Then
            selectProdi = cbProdi.SelectedItem.ToString()
            LoadMhs()
            TampilDataMahasiswa()
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If cbProdi.SelectedIndex = -1 Then
            MsgBox("Mohon Pilih Program Studi Terlebih Dahulu")
        Else
            Dim printDoc As New Printing.PrintDocument()
            AddHandler printDoc.PrintPage, AddressOf Me.printDocument_PrintPage
            Dim printPreview As New PrintPreviewDialog()
            printPreview.Document = printDoc
            printPreview.ShowDialog()
        End If
    End Sub

    Private Sub printDocument_PrintPage(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs)
        Dim fontTitle As New Font("Arial", 16, FontStyle.Bold)
        Dim fontSubTitle As New Font("Arial", 12, FontStyle.Bold)
        Dim fontHeader As New Font("Arial", 10, FontStyle.Bold)
        Dim fontContent As New Font("Arial", 10)
        Dim yPos As Integer = 100
        Dim leftMargin As Integer = e.MarginBounds.Left
        Dim rightMargin As Integer = e.MarginBounds.Right
        Dim lineHeight As Integer = fontContent.GetHeight(e.Graphics)
        Dim headerLineHeight As Integer = fontHeader.GetHeight(e.Graphics)

        ' Print header
        e.Graphics.DrawString("KEMENTERIAN PENDIDIKAN", fontTitle, Brushes.Black, leftMargin + 175, yPos)
        yPos += lineHeight + 10
        e.Graphics.DrawString("UNIVERSITAS MULAWARMAN", fontTitle, Brushes.Black, leftMargin + 168, yPos)
        yPos += lineHeight + 30
        e.Graphics.DrawString("LAPORAN DATA KELULUSAN", fontSubTitle, Brushes.Black, leftMargin + 210, yPos)
        yPos += lineHeight + 5
        e.Graphics.DrawString("PROGRAM STUDI " & selectProdi.ToUpper(), fontSubTitle, Brushes.Black, leftMargin + 195, yPos)
        yPos += lineHeight + 10

        ' Draw horizontal line
        yPos += headerLineHeight / 2
        ' Draw horizontal line
        e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, rightMargin, yPos)
        yPos += headerLineHeight / 2

        ' Print table header
        e.Graphics.DrawString("NIM", fontHeader, Brushes.Black, leftMargin, yPos)
        e.Graphics.DrawString("NAMA", fontHeader, Brushes.Black, leftMargin + 100, yPos)
        e.Graphics.DrawString("PROGRAM STUDI", fontHeader, Brushes.Black, leftMargin + 300, yPos)
        e.Graphics.DrawString("IPK", fontHeader, Brushes.Black, leftMargin + 450, yPos)
        e.Graphics.DrawString("PREDIKAT", fontHeader, Brushes.Black, leftMargin + 500, yPos)
        yPos += lineHeight

        ' Draw horizontal line
        yPos += headerLineHeight / 2
        ' Draw horizontal line
        e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, rightMargin, yPos)
        yPos += headerLineHeight / 2

        ' Print table content
        For Each item In listBoxMhs.Items
            Dim parts() As String = item.ToString().Split(", ")
            Dim nim As String = parts(0).Split(": ")(1).Trim()
            Dim nama As String = parts(1).Split(": ")(1).Trim()
            Dim ipk1 As String = parts(2).Split(": ")(1).Trim()
            Dim ulang As String = parts(3).Split(": ")(1).Trim()

            e.Graphics.DrawString(nim, fontContent, Brushes.Black, leftMargin, yPos)
            e.Graphics.DrawString(nama, fontContent, Brushes.Black, leftMargin + 100, yPos)
            e.Graphics.DrawString(selectProdi, fontContent, Brushes.Black, leftMargin + 300, yPos)
            e.Graphics.DrawString(ipk1, fontContent, Brushes.Black, leftMargin + 450, yPos)

            ' Calculate and print predikat
            Dim ipk = Val(ipk1)
            If ipk = 4.0 AndAlso ulang = "Tidak" Then
                predikat = "Summa Cumlaude"
            ElseIf ipk = 4.0 AndAlso ulang = "Ya" Then
                predikat = "Sangat Memuaskan"
            ElseIf ipk >= 3.79 AndAlso ipk <= 3.99 AndAlso ulang = "Tidak" Then
                predikat = "Magna Cumlaude"
            ElseIf ipk >= 3.79 AndAlso ipk <= 3.99 AndAlso ulang = "Ya" Then
                predikat = "Sangat Memuaskan"
            ElseIf ipk >= 3.5 AndAlso ipk < 3.79 AndAlso ulang = "Tidak" Then
                predikat = "Cumlaude"
            ElseIf ipk >= 3.5 AndAlso ipk < 3.79 AndAlso ulang = "Ya" Then
                predikat = "Sangat Memuaskan"
            ElseIf ipk >= 3.0 AndAlso ulang = "Ya" Then
                predikat = "Memuaskan"
            ElseIf ipk >= 3.0 AndAlso ulang = "Tidak" Then
                predikat = "Memuaskan"
            ElseIf ipk >= 2.75 AndAlso ipk < 3.0 Then
                predikat = "Memuaskan"
            ElseIf ipk >= 2.0 AndAlso ipk <= 2.75 Then
                predikat = "Cukup"
                Exit Sub
            End If

            e.Graphics.DrawString(predikat, fontContent, Brushes.Black, leftMargin + 500, yPos)

            yPos += lineHeight

        Next
        yPos += headerLineHeight / 2
        ' Draw horizontal line
        e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, rightMargin, yPos)
        yPos += headerLineHeight / 2

        ' Print footer
        yPos += 2 * lineHeight
        Dim currentDate As String = DateTime.Now.ToString("dd MMMM yyyy")
        e.Graphics.DrawString("Samarinda, " & currentDate, fontContent, Brushes.Black, rightMargin - 200, yPos)
        yPos += lineHeight
        e.Graphics.DrawString("Mengetahui,", fontContent, Brushes.Black, leftMargin, yPos)
        yPos += lineHeight
        e.Graphics.DrawString("Rektor Universitas Mulawarman", fontContent, Brushes.Black, leftMargin, yPos)
        e.Graphics.DrawString("Dekan Fakultas", fontContent, Brushes.Black, rightMargin - 200, yPos)

        yPos += 5 * lineHeight
        e.Graphics.DrawString("Ahmad Nur Azam", fontContent, Brushes.Black, leftMargin, yPos)
        e.Graphics.DrawString("Muhammad Candra", fontContent, Brushes.Black, rightMargin - 200, yPos)
    End Sub
    Private Sub TampilDataMahasiswa()
        FlowLayoutPanel1.Controls.Clear()

        ' Tambahkan Header
        Dim headerPanel As New Panel With {
        .Width = FlowLayoutPanel1.Width - 20,
        .Height = 40,
        .BackColor = Color.LightGray
    }

        AddHeaderLabel(headerPanel, "No", 20)
        AddHeaderLabel(headerPanel, "NIM", 90)
        AddHeaderLabel(headerPanel, "Nama", 250)
        AddHeaderLabel(headerPanel, "IPK", 480)

        FlowLayoutPanel1.Controls.Add(headerPanel)

        ' Tambahkan Data Mahasiswa
        Dim query As String = "SELECT * FROM tbmhs WHERE prodi = @prodi"
        CMD = New MySqlCommand(query, CONN)
        CMD.Parameters.AddWithValue("@prodi", selectProdi)

        ' Inisialisasi adapter sebelum digunakan
        Dim adapter As New MySqlDataAdapter(CMD)
        Dim table As New DataTable()
        adapter.Fill(table)

        Dim rowIndex As Integer = 1
        For Each row As DataRow In table.Rows
            Dim dataPanel As New Panel With {
            .Width = FlowLayoutPanel1.Width - 20,
            .Height = 40,
            .BorderStyle = BorderStyle.None,
            .BackColor = If(rowIndex Mod 2 = 0, Color.White, Color.LightBlue)
        }

            Dim lblNo As New Label With {
            .Text = rowIndex.ToString(),
            .AutoSize = True,
            .Top = 10,
            .Left = 20,
            .Font = New Font("Arial", 10)
        }

            Dim lblNim As New Label With {
            .Text = row("nim").ToString(),
            .AutoSize = True,
            .Top = 10,
            .Left = 90,
            .Font = New Font("Arial", 10)
        }

            Dim lblNama As New Label With {
            .Text = row("nama").ToString(),
            .AutoSize = True,
            .Top = 10,
            .Left = 250,
            .Font = New Font("Arial", 10)
        }

            Dim lblIpk As New Label With {
            .Text = row("ipk").ToString(),
            .AutoSize = True,
            .Top = 10,
            .Left = 480,
            .Font = New Font("Arial", 10)
        }

            dataPanel.Controls.Add(lblNo)
            dataPanel.Controls.Add(lblNim)
            dataPanel.Controls.Add(lblNama)
            dataPanel.Controls.Add(lblIpk)

            FlowLayoutPanel1.Controls.Add(dataPanel)

            ' Tambahkan garis horizontal di bawah setiap panel data
            Dim line As New Label With {
            .Width = FlowLayoutPanel1.Width - 40,
            .Height = 2,
            .BorderStyle = BorderStyle.Fixed3D,
            .BackColor = Color.Black,
            .Top = dataPanel.Bottom + 2,
            .Left = 10
        }
            FlowLayoutPanel1.Controls.Add(line)

            rowIndex += 1
        Next
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
End Class
