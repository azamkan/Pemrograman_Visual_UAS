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
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnIjazah = New System.Windows.Forms.Button()
        Me.btnInformasi = New System.Windows.Forms.Button()
        Me.btnGrafik = New System.Windows.Forms.Button()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.panelOutput = New System.Windows.Forms.Panel()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panelOutput.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Yellow
        Me.Panel1.Controls.Add(Me.btnIjazah)
        Me.Panel1.Controls.Add(Me.btnInformasi)
        Me.Panel1.Controls.Add(Me.btnGrafik)
        Me.Panel1.Controls.Add(Me.btnInput)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnKeluar)
        Me.Panel1.Location = New System.Drawing.Point(2, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(229, 573)
        Me.Panel1.TabIndex = 21
        '
        'btnIjazah
        '
        Me.btnIjazah.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnIjazah.FlatAppearance.BorderSize = 0
        Me.btnIjazah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIjazah.Location = New System.Drawing.Point(0, 321)
        Me.btnIjazah.Name = "btnIjazah"
        Me.btnIjazah.Size = New System.Drawing.Size(229, 39)
        Me.btnIjazah.TabIndex = 42
        Me.btnIjazah.Text = "              Ijazah dan Laporan"
        Me.btnIjazah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIjazah.UseVisualStyleBackColor = True
        '
        'btnInformasi
        '
        Me.btnInformasi.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInformasi.FlatAppearance.BorderSize = 0
        Me.btnInformasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInformasi.Location = New System.Drawing.Point(0, 282)
        Me.btnInformasi.Name = "btnInformasi"
        Me.btnInformasi.Size = New System.Drawing.Size(229, 39)
        Me.btnInformasi.TabIndex = 41
        Me.btnInformasi.Text = "              Informasi Lulusan"
        Me.btnInformasi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInformasi.UseVisualStyleBackColor = True
        '
        'btnGrafik
        '
        Me.btnGrafik.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGrafik.FlatAppearance.BorderSize = 0
        Me.btnGrafik.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrafik.Location = New System.Drawing.Point(0, 243)
        Me.btnGrafik.Name = "btnGrafik"
        Me.btnGrafik.Size = New System.Drawing.Size(229, 39)
        Me.btnGrafik.TabIndex = 40
        Me.btnGrafik.Text = "              Grafik Kelulusan"
        Me.btnGrafik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrafik.UseVisualStyleBackColor = True
        '
        'btnInput
        '
        Me.btnInput.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInput.FlatAppearance.BorderSize = 0
        Me.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInput.Location = New System.Drawing.Point(0, 204)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(229, 39)
        Me.btnInput.TabIndex = 39
        Me.btnInput.Text = "              Input Data"
        Me.btnInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(229, 204)
        Me.Panel2.TabIndex = 38
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = Global.Tugas_Kelompok.My.Resources.Resources.LogoUnmul_1
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(64, 52)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(100, 100)
        Me.Panel3.TabIndex = 34
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(64, 518)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(95, 38)
        Me.btnKeluar.TabIndex = 34
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'panelOutput
        '
        Me.panelOutput.BackColor = System.Drawing.Color.Transparent
        Me.panelOutput.Controls.Add(Me.PictureBoxLogo)
        Me.panelOutput.Location = New System.Drawing.Point(232, -1)
        Me.panelOutput.Name = "panelOutput"
        Me.panelOutput.Size = New System.Drawing.Size(763, 579)
        Me.panelOutput.TabIndex = 0
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxLogo.Image = Global.Tugas_Kelompok.My.Resources.Resources.LogoUnmul_1
        Me.PictureBoxLogo.Location = New System.Drawing.Point(362, 20)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(1, 1)
        Me.PictureBoxLogo.TabIndex = 4
        Me.PictureBoxLogo.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 573)
        Me.Controls.Add(Me.panelOutput)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.panelOutput.ResumeLayout(False)
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PictureBoxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnKeluar As Button
    Friend WithEvents panelOutput As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnIjazah As Button
    Friend WithEvents btnInformasi As Button
    Friend WithEvents btnGrafik As Button
    Friend WithEvents btnInput As Button
End Class
