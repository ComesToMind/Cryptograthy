using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cryptograthy
{
    public partial class Polyalph : Form
    {
        public Polyalph()
        {
            InitializeComponent();
        }
        public string ru = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        public string RU = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public string en = "abcdefghijklmnopqrstuvwxyz";
        public string EN = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        bool alph_check_ru = false;
        bool alph_check_en = false;

        public double[] freqs_ru = { 0.062,0.014,0.038,0.013,0.025,0.072,0.0001,0.007,0.016,0.062,0.01,0.028,0.035,0.026,0.053,
            0.09,0.023,0.04,0.045,0.053,0.021,0.002,0.009,0.004,0.012,0.006,0.003,0.0004,0.016,0.014,0.003,0.006,0.018};
        public double[] freqs_en = {0.081,0.016,0.032,0.036,0.123,0.023,0.016,0.051,0.071,0.001,0.005,0.04,0.022,0.072,
            0.079,0.023,0.002,0.06,0.066,0.096,0.031,0.009,0.02,0.002,0.019,0.001};


        public string alphabet = "", ALPHABET = "";

        private void fieldKey_TextChanged(object sender, EventArgs e)
        {
            //РАСШИФРОВАНИЕ ПО ВВЕДЕННОМУ КЛЮЧУ
            if (fieldKey.TextLength > 0)
            {
                string res = "";
                int j = 0;
                for (int i = 0; i < fieldCiphertext.TextLength; i++)
                {
                    int curSymbNum = alphabet.IndexOf(fieldCiphertext.Text[i]);
                    int rotSymbNum = alphabet.IndexOf(fieldKey.Text[j]);
                    if (curSymbNum != -1)
                    {//строчная буква
                        res += alphabet[((curSymbNum - rotSymbNum) + alphabet.Length) % alphabet.Length];
                        j++;
                        j = j % fieldKey.TextLength;
                    }
                    else
                    {
                        curSymbNum = ALPHABET.IndexOf(fieldCiphertext.Text[i]);
                        if (curSymbNum != -1)//заглавная буква
                        {
                            res += ALPHABET[((curSymbNum - rotSymbNum) + ALPHABET.Length) % ALPHABET.Length];
                            j++;
                            j = j % fieldKey.TextLength;
                        }
                        else
                        {
                            //Символы, которых нет в алфавите, просто 
                            res += fieldCiphertext.Text[i];         
                        }
                    }
                }
                fieldOriginal.Text = res;
            }
            else fieldOriginal.Text = null;
        }

        private void fieldOriginal_TextChanged(object sender, EventArgs e)
        {
            Table_Chart_func();
        }


        private void fieldCiphertext_TextChanged(object sender, EventArgs e)
        {
            //проверяем входной текст на корректность
            fieldOriginal.Text = null;
            foundedKey.Text = null;
            keyLengthUpDown.Value = 0;

            
            int amount_ru = 0, amount_en = 0;
            for (int i = 0; i < fieldCiphertext.TextLength; i++)
            {
                if (ru.IndexOf(fieldCiphertext.Text[i]) >= 0 || RU.IndexOf(fieldCiphertext.Text[i]) >= 0)
                {
                    amount_ru++;
                }
                if (en.IndexOf(fieldCiphertext.Text[i]) >= 0 || EN.IndexOf(fieldCiphertext.Text[i]) >= 0)
                {
                    amount_en++;
                }
            }
            if (amount_ru > 0) { alphabet = ru; ALPHABET = RU; alph_check_ru = true; alph_check_en = false; }
            if (amount_en > 0) { alphabet = en; ALPHABET = EN; alph_check_ru = false; alph_check_en = true; }
            alfTextBox.Text = alphabet;
            alfExtended.Text = "";
            if (amount_en * amount_ru > 0)
            {
                fieldCiphertext.Text = null;
                MessageBox.Show("Пожалуйста, используйте только один язык.", "Ошибка");
            }

            string tmp = fieldKey.Text;
            fieldKey.Text = null;
            fieldKey.Text = tmp;
        }

        private void fieldKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symb = e.KeyChar;
            if (fieldCiphertext.TextLength > 0 &&
                (alphabet.IndexOf(symb) == -1 && ALPHABET.IndexOf(symb) == -1 && symb != (char)8)) e.Handled = true;
        }

        private void buttonFindKeyLength_Click(object sender, EventArgs e)
        {
            //МЕТОДЫ поиска длины ключа
            keyLengthUpDown.Value = 0;  //Сброс комбобокса
            if (MatchIndex_radioButton.Checked && fieldCiphertext.TextLength > 0)
            {
                //метод индекса совпадений
                int possibleLen = 1;
                while (possibleLen < fieldCiphertext.Text.Length)
                {
                    string Source = fieldCiphertext.Text.ToLower();
                    string everyXdiv = ""; // Формируем строку БЕЗ УЧЕТА РАЗДЕЛИТЕЛЕЙ
                    //каждый символ текста через длинну ключа шифруется одним и тем же смиволом ключа
                    int j = 0;
                    for (int i = 0; i < Source.Length; i++)
                    {
                        if (j % possibleLen == 0 && (alphabet.IndexOf(Source[i]) != -1 || ALPHABET.IndexOf(Source[i]) != -1)) 
                        {
                            everyXdiv += Source[i];
                            j++;
                        }
                        else if (j % possibleLen != 0 && (alphabet.IndexOf(Source[i]) != -1 || ALPHABET.IndexOf(Source[i]) != -1)) 
                        {
                            j++;
                        }
                    }

                    //Подсчитаем индекс 
                    double index = 0;
                    int[] times = new int[alphabet.Length];
                    //Array.Clear(times, 0, alphabet.Length);
                    //Вычислим количество вхождений каждой буквы
                    int amount = 0;
                    for (int i = 0; i < everyXdiv.Length; i++)
                    {
                        if (alphabet.IndexOf(everyXdiv[i]) >= 0)
                        {
                            amount++;
                            times[alphabet.IndexOf(everyXdiv[i])]++;
                        }
                    }
                    //теперь по формуле общего случая индекса совпадений f_i(f_i-1)/n(n-1)

                    for (int i = 0; i < times.Length; i++)
                    {
                        index += (times[i]) * (times[i] - 1);
                    }
                    index = index / (double)(amount * (amount - 1));
                    //if ((index > 0.0553 && alph_check_ru) || (index > 0.0644 && alph_check_en))
                    if (index > 0.0553)
                    {
                        keyLengthUpDown.Value = possibleLen;
                        goto m_exit;
                    }

                    possibleLen++;
                }
            m_exit:;
            }
            if (Autocorr_radioButton.Checked && fieldCiphertext.TextLength > 0)
            {
                //АВТОКОРЕЛЯЦИОННЫЙ МЕТОД
                string Source = (fieldCiphertext.Text).ToLower();
                for (int i = 0; i < Source.Length; i++) //Удаляем разделители
                {
                    if (alphabet.IndexOf(Source[i]) < 0)
                    {
                        string tmpDel = "";
                        tmpDel += Source[i];
                        Source = Source.Replace(tmpDel, "");
                    }
                }
                for (int possibleLength = 1; possibleLength < fieldCiphertext.Text.Length; possibleLength++)
                {
                    //циклический сдвиг строки 
                    string copySource = Source.Substring(possibleLength) + Source.Substring(0, possibleLength);

                    int coincidences = 0;
                    //количество совпадений букв
                    for (int i = 0; i < Source.Length; i++)
                    {
                        if (Source[i] == copySource[i]) coincidences++;
                    }
                    //А так как индекс совпадений вводится как вероятность совпадения двух произвольных букв в строке,
                    //    то для сдвигов, кратных или равных периоду, автокорреляционные коэффициенты,
                    //    при достаточно большой длине текста, будут близки к индексу совпадений естественного языка
                    double index = coincidences / (double)Source.Length;
                    //if ((index > 0.0553 && alph_check_ru) || (index >0.0644 && alph_check_en ))
                    if (index > 0.0553)
                    {
                        keyLengthUpDown.Value = possibleLength;
                        break;
                    }
                }
            }
            if (Casiski_radioButton.Checked && fieldCiphertext.TextLength > 0)
            {
                string Source = (fieldCiphertext.Text).ToLower();
                for (int i = 0; i < Source.Length; i++) //Удаляем разделители
                {
                    if (alphabet.IndexOf(Source[i]) < 0)
                    {
                        string tmpDel = "";
                        tmpDel += Source[i];
                        Source = Source.Replace(tmpDel, "");
                    }
                }
                if (Source.Length < 10)
                {
                    MessageBox.Show("Недостаточная длина текста для метода Касиски!", "Внимание!");
                    goto m_exit; 

                }
                string checked_sublines = ""; //В эту строку через пробел далее записывать проверенные строки
                List<int> possibleLengths = new List<int>();
                //если индекс в ней -1 то можно проверять, иначе - не надо
                for (int i = 0; i < Source.Length / 3 - 1; i++)
                {
                    string subline = Source.Substring(i, 3);
                    if (checked_sublines.IndexOf(subline) == -1)
                    {
                        //Считаем количество вхождений подстроки
                        int times = 0;
                        int j = 0;
                        while (Source.IndexOf(subline, j) != -1)
                        {
                            j = Source.IndexOf(subline, j) + 1; //Следующий поиск начнем после текущего вхождения
                            times++;
                        };
                        if (times >= 3)
                        {
                            checked_sublines += subline + " ";
                            List<int> positionsDifference = new List<int>();
                            int prev = Source.IndexOf(subline); //первое вхождение
                            j = prev + 1; //начнем поиск со второго
                            while (Source.IndexOf(subline, j) != -1)
                            {
                                int curIndex = Source.IndexOf(subline, j);
                                positionsDifference.Add(curIndex - 1);
                                prev = curIndex;
                                j = curIndex + 1;
                            };
                            int curGCD = positionsDifference[0];
                            for (int k = 1; k < positionsDifference.Count; k++)
                            {
                                curGCD = GCD(curGCD, positionsDifference[k]);
                            }
                            if (curGCD > 1) possibleLengths.Add(curGCD);
                        }
                    }
                }
                if (possibleLengths.Count > 0)
                {
                    possibleLengths.Sort();
                    int[] possibility = new int[50];
                    int i = 0;
                    while (i < possibleLengths.Count() && possibleLengths[i] < 50)
                    {
                        possibility[possibleLengths[i]]++;
                        i++;
                    }
                    for (i = 0; i < 50; i++)
                        possibility[i] = possibility[i] * i;    //Уменьшим значимость ложных срабатываний 
                    for (i = 0; i < 50; i++)
                        if (possibility[i] == possibility.Max())
                            keyLengthUpDown.Value = i;
                }
            m_exit:;
            }
        }

        private void Table_Chart_func()
        {
            int[] times_ru = new int[ru.Length];    //Массив подсчета вхождений каждой буквы 
            int[] times_en = new int[en.Length];
            Array.Clear(times_ru, 0, ru.Length);
            Array.Clear(times_en, 0, en.Length);

            string analyzedText = fieldOriginal.Text.ToLower();

            //Подсчитаем количество русских и английских букв, количество их вхождений
            int amount_ru = 0, amount_en = 0;
            for (int i = 0; i < analyzedText.Length; i++)
            {
                if (ru.IndexOf(analyzedText[i]) >= 0)
                {
                    amount_ru++;
                    times_ru[ru.IndexOf(analyzedText[i])]++;
                }
                if (en.IndexOf(analyzedText[i]) >= 0)
                {
                    amount_en++;
                    times_en[en.IndexOf(analyzedText[i])]++;
                }
            }

            dataGridView.ColumnCount = 4;
            dataGridView.RowCount = 1;
            int real_index = 0;
            for (int i = 0; i < times_ru.Length; i++)
            {
                if (times_ru[i] > 0)
                {
                    dataGridView.RowCount++;
                    dataGridView.Rows[real_index].Cells[0].Value = ru[i];
                    dataGridView.Rows[real_index].Cells[1].Value = times_ru[i];
                    dataGridView.Rows[real_index].Cells[2].Value = Math.Round((double)times_ru[i] / amount_ru, 6); //округлим до 6 знаков после ,
                    dataGridView.Rows[real_index].Cells[3].Value = freqs_ru[i];
                    real_index++;
                }
            }
            for (int i = 0; i < times_en.Length; i++)
            {
                if (times_en[i] > 0)
                {

                    dataGridView.RowCount++;
                    dataGridView.Rows[real_index].Cells[0].Value = en[i];
                    dataGridView.Rows[real_index].Cells[1].Value = times_en[i];
                    dataGridView.Rows[real_index].Cells[2].Value = Math.Round((double)times_en[i] / amount_en, 6); //округлим до 6 знаков после ,
                    dataGridView.Rows[real_index].Cells[3].Value = freqs_en[i];
                    real_index++;
                }
            }

            //Заполнение графиков

            chart.Series[0].Points.Clear(); //Очистка
            chart.Series[1].Points.Clear();
            if (amount_ru > 0)
            {
                for (int i = 0; i < times_ru.Length; i++)
                {
                    chart.Series[0].Points.Add((double)times_ru[i]/amount_ru);
                    chart.Series[1].Points.Add(freqs_ru[i]);
                    chart.Series[0].Points[i].Label = ru[i].ToString();
                }
            }
            if (amount_en > 0)
            {
                for (int i = 0; i < times_en.Length; i++)
                {
                    chart.Series[0].Points.Add((double)times_en[i]/amount_en);
                    chart.Series[0].Points[i].Label = en[i].ToString();
                    chart.Series[1].Points.Add(freqs_en[i]);

                }
            }

        }


        private void buttonFindKeys_Click(object sender, EventArgs e)
        {
            //ЗДЕСЬ МЫ ИЩЕМ САМ КЛЮЧ ТОЛЬКО ПО ЕГО ИЗВЕСТНОЙ ДЛИНЕ
            int keyLen = (int)keyLengthUpDown.Value;
            string Source = (fieldCiphertext.Text).ToLower();
            for (int i = 0; i < Source.Length; i++) //Удаляем разделители
            {
                if (alphabet.IndexOf(Source[i]) < 0)
                {
                    string tmpDel = "";
                    tmpDel += Source[i];
                    Source = Source.Replace(tmpDel, "");
                }
            }
            if (keyLen < 1 || Source.Length < keyLengthUpDown.Value)
                goto metka_exit;

            //Разобьем текст на k блоков по keyLen 
            string[] everyXsymb = new string[keyLen];
            for (int k = 0; k < keyLen; k++)
            {
                string tmp = "";
                int j = k;
                while (j < Source.Length)
                {
                    tmp += Source[j];
                    j += keyLen;
                }
                everyXsymb[k] = tmp;
            }

            string result = "";
            //Найдем ключ для каждого цезаря отдельно
            for (int k = 0; k < keyLen; k++)
            {
                //Подсчитаем количество вхождений каждой буквы
                int[] times = new int[alphabet.Length];
                Array.Clear(times, 0, times.Length);
                for (int i = 0; i < everyXsymb[k].Length; i++)
                {
                    if (alphabet.IndexOf(everyXsymb[k][i]) >= 0)
                    {
                        times[alphabet.IndexOf(everyXsymb[k][i])]++;
                    }
                }

                //Найдем самый часто встречающийся элемент, запишем его индекс
                int index = -1;
                for (int i = 0; i < times.Length; i++)
                {
                    if (times[i] == times.Max()) index = i;
                }

                //Запишем номер самой встречающейся статистичеки буквы в переменную standard
                int standard = alphabet.IndexOf('e'); 
                if (alphabet.IndexOf('о') >= 0) standard = alphabet.IndexOf('о'); //русская О
                if (alphabet.IndexOf('_') >= 0) standard = alphabet.IndexOf('_'); //пробел подчеркиванием
                if (alphabet.IndexOf(' ') >= 0) standard = alphabet.IndexOf(' '); //пробел

                result += alphabet[((index - standard) + alphabet.Length) % alphabet.Length];
            }
            foundedKey.Text = result;
        metka_exit:;
        }

        private void useFoundedKey_Click(object sender, EventArgs e)
        {
            fieldKey.Text = foundedKey.Text;
        }


        private void alfExtended_TextChanged(object sender, EventArgs e)
        {
            if (checkBox_alfEx.Checked)
                alphabet = alfExtended.Text + alfTextBox.Text;
            else
                alphabet = alfTextBox.Text + alfExtended.Text;

            ALPHABET = alphabet.ToUpper();
            string tmp = fieldKey.Text;
            fieldKey.Text = null;
            fieldKey.Text = tmp;
        }

        private void checkBox_alfEx_CheckedChanged(object sender, EventArgs e)
        {
            string tmp = alfExtended.Text;
            alfExtended.Text = null;
            alfExtended.Text = tmp;
        }

        public static int GCD(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }
            return GCD(b % a, a);
        }
        private void f15_ButtonReadCiphertext_Click(object sender, EventArgs e)
        {
            fieldOriginal.Text = null;
            foundedKey.Text = null;
            fieldKey.Text = null;
            keyLengthUpDown.Value = 0;

            string textFromFile = "";
            Stream myStream = null;
            OpenFileDialog myDialog = new OpenFileDialog();

            myDialog.DefaultExt = "txt";
            myDialog.Filter = "TXT|*.txt";
            myDialog.FilterIndex = 2;
            myDialog.RestoreDirectory = true;

            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = myDialog.OpenFile()) != null)
                    {
                        textFromFile = new StreamReader(myStream, Encoding.GetEncoding(1251)).ReadToEnd();
                        myStream.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: Невозможно прочитать файл. " + ex.Message);
                }
            }

            //Подсчитаем количество русских и английских букв, количество их вхождений
            int amount_ru = 0, amount_en = 0;
            for (int i = 0; i < textFromFile.Length; i++)
            {
                if (ru.IndexOf(textFromFile[i]) >= 0)
                {
                    amount_ru++;
                }
                if (en.IndexOf(textFromFile[i]) >= 0)
                {
                    amount_en++;
                }
            }
            if (amount_ru > 0) { alphabet = ru; ALPHABET = RU; alph_check_ru = true; alph_check_en = false; }
            if (amount_en > 0) { alphabet = en; ALPHABET = EN; alph_check_ru = false; alph_check_en = true; }
            alfTextBox.Text = alphabet;
            alfExtended.Text = "";
            fieldCiphertext.Text = textFromFile;
            if (amount_en * amount_ru > 0)
            {
                fieldCiphertext.Text = null;
                MessageBox.Show("Пожалуйста, используйте только один язык.", "Ошибка");
            }
        }



        private void ButtonSaveOriginal_Click(object sender, EventArgs e)
        {
            StreamWriter myStream = null;
            SaveFileDialog myDialog = new SaveFileDialog();

            myDialog.DefaultExt = "txt";
            myDialog.FileName = "2.txt";
            myDialog.Filter = "TXT|*.txt";
            myDialog.FilterIndex = 2;
            myDialog.RestoreDirectory = true;

            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = new StreamWriter(myDialog.OpenFile(), Encoding.GetEncoding(1251))) != null)
                {
                    myStream.WriteLine(Convert.ToString(fieldOriginal.Text));
                    myStream.Close();
                }
            }
        }
    }
}
