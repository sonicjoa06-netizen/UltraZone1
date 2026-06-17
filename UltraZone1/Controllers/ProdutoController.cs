using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using UltraZone1.Repositorio;
namespace UltraZone1.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public IActionResult Index()
        {
            var produtos = _produtoRepositorio.ListarTodos();
            return View(produtos);
        }
        [HttpGet]

        public IActionResult Criar() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Criar(ProdutoController vm)
        {
            if (!ModelState.IsValid) return View(vm);

            var produto = new Produto
            {
                Nome = vm.Nome,
                Preco = vm.Preco
            };
            _produtoRepositorio.Adicionar(produto);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Editat(int id)
        {
            var produto = _produtoRepositorio.ObterPorId(id);
            if (produto == null) return NotFound();

            var viewModel = new Produto
            {
                id = produto.Id,
                Nome = produto.Nome,
                Preco = produto.Preco
            };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Editar(int id, Produto model)
        {
            if (id != model.Id) return BadRequest();

            if (ModelState.IsValid)
            {
                var produto = new produto
                {
                    id = model.Id,
                    Nome = model.Nome,
                    preco = model.Preco
                };
                _produtoRepositorio.Atualizar(produto);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]

        public IActionResult Excluir(int id)
        {
            _produtoRepositorio.Excluir(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
