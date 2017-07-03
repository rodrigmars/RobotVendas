using RobotVendas.Domain.Entities;
using RobotVendas.Domain.Interfaces;

namespace RobotVendas.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository) : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
    }
}