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
                                                   " dupla com um amigo, iniciamos o " +
                                                   "desenvolvimento do aplicativo ainda sem nome. Um marketplace " +
                                                   "que visa ser uma versão do mercado livre voltada para cidades " +
                                                   "menores, onde se compra da mesma cidade onde está o comprador, " +
                                                   "movimentando assim o mercado local. Utilizamos <strong>PHP</strong> <strong>Laravel</strong> para o " +
                                                   "back-end, para o desenvolvimento mobile optamos por <strong> Flutter </strong>." +
                                                   " Atualmente estamos desenvolvendo as telas em <strong>flutter</strong>." +
                                                   "Conceitos aplicados: <strong>Autorização e autênticação</strong>, <strong>Testes de ponta a" +
                                                   " ponta</strong>, <strong>metodologia ágil</strong>, <strong>consumo de API</strong> externa para ser integrada " +
                                                   "dentro do back-end, <strong>normalização de dados</strong>.\n";

    private static readonly string CalculadoraDesc = "Quando eu era dono de uma hamburgueria a coisa que eu mais" +
                                                     " tinha dificuldade era precificar o meu lanche, conversando " +
                                                     "com outros amigos donos de lanchonetes, percebi que é um " +
                                                     "problema que não era apenas meu, com isso decidi desenvolver " +
                                                     "uma calculadora que ajudaria eles com isso. A ideia é que os " +
                                                     "proprietários de lanchonetes no geral conseguem cadastrar todos " +
                                                     "os seus insumos, cadastrar seus custos fixos e variáveis, " +
                                                     "salvar receitas para facilitar revisão e com isso tudo o " +
                                                     "serviço irá calcular para ele um range de valores que ele " +
                                                     "possa cobrar, mostrando também a porcentagem de seu lucro e " +
                                                     "qual o saldo final. Esse projeto ainda encontra-se em " +
                                                     "desenvolvimento, uso <strong>C#</strong> <strong>.NET</strong> para o back-end e planejo " +
                                                     "utilizar <strong>Flutter</strong> para o front mobile e <strong>react</strong> para o front WEB";

    private static readonly string OrganizadoraDeGastos = "Durante os meus estudos com o 12x Microsoft MVP, André Baltieri, " +
                                                          "tive como projeto foco esse organizador de finanças pessoais " +
                                                          "feito em C#, com Front usando ASP.NET.";

    private static readonly string ContadorMortes = "Durante um dia de descanso enquanto jogava Elden Ring, jogo famoso " +
                                                    "por ser extremamente difícil onde morremos inúmeras vezes, decidi " +
                                                    "baixar um app para contar quantas vezes eu morri, buscando na " +
                                                    "playstore algo assim e vendo a deficiência que existia nisso, " +
                                                    "decidi por fazer meu próprio app para isso, a ideia era simples: " +
                                                    "\n1- rodar em android e ios (para isso utilizei <strong>Kotlin</strong> multiplataforma). " +
                                                    "\n2- Ser simples, afinal o usuário alvo iria utilizar muitas vezes por " +
                                                    "hora. \n3- Conseguir manter salvo esse progresso e o progresso em " +
                                                    "outros jogos. Esse foi meu primeiro contato com a linguagem <strong>kotlin</strong>. " +
                                                    "Versionei ele utilizando <strong>Git</strong> e hospedando no <strong>GitHub</strong>.";
    
    private static readonly string ApiReceitas = "Na minha jornada na trybe utilizamos uma api para treinar consumo " +
                                                 "no front-end com a proposta de ser um app de receitas, no " +
                                                 "módulo de estudos em <strong>C#</strong> tivemos que montar do zero essa " +
                                                 "api que usamos antes.";
    
    private static readonly string SistemaApostas = "";
    
    private static readonly string OrganizadorShinyHunter= "Para resolver uma deficiência específica na comunidade de " +
                                                           "quem joga pokemon resolvi fazer esse projeto que visa " +
                                                           "facilitar a vida dessa parcela da população, o projeto " +
                                                           "consiste em um agregador de informações de onde e como " +
                                                           "conseguir acesso a certos itens, onde será mais fácil " +
                                                           "capturar certos bichinhos, qual melhor estratégia para " +
                                                           "isso e algumas ferramentas que facilitaram a organização. " +
                                                           "Utilizei <strong>C#</strong> para o back-end, planejo utilizar <strong>Flutter</strong> para " +
                                                           "versões android e ios e também integrar com o OBS(software " +
                                                           "usado por criadores de conteúdo para fazer lives) " +
                                                           "para ser usado por streamers. \n";
    
    private static readonly string PortfolioDesc= "Meu portfólio pessoal, feito em <strong>C#</strong>, utilizando " +
                                                  "<strong>ASP.NET</strong> para o " +
                                                  "front, a ideia sempre foi algo mais automatizado, onde mesmo sem " +
                                                  "uso de uma api eu conseguisse colocar meus projetos de maneira " +
                                                  "centralizada e organizada onde ele voltaria para o front já " +
                                                  "formatado com o <strong>CSS</strong>. Fiz de maneira que facilita a adição de " +
                                                  "novos projetos e stacks.\n";
    List<Projeto> projetos = new List<Projeto> {
            new Projeto {
                Id = 1,
                Nome = "Marketplace com laravel",
                Descricao = MarketPlaceDescription,
                Imagem = "/Images/Marketplace.png",
                LinkUtil = "https://docs.google.com/document/d/1-Uea0pZ1BddrQMQM5nCr1Ls6M8gn0Aot39LOX9AnkJA/preview",
                PrincipalStacks = new List<string> { "Laravel", "Flutter", "Git" },
            },
            new Projeto {
                Id = 2,
                Nome = "Calculadora de custos para lanchonetes",
                Descricao = CalculadoraDesc,
                Imagem = "/Images/CalculadoraCustos.png",
                LinkUtil = "https://github.com/FMagalhaess/calculadora-custos",
                DeployLink = "",
                PrincipalStacks = new List<string> { "C#", ".NET", "Git" },
            },
            new Projeto{
                Id = 7,
                Nome = "Organizador para jogadores de pokémon",
                Descricao = OrganizadorShinyHunter,
                Imagem = "/Images/Pokeball.png",
                LinkUtil = "https://github.com/FMagalhaess/shiny-hunt-C-",
                PrincipalStacks = new List<string> { ".NET", "C#", "Flutter" },
            
            },
            // new Projeto{
            //     Id = 3,
            //     Nome = "Controle de finanças pessoais",
            //     Descricao = OrganizadoraDeGastos,
            //     Imagem = "https://placehold.co/6000/png",
            //     LinkUtil = "https://github.com/FMagalhaess/Controle-de-financas",
            //     PrincipalStacks = new List<string> { "Html", "C#", "Css" },
            //
            // },
            new Projeto{
                Id = 4,
                Nome = "Contador de game-over em games",
                Descricao = ContadorMortes,
                Imagem = "/Images/ContadorMortes.png",
                LinkUtil = "https://github.com/FMagalhaess/DeathCounterAppv2",
                PrincipalStacks = new List<string> { "Kotlin", "Git", "SqlServer" },
            
            },
            new Projeto{
                Id = 5,
                Nome = "Api site de receitas",
                Descricao = ApiReceitas,
                Imagem = "/Images/Receitas.jpg",
                LinkUtil = "https://github.com/FMagalhaess/api-app-de-receitas",
                PrincipalStacks = new List<string> { ".NET", "C#", "Javascript" },
            
            },
            // new Projeto{
            //     Id = 6,
            //     Nome = "Sistema de apostas esportivas",
            //     Descricao = SistemaApostas,
            //     Imagem = "https://placehold.co/6000/png",
            //     LinkUtil = "https://github.com/FMagalhaess/sistema-apostas",
            //     PrincipalStacks = new List<string> { "Docker", "C#", "Css" },
            //
            // },
            new Projeto{
                Id = 8,
                Nome = "Portfólio",
                Descricao = PortfolioDesc,
                Imagem = "/Images/PrintPortfolioQuadrada.png",
                PrincipalStacks = new List<string> { "Html", "C#", "Css" },
            
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
                LinkUtil = projeto.LinkUtil,
                DeployLink = projeto.DeployLink,
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