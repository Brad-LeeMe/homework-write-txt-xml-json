Imports System.IO
Imports System.Xml
Imports Newtonsoft.Json

Public Class Writer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtBTN_Click(sender As Object, e As EventArgs) Handles txtBTN.Click
        Dim writer As System.IO.StreamWriter
        writer = My.Computer.FileSystem.OpenTextFileWriter("C:\HW\" + filenameTB.Text + ".txt", True)
        writer.WriteLine("Name: " + nameTB.Text + Environment.NewLine + "Age: " + ageTB.Text + Environment.NewLine + "Address: " + AddressTB.Text)
        writer.Close()
        MessageBox.Show("TXT file saved.")
    End Sub

    Private Sub xmlBTN_Click(sender As Object, e As EventArgs) Handles xmlBTN.Click
        Dim xmlSettings As New XmlWriterSettings
        xmlSettings.Indent = True

        Dim writer As XmlWriter = XmlWriter.Create("C:\HW\" + filenameTB.Text + ".xml", xmlSettings)

        writer.WriteStartDocument()
        writer.WriteComment("New XML File")
        writer.WriteStartElement("Data")

        writer.WriteStartElement("Name")
        writer.WriteString(nameTB.Text)
        writer.WriteEndElement()

        writer.WriteStartElement("Age")
        writer.WriteString(ageTB.Text)
        writer.WriteEndElement()

        writer.WriteStartElement("Address")
        writer.WriteString(AddressTB.Text)
        writer.WriteEndElement()

        writer.WriteEndElement()
        writer.WriteEndDocument()
        writer.Close()

        MessageBox.Show("XML file saved.")
    End Sub

    Private Sub jsonBTN_Click(sender As Object, e As EventArgs) Handles jsonBTN.Click
        Dim data As New Data()
        data.Name = nameTB.Text
        data.Age = ageTB.Text
        data.Address = AddressTB.Text

        Dim json As String = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented)
        Dim writer As IO.StreamWriter
        writer = My.Computer.FileSystem.OpenTextFileWriter("C:\HW\" + filenameTB.Text + ".json", True)
        writer.WriteLine(json)
        writer.Close()
        MessageBox.Show("JSON file saved.")
    End Sub


End Class

