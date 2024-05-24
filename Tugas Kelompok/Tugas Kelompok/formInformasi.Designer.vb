<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formInformasi
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
        Me.btnInfoIpk = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.panelOutput = New System.Windows.Forms.Panel()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.panelOutput.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInfoIpk
        '
        Me.btnInfoIpk.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnInfoIpk.Location = New System.Drawing.Point(0, 0)
        Me.btnInfoIpk.Name = "btnInfoIpk"
        Me.btnInfoIpk.Size = New System.Drawing.Size(159, 51)
        Me.btnInfoIpk.TabIndex = 1
        Me.btnInfoIpk.Text = "Info IPK"
        Me.btnInfoIpk.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btnInfoIpk)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 51)
        Me.Panel1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.Location = New System.Drawing.Point(159, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(159, 51)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "IPK Perjurusan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'panelOutput
        '
        Me.panelOutput.BackColor = System.Drawing.Color.Transparent
        Me.panelOutput.Controls.Add(Me.PictureBoxLogo)
        Me.panelOutput.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelOutput.Location = New System.Drawing.Point(0, 51)
        Me.panelOutput.Name = "panelOutput"
        Me.panelOutput.Size = New System.Drawing.Size(800, 455)
        Me.panelOutput.TabIndex = 4
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
        'formInformasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 506)
        Me.Controls.Add(Me.panelOutput)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "formInformasi"
        Me.Text = "formKelulusan"
        Me.Panel1.ResumeLayout(False)
        Me.panelOutput.ResumeLayout(False)
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInfoIpk As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents panelOutput As Panel
    Friend WithEvents PictureBoxLogo As PictureBox
End Class
