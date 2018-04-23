Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraBars.Alerter

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			alertControl1.CreateTextButton("New Text Button", "textButton1")
		End Sub



		Private Sub textEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles textEdit1.EditValueChanged
			alertControl1.Show(Me, "test caption", "test text")
		End Sub
	End Class
End Namespace