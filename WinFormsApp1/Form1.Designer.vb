<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(259, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 15)
        Label1.TabIndex = 1
        Label1.Text = "Chọn thời gian"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"2023-11-27 00:00:00"})
        ComboBox1.Location = New Point(351, 40)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(164, 23)
        ComboBox1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(259, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(31, 15)
        Label2.TabIndex = 4
        Label2.Text = "Path"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(351, 90)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(164, 23)
        TextBox1.TabIndex = 5
        TextBox1.Text = "C:\Users\v2202\Downloads"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(211, 166)
        Button1.Name = "Button1"
        Button1.Size = New Size(97, 29)
        Button1.TabIndex = 6
        Button1.Text = "Xóa"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(436, 166)
        Button2.Name = "Button2"
        Button2.Size = New Size(97, 29)
        Button2.TabIndex = 7
        Button2.Text = "Thoát"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(525, 92)
        Button3.Name = "Button3"
        Button3.Size = New Size(34, 22)
        Button3.TabIndex = 8
        Button3.Text = "...."
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        MaximizeBox = False
        Name = "Form1"
        Text = "Ví dụ về xóa file"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
