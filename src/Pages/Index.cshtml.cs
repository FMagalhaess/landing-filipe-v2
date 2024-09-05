using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model;
using Services;

namespace src.Pages;

public class IndexModel : PageModel
{
    public List<ProjetoPronto> Projetos { get; set; }
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        var ProjetoService = new ProjetosServices();
        Projetos = ProjetoService.GetProjetos();
    }
}
