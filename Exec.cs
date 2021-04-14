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
        int c = 0;



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
            int counter1=0;
            int counter2=0;
            int counter3=0;
            int counter4=0;
            int counter5=0;
            int counter6=0;
            int counter7=0;
            int counter8=0;
            int counter9=0;
            for (int i = 0; i < 9; i++)
            {
                
                for (int j = 0; j < 9; j++)
                {
                    if ((i==0 || i == 1 || i==2) && (j==0 || j==1 || j==2))
                    {
                        counter1 = counter1 + matriz[i, j];
                    }
                    if ((i == 0 || i == 1 || i == 2) && (j == 3 || j == 4 || j == 5))
                    {
                        counter2 = counter2 + matriz[i, j];
                    }
                    if ((i == 0 || i == 1 || i == 2) && (j == 6 || j == 7 || j == 8))
                    {
                        counter3 = counter3 + matriz[i, j];
                    }

                    if ((i == 3 || i == 4 || i == 5) && (j == 0 || j == 1 || j == 2))
                    {
                        counter4 = counter4 + matriz[i, j];
                    }
                    if ((i == 3 || i == 4 || i == 5) && (j == 3 || j == 4 || j == 5))
                    {
                        counter5 = counter5 + matriz[i, j];
                    }
                    if ((i == 3 || i == 4 || i == 5) && (j == 6 || j == 7 || j == 8))
                    {
                        counter6 = counter6 + matriz[i, j];
                    }

                    if ((i == 6 || i == 7 || i == 8) && (j == 0 || j == 1 || j == 2))
                    {
                        counter7 = counter7 + matriz[i, j];
                    }
                    if ((i == 6 || i == 7 || i == 8) && (j == 3 || j == 4 || j == 5))
                    {
                        counter8 = counter8 + matriz[i, j];
                    }
                    if ((i == 6 || i == 7 || i == 8) && (j == 6 || j == 7 || j == 8))
                    {
                        counter9 = counter9 + matriz[i, j];
                    }

                    
                }
            }
            if (counter1 == 45 && counter2 == 45 && counter3 == 45 && counter4 == 45 && counter5 == 45 && counter6 == 45
                        && counter7 == 45 && counter7 == 45 && counter8 == 45 && counter9 == 45)
                this.c = 0;
            else
                this.c = 1;
        }

        public void Saida()
        {
            if (a==0 && b ==0 && c==0)
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
