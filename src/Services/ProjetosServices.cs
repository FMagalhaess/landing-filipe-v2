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

    private static readonly string MarketPlaceDescription = "Em cidades pequenas costumamos comprar comida por aplicativos" +
                                                   " bem como nas capitais, mas eletrodomésticos, itens de construção, itens" +
                                                   "de manutenção, entre outros são comprados indo diretamente na loja," +
                                                   " mas isso gera um problema para aqueles que tem menos tempo e/ou " +
                                                   "disponibilidade para sair de casa. Foi pensando nisso que em" +
                                                   " dupla com um amigo da mesma  cidade que eu, iniciamos o" +
                                                   "desenvolvimento do aplicativo ainda sem nome. Um marketplace " +
                                                   "que visa ser uma versão do mercado livre voltada para cidades " +
                                                   "menores, onde se compra da mesma cidade onde está o comprador, " +
                                                   "movimentando assim o mercado local. Utilizamos PHP Laravel para o " +
                                                   "back-end, para o desenvolvimento mobile optamos por Flutter. Atualmente estamos desenvolvendo as telas em flutter.\n";

    private static readonly string CalculadoraDesc = "Quando eu era dono de uma hamburgueria a coisa que eu mais tinha" +
                                                     " dificuldade era precificar o meu lanche, conversando" +
                                                     " com outros amigos donos de lanchonetes, percebi que é um" +
                                                     " problema que não era apenas meu, com isso decidi desenvolver" +
                                                     " uma calculadora que ajudaria eles com isso. Esse projeto ainda" +
                                                     " encontra-se em desenvolvimento, uso C# .NET para o back-end e" +
                                                     " planejo utilizar Flutter para o front mobile e react para o" +
                                                     " front WEB";
    List<Projeto> projetos = new List<Projeto> {
            new Projeto {
                Id = 1,
                Nome = "Marketplace com laravel",
                Descricao = MarketPlaceDescription,
                Imagem = "https://i.postimg.cc/MTSWSvGF/Captura-de-tela-de-2024-09-09-10-48-27.png",
                PrincipalStacks = new List<string> { "Laravel", "Flutter", "Git" },
            },
            new Projeto {
                Id = 2,
                Nome = "Calculadora de custos para lanchonetes",
                Descricao = CalculadoraDesc,
                Imagem = "https://i.postimg.cc/MTSWSvGF/Captura-de-tela-de-2024-09-09-10-48-27.png",
                PrincipalStacks = new List<string> { "C#", ".NET", "Flutter" },
            },
            new Projeto{
                Id = 3,
                Nome = "atque",
                Descricao = loren,
                Imagem = "https://placehold.co/6000/png",
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