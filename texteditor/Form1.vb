Imports System.IO ' Pastikan Anda mengimpor namespace ini

Public Class Form1
    ' Event handler untuk membuka folder dan menampilkan daftar file .txt
    Private Sub OpenFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFolderToolStripMenuItem.Click
        Using folderBrowserDialog As New FolderBrowserDialog()
            If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                Try
                    listBoxFiles.Items.Clear() ' Hapus item yang ada
                    Dim files As String() = Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.txt")
                    If files.Length > 0 Then
                        For Each file In files
                            listBoxFiles.Items.Add(Path.GetFileName(file)) ' Tambahkan nama file ke ListBox
                        Next
                    Else
                        MessageBox.Show("Tidak ada file .txt ditemukan di folder yang dipilih.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message)
                End Try
            End If
        End Using
    End Sub

    ' Event handler saat item di ListBox diklik
    Private Sub ListBoxFiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBoxFiles.SelectedIndexChanged
        If listBoxFiles.SelectedItem IsNot Nothing Then
            Dim selectedFile As String = listBoxFiles.SelectedItem.ToString()
            Dim folderPath As String = Path.GetDirectoryName(Directory.GetCurrentDirectory())
            Dim fullPath As String = Path.Combine(folderPath, selectedFile)

            If File.Exists(fullPath) Then
                txteditor.Text = File.ReadAllText(fullPath) ' Baca dan tampilkan isi file
            End If
        End If
    End Sub

    ' Event handler untuk menyimpan file .txt
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Using saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                File.WriteAllText(saveFileDialog.FileName, txteditor.Text)
            End If
        End Using
    End Sub

    ' Event handler untuk keluar dari aplikasi
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

End Class
