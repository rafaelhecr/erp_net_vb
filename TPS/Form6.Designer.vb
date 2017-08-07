<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim NOMBRETRABLabel As System.Windows.Forms.Label
        Dim PUESTOLabel As System.Windows.Forms.Label
        Dim SUELDODIALabel As System.Windows.Forms.Label
        Dim DIASTRABLabel As System.Windows.Forms.Label
        Dim TOTALPAGLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DbsDataSet = New TPS.dbsDataSet
        Me.NOMIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NOMITableAdapter = New TPS.dbsDataSetTableAdapters.NOMITableAdapter
        Me.TableAdapterManager = New TPS.dbsDataSetTableAdapters.TableAdapterManager
        Me.CONTSUELDTableAdapter = New TPS.dbsDataSetTableAdapters.CONTSUELDTableAdapter
        Me.NOMIBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
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
        Me.NOMIBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.NOMBRETRABTextBox = New System.Windows.Forms.TextBox
        Me.PUESTOComboBox = New System.Windows.Forms.ComboBox
        Me.CONTSUELDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SUELDODIAComboBox = New System.Windows.Forms.ComboBox
        Me.DIASTRABComboBox = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.TOTALPAGTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        NOMBRETRABLabel = New System.Windows.Forms.Label
        PUESTOLabel = New System.Windows.Forms.Label
        SUELDODIALabel = New System.Windows.Forms.Label
        DIASTRABLabel = New System.Windows.Forms.Label
        TOTALPAGLabel = New System.Windows.Forms.Label
        CType(Me.DbsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NOMIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NOMIBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NOMIBindingNavigator.SuspendLayout()
        CType(Me.CONTSUELDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NOMBRETRABLabel
        '
        NOMBRETRABLabel.AutoSize = True
        NOMBRETRABLabel.Location = New System.Drawing.Point(52, 99)
        NOMBRETRABLabel.Name = "NOMBRETRABLabel"
        NOMBRETRABLabel.Size = New System.Drawing.Size(148, 17)
        NOMBRETRABLabel.TabIndex = 5
        NOMBRETRABLabel.Text = "Nombre del trabajador:"
        '
        'PUESTOLabel
        '
        PUESTOLabel.AutoSize = True
        PUESTOLabel.Location = New System.Drawing.Point(52, 140)
        PUESTOLabel.Name = "PUESTOLabel"
        PUESTOLabel.Size = New System.Drawing.Size(115, 17)
        PUESTOLabel.TabIndex = 6
        PUESTOLabel.Text = "Puesto de trabajo:"
        '
        'SUELDODIALabel
        '
        SUELDODIALabel.AutoSize = True
        SUELDODIALabel.Location = New System.Drawing.Point(355, 137)
        SUELDODIALabel.Name = "SUELDODIALabel"
        SUELDODIALabel.Size = New System.Drawing.Size(89, 17)
        SUELDODIALabel.TabIndex = 7
        SUELDODIALabel.Text = "Sueldo diario:"
        '
        'DIASTRABLabel
        '
        DIASTRABLabel.AutoSize = True
        DIASTRABLabel.Location = New System.Drawing.Point(52, 192)
        DIASTRABLabel.Name = "DIASTRABLabel"
        DIASTRABLabel.Size = New System.Drawing.Size(100, 17)
        DIASTRABLabel.TabIndex = 9
        DIASTRABLabel.Text = "Dias trabajados"
        '
        'TOTALPAGLabel
        '
        TOTALPAGLabel.AutoSize = True
        TOTALPAGLabel.Location = New System.Drawing.Point(307, 246)
        TOTALPAGLabel.Name = "TOTALPAGLabel"
        TOTALPAGLabel.Size = New System.Drawing.Size(100, 17)
        TOTALPAGLabel.TabIndex = 14
        TOTALPAGLabel.Text = "Total a pagarle:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nomina"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(500, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Con esta herramienta cree la nomina de los trabajadores, solo llene los datos sol" & _
            "icitados:"
        '
        'DbsDataSet
        '
        Me.DbsDataSet.DataSetName = "dbsDataSet"
        Me.DbsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NOMIBindingSource
        '
        Me.NOMIBindingSource.DataMember = "NOMI"
        Me.NOMIBindingSource.DataSource = Me.DbsDataSet
        '
        'NOMITableAdapter
        '
        Me.NOMITableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CONTPRODTableAdapter = Nothing
        Me.TableAdapterManager.CONTSUELDTableAdapter = Me.CONTSUELDTableAdapter
        Me.TableAdapterManager.NOMITableAdapter = Me.NOMITableAdapter
        Me.TableAdapterManager.NOTASTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TPS.dbsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CONTSUELDTableAdapter
        '
        Me.CONTSUELDTableAdapter.ClearBeforeFill = True
        '
        'NOMIBindingNavigator
        '
        Me.NOMIBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.NOMIBindingNavigator.BackgroundImage = CType(resources.GetObject("NOMIBindingNavigator.BackgroundImage"), System.Drawing.Image)
        Me.NOMIBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NOMIBindingNavigator.BindingSource = Me.NOMIBindingSource
        Me.NOMIBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.NOMIBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.NOMIBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.NOMIBindingNavigator.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.NOMIBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.NOMIBindingNavigatorSaveItem})
        Me.NOMIBindingNavigator.Location = New System.Drawing.Point(202, 378)
        Me.NOMIBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.NOMIBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.NOMIBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.NOMIBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.NOMIBindingNavigator.Name = "NOMIBindingNavigator"
        Me.NOMIBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.NOMIBindingNavigator.Size = New System.Drawing.Size(322, 32)
        Me.NOMIBindingNavigator.TabIndex = 5
        Me.NOMIBindingNavigator.Text = "BindingNavigator1"
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
        'NOMIBindingNavigatorSaveItem
        '
        Me.NOMIBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NOMIBindingNavigatorSaveItem.Image = CType(resources.GetObject("NOMIBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.NOMIBindingNavigatorSaveItem.Name = "NOMIBindingNavigatorSaveItem"
        Me.NOMIBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 29)
        Me.NOMIBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'NOMBRETRABTextBox
        '
        Me.NOMBRETRABTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NOMIBindingSource, "NOMBRETRAB", True))
        Me.NOMBRETRABTextBox.Location = New System.Drawing.Point(206, 96)
        Me.NOMBRETRABTextBox.Name = "NOMBRETRABTextBox"
        Me.NOMBRETRABTextBox.Size = New System.Drawing.Size(349, 25)
        Me.NOMBRETRABTextBox.TabIndex = 6
        '
        'PUESTOComboBox
        '
        Me.PUESTOComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NOMIBindingSource, "PUESTO", True))
        Me.PUESTOComboBox.DataSource = Me.CONTSUELDBindingSource
        Me.PUESTOComboBox.DisplayMember = "PUESTO"
        Me.PUESTOComboBox.FormattingEnabled = True
        Me.PUESTOComboBox.Location = New System.Drawing.Point(173, 134)
        Me.PUESTOComboBox.Name = "PUESTOComboBox"
        Me.PUESTOComboBox.Size = New System.Drawing.Size(176, 25)
        Me.PUESTOComboBox.TabIndex = 7
        Me.PUESTOComboBox.ValueMember = "PUESTO"
        '
        'CONTSUELDBindingSource
        '
        Me.CONTSUELDBindingSource.DataMember = "CONTSUELD"
        Me.CONTSUELDBindingSource.DataSource = Me.DbsDataSet
        '
        'SUELDODIAComboBox
        '
        Me.SUELDODIAComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NOMIBindingSource, "SUELDODIA", True))
        Me.SUELDODIAComboBox.DataSource = Me.CONTSUELDBindingSource
        Me.SUELDODIAComboBox.DisplayMember = "SUELDO"
        Me.SUELDODIAComboBox.FormattingEnabled = True
        Me.SUELDODIAComboBox.Location = New System.Drawing.Point(450, 134)
        Me.SUELDODIAComboBox.Name = "SUELDODIAComboBox"
        Me.SUELDODIAComboBox.Size = New System.Drawing.Size(153, 25)
        Me.SUELDODIAComboBox.TabIndex = 8
        Me.SUELDODIAComboBox.ValueMember = "SUELDO"
        '
        'DIASTRABComboBox
        '
        Me.DIASTRABComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NOMIBindingSource, "DIASTRAB", True))
        Me.DIASTRABComboBox.FormattingEnabled = True
        Me.DIASTRABComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.DIASTRABComboBox.Location = New System.Drawing.Point(158, 189)
        Me.DIASTRABComboBox.Name = "DIASTRABComboBox"
        Me.DIASTRABComboBox.Size = New System.Drawing.Size(60, 25)
        Me.DIASTRABComboBox.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(81, 233)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 43)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Calcular su pago"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(81, 375)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 48)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Regresar al menu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(571, 375)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 48)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Crear en Word"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TOTALPAGTextBox
        '
        Me.TOTALPAGTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TOTALPAGTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NOMIBindingSource, "TOTALPAG", True))
        Me.TOTALPAGTextBox.Location = New System.Drawing.Point(413, 243)
        Me.TOTALPAGTextBox.Name = "TOTALPAGTextBox"
        Me.TOTALPAGTextBox.Size = New System.Drawing.Size(100, 25)
        Me.TOTALPAGTextBox.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(532, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Fecha"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(583, 52)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(117, 25)
        Me.DateTimePicker1.TabIndex = 17
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(725, 445)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(TOTALPAGLabel)
        Me.Controls.Add(Me.TOTALPAGTextBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(DIASTRABLabel)
        Me.Controls.Add(Me.DIASTRABComboBox)
        Me.Controls.Add(SUELDODIALabel)
        Me.Controls.Add(Me.SUELDODIAComboBox)
        Me.Controls.Add(PUESTOLabel)
        Me.Controls.Add(Me.PUESTOComboBox)
        Me.Controls.Add(NOMBRETRABLabel)
        Me.Controls.Add(Me.NOMBRETRABTextBox)
        Me.Controls.Add(Me.NOMIBindingNavigator)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form6"
        Me.Text = "TPSFripapas - Nomina"
        CType(Me.DbsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NOMIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NOMIBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NOMIBindingNavigator.ResumeLayout(False)
        Me.NOMIBindingNavigator.PerformLayout()
        CType(Me.CONTSUELDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DbsDataSet As TPS.dbsDataSet
    Friend WithEvents NOMIBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NOMITableAdapter As TPS.dbsDataSetTableAdapters.NOMITableAdapter
    Friend WithEvents TableAdapterManager As TPS.dbsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NOMIBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents NOMIBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CONTSUELDTableAdapter As TPS.dbsDataSetTableAdapters.CONTSUELDTableAdapter
    Friend WithEvents NOMBRETRABTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PUESTOComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SUELDODIAComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CONTSUELDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DIASTRABComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TOTALPAGTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
