Public Class StoreDiscount

    Private Sub StoreDiscount_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Project_May3_dataDataSet.StoreSearch' table. You can move, or remove it, as needed.
        Me.StoreSearchTableAdapter.Fill(Me.Project_May3_dataDataSet.StoreSearch)

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        StoreInfo.Show()

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        CarModel.Show()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        main_menu.Show()

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        StoreInfo.Show()

    End Sub

    Private Sub FillByq7ToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.StoreSearchTableAdapter.FillByq7(Me.Project_May3_dataDataSet.StoreSearch)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Me.StoreSearchTableAdapter.Fill(Me.Project_May3_dataDataSet.StoreSearch)
    End Sub

    Private Sub FillByModelToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.StoreSearchTableAdapter.FillByModel(Me.Project_May3_dataDataSet.StoreSearch, MODEL_NAMEToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Try
            Me.StoreSearchTableAdapter.FillByModel(Me.Project_May3_dataDataSet.StoreSearch, MODEL_NAMEToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub Button6_Click(p2 As String)
        Try
            Me.StoreSearchTableAdapter.FillByModel(Me.Project_May3_dataDataSet.StoreSearch, p2)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim value As String
        value = TextBox1.Text
        Dim SearchObj As New StoreInfo
        SearchObj.Show()
        SearchObj.Button8_Click(value)
        Me.Hide()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim value As Object = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        Dim row As DataGridViewRow
        row = Me.DataGridView1.Rows(e.RowIndex)

        If IsDBNull(value) Then
            TextBox1.Text = "" ' blank if dbnull values
        Else
            TextBox1.Text = row.Cells(1).Value.ToString
        End If

    End Sub

    Private Sub FillBycityToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.StoreSearchTableAdapter.FillBycity(Me.Project_May3_dataDataSet.StoreSearch)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBydiscountToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.StoreSearchTableAdapter.FillBydiscount(Me.Project_May3_dataDataSet.StoreSearch)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBycity1ToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.StoreSearchTableAdapter.FillBycity1(Me.Project_May3_dataDataSet.StoreSearch)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBydiscount1ToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.StoreSearchTableAdapter.FillBydiscount1(Me.Project_May3_dataDataSet.StoreSearch)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FilterByDiscountToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles FilterByDiscountToolStripButton.Click
        Try
            Me.StoreSearchTableAdapter.FilterByDiscount(Me.Project_May3_dataDataSet.StoreSearch)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class