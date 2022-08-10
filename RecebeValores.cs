using System;

namespace CalculadoraDeValores
{
    public class RecebeValores
    {
        public IMC IMC()
        {
            IMC imc = new IMC();
            Console.WriteLine("Diguite seu peso(KG)");
            imc.Peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Diguite sua altura(M)");
            imc.Altura = float.Parse(Console.ReadLine());

            return imc ;
        }

        public Area Area()
        {
            Area area = new Area();
            Console.Write(" Informe o raio do Círculo: ");
            area.Raio = double.Parse(Console.ReadLine());

            return area;
        }

        public RegraDeTres RegraDeTres()
        {
            RegraDeTres regraDeTres = new RegraDeTres();
            Console.Write("Insira o valor de A: ");
            regraDeTres.Operador1 = float.Parse(Console.ReadLine());

            Console.Write("Insira o valor de B: ");
            regraDeTres.Operador2 = float.Parse(Console.ReadLine());

            Console.Write("Insira o valor de C: ");
            regraDeTres.Operador3 = float.Parse(Console.ReadLine());

            return regraDeTres;
        }

    }
}
