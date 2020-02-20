Imports System.IO
Imports System.Xml
Imports Newtonsoft.Json

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtBTN_Click(sender As Object, e As EventArgs) Handles txtBTN.Click
        Dim writer As System.IO.StreamWriter
        writer = My.Computer.FileSystem.OpenTextFileWriter("C:\HW\" + filenameTB.Text + ".txt", True)
        writer.WriteLine("Name: " + nameTB.Text)
        writer.WriteLine("Age: " + ageTB.Text)
        writer.WriteLine("Address: " + AddressTB.Text)
        writer.Close()
        MessageBox.Show("TXT file saved.")
    End Sub
End Class
