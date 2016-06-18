Public Class StoreInfo

    Private Sub STORESBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles STORESBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.STORESBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_May2_dataDataSet1)

    End Sub

    Private Sub StoreInfo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Project_May2_dataDataSet1.STORES' table. You can move, or remove it, as needed.
        Me.STORESTableAdapter.Fill(Me.Project_May2_dataDataSet1.STORES)

    End Sub

    Private Sub STORE_CITYTextBox_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub STORE_CITYLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub STORE_STATETextBox_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub STORE_STATELabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        main_menu.Show()

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        StoreDiscount.Show()

    End Sub

    Private Sub FillBystoreToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.STORESTableAdapter.FillBystore(Me.Project_May2_dataDataSet1.STORES, STORE_NAMEToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Try
            Me.STORESTableAdapter.FillBystore(Me.Project_May2_dataDataSet1.STORES, STORE_NAMEToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub Button8_Click(p1 As String)
        Try
            Me.STORESTableAdapter.FillBystore(Me.Project_May2_dataDataSet1.STORES, p1)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Me.STORESTableAdapter.Fill(Me.Project_May2_dataDataSet1.STORES)
    End Sub
End Class