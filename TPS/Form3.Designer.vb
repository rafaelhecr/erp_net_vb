<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim FECHALabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim CLAVELabel As System.Windows.Forms.Label
        Dim PRDUCTOLabel As System.Windows.Forms.Label
        Dim PRECIOLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim CANTIUNILabel As System.Windows.Forms.Label
        Dim CANTICAJLabel As System.Windows.Forms.Label
        Dim CANTIDADLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label1 = New System.Windows.Forms.Label
        Me.NOTASBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.NOTASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbsDataSet = New TPS.dbsDataSet
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.NOTASBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.FECHADateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.NOMBRETextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CLAVEComboBox = New System.Windows.Forms.ComboBox
        Me.CONTPRODBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRDUCTOComboBox = New System.Windows.Forms.ComboBox
        Me.PRECIOLabel2 = New System.Windows.Forms.Label
        Me.CANTIUNILabel1 = New System.Windows.Forms.Label
        Me.CANTICAJLabel1 = New System.Windows.Forms.Label
        Me.NOTASTableAdapter = New TPS.dbsDataSetTableAdapters.NOTASTableAdapter
        Me.TableAdapterManager = New TPS.dbsDataSetTableAdapters.TableAdapterManager
        Me.CONTPRODTableAdapter = New TPS.dbsDataSetTableAdapters.CONTPRODTableAdapter
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.CANTIDADTextBox = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.ListBox3 = New System.Windows.Forms.ListBox
        Me.ListBox4 = New System.Windows.Forms.ListBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TOTALTextBox = New System.Windows.Forms.TextBox
        Me.Button5 = New System.Windows.Forms.Button
        FECHALabel = New System.Windows.Forms.Label
        NOMBRELabel = New System.Windows.Forms.Label
        CLAVELabel = New System.Windows.Forms.Label
        PRDUCTOLabel = New System.Windows.Forms.Label
        PRECIOLabel = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        CANTIUNILabel = New System.Windows.Forms.Label
        CANTICAJLabel = New System.Windows.Forms.Label
        CANTIDADLabel = New System.Windows.Forms.Label
        CType(Me.NOTASBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NOTASBindingNavigator.SuspendLayout()
        CType(Me.NOTASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTPRODBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FECHALabel
        '
        FECHALabel.AutoSize = True
        FECHALabel.Location = New System.Drawing.Point(812, 82)
        FECHALabel.Name = "FECHALabel"
        FECHALabel.Size = New System.Drawing.Size(44, 17)
        FECHALabel.TabIndex = 2
        FECHALabel.Text = "Fecha:"
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(12, 64)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(152, 17)
        NOMBRELabel.TabIndex = 4
        NOMBRELabel.Text = "Nombre del comprador:"
        '
        'CLAVELabel
        '
        CLAVELabel.AutoSize = True
        CLAVELabel.Location = New System.Drawing.Point(60, 99)
        CLAVELabel.Name = "CLAVELabel"
        CLAVELabel.Size = New System.Drawing.Size(42, 17)
        CLAVELabel.TabIndex = 7
        CLAVELabel.Text = "Clave:"
        '
        'PRDUCTOLabel
        '
        PRDUCTOLabel.AutoSize = True
        PRDUCTOLabel.Location = New System.Drawing.Point(215, 99)
        PRDUCTOLabel.Name = "PRDUCTOLabel"
        PRDUCTOLabel.Size = New System.Drawing.Size(140, 17)
        PRDUCTOLabel.TabIndex = 9
        PRDUCTOLabel.Text = "Nombre del producto:"
        '
        'PRECIOLabel
        '
        PRECIOLabel.AutoSize = True
        PRECIOLabel.Location = New System.Drawing.Point(12, 137)
        PRECIOLabel.Name = "PRECIOLabel"
        PRECIOLabel.Size = New System.Drawing.Size(116, 17)
        PRECIOLabel.TabIndex = 11
        PRECIOLabel.Text = "Precio por unidad:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(231, 137)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(180, 17)
        Label3.TabIndex = 15
        Label3.Text = "Cantidades por existencía de:"
        '
        'CANTIUNILabel
        '
        CANTIUNILabel.AutoSize = True
        CANTIUNILabel.Location = New System.Drawing.Point(231, 160)
        CANTIUNILabel.Name = "CANTIUNILabel"
        CANTIUNILabel.Size = New System.Drawing.Size(66, 17)
        CANTIUNILabel.TabIndex = 15
        CANTIUNILabel.Text = "Unidades:"
        '
        'CANTICAJLabel
        '
        CANTICAJLabel.AutoSize = True
        CANTICAJLabel.Location = New System.Drawing.Point(409, 160)
        CANTICAJLabel.Name = "CANTICAJLabel"
        CANTICAJLabel.Size = New System.Drawing.Size(36, 17)
        CANTICAJLabel.TabIndex = 16
        CANTICAJLabel.Text = "Caja:"
        '
        'CANTIDADLabel
        '
        CANTIDADLabel.AutoSize = True
        CANTIDADLabel.Location = New System.Drawing.Point(60, 202)
        CANTIDADLabel.Name = "CANTIDADLabel"
        CANTIDADLabel.Size = New System.Drawing.Size(63, 17)
        CANTIDADLabel.TabIndex = 21
        CANTIDADLabel.Text = "Cantidad:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Notas"
        '
        'NOTASBindingNavigator
        '
        Me.NOTASBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.NOTASBindingNavigator.BackgroundImage = Global.TPS.My.Resources.Resources.barra1
        Me.NOTASBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NOTASBindingNavigator.BindingSource = Me.NOTASBindingSource
        Me.NOTASBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.NOTASBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.NOTASBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.NOTASBindingNavigator.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.NOTASBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.NOTASBindingNavigatorSaveItem})
        Me.NOTASBindingNavigator.Location = New System.Drawing.Point(312, 620)
        Me.NOTASBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.NOTASBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.NOTASBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.NOTASBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.NOTASBindingNavigator.Name = "NOTASBindingNavigator"
        Me.NOTASBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.NOTASBindingNavigator.Size = New System.Drawing.Size(322, 32)
        Me.NOTASBindingNavigator.TabIndex = 1
        Me.NOTASBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 29)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'NOTASBindingSource
        '
        Me.NOTASBindingSource.DataMember = "NOTAS"
        Me.NOTASBindingSource.DataSource = Me.DbsDataSet
        '
        'DbsDataSet
        '
        Me.DbsDataSet.DataSetName = "dbsDataSet"
        Me.DbsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 29)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 29)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 29)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 29)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 32)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 29)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 29)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 32)
        '
        'NOTASBindingNavigatorSaveItem
        '
        Me.NOTASBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NOTASBindingNavigatorSaveItem.Image = CType(resources.GetObject("NOTASBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.NOTASBindingNavigatorSaveItem.Name = "NOTASBindingNavigatorSaveItem"
        Me.NOTASBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 29)
        Me.NOTASBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'FECHADateTimePicker
        '
        Me.FECHADateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.NOTASBindingSource, "FECHA", True))
        Me.FECHADateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FECHADateTimePicker.Location = New System.Drawing.Point(862, 76)
        Me.FECHADateTimePicker.Name = "FECHADateTimePicker"
        Me.FECHADateTimePicker.Size = New System.Drawing.Size(100, 25)
        Me.FECHADateTimePicker.TabIndex = 3
        '
        'NOMBRETextBox
        '
        Me.NOMBRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NOTASBindingSource, "NOMBRE", True))
        Me.NOMBRETextBox.Location = New System.Drawing.Point(170, 61)
        Me.NOMBRETextBox.Name = "NOMBRETextBox"
        Me.NOMBRETextBox.Size = New System.Drawing.Size(291, 25)
        Me.NOMBRETextBox.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Buscar"
        '
        'CLAVEComboBox
        '
        Me.CLAVEComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NOTASBindingSource, "CLAVE", True))
        Me.CLAVEComboBox.DataSource = Me.CONTPRODBindingSource
        Me.CLAVEComboBox.DisplayMember = "CLAVE"
        Me.CLAVEComboBox.FormattingEnabled = True
        Me.CLAVEComboBox.Location = New System.Drawing.Point(114, 96)
        Me.CLAVEComboBox.Name = "CLAVEComboBox"
        Me.CLAVEComboBox.Size = New System.Drawing.Size(73, 25)
        Me.CLAVEComboBox.TabIndex = 8
        Me.CLAVEComboBox.ValueMember = "CLAVE"
        '
        'CONTPRODBindingSource
        '
        Me.CONTPRODBindingSource.DataMember = "CONTPROD"
        Me.CONTPRODBindingSource.DataSource = Me.DbsDataSet
        '
        'PRDUCTOComboBox
        '
        Me.PRDUCTOComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NOTASBindingSource, "PRDUCTO", True))
        Me.PRDUCTOComboBox.DataSource = Me.CONTPRODBindingSource
        Me.PRDUCTOComboBox.DisplayMember = "PRODUCTO"
        Me.PRDUCTOComboBox.FormattingEnabled = True
        Me.PRDUCTOComboBox.Location = New System.Drawing.Point(361, 96)
        Me.PRDUCTOComboBox.Name = "PRDUCTOComboBox"
        Me.PRDUCTOComboBox.Size = New System.Drawing.Size(184, 25)
        Me.PRDUCTOComboBox.TabIndex = 10
        Me.PRDUCTOComboBox.ValueMember = "PRODUCTO"
        '
        'PRECIOLabel2
        '
        Me.PRECIOLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTPRODBindingSource, "PRECIO", True))
        Me.PRECIOLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRECIOLabel2.Location = New System.Drawing.Point(134, 137)
        Me.PRECIOLabel2.Name = "PRECIOLabel2"
        Me.PRECIOLabel2.Size = New System.Drawing.Size(100, 23)
        Me.PRECIOLabel2.TabIndex = 13
        Me.PRECIOLabel2.Text = "00.00"
        '
        'CANTIUNILabel1
        '
        Me.CANTIUNILabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTPRODBindingSource, "CANTIUNI", True))
        Me.CANTIUNILabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANTIUNILabel1.Location = New System.Drawing.Point(303, 160)
        Me.CANTIUNILabel1.Name = "CANTIUNILabel1"
        Me.CANTIUNILabel1.Size = New System.Drawing.Size(100, 23)
        Me.CANTIUNILabel1.TabIndex = 16
        Me.CANTIUNILabel1.Text = "0"
        '
        'CANTICAJLabel1
        '
        Me.CANTICAJLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTPRODBindingSource, "CANTICAJ", True))
        Me.CANTICAJLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANTICAJLabel1.Location = New System.Drawing.Point(451, 160)
        Me.CANTICAJLabel1.Name = "CANTICAJLabel1"
        Me.CANTICAJLabel1.Size = New System.Drawing.Size(100, 23)
        Me.CANTICAJLabel1.TabIndex = 17
        Me.CANTICAJLabel1.Text = "0"
        '
        'NOTASTableAdapter
        '
        Me.NOTASTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CONTPRODTableAdapter = Nothing
        Me.TableAdapterManager.CONTSUELDTableAdapter = Nothing
        Me.TableAdapterManager.NOMITableAdapter = Nothing
        Me.TableAdapterManager.NOTASTableAdapter = Me.NOTASTableAdapter
        Me.TableAdapterManager.UpdateOrder = TPS.dbsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CONTPRODTableAdapter
        '
        Me.CONTPRODTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(27, 620)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 32)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Regresar al menú"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(647, 620)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 33)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Llevar nota a word"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Pedido:"
        '
        'CANTIDADTextBox
        '
        Me.CANTIDADTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NOTASBindingSource, "CANTIDAD", True))
        Me.CANTIDADTextBox.Location = New System.Drawing.Point(129, 199)
        Me.CANTIDADTextBox.Name = "CANTIDADTextBox"
        Me.CANTIDADTextBox.Size = New System.Drawing.Size(100, 25)
        Me.CANTIDADTextBox.TabIndex = 22
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(704, 185)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 50)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Agregar otro producto"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(235, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 17)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Tipo:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Caja", "Unidad"})
        Me.ComboBox1.Location = New System.Drawing.Point(278, 199)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 25)
        Me.ComboBox1.TabIndex = 25
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Location = New System.Drawing.Point(169, 281)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(86, 138)
        Me.ListBox1.TabIndex = 26
        '
        'ListBox2
        '
        Me.ListBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 17
        Me.ListBox2.Location = New System.Drawing.Point(292, 281)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(250, 138)
        Me.ListBox2.TabIndex = 27
        '
        'ListBox3
        '
        Me.ListBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 17
        Me.ListBox3.Location = New System.Drawing.Point(560, 281)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(86, 138)
        Me.ListBox3.TabIndex = 28
        '
        'ListBox4
        '
        Me.ListBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 17
        Me.ListBox4.Location = New System.Drawing.Point(654, 281)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(86, 138)
        Me.ListBox4.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(557, 261)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 17)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Tipo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(289, 261)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 17)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Producto:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(166, 261)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 17)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Cantidad:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(651, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 17)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Subtotal:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(405, 202)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 17)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Subtotal:"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NOTASBindingSource, "CANTIDAD", True))
        Me.TextBox1.Location = New System.Drawing.Point(470, 199)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 25)
        Me.TextBox1.TabIndex = 35
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(576, 185)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(122, 50)
        Me.Button4.TabIndex = 36
        Me.Button4.Text = "Resultado"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(170, 443)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox2.Size = New System.Drawing.Size(85, 147)
        Me.TextBox2.TabIndex = 37
        Me.TextBox2.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(292, 443)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox3.Size = New System.Drawing.Size(250, 152)
        Me.TextBox3.TabIndex = 38
        Me.TextBox3.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(560, 443)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox4.Size = New System.Drawing.Size(85, 152)
        Me.TextBox4.TabIndex = 39
        Me.TextBox4.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NOTASBindingSource, "SUBTOTAL", True))
        Me.TextBox5.Location = New System.Drawing.Point(654, 443)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox5.Size = New System.Drawing.Size(85, 152)
        Me.TextBox5.TabIndex = 40
        Me.TextBox5.Visible = False
        '
        'TOTALTextBox
        '
        Me.TOTALTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TOTALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NOTASBindingSource, "TOTAL", True))
        Me.TOTALTextBox.Location = New System.Drawing.Point(826, 565)
        Me.TOTALTextBox.Name = "TOTALTextBox"
        Me.TOTALTextBox.Size = New System.Drawing.Size(100, 25)
        Me.TOTALTextBox.TabIndex = 42
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(745, 557)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 36)
        Me.Button5.TabIndex = 43
        Me.Button5.Text = "Total:"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 673)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TOTALTextBox)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(CANTIDADLabel)
        Me.Controls.Add(Me.CANTIDADTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(CANTICAJLabel)
        Me.Controls.Add(Me.CANTICAJLabel1)
        Me.Controls.Add(CANTIUNILabel)
        Me.Controls.Add(Me.CANTIUNILabel1)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.PRECIOLabel2)
        Me.Controls.Add(PRECIOLabel)
        Me.Controls.Add(PRDUCTOLabel)
        Me.Controls.Add(Me.PRDUCTOComboBox)
        Me.Controls.Add(CLAVELabel)
        Me.Controls.Add(Me.CLAVEComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(NOMBRELabel)
        Me.Controls.Add(Me.NOMBRETextBox)
        Me.Controls.Add(FECHALabel)
        Me.Controls.Add(Me.FECHADateTimePicker)
        Me.Controls.Add(Me.NOTASBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.Text = " TPSFripapas - Notas"
        CType(Me.NOTASBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NOTASBindingNavigator.ResumeLayout(False)
        Me.NOTASBindingNavigator.PerformLayout()
        CType(Me.NOTASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTPRODBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DbsDataSet As TPS.dbsDataSet
    Friend WithEvents NOTASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NOTASTableAdapter As TPS.dbsDataSetTableAdapters.NOTASTableAdapter
    Friend WithEvents TableAdapterManager As TPS.dbsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NOTASBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents NOTASBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FECHADateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NOMBRETextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CLAVEComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PRDUCTOComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CONTPRODBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONTPRODTableAdapter As TPS.dbsDataSetTableAdapters.CONTPRODTableAdapter
    Friend WithEvents PRECIOLabel2 As System.Windows.Forms.Label
    Friend WithEvents CANTIUNILabel1 As System.Windows.Forms.Label
    Friend WithEvents CANTICAJLabel1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CANTIDADTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TOTALTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
