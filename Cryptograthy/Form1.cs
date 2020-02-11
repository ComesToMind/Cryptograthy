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
    public partial class Form1 : Form
    {
        public Form1()
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
        enum Kind { ENCRYPT, DECRYPT};
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





        public void Atbash()
        {
            char[] first_data = textBox1.Text.ToCharArray();
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
                            first_data[i] = RUS[32 - j];
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
                                first_data[i] = ENG[25 - j];
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
                            first_data[i] = eng[25 - j];
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
                                first_data[i] = rus[32 - j];
                                break;
                            }

                        }
                    }


                }
            }

            textBox2.Text = new string(first_data);

        }

        private void Caesar(Kind k)
        {
            char[] first_data = textBox1.Text.ToCharArray();
            int key =0;
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
                            first_data[i] = RUS[(j+keyR)%33];
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
                            first_data[i] = eng[(j + keyE) % 26 ];
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
                                first_data[i] = rus[(j + keyR) % 33 ];
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
                if (ctrl.GetType() == typeof(ComboBox))
                {
                    ComboBox cmb = (ComboBox)ctrl;
                    if (cmb.SelectedItem != null)
                    {
                        row_amount = int.Parse(cmb.SelectedItem.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Неправильное значение ключа", "Некорректные данные");
                        return;
                    }
                    break;

                }

            }
            int column_amount = (int)((first_data.Length-1)/ row_amount) +1;
            if (k == Kind.DECRYPT)
            {
                int temp = column_amount;
                column_amount = row_amount;
                row_amount = temp;
            }
            int index;
            //Array.Clear(second_data,0,second_data.Length);
            for (int i = 0; i < second_data.Length; i++)
            {
                index = row_amount *(i % column_amount) + (i / column_amount);
                second_data[index] = first_data[i];
            }

            textBox2.Text = new string(second_data);

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
            ComboBox cb = new ComboBox();
            cb.Location = new Point(125, 13);
            cb.Size = new Size(58, 21);
            cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; //запрет на ввод 
            for (int i = 1; i < 34; i++)
            {
                cb.Items.Add(i);
            }
            controls.Add(lb);
            controls.Add(cb);
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
            for (int i = 1; i < 34; i++)
            {
                cb.Items.Add(i);
            }
            controls.Add(lb);
            controls.Add(cb);
            InitialazePanel();


        }
    }
}
