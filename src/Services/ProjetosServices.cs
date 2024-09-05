using Model;

namespace Services;
public class ProjetosServices {
    List<Projeto> projetos = new List<Projeto> {
            new Projeto {
                Id = 1,
                Nome = "Projeto 1",
                Descricao = "Descrição do projeto 1",
                Imagem = "https://via.placeholder.com/300",
                PrincipalStacks = new List<string> { "Javascript", "TypeScript", "C#" },
            },
        };
    List<ProjetoPronto> projetosConvertidos = new List<ProjetoPronto>();
    public List<ProjetoPronto> GetProjetos() {
        foreach (var projeto in projetos)
        {
            var projetoConvertido = new ProjetoPronto()
            {
                Id = projeto.Id,
                Nome = projeto.Nome,
                Descricao = projeto.Descricao,
                Imagem = projeto.Imagem,
                PrincipalStacks = new List<Icon>(),
            };
            foreach (var stack in projeto.PrincipalStacks)
            {
                var iconService = new IconServices();
                Icon icon = iconService.GetIconByName(stack);
                projetoConvertido.PrincipalStacks.Add(icon);
            }
            projetosConvertidos.Add(projetoConvertido);
        }
        return projetosConvertidos;
    }
}