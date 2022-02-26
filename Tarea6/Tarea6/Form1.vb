Public Class Form1
    Private Sub btn_minus_a_Click(sender As Object, e As EventArgs) Handles btn_minus_a.Click
        lbl_num_a.Text = Convert.ToInt32(lbl_num_a.Text) - 1
    End Sub

    Private Sub btn_plus_a_Click(sender As Object, e As EventArgs) Handles btn_plus_a.Click
        lbl_num_a.Text = Convert.ToInt32(lbl_num_a.Text) + 1
    End Sub

    Private Sub btn_minus_b_Click(sender As Object, e As EventArgs) Handles btn_minus_b.Click
        lbl_num_b.Text = Convert.ToInt32(lbl_num_b.Text) - 1
    End Sub

    Private Sub btn_plus_b_Click(sender As Object, e As EventArgs) Handles btn_plus_b.Click
        lbl_num_b.Text = Convert.ToInt32(lbl_num_b.Text) + 1
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim a, b, r As Integer
        a = Convert.ToInt32(lbl_num_a.Text)
        b = Convert.ToInt32(lbl_num_b.Text)
        r = a + b
        lbl_result.Text = r.ToString
    End Sub

    Private Sub btn_substract_Click(sender As Object, e As EventArgs) Handles btn_substract.Click
        Dim a, b, r As Integer
        a = Convert.ToInt32(lbl_num_a.Text)
        b = Convert.ToInt32(lbl_num_b.Text)
        r = a - b
        lbl_result.Text = r.ToString
    End Sub
End Class
