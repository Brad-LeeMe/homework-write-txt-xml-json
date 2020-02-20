<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nameTB = New System.Windows.Forms.TextBox()
        Me.txtBTN = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ageTB = New System.Windows.Forms.TextBox()
        Me.AddressTB = New System.Windows.Forms.TextBox()
        Me.xmlBTN = New System.Windows.Forms.Button()
        Me.jsonBTN = New System.Windows.Forms.Button()
        Me.filenameTB = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(172, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nameTB
        '
        Me.nameTB.Location = New System.Drawing.Point(261, 29)
        Me.nameTB.Name = "nameTB"
        Me.nameTB.Size = New System.Drawing.Size(100, 20)
        Me.nameTB.TabIndex = 1
        '
        'txtBTN
        '
        Me.txtBTN.Location = New System.Drawing.Point(126, 168)
        Me.txtBTN.Name = "txtBTN"
        Me.txtBTN.Size = New System.Drawing.Size(75, 23)
        Me.txtBTN.TabIndex = 2
        Me.txtBTN.Text = "txt"
        Me.txtBTN.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(172, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Age:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(172, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Address:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ageTB
        '
        Me.ageTB.Location = New System.Drawing.Point(261, 63)
        Me.ageTB.Name = "ageTB"
        Me.ageTB.Size = New System.Drawing.Size(100, 20)
        Me.ageTB.TabIndex = 5
        '
        'AddressTB
        '
        Me.AddressTB.Location = New System.Drawing.Point(261, 98)
        Me.AddressTB.Name = "AddressTB"
        Me.AddressTB.Size = New System.Drawing.Size(100, 20)
        Me.AddressTB.TabIndex = 6
        '
        'xmlBTN
        '
        Me.xmlBTN.Location = New System.Drawing.Point(245, 168)
        Me.xmlBTN.Name = "xmlBTN"
        Me.xmlBTN.Size = New System.Drawing.Size(75, 23)
        Me.xmlBTN.TabIndex = 7
        Me.xmlBTN.Text = "xml"
        Me.xmlBTN.UseVisualStyleBackColor = True
        '
        'jsonBTN
        '
        Me.jsonBTN.Location = New System.Drawing.Point(362, 168)
        Me.jsonBTN.Name = "jsonBTN"
        Me.jsonBTN.Size = New System.Drawing.Size(75, 23)
        Me.jsonBTN.TabIndex = 8
        Me.jsonBTN.Text = "json"
        Me.jsonBTN.UseVisualStyleBackColor = True
        '
        'filenameTB
        '
        Me.filenameTB.Location = New System.Drawing.Point(261, 133)
        Me.filenameTB.Name = "filenameTB"
        Me.filenameTB.Size = New System.Drawing.Size(100, 20)
        Me.filenameTB.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 359)
        Me.Controls.Add(Me.filenameTB)
        Me.Controls.Add(Me.jsonBTN)
        Me.Controls.Add(Me.xmlBTN)
        Me.Controls.Add(Me.AddressTB)
        Me.Controls.Add(Me.ageTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBTN)
        Me.Controls.Add(Me.nameTB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents nameTB As TextBox
    Friend WithEvents txtBTN As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ageTB As TextBox
    Friend WithEvents AddressTB As TextBox
    Friend WithEvents xmlBTN As Button
    Friend WithEvents jsonBTN As Button
    Friend WithEvents filenameTB As TextBox
End Class
