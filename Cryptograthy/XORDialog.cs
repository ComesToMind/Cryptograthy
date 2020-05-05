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
    public partial class XORDialog : Form
    {
        public XORDialog()
        {
            InitializeComponent();
            textBoxA.KeyPress += tb_KeyPress;
            textBoxB.KeyPress += tb_KeyPress;
            textBoxXo.KeyPress += tb_KeyPress;
            textBoxA.Text = "1";
            textBoxB.Text = "1";
            textBoxXo.Text = "250";
            labelM.Text = "m = " + m.ToString();
        }

        uint m = 3571;

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


        private uint[] Create_Key(uint A, uint B, uint X0, uint Length)
        {
            if ((A > m) || (B > m) || (X0 > m))
            {
                MessageBox.Show("Числа не должны превышать модуль m!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
            //if (GCD(m, B) != 1)
            //{
            //    MessageBox.Show("Число B должно быть взаимнопростым с модулем!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return null;
            //}
            //if (A % 4 != 1)
            //{
            //    MessageBox.Show("Число A должно быть нечетным!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return null;
            //}

            uint[] Key = new uint[Length];

            for (int i = 0; i < Length; i++)
            {
                X0 = (A * X0 + B);
                X0 %= m;
                Key[i] = X0;
            }
            
            //
          
            return Key;
        }

        //private static int GCD(int a, int b)//НОД Алгоритм Евклида)
        //{
        //    while (b != 0)
        //    {
        //        b = a % (a = b);
        //    }
        //    return a;
        //}

        private string Crypt(string Text, uint[] Key)
        {
            string New_Text = null;
            
            for (int i = 0; i < Key.Length; i++)
            {
                
                New_Text += Convert.ToChar(Convert.ToUInt16(Text[i]) ^ Key[i]);
            }

            return New_Text;
        }

        private void encrypt_button_Click(object sender, EventArgs e)
        {
            string first_data;
            first_data = textBox1.Text;

            //генирурем ключ сразу на всю длину текста
            if (!TextboxCheck())
            {
                return;
            }
            uint[] flagInit;
            flagInit = Create_Key(Convert.ToUInt32(textBoxA.Text), Convert.ToUInt32(textBoxB.Text), Convert.ToUInt32(textBoxXo.Text), Convert.ToUInt32(first_data.Length));
            if (flagInit == null || first_data.Length == 0)
                return;

            first_data = Crypt(first_data, flagInit);

            textBox2.Clear();
            foreach (var v in first_data)
            {
                if (v == '\0')
                {
                    textBox2.Text += @"\0";
                }
                else
                    textBox2.Text += v;
            }
            textBox2.Update();
        }

        private void decrypt_button_Click(object sender, EventArgs e)
        {
            string first_data;
            first_data = textBox2.Text;

            //генирурем ключ сразу на всю длину текста
            if (!TextboxCheck())
            {
                return;
            }
            uint [] flagInit = Create_Key(Convert.ToUInt32(textBoxA.Text), Convert.ToUInt32(textBoxB.Text), Convert.ToUInt32(textBoxXo.Text), Convert.ToUInt32(first_data.Length));
            if (flagInit == null || first_data.Length == 0)
                return;

            first_data = Crypt(first_data, flagInit);
            textBox2.Clear();
            foreach (var v in first_data)
            {
                if (v == '\0')
                {
                    textBox2.Text += @"\0";
                }
                else
                    textBox2.Text += v;
            }
            textBox2.Update();

        }

        private void round_calc_button_Click(object sender, EventArgs e)
        {
            if (!TextboxCheck())
            {
                return;
            }
            uint B = Convert.ToUInt32(textBoxB.Text);
            uint A = Convert.ToUInt32(textBoxA.Text);
            uint X0 = Convert.ToUInt32(textBoxXo.Text);
            uint control;
            X0 = (A * X0 + B);
            X0 %= m;
            control = X0;
            int counter = 0;
            do {
                X0 = (A * X0 + B);
                X0 %= m;
                counter++;
            } while (X0 != control);
            labelCacl.Text = "Длина раунда = " + counter.ToString();
            labelCacl.Update();
        }

        private bool TextboxCheck()
        {
            if ((textBoxA.Text != null && textBoxA.Text != "") && (textBoxB.Text != null && textBoxB.Text != "") && (textBoxXo.Text != null && textBoxXo.Text != ""))
                return true;
            MessageBox.Show("Числа не должны быть пустыми!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
