Imports System.IO
Public Class Form1

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = Char.IsDigit(e.KeyChar)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ListBox1.SelectedIndex = -1) Then
            MsgBox("EKLENECEK DERSİ SEÇİNİZ", 0, "HATA")
            Exit Sub
        End If
        If (ListBox2.Items.Count <= 2) Then




            ListBox2.Items.Add(ListBox1.SelectedItem)
            'ListBox1.Items.Remove(ListBox1.SelectedItem)
            'VEYA
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        Else
            MsgBox("EN FAZLA 3 DERS EKLENEBİLİR", 0, "HATA")

        End If
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = " EKLENEN DERS :" & ListBox2.Items.Count &
            " TANEDİR"

    End Sub
    Dim i As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'For Each dersler As String In ListBox1.Items
        '    ListBox2.Items.Add(dersler)

        'Next
        For i = 0 To ListBox1.Items.Count - 1
            ListBox2.Items.Add(ListBox1.Items(i))
        Next

        ListBox1.Items.Clear()

    End Sub
    Dim soru As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        soru = Convert.ToInt32(MessageBox.Show("KAYIT YAPILSIN MI",
        "KAYIT İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
        If (soru = DialogResult.Yes) Then
            Dim kaydet As New StreamWriter("bilgiler.txt", True)
            kaydet.WriteLine(TextBox1.Text + " İSİMLİ ÖĞRENCİNİN VERİLERİ AŞAĞIDADIR")
            kaydet.WriteLine(DateTime.Now & " TARİHİNDE KAYDEDİLMİŞTİR")
            kaydet.WriteLine("-------------------------------------------------------")
            For Each dersler As String In ListBox2.Items
                kaydet.WriteLine(dersler)

            Next
            kaydet.WriteLine("-------------------------------------------------------")
            kaydet.Close()
            MsgBox("ÖĞRENCİ BİLGİLERİ BAŞARIYLA KAYDEDİLDİ..")


        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()
    End Sub
End Class
