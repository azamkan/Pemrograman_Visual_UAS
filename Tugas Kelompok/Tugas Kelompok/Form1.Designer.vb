<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNim = New System.Windows.Forms.TextBox()
        Me.txtIpk = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Tidak = New System.Windows.Forms.RadioButton()
        Me.Ya = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbJurusan = New System.Windows.Forms.ComboBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ttd = New System.Windows.Forms.PictureBox()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.PictureBoxBorder = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ttd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxBorder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(288, 161)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(294, 22)
        Me.txtNama.TabIndex = 0
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(435, 465)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(147, 43)
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Text = "Cetak Ijazah"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nama Lengkap :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Program Studi :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 355)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "IPK"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "NIM : "
        '
        'txtNim
        '
        Me.txtNim.Location = New System.Drawing.Point(288, 206)
        Me.txtNim.Name = "txtNim"
        Me.txtNim.Size = New System.Drawing.Size(294, 22)
        Me.txtNim.TabIndex = 10
        '
        'txtIpk
        '
        Me.txtIpk.Location = New System.Drawing.Point(288, 362)
        Me.txtIpk.MaxLength = 4
        Me.txtIpk.Name = "txtIpk"
        Me.txtIpk.Size = New System.Drawing.Size(294, 22)
        Me.txtIpk.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 305)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Pernah Mengulang :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.Tidak)
        Me.GroupBox1.Controls.Add(Me.Ya)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(288, 296)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 53)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'Tidak
        '
        Me.Tidak.AutoSize = True
        Me.Tidak.Location = New System.Drawing.Point(88, 16)
        Me.Tidak.Name = "Tidak"
        Me.Tidak.Size = New System.Drawing.Size(64, 21)
        Me.Tidak.TabIndex = 17
        Me.Tidak.TabStop = True
        Me.Tidak.Text = "Tidak"
        Me.Tidak.UseVisualStyleBackColor = True
        '
        'Ya
        '
        Me.Ya.AutoSize = True
        Me.Ya.Location = New System.Drawing.Point(19, 16)
        Me.Ya.Name = "Ya"
        Me.Ya.Size = New System.Drawing.Size(46, 21)
        Me.Ya.TabIndex = 0
        Me.Ya.TabStop = True
        Me.Ya.Text = "Ya"
        Me.Ya.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 400)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Tanggal Lulus"
        '
        'cmbJurusan
        '
        Me.cmbJurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJurusan.FormattingEnabled = True
        Me.cmbJurusan.Items.AddRange(New Object() {"Informatika", "Sistem Informasi", "Kedokteran", "Teknik Industri", "Kehutanan", "Pendidikan Biologi", "Hukum"})
        Me.cmbJurusan.Location = New System.Drawing.Point(288, 258)
        Me.cmbJurusan.Name = "cmbJurusan"
        Me.cmbJurusan.Size = New System.Drawing.Size(294, 24)
        Me.cmbJurusan.TabIndex = 19
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(285, 465)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(147, 43)
        Me.btnHapus.TabIndex = 20
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Yellow
        Me.Panel1.Controls.Add(Me.btnKeluar)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(2, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(229, 573)
        Me.Panel1.TabIndex = 21
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(48, 465)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(95, 38)
        Me.btnKeluar.TabIndex = 34
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.Tugas_Kelompok.My.Resources.Resources.LogoUnmul_1
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(59, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(100, 100)
        Me.Panel2.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(279, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(268, 32)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Program Sertifikat "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(280, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(347, 32)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Universitas Mulawarman"
        '
        'ttd
        '
        Me.ttd.Location = New System.Drawing.Point(757, 99)
        Me.ttd.Name = "ttd"
        Me.ttd.Size = New System.Drawing.Size(10, 10)
        Me.ttd.TabIndex = 24
        Me.ttd.TabStop = False
        Me.ttd.Visible = False
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxLogo.Image = Global.Tugas_Kelompok.My.Resources.Resources.LogoUnmul_1
        Me.PictureBoxLogo.Location = New System.Drawing.Point(594, 29)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(1, 1)
        Me.PictureBoxLogo.TabIndex = 4
        Me.PictureBoxLogo.TabStop = False
        '
        'PictureBoxBorder
        '
        Me.PictureBoxBorder.Location = New System.Drawing.Point(757, 64)
        Me.PictureBoxBorder.Name = "PictureBoxBorder"
        Me.PictureBoxBorder.Size = New System.Drawing.Size(10, 10)
        Me.PictureBoxBorder.TabIndex = 5
        Me.PictureBoxBorder.TabStop = False
        Me.PictureBoxBorder.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(285, 405)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(297, 22)
        Me.DateTimePicker1.TabIndex = 25
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 573)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ttd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.cmbJurusan)
        Me.Controls.Add(Me.txtIpk)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.txtNim)
        Me.Controls.Add(Me.PictureBoxBorder)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ttd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxBorder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PictureBoxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxBorder As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNim As System.Windows.Forms.TextBox
    Friend WithEvents txtIpk As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Tidak As System.Windows.Forms.RadioButton
    Friend WithEvents Ya As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbJurusan As System.Windows.Forms.ComboBox
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ttd As System.Windows.Forms.PictureBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker

End Class
