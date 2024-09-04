using Model;

namespace Services;
public class ProjetosServices {
    public List<Projeto> GetProjetos() {
        return new List<Projeto>{
            new Projeto {
                Id = 1,
                Nome = "Projeto 1",
                Descricao = "Descrição do projeto 1",
                Imagem = "https://via.placeholder.com/300",
                PrincipalStacks = new List<Stacks> {
                    new Stacks {
                        id = 1,
                        name = "Stack 1",
                        icon = "https://via.placeholder.com/50"
                    },
                    new Stacks {
                        id = 2,
                        name = "Stack 2",
                        icon = "https://via.placeholder.com/50"
                    },
                    new Stacks {
                        id = 3,
                        name = "Stack 3",
                        icon = "https://via.placeholder.com/50"
                    }
                }
            },
        };
    }
}