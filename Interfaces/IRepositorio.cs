using System.Collections.Generic;

namespace APP_SERIES.Interfaces
{
    public interface IRepositorio <T> //T é um tipo genérico de classe
    {
         List<T> Lista (); //metodo lista
         T RetornaPorId(int id);
         void Insere (T entidade);
         void Exclui(int id);
         void Atualiza(int id, T entidade);
         int ProximoId();
    }
}