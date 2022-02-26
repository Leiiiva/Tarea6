Public Class Form1
    Private Sub btn_minus_a_Click(sender As Object, e As EventArgs) Handles btn_minus_a.Click
        lbl_num_a.Text = Minus(lbl_num_a.Text)
    End Sub

    Private Sub btn_plus_a_Click(sender As Object, e As EventArgs) Handles btn_plus_a.Click
        lbl_num_a.Text = Plus(lbl_num_a.Text)
    End Sub

    Private Sub btn_minus_b_Click(sender As Object, e As EventArgs) Handles btn_minus_b.Click
        lbl_num_b.Text = Minus(lbl_num_b.Text)
    End Sub

    Private Sub btn_plus_b_Click(sender As Object, e As EventArgs) Handles btn_plus_b.Click
        lbl_num_b.Text = Plus(lbl_num_b.Text)
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Calculadora(Convert.ToInt32(lbl_num_a.Text), Convert.ToInt32(lbl_num_b.Text), "add")
    End Sub

    Private Sub btn_substract_Click(sender As Object, e As EventArgs) Handles btn_substract.Click
        Calculadora(Convert.ToInt32(lbl_num_a.Text), Convert.ToInt32(lbl_num_b.Text), "substract")
    End Sub

    Private Sub btn_multiply_Click(sender As Object, e As EventArgs) Handles btn_multiply.Click
        Calculadora(Convert.ToInt32(lbl_num_a.Text), Convert.ToInt32(lbl_num_b.Text), "multiply")
    End Sub

    Private Sub btn_divide_Click(sender As Object, e As EventArgs) Handles btn_divide.Click
        Calculadora(Convert.ToDecimal(lbl_num_a.Text), Convert.ToDecimal(lbl_num_b.Text), "divide")
    End Sub

    Private Sub btn_clean_Click(sender As Object, e As EventArgs) Handles btn_clean.Click
        Clean()
    End Sub
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub
    Private Sub Clean()
        lbl_num_a.Text = "0"
        lbl_num_b.Text = "0"
    End Sub
    Function Plus(text As String)
        Dim number As Integer = Convert.ToInt32(text)
        Dim newnumber As String
        number = number + 1
        newnumber = number.ToString()
        Return newnumber
    End Function
    Function Minus(text As String)
        Dim number As Integer = Convert.ToInt32(text)
        Dim newnumber As String
        number = number - 1
        newnumber = number.ToString()
        Return newnumber
    End Function
    Private Sub Calculadora(a As Integer, b As Integer, operation As String)
        Dim r As Decimal
        Select Case operation
            Case = "add"
                r = a + b
            Case = "substract"
                r = a - b
            Case = "multiply"
                r = a * b
            Case = "divide"
                If (b <> 0) Then
                    r = a / b
                Else
                    MsgBox("Ingrese un numero B valido por favor.")
                End If
        End Select
        lbl_result.Text = r.ToString
    End Sub



End Class
