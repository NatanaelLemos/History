using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace History.Controls
{
    public partial class ctrImageViewer : Form
    {
        public ctrImageViewer()
        {
            InitializeComponent();
        }

        public String Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        public String Description
        {
            get { return lblDescription.Text; }
            set { lblDescription.Text = value; }
        }

        public Image Image
        {
            get { return ptbImage.BackgroundImage; }
            set { ptbImage.BackgroundImage = value; }
        }
    }
}
