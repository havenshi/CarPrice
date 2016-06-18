Public Class Manufacturer

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Me.Hide()
        CarModel.Show()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        main_menu.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        Dim SearchObj As New CarModel
        SearchObj.Show()
        SearchObj.Button8_Click_1("Lexus")
        Me.Hide()
    End Sub

    Private Sub Button3_Click_1(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim SearchObj As New CarModel
        SearchObj.Show()
        SearchObj.Button8_Click_1("Audi")
        Me.Hide()

    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        Me.Hide()
        CarModel.Show()

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button4_Click_1(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim SearchObj As New CarModel
        SearchObj.Show()
        SearchObj.Button8_Click_1("Buick")
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim SearchObj As New CarModel
        SearchObj.Show()
        SearchObj.Button8_Click_1("Cadillac")
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Dim SearchObj As New CarModel
        SearchObj.Show()
        SearchObj.Button8_Click_1("Chrysler")
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Dim SearchObj As New CarModel
        SearchObj.Show()
        SearchObj.Button8_Click_1("Dodge")
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Dim SearchObj As New CarModel
        SearchObj.Show()
        SearchObj.Button8_Click_1("Ford")
        Me.Hide()
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        Dim SearchObj As New CarModel
        SearchObj.Show()
        SearchObj.Button8_Click_1("Honda")
        Me.Hide()
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        Dim SearchObj As New CarModel
        SearchObj.Show()
        SearchObj.Button8_Click_1("Nissan")
        Me.Hide()
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Dim SearchObj As New CarModel
        SearchObj.Show()
        SearchObj.Button8_Click_1("Tesla")
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Dim SearchObj As New CarModel
        SearchObj.Show()
        SearchObj.Button8_Click_1("Toyota")
        Me.Hide()
    End Sub
End Class