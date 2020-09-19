<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DaftarKonsumen
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
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.ConsumentDataView = New System.Windows.Forms.DataGridView()
        Me.FormLabel = New System.Windows.Forms.Label()
        Me.NoTelponBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NamaBox = New System.Windows.Forms.TextBox()
        Me.ConsumentTransactionDataView = New System.Windows.Forms.DataGridView()
        Me.TransactionLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DetailTransactionBtn = New System.Windows.Forms.Button()
        Me.EmailBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AlamatBox = New System.Windows.Forms.TextBox()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.DaftarKaryawanBtn = New System.Windows.Forms.Button()
        CType(Me.ConsumentDataView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsumentTransactionDataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.Location = New System.Drawing.Point(659, 21)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(183, 53)
        Me.DeleteBtn.TabIndex = 6
        Me.DeleteBtn.Text = "Hapus"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'AddBtn
        '
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.Location = New System.Drawing.Point(470, 21)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(183, 53)
        Me.AddBtn.TabIndex = 5
        Me.AddBtn.Text = "Tambah"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'ConsumentDataView
        '
        Me.ConsumentDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ConsumentDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConsumentDataView.Location = New System.Drawing.Point(470, 134)
        Me.ConsumentDataView.Name = "ConsumentDataView"
        Me.ConsumentDataView.RowTemplate.Height = 24
        Me.ConsumentDataView.Size = New System.Drawing.Size(712, 250)
        Me.ConsumentDataView.TabIndex = 4
        '
        'FormLabel
        '
        Me.FormLabel.AutoSize = True
        Me.FormLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormLabel.Location = New System.Drawing.Point(16, 21)
        Me.FormLabel.Name = "FormLabel"
        Me.FormLabel.Size = New System.Drawing.Size(191, 36)
        Me.FormLabel.TabIndex = 8
        Me.FormLabel.Text = "Tambah Data"
        '
        'NoTelponBox
        '
        Me.NoTelponBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoTelponBox.Location = New System.Drawing.Point(22, 213)
        Me.NoTelponBox.Name = "NoTelponBox"
        Me.NoTelponBox.Size = New System.Drawing.Size(424, 28)
        Me.NoTelponBox.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 24)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "No. Telpon :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 24)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nama :"
        '
        'NamaBox
        '
        Me.NamaBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaBox.Location = New System.Drawing.Point(22, 134)
        Me.NamaBox.Name = "NamaBox"
        Me.NamaBox.Size = New System.Drawing.Size(424, 28)
        Me.NamaBox.TabIndex = 14
        '
        'ConsumentTransactionDataView
        '
        Me.ConsumentTransactionDataView.AllowUserToAddRows = False
        Me.ConsumentTransactionDataView.AllowUserToDeleteRows = False
        Me.ConsumentTransactionDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ConsumentTransactionDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConsumentTransactionDataView.Location = New System.Drawing.Point(470, 451)
        Me.ConsumentTransactionDataView.Name = "ConsumentTransactionDataView"
        Me.ConsumentTransactionDataView.ReadOnly = True
        Me.ConsumentTransactionDataView.RowTemplate.Height = 24
        Me.ConsumentTransactionDataView.Size = New System.Drawing.Size(712, 137)
        Me.ConsumentTransactionDataView.TabIndex = 18
        '
        'TransactionLabel
        '
        Me.TransactionLabel.AutoSize = True
        Me.TransactionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.8!)
        Me.TransactionLabel.Location = New System.Drawing.Point(465, 422)
        Me.TransactionLabel.Name = "TransactionLabel"
        Me.TransactionLabel.Size = New System.Drawing.Size(268, 26)
        Me.TransactionLabel.TabIndex = 19
        Me.TransactionLabel.Text = "Data Transaksi Konsumen"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.8!)
        Me.Label1.Location = New System.Drawing.Point(465, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 26)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Data Konsumen"
        '
        'DetailTransactionBtn
        '
        Me.DetailTransactionBtn.Enabled = False
        Me.DetailTransactionBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.DetailTransactionBtn.Location = New System.Drawing.Point(848, 21)
        Me.DetailTransactionBtn.Name = "DetailTransactionBtn"
        Me.DetailTransactionBtn.Size = New System.Drawing.Size(175, 53)
        Me.DetailTransactionBtn.TabIndex = 21
        Me.DetailTransactionBtn.Text = "Detail Transaksi"
        Me.DetailTransactionBtn.UseVisualStyleBackColor = True
        '
        'EmailBox
        '
        Me.EmailBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailBox.Location = New System.Drawing.Point(22, 294)
        Me.EmailBox.Name = "EmailBox"
        Me.EmailBox.Size = New System.Drawing.Size(424, 28)
        Me.EmailBox.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 24)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Email :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 345)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 24)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Alamat :"
        '
        'AlamatBox
        '
        Me.AlamatBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlamatBox.Location = New System.Drawing.Point(22, 372)
        Me.AlamatBox.Multiline = True
        Me.AlamatBox.Name = "AlamatBox"
        Me.AlamatBox.Size = New System.Drawing.Size(424, 99)
        Me.AlamatBox.TabIndex = 24
        '
        'SubmitBtn
        '
        Me.SubmitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.SubmitBtn.Location = New System.Drawing.Point(22, 531)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(424, 57)
        Me.SubmitBtn.TabIndex = 26
        Me.SubmitBtn.Text = " Submit"
        Me.SubmitBtn.UseVisualStyleBackColor = True
        '
        'DaftarKaryawanBtn
        '
        Me.DaftarKaryawanBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.DaftarKaryawanBtn.Location = New System.Drawing.Point(1188, 134)
        Me.DaftarKaryawanBtn.Name = "DaftarKaryawanBtn"
        Me.DaftarKaryawanBtn.Size = New System.Drawing.Size(321, 49)
        Me.DaftarKaryawanBtn.TabIndex = 27
        Me.DaftarKaryawanBtn.Text = "Daftar Karyawan"
        Me.DaftarKaryawanBtn.UseVisualStyleBackColor = True
        '
        'DaftarKonsumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1517, 721)
        Me.Controls.Add(Me.DaftarKaryawanBtn)
        Me.Controls.Add(Me.SubmitBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AlamatBox)
        Me.Controls.Add(Me.EmailBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DetailTransactionBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TransactionLabel)
        Me.Controls.Add(Me.ConsumentTransactionDataView)
        Me.Controls.Add(Me.NoTelponBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NamaBox)
        Me.Controls.Add(Me.FormLabel)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.ConsumentDataView)
        Me.Name = "DaftarKonsumen"
        Me.Text = "Daftar Konsumen"
        CType(Me.ConsumentDataView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsumentTransactionDataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DeleteBtn As System.Windows.Forms.Button
    Friend WithEvents AddBtn As System.Windows.Forms.Button
    Friend WithEvents ConsumentDataView As System.Windows.Forms.DataGridView
    Friend WithEvents FormLabel As System.Windows.Forms.Label
    Friend WithEvents NoTelponBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NamaBox As System.Windows.Forms.TextBox
    Friend WithEvents ConsumentTransactionDataView As System.Windows.Forms.DataGridView
    Friend WithEvents TransactionLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DetailTransactionBtn As System.Windows.Forms.Button
    Friend WithEvents EmailBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AlamatBox As System.Windows.Forms.TextBox
    Friend WithEvents SubmitBtn As System.Windows.Forms.Button
    Friend WithEvents DaftarKaryawanBtn As System.Windows.Forms.Button
End Class
