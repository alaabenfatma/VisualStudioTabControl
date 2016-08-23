using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tester
{
    public partial class Blue : Form
    {
        public Blue()
        {
            InitializeComponent();
            this.visualStudioTabControl1.HeaderColor = Color.FromArgb(54, 78, 114);
            this.visualStudioTabControl1.ActiveColor = Color.FromArgb(247, 238, 153);
            this.visualStudioTabControl1.HorizontalLineColor = Color.FromArgb(247, 238, 153);
            this.visualStudioTabControl1.selectedTextColor = Color.Black;
            this.visualStudioTabControl1.BackTabColor = Color.LightGray;
        }

        private void Blue_Load(object sender, EventArgs e)
        {
            
        }

       
    }
}
