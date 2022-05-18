using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siscesta.Model
{
    public class Veiculo : ClasseBase
    {
        public string Placa { get; set; }
        public string Cor { get; set; }
        public int IdMarca { get; set; }
        public Marca Marca { get; set; }
        public int IdModelo { get; set; }
        public Modelo Modelo { get; set; }

    }
}
