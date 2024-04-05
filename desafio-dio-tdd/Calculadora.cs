using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDioTDD
{
    public class Calculadora
    {
        List<string> historico;

        public Calculadora()
        {
            historico = new List<string>();
        }

        public int Somar(int x, int y)
        {
            int resultado = x + y;   
            historico.Insert(0,$"{x} + {y} = {resultado}");
            return resultado;
        }

        public int Subtrair(int x, int y)
        {
            int resultado = x - y;
            historico.Insert(0, $"{x} - {y} = {resultado}");
            return resultado;
        }

        public int Multiplicar(int x, int y)
        {
            int resultado = x * y;
            historico.Insert(0, $"{x} * {y} = {resultado}");
            return resultado;
        }

        public int Dividir(int x, int y)
        {
            int resultado = x / y;
            historico.Insert(0, $"{x} / {y} = {resultado}");
            return resultado;
        }

        public List<string> GetHistorico()
        {
            return historico;
        }

    }
}
