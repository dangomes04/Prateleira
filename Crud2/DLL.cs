using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Crud2
{
    class DLL
    {
        DAL dal = null;

        public DataTable exibirDadosDal()
        {
            try
            {
                DataTable DataT = new DataTable();
                dal = new DAL();

                DataT = dal.exibirDados();

                return DataT;
            }

            catch(Exception erro)
            {
                throw erro;
            }
        }
    }
}
