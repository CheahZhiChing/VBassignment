Imports System.IO

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim months(11) As String
        months(0) = "Jan"
        months(1) = "Feb"
        months(2) = "Mar"
        months(3) = "Apr"
        months(4) = "May"
        months(5) = "Jun"
        months(6) = "Jul"
        months(7) = "Aug"
        months(8) = "Sep"
        months(9) = "Oct"
        months(10) = "Nov"
        months(11) = "Dec"

        Dim path As String = Application.StartupPath & "\form1.txt"
        File.WriteAllLines(path, months)
        MessageBox.Show("add complete.", "complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
