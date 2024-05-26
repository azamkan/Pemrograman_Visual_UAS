Imports System.IO
Imports MySql.Data.MySqlClient

Public Class formEdit
    Dim mahasiswaList As DataTable
    Dim currentIndex As Integer
    Dim gambarPath As String = ""
    Public idMhs As String = ""

    ' Method untuk mengisi data mahasiswa ke kontrol
    Public Sub IsiDataMahasiswa(ByVal row As DataRow)
        idMhs = row("idMhs").ToString() ' Misalnya, Anda menggunakan Label untuk menyimpan ID
        txtNama.Text = row("nama").ToString()
        txtNim.Text = row("nim").ToString()
        cmbJurusan.Text = row("prodi").ToString()
        txtIpk.Text = row("ipk").ToString()

        If row("kelamin").ToString() = "Laki - Laki" Then
            lk.Checked = True
        Else
            pr.Checked = True
        End If

        If row("ulang").ToString() = "Ya" Then
            Ya.Checked = True
        Else
            Tidak.Checked = True
        End If

        ' Load gambar
        Dim gambar As String = row("gambar").ToString()
        If Not String.IsNullOrEmpty(gambar) Then
            PictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, gambar))
            gambarPath = gambar
        End If
    End Sub

    ' Method untuk inisialisasi data mahasiswa
    Public Sub InisialisasiMahasiswa()
        Dim query As String = "SELECT * FROM tbmhs WHERE idMhs = @idMhs"
        CMD = New MySqlCommand(query, CONN)
        CMD.Parameters.AddWithValue("@idMhs", idMhs)
        Dim adapter As New MySqlDataAdapter(CMD)
        Dim mahasiswaList As New DataTable()
        adapter.Fill(mahasiswaList)

        ' Jika ada data mahasiswa, isi kontrol dengan data tersebut
        If mahasiswaList.Rows.Count > 0 Then
            IsiDataMahasiswa(mahasiswaList.Rows(0))
        End If
    End Sub
    Private Sub CopyImageToFolder(sourcePath As String, folderName As String)
        Try
            ' Pastikan file gambar sumber ada
            If File.Exists(sourcePath) Then
                ' Mendapatkan path folder tujuan
                Dim destinationFolder As String = Path.Combine(Application.StartupPath, folderName)

                ' Pastikan folder tujuan ada, jika belum, buat folder baru
                If Not Directory.Exists(destinationFolder) Then
                    Directory.CreateDirectory(destinationFolder)
                End If

                ' Mendapatkan nama file dari path sumber
                Dim fileName As String = Path.GetFileName(sourcePath)

                ' Mendapatkan path tujuan
                Dim destinationPath As String = Path.Combine(destinationFolder, fileName)

                ' Melakukan kopi file
                File.Copy(sourcePath, destinationPath, True)
            End If
        Catch ex As Exception
            'MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub formEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        formEdit_Load(Nothing, Nothing)
        idMhs = ""
        formMhs.idMhs = ""
        Form1.childform(formMhs)
    End Sub

    Private Sub btnSimpan_Click_1(sender As Object, e As EventArgs) Handles btnSimpan.Click
        koneksi()
        If txtNama.Text = "" OrElse txtNim.Text = "" OrElse cmbJurusan.Text = "" OrElse txtIpk.Text = "" Then
            MsgBox("Data belum lengkap", MessageBoxIcon.Warning)
        ElseIf Not (lk.Checked Or pr.Checked) Then
            MsgBox("Pilih jenis produk", MessageBoxIcon.Warning)
        ElseIf Not (Ya.Checked Or Tidak.Checked) Then
            MsgBox("Pilih jenis produk", MessageBoxIcon.Warning)
        ElseIf String.IsNullOrEmpty(gambarPath) Then
            MsgBox("Pilih gambar produk", MessageBoxIcon.Warning)
        Else
            If Not String.IsNullOrEmpty(gambarPath) AndAlso Not gambarPath.StartsWith(Application.StartupPath) Then
                CopyImageToFolder(gambarPath, "GambarMhs")
            End If

            ' Tentukan jenis produk berdasarkan checkbox yang dipilih
            Dim jenisKelamin As String
            If lk.Checked Then
                jenisKelamin = lk.Text
            Else
                jenisKelamin = pr.Text
            End If

            Dim pernahUlang As String
            If lk.Checked Then
                pernahUlang = Ya.Text
            Else
                pernahUlang = Tidak.Text
            End If

            ' Dapatkan path relatif gambar
            Dim gambarPathRelatif As String = Path.Combine("GambarMhs", Path.GetFileName(gambarPath))

            Try
                ' Simpan data produk ke database
                CMD = New MySqlCommand("UPDATE tbmhs SET nama = @nama, nim = @nim, kelamin = @kelamin, ulang = @ulang, prodi = @prodi, ipk = @ipk, gambar = @gambar WHERE idMhs = @idMhs", CONN)
                CMD.Parameters.AddWithValue("@nama", txtNama.Text)
                CMD.Parameters.AddWithValue("@nim", txtNim.Text)
                CMD.Parameters.AddWithValue("@kelamin", If(lk.Checked, lk.Text, pr.Text))
                CMD.Parameters.AddWithValue("@ulang", If(Ya.Checked, Ya.Text, Tidak.Text))
                CMD.Parameters.AddWithValue("@prodi", cmbJurusan.Text)
                CMD.Parameters.AddWithValue("@ipk", txtIpk.Text)
                CMD.Parameters.AddWithValue("@gambar", gambarPathRelatif) ' pastikan gambarPathRelatif sudah diatur sebelumnya
                CMD.Parameters.AddWithValue("@idMhs", idMhs) ' idMhs harus sesuai dengan ID yang ingin diperbarui
                CMD.ExecuteNonQuery()

                MsgBox("Simpan Data Berhasil!", MessageBoxIcon.Information)

                ' Kosongkan textbox setelah penyimpanan
                InisialisasiMahasiswa()
                formEdit_Load(Nothing, Nothing)
                formMhs.InisialisasiMahasiswa()
                formMhs.tampilMhs()
                Form1.childform(formMhs)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                CONN.Close()
            End Try
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        ' Tampilkan dialog untuk memilih gambar
        Dim dialog As New OpenFileDialog()
        dialog.Filter = "File Gambar (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif"

        If dialog.ShowDialog() = DialogResult.OK Then
            ' Simpan path gambar yang dipilih dalam variabel
            gambarPath = dialog.FileName
            PictureBox1.Image = Image.FromFile(gambarPath)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Form1.childform(formMhs)
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

    Private Sub txtNama_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtNim_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles txtNim.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub txtIpk_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles txtIpk.KeyPress
        khususipk(e)
    End Sub
End Class