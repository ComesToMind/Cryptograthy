using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void Caesar()
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
                    }
                    break;
                }

            }

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
                            first_data[i] = RUS[(j+key)%33];
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
                                first_data[i] = ENG[(j + key) % 26];
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
                            first_data[i] = eng[(j + key) % 26 ];
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
                                first_data[i] = rus[(j + key) % 33 ];
                                break;
                            }

                        }
                    }


                }
            }
            textBox2.Text = new string(first_data);
        }



        private void atbash_button_Click(object sender, EventArgs e)
        {
            ClearPanel();
            PressedButt = sender as Button;
            
        }


        private void cypher_Click(object sender, EventArgs e)
        {
         
            
            if (PressedButt == atbash_button)
            {
                Atbash();
            }
            else if (PressedButt == skytala_button)
            { }
            else if (PressedButt == caesar_button)
            {
                Caesar();
            }
            
        }

        private void decypher_Click(object sender, EventArgs e)
        {

            if (PressedButt == atbash_button)
            {
                Atbash();
            }
            else if (PressedButt == skytala_button)
            { }
            else if (PressedButt == caesar_button)
            {
                Caesar();
            }
        }

        private void skytala_button_Click(object sender, EventArgs e)
        {
            PressedButt = sender as Button;
            ClearPanel();
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
