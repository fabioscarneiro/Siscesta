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
    public partial class frmMarca : Form
    {
        public frmMarca()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            marca.Descricao = txtDesc.Text;
            marca.CreateTime = DateTime.Now;
            marca.UpdateTime = DateTime.Now;

            if (marca.Add())
            {
                MessageBox.Show("Marca cadastrada com sucesso");
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao realizar o cadastro da marca");
            }

        }
    }
}
