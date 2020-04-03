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
        private class Found
        {
            public int row = null;
            public int col = null;
            public string alpabet = null;
            public int address = null;
        }
        //private class Bigramm
        //{
        //    public char left;
        //    public char right;
        ////    public int[] address;
        //}
	    public Playfair()
	    {
            char[] first_data = textBox1.Text.ToCharArray();
            char[] flagInit = null;
            char[] r = rus.ToCharArray();
            char[] e = eng.ToCharArray();
            //функция добавления флага в алфавит
            FlagAlphabet(ref r, ref e);
            Found fRus = null, sRus = null; //парные русские символы
            Found fEng = null, sEng = null; // парные английские символы
            for (int i = 0, row = 0, col =0; i < first_data.Length(); i++)
            {
                //берем символ, возврашаем его строку,столбец, алфавит
                Found f = Find(first_data[i]);
                if (f.alpabet != null)
                {
                    if (f.alpabet == "rus")
                    {
                        if (fRus == null)
                        {
                            f.address = i;
                            fRus = f;
                        }
                        else
                        {
                            if (sRus == null)
                            {
                                f.address = i;
                                sRus = f;
                            }
                            else
                            {
                                PlayfairEncrtypt(fRus,sRus);
                                fRus = null;
                                sRus = null;
                            }

                        }

                    }
                    else
                    {
                        if (fEng == null)
                        {
                            f.address = i;
                            fEng = f;
                        }
                        else
                        {
                            if (sEng == null)
                            {
                                f.address = i;
                                sEng = f;
                            }
                            else
                            {
                                PlayfairEncrtypt(fEng,sEng);
                                fEng = null;
                                sEng = null;
                            }

                        }
                    }
                }
            }
            //шифровка 

        }

        private PlayfairEncrtypt(ref Found left, ref Found right)
        {
            if (left.row == right.row)
            {
            }
            if (left.col == right.col)
            {

            }

            
        }

        Found Find(char smb)
        {
         if (Char.IsUpper(smb))
            {
                    smb = Char.ToLower(smb);
            }

            for (int i = 0; i < r.Length; i++)
            {
                if (smb == r[i])
                {
                    Found infSmb;
                    infSmb.row = i / 6;
                    infSmb.col = i % 6;
                    infSmb.alpabet = "rus";
                    return infSmb;
              
                }


            }
            for (int i = 0; i < e.Length; i++)
            {
                if (smb == e[i])
                {
                    Found infSmb;
                    infSmb.row = i / 6;
                    infSmb.col = i % 5;
                    infSmb.alpabet = "eng";
                    return infSmb;

                }

            }
            Found f();
            return f;

        }

    }
}

