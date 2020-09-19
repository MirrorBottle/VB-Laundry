Public Class Login

    
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PasswordBox.PasswordChar = "*"
    End Sub


    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Me.Visible = False
        DaftarKaryawan.Visible = True
    End Sub
End Class
