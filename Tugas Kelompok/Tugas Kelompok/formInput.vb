Imports System.Drawing.Printing
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class formInput
    Dim gambarPath As String = ""
    Dim idMhs As Integer
    Dim ipk As Decimal '= Val(txtIpk)
    Private Sub fromInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub
    Private Sub btnPilihGambar_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
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
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        koneksi()
        Decimal.TryParse(txtIpk.Text, ipk)
        If txtNama.Text = "" OrElse txtNim.Text = "" OrElse cmbJurusan.Text = "" OrElse txtIpk.Text = "" Then
            MsgBox("Data belum lengkap", MessageBoxIcon.Warning)
        ElseIf Not (lk.Checked Or pr.Checked) Then
            MsgBox("Pilih jenis produk", MessageBoxIcon.Warning)
        ElseIf Not (Ya.Checked Or Tidak.Checked) Then
            MsgBox("Pilih jenis produk", MessageBoxIcon.Warning)
        ElseIf String.IsNullOrEmpty(gambarPath) Then
            MsgBox("Pilih Foto Mahasiswa", MessageBoxIcon.Warning)
        ElseIf ipk < 2.0 Then
            MessageBox.Show("IPK Kurang")
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
                CMD = New MySqlCommand("INSERT INTO tbmhs (nama, nim, kelamin, ulang, prodi, ipk, gambar) VALUES (@nama, @nim, @kelamin, @ulang, @prodi, @ipk, @gambar)", CONN)
                CMD.Parameters.AddWithValue("@nama", txtNama.Text)
                CMD.Parameters.AddWithValue("@nim", txtNim.Text)
                CMD.Parameters.AddWithValue("@kelamin", jenisKelamin)
                CMD.Parameters.AddWithValue("@ulang", pernahUlang)
                CMD.Parameters.AddWithValue("@prodi", cmbJurusan.Text)
                CMD.Parameters.AddWithValue("@ipk", txtIpk.Text)
                CMD.Parameters.AddWithValue("@gambar", gambarPathRelatif)
                CMD.ExecuteNonQuery()

                MsgBox("Simpan Data Berhasil!", MessageBoxIcon.Information)

                ' Kosongkan textbox setelah penyimpanan
                Kosong()
                formMhs.tampilMhs()
                formMhs.InisialisasiMahasiswa()
                Form1.childform(formMhs)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                CONN.Close()
            End Try
        End If
    End Sub
    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        Dim tombol As Integer = Asc(e.KeyChar)
        If Not (((tombol >= 65) And (tombol <= 90)) Or ((tombol >= 97) And (tombol <= 122)) Or (tombol = 8) Or (tombol = 32) Or (tombol = 46)) Then
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

    'Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    HanyaHuruf(e)
    'End Sub
    'Private Sub txtNim_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    HanyaAngka(e)
    'End Sub
    'Private Sub txtIpk_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    khususipk(e)
    'End Sub
    Sub Kosong()
        txtNama.Clear()
        txtIpk.Clear()
        cmbJurusan.SelectedIndex = -1
        Ya.Checked = False
        Tidak.Checked = False
        lk.Checked = False
        pr.Checked = False
        PictureBox1.Image = Nothing ' Menghapus gambar pada PictureBox
        gambarPath = ""
        txtNim.Clear()
        txtNama.Focus()
    End Sub
    Public Function GetFirstIdMhs() As Integer
        koneksi()
        Dim idMhs As Integer = -1
        Try
            Dim query As String = "SELECT idMhs FROM tbmhs ORDER BY idMhs ASC LIMIT 1" ' Mengambil idMhs terkecil
            CMD = New MySqlCommand(query, CONN)
            Dim reader As MySqlDataReader = CMD.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                idMhs = Convert.ToInt32(reader("idMhs"))
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CONN.Close()
        End Try
        Return idMhs
    End Function
    Private Sub btnEdit_Click(sender As Object, e As EventArgs)
        Dim idMhs As Integer = GetFirstIdMhs()
        If idMhs <> -1 Then
            formEdit.InisialisasiMahasiswa()
            Form1.childform(formEdit)
        Else
            ' Data tidak ditemukan
            MsgBox("Tidak ada data mahasiswa yang ditemukan", MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Form1.childform(formMhs)
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