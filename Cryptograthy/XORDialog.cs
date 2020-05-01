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
        }
        private void GenerateKey()
        {
            string Key = null;

            if (B % 2 == 0)
            {
                MessageBox.Show("Число B должно быть нечетным!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            if (GCD(0xffff, B) != 1)
            {
                MessageBox.Show("Число B должно быть взаимнопростым с модулем!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            if (A % 4 != 1)
            {
                MessageBox.Show("Число A должно быть нечетным!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            for (int i = 0; i < len; i++)
            {
                Key += (char)Y0;
                Y0 = (A * Y0 + B);
                Y0 %= 0xffff;
            }

            return Key;

        }
    }
}
