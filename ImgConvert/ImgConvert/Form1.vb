Public Class Form1
    Private fbdPicture As New FolderBrowserDialog()
    Private ofdPicture As New OpenFileDialog()




    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbFormats.SelectedItem = "BMP"
    End Sub

    Private Sub btnOpenImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenImage.Click
        Try
            Static i As Integer = 0
            If ofdPicture.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
                For Each f As String In ofdPicture.FileNames
                    dgvFiles.Rows.Insert(i)
                    dgvFiles.Rows(i).SetValues(f)
                    i += 1
                Next
            End If
            i = 0
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub dgvFiles_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFiles.CellContentClick
        If dgvFiles.SelectedRows.Count > 0 Then
            pbPreview.Image = Image.FromFile(dgvFiles.Item(0, dgvFiles.SelectedRows.Item(0).Index).Value)
        End If
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If dgvFiles.SelectedRows.Count > 0 Then
            dgvFiles.Rows.RemoveAt(dgvFiles.SelectedRows.Item(0).Index)
        End If
    End Sub

    Private Sub btnClearList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearList.Click
        If dgvFiles.Rows.Count > 0 Then
            dgvFiles.Rows.Clear()
        End If
    End Sub

    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        If dgvFiles.Rows.Count > 0 And fbdPicture.ShowDialog <> DialogResult.Cancel Then
            Dim j As Integer = 0
            Dim spath As String = ""
            Dim fpath As String = fbdPicture.SelectedPath
            For j = 0 To dgvFiles.Rows.Count - 1
                spath = fpath & "\" & dgvFiles.Item(0, j).Value.ToString.Substring(dgvFiles.Item(0, j).Value.ToString.LastIndexOf("\") + 1, (dgvFiles.Item(0, j).Value.ToString.LastIndexOf(".") - dgvFiles.Item(0, j).Value.ToString.LastIndexOf("\")) - 1)
                pbPreview.Image = Image.FromFile(dgvFiles.Item(0, j).Value.ToString)
                If cmbFormats.SelectedItem = "BMP" Then pbPreview.Image.Save(spath & ".bmp", System.Drawing.Imaging.ImageFormat.Bmp)
                If cmbFormats.SelectedItem = "PNG" Then pbPreview.Image.Save(spath & ".png", System.Drawing.Imaging.ImageFormat.Png)
                If cmbFormats.SelectedItem = "GIF" Then pbPreview.Image.Save(spath & ".gif", System.Drawing.Imaging.ImageFormat.Gif)
                If cmbFormats.SelectedItem = "TIFF" Then pbPreview.Image.Save(spath & ".tiff", System.Drawing.Imaging.ImageFormat.Tiff)
                If cmbFormats.SelectedItem = "JPG" Then pbPreview.Image.Save(spath & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                spath = ""
            Next
            j = 0
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://algyazilim.com")
    End Sub
End Class
