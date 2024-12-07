Public Class Form2

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = Char.IsLetter(e.KeyChar)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text.Trim())
        TextBox1.Clear()

    End Sub
    Dim toplam As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        toplam = 0
        For Each degerler As Integer In ListBox1.Items
            toplam = toplam + degerler
        Next
        TextBox2.Text = "TOPLAMLARI   :" & toplam.ToString("c2")

    End Sub
End Class