<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DaftarKaryawan
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
        Me.DataView = New System.Windows.Forms.DataGridView()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.NikBox = New System.Windows.Forms.TextBox()
        Me.FormLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NamaBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.AlamatBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NoTelponBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ManGenderRadioButton = New System.Windows.Forms.RadioButton()
        Me.WomanGenderRadioButton = New System.Windows.Forms.RadioButton()
        Me.DaftarKonsumenBtn = New System.Windows.Forms.Button()
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataView
        '
        Me.DataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataView.Location = New System.Drawing.Point(472, 89)
        Me.DataView.MultiSelect = False
        Me.DataView.Name = "DataView"
        Me.DataView.RowTemplate.Height = 24
        Me.DataView.Size = New System.Drawing.Size(712, 547)
        Me.DataView.TabIndex = 0
        '
        'AddBtn
        '
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.Location = New System.Drawing.Point(472, 25)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(183, 53)
        Me.AddBtn.TabIndex = 1
        Me.AddBtn.Text = "Tambah"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.Location = New System.Drawing.Point(661, 25)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(183, 53)
        Me.DeleteBtn.TabIndex = 3
        Me.DeleteBtn.Text = "Hapus"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'NikBox
        '
        Me.NikBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NikBox.Location = New System.Drawing.Point(18, 116)
        Me.NikBox.Name = "NikBox"
        Me.NikBox.Size = New System.Drawing.Size(424, 28)
        Me.NikBox.TabIndex = 4
        '
        'FormLabel
        '
        Me.FormLabel.AutoSize = True
        Me.FormLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormLabel.Location = New System.Drawing.Point(12, 29)
        Me.FormLabel.Name = "FormLabel"
        Me.FormLabel.Size = New System.Drawing.Size(191, 36)
        Me.FormLabel.TabIndex = 5
        Me.FormLabel.Text = "Tambah Data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "NIK :"
        '
        'NamaBox
        '
        Me.NamaBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaBox.Location = New System.Drawing.Point(18, 196)
        Me.NamaBox.Name = "NamaBox"
        Me.NamaBox.Size = New System.Drawing.Size(424, 28)
        Me.NamaBox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nama :"
        '
        'SubmitBtn
        '
        Me.SubmitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.SubmitBtn.Location = New System.Drawing.Point(18, 579)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(424, 57)
        Me.SubmitBtn.TabIndex = 9
        Me.SubmitBtn.Text = " Submit"
        Me.SubmitBtn.UseVisualStyleBackColor = True
        '
        'AlamatBox
        '
        Me.AlamatBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlamatBox.Location = New System.Drawing.Point(18, 350)
        Me.AlamatBox.Multiline = True
        Me.AlamatBox.Name = "AlamatBox"
        Me.AlamatBox.Size = New System.Drawing.Size(424, 99)
        Me.AlamatBox.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 323)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 24)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Alamat :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 24)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "No.Telpon :"
        '
        'NoTelponBox
        '
        Me.NoTelponBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoTelponBox.Location = New System.Drawing.Point(18, 275)
        Me.NoTelponBox.Name = "NoTelponBox"
        Me.NoTelponBox.Size = New System.Drawing.Size(424, 28)
        Me.NoTelponBox.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 466)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 24)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Jenis Kelamin :"
        '
        'ManGenderRadioButton
        '
        Me.ManGenderRadioButton.AutoSize = True
        Me.ManGenderRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.ManGenderRadioButton.Location = New System.Drawing.Point(19, 503)
        Me.ManGenderRadioButton.Name = "ManGenderRadioButton"
        Me.ManGenderRadioButton.Size = New System.Drawing.Size(97, 28)
        Me.ManGenderRadioButton.TabIndex = 16
        Me.ManGenderRadioButton.TabStop = True
        Me.ManGenderRadioButton.Text = "Laki-laki"
        Me.ManGenderRadioButton.UseVisualStyleBackColor = True
        '
        'WomanGenderRadioButton
        '
        Me.WomanGenderRadioButton.AutoSize = True
        Me.WomanGenderRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.WomanGenderRadioButton.Location = New System.Drawing.Point(154, 503)
        Me.WomanGenderRadioButton.Name = "WomanGenderRadioButton"
        Me.WomanGenderRadioButton.Size = New System.Drawing.Size(130, 28)
        Me.WomanGenderRadioButton.TabIndex = 17
        Me.WomanGenderRadioButton.TabStop = True
        Me.WomanGenderRadioButton.Text = "Perempuan"
        Me.WomanGenderRadioButton.UseVisualStyleBackColor = True
        '
        'DaftarKonsumenBtn
        '
        Me.DaftarKonsumenBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.DaftarKonsumenBtn.Location = New System.Drawing.Point(1190, 89)
        Me.DaftarKonsumenBtn.Name = "DaftarKonsumenBtn"
        Me.DaftarKonsumenBtn.Size = New System.Drawing.Size(321, 49)
        Me.DaftarKonsumenBtn.TabIndex = 18
        Me.DaftarKonsumenBtn.Text = "Daftar Konsumen"
        Me.DaftarKonsumenBtn.UseVisualStyleBackColor = True
        '
        'DaftarKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1517, 721)
        Me.Controls.Add(Me.DaftarKonsumenBtn)
        Me.Controls.Add(Me.WomanGenderRadioButton)
        Me.Controls.Add(Me.ManGenderRadioButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NoTelponBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AlamatBox)
        Me.Controls.Add(Me.SubmitBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NamaBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FormLabel)
        Me.Controls.Add(Me.NikBox)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.DataView)
        Me.Name = "DaftarKaryawan"
        Me.Text = "Daftar Karyawan"
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataView As System.Windows.Forms.DataGridView
    Friend WithEvents AddBtn As System.Windows.Forms.Button
    Friend WithEvents DeleteBtn As System.Windows.Forms.Button
    Friend WithEvents NikBox As System.Windows.Forms.TextBox
    Friend WithEvents FormLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NamaBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SubmitBtn As System.Windows.Forms.Button
    Friend WithEvents AlamatBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NoTelponBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ManGenderRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents WomanGenderRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents DaftarKonsumenBtn As System.Windows.Forms.Button
End Class
