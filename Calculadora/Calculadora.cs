using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        private List<string> historico;
        private string data;

        public Calculadora(string data)
        {
            historico = new List<String>();
            this.data = data;
        }

        public int Somar(int num1, int num2)
        {
            historico.Insert(0, "Res:" + (num1+num2) + " - Data: " +data);
            return (num1 + num2);
        }
        public int Subtrair(int num1, int num2)
        {
             historico.Insert(0,"Res:" + (num1-num2)+ " - Data: " +data);
            return (num1 - num2);
        }
        public int Dividir(int num1, int num2)
        {
             historico.Insert(0,"Res:" + (num1/num2)+ " - Data: " +data);
            return (num1 / num2);
        }
        public int Multiplicar(int num1, int num2)
        {
             historico.Insert(0,"Res:" + (num1*num2)+ " - Data: " +data);
            return (num1 * num2);
        }

        public List<string> Historico()
        {
            historico.RemoveRange(3, historico.Count -3);
            return historico;
        }
    }
}