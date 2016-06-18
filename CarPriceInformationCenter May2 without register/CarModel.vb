Public Class CarModel

    Private Sub CarModel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Project_May3_dataDataSet.ModelSearch' table. You can move, or remove it, as needed.
        Me.ModelSearchTableAdapter1.Fill(Me.Project_May3_dataDataSet.ModelSearch)
        'TODO: This line of code loads data into the 'Project_May2_dataDataSet.ModelSearch' table. You can move, or remove it, as needed.
        Me.ModelSearchTableAdapter.Fill(Me.Project_May2_dataDataSet.ModelSearch)

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        main_menu.Show()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.ModelSearchTableAdapter.FillByaudiiii(Me.Project_May2_dataDataSet.ModelSearch)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim value As String
        value = TextBox1.Text
        Dim SearchObj As New StoreDiscount
        SearchObj.Show()
        SearchObj.Button6_Click(value)
        Me.Hide()
    End Sub

    Private Sub FillByaudiToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.ModelSearchTableAdapter1.FillByaudi(Me.Project_May3_dataDataSet.ModelSearch)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.ModelSearchTableAdapter1.FillByaudi(Me.Project_May3_dataDataSet.ModelSearch)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Manufacturer.Show()

    End Sub

    Private Sub Button4_Click_1(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        StoreDiscount.Show()

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        StoreDiscount.Show()

    End Sub

    Private Sub FillByaudi2ToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.ModelSearchTableAdapter.FillByaudi2(Me.Project_May2_dataDataSet.ModelSearch)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByaudi3ToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.ModelSearchTableAdapter1.FillByaudi3(Me.Project_May3_dataDataSet.ModelSearch)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByaudi3ToolStrip_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Try
            Me.ModelSearchTableAdapter1.FillByaudi3(Me.Project_May3_dataDataSet.ModelSearch)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FillBymanToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.ModelSearchTableAdapter.FillByman(Me.Project_May2_dataDataSet.ModelSearch)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByman1ToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.ModelSearchTableAdapter.FillByman1(Me.Project_May2_dataDataSet.ModelSearch, MAN_NAMEToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub MAN_NAMEToolStripLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub MAN_NAMEToolStripTextBox_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Me.ModelSearchTableAdapter1.Fill(Me.Project_May3_dataDataSet.ModelSearch)
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.ModelSearchTableAdapter.FillByman11(Me.Project_May2_dataDataSet.ModelSearch, MAN_NAMEToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub MAN_NAMEToolStripLabel_Click_1(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub FillByman11ToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.ModelSearchTableAdapter1.FillByman11(Me.Project_May3_dataDataSet.ModelSearch, MAN_NAMEToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button8_Click_1(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Try
            Me.ModelSearchTableAdapter1.FillByman11(Me.Project_May3_dataDataSet.ModelSearch, MAN_NAMEToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub Button8_Click_1()
        Throw New NotImplementedException
    End Sub

    Sub Button8_Click_1(p1 As String)
        Try
            Me.ModelSearchTableAdapter1.FillByman11(Me.Project_May3_dataDataSet.ModelSearch, p1)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim value As Object = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        Dim row As DataGridViewRow
        row = Me.DataGridView1.Rows(e.RowIndex)

        If IsDBNull(value) Then
            TextBox1.Text = "" ' blank if dbnull values
        Else
            TextBox1.Text = row.Cells(1).Value.ToString
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class