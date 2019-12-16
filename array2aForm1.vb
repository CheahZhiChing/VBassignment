Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim student(7) As String
        student(0) = "Gary"
        student(1) = "Bella"
        student(2) = "Joan"
        student(3) = "Cloee"
        student(4) = "Elia"
        student(5) = "Mark"
        student(6) = "Alan"
        For i = 0 To 6
            ListBox1.Items.Add(student(i))
        Next
    End Sub
End Class
