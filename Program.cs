using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Exec e = new Exec();
            e.RecebeNaMatriz();
            //e.Test();
            e.VerificaLinhas();
            e.VerificaColunas();
            e.VerificaQuadrados();
            e.Saida();
            Console.ReadLine();

        }
    }
}
