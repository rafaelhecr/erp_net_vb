Imports Microsoft.Office.Interop.Word
Public Class Form3
    Public suma As Double
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button3.Enabled = False
        Button5.Enabled = False
        Button2.Enabled = False
        'TODO: esta línea de código carga datos en la tabla 'DbsDataSet.CONTPROD' Puede moverla o quitarla según sea necesario.
        Me.CONTPRODTableAdapter.Fill(Me.DbsDataSet.CONTPROD)
        'TODO: esta línea de código carga datos en la tabla 'DbsDataSet.NOTAS' Puede moverla o quitarla según sea necesario.
        Me.NOTASTableAdapter.Fill(Me.DbsDataSet.NOTAS)
        Dim glass As New rtaGlassEffectsLib.rtaGlassEffect
        glass.TopBarSize = 50
        glass.BottomBarSize = 10
        glass.LeftBarSize = 10
        glass.RightBarSize = 10
        glass.ShowEffect(Me, Label1)
    End Sub

    Private Sub NOTASBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NOTASBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.NOTASBindingSource.EndEdit()
        Me.CONTPRODBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbsDataSet)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button2.Enabled = True
        Button3.Enabled = True
        Button5.Enabled = True
        Dim can, res As Double
        If ComboBox1.Text = "Caja" Then
            If CLAVEComboBox.Text = 1 Then
                res = can * (PRECIOLabel2.Text * 50)
                TextBox1.Text = can
            End If
            If CLAVEComboBox.Text = 2 Then
                res = can * (PRECIOLabel2.Text * 50)
                TextBox1.Text = can
            End If
            If CLAVEComboBox.Text = 3 Then
                res = can * (PRECIOLabel2.Text * 50)
                TextBox1.Text = can
            End If
            If CLAVEComboBox.Text = 4 Then
                res = can * (PRECIOLabel2.Text * 50)
                TextBox1.Text = can
            End If
        End If
        If ComboBox1.Text = "Unidad" Then
            If CLAVEComboBox.Text = 1 Then
                res = can * PRECIOLabel2.Text
                TextBox1.Text = can
            End If
            If CLAVEComboBox.Text = 2 Then
                res = can * PRECIOLabel2.Text
                TextBox1.Text = can
            End If
            If CLAVEComboBox.Text = 3 Then
                res = can * PRECIOLabel2.Text
                TextBox1.Text = can
            End If
            If CLAVEComboBox.Text = 4 Then
                res = can * PRECIOLabel2.Text
                TextBox1.Text = can
            End If
        End If
    End Sub

    Public Sub restainvet()
        Dim a, b, c, d As Integer
        If ComboBox1.Text = "Unidad" Then
            b = CANTIUNILabel1.Text
            a = b - CANTIDADTextBox.Text
            CANTIUNILabel1.Text = b
            If CANTIDADTextBox.Text = 50 Then
                c = CANTICAJLabel1.Text
                d = c - 1
                CANTICAJLabel1.Text = d
            End If
        End If
        If ComboBox1.Text = "Caja" Then
            c = CANTICAJLabel1.Text
            d = c - 1
            CANTICAJLabel1.Text = d
            b = CANTIUNILabel1.Text
            a = b - 50
            CANTIUNILabel1.Text = b
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Add(CANTIDADTextBox.Text)
        ListBox2.Items.Add(PRDUCTOComboBox.Text)
        ListBox3.Items.Add(ComboBox1.Text)
        ListBox4.Items.Add(TextBox1.Text)
        CANTIDADTextBox.Clear()
        TextBox1.Clear()
        ComboBox1.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i1, i2, i3, i4 As Integer
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        For i1 = 0 To ListBox1.Items.Count - 1
            TextBox2.Text = TextBox2.Text & ListBox1.Items.Item(i1) & vbCrLf
        Next
        For i2 = 0 To ListBox1.Items.Count - 1
            TextBox3.Text = TextBox3.Text & ListBox2.Items.Item(i2) & vbCrLf
        Next
        For i3 = 0 To ListBox1.Items.Count - 1
            TextBox4.Text = TextBox4.Text & ListBox3.Items.Item(i3) & vbCrLf
        Next
        For i4 = 0 To ListBox1.Items.Count - 1
            TextBox5.Text = TextBox5.Text & ListBox4.Items.Item(i4) & vbCrLf
        Next



        Dim doc As New Microsoft.Office.Interop.Word.Application
        With doc
            .Application.Documents.Open("C:\Program Files\TPSFripapas\doc\fn1.docx")
            .Application.Visible = True
        End With
        doc.ActiveDocument.GoTo(What:=WdGoToDirection.wdGoToNext, Name:=1)
        doc.Selection.Find.ClearFormatting()
        doc.Selection.Find.Replacement.ClearFormatting()
        With doc.Selection.Find
            .Text = "1NOMCLIENT1"
            .Replacement.Text = NOMBRETextBox.Text
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
            .Text = "1CANT1"
            .Replacement.Text = TextBox2.Text
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
            .Text = "1PROD1"
            .Replacement.Text = TextBox3.Text
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
            .Text = "1PREC1"
            .Replacement.Text = TextBox4.Text
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
            .Text = "1SUBT1"
            .Replacement.Text = TextBox5.Text
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
            .Replacement.Text = TOTALTextBox.Text
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
            .Text = "1FECH1"
            .Replacement.Text = FECHADateTimePicker.Text
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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim il As Integer
        Dim calcu As Double
        For il = 0 To ListBox1.Items.Count - 1
            calcu = calcu + ListBox4.Items.Item(il)
        Next
        TOTALTextBox.Text = calcu
    End Sub

    Private Sub CLAVEComboBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CLAVEComboBox.KeyPress
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


    Private Sub CANTIDADTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CANTIDADTextBox.KeyPress
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

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
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

    Private Sub TOTALTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TOTALTextBox.KeyPress
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