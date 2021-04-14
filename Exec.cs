using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.ConsoleApp
{
    class Exec
    {
        int[,] matriz = new int[9, 9];
        string inp = "1 3 2 5 7 9 4 6 8" +
                      "4 9 8 2 6 1 3 7 5" +
                      "7 5 6 3 8 4 2 1 9" +
                      "6 4 3 1 5 8 7 9 2" +
                      "5 2 1 7 9 3 8 4 6" +
                      "9 8 7 4 2 6 5 3 1" +
                      "2 1 4 9 3 5 6 8 7" +
                      "3 6 5 8 1 7 9 2 4" +
                      "8 7 9 6 4 2 1 5 3";
        char[] vet;
        int cont = 0;
        int contm = 0;
        int a = 0;
        int b = 0;
        bool verifica = true;


        public void RecebeNaMatriz()
        {
            
            this.vet = inp.ToCharArray();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    if (vet[contm] != ' ')
                    {
                        matriz[i, cont] = (int)Char.GetNumericValue(vet[contm]);
                        if (cont != 8)
                        {
                            cont++;
                        }
                        else
                        {
                            cont = 0;
                        }
                    }
                    contm++;
                }

            }
        }

        public void VerificaLinhas()
        {
            
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    for (int k = 0; k < 9; k++)
                    {
                        if (matriz[i,j] == matriz[i,k] && j!=k)
                        {
                            this.a = 1;
                        }
                    }
                    

                }
            }
            
            
        }

        public void VerificaColunas()
        {
            
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    for (int k = 0; k < 9; k++)
                    {
                        if (matriz[j, i] == matriz[k, i] && j != k)
                        {
                            this.b = 1;
                        }
                    }


                }
            }
           
        }

        public void VerificaQuadrados()
        {
            int cont4 = 0;
            int cont5 = 0;
            int soma = 0;
            for (int i = 0; i < 3; i++)
            {
                
                for (int j = 0; j < 3; j++)
                {
                    cont4 = i * 3;
                    cont5 = j * 3;
                    soma = 0;
                    for (int k = cont4; k < cont4+3; k++)
                    {
                        for (int l = cont5; l < cont5+3; l++)
                        {
                            soma = matriz[k, l] + soma;
                        }
                    }
                    if (soma!=45)
                    {
                        this.verifica = false;
                    }
                }

            }
            if (verifica == false)
            {
                Console.WriteLine("erro");
            }
        }

        public void Saida()
        {
            if (a==0 && b ==0 && verifica == true)
            {
                Console.WriteLine("SIM!");
            }
            else
            {
                Console.WriteLine("Erro!");
            }
        }
    // public void Test()
    // {
    //     for (int i = 0; i < 9; i++)
    //     {
    //         for (int j = 0; j < 9; j++)
    //         {
    //             Console.Write(matriz[i, j]);
    //         }
    //         Console.WriteLine("");
    //     }
    // }

        
    }
}
