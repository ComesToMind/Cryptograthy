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
            if (row_amount == 0)
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
    }
}
