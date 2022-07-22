using System;

namespace ValidaPlacaVeiculo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a Placa do Veículo:");
            var placa = Console.ReadLine();

            var resultado = Valida.ValidarPlaca(placa);
            var mensagem = resultado ? "é válida" : "não é válida";

            Console.WriteLine($"A placa informada {mensagem}");


            Console.ReadKey();
        }
    }
}
