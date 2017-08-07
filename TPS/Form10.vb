Imports Microsoft.Office.Interop.Access
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop.Word
Public Class Form10

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form5.con = 1
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form5.con = 1
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim glass As New rtaGlassEffectsLib.rtaGlassEffect
        glass.TopBarSize = 50
        glass.LeftBarSize = 20
        glass.RightBarSize = 20
        glass.BottomBarSize = 60
        glass.ShowEffect(Me)
    End Sub

    Private Sub CrearRespaldoDeLaBDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearRespaldoDeLaBDToolStripMenuItem.Click
        Dim ruta As String
        FolderBrowserDialog1.ShowDialog()
        ruta = FolderBrowserDialog1.SelectedPath
        System.IO.File.Copy("C:\Program Files\TPSFripapas\db\dbs.accdb", ruta + "\dbs.accdb", True)
    End Sub

    Private Sub CerrarSecionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSecionToolStripMenuItem.Click
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        Dim doc As New Microsoft.Office.Interop.Word.Application
        With doc
            .Application.Documents.Add()
            .Application.Visible = True
        End With
    End Sub

    Private Sub NuevaLibroDeExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaLibroDeExcelToolStripMenuItem.Click
        Dim doc As New Microsoft.Office.Interop.Excel.Application
        With doc
            .Application.Documents.Add()
            .Application.Visible = True
        End With
    End Sub

    Private Sub NuevaBaseDeDatosAccesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaBaseDeDatosAccesToolStripMenuItem.Click
        Dim ruta As String
        FolderBrowserDialog1.ShowDialog()
        ruta = FolderBrowserDialog1.SelectedPath
        Dim doc As New Microsoft.Office.Interop.Access.Application
        With doc
            .Application.NewCurrentDatabase(ruta, AcNewDatabaseFormat.acNewDatabaseFormatAccess2007)
            .Application.Visible = True
        End With
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyudaToolStripMenuItem.Click
        Dim help As New System.Diagnostics.Process
        help.StartInfo.FileName = "C:\Program Files\TPSFripapas\help\ini.htm"
        help.Start()
    End Sub

    Private Sub InfoDeAutoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoDeAutoresToolStripMenuItem.Click
        Form12.Show()
    End Sub
End Class