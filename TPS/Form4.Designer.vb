<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label1 = New System.Windows.Forms.Label
        Me.DbsDataSet = New TPS.dbsDataSet
        Me.NOTASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NOTASTableAdapter = New TPS.dbsDataSetTableAdapters.NOTASTableAdapter
        Me.TableAdapterManager = New TPS.dbsDataSetTableAdapters.TableAdapterManager
        Me.NOTASBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.NOTASBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.NOTASDataGridView = New System.Windows.Forms.DataGridView
        Me.Fecha_de_la_venta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre_del_comprador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Clave_ID_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre_del_producto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Subtotal_vendido = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total_vendido = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.DbsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NOTASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NOTASBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NOTASBindingNavigator.SuspendLayout()
        CType(Me.NOTASDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Informes"
        '
        'DbsDataSet
        '
        Me.DbsDataSet.DataSetName = "dbsDataSet"
        Me.DbsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NOTASBindingSource
        '
        Me.NOTASBindingSource.DataMember = "NOTAS"
        Me.NOTASBindingSource.DataSource = Me.DbsDataSet
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
        'NOTASBindingNavigator
        '
        Me.NOTASBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.NOTASBindingNavigator.BackgroundImage = CType(resources.GetObject("NOTASBindingNavigator.BackgroundImage"), System.Drawing.Image)
        Me.NOTASBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NOTASBindingNavigator.BindingSource = Me.NOTASBindingSource
        Me.NOTASBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.NOTASBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.NOTASBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.NOTASBindingNavigator.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.NOTASBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.NOTASBindingNavigatorSaveItem})
        Me.NOTASBindingNavigator.Location = New System.Drawing.Point(143, 603)
        Me.NOTASBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.NOTASBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.NOTASBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.NOTASBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.NOTASBindingNavigator.Name = "NOTASBindingNavigator"
        Me.NOTASBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.NOTASBindingNavigator.Size = New System.Drawing.Size(322, 32)
        Me.NOTASBindingNavigator.TabIndex = 13
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
        'NOTASDataGridView
        '
        Me.NOTASDataGridView.AutoGenerateColumns = False
        Me.NOTASDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NOTASDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha_de_la_venta, Me.Nombre_del_comprador, Me.Clave_ID_Producto, Me.Nombre_del_producto, Me.Cantidad, Me.Subtotal_vendido, Me.Total_vendido})
        Me.NOTASDataGridView.DataSource = Me.NOTASBindingSource
        Me.NOTASDataGridView.Location = New System.Drawing.Point(25, 66)
        Me.NOTASDataGridView.Name = "NOTASDataGridView"
        Me.NOTASDataGridView.Size = New System.Drawing.Size(903, 464)
        Me.NOTASDataGridView.TabIndex = 13
        '
        'Fecha_de_la_venta
        '
        Me.Fecha_de_la_venta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Fecha_de_la_venta.DataPropertyName = "FECHA"
        Me.Fecha_de_la_venta.HeaderText = "Fecha de la venta"
        Me.Fecha_de_la_venta.Name = "Fecha_de_la_venta"
        Me.Fecha_de_la_venta.Width = 95
        '
        'Nombre_del_comprador
        '
        Me.Nombre_del_comprador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Nombre_del_comprador.DataPropertyName = "NOMBRE"
        Me.Nombre_del_comprador.HeaderText = "Nombre del comprador"
        Me.Nombre_del_comprador.Name = "Nombre_del_comprador"
        Me.Nombre_del_comprador.Width = 159
        '
        'Clave_ID_Producto
        '
        Me.Clave_ID_Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Clave_ID_Producto.DataPropertyName = "CLAVE"
        Me.Clave_ID_Producto.HeaderText = "Clave de ID producto"
        Me.Clave_ID_Producto.Name = "Clave_ID_Producto"
        Me.Clave_ID_Producto.Width = 143
        '
        'Nombre_del_producto
        '
        Me.Nombre_del_producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Nombre_del_producto.DataPropertyName = "PRDUCTO"
        Me.Nombre_del_producto.HeaderText = "Nombre del Producto"
        Me.Nombre_del_producto.Name = "Nombre_del_producto"
        Me.Nombre_del_producto.Width = 147
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Cantidad.DataPropertyName = "CANTIDAD"
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 85
        '
        'Subtotal_vendido
        '
        Me.Subtotal_vendido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Subtotal_vendido.DataPropertyName = "SUBTOTAL"
        Me.Subtotal_vendido.HeaderText = "Subtotal vendido"
        Me.Subtotal_vendido.Name = "Subtotal_vendido"
        Me.Subtotal_vendido.Width = 121
        '
        'Total_vendido
        '
        Me.Total_vendido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Total_vendido.DataPropertyName = "TOTAL"
        Me.Total_vendido.HeaderText = "Total Vendido"
        Me.Total_vendido.Name = "Total_vendido"
        Me.Total_vendido.Width = 106
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(25, 588)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 47)
        Me.Button1.TabIndex = 14
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
        Me.Button2.Location = New System.Drawing.Point(493, 588)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 47)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Exportar a Excel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NOTASDataGridView)
        Me.Controls.Add(Me.NOTASBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form4"
        Me.Text = "TPSFripapas - Informes"
        CType(Me.DbsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NOTASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NOTASBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NOTASBindingNavigator.ResumeLayout(False)
        Me.NOTASBindingNavigator.PerformLayout()
        CType(Me.NOTASDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents NOTASDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Fecha_de_la_venta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre_del_comprador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Clave_ID_Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre_del_producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Subtotal_vendido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total_vendido As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
