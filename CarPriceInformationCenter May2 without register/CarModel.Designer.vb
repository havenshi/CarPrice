<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarModel
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MODELCHECKDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MODELNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MODELYEARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MODELORIGINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MODELCOLORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MODELFUELTYPEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MODELAVGPRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MANNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelSearchBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Project_May3_dataDataSet = New CarPriceInformationCenter_May2_without_register.project_May3_dataDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ModelSearchTableAdapter1 = New CarPriceInformationCenter_May2_without_register.project_May3_dataDataSetTableAdapters.ModelSearchTableAdapter()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ModelSearchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Project_May2_dataDataSet = New CarPriceInformationCenter_May2_without_register.project_May2_dataDataSet()
        Me.ModelSearchTableAdapter = New CarPriceInformationCenter_May2_without_register.project_May2_dataDataSetTableAdapters.ModelSearchTableAdapter()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.CAR_MODELTableAdapter = New CarPriceInformationCenter_May2_without_register.project_May3_dataDataSetTableAdapters.CAR_MODELTableAdapter()
        Me.TableAdapterManager = New CarPriceInformationCenter_May2_without_register.project_May3_dataDataSetTableAdapters.TableAdapterManager()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.MAN_NAMEToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.MAN_NAMEToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByman11ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelSearchBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Project_May3_dataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelSearchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Project_May2_dataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByman11ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(273, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Find Your Favorite Car Model:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 356)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 25)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Click Here to See Store and Discount of"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MODELCHECKDataGridViewCheckBoxColumn, Me.MODELNAMEDataGridViewTextBoxColumn, Me.MODELYEARDataGridViewTextBoxColumn, Me.MODELORIGINDataGridViewTextBoxColumn, Me.MODELCOLORDataGridViewTextBoxColumn, Me.MODELFUELTYPEDataGridViewTextBoxColumn, Me.MODELAVGPRICEDataGridViewTextBoxColumn, Me.MANNAMEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ModelSearchBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(20, 100)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(861, 218)
        Me.DataGridView1.TabIndex = 28
        '
        'MODELCHECKDataGridViewCheckBoxColumn
        '
        Me.MODELCHECKDataGridViewCheckBoxColumn.DataPropertyName = "MODEL_CHECK"
        Me.MODELCHECKDataGridViewCheckBoxColumn.HeaderText = "MODEL_CHECK"
        Me.MODELCHECKDataGridViewCheckBoxColumn.Name = "MODELCHECKDataGridViewCheckBoxColumn"
        '
        'MODELNAMEDataGridViewTextBoxColumn
        '
        Me.MODELNAMEDataGridViewTextBoxColumn.DataPropertyName = "MODEL_NAME"
        Me.MODELNAMEDataGridViewTextBoxColumn.HeaderText = "MODEL_NAME"
        Me.MODELNAMEDataGridViewTextBoxColumn.Name = "MODELNAMEDataGridViewTextBoxColumn"
        '
        'MODELYEARDataGridViewTextBoxColumn
        '
        Me.MODELYEARDataGridViewTextBoxColumn.DataPropertyName = "MODEL_YEAR"
        Me.MODELYEARDataGridViewTextBoxColumn.HeaderText = "MODEL_YEAR"
        Me.MODELYEARDataGridViewTextBoxColumn.Name = "MODELYEARDataGridViewTextBoxColumn"
        '
        'MODELORIGINDataGridViewTextBoxColumn
        '
        Me.MODELORIGINDataGridViewTextBoxColumn.DataPropertyName = "MODEL_ORIGIN"
        Me.MODELORIGINDataGridViewTextBoxColumn.HeaderText = "MODEL_ORIGIN"
        Me.MODELORIGINDataGridViewTextBoxColumn.Name = "MODELORIGINDataGridViewTextBoxColumn"
        '
        'MODELCOLORDataGridViewTextBoxColumn
        '
        Me.MODELCOLORDataGridViewTextBoxColumn.DataPropertyName = "MODEL_COLOR"
        Me.MODELCOLORDataGridViewTextBoxColumn.HeaderText = "MODEL_COLOR"
        Me.MODELCOLORDataGridViewTextBoxColumn.Name = "MODELCOLORDataGridViewTextBoxColumn"
        '
        'MODELFUELTYPEDataGridViewTextBoxColumn
        '
        Me.MODELFUELTYPEDataGridViewTextBoxColumn.DataPropertyName = "MODEL_FUEL_TYPE"
        Me.MODELFUELTYPEDataGridViewTextBoxColumn.HeaderText = "MODEL_FUEL_TYPE"
        Me.MODELFUELTYPEDataGridViewTextBoxColumn.Name = "MODELFUELTYPEDataGridViewTextBoxColumn"
        '
        'MODELAVGPRICEDataGridViewTextBoxColumn
        '
        Me.MODELAVGPRICEDataGridViewTextBoxColumn.DataPropertyName = "MODEL_AVG_PRICE"
        Me.MODELAVGPRICEDataGridViewTextBoxColumn.HeaderText = "MODEL_AVG_PRICE"
        Me.MODELAVGPRICEDataGridViewTextBoxColumn.Name = "MODELAVGPRICEDataGridViewTextBoxColumn"
        '
        'MANNAMEDataGridViewTextBoxColumn
        '
        Me.MANNAMEDataGridViewTextBoxColumn.DataPropertyName = "MAN_NAME"
        Me.MANNAMEDataGridViewTextBoxColumn.HeaderText = "MAN_NAME"
        Me.MANNAMEDataGridViewTextBoxColumn.Name = "MANNAMEDataGridViewTextBoxColumn"
        '
        'ModelSearchBindingSource1
        '
        Me.ModelSearchBindingSource1.DataMember = "ModelSearch"
        Me.ModelSearchBindingSource1.DataSource = Me.Project_May3_dataDataSet
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
        Me.Label3.Location = New System.Drawing.Point(15, 411)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(262, 25)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Haven't Decided Car Model?"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = Global.CarPriceInformationCenter_May2_without_register.My.Resources.Resources.next副本
        Me.Button5.Location = New System.Drawing.Point(821, 403)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(60, 60)
        Me.Button5.TabIndex = 31
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.CarPriceInformationCenter_May2_without_register.My.Resources.Resources.click
        Me.Button4.Location = New System.Drawing.Point(519, 403)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(170, 45)
        Me.Button4.TabIndex = 30
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.CarPriceInformationCenter_May2_without_register.My.Resources.Resources.back1
        Me.Button3.Location = New System.Drawing.Point(755, 403)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 60)
        Me.Button3.TabIndex = 27
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.CarPriceInformationCenter_May2_without_register.My.Resources.Resources.click
        Me.Button1.Location = New System.Drawing.Point(519, 348)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 45)
        Me.Button1.TabIndex = 25
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.CarPriceInformationCenter_May2_without_register.My.Resources.Resources.home1
        Me.Button2.Location = New System.Drawing.Point(821, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 60)
        Me.Button2.TabIndex = 21
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(156, 1)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 33
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ModelSearchTableAdapter1
        '
        Me.ModelSearchTableAdapter1.ClearBeforeFill = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(105, 0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 35
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ModelSearchBindingSource
        '
        Me.ModelSearchBindingSource.DataMember = "ModelSearch"
        Me.ModelSearchBindingSource.DataSource = Me.Project_May2_dataDataSet
        '
        'Project_May2_dataDataSet
        '
        Me.Project_May2_dataDataSet.DataSetName = "project_May2_dataDataSet"
        Me.Project_May2_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ModelSearchTableAdapter
        '
        Me.ModelSearchTableAdapter.ClearBeforeFill = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(442, 1)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(100, 35)
        Me.Button9.TabIndex = 38
        Me.Button9.Text = "ReOrder"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'CAR_MODELTableAdapter
        '
        Me.CAR_MODELTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CAR_MODELTableAdapter = Me.CAR_MODELTableAdapter
        Me.TableAdapterManager.DISCOUNTTableAdapter = Nothing
        Me.TableAdapterManager.SALES_ORDERTableAdapter = Nothing
        Me.TableAdapterManager.STORESTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CarPriceInformationCenter_May2_without_register.project_May3_dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(224, 0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(165, 35)
        Me.Button8.TabIndex = 39
        Me.Button8.Text = "FilterByManufacturer"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'MAN_NAMEToolStripLabel
        '
        Me.MAN_NAMEToolStripLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MAN_NAMEToolStripLabel.Name = "MAN_NAMEToolStripLabel"
        Me.MAN_NAMEToolStripLabel.Size = New System.Drawing.Size(100, 26)
        Me.MAN_NAMEToolStripLabel.Text = "MAN_NAME:"
        '
        'MAN_NAMEToolStripTextBox
        '
        Me.MAN_NAMEToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MAN_NAMEToolStripTextBox.Name = "MAN_NAMEToolStripTextBox"
        Me.MAN_NAMEToolStripTextBox.Size = New System.Drawing.Size(100, 29)
        '
        'FillByman11ToolStrip
        '
        Me.FillByman11ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MAN_NAMEToolStripLabel, Me.MAN_NAMEToolStripTextBox})
        Me.FillByman11ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByman11ToolStrip.Name = "FillByman11ToolStrip"
        Me.FillByman11ToolStrip.Size = New System.Drawing.Size(901, 29)
        Me.FillByman11ToolStrip.TabIndex = 0
        Me.FillByman11ToolStrip.Text = "FillByman11ToolStrip"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(377, 354)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(84, 26)
        Me.TextBox1.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(467, 354)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 25)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = ":"
        '
        'CarModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 528)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.FillByman11ToolStrip)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "CarModel"
        Me.Text = "CarModel"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelSearchBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Project_May3_dataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelSearchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Project_May2_dataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByman11ToolStrip.ResumeLayout(False)
        Me.FillByman11ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ModelSearchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ModelSearchTableAdapter As CarPriceInformationCenter_May2_without_register.project_May2_dataDataSetTableAdapters.ModelSearchTableAdapter
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Project_May2_dataDataSet As CarPriceInformationCenter_May2_without_register.project_May2_dataDataSet
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Project_May3_dataDataSet As CarPriceInformationCenter_May2_without_register.project_May3_dataDataSet
    Friend WithEvents ModelSearchBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ModelSearchTableAdapter1 As CarPriceInformationCenter_May2_without_register.project_May3_dataDataSetTableAdapters.ModelSearchTableAdapter
    Friend WithEvents MODELCHECKDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MODELNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MODELYEARDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MODELORIGINDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MODELCOLORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MODELFUELTYPEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MODELAVGPRICEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MANNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents CAR_MODELTableAdapter As CarPriceInformationCenter_May2_without_register.project_May3_dataDataSetTableAdapters.CAR_MODELTableAdapter
    Friend WithEvents TableAdapterManager As CarPriceInformationCenter_May2_without_register.project_May3_dataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents MAN_NAMEToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents MAN_NAMEToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByman11ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
