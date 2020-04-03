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
        public void Vigenere(Kind kind)
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
                        MessageBox.Show("Неправильное значение ключа", "Некорректные данные");
                        return;
                    }
                    break;

                }

            }
            //отделяем цифры, а также русские буквы от английских
            List<char> flagListInitRus = new List<char>();
            List<char> flagListInitEng = new List<char>();
            for (int i = 0; i < flagInit.Length; i++)
            {
                flagInit[i] = Char.ToLower(flagInit[i]);
                foreach (char var in rus)
                {
                    if (var == flagInit[i])
                    {
                        flagListInitRus.Add(flagInit[i]);
                        break;
                    }
                }
                foreach (char var in eng)
                {
                    if (var == flagInit[i])
                    {
                        flagListInitEng.Add(flagInit[i]);
                        break;
                    }
                }

            }
            List<char> flagListRus = new List<char>();
            List<char> flagListEng = new List<char>();
            int modR = flagListInitRus.Count;
            int modE = flagListInitEng.Count;
            if (flagListInitRus.Count != 0)
            {
                for (int i = 0; i < first_data.Length; i++)
                {
                    flagListRus.Add(flagListInitRus[i % modR]);

                }
            }
            if (flagListInitEng.Count != 0)
            {
                for (int i = 0; i < first_data.Length; i++)
                {
                    flagListEng.Add(flagListInitEng[i % modE]);
                }

            }

            //шифровка
            bool UP = false;
            char smb = ' ';
            //if (kind == Kind.ENCRYPT)
            //{
                for (int k = 0; k < first_data.Length; k++)
                {
                    smb = first_data[k];
                    UP = false;
                    if (Char.IsUpper(first_data[k]))
                    {
                        first_data[k] = Char.ToLower(first_data[k]);
                        smb = first_data[k];
                        UP = true;
                    }

                    if (flagListRus.Count != 0)
                    {
                        for (int i = 0; i < rus.Length; i++)
                        {
                            if (first_data[k] == rus[i])
                            {
                                //находим теперь индекс буквы ключа
                                for (int j = 0; j < rus.Length; j++)
                                {
                                    if (flagListRus[k] == rus[j])
                                    {
                                    if (kind == Kind.ENCRYPT)
                                        smb = rus[(i + j) % 33];
                                    else
                                        smb = rus[(i + 33-j) % 33];
                                        goto Find;
                                    }
                                }
                            }
                        }
                    }

                    if (flagListEng.Count != 0)
                    {
                        for (int i = 0; i < eng.Length; i++)
                        {
                            if (first_data[k] == eng[i])
                            {
                                //находим теперь индекс буквы ключа
                                for (int j = 0; j < eng.Length; j++)
                                {
                                    if (flagListEng[k] == eng[j])
                                    {
                                    if (kind == Kind.ENCRYPT)
                                        smb = eng[(i + j) % 26];
                                    else
                                        smb = eng[(i + 26 - j) % 26];
                                        goto Find;
                                    }
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
    }
}
