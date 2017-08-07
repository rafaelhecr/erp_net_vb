<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.DbsDataSet = New TPS.dbsDataSet
        Me.CONTPRODBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONTPRODTableAdapter = New TPS.dbsDataSetTableAdapters.CONTPRODTableAdapter
        Me.TableAdapterManager = New TPS.dbsDataSetTableAdapters.TableAdapterManager
        Me.CONTPRODBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CONTPRODBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.CONTPRODDataGridView = New System.Windows.Forms.DataGridView
        Me.Clave = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cantidad_de_unidades = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cantidad_en_cajas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.DbsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTPRODBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTPRODBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CONTPRODBindingNavigator.SuspendLayout()
        CType(Me.CONTPRODDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DbsDataSet
        '
        Me.DbsDataSet.DataSetName = "dbsDataSet"
        Me.DbsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONTPRODBindingSource
        '
        Me.CONTPRODBindingSource.DataMember = "CONTPROD"
        Me.CONTPRODBindingSource.DataSource = Me.DbsDataSet
        '
        'CONTPRODTableAdapter
        '
        Me.CONTPRODTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CONTPRODTableAdapter = Me.CONTPRODTableAdapter
        Me.TableAdapterManager.CONTSUELDTableAdapter = Nothing
        Me.TableAdapterManager.NOMITableAdapter = Nothing
        Me.TableAdapterManager.NOTASTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TPS.dbsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CONTPRODBindingNavigator
        '
        Me.CONTPRODBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CONTPRODBindingNavigator.BackgroundImage = CType(resources.GetObject("CONTPRODBindingNavigator.BackgroundImage"), System.Drawing.Image)
        Me.CONTPRODBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CONTPRODBindingNavigator.BindingSource = Me.CONTPRODBindingSource
        Me.CONTPRODBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CONTPRODBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CONTPRODBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.CONTPRODBindingNavigator.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.CONTPRODBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CONTPRODBindingNavigatorSaveItem})
        Me.CONTPRODBindingNavigator.Location = New System.Drawing.Point(203, 271)
        Me.CONTPRODBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CONTPRODBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CONTPRODBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CONTPRODBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CONTPRODBindingNavigator.Name = "CONTPRODBindingNavigator"
        Me.CONTPRODBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CONTPRODBindingNavigator.Size = New System.Drawing.Size(322, 32)
        Me.CONTPRODBindingNavigator.TabIndex = 0
        Me.CONTPRODBindingNavigator.Text = "BindingNavigator1"
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
        'CONTPRODBindingNavigatorSaveItem
        '
        Me.CONTPRODBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CONTPRODBindingNavigatorSaveItem.Image = CType(resources.GetObject("CONTPRODBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CONTPRODBindingNavigatorSaveItem.Name = "CONTPRODBindingNavigatorSaveItem"
        Me.CONTPRODBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 29)
        Me.CONTPRODBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CONTPRODDataGridView
        '
        Me.CONTPRODDataGridView.AutoGenerateColumns = False
        Me.CONTPRODDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CONTPRODDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Clave, Me.Producto, Me.Precio, Me.Cantidad_de_unidades, Me.Cantidad_en_cajas})
        Me.CONTPRODDataGridView.DataSource = Me.CONTPRODBindingSource
        Me.CONTPRODDataGridView.Location = New System.Drawing.Point(73, 65)
        Me.CONTPRODDataGridView.Name = "CONTPRODDataGridView"
        Me.CONTPRODDataGridView.Size = New System.Drawing.Size(554, 171)
        Me.CONTPRODDataGridView.TabIndex = 1
        '
        'Clave
        '
        Me.Clave.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Clave.DataPropertyName = "CLAVE"
        Me.Clave.HeaderText = "Clave"
        Me.Clave.Name = "Clave"
        Me.Clave.Width = 64
        '
        'Producto
        '
        Me.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Producto.DataPropertyName = "PRODUCTO"
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.Width = 86
        '
        'Precio
        '
        Me.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Precio.DataPropertyName = "PRECIO"
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.Width = 69
        '
        'Cantidad_de_unidades
        '
        Me.Cantidad_de_unidades.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Cantidad_de_unidades.DataPropertyName = "CANTIUNI"
        Me.Cantidad_de_unidades.HeaderText = "Cantidad de Unidades"
        Me.Cantidad_de_unidades.Name = "Cantidad_de_unidades"
        Me.Cantidad_de_unidades.Width = 149
        '
        'Cantidad_en_cajas
        '
        Me.Cantidad_en_cajas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Cantidad_en_cajas.DataPropertyName = "CANTICAJ"
        Me.Cantidad_en_cajas.HeaderText = "Cantidad en Cajas"
        Me.Cantidad_en_cajas.Name = "Cantidad_en_cajas"
        Me.Cantidad_en_cajas.Width = 98
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Inventario"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(541, 271)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 47)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Exportar a Excel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(73, 271)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 47)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Regresar al menú"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(713, 379)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CONTPRODDataGridView)
        Me.Controls.Add(Me.CONTPRODBindingNavigator)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form5"
        Me.Text = "TPSFripapas - Inventario"
        CType(Me.DbsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTPRODBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTPRODBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CONTPRODBindingNavigator.ResumeLayout(False)
        Me.CONTPRODBindingNavigator.PerformLayout()
        CType(Me.CONTPRODDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DbsDataSet As TPS.dbsDataSet
    Friend WithEvents CONTPRODBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONTPRODTableAdapter As TPS.dbsDataSetTableAdapters.CONTPRODTableAdapter
    Friend WithEvents TableAdapterManager As TPS.dbsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CONTPRODBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents CONTPRODBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CONTPRODDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Clave As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad_de_unidades As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad_en_cajas As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
