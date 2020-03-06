Imports System.ComponentModel
Imports Syncfusion.Windows.Forms.Tools

Public Class Form1
	Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
		If MsgBox("Unsaved Changes Will Be Lost", "1", "Byoo PageWriter") = MsgBoxResult.Ok Then
			Me.Close()
		Else
			'Do Nothing
		End If
	End Sub
	Private Sub ChangeFont()
		FontDialog1.ShowDialog()
		RichTextBox1.SelectionFont = FontDialog1.Font
	End Sub

	Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles ToolStripButton12.Click
		ChangeFont()
	End Sub

	Private Sub FontOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontOptionsToolStripMenuItem.Click
		ChangeFont()
	End Sub
	Private Sub ChangeColour()
		SelectedTextColour.ShowDialog()
		RichTextBox1.SelectionColor = SelectedTextColour.Color
	End Sub

	Private Sub ColourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColourToolStripMenuItem.Click
		ChangeColour()
	End Sub

	Private Sub ToolStripButton13_Click(sender As Object, e As EventArgs) Handles ToolStripButton13.Click
		ChangeColour()
	End Sub

	Private Sub ChangeBackgroundColourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeBackgroundColourToolStripMenuItem.Click
		ChangeBackgroundColour()
	End Sub
	Private Sub ChangeBackgroundColour()
		BackgroundColour.ShowDialog()
		RichTextBox1.BackColor = BackgroundColour.Color
	End Sub
	Private Sub Copy()
		RichTextBox1.Copy()
	End Sub
	Private Sub Paste()
		RichTextBox1.Paste()
	End Sub
	Private Sub Cut()
		RichTextBox1.Cut()
	End Sub

	Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
		Copy()
	End Sub

	Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
		Cut()
	End Sub

	Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
		Paste()
	End Sub

	Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
		Copy()
	End Sub

	Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
		Cut()
	End Sub

	Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
		Paste()
	End Sub
	Private Sub Undo()
		RichTextBox1.Undo()
	End Sub

	Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
		Undo()
	End Sub

	Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButton11.Click
		Undo()
	End Sub
	Private Sub Redo()
		RichTextBox1.Redo()
	End Sub

	Private Sub ToolStripButton14_Click(sender As Object, e As EventArgs) Handles ToolStripButton14.Click
		Redo()
	End Sub

	Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
		Redo()
	End Sub

	Private Sub CopyToolStripMenuItem1_Click(sender As Object, e As EventArgs)
		Copy()
	End Sub

	Private Sub CutToolStripMenuItem1_Click(sender As Object, e As EventArgs)
		Cut()
	End Sub

	Private Sub PasteToolStripMenuItem1_Click(sender As Object, e As EventArgs)
		Paste()
	End Sub

	Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs)
		ChangeFont()
	End Sub

	Private Sub ColourToolStripMenuItem1_Click(sender As Object, e As EventArgs)
		ChangeColour()
	End Sub

	Private Sub BackgroundColourToolStripMenuItem_Click(sender As Object, e As EventArgs)
		ChangeBackgroundColour()
	End Sub
	Private Sub NewDocument()
		RichTextBox1.Clear()
		Me.Text = "Byoo PageWriter"
	End Sub

	Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
		NewDocument()
	End Sub

	Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
		NewDocument()
	End Sub
	Private Sub ToggleBullets()
		If RichTextBox1.SelectionBullet = True Then
			RichTextBox1.SelectionBullet = False
		Else
			RichTextBox1.SelectionBullet = True
		End If
	End Sub

	Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BulletMenu.Click
		ToggleBullets()
	End Sub

	Private Sub ToolStripSplitButton1_Click(sender As Object, e As EventArgs) Handles BulletToolbar.Click
		ToggleBullets()
	End Sub

	Private Sub ActionToUndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActionToUndoToolStripMenuItem.Click
		If RichTextBox1.UndoActionName = "" Then
			MsgBox("There's Nothing to Undo")
		Else
			MsgBox(RichTextBox1.UndoActionName)
		End If
	End Sub

	Private Sub ActionToRedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActionToRedoToolStripMenuItem.Click
		If RichTextBox1.RedoActionName = "" Then
			MsgBox("There's Nothing to Redo")
		Else
			MsgBox(RichTextBox1.RedoActionName)
		End If
	End Sub
	Private Sub Find()
		FindDialog.Show()
	End Sub

	Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
		Find()
	End Sub

	Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
		Find()
	End Sub

	Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
		AboutBox1.ShowDialog()
	End Sub
	Private Sub HighlightSelectedText()
		Highlighter.ShowDialog()
		RichTextBox1.SelectionBackColor = Highlighter.Color
	End Sub

	Private Sub HighlightSelectedTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HighlightSelectedTextToolStripMenuItem.Click
		HighlightSelectedText()
	End Sub

	Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
		HighlightSelectedText()
	End Sub

	Private Sub HighlightSelectedTextToolStripMenuItem1_Click(sender As Object, e As EventArgs)
		HighlightSelectedText()
	End Sub

	Private Sub ClearUndoActionListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearUndoActionListToolStripMenuItem.Click
		RichTextBox1.ClearUndo()
	End Sub
	Private Sub Open()
		Try
			OpenFileDialog1.Filter = "PageWriter Documents | *.page"
			OpenFileDialog1.FilterIndex = "1"
			OpenFileDialog1.Title = "Open File"
			OpenFileDialog1.ShowDialog()
			OpenFileDialog1.CheckFileExists = True
			OpenFileDialog1.CheckPathExists = True
			OpenFileDialog1.ReadOnlyChecked = False
			RichTextBox1.LoadFile(OpenFileDialog1.FileName)
			Me.Text = (OpenFileDialog1.FileName + " - Byoo PageWriter")
		Catch ex As Exception
			'Do Nothing
		End Try
	End Sub

	Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
		Open()
	End Sub

	Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
		Open()
	End Sub
	Private Sub SetIndent()
		RichTextBox1.SelectionIndent = InputBox("Enter a Number", "Set Indent")
	End Sub
	Private Sub SetHangingIndent()
		RichTextBox1.SelectionHangingIndent = InputBox("Enter a Number", "Set Hanging Indent")
	End Sub
	Private Sub SetRightIndent()
		RichTextBox1.SelectionRightIndent = InputBox("Enter a Number", "Set Right Indent")
	End Sub

	Private Sub SetIndentToolStripMenuItem_Click(sender As Object, e As EventArgs)
		SetIndent()
	End Sub

	Private Sub SetHangingIndentToolStripMenuItem_Click(sender As Object, e As EventArgs)
		SetHangingIndent()
	End Sub

	Private Sub SetRightIndentToolStripMenuItem_Click(sender As Object, e As EventArgs)
		SetRightIndent()
	End Sub
	Private Sub SetBulletIndent()
		RichTextBox1.BulletIndent = InputBox("Enter a Number", "Set Bullet Indent")
	End Sub

	Private Sub SetBulletIndentToolStripMenuItem_Click(sender As Object, e As EventArgs)
		SetBulletIndent()
	End Sub
	Private Sub Save()
		Try
			SaveFileDialog1.Filter = "PageWriter Documents | *.page"
			SaveFileDialog1.FilterIndex = "1"
			SaveFileDialog1.Title = "Save File"
			SaveFileDialog1.AddExtension = True
			SaveFileDialog1.ShowDialog()
			SaveFileDialog1.CheckFileExists = True
			SaveFileDialog1.CheckPathExists = True
			RichTextBox1.SaveFile(SaveFileDialog1.FileName)
			Me.Text = (SaveFileDialog1.FileName + " - Byoo PageWriter")
		Catch ex As Exception
			'Do Nothing
		End Try
	End Sub

	Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
		RichTextBox1.SaveFile(Me.Text)
	End Sub

	Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
		Save()
	End Sub
	Private Sub OpenPNG()
		Try
			Dim myimg As Image
			ChooseImage.Filter = "PNG Image | *.png"
			ChooseImage.FilterIndex = "1"
			ChooseImage.Title = "Choose Image"
			ChooseImage.ShowDialog()
			ChooseImage.CheckFileExists = True
			ChooseImage.CheckPathExists = True
			ChooseImage.ReadOnlyChecked = False
			myimg = Image.FromFile(ChooseImage.FileName)
			Clipboard.SetImage(myimg)
			RichTextBox1.Paste()
		Catch ex As Exception
			'Do Nothing
		End Try
	End Sub
	Private Sub OpenJPG()
		Try
			Dim myimg As Image
			ChooseImage.Filter = "JPG Image | *.jpg"
			ChooseImage.FilterIndex = "1"
			ChooseImage.Title = "Choose Image"
			ChooseImage.ShowDialog()
			ChooseImage.CheckFileExists = True
			ChooseImage.CheckPathExists = True
			ChooseImage.ReadOnlyChecked = False
			myimg = Image.FromFile(ChooseImage.FileName)
			Clipboard.SetImage(myimg)
			RichTextBox1.Paste()
		Catch ex As Exception
			'Do Nothing
		End Try
	End Sub

	Private Sub OpenPNGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenPNGToolStripMenuItem.Click
		OpenPNG()
	End Sub

	Private Sub OpenJPGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenJPGToolStripMenuItem.Click
		OpenJPG()
	End Sub

	Private Sub OpenPNGToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenPNGToolStripMenuItem1.Click
		OpenPNG()
	End Sub

	Private Sub OpenJPGToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenJPGToolStripMenuItem1.Click
		OpenJPG()
	End Sub

	Private Sub ToolStripButton10_ButtonClick(sender As Object, e As EventArgs)
		OpenPNG()
	End Sub

	Private Sub RichTextBox1_SelectionChanged(sender As Object, e As EventArgs)
		If RichTextBox1.SelectionBullet = True Then
			BulletToolbar.CheckState = CheckState.Checked
			BulletMenu.CheckState = CheckState.Checked
		Else
			BulletToolbar.CheckState = CheckState.Unchecked
			BulletMenu.CheckState = CheckState.Unchecked
		End If
		If RichTextBox1.SelectionAlignment = HorizontalAlignment.Left Then
			MenuAlignLeft.CheckState = CheckState.Checked
			ToolbarAlignLeft.CheckState = CheckState.Checked
		End If
		If RichTextBox1.SelectionAlignment = HorizontalAlignment.Center Then
			MenuAlignCentre.CheckState = CheckState.Checked
			ToolbarAlignCentre.CheckState = CheckState.Checked
		End If
		If RichTextBox1.SelectionAlignment = HorizontalAlignment.Right Then
			MenuAlignRight.CheckState = CheckState.Checked
			ToolbarAlignRight.CheckState = CheckState.Checked
		End If
	End Sub

	Private Sub ExportToRTF()
		Try
			SaveFileDialog1.Filter = "Rich Text Files | *.rtf"
			SaveFileDialog1.FilterIndex = "1"
			SaveFileDialog1.Title = "Export to RTF"
			SaveFileDialog1.AddExtension = True
			SaveFileDialog1.ShowDialog()
			SaveFileDialog1.CheckFileExists = True
			SaveFileDialog1.CheckPathExists = True
			RichTextBox1.SaveFile(SaveFileDialog1.FileName)
		Catch ex As Exception
			'Do Nothing
		End Try
	End Sub

	Private Sub PDFDocumentpdfToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PDFDocumentpdfToolStripMenuItem1.Click
		ExportToRTF()
	End Sub
	Private Sub ExportToTXT()
		Try
			SaveFileDialog1.Filter = "Text Files | *.txt"
			SaveFileDialog1.FilterIndex = "1"
			SaveFileDialog1.Title = "Export to TXT"
			SaveFileDialog1.AddExtension = True
			SaveFileDialog1.ShowDialog()
			SaveFileDialog1.CheckFileExists = True
			SaveFileDialog1.CheckPathExists = True
			RichTextBox1.SaveFile(SaveFileDialog1.FileName)
		Catch ex As Exception
			'Do Nothing
		End Try
	End Sub

	Private Sub AdobeInDesignCS5CCDocumentinddToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AdobeInDesignCS5CCDocumentinddToolStripMenuItem1.Click
		ExportToTXT()
	End Sub
	Private Sub ImportRTF()
		Try
			OpenFileDialog1.Filter = "Rich Text Files | *.rtf"
			OpenFileDialog1.FilterIndex = "1"
			OpenFileDialog1.Title = "Import RTF"
			OpenFileDialog1.ShowDialog()
			OpenFileDialog1.CheckFileExists = True
			OpenFileDialog1.CheckPathExists = True
			OpenFileDialog1.ReadOnlyChecked = False
			RichTextBox1.LoadFile(OpenFileDialog1.FileName)
		Catch ex As Exception
			'Do Nothing
		End Try
	End Sub
	Private Sub ImportTXT()
		Try
			OpenFileDialog1.Filter = "Text Files | *.txt"
			OpenFileDialog1.FilterIndex = "1"
			OpenFileDialog1.Title = "Import TXT"
			OpenFileDialog1.ShowDialog()
			OpenFileDialog1.CheckFileExists = True
			OpenFileDialog1.CheckPathExists = True
			OpenFileDialog1.ReadOnlyChecked = False
			RichTextBox1.LoadFile(OpenFileDialog1.FileName)
		Catch ex As Exception
			'Do Nothing
		End Try
	End Sub

	Private Sub TextFiletxtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextFiletxtToolStripMenuItem.Click
		ImportTXT()
	End Sub

	Private Sub RichTextFilertfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RichTextFilertfToolStripMenuItem.Click
		ImportRTF()
	End Sub
	Private Sub ZoomInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomInToolStripMenuItem.Click
		RichTextBox1.ZoomFactor = RichTextBox1.ZoomFactor + 1
	End Sub

	Private Sub ZoomOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomOutToolStripMenuItem.Click
		RichTextBox1.ZoomFactor = RichTextBox1.ZoomFactor - 1
	End Sub

	Private Sub ResetZoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetZoomToolStripMenuItem.Click
		RichTextBox1.ZoomFactor = "1"
	End Sub

	Private Sub InToolStripMenuItem_Click(sender As Object, e As EventArgs)
		RichTextBox1.ZoomFactor = RichTextBox1.ZoomFactor + 1
	End Sub

	Private Sub OutToolStripMenuItem_Click(sender As Object, e As EventArgs)
		RichTextBox1.ZoomFactor = RichTextBox1.ZoomFactor - 1
	End Sub

	Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs)
		RichTextBox1.ZoomFactor = "1"
	End Sub

	Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
		RichTextBox1.SelectAll()
	End Sub
	Private Sub IncreaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncreaseToolStripMenuItem.Click
		RichTextBox1.SelectionIndent = RichTextBox1.SelectionIndent + 1
	End Sub

	Private Sub DecreaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecreaseToolStripMenuItem.Click
		RichTextBox1.SelectionIndent = RichTextBox1.SelectionIndent - 1
	End Sub

	Private Sub ToolStripButton15_Click(sender As Object, e As EventArgs) Handles ToolStripButton15.Click
		RichTextBox1.ZoomFactor = RichTextBox1.ZoomFactor + 1
	End Sub

	Private Sub ToolStripButton16_Click(sender As Object, e As EventArgs) Handles ToolStripButton16.Click
		RichTextBox1.ZoomFactor = RichTextBox1.ZoomFactor - 1
	End Sub

	Private Sub ToolStripButton17_Click(sender As Object, e As EventArgs) Handles ToolStripButton17.Click
		RichTextBox1.ZoomFactor = "1"
	End Sub
	Private Sub RightToLeftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RightToLeftToolStripMenuItem.Click
		If RichTextBox1.RightToLeft = RightToLeft.Yes Then
			RightToLeftToolStripMenuItem.Checked = False
			RichTextBox1.RightToLeft = RightToLeft.No
		Else
			RightToLeftToolStripMenuItem.Checked = True
			RichTextBox1.RightToLeft = RightToLeft.Yes
		End If
	End Sub

	Private Sub WordWrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.Click
		If RichTextBox1.WordWrap = True Then
			WordWrapToolStripMenuItem.Checked = False
			RichTextBox1.WordWrap = False
		Else
			WordWrapToolStripMenuItem.Checked = True
			RichTextBox1.WordWrap = True
		End If
	End Sub

	Private Sub ToolStripButton18_Click(sender As Object, e As EventArgs) Handles ToolStripButton18.Click
		RichTextBox1.SelectAll()
	End Sub
	Private Sub RichTextBox1_LinkClicked(sender As Object, e As LinkClickedEventArgs)
		Dim p As New System.Diagnostics.Process
		p = System.Diagnostics.Process.Start(InputBox("Type the Web Browser you Wish to Use (IExplore.exe for Internet Explorer, chrome.exe for Google Chrome or firefox.exe for Mozilla Firefox)", "Choose the Web Browser"), e.LinkText)
	End Sub

	Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
		IndentMangaer.Show()
	End Sub

	Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
		RichTextBox1.SaveFile(Me.Text)
	End Sub

	Private Sub ToolStripButton4_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripButton4.ButtonClick
		IndentMangaer.Show()
	End Sub
	Private Sub SetRightMargin()
		Margin_Manager.Show()
	End Sub

	Private Sub OpenRightMarginManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenRightMarginManagerToolStripMenuItem.Click
		SetRightMargin()
	End Sub
	Private Sub AlignLeft()
		RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
	End Sub
	Private Sub AlignCentre()
		RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
	End Sub
	Private Sub AlignRight()
		RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
	End Sub

	Private Sub ToolStripButton19_Click(sender As Object, e As EventArgs) Handles ToolbarAlignLeft.Click
		AlignLeft()
	End Sub

	Private Sub ToolStripButton20_Click(sender As Object, e As EventArgs) Handles ToolbarAlignCentre.Click
		AlignCentre()
	End Sub

	Private Sub ToolStripButton21_Click(sender As Object, e As EventArgs) Handles ToolbarAlignRight.Click
		AlignRight()
	End Sub

	Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles MenuAlignLeft.Click
		AlignLeft()
	End Sub

	Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles MenuAlignCentre.Click
		AlignCentre()
	End Sub

	Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles MenuAlignRight.Click
		AlignRight()
	End Sub

	Private Sub ProtectSelectedTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProtectSelectedTextToolStripMenuItem.Click
		If RichTextBox1.SelectionProtected = True Then
			RichTextBox1.SelectionProtected = False
			ProtectSelectedTextToolStripMenuItem.CheckState = CheckState.Unchecked
		Else
			RichTextBox1.SelectionProtected = True
			ProtectSelectedTextToolStripMenuItem.CheckState = CheckState.Checked
		End If
	End Sub
	Private Sub InsertLine()
		Dim Line As Image
		Line = My.Resources.Line
		Clipboard.SetImage(Line)
		RichTextBox1.Paste()
	End Sub

	Private Sub ToolStripButton19_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton19.Click
		InsertLine()
	End Sub

	Private Sub LineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LineToolStripMenuItem.Click
		InsertLine()
	End Sub

	Private Sub BreakToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BreakToolStripMenuItem.Click
		Dim Break As String
		Break = "------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------"
		Clipboard.SetText(Break)
		RichTextBox1.Paste()
	End Sub

	Private Sub ToolStripMenuItem7_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
		RichTextBox1.DeselectAll()
	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
		Dim Path As String()
		Path = Environment.GetCommandLineArgs
		Try
			RichTextBox1.LoadFile(Path.ToString)
		Catch ex As System.IO.FileNotFoundException
			'Do Nothing
		End Try
	End Sub

	Private Sub ToolStripButton20_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton20.Click
		DateTime()
	End Sub
	Private Sub DateTime()
		InsertDateTime.ShowDialog()
	End Sub

	Private Sub DateAndTimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateAndTimeToolStripMenuItem.Click
		DateTime()
	End Sub

	Private Sub CopyToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem1.Click
		Copy()
	End Sub

	Private Sub CutToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles CutToolStripMenuItem1.Click
		Cut()
	End Sub

	Private Sub PasteToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem1.Click
		Paste()
	End Sub

	Private Sub FontToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
		ChangeFont()
	End Sub

	Private Sub ColourToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles ColourToolStripMenuItem1.Click
		ChangeColour()
	End Sub

	Private Sub HighlightSelectedTextToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles HighlightSelectedTextToolStripMenuItem1.Click
		HighlightSelectedText()
	End Sub

	Private Sub InToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles InToolStripMenuItem.Click
		RichTextBox1.ZoomFactor = RichTextBox1.ZoomFactor + 1
	End Sub

	Private Sub OutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles OutToolStripMenuItem.Click
		RichTextBox1.ZoomFactor = RichTextBox1.ZoomFactor - 1
	End Sub

	Private Sub ResetToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
		RichTextBox1.ZoomFactor = "1"
	End Sub
End Class