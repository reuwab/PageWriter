Imports System.Windows.Forms

Public Class IndentMangaer

	Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
		IndentHandler()
		Me.DialogResult = System.Windows.Forms.DialogResult.OK
	End Sub

	Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
		Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Close()
	End Sub
	Private Sub IndentHandler()
		If RadioButton1.Checked = True Then
			Form1.RichTextBox1.SelectionIndent = TextBox1.Text
		End If
		If RadioButton2.Checked = True Then
			Form1.RichTextBox1.SelectionHangingIndent = TextBox1.Text
		End If
		If RadioButton3.Checked = True Then
			Form1.RichTextBox1.SelectionRightIndent = TextBox1.Text
		End If
		If RadioButton4.Checked = True Then
			Form1.RichTextBox1.BulletIndent = TextBox1.Text
		End If
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		If RadioButton1.Checked = True Then
			Form1.RichTextBox1.SelectionIndent = "0"
		End If
		If RadioButton2.Checked = True Then
			Form1.RichTextBox1.SelectionHangingIndent = "0"
		End If
		If RadioButton3.Checked = True Then
			Form1.RichTextBox1.SelectionRightIndent = "0"
		End If
		If RadioButton4.Checked = True Then
			Form1.RichTextBox1.BulletIndent = "0"
		End If
	End Sub
End Class
