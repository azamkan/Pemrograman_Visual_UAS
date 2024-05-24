<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pr = New System.Windows.Forms.RadioButton()
        Me.lk = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Tidak = New System.Windows.Forms.RadioButton()
        Me.Ya = New System.Windows.Forms.RadioButton()
        Me.txtIpk = New System.Windows.Forms.TextBox()
        Me.txtNim = New System.Windows.Forms.TextBox()
        Me.cmbJurusan = New System.Windows.Forms.ComboBox()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(468, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 16)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = ":"
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(464, 364)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(122, 43)
        Me.btnBatal.TabIndex = 69
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.ForestGreen
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(592, 364)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(116, 44)
        Me.btnSimpan.TabIndex = 68
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.ForestGreen
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Location = New System.Drawing.Point(30, 315)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(210, 41)
        Me.btnBrowse.TabIndex = 67
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Tugas_Kelompok.My.Resources.Resources.user
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(30, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(210, 240)
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'pr
        '
        Me.pr.AutoSize = True
        Me.pr.Location = New System.Drawing.Point(112, 7)
        Me.pr.Name = "pr"
        Me.pr.Size = New System.Drawing.Size(98, 20)
        Me.pr.TabIndex = 17
        Me.pr.TabStop = True
        Me.pr.Text = "Perempuan"
        Me.pr.UseVisualStyleBackColor = True
        '
        'lk
        '
        Me.lk.AutoSize = True
        Me.lk.Location = New System.Drawing.Point(14, 7)
        Me.lk.Name = "lk"
        Me.lk.Size = New System.Drawing.Size(88, 20)
        Me.lk.TabIndex = 0
        Me.lk.TabStop = True
        Me.lk.Text = "Laki - Laki"
        Me.lk.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(278, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 16)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Jenis Kelamin"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox2.Controls.Add(Me.pr)
        Me.GroupBox2.Controls.Add(Me.lk)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(484, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(226, 37)
        Me.GroupBox2.TabIndex = 64
        Me.GroupBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(278, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 16)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Pernah Mengulang :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(278, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 16)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Nomor Induk Mahasiswa "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(278, 293)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 16)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "IPK"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(278, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 16)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Program Studi :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(278, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Nama Lengkap "
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(484, 43)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(226, 22)
        Me.txtNama.TabIndex = 51
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.Tidak)
        Me.GroupBox1.Controls.Add(Me.Ya)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(484, 183)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(226, 38)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        '
        'Tidak
        '
        Me.Tidak.AutoSize = True
        Me.Tidak.Location = New System.Drawing.Point(72, 7)
        Me.Tidak.Name = "Tidak"
        Me.Tidak.Size = New System.Drawing.Size(63, 20)
        Me.Tidak.TabIndex = 17
        Me.Tidak.TabStop = True
        Me.Tidak.Text = "Tidak"
        Me.Tidak.UseVisualStyleBackColor = True
        '
        'Ya
        '
        Me.Ya.AutoSize = True
        Me.Ya.Location = New System.Drawing.Point(14, 7)
        Me.Ya.Name = "Ya"
        Me.Ya.Size = New System.Drawing.Size(45, 20)
        Me.Ya.TabIndex = 0
        Me.Ya.TabStop = True
        Me.Ya.Text = "Ya"
        Me.Ya.UseVisualStyleBackColor = True
        '
        'txtIpk
        '
        Me.txtIpk.Location = New System.Drawing.Point(484, 293)
        Me.txtIpk.Name = "txtIpk"
        Me.txtIpk.Size = New System.Drawing.Size(226, 22)
        Me.txtIpk.TabIndex = 55
        '
        'txtNim
        '
        Me.txtNim.Location = New System.Drawing.Point(484, 93)
        Me.txtNim.Name = "txtNim"
        Me.txtNim.Size = New System.Drawing.Size(226, 22)
        Me.txtNim.TabIndex = 54
        '
        'cmbJurusan
        '
        Me.cmbJurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJurusan.FormattingEnabled = True
        Me.cmbJurusan.Items.AddRange(New Object() {"Informatika", "Sistem Informasi", "Kedokteran", "Teknik Industri", "Kehutanan", "Pendidikan Biologi", "Hukum"})
        Me.cmbJurusan.Location = New System.Drawing.Point(484, 243)
        Me.cmbJurusan.Name = "cmbJurusan"
        Me.cmbJurusan.Size = New System.Drawing.Size(226, 24)
        Me.cmbJurusan.TabIndex = 57
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxLogo.Image = Global.Tugas_Kelompok.My.Resources.Resources.LogoUnmul_1
        Me.PictureBoxLogo.Location = New System.Drawing.Point(864, 84)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(1, 1)
        Me.PictureBoxLogo.TabIndex = 52
        Me.PictureBoxLogo.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(468, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 16)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(468, 143)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(10, 16)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(468, 193)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 16)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(468, 243)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(10, 16)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(468, 293)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(10, 16)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = ":"
        '
        'formEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 516)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtIpk)
        Me.Controls.Add(Me.txtNim)
        Me.Controls.Add(Me.cmbJurusan)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Name = "formEdit"
        Me.Text = "edit"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pr As RadioButton
    Friend WithEvents lk As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Tidak As RadioButton
    Friend WithEvents Ya As RadioButton
    Friend WithEvents txtIpk As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents cmbJurusan As ComboBox
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
