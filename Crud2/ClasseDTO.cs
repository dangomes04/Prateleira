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
        string sexo, nacionalidade, nome;
        double peso;
        DateTime nascimento;


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

        private string Nacionalidade
        {
            get { return nacionalidade; }
            set { nacionalidade = value; }
        }

        private string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        private DateTime Nascimento
        {
            get { return nascimento; }
            set { nascimento = value; }
        }

    }
}
