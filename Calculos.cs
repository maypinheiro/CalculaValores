using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDeValores
{
    class Calculos
    {
 
        public  String CalcularIMC(float peso, float altura)
        {
                float imc = peso / (altura * altura);

                if (imc < 18.5) return $"IMC: { imc } A baixo do peso.";
                else if (imc < 24.9) return $"IMC: {imc} Peso Normal.";
                else if (imc < 29.9) return $"IMC: {imc} Excesso de peso.";
                else if (imc < 35) return $"IMC: {imc} Obesidade.";
                else return $"IMC: {imc} Obesidade extrema.";
        }
        public  String CalculaArea( double raioDoCirculo)
        {
                 double areaCirculo = Math.PI * Math.Pow(raioDoCirculo, 2);

                 return $"Área do circulo: { areaCirculo} N2"; 
        }
        public  String CalculaRegraDeTres(float a, float b, float c)
        {
                float d = (c * b) / a;

                return $" Valor de X: { d }";
        }

    }

}
