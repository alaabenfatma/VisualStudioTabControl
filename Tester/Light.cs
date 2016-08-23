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
    public partial class Light : Form
    {
        public Light()
        {
            InitializeComponent();
            this.visualStudioTabControl1.HeaderColor = Color.FromArgb(237 , 238 , 242);
            this.visualStudioTabControl1.ActiveColor = Color.FromArgb(1, 122, 204);
            this.visualStudioTabControl1.HorizontalLineColor = Color.FromArgb(1, 122, 204);
            this.visualStudioTabControl1.TextColor = Color.Black;
            this.visualStudioTabControl1.BackTabColor = Color.WhiteSmoke;
        }

        private void Light_Load(object sender, EventArgs e)
        {

        }
    }
}
