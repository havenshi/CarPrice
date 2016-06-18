<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StoreDiscount
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ORDERCHECKDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.STORENAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STORECITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DISCOUNTTOTALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MODELNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StoreSearchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Project_May3_dataDataSet = New CarPriceInformationCenter_May2_without_register.project_May3_dataDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.StoreSearchTableAdapter = New CarPriceInformationCenter_May2_without_register.project_May3_dataDataSetTableAdapters.StoreSearchTableAdapter()
        Me.FillByModelToolStrip = New System.Windows.Forms.ToolStrip()
        Me.MODEL_NAMEToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.MODEL_NAMEToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FilterByDiscountToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FilterByDiscountToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoreSearchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Project_May3_dataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByModelToolStrip.SuspendLayout()
        Me.FilterByDiscountToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 355)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 25)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Click Here to See Details of"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(311, 25)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Find Your Favorite Store/Discount:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ORDERCHECKDataGridViewCheckBoxColumn, Me.STORENAMEDataGridViewTextBoxColumn, Me.STORECITYDataGridViewTextBoxColumn, Me.DISCOUNTTOTALDataGridViewTextBoxColumn, Me.MODELNAMEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StoreSearchBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(90, 110)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(560, 215)
        Me.DataGridView1.TabIndex = 33
        '
        'ORDERCHECKDataGridViewCheckBoxColumn
        '
        Me.ORDERCHECKDataGridViewCheckBoxColumn.DataPropertyName = "ORDER_CHECK"
        Me.ORDERCHECKDataGridViewCheckBoxColumn.HeaderText = "ORDER_CHECK"
        Me.ORDERCHECKDataGridViewCheckBoxColumn.Name = "ORDERCHECKDataGridViewCheckBoxColumn"
        '
        'STORENAMEDataGridViewTextBoxColumn
        '
        Me.STORENAMEDataGridViewTextBoxColumn.DataPropertyName = "STORE_NAME"
        Me.STORENAMEDataGridViewTextBoxColumn.HeaderText = "STORE_NAME"
        Me.STORENAMEDataGridViewTextBoxColumn.Name = "STORENAMEDataGridViewTextBoxColumn"
        '
        'STORECITYDataGridViewTextBoxColumn
        '
        Me.STORECITYDataGridViewTextBoxColumn.DataPropertyName = "STORE_CITY"
        Me.STORECITYDataGridViewTextBoxColumn.HeaderText = "STORE_CITY"
        Me.STORECITYDataGridViewTextBoxColumn.Name = "STORECITYDataGridViewTextBoxColumn"
        '
        'DISCOUNTTOTALDataGridViewTextBoxColumn
        '
        Me.DISCOUNTTOTALDataGridViewTextBoxColumn.DataPropertyName = "DISCOUNT_TOTAL"
        Me.DISCOUNTTOTALDataGridViewTextBoxColumn.HeaderText = "DISCOUNT_TOTAL"
        Me.DISCOUNTTOTALDataGridViewTextBoxColumn.Name = "DISCOUNTTOTALDataGridViewTextBoxColumn"
        '
        'MODELNAMEDataGridViewTextBoxColumn
        '
        Me.MODELNAMEDataGridViewTextBoxColumn.DataPropertyName = "MODEL_NAME"
        Me.MODELNAMEDataGridViewTextBoxColumn.HeaderText = "MODEL_NAME"
        Me.MODELNAMEDataGridViewTextBoxColumn.Name = "MODELNAMEDataGridViewTextBoxColumn"
        '
        'StoreSearchBindingSource
        '
        Me.StoreSearchBindingSource.DataMember = "StoreSearch"
        Me.StoreSearchBindingSource.DataSource = Me.Project_May3_dataDataSet
        '
        'Project_May3_dataDataSet
        '
        Me.Project_May3_dataDataSet.DataSetName = "project_May3_dataDataSet"
        Me.Project_May3_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 408)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 25)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Haven't Decided Store? "
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = Global.CarPriceInformationCenter_May2_without_register.My.Resources.Resources.next副本
        Me.Button5.Location = New System.Drawing.Point(725, 396)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(60, 60)
        Me.Button5.TabIndex = 36
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.CarPriceInformationCenter_May2_without_register.My.Resources.Resources.click
        Me.Button4.Location = New System.Drawing.Point(449, 400)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(170, 45)
        Me.Button4.TabIndex = 35
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.CarPriceInformationCenter_May2_without_register.My.Resources.Resources.back
        Me.Button3.Location = New System.Drawing.Point(659, 396)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 60)
        Me.Button3.TabIndex = 32
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.CarPriceInformationCenter_May2_without_register.My.Resources.Resources.click
        Me.Button1.Location = New System.Drawing.Point(449, 345)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 45)
        Me.Button1.TabIndex = 31
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.CarPriceInformationCenter_May2_without_register.My.Resources.Resources.home1
        Me.Button2.Location = New System.Drawing.Point(725, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 60)
        Me.Button2.TabIndex = 29
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(435, 0)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(100, 35)
        Me.Button9.TabIndex = 39
        Me.Button9.Text = "ReOrder"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'StoreSearchTableAdapter
        '
        Me.StoreSearchTableAdapter.ClearBeforeFill = True
        '
        'FillByModelToolStrip
        '
        Me.FillByModelToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MODEL_NAMEToolStripLabel, Me.MODEL_NAMEToolStripTextBox})
        Me.FillByModelToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByModelToolStrip.Name = "FillByModelToolStrip"
        Me.FillByModelToolStrip.Size = New System.Drawing.Size(829, 29)
        Me.FillByModelToolStrip.TabIndex = 40
        Me.FillByModelToolStrip.Text = "FillByModelToolStrip"
        '
        'MODEL_NAMEToolStripLabel
        '
        Me.MODEL_NAMEToolStripLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MODEL_NAMEToolStripLabel.Name = "MODEL_NAMEToolStripLabel"
        Me.MODEL_NAMEToolStripLabel.Size = New System.Drawing.Size(117, 26)
        Me.MODEL_NAMEToolStripLabel.Text = "MODEL_NAME:"
        '
        'MODEL_NAMEToolStripTextBox
        '
        Me.MODEL_NAMEToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MODEL_NAMEToolStripTextBox.Name = "MODEL_NAMEToolStripTextBox"
        Me.MODEL_NAMEToolStripTextBox.Size = New System.Drawing.Size(100, 29)
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(241, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(160, 35)
        Me.Button6.TabIndex = 41
        Me.Button6.Text = "FilterByModel"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(283, 354)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(136, 26)
        Me.TextBox1.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(425, 353)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 25)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = ":"
        '
        'FilterByDiscountToolStrip
        '
        Me.FilterByDiscountToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilterByDiscountToolStripButton})
        Me.FilterByDiscountToolStrip.Location = New System.Drawing.Point(0, 29)
        Me.FilterByDiscountToolStrip.Name = "FilterByDiscountToolStrip"
        Me.FilterByDiscountToolStrip.Size = New System.Drawing.Size(829, 28)
        Me.FilterByDiscountToolStrip.TabIndex = 44
        Me.FilterByDiscountToolStrip.Text = "FilterByDiscountToolStrip"
        '
        'FilterByDiscountToolStripButton
        '
        Me.FilterByDiscountToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FilterByDiscountToolStripButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FilterByDiscountToolStripButton.Name = "FilterByDiscountToolStripButton"
        Me.FilterByDiscountToolStripButton.Size = New System.Drawing.Size(127, 25)
        Me.FilterByDiscountToolStripButton.Text = "FilterByDiscount"
        '
        'StoreDiscount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 534)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.FilterByDiscountToolStrip)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.FillByModelToolStrip)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "StoreDiscount"
        Me.Text = "StoreDiscount"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoreSearchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Project_May3_dataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByModelToolStrip.ResumeLayout(False)
        Me.FillByModelToolStrip.PerformLayout()
        Me.FilterByDiscountToolStrip.ResumeLayout(False)
        Me.FilterByDiscountToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Project_May3_dataDataSet As CarPriceInformationCenter_May2_without_register.project_May3_dataDataSet
    Friend WithEvents StoreSearchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StoreSearchTableAdapter As CarPriceInformationCenter_May2_without_register.project_May3_dataDataSetTableAdapters.StoreSearchTableAdapter
    Friend WithEvents ORDERCHECKDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents STORENAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STORECITYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DISCOUNTTOTALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MODELNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents FillByModelToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents MODEL_NAMEToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents MODEL_NAMEToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FilterByDiscountToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FilterByDiscountToolStripButton As System.Windows.Forms.ToolStripButton
End Class
