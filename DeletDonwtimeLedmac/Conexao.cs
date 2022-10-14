using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeletDonwtimeLedmac
{
    //Conexão só serve para deletar donwtime
    class Conexao
    {
        //encapsulamento para chegar no banco
        private static string _ROTA = @"";
        public static string ROTA
        {
            get { return _ROTA; }
            set { _ROTA = value; }
        }
    }
}
