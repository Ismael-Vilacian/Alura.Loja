using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //GravarUsandoAdoNet();
            //GravarUsandoEF();
            //RecuperarProdutos();
            //RemoverUsandoEF();
            AtualizarUsandoEF();
        }

        private static void AtualizarUsandoEF()
        {
            using (var repositorio = new ProdutoDAOEntity())
            {
                var produto = repositorio.Produtos().First();

                repositorio.Atualizar(produto);
            }
        }

        private static void RemoverUsandoEF()
        {
            using (var repositorio = new ProdutoDAOEntity())
            {
                var produtos = repositorio.Produtos();

                foreach (var item in produtos)
                {
                    repositorio.Remover(item);
                }

            }
        }

        private static void RecuperarProdutos()
        {
            using (var repositorio = new ProdutoDAOEntity())
            {
                var produtos = repositorio.Produtos();

                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }
            }
        }

        private static void GravarUsandoEF()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var repositorio = new ProdutoDAOEntity())
            {
                repositorio.Adicionar(p);
            }

        }

        private static void GravarUsandoAdoNet()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var repo = new ProdutoDAO())
            {
                repo.Adicionar(p);
            }
        }
    }
}
