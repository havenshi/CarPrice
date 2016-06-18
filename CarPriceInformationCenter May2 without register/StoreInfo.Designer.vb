<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StoreInfo
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
        Dim STORE_NAMELabel As System.Windows.Forms.Label
        Dim STORE_IDLabel As System.Windows.Forms.Label
        Dim STORE_ADDRESSLabel As System.Windows.Forms.Label
        Dim STORE_ZIPCODELabel As System.Windows.Forms.Label
        Dim STORE_STATELabel As System.Windows.Forms.Label
        Dim STORE_CITYLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StoreInfo))
        Me.Project_May2_dataDataSet1 = New CarPriceInformationCenter_May2_without_register.project_May2_dataDataSet1()
        Me.STORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STORESTableAdapter = New CarPriceInformationCenter_May2_without_register.project_May2_dataDataSet1TableAdapters.STORESTableAdapter()
        Me.TableAdapterManager = New CarPriceInformationCenter_May2_without_register.project_May2_dataDataSet1TableAdapters.TableAdapterManager()
        Me.STORESBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.STORESBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.STORESBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.STORE_NAMEComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.STORE_IDComboBox = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Project_May3_dataDataSet = New CarPriceInformationCenter_May2_without_register.project_May3_dataDataSet()
        Me.STORESTableAdapter1 = New CarPriceInformationCenter_May2_without_register.project_May3_dataDataSetTableAdapters.STORESTableAdapter()
        Me.TableAdapterManager1 = New CarPriceInformationCenter_May2_without_register.project_May3_dataDataSetTableAdapters.TableAdapterManager()
        Me.STORE_ADDRESSComboBox = New System.Windows.Forms.ComboBox()
        Me.STORE_ZIPCODEComboBox = New System.Windows.Forms.ComboBox()
        Me.STORE_STATETextBox = New System.Windows.Forms.TextBox()
        Me.STORE_CITYTextBox = New System.Windows.Forms.TextBox()
        Me.FillBystoreToolStrip = New System.Windows.Forms.ToolStrip()
        Me.STORE_NAMEToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.STORE_NAMEToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        STORE_NAMELabel = New System.Windows.Forms.Label()
        STORE_IDLabel = New System.Windows.Forms.Label()
        STORE_ADDRESSLabel = New System.Windows.Forms.Label()
        STORE_ZIPCODELabel = New System.Windows.Forms.Label()
        STORE_STATELabel = New System.Windows.Forms.Label()
        STORE_CITYLabel = New System.Windows.Forms.Label()
        CType(Me.Project_May2_dataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STORESBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.STORESBindingNavigator.SuspendLayout()
        CType(Me.STORESBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Project_May3_dataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBystoreToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'STORE_NAMELabel
        '
        STORE_NAMELabel.AutoSize = True
        STORE_NAMELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        STORE_NAMELabel.Location = New System.Drawing.Point(109, 165)
        STORE_NAMELabel.Name = "STORE_NAMELabel"
        STORE_NAMELabel.Size = New System.Drawing.Size(103, 17)
        STORE_NAMELabel.TabIndex = 12
        STORE_NAMELabel.Text = "STORE NAME:"
        '
        'STORE_IDLabel
        '
        STORE_IDLabel.AutoSize = True
        STORE_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        STORE_IDLabel.Location = New System.Drawing.Point(109, 135)
        STORE_IDLabel.Name = "STORE_IDLabel"
        STORE_IDLabel.Size = New System.Drawing.Size(77, 17)
        STORE_IDLabel.TabIndex = 29
        STORE_IDLabel.Text = "STORE ID:"
        '
        'STORE_ADDRESSLabel
        '
        STORE_ADDRESSLabel.AutoSize = True
        STORE_ADDRESSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        STORE_ADDRESSLabel.Location = New System.Drawing.Point(109, 199)
        STORE_ADDRESSLabel.Name = "STORE_ADDRESSLabel"
        STORE_ADDRESSLabel.Size = New System.Drawing.Size(130, 17)
        STORE_ADDRESSLabel.TabIndex = 34
        STORE_ADDRESSLabel.Text = "STORE ADDRESS:"
        '
        'STORE_ZIPCODELabel
        '
        STORE_ZIPCODELabel.AutoSize = True
        STORE_ZIPCODELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        STORE_ZIPCODELabel.Location = New System.Drawing.Point(109, 293)
        STORE_ZIPCODELabel.Name = "STORE_ZIPCODELabel"
        STORE_ZIPCODELabel.Size = New System.Drawing.Size(124, 17)
        STORE_ZIPCODELabel.TabIndex = 37
        STORE_ZIPCODELabel.Text = "STORE ZIPCODE:"
        '
        'STORE_STATELabel
        '
        STORE_STATELabel.AutoSize = True
        STORE_STATELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        STORE_STATELabel.Location = New System.Drawing.Point(109, 261)
        STORE_STATELabel.Name = "STORE_STATELabel"
        STORE_STATELabel.Size = New System.Drawing.Size(109, 17)
        STORE_STATELabel.TabIndex = 38
        STORE_STATELabel.Text = "STORE STATE:"
        '
        'STORE_CITYLabel
        '
        STORE_CITYLabel.AutoSize = True
        STORE_CITYLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        STORE_CITYLabel.Location = New System.Drawing.Point(109, 232)
        STORE_CITYLabel.Name = "STORE_CITYLabel"
        STORE_CITYLabel.Size = New System.Drawing.Size(94, 17)
        STORE_CITYLabel.TabIndex = 39
        STORE_CITYLabel.Text = "STORE CITY:"
        '
        'Project_May2_dataDataSet1
        '
        Me.Project_May2_dataDataSet1.DataSetName = "project_May2_dataDataSet1"
        Me.Project_May2_dataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'STORESBindingSource
        '
        Me.STORESBindingSource.DataMember = "STORES"
        Me.STORESBindingSource.DataSource = Me.Project_May2_dataDataSet1
        '
        'STORESTableAdapter
        '
        Me.STORESTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.STORESTableAdapter = Me.STORESTableAdapter
        Me.TableAdapterManager.UpdateOrder = CarPriceInformationCenter_May2_without_register.project_May2_dataDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'STORESBindingNavigator
        '
        Me.STORESBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.STORESBindingNavigator.BindingSource = Me.STORESBindingSource
        Me.STORESBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.STORESBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.STORESBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.STORESBindingNavigatorSaveItem})
        Me.STORESBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.STORESBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.STORESBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.STORESBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.STORESBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.STORESBindingNavigator.Name = "STORESBindingNavigator"
        Me.STORESBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.STORESBindingNavigator.Size = New System.Drawing.Size(569, 25)
        Me.STORESBindingNavigator.TabIndex = 0
        Me.STORESBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'STORESBindingNavigatorSaveItem
        '
        Me.STORESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.STORESBindingNavigatorSaveItem.Image = CType(resources.GetObject("STORESBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.STORESBindingNavigatorSaveItem.Name = "STORESBindingNavigatorSaveItem"
        Me.STORESBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.STORESBindingNavigatorSaveItem.Text = "Save Data"
        '
        'STORESBindingSource1
        '
        Me.STORESBindingSource1.DataMember = "STORES"
        Me.STORESBindingSource1.DataSource = Me.Project_May2_dataDataSet1
        '
        'STORE_NAMEComboBox
        '
        Me.STORE_NAMEComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STORESBindingSource, "STORE_NAME", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.STORE_NAMEComboBox.DataSource = Me.STORESBindingSource
        Me.STORE_NAMEComboBox.DisplayMember = "STORE_NAME"
        Me.STORE_NAMEComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STORE_NAMEComboBox.FormattingEnabled = True
        Me.STORE_NAMEComboBox.Location = New System.Drawing.Point(245, 165)
        Me.STORE_NAMEComboBox.Name = "STORE_NAMEComboBox"
        Me.STORE_NAMEComboBox.Size = New System.Drawing.Size(190, 24)
        Me.STORE_NAMEComboBox.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 25)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Information of the Store:"
        '
        'STORE_IDComboBox
        '
        Me.STORE_IDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STORESBindingSource, "STORE_ID", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.STORE_IDComboBox.DataSource = Me.STORESBindingSource
        Me.STORE_IDComboBox.DisplayMember = "STORE_ID"
        Me.STORE_IDComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STORE_IDComboBox.FormattingEnabled = True
        Me.STORE_IDComboBox.Location = New System.Drawing.Point(245, 135)
        Me.STORE_IDComboBox.Name = "STORE_IDComboBox"
        Me.STORE_IDComboBox.Size = New System.Drawing.Size(190, 24)
        Me.STORE_IDComboBox.TabIndex = 30
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.CarPriceInformationCenter_May2_without_register.My.Resources.Resources.back
        Me.Button3.Location = New System.Drawing.Point(503, 323)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 60)
        Me.Button3.TabIndex = 34
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.CarPriceInformationCenter_May2_without_register.My.Resources.Resources.home1
        Me.Button2.Location = New System.Drawing.Point(503, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 60)
        Me.Button2.TabIndex = 33
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Project_May3_dataDataSet
        '
        Me.Project_May3_dataDataSet.DataSetName = "project_May3_dataDataSet"
        Me.Project_May3_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'STORESTableAdapter1
        '
        Me.STORESTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CAR_MODELTableAdapter = Nothing
        Me.TableAdapterManager1.DISCOUNTTableAdapter = Nothing
        Me.TableAdapterManager1.SALES_ORDERTableAdapter = Nothing
        Me.TableAdapterManager1.STORESTableAdapter = Me.STORESTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = CarPriceInformationCenter_May2_without_register.project_May3_dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'STORE_ADDRESSComboBox
        '
        Me.STORE_ADDRESSComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STORESBindingSource, "STORE_ADDRESS", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.STORE_ADDRESSComboBox.DataSource = Me.STORESBindingSource
        Me.STORE_ADDRESSComboBox.DisplayMember = "STORE_ADDRESS"
        Me.STORE_ADDRESSComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STORE_ADDRESSComboBox.FormattingEnabled = True
        Me.STORE_ADDRESSComboBox.Location = New System.Drawing.Point(245, 199)
        Me.STORE_ADDRESSComboBox.Name = "STORE_ADDRESSComboBox"
        Me.STORE_ADDRESSComboBox.Size = New System.Drawing.Size(190, 24)
        Me.STORE_ADDRESSComboBox.TabIndex = 35
        '
        'STORE_ZIPCODEComboBox
        '
        Me.STORE_ZIPCODEComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STORESBindingSource, "STORE_ZIPCODE", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.STORE_ZIPCODEComboBox.DataSource = Me.STORESBindingSource
        Me.STORE_ZIPCODEComboBox.DisplayMember = "STORE_ZIPCODE"
        Me.STORE_ZIPCODEComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STORE_ZIPCODEComboBox.FormattingEnabled = True
        Me.STORE_ZIPCODEComboBox.Location = New System.Drawing.Point(245, 293)
        Me.STORE_ZIPCODEComboBox.Name = "STORE_ZIPCODEComboBox"
        Me.STORE_ZIPCODEComboBox.Size = New System.Drawing.Size(190, 24)
        Me.STORE_ZIPCODEComboBox.TabIndex = 38
        '
        'STORE_STATETextBox
        '
        Me.STORE_STATETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STORESBindingSource, "STORE_STATE", True))
        Me.STORE_STATETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STORE_STATETextBox.Location = New System.Drawing.Point(245, 261)
        Me.STORE_STATETextBox.Name = "STORE_STATETextBox"
        Me.STORE_STATETextBox.Size = New System.Drawing.Size(190, 23)
        Me.STORE_STATETextBox.TabIndex = 39
        '
        'STORE_CITYTextBox
        '
        Me.STORE_CITYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STORESBindingSource, "STORE_CITY", True))
        Me.STORE_CITYTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STORE_CITYTextBox.Location = New System.Drawing.Point(245, 232)
        Me.STORE_CITYTextBox.Name = "STORE_CITYTextBox"
        Me.STORE_CITYTextBox.Size = New System.Drawing.Size(190, 23)
        Me.STORE_CITYTextBox.TabIndex = 40
        '
        'FillBystoreToolStrip
        '
        Me.FillBystoreToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STORE_NAMEToolStripLabel, Me.STORE_NAMEToolStripTextBox})
        Me.FillBystoreToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillBystoreToolStrip.Name = "FillBystoreToolStrip"
        Me.FillBystoreToolStrip.Size = New System.Drawing.Size(569, 29)
        Me.FillBystoreToolStrip.TabIndex = 41
        Me.FillBystoreToolStrip.Text = "FillBystoreToolStrip"
        '
        'STORE_NAMEToolStripLabel
        '
        Me.STORE_NAMEToolStripLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.STORE_NAMEToolStripLabel.Name = "STORE_NAMEToolStripLabel"
        Me.STORE_NAMEToolStripLabel.Size = New System.Drawing.Size(111, 26)
        Me.STORE_NAMEToolStripLabel.Text = "STORE_NAME:"
        '
        'STORE_NAMEToolStripTextBox
        '
        Me.STORE_NAMEToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.STORE_NAMEToolStripTextBox.Name = "STORE_NAMEToolStripTextBox"
        Me.STORE_NAMEToolStripTextBox.Size = New System.Drawing.Size(100, 29)
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(245, 25)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(146, 35)
        Me.Button8.TabIndex = 42
        Me.Button8.Text = "FilterByStore"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(397, 25)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(100, 35)
        Me.Button9.TabIndex = 43
        Me.Button9.Text = "ReOrder"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'StoreInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 414)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.FillBystoreToolStrip)
        Me.Controls.Add(STORE_CITYLabel)
        Me.Controls.Add(Me.STORE_CITYTextBox)
        Me.Controls.Add(STORE_STATELabel)
        Me.Controls.Add(Me.STORE_STATETextBox)
        Me.Controls.Add(STORE_ZIPCODELabel)
        Me.Controls.Add(Me.STORE_ZIPCODEComboBox)
        Me.Controls.Add(STORE_ADDRESSLabel)
        Me.Controls.Add(Me.STORE_ADDRESSComboBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(STORE_IDLabel)
        Me.Controls.Add(Me.STORE_IDComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(STORE_NAMELabel)
        Me.Controls.Add(Me.STORE_NAMEComboBox)
        Me.Controls.Add(Me.STORESBindingNavigator)
        Me.Name = "StoreInfo"
        Me.Text = "StoreInfo"
        CType(Me.Project_May2_dataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STORESBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.STORESBindingNavigator.ResumeLayout(False)
        Me.STORESBindingNavigator.PerformLayout()
        CType(Me.STORESBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Project_May3_dataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBystoreToolStrip.ResumeLayout(False)
        Me.FillBystoreToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Project_May2_dataDataSet1 As CarPriceInformationCenter_May2_without_register.project_May2_dataDataSet1
    Friend WithEvents STORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents STORESTableAdapter As CarPriceInformationCenter_May2_without_register.project_May2_dataDataSet1TableAdapters.STORESTableAdapter
    Friend WithEvents TableAdapterManager As CarPriceInformationCenter_May2_without_register.project_May2_dataDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents STORESBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents STORESBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents STORESBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents STORE_NAMEComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents STORE_IDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Project_May3_dataDataSet As CarPriceInformationCenter_May2_without_register.project_May3_dataDataSet
    Friend WithEvents STORESTableAdapter1 As CarPriceInformationCenter_May2_without_register.project_May3_dataDataSetTableAdapters.STORESTableAdapter
    Friend WithEvents TableAdapterManager1 As CarPriceInformationCenter_May2_without_register.project_May3_dataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents STORE_ADDRESSComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents STORE_ZIPCODEComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents STORE_STATETextBox As System.Windows.Forms.TextBox
    Friend WithEvents STORE_CITYTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FillBystoreToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents STORE_NAMEToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents STORE_NAMEToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
End Class
