<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RibbonForm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
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

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RibbonForm))
		Me.Ribbon1 = New System.Windows.Forms.Ribbon()
		Me.RibbonTab1 = New System.Windows.Forms.RibbonTab()
		Me.SuspendLayout()
		'
		'Ribbon1
		'
		Me.Ribbon1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.Ribbon1.Location = New System.Drawing.Point(0, 0)
		Me.Ribbon1.Minimized = False
		Me.Ribbon1.Name = "Ribbon1"
		'
		'
		'
		Me.Ribbon1.OrbDropDown.BorderRoundness = 8
		Me.Ribbon1.OrbDropDown.Location = New System.Drawing.Point(0, 0)
		Me.Ribbon1.OrbDropDown.Name = ""
		Me.Ribbon1.OrbDropDown.Size = New System.Drawing.Size(527, 72)
		Me.Ribbon1.OrbDropDown.TabIndex = 0
		Me.Ribbon1.OrbImage = CType(resources.GetObject("Ribbon1.OrbImage"), System.Drawing.Image)
		Me.Ribbon1.OrbText = ""
		Me.Ribbon1.RibbonTabFont = New System.Drawing.Font("Trebuchet MS", 9.0!)
		Me.Ribbon1.Size = New System.Drawing.Size(800, 133)
		Me.Ribbon1.TabIndex = 0
		Me.Ribbon1.Tabs.Add(Me.RibbonTab1)
		Me.Ribbon1.Text = "Ribbon1"
		'
		'RibbonTab1
		'
		Me.RibbonTab1.Name = "RibbonTab1"
		Me.RibbonTab1.Text = "RibbonTab1"
		'
		'RibbonForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.Ribbon1)
		Me.KeyPreview = True
		Me.Name = "RibbonForm"
		Me.Text = "Byoo PageWriter"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Ribbon1 As Ribbon
	Friend WithEvents RibbonTab1 As RibbonTab
End Class
