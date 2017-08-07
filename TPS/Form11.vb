Imports Microsoft.WindowsAPICodePack.Shell
Imports Microsoft.WindowsAPICodePack
Public Class Form11
    Inherits GlassForm


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim sys As New System.Diagnostics.Process
        sys.StartInfo.FileName = "C:\Windows\system32\msinfo32.exe"
        sys.Start()
    End Sub
End Class