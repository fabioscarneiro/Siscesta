﻿using Siscesta.Model;
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
        public SiscestaDbContext _context { get; set; }

        public frmMarca()
        {
            _context = new SiscestaDbContext();
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            marca.Descricao = txtDesc.Text;
            marca.CreateTime = DateTime.Now;
            marca.UpdateTime = DateTime.Now;

            try
            {
                _context.Marcas.Add(marca);
                _context.SaveChanges();
                MessageBox.Show("Cadastro realizado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu o seguinte erro: {ex.Message}");
            }


        }
    }
}
