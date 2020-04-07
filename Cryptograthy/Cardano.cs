using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cryptograthy
{
    partial class Kazakevich
    {
        public void Cardano()
        {
            int[,] grille = {{0,0,1,0,0,1,0,1},
                             {1,0,0,1,0,0,1,0},
                             {0,0,0,0,0,0,1,0},
                             {0,0,1,0,0,1,0,0},
                             {0,0,0,1,0,0,1,0},
                             {0,0,1,0,0,0,0,0},
                             {1,0,1,0,0,0,0,0},
                             {0,0,0,1,1,0,0,0}};
            char[] first_data = textBox1.Text.ToCharArray();
            if (first_data.Length == 0)
            {
                return;
            }
            // за четыре поворота мы можем зашифровать 64 символа
            // далее мы будем
            // добавляем длину до кратности 64м
            int add = first_data.Length % 64;
            char[] second_data;
            if (add != 0)//решетка "больше", чем число символов
            {
                second_data = new char[first_data.Length + 64 - add];
                //заполняем всё мусором где не хватает
                Random r = new Random();
                for (int i = second_data.Length - 64; i < second_data.Length; i++)
                {
                    second_data[i] = first_data[r.Next(0, first_data.Length)];

                }

            }
            else
            {
                 second_data = new char[first_data.Length];
            }
            //+64
            int lengh = grille.GetLength(0);
            int wieght = grille.GetLength(1);
            for (int adrs = 0; adrs < first_data.Length; adrs++)
            {
            //0 по часовой
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (grille[i,j]==1)
                        {
                            second_data[i*8+j] = first_data[adrs];
                            adrs++;
                        }
                    }
                }
                //90 по часовой 

                for (int j = 0; j < 8; j++)
                {
                    for (int i = 7; i > -1; i--)
                    {
                        if (grille[i, j] == 1)
                        {
                            second_data[j * 8 + (7-i)] = first_data[adrs];
                            adrs++;
                        }
                    }
                }
                //180 по часовой
                for (int i = 7; i > -1; i--)
                {
                    for (int j = 7; j > -1; j--)
                    {
                        if (grille[i, j] == 1)
                        {
                            second_data[(7-i) * 8 + (7-j)] = first_data[adrs];
                            adrs++;
                        }
                    }
                }
                //270 по часовой 
                for (int j = 7; j > -1; j--)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        if (grille[i, j] == 1)
                        {
                            second_data[(7-j) * 8 + i] = first_data[adrs];
                            adrs++;
                        }
                    }
                }

            }

            textBox2.Text = new string(second_data);
           
        
        }

    }
}
