Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim course(5) As String
        course(0) = "Calculus"
        course(1) = "Principles of Managemnet"
        course(2) = "Discrete Mathematics"
        course(3) = "Programming in Business Applications"
        course(4) = "Malaysian Nationhood Studies"
        For i = 0 To 4
            ListBox1.Items.Add(course(i))
        Next
    End Sub
End Class
