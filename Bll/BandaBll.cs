using Pojo;
using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class BandaBll : ICadastro<Banda>
    {
        public bool Alterar(Banda banda)
        {
            BandaDal bdl = new BandaDal();
            return bdl.Alterar(banda);
        }

        public bool Excluir(Banda banda)
        {
            BandaDal bdl = new BandaDal();
            return bdl.Excluir(banda);
        }

        public bool Inserir(Banda banda)
        {
            BandaDal bdl = new BandaDal();
            return bdl.Inserir(banda);
        }

        public List<Banda> Listar()
        {
            BandaDal bdl = new BandaDal();
            return bdl.Listar();
        }
    }
}
