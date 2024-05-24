Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class formGrafik
    Private Sub formGrafik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        TampilGrafikKelulusan()
    End Sub

    Private Sub TampilGrafikKelulusan()
        ' Query untuk mendapatkan jumlah lulusan per prodi
        Dim query As String = "SELECT prodi, COUNT(*) as JumlahLulus FROM tbmhs GROUP BY prodi"
        Dim adapter As New MySqlDataAdapter(query, CONN)
        Dim table As New DataTable()
        adapter.Fill(table)

        ' Hapus semua seri yang ada di Chart
        Chart1.Series.Clear()

        ' Buat seri baru untuk grafik kolom
        Dim series As New Series("Kelulusan")
        series.ChartType = SeriesChartType.Column
        Chart1.Series.Add(series)

        ' Tambahkan data ke dalam seri
        For Each row As DataRow In table.Rows
            series.Points.AddXY(row("prodi").ToString(), Convert.ToInt32(row("JumlahLulus")))
        Next

        ' Atur judul sumbu X dan Y
        Chart1.ChartAreas(0).AxisX.Title = "Prodi"
        Chart1.ChartAreas(0).AxisY.Title = "Jumlah Lulus"

        ' Atur posisi label pada sumbu X agar berada di bawah
        Chart1.ChartAreas(0).AxisX.LabelStyle.Angle = 0 ' 0 derajat (horizontal)
        Chart1.ChartAreas(0).AxisX.Interval = 1 ' Pastikan intervalnya adalah 1
        Chart1.ChartAreas(0).AxisX.MajorGrid.LineWidth = 0 ' Hilangkan garis grid mayor pada sumbu X

        ' Atur posisi label pada sumbu Y
        Chart1.ChartAreas(0).AxisY.LabelStyle.Format = "N0" ' Format angka tanpa desimal
        Chart1.ChartAreas(0).AxisY.Interval = 1 ' Pastikan intervalnya adalah 1
    End Sub

End Class