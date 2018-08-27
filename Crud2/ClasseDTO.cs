using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud2
{
    class ClasseDTO
    {
        int codigo;
        string sexo, uf, nome, telefone, celular, bairro, cidade;        
        DateTime nascimento;

        private string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        private string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        private string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        private string Cidade
        {
            get { return bairro; }
            set { bairro = value; }
        }
        
        private int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        private string UF
        {
            get { return uf; }
            set { uf = value; }
        }

        private string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private DateTime Nascimento
        {
            get { return nascimento; }
            set { nascimento = value; }
        }

    }
}
