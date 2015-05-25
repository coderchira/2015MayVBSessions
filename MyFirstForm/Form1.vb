Public Class Form1

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        MessageBox.Show("Form has been clicked")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSubmit.Text = "SubmitNow"

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.ForeColor = Color.Red
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        MessageBox.Show("Button is clicked")
    End Sub
End Class
