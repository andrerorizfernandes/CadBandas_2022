using MySql.Data.MySqlClient;
using Pojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class BandaDal : ICadastro<Banda>
    {
        public bool Alterar(Banda banda)
        {
            MySqlCommand cmd = new MySqlCommand("Update Banda Set Descricao=@Descricao, Cidade=@Cidade, Uf=@Uf, Vocalista=@Vocalista " +
                "Where CodBanda=@CodBanda",
                Conexao.ConectarBD());

            cmd.Parameters.AddWithValue("@Descricao", banda.Descricao);
            cmd.Parameters.AddWithValue("@Cidade", banda.Cidade);
            cmd.Parameters.AddWithValue("@Uf", banda.Uf);
            cmd.Parameters.AddWithValue("@Vocalista", banda.Vocalista);
            cmd.Parameters.AddWithValue("@CodBanda", banda.CodBanda);

            MySqlDataReader dr = cmd.ExecuteReader();
            return dr.RecordsAffected > 0;
        }

        public bool Excluir(Banda banda)
        {
            MySqlCommand cmd = new MySqlCommand("Delete From Banda " +
                "Where CodBanda=@CodBand",
                Conexao.ConectarBD());

            cmd.Parameters.AddWithValue("CodBand", banda.CodBanda);

            MySqlDataReader dr = cmd.ExecuteReader();
            return dr.RecordsAffected > 0;
        }

        public bool Inserir(Banda banda)
        {
            MySqlCommand cmd = new MySqlCommand("Insert Into Banda (Descricao, Cidade, Uf, Vocalista) Values " +
                "(@Descricao, @Cidade, @Uf, @Vocalista)",
                Conexao.ConectarBD());

            cmd.Parameters.AddWithValue("@Descricao", banda.Descricao);
            cmd.Parameters.AddWithValue("@Cidade", banda.Cidade);
            cmd.Parameters.AddWithValue("@Uf", banda.Uf);
            cmd.Parameters.AddWithValue("@Vocalista", banda.Vocalista);

            MySqlDataReader dr = cmd.ExecuteReader();
            return dr.RecordsAffected > 0;
        }

        public List<Banda> Listar()
        {
            MySqlCommand cmd = new MySqlCommand("Select CodBanda, Descricao, Cidade, Uf, Vocalista From Banda",
                Conexao.ConectarBD());
            MySqlDataReader dr = cmd.ExecuteReader();

            List<Banda> lb = new List<Banda>();

            while (dr.Read())
            {
                Banda b = new Banda();
                b.CodBanda = Convert.ToInt32(dr["CodBanda"].ToString());
                b.Descricao = dr["Descricao"].ToString();
                b.Cidade = dr["Cidade"].ToString();
                b.Uf = dr["Uf"].ToString();
                b.Vocalista = dr["Vocalista"].ToString();

                lb.Add(b);
            }

            return lb;
        }
    }
}
