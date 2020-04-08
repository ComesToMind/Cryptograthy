using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cryptograthy
{
    partial class Kazakevich
    {
        int[,] grille = {{0,0,1,0,0,1,0,1},
                         {1,0,0,1,0,0,1,0},
                         {0,0,0,0,0,0,1,0},
                         {0,0,1,0,0,1,0,0},
                         {0,0,0,1,0,0,1,0},
                         {0,0,1,0,0,0,0,0},
                         {1,0,1,0,0,0,0,0},
                         {0,0,0,1,1,0,0,0}};
        //функция шифрования
        public void CardanEncrypt()
        {

            if (textBox1.Text.Length== 0)
            {
                return;
            }
            int add = textBox1.Text.Length % 64;
            char[] first_data;
            if (add != 0)
            {
                first_data = textBox1.Text.ToCharArray();
                Array.Resize<char>(ref first_data, first_data.Length + 1);
                first_data[first_data.Length - 1] = ' ';
                add++;
            }
            else
            {
                first_data = textBox1.Text.ToCharArray();
            }
            // за четыре поворота мы можем зашифровать 64 символа
            // далее мы будем
            // добавляем длину до кратности 64м
            char[] second_data;
            if (add != 0)//решетка "больше", чем число символов
            {
                second_data = new char[first_data.Length + 64 - add];
                //заполняем всё мусором где не хватает
                Random r = new Random();
                for (int i = first_data.Length-64; i < second_data.Length; i++)
                {
                    second_data[i] = first_data[r.Next(0, first_data.Length)];

                }

            }
            else
            {
                 second_data = new char[first_data.Length];
            }
            int k = 0;//+64
            
            for (int adrs = 0; adrs < first_data.Length; adrs++)
            {
            //0 по часовой
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (grille[i,j]==1)
                        {
                            second_data[i*8+j+64*k] = first_data[adrs];// i + j + 64*k
                            adrs++;
                            if (adrs == first_data.Length)
                                goto End;
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
                            second_data[j * 8 + (7-i)+64 * k] = first_data[adrs];
                            adrs++;
                            if (adrs == first_data.Length)
                                goto End;
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
                            second_data[(7-i) * 8 + (7-j)+ 64 * k] = first_data[adrs];
                            adrs++;
                            if (adrs == first_data.Length)
                                goto End;
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
                            second_data[(7-j) * 8 + i+ 64 * k] = first_data[adrs];
                            adrs++;
                            if (adrs == first_data.Length)
                                goto End;
                        }
                    }
                }
                k++;
                adrs--;
            }
            End:
            textBox2.Text = new string(second_data);
           
        
        }
        //функция расшифрования
        public void CardanDecrypt()
        {
            char[] first_data = textBox1.Text.ToCharArray();
            if (first_data.Length == 0)
            {
                return;
            }
            char[] second_data = new char[first_data.Length];
            int k = 0; 
            for (int adrs = 0; adrs < first_data.Length; adrs++)
            {
                //0 по часовой
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (grille[i, j] == 1)
                        {
                            second_data[adrs] = first_data[i * 8 + j+ 64 * k];// i + j + 64*k 
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
                            second_data[adrs] = first_data[j * 8 + (7 - i)+ 64 * k];
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
                            second_data[adrs] = first_data[(7 - i) * 8 + (7 - j)+ 64 * k];
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
                            second_data[adrs] = first_data[(7 - j) * 8 + i+ 64 * k];
                            adrs++;
                        }
                    }
                }
                k++;
                adrs--;
            }
            textBox2.Text = new string(second_data);
        }

    }
}
