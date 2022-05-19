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
            throw new NotImplementedException();
        }

        public bool Excluir(Banda banda)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
