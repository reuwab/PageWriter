Imports System.Windows.Forms

Public Class AddDateTime

	Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
		DTHandler()
		Me.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.Close()
	End Sub

	Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
		Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Close()
	End Sub
	Private Sub DTHandler()
		Dim SelectedDateTime As String
		SelectedDateTime = DateTimePicker1.Value
		Clipboard.SetText(SelectedDateTime)
		Form1.RichTextBox1.Paste()
	End Sub
End Class
