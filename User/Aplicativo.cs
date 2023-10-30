using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolsProject;

namespace User
{
    public partial class Aplicativo : Form
    {
        public Aplicativo()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var login = new Login();
            this.Hide();
            this.Visible = false;
            login.ShowDialog();

        }

        private void pnlApp_Paint(object sender, PaintEventArgs e)
        {


        }
    }
}
