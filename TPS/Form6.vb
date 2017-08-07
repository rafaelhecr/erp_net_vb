Imports Microsoft.Office.Interop.Word
Public Class Form6

    Private Sub NOMIBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NOMIBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.NOMIBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbsDataSet)

    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim glass As New rtaGlassEffectsLib.rtaGlassEffect
        glass.TopBarSize = 50
        glass.BottomBarSize = 10
        glass.RightBarSize = 10
        glass.LeftBarSize = 10
        glass.ShowEffect(Me, Label1)
        'TODO: esta línea de código carga datos en la tabla 'DbsDataSet.CONTSUELD' Puede moverla o quitarla según sea necesario.
        Me.CONTSUELDTableAdapter.Fill(Me.DbsDataSet.CONTSUELD)
        'TODO: esta línea de código carga datos en la tabla 'DbsDataSet.NOMI' Puede moverla o quitarla según sea necesario.
        Me.NOMITableAdapter.Fill(Me.DbsDataSet.NOMI)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Double
        a = Val(DIASTRABComboBox.Text) * Val(SUELDODIAComboBox.Text)
        TOTALPAGTextBox.Text = a
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form10.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim doc As New Microsoft.Office.Interop.Word.Application
        With doc
            .Application.Documents.Open("C:\Program Files\TPSFripapas\doc\fno1.docx")
            .Application.Visible = True
        End With
        doc.ActiveDocument.GoTo(What:=WdGoToDirection.wdGoToNext, Name:=1)
        doc.Selection.Find.ClearFormatting()
        doc.Selection.Find.Replacement.ClearFormatting()
        With doc.Selection.Find
            .Text = "1NOMTR1"
            .Replacement.Text = NOMBRETRABTextBox.Text
            .Forward = True
            .Wrap = WdFindWrap.wdFindAsk
            .Format = False
            .MatchCase = False
            .MatchWholeWord = False
            .MatchWildcards = False
            .MatchSoundsLike = False
            .MatchAllWordForms = False
        End With
        doc.ActiveWindow.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)
        doc.Selection.Find.ClearFormatting()
        With doc.Selection.Find
            .Text = "1PUESTR1"
            .Replacement.Text = PUESTOComboBox.Text
            .Forward = True
            .Wrap = WdFindWrap.wdFindAsk
            .Format = False
            .MatchCase = False
            .MatchWholeWord = False
            .MatchWildcards = False
            .MatchSoundsLike = False
            .MatchAllWordForms = False
        End With
        doc.ActiveWindow.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)
        doc.Selection.Find.ClearFormatting()
        With doc.Selection.Find
            .Text = "1TOTAL1"
            .Replacement.Text = TOTALPAGTextBox.Text
            .Forward = True
            .Wrap = WdFindWrap.wdFindAsk
            .Format = False
            .MatchCase = False
            .MatchWholeWord = False
            .MatchWildcards = False
            .MatchSoundsLike = False
            .MatchAllWordForms = False
        End With
        doc.ActiveWindow.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)
        doc.Selection.Find.ClearFormatting()
        With doc.Selection.Find
            .Text = "1FECHA1"
            .Replacement.Text = DateTimePicker1.Text
            .Forward = True
            .Wrap = WdFindWrap.wdFindAsk
            .Format = False
            .MatchCase = False
            .MatchWholeWord = False
            .MatchWildcards = False
            .MatchSoundsLike = False
            .MatchAllWordForms = False
        End With
        doc.ActiveWindow.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)
        doc.Selection.Find.ClearFormatting()
    End Sub


    Private Sub DIASTRABComboBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DIASTRABComboBox.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub SUELDODIAComboBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SUELDODIAComboBox.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub TOTALPAGTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TOTALPAGTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub
End Class