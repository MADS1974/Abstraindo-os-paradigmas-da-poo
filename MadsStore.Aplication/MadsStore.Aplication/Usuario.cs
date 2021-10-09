namespace MadsStore.Aplication
{
    internal class Usuario
    {
        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string Email { get; internal set; }
        public string Senha { get; internal set; }
        public bool Ativo { get; internal set; }
    }
}