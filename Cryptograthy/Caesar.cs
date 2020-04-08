using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cryptograthy
{
    partial class Kazakevich
    {

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
    }
}
