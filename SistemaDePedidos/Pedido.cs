using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDePedidos
{
    class Pedido
    {
        private int pedidoId = 1;

        public int PedidoId
        {
            get { return pedidoId; }
            set { pedidoId = value; }   
        }

        private string dataEmissao;

        public string DataEmissao
        {
            get { return dataEmissao; }
            set { dataEmissao = value; }
        }

        private float valorDoProduto;

        public float ValorDoProduto
        {
            get { return valorDoProduto; }
            set { valorDoProduto = value; }
        }

        private string descricaoDoProduto;

        public string DescricaoDoProduto
        {
            get { return descricaoDoProduto; }
            set { descricaoDoProduto = value;}
        }

        private int IDconsulta;

        public int IDConsulta
        {
            get { return IDconsulta; }
            set { IDconsulta = value; }
        }

        private int IDremove;

        public int IDRemove
        {
            get { return IDremove; }
            set { IDremove = value; }
        }

        private int id = 0;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private float calculoValorTotal;
        public float CalculoValorTotal
        {
            get { return calculoValorTotal; }
            set { calculoValorTotal = value; }
        }

    }
}
