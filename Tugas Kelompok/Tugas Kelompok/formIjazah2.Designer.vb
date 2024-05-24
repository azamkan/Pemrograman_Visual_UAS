<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formIjazah2
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.panelOutput = New System.Windows.Forms.Panel()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.panelOutput.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnLaporan)
        Me.Panel1.Controls.Add(Me.btnCetak)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 53)
        Me.Panel1.TabIndex = 3
        '
        'btnLaporan
        '
        Me.btnLaporan.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnLaporan.Location = New System.Drawing.Point(139, 0)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(139, 53)
        Me.btnLaporan.TabIndex = 0
        Me.btnLaporan.Text = "Laporan"
        Me.btnLaporan.UseVisualStyleBackColor = True
        '
        'btnCetak
        '
        Me.btnCetak.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCetak.Location = New System.Drawing.Point(0, 0)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(139, 53)
        Me.btnCetak.TabIndex = 1
        Me.btnCetak.Text = "Cetak Ijazah"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'panelOutput
        '
        Me.panelOutput.BackColor = System.Drawing.Color.Transparent
        Me.panelOutput.Controls.Add(Me.PictureBoxLogo)
        Me.panelOutput.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelOutput.Location = New System.Drawing.Point(0, 53)
        Me.panelOutput.Name = "panelOutput"
        Me.panelOutput.Size = New System.Drawing.Size(800, 397)
        Me.panelOutput.TabIndex = 5
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
        'formIjazah2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.panelOutput)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "formIjazah2"
        Me.Text = "formIjazah2"
        Me.Panel1.ResumeLayout(False)
        Me.panelOutput.ResumeLayout(False)
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLaporan As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents panelOutput As Panel
    Friend WithEvents PictureBoxLogo As PictureBox
End Class
