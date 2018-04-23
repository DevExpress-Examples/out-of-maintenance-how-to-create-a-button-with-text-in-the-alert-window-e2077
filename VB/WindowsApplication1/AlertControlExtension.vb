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
	Public Module AlertControlExtension
	
        <System.Runtime.CompilerServices.Extension()> _
        Public Sub CreateTextButton(ByVal alertControl As AlertControl, ByVal text As String, ByVal name As String)
            Dim btn As New AlertButton()
            btn.Name = name
            btn.Image = GetBitmapWithText(alertControl, text)
            alertControl.Buttons.Add(btn)
        End Sub

        Private Function GetBitmapWithText(ByVal alertControl As AlertControl, ByVal text As String) As Image
            Dim image As New Bitmap(1, 1)
            Dim g As Graphics = Graphics.FromImage(image)
            Dim size As Size = g.MeasureString(text, alertControl.AppearanceText.GetFont()).ToSize()
            size.Width += 1
            size.Height += 1
            image = New Bitmap(size.Width, size.Height)
            Using graphicsCache As New GraphicsCache(Graphics.FromImage(image))
                Dim bounds As New Rectangle(New Point(0, 0), size)
                alertControl.AppearanceText.FillRectangle(graphicsCache, bounds)
                alertControl.AppearanceText.DrawString(graphicsCache, text, bounds)
            End Using
            Return image
        End Function

	End Module
End Namespace
