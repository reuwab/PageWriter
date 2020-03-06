Imports System.Windows.Forms

Public Class Margin_Manager

	Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
		MarginHandler()
		Me.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.Close()
	End Sub

	Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
		Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Close()
	End Sub
	Private Sub MarginHandler()
		If TextBox1.Text = "" Then
			' Do Nothing
		Else
			Form1.RichTextBox1.RightMargin = TextBox1.Text
		End If
		If CheckBox1.Checked = True Then
			Form1.RichTextBox1.ShowSelectionMargin = True
		Else
			Form1.RichTextBox1.ShowSelectionMargin = False
		End If
	End Sub

	Private Sub Margin_Manager_Load(sender As Object, e As EventArgs) Handles Me.Load
		If Form1.RichTextBox1.ShowSelectionMargin = True Then
			CheckBox1.Checked = True
		Else
			CheckBox1.Checked = False
		End If
	End Sub
End Class
