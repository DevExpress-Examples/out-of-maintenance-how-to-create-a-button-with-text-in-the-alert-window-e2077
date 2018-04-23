using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Alerter;

namespace WindowsApplication1
{
    public static class AlertControlExtension
    {
        public static void CreateTextButton(this AlertControl alertControl, string text, string name)
        {
            AlertButton btn = new AlertButton();
            btn.Name = name;
            btn.Image = GetBitmapWithText(alertControl, text);
            alertControl.Buttons.Add(btn);
        }

        static Image GetBitmapWithText(AlertControl alertControl, string text)
        {
            Bitmap image = new Bitmap(1, 1);
            Graphics g = Graphics.FromImage(image);
            Size size = g.MeasureString(text, alertControl.AppearanceText.GetFont()).ToSize();
            size.Width++;
            size.Height++;
            image = new Bitmap(size.Width, size.Height);
            using (GraphicsCache graphicsCache = new GraphicsCache(Graphics.FromImage(image)))
            {
                Rectangle bounds = new Rectangle(new Point(0, 0), size);
                alertControl.AppearanceText.FillRectangle(graphicsCache, bounds);
                alertControl.AppearanceText.DrawString(graphicsCache, text, bounds);
            }
            return image;
        }

    }
}
