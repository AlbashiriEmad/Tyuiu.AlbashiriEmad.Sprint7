using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.AlbashiriEmad.Sprint7.Project.V13
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void buttonOkAbout_PDE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxAbout_PDE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
