using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDePedidos
{
    class Gerente : Funcionario
    {
        private string senha = "gerentey";
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        public decimal calcularDesconto(decimal valorProduto)
        {
            return valorProduto -= (valorProduto * 0.10m);
        }

    }
}
