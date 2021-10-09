using System;

namespace MadsStore.Aplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new()
            {
                Id = 1,
                Nome = "Marcio",
                Email = "deejaykbello@hotmail",
                Senha = "123456",
                Ativo = true

            };




            Console.WriteLine("Hello World!");
        }
    }
}
