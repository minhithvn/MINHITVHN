Imports System.ComponentModel
Imports System.IO
Public Class Form1
    Private selectedTime As DateTime
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("2023-11-27 00:00:00")
        ComboBox1.Items.Add("2023-10-27 00:00:00")
        ComboBox1.Items.Add("2023-09-27 00:00:00")
        ComboBox1.SelectedIndex = 0
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Lấy đường dẫn từ TextBox
        Dim filePath As String = TextBox1.Text

        ' Kiểm tra xem có đường dẫn nào được nhập không
        If String.IsNullOrEmpty(filePath) Then
            MessageBox.Show("Vui lòng chọn đường dẫn file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Kiểm tra xem mốc thời gian đã được chọn chưa
        If ComboBox1.SelectedIndex = 0 Then
            MessageBox.Show("Vui lòng chọn mốc thời gian.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Kiểm tra thời gian của tệp
        Dim fileInfo As New FileInfo(filePath)
        If fileInfo.LastWriteTime >= selectedTime Then
            ' Nếu thỏa mãn điều kiện thời gian, thực hiện lệnh xóa
            Try
                File.Delete(filePath)
                MessageBox.Show("Đã xóa file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Không thể xóa file: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("File không nằm trong khoảng thời gian được chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Mở hộp thoại duyệt đường dẫn và cập nhật TextBox
        Dim folderBrowserDialog As New FolderBrowserDialog()
        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = folderBrowserDialog.SelectedPath
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Lấy thời gian từ ComboBox khi một mốc thời gian được chọn
        If ComboBox1.SelectedIndex > 0 Then
            selectedTime = DateTime.ParseExact(ComboBox1.SelectedItem.ToString(), "yyyy-MM-dd HH:mm:ss", Nothing)
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        ' Hiển thị hộp thoại Yes/No khi người dùng cố gắng đóng form
        Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Kiểm tra kết quả của hộp thoại
        If result = DialogResult.No Then
            ' Ngăn chặn sự kiện đóng nếu người dùng chọn No
            e.Cancel = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class


