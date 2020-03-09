using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptograthy
{
    partial class Form1
    {
        public void Gronsfield(Kind kind)
        {
            char[] first_data = textBox1.Text.ToCharArray();
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

            
                int mod = flagInit.Length;
                for (int i = 0; i < first_data.Length; i++)
                {
                    flagList.Add(flagInit[i%mod]);
                }
           
            //шифровка
            bool UP = false;
            char smb = ' ';

            if (kind == Kind.ENCRYPT)
            {
                for (int k = 0; k < first_data.Length; k++)
                {
                    smb = first_data[k];
                    UP = false;
                    if (Char.IsUpper(first_data[k]))
                    {
                        first_data[k] = Char.ToLower(first_data[k]);
                        UP = true;
                    }

                    for (int i = 0; i < rus.Length; i++)
                    {
                        if (first_data[k] == rus[i])
                        {
                            smb = rus[(i + (flagList[k] - '0')) % 33];
                            goto Find;

                        }


                    }
                    for (int i = 0; i < eng.Length; i++)
                    {
                        if (first_data[k] == eng[i])
                        {
                            smb = eng[(i + (flagList[k] - '0')) % 26];
                            goto Find;

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
            if (kind == Kind.DECRYPT)
            {
                for (int k = 0; k < first_data.Length; k++)
                {
                    smb = first_data[k];
                    UP = false;
                    if (Char.IsUpper(first_data[k]))
                    {
                        first_data[k] = Char.ToLower(first_data[k]);
                        UP = true;
                    }

                    for (int i = 0; i < rus.Length; i++)
                    {
                        if (first_data[k] == rus[i])
                        {
                            smb = rus[(i - (flagList[k] - '0')) % 33];
                            goto Find;

                        }


                    }
                    for (int i = 0; i < eng.Length; i++)
                    {
                        if (first_data[k] == eng[i])
                        {
                            smb = eng[(i-(flagList[k] - '0')) % 26];
                            goto Find;

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
        }
        
          
    }
}