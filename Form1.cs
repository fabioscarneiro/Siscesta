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

            List<Pessoa> PessoaList = new List<Pessoa>();
            Pessoa pessoa = new Pessoa();
            pessoa.Id = Guid.NewGuid();
            pessoa.Nome = "Fabio";
            pessoa.DataNascimento = DateTime.Parse("29/04/1996");
            pessoa.Cpf = "444.444.444.44";
            pessoa.CreateTime = DateTime.Now;

            PessoaList.Add(pessoa);

            Pessoa pessoa2 = new Pessoa();
            pessoa2.Id = Guid.NewGuid();
            pessoa2.Nome = "Fabio258";
            pessoa2.DataNascimento = DateTime.Parse("29/04/1996");
            pessoa2.Cpf = "444.444.444.44";
            pessoa2.CreateTime = DateTime.Now;

            PessoaList.Add(pessoa2);

            foreach(var item in PessoaList)
            {
                Console.WriteLine(pessoa.Id);
                Console.WriteLine(item.Nome);
                Console.WriteLine(item.DataNascimento);
                Console.WriteLine(item.Cpf);
                Console.WriteLine(item.CreateTime);
            }

            var pessoaBuscada = PessoaList.Where(x => x.Nome == "Fabio").FirstOrDefault();
            PessoaList.Clear();


           
        }
    }
}
