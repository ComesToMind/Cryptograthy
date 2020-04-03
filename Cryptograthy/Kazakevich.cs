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

//using static Cryptograthy.Innitial;

namespace Cryptograthy
{
    public partial class Kazakevich : Form
    {
        public Kazakevich()
        {
            InitializeComponent();
        }
        //обернуть в класс
        string rus = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        string RUS = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        string eng = "abcdefghijklmnopqrstuvwxyz";
        string ENG = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        
        
        List<Control> controls = new List<Control>();
        Button PressedButt;
        public enum Kind { ENCRYPT, DECRYPT };
        TextBox tb;
        ///=====
        private void ClearPanel()
        {
            if (controls.Any())
            {
                foreach (Control ctrl in controls)// подписываем каждый элемент списка на клик
                    panel_each.Controls.Remove(ctrl);
                controls.Clear();
            }

        }

        private void InitialazePanel()
        {
            foreach (Control ctrl in controls)// подписываем каждый элемент списка на клик
                panel_each.Controls.Add(ctrl);
        }
        //============

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textBox2.Text = e.KeyChar.ToString();

            if (!Char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }




        }



        
        private void Caesar(Kind k)
        {
            char[] first_data = textBox1.Text.ToCharArray();
            char[] second_data = textBox1.Text.ToCharArray();
            int key = 0;
            foreach (Control ctrl in controls)// подписываем каждый элемент списка на 
            {
                if (ctrl.GetType() == typeof(ComboBox))
                {
                    ComboBox cmb = (ComboBox)ctrl;
                    if (cmb.SelectedItem != null)
                    {
                        key = int.Parse(cmb.SelectedItem.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Неправильное значение ключа", "Некорректные данные");
                        return;
                    }
                    break;

                }

            }
            //одна функции на шифровку и дешивфроку 
            //отличие лишь в знаке ключа
            int keyR, keyE;
            if (k == Kind.DECRYPT)
            {
                keyR = 33 - key;
                keyE = 26 - key;
            }
            else
                keyR = keyE = key;

            bool keyLow, keyUp;
            for (int i = 0; i < first_data.Length; i++)
            {
                keyLow = keyUp = true;
                if (char.IsUpper(first_data[i]))
                {
                    for (int j = 0; (j < 33); j++)
                    {
                        if (first_data[i] == RUS[j])
                        {
                            first_data[i] = RUS[(j + keyR) % 33];
                            keyUp = false;
                            break;
                        }

                    }
                    if (keyUp)
                    {
                        for (int j = 0; (j < 26); j++)
                        {
                            if (first_data[i] == ENG[j])
                            {
                                first_data[i] = ENG[(j + keyE) % 26];
                                keyLow = false;
                                break;
                            }

                        }
                    }

                }

                if (keyUp)
                {
                    for (int j = 0; j < 26; j++)
                    {
                        if (first_data[i] == eng[j])
                        {
                            first_data[i] = eng[(j + keyE) % 26];
                            keyLow = false;
                            break;
                        }

                    }
                    if (keyLow)
                    {
                        for (int j = 0; j < 33; j++)
                        {
                            if (first_data[i] == rus[j])
                            {
                                first_data[i] = rus[(j + keyR) % 33];
                                break;
                            }

                        }
                    }


                }
            }
            textBox2.Text = new string(first_data);
            StreamWriter sw = new StreamWriter("Output.txt", false, System.Text.Encoding.Default);
            sw.Write(first_data);
            sw.Close();
        }


        private void Skytala(Kind k)
        {
            char[] first_data = textBox1.Text.ToCharArray();
            char[] second_data = textBox1.Text.ToCharArray();
            int row_amount = 0;
            foreach (Control ctrl in controls)// подписываем каждый элемент списка на 
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    TextBox cmb = (TextBox)ctrl;
                    if (cmb.Text != null && !cmb.Text.Equals(""))
                    {

                        row_amount = int.Parse(cmb.Text.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Неправильное значение ключа", "Некорректные данные");
                        return;
                    }
                    break;

                }

            }
            if (row_amount==0)
            {
                MessageBox.Show("Неправильное значение ключа", "Некорректные данные");
                return;
            }

            int column_amount = (int)((first_data.Length - 1) / row_amount) + 1;
            if (k == Kind.ENCRYPT)
            {
                int index = 0;

                for (int i = 0; i < column_amount; i++)
                {
                    for (int j = 0; j < row_amount; j++)
                    {
                        if (j * column_amount + i < first_data.Length)
                        {
                            second_data[index] = first_data[j * column_amount + i];
                            index++;
                        }

                    }
                }
            }
            if (k == Kind.DECRYPT)
            {
                int index = 0;
                
                            
                for (int i = 0; i < column_amount; i++)
                {
                    for (int j = 0; j < row_amount; j++)
                    {
                        if ((i + column_amount * j) < first_data.Length)
                        {
                            second_data[i + column_amount * j] = first_data[index];
                            index++;
                        }
                    }
                }



            }

            textBox2.Text = new string(second_data);

        }


        public void Polybius()
        {
            char[] first_data = textBox1.Text.ToCharArray();
            char[] r = rus.ToCharArray();
            char[] e = eng.ToCharArray();
            //функция добавления флага в алфавит
            FlagAlphabet(ref r, ref e);
            bool UP = false;
            char smb = ' ';
            for (int k = 0; k < first_data.Length; k++)
            {
                smb = first_data[k];
                UP = false;
                if (Char.IsUpper(first_data[k]))
                {
                    first_data[k] = Char.ToLower(first_data[k]);
                    UP = true;
                }

                for (int i = 0; i < r.Length; i++)
                {
                    if (first_data[k] == r[i])
                    {
                        if (i < 27)
                        {
                            smb = r[i + 6];
                            goto Find;
                        }
                        else
                        {
                            smb = r[0 + i % 6];
                            goto Find;
                        }
                    }


                }
                for (int i = 0; i < eng.Length; i++)
                {
                    if (first_data[k] == e[i])
                    {
                        if (i < 20)
                        {
                            smb = e[i + 6];
                            goto Find;
                        }
                        else
                        {
                            smb = e[0 + i % 6];
                            goto Find;
                        }
                    }


                }

            Find:
                if (UP)
                {
                    first_data[k] = Char.ToUpper(smb);
                }
                else
                {
                    first_data[k] = smb;
                }


            }
            textBox2.Text = new string(first_data);


        }
        public void dePolybius()
        {
            char[] first_data = textBox1.Text.ToCharArray();
            char[] r = rus.ToCharArray();
            char[] e = eng.ToCharArray();
            //функция добавления флага в алфавит
            FlagAlphabet(ref r,ref e);
            bool UP = false;
            char smb = ' ';
            for (int k = 0; k < first_data.Length; k++)
            {
                smb = first_data[k];
                UP = false;
                if (Char.IsUpper(first_data[k]))
                {
                    first_data[k] = Char.ToLower(first_data[k]);
                    UP = true;
                }

                for (int i = 0; i < r.Length; i++)
                {
                    if (first_data[k] == r[i])
                    {
                        if (i >= 6)
                        {
                            smb = r[i - 6];
                            goto Find;
                        }
                        else
                        {
                            if (i >= 0 && i < 3)
                            {
                                //буквы АБВ
                                smb = r[30 + i];
                                goto Find;
                            }
                            else if (i >= 3 && i < 6)
                            {
                                smb = r[24 + i];
                                goto Find;
                            }
                        }
                    }


                }
                for (int i = 0; i < e.Length; i++)
                {
                    if (first_data[k] == e[i])
                    {
                        if (i >= 6)
                        {
                            smb = e[i - 6];
                            goto Find;
                        }
                        else
                        {
                            if (i >= 0 && i < 2)
                            {
                                smb = e[24 + i];
                                goto Find;
                            }
                            else if (i >= 2 && i < 6)
                            {
                                smb = e[18 + i];
                                goto Find;

                            }
                        }
                    }


                }

            Find:
                if (UP)
                {
                    first_data[k] = Char.ToUpper(smb);
                }
                else
                {
                    first_data[k] = smb;
                }


            }
            textBox2.Text = new string(first_data);
        }

        public void FlagAlphabet(ref char[] r,ref char[] e)
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
            List<char> flagList= new List<char>();
            

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
            char[] flag = flagList.ToArray();

            int r_counter = 0, e_counter = 0; //количество добавленных букв в начало алфавита
            for (int k = 0; k < flag.Length; k++)
            {

                if (Char.IsUpper(flag[k]))
                {
                    flag[k] = Char.ToLower(flag[k]);
                }

                for (int i = 0; i < rus.Length; i++)
                {
                    if (flag[k] == rus[i])
                    {
                        r[r_counter] = flag[k];
                        r_counter++;
                        break;

                    }
                }
                for (int i = 0; i < eng.Length; i++)
                {
                    if (flag[k] == eng[i])
                    {
                        e[e_counter] = flag[k];
                        e_counter++;
                        break;
                    }
                }
            }
            
            int counter = r_counter;
            bool fl;
            foreach (char var in rus)
            {
                fl = false;
                for(int i = 0; i<r_counter;i++)
                {
                    if (r[i] == var)//буква алфавита есть в ключе, то 
                    {
                        fl = true; //
                        break;
                    }
                        
                }
                if (!fl)
                {
                    r[counter] = var;
                    counter++;
                }

            }
            counter = e_counter;
            foreach (char var in eng)
            {
                fl = false;
                for (int i = 0; i < e_counter; i++)
                {
                    if (e[i] == var)
                    {
                        fl = true;
                        break;
                    }

                }
                if (!fl)
                {
                    e[counter] = var;
                    counter++;
                }

            }
            //panel_alpabet_rus.Controls.Clear();
            //Label[] lb = new Label[33];
            //for (int i = 0; i < lb.Length; i++)
            //{
            //    lb[i] = new System.Windows.Forms.Label();
            //    lb[i].Location = new System.Drawing.Point(3, 50 + i * 30);
            //    lb[i].Name = "lb" + i.ToString();
            //    lb[i].Size = new System.Drawing.Size(13, 13);
            //    lb[i].TabIndex = i;
            //    lb[i].Text = r[i].ToString();
            //    panel_alpabet_rus.Controls.Add(lb[i]);
            //}
            //InitialazePanel();
        }

    


        private void atbash_button_Click(object sender, EventArgs e)
        {
            ClearPanel();
            PressedButt = sender as Button;
            
        }


        private void cypher_Click(object sender, EventArgs e)
        {

            //ШИФРОВКА
            if (PressedButt == atbash_button)
            {
                Atbash();
            }
            else if (PressedButt == skytala_button)
            {
                Skytala(Kind.ENCRYPT);
            }
            else if (PressedButt == caesar_button)
            {
                Caesar(Kind.ENCRYPT);
            }
            else if (PressedButt == polybius_button)
            {
                Polybius();
            }
            else if (PressedButt == alberti_button)
            {
                Alberti_s_disk();
            }
            else if (PressedButt == gronsfeild_button)
            {
                Gronsfield(Kind.ENCRYPT);
            }
            else if (PressedButt == vigenere_button)
            {
                Vigenere(Kind.ENCRYPT);
            }
            else if (PressedButt == playfair_button)
            {
                Playfair();
            }
            //ШИФРОВКА
        }

        private void decypher_Click(object sender, EventArgs e)
        {
            //РАСШИФРОВКА
            if (PressedButt == atbash_button)
            {
                Atbash();
            }
            else if (PressedButt == skytala_button)
            {
                Skytala(Kind.DECRYPT);
            }
            else if (PressedButt == caesar_button)
            {
                Caesar(Kind.DECRYPT);
            }
            else if (PressedButt == polybius_button)
            {
                dePolybius();
            }
            else if (PressedButt == alberti_button)
            {
                deAlberti_s_disk();
            }
            else if (PressedButt == gronsfeild_button)
            {
                Gronsfield(Kind.DECRYPT);
            }
            else if (PressedButt == vigenere_button)
            {
                Vigenere(Kind.DECRYPT);
            }
            else if (PressedButt == playfair_button)
            {
                Playfair();
            }
            //РАСШИФРОВКА
        }

        private void skytala_button_Click(object sender, EventArgs e)
        {
            ClearPanel();
            PressedButt = sender as Button;
            Label lb = new Label();
            lb.Location = new Point(21, 16);
            lb.Text = "Количество строк";
            lb.Size = new Size(98, 13);

             tb = new TextBox();
            tb.Location = new Point(125, 13);
            tb.Size = new Size(58, 21);
            tb.KeyPress += tb_KeyPress;
            
            //ComboBox cb = new ComboBox();
            //cb.Location = new Point(125, 13);
            //cb.Size = new Size(58, 21);
            //cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; //запрет на ввод 
            //for (int i = 1; i < 34; i++)
            //{
            //    cb.Items.Add(i);
            //}
            controls.Add(lb);
            controls.Add(tb);
            InitialazePanel();
           


        }

        private void caesar_button_Click(object sender, EventArgs e)
        {
            PressedButt = sender as Button;
            ClearPanel();
            Label lb = new Label();
            lb.Location = new Point(56, 16);
            lb.Text = "Ключ";
            lb.Size = new Size(35, 13);
            ComboBox cb = new ComboBox();
            cb.Location = new Point(107, 13);
            cb.Size = new Size(50, 13);
            cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; //запрет на ввод 
            for (int i = 1; i < 67; i++)
            {
                cb.Items.Add(i);
            }
            controls.Add(lb);
            controls.Add(cb);
            InitialazePanel();


        }

        private void polybius_button_Click(object sender, EventArgs e)
        {
            ClearPanel();
            PressedButt = sender as Button;
            Label lb = new Label();
            lb.Location = new Point(5, 16);
            lb.Text = "Кодовое слово: ";
            lb.Size = new Size(98, 13);

            tb = new TextBox();
            tb.Location = new Point(105, 13);
            tb.Size = new Size(85, 21);
            //можно сделать проверку на символы 
            controls.Add(lb);
            controls.Add(tb);
            InitialazePanel();

        }

        private void alberti_button_Click(object sender, EventArgs e)
        {
            ClearPanel();
            PressedButt = sender as Button;
            Label lb = new Label();
            lb.Location = new Point(5, 16);
            lb.Text = "Введите ключ: ";
            lb.Size = new Size(98, 13);

            tb = new TextBox();
            tb.Location = new Point(105, 13);
            tb.Size = new Size(45, 21);
            tb.KeyPress += tb_KeyPress;
            //можно сделать проверку на символы 
            controls.Add(lb);
            controls.Add(tb);
            InitialazePanel();

        }

        private void exchange_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = textBox2.Text;
        }

        private void panel_each_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gronsfeild_button_Click(object sender, EventArgs e)
        {
            ClearPanel();
            PressedButt = sender as Button;
            Label lb = new Label();
            lb.Location = new Point(5, 16);
            lb.Text = "Введите ключ: ";
            lb.Size = new Size(98, 13);
                        

            tb = new TextBox();
            tb.Location = new Point(105, 13);
            tb.Size = new Size(45, 21);
            tb.KeyPress += tb_KeyPress;
            controls.Add(lb);
            controls.Add(tb);
            InitialazePanel();
        }

        private void vigenere_button_Click(object sender, EventArgs e)
        {
            ClearPanel();
            PressedButt = sender as Button;
            Label lb = new Label();
            lb.Location = new Point(5, 16);
            lb.Text = "Введите ключ: ";
            lb.Size = new Size(98, 13);


            tb = new TextBox();
            tb.Location = new Point(105, 13);
            tb.Size = new Size(60, 21);
            controls.Add(lb);
            controls.Add(tb);
            InitialazePanel();
        }

        private void playfair_button_Click(object sender, EventArgs e)
        {
            ClearPanel();
            PressedButt = sender as Button;
            Label lb = new Label();
            lb.Location = new Point(5, 16);
            lb.Text = "Введите ключ: ";
            lb.Size = new Size(98, 13);


            tb = new TextBox();
            tb.Location = new Point(105, 13);
            tb.Size = new Size(60, 21);
            controls.Add(lb);
            controls.Add(tb);
            InitialazePanel();
        }
    }
}
