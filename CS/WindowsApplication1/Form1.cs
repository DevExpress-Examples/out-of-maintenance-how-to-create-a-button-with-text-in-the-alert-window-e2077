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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            alertControl1.CreateTextButton("New Text Button", "textButton1");
        }

     

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            alertControl1.Show(this, "test caption", "test text");
        }
    }
}