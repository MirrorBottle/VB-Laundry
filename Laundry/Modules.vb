Imports System.Data.Odbc


Module Modules

    Public Connection As OdbcConnection = New OdbcConnection("Dsn=laundry_ukk")
    Public Command As New OdbcCommand


    Public Sub MakeConnection()
        If Connection.State = ConnectionState.Closed Then Connection.Open()
    End Sub

    Public Sub SetDataViewHeader(DataView As System.Windows.Forms.DataGridView, Columns() As String)
        For i As Int32 = 0 To Columns.Count - 1
            DataView.Columns(i).HeaderText = Columns(i)
        Next
        DataView.Columns(0).Visible = False
    End Sub

    Public Function GetTableDataToDataTable(Query As String) As DataTable
        Dim DataTable = New DataTable()
        Try
            Command.Connection = Connection
            Command.CommandText = Query
            Dim DataReader As Odbc.OdbcDataReader = Command.ExecuteReader()
            DataTable.Load(DataReader)
            DataReader.Close()
            Return DataTable
        Catch ex As Exception
            Return ErrorMessage(ex.ToString)
        End Try
    End Function

    Public Function ExecuteQuery(Query As String) As Integer
        Try
            Dim InnerCommand As New OdbcCommand
            InnerCommand.Connection = Connection
            InnerCommand.CommandText = Query
            InnerCommand.ExecuteNonQuery()
            Return 0
        Catch MyOdbcException As OdbcException
            ErrorMessage(MyOdbcException.ToString)
            Return 1
        Catch MyException As Exception
            ErrorMessage(MyException.ToString)
            Return 1
        End Try
    End Function

    Public Function ExecuteSelectQuery(Query As String)
        Try
            Command.Connection = Connection
            Command.CommandText = Query
            Dim DataReader As Odbc.OdbcDataReader = Command.ExecuteReader()
            Return DataReader
        Catch ex As Exception
            Return ErrorMessage(ex.ToString)
        End Try
    End Function

    Public Function WarningMessage(Message As String)
        Return MessageBox.Show(Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Function

    Public Function ErrorMessage(Message As String)
        Return MessageBox.Show(Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Function

    Public Function SuccessMessage(Message As String)
        Return MessageBox.Show(Message, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Function

    Public Sub ChangeForm(CurrentForm As System.Windows.Forms.Form, ToForm As System.Windows.Forms.Form)
        CurrentForm.Visible = False
        ToForm.Visible = True
    End Sub
End Module
