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
    public partial class FrequenAnalyzDialog : Form
    {
        public FrequenAnalyzDialog()
        {
            InitializeComponent();
            lettersGridView.ColumnCount = 4;
            lettersGridView.RowCount = 1;
            replaceGridView.ColumnCount= 2;
            //replaceGridView.RowCount = 1;
            replaceGridView.Columns[0].HeaderText = "Заменить на\n символ";
            replaceGridView.Columns[1].HeaderText = "Исходный \n символ";
            replaceGridView.RowHeadersVisible = false;
            replaceGridView.Columns[1].ReadOnly = true;
            replaceGridView.AllowUserToAddRows = false;


        }
        public string ru = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        public string en = "abcdefghijklmnopqrstuvwxyz";
        public double[] freqsRu = { 0.062,0.014,0.038,0.013,0.025,0.072,0.0001,0.007,0.016,0.062,0.01,0.028,0.035,0.026,0.053,
            0.09,0.023,0.04,0.045,0.053,0.021,0.002,0.009,0.004,0.012,0.006,0.003,0.0004,0.016,0.014,0.003,0.006,0.018};
        public double[] freqsEn = {0.081,0.016,0.032,0.036,0.123,0.023,0.016,0.051,0.071,0.001,0.005,0.04,0.022,0.072,
            0.079,0.023,0.002,0.06,0.066,0.096,0.031,0.009,0.02,0.002,0.019,0.001};

        public string Alphabet = null; //алфавит текста под анализ
        public int AmountSymbol; //количество символов в исходном тексте

        private void ReadText_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            string FileText = null;
            Stream myStream = null;
            OpenFileDialog myDialog = new OpenFileDialog();

            //myDialog.InitialDirectory = "C:\\Users\\Александр\\Documents\\Мои документы\\Visual Studio 2015\\Projects\\Cryptanalysis";
            //myDialog.DefaultExt = "txt";
            //myDialog.FileName = "1.txt";
            //myDialog.Filter = "TXT|*.txt";
            //myDialog.FilterIndex = 2;
            //myDialog.RestoreDirectory = true;

            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = myDialog.OpenFile()) != null)
                    {
                        FileText = new StreamReader(myStream, Encoding.GetEncoding(1251)).ReadToEnd();
                        myStream.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

            FileText = FileText.ToLower();
            //Подсчитаем количество русских и английских букв, количество их вхождений
            int AmountRu = 0, AmountEn = 0;
            for (int i = 0; i < FileText.Length; i++)
            {
                if (ru.IndexOf(FileText[i]) >= 0)
                {
                    AmountRu++;
                }
                if (en.IndexOf(FileText[i]) >= 0)
                {
                    AmountEn++;
                }
            }

            if (AmountRu > 0)
            {
                Alphabet = ru;
                AmountSymbol = AmountRu;
            }
            if (AmountEn > 0)
            {
                Alphabet = en;
                AmountSymbol = AmountEn;
            }

            textBox1.Text = FileText;

            if (AmountEn * AmountRu > 0)
            {
                textBox1.Clear();
                MessageBox.Show("Перемешивание разных языков запрещено", "Ошибка");
            }
        }

        private void SaveText_Click(object sender, EventArgs e)
        {
            StreamWriter myStream = null;
            SaveFileDialog myDialog = new SaveFileDialog();

            myDialog.InitialDirectory = "C:\\Users\\Александр\\Documents\\Мои документы\\Visual Studio 2015\\Projects\\Cryptanalysis";
            myDialog.DefaultExt = "txt";
            myDialog.FileName = "2.txt";
            myDialog.Filter = "TXT|*.txt";
            myDialog.FilterIndex = 2;
            myDialog.RestoreDirectory = true;

            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = new StreamWriter(myDialog.OpenFile(), Encoding.GetEncoding(1251))) != null)
                {
                    myStream.WriteLine(Convert.ToString(textBox2.Text));
                    myStream.Close();
                }
            }
        }

       
        private void Table_Chart()
        {
            int[] times_ru = new int[ru.Length];    //Массив подсчета вхождений каждой буквы 
            int[] times_en = new int[en.Length];

            string analyzedText = textBox2.Text.ToLower();

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

            lettersGridView.ColumnCount = 4;
            lettersGridView.RowCount = 1;
            int real_index = 0;
            for (int i = 0; i < times_ru.Length; i++)
            {
                if (times_ru[i] > 0)
                {
                    lettersGridView.RowCount++;
                    lettersGridView.Rows[real_index].Cells[0].Value = ru[i];
                    lettersGridView.Rows[real_index].Cells[1].Value = times_ru[i];
                    lettersGridView.Rows[real_index].Cells[2].Value = Math.Round((double)times_ru[i] / amount_ru, 6); //округлим до 6 знаков после ,
                    lettersGridView.Rows[real_index].Cells[3].Value = freqsRu[i];
                    real_index++;
                }
            }
            for (int i = 0; i < times_en.Length; i++)
            {
                if (times_en[i] > 0)
                {
                    lettersGridView.RowCount++;
                    lettersGridView.Rows[real_index].Cells[0].Value = en[i];
                    lettersGridView.Rows[real_index].Cells[1].Value = times_en[i];
                    lettersGridView.Rows[real_index].Cells[2].Value = Math.Round((double)times_en[i] / amount_en, 6); //округлим до 6 знаков после ,
                    lettersGridView.Rows[real_index].Cells[3].Value = freqsEn[i];
                    real_index++;
                }
            }

            //Заполнение гистограммы
            letters_chart.Series[0].Points.Clear(); //Очистка старых точек
            if (amount_ru > 0)
            {
                for (int i = 0; i < times_ru.Length; i++)
                {
                    letters_chart.Series[0].Points.Add(times_ru[i]);
                }
            }
            if (amount_en > 0)
            {
                for (int i = 0; i < times_en.Length; i++)
                {
                    letters_chart.Series[0].Points.Add(times_en[i]);
                }
            }
        }


       
            
   



        private void analyze_button_Click(object sender, EventArgs e)
        {
            string Text = textBox1.Text.ToLower();
            //Подсчитаем количество вхождений каждой буквы
            int[] times = new int[Alphabet.Length];
            for (int i = 0; i < Text.Length; i++)
            {
                if (Alphabet.IndexOf(Text[i]) >= 0)
                {
                    times[Alphabet.IndexOf(Text[i])]++;
                }
            }

            Dictionary<char, int> Calculated = new Dictionary<char, int>();
            Dictionary<char, int> Real = new Dictionary<char, int>();

            if (Alphabet == ru)
            {
                for (int i = 0; i < ru.Length; i++)
                {
                    Real.Add(ru[i], times[i]);
                    Calculated.Add(ru[i], Convert.ToInt32(freqsRu[i] * AmountSymbol));
                }
            }
            else
            {
                for (int i = 0; i < en.Length; i++)
                {
                    Real.Add(en[i], times[i]);
                    Calculated.Add(en[i], Convert.ToInt32(freqsEn[i] * AmountSymbol));
                }
            }

            //Real.OrderByDescending(key => key.Value);
            //Calculated.OrderByDescending(key => key.Value);
            var List_Real = Real.ToList();
            List_Real.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
            List_Real.Reverse();

            var List_Calculated = Calculated.ToList();
            List_Calculated.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
            List_Calculated.Reverse();


            //заполняем таблицу редактирования символов
            int real_index = 0;
            foreach (var item in List_Calculated)
            {
                replaceGridView.RowCount++;
                replaceGridView.Rows[real_index].Cells[0].Value = Convert.ToString(item.Key);
                real_index++;
            }
            real_index = 0;
            foreach (var item in List_Real)
            {
                replaceGridView.Rows[real_index].Cells[1].Value = Convert.ToString(item.Key);
                real_index++;
            }

            //string temp = null;
            //foreach (var item in List_Real)
            //{
            //    temp += Convert.ToString(item.Key) + "-" + Convert.ToString(item.Value) + " ";
            //}
            //richTextBoxReal.Text = temp;
            //temp = null;
            //foreach (var item in List_Calculated)
            //{
            //    temp += Convert.ToString(item.Key) + "-" + Convert.ToString(item.Value) + " ";
            //}
            //richTextBoxCalculated.Text = temp;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Clear();

            string Text = textBox1.Text.ToLower();
            //Подсчитаем количество русских и английских букв, количество их вхождений
            int AmountRu = 0, AmountEn = 0;
            for (int i = 0; i < Text.Length; i++)
            {
                if (ru.IndexOf(Text[i]) >= 0)
                {
                    AmountRu++;
                }
                if (en.IndexOf(Text[i]) >= 0)
                {
                    AmountEn++;
                }
            }

            if (AmountRu > 0)
            {
                Alphabet = ru;
                AmountSymbol = AmountRu;
            }
            if (AmountEn > 0)
            {
                Alphabet = en;
                AmountSymbol = AmountEn;
            }
            if (AmountEn * AmountRu > 0)
            {
                textBox1.Clear();
                MessageBox.Show("Пожалуйста, используйте только один язык.", "Ошибка");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Table_Chart();
        }

        private void replace_button_Click(object sender, EventArgs e)
        {
            //string New_Alphabet = null;
            //for (int i = 0; i < Alphabet.Length; i++)
            //{
            //    if (replaceGridView.Rows[i].Cells[1].Value.ToString() != "")
            //    {
            //        New_Alphabet += replaceGridView.Rows[i].Cells[1].Value.ToString();
            //    }
            //    else
            //    {
            //        New_Alphabet += " ";
            //    }
            //}
            string first = string.Empty;
            foreach (DataGridViewRow row in replaceGridView.Rows)
            {
                if(row.Cells[0].Value !=null)
                {
                first += row.Cells[0].Value.ToString();

                }
            }

            string second = string.Empty;
            foreach (DataGridViewRow row in replaceGridView.Rows)
            {
                if (row.Cells[1].Value != null)
                    second += row.Cells[1].Value.ToString();
                else
                    second += " ";
            }


            string Text = textBox1.Text.ToLower();
            char[] New_Text = Text.ToArray();

            bool[] Status = new bool[Text.Length];

            for (int i = 0; i < second.Length; i++)
            {
                for (int j = 0; j < Text.Length; j++)
                {
                    if ((New_Text[j] == second[i]) && (Status[j] == false))
                    {
                        New_Text[j] = first[i];
                        Status[j] = true;
                    }
                }
            }

            Text = null;
            Text = new string(New_Text);

            textBox2.Text = Text;
        }
    }
}

