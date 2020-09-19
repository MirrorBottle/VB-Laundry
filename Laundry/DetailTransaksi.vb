Public Class DetailTransaksi

    Private transactionId As Integer = 0
    Private consumentName As String = "-"
    Private discount As Integer = 0
    Private totalCost As Integer = 0


    Private Sub GetTransactionDetailData()
        TransactionDetailDataView.DataSource = GetTableDataToDataTable("SELECT rincian_transaksi.id, tarif.nama_pakaian, tarif.tarif, jenis_laundry.nama_jenis_laundry, rincian_transaksi.jumlah FROM rincian_transaksi JOIN tarif ON rincian_transaksi.id_tarif=tarif.id JOIN jenis_laundry ON tarif.id_jenis_laundry=jenis_laundry.id WHERE rincian_transaksi.id_transaksi=" & transactionId)
    End Sub

    Public Sub SetTransactionDetailData(transactionId As Integer, consumentName As String, discount As Integer)
        Me.transactionId = transactionId
        Me.consumentName = consumentName
        Me.discount = discount
    End Sub

    Private Sub DetailTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DetailTransactionLabel.Text = "Detail Transaksi - #" & transactionId
        ConsumerNameLabel.Text = "Nama Konsumen : " & consumentName
        DiscountLabel.Text = "Diskon : " & discount & "%"

        Call MakeConnection()
        GetTransactionDetailData()
        SetDataViewHeader(TransactionDetailDataView, {"ID", "Nama Pakaian", "Tarif", "Jenis Laundry", "Jumlah"})
        Dim CostTotalColumn As New DataGridViewTextBoxColumn
        CostTotalColumn.HeaderText = "Jumlah Biaya"
        TransactionDetailDataView.Columns.Add(CostTotalColumn)

        Using Transactions As Odbc.OdbcDataReader = ExecuteSelectQuery("SELECT tarif.tarif, rincian_transaksi.jumlah FROM rincian_transaksi JOIN tarif ON rincian_transaksi.id_tarif=tarif.id WHERE rincian_transaksi.id_transaksi=" & transactionId)
            While Transactions.Read
                Dim total As Integer = Transactions("tarif") * Transactions("jumlah")
                totalCost = totalCost + total
            End While
            Transactions.Close()
        End Using
        CostLabel.Text = "Biaya : Rp. " & totalCost
        CostTotalLabel.Text = "Total Biaya : Rp. " & totalCost - totalCost * discount / 100
    End Sub

    Private Sub DataView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles TransactionDetailDataView.CellFormatting
        Dim SelectedRow As DataGridViewRow = TransactionDetailDataView.Rows(e.RowIndex)

        If e.ColumnIndex = 2 Then
            If Not IsDBNull(e.Value) Then
                e.Value = "Rp. " & e.Value
                e.FormattingApplied = True
            End If
        End If

        If e.ColumnIndex = 5 Then
            Dim total As Integer = SelectedRow.Cells(2).Value * SelectedRow.Cells(4).Value
            totalCost = totalCost + total
            e.Value = "Rp. " + total.ToString
            e.FormattingApplied = True
        End If
    End Sub
End Class