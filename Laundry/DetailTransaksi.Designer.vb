<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailTransaksi
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
        Me.TransactionDetailDataView = New System.Windows.Forms.DataGridView()
        Me.DetailTransactionLabel = New System.Windows.Forms.Label()
        Me.ConsumerNameLabel = New System.Windows.Forms.Label()
        Me.CostTotalLabel = New System.Windows.Forms.Label()
        Me.CostLabel = New System.Windows.Forms.Label()
        Me.DiscountLabel = New System.Windows.Forms.Label()
        CType(Me.TransactionDetailDataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TransactionDetailDataView
        '
        Me.TransactionDetailDataView.AllowUserToAddRows = False
        Me.TransactionDetailDataView.AllowUserToDeleteRows = False
        Me.TransactionDetailDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TransactionDetailDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TransactionDetailDataView.Location = New System.Drawing.Point(12, 248)
        Me.TransactionDetailDataView.Name = "TransactionDetailDataView"
        Me.TransactionDetailDataView.ReadOnly = True
        Me.TransactionDetailDataView.RowTemplate.Height = 24
        Me.TransactionDetailDataView.Size = New System.Drawing.Size(653, 273)
        Me.TransactionDetailDataView.TabIndex = 0
        '
        'DetailTransactionLabel
        '
        Me.DetailTransactionLabel.AutoSize = True
        Me.DetailTransactionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.8!)
        Me.DetailTransactionLabel.Location = New System.Drawing.Point(12, 9)
        Me.DetailTransactionLabel.Name = "DetailTransactionLabel"
        Me.DetailTransactionLabel.Size = New System.Drawing.Size(195, 29)
        Me.DetailTransactionLabel.TabIndex = 1
        Me.DetailTransactionLabel.Text = "Detail Transaksi"
        '
        'ConsumerNameLabel
        '
        Me.ConsumerNameLabel.AutoSize = True
        Me.ConsumerNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.8!)
        Me.ConsumerNameLabel.Location = New System.Drawing.Point(12, 62)
        Me.ConsumerNameLabel.Name = "ConsumerNameLabel"
        Me.ConsumerNameLabel.Size = New System.Drawing.Size(200, 26)
        Me.ConsumerNameLabel.TabIndex = 2
        Me.ConsumerNameLabel.Text = "Nama Konsumen : "
        '
        'CostTotalLabel
        '
        Me.CostTotalLabel.AutoSize = True
        Me.CostTotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.8!)
        Me.CostTotalLabel.Location = New System.Drawing.Point(12, 189)
        Me.CostTotalLabel.Name = "CostTotalLabel"
        Me.CostTotalLabel.Size = New System.Drawing.Size(132, 26)
        Me.CostTotalLabel.TabIndex = 3
        Me.CostTotalLabel.Text = "Total Biaya :"
        '
        'CostLabel
        '
        Me.CostLabel.AutoSize = True
        Me.CostLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.8!)
        Me.CostLabel.Location = New System.Drawing.Point(12, 145)
        Me.CostLabel.Name = "CostLabel"
        Me.CostLabel.Size = New System.Drawing.Size(79, 26)
        Me.CostLabel.TabIndex = 4
        Me.CostLabel.Text = "Biaya :"
        '
        'DiscountLabel
        '
        Me.DiscountLabel.AutoSize = True
        Me.DiscountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.8!)
        Me.DiscountLabel.Location = New System.Drawing.Point(12, 102)
        Me.DiscountLabel.Name = "DiscountLabel"
        Me.DiscountLabel.Size = New System.Drawing.Size(97, 26)
        Me.DiscountLabel.TabIndex = 5
        Me.DiscountLabel.Text = "Diskon : "
        '
        'DetailTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 533)
        Me.Controls.Add(Me.DiscountLabel)
        Me.Controls.Add(Me.CostLabel)
        Me.Controls.Add(Me.CostTotalLabel)
        Me.Controls.Add(Me.ConsumerNameLabel)
        Me.Controls.Add(Me.DetailTransactionLabel)
        Me.Controls.Add(Me.TransactionDetailDataView)
        Me.Name = "DetailTransaksi"
        Me.Text = "Detail Transaksi"
        CType(Me.TransactionDetailDataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TransactionDetailDataView As System.Windows.Forms.DataGridView
    Friend WithEvents DetailTransactionLabel As System.Windows.Forms.Label
    Friend WithEvents ConsumerNameLabel As System.Windows.Forms.Label
    Friend WithEvents CostTotalLabel As System.Windows.Forms.Label
    Friend WithEvents CostLabel As System.Windows.Forms.Label
    Friend WithEvents DiscountLabel As System.Windows.Forms.Label
End Class
