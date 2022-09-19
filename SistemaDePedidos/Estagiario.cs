using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDePedidos
{
    internal class Estagiario : Funcionario
    {
        public decimal calcularDesconto(decimal valorProduto)
        {
            return valorProduto -= (valorProduto * 0.03m);
        }

    }
}
