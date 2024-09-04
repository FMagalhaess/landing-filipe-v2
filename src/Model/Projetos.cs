namespace Model
{
    public class Projeto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public List<Stacks> PrincipalStacks { get; set; }
    }
}