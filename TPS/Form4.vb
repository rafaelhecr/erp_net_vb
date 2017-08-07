Imports Microsoft.Office.Interop.Excel
Public Class Form4
    Public con As Integer
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbsDataSet.NOTAS' Puede moverla o quitarla según sea necesario.
        Me.NOTASTableAdapter.Fill(Me.DbsDataSet.NOTAS)
        'TODO: esta línea de código carga datos en la tabla 'DbsDataSet.NOTAS' Puede moverla o quitarla según sea necesario.
        Me.NOTASTableAdapter.Fill(Me.DbsDataSet.NOTAS)
        'TODO: esta línea de código carga datos en la tabla 'DbsDataSet.NOTAS' Puede moverla o quitarla según sea necesario.
        Me.NOTASTableAdapter.Fill(Me.DbsDataSet.NOTAS)
        Dim glass As New rtaGlassEffectsLib.rtaGlassEffect
        glass.TopBarSize = 50
        glass.BottomBarSize = 10
        glass.RightBarSize = 10
        glass.LeftBarSize = 10
        glass.ShowEffect(Me, Label1)
    End Sub
    Sub buscar_fecha()
        Dim cn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Program Files\TPSFripapas\db\dbs.accdb;Jet OLEDB:Database Password=adminsys")

    End Sub


    Private Sub NOTASBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NOTASBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.NOTASBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbsDataSet)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = NOTASDataGridView.ColumnCount
            Dim NRow As Integer = NOTASDataGridView.RowCount

            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = NOTASDataGridView.Columns(i - 1).Name.ToString
                'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = NOTASDataGridView.Rows(Fila).Cells(Col).Value
                Next
            Next
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()


            'Aplicación visible
            exApp.Application.Visible = True

            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If con = 0 Then
            Form2.Show()
            Me.Hide()
        End If
        If con = 1 Then
            Form10.Show()
            Me.Hide()
        End If
    End Sub
End Class