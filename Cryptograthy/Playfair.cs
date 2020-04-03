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
        private class Found
        {
            public int row = -1;
            public int col = -1;
            public char alpabet;
            public int address = -1;
        }
        //private class Bigramm
        //{
        //    public char left;
        //    public char right;
        ////    public int[] address;
        //}
	    public void Playfair()
	    {
            char[] first_data = textBox1.Text.ToCharArray();

            //функция добавления флага в алфавит
            FlagAlphabetAll();
            Found f = null, s = null; //парные  символы
            Found split  = new Found();//разделитель
            split.row = 5;
            split.col = 9;
            List<char> second_data = new List<char>();
            int indexInSecond = 0; 
            for (int i = 0; i < first_data.Length; i++)
            {
                //берем символ, возврашаем его строку,столбец, алфавит
                Found sym = Find(first_data[i]);
                if (sym.row != -1)
                {
                    if (f == null)
                    {
                        sym.address = indexInSecond;
                        f = sym;
                        indexInSecond++;
                        second_data.Add(f.alpabet);
                    }
                    else
                    {
                        if (s == null)
                        {
                            sym.address = indexInSecond;
                            s = sym;
                            indexInSecond++;
                            second_data.Add(s.alpabet);

                            //ставим им 'х' после двух одинаковых символов
                            if (f.alpabet == s.alpabet)
                            {
                                split.address = s.address;
                                PlayfairEncrypt(ref f, ref split);
                                second_data[f.address] = f.alpabet;
                                second_data[split.address] = split.alpabet;

                                f = s;
                                f.address = indexInSecond;
                                indexInSecond++;
                                s = null;
                                //
                                indexInSecond++;
                                //не забыть при уже существ f and s добавить символ в f 
                            }
                            else
                            {

                                PlayfairEncrypt(ref f, ref s);
                                second_data[f.address] = f.alpabet;
                                second_data[s.address] = s.alpabet;
                                f = null;
                                s = null;
                            }
                        }
                    }
                }
                else { sym.address = indexInSecond; second_data.Add(sym.alpabet); indexInSecond++; }
            }
            textBox2.Text = new string(second_data.ToArray());
            alphabet = save_alpha;
            //шифровка 

        }

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
                left.alpabet = alphabet[(left.row * 10 + left.col+left.row) % 60]; 
                right.alpabet= alphabet[(right.row * 10 + right.col + right.row) % 60];
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
            return inf3Smb;

        }

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
            //приводим все нижний регистр 
            for(int i = 0; i < flagList.Count();i++)
            {
                if (Char.IsUpper(flagList[i]))
                {
                    flagList[i] = Char.ToLower(flagList[i]);
                }
            }

            //формируем конечный ключ
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (flagList.IndexOf(alphabet[i]) != -1)
                {
                    flagList.Add(alphabet[i]);
                }
               
            }
            alphabet = flagList.ToString();

        }

    }

}

