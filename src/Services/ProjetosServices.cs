using Model;

namespace Services;
public class ProjetosServices
{
    private static string loren =
        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse faucibus urna magna," +
        "vitae ullamcorper nisl egestas id. In augue leo, blandit vitae velit ac, rutrum elementum arcu." +
        "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Sed et" +
        "lacus dapibus," +
        "semper dui at, laoreet arcu. Aliquam erat volutpat. Etiam ornare iaculis sapien, eget mattis dolor volutpat" +
        "molestie. Nunc cursus est libero, vel ullamcorper purus bibendum at. Donec congue faucibus varius. Orci varius" +
        "natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Integer vestibulum pellentesque" +
        "risus id finibus. Quisque non turpis semper, rhoncus enim nec, venenatis magna.";
    List<Projeto> projetos = new List<Projeto> {
            new Projeto {
                Id = 1,
                Nome = "Projeto 1",
                Descricao = loren,
                Imagem = "https://i.postimg.cc/MTSWSvGF/Captura-de-tela-de-2024-09-09-10-48-27.png",
                PrincipalStacks = new List<string> { "Javascript", "Git", "C#" },
            },
            new Projeto {
                Id = 2,
                Nome = "Projeto 2",
                Descricao = "Descrição do projeto 2",
                Imagem = "https://i.postimg.cc/MTSWSvGF/Captura-de-tela-de-2024-09-09-10-48-27.png",
                PrincipalStacks = new List<string> { "Typescript", "SqlServer", "Python" },
            },
            new Projeto{
                Id = 3,
                Nome = "atque",
                Descricao = "Landing",
                Imagem = "https://placehold.co/60",
                PrincipalStacks = new List<string> { "Html", "C#", "Css" },

            }
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