Imports MySql.Data.MySqlClient

Public Class formIpk
    Private Sub formIpk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        TampilIPKPerJurusan()
    End Sub

    Private Sub TampilIPKPerJurusan()
        ' Bersihkan FlowLayoutPanel sebelum menambahkan kontrol baru
        FlowLayoutPanel1.Controls.Clear()

        ' Tambahkan header ke FlowLayoutPanel
        Dim headerPanel As New Panel With {
            .Width = FlowLayoutPanel1.Width - 20,
            .Height = 40,
            .BackColor = Color.LightGray} 'Optional: Change background color for better visibility


        AddHeaderLabel(headerPanel, "No", 10)
        AddHeaderLabel(headerPanel, "Prodi", 50)
        AddHeaderLabel(headerPanel, "Jumlah Mahasiswa", 200)
        AddHeaderLabel(headerPanel, "Rata-Rata IPK", 360)

        FlowLayoutPanel1.Controls.Add(headerPanel)

        ' Query untuk mendapatkan rata-rata IPK per prodi
        Dim query As String = "SELECT prodi, COUNT(*) as JumlahMahasiswa, AVG(ipk) as RataRataIPK FROM tbmhs GROUP BY prodi ORDER BY prodi"
        Dim adapter As New MySqlDataAdapter(query, CONN)
        Dim table As New DataTable()
        adapter.Fill(table)

        Dim rowIndex As Integer = 1
        ' Tambahkan data ke FlowLayoutPanel
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
                .Left = 10,
                .Font = New Font("Arial", 10)
            }

            Dim lblProdi As New Label With {
                .Text = row("prodi").ToString(),
                .AutoSize = True,
                .Top = 10,
                .Left = 50,
                .Font = New Font("Arial", 10)
            }

            Dim lblJlhMhs As New Label With {
                .Text = row("JumlahMahasiswa").ToString(),
                .AutoSize = True,
                .Top = 10,
                .Left = 200,
                .Font = New Font("Arial", 10)
            }

            Dim lblIpk As New Label With {
                .Text = Format(CDbl(row("RataRataIPK")), "0.00"),
                .AutoSize = True,
                .Top = 10,
                .Left = 360,
                .Font = New Font("Arial", 10)
            }

            dataPanel.Controls.Add(lblNo)
            dataPanel.Controls.Add(lblProdi)
            dataPanel.Controls.Add(lblJlhMhs)
            dataPanel.Controls.Add(lblIpk)

            ' Tambahkan panel ke FlowLayoutPanel
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
