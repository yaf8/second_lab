Public Class Form3
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedIndex

            Case 0
                TextBox1.Text = "+"
            Case 1
                TextBox1.Text = "*"
            Case 2
                TextBox1.Text = "-"
            Case 3
                TextBox1.Text = "/"
            Case 4
                TextBox1.Text = "\ "
            Case 5
                TextBox1.Text = "%"
            Case 6
                TextBox1.Text = "^"

        End Select

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("addition")
        ListBox1.Items.Add("multiplication")
        ListBox1.Items.Add("subtraction")
        ListBox1.Items.Add("division")
        ListBox1.Items.Add("integer division")
        ListBox1.Items.Add("remender")
        ListBox1.Items.Add("exponet")

    End Sub
End Class