﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Crud2
{
    class DAL
    {
        
        MySqlConnection conexao = null;
        MySqlCommand comando;


        public DataTable exibirDados()
        {
            try
            {
                conexao = new MySqlConnection("server=localhost;user id=root;password=;persistsecurityinfo=True;database=escola;SslMode=none");
                comando = new MySqlCommand("select * from aluno", conexao);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = comando;

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }

            catch(Exception erro)
            {
                throw erro;
            }
            

            
        }
    }
}
