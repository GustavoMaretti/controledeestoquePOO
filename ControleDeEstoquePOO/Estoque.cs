using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ControleDeEstoquePOO
{
    class Estoque
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
             Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        { 
            Quantidade -= quantidade;
        }


        public override string ToString()
        {
            return Nome 
                + ", valor unitário: R$ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", quantidade em estoque: "
                + Quantidade
                + " unidades, valor total em estoque: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);  
        }
    }
}
