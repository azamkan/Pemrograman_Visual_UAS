Imports MySql.Data.MySqlClient
Imports System.IO

Public Class formMhs
    Dim mahasiswaList As DataTable
    Dim currentIndex As Integer
    Dim gambarPath As String = ""
    Public idMhs As String = "" ' Pastikan idMhs public jika diakses dari formEdit

    ' Method untuk mengisi data mahasiswa ke kontrol
    Public Sub IsiDataMahasiswa(ByVal row As DataRow)
        koneksi()
        idMhs = row("idMhs").ToString()
        lblNama.Text = row("nama").ToString()
        lblNim.Text = row("nim").ToString()
        lblProdi.Text = row("prodi").ToString()
        lblIpk.Text = row("ipk").ToString()
        lblJk.Text = row("kelamin").ToString()
        lblUlang.Text = row("ulang").ToString()

        ' Load gambar
        Dim gambar As String = row("gambar").ToString()
        If Not String.IsNullOrEmpty(gambar) Then
            PictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, gambar))
            gambarPath = gambar
        End If

        ' Update combobox selection
        If cbMhs.Items.Contains(row("nama").ToString()) Then
            cbMhs.SelectedItem = row("nama").ToString()
        End If
    End Sub

    ' Method untuk inisialisasi data mahasiswa
    Public Sub InisialisasiMahasiswa()
        koneksi()
        mahasiswaList = New DataTable()
        Dim query As String = "SELECT * FROM tbmhs ORDER BY idMhs ASC"
        CMD = New MySqlCommand(query, CONN)
        Dim adapter As New MySqlDataAdapter(CMD)
        adapter.Fill(mahasiswaList)
        If mahasiswaList.Rows.Count > 0 Then
            currentIndex = 0
            IsiDataMahasiswa(mahasiswaList.Rows(currentIndex))
        End If
    End Sub

    ' Event handler untuk tombol "Previous"
    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        koneksi()
        If currentIndex > 0 Then
            currentIndex -= 1
            IsiDataMahasiswa(mahasiswaList.Rows(currentIndex))
        End If
    End Sub

    ' Event handler untuk tombol "Next"
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        koneksi()
        If currentIndex < mahasiswaList.Rows.Count - 1 Then
            currentIndex += 1
            IsiDataMahasiswa(mahasiswaList.Rows(currentIndex))
        End If
    End Sub

    ' Method untuk menampilkan daftar mahasiswa ke combobox
    Sub tampilMhs()
        koneksi()
        cbMhs.Items.Clear()
        Dim query As String = "SELECT nama FROM tbmhs"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()
        While RD.Read()
            cbMhs.Items.Add(RD("nama").ToString())
        End While
        RD.Close()
    End Sub

    ' Event handler untuk perubahan pilihan pada combobox
    Private Sub cbMhs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMhs.SelectedIndexChanged
        koneksi()
        If cbMhs.SelectedIndex >= 0 Then
            Try
                Dim selectedName As String = cbMhs.SelectedItem.ToString()
                Dim query As String = "SELECT * FROM tbmhs WHERE nama = @nama"
                CMD = New MySqlCommand(query, CONN)
                CMD.Parameters.AddWithValue("@nama", selectedName)
                RD = CMD.ExecuteReader()
                If RD.HasRows Then
                    RD.Read()
                    Dim row As DataRow = mahasiswaList.NewRow()
                    row("idMhs") = RD("idMhs")
                    row("nama") = RD("nama")
                    row("nim") = RD("nim")
                    row("prodi") = RD("prodi")
                    row("ipk") = RD("ipk")
                    row("kelamin") = RD("kelamin")
                    row("ulang") = RD("ulang")
                    row("gambar") = RD("gambar")
                    IsiDataMahasiswa(row)
                End If
                RD.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub formMhs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilMhs()
        InisialisasiMahasiswa()
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Form1.childform(formInput)
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        koneksi()
        formEdit.idMhs = idMhs
        formEdit.InisialisasiMahasiswa()
        Form1.childform(formEdit)
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim result As DialogResult = MessageBox.Show("Anda yakin ingin menghapus data mahasiswa?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Dim query As String = "DELETE FROM tbmhs WHERE idMhs = @idMhs"
            CMD = New MySqlCommand(query, CONN)
            CMD.Parameters.AddWithValue("@idMhs", idMhs)
            CMD.ExecuteNonQuery()
            MsgBox("Hapus Data Berhasil!", MessageBoxIcon.Information)
        End If
        InisialisasiMahasiswa()
        tampilMhs()
    End Sub
End Class
