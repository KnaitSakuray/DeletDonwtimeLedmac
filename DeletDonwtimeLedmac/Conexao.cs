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
        private static string _ROTA = @"Data Source = ext-sfis-dev\sqlexpress; Initial Catalog = LEDMEC; Persist Security Info=True;User ID =UserDeleteSistemas; Password=Go9W1QZ1";
        public static string ROTA
        {
            get { return _ROTA; }
            set { _ROTA = value; }
        }
    }
}
