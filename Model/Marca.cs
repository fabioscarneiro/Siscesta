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

        MySqlCommand cmd = new MySqlCommand();
        Conexao conn = new Conexao();


        public bool Add()
        {
            cmd.CommandText = $"INSERT INTO `marca` (`Descricao`) " +
                $"VALUES ('{this.Descricao}')";

            try
            {
                cmd.Connection = conn.connect();
                cmd.ExecuteNonQuery();
                conn.disconnect();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
    }


}
