using System;
using elevador.classe;

namespace elevador
{
    class Program : Elevador
    {
        static void Main(string[] args)
        {
            Elevador elevador = new Elevador();

            Console.WriteLine("Quantos andares tem este elevador?");
            elevador.totalDeAndares = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Quantas pessoas há no elevador?");
            elevador.capacidadeDoElevador = int.Parse(Console.ReadLine());
            Console.WriteLine(elevador.Entrar());

            //Console.WriteLine("Há alguem dentro do elevador?");
            Console.WriteLine(elevador.Sair());

            Console.WriteLine("Quantos Andares deseja subir?");
            
            Console.WriteLine(elevador.Subir());
            
        }
    }
}
