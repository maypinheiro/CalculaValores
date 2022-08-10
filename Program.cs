using System;

namespace CalculadoraDeValores
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal();
            SelecionaOperacao();
        }
        static void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("Escolha um Opção");
            Console.WriteLine("1- Calculadora IMC");
            Console.WriteLine("2- Calculadora Area Circulo");
            Console.WriteLine("3- Calculadora regra de 3");
            Console.WriteLine("4- Sair");
            Console.WriteLine("------------------------------");
        }

        private static void SelecionaOperacao()
        {
            RecebeValores recebeValores = new RecebeValores();
            Calculos calculo = new Calculos();
            ValidaOperadores validarOperadores = new ValidaOperadores();

            int op = int.Parse(Console.ReadLine()) - 1;

            switch (op)
            {
                case (int)Calcular.IMC:
                    {
                        var valores = recebeValores.IMC();
                        if (validarOperadores.IMC(valores.Peso, valores.Altura))
                           Console.WriteLine(calculo.CalcularIMC(valores.Peso, valores.Altura));
                    };
                    break;
                    
                case (int)Calcular.Area: {
                        var valor = recebeValores.Area();
                        if (validarOperadores.Area(valor.Raio))
                        Console.WriteLine(calculo.CalculaArea(valor.Raio));
                    };
                    break;

                case (int)Calcular.RegraDeTres:
                    {
                        var valores = recebeValores.RegraDeTres();
                        Console.WriteLine(calculo.CalculaRegraDeTres(valores.Operador1, valores.Operador2,valores.Operador3));
                    };
                    break;

                case (3): Console.WriteLine(" Programa FINALIZADO COM SUCESSO");
                    Console.ReadKey();
                    System.Environment.Exit(0); break;

                default: MenuPrincipal(); break;
            }

            Console.ReadKey();
            MenuPrincipal();
            SelecionaOperacao();

        }
        
    }
}
