using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Senai.RH.Dao
{
    interface IDao<T>
    {
        void Salvar(T t);
        List<T> Consultar();
        void Excluir(T t);
    }
}
