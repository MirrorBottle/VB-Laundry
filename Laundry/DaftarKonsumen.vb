Imports System.Data.Odbc

Public Class DaftarKonsumen

    Dim SelectedConsumentRowIndex As Integer = -1
    Dim SelectedTransactionRowIndex As Integer = -1
    Dim isAdd As Boolean = True

    Private Sub ResetForm()
        isAdd = True
        FormLabel.Text = "Tambah Data"
        EmailBox.Text = ""
        NamaBox.Text = ""
        NoTelponBox.Text = ""
        AlamatBox.Text = ""
        DetailTransactionBtn.Enabled = False
    End Sub

    Private Sub ChangeFormMode(Mode As String)
        If Mode = "add" Then
            ResetForm()

        Else
            Dim SelectedRow As DataGridViewRow = ConsumentDataView.Rows(SelectedConsumentRowIndex)
            isAdd = False
            FormLabel.Text = "Ubah Data"
            EmailBox.Text = SelectedRow.Cells(4).Value
            NamaBox.Text = SelectedRow.Cells(1).Value
            AlamatBox.Text = SelectedRow.Cells(2).Value
            NoTelponBox.Text = SelectedRow.Cells(3).Value
        End If
    End Sub

    Private Sub GetConsumentData()
        ConsumentDataView.DataSource = GetTableDataToDataTable("SELECT id, nama, alamat, telpon, email FROM konsumen")
    End Sub

    Private Sub GetConsumentTransactionData()
        ConsumentTransactionDataView.DataSource = GetTableDataToDataTable("SELECT transaksi.id, transaksi.tanggal_transaksi, transaksi.tanggal_ambil, transaksi.diskon, karyawan.nama FROM transaksi INNER JOIN karyawan ON transaksi.id_karyawan=karyawan.id AND transaksi.id_konsumen=" & ConsumentDataView.Rows(SelectedConsumentRowIndex).Cells(0).Value)
        SetDataViewHeader(ConsumentTransactionDataView, {"ID", "Tanggal Transaksi", "Tanggal Ambil", "Diskon", "Karyawan"})
    End Sub


    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        ChangeFormMode("add")
    End Sub

    Private Sub DaftarKonsumen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MakeConnection()
        GetConsumentData()
        SetDataViewHeader(ConsumentDataView, {"ID", "Nama Konsumen", "Alamat", "No. Telpon", "Email"})
    End Sub

    Private Sub ConsumentDataView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ConsumentDataView.CellClick
        If Not IsDBNull(ConsumentDataView.Rows(e.RowIndex).Cells(1).Value) Then
            SelectedConsumentRowIndex = e.RowIndex
            TransactionLabel.Text = "Data Transaksi Konsumen - " & ConsumentDataView.Rows(e.RowIndex).Cells(1).Value
            GetConsumentTransactionData()
            ChangeFormMode("edit")
        End If
    End Sub

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        Dim query As String
        If isAdd = True Then
            query = "INSERT INTO konsumen VALUES ('','" & NamaBox.Text & "', '" & AlamatBox.Text & "', '" & NoTelponBox.Text & "', '" & EmailBox.Text & "')"
        Else
            query = "UPDATE konsumen SET nama='" & NamaBox.Text & "', alamat='" & AlamatBox.Text & "', telpon='" & NoTelponBox.Text & "', email='" & EmailBox.Text & "' WHERE id=" & ConsumentDataView.Rows(SelectedConsumentRowIndex).Cells(0).Value
        End If
        Dim isSuccess As Integer = ExecuteQuery(query)
        If isSuccess = 0 Then
            If isAdd Then
                SuccessMessage("Data berhasil ditambah")
            Else
                SuccessMessage("Data berhasil diubah")
            End If
            ResetForm()
            GetConsumentData()
        End If
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If SelectedConsumentRowIndex > -1 Then
            Dim answer As DialogResult = MessageBox.Show("Semua data transaksi dan detail transaksi akan dihapus pula. Apa anda yakin?", "Hapus Data Konsumen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If answer = vbYes Then
                ResetForm()
                Using Transactions As Odbc.OdbcDataReader = ExecuteSelectQuery("SELECT * FROM transaksi WHERE id_konsumen=" & ConsumentDataView.Rows(SelectedConsumentRowIndex).Cells(0).Value)
                    While Transactions.Read
                        Dim isSuccess = ExecuteQuery("DELETE FROM rincian_transaksi WHERE id_transaksi=" & Transactions("id"))
                        If isSuccess = 0 Then
                            ExecuteQuery("DELETE FROM transaksi WHERE id=" & Transactions("id"))
                        End If
                    End While
                    Transactions.Close()
                End Using
                SuccessMessage("Data berhasil dihapus")
                GetConsumentData()
            End If
        Else
            WarningMessage("Data belum dipilih")
        End If
    End Sub

    Private Sub DaftarKaryawanBtn_Click(sender As Object, e As EventArgs) Handles DaftarKaryawanBtn.Click
        ChangeForm(Me, DaftarKaryawan)
    End Sub

    Private Sub DetailTransactionBtn_Click(sender As Object, e As EventArgs) Handles DetailTransactionBtn.Click
        Dim SelectedRow As DataGridViewRow = ConsumentTransactionDataView.Rows(SelectedTransactionRowIndex)
        DetailTransaksi.SetTransactionDetailData(SelectedRow.Cells(0).Value, ConsumentDataView.Rows(SelectedConsumentRowIndex).Cells(1).Value, SelectedRow.Cells(3).Value)
        DetailTransaksi.Visible = True
    End Sub

    Private Sub ConsumentTransactionDataView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ConsumentTransactionDataView.CellClick
        If Not IsDBNull(ConsumentTransactionDataView.Rows(e.RowIndex).Cells(1).Value) Then
            SelectedTransactionRowIndex = e.RowIndex
            DetailTransactionBtn.Enabled = True
        End If
    End Sub
End Class