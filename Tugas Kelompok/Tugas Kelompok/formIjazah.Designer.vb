<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formIjazah
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formIjazah))
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.cbProdi = New System.Windows.Forms.ComboBox()
        Me.panelProduk = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PrintDocument1
        '
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
        'cbProdi
        '
        Me.cbProdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProdi.FormattingEnabled = True
        Me.cbProdi.Location = New System.Drawing.Point(106, 25)
        Me.cbProdi.Name = "cbProdi"
        Me.cbProdi.Size = New System.Drawing.Size(170, 24)
        Me.cbProdi.TabIndex = 3
        '
        'panelProduk
        '
        Me.panelProduk.AutoScroll = True
        Me.panelProduk.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.panelProduk.Location = New System.Drawing.Point(11, 73)
        Me.panelProduk.Name = "panelProduk"
        Me.panelProduk.Size = New System.Drawing.Size(760, 467)
        Me.panelProduk.TabIndex = 4
        Me.panelProduk.WrapContents = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Program Studi"
        '
        'formIjazah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 481)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panelProduk)
        Me.Controls.Add(Me.cbProdi)
        Me.Name = "formIjazah"
        Me.Text = "formIjazah"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents cbProdi As ComboBox
    Friend WithEvents panelProduk As FlowLayoutPanel
    Friend WithEvents Label1 As Label
End Class
