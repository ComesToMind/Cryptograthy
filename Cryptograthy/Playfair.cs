using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptograthy
{

    partial class Kazakevich
    {
        string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяabcdefghijklmnopqrstuvwxyz" + '\xa0';
        string save_alpha = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяabcdefghijklmnopqrstuvwxyz" + '\xa0';
        public class Found
        {
            public int row = -1;
            public int col = -1;
            public char alpabet;
            public int address = -1;
        }
        
        //ФУНКЦИЯ ШИФРОВАНИЯ
	    public void Playfair()
	    {
            char[] first_data = textBox1.Text.ToCharArray();
            //проверка на ввод
            foreach (char var in first_data)
            {
                if (var == '\xa0')
                {
                    MessageBox.Show("Недопустимый символ в данных", "Некорректные данные");
                    return;

                }
            }
            //функция добавления флага в алфавит
            FlagAlphabetAll();
            //добавляем символы где повторяются в биграмме
            List<Found> cooking_data = new List<Found>();
            List<Found> splitters = new List<Found>();

            Found f = null, s = null; //парные  символы
            int indexInSecond = 0;

            //формируем биграммы из того, что есть в алфавите
            for (int i = 0; i < first_data.Length; i++)
            {
                Found sym = Find(first_data[i]);
                if (sym.row != -1)
                {
                    cooking_data.Add(sym);
                }
                else
                {
                    sym.address = indexInSecond;
                    splitters.Add(sym);
                }
                indexInSecond++;
            }
            //работа с повтор символами 
            for (int i = 1; i < cooking_data.Count; i++)
            {
                if (cooking_data[i].alpabet == cooking_data[i - 1].alpabet)
                {
                    Found split = Find('\xa0');//разделитель
                    cooking_data.Insert(i,split);
                    i++;
                }
            }
            //у последней биграммы не хватает символа
            if (cooking_data.Count % 2 == 1)
            {
                Found split = Find('\xa0');//разделитель
                cooking_data.Add(split);
            }

            


      
            //сама шифровка
            f = null; s = null; //парные  символы
            int j = 0;
         
            for (int i = 0; i < cooking_data.Count; i++)
            {

                if (cooking_data[i].row != -1)
                {
                    j = i + 1;
                    
                    Found one = cooking_data[i];
                    Found two = cooking_data[j];
                    PlayfairEncrypt(ref one, ref two );
                    cooking_data[i] = one;
                    cooking_data[j] = two;
                    i = j;
                }
            }
            //вставляем между биграммми текст, который не можем зашифровать всякие ?1:№"
            foreach (Found var in splitters)
            {
                cooking_data.Insert(var.address, var);
            }
            string cooked_text = "";

            //вывод в окно
            foreach (Found var in cooking_data)
            {
                cooked_text += var.alpabet;
            }
            textBox2.Text = cooked_text;
            alphabet = save_alpha;

        }

        //ФУНКЦИЯ РАСШИФРОВАНИЯ

        public void PlayfairDecrypt()
        {
            char[] first_data = textBox1.Text.ToCharArray();

            //функция добавления флага в алфавит
            FlagAlphabetAll();
            Found f = null, s = null; //парные  символы

            //расшифровываем
            List<Found> cooking_data = new List<Found>(); //здесь храятся все символы без разделителей 
            List<Found> splitters = new List<Found>();

            for (int i = 0; i < first_data.Length; i++)
            {
               Found smb = Find(first_data[i]);
                smb.address = i;
                if (smb.row != -1)
                {
                    if (f == null)
                    {
                        f = smb;
                    }
                    else
                    {
                        s = smb;
                        PlayfairDec(ref f, ref s);
                        if (f.alpabet != '\xa0')
                            cooking_data.Add(f);
                        if (s.alpabet != '\xa0')
                            cooking_data.Add(s);
                        f = null;

                    }

                }
                else
                {
                    splitters.Add(smb);
                }
            }
            //теперь вствляем нешифруемые разделители 
            foreach (Found var in splitters)
                {
                    cooking_data.Insert(var.address, var);
                }

            string cooked_text = "";

            //вывод в окно
            foreach (Found var in cooking_data)
            {
                cooked_text += var.alpabet;
            }
            textBox2.Text = cooked_text;

            alphabet = save_alpha;
        }
        //ФУНКЦИЯ РАБОТЫ С АЛФАВИТОМ ПРИ РАСШИФРОВАНИИ
        private void PlayfairDec(ref Found left, ref Found right)
        {
            if (left.row == right.row)
            {
                if (left.col == 0)
                    left.alpabet = alphabet[left.row*10 + 9];
                else
                    left.alpabet = alphabet[left.row * 10 + left.col-1];

                if (right.col == 0)
                    right.alpabet = alphabet[right.row * 10 + 9];
                else
                    right.alpabet = alphabet[right.row * 10 + (right.col - 1)];
                return;
            }
            if (left.col == right.col) //50 51 52 53 54 55 56 57 58 59 
            {
                if (left.row == 0)
                    left.alpabet = alphabet[50+left.col];
                else
                    left.alpabet = alphabet[(left.row * 10 + left.col - 10)];
                if (right.row == 0)
                    right.alpabet = alphabet[50 + right.col];
                else
                    right.alpabet = alphabet[right.row * 10 + right.col - 10];
                return;
            }
            else
            {
                //квадратик 
                left.alpabet = alphabet[left.row * 10 + right.col];
                right.alpabet = alphabet[right.row * 10 + left.col];
                return;
            }

        }

        //ФУНКЦИЯ РАБОТЫ С АЛФАВИТОМ ПРИ ШИФРОВАНИИ

        private void PlayfairEncrypt(ref Found left, ref Found right)
        {
          
            if (left.row == right.row)
            { 
                left.alpabet = alphabet[left.row * 10 + (left.col + 1) % 10];
                right.alpabet = alphabet[right.row * 10 + (right.col + 1) % 10];
                return;
            }
            if (left.col == right.col)
            {
                left.alpabet = alphabet[(left.row * 10 + left.col+10) % 60]; 
                right.alpabet= alphabet[(right.row * 10 + right.col + 10) % 60];
                return;
            }
            else
            {
                //квадратик 
                left.alpabet = alphabet[left.row * 10 + right.col];
                right.alpabet = alphabet[right.row * 10 + left.col];
                return;
            }



            
        }
        //ФУНКЦИЯ ВОЗВРАШАЕТ ДЛЯ БУКВЫ ИСХОДНОГО ТЕКСТА СТРОКУ И СТОЛБЕЦ  ИЗ АЛФАВИТА
        private Found Find(char smb)
        {
         if (Char.IsUpper(smb))
            {
                    smb = Char.ToLower(smb);
            }

            for (int i = 0; i < alphabet.Length; i++)
            {
                if (smb == alphabet[i])
                {
                    Found infSmb = new Found();
                    infSmb.row = i / 10;
                    infSmb.col = i % 10;
                    infSmb.alpabet = alphabet[i];
                    return infSmb;
              
                }


            }
         
            Found inf3Smb = new Found();
            inf3Smb.alpabet = smb;

            return inf3Smb;

        }
        //фУНКЦИЯ ФОРМИРОВАНИИ АЛФАВИТА ПО КЛЮЧУ
        private void FlagAlphabetAll()
        {
            char[] flagInit = null;
            foreach (Control ctrl in controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    TextBox cmb = (TextBox)ctrl;
                    if (cmb.Text != null && !cmb.Text.Equals(""))
                    {
                        flagInit = cmb.Text.ToCharArray();
                    }
                    else
                    {
                        //MessageBox.Show("Неправильное значение ключа", "Некорректные данные");
                        return;
                    }
                    break;

                }

            }
            List<char> flagList = new List<char>();


            //приводим все нижний регистр 
            for (int i = 0; i < flagInit.Length; i++)
            {
                if (Char.IsLetter(flagInit[i]) &&Char.IsUpper(flagInit[i]))
                {
                    flagInit[i] = Char.ToLower(flagInit[i]);
                }
            }

            //удаляем повторяющиеся символы 
            bool findSymb;
            for (int i = 0; i < flagInit.Length; i++)
            {
                findSymb = false;
                foreach (char var in flagList)
                {
                    if (var == flagInit[i])
                    {
                        findSymb = true;
                    }
                }
                if (!findSymb)
                {
                    flagList.Add(flagInit[i]);
                }
            }
           

            //формируем конечный ключ
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (flagList.IndexOf(alphabet[i]) == -1)
                {
                    flagList.Add(alphabet[i]);
                }
               
            }
            alphabet = String.Join("",flagList);

        }

    }

}

