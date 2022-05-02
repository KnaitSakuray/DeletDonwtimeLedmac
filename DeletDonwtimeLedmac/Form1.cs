using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeletDonwtimeLedmac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string delet = "";
       
        //comando para Delet de Donwtime pelo ID Linkado com o banco
        private void DeletDonwtime()
        {
        
              //Abre conexão com o  banco
            SqlConnection conm = new SqlConnection(Conexao.ROTA);
            SqlCommand comande1 = new SqlCommand(@"  DELETE FROM LEDMEC.[dbo].[DOWN_TIME_MEC] WHERE Id =@Id", conm);
            comande1.Parameters.Add("@Id", SqlDbType.Int).Value = delet;
            
            conm.Open();
            comande1.ExecuteScalar();
            
            //Fecha Conexão com o banco
            conm.Close();
       
         
        }

        //botão onde será Clicado para Deletar!
        private void Delet_Click(object sender, EventArgs e)
        {
            delet = textBox.Text.Trim();
            DeletDonwtime();
            
        }
    }
}
