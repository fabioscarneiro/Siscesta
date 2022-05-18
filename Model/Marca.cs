using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siscesta.Model
{
    public class Marca : ClasseBase
    {
        public string Descricao { get; set; }
        public List<Modelo> Modelo { get; set; }
    }


}
