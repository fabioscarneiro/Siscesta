
using Siscesta.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siscesta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarca frm = new frmMarca();
            frm.ShowDialog();
        }

        private void modeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModelo frm = new frmModelo();
            frm.ShowDialog();
        }
    }
}
