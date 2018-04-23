Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim alertButton1 As New DevExpress.XtraBars.Alerter.AlertButton()
			Me.alertControl1 = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' alertControl1
			' 
			Me.alertControl1.AppearanceText.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))))
			Me.alertControl1.AppearanceText.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(0))))))
			Me.alertControl1.AppearanceText.Font = New System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.alertControl1.AppearanceText.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
			Me.alertControl1.AppearanceText.Options.UseBackColor = True
			Me.alertControl1.AppearanceText.Options.UseFont = True
			alertButton1.Name = "alertButton1"
			Me.alertControl1.Buttons.Add(alertButton1)
			' 
			' textEdit1
			' 
			Me.textEdit1.Location = New System.Drawing.Point(12, 12)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Properties.NullValuePrompt = "Type your text"
			Me.textEdit1.Properties.NullValuePromptShowForEmptyValue = True
			Me.textEdit1.Size = New System.Drawing.Size(764, 20)
			Me.textEdit1.TabIndex = 0
'			Me.textEdit1.EditValueChanged += New System.EventHandler(Me.textEdit1_EditValueChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(788, 48)
			Me.Controls.Add(Me.textEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private alertControl1 As DevExpress.XtraBars.Alerter.AlertControl
		Private WithEvents textEdit1 As DevExpress.XtraEditors.TextEdit
	End Class
End Namespace

