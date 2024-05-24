<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formInfoIpk
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cbProdi = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(11, 70)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(758, 467)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'cbProdi
        '
        Me.cbProdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProdi.FormattingEnabled = True
        Me.cbProdi.Location = New System.Drawing.Point(106, 25)
        Me.cbProdi.Name = "cbProdi"
        Me.cbProdi.Size = New System.Drawing.Size(170, 24)
        Me.cbProdi.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Program Studi"
        '
        'formInfoIpk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(771, 540)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbProdi)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "formInfoIpk"
        Me.Text = "formInfoIpk"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents cbProdi As ComboBox
    Friend WithEvents Label1 As Label
End Class
