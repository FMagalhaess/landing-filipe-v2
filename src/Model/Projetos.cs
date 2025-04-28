namespace Model
{
    public class Projeto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public string LinkUtil { get; set; }
        public string DeployLink { get; set; }
        public List<String> PrincipalStacks { get; set; }
        public List<Icon> NormalStacks { get; set; }
    }
    public class ProjetoPronto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public string LinkUtil { get; set; }
        public string DeployLink { get; set; }
        public List<Icon> PrincipalStacks { get; set; }
        public List<Icon> NormalStacks { get; set; }
    }
}