<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_menu
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
        Me.cmdjjjCancel = New System.Windows.Forms.Button()
        Me.cmdLogin = New System.Windows.Forms.Button()
        Me.cmdRegister = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Welcome to Car Price Information Center!"
        '
        'cmdjjjCancel
        '
        Me.cmdjjjCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdjjjCancel.Image = Global.CarPriceInformationCenter_May2_without_register.My.Resources.Resources.exit2
        Me.cmdjjjCancel.Location = New System.Drawing.Point(386, 185)
        Me.cmdjjjCancel.Name = "cmdjjjCancel"
        Me.cmdjjjCancel.Size = New System.Drawing.Size(85, 45)
        Me.cmdjjjCancel.TabIndex = 7
        Me.cmdjjjCancel.UseVisualStyleBackColor = True
        '
        'cmdLogin
        '
        Me.cmdLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogin.Image = Global.CarPriceInformationCenter_May2_without_register.My.Resources.Resources.login
        Me.cmdLogin.Location = New System.Drawing.Point(234, 185)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(125, 45)
        Me.cmdLogin.TabIndex = 6
        Me.cmdLogin.UseVisualStyleBackColor = True
        '
        'cmdRegister
        '
        Me.cmdRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRegister.Image = Global.CarPriceInformationCenter_May2_without_register.My.Resources.Resources.register
        Me.cmdRegister.Location = New System.Drawing.Point(103, 185)
        Me.cmdRegister.Name = "cmdRegister"
        Me.cmdRegister.Size = New System.Drawing.Size(125, 45)
        Me.cmdRegister.TabIndex = 5
        Me.cmdRegister.UseVisualStyleBackColor = True
        '
        'main_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 368)
        Me.Controls.Add(Me.cmdjjjCancel)
        Me.Controls.Add(Me.cmdLogin)
        Me.Controls.Add(Me.cmdRegister)
        Me.Controls.Add(Me.Label1)
        Me.Name = "main_menu"
        Me.Text = "Welcome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdjjjCancel As System.Windows.Forms.Button
    Friend WithEvents cmdLogin As System.Windows.Forms.Button
    Friend WithEvents cmdRegister As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
