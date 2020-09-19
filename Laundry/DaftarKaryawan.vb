Imports System.Data.SqlClient
Imports System.Data.Odbc.OdbcConnection
Public Class DaftarKaryawan

    Dim SelectedRowIndex As Integer = -1
    Dim isAdd As Boolean = True


    Private Sub ResetForm()
        isAdd = True
        FormLabel.Text = "Tambah Data"
        NikBox.Text = ""
        NamaBox.Text = ""
        NoTelponBox.Text = ""
        AlamatBox.Text = ""
        WomanGenderRadioButton.Checked = False
        ManGenderRadioButton.Checked = False
    End Sub

    Private Sub ChangeFormMode(Mode As String)
        If Mode = "add" Then
            ResetForm()
        Else
            Dim SelectedRow As DataGridViewRow = DataView.Rows(SelectedRowIndex)
            isAdd = False
            FormLabel.Text = "Ubah Data"
            NikBox.Text = SelectedRow.Cells(1).Value
            NamaBox.Text = SelectedRow.Cells(2).Value
            AlamatBox.Text = SelectedRow.Cells(3).Value
            NoTelponBox.Text = SelectedRow.Cells(5).Value
            If SelectedRow.Cells(4).Value = "L" Then
                ManGenderRadioButton.Checked = True
            ElseIf SelectedRow.Cells(4).Value = "P" Then
                WomanGenderRadioButton.Checked = True
            End If
        End If
    End Sub

    Private Sub GetData()
        DataView.DataSource = GetTableDataToDataTable("SELECT id, nik, nama, alamat, gender, telpon FROM karyawan")
    End Sub

    Private Sub DaftarKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MakeConnection()
        GetData()
        Dim Columns() As String = {"ID", "NIK Karyawan", "Nama Karyawan", "Alamat", "Gender", "No. Telpon"}

        For i As Int32 = 0 To Columns.Count - 1
            DataView.Columns(i).HeaderText = Columns(i)
        Next
        DataView.Columns(0).Visible = False
    End Sub

    

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        ChangeFormMode("add")
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If SelectedRowIndex > -1 Then
            Dim answer As DialogResult = MessageBox.Show("Apa anda yakin ingin menghapus data ini", "Data tidak akan bisa dikembalikan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If answer = vbYes Then
                ResetForm()
                Dim isSuccess As Integer = ExecuteQuery("DELETE FROM karyawan WHERE id=" & DataView.Rows(SelectedRowIndex).Cells(0).Value)
                If isSuccess = 0 Then
                    SuccessMessage("Data berhasil dihapus")
                    GetData()
                End If
            End If
        Else
            WarningMessage("Data belum dipilih")
        End If
    End Sub

    Private Function getGender()
        If ManGenderRadioButton.Checked = True Then
            Return "L"
        ElseIf WomanGenderRadioButton.Checked = True Then
            Return "P"
        End If
        Return ""
    End Function

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        Dim gender As String = getGender()
        Dim query As String
        If isAdd = True Then
            query = "INSERT INTO karyawan VALUES ('','" & NamaBox.Text & "', '" & AlamatBox.Text & "', '" & gender & "', '" & NoTelponBox.Text & "', '" & NikBox.Text & "')"
        Else
            query = "UPDATE karyawan SET nama='" & NamaBox.Text & "', alamat='" & AlamatBox.Text & "', gender='" & gender & "', telpon='" & NoTelponBox.Text & "', nik='" & NikBox.Text & "' WHERE id=" & DataView.Rows(SelectedRowIndex).Cells(0).Value
        End If
        Dim isSuccess As Integer = ExecuteQuery(query)
        If isSuccess = 0 Then
            If isAdd Then
                SuccessMessage("Data berhasil ditambah")
            Else
                SuccessMessage("Data berhasil diubah")
            End If
            ResetForm()
            GetData()
        End If
    End Sub

    Private Sub DataView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataView.CellFormatting
        If e.ColumnIndex = 4 Then
            If Not IsDBNull(e.Value) Then
                If Not e.Value = "" Then
                    e.Value = IIf(e.Value = "L", "Laki-laki", "Perempuan")
                    e.FormattingApplied = True
                End If
            End If
        End If
    End Sub

    Private Sub DataView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataView.CellClick
        If Not IsDBNull(DataView.Rows(e.RowIndex).Cells(1).Value) Then
            SelectedRowIndex = e.RowIndex
            ChangeFormMode("edit")
        End If
    End Sub

    Private Sub DaftarKaryawanBtn_Click(sender As Object, e As EventArgs) Handles DaftarKonsumenBtn.Click
        ChangeForm(Me, DaftarKonsumen)
    End Sub
End Class