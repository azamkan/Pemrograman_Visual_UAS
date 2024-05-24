Imports MySql.Data.MySqlClient
Imports System.IO

Public Class formInfoIpk
    Dim selectProdi As String = ""
    Dim adapter As MySqlDataAdapter
    Private Sub formInfoIpk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


    Private Sub cbProdi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProdi.SelectedIndexChanged
        If cbProdi.SelectedIndex >= 0 Then
            selectProdi = cbProdi.SelectedItem.ToString()
            TampilDataMahasiswa()
        End If
    End Sub
End Class